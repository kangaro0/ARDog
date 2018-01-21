package de.fhws.mobcom.ardog_java;

import java.util.ArrayList;

import org.rajawali3d.Object3D;

/**
 * Created by kanga on 21.01.2018.
 */

public class GameObject {
    private String name;
    private int thumbnailId;    // thumbnail for selection bar

    // actual Object3D
    private Object3D object;

    // managing children + parents
    ArrayList<GameObject> children;
    private GameObject parent;


    GameObject( String name, Object3D object ){
        this.name = name;
        this.object = object;
    }
    GameObject( String name, Object3D object, ArrayList<GameObject> children ){
        this( name, object );
        this.children = children;
    }

    /* Getter & Setter */
    public String getName() { return this.name; }
    public int getThumbnailId() { return this.thumbnailId; }
    public Object3D getObject() { return this.object; }
    public ArrayList<GameObject> getChildren() { return this.children; }
    public GameObject getChildByName( String name ){
        for( int i = 0 ; i < this.children.size() ; i++ ){
            GameObject current = this.children.get( i );
            if( current.getName() == name )
                return current;
        }
        return null;
    }

    public void addChild( GameObject child ){ this.children.add( child ); }
}
