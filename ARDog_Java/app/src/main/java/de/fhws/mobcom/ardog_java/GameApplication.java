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
    // UUID
    public String getUUID() { return this.uuid; }
    public void setUUID( String uuid ) { this.uuid = uuid; }
    // Room
    public DBRoom getRoom(){ return this.room; }
    public void setRoom( DBRoom room ){ this.room = room; }


    /* Singleton */
    public static GameApplication getInstance(){
        return GameApplication.instance;
    }
}
