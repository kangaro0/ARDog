package de.fhws.mobcom.ardog_java.Activities;

import android.app.Activity;
import android.app.AlertDialog;
import android.content.DialogInterface;
import android.content.Intent;
import android.hardware.display.DisplayManager;
import android.opengl.GLSurfaceView;
import android.os.Bundle;
import android.support.design.widget.FloatingActionButton;
import android.text.InputType;
import android.util.Log;
import android.view.Display;
import android.view.View;
import android.widget.EditText;

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

import de.fhws.mobcom.ardog_java.Callbacks.AdfTaskCallback;
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
    private final static int INVALID_TEXTURE_ID = 0;

    /* Tango */
    private Tango tango;
    private TangoConfig config;
    private boolean isConnected = false;
    private double cameraPoseTimestamp = 0;

    /* Application */
    GameApplication application;

    /* Rendering */
    private SurfaceView surfaceView;
    private AreaLearningRenderer renderer;

    /* OpenGL & Tango synchronization */
    private int connectedTextureIdGlThread = INVALID_TEXTURE_ID;
    private AtomicBoolean isFrameAvailableTangoThread = new AtomicBoolean(false);
    private double rgbTimestampGlThread;

    /* Elements */
    private FloatingActionButton actionButton;

    /* Localization */
    private double previousPoseTimeStamp;
    private double timeToNextUpdate = 1000;
    private boolean isNewRoom;
    private boolean isLocalized;

    /* SaveAdfTask */
    private SaveAdfTask saveAdfTask;

    private boolean hasPermissions = false;

    private int displayRotation = 0;


    @Override
    protected void onCreate( Bundle savedInstances ) {

        super.onCreate(savedInstances);
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

        Intent intent = getIntent();
        isNewRoom = intent.getBooleanExtra( "AREA_EXISTS", false );

        setupRenderer();
    }

    @Override
    protected void onStart(){
        Log.d( TAG, "AreaLearningActivity: onStart()" );
        super.onStart();

        surfaceView.setRenderMode( GLSurfaceView.RENDERMODE_CONTINUOUSLY );
        bindTangoService();
    }

    @Override
    protected void onResume(){
        Log.d( TAG, "AreaLearningActivity: onResume()" );
        super.onResume();
        if( isConnected )
            tango.disconnect();
        bindTangoService();
    }

    @Override
    protected void onPause(){
        Log.d( TAG, "AreaLearningActivity: onPause()" );
        super.onPause();
        if( isConnected )
            tango.disconnect();
    }

    @Override
    protected void onStop(){
        Log.d( TAG, "AreaLearningActivity: onStop()" );
        super.onStop();
        if( isConnected )
            tango.disconnect();
    }

    private void bindTangoService(){
        Log.d( TAG, "bindTangoService()" );
        tango = new Tango(AreaLearningActivity.this, new Runnable() {
            // Pass in a Runnable to be called from UI thread when Tango is ready; this Runnable
            // will be running on a new thread.
            // When Tango is ready, we can call Tango functions safely here only when there are no
            // UI thread changes involved.
            @Override
            public void run() {
                synchronized ( AreaLearningActivity.this ) {
                    try {
                        config = setupTangoConfig( tango, false);
                        tango.connect(config);
                        startupTango();
                        TangoSupport.initialize( tango );
                        isConnected = true;
                        setup();
                        setDisplayRotation();
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

    private TangoConfig setupTangoConfig( Tango tango, boolean loadAdf ) {
        TangoConfig config = tango.getConfig( TangoConfig.CONFIG_TYPE_DEFAULT );
        config.putBoolean( TangoConfig.KEY_BOOLEAN_LEARNINGMODE, true );
        config.putBoolean( TangoConfig.KEY_BOOLEAN_COLORCAMERA, true );
        config.putBoolean( TangoConfig.KEY_BOOLEAN_LOWLATENCYIMUINTEGRATION, true );
        if( loadAdf )
            config.putString( TangoConfig.KEY_STRING_AREADESCRIPTION, application.getUUID() );
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
                synchronized ( AreaLearningActivity.this ) {
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

                    runOnUiThread( new Runnable(){
                        @Override
                        public void run(){
                            actionButton.setVisibility( View.VISIBLE );
                        }
                    });
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

    private void setup(){
        runOnUiThread(new Runnable() {
            @Override
            public void run() {
                setupActionButton();
            }
        });
    }

    private void setupActionButton(){
        actionButton = ( FloatingActionButton ) findViewById( R.id.area_learn_fab );
        actionButton.setVisibility( View.INVISIBLE );
        actionButton.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                showNameRoomAlert();
            }
        });
    }

    private void showNameRoomAlert(){
        AlertDialog.Builder builder = new AlertDialog.Builder(
                this,
                R.style.AlertDialogCustom
        );

        final EditText input = new EditText( this );
        input.setInputType( InputType.TYPE_CLASS_TEXT );

        builder.setView( input );
        builder.setTitle( "Name:                               " );
        builder.setPositiveButton("OK", new DialogInterface.OnClickListener() {
            @Override
            public void onClick(DialogInterface dialog, int which) {
                String name = input.getText().toString();

                saveAdfTask = new SaveAdfTask( application, tango, name, new AdfTaskCallback(){
                    @Override
                    public void onDone() {
                        Log.d( TAG, "AreaLearningAcitivty: ADF saved." );
                        // Switch back to AreaSelectionActivity
                        Intent intent = new Intent( application, de.fhws.mobcom.ardog_java.Activities.AreaSelectionActivity.class );
                        startActivity( intent );
                    }

                    @Override
                    public void onError(Exception e) {

                    }
                });
                saveAdfTask.execute();

            }
        });
        builder.setNegativeButton("Cancle", new DialogInterface.OnClickListener() {
            @Override
            public void onClick(DialogInterface dialog, int which) {
                dialog.cancel();
            }
        });

        builder.show();
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
