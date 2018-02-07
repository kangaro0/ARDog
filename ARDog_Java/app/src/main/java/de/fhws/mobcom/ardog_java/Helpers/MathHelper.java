package de.fhws.mobcom.ardog_java.Helpers;

/**
 * Created by kanga on 07.02.2018.
 */

public class MathHelper {

    public static double clampMin( double value, double min ){
        if( value >= min )
            return value;
        return min;
    }

    public static double clampMax( double value, double max ){
        if( value <= max )
            return value;
        return max;
    }
}
