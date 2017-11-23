package de.fhws.mobcom.ardog;

import android.app.Activity;
import android.app.Service;
import android.content.ComponentName;
import android.content.ServiceConnection;
import android.content.res.Configuration;
import android.graphics.Point;
import android.hardware.Camera;
import android.opengl.GLSurfaceView;
import android.os.Bundle;
import android.os.IBinder;
import android.view.Display;
import android.view.WindowManager;

import com.projecttango.examples.cpp.util.TangoInitializationHelper;

public class MainActivity extends Activity {

    private MainRenderer mRenderer;
    private GLSurfaceView mGLView;

    private Point mScreenSize = new Point();

    ServiceConnection mTangoServiceConnection = new ServiceConnection(){
        @Override
        public void onServiceConnected( ComponentName name, IBinder service ){
            JNINative.onTangoServiceConnected( service );
        }
        @Override
        public void onServiceDisconnected( ComponentName name ){
            // ...
        }
    };

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);

        WindowManager windowManager = (WindowManager) getSystemService(WINDOW_SERVICE);
        Display display = windowManager.getDefaultDisplay();
        display.getSize(mScreenSize);

        JNINative.onCreate(this, display.getRotation());

        getWindow().setFlags(WindowManager.LayoutParams.FLAG_FULLSCREEN,
                WindowManager.LayoutParams.FLAG_FULLSCREEN);

        // Setting content view of this activity and getting the mIsAutoRecovery
        // flag from StartActivity.
        setContentView(R.layout.activity_augmented_reality);

        // OpenGL view where all of the graphics are drawn
        mGLView = (GLSurfaceView) findViewById(R.id.gl_surface_view);

        // Configure OpenGL renderer
        mGLView.setEGLContextClientVersion(2);

        // Configure OpenGL renderer. The RENDERMODE_WHEN_DIRTY is set explicitly
        // for reducing the CPU load. The request render function call is triggered
        // by the onTextureAvailable callback from the Tango Service in the native
        // code.
        mRenderer = new MainRenderer(getAssets());
        mGLView.setRenderer(mRenderer);
    }

    @Override
    protected void onResume() {
        super.onResume();
        mGLView.onResume();

        mGLView.setRenderMode(GLSurfaceView.RENDERMODE_CONTINUOUSLY);

        TangoInitializationHelper.bindTangoService(this, mTangoServiceConnection);
    }

    @Override
    protected void onPause() {
        super.onPause();
        mGLView.onPause();

        JNINative.onPause();
        unbindService(mTangoServiceConnection);
    }

    @Override
    protected void onDestroy() {
        super.onDestroy();
        JNINative.onDestroy();
    }

    @Override
    public void onConfigurationChanged(Configuration newConfig) {
        super.onConfigurationChanged(newConfig);

        WindowManager windowManager = (WindowManager) getSystemService(WINDOW_SERVICE);
        Display display = windowManager.getDefaultDisplay();
        display.getSize(mScreenSize);

        JNINative.onConfigurationChanged(display.getRotation());
    }

    public void requestRender() {
        if (mGLView.getRenderMode() != GLSurfaceView.RENDERMODE_CONTINUOUSLY) {
            mGLView.setRenderMode(GLSurfaceView.RENDERMODE_WHEN_DIRTY);
        }
        mGLView.requestRender();
    }
}
