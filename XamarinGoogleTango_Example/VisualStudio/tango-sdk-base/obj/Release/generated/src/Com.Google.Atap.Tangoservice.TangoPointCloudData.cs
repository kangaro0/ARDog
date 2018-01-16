using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Google.Atap.Tangoservice {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.google.atap.tangoservice']/class[@name='TangoPointCloudData']"
	[global::Android.Runtime.Register ("com/google/atap/tangoservice/TangoPointCloudData", DoNotGenerateAcw=true)]
	public partial class TangoPointCloudData : global::Java.Lang.Object, global::Android.OS.IParcelable {


		static IntPtr CREATOR_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.atap.tangoservice']/class[@name='TangoPointCloudData']/field[@name='CREATOR']"
		[Register ("CREATOR")]
		public static global::Android.OS.IParcelableCreator Creator {
			get {
				if (CREATOR_jfieldId == IntPtr.Zero)
					CREATOR_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "CREATOR", "Landroid/os/Parcelable$Creator;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, CREATOR_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Android.OS.IParcelableCreator> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr numPoints_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.atap.tangoservice']/class[@name='TangoPointCloudData']/field[@name='numPoints']"
		[Register ("numPoints")]
		public int NumPoints {
			get {
				if (numPoints_jfieldId == IntPtr.Zero)
					numPoints_jfieldId = JNIEnv.GetFieldID (class_ref, "numPoints", "I");
				return JNIEnv.GetIntField (((global::Java.Lang.Object) this).Handle, numPoints_jfieldId);
			}
			set {
				if (numPoints_jfieldId == IntPtr.Zero)
					numPoints_jfieldId = JNIEnv.GetFieldID (class_ref, "numPoints", "I");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, numPoints_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr pointCloudNativeFileDescriptor_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.atap.tangoservice']/class[@name='TangoPointCloudData']/field[@name='pointCloudNativeFileDescriptor']"
		[Register ("pointCloudNativeFileDescriptor")]
		public int PointCloudNativeFileDescriptor {
			get {
				if (pointCloudNativeFileDescriptor_jfieldId == IntPtr.Zero)
					pointCloudNativeFileDescriptor_jfieldId = JNIEnv.GetFieldID (class_ref, "pointCloudNativeFileDescriptor", "I");
				return JNIEnv.GetIntField (((global::Java.Lang.Object) this).Handle, pointCloudNativeFileDescriptor_jfieldId);
			}
			set {
				if (pointCloudNativeFileDescriptor_jfieldId == IntPtr.Zero)
					pointCloudNativeFileDescriptor_jfieldId = JNIEnv.GetFieldID (class_ref, "pointCloudNativeFileDescriptor", "I");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, pointCloudNativeFileDescriptor_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr pointCloudParcelFileDescriptor_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.atap.tangoservice']/class[@name='TangoPointCloudData']/field[@name='pointCloudParcelFileDescriptor']"
		[Register ("pointCloudParcelFileDescriptor")]
		public global::Android.OS.ParcelFileDescriptor PointCloudParcelFileDescriptor {
			get {
				if (pointCloudParcelFileDescriptor_jfieldId == IntPtr.Zero)
					pointCloudParcelFileDescriptor_jfieldId = JNIEnv.GetFieldID (class_ref, "pointCloudParcelFileDescriptor", "Landroid/os/ParcelFileDescriptor;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, pointCloudParcelFileDescriptor_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Android.OS.ParcelFileDescriptor> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (pointCloudParcelFileDescriptor_jfieldId == IntPtr.Zero)
					pointCloudParcelFileDescriptor_jfieldId = JNIEnv.GetFieldID (class_ref, "pointCloudParcelFileDescriptor", "Landroid/os/ParcelFileDescriptor;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, pointCloudParcelFileDescriptor_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr pointCloudParcelFileDescriptorFlags_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.atap.tangoservice']/class[@name='TangoPointCloudData']/field[@name='pointCloudParcelFileDescriptorFlags']"
		[Register ("pointCloudParcelFileDescriptorFlags")]
		public int PointCloudParcelFileDescriptorFlags {
			get {
				if (pointCloudParcelFileDescriptorFlags_jfieldId == IntPtr.Zero)
					pointCloudParcelFileDescriptorFlags_jfieldId = JNIEnv.GetFieldID (class_ref, "pointCloudParcelFileDescriptorFlags", "I");
				return JNIEnv.GetIntField (((global::Java.Lang.Object) this).Handle, pointCloudParcelFileDescriptorFlags_jfieldId);
			}
			set {
				if (pointCloudParcelFileDescriptorFlags_jfieldId == IntPtr.Zero)
					pointCloudParcelFileDescriptorFlags_jfieldId = JNIEnv.GetFieldID (class_ref, "pointCloudParcelFileDescriptorFlags", "I");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, pointCloudParcelFileDescriptorFlags_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr pointCloudParcelFileDescriptorOffset_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.atap.tangoservice']/class[@name='TangoPointCloudData']/field[@name='pointCloudParcelFileDescriptorOffset']"
		[Register ("pointCloudParcelFileDescriptorOffset")]
		public int PointCloudParcelFileDescriptorOffset {
			get {
				if (pointCloudParcelFileDescriptorOffset_jfieldId == IntPtr.Zero)
					pointCloudParcelFileDescriptorOffset_jfieldId = JNIEnv.GetFieldID (class_ref, "pointCloudParcelFileDescriptorOffset", "I");
				return JNIEnv.GetIntField (((global::Java.Lang.Object) this).Handle, pointCloudParcelFileDescriptorOffset_jfieldId);
			}
			set {
				if (pointCloudParcelFileDescriptorOffset_jfieldId == IntPtr.Zero)
					pointCloudParcelFileDescriptorOffset_jfieldId = JNIEnv.GetFieldID (class_ref, "pointCloudParcelFileDescriptorOffset", "I");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, pointCloudParcelFileDescriptorOffset_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr pointCloudParcelFileDescriptorSize_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.atap.tangoservice']/class[@name='TangoPointCloudData']/field[@name='pointCloudParcelFileDescriptorSize']"
		[Register ("pointCloudParcelFileDescriptorSize")]
		public int PointCloudParcelFileDescriptorSize {
			get {
				if (pointCloudParcelFileDescriptorSize_jfieldId == IntPtr.Zero)
					pointCloudParcelFileDescriptorSize_jfieldId = JNIEnv.GetFieldID (class_ref, "pointCloudParcelFileDescriptorSize", "I");
				return JNIEnv.GetIntField (((global::Java.Lang.Object) this).Handle, pointCloudParcelFileDescriptorSize_jfieldId);
			}
			set {
				if (pointCloudParcelFileDescriptorSize_jfieldId == IntPtr.Zero)
					pointCloudParcelFileDescriptorSize_jfieldId = JNIEnv.GetFieldID (class_ref, "pointCloudParcelFileDescriptorSize", "I");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, pointCloudParcelFileDescriptorSize_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr points_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.atap.tangoservice']/class[@name='TangoPointCloudData']/field[@name='points']"
		[Register ("points")]
		public global::Java.Nio.FloatBuffer Points {
			get {
				if (points_jfieldId == IntPtr.Zero)
					points_jfieldId = JNIEnv.GetFieldID (class_ref, "points", "Ljava/nio/FloatBuffer;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, points_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Java.Nio.FloatBuffer> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (points_jfieldId == IntPtr.Zero)
					points_jfieldId = JNIEnv.GetFieldID (class_ref, "points", "Ljava/nio/FloatBuffer;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, points_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr timestamp_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.atap.tangoservice']/class[@name='TangoPointCloudData']/field[@name='timestamp']"
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
				return JNIEnv.FindClass ("com/google/atap/tangoservice/TangoPointCloudData", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (TangoPointCloudData); }
		}

		protected TangoPointCloudData (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.google.atap.tangoservice']/class[@name='TangoPointCloudData']/constructor[@name='TangoPointCloudData' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe TangoPointCloudData ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (TangoPointCloudData)) {
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

		static Delegate cb_getPointsBuffer;
#pragma warning disable 0169
		static Delegate GetGetPointsBufferHandler ()
		{
			if (cb_getPointsBuffer == null)
				cb_getPointsBuffer = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetPointsBuffer);
			return cb_getPointsBuffer;
		}

		static IntPtr n_GetPointsBuffer (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Google.Atap.Tangoservice.TangoPointCloudData __this = global::Java.Lang.Object.GetObject<global::Com.Google.Atap.Tangoservice.TangoPointCloudData> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.PointsBuffer);
		}
#pragma warning restore 0169

		static IntPtr id_getPointsBuffer;
		public virtual unsafe global::Java.Nio.FloatBuffer PointsBuffer {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.atap.tangoservice']/class[@name='TangoPointCloudData']/method[@name='getPointsBuffer' and count(parameter)=0]"
			[Register ("getPointsBuffer", "()Ljava/nio/FloatBuffer;", "GetGetPointsBufferHandler")]
			get {
				if (id_getPointsBuffer == IntPtr.Zero)
					id_getPointsBuffer = JNIEnv.GetMethodID (class_ref, "getPointsBuffer", "()Ljava/nio/FloatBuffer;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Java.Nio.FloatBuffer> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getPointsBuffer), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Java.Nio.FloatBuffer> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getPointsBuffer", "()Ljava/nio/FloatBuffer;")), JniHandleOwnership.TransferLocalRef);
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
			global::Com.Google.Atap.Tangoservice.TangoPointCloudData __this = global::Java.Lang.Object.GetObject<global::Com.Google.Atap.Tangoservice.TangoPointCloudData> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.DescribeContents ();
		}
#pragma warning restore 0169

		static IntPtr id_describeContents;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.atap.tangoservice']/class[@name='TangoPointCloudData']/method[@name='describeContents' and count(parameter)=0]"
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
			global::Com.Google.Atap.Tangoservice.TangoPointCloudData __this = global::Java.Lang.Object.GetObject<global::Com.Google.Atap.Tangoservice.TangoPointCloudData> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.Parcel p0 = global::Java.Lang.Object.GetObject<global::Android.OS.Parcel> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.ReadFromParcel (p0);
		}
#pragma warning restore 0169

		static IntPtr id_readFromParcel_Landroid_os_Parcel_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.atap.tangoservice']/class[@name='TangoPointCloudData']/method[@name='readFromParcel' and count(parameter)=1 and parameter[1][@type='android.os.Parcel']]"
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
			global::Com.Google.Atap.Tangoservice.TangoPointCloudData __this = global::Java.Lang.Object.GetObject<global::Com.Google.Atap.Tangoservice.TangoPointCloudData> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.Parcel p0 = global::Java.Lang.Object.GetObject<global::Android.OS.Parcel> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.ParcelableWriteFlags p1 = (global::Android.OS.ParcelableWriteFlags) native_p1;
			__this.WriteToParcel (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_writeToParcel_Landroid_os_Parcel_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.atap.tangoservice']/class[@name='TangoPointCloudData']/method[@name='writeToParcel' and count(parameter)=2 and parameter[1][@type='android.os.Parcel'] and parameter[2][@type='int']]"
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
