using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Google.Atap.Tangoservice.Experimental {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.google.atap.tangoservice.experimental']/class[@name='TangoTransformation']"
	[global::Android.Runtime.Register ("com/google/atap/tangoservice/experimental/TangoTransformation", DoNotGenerateAcw=true)]
	public partial class TangoTransformation : global::Java.Lang.Object, global::Android.OS.IParcelable {


		static IntPtr CREATOR_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.atap.tangoservice.experimental']/class[@name='TangoTransformation']/field[@name='CREATOR']"
		[Register ("CREATOR")]
		public static global::Android.OS.IParcelableCreator Creator {
			get {
				if (CREATOR_jfieldId == IntPtr.Zero)
					CREATOR_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "CREATOR", "Landroid/os/Parcelable$Creator;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, CREATOR_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Android.OS.IParcelableCreator> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.atap.tangoservice.experimental']/class[@name='TangoTransformation']/field[@name='INDEX_ROTATION_W']"
		[Register ("INDEX_ROTATION_W")]
		public const int IndexRotationW = (int) 3;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.atap.tangoservice.experimental']/class[@name='TangoTransformation']/field[@name='INDEX_ROTATION_X']"
		[Register ("INDEX_ROTATION_X")]
		public const int IndexRotationX = (int) 0;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.atap.tangoservice.experimental']/class[@name='TangoTransformation']/field[@name='INDEX_ROTATION_Y']"
		[Register ("INDEX_ROTATION_Y")]
		public const int IndexRotationY = (int) 1;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.atap.tangoservice.experimental']/class[@name='TangoTransformation']/field[@name='INDEX_ROTATION_Z']"
		[Register ("INDEX_ROTATION_Z")]
		public const int IndexRotationZ = (int) 2;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.atap.tangoservice.experimental']/class[@name='TangoTransformation']/field[@name='INDEX_TRANSLATION_X']"
		[Register ("INDEX_TRANSLATION_X")]
		public const int IndexTranslationX = (int) 0;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.atap.tangoservice.experimental']/class[@name='TangoTransformation']/field[@name='INDEX_TRANSLATION_Y']"
		[Register ("INDEX_TRANSLATION_Y")]
		public const int IndexTranslationY = (int) 1;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.atap.tangoservice.experimental']/class[@name='TangoTransformation']/field[@name='INDEX_TRANSLATION_Z']"
		[Register ("INDEX_TRANSLATION_Z")]
		public const int IndexTranslationZ = (int) 2;

		static IntPtr rotation_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.atap.tangoservice.experimental']/class[@name='TangoTransformation']/field[@name='rotation']"
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

		static IntPtr translation_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.atap.tangoservice.experimental']/class[@name='TangoTransformation']/field[@name='translation']"
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
				return JNIEnv.FindClass ("com/google/atap/tangoservice/experimental/TangoTransformation", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (TangoTransformation); }
		}

		protected TangoTransformation (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.google.atap.tangoservice.experimental']/class[@name='TangoTransformation']/constructor[@name='TangoTransformation' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe TangoTransformation ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (TangoTransformation)) {
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
			global::Com.Google.Atap.Tangoservice.Experimental.TangoTransformation __this = global::Java.Lang.Object.GetObject<global::Com.Google.Atap.Tangoservice.Experimental.TangoTransformation> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.DescribeContents ();
		}
#pragma warning restore 0169

		static IntPtr id_describeContents;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.atap.tangoservice.experimental']/class[@name='TangoTransformation']/method[@name='describeContents' and count(parameter)=0]"
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
			global::Com.Google.Atap.Tangoservice.Experimental.TangoTransformation __this = global::Java.Lang.Object.GetObject<global::Com.Google.Atap.Tangoservice.Experimental.TangoTransformation> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetRotationAsFloats ());
		}
#pragma warning restore 0169

		static IntPtr id_getRotationAsFloats;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.atap.tangoservice.experimental']/class[@name='TangoTransformation']/method[@name='getRotationAsFloats' and count(parameter)=0]"
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
			global::Com.Google.Atap.Tangoservice.Experimental.TangoTransformation __this = global::Java.Lang.Object.GetObject<global::Com.Google.Atap.Tangoservice.Experimental.TangoTransformation> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetTranslationAsFloats ());
		}
#pragma warning restore 0169

		static IntPtr id_getTranslationAsFloats;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.atap.tangoservice.experimental']/class[@name='TangoTransformation']/method[@name='getTranslationAsFloats' and count(parameter)=0]"
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
			global::Com.Google.Atap.Tangoservice.Experimental.TangoTransformation __this = global::Java.Lang.Object.GetObject<global::Com.Google.Atap.Tangoservice.Experimental.TangoTransformation> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.Parcel p0 = global::Java.Lang.Object.GetObject<global::Android.OS.Parcel> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.ReadFromParcel (p0);
		}
#pragma warning restore 0169

		static IntPtr id_readFromParcel_Landroid_os_Parcel_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.atap.tangoservice.experimental']/class[@name='TangoTransformation']/method[@name='readFromParcel' and count(parameter)=1 and parameter[1][@type='android.os.Parcel']]"
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
			global::Com.Google.Atap.Tangoservice.Experimental.TangoTransformation __this = global::Java.Lang.Object.GetObject<global::Com.Google.Atap.Tangoservice.Experimental.TangoTransformation> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.Parcel p0 = global::Java.Lang.Object.GetObject<global::Android.OS.Parcel> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.ParcelableWriteFlags p1 = (global::Android.OS.ParcelableWriteFlags) native_p1;
			__this.WriteToParcel (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_writeToParcel_Landroid_os_Parcel_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.atap.tangoservice.experimental']/class[@name='TangoTransformation']/method[@name='writeToParcel' and count(parameter)=2 and parameter[1][@type='android.os.Parcel'] and parameter[2][@type='int']]"
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
