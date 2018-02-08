package de.fhws.mobcom.ardog_java.Callbacks;

import de.fhws.mobcom.ardog_java.Objects.GameObject;

/**
 * Created by kanga on 03.02.2018.
 */

public interface GameRendererCallback {
    public void onObjectPicked( GameObject obj );
    public void onNoObjectPicked();
    public void onObjectPlaced(String name);
    public void onObjectRemoved(String name);
    public void onRendererResume();
}
