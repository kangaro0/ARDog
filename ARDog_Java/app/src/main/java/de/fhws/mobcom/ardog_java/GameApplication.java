package de.fhws.mobcom.ardog_java;

import android.app.Application;
import android.content.res.Resources;
import android.util.Log;

import org.rajawali3d.loader.LoaderOBJ;
import org.rajawali3d.loader.ParsingException;
import org.rajawali3d.materials.textures.TextureManager;

import java.util.ArrayList;

import static java.security.AccessController.getContext;

/**
 * Created by kanga on 21.01.2018.
 */

public class GameApplication extends Application {
    private static final String TAG = GameApplication.class.getSimpleName();

    private ObjectManager objectManager;
    private boolean objectManagerInitialized;

    GameApplication(){
        this.objectManagerInitialized = false;
    }

    /* Getter & Setter */
    public ObjectManager getObjectManager(){
        if( !this.objectManagerInitialized )
            return null;
        return this.objectManager;
    }

    public void loadAssets( final Resources resources, final TextureManager textureManager ){
        // intialize GameObjects
        objectManager = new ObjectManager( new ObjectManagerCallback() {
            @Override
            public ArrayList<GameObject> setup() throws ParsingException {
                // loading all necessary assets is done here
                ArrayList<GameObject> objects = new ArrayList<GameObject>();

                /* Dog */
                // Mesh
                //LoaderMD5Mesh dogMeshLoader = new LoaderMD5Mesh( resources, mTextureManager, R.raw.dog );
                //dogMeshLoader.parse();
                // Animations
                //LoaderMD5Anim dogAnimLoader = new LoaderMD5Anim( resources, mTextureManager, R.raw.dog_anim );

                // Bowl
                LoaderOBJ bowlLoader = new LoaderOBJ( resources, textureManager, R.raw.bowl_obj );
                bowlLoader.parse();
                // add to collection
                objects.add( new GameObject( "Bowl", bowlLoader.getParsedObject() ) );

                return objects;
            }

            @Override
            public void onDone() {
                objectManagerInitialized = true;
            }

            @Override
            public void onError(Exception e) {
                Log.e(TAG, "Cannot parse objects", e);
            }
        });
    }


}
