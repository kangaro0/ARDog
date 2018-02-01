package de.fhws.mobcom.ardog_java.Sql;

import android.provider.BaseColumns;

/**
 * Created by Patrick on 01/02/2018.
 */

public class ARDogContract {

    private ARDogContract() {
    }

    public static class TangoRoom implements BaseColumns {
        public static final String TABLE_NAME = "Rooms";
        public static final String COLUMN_NAME_UUID = "uuid";
        public static final String COLUMN_NAME_NAME = "name";

    }

    public static class TangoObjects implements BaseColumns {
        public static final String TABLE_NAME = "TangoObjects";
        public static final String COLUMN_NAME_UUID = "room_uuid";
        public static final String COLUMN_NAME_NAME = "obj_name";
        public static final String COLUMN_NAME_POS_X= "pos_x";
        public static final String COLUMN_NAME_POS_Y = "pos_y";
        public static final String COLUMN_NAME_POS_Z = "pos_z";

    }
}
