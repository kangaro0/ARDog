package de.fhws.mobcom.ardog_java.Sql;

import android.content.ContentValues;
import android.database.Cursor;
import android.database.sqlite.SQLiteDatabase;

import java.util.ArrayList;
import java.util.List;

/**
 * Created by Patrick on 01/02/2018.
 */

public class ARDogQuery {

    public final static String[] OBJECTS = {"Bowl", "Pillow"};

    ARDogDbHelper adHelper;

    public ARDogQuery(ARDogDbHelper adHelper){
        this.adHelper = adHelper;
    };

  /* public List<DBRoom> getRooms(){
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
   }*/

   /*public boolean hasObject(String uuid, String object){
       SQLiteDatabase db = adHelper.getReadableDatabase();
       String selection = ARDogContract.TangoObjects.COLUMN_NAME_UUID + "= ? AND " + ARDogContract.TangoObjects.COLUMN_NAME_NAME +"= ?";
       String[] selectionArgs = {uuid, object};
       Cursor cursor = db.query(
               ARDogContract.TangoObjects.TABLE_NAME,
               null,
               selection,
               selectionArgs,
               null,
               null,
               null
       );
       return cursor.getCount()>0;
   }*/

   public List<DBObject> getObjectsByRoom(String uuid){
       SQLiteDatabase db = adHelper.getReadableDatabase();
       ArrayList<DBObject> list = new ArrayList<>();
       String [] projection ={
               ARDogContract.TangoObjects.COLUMN_NAME_NAME,
               ARDogContract.TangoObjects.COLUMN_NAME_UUID,
               ARDogContract.TangoObjects.COLUMN_NAME_POS_X,
               ARDogContract.TangoObjects.COLUMN_NAME_POS_Y,
               ARDogContract.TangoObjects.COLUMN_NAME_POS_Z,
               ARDogContract.TangoObjects.COLUMN_NAME_SCALE,
               ARDogContract.TangoObjects.COLUMN_NAME_IS_SET,
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
           double scale = cursor.getDouble(cursor.getColumnIndexOrThrow(ARDogContract.TangoObjects.COLUMN_NAME_SCALE));
           boolean isSet = cursor.getInt(cursor.getColumnIndexOrThrow(ARDogContract.TangoObjects.COLUMN_NAME_IS_SET)) > 0;
           list.add(new DBObject(name, x, y, z, scale, isSet));
       }
       cursor.close();
       return list;
   }

   /*public DBRoom getRoom(String name){
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
   }*/

   public void addRoom(String uuid){
       SQLiteDatabase db = adHelper.getWritableDatabase();
       for(String object : ARDogQuery.OBJECTS) {
           ContentValues values = new ContentValues();
           values.put(ARDogContract.TangoObjects.COLUMN_NAME_UUID, uuid);
           values.put(ARDogContract.TangoObjects.COLUMN_NAME_NAME, object);
           values.put(ARDogContract.TangoObjects.COLUMN_NAME_IS_SET, 0);
           db.insert(ARDogContract.TangoObjects.TABLE_NAME, null, values);
       }
   }

  /* public void addObjectToRoom(String uuid, DBObject obj){
       SQLiteDatabase db = adHelper.getWritableDatabase();
       ContentValues values = new ContentValues();
       values.put(ARDogContract.TangoObjects.COLUMN_NAME_UUID, uuid);
       values.put(ARDogContract.TangoObjects.COLUMN_NAME_NAME, obj.getName());
       values.put(ARDogContract.TangoObjects.COLUMN_NAME_POS_X, obj.getVec().x);
       values.put(ARDogContract.TangoObjects.COLUMN_NAME_POS_Y, obj.getVec().y);
       values.put(ARDogContract.TangoObjects.COLUMN_NAME_POS_Z, obj.getVec().z);
       values.put(ARDogContract.TangoObjects.COLUMN_NAME_SCALE, obj.getScale());
       db.insert(ARDogContract.TangoObjects.TABLE_NAME, null, values);
   }*/

   public void deleteRoom(String uuid){
       SQLiteDatabase db = adHelper.getWritableDatabase();
       String[] selectionArgs = { uuid };

      /* String selection = ARDogContract.TangoRoom.COLUMN_NAME_UUID + " LIKE ?";
       db.delete(ARDogContract.TangoRoom.TABLE_NAME, selection, selectionArgs);*/

       String selection = ARDogContract.TangoObjects.COLUMN_NAME_UUID + " LIKE ?";
       db.delete(ARDogContract.TangoObjects.TABLE_NAME, selection, selectionArgs);
   }

   /*public void deleteObject(String uuid, String name){
       SQLiteDatabase db = adHelper.getWritableDatabase();
       String selection = ARDogContract.TangoObjects.COLUMN_NAME_UUID + " LIKE ? AND + " + ARDogContract.TangoObjects.COLUMN_NAME_NAME+ " LIKE ?";
       String[] selectionArgs = { uuid, name};
       db.delete(ARDogContract.TangoObjects.TABLE_NAME, selection, selectionArgs);
   }*/

   public void updateObject(String uuid, DBObject updatedObj){
       SQLiteDatabase db = adHelper.getWritableDatabase();
       ContentValues values = new ContentValues();
       values.put(ARDogContract.TangoObjects.COLUMN_NAME_NAME, updatedObj.getName());
       values.put(ARDogContract.TangoObjects.COLUMN_NAME_POS_X, updatedObj.getVec().x);
       values.put(ARDogContract.TangoObjects.COLUMN_NAME_POS_Y, updatedObj.getVec().y);
       values.put(ARDogContract.TangoObjects.COLUMN_NAME_POS_Z, updatedObj.getVec().z);
       values.put(ARDogContract.TangoObjects.COLUMN_NAME_SCALE, updatedObj.getScale());
       values.put(ARDogContract.TangoObjects.COLUMN_NAME_IS_SET, updatedObj.isSet() ? 1:0);

       String selection = ARDogContract.TangoObjects.COLUMN_NAME_UUID + " LIKE ? AND + " + ARDogContract.TangoObjects.COLUMN_NAME_NAME+ " LIKE ?";
       String[] selectionArgs = { uuid, updatedObj.getName() };
       db.update(
               ARDogContract.TangoObjects.TABLE_NAME,
               values,
               selection,
               selectionArgs);
   }

   /*public void updateRoomByUuid (String uuid, String newName ){
       SQLiteDatabase db = adHelper.getWritableDatabase();
       ContentValues values = new ContentValues();
       values.put(ARDogContract.TangoRoom.COLUMN_NAME_NAME, newName);
       String selection = ARDogContract.TangoRoom.COLUMN_NAME_UUID + " = ?";
       String[] selectionArgs = { uuid };
       db.update(
               ARDogContract.TangoRoom.TABLE_NAME,
               values,
               selection,
               selectionArgs);
   }*/


  /* public void updateRoomByName (String name, String newName ){
       SQLiteDatabase db = adHelper.getWritableDatabase();
       ContentValues values = new ContentValues();
       values.put(ARDogContract.TangoRoom.COLUMN_NAME_NAME, newName);
       String selection = ARDogContract.TangoRoom.COLUMN_NAME_NAME + " = ?";
       String[] selectionArgs = { name };
       db.update(
               ARDogContract.TangoRoom.TABLE_NAME,
               values,
               selection,
               selectionArgs);
   }*/
}
