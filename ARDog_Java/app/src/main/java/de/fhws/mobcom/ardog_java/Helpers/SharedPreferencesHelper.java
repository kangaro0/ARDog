package de.fhws.mobcom.ardog_java.Helpers;

import org.rajawali3d.math.vector.Vector3;

import java.util.ArrayList;

/**
 * Created by kanga on 25.01.2018.
 */

public class SharedPreferencesHelper {

    public static int preferencesPerEntity = 1;

    /* Parser function for String-Array from SharedPreferences */
    public static ArrayList<SharedPreferencesObject> parseArray(String[] entities ){
        ArrayList<SharedPreferencesObject> toReturn = new ArrayList<SharedPreferencesObject>();

        if( entities.length % preferencesPerEntity != 0 )
            return toReturn;

        for( int i = 0 ; i < entities.length / preferencesPerEntity ; i++ ){
            SharedPreferencesObject current = new SharedPreferencesObject();

            for( int j = 0 ; j < preferencesPerEntity ; j++ ){
                switch( j ) {
                    case 0:
                        current.setName( entities[ j ] );
                        break;
                    case 1:
                        current.setPosition( StringToVector( entities[ j ] ) );
                        break;
                }
            }

            toReturn.add( current );
        }

        return toReturn;
    }

    public static String[] parseList( ArrayList<SharedPreferencesObject> objects ){
        String[] toReturn = new String[ preferencesPerEntity * objects.size() ];

        for( int i = 0 ; i < objects.size() ; i++ ){
            SharedPreferencesObject curObject = objects.get( i );

            toReturn[ 0 + i * preferencesPerEntity ] = curObject.getName();
            toReturn[ 1 + i * preferencesPerEntity ] = VectorToString( curObject.getPosition() );
        }

        return toReturn;
    }

    /* Conversion function for String to Vector3 */
    private static Vector3 StringToVector( String str ){
        Vector3 toReturn = new Vector3();
        String[] strArr = str.split( "-" );

        for( int i = 0; i < strArr.length ; i++ ){
            double d = Double.parseDouble( strArr[ i ] );
            switch( i ){
                case 0:
                    toReturn.x = d;
                    break;
                case 1:
                    toReturn.y = d;
                    break;
                case 2:
                    toReturn.z = d;
                    break;
            }
        }

        return toReturn;
    }

    /* Conversion function for Vector3 to String */
    private static String VectorToString( Vector3 vec ){
        String toReturn = "";

        for( int i = 0 ; i < 3 ; i++ ){
            switch( i ){
                case 0:
                    toReturn += String.valueOf( vec.x ) + "-";
                    break;
                case 1:
                    toReturn += String.valueOf( vec.y ) + "-";
                    break;
                case 2:
                    toReturn += String.valueOf( vec.z ) + "-";
                    break;
            }
        }

        return toReturn;
    }
}
