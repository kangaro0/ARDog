package de.fhws.mobcom.ardog_java.Objects;

/**
 * Created by kanga on 03.02.2018.
 */

public class Room {
    private String name;
    private String uuid;

    public Room( String name, String uuid ){
        this.name = name;
        this.uuid = uuid;
    }

    public String getName(){ return this.name; }
    public String getUuid(){ return this.uuid; }
}
