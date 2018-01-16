using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Google.Atap.Tangoservice {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.google.atap.tangoservice']/class[@name='TangoConfig']"
	[global::Android.Runtime.Register ("com/google/atap/tangoservice/TangoConfig", DoNotGenerateAcw=true)]
	public partial class TangoConfig : global::Java.Lang.Object, global::Android.OS.IParcelable {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.atap.tangoservice']/class[@name='TangoConfig']/field[@name='CONFIG_TYPE_AREA_DESCRIPTION']"
		[Register ("CONFIG_TYPE_AREA_DESCRIPTION")]
		public const int ConfigTypeAreaDescription = (int) 3;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.atap.tangoservice']/class[@name='TangoConfig']/field[@name='CONFIG_TYPE_CURRENT']"
		[Register ("CONFIG_TYPE_CURRENT")]
		public const int ConfigTypeCurrent = (int) 1;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.atap.tangoservice']/class[@name='TangoConfig']/field[@name='CONFIG_TYPE_DEFAULT']"
		[Register ("CONFIG_TYPE_DEFAULT")]
		public const int ConfigTypeDefault = (int) 0;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.atap.tangoservice']/class[@name='TangoConfig']/field[@name='CONFIG_TYPE_MOTION_TRACKING']"
		[Register ("CONFIG_TYPE_MOTION_TRACKING")]
		public const int ConfigTypeMotionTracking = (int) 2;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.atap.tangoservice']/class[@name='TangoConfig']/field[@name='CONFIG_TYPE_RUNTIME']"
		[Register ("CONFIG_TYPE_RUNTIME")]
		public const int ConfigTypeRuntime = (int) 4;

		static IntPtr CREATOR_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.atap.tangoservice']/class[@name='TangoConfig']/field[@name='CREATOR']"
		[Register ("CREATOR")]
		public static global::Android.OS.IParcelableCreator Creator {
			get {
				if (CREATOR_jfieldId == IntPtr.Zero)
					CREATOR_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "CREATOR", "Landroid/os/Parcelable$Creator;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, CREATOR_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Android.OS.IParcelableCreator> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.atap.tangoservice']/class[@name='TangoConfig']/field[@name='KEY_BOOLEAN_AUTORECOVERY']"
		[Register ("KEY_BOOLEAN_AUTORECOVERY")]
		public const string KeyBooleanAutorecovery = (string) "config_enable_auto_recovery";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.atap.tangoservice']/class[@name='TangoConfig']/field[@name='KEY_BOOLEAN_COLORCAMERA']"
		[Register ("KEY_BOOLEAN_COLORCAMERA")]
		public const string KeyBooleanColorcamera = (string) "config_enable_color_camera";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.atap.tangoservice']/class[@name='TangoConfig']/field[@name='KEY_BOOLEAN_DATASETRECORDING']"
		[Register ("KEY_BOOLEAN_DATASETRECORDING")]
		public const string KeyBooleanDatasetrecording = (string) "config_enable_dataset_recording";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.atap.tangoservice']/class[@name='TangoConfig']/field[@name='KEY_BOOLEAN_DEPTH']"
		[Register ("KEY_BOOLEAN_DEPTH")]
		public const string KeyBooleanDepth = (string) "config_enable_depth";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.atap.tangoservice']/class[@name='TangoConfig']/field[@name='KEY_BOOLEAN_DRIFT_CORRECTION']"
		[Register ("KEY_BOOLEAN_DRIFT_CORRECTION")]
		public const string KeyBooleanDriftCorrection = (string) "config_enable_drift_correction";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.atap.tangoservice']/class[@name='TangoConfig']/field[@name='KEY_BOOLEAN_EXPERIMENTAL_LOADDATASETUUID']"
		[Register ("KEY_BOOLEAN_EXPERIMENTAL_LOADDATASETUUID")]
		public const string KeyBooleanExperimentalLoaddatasetuuid = (string) "config_experimental_load_dataset_UUID";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.atap.tangoservice']/class[@name='TangoConfig']/field[@name='KEY_BOOLEAN_HIGH_RATE_POSE']"
		[Register ("KEY_BOOLEAN_HIGH_RATE_POSE")]
		public const string KeyBooleanHighRatePose = (string) "config_high_rate_pose";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.atap.tangoservice']/class[@name='TangoConfig']/field[@name='KEY_BOOLEAN_LEARNINGMODE']"
		[Register ("KEY_BOOLEAN_LEARNINGMODE")]
		public const string KeyBooleanLearningmode = (string) "config_enable_learning_mode";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.atap.tangoservice']/class[@name='TangoConfig']/field[@name='KEY_BOOLEAN_LOWLATENCYIMUINTEGRATION']"
		[Register ("KEY_BOOLEAN_LOWLATENCYIMUINTEGRATION")]
		public const string KeyBooleanLowlatencyimuintegration = (string) "config_enable_low_latency_imu_integration";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.atap.tangoservice']/class[@name='TangoConfig']/field[@name='KEY_BOOLEAN_MOTIONTRACKING']"
		[Register ("KEY_BOOLEAN_MOTIONTRACKING")]
		public const string KeyBooleanMotiontracking = (string) "config_enable_motion_tracking";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.atap.tangoservice']/class[@name='TangoConfig']/field[@name='KEY_BOOLEAN_SMOOTH_POSE']"
		[Register ("KEY_BOOLEAN_SMOOTH_POSE")]
		public const string KeyBooleanSmoothPose = (string) "config_smooth_pose";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.atap.tangoservice']/class[@name='TangoConfig']/field[@name='KEY_BOOLEAN_USE_3DOF_FALLBACK']"
		[Register ("KEY_BOOLEAN_USE_3DOF_FALLBACK")]
		public const string KeyBooleanUse3dofFallback = (string) "config_experimental_3dof_fallback";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.atap.tangoservice']/class[@name='TangoConfig']/field[@name='KEY_DOUBLE_DEPTHPERIODINSECONDS']"
		[Register ("KEY_DOUBLE_DEPTHPERIODINSECONDS")]
		public const string KeyDoubleDepthperiodinseconds = (string) "depth_period_in_seconds";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.atap.tangoservice']/class[@name='TangoConfig']/field[@name='KEY_INT_DATASETRECORDING_MODE']"
		[Register ("KEY_INT_DATASETRECORDING_MODE")]
		public const string KeyIntDatasetrecordingMode = (string) "config_dataset_recording_mode";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.atap.tangoservice']/class[@name='TangoConfig']/field[@name='KEY_INT_DEPTH_MODE']"
		[Register ("KEY_INT_DEPTH_MODE")]
		public const string KeyIntDepthMode = (string) "config_depth_mode";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.atap.tangoservice']/class[@name='TangoConfig']/field[@name='KEY_INT_EXPERIMENTAL_RUNTIME_RECORDING_CONTROL']"
		[Register ("KEY_INT_EXPERIMENTAL_RUNTIME_RECORDING_CONTROL")]
		public const string KeyIntExperimentalRuntimeRecordingControl = (string) "config_runtime_recording_control";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.atap.tangoservice']/class[@name='TangoConfig']/field[@name='KEY_INT_MAXPOINTCLOUDELEMENTS']"
		[Register ("KEY_INT_MAXPOINTCLOUDELEMENTS")]
		public const string KeyIntMaxpointcloudelements = (string) "max_point_cloud_elements";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.atap.tangoservice']/class[@name='TangoConfig']/field[@name='KEY_INT_RUNTIME_DEPTH_FRAMERATE']"
		[Register ("KEY_INT_RUNTIME_DEPTH_FRAMERATE")]
		public const string KeyIntRuntimeDepthFramerate = (string) "config_runtime_depth_framerate";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.atap.tangoservice']/class[@name='TangoConfig']/field[@name='KEY_STRING_AREADESCRIPTION']"
		[Register ("KEY_STRING_AREADESCRIPTION")]
		public const string KeyStringAreadescription = (string) "config_load_area_description_UUID";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.atap.tangoservice']/class[@name='TangoConfig']/field[@name='KEY_STRING_DATASETS_PATH']"
		[Register ("KEY_STRING_DATASETS_PATH")]
		public const string KeyStringDatasetsPath = (string) "config_datasets_path";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.atap.tangoservice']/class[@name='TangoConfig']/field[@name='KEY_STRING_SERVICEVERSION']"
		[Register ("KEY_STRING_SERVICEVERSION")]
		public const string KeyStringServiceversion = (string) "tango_service_library_version";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.atap.tangoservice']/class[@name='TangoConfig']/field[@name='TANGO_DATASETRECORDING_MODE_ALL']"
		[Register ("TANGO_DATASETRECORDING_MODE_ALL")]
		public const int TangoDatasetrecordingModeAll = (int) 3;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.atap.tangoservice']/class[@name='TangoConfig']/field[@name='TANGO_DATASETRECORDING_MODE_MOTION_TRACKING']"
		[Register ("TANGO_DATASETRECORDING_MODE_MOTION_TRACKING")]
		public const int TangoDatasetrecordingModeMotionTracking = (int) 0;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.atap.tangoservice']/class[@name='TangoConfig']/field[@name='TANGO_DATASETRECORDING_MODE_MOTION_TRACKING_AND_FISHEYE']"
		[Register ("TANGO_DATASETRECORDING_MODE_MOTION_TRACKING_AND_FISHEYE")]
		public const int TangoDatasetrecordingModeMotionTrackingAndFisheye = (int) 2;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.atap.tangoservice']/class[@name='TangoConfig']/field[@name='TANGO_DATASETRECORDING_MODE_SCENE_RECONSTRUCTION']"
		[Register ("TANGO_DATASETRECORDING_MODE_SCENE_RECONSTRUCTION")]
		public const int TangoDatasetrecordingModeSceneReconstruction = (int) 1;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.atap.tangoservice']/class[@name='TangoConfig']/field[@name='TANGO_DEPTH_MODE_POINT_CLOUD']"
		[Register ("TANGO_DEPTH_MODE_POINT_CLOUD")]
		public const int TangoDepthModePointCloud = (int) 0;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.atap.tangoservice']/class[@name='TangoConfig']/field[@name='TANGO_DEPTH_MODE_XYZ_IJ']"
		[Register ("TANGO_DEPTH_MODE_XYZ_IJ")]
		public const int TangoDepthModeXyzIj = (int) -1;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.atap.tangoservice']/class[@name='TangoConfig']/field[@name='TANGO_RUNTIME_RECORDING_NO_CHANGE']"
		[Register ("TANGO_RUNTIME_RECORDING_NO_CHANGE")]
		public const int TangoRuntimeRecordingNoChange = (int) 0;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.atap.tangoservice']/class[@name='TangoConfig']/field[@name='TANGO_RUNTIME_RECORDING_START']"
		[Register ("TANGO_RUNTIME_RECORDING_START")]
		public const int TangoRuntimeRecordingStart = (int) 1;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.atap.tangoservice']/class[@name='TangoConfig']/field[@name='TANGO_RUNTIME_RECORDING_STOP']"
		[Register ("TANGO_RUNTIME_RECORDING_STOP")]
		public const int TangoRuntimeRecordingStop = (int) 2;
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/google/atap/tangoservice/TangoConfig", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (TangoConfig); }
		}

		protected TangoConfig (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.google.atap.tangoservice']/class[@name='TangoConfig']/constructor[@name='TangoConfig' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe TangoConfig ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (TangoConfig)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "()V"),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
					return;
				}

				if (id_ctor == IntPtr.Zero)
					id_ctor = JNIEnv.GetMethodID (class_ref, "<init>", "()V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor);
			} finally {
			}
		}

		static Delegate cb_describeContents;
#pragma warning disable 0169
		static Delegate GetDescribeContentsHandler ()
		{
			if (cb_describeContents == null)
				cb_describeContents = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_DescribeContents);
			return cb_describeContents;
		}

		static int n_DescribeContents (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Google.Atap.Tangoservice.TangoConfig __this = global::Java.Lang.Object.GetObject<global::Com.Google.Atap.Tangoservice.TangoConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.DescribeContents ();
		}
#pragma warning restore 0169

		static IntPtr id_describeContents;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.atap.tangoservice']/class[@name='TangoConfig']/method[@name='describeContents' and count(parameter)=0]"
		[Register ("describeContents", "()I", "GetDescribeContentsHandler")]
		public virtual unsafe int DescribeContents ()
		{
			if (id_describeContents == IntPtr.Zero)
				id_describeContents = JNIEnv.GetMethodID (class_ref, "describeContents", "()I");
			try {

				if (GetType () == ThresholdType)
					return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_describeContents);
				else
					return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "describeContents", "()I"));
			} finally {
			}
		}

		static Delegate cb_getBoolean_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGetBoolean_Ljava_lang_String_Handler ()
		{
			if (cb_getBoolean_Ljava_lang_String_ == null)
				cb_getBoolean_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_GetBoolean_Ljava_lang_String_);
			return cb_getBoolean_Ljava_lang_String_;
		}

		static bool n_GetBoolean_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Google.Atap.Tangoservice.TangoConfig __this = global::Java.Lang.Object.GetObject<global::Com.Google.Atap.Tangoservice.TangoConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.GetBoolean (p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getBoolean_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.atap.tangoservice']/class[@name='TangoConfig']/method[@name='getBoolean' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getBoolean", "(Ljava/lang/String;)Z", "GetGetBoolean_Ljava_lang_String_Handler")]
		public virtual unsafe bool GetBoolean (string p0)
		{
			if (id_getBoolean_Ljava_lang_String_ == IntPtr.Zero)
				id_getBoolean_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "getBoolean", "(Ljava/lang/String;)Z");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				bool __ret;
				if (GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_getBoolean_Ljava_lang_String_, __args);
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getBoolean", "(Ljava/lang/String;)Z"), __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_getDouble_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGetDouble_Ljava_lang_String_Handler ()
		{
			if (cb_getDouble_Ljava_lang_String_ == null)
				cb_getDouble_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, double>) n_GetDouble_Ljava_lang_String_);
			return cb_getDouble_Ljava_lang_String_;
		}

		static double n_GetDouble_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Google.Atap.Tangoservice.TangoConfig __this = global::Java.Lang.Object.GetObject<global::Com.Google.Atap.Tangoservice.TangoConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			double __ret = __this.GetDouble (p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getDouble_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.atap.tangoservice']/class[@name='TangoConfig']/method[@name='getDouble' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getDouble", "(Ljava/lang/String;)D", "GetGetDouble_Ljava_lang_String_Handler")]
		public virtual unsafe double GetDouble (string p0)
		{
			if (id_getDouble_Ljava_lang_String_ == IntPtr.Zero)
				id_getDouble_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "getDouble", "(Ljava/lang/String;)D");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				double __ret;
				if (GetType () == ThresholdType)
					__ret = JNIEnv.CallDoubleMethod (((global::Java.Lang.Object) this).Handle, id_getDouble_Ljava_lang_String_, __args);
				else
					__ret = JNIEnv.CallNonvirtualDoubleMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getDouble", "(Ljava/lang/String;)D"), __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_getInt_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGetInt_Ljava_lang_String_Handler ()
		{
			if (cb_getInt_Ljava_lang_String_ == null)
				cb_getInt_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, int>) n_GetInt_Ljava_lang_String_);
			return cb_getInt_Ljava_lang_String_;
		}

		static int n_GetInt_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Google.Atap.Tangoservice.TangoConfig __this = global::Java.Lang.Object.GetObject<global::Com.Google.Atap.Tangoservice.TangoConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.GetInt (p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getInt_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.atap.tangoservice']/class[@name='TangoConfig']/method[@name='getInt' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getInt", "(Ljava/lang/String;)I", "GetGetInt_Ljava_lang_String_Handler")]
		public virtual unsafe int GetInt (string p0)
		{
			if (id_getInt_Ljava_lang_String_ == IntPtr.Zero)
				id_getInt_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "getInt", "(Ljava/lang/String;)I");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				int __ret;
				if (GetType () == ThresholdType)
					__ret = JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getInt_Ljava_lang_String_, __args);
				else
					__ret = JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getInt", "(Ljava/lang/String;)I"), __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_getLong_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGetLong_Ljava_lang_String_Handler ()
		{
			if (cb_getLong_Ljava_lang_String_ == null)
				cb_getLong_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, long>) n_GetLong_Ljava_lang_String_);
			return cb_getLong_Ljava_lang_String_;
		}

		static long n_GetLong_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Google.Atap.Tangoservice.TangoConfig __this = global::Java.Lang.Object.GetObject<global::Com.Google.Atap.Tangoservice.TangoConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			long __ret = __this.GetLong (p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getLong_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.atap.tangoservice']/class[@name='TangoConfig']/method[@name='getLong' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getLong", "(Ljava/lang/String;)J", "GetGetLong_Ljava_lang_String_Handler")]
		public virtual unsafe long GetLong (string p0)
		{
			if (id_getLong_Ljava_lang_String_ == IntPtr.Zero)
				id_getLong_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "getLong", "(Ljava/lang/String;)J");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				long __ret;
				if (GetType () == ThresholdType)
					__ret = JNIEnv.CallLongMethod (((global::Java.Lang.Object) this).Handle, id_getLong_Ljava_lang_String_, __args);
				else
					__ret = JNIEnv.CallNonvirtualLongMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getLong", "(Ljava/lang/String;)J"), __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_getString_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGetString_Ljava_lang_String_Handler ()
		{
			if (cb_getString_Ljava_lang_String_ == null)
				cb_getString_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetString_Ljava_lang_String_);
			return cb_getString_Ljava_lang_String_;
		}

		static IntPtr n_GetString_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Google.Atap.Tangoservice.TangoConfig __this = global::Java.Lang.Object.GetObject<global::Com.Google.Atap.Tangoservice.TangoConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.GetString (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getString_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.atap.tangoservice']/class[@name='TangoConfig']/method[@name='getString' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getString", "(Ljava/lang/String;)Ljava/lang/String;", "GetGetString_Ljava_lang_String_Handler")]
		public virtual unsafe string GetString (string p0)
		{
			if (id_getString_Ljava_lang_String_ == IntPtr.Zero)
				id_getString_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "getString", "(Ljava/lang/String;)Ljava/lang/String;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				string __ret;
				if (GetType () == ThresholdType)
					__ret = JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getString_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getString", "(Ljava/lang/String;)Ljava/lang/String;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_keySet;
#pragma warning disable 0169
		static Delegate GetKeySetHandler ()
		{
			if (cb_keySet == null)
				cb_keySet = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_KeySet);
			return cb_keySet;
		}

		static IntPtr n_KeySet (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Google.Atap.Tangoservice.TangoConfig __this = global::Java.Lang.Object.GetObject<global::Com.Google.Atap.Tangoservice.TangoConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaSet<string>.ToLocalJniHandle (__this.KeySet ());
		}
#pragma warning restore 0169

		static IntPtr id_keySet;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.atap.tangoservice']/class[@name='TangoConfig']/method[@name='keySet' and count(parameter)=0]"
		[Register ("keySet", "()Ljava/util/Set;", "GetKeySetHandler")]
		public virtual unsafe global::System.Collections.Generic.ICollection<string> KeySet ()
		{
			if (id_keySet == IntPtr.Zero)
				id_keySet = JNIEnv.GetMethodID (class_ref, "keySet", "()Ljava/util/Set;");
			try {

				if (GetType () == ThresholdType)
					return global::Android.Runtime.JavaSet<string>.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_keySet), JniHandleOwnership.TransferLocalRef);
				else
					return global::Android.Runtime.JavaSet<string>.FromJniHandle (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "keySet", "()Ljava/util/Set;")), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_putBoolean_Ljava_lang_String_Z;
#pragma warning disable 0169
		static Delegate GetPutBoolean_Ljava_lang_String_ZHandler ()
		{
			if (cb_putBoolean_Ljava_lang_String_Z == null)
				cb_putBoolean_Ljava_lang_String_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, bool>) n_PutBoolean_Ljava_lang_String_Z);
			return cb_putBoolean_Ljava_lang_String_Z;
		}

		static void n_PutBoolean_Ljava_lang_String_Z (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, bool p1)
		{
			global::Com.Google.Atap.Tangoservice.TangoConfig __this = global::Java.Lang.Object.GetObject<global::Com.Google.Atap.Tangoservice.TangoConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.PutBoolean (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_putBoolean_Ljava_lang_String_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.atap.tangoservice']/class[@name='TangoConfig']/method[@name='putBoolean' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='boolean']]"
		[Register ("putBoolean", "(Ljava/lang/String;Z)V", "GetPutBoolean_Ljava_lang_String_ZHandler")]
		public virtual unsafe void PutBoolean (string p0, bool p1)
		{
			if (id_putBoolean_Ljava_lang_String_Z == IntPtr.Zero)
				id_putBoolean_Ljava_lang_String_Z = JNIEnv.GetMethodID (class_ref, "putBoolean", "(Ljava/lang/String;Z)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_putBoolean_Ljava_lang_String_Z, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "putBoolean", "(Ljava/lang/String;Z)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_putDouble_Ljava_lang_String_D;
#pragma warning disable 0169
		static Delegate GetPutDouble_Ljava_lang_String_DHandler ()
		{
			if (cb_putDouble_Ljava_lang_String_D == null)
				cb_putDouble_Ljava_lang_String_D = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, double>) n_PutDouble_Ljava_lang_String_D);
			return cb_putDouble_Ljava_lang_String_D;
		}

		static void n_PutDouble_Ljava_lang_String_D (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, double p1)
		{
			global::Com.Google.Atap.Tangoservice.TangoConfig __this = global::Java.Lang.Object.GetObject<global::Com.Google.Atap.Tangoservice.TangoConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.PutDouble (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_putDouble_Ljava_lang_String_D;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.atap.tangoservice']/class[@name='TangoConfig']/method[@name='putDouble' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='double']]"
		[Register ("putDouble", "(Ljava/lang/String;D)V", "GetPutDouble_Ljava_lang_String_DHandler")]
		public virtual unsafe void PutDouble (string p0, double p1)
		{
			if (id_putDouble_Ljava_lang_String_D == IntPtr.Zero)
				id_putDouble_Ljava_lang_String_D = JNIEnv.GetMethodID (class_ref, "putDouble", "(Ljava/lang/String;D)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_putDouble_Ljava_lang_String_D, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "putDouble", "(Ljava/lang/String;D)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_putInt_Ljava_lang_String_I;
#pragma warning disable 0169
		static Delegate GetPutInt_Ljava_lang_String_IHandler ()
		{
			if (cb_putInt_Ljava_lang_String_I == null)
				cb_putInt_Ljava_lang_String_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, int>) n_PutInt_Ljava_lang_String_I);
			return cb_putInt_Ljava_lang_String_I;
		}

		static void n_PutInt_Ljava_lang_String_I (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1)
		{
			global::Com.Google.Atap.Tangoservice.TangoConfig __this = global::Java.Lang.Object.GetObject<global::Com.Google.Atap.Tangoservice.TangoConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.PutInt (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_putInt_Ljava_lang_String_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.atap.tangoservice']/class[@name='TangoConfig']/method[@name='putInt' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='int']]"
		[Register ("putInt", "(Ljava/lang/String;I)V", "GetPutInt_Ljava_lang_String_IHandler")]
		public virtual unsafe void PutInt (string p0, int p1)
		{
			if (id_putInt_Ljava_lang_String_I == IntPtr.Zero)
				id_putInt_Ljava_lang_String_I = JNIEnv.GetMethodID (class_ref, "putInt", "(Ljava/lang/String;I)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_putInt_Ljava_lang_String_I, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "putInt", "(Ljava/lang/String;I)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_putLong_Ljava_lang_String_J;
#pragma warning disable 0169
		static Delegate GetPutLong_Ljava_lang_String_JHandler ()
		{
			if (cb_putLong_Ljava_lang_String_J == null)
				cb_putLong_Ljava_lang_String_J = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, long>) n_PutLong_Ljava_lang_String_J);
			return cb_putLong_Ljava_lang_String_J;
		}

		static void n_PutLong_Ljava_lang_String_J (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, long p1)
		{
			global::Com.Google.Atap.Tangoservice.TangoConfig __this = global::Java.Lang.Object.GetObject<global::Com.Google.Atap.Tangoservice.TangoConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.PutLong (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_putLong_Ljava_lang_String_J;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.atap.tangoservice']/class[@name='TangoConfig']/method[@name='putLong' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='long']]"
		[Register ("putLong", "(Ljava/lang/String;J)V", "GetPutLong_Ljava_lang_String_JHandler")]
		public virtual unsafe void PutLong (string p0, long p1)
		{
			if (id_putLong_Ljava_lang_String_J == IntPtr.Zero)
				id_putLong_Ljava_lang_String_J = JNIEnv.GetMethodID (class_ref, "putLong", "(Ljava/lang/String;J)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_putLong_Ljava_lang_String_J, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "putLong", "(Ljava/lang/String;J)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_putString_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetPutString_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_putString_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_putString_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_PutString_Ljava_lang_String_Ljava_lang_String_);
			return cb_putString_Ljava_lang_String_Ljava_lang_String_;
		}

		static void n_PutString_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Google.Atap.Tangoservice.TangoConfig __this = global::Java.Lang.Object.GetObject<global::Com.Google.Atap.Tangoservice.TangoConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.PutString (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_putString_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.atap.tangoservice']/class[@name='TangoConfig']/method[@name='putString' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("putString", "(Ljava/lang/String;Ljava/lang/String;)V", "GetPutString_Ljava_lang_String_Ljava_lang_String_Handler")]
		public virtual unsafe void PutString (string p0, string p1)
		{
			if (id_putString_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_putString_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "putString", "(Ljava/lang/String;Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_putString_Ljava_lang_String_Ljava_lang_String_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "putString", "(Ljava/lang/String;Ljava/lang/String;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static Delegate cb_readFromParcel_Landroid_os_Parcel_;
#pragma warning disable 0169
		static Delegate GetReadFromParcel_Landroid_os_Parcel_Handler ()
		{
			if (cb_readFromParcel_Landroid_os_Parcel_ == null)
				cb_readFromParcel_Landroid_os_Parcel_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_ReadFromParcel_Landroid_os_Parcel_);
			return cb_readFromParcel_Landroid_os_Parcel_;
		}

		static void n_ReadFromParcel_Landroid_os_Parcel_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Google.Atap.Tangoservice.TangoConfig __this = global::Java.Lang.Object.GetObject<global::Com.Google.Atap.Tangoservice.TangoConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.Parcel p0 = global::Java.Lang.Object.GetObject<global::Android.OS.Parcel> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.ReadFromParcel (p0);
		}
#pragma warning restore 0169

		static IntPtr id_readFromParcel_Landroid_os_Parcel_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.atap.tangoservice']/class[@name='TangoConfig']/method[@name='readFromParcel' and count(parameter)=1 and parameter[1][@type='android.os.Parcel']]"
		[Register ("readFromParcel", "(Landroid/os/Parcel;)V", "GetReadFromParcel_Landroid_os_Parcel_Handler")]
		public virtual unsafe void ReadFromParcel (global::Android.OS.Parcel p0)
		{
			if (id_readFromParcel_Landroid_os_Parcel_ == IntPtr.Zero)
				id_readFromParcel_Landroid_os_Parcel_ = JNIEnv.GetMethodID (class_ref, "readFromParcel", "(Landroid/os/Parcel;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_readFromParcel_Landroid_os_Parcel_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "readFromParcel", "(Landroid/os/Parcel;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_writeToParcel_Landroid_os_Parcel_I;
#pragma warning disable 0169
		static Delegate GetWriteToParcel_Landroid_os_Parcel_IHandler ()
		{
			if (cb_writeToParcel_Landroid_os_Parcel_I == null)
				cb_writeToParcel_Landroid_os_Parcel_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, int>) n_WriteToParcel_Landroid_os_Parcel_I);
			return cb_writeToParcel_Landroid_os_Parcel_I;
		}

		static void n_WriteToParcel_Landroid_os_Parcel_I (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int native_p1)
		{
			global::Com.Google.Atap.Tangoservice.TangoConfig __this = global::Java.Lang.Object.GetObject<global::Com.Google.Atap.Tangoservice.TangoConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.Parcel p0 = global::Java.Lang.Object.GetObject<global::Android.OS.Parcel> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.ParcelableWriteFlags p1 = (global::Android.OS.ParcelableWriteFlags) native_p1;
			__this.WriteToParcel (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_writeToParcel_Landroid_os_Parcel_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.atap.tangoservice']/class[@name='TangoConfig']/method[@name='writeToParcel' and count(parameter)=2 and parameter[1][@type='android.os.Parcel'] and parameter[2][@type='int']]"
		[Register ("writeToParcel", "(Landroid/os/Parcel;I)V", "GetWriteToParcel_Landroid_os_Parcel_IHandler")]
		public virtual unsafe void WriteToParcel (global::Android.OS.Parcel p0, [global::Android.Runtime.GeneratedEnum] global::Android.OS.ParcelableWriteFlags p1)
		{
			if (id_writeToParcel_Landroid_os_Parcel_I == IntPtr.Zero)
				id_writeToParcel_Landroid_os_Parcel_I = JNIEnv.GetMethodID (class_ref, "writeToParcel", "(Landroid/os/Parcel;I)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue ((int) p1);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_writeToParcel_Landroid_os_Parcel_I, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "writeToParcel", "(Landroid/os/Parcel;I)V"), __args);
			} finally {
			}
		}

	}
}
