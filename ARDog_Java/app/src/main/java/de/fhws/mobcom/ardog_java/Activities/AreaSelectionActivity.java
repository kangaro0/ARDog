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
import android.view.Display;
import android.view.MotionEvent;
import android.view.View;
import android.view.View.OnClickListener;
import android.widget.AdapterView;
import android.widget.EditText;
import android.widget.FrameLayout;
import android.widget.ListView;
import android.widget.TextView;

import com.google.atap.tangoservice.Tango;
import com.google.atap.tangoservice.TangoAreaDescriptionMetaData;
import com.google.atap.tangoservice.TangoCameraIntrinsics;
import com.google.atap.tangoservice.TangoConfig;
import com.google.atap.tangoservice.TangoErrorException;
import com.google.atap.tangoservice.TangoInvalidException;
import com.google.atap.tangoservice.TangoOutOfDateException;
import com.google.tango.support.TangoSupport;

import java.util.ArrayList;

import de.fhws.mobcom.ardog_java.Adapters.RoomAdapter;
import de.fhws.mobcom.ardog_java.Callbacks.AdfTaskCallback;
import de.fhws.mobcom.ardog_java.GameApplication;
import de.fhws.mobcom.ardog_java.Objects.Room;
import de.fhws.mobcom.ardog_java.R;
import de.fhws.mobcom.ardog_java.Sql.ARDogDbHelper;
import de.fhws.mobcom.ardog_java.Sql.ARDogQuery;
import de.fhws.mobcom.ardog_java.Tasks.RenameAdfTask;

/**
 * Created by kanga on 01.02.2018.
 */

public class AreaSelectionActivity extends Activity implements View.OnTouchListener {
    private static final String TAG = AreaSelectionActivity.class.getSimpleName();

    /* Tango */
    private Tango tango;
    private TangoConfig config;
    private boolean isConnected = false;
    private boolean isConnecting = false;

    /* Task */
    RenameAdfTask task;

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
    private ArrayList<Room> rooms;

    /* State */
    private int currentId = -1;

    private int displayRotation;

    @Override
    protected void onCreate( Bundle savedInstances ){
        super.onCreate( savedInstances );
        setContentView( R.layout.activity_area_selection );

        // DB
        /*
        adHelper = new ARDogDbHelper(this);
        adQuery = new ARDogQuery(adHelper);

        // insert dummy
        adQuery.addRoom("123", "Hello World1.");
        adQuery.addRoom("124", "Hello World2.");
        adQuery.addRoom("125", "Hello World3.");

        adQuery.addObjectToRoom("123", new DBObject("objekt", 1.0, 2.0, 3.0));
        */

        application = ( GameApplication ) getApplicationContext();
    }

    @Override
    protected void onStart(){
        Log.d( TAG, "AreaSelectionActivity: onStart()" );
        super.onStart();

        startActivityForResult(
                Tango.getRequestPermissionIntent(Tango.PERMISSIONTYPE_ADF_LOAD_SAVE),
                Tango.TANGO_INTENT_ACTIVITYCODE);

        //bindTangoService();
    }

    @Override
    protected void onPause(){
        Log.d( TAG, "AreaSelectionActivity: onPause()" );
        super.onPause();
        synchronized ( AreaSelectionActivity.this ){
            try {
                if( tango != null ){
                    tango.disconnect();
                }

                isConnected = false;
            } catch ( TangoErrorException e ){
                Log.e( TAG, getString( R.string.exception_tango_error ), e );
            }
        }
    }

    @Override
    protected void onResume(){
        Log.d( TAG, "AreaSelectionActivity: onResume()" );
        super.onResume();
        if( !isConnecting && !isConnected )
            bindTangoService();
    }

    @Override
    protected void onStop(){
        Log.d( TAG, "AreaSelectionActivity: onStop()" );
        super.onStop();
        if( isConnected ) {
            tango.disconnect();
            isConnected = false;
        }
    }

    @Override
    protected void onDestroy() {
        adHelper.close();
        super.onDestroy();
        if( isConnected ) {
            tango.disconnect();
            isConnected = false;
        }
        tango = null;
    }

    @Override
    public boolean onTouch(View view, MotionEvent motionEvent) {
        return false;
    }

    private void bindTangoService(){
        isConnecting = true;
        Log.d( TAG, "bindTangoService()" );
        tango = new Tango(AreaSelectionActivity.this, new Runnable() {
            // Pass in a Runnable to be called from UI thread when Tango is ready; this Runnable
            // will be running on a new thread.
            // When Tango is ready, we can call Tango functions safely here only when there are no
            // UI thread changes involved.
            @Override
            public void run() {
                synchronized ( AreaSelectionActivity.this ) {
                    try {
                        config = setupTangoConfig( tango );
                        tango.connect(config);
                        TangoSupport.initialize( tango );
                        // init state
                        isConnected = true;
                        getRooms();
                        // init elements
                        setup();
                        setDisplayRotation();
                    } catch (TangoOutOfDateException e) {
                        Log.e(TAG, getString( R.string.exception_out_of_date ), e);
                    } catch (TangoErrorException e) {
                        Log.e(TAG, getString( R.string.exception_tango_error ), e);
                    } catch (TangoInvalidException e) {
                        Log.e(TAG, getString( R.string.exception_tango_invalid ), e);
                    } catch (SecurityException e) {
                        // Area Learning permissions are required. If they are not available,
                        // SecurityException is thrown.
                        Log.e(TAG, getString( R.string.permission_camera ), e);
                    }

                    isConnecting = false;
                }
            }
        });
    }

    private TangoConfig setupTangoConfig( Tango tango ) {
        TangoConfig config = tango.getConfig( TangoConfig.CONFIG_TYPE_DEFAULT );
        return config;
    }

    private void getRooms(){
        ArrayList<Room> toReturn = new ArrayList<Room>();

        try {
            ArrayList<String> uuids = tango.listAreaDescriptions();
            int size = uuids.size();
            for( int i = 0 ; i < size ; i++ ){
                String uuid = uuids.get( i );
                TangoAreaDescriptionMetaData metadata = new TangoAreaDescriptionMetaData();
                metadata = tango.loadAreaDescriptionMetaData( uuid );

                byte[] nameBytes = metadata.get(TangoAreaDescriptionMetaData.KEY_NAME);

                Room room = new Room( new String( nameBytes ), uuid );
                toReturn.add( room );
            }

        } catch( TangoErrorException e ){
            Log.e( TAG, "Error when reading saved adfs.", e );
        }
        rooms = toReturn;
    }

    private void setup(){
        runOnUiThread(new Runnable() {
            @Override
            public void run() {
                setupFrameLayout();
                setupListView();
                setupActionButtons();
            }
        });
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
        final RoomAdapter adapter = new RoomAdapter( this, R.layout.listview_item, rooms);

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

    private void setupDialog(){
        AlertDialog.Builder builder = new AlertDialog.Builder(
                this,
                R.style.AlertDialogCustom
        );

        final TextView dialog = new TextView( this );
        dialog.setText( "hallo" );

        builder.setView( dialog );
        builder.setTitle( "Name:                               " );
        builder.setPositiveButton("OK", new DialogInterface.OnClickListener() {
            @Override
            public void onClick(DialogInterface dialog, int which) {
                Intent intent = new Intent( application, de.fhws.mobcom.ardog_java.Activities.AreaLearningActivity.class );
                intent.putExtra( "KEY_AREA_EXISTS", false );
                startActivity( intent );
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

    private void setupActionButtons(){
        // Add
        this.actionButtonAdd = ( FloatingActionButton ) findViewById( R.id.area_fab_add );
        this.actionButtonAdd.setOnClickListener( new OnClickListener() {
            @Override
            public void onClick(View v) {
                // check if item is selected
                if( currentId > 0 ) {
                    // is start button
                    application.setUUID( rooms.get( currentId ).getUuid() );

                    Intent intent = new Intent( application, de.fhws.mobcom.ardog_java.Activities.GameActivity.class );
                    startActivity( intent );
                } else {
                    setupDialog();
                }
            }
        });

        // Delete
        this.actionButtonDelete = ( FloatingActionButton ) findViewById( R.id.area_fab_delete );
        this.actionButtonDelete.setVisibility( View.INVISIBLE );
        this.actionButtonDelete.setOnClickListener(new OnClickListener() {
            @Override
            public void onClick(View v) {
                adQuery.deleteRoom( rooms.get( currentId ).getUuid() );

                listView.invalidateViews();
                setupListView();
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
                renameCurrentRoom( input.getText().toString() );
            }
        });
        builder.setNegativeButton("Cancel", new DialogInterface.OnClickListener() {
            @Override
            public void onClick(DialogInterface dialog, int which) {
                dialog.cancel();
            }
        });

        builder.show();
    }

    private void createNewRoom(){
        Intent intent = new Intent( application, de.fhws.mobcom.ardog_java.Activities.AreaLearningActivity.class );
        startActivity( intent );
    }

    private void renameCurrentRoom(String name ){
        if( name == null || name == "" )
            return;

        Room room = rooms.get( currentId );
        task = new RenameAdfTask( application, tango, room.getUuid(), name, new AdfTaskCallback() {
            @Override
            public void onDone() {
                Log.d( TAG, "ADF sucessfully renamed." );
                getRooms();
                listView.invalidateViews();
                setupListView();
            }

            @Override
            public void onError(Exception e) {
                Log.e( TAG, "Error when renaming ADF.", e );
                task = null;
            }
        });
        task.execute();
    }

    private void setDisplayRotation(){
        Display display = getWindowManager().getDefaultDisplay();
        displayRotation = display.getRotation();
    }

    @Override
    protected void onActivityResult( int requestCode, int resultCode, Intent data ){
        if( requestCode == Tango.TANGO_INTENT_ACTIVITYCODE ){
            if( resultCode == RESULT_OK ){
                // if permission was granted, reset tango
                tango.disconnect();
                tango = null;

                bindTangoService();
            }
        }
    }

}
