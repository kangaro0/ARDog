using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Google.Atap.Tangoservice {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.google.atap.tangoservice']/class[@name='TangoXyzIjData']"
	[global::Android.Runtime.Register ("com/google/atap/tangoservice/TangoXyzIjData", DoNotGenerateAcw=true)]
	public partial class TangoXyzIjData : global::Java.Lang.Object, global::Android.OS.IParcelable {


		static IntPtr CREATOR_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.atap.tangoservice']/class[@name='TangoXyzIjData']/field[@name='CREATOR']"
		[Register ("CREATOR")]
		public static global::Android.OS.IParcelableCreator Creator {
			get {
				if (CREATOR_jfieldId == IntPtr.Zero)
					CREATOR_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "CREATOR", "Landroid/os/Parcelable$Creator;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, CREATOR_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Android.OS.IParcelableCreator> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr ijCols_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.atap.tangoservice']/class[@name='TangoXyzIjData']/field[@name='ijCols']"
		[Register ("ijCols")]
		public int IjCols {
			get {
				if (ijCols_jfieldId == IntPtr.Zero)
					ijCols_jfieldId = JNIEnv.GetFieldID (class_ref, "ijCols", "I");
				return JNIEnv.GetIntField (((global::Java.Lang.Object) this).Handle, ijCols_jfieldId);
			}
			set {
				if (ijCols_jfieldId == IntPtr.Zero)
					ijCols_jfieldId = JNIEnv.GetFieldID (class_ref, "ijCols", "I");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, ijCols_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr ijParcelFileDescriptor_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.atap.tangoservice']/class[@name='TangoXyzIjData']/field[@name='ijParcelFileDescriptor']"
		[Register ("ijParcelFileDescriptor")]
		public global::Android.OS.ParcelFileDescriptor IjParcelFileDescriptor {
			get {
				if (ijParcelFileDescriptor_jfieldId == IntPtr.Zero)
					ijParcelFileDescriptor_jfieldId = JNIEnv.GetFieldID (class_ref, "ijParcelFileDescriptor", "Landroid/os/ParcelFileDescriptor;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, ijParcelFileDescriptor_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Android.OS.ParcelFileDescriptor> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (ijParcelFileDescriptor_jfieldId == IntPtr.Zero)
					ijParcelFileDescriptor_jfieldId = JNIEnv.GetFieldID (class_ref, "ijParcelFileDescriptor", "Landroid/os/ParcelFileDescriptor;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, ijParcelFileDescriptor_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr ijRows_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.atap.tangoservice']/class[@name='TangoXyzIjData']/field[@name='ijRows']"
		[Register ("ijRows")]
		public int IjRows {
			get {
				if (ijRows_jfieldId == IntPtr.Zero)
					ijRows_jfieldId = JNIEnv.GetFieldID (class_ref, "ijRows", "I");
				return JNIEnv.GetIntField (((global::Java.Lang.Object) this).Handle, ijRows_jfieldId);
			}
			set {
				if (ijRows_jfieldId == IntPtr.Zero)
					ijRows_jfieldId = JNIEnv.GetFieldID (class_ref, "ijRows", "I");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, ijRows_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr timestamp_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.atap.tangoservice']/class[@name='TangoXyzIjData']/field[@name='timestamp']"
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

		static IntPtr xyz_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.atap.tangoservice']/class[@name='TangoXyzIjData']/field[@name='xyz']"
		[Register ("xyz")]
		public global::Java.Nio.FloatBuffer Xyz {
			get {
				if (xyz_jfieldId == IntPtr.Zero)
					xyz_jfieldId = JNIEnv.GetFieldID (class_ref, "xyz", "Ljava/nio/FloatBuffer;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, xyz_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Java.Nio.FloatBuffer> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (xyz_jfieldId == IntPtr.Zero)
					xyz_jfieldId = JNIEnv.GetFieldID (class_ref, "xyz", "Ljava/nio/FloatBuffer;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, xyz_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr xyzCount_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.atap.tangoservice']/class[@name='TangoXyzIjData']/field[@name='xyzCount']"
		[Register ("xyzCount")]
		public int XyzCount {
			get {
				if (xyzCount_jfieldId == IntPtr.Zero)
					xyzCount_jfieldId = JNIEnv.GetFieldID (class_ref, "xyzCount", "I");
				return JNIEnv.GetIntField (((global::Java.Lang.Object) this).Handle, xyzCount_jfieldId);
			}
			set {
				if (xyzCount_jfieldId == IntPtr.Zero)
					xyzCount_jfieldId = JNIEnv.GetFieldID (class_ref, "xyzCount", "I");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, xyzCount_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr xyzParcelFileDescriptor_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.atap.tangoservice']/class[@name='TangoXyzIjData']/field[@name='xyzParcelFileDescriptor']"
		[Register ("xyzParcelFileDescriptor")]
		public global::Android.OS.ParcelFileDescriptor XyzParcelFileDescriptor {
			get {
				if (xyzParcelFileDescriptor_jfieldId == IntPtr.Zero)
					xyzParcelFileDescriptor_jfieldId = JNIEnv.GetFieldID (class_ref, "xyzParcelFileDescriptor", "Landroid/os/ParcelFileDescriptor;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, xyzParcelFileDescriptor_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Android.OS.ParcelFileDescriptor> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (xyzParcelFileDescriptor_jfieldId == IntPtr.Zero)
					xyzParcelFileDescriptor_jfieldId = JNIEnv.GetFieldID (class_ref, "xyzParcelFileDescriptor", "Landroid/os/ParcelFileDescriptor;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, xyzParcelFileDescriptor_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr xyzParcelFileDescriptorFlags_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.atap.tangoservice']/class[@name='TangoXyzIjData']/field[@name='xyzParcelFileDescriptorFlags']"
		[Register ("xyzParcelFileDescriptorFlags")]
		public int XyzParcelFileDescriptorFlags {
			get {
				if (xyzParcelFileDescriptorFlags_jfieldId == IntPtr.Zero)
					xyzParcelFileDescriptorFlags_jfieldId = JNIEnv.GetFieldID (class_ref, "xyzParcelFileDescriptorFlags", "I");
				return JNIEnv.GetIntField (((global::Java.Lang.Object) this).Handle, xyzParcelFileDescriptorFlags_jfieldId);
			}
			set {
				if (xyzParcelFileDescriptorFlags_jfieldId == IntPtr.Zero)
					xyzParcelFileDescriptorFlags_jfieldId = JNIEnv.GetFieldID (class_ref, "xyzParcelFileDescriptorFlags", "I");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, xyzParcelFileDescriptorFlags_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr xyzParcelFileDescriptorOffset_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.atap.tangoservice']/class[@name='TangoXyzIjData']/field[@name='xyzParcelFileDescriptorOffset']"
		[Register ("xyzParcelFileDescriptorOffset")]
		public int XyzParcelFileDescriptorOffset {
			get {
				if (xyzParcelFileDescriptorOffset_jfieldId == IntPtr.Zero)
					xyzParcelFileDescriptorOffset_jfieldId = JNIEnv.GetFieldID (class_ref, "xyzParcelFileDescriptorOffset", "I");
				return JNIEnv.GetIntField (((global::Java.Lang.Object) this).Handle, xyzParcelFileDescriptorOffset_jfieldId);
			}
			set {
				if (xyzParcelFileDescriptorOffset_jfieldId == IntPtr.Zero)
					xyzParcelFileDescriptorOffset_jfieldId = JNIEnv.GetFieldID (class_ref, "xyzParcelFileDescriptorOffset", "I");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, xyzParcelFileDescriptorOffset_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr xyzParcelFileDescriptorSize_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.atap.tangoservice']/class[@name='TangoXyzIjData']/field[@name='xyzParcelFileDescriptorSize']"
		[Register ("xyzParcelFileDescriptorSize")]
		public int XyzParcelFileDescriptorSize {
			get {
				if (xyzParcelFileDescriptorSize_jfieldId == IntPtr.Zero)
					xyzParcelFileDescriptorSize_jfieldId = JNIEnv.GetFieldID (class_ref, "xyzParcelFileDescriptorSize", "I");
				return JNIEnv.GetIntField (((global::Java.Lang.Object) this).Handle, xyzParcelFileDescriptorSize_jfieldId);
			}
			set {
				if (xyzParcelFileDescriptorSize_jfieldId == IntPtr.Zero)
					xyzParcelFileDescriptorSize_jfieldId = JNIEnv.GetFieldID (class_ref, "xyzParcelFileDescriptorSize", "I");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, xyzParcelFileDescriptorSize_jfieldId, value);
				} finally {
				}
			}
		}
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/google/atap/tangoservice/TangoXyzIjData", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (TangoXyzIjData); }
		}

		protected TangoXyzIjData (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.google.atap.tangoservice']/class[@name='TangoXyzIjData']/constructor[@name='TangoXyzIjData' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe TangoXyzIjData ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (TangoXyzIjData)) {
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

		static Delegate cb_getXyzBuffer;
#pragma warning disable 0169
		static Delegate GetGetXyzBufferHandler ()
		{
			if (cb_getXyzBuffer == null)
				cb_getXyzBuffer = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetXyzBuffer);
			return cb_getXyzBuffer;
		}

		static IntPtr n_GetXyzBuffer (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Google.Atap.Tangoservice.TangoXyzIjData __this = global::Java.Lang.Object.GetObject<global::Com.Google.Atap.Tangoservice.TangoXyzIjData> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.XyzBuffer);
		}
#pragma warning restore 0169

		static IntPtr id_getXyzBuffer;
		public virtual unsafe global::Java.Nio.FloatBuffer XyzBuffer {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.atap.tangoservice']/class[@name='TangoXyzIjData']/method[@name='getXyzBuffer' and count(parameter)=0]"
			[Register ("getXyzBuffer", "()Ljava/nio/FloatBuffer;", "GetGetXyzBufferHandler")]
			get {
				if (id_getXyzBuffer == IntPtr.Zero)
					id_getXyzBuffer = JNIEnv.GetMethodID (class_ref, "getXyzBuffer", "()Ljava/nio/FloatBuffer;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Java.Nio.FloatBuffer> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getXyzBuffer), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Java.Nio.FloatBuffer> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getXyzBuffer", "()Ljava/nio/FloatBuffer;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
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
			global::Com.Google.Atap.Tangoservice.TangoXyzIjData __this = global::Java.Lang.Object.GetObject<global::Com.Google.Atap.Tangoservice.TangoXyzIjData> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.DescribeContents ();
		}
#pragma warning restore 0169

		static IntPtr id_describeContents;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.atap.tangoservice']/class[@name='TangoXyzIjData']/method[@name='describeContents' and count(parameter)=0]"
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
			global::Com.Google.Atap.Tangoservice.TangoXyzIjData __this = global::Java.Lang.Object.GetObject<global::Com.Google.Atap.Tangoservice.TangoXyzIjData> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.Parcel p0 = global::Java.Lang.Object.GetObject<global::Android.OS.Parcel> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.ReadFromParcel (p0);
		}
#pragma warning restore 0169

		static IntPtr id_readFromParcel_Landroid_os_Parcel_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.atap.tangoservice']/class[@name='TangoXyzIjData']/method[@name='readFromParcel' and count(parameter)=1 and parameter[1][@type='android.os.Parcel']]"
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
			global::Com.Google.Atap.Tangoservice.TangoXyzIjData __this = global::Java.Lang.Object.GetObject<global::Com.Google.Atap.Tangoservice.TangoXyzIjData> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.Parcel p0 = global::Java.Lang.Object.GetObject<global::Android.OS.Parcel> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.ParcelableWriteFlags p1 = (global::Android.OS.ParcelableWriteFlags) native_p1;
			__this.WriteToParcel (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_writeToParcel_Landroid_os_Parcel_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.atap.tangoservice']/class[@name='TangoXyzIjData']/method[@name='writeToParcel' and count(parameter)=2 and parameter[1][@type='android.os.Parcel'] and parameter[2][@type='int']]"
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
