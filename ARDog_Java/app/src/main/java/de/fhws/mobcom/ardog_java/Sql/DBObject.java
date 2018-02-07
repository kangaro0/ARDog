package de.fhws.mobcom.ardog_java.Sql;

import org.rajawali3d.Object3D;
import org.rajawali3d.math.vector.Vector3;

/**
 * Created by Patrick on 01/02/2018.
 */

public class DBObject {

    private String name;
    private Vector3 vec;
    private double scale;
    private boolean isSet;

    public boolean isSet(){
        return this.isSet;
    }

    public boolean isSet(boolean isSet){
        return this.isSet = isSet;
    }

    public Vector3 getVec() {
        return vec;
    }

    public void setVec(Vector3 vec) {
        this.vec = vec;
    }

    public String getName() {
        return name;
    }

    public void setName(String name) {
        this.name = name;
    }

    public double getScale() {
        return scale;
    }

    public void setScale(double scale) {
        this.scale = scale;
    }

    public DBObject(String name, double x, double y, double z, double scale, boolean isSet){
        this.name = name;
        this.scale = scale;
        this.vec = new Vector3(x, y, z);
        this.isSet = isSet;
    }


    public static DBObject convert(Object3D obj, boolean isPlaced){
        DBObject db = new DBObject(obj.getName(), obj.getX(), obj.getY(), obj.getZ(), obj.getScale().x, isPlaced);
        return db;
    }
}
