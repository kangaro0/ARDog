package de.fhws.mobcom.ardog_java.Callbacks;

import java.util.ArrayList;

import org.rajawali3d.loader.ParsingException;

import de.fhws.mobcom.ardog_java.Objects.GameObject;

/**
 * Created by kanga on 21.01.2018.
 */

public interface ObjectManagerCallback {
    public ArrayList<GameObject> setup() throws ParsingException;
    public void onDone();
    public void onError( Exception e );
}
