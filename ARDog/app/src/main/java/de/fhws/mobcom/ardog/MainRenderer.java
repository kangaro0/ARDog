package de.fhws.mobcom.ardog;

/**
 * Created by kanga on 23.11.2017.
 */

import android.content.res.AssetManager;
import android.opengl.GLSurfaceView;

import javax.microedition.khronos.egl.EGLConfig;
import javax.microedition.khronos.opengles.GL10;

public class MainRenderer implements GLSurfaceView.Renderer {

    private AssetManager mAssetManager;

    public MainRenderer( AssetManager assetManager ) { mAssetManager = assetManager; }

    public void onDrawFrame( GL10 gl ){

    }

    public void onSurfaceChanged( GL10 gl, int witdth, int height ){

    }

    public void onSurfaceCreated( GL10 gl, EGLConfig config ){

    }
}
