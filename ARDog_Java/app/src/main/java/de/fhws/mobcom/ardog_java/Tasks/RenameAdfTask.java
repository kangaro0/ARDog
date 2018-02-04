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
 * Created by kanga on 04.02.2018.
 */

public class RenameAdfTask extends AsyncTask<Void, Integer, String> {
    private final String TAG = RenameAdfTask.class.getSimpleName();

    private GameApplication context;
    private Tango tango;
    private String uuid;
    private byte[] name;
    private AdfTaskCallback callback;

    public RenameAdfTask(Context context, Tango tango, String uuid, String name, AdfTaskCallback callback ){
        this.context = ( GameApplication ) context;
        this.tango = tango;
        this.uuid = uuid;
        this.name = name.getBytes();
        this.callback = callback;
    }

    @Override
    protected String doInBackground(Void... voids) {
        try {

            TangoAreaDescriptionMetaData metadata = tango.loadAreaDescriptionMetaData( uuid );
            metadata.set(TangoAreaDescriptionMetaData.KEY_NAME, name );
            tango.saveAreaDescriptionMetadata(uuid, metadata);

        } catch( TangoErrorException e ){
            Log.e( TAG, "Error when saving ADF!", e );
            return null;
        } catch( TangoInvalidException e ){
            Log.e( TAG, "Error when saving ADF!", e );
            return null;
        }

        return uuid;
    }

    @Override
    protected void onPostExecute(String adfUuid) {
        if (callback != null) {
            if (adfUuid != null) {
                callback.onDone();
            } else {
                callback.onError( new Exception( "Error when saving adf." ) );
            }
        }
    }
}
