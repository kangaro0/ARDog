package de.fhws.mobcom.ardog;

/**
 * Created by kanga on 23.11.2017.
 */

import android.app.Activity;
import android.content.res.AssetManager;
import android.os.IBinder;
import android.util.Log;

import com.projecttango.examples.cpp.util.TangoInitializationHelper;

public class JNINative {
    static {
        if( TangoInitializationHelper.loadTangoSharedLibrary() ==
                TangoInitializationHelper.ARCH_ERROR ){
            Log.e("JNINative", "ERRROR! Unable to load libtango_client_api.so!");
        }
        System.loadLibrary( "native-lib");
    }

    public static native void onCreate( Activity callerActivity, int activityOrientation );

    public static native void onTangoServiceConnected( IBinder nativeTangoServiceBinder );

    public static native void onPause();

    public static native void onDestroy();

    public static native void onGlSurfaceCreated( AssetManager assetManager );

    public static native void onGlSurfaceChanges( int width, int height );

    public static native void onGlSurfaceDrawFrame();

    public static native void onConfigurationChanged( int displayOrientation );
}
