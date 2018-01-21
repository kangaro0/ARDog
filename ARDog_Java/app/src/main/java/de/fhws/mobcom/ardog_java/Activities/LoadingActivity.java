package de.fhws.mobcom.ardog_java.Activities;

import android.app.Activity;
import android.graphics.Color;
import android.graphics.PorterDuff;
import android.os.Bundle;
import android.widget.ProgressBar;
import android.widget.TextView;

import de.fhws.mobcom.ardog_java.R;

/**
 * Created by kanga on 21.01.2018.
 */

public class LoadingActivity extends Activity {
    private static final String TAG = LoadingActivity.class.getSimpleName();

    ProgressBar progressBar;
    TextView progressText;

    @Override
    protected void onCreate( Bundle savedInstances ){
        super.onCreate( savedInstances );
        setContentView( R.layout.activity_load );

        progressBar = ( ProgressBar ) findViewById( R.id.progressBar );
        progressBar.getIndeterminateDrawable().setColorFilter( Color.WHITE, PorterDuff.Mode.MULTIPLY );
        // .getIndeterminateDrawable().setColorFilter(0xFFFF0000, android.graphics.PorterDuff.Mode.MULTIPLY);

        progressText = ( TextView ) findViewById( R.id.progressText );
        progressText.setTextColor( Color.WHITE );
        progressText.setTextSize( 18.0F );
        progressText.setText( "Loading..." );
    }

    @Override
    protected void onStart(){
        super.onStart();
    }

    @Override
    protected void onStop(){
        super.onStop();
    }

}
