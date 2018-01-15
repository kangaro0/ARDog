using Com.Google.Atap.Tangoservice;
using Urho;

namespace urhosharpgoogletango.Droid
{
    public class TangoUpdateListener : Java.Lang.Object, Tango.IOnTangoUpdateListener
    {
        private readonly GameActivity _activity;

        

        public TangoUpdateListener(GameActivity activity)
        {
            _activity = activity;
        }

        public void OnFrameAvailable(int p0)
        {
            // Nothing
        }

        public void OnPointCloudAvailable(TangoPointCloudData pointCloud)
        {
            // Save the cloud and point data for later use.
            _activity.UpdatePointCloud(pointCloud);

        }

        public void OnPoseAvailable(TangoPoseData p0)
        {
            if (p0.StatusCode != TangoPoseData.PoseValid)
                return;

            if (p0.Translation != null)
            {
                var x = p0.Translation[TangoPoseData.IndexTranslationX];
                var y = p0.Translation[TangoPoseData.IndexTranslationY];
                var z = p0.Translation[TangoPoseData.IndexTranslationZ];

                _activity.SetPosition(new Vector3((float)x, (float)y, (float)z));

                switch (p0.BaseFrame)
                {
                    case TangoPoseData.CoordinateFrameStartOfService:
                        // Do something with the coordinates and interprete them as relative to the start position (0/0/0)
                        break;
                    case TangoPoseData.CoordinateFrameAreaDescription:
                        // Do something with the coordinates and interprete them as relative to the ADF start position(0/0/0)
                        break;
                }
            }

            if (p0.Rotation != null)
            {
                var x = p0.Rotation[TangoPoseData.IndexRotationX];
                var y = p0.Rotation[TangoPoseData.IndexRotationY];
                var z = p0.Rotation[TangoPoseData.IndexRotationZ];
                var w = p0.Rotation[TangoPoseData.IndexRotationW];
                _activity.SetRotation(new Quaternion((float)x, (float)y, (float)z, (float)w));
                // Do somethine with these data (rotation as quaternion)
            }
        }

        public void OnTangoEvent(TangoEvent p0)
        {
            // Do somethinig with the status
        }

        public void OnXyzIjAvailable(TangoXyzIjData xyzIj)
        {
            for (var i = 0; i < xyzIj.Xyz.Capacity() - 3; i += 3)
            {
                var x = xyzIj.Xyz.Get(i);
                var y = xyzIj.Xyz.Get(i + 1);
                var z = xyzIj.Xyz.Get(i + 2);

                // Do somthing....
            }
        }
    }
}