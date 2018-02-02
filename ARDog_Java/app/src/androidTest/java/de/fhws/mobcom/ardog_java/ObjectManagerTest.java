package de.fhws.mobcom.ardog_java;

import android.support.test.runner.AndroidJUnit4;
import static org.junit.Assert.*;

import de.fhws.mobcom.ardog_java.Callbacks.ObjectManagerCallback;
import de.fhws.mobcom.ardog_java.ObjectManager;
import de.fhws.mobcom.ardog_java.GameObject;

import org.junit.Test;
import org.junit.runner.RunWith;
import org.rajawali3d.Object3D;
import org.rajawali3d.loader.ParsingException;

import java.util.ArrayList;
import java.util.concurrent.CountDownLatch;

/**
 * Created by kanga on 01.02.2018.
 */

@RunWith(AndroidJUnit4.class)
public class ObjectManagerTest {
    final CountDownLatch signal = new CountDownLatch(1);

    @Test
    public void initialize(){
        ObjectManager objectManager = new ObjectManager(new ObjectManagerCallback() {
            @Override
            public ArrayList<GameObject> setup() throws ParsingException {
                ArrayList<GameObject> toReturn = new ArrayList<GameObject>();

                // init object
                Object3D obj = new Object3D( );
                GameObject gObj = new GameObject( "Test", obj, null );

                // add to list
                toReturn.add( gObj );

                return toReturn;
            }

            @Override
            public void onDone() {
                signal.countDown();
            }

            @Override
            public void onError(Exception e) {

            }
        });

        signal.await();

        assertEquals( );
    }
}
