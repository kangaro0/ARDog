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


/**
 * Created by Patrick on 01/02/2018.
 */
@RunWith(RobolectricTestRunner.class)
@Config(constants = BuildConfig.class)
public class DBTest {

    Context context = RuntimeEnvironment.application.getApplicationContext();
    ARDogDbHelper adHelper = new ARDogDbHelper(context);
    ARDogQuery adQuery = new ARDogQuery(adHelper);



    @Test
    public void testAddRoom(){
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
    public void testAddObjectToRoom(){
        DBObject obj1 = new DBObject("DBObject1", 1.0, 2.0, 3.0);
        DBObject obj2 = new DBObject("DBObject2", 1.0, 2.0, 3.0);
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
}
