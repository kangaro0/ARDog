package de.fhws.mobcom.ardog_java.Renderers;

/**
 * Created by kanga on 19.01.2018.
 */

import com.google.atap.tangoservice.TangoPoseData;
import com.google.tango.support.TangoSupport;

import android.content.Context;

import android.support.annotation.NonNull;
import android.util.Log;
import android.view.MotionEvent;
import android.view.animation.AnimationSet;
import android.widget.Toast;

import org.rajawali3d.Object3D;
import org.rajawali3d.animation.mesh.SkeletalAnimationObject3D;
import org.rajawali3d.animation.mesh.SkeletalAnimationSequence;
import org.rajawali3d.animation.mesh.VertexAnimationObject3D;
import org.rajawali3d.lights.DirectionalLight;
import org.rajawali3d.loader.LoaderMD2;
import org.rajawali3d.loader.LoaderOBJ;
import org.rajawali3d.loader.ParsingException;
import org.rajawali3d.loader.md5.LoaderMD5Anim;
import org.rajawali3d.loader.md5.LoaderMD5Mesh;
import org.rajawali3d.materials.Material;
import org.rajawali3d.materials.methods.DiffuseMethod;
import org.rajawali3d.materials.textures.ATexture;
import org.rajawali3d.materials.textures.StreamingTexture;
import org.rajawali3d.materials.textures.Texture;
import org.rajawali3d.math.Matrix4;
import org.rajawali3d.math.Quaternion;
import org.rajawali3d.math.vector.Vector3;
import org.rajawali3d.primitives.ScreenQuad;
import org.rajawali3d.renderer.Renderer;
import org.rajawali3d.util.ObjectColorPicker;
import org.rajawali3d.util.OnObjectPickedListener;

import java.util.ArrayList;

import javax.microedition.khronos.opengles.GL10;

import de.fhws.mobcom.ardog_java.GameApplication;
import de.fhws.mobcom.ardog_java.Helpers.MathHelper;
import de.fhws.mobcom.ardog_java.ObjectManager;
import de.fhws.mobcom.ardog_java.Objects.GameObject;
import de.fhws.mobcom.ardog_java.Callbacks.GameRendererCallback;
import de.fhws.mobcom.ardog_java.R;

public class GameRenderer extends Renderer implements OnObjectPickedListener {
    private static final String TAG = GameRenderer.class.getSimpleName();

    private float[] textureCoords0 = new float[]{ 0.0F, 1.0F, 0.0F, 0.0F, 1.0F, 1.0F, 1.0F, 0.0F };

    private ATexture mTangoCameraTexture;
    private boolean mSceneCameraConfigured;
    private ScreenQuad mBackgroundQuad;
    private DirectionalLight mDirLight;
    private ObjectColorPicker mOnePicker;

    private GameObject toBePlaced;
    private Vector3 touchPoint;
    private boolean hasTouched = false;
    private boolean hasPlacedDog = false;

    private GameApplication application;
    private GameRendererCallback callback;
    private ObjectManager objectManager;

    public GameRenderer( Context context, GameRendererCallback rendererCallback ){
        super( context );
        application = ( GameApplication ) context.getApplicationContext();
        callback = rendererCallback;

        setMaxLights( 100 );
    }

    /* Getter & Setter */
    public ObjectManager getObjectManager(){ return this.objectManager; }

    @Override
    protected void initScene(){

        initializeObjects();

        mOnePicker = new ObjectColorPicker( this );
        mOnePicker.setOnObjectPickedListener( this );

        Material tangoCameraMaterial = new Material();
        tangoCameraMaterial.setColorInfluence( 0 );

        if( mBackgroundQuad == null ) {
            mBackgroundQuad = new ScreenQuad();
            mBackgroundQuad.getGeometry().setTextureCoords( textureCoords0 );
        }

        mTangoCameraTexture = new StreamingTexture( "camera", ( StreamingTexture.ISurfaceListener ) null );
        try {
            tangoCameraMaterial.addTexture( mTangoCameraTexture );
            mBackgroundQuad.setMaterial( tangoCameraMaterial );
        } catch( ATexture.TextureException e ) {
            Log.e(TAG, "Exception creating texture for RGB camera contents", e);
        }

        getCurrentScene().addChildAt( mBackgroundQuad, 0 );
        mOnePicker.registerObject( mBackgroundQuad );

        // Add a directional light in an arbitrary direction.
        mDirLight = new DirectionalLight(1, 0.2, -1);
        mDirLight.setColor(1, 1, 1);
        mDirLight.setPower(0.8f);
        getCurrentScene().addLight(mDirLight);

        // Get places objects from objectManager
        ArrayList<GameObject> objects = objectManager.getPlacedObjects();
        for( GameObject current : objects ){
            Object3D curObject = current.getObject();
            // add to Scene and register in ObjectPicker
            getCurrentScene().addChild( curObject );
            mOnePicker.registerObject( curObject );
        }
        callback.onRendererResume();

    }

    private void initializeObjects( ){
        Log.d( TAG, "GameActivity: initializeApp()" );
        objectManager = new ObjectManager();

        try {

            // Dog
            /*
            LoaderMD5Mesh dogLoader = new LoaderMD5Mesh( this, R.raw.dog );
            dogLoader.parse();

            LoaderMD5Anim dogWalkLoader = new LoaderMD5Anim( "Walk", this, R.raw.dog_walk );
            dogWalkLoader.parse();

            SkeletalAnimationSequence walkSequence = ( SkeletalAnimationSequence ) dogWalkLoader.getParsedAnimationSequence();

            SkeletalAnimationObject3D dog = ( SkeletalAnimationObject3D ) dogLoader.getParsedAnimationObject();

            GameObject dogObj = new GameObject( "Dog", dog );
            dogObj.addSequence( walkSequence );

            objectManager.add( dogObj );
            */

            LoaderOBJ dogLoader = new LoaderOBJ( getContext().getResources(), mTextureManager, R.raw.dog );
            dogLoader.parse();

            Object3D dogObj = dogLoader.getParsedObject();
            dogObj.setName( "Dog" );

            GameObject dog = new GameObject( "Dog", dogObj );
            objectManager.add( dog );

            // Bowl
            LoaderOBJ bowlLoader = new LoaderOBJ( getContext().getResources(), mTextureManager, R.raw.dog_bowl_obj );
            bowlLoader.parse();

            Object3D bowlObj = bowlLoader.getParsedObject();
            bowlObj.setName( "Bowl" );
            // add to collection
            GameObject bowl = new GameObject("Bowl", bowlObj );
            // set initial properties of object
            //bowl.getObject().setScale( 1.0 );
            objectManager.add( bowl );
            // for test
            //toBePlaced = bowl;

            // Pillow
            LoaderOBJ pillowLoader = new LoaderOBJ( getContext().getResources(), mTextureManager, R.raw.pillow_obj );
            pillowLoader.parse();

            Object3D pillowObj = pillowLoader.getParsedObject();
            pillowObj.setName( "Pillow" );
            GameObject bed = new GameObject( "Pillow", pillowObj );

            objectManager.add( bed );
        } catch( ParsingException e ) {
            Log.e(TAG, "Error while parsing objects.", e);
        }
    }

    @Override
    protected void onRender( long elapsedRealTime, double deltaTime ){
        synchronized ( GameRenderer.this ){
            super.onRender( elapsedRealTime, deltaTime );

            if( hasTouched && toBePlaced != null ){
                // render click
                Object3D obj = toBePlaced.getObject();
                obj.setPosition( touchPoint );
                obj.setScale( calculateScale( obj.getName() ) );
                objectManager.getByName( toBePlaced.getName() ).setPlaced( true );

                // enable lighting
                Material objMaterial = obj.getMaterial();
                if( objMaterial != null ){
                    objMaterial.enableLighting( true );
                    objMaterial.setDiffuseMethod( new DiffuseMethod.Lambert() );
                }
                for( int i = 0 ; i < obj.getNumChildren() ; i++ ){
                    Material curMaterial = obj.getChildAt( i ).getMaterial();
                    curMaterial.enableLighting( true );
                    curMaterial.setDiffuseMethod( new DiffuseMethod.Lambert() );
                }

                // add light for object
                DirectionalLight objLight = new DirectionalLight( touchPoint.x, touchPoint.y + 5, touchPoint.z );
                objLight.resetToLookAt( touchPoint );
                objLight.setColor( 1.0f, 1.0f, 1.0f );
                objLight.setPower( 0.8f );

                toBePlaced.setLight( objLight );
                getCurrentScene().addLight( objLight );

                getCurrentScene().addChild( obj );
                mOnePicker.registerObject( obj );

                resetPlaceState();

                Log.d(TAG, "before onObjectPlaced callback");
                callback.onObjectPlaced(obj.getName());
                Log.d(TAG, "onObjectPlaced callback called");
            }
        }
    }

    public void updateColorCameraTextureUvGlThread( int rotation ){
        if( mBackgroundQuad == null )
            mBackgroundQuad = new ScreenQuad();

        float[] textureCoords = TangoSupport.getVideoOverlayUVBasedOnDisplayRotation( textureCoords0, rotation );
        mBackgroundQuad.getGeometry().setTextureCoords( textureCoords, true );
        mBackgroundQuad.getGeometry().reload();
    }

    public void updateRenderCameraPose( TangoPoseData cameraPose ){
        float[] rotation = cameraPose.getRotationAsFloats();
        float[] translation = cameraPose.getTranslationAsFloats();
        Quaternion quat = new Quaternion( rotation[ 3 ], rotation[ 0 ], rotation[ 1 ], rotation[ 2 ] );
        getCurrentCamera().setRotation( quat.conjugate() );
        getCurrentCamera().setPosition( translation[ 0 ], translation[ 1 ], translation[ 2 ] );
    }

    public int getTextureId(){
        return mTangoCameraTexture == null ? -1 : mTangoCameraTexture.getTextureId();
    }

    @Override
    public void onRenderSurfaceSizeChanged( GL10 gl, int width, int height ){
        super.onRenderSurfaceSizeChanged( gl, width, height );
        mSceneCameraConfigured = false;
    }

    public boolean isSceneCameraConfigured(){
        return mSceneCameraConfigured;
    }

    public void setProjectionMatrix( float[] matrixFloats ){
        getCurrentCamera().setProjectionMatrix( new Matrix4( matrixFloats ) );
    }

    @Override
    public void onOffsetsChanged( float xOffset, float yOffset,
                                 float xOffsetStep, float yOffsetStep,
                                 int xPixelOffset, int yPixelOffset ){
    }

    @Override
    public void onTouchEvent( MotionEvent event ){
        if( event.getAction() == MotionEvent.ACTION_DOWN ){
            Log.d(TAG, "Pick object attempt");
            mOnePicker.getObjectAt( event.getX(), event.getY() );
        }
    }

    @Override
    public void onObjectPicked( @NonNull Object3D object ){
        Log.d(TAG, "Picked object: " + object );
        GameObject picked = objectManager.getByObject3D( object );
        if( picked != null )
            callback.onObjectPicked( picked );
    }

    @Override
    public void onNoObjectPicked(){
        callback.onNoObjectPicked();
        Log.d(TAG, "Picked no object.");
    }

    public void showTouch( Vector3 point ){
        if( point != null ) {
            touchPoint = point;
            hasTouched = true;
        }
    }

    public void setToPlace( String name ) {
        synchronized (GameRenderer.this) {
            this.toBePlaced = objectManager.getByName(name);
        }
    }

    public void resetPlaceState(){
        this.toBePlaced = null;
        this.touchPoint = null;
        this.hasTouched = false;
    }

    // Remove given object from scene
    public void removeFromScene(String name){
        getCurrentScene().removeChild(objectManager.getByName(name).getObject());
        objectManager.getByName(name).setPlaced(false);
        callback.onObjectRemoved(name);
    }

    // Placeholder for GameObject Child Action (e.g feed dog with bowl)
    public void doChildAction(String name){}

    // Remove all placed objects from scene
    public void removeAllObjects() {
        for(GameObject obj : objectManager.getPlacedObjects()){
            getCurrentScene().removeChild( obj.getObject() );
            getCurrentScene().removeLight( obj.getLight() );
            objectManager.getByName(obj.getName()).setPlaced(false);
            callback.onObjectRemoved(obj.getName());
        }

        Log.d(TAG, "remove all objects entered");
    }

    private double calculateScale( String name ){
        double depth = touchPoint.z;
        switch( name ){
            case "Bowl":
                return MathHelper.clampMax( MathHelper.clampMin( 0.1 / ( (-1) * depth * 5 ) ,0.02 ), 0.05 );
            case "Pillow":
                return MathHelper.clampMax( MathHelper.clampMin( 0.1 / (-1) * depth * 5, 0.02 ), 0.05 );
            case "Dog":
                return MathHelper.clampMax( MathHelper.clampMin( 0.1 / (-1) * depth * 5, 0.02 ), 0.05 );
        }
        return 0.0;
    }
}
