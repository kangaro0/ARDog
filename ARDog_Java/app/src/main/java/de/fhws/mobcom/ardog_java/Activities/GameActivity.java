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
import android.annotation.SuppressLint;
import android.app.Activity;
import android.app.AlertDialog;
import android.content.DialogInterface;
import android.content.pm.PackageManager;
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
import android.widget.Toast;

import org.rajawali3d.Object3D;
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
import de.fhws.mobcom.ardog_java.Sql.ARDogDbHelper;
import de.fhws.mobcom.ardog_java.Sql.ARDogQuery;
import de.fhws.mobcom.ardog_java.Sql.DBObject;

public class GameActivity extends Activity implements View.OnTouchListener, GameRendererCallback {

    private class TouchPoint {
        public double timestamp;
        public float[] depthPoint;

        public TouchPoint( double timestamp, float[] depthPoint ){
            this.timestamp = timestamp;
            this.depthPoint = depthPoint;
        }
    }

    private static final String TAG = GameActivity.class.getSimpleName() + "aaaaa";
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

    /* SQLite */
    private ARDogDbHelper helper;
    private ARDogQuery query;

    private int displayRotation = 0;

    /* Application */
    GameApplication application;

    /* Game-specific */
    private boolean isEditMode = false;

    /* UI */
    private FloatingActionMenu mFabBuild;
    private FloatingActionMenu mFabObject;
    private FloatingActionButton mBowlButton;
    private FloatingActionButton mPillowButton;
    private FloatingActionButton mDeleteAllButton;
    private FloatingActionButton mDogButton;
    private String mLastObjectName;

    /*Ui Listeners*/
    private boolean bowlWasPressed = false;
    private boolean pillowWasPressed = false;
    private boolean dogWasPressed = false;

    private View.OnClickListener mBowlListener;
    private View.OnClickListener mPillowListener;
    private View.OnClickListener mDeleteAllListener;
    private View.OnClickListener mDogListener;


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

        setupRenderer();

        /* db */
        helper = new ARDogDbHelper( this );
        query = new ARDogQuery( helper );

        initBuildFabListeners();
        mFabBuild = (FloatingActionMenu) findViewById(R.id.fab_build);
        mBowlButton = (FloatingActionButton) findViewById(R.id.bowl_button);
        mBowlButton.setOnClickListener(mBowlListener);
        mPillowButton = (FloatingActionButton) findViewById(R.id.bed_button);
        mPillowButton.setOnClickListener(mPillowListener);
        mDeleteAllButton = (FloatingActionButton) findViewById(R.id.delete_all);
        mDeleteAllButton.setOnClickListener(mDeleteAllListener);
        mDogButton = (FloatingActionButton) findViewById(R.id.dog_button);
        mDogButton.setOnClickListener(mDogListener);

        mFabObject = (FloatingActionMenu) findViewById(R.id.fab_object);
        mFabObject.open(true);

    }

    @Override
    protected void onStart(){
        Log.d(TAG, "onStart entered");
        super.onStart();

        mSurfaceView.setRenderMode( GLSurfaceView.RENDERMODE_CONTINUOUSLY );
        if( checkAndRequestPermissions() ){
            if( !isConnected && !isConnecting )
                bindTangoService();
        }
        setupDb();
    }

    @Override
    protected void onResume(){
        Log.d(TAG, "onResume entered");
        super.onResume();
        if( !isConnected && !isConnecting )
            bindTangoService();
        setupDb();
    }

    @Override
    protected void onPause(){
        super.onPause();
        shutdownTango();
    }

    @Override
    public void onStop(){
        Log.d(TAG, "onStop entered");
        for(GameObject obj : mRenderer.getObjectManager().getAll()){
            if(obj.getName() == "Bowl") {
                query.updateObject(application.getUUID(), DBObject.convert(obj.getObject(), obj.isPlaced()));
                Log.d(TAG, "Bowl saved" + obj.getObject().getName());
            }
            else if (obj.getName() == "Pillow"){
                query.updateObject(application.getUUID(), DBObject.convert(obj.getObject(), obj.isPlaced()));
            }
        }

        super.onStop();
        shutdownTango();
    }

    private void shutdownTango(){
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
                        TangoSupport.initialize(tango);
                        isConnected = true;
                        startupTango();
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

                    isConnecting = false;
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

    @SuppressLint("WrongConstant")
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

    private void showToast( final String content ){
        runOnUiThread(new Runnable() {
            @Override
            public void run() {
                Toast.makeText( GameActivity.this, content, Toast.LENGTH_LONG ).show();
            }
        });
    }

    @Override
    public boolean onTouch( View view, MotionEvent motionEvent ){
        Log.d( TAG, "GameActivity: onTouch(...)" );
        if( bowlWasPressed || pillowWasPressed || dogWasPressed) {
            bowlWasPressed = false;
            pillowWasPressed = false;
            dogWasPressed = false;
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

        if(TextUtils.isEmpty(mLastObjectName))
            mLastObjectName = obj.getName();
        else
            buildObjectFab(obj);
    }

    @Override
    public void onNoObjectPicked() {
        runOnUiThread(new Runnable() {
            @Override
            public void run() {
                mFabObject.setVisibility(View.GONE);
                mFabBuild.setVisibility(View.VISIBLE);
            }
        });
    }

    @Override
    public void onObjectPlaced(String name) {
        Log.d("", "entered onObjectPlaced on GameActivity");
        switch(name){
            case "Bowl":
                runOnUiThread(new Runnable() {
                    @Override
                    public void run() {
                        mBowlButton.setEnabled(false);
                    }
                });
                break;
            case "Pillow":
                runOnUiThread(new Runnable() {
                    @Override
                    public void run() {
                        mPillowButton.setEnabled(false);
                    }
                });
                break;

        }

    }

    @Override
    public void onObjectRemoved(String name) {
        Log.d(TAG, "entered onObjectRemoved on GameActivity");
        switch(name){
            case "Bowl":
                runOnUiThread(new Runnable() {
                    @Override
                    public void run() {
                        mBowlButton.setEnabled(true);
                    }
                });
                break;

            case "Pillow":
                runOnUiThread(new Runnable() {
                    @Override
                    public void run() {
                        mPillowButton.setEnabled(true);
                    }
                });
                break;
        }

    }

    // builds a Fab menu with a button for every object action(child)
    private void buildObjectFab(final GameObject obj){

        if(mLastObjectName != obj.getName()){
            mFabObject.removeAllMenuButtons();

            final FloatingActionButton deleteFab = new FloatingActionButton(this);
            deleteFab.setButtonSize(FloatingActionButton.SIZE_MINI);
            deleteFab.setLabelText(getString(R.string.delete));
            deleteFab.setImageResource(R.drawable.ic_delete_forever_white_3x);
            deleteFab.setOnClickListener(new View.OnClickListener() {
                @Override
                public void onClick(View view) {
                    mRenderer.removeFromScene(obj.getName());
                }
            });
            mFabObject.addMenuButton(deleteFab);

            for(GameObject o : obj.getChildren()) {
                final FloatingActionButton fab = new FloatingActionButton(this);
                fab.setButtonSize(FloatingActionButton.SIZE_MINI);
                fab.setLabelText(o.getName());
                fab.setImageResource(o.getThumbnailId());
                fab.setOnClickListener(new View.OnClickListener() {
                    @Override
                    public void onClick(View view) {
                        mRenderer.doChildAction(obj.getName());
                    }
                });
                mFabObject.addMenuButton(fab);
            }
        }
        else{
            runOnUiThread(new Runnable() {
                @Override
                public void run() {
                    mFabBuild.setVisibility(View.GONE);
                    mFabObject.setVisibility(View.VISIBLE);
                }
            });
        }
    }

    private void initBuildFabListeners(){
        mBowlListener = new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                mRenderer.resetPlaceState();
                if(bowlWasPressed){
                    bowlWasPressed = false;
                }
                else{
                    bowlWasPressed = true;
                    Toast.makeText(GameActivity.this, getString(R.string.place_object_notification),Toast.LENGTH_SHORT).show();
                    mRenderer.setToPlace("Bowl");
                }

            }
        };
        mPillowListener = new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                mRenderer.resetPlaceState();
                if(pillowWasPressed){
                    pillowWasPressed = false;
                    mRenderer.resetPlaceState();
                }
                else{
                    pillowWasPressed = true;
                    Toast.makeText(GameActivity.this, getString(R.string.place_object_notification),Toast.LENGTH_SHORT).show();
                    mRenderer.setToPlace("Pillow");
                }
            }
        };

        mDeleteAllListener = new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                showConfirmDeleteAlert();
            }
        };

        mDogListener = new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                mRenderer.resetPlaceState();
                if(dogWasPressed){
                    dogWasPressed = false;
                    mRenderer.resetPlaceState();
                }
                else{
                    dogWasPressed = true;
                    Toast.makeText(GameActivity.this, getString(R.string.place_object_notification),Toast.LENGTH_SHORT).show();
                    mRenderer.setToPlace("Dog");
                }
            }
        };
    }

    private void showConfirmDeleteAlert(){
        AlertDialog.Builder builder = new AlertDialog.Builder(
                this,
                R.style.AlertDialogCustom
        );

        builder.setTitle( "Do you want to delete all placed objects?" );
        builder.setPositiveButton("OK", new DialogInterface.OnClickListener() {
            @Override
            public void onClick(DialogInterface dialog, int which) {
                mRenderer.removeAllObjects();
            }
        });
        builder.setNegativeButton("Cancel", new DialogInterface.OnClickListener() {
            @Override
            public void onClick(DialogInterface dialog, int which) {
                dialog.cancel();
            }
        });

        builder.show();
    }

    private void setupDb2(){
        String currentUuid = application.getUUID();
        ArrayList<DBObject> objects = ( ArrayList ) query.getObjectsByRoom( currentUuid );
        Log.d(TAG, "setup DB entered, size DBobjects = " + objects.size());
        int listSize = objects.size();
        for( int i = 0 ; i < listSize ; i++ ){
            DBObject currentDBObject = objects.get( i );
            // get object from objectManager in Renderer
            GameObject currentGameObject = mRenderer.getObjectManager().getByName( objects.get( i ).getName() );
            if( currentGameObject != null ) {
                // set position and scale
                currentGameObject.getObject().setPosition( currentDBObject.getVec() );
                // scale...
                // add to gameScene
                mRenderer.getCurrentScene().addChild( currentGameObject.getObject() );
                //disable place object button for this object
                onObjectPlaced(currentGameObject.getName());
                Log.d(TAG, "setup DB: added object");
            }
        }
    }

    private void setupDb() {
        String currentUuid = application.getUUID();
        ArrayList<DBObject> objects = (ArrayList) query.getObjectsByRoom(currentUuid);
        Log.d(TAG, "setup DB entered, size DBobjects = " + objects.size());
        ;
        for (DBObject currentDBObject : objects) {
            // get object from objectManager in Renderer
            if (currentDBObject.isSet() && (currentDBObject.getName() == "Bowl" || currentDBObject.getName() == "Pillow")) {
                GameObject currentGameObject = mRenderer.getObjectManager().getByName(currentDBObject.getName());
                if (currentGameObject != null) {
                    // set position and scale
                    currentGameObject.getObject().setPosition(currentDBObject.getVec());
                    // scale...
                    // add to gameScene
                    mRenderer.getCurrentScene().addChild(currentGameObject.getObject());
                    //disable place object button for this object
                    onObjectPlaced(currentGameObject.getName());
                    Log.d(TAG, "setup DB: added object");
                }
            }
        }
    }
}
