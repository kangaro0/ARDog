package de.fhws.mobcom.ardog_java;

import android.app.Application;
import android.content.res.Configuration;
import android.content.res.Resources;
import android.util.Log;

import org.rajawali3d.Object3D;
import org.rajawali3d.loader.LoaderOBJ;
import org.rajawali3d.loader.ParsingException;
import org.rajawali3d.materials.textures.TextureManager;

import java.util.ArrayList;

import de.fhws.mobcom.ardog_java.Callbacks.GameApplicationLoadCallback;
import de.fhws.mobcom.ardog_java.Callbacks.ObjectManagerCallback;
import de.fhws.mobcom.ardog_java.Objects.GameObject;
import de.fhws.mobcom.ardog_java.Sql.DBRoom;

/**
 * Created by kanga on 21.01.2018.
 */

public class GameApplication extends Application {
    private static final String TAG = GameApplication.class.getSimpleName();

    /* Singleton */
    private static GameApplication instance;

    /* Current ADF */
    private String uuid;
    /* Current Room */
    private DBRoom room;

    private ObjectManager objectManager;

    /* Booleans */
    private boolean firstStart;

    /* Lifecycle */
    @Override
    public void onConfigurationChanged( Configuration newConfig ){
        super.onConfigurationChanged( newConfig );
    }

    @Override
    public void onCreate(){
        super.onCreate();
        instance = this;
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
    // UUID
    public String getUUID() { return this.uuid; }
    public void setUUID( String uuid ) { this.uuid = uuid; }
    // Room
    public DBRoom getRoom(){ return this.room; }
    public void setRoom( DBRoom room ){ this.room = room; }

    public void loadAssets( final TextureManager textureManager, final GameApplicationLoadCallback callback ){
        Log.d( TAG, "GameApplication: loadAssets()" );
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
                //Object3D dogObj = dogMeshLoader.getParsedObject();
                //dogObj.setName( "Dog" );
                //GameObject dog = new GameObject( "Dog", dogObj );
                //dog.addSequence( sequence );
                //objects.add( dog );

                // Bowl
                LoaderOBJ bowlLoader = new LoaderOBJ( resources, textureManager, R.raw.bowl_obj );
                bowlLoader.parse();

                Object3D bowlObj = bowlLoader.getParsedObject();
                bowlObj.setName( "Bowl" );
                // add to collection
                GameObject bowl = new GameObject( "Bowl", bowlObj );
                // set initial properties of object
                //bowl.getObject().setScale( 1.0 );
                objects.add( bowl );

                // Bed
                LoaderOBJ bedLoader = new LoaderOBJ( resources, textureManager, R.raw.bed_obj );
                bedLoader.parse();

                Object3D bedObj = bedLoader.getParsedObject();
                bedObj.setName( "Bed" );
                GameObject bed = new GameObject( "Bed", bedObj );

                objects.add( bed );

                return objects;
            }

            @Override
            public void onDone() {
                callback.onDone();
            }

            @Override
            public void onError(Exception e) {
                callback.onError( e );
            }
        });
    }

    /* Singleton */
    public static GameApplication getInstance(){
        return GameApplication.instance;
    }
}
