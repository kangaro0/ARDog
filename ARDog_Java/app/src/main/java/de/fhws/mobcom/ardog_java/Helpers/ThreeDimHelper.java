package de.fhws.mobcom.ardog_java.Helpers;

import android.opengl.Matrix;

import com.google.atap.tangoservice.TangoCameraIntrinsics;

/**
 * Created by kanga on 26.01.2018.
 */

public class ThreeDimHelper {

    /* Calculates projection matrix from TangoCameraIntrinsics */
    public static float[] projectionMatrixFromCameraIntrinsics( TangoCameraIntrinsics intrinsics ){
        float cx = ( float ) intrinsics.cx;
        float cy = ( float ) intrinsics.cy;
        float width = ( float ) intrinsics.width;
        float height = ( float ) intrinsics.height;
        float fx = ( float ) intrinsics.fx;
        float fy = ( float ) intrinsics.fy;

        float near = 0.1f;
        float far = 100;

        float xScale = near / fx;
        float yScale = near / fy;
        float xOffset = -( cy - ( width / 2.0f ) ) * xScale;
        float yOffset = -( cy - ( height / 2.0f ) ) * yScale;

        float m[] = new float[16];
        Matrix.frustumM( m, 0,
                xScale * ( float ) - width / 2.0f - xOffset,
                xScale * ( float ) width / 2.0f - xOffset,
                yScale * ( float ) - height / 2.0f - yOffset,
                yScale * ( float ) height / 2.0f - yOffset,
                near, far );
        return m;
    }
}
