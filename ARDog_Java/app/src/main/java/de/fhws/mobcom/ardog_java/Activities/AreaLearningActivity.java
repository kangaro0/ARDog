package de.fhws.mobcom.ardog_java.Activities;

import android.app.Activity;
import android.content.Intent;
import android.hardware.display.DisplayManager;
import android.opengl.GLSurfaceView;
import android.os.Bundle;
import android.support.design.widget.FloatingActionButton;
import android.util.Log;
import android.view.Display;
import android.view.View;

import com.google.atap.tangoservice.Tango;
import com.google.atap.tangoservice.TangoCameraIntrinsics;
import com.google.atap.tangoservice.TangoConfig;
import com.google.atap.tangoservice.TangoCoordinateFramePair;
import com.google.atap.tangoservice.TangoErrorException;
import com.google.atap.tangoservice.TangoEvent;
import com.google.atap.tangoservice.TangoInvalidException;
import com.google.atap.tangoservice.TangoOutOfDateException;
import com.google.atap.tangoservice.TangoPointCloudData;
import com.google.atap.tangoservice.TangoPoseData;
import com.google.atap.tangoservice.TangoXyzIjData;
import com.google.tango.support.TangoSupport;

import org.rajawali3d.scene.ASceneFrameCallback;
import org.rajawali3d.view.SurfaceView;

import java.util.ArrayList;
import java.util.concurrent.atomic.AtomicBoolean;

import de.fhws.mobcom.ardog_java.Callbacks.SaveAdfTaskCallback;
import de.fhws.mobcom.ardog_java.GameApplication;
import de.fhws.mobcom.ardog_java.Helpers.ThreeDimHelper;
import de.fhws.mobcom.ardog_java.R;
import de.fhws.mobcom.ardog_java.Renderers.AreaLearningRenderer;
import de.fhws.mobcom.ardog_java.Tasks.SaveAdfTask;

/**
 * Created by kanga on 01.02.2018.
 */

public class AreaLearningActivity extends Activity {
    public final String TAG = AreaLearningActivity.class.getSimpleName();
    private final static int INVALID_TEXTURE_ID = -1;

    /* Tango */
    private Tango tango;
    private TangoConfig config;
    private boolean isConnected = false;

    /* Application */
    GameApplication application;

    /* Rendering */
    private SurfaceView surfaceView;
    private AreaLearningRenderer renderer;

    /* OpenGL & Tango synchronization */
    private int connectedTextureIdGlThread = INVALID_TEXTURE_ID;
    private AtomicBoolean isFrameAvailableTangoThread = new AtomicBoolean(false);
    private double rgbTimestampGlThread;
    private double cameraPoseTimestamp = 0;

    /* Elements */
    private FloatingActionButton actionButton;

    /* Localization */
    private double previousPoseTimeStamp;
    private double timeToNextUpdate = 1000;
    private boolean isNewRoom;
    private boolean isLocalized;

    /* SaveAdfTask */
    private SaveAdfTask saveAdfTask;

    /* Lock */
    private final Object sharedLock = new Object();

    private int displayRotation = 0;


    @Override
    protected void onCreate( Bundle savedInstances ){

        super.onCreate( savedInstances );
        setContentView(R.layout.activity_area_learning);

        application = ( GameApplication ) getApplicationContext();
        actionButton = ( FloatingActionButton ) findViewById( R.id.area_learn_fab );

        surfaceView = ( SurfaceView ) findViewById( R.id.area_learn_surfaceview );
        renderer = new AreaLearningRenderer( application );

        DisplayManager displayManager = ( DisplayManager ) getSystemService( DISPLAY_SERVICE );
        if( displayManager != null ){
            displayManager.registerDisplayListener( new DisplayManager.DisplayListener() {
                @Override
                public void onDisplayAdded( int displayId ){ }

                @Override
                public void onDisplayChanged( int displayId ){
                    synchronized ( this ) {
                        setDisplayRotation();
                    }
                }

                @Override
                public void onDisplayRemoved( int displayId ){}
            }, null );
        }


        startActivityForResult(
                Tango.getRequestPermissionIntent(Tango.PERMISSIONTYPE_ADF_LOAD_SAVE), 0);

        Intent intent = getIntent();
        isNewRoom = intent.getBooleanExtra( "AREA_EXISTS", false );

        setupRenderer();
    }

    @Override
    protected void onStart(){
        super.onStart();

        surfaceView.setRenderMode( GLSurfaceView.RENDERMODE_CONTINUOUSLY );
        bindTangoService();
    }

    @Override
    protected void onPause(){
        super.onPause();
        isLocalized = false;
        synchronized (this) {
            try {
                tango.disconnect();
            } catch (TangoErrorException e) {
                Log.e( TAG, getString( R.string.exception_tango_error ), e );
            }
        }
    }

    @Override
    protected void onResume(){
        super.onResume();
        bindTangoService();
    }

    @Override
    protected void onStop(){
        super.onStop();
    }

    private void bindTangoService(){
        // Initialize Tango Service as a normal Android Service. Since we call mTango.disconnect()
        // in onPause, this will unbind Tango Service, so every time onResume gets called we
        // should create a new Tango object.
        tango = new Tango(AreaLearningActivity.this, new Runnable() {
            // Pass in a Runnable to be called from UI thread when Tango is ready; this Runnable
            // will be running on a new thread.
            // When Tango is ready, we can call Tango functions safely here only when there are no
            // UI thread changes involved.
            @Override
            public void run() {
                synchronized ( AreaLearningActivity.this ) {
                    try {
                        config = setTangoConfig( tango, false);
                        tango.connect(config);
                        isConnected = true;
                        TangoSupport.initialize( tango );
                        startupTango();
                    } catch (TangoOutOfDateException e) {
                        Log.e(TAG, getString( R.string.exception_out_of_date ), e);
                    } catch (TangoErrorException e) {
                        Log.e(TAG, getString( R.string.exception_tango_error ), e);
                    } catch (TangoInvalidException e) {
                        Log.e(TAG, getString( R.string.exception_tango_invalid ), e);
                    } catch (SecurityException e) {
                        // Area Learning permissions are required. If they are not available,
                        // SecurityException is thrown.
                        Log.e(TAG, getString( R.string.permission_camera ), e);
                    }
                }
            }
        });
    }

    private TangoConfig setTangoConfig(Tango tango, boolean isLoadAdf) {
        // Use default configuration for Tango Service.
        TangoConfig config = tango.getConfig(TangoConfig.CONFIG_TYPE_DEFAULT);
        config.putBoolean( TangoConfig.KEY_BOOLEAN_LEARNINGMODE, true );
        if (isLoadAdf)
            config.putString(TangoConfig.KEY_STRING_AREADESCRIPTION, application.getUUID());
        return config;
    }

    private void startupTango() {
        ArrayList<TangoCoordinateFramePair> framePairs = new ArrayList<TangoCoordinateFramePair>();
        framePairs.add(new TangoCoordinateFramePair(
                TangoPoseData.COORDINATE_FRAME_START_OF_SERVICE,
                TangoPoseData.COORDINATE_FRAME_DEVICE));
        framePairs.add(new TangoCoordinateFramePair(
                TangoPoseData.COORDINATE_FRAME_AREA_DESCRIPTION,
                TangoPoseData.COORDINATE_FRAME_DEVICE));
        framePairs.add(new TangoCoordinateFramePair(
                TangoPoseData.COORDINATE_FRAME_AREA_DESCRIPTION,
                TangoPoseData.COORDINATE_FRAME_START_OF_SERVICE));

        tango.connectListener(framePairs, new Tango.OnTangoUpdateListener() {
            @Override
            public void onPoseAvailable(TangoPoseData pose) {
                synchronized ( sharedLock ) {
                    if (pose.baseFrame == TangoPoseData.COORDINATE_FRAME_AREA_DESCRIPTION
                            && pose.targetFrame == TangoPoseData
                            .COORDINATE_FRAME_START_OF_SERVICE) {
                        if (pose.statusCode == TangoPoseData.POSE_VALID) {
                            isLocalized = true;
                        } else {
                            isLocalized = false;
                        }
                    }
                }

                final double deltaTime = (pose.timestamp - previousPoseTimeStamp) *
                        1000;
                previousPoseTimeStamp = pose.timestamp;
                timeToNextUpdate -= deltaTime;

                if (timeToNextUpdate < 0.0) {
                    timeToNextUpdate = 1000;

                    actionButton.setVisibility( View.VISIBLE );
                }
            }

            @Override
            public void onXyzIjAvailable(TangoXyzIjData xyzIj) {
                // We are not using onXyzIjAvailable for this app.
            }

            @Override
            public void onPointCloudAvailable(TangoPointCloudData xyzij) {
                // We are not using onPointCloudAvailable for this app.
            }

            @Override
            public void onTangoEvent(final TangoEvent event) {
                // Ignoring TangoEvents.
            }

            @Override
            public void onFrameAvailable(int cameraId) {
                if( cameraId == TangoCameraIntrinsics.TANGO_CAMERA_COLOR ){
                    if( surfaceView.getRenderMode() != GLSurfaceView.RENDERMODE_WHEN_DIRTY )
                        surfaceView.setRenderMode( GLSurfaceView.RENDERMODE_WHEN_DIRTY );
                    isFrameAvailableTangoThread.set( true );
                    surfaceView.requestRender();
                }
            }
        });
    }

    private void setupRenderer(){
        renderer.getCurrentScene().registerFrameCallback(new ASceneFrameCallback() {
            @Override
            public void onPreFrame(long sceneTime, double deltaTime) {
                try {
                    synchronized ( AreaLearningActivity.this ) {
                        if (!isConnected)
                            return;

                        if (!renderer.isSceneCameraConfigured()) {
                            TangoCameraIntrinsics intrinsics = TangoSupport.getCameraIntrinsicsBasedOnDisplayRotation(
                                    TangoCameraIntrinsics.TANGO_CAMERA_COLOR, displayRotation
                            );
                            renderer.setProjectionMatrix( ThreeDimHelper.projectionMatrixFromCameraIntrinsics(intrinsics) );
                        }

                        if (connectedTextureIdGlThread != renderer.getTextureId()) {
                            tango.connectTextureId(TangoCameraIntrinsics.TANGO_CAMERA_COLOR, renderer.getTextureId());
                            connectedTextureIdGlThread = renderer.getTextureId();
                            Log.d(TAG, "connected to texture id: " + renderer.getTextureId());
                        }

                        if (isFrameAvailableTangoThread.compareAndSet(true, false))
                            rgbTimestampGlThread = tango.updateTexture(TangoCameraIntrinsics.TANGO_CAMERA_COLOR);

                        if (rgbTimestampGlThread > cameraPoseTimestamp) {
                            TangoPoseData lastFramePose = TangoSupport.getPoseAtTime(
                                    rgbTimestampGlThread,
                                    TangoPoseData.COORDINATE_FRAME_START_OF_SERVICE,
                                    TangoPoseData.COORDINATE_FRAME_CAMERA_COLOR,
                                    TangoSupport.ENGINE_OPENGL,
                                    TangoSupport.ENGINE_OPENGL,
                                    displayRotation
                            );

                            if (lastFramePose.statusCode == TangoPoseData.POSE_VALID) {
                                renderer.updateRenderCameraPose(lastFramePose);
                                cameraPoseTimestamp = lastFramePose.timestamp;
                            } else {
                                Log.w(TAG, "Can't get device pose at time: " + rgbTimestampGlThread);
                            }
                        }
                    }
                } catch (TangoErrorException e) {
                    Log.e(TAG, "Tango API call error within the OpenGL render thread", e);
                } catch (Throwable t) {
                    Log.e(TAG, "Exception on the OpenGL thread", t);
                }
            }

            @Override
            public void onPreDraw(long sceneTime, double deltaTime) {

            }

            @Override
            public void onPostFrame(long sceneTime, double deltaTime) {

            }

            @Override
            public boolean callPreFrame(){
                return true;
            }
        });

        surfaceView.setSurfaceRenderer( renderer );
    }

    private void setupActionButton(){
        actionButton = ( FloatingActionButton ) findViewById( R.id.area_learn_fab );
        actionButton.setVisibility( View.INVISIBLE );
        actionButton.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                saveAdfTask = new SaveAdfTask( application, tango, new SaveAdfTaskCallback(){
                    @Override
                    public void onDone() {

                    }

                    @Override
                    public void onError(Exception e) {

                    }
                });
                saveAdfTask.execute();
            }
        });
    }

    private void setDisplayRotation(){
        Display display = getWindowManager().getDefaultDisplay();
        displayRotation = display.getRotation();

        surfaceView.queueEvent( new Runnable(){
            @Override
            public void run(){
                if( isConnected )
                    renderer.updateColorCameraTextureUvGlThread( displayRotation );
            }
        });
    }
}
