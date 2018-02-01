package de.fhws.mobcom.ardog_java.Sql;

import android.content.ContentValues;
import android.database.Cursor;
import android.database.sqlite.SQLiteDatabase;

import java.util.ArrayList;
import java.util.HashMap;
import java.util.List;

/**
 * Created by Patrick on 01/02/2018.
 */

public class ARDogQuery {

    ARDogDbHelper adHelper;

    public ARDogQuery(ARDogDbHelper adHelper){
        this.adHelper = adHelper;
    };

   public List<DBRoom> getRooms(){
       SQLiteDatabase db = adHelper.getReadableDatabase();
       ArrayList<DBRoom> list = new ArrayList<>();
       String [] projection ={
               ARDogContract.TangoRoom.COLUMN_NAME_UUID,
               ARDogContract.TangoRoom.COLUMN_NAME_NAME,
       };
       Cursor cursor = db.query(
               ARDogContract.TangoRoom.TABLE_NAME,
               projection,
               null,
               null,
               null,
               null,
               null
       );

       while(cursor.moveToNext()) {
           String uuid = cursor.getString(
                   cursor.getColumnIndexOrThrow(ARDogContract.TangoRoom.COLUMN_NAME_UUID));
           String name = cursor.getString(
                   cursor.getColumnIndexOrThrow(ARDogContract.TangoRoom.COLUMN_NAME_NAME));
            list.add(new DBRoom(uuid, name));
       }
       cursor.close();
       return list;
   }

   public List<DBObject> getObjectsByRoom(String uuid){
       SQLiteDatabase db = adHelper.getReadableDatabase();
       ArrayList<DBObject> list = new ArrayList<>();
       String [] projection ={
               ARDogContract.TangoObjects.COLUMN_NAME_NAME,
               ARDogContract.TangoObjects.COLUMN_NAME_UUID,
               ARDogContract.TangoObjects.COLUMN_NAME_POS_X,
               ARDogContract.TangoObjects.COLUMN_NAME_POS_Y,
               ARDogContract.TangoObjects.COLUMN_NAME_POS_Z,
       };
       String selection = ARDogContract.TangoObjects.COLUMN_NAME_UUID + "= ?";
       String[] selectionArgs = {uuid};
       Cursor cursor = db.query(
               ARDogContract.TangoObjects.TABLE_NAME,
               projection,
               selection,
               selectionArgs,
               null,
               null,
               null
       );

       while(cursor.moveToNext()) {
           String name = cursor.getString(cursor.getColumnIndexOrThrow(ARDogContract.TangoObjects.COLUMN_NAME_NAME));
           double x = cursor.getDouble(cursor.getColumnIndexOrThrow(ARDogContract.TangoObjects.COLUMN_NAME_POS_X));
           double y = cursor.getDouble(cursor.getColumnIndexOrThrow(ARDogContract.TangoObjects.COLUMN_NAME_POS_Y));
           double z =  cursor.getDouble(cursor.getColumnIndexOrThrow(ARDogContract.TangoObjects.COLUMN_NAME_POS_Z));
           list.add(new DBObject(name, x, y, z));
       }
       cursor.close();
       return list;
   }

   public DBRoom getRoom(String name){
       SQLiteDatabase db = adHelper.getReadableDatabase();
       String [] projection ={
               ARDogContract.TangoRoom.COLUMN_NAME_UUID,
       };
       String selection = ARDogContract.TangoRoom.COLUMN_NAME_NAME+ "= ?";
       String[] selectionArgs = {name};
       Cursor cursor = db.query(
               ARDogContract.TangoRoom.TABLE_NAME,
               projection,
               selection,
               selectionArgs,
               null,
               null,
               null
       );

       DBRoom dbRoom = null;
       while(cursor.moveToNext()) {
           String uuid = cursor.getString(cursor.getColumnIndexOrThrow(ARDogContract.TangoRoom.COLUMN_NAME_UUID));
           dbRoom = new DBRoom(uuid, name);
           break;
       }
       cursor.close();
       return dbRoom;
   }

   public long addRoom(String uuid, String name){
       SQLiteDatabase db = adHelper.getWritableDatabase();
       ContentValues values = new ContentValues();
       values.put(ARDogContract.TangoRoom.COLUMN_NAME_NAME, name);
       values.put(ARDogContract.TangoRoom.COLUMN_NAME_UUID, uuid);
       long newRowId = db.insert(ARDogContract.TangoRoom.TABLE_NAME, null, values);
       return newRowId;
   }

   public long addObjectToRoom(String uuid, DBObject obj){
       SQLiteDatabase db = adHelper.getWritableDatabase();
       ContentValues values = new ContentValues();
       values.put(ARDogContract.TangoObjects.COLUMN_NAME_UUID, uuid);
       values.put(ARDogContract.TangoObjects.COLUMN_NAME_NAME, obj.getName());
       values.put(ARDogContract.TangoObjects.COLUMN_NAME_POS_X, obj.getVec().x);
       values.put(ARDogContract.TangoObjects.COLUMN_NAME_POS_Y, obj.getVec().y);
       values.put(ARDogContract.TangoObjects.COLUMN_NAME_POS_Z, obj.getVec().z);
       return db.insert(ARDogContract.TangoObjects.TABLE_NAME, null, values);
   }
}
