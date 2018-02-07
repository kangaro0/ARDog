package de.fhws.mobcom.ardog_java.Callbacks;

/**
 * Created by kanga on 03.02.2018.
 */

public interface AdfTaskCallback {
    public void onDone( String uuid );
    public void onError( Exception e );
}
