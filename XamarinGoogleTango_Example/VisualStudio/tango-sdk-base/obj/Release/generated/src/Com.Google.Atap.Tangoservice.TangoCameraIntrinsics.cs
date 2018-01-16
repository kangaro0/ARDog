using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Google.Atap.Tangoservice {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.google.atap.tangoservice']/class[@name='TangoCameraIntrinsics']"
	[global::Android.Runtime.Register ("com/google/atap/tangoservice/TangoCameraIntrinsics", DoNotGenerateAcw=true)]
	public partial class TangoCameraIntrinsics : global::Java.Lang.Object, global::Android.OS.IParcelable {


		static IntPtr CREATOR_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.atap.tangoservice']/class[@name='TangoCameraIntrinsics']/field[@name='CREATOR']"
		[Register ("CREATOR")]
		public static global::Android.OS.IParcelableCreator Creator {
			get {
				if (CREATOR_jfieldId == IntPtr.Zero)
					CREATOR_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "CREATOR", "Landroid/os/Parcelable$Creator;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, CREATOR_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Android.OS.IParcelableCreator> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.atap.tangoservice']/class[@name='TangoCameraIntrinsics']/field[@name='TANGO_CALIBRATION_EQUIDISTANT']"
		[Register ("TANGO_CALIBRATION_EQUIDISTANT")]
		public const int TangoCalibrationEquidistant = (int) 1;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.atap.tangoservice']/class[@name='TangoCameraIntrinsics']/field[@name='TANGO_CALIBRATION_POLYNOMIAL_2_PARAMETERS']"
		[Register ("TANGO_CALIBRATION_POLYNOMIAL_2_PARAMETERS")]
		public const int TangoCalibrationPolynomial2Parameters = (int) 2;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.atap.tangoservice']/class[@name='TangoCameraIntrinsics']/field[@name='TANGO_CALIBRATION_POLYNOMIAL_3_PARAMETERS']"
		[Register ("TANGO_CALIBRATION_POLYNOMIAL_3_PARAMETERS")]
		public const int TangoCalibrationPolynomial3Parameters = (int) 3;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.atap.tangoservice']/class[@name='TangoCameraIntrinsics']/field[@name='TANGO_CALIBRATION_POLYNOMIAL_5_PARAMETERS']"
		[Register ("TANGO_CALIBRATION_POLYNOMIAL_5_PARAMETERS")]
		public const int TangoCalibrationPolynomial5Parameters = (int) 4;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.atap.tangoservice']/class[@name='TangoCameraIntrinsics']/field[@name='TANGO_CALIBRATION_UNKNOWN']"
		[Register ("TANGO_CALIBRATION_UNKNOWN")]
		public const int TangoCalibrationUnknown = (int) 0;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.atap.tangoservice']/class[@name='TangoCameraIntrinsics']/field[@name='TANGO_CAMERA_COLOR']"
		[Register ("TANGO_CAMERA_COLOR")]
		public const int TangoCameraColor = (int) 0;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.atap.tangoservice']/class[@name='TangoCameraIntrinsics']/field[@name='TANGO_CAMERA_DEPTH']"
		[Register ("TANGO_CAMERA_DEPTH")]
		public const int TangoCameraDepth = (int) 3;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.atap.tangoservice']/class[@name='TangoCameraIntrinsics']/field[@name='TANGO_CAMERA_FISHEYE']"
		[Register ("TANGO_CAMERA_FISHEYE")]
		public const int TangoCameraFisheye = (int) 2;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.atap.tangoservice']/class[@name='TangoCameraIntrinsics']/field[@name='TANGO_CAMERA_RGBIR']"
		[Register ("TANGO_CAMERA_RGBIR")]
		public const int TangoCameraRgbir = (int) 1;

		static IntPtr calibrationType_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.atap.tangoservice']/class[@name='TangoCameraIntrinsics']/field[@name='calibrationType']"
		[Register ("calibrationType")]
		public int CalibrationType {
			get {
				if (calibrationType_jfieldId == IntPtr.Zero)
					calibrationType_jfieldId = JNIEnv.GetFieldID (class_ref, "calibrationType", "I");
				return JNIEnv.GetIntField (((global::Java.Lang.Object) this).Handle, calibrationType_jfieldId);
			}
			set {
				if (calibrationType_jfieldId == IntPtr.Zero)
					calibrationType_jfieldId = JNIEnv.GetFieldID (class_ref, "calibrationType", "I");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, calibrationType_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr cameraId_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.atap.tangoservice']/class[@name='TangoCameraIntrinsics']/field[@name='cameraId']"
		[Register ("cameraId")]
		public int CameraId {
			get {
				if (cameraId_jfieldId == IntPtr.Zero)
					cameraId_jfieldId = JNIEnv.GetFieldID (class_ref, "cameraId", "I");
				return JNIEnv.GetIntField (((global::Java.Lang.Object) this).Handle, cameraId_jfieldId);
			}
			set {
				if (cameraId_jfieldId == IntPtr.Zero)
					cameraId_jfieldId = JNIEnv.GetFieldID (class_ref, "cameraId", "I");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, cameraId_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr cx_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.atap.tangoservice']/class[@name='TangoCameraIntrinsics']/field[@name='cx']"
		[Register ("cx")]
		public double Cx {
			get {
				if (cx_jfieldId == IntPtr.Zero)
					cx_jfieldId = JNIEnv.GetFieldID (class_ref, "cx", "D");
				return JNIEnv.GetDoubleField (((global::Java.Lang.Object) this).Handle, cx_jfieldId);
			}
			set {
				if (cx_jfieldId == IntPtr.Zero)
					cx_jfieldId = JNIEnv.GetFieldID (class_ref, "cx", "D");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, cx_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr cy_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.atap.tangoservice']/class[@name='TangoCameraIntrinsics']/field[@name='cy']"
		[Register ("cy")]
		public double Cy {
			get {
				if (cy_jfieldId == IntPtr.Zero)
					cy_jfieldId = JNIEnv.GetFieldID (class_ref, "cy", "D");
				return JNIEnv.GetDoubleField (((global::Java.Lang.Object) this).Handle, cy_jfieldId);
			}
			set {
				if (cy_jfieldId == IntPtr.Zero)
					cy_jfieldId = JNIEnv.GetFieldID (class_ref, "cy", "D");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, cy_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr distortion_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.atap.tangoservice']/class[@name='TangoCameraIntrinsics']/field[@name='distortion']"
		[Register ("distortion")]
		public IList<double> Distortion {
			get {
				if (distortion_jfieldId == IntPtr.Zero)
					distortion_jfieldId = JNIEnv.GetFieldID (class_ref, "distortion", "[D");
				return global::Android.Runtime.JavaArray<double>.FromJniHandle (JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, distortion_jfieldId), JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (distortion_jfieldId == IntPtr.Zero)
					distortion_jfieldId = JNIEnv.GetFieldID (class_ref, "distortion", "[D");
				IntPtr native_value = global::Android.Runtime.JavaArray<double>.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, distortion_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr fx_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.atap.tangoservice']/class[@name='TangoCameraIntrinsics']/field[@name='fx']"
		[Register ("fx")]
		public double Fx {
			get {
				if (fx_jfieldId == IntPtr.Zero)
					fx_jfieldId = JNIEnv.GetFieldID (class_ref, "fx", "D");
				return JNIEnv.GetDoubleField (((global::Java.Lang.Object) this).Handle, fx_jfieldId);
			}
			set {
				if (fx_jfieldId == IntPtr.Zero)
					fx_jfieldId = JNIEnv.GetFieldID (class_ref, "fx", "D");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, fx_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr fy_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.atap.tangoservice']/class[@name='TangoCameraIntrinsics']/field[@name='fy']"
		[Register ("fy")]
		public double Fy {
			get {
				if (fy_jfieldId == IntPtr.Zero)
					fy_jfieldId = JNIEnv.GetFieldID (class_ref, "fy", "D");
				return JNIEnv.GetDoubleField (((global::Java.Lang.Object) this).Handle, fy_jfieldId);
			}
			set {
				if (fy_jfieldId == IntPtr.Zero)
					fy_jfieldId = JNIEnv.GetFieldID (class_ref, "fy", "D");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, fy_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr height_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.atap.tangoservice']/class[@name='TangoCameraIntrinsics']/field[@name='height']"
		[Register ("height")]
		public int Height {
			get {
				if (height_jfieldId == IntPtr.Zero)
					height_jfieldId = JNIEnv.GetFieldID (class_ref, "height", "I");
				return JNIEnv.GetIntField (((global::Java.Lang.Object) this).Handle, height_jfieldId);
			}
			set {
				if (height_jfieldId == IntPtr.Zero)
					height_jfieldId = JNIEnv.GetFieldID (class_ref, "height", "I");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, height_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr width_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.atap.tangoservice']/class[@name='TangoCameraIntrinsics']/field[@name='width']"
		[Register ("width")]
		public int Width {
			get {
				if (width_jfieldId == IntPtr.Zero)
					width_jfieldId = JNIEnv.GetFieldID (class_ref, "width", "I");
				return JNIEnv.GetIntField (((global::Java.Lang.Object) this).Handle, width_jfieldId);
			}
			set {
				if (width_jfieldId == IntPtr.Zero)
					width_jfieldId = JNIEnv.GetFieldID (class_ref, "width", "I");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, width_jfieldId, value);
				} finally {
				}
			}
		}
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/google/atap/tangoservice/TangoCameraIntrinsics", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (TangoCameraIntrinsics); }
		}

		protected TangoCameraIntrinsics (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.google.atap.tangoservice']/class[@name='TangoCameraIntrinsics']/constructor[@name='TangoCameraIntrinsics' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe TangoCameraIntrinsics ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (TangoCameraIntrinsics)) {
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
			global::Com.Google.Atap.Tangoservice.TangoCameraIntrinsics __this = global::Java.Lang.Object.GetObject<global::Com.Google.Atap.Tangoservice.TangoCameraIntrinsics> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.DescribeContents ();
		}
#pragma warning restore 0169

		static IntPtr id_describeContents;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.atap.tangoservice']/class[@name='TangoCameraIntrinsics']/method[@name='describeContents' and count(parameter)=0]"
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
			global::Com.Google.Atap.Tangoservice.TangoCameraIntrinsics __this = global::Java.Lang.Object.GetObject<global::Com.Google.Atap.Tangoservice.TangoCameraIntrinsics> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.Parcel p0 = global::Java.Lang.Object.GetObject<global::Android.OS.Parcel> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.ReadFromParcel (p0);
		}
#pragma warning restore 0169

		static IntPtr id_readFromParcel_Landroid_os_Parcel_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.atap.tangoservice']/class[@name='TangoCameraIntrinsics']/method[@name='readFromParcel' and count(parameter)=1 and parameter[1][@type='android.os.Parcel']]"
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
			global::Com.Google.Atap.Tangoservice.TangoCameraIntrinsics __this = global::Java.Lang.Object.GetObject<global::Com.Google.Atap.Tangoservice.TangoCameraIntrinsics> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.Parcel p0 = global::Java.Lang.Object.GetObject<global::Android.OS.Parcel> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.ParcelableWriteFlags p1 = (global::Android.OS.ParcelableWriteFlags) native_p1;
			__this.WriteToParcel (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_writeToParcel_Landroid_os_Parcel_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.atap.tangoservice']/class[@name='TangoCameraIntrinsics']/method[@name='writeToParcel' and count(parameter)=2 and parameter[1][@type='android.os.Parcel'] and parameter[2][@type='int']]"
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
