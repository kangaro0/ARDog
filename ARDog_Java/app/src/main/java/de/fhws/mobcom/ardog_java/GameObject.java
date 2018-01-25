package de.fhws.mobcom.ardog_java;

import java.util.ArrayList;

import org.rajawali3d.Object3D;
import org.rajawali3d.animation.mesh.SkeletalAnimationSequence;

/**
 * Created by kanga on 21.01.2018.
 */

public class GameObject {
    // identification
    private String name;
    private int thumbnailId;    // thumbnail for selection bar

    // actual Object3D
    private Object3D object;
    private ArrayList<SkeletalAnimationSequence> sequences;
    private boolean isPlaced;

    // managing children + parents
    ArrayList<GameObject> children;
    private GameObject parent;

    // ctors
    public GameObject( String name, Object3D object ){
        this.name = name;
        this.object = object;
        this.isPlaced = false;
    }
    public GameObject( String name, Object3D object, ArrayList<GameObject> children ){
        this( name, object );
        this.children = children;
    }

    /* Getter & Setter */
    public String getName() { return this.name; }
    public int getThumbnailId() { return this.thumbnailId; }
    public Object3D getObject() { return this.object; }

    // Animations
    public ArrayList<SkeletalAnimationSequence> getSequences() { return this.sequences; }
    public void setSequences( ArrayList<SkeletalAnimationSequence> sequences ){ this.sequences = sequences; }
    public void addSequence( SkeletalAnimationSequence sequence ){
        this.sequences.add( sequence );
    }

    // Parent
    public GameObject getParent(){
        if( this.parent == null )
            return null;
        return this.parent;
    }
    public void setParent( GameObject parent ){
        this.parent = parent;
    }

    // Children
    public ArrayList<GameObject> getChildren() { return this.children; }
    public GameObject getChildByName( String name ){
        for( int i = 0 ; i < this.children.size() ; i++ ){
            GameObject current = this.children.get( i );
            if( current.getName() == name )
                return current;
        }
        return null;
    }
    public void addChild( GameObject child ){
        // set parent
        if( child.getParent() == null )
            child.setParent( this );
        // if already has parent -> don't set
        else
            return;

        this.children.add( child );
    }

    public boolean isPlaced(){
        return this.isPlaced;
    }
}
