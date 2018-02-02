package de.fhws.mobcom.ardog_java.Sql;

import android.content.Context;
import android.database.sqlite.SQLiteDatabase;
import android.database.sqlite.SQLiteOpenHelper;

/**
 * Created by Patrick on 01/02/2018.
 */

public class ARDogDbHelper extends SQLiteOpenHelper {


    private static final String SQL_CREATE_ENTRIES_TANGO_ROOM =
            "CREATE TABLE " + ARDogContract.TangoRoom.TABLE_NAME + " (" +
                    ARDogContract.TangoRoom._ID + " INTEGER PRIMARY KEY," +
                    ARDogContract.TangoRoom.COLUMN_NAME_UUID + " TEXT UNIQUE," +
                    ARDogContract.TangoRoom.COLUMN_NAME_NAME + " TEXT UNIQUE);";
     private static final String SQL_CREATE_TANGO_OBJECT =
            "CREATE TABLE " + ARDogContract.TangoObjects.TABLE_NAME + " (" +
                    ARDogContract.TangoObjects._ID + " INTEGER PRIMARY KEY," +
                    ARDogContract.TangoObjects.COLUMN_NAME_UUID + " TEXT," +
                    ARDogContract.TangoObjects.COLUMN_NAME_NAME + " TEXT," +
                    ARDogContract.TangoObjects.COLUMN_NAME_POS_X + " DOUBLE," +
                    ARDogContract.TangoObjects.COLUMN_NAME_POS_Y + " DOUBLE," +
                    ARDogContract.TangoObjects.COLUMN_NAME_POS_Z + " DOUBLE," +
                    "FOREIGN KEY("+ARDogContract.TangoObjects.COLUMN_NAME_UUID+") REFERENCES " +ARDogContract.TangoRoom.TABLE_NAME +"("+ARDogContract.TangoRoom.COLUMN_NAME_UUID+")," +
                    "unique("+ARDogContract.TangoObjects.COLUMN_NAME_UUID+","+ ARDogContract.TangoObjects.COLUMN_NAME_NAME+"));";

    private static final String SQL_DELETE_ENTRIES =
                    "DROP TABLE IF EXISTS " + ARDogContract.TangoRoom.TABLE_NAME+
                    "; DROP TABLE IF EXISTS " + ARDogContract.TangoObjects.TABLE_NAME;


    public static final int DATABASE_VERSION = 3;
    public static final String DATABASE_NAME = "ARDog.db";


    public ARDogDbHelper(Context context){
        super(context, DATABASE_NAME, null, DATABASE_VERSION);
    }

    public void onCreate(SQLiteDatabase db) {
        db.execSQL(SQL_CREATE_ENTRIES_TANGO_ROOM);
        db.execSQL(SQL_CREATE_TANGO_OBJECT);
    }


    public void onUpgrade(SQLiteDatabase db, int oldVersion, int newVersion) {
        // This database is only a cache for online data, so its upgrade policy is
        // to simply to discard the data and start over
        db.execSQL(SQL_DELETE_ENTRIES);
        onCreate(db);
    }
    public void onDowngrade(SQLiteDatabase db, int oldVersion, int newVersion) {
        onUpgrade(db, oldVersion, newVersion);
    }

}
