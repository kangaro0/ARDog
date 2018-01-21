package de.fhws.mobcom.ardog_java;

/**
 * Created by kanga on 19.01.2018.
 */

import com.google.atap.tangoservice.TangoPoseData;
import com.google.tango.support.TangoSupport;

import android.content.Context;

import android.content.Loader;
import android.content.res.Resources;
import android.support.annotation.NonNull;
import android.util.Log;
import android.view.MotionEvent;
import android.view.animation.LinearInterpolator;

import org.rajawali3d.Object3D;
import org.rajawali3d.animation.Animation;
import org.rajawali3d.animation.Animation3D;
import org.rajawali3d.animation.EllipticalOrbitAnimation3D;
import org.rajawali3d.animation.RotateOnAxisAnimation;
import org.rajawali3d.animation.mesh.SkeletalAnimationObject3D;
import org.rajawali3d.animation.mesh.SkeletalAnimationSequence;
import org.rajawali3d.lights.DirectionalLight;
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
import org.rajawali3d.primitives.Sphere;
import org.rajawali3d.renderer.Renderer;
import org.rajawali3d.util.ObjectColorPicker;
import org.rajawali3d.util.OnObjectPickedListener;

import java.util.ArrayList;

import javax.microedition.khronos.opengles.GL10;

import de.fhws.mobcom.ardog_java.ObjectManager;

public class GameRenderer extends Renderer implements OnObjectPickedListener {
    private static final String TAG = GameRenderer.class.getSimpleName();

    private float[] textureCoords0 = new float[]{ 0.0F, 1.0F, 0.0F, 0.0F, 1.0F, 1.0F, 1.0F, 0.0F };

    private ATexture mTangoCameraTexture;
    private boolean mSceneCameraConfigured;
    private ScreenQuad mBackgroundQuad;
    private ObjectColorPicker mOnePicker;

    private ObjectManager objectManager;

    private SkeletalAnimationObject3D mDog;

    public GameRenderer( Context context ){
        super( context );
    }

    @Override
    protected void initScene(){

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

        // Add a directional light in an arbitrary direction.
        DirectionalLight light = new DirectionalLight(1, 0.2, -1);
        light.setColor(1, 1, 1);
        light.setPower(0.8f);
        light.setPosition(3, 2, 4);
        getCurrentScene().addLight(light);

        // load model
        try {
            LoaderMD5Mesh meshParser = new LoaderMD5Mesh( this,
                    R.raw.boblampclean_mesh );
            meshParser.parse();

            LoaderMD5Anim animParser = new LoaderMD5Anim( "attack2", this,
                    R.raw.boblampclean_anim );
            animParser.parse();

            SkeletalAnimationSequence sequence = ( SkeletalAnimationSequence ) animParser.getParsedAnimationSequence();

            // add model
            mDog = ( SkeletalAnimationObject3D ) meshParser.getParsedAnimationObject();
            mDog.setAnimationSequence( sequence );
            mDog.setPosition( 0, 0, -30 );
            mDog.setScale( .5f );
            mDog.setRotation( Vector3.Axis.Y, 90 );
            mDog.setRotation( Vector3.Axis.Z, -90 );
            mDog.play();

            getCurrentScene().addChild( mDog );

        } catch( ParsingException e ){
            e.printStackTrace();
        }

        mOnePicker.registerObject( mBackgroundQuad );
        if( mDog != null )
            mOnePicker.registerObject( mDog );
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
    }

    @Override
    public void onNoObjectPicked(){
        Log.d(TAG, "Picked no object.");
    }

}
