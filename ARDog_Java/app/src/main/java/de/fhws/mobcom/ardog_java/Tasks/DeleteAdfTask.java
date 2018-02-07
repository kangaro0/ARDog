package de.fhws.mobcom.ardog_java.Tasks;

import android.content.Context;
import android.os.AsyncTask;
import android.util.Log;

import com.google.atap.tangoservice.Tango;
import com.google.atap.tangoservice.TangoAreaDescriptionMetaData;
import com.google.atap.tangoservice.TangoErrorException;
import com.google.atap.tangoservice.TangoInvalidException;

import de.fhws.mobcom.ardog_java.Callbacks.AdfTaskCallback;
import de.fhws.mobcom.ardog_java.GameApplication;

/**
 * Created by kanga on 07.02.2018.
 */

public class DeleteAdfTask extends AsyncTask<Void, Integer, Boolean> {
    private static final String TAG = DeleteAdfTask.class.getSimpleName();

    private GameApplication context;
    private Tango tango;
    private String uuid;
    private AdfTaskCallback callback;

    public DeleteAdfTask(Context context, Tango tango, String uuid, AdfTaskCallback callback ){
        this.context = ( GameApplication ) context;
        this.tango = tango;
        this.uuid = uuid;
        this.callback = callback;
    }

    @Override
    protected Boolean doInBackground(Void... voids) {
        try {

            tango.deleteAreaDescription( uuid );

        } catch( TangoErrorException e ){
            Log.e( TAG, "Error when deleting ADF!", e );
            return false;
        } catch( TangoInvalidException e ){
            Log.e( TAG, "Error when deleting ADF!", e );
            return false;
        }

        return true;
    }

    @Override
    protected void onPostExecute( Boolean state ){
        if (callback != null) {
            if ( state ) {
                callback.onDone( null );
            } else {
                callback.onError( new Exception( "Error when deleting adf." ) );
            }
        }
    }
}
