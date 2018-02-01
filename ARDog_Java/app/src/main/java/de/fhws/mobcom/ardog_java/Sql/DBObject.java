package de.fhws.mobcom.ardog_java.Sql;

import org.rajawali3d.math.vector.Vector3;

import java.util.Vector;

/**
 * Created by Patrick on 01/02/2018.
 */

public class DBObject {

    String name;
    Vector3 vec;

    public String getName() {
        return name;
    }

    public void setName(String name) {
        this.name = name;
    }



    public DBObject(String name, Double x, Double y, Double z){
        this.name = name;
        this.vec = new Vector3(x, y, z);
    }

}
