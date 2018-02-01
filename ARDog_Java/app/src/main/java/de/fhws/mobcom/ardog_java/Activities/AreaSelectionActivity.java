package de.fhws.mobcom.ardog_java.Activities;

import android.app.Activity;
import android.os.Bundle;
import android.util.Log;
import android.view.MotionEvent;
import android.view.View;

import com.google.atap.tangoservice.Tango;
import com.google.atap.tangoservice.TangoConfig;
import com.google.atap.tangoservice.TangoErrorException;
import com.google.atap.tangoservice.TangoInvalidException;
import com.google.atap.tangoservice.TangoOutOfDateException;
import com.google.tango.support.TangoSupport;

import de.fhws.mobcom.ardog_java.GameApplication;
import de.fhws.mobcom.ardog_java.R;

/**
 * Created by kanga on 01.02.2018.
 */

public class AreaSelectionActivity extends Activity implements View.OnTouchListener {
    private static final String TAG = AreaSelectionActivity.class.getSimpleName();

    /* Application */
    GameApplication application;

    @Override
    protected void onCreate( Bundle savedInstances ){
        super.onCreate( savedInstances );

        this.application = ( GameApplication ) getApplicationContext();
    }

    @Override
    protected void onStart(){
        super.onStart();
    }

    @Override
    protected void onPause(){
        super.onPause();
    }

    @Override
    protected void onResume(){
        super.onResume();
    }

    @Override
    protected void onStop(){
        super.onStop();
    }

    @Override
    public boolean onTouch(View view, MotionEvent motionEvent) {
        return false;
    }
}
