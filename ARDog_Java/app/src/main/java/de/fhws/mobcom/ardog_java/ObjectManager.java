package de.fhws.mobcom.ardog_java;

import java.util.ArrayList;
import java.util.Observable;

import org.rajawali3d.loader.ParsingException;

import de.fhws.mobcom.ardog_java.Callbacks.ObjectManagerCallback;

/**
 * Created by kanga on 21.01.2018.
 * Singleton-Class for managing 3D-objects available in scene.
 */

public class ObjectManager {
    // TAG for logcat
    private static final String TAG = ObjectManager.class.getSimpleName();

    // Singleton Instance
    private static ObjectManager instance;

    // ArrayList for holding the 3D-objects
    private ArrayList<GameObject> objects;
    private GameObject curSelected;

    // ctor
    public ObjectManager( final ObjectManagerCallback callback ){
        new Runnable(){
            @Override
            public void run(){
                try {
                    objects = callback.setup();
                } catch ( ParsingException e ) {
                    callback.onError( e );
                }
                callback.onDone();
            }
        };
    }

    /* Public Interface */

    // currently selected
    public GameObject getCurrentlySelected(){
        return this.curSelected;
    }
    public void setCurrentlySelected( String name ){
        if( name == null ) {
            // deselect item
            this.curSelected = null;
            return;
        } else {
            this.curSelected = this.getByName( name );
            // if currently selected make it a little lighter
            // not implemented...
        }
    }
    public boolean isCurrentlySelected(){
        if( this.curSelected == null )
            return false;
        return true;
    }

    // access to game-objects
    public ArrayList<GameObject> getAll(){
        return this.objects;
    }
    public GameObject getByName( String name ){
        for( int i = 0 ; i < this.objects.size() ; i++ ){
            GameObject current = this.objects.get( i );
            if( current.getName() == name )
                return current;
        }
        return null;
    }
    public ArrayList<GameObject> getPlacedObjects(){
        ArrayList<GameObject> toReturn = new ArrayList<GameObject>();
        for( GameObject current : this.objects ){
            if( current.isPlaced() )
                toReturn.add( current );
        }
        return toReturn;
    }
}