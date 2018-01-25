package de.fhws.mobcom.ardog_java.Activities;

import com.google.atap.tangoservice.Tango;
import com.google.atap.tangoservice.Tango.OnTangoUpdateListener;
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

import android.Manifest;
import android.app.Activity;
import android.app.AlertDialog;
import android.content.DialogInterface;
import android.content.pm.PackageManager;
import android.content.res.Resources;
import android.graphics.Color;
import android.graphics.PorterDuff;
import android.hardware.display.DisplayManager;
import android.opengl.GLSurfaceView;
import android.opengl.Matrix;
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

import org.rajawali3d.animation.mesh.SkeletalAnimationSequence;
import org.rajawali3d.loader.LoaderOBJ;
import org.rajawali3d.loader.ParsingException;
import org.rajawali3d.loader.md5.LoaderMD5Anim;
import org.rajawali3d.loader.md5.LoaderMD5Mesh;
import org.rajawali3d.materials.textures.TextureManager;
import org.rajawali3d.scene.ASceneFrameCallback;
import org.rajawali3d.view.SurfaceView;

import java.util.ArrayList;
import java.util.concurrent.atomic.AtomicBoolean;

import de.fhws.mobcom.ardog_java.GameApplication;
import de.fhws.mobcom.ardog_java.GameObject;
import de.fhws.mobcom.ardog_java.GameRenderer;
import de.fhws.mobcom.ardog_java.ObjectManager;
import de.fhws.mobcom.ardog_java.ObjectManagerCallback;
import de.fhws.mobcom.ardog_java.R;

public class GameActivity extends Activity implements View.OnTouchListener {
    private static final String TAG = GameActivity.class.getSimpleName();
    private static final int INVALID_TEXTURE_ID = 0;

    /* Permissions */
    private static final String CAMERA_PERMISSION = Manifest.permission.CAMERA;
    private static final int CAMERA_PERMISSION_CODE = 0;

    /* Rendering */
    private SurfaceView mSurfaceView;
    private GameRenderer mRenderer;

    /* Tango-specific */
    private Tango mTango;
    private TangoConfig mConfig;
    private boolean mIsConnected = false;
    private double mCameraPoseTimestamp = 0;

    /* OpenGL & Tango synchronization */
    private int mConnectedTextureIdGlThread = INVALID_TEXTURE_ID;
    private AtomicBoolean mIsFrameAvailableTangoThread = new AtomicBoolean(false);
    private double mRgbTimestampGlThread;

    private int mDisplayRotation = 0;

    /* Application */
    GameApplication application;

    /* Game-specific */
    private boolean mIsEditMode = false;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_game);

        // get Application
        application = ( GameApplication ) getApplicationContext();

        mSurfaceView = ( SurfaceView ) findViewById( R.id.surfaceview );
        mSurfaceView.setOnTouchListener( this );
        mRenderer = new GameRenderer( this );

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

        this.onLoadingStart();

        initializeApp( mRenderer.getTextureManager() );
        setupRenderer();

        this.onLoadingDone();
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
    public void onStop(){
        super.onStop();

        synchronized ( this ){
            try {
                if( mTango != null ){
                    mTango.disconnectCamera( TangoCameraIntrinsics.TANGO_CAMERA_COLOR );
                    mTango.disconnect();
                }

                mConnectedTextureIdGlThread = INVALID_TEXTURE_ID;
                mTango = null;
                mIsConnected = false;
            } catch ( TangoErrorException e ){
                Log.e(TAG, getString( R.string.exception_tango_error ), e );
            }
        }
    }

    private void bindTangoService(){
        mTango = new Tango( GameActivity.this, new Runnable(){
            @Override
            public void run(){
                synchronized ( GameActivity.this ){
                    try {
                        mConfig = setupTangoConfig( mTango );
                        mTango.connect( mConfig );
                        startupTango();
                        TangoSupport.initialize( mTango );
                        mIsConnected = true;
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

    private TangoConfig setupTangoConfig( Tango tango ){
        TangoConfig config = tango.getConfig( TangoConfig.CONFIG_TYPE_DEFAULT );
        config.putBoolean( TangoConfig.KEY_BOOLEAN_COLORCAMERA, true );
        config.putBoolean( TangoConfig.KEY_BOOLEAN_LOWLATENCYIMUINTEGRATION, true );
        config.putBoolean( TangoConfig.KEY_BOOLEAN_DRIFT_CORRECTION, true );
        return config;
    }

    private void startupTango(){
        ArrayList<TangoCoordinateFramePair> framePairs = new ArrayList<TangoCoordinateFramePair>();

        mTango.connectListener(framePairs, new OnTangoUpdateListener() {
            @Override
            public void onPoseAvailable( TangoPoseData pose ){

            }
            @Override
            public void onXyzIjAvailable(TangoXyzIjData xyzIj) {
                // We are not using onXyzIjAvailable for this app.
            }

            @Override
            public void onPointCloudAvailable(TangoPointCloudData pointCloud) {
                // We are not using onPointCloudAvailable for this app.
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
                    mIsFrameAvailableTangoThread.set( true );
                    mSurfaceView.requestRender();
                }
            }
        });
    }

    private void setupRenderer(){
        mRenderer.getCurrentScene().registerFrameCallback(new ASceneFrameCallback() {
            @Override
            public void onPreFrame(long sceneTime, double deltaTime) {
                try {
                    synchronized ( GameActivity.this ){
                        if( !mIsConnected )
                            return;

                        if( !mRenderer.isSceneCameraConfigured() ){
                            TangoCameraIntrinsics intrinsics = TangoSupport.getCameraIntrinsicsBasedOnDisplayRotation(
                                    TangoCameraIntrinsics.TANGO_CAMERA_COLOR, mDisplayRotation
                            );
                            mRenderer.setProjectionMatrix( projectionMatrixFromCameraIntrinsics(intrinsics) );
                        }

                        if( mConnectedTextureIdGlThread != mRenderer.getTextureId() ){
                            mTango.connectTextureId( TangoCameraIntrinsics.TANGO_CAMERA_COLOR, mRenderer.getTextureId() );
                            mConnectedTextureIdGlThread = mRenderer.getTextureId();
                            Log.d(TAG, "connected to texture id: " + mRenderer.getTextureId() );
                        }

                        if( mIsFrameAvailableTangoThread.compareAndSet( true, false ) )
                            mRgbTimestampGlThread = mTango.updateTexture( TangoCameraIntrinsics.TANGO_CAMERA_COLOR );

                        if( mRgbTimestampGlThread > mCameraPoseTimestamp ){
                            TangoPoseData lastFramePose = TangoSupport.getPoseAtTime(
                                    mRgbTimestampGlThread,
                                    TangoPoseData.COORDINATE_FRAME_START_OF_SERVICE,
                                    TangoPoseData.COORDINATE_FRAME_CAMERA_COLOR,
                                    TangoSupport.ENGINE_OPENGL,
                                    TangoSupport.ENGINE_OPENGL,
                                    mDisplayRotation
                            );

                            if( lastFramePose.statusCode == TangoPoseData.POSE_VALID ){
                                mRenderer.updateRenderCameraPose( lastFramePose );
                                mCameraPoseTimestamp = lastFramePose.timestamp;
                            } else {
                                Log.w(TAG, "Can't get device pose at time: " + mRgbTimestampGlThread );
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

        this.onLoadingDone();

        mSurfaceView.setSurfaceRenderer( mRenderer );
    }

    private static float[] projectionMatrixFromCameraIntrinsics( TangoCameraIntrinsics intrinsics ){
        float cx = ( float ) intrinsics.cx;
        float cy = ( float ) intrinsics.cy;
        float width = ( float ) intrinsics.width;
        float height = ( float ) intrinsics.height;
        float fx = ( float ) intrinsics.fx;
        float fy = ( float ) intrinsics.fy;

        float near = 0.1f;
        float far = 100;

        float xScale = near / fx;
        float yScale = near / fy;
        float xOffset = -( cy - ( width / 2.0f ) ) * xScale;
        float yOffset = -( cy - ( height / 2.0f ) ) * yScale;

        float m[] = new float[16];
        Matrix.frustumM( m, 0,
                xScale * ( float ) - width / 2.0f - xOffset,
                xScale * ( float ) width / 2.0f - xOffset,
                yScale * ( float ) - height / 2.0f - yOffset,
                yScale * ( float ) height / 2.0f - yOffset,
                near, far );
        return m;
    }

    private void setDisplayRotation(){
        Display display = getWindowManager().getDefaultDisplay();
        mDisplayRotation = display.getRotation();

        mSurfaceView.queueEvent( new Runnable(){
            @Override
            public void run(){
                if( mIsConnected )
                    mRenderer.updateColorCameraTextureUvGlThread( mDisplayRotation );
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
        mRenderer.onTouchEvent( motionEvent );
        return true;
    }

    /* initializes GameApplication */
    private void initializeApp( TextureManager textureManager ){
        Resources resources = getResources();
        this.application.loadAssets( resources, textureManager );
    }

    private void onLoadingStart(){
        ProgressBar progressBar = ( ProgressBar ) findViewById( R.id.progressBar );
        progressBar.getIndeterminateDrawable().setColorFilter( Color.WHITE, PorterDuff.Mode.MULTIPLY );

        TextView progressText = ( TextView ) findViewById( R.id.progressText );
        progressText.setTextColor( Color.WHITE );
        progressText.setTextSize( 18.0F );
        progressText.setText( "Loading..." );
    }

    // this method gets called when loading is done
    private void onLoadingDone(){
        ProgressBar progressBar = ( ProgressBar ) findViewById( R.id.progressBar );
        progressBar.setVisibility( View.GONE );

        TextView progressText = ( TextView ) findViewById( R.id.progressText );
        progressText.setVisibility( View.GONE );
    }
}
