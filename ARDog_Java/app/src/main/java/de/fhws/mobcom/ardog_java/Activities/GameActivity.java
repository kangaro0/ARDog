package de.fhws.mobcom.ardog_java.Activities;

import com.google.atap.tangoservice.Tango;
import com.google.atap.tangoservice.Tango.OnTangoUpdateListener;
import com.google.atap.tangoservice.TangoCameraIntrinsics;
import com.google.atap.tangoservice.TangoConfig;
import com.google.atap.tangoservice.TangoCoordinateFramePair;
import com.google.atap.tangoservice.TangoErrorException;
import com.google.atap.tangoservice.TangoEvent;
import com.google.atap.tangoservice.TangoException;
import com.google.atap.tangoservice.TangoInvalidException;
import com.google.atap.tangoservice.TangoOutOfDateException;
import com.google.atap.tangoservice.TangoPointCloudData;
import com.google.atap.tangoservice.TangoPoseData;
import com.google.atap.tangoservice.TangoXyzIjData;
import com.google.atap.tangoservice.experimental.TangoImageBuffer;
import com.google.tango.depthinterpolation.TangoDepthInterpolation;
import com.google.tango.support.TangoPointCloudManager;
import com.google.tango.support.TangoSupport;
import com.google.tango.transformhelpers.TangoTransformHelper;

import android.Manifest;
import android.app.Activity;
import android.app.AlertDialog;
import android.content.DialogInterface;
import android.content.pm.PackageManager;
import android.graphics.Color;
import android.graphics.PorterDuff;
import android.hardware.display.DisplayManager;
import android.opengl.GLSurfaceView;
import android.os.Bundle;
import android.support.v4.app.ActivityCompat;
import android.support.v4.content.ContextCompat;
import android.util.Log;
import android.view.Display;
import android.view.MotionEvent;
import android.view.View;
import android.widget.ProgressBar;
import android.widget.TextView;
import android.widget.Toast;

import org.rajawali3d.math.vector.Vector3;
import org.rajawali3d.scene.ASceneFrameCallback;
import org.rajawali3d.view.SurfaceView;

import java.nio.ByteBuffer;
import java.util.ArrayList;
import java.util.concurrent.atomic.AtomicBoolean;

import de.fhws.mobcom.ardog_java.Callbacks.GameRendererCallback;
import de.fhws.mobcom.ardog_java.GameApplication;
import de.fhws.mobcom.ardog_java.Objects.GameObject;
import de.fhws.mobcom.ardog_java.Helpers.ThreeDimHelper;
import de.fhws.mobcom.ardog_java.Renderers.GameRenderer;
import de.fhws.mobcom.ardog_java.R;

public class GameActivity extends Activity implements View.OnTouchListener, GameRendererCallback {

    private class TouchPoint {
        public double timestamp;
        public float[] depthPoint;

        public TouchPoint( double timestamp, float[] depthPoint ){
            this.timestamp = timestamp;
            this.depthPoint = depthPoint;
        }
    }

    private static final String TAG = GameActivity.class.getSimpleName();
    private static final int INVALID_TEXTURE_ID = 0;

    /* Permissions */
    private static final String CAMERA_PERMISSION = Manifest.permission.CAMERA;
    private static final int CAMERA_PERMISSION_CODE = 0;

    /* Rendering */
    private SurfaceView mSurfaceView;
    private GameRenderer mRenderer;

    /* Tango-specific */
    private Tango tango;
    private TangoConfig config;
    private TangoPointCloudManager pointCloudManager;
    private boolean isConnected = false;
    private boolean isConnecting = false;
    private double cameraPoseTimestamp = 0;

    /* OpenGL & Tango synchronization */
    private int connectedTextureIdGlThread = INVALID_TEXTURE_ID;
    private AtomicBoolean isFrameAvailableTangoThread = new AtomicBoolean(false);
    private double rgbTimestampGlThread;

    /* Touch to 3D */
    private volatile TangoImageBuffer mCurrentImageBuffer;
    private TouchPoint touchPoint;
    private Vector3 touchInOpenGl;

    private int displayRotation = 0;

    /* Application */
    GameApplication application;

    /* Game-specific */
    private boolean isEditMode = false;
    private boolean isPlacing = true;      // true when user wants to place an object instead of selecting it


    @Override
    protected void onCreate(Bundle savedInstanceState) {
        Log.d( TAG, "GameActivity: onCreate()" );
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_game);

         // get Application
        application = ( GameApplication ) getApplicationContext();

        pointCloudManager = new TangoPointCloudManager();

        mSurfaceView = ( SurfaceView ) findViewById( R.id.surfaceview );
        mSurfaceView.setOnTouchListener( this );
        mRenderer = new GameRenderer(this, this );

        DisplayManager displayManager = ( DisplayManager ) getSystemService( DISPLAY_SERVICE );
        if( displayManager != null ){
            displayManager.registerDisplayListener( new DisplayManager.DisplayListener() {
                @Override
                public void onDisplayAdded( int displayId ){ }

                @Override
                public void onDisplayChanged( int displayId ){
                    synchronized ( GameActivity.this ) {
                        setDisplayRotation();
                    }
                }

                @Override
                public void onDisplayRemoved( int displayId ){}
            }, null );
        }

        // gets called when 3D-Models are loaded
        setupRenderer();
    }

    @Override
    protected void onStart(){
        super.onStart();

        mSurfaceView.setRenderMode( GLSurfaceView.RENDERMODE_CONTINUOUSLY );
        if( checkAndRequestPermissions() ){
            bindTangoService();
        }
    }

    @Override
    protected void onResume(){
        super.onResume();
        if( !isConnected && !isConnected )
            bindTangoService();
    }

    @Override
    protected void onPause(){
        super.onPause();
    }

    @Override
    public void onStop(){
        super.onStop();

        synchronized ( GameActivity.this ){
            try {
                mRenderer.getCurrentScene().clearFrameCallbacks();
                if( tango != null ){
                    tango.disconnectCamera( TangoCameraIntrinsics.TANGO_CAMERA_COLOR );
                    tango.disconnect();
                }

                connectedTextureIdGlThread = INVALID_TEXTURE_ID;
                isConnected = false;
            } catch ( TangoErrorException e ){
                Log.e( TAG, getString( R.string.exception_tango_error ), e );
            }
        }
    }

    private void bindTangoService(){
        isConnecting = true;
        Log.d( TAG, "GameActivity: bindTangoService()" );
        tango = new Tango( GameActivity.this,  new Runnable(){
            @Override
            public void run(){
                synchronized ( GameActivity.this ){
                    try {
                        // beware, if no adf loaded this will crash
                        config = setupTangoConfig(tango, false );
                        tango.connect(config);
                        startupTango();
                        TangoSupport.initialize(tango);
                        isConnected = true;
                        isConnecting = false;
                        setDisplayRotation();
                    } catch (TangoOutOfDateException e) {
                        Log.e(TAG, getString(R.string.exception_out_of_date), e);
                        showsToastAndFinishOnUiThread( R.string.exception_out_of_date );
                    } catch (TangoErrorException e) {
                        Log.e(TAG, getString(R.string.exception_tango_error), e);
                        showsToastAndFinishOnUiThread( R.string.exception_tango_error );
                    } catch (TangoInvalidException e) {
                        Log.e(TAG, getString(R.string.exception_tango_invalid), e);
                        showsToastAndFinishOnUiThread( R.string.exception_tango_invalid );
                    } catch (Exception e) {
                        e.printStackTrace();
                    }
                }
            }
        });
    }

    private TangoConfig setupTangoConfig( Tango tango, boolean loadAdf ){
        TangoConfig config = tango.getConfig( TangoConfig.CONFIG_TYPE_DEFAULT );
        config.putBoolean( TangoConfig.KEY_BOOLEAN_COLORCAMERA, true );
        config.putBoolean( TangoConfig.KEY_BOOLEAN_LOWLATENCYIMUINTEGRATION, true );
        config.putBoolean( TangoConfig.KEY_BOOLEAN_DEPTH, true );
        config.putInt( TangoConfig.KEY_INT_DEPTH_MODE, TangoConfig.TANGO_DEPTH_MODE_POINT_CLOUD );
        if( loadAdf )
            config.putString( TangoConfig.KEY_STRING_AREADESCRIPTION, application.getUUID() );
        return config;
    }

    private void startupTango(){
        Log.d( TAG, "GameActivity: startupTango()" );
        ArrayList<TangoCoordinateFramePair> framePairs = new ArrayList<TangoCoordinateFramePair>();

        tango.connectListener(framePairs, new OnTangoUpdateListener() {
            @Override
            public void onPoseAvailable( TangoPoseData pose ){

            }
            @Override
            public void onXyzIjAvailable(TangoXyzIjData xyzIj) {
                // We are not using onXyzIjAvailable for this app.
            }

            @Override
            public void onPointCloudAvailable(TangoPointCloudData pointCloud) {
                pointCloudManager.updatePointCloud( pointCloud );
            }

            @Override
            public void onTangoEvent(TangoEvent event) {
                // We are not using onTangoEvent for this app.
            }

            @Override
            public void onFrameAvailable( int cameraId ){
                if( cameraId == TangoCameraIntrinsics.TANGO_CAMERA_COLOR ){
                    if( mSurfaceView.getRenderMode() != GLSurfaceView.RENDERMODE_WHEN_DIRTY )
                        mSurfaceView.setRenderMode( GLSurfaceView.RENDERMODE_WHEN_DIRTY );
                    isFrameAvailableTangoThread.set( true );
                    mSurfaceView.requestRender();
                }
            }
        });
        tango.experimentalConnectOnFrameListener(TangoCameraIntrinsics.TANGO_CAMERA_COLOR,
                new Tango.OnFrameAvailableListener() {
                    @Override
                    public void onFrameAvailable(TangoImageBuffer tangoImageBuffer, int i) {
                        mCurrentImageBuffer = copyImageBuffer( tangoImageBuffer );
                    }

                    TangoImageBuffer copyImageBuffer(TangoImageBuffer imageBuffer) {
                        ByteBuffer clone = ByteBuffer.allocateDirect(imageBuffer.data.capacity());
                        imageBuffer.data.rewind();
                        clone.put(imageBuffer.data);
                        imageBuffer.data.rewind();
                        clone.flip();
                        return new TangoImageBuffer(imageBuffer.width, imageBuffer.height,
                                imageBuffer.stride, imageBuffer.frameNumber,
                                imageBuffer.timestamp, imageBuffer.format, clone,
                                imageBuffer.exposureDurationNs);
                    }
                });
    }

    private void setupRenderer(){
        Log.d( TAG, "GameActivity: setupRenderer()" );
        mRenderer.getCurrentScene().registerFrameCallback(new ASceneFrameCallback() {
            @Override
            public void onPreFrame(long sceneTime, double deltaTime) {
                try {
                    synchronized ( GameActivity.this ){
                        if( !isConnected)
                            return;

                        if( !mRenderer.isSceneCameraConfigured() ){
                            TangoCameraIntrinsics intrinsics = TangoSupport.getCameraIntrinsicsBasedOnDisplayRotation(
                                    TangoCameraIntrinsics.TANGO_CAMERA_COLOR, displayRotation
                            );
                            mRenderer.setProjectionMatrix(ThreeDimHelper.projectionMatrixFromCameraIntrinsics(intrinsics) );
                        }

                        if( connectedTextureIdGlThread != mRenderer.getTextureId() ){
                            tango.connectTextureId( TangoCameraIntrinsics.TANGO_CAMERA_COLOR, mRenderer.getTextureId() );
                            connectedTextureIdGlThread = mRenderer.getTextureId();
                            Log.d(TAG, "connected to texture id: " + mRenderer.getTextureId() );
                        }

                        if( isFrameAvailableTangoThread.compareAndSet( true, false ) )
                            rgbTimestampGlThread = tango.updateTexture( TangoCameraIntrinsics.TANGO_CAMERA_COLOR );

                        if( rgbTimestampGlThread > cameraPoseTimestamp){
                            TangoPoseData lastFramePose = TangoSupport.getPoseAtTime(
                                    rgbTimestampGlThread,
                                    TangoPoseData.COORDINATE_FRAME_START_OF_SERVICE,
                                    TangoPoseData.COORDINATE_FRAME_CAMERA_COLOR,
                                    TangoSupport.ENGINE_OPENGL,
                                    TangoSupport.ENGINE_OPENGL,
                                    displayRotation
                            );

                            if( lastFramePose.statusCode == TangoPoseData.POSE_VALID ){
                                mRenderer.updateRenderCameraPose( lastFramePose );
                                cameraPoseTimestamp = lastFramePose.timestamp;
                            } else {
                                Log.w(TAG, "Can't get device pose at time: " + rgbTimestampGlThread);
                            }
                        }

                        if( touchPoint != null ){
                            TangoSupport.MatrixTransformData openglTDepthArr =
                                    TangoSupport.getMatrixTransformAtTime(
                                            touchPoint.timestamp,
                                            TangoPoseData.COORDINATE_FRAME_START_OF_SERVICE,
                                            TangoPoseData.COORDINATE_FRAME_CAMERA_DEPTH,
                                            TangoSupport.ENGINE_OPENGL,
                                            TangoSupport.ENGINE_TANGO,
                                            TangoSupport.ROTATION_IGNORED
                                    );

                            if( openglTDepthArr.statusCode == TangoPoseData.POSE_VALID ){

                                float[] p0 = TangoTransformHelper.transformPoint(
                                        openglTDepthArr.matrix,
                                        touchPoint.depthPoint
                                );

                                mRenderer.showTouch( new Vector3( p0[ 0 ], p0[ 1 ], p0[ 2 ] ) );
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

        mSurfaceView.setSurfaceRenderer( mRenderer );
    }

    private void setDisplayRotation(){
        Display display = getWindowManager().getDefaultDisplay();
        displayRotation = display.getRotation();

        mSurfaceView.queueEvent( new Runnable(){
            @Override
            public void run(){
                if(isConnected)
                    mRenderer.updateColorCameraTextureUvGlThread(displayRotation);
            }
        });
    }

    private boolean checkAndRequestPermissions(){
        if( !hasCameraPermission() ){
            requestCameraPermission();
            return false;
        }
        return true;
    }

    private boolean hasCameraPermission(){
        return ContextCompat.checkSelfPermission( this, CAMERA_PERMISSION ) ==
                PackageManager.PERMISSION_GRANTED;
    }

    private void requestCameraPermission(){
        if( ActivityCompat.shouldShowRequestPermissionRationale( this, CAMERA_PERMISSION ) ){
            showRequestPermissionRationale();
        } else {
            ActivityCompat.requestPermissions( this, new String[]{ CAMERA_PERMISSION }, CAMERA_PERMISSION_CODE );
        }
    }

    private void showRequestPermissionRationale(){
        final AlertDialog dialog = new AlertDialog.Builder(this)
            .setMessage( "This app requires camera permission" )
            .setPositiveButton( "Ok", new DialogInterface.OnClickListener() {
                @Override
                public void onClick( DialogInterface dialogInterface, int i ){
                    ActivityCompat.requestPermissions( GameActivity.this, new String[]{ CAMERA_PERMISSION }, CAMERA_PERMISSION_CODE  );
                }
            })
            .create();
        dialog.show();
    }

    @Override
    public void onRequestPermissionsResult( int requestCode, String[] permissions, int[] grantResults ){
        if( hasCameraPermission() )
            bindTangoService();
        else
            Toast.makeText( this, "This app requires camera permission", Toast.LENGTH_LONG ).show();
    }

    private void showsToastAndFinishOnUiThread( final int resId ){
        runOnUiThread(new Runnable() {
            @Override
            public void run(){
                Toast.makeText( GameActivity.this, getString( resId ), Toast.LENGTH_LONG ).show();
                finish();
            }
        });
    }

    @Override
    public boolean onTouch( View view, MotionEvent motionEvent ){
        Log.d( TAG, "GameActivity: onTouch(...)" );
        if( isPlacing ) {
            // convert to uv-coords
            float u = motionEvent.getX() / view.getWidth();
            float v = motionEvent.getY() / view.getHeight();

            try {
                synchronized ( GameActivity.this ){
                    // save TouchPoint, which will be processed on next Tango Callback
                    getDepthAtTouchPosition( u, v );
                }
            } catch ( TangoException e ){
                Log.e( TAG, "Tango error!", e );
            } catch( SecurityException e ){
                Log.e( TAG, "Security exception ...", e );
            }
        } else {
            mRenderer.onTouchEvent(motionEvent);
        }
        return true;
    }

    private void getDepthAtTouchPosition( float u, float v ){
        TangoPointCloudData pointCloud = pointCloudManager.getLatestPointCloud();
        if( pointCloud == null )
            return;

        double rgbTimestamp = rgbTimestampGlThread;
        TangoImageBuffer imageBuffer = mCurrentImageBuffer;

        TangoPoseData depthlTcolorPose = TangoSupport.getPoseAtTime(
                rgbTimestamp,
                TangoPoseData.COORDINATE_FRAME_CAMERA_DEPTH,
                TangoPoseData.COORDINATE_FRAME_CAMERA_COLOR,
                TangoSupport.ENGINE_TANGO,
                TangoSupport.ENGINE_TANGO,
                TangoSupport.ROTATION_IGNORED
        );

        if( depthlTcolorPose.statusCode != TangoPoseData.POSE_VALID ){
            Log.w( TAG, "Could not get color camera transform at time: " + rgbTimestamp );
            return;
        }

        float[] depthPoint = TangoDepthInterpolation.getDepthAtPointBilateral(
                pointCloud,
                new double[] { 0.0, 0.0, 0.0 },
                new double[] { 0.0, 0.0, 0.0, 1.0 },
                imageBuffer,
                u, v,
                displayRotation,
                depthlTcolorPose.translation,
                depthlTcolorPose.rotation
        );

        if( depthPoint == null ){
            Log.e( TAG, "There is no depth point." );
            // reset touchpoint from before
            touchPoint = null;
            return;
        }

        touchPoint = new TouchPoint( rgbTimestamp, depthPoint );
    }

    @Override
    public void onObjectPicked(GameObject obj) {

    }
}
