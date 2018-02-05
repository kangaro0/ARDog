package de.fhws.mobcom.ardog_java.Activities;

import com.github.clans.fab.FloatingActionButton;
import com.github.clans.fab.FloatingActionMenu;
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
import android.content.res.Resources;
import android.graphics.Color;
import android.graphics.PorterDuff;
import android.hardware.display.DisplayManager;
import android.opengl.GLSurfaceView;
import android.os.Bundle;
import android.support.v4.app.ActivityCompat;
import android.support.v4.content.ContextCompat;
import android.text.TextUtils;
import android.util.Log;
import android.view.Display;
import android.view.MotionEvent;
import android.view.View;
import android.widget.ProgressBar;
import android.widget.TextView;
import android.widget.Toast;

import org.rajawali3d.materials.textures.TextureManager;
import org.rajawali3d.math.vector.Vector3;
import org.rajawali3d.scene.ASceneFrameCallback;
import org.rajawali3d.view.SurfaceView;

import java.nio.ByteBuffer;
import java.util.ArrayList;
import java.util.concurrent.atomic.AtomicBoolean;

import de.fhws.mobcom.ardog_java.Callbacks.GameApplicationLoadCallback;
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

    /* UI */
    private FloatingActionMenu mFabBuild;
    private FloatingActionMenu mFabObject;
    private String mLastObjectName;


    @Override
    protected void onCreate(Bundle savedInstanceState) {
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
        // gets called when 3D-Models are loaded
        setupRenderer();


       /* SQLiteDatabase db = adHelper.getWritableDatabase();
        ContentValues values = new ContentValues();
        values.put(ARDogContract.TangoRoom.COLUMN_NAME_UUID, "asfafds-asdfassf-adfa");
        values.put(ARDogContract.TangoRoom.COLUMN_NAME_NAME, "Raumname");
        long newRowId = db.insert(ARDogContract.TangoRoom.TABLE_NAME, null, values);

       db = adHelper.getReadableDatabase();
        String [] projection ={
                ARDogContract.TangoRoom.COLUMN_NAME_UUID,
                ARDogContract.TangoRoom.COLUMN_NAME_NAME,
        };
        String selection = ARDogContract.TangoRoom.COLUMN_NAME_NAME + "= ?";
        String[] selectionArgs = {"Raumname"};
        Cursor cursor = db.query(
                ARDogContract.TangoRoom.TABLE_NAME,
                projection,
                selection,
                selectionArgs,
                null,
                null,
                null
        );
        cursor.moveToNext();
        String name = cursor.getString(cursor.getColumnIndexOrThrow(ARDogContract.TangoRoom.COLUMN_NAME_NAME));
        cursor.close();
        Log.d("Db result" ,name);*/

       mFabBuild = (FloatingActionMenu) findViewById(R.id.fab_build);
       mFabObject = (FloatingActionMenu) findViewById(R.id.fab_object);
       mFabObject.open(true);

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
        tango = new Tango( GameActivity.this, new Runnable(){
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
        //config.putBoolean( TangoConfig.KEY_BOOLEAN_DRIFT_CORRECTION, true );
        config.putBoolean(TangoConfig.KEY_BOOLEAN_DEPTH, true);
        config.putInt(TangoConfig.KEY_INT_DEPTH_MODE, TangoConfig.TANGO_DEPTH_MODE_POINT_CLOUD);
        if( loadAdf )
            config.putString( TangoConfig.KEY_STRING_AREADESCRIPTION, application.getUUID() );
        return config;
    }

    private void startupTango(){
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

                                touchInOpenGl = new Vector3( p0[ 0 ], p0[ 1 ], p0[ 2 ] );
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

    /* initializes GameApplication */
    private void initializeApp( TextureManager textureManager ){
        Resources resources = getResources();
        this.application.loadAssets( textureManager, new GameApplicationLoadCallback() {
            @Override
            public void onDone() {
                // Loading done here
                onLoadingDone();
            }
            @Override
            public void onError( Exception e ){
                // Error happened
                Log.e( TAG, "Error while loading assets:", e );
            }
        });
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

        float[] depthPoint = TangoDepthInterpolation.getDepthAtPointNearestNeighbor(
                pointCloud,
                new double[] { 0.0, 0.0, 0.0 },
                new double[] { 0.0, 0.0, 0.0, 1.0 },
                u, v,
                displayRotation,
                depthlTcolorPose.translation,
                depthlTcolorPose.rotation
        );

        touchPoint = new TouchPoint( rgbTimestamp, depthPoint );

    }

    // Builds a Fab Menu for the picked object
    @Override
    public void onObjectPicked(GameObject obj) {

    if(TextUtils.isEmpty(mLastObjectName))
        mLastObjectName = obj.getName();
    else
        buildObjectFab(obj);
    }

    @Override
    public void onObjectUnpicked() {
        mFabObject.setVisibility(View.GONE);
        mFabBuild.setVisibility(View.VISIBLE);

    }

    private void buildObjectFab(GameObject obj){

        if(mLastObjectName != obj.getName()){
            mFabObject.removeAllMenuButtons();

            final FloatingActionButton deleteFab = new FloatingActionButton(this);
            deleteFab.setButtonSize(FloatingActionButton.SIZE_MINI);
            deleteFab.setLabelText(getString(R.string.delete));
            deleteFab.setImageResource(R.drawable.ic_delete_forever_black_18dp);
            mFabObject.addMenuButton(deleteFab);

            for(GameObject o : obj.getChildren()) {
                final FloatingActionButton fab = new FloatingActionButton(this);
                fab.setButtonSize(FloatingActionButton.SIZE_MINI);
                fab.setLabelText(o.getName());
                fab.setImageResource(o.getThumbnailId());
                mFabObject.addMenuButton(fab);
            }
        }
        else{
            runOnUiThread(new Runnable() {
                @Override
                public void run() {
                    mFabBuild.setVisibility(View.GONE);
                    mFabObject.setVisibility(View.VISIBLE);
                    finish();
                }
            });
        }
    }

}
