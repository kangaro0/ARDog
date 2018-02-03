package de.fhws.mobcom.ardog_java.Renderers;

import android.content.Context;
import android.util.Log;
import android.view.MotionEvent;

import com.google.atap.tangoservice.TangoPoseData;
import com.google.tango.support.TangoSupport;

import org.rajawali3d.materials.Material;
import org.rajawali3d.materials.textures.ATexture;
import org.rajawali3d.materials.textures.StreamingTexture;
import org.rajawali3d.math.Matrix4;
import org.rajawali3d.math.Quaternion;
import org.rajawali3d.primitives.ScreenQuad;
import org.rajawali3d.renderer.Renderer;

import javax.microedition.khronos.opengles.GL10;

import de.fhws.mobcom.ardog_java.GameApplication;

/**
 * Created by kanga on 03.02.2018.
 */

public class AreaLearningRenderer extends Renderer {

    /* Application */
    GameApplication application;

    /* CameraTexture */
    private float[] textureCoords0 = new float[]{ 0.0F, 1.0F, 0.0F, 0.0F, 1.0F, 1.0F, 1.0F, 0.0F };

    private ATexture tangoCameraTexture;
    private boolean sceneCameraConfigured;
    private ScreenQuad backgroundQuad;

    public AreaLearningRenderer( Context application ){
        super( application );
        this.application = ( GameApplication ) application;
    }

    private static final String TAG = GameRenderer.class.getSimpleName();

    @Override
    protected void initScene() {
        Material tangoCameraMaterial = new Material();
        tangoCameraMaterial.setColorInfluence( 0 );

        if( backgroundQuad == null ) {
            backgroundQuad = new ScreenQuad();
            backgroundQuad.getGeometry().setTextureCoords( textureCoords0 );
        }

        tangoCameraTexture = new StreamingTexture( "camera", ( StreamingTexture.ISurfaceListener ) null );
        try {
            tangoCameraMaterial.addTexture(tangoCameraTexture);
            backgroundQuad.setMaterial( tangoCameraMaterial );
        } catch( ATexture.TextureException e ) {
            Log.e(TAG, "Exception creating texture for RGB camera contents", e);
        }

        getCurrentScene().addChildAt(backgroundQuad, 0 );
    }

    public void updateColorCameraTextureUvGlThread( int rotation ){
        if( backgroundQuad == null )
            backgroundQuad = new ScreenQuad();

        float[] textureCoords = TangoSupport.getVideoOverlayUVBasedOnDisplayRotation( textureCoords0, rotation );
        backgroundQuad.getGeometry().setTextureCoords( textureCoords, true );
        backgroundQuad.getGeometry().reload();
    }

    public void updateRenderCameraPose( TangoPoseData cameraPose ){
        float[] rotation = cameraPose.getRotationAsFloats();
        float[] translation = cameraPose.getTranslationAsFloats();
        Quaternion quat = new Quaternion( rotation[ 3 ], rotation[ 0 ], rotation[ 1 ], rotation[ 2 ] );
        getCurrentCamera().setRotation( quat.conjugate() );
        getCurrentCamera().setPosition( translation[ 0 ], translation[ 1 ], translation[ 2 ] );
    }

    public void setProjectionMatrix( float[] matrixFloats ){
        getCurrentCamera().setProjectionMatrix( new Matrix4( matrixFloats ) );
    }

    public int getTextureId(){
        return tangoCameraTexture == null ? -1 : tangoCameraTexture.getTextureId();
    }

    public boolean isSceneCameraConfigured(){
        return sceneCameraConfigured;
    }

    @Override
    public void onRenderSurfaceSizeChanged(GL10 gl, int width, int height ){
        super.onRenderSurfaceSizeChanged( gl, width, height );
        sceneCameraConfigured = false;
    }

    @Override
    public void onOffsetsChanged(float xOffset, float yOffset, float xOffsetStep, float yOffsetStep, int xPixelOffset, int yPixelOffset) {

    }

    @Override
    public void onTouchEvent(MotionEvent event) {

    }
}
