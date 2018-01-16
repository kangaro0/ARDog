using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Google.Atap.Tangoservice {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.google.atap.tangoservice']/class[@name='TangoPoseData']"
	[global::Android.Runtime.Register ("com/google/atap/tangoservice/TangoPoseData", DoNotGenerateAcw=true)]
	public partial class TangoPoseData : global::Java.Lang.Object, global::Android.OS.IParcelable {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.atap.tangoservice']/class[@name='TangoPoseData']/field[@name='COORDINATE_FRAME_AREA_DESCRIPTION']"
		[Register ("COORDINATE_FRAME_AREA_DESCRIPTION")]
		public const int CoordinateFrameAreaDescription = (int) 1;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.atap.tangoservice']/class[@name='TangoPoseData']/field[@name='COORDINATE_FRAME_CAMERA_COLOR']"
		[Register ("COORDINATE_FRAME_CAMERA_COLOR")]
		public const int CoordinateFrameCameraColor = (int) 7;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.atap.tangoservice']/class[@name='TangoPoseData']/field[@name='COORDINATE_FRAME_CAMERA_DEPTH']"
		[Register ("COORDINATE_FRAME_CAMERA_DEPTH")]
		public const int CoordinateFrameCameraDepth = (int) 8;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.atap.tangoservice']/class[@name='TangoPoseData']/field[@name='COORDINATE_FRAME_CAMERA_FISHEYE']"
		[Register ("COORDINATE_FRAME_CAMERA_FISHEYE")]
		public const int CoordinateFrameCameraFisheye = (int) 9;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.atap.tangoservice']/class[@name='TangoPoseData']/field[@name='COORDINATE_FRAME_DEVICE']"
		[Register ("COORDINATE_FRAME_DEVICE")]
		public const int CoordinateFrameDevice = (int) 4;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.atap.tangoservice']/class[@name='TangoPoseData']/field[@name='COORDINATE_FRAME_DISPLAY']"
		[Register ("COORDINATE_FRAME_DISPLAY")]
		public const int CoordinateFrameDisplay = (int) 6;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.atap.tangoservice']/class[@name='TangoPoseData']/field[@name='COORDINATE_FRAME_GLOBAL_WGS84']"
		[Register ("COORDINATE_FRAME_GLOBAL_WGS84")]
		public const int CoordinateFrameGlobalWgs84 = (int) 0;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.atap.tangoservice']/class[@name='TangoPoseData']/field[@name='COORDINATE_FRAME_IMU']"
		[Register ("COORDINATE_FRAME_IMU")]
		public const int CoordinateFrameImu = (int) 5;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.atap.tangoservice']/class[@name='TangoPoseData']/field[@name='COORDINATE_FRAME_PREVIOUS_DEVICE_POSE']"
		[Register ("COORDINATE_FRAME_PREVIOUS_DEVICE_POSE")]
		public const int CoordinateFramePreviousDevicePose = (int) 3;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.atap.tangoservice']/class[@name='TangoPoseData']/field[@name='COORDINATE_FRAME_START_OF_SERVICE']"
		[Register ("COORDINATE_FRAME_START_OF_SERVICE")]
		public const int CoordinateFrameStartOfService = (int) 2;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.atap.tangoservice']/class[@name='TangoPoseData']/field[@name='COORDINATE_FRAME_UUID']"
		[Register ("COORDINATE_FRAME_UUID")]
		public const int CoordinateFrameUuid = (int) 10;

		static IntPtr CREATOR_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.atap.tangoservice']/class[@name='TangoPoseData']/field[@name='CREATOR']"
		[Register ("CREATOR")]
		public static global::Android.OS.IParcelableCreator Creator {
			get {
				if (CREATOR_jfieldId == IntPtr.Zero)
					CREATOR_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "CREATOR", "Landroid/os/Parcelable$Creator;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, CREATOR_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Android.OS.IParcelableCreator> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr FRAME_NAMES_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.atap.tangoservice']/class[@name='TangoPoseData']/field[@name='FRAME_NAMES']"
		[Register ("FRAME_NAMES")]
		public static IList<string> FrameNames {
			get {
				if (FRAME_NAMES_jfieldId == IntPtr.Zero)
					FRAME_NAMES_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "FRAME_NAMES", "[Ljava/lang/String;");
				return global::Android.Runtime.JavaArray<string>.FromJniHandle (JNIEnv.GetStaticObjectField (class_ref, FRAME_NAMES_jfieldId), JniHandleOwnership.TransferLocalRef);
			}
		}

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.atap.tangoservice']/class[@name='TangoPoseData']/field[@name='INDEX_ROTATION_W']"
		[Register ("INDEX_ROTATION_W")]
		public const int IndexRotationW = (int) 3;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.atap.tangoservice']/class[@name='TangoPoseData']/field[@name='INDEX_ROTATION_X']"
		[Register ("INDEX_ROTATION_X")]
		public const int IndexRotationX = (int) 0;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.atap.tangoservice']/class[@name='TangoPoseData']/field[@name='INDEX_ROTATION_Y']"
		[Register ("INDEX_ROTATION_Y")]
		public const int IndexRotationY = (int) 1;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.atap.tangoservice']/class[@name='TangoPoseData']/field[@name='INDEX_ROTATION_Z']"
		[Register ("INDEX_ROTATION_Z")]
		public const int IndexRotationZ = (int) 2;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.atap.tangoservice']/class[@name='TangoPoseData']/field[@name='INDEX_TRANSLATION_X']"
		[Register ("INDEX_TRANSLATION_X")]
		public const int IndexTranslationX = (int) 0;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.atap.tangoservice']/class[@name='TangoPoseData']/field[@name='INDEX_TRANSLATION_Y']"
		[Register ("INDEX_TRANSLATION_Y")]
		public const int IndexTranslationY = (int) 1;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.atap.tangoservice']/class[@name='TangoPoseData']/field[@name='INDEX_TRANSLATION_Z']"
		[Register ("INDEX_TRANSLATION_Z")]
		public const int IndexTranslationZ = (int) 2;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.atap.tangoservice']/class[@name='TangoPoseData']/field[@name='POSE_INITIALIZING']"
		[Register ("POSE_INITIALIZING")]
		public const int PoseInitializing = (int) 0;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.atap.tangoservice']/class[@name='TangoPoseData']/field[@name='POSE_INVALID']"
		[Register ("POSE_INVALID")]
		public const int PoseInvalid = (int) 2;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.atap.tangoservice']/class[@name='TangoPoseData']/field[@name='POSE_UNKNOWN']"
		[Register ("POSE_UNKNOWN")]
		public const int PoseUnknown = (int) 3;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.atap.tangoservice']/class[@name='TangoPoseData']/field[@name='POSE_VALID']"
		[Register ("POSE_VALID")]
		public const int PoseValid = (int) 1;

		static IntPtr STATUS_NAMES_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.atap.tangoservice']/class[@name='TangoPoseData']/field[@name='STATUS_NAMES']"
		[Register ("STATUS_NAMES")]
		public static IList<string> StatusNames {
			get {
				if (STATUS_NAMES_jfieldId == IntPtr.Zero)
					STATUS_NAMES_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "STATUS_NAMES", "[Ljava/lang/String;");
				return global::Android.Runtime.JavaArray<string>.FromJniHandle (JNIEnv.GetStaticObjectField (class_ref, STATUS_NAMES_jfieldId), JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr accuracy_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.atap.tangoservice']/class[@name='TangoPoseData']/field[@name='accuracy']"
		[Register ("accuracy")]
		public float Accuracy {
			get {
				if (accuracy_jfieldId == IntPtr.Zero)
					accuracy_jfieldId = JNIEnv.GetFieldID (class_ref, "accuracy", "F");
				return JNIEnv.GetFloatField (((global::Java.Lang.Object) this).Handle, accuracy_jfieldId);
			}
			set {
				if (accuracy_jfieldId == IntPtr.Zero)
					accuracy_jfieldId = JNIEnv.GetFieldID (class_ref, "accuracy", "F");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, accuracy_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr baseFrame_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.atap.tangoservice']/class[@name='TangoPoseData']/field[@name='baseFrame']"
		[Register ("baseFrame")]
		public int BaseFrame {
			get {
				if (baseFrame_jfieldId == IntPtr.Zero)
					baseFrame_jfieldId = JNIEnv.GetFieldID (class_ref, "baseFrame", "I");
				return JNIEnv.GetIntField (((global::Java.Lang.Object) this).Handle, baseFrame_jfieldId);
			}
			set {
				if (baseFrame_jfieldId == IntPtr.Zero)
					baseFrame_jfieldId = JNIEnv.GetFieldID (class_ref, "baseFrame", "I");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, baseFrame_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr confidence_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.atap.tangoservice']/class[@name='TangoPoseData']/field[@name='confidence']"
		[Register ("confidence")]
		public int Confidence {
			get {
				if (confidence_jfieldId == IntPtr.Zero)
					confidence_jfieldId = JNIEnv.GetFieldID (class_ref, "confidence", "I");
				return JNIEnv.GetIntField (((global::Java.Lang.Object) this).Handle, confidence_jfieldId);
			}
			set {
				if (confidence_jfieldId == IntPtr.Zero)
					confidence_jfieldId = JNIEnv.GetFieldID (class_ref, "confidence", "I");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, confidence_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr rotation_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.atap.tangoservice']/class[@name='TangoPoseData']/field[@name='rotation']"
		[Register ("rotation")]
		public IList<double> Rotation {
			get {
				if (rotation_jfieldId == IntPtr.Zero)
					rotation_jfieldId = JNIEnv.GetFieldID (class_ref, "rotation", "[D");
				return global::Android.Runtime.JavaArray<double>.FromJniHandle (JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, rotation_jfieldId), JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (rotation_jfieldId == IntPtr.Zero)
					rotation_jfieldId = JNIEnv.GetFieldID (class_ref, "rotation", "[D");
				IntPtr native_value = global::Android.Runtime.JavaArray<double>.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, rotation_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr statusCode_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.atap.tangoservice']/class[@name='TangoPoseData']/field[@name='statusCode']"
		[Register ("statusCode")]
		public int StatusCode {
			get {
				if (statusCode_jfieldId == IntPtr.Zero)
					statusCode_jfieldId = JNIEnv.GetFieldID (class_ref, "statusCode", "I");
				return JNIEnv.GetIntField (((global::Java.Lang.Object) this).Handle, statusCode_jfieldId);
			}
			set {
				if (statusCode_jfieldId == IntPtr.Zero)
					statusCode_jfieldId = JNIEnv.GetFieldID (class_ref, "statusCode", "I");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, statusCode_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr targetFrame_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.atap.tangoservice']/class[@name='TangoPoseData']/field[@name='targetFrame']"
		[Register ("targetFrame")]
		public int TargetFrame {
			get {
				if (targetFrame_jfieldId == IntPtr.Zero)
					targetFrame_jfieldId = JNIEnv.GetFieldID (class_ref, "targetFrame", "I");
				return JNIEnv.GetIntField (((global::Java.Lang.Object) this).Handle, targetFrame_jfieldId);
			}
			set {
				if (targetFrame_jfieldId == IntPtr.Zero)
					targetFrame_jfieldId = JNIEnv.GetFieldID (class_ref, "targetFrame", "I");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, targetFrame_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr timestamp_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.atap.tangoservice']/class[@name='TangoPoseData']/field[@name='timestamp']"
		[Register ("timestamp")]
		public double Timestamp {
			get {
				if (timestamp_jfieldId == IntPtr.Zero)
					timestamp_jfieldId = JNIEnv.GetFieldID (class_ref, "timestamp", "D");
				return JNIEnv.GetDoubleField (((global::Java.Lang.Object) this).Handle, timestamp_jfieldId);
			}
			set {
				if (timestamp_jfieldId == IntPtr.Zero)
					timestamp_jfieldId = JNIEnv.GetFieldID (class_ref, "timestamp", "D");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, timestamp_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr translation_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.atap.tangoservice']/class[@name='TangoPoseData']/field[@name='translation']"
		[Register ("translation")]
		public IList<double> Translation {
			get {
				if (translation_jfieldId == IntPtr.Zero)
					translation_jfieldId = JNIEnv.GetFieldID (class_ref, "translation", "[D");
				return global::Android.Runtime.JavaArray<double>.FromJniHandle (JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, translation_jfieldId), JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (translation_jfieldId == IntPtr.Zero)
					translation_jfieldId = JNIEnv.GetFieldID (class_ref, "translation", "[D");
				IntPtr native_value = global::Android.Runtime.JavaArray<double>.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, translation_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/google/atap/tangoservice/TangoPoseData", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (TangoPoseData); }
		}

		protected TangoPoseData (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.google.atap.tangoservice']/class[@name='TangoPoseData']/constructor[@name='TangoPoseData' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe TangoPoseData ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (TangoPoseData)) {
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
			global::Com.Google.Atap.Tangoservice.TangoPoseData __this = global::Java.Lang.Object.GetObject<global::Com.Google.Atap.Tangoservice.TangoPoseData> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.DescribeContents ();
		}
#pragma warning restore 0169

		static IntPtr id_describeContents;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.atap.tangoservice']/class[@name='TangoPoseData']/method[@name='describeContents' and count(parameter)=0]"
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

		static Delegate cb_getRotationAsFloats;
#pragma warning disable 0169
		static Delegate GetGetRotationAsFloatsHandler ()
		{
			if (cb_getRotationAsFloats == null)
				cb_getRotationAsFloats = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetRotationAsFloats);
			return cb_getRotationAsFloats;
		}

		static IntPtr n_GetRotationAsFloats (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Google.Atap.Tangoservice.TangoPoseData __this = global::Java.Lang.Object.GetObject<global::Com.Google.Atap.Tangoservice.TangoPoseData> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetRotationAsFloats ());
		}
#pragma warning restore 0169

		static IntPtr id_getRotationAsFloats;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.atap.tangoservice']/class[@name='TangoPoseData']/method[@name='getRotationAsFloats' and count(parameter)=0]"
		[Register ("getRotationAsFloats", "()[F", "GetGetRotationAsFloatsHandler")]
		public virtual unsafe float[] GetRotationAsFloats ()
		{
			if (id_getRotationAsFloats == IntPtr.Zero)
				id_getRotationAsFloats = JNIEnv.GetMethodID (class_ref, "getRotationAsFloats", "()[F");
			try {

				if (GetType () == ThresholdType)
					return (float[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getRotationAsFloats), JniHandleOwnership.TransferLocalRef, typeof (float));
				else
					return (float[]) JNIEnv.GetArray (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getRotationAsFloats", "()[F")), JniHandleOwnership.TransferLocalRef, typeof (float));
			} finally {
			}
		}

		static Delegate cb_getTranslationAsFloats;
#pragma warning disable 0169
		static Delegate GetGetTranslationAsFloatsHandler ()
		{
			if (cb_getTranslationAsFloats == null)
				cb_getTranslationAsFloats = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetTranslationAsFloats);
			return cb_getTranslationAsFloats;
		}

		static IntPtr n_GetTranslationAsFloats (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Google.Atap.Tangoservice.TangoPoseData __this = global::Java.Lang.Object.GetObject<global::Com.Google.Atap.Tangoservice.TangoPoseData> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetTranslationAsFloats ());
		}
#pragma warning restore 0169

		static IntPtr id_getTranslationAsFloats;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.atap.tangoservice']/class[@name='TangoPoseData']/method[@name='getTranslationAsFloats' and count(parameter)=0]"
		[Register ("getTranslationAsFloats", "()[F", "GetGetTranslationAsFloatsHandler")]
		public virtual unsafe float[] GetTranslationAsFloats ()
		{
			if (id_getTranslationAsFloats == IntPtr.Zero)
				id_getTranslationAsFloats = JNIEnv.GetMethodID (class_ref, "getTranslationAsFloats", "()[F");
			try {

				if (GetType () == ThresholdType)
					return (float[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getTranslationAsFloats), JniHandleOwnership.TransferLocalRef, typeof (float));
				else
					return (float[]) JNIEnv.GetArray (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getTranslationAsFloats", "()[F")), JniHandleOwnership.TransferLocalRef, typeof (float));
			} finally {
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
			global::Com.Google.Atap.Tangoservice.TangoPoseData __this = global::Java.Lang.Object.GetObject<global::Com.Google.Atap.Tangoservice.TangoPoseData> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.Parcel p0 = global::Java.Lang.Object.GetObject<global::Android.OS.Parcel> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.ReadFromParcel (p0);
		}
#pragma warning restore 0169

		static IntPtr id_readFromParcel_Landroid_os_Parcel_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.atap.tangoservice']/class[@name='TangoPoseData']/method[@name='readFromParcel' and count(parameter)=1 and parameter[1][@type='android.os.Parcel']]"
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
			global::Com.Google.Atap.Tangoservice.TangoPoseData __this = global::Java.Lang.Object.GetObject<global::Com.Google.Atap.Tangoservice.TangoPoseData> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.Parcel p0 = global::Java.Lang.Object.GetObject<global::Android.OS.Parcel> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.ParcelableWriteFlags p1 = (global::Android.OS.ParcelableWriteFlags) native_p1;
			__this.WriteToParcel (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_writeToParcel_Landroid_os_Parcel_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.atap.tangoservice']/class[@name='TangoPoseData']/method[@name='writeToParcel' and count(parameter)=2 and parameter[1][@type='android.os.Parcel'] and parameter[2][@type='int']]"
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
