package de.fhws.mobcom.ardog_java;

import android.app.Application;
import android.content.Context;
import android.content.SharedPreferences;
import android.content.res.Configuration;
import android.content.res.Resources;
import android.graphics.Bitmap;
import android.util.Log;

import org.rajawali3d.loader.LoaderOBJ;
import org.rajawali3d.loader.ParsingException;
import org.rajawali3d.materials.textures.TextureManager;

import java.util.ArrayList;
import java.util.Map;

import static java.security.AccessController.getContext;

/**
 * Created by kanga on 21.01.2018.
 */

public class GameApplication extends Application {
    private static final String TAG = GameApplication.class.getSimpleName();

    /* Singleton */
    private static GameApplication instance;

    private ObjectManager objectManager;
    private SharedPreferences sharedPreferences;

    /* Lifecycle */
    @Override
    public void onConfigurationChanged( Configuration newConfig ){
        super.onConfigurationChanged( newConfig );
    }

    @Override
    public void onCreate(){
        super.onCreate();
        instance = this;

        // get reference to SharedPreferences
        this.sharedPreferences = getSharedPreferences( getString( R.string.shared_preferences_key ), Context.MODE_PRIVATE );
        this.setupSharedPreferences();
    }

    @Override
    public void onLowMemory(){
        super.onLowMemory();
    }

    @Override
    public void onTerminate(){
        super.onTerminate();
    }

    /* Getter & Setter */
    public ObjectManager getObjectManager(){
        return this.objectManager;
    }

    public void loadAssets( final Resources resources, final TextureManager textureManager ){
        // intialize GameObjects
        objectManager = new ObjectManager( new ObjectManagerCallback() {
            @Override
            public ArrayList<GameObject> setup() throws ParsingException {
                // loading all necessary assets is done here
                ArrayList<GameObject> objects = new ArrayList<GameObject>();
                // Get resources from Context
                Resources resources = getResources();

                /* Dog */
                // Mesh
                //LoaderMD5Mesh dogMeshLoader = new LoaderMD5Mesh( resources, mRenderer.getTextureManager(), R.raw.dog );
                //dogMeshLoader.parse();
                // Animations
                //LoaderMD5Anim dogAnimLoader = new LoaderMD5Anim( resources, mRenderer.getTextureManager(), R.raw.dog_anim );
                //dogAnimLoader.parse();
                //SkeletalAnimationSequence sequence = ( SkeletalAnimationSequence ) dogAnimLoader.getParsedAnimationSequence();
                // setup GameObject
                //GameObject dog = new GameObject( "Dog", dogMeshLoader.getParsedObject() );
                //dog.addSequence( sequence );
                //objects.add( dog );

                // Bowl
                LoaderOBJ bowlLoader = new LoaderOBJ( resources, textureManager, R.raw.bowl_obj );
                bowlLoader.parse();
                // add to collection
                GameObject bowl = new GameObject( "Bowl", bowlLoader.getParsedObject() );
                // set initial properties of object
                //bowl.getObject().setScale( 1.0 );
                objects.add( bowl );

                // Bed
                LoaderOBJ bedLoader = new LoaderOBJ( resources, textureManager, R.raw.bed_obj );
                bedLoader.parse();
                GameObject bed = new GameObject( "Bed", bedLoader.getParsedObject() );

                objects.add( bed );

                return objects;
            }

            @Override
            public void onDone() {
                // load SharedPreferences

            }

            @Override
            public void onError(Exception e) {
                Log.e(TAG, "Cannot parse objects", e);
            }
        });
    }

    /* Sets up keys in SharedPreferences if they do not exist */
    public boolean setupSharedPreferences(){
        return true;
    }

    public static GameApplication getInstance(){
        return GameApplication.instance;
    }
}
