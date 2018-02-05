package de.fhws.mobcom.ardog_java.Callbacks;

import de.fhws.mobcom.ardog_java.Objects.GameObject;

/**
 * Created by kanga on 03.02.2018.
 */

public interface GameRendererCallback {
    public void onObjectPicked( GameObject obj );
    public void onObjectUnpicked();
}
