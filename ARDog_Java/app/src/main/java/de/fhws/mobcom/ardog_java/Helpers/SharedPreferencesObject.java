package de.fhws.mobcom.ardog_java.Helpers;

import org.rajawali3d.math.vector.Vector3;

/**
 * Created by kanga on 25.01.2018.
 */

public class SharedPreferencesObject {
    private String name;
    private Vector3 position;

    public SharedPreferencesObject( ){
        position = new Vector3( 0.0, 0.0, 0.0 );
    }

    public void setName( String name ){ this.name = name; }
    public String getName( ){ return this.name; }

    public void setPosition( Vector3 vector ){ this.position = vector; }
    public Vector3 getPosition(){ return this.position; }
}
