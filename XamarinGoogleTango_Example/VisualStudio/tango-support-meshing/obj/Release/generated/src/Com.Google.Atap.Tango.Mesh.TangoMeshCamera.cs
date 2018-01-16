using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Google.Atap.Tango.Mesh {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.google.atap.tango.mesh']/class[@name='TangoMeshCamera']"
	[global::Android.Runtime.Register ("com/google/atap/tango/mesh/TangoMeshCamera", DoNotGenerateAcw=true)]
	public partial class TangoMeshCamera : global::Java.Lang.Object, global::Android.OS.IParcelable {


		static IntPtr CREATOR_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.atap.tango.mesh']/class[@name='TangoMeshCamera']/field[@name='CREATOR']"
		[Register ("CREATOR")]
		public static global::Android.OS.IParcelableCreator Creator {
			get {
				if (CREATOR_jfieldId == IntPtr.Zero)
					CREATOR_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "CREATOR", "Landroid/os/Parcelable$Creator;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, CREATOR_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Android.OS.IParcelableCreator> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr flags_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.atap.tango.mesh']/class[@name='TangoMeshCamera']/field[@name='flags']"
		[Register ("flags")]
		public int Flags {
			get {
				if (flags_jfieldId == IntPtr.Zero)
					flags_jfieldId = JNIEnv.GetFieldID (class_ref, "flags", "I");
				return JNIEnv.GetIntField (((global::Java.Lang.Object) this).Handle, flags_jfieldId);
			}
			set {
				if (flags_jfieldId == IntPtr.Zero)
					flags_jfieldId = JNIEnv.GetFieldID (class_ref, "flags", "I");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, flags_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr focalDistance_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.atap.tango.mesh']/class[@name='TangoMeshCamera']/field[@name='focalDistance']"
		[Register ("focalDistance")]
		public float FocalDistance {
			get {
				if (focalDistance_jfieldId == IntPtr.Zero)
					focalDistance_jfieldId = JNIEnv.GetFieldID (class_ref, "focalDistance", "F");
				return JNIEnv.GetFloatField (((global::Java.Lang.Object) this).Handle, focalDistance_jfieldId);
			}
			set {
				if (focalDistance_jfieldId == IntPtr.Zero)
					focalDistance_jfieldId = JNIEnv.GetFieldID (class_ref, "focalDistance", "F");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, focalDistance_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr fov_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.atap.tango.mesh']/class[@name='TangoMeshCamera']/field[@name='fov']"
		[Register ("fov")]
		public float Fov {
			get {
				if (fov_jfieldId == IntPtr.Zero)
					fov_jfieldId = JNIEnv.GetFieldID (class_ref, "fov", "F");
				return JNIEnv.GetFloatField (((global::Java.Lang.Object) this).Handle, fov_jfieldId);
			}
			set {
				if (fov_jfieldId == IntPtr.Zero)
					fov_jfieldId = JNIEnv.GetFieldID (class_ref, "fov", "F");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, fov_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr isOrthographic_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.atap.tango.mesh']/class[@name='TangoMeshCamera']/field[@name='isOrthographic']"
		[Register ("isOrthographic")]
		public bool IsOrthographic {
			get {
				if (isOrthographic_jfieldId == IntPtr.Zero)
					isOrthographic_jfieldId = JNIEnv.GetFieldID (class_ref, "isOrthographic", "Z");
				return JNIEnv.GetBooleanField (((global::Java.Lang.Object) this).Handle, isOrthographic_jfieldId);
			}
			set {
				if (isOrthographic_jfieldId == IntPtr.Zero)
					isOrthographic_jfieldId = JNIEnv.GetFieldID (class_ref, "isOrthographic", "Z");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, isOrthographic_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr viewMatrix_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.atap.tango.mesh']/class[@name='TangoMeshCamera']/field[@name='viewMatrix']"
		[Register ("viewMatrix")]
		public IList<float> ViewMatrix {
			get {
				if (viewMatrix_jfieldId == IntPtr.Zero)
					viewMatrix_jfieldId = JNIEnv.GetFieldID (class_ref, "viewMatrix", "[F");
				return global::Android.Runtime.JavaArray<float>.FromJniHandle (JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, viewMatrix_jfieldId), JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (viewMatrix_jfieldId == IntPtr.Zero)
					viewMatrix_jfieldId = JNIEnv.GetFieldID (class_ref, "viewMatrix", "[F");
				IntPtr native_value = global::Android.Runtime.JavaArray<float>.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, viewMatrix_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/google/atap/tango/mesh/TangoMeshCamera", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (TangoMeshCamera); }
		}

		protected TangoMeshCamera (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.google.atap.tango.mesh']/class[@name='TangoMeshCamera']/constructor[@name='TangoMeshCamera' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe TangoMeshCamera ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (TangoMeshCamera)) {
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
			global::Com.Google.Atap.Tango.Mesh.TangoMeshCamera __this = global::Java.Lang.Object.GetObject<global::Com.Google.Atap.Tango.Mesh.TangoMeshCamera> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.DescribeContents ();
		}
#pragma warning restore 0169

		static IntPtr id_describeContents;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.atap.tango.mesh']/class[@name='TangoMeshCamera']/method[@name='describeContents' and count(parameter)=0]"
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
			global::Com.Google.Atap.Tango.Mesh.TangoMeshCamera __this = global::Java.Lang.Object.GetObject<global::Com.Google.Atap.Tango.Mesh.TangoMeshCamera> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.Parcel p0 = global::Java.Lang.Object.GetObject<global::Android.OS.Parcel> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.ParcelableWriteFlags p1 = (global::Android.OS.ParcelableWriteFlags) native_p1;
			__this.WriteToParcel (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_writeToParcel_Landroid_os_Parcel_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.atap.tango.mesh']/class[@name='TangoMeshCamera']/method[@name='writeToParcel' and count(parameter)=2 and parameter[1][@type='android.os.Parcel'] and parameter[2][@type='int']]"
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
