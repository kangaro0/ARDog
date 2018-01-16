using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Google.Atap.Tangoservice {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.google.atap.tangoservice']/class[@name='TangoEvent']"
	[global::Android.Runtime.Register ("com/google/atap/tangoservice/TangoEvent", DoNotGenerateAcw=true)]
	public partial class TangoEvent : global::Java.Lang.Object, global::Android.OS.IParcelable {


		static IntPtr CREATOR_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.atap.tangoservice']/class[@name='TangoEvent']/field[@name='CREATOR']"
		[Register ("CREATOR")]
		public static global::Android.OS.IParcelableCreator Creator {
			get {
				if (CREATOR_jfieldId == IntPtr.Zero)
					CREATOR_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "CREATOR", "Landroid/os/Parcelable$Creator;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, CREATOR_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Android.OS.IParcelableCreator> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.atap.tangoservice']/class[@name='TangoEvent']/field[@name='DESCRIPTION_COLOR_OVER_EXPOSED']"
		[Register ("DESCRIPTION_COLOR_OVER_EXPOSED")]
		public const string DescriptionColorOverExposed = (string) "ColorOverExposed";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.atap.tangoservice']/class[@name='TangoEvent']/field[@name='DESCRIPTION_COLOR_UNDER_EXPOSED']"
		[Register ("DESCRIPTION_COLOR_UNDER_EXPOSED")]
		public const string DescriptionColorUnderExposed = (string) "ColorUnderExposed";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.atap.tangoservice']/class[@name='TangoEvent']/field[@name='DESCRIPTION_FISHEYE_OVER_EXPOSED']"
		[Register ("DESCRIPTION_FISHEYE_OVER_EXPOSED")]
		public const string DescriptionFisheyeOverExposed = (string) "FisheyeOverExposed";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.atap.tangoservice']/class[@name='TangoEvent']/field[@name='DESCRIPTION_FISHEYE_UNDER_EXPOSED']"
		[Register ("DESCRIPTION_FISHEYE_UNDER_EXPOSED")]
		public const string DescriptionFisheyeUnderExposed = (string) "FisheyeUnderExposed";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.atap.tangoservice']/class[@name='TangoEvent']/field[@name='DESCRIPTION_TOO_FEW_FEATURES_TRACKED']"
		[Register ("DESCRIPTION_TOO_FEW_FEATURES_TRACKED")]
		public const string DescriptionTooFewFeaturesTracked = (string) "TooFewFeaturesTracked";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.atap.tangoservice']/class[@name='TangoEvent']/field[@name='EVENT_AREA_LEARNING']"
		[Register ("EVENT_AREA_LEARNING")]
		public const int EventAreaLearning = (int) 6;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.atap.tangoservice']/class[@name='TangoEvent']/field[@name='EVENT_CLOUD_ADF']"
		[Register ("EVENT_CLOUD_ADF")]
		public const int EventCloudAdf = (int) 7;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.atap.tangoservice']/class[@name='TangoEvent']/field[@name='EVENT_COLOR_CAMERA']"
		[Register ("EVENT_COLOR_CAMERA")]
		public const int EventColorCamera = (int) 3;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.atap.tangoservice']/class[@name='TangoEvent']/field[@name='EVENT_FEATURE_TRACKING']"
		[Register ("EVENT_FEATURE_TRACKING")]
		public const int EventFeatureTracking = (int) 5;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.atap.tangoservice']/class[@name='TangoEvent']/field[@name='EVENT_FISHEYE_CAMERA']"
		[Register ("EVENT_FISHEYE_CAMERA")]
		public const int EventFisheyeCamera = (int) 2;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.atap.tangoservice']/class[@name='TangoEvent']/field[@name='EVENT_GENERAL']"
		[Register ("EVENT_GENERAL")]
		public const int EventGeneral = (int) 1;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.atap.tangoservice']/class[@name='TangoEvent']/field[@name='EVENT_IMU']"
		[Register ("EVENT_IMU")]
		public const int EventImu = (int) 4;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.atap.tangoservice']/class[@name='TangoEvent']/field[@name='EVENT_UNKNOWN']"
		[Register ("EVENT_UNKNOWN")]
		public const int EventUnknown = (int) 0;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.atap.tangoservice']/class[@name='TangoEvent']/field[@name='KEY_AREA_DESCRIPTION_SAVE_PROGRESS']"
		[Register ("KEY_AREA_DESCRIPTION_SAVE_PROGRESS")]
		public const string KeyAreaDescriptionSaveProgress = (string) "AreaDescriptionSaveProgress";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.atap.tangoservice']/class[@name='TangoEvent']/field[@name='KEY_SERVICE_EXCEPTION']"
		[Register ("KEY_SERVICE_EXCEPTION")]
		public const string KeyServiceException = (string) "TangoServiceException";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.atap.tangoservice']/class[@name='TangoEvent']/field[@name='VALUE_SERVICE_FAULT']"
		[Register ("VALUE_SERVICE_FAULT")]
		public const string ValueServiceFault = (string) "Service faulted will restart.";

		static IntPtr eventKey_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.atap.tangoservice']/class[@name='TangoEvent']/field[@name='eventKey']"
		[Register ("eventKey")]
		public string EventKey {
			get {
				if (eventKey_jfieldId == IntPtr.Zero)
					eventKey_jfieldId = JNIEnv.GetFieldID (class_ref, "eventKey", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, eventKey_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (eventKey_jfieldId == IntPtr.Zero)
					eventKey_jfieldId = JNIEnv.GetFieldID (class_ref, "eventKey", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, eventKey_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr eventType_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.atap.tangoservice']/class[@name='TangoEvent']/field[@name='eventType']"
		[Register ("eventType")]
		public int EventType {
			get {
				if (eventType_jfieldId == IntPtr.Zero)
					eventType_jfieldId = JNIEnv.GetFieldID (class_ref, "eventType", "I");
				return JNIEnv.GetIntField (((global::Java.Lang.Object) this).Handle, eventType_jfieldId);
			}
			set {
				if (eventType_jfieldId == IntPtr.Zero)
					eventType_jfieldId = JNIEnv.GetFieldID (class_ref, "eventType", "I");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, eventType_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr eventValue_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.atap.tangoservice']/class[@name='TangoEvent']/field[@name='eventValue']"
		[Register ("eventValue")]
		public string EventValue {
			get {
				if (eventValue_jfieldId == IntPtr.Zero)
					eventValue_jfieldId = JNIEnv.GetFieldID (class_ref, "eventValue", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, eventValue_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (eventValue_jfieldId == IntPtr.Zero)
					eventValue_jfieldId = JNIEnv.GetFieldID (class_ref, "eventValue", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, eventValue_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr timestamp_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.atap.tangoservice']/class[@name='TangoEvent']/field[@name='timestamp']"
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
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/google/atap/tangoservice/TangoEvent", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (TangoEvent); }
		}

		protected TangoEvent (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.google.atap.tangoservice']/class[@name='TangoEvent']/constructor[@name='TangoEvent' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe TangoEvent ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (TangoEvent)) {
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
			global::Com.Google.Atap.Tangoservice.TangoEvent __this = global::Java.Lang.Object.GetObject<global::Com.Google.Atap.Tangoservice.TangoEvent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.DescribeContents ();
		}
#pragma warning restore 0169

		static IntPtr id_describeContents;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.atap.tangoservice']/class[@name='TangoEvent']/method[@name='describeContents' and count(parameter)=0]"
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
			global::Com.Google.Atap.Tangoservice.TangoEvent __this = global::Java.Lang.Object.GetObject<global::Com.Google.Atap.Tangoservice.TangoEvent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.Parcel p0 = global::Java.Lang.Object.GetObject<global::Android.OS.Parcel> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.ReadFromParcel (p0);
		}
#pragma warning restore 0169

		static IntPtr id_readFromParcel_Landroid_os_Parcel_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.atap.tangoservice']/class[@name='TangoEvent']/method[@name='readFromParcel' and count(parameter)=1 and parameter[1][@type='android.os.Parcel']]"
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
			global::Com.Google.Atap.Tangoservice.TangoEvent __this = global::Java.Lang.Object.GetObject<global::Com.Google.Atap.Tangoservice.TangoEvent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.Parcel p0 = global::Java.Lang.Object.GetObject<global::Android.OS.Parcel> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.ParcelableWriteFlags p1 = (global::Android.OS.ParcelableWriteFlags) native_p1;
			__this.WriteToParcel (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_writeToParcel_Landroid_os_Parcel_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.atap.tangoservice']/class[@name='TangoEvent']/method[@name='writeToParcel' and count(parameter)=2 and parameter[1][@type='android.os.Parcel'] and parameter[2][@type='int']]"
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
