package de.fhws.mobcom.ardog_java.Callbacks;

/**
 * Created by kanga on 25.01.2018.
 */

public interface GameApplicationLoadCallback {
    public void onDone();
    public void onError( Exception e );
}
