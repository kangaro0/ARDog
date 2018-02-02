package de.fhws.mobcom.ardog_java;

import android.content.Context;

import org.junit.Test;
import org.junit.runner.RunWith;
import org.robolectric.RobolectricTestRunner;
import org.robolectric.RuntimeEnvironment;
import org.robolectric.annotation.Config;

import java.util.ArrayList;

import de.fhws.mobcom.ardog_java.Sql.ARDogDbHelper;
import de.fhws.mobcom.ardog_java.Sql.ARDogQuery;
import de.fhws.mobcom.ardog_java.Sql.DBObject;
import de.fhws.mobcom.ardog_java.Sql.DBRoom;

import static org.junit.Assert.assertEquals;
import static org.junit.Assert.assertNull;


/**
 * Created by Patrick on 01/02/2018.
 */
@RunWith(RobolectricTestRunner.class)
@Config(constants = BuildConfig.class)
public class DBTest {

    Context context = RuntimeEnvironment.application.getApplicationContext();
    ARDogDbHelper adHelper = new ARDogDbHelper(context);
    ARDogQuery adQuery = new ARDogQuery(adHelper);
    DBObject obj1 = new DBObject("DBObject1", 1.0, 2.0, 3.0);
    DBObject obj2 = new DBObject("DBObject2", 1.0, 2.0, 3.0);
    DBObject objUpdate2 = new DBObject("DBObject2", 2.0, 2.0, 3.0);


    @Test
    public void testAddAndGetRoom(){
        adQuery.addRoom("1", "Raum 1");
        adQuery.addRoom("2", "Raum 2");
        adQuery.addRoom("3", "Raum 3");
        adQuery.addRoom("4", "Raum 4");

        DBRoom room = adQuery.getRoom("Raum 1");
        System.out.println(room.getName());
        assertEquals(room.getUuid(), "1");

        ArrayList<DBRoom> rooms = (ArrayList) adQuery.getRooms();
        assertEquals(rooms.size(), 4);
        assertEquals(rooms.get(3).getUuid(), "4" );
    }

    @Test
    public void testAddObjectToRoomAndGetObjectsByRoom(){

        adQuery.addObjectToRoom("1", obj1);
        adQuery.addObjectToRoom("1", obj2);

        ArrayList<DBObject> objList = (ArrayList) adQuery.getObjectsByRoom("1");
        assertEquals(objList.size(), 2);
        assertEquals(objList.get(0).getName(), obj1.getName() );
        assertEquals(objList.get(1).getName(), obj2.getName() );

        adQuery.addObjectToRoom("1", obj1);
        ArrayList<DBObject> objList2 = (ArrayList) adQuery.getObjectsByRoom("1");
        assertEquals(objList2.size(), 2);
    }

    @Test
    public void testDeleteRoom(){
        adQuery.deleteRoom("1");
        DBRoom room = adQuery.getRoom("Raum 1");
        assertNull(room);

        ArrayList<DBObject> objList = (ArrayList) adQuery.getObjectsByRoom("1");
        assertEquals(objList.size(), 0);
    }

    @Test
    public void testUpdateObject(){
        adQuery.addObjectToRoom("2", obj1);
        adQuery.addObjectToRoom("2", obj2);
        ArrayList<DBObject> objList = (ArrayList) adQuery.getObjectsByRoom("2");
        assertEquals(objList.get(1).getVec().x , 1.0, 0.1);

        adQuery.updateObject("2", objUpdate2);
        ArrayList<DBObject> objList2 = (ArrayList) adQuery.getObjectsByRoom("2");
        assertEquals(objList2.get(1).getVec().x , 2.0, 0.1);
    }

    @Test
    public void testUpdateRoomByUuid(){
        adQuery.addRoom("3", "Raum 3");
        DBRoom room = adQuery.getRoom("Raum 3");
        assertEquals(room.getUuid(), "3");

        String roomNameUpdated = "Raum 3 updated";
        adQuery.updateRoomByUuid("3", roomNameUpdated);
        DBRoom roomUpdated = adQuery.getRoom(roomNameUpdated);

        assertEquals(room.getUuid(), roomUpdated.getUuid());
        assertEquals(roomNameUpdated, roomUpdated.getName());
    }

    @Test
    public void testUpdateRoomByName(){
        String roomName = "Raum 4";
        String roomNameUpdated = "Raum 4 updated";
        adQuery.addRoom("4", roomName);
        DBRoom room = adQuery.getRoom(roomName);
        assertEquals(room.getUuid(), "4");

        adQuery.updateRoomByName(roomName, roomNameUpdated);
        DBRoom roomUpdated = adQuery.getRoom(roomNameUpdated);

        assertEquals(room.getUuid(), roomUpdated.getUuid());
        assertEquals(roomNameUpdated, roomUpdated.getName());
    }
}
