package de.fhws.mobcom.ardog_java.Activities;

import android.app.Activity;
import android.os.Bundle;
import android.util.Log;
import android.view.MotionEvent;
import android.view.View;
import android.view.View.OnClickListener;
import android.widget.AdapterView;
import android.widget.ListView;

import java.util.ArrayList;

import de.fhws.mobcom.ardog_java.Adapters.ListViewAdapter;
import de.fhws.mobcom.ardog_java.GameApplication;
import de.fhws.mobcom.ardog_java.R;
import de.fhws.mobcom.ardog_java.Sql.ARDogDbHelper;
import de.fhws.mobcom.ardog_java.Sql.ARDogQuery;
import de.fhws.mobcom.ardog_java.Sql.DBRoom;

/**
 * Created by kanga on 01.02.2018.
 */


public class AreaSelectionActivity extends Activity implements View.OnTouchListener {
    private static final String TAG = AreaSelectionActivity.class.getSimpleName();

    /* DB */
    ARDogDbHelper adHelper;
    ARDogQuery adQuery;

    /* Application */
    private GameApplication application;

    /* ListView for saved Rooms */
    private ListView listView;

    @Override
    protected void onCreate( Bundle savedInstances ){
        super.onCreate( savedInstances );
        setContentView( R.layout.activity_area_selection );

        this.adHelper = new ARDogDbHelper(this);
        this.adQuery = new ARDogQuery(adHelper);

        // insert dummy
        this.adQuery.addRoom("123", "Hello World.");

        ArrayList<DBRoom> rooms = ( ArrayList ) adQuery.getRooms();
        ListViewAdapter adapter = new ListViewAdapter( this, R.layout.listview_item, rooms );

        listView = ( ListView ) findViewById( R.id.list_view );
        listView.setAdapter( adapter );
        listView.setOnItemClickListener( new AdapterView.OnItemClickListener(){
            @Override
            public void onItemClick(AdapterView<?> adapterView, View view, int i, long l) {
                Log.d( TAG, "Item clicked." );
            }
        });

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

    @Override
    public void onDestroy() {
        adHelper.close();
        super.onDestroy();
    }
}
