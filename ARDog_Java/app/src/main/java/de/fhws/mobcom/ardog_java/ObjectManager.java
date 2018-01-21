package de.fhws.mobcom.ardog_java;

import android.content.res.Resources;

import java.util.ArrayList;
import java.util.HashMap;
import java.util.Observable;
import java.util.Observer;

import org.rajawali3d.Object3D;
import org.rajawali3d.renderer.Renderer;

import de.fhws.mobcom.ardog_java.GameObject.GameObject;

/**
 * Created by kanga on 21.01.2018.
 * Singleton-Class for managing 3D-objects available in scene.
 */

public class ObjectManager extends Observable {
    // TAG for logcat
    private static final String TAG = ObjectManager.class.getSimpleName();

    // Singleton Instance
    private static ObjectManager instance;

    // ArrayList for holding the 3D-objects
    private ArrayList<GameObject> objects;
    private Object3D curSelected;

    // private ctor
    private ObjectManager(){
        this.objects = new ArrayList<GameObject>();
        // initialize all possible objects here..
    }

    /* Private Interface */

    // setup ObjectManager, loads asset
    private void setup(final Resources resources, final Renderer mRenderer ){
        // check if there are any observers to notify
        if( super.countObservers() < 1 )
            return;
        // run loading in new Runnable
        new Runnable(){
            @Override
            public void run(){
                for( GameObject obj : objects ){
                    switch( obj.getName() ){

                        // dog requires different loading ( md5-mesh & -animations )
                        case "Dog":

                            break;
                        // the rest is just obj
                        default:

                            break;
                    }
                }

                // notify Observers when finished loading
                this.notify();
            }
        };
    }

    /* Public Interface */

    public Object3D getCurrentlySelected(){
        return this.curSelected;
    }

    public void setCurrentlySelected( ObjectType type ){
        if( type == null ) {
            // deselect item
            this.curSelected = null;
            return;
        } else {
            this.curSelected = this.objects.get(type);
            // if currently selected make it a little lighter
            // not implemented...
        }
    }

    public boolean isCurrentlySelected(){
        if( this.curSelected == null )
            return false;
        return true;
    }

    // Singleton
    public static ObjectManager getInstance( ){
        if( ObjectManager.instance == null )
            ObjectManager.instance = new ObjectManager();
        return ObjectManager.instance;
    }

    // Observable
    public void registerObserver( Observer observer ){
        this.addObserver( observer );
    }

    public void unregisterObserver( Observer observer ){
        this.deleteObserver( observer );
    }
}
