package de.fhws.mobcom.ardog_java.Activities;

import android.app.Activity;
import android.app.AlertDialog;
import android.content.DialogInterface;
import android.content.Intent;
import android.content.res.Resources;
import android.os.Bundle;
import android.support.design.widget.FloatingActionButton;
import android.text.InputType;
import android.util.Log;
import android.view.MotionEvent;
import android.view.View;
import android.view.View.OnClickListener;
import android.widget.Adapter;
import android.widget.AdapterView;
import android.widget.ArrayAdapter;
import android.widget.EditText;
import android.widget.FrameLayout;
import android.widget.ListAdapter;
import android.widget.ListView;
import android.widget.TextView;

import java.util.ArrayList;

import de.fhws.mobcom.ardog_java.Adapters.ListViewAdapter;
import de.fhws.mobcom.ardog_java.GameApplication;
import de.fhws.mobcom.ardog_java.R;
import de.fhws.mobcom.ardog_java.Sql.ARDogDbHelper;
import de.fhws.mobcom.ardog_java.Sql.ARDogQuery;
import de.fhws.mobcom.ardog_java.Sql.DBObject;
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

    /* Elements */
    private FloatingActionButton actionButtonAdd;
    private FloatingActionButton actionButtonDelete;
    private FloatingActionButton actionButtonRename;
    private TextView topBar_left;
    private TextView topBar_right;

    private FrameLayout frameLayout;
    private ListView listView;
    private ArrayList<DBRoom> rooms;

    /* State */
    private int currentId = -1;

    /* Booleans */

    @Override
    protected void onCreate( Bundle savedInstances ){
        super.onCreate( savedInstances );
        setContentView( R.layout.activity_area_selection );

        // DB
        this.adHelper = new ARDogDbHelper(this);
        this.adQuery = new ARDogQuery(adHelper);

        // insert dummy
        this.adQuery.addRoom("123", "Hello World1.");
        this.adQuery.addRoom("124", "Hello World2.");
        this.adQuery.addRoom("125", "Hello World3.");

        this.adQuery.addObjectToRoom("123", new DBObject("objekt", 1.0, 2.0, 3.0));

        this.setupFrameLayout();
        this.setupListView();
        this.setupActionButtons();

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
    protected void onDestroy() {
        adHelper.close();
        super.onDestroy();
    }

    @Override
    public boolean onTouch(View view, MotionEvent motionEvent) {
        return false;
    }

    private void setupFrameLayout(){
        frameLayout = ( FrameLayout ) findViewById( R.id.area_frame );
        frameLayout.setOnClickListener(new OnClickListener() {
            @Override
            public void onClick(View v) {
                Log.d( TAG, "List clicked.");

                currentId = -1;

                resetBackgroundColors();
                updateActionButtons();
            }
        });
    }

    private void setupListView(){
        ArrayList<DBObject> obj = (ArrayList)this.adQuery.getObjectsByRoom("123");
        Log.d("dbobject", obj.get(0).getName());

        final ArrayList<DBRoom> rooms = ( ArrayList ) adQuery.getRooms();
        final ListViewAdapter adapter = new ListViewAdapter( this, R.layout.listview_item, rooms );

        listView = ( ListView ) findViewById( R.id.list_view );
        listView.setAdapter( adapter );
        // to select
        listView.setOnItemClickListener( new AdapterView.OnItemClickListener(){
            @Override
            public void onItemClick(AdapterView<?> adapterView, View view, int i, long l) {
                Log.d(TAG, "Item clicked.");

                currentId = i;
                // set background color
                resetBackgroundColors();
                setBackgroundColor( i );
                // update action buttons
                updateActionButtons();

            }
        });

        // to delete
        listView.setOnItemLongClickListener( new AdapterView.OnItemLongClickListener(){

            @Override
            public boolean onItemLongClick(AdapterView<?> parent, View view, int position, long id) {
                Log.d( TAG, "Itm long clicked." );
                resetBackgroundColors();

                // set as currently selected
                currentId = position;

                return false;
            }
        });
    }

    private void setupActionButtons(){
        // Add
        this.actionButtonAdd = ( FloatingActionButton ) findViewById( R.id.area_fab_add );
        this.actionButtonAdd.setOnClickListener( new OnClickListener() {
            @Override
            public void onClick(View v) {
                // check if item is selected
                if( currentId > 0 ) {
                    // is start button
                    Intent intent = new Intent( application, de.fhws.mobcom.ardog_java.Activities.GameActivity.class );
                    startActivity( intent );
                } else {
                    // create new adf
                }
            }
        });

        // Delete
        this.actionButtonDelete = ( FloatingActionButton ) findViewById( R.id.area_fab_delete );
        this.actionButtonDelete.setVisibility( View.INVISIBLE );
        this.actionButtonDelete.setOnClickListener(new OnClickListener() {
            @Override
            public void onClick(View v) {

            }
        });

        // Rename
        this.actionButtonRename = ( FloatingActionButton ) findViewById( R.id.area_fab_rename );
        this.actionButtonRename.setVisibility( View.INVISIBLE );
        this.actionButtonRename.setOnClickListener(new OnClickListener() {
            @Override
            public void onClick(View v) {
                Log.d( TAG, "Rename clicked." );
                showRenameRoomAlert();
            }
        });
    }

    private void updateActionButtons(){
        if( currentId < 0 ){
            this.actionButtonAdd.setImageResource( R.drawable.ic_add_black_18dp );
            this.actionButtonDelete.setVisibility( View.INVISIBLE );
            this.actionButtonRename.setVisibility( View.INVISIBLE );
        } else {
            this.actionButtonAdd.setImageResource( R.drawable.ic_play_arrow_black_18dp );
            this.actionButtonDelete.setVisibility( View.VISIBLE );
            this.actionButtonRename.setVisibility( View.VISIBLE );
        }
    }

    private void setBackgroundColor( int position ){
        // set new active
        listView.getChildAt( position )
                .setBackgroundColor( getResources().getColor( R.color.grey ) );
    }

    private void resetBackgroundColors(  ){
        int itemCount = listView.getAdapter().getCount();
        for( int j = 0 ; j < itemCount ; j++ ){
            View current = listView.getChildAt( j );
            // reset background to normal
            Resources res = getResources();
            current.setBackgroundColor( res.getColor( R.color.white ) );
        }
    }

    private void showRenameRoomAlert(){
        AlertDialog.Builder builder = new AlertDialog.Builder(
                this,
                R.style.AlertDialogCustom
        );

        final EditText input = new EditText( this );
        input.setInputType( InputType.TYPE_CLASS_TEXT );

        builder.setView( input );
        builder.setTitle( "Type new name:                               " );
        builder.setPositiveButton("OK", new DialogInterface.OnClickListener() {
            @Override
            public void onClick(DialogInterface dialog, int which) {
                renameRoom( input.getText().toString() );
            }
        });
        builder.setNegativeButton("Cancle", new DialogInterface.OnClickListener() {
            @Override
            public void onClick(DialogInterface dialog, int which) {
                dialog.cancel();
            }
        });

        builder.show();
    }

    private void renameRoom( String name ){
        if( name == null || name == "" )
            return;

        DBRoom room = rooms.get(currentId);
        room.setName( name );

        listView.invalidateViews();
        setupListView();
    }

}
