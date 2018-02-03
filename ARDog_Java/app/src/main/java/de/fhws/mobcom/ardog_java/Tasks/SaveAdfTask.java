package de.fhws.mobcom.ardog_java.Tasks;

import android.os.AsyncTask;

import com.google.atap.tangoservice.Tango;
import com.google.atap.tangoservice.TangoAreaDescriptionMetaData;
import com.google.atap.tangoservice.TangoErrorException;
import com.google.atap.tangoservice.TangoInvalidException;

import de.fhws.mobcom.ardog_java.Callbacks.SaveAdfTaskCallback;
import de.fhws.mobcom.ardog_java.GameApplication;

/**
 * Created by kanga on 03.02.2018.
 */

public class SaveAdfTask extends AsyncTask<Void, Integer, String> {

    private GameApplication context;
    private SaveAdfTaskCallback callback;
    private Tango tango;
    private String name;


    public SaveAdfTask(GameApplication context, Tango tango, String name, SaveAdfTaskCallback callback ){
        this.context = context;
        this.callback = callback;
        this.tango = tango;
        this.name = context.getUUID();
    }


    @Override
    protected String doInBackground(Void... voids) {
        String adfUuid = null;
        try {
            // Save the ADF.
            adfUuid = tango.saveAreaDescription();

            // Read the ADF Metadata, set the desired name, and save it back.
            TangoAreaDescriptionMetaData metadata = tango.loadAreaDescriptionMetaData(adfUuid);
            metadata.set(TangoAreaDescriptionMetaData.KEY_NAME, name.getBytes());
            tango.saveAreaDescriptionMetadata(adfUuid, metadata);

        } catch (TangoErrorException e) {
            adfUuid = null; // There's currently no additional information in the exception.
        } catch (TangoInvalidException e) {
            adfUuid = null; // There's currently no additional information in the exception.
        }
        return adfUuid;
    }

    @Override
    protected void onPostExecute(String adfUuid) {
        if (callback != null) {
            if (adfUuid == null) {
                callback.onDone();
            } else {
                callback.onError( new Exception( "Error when saving adf." ) );
            }
        }
    }
}
