using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using Android.App;
using Android.Content.PM;
using Android.OS;
using Android.Runtime;
using Android.Util;
using Android.Views;
using Android.Widget;
using Com.Google.Atap.Tangoservice;
using Com.Projecttango.Tangosupport;
using Com.Google.Atap.Tango;
using Java.Lang;
using Org.Libsdl.App;
using Urho;
using Urho.Droid;
using UrhoSharpGoogleTango.Scripts;
using Orientation = Android.Content.Res.Orientation;

namespace urhosharpgoogletango.Droid
{
	[Activity(Label = "urhosharpgoogletango",
		Icon = "@drawable/icon", Theme = "@android:style/Theme.NoTitleBar.Fullscreen",
		MainLauncher = true,
		ConfigurationChanges = ConfigChanges.KeyboardHidden | ConfigChanges.Orientation
        //, ScreenOrientation = ScreenOrientation.Landscape
        )]
	public class GameActivity : Activity
	{
        private const int INVALID_TEXTURE_ID = 0;
        // For all current Tango devices, color camera is in the camera id 0.
        private const int COLOR_CAMERA_ID = 0;

        private SDLSurface surface;
        public static string Tag = "GameActivity";
        private Tango _tango;
        private TangoConfig _tangoConfig;
        private TangoUpdateListener _tangoUpdateListener;
	    private DemoScene _scene;
	    private IWindowManager _windowManager;
	    private bool _isConnected;
	    private int _connectedTextureIdGlThread = INVALID_TEXTURE_ID;
	    private TangoPointCloudManager _pointCloudManager;

	    protected override void OnCreate(Bundle bundle)
		{
			base.OnCreate(bundle);
			var mLayout = new AbsoluteLayout(this);
            surface = UrhoSurface.CreateSurface(this, ()=> _scene = new DemoScene(new ApplicationOptions("Data")), true);
            mLayout.AddView(surface);
			SetContentView(mLayout);
            _pointCloudManager = new TangoPointCloudManager();
            _windowManager = this.ApplicationContext.GetSystemService(Android.Content.Context.WindowService).JavaCast<IWindowManager>();

		}
     
        protected override void OnResume()
		{
			UrhoSurface.OnResume();
			base.OnResume();
            _tango = new Tango(this, new Runnable(() =>
            {
                Log.Debug(Tag, "TangoRunnable");
                try
                {
                    TangoSupport.Initialize();
                    _tangoConfig = SetupTangoConfig(_tango);
                    _tango.Connect(_tangoConfig);
                    StartupTango();
                    _isConnected = true;
                }
                catch (TangoOutOfDateException e)
                {
                    Log.Error(Tag, "TangoOutOfDateException",    e);
                }
                catch (TangoErrorException e)
                {
                    Log.Error(Tag, "TangoErrorException", e);
                }
                catch (TangoInvalidException e)
                {
                    Log.Error(Tag, "TangoInvalidException", e);
                }
            }));
        }
        private void StartupTango()
        {
            var framePairs = new List<TangoCoordinateFramePair>()
            {
                new TangoCoordinateFramePair(
                    TangoPoseData.CoordinateFrameStartOfService,
                    TangoPoseData.CoordinateFrameDevice)
            };
            _tangoUpdateListener = new TangoUpdateListener(this);
            _tango.ConnectListener(framePairs, _tangoUpdateListener);
        }

        private TangoConfig SetupTangoConfig(Tango tango)
        {
            try
            {
                // Create a new Tango Configuration and enable the MotionTrackingActivity API.
                TangoConfig config = tango.GetConfig(TangoConfig.ConfigTypeDefault);
                config.PutBoolean(TangoConfig.KeyBooleanMotiontracking, true);
                // Tango service should automatically attempt to recover when it enters an invalid state.
                config.PutBoolean(TangoConfig.KeyBooleanAutorecovery, true);

                config.PutBoolean(TangoConfig.KeyBooleanColorcamera, true);
                config.PutBoolean(TangoConfig.KeyBooleanDepth, true);
                // NOTE: Low latency integration is necessary to achieve a precise alignment of
                // virtual objects with the RBG image and produce a good AR effect.
                config.PutBoolean(TangoConfig.KeyBooleanLowlatencyimuintegration, true);
                // Drift correction allows motion tracking to recover after it loses tracking.
                // The drift corrected pose is is available through the frame pair with
                // base frame AREA_DESCRIPTION and target frame DEVICE.
                config.PutBoolean(TangoConfig.KeyBooleanDriftCorrection, true);
                config.PutInt(TangoConfig.KeyIntDepthMode, TangoConfig.TangoDepthModePointCloud);

                return config;
            }
            catch (TangoErrorException e)
            {
                Log.Error(Tag, "TangoErrorException", e);
                throw;
            }
        }
        protected override void OnPause()
		{
			UrhoSurface.OnPause();
            try
            {
                _isConnected = false;
                _tango.DisconnectCamera(TangoCameraIntrinsics.TangoCameraColor);
                _connectedTextureIdGlThread = INVALID_TEXTURE_ID;
                _tango.Disconnect();
            }
            catch (TangoErrorException e)
            {
                Log.Error(Tag, "TangoErrorException", e);
            }
            base.OnPause();
		}

		public override void OnLowMemory()
		{
			UrhoSurface.OnLowMemory();
			base.OnLowMemory();
		}

		protected override void OnDestroy()
		{
			UrhoSurface.OnDestroy();
			base.OnDestroy();
		}

		public override bool DispatchKeyEvent(KeyEvent e)
		{
			if (!UrhoSurface.DispatchKeyEvent(e))
				return false;
			return base.DispatchKeyEvent(e);
		}

		public override void OnWindowFocusChanged(bool hasFocus)
		{
			UrhoSurface.OnWindowFocusChanged(hasFocus);
			base.OnWindowFocusChanged(hasFocus);
		}

	    public void SetPosition(Vector3 vector3)
	    {
	        if (_scene != null)
	            _scene.SetCameraPositoin(new Vector3(vector3.X, vector3.Z, vector3.Y));
	    }

	    public void SetRotation(Quaternion quaternion)
	    {
	        if (_scene != null)
	        {
                const float kSqrt2Over2 = 0.70710678118654752440084436210485f;
                // Tango frame is a -90 degree rotation about +X from the GL frame.
                var openGLTransformation = new Quaternion(-kSqrt2Over2, 0.0f, 0.0f, kSqrt2Over2);
	            var openglQuaternion = openGLTransformation * quaternion;
	            var urhoQuaternion = new Quaternion(-openglQuaternion.X, -openglQuaternion.Y, openglQuaternion.Z, openglQuaternion.W);
	            urhoQuaternion = urhoQuaternion * GetScreenOrientationQuaternion();
	            if (Resources.Configuration.Orientation == Orientation.Landscape)
	            {
	                
	            }
	            _scene.SetCameraRotation(urhoQuaternion);
	        }
	    }

	    private Quaternion GetScreenOrientationQuaternion()
	    {
            const float kSqrt2Over2 = 0.70710678118654752440084436210485f;
            switch (_windowManager.DefaultDisplay.Rotation)
	        {
	            case SurfaceOrientation.Rotation0:
                    return Quaternion.Identity;
	            case SurfaceOrientation.Rotation180:
                    return new Quaternion(0.0f, 0.0f, -1, 0);
	            case SurfaceOrientation.Rotation270:
	                return new Quaternion(0.0f, 0.0f, kSqrt2Over2, kSqrt2Over2);
	            case SurfaceOrientation.Rotation90:
                    return new Quaternion(0.0f, 0.0f, -kSqrt2Over2, kSqrt2Over2);
	            default:
	                throw new ArgumentOutOfRangeException();
	        }
	    }

	    public void UpdatePointCloud(TangoPointCloudData pointCloud)
	    {
            if (_scene.PointCouldPoints == null)
                return;
            var index = 0;
            var indexStep = 1;
	        if (pointCloud.NumPoints > _scene.PointCouldPoints.Length)
	        {
	            indexStep = (int) (pointCloud.NumPoints/_scene.PointCouldPoints.Length);
	        }
            int j = 0;
            var rot = GetScreenOrientationQuaternion();
            for (j = 0; j < _scene.PointCouldPoints.Length && index < pointCloud.NumPoints; ++j)
            {
                var x = pointCloud.Points.Get(index * 4);
                var y = pointCloud.Points.Get(index * 4 + 1);
                var z = pointCloud.Points.Get(index * 4 + 2);

                var pointCouldPoint = new Vector3(x, y, z);
                Vector3 localPoint;
                Transform(ref pointCouldPoint, ref rot, out localPoint);
                _scene.PointCouldPoints[j] = new Vector3(localPoint.Y, localPoint.X, localPoint.Z);
                index += indexStep;

            }
	        for (; j < _scene.PointCouldPoints.Length; ++j)
	        {
	            _scene.PointCouldPoints[j] = Vector3.Zero;
	        }

	        _scene.IvalidatePointCloud();

            _pointCloudManager.UpdatePointCloud(pointCloud);
        }
        public static void Transform(ref Vector3 vec, ref Quaternion quat, out Vector3 result)
        {
            // Since vec.W == 0, we can optimize quat * vec * quat^-1 as follows:
            // vec + 2.0 * cross(quat.xyz, cross(quat.xyz, vec) + quat.w * vec)
            Vector3 xyz = quat.Xyz, temp, temp2;
            Vector3Cross(ref xyz, ref vec, out temp);
            Vector3.Multiply(ref vec, quat.W, out temp2);
            Vector3.Add(ref temp, ref temp2, out temp);
            Vector3Cross(ref xyz, ref temp, out temp);
            Vector3.Multiply(ref temp, 2, out temp);
            Vector3.Add(ref vec, ref temp, out result);
        }
        public static void Vector3Cross(ref Vector3 left, ref Vector3 right, out Vector3 result)
        {
            result = new Vector3(
                left.Y * right.Z - left.Z * right.Y,
                left.Z * right.X - left.X * right.Z,
                left.X * right.Y - left.Y * right.X);
        }

    }
}