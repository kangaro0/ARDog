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
}
