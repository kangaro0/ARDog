package de.fhws.mobcom.ardog_java.Sql;

/**
 * Created by Patrick on 01/02/2018.
 */

public class DBRoom {


    private String uuid;
    private String name;
    
    public String getUuid() {
        return uuid;
    }

    public void setUuid(String uuid) {
        this.uuid = uuid;
    }



    public DBRoom(String uuid, String name){
        this.uuid = uuid;
        this.name = name;
    }

    public String getName() {
        return name;
    }

    public void setName(String name) {
        this.name = name;
    }


}
