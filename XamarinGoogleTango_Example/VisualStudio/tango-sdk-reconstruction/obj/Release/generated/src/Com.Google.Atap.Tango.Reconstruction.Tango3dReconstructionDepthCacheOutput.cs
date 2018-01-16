using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Google.Atap.Tango.Reconstruction {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.google.atap.tango.reconstruction']/class[@name='Tango3dReconstructionDepthCacheOutput']"
	[global::Android.Runtime.Register ("com/google/atap/tango/reconstruction/Tango3dReconstructionDepthCacheOutput", DoNotGenerateAcw=true)]
	public partial class Tango3dReconstructionDepthCacheOutput : global::Java.Lang.Object {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.atap.tango.reconstruction']/class[@name='Tango3dReconstructionDepthCacheOutput']/field[@name='NANOSECONDS_IN_SECOND']"
		[Register ("NANOSECONDS_IN_SECOND")]
		public const double NanosecondsInSecond = (double) 1000000000.000000000000000;
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/google/atap/tango/reconstruction/Tango3dReconstructionDepthCacheOutput", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (Tango3dReconstructionDepthCacheOutput); }
		}

		protected Tango3dReconstructionDepthCacheOutput (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Ljava_io_File_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.google.atap.tango.reconstruction']/class[@name='Tango3dReconstructionDepthCacheOutput']/constructor[@name='Tango3dReconstructionDepthCacheOutput' and count(parameter)=1 and parameter[1][@type='java.io.File']]"
		[Register (".ctor", "(Ljava/io/File;)V", "")]
		public unsafe Tango3dReconstructionDepthCacheOutput (global::Java.IO.File p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (GetType () != typeof (Tango3dReconstructionDepthCacheOutput)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Ljava/io/File;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Ljava/io/File;)V", __args);
					return;
				}

				if (id_ctor_Ljava_io_File_ == IntPtr.Zero)
					id_ctor_Ljava_io_File_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/io/File;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_io_File_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Ljava_io_File_, __args);
			} finally {
			}
		}

		static Delegate cb_addPointCloudAsDepthImage_Lcom_google_atap_tangoservice_TangoPointCloudData_;
#pragma warning disable 0169
		static Delegate GetAddPointCloudAsDepthImage_Lcom_google_atap_tangoservice_TangoPointCloudData_Handler ()
		{
			if (cb_addPointCloudAsDepthImage_Lcom_google_atap_tangoservice_TangoPointCloudData_ == null)
				cb_addPointCloudAsDepthImage_Lcom_google_atap_tangoservice_TangoPointCloudData_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_AddPointCloudAsDepthImage_Lcom_google_atap_tangoservice_TangoPointCloudData_);
			return cb_addPointCloudAsDepthImage_Lcom_google_atap_tangoservice_TangoPointCloudData_;
		}

		static void n_AddPointCloudAsDepthImage_Lcom_google_atap_tangoservice_TangoPointCloudData_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Google.Atap.Tango.Reconstruction.Tango3dReconstructionDepthCacheOutput __this = global::Java.Lang.Object.GetObject<global::Com.Google.Atap.Tango.Reconstruction.Tango3dReconstructionDepthCacheOutput> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Google.Atap.Tangoservice.TangoPointCloudData p0 = global::Java.Lang.Object.GetObject<global::Com.Google.Atap.Tangoservice.TangoPointCloudData> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.AddPointCloudAsDepthImage (p0);
		}
#pragma warning restore 0169

		static IntPtr id_addPointCloudAsDepthImage_Lcom_google_atap_tangoservice_TangoPointCloudData_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.atap.tango.reconstruction']/class[@name='Tango3dReconstructionDepthCacheOutput']/method[@name='addPointCloudAsDepthImage' and count(parameter)=1 and parameter[1][@type='com.google.atap.tangoservice.TangoPointCloudData']]"
		[Register ("addPointCloudAsDepthImage", "(Lcom/google/atap/tangoservice/TangoPointCloudData;)V", "GetAddPointCloudAsDepthImage_Lcom_google_atap_tangoservice_TangoPointCloudData_Handler")]
		public virtual unsafe void AddPointCloudAsDepthImage (global::Com.Google.Atap.Tangoservice.TangoPointCloudData p0)
		{
			if (id_addPointCloudAsDepthImage_Lcom_google_atap_tangoservice_TangoPointCloudData_ == IntPtr.Zero)
				id_addPointCloudAsDepthImage_Lcom_google_atap_tangoservice_TangoPointCloudData_ = JNIEnv.GetMethodID (class_ref, "addPointCloudAsDepthImage", "(Lcom/google/atap/tangoservice/TangoPointCloudData;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_addPointCloudAsDepthImage_Lcom_google_atap_tangoservice_TangoPointCloudData_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "addPointCloudAsDepthImage", "(Lcom/google/atap/tangoservice/TangoPointCloudData;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_delete;
#pragma warning disable 0169
		static Delegate GetDeleteHandler ()
		{
			if (cb_delete == null)
				cb_delete = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Delete);
			return cb_delete;
		}

		static void n_Delete (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Google.Atap.Tango.Reconstruction.Tango3dReconstructionDepthCacheOutput __this = global::Java.Lang.Object.GetObject<global::Com.Google.Atap.Tango.Reconstruction.Tango3dReconstructionDepthCacheOutput> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Delete ();
		}
#pragma warning restore 0169

		static IntPtr id_delete;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.atap.tango.reconstruction']/class[@name='Tango3dReconstructionDepthCacheOutput']/method[@name='delete' and count(parameter)=0]"
		[Register ("delete", "()V", "GetDeleteHandler")]
		public virtual unsafe void Delete ()
		{
			if (id_delete == IntPtr.Zero)
				id_delete = JNIEnv.GetMethodID (class_ref, "delete", "()V");
			try {

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_delete);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "delete", "()V"));
			} finally {
			}
		}

		static Delegate cb_moveToAndRelease_Ljava_io_File_;
#pragma warning disable 0169
		static Delegate GetMoveToAndRelease_Ljava_io_File_Handler ()
		{
			if (cb_moveToAndRelease_Ljava_io_File_ == null)
				cb_moveToAndRelease_Ljava_io_File_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_MoveToAndRelease_Ljava_io_File_);
			return cb_moveToAndRelease_Ljava_io_File_;
		}

		static bool n_MoveToAndRelease_Ljava_io_File_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Google.Atap.Tango.Reconstruction.Tango3dReconstructionDepthCacheOutput __this = global::Java.Lang.Object.GetObject<global::Com.Google.Atap.Tango.Reconstruction.Tango3dReconstructionDepthCacheOutput> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.IO.File p0 = global::Java.Lang.Object.GetObject<global::Java.IO.File> (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.MoveToAndRelease (p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_moveToAndRelease_Ljava_io_File_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.atap.tango.reconstruction']/class[@name='Tango3dReconstructionDepthCacheOutput']/method[@name='moveToAndRelease' and count(parameter)=1 and parameter[1][@type='java.io.File']]"
		[Register ("moveToAndRelease", "(Ljava/io/File;)Z", "GetMoveToAndRelease_Ljava_io_File_Handler")]
		public virtual unsafe bool MoveToAndRelease (global::Java.IO.File p0)
		{
			if (id_moveToAndRelease_Ljava_io_File_ == IntPtr.Zero)
				id_moveToAndRelease_Ljava_io_File_ = JNIEnv.GetMethodID (class_ref, "moveToAndRelease", "(Ljava/io/File;)Z");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				bool __ret;
				if (GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_moveToAndRelease_Ljava_io_File_, __args);
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "moveToAndRelease", "(Ljava/io/File;)Z"), __args);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_release;
#pragma warning disable 0169
		static Delegate GetReleaseHandler ()
		{
			if (cb_release == null)
				cb_release = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Release);
			return cb_release;
		}

		static void n_Release (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Google.Atap.Tango.Reconstruction.Tango3dReconstructionDepthCacheOutput __this = global::Java.Lang.Object.GetObject<global::Com.Google.Atap.Tango.Reconstruction.Tango3dReconstructionDepthCacheOutput> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Release ();
		}
#pragma warning restore 0169

		static IntPtr id_release;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.atap.tango.reconstruction']/class[@name='Tango3dReconstructionDepthCacheOutput']/method[@name='release' and count(parameter)=0]"
		[Register ("release", "()V", "GetReleaseHandler")]
		public virtual unsafe void Release ()
		{
			if (id_release == IntPtr.Zero)
				id_release = JNIEnv.GetMethodID (class_ref, "release", "()V");
			try {

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_release);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "release", "()V"));
			} finally {
			}
		}

		static Delegate cb_reset;
#pragma warning disable 0169
		static Delegate GetResetHandler ()
		{
			if (cb_reset == null)
				cb_reset = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Reset);
			return cb_reset;
		}

		static void n_Reset (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Google.Atap.Tango.Reconstruction.Tango3dReconstructionDepthCacheOutput __this = global::Java.Lang.Object.GetObject<global::Com.Google.Atap.Tango.Reconstruction.Tango3dReconstructionDepthCacheOutput> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Reset ();
		}
#pragma warning restore 0169

		static IntPtr id_reset;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.atap.tango.reconstruction']/class[@name='Tango3dReconstructionDepthCacheOutput']/method[@name='reset' and count(parameter)=0]"
		[Register ("reset", "()V", "GetResetHandler")]
		public virtual unsafe void Reset ()
		{
			if (id_reset == IntPtr.Zero)
				id_reset = JNIEnv.GetMethodID (class_ref, "reset", "()V");
			try {

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_reset);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "reset", "()V"));
			} finally {
			}
		}

		static Delegate cb_setIntrinsics_Lcom_google_atap_tangoservice_TangoCameraIntrinsics_;
#pragma warning disable 0169
		static Delegate GetSetIntrinsics_Lcom_google_atap_tangoservice_TangoCameraIntrinsics_Handler ()
		{
			if (cb_setIntrinsics_Lcom_google_atap_tangoservice_TangoCameraIntrinsics_ == null)
				cb_setIntrinsics_Lcom_google_atap_tangoservice_TangoCameraIntrinsics_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetIntrinsics_Lcom_google_atap_tangoservice_TangoCameraIntrinsics_);
			return cb_setIntrinsics_Lcom_google_atap_tangoservice_TangoCameraIntrinsics_;
		}

		static void n_SetIntrinsics_Lcom_google_atap_tangoservice_TangoCameraIntrinsics_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Google.Atap.Tango.Reconstruction.Tango3dReconstructionDepthCacheOutput __this = global::Java.Lang.Object.GetObject<global::Com.Google.Atap.Tango.Reconstruction.Tango3dReconstructionDepthCacheOutput> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Google.Atap.Tangoservice.TangoCameraIntrinsics p0 = global::Java.Lang.Object.GetObject<global::Com.Google.Atap.Tangoservice.TangoCameraIntrinsics> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetIntrinsics (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setIntrinsics_Lcom_google_atap_tangoservice_TangoCameraIntrinsics_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.atap.tango.reconstruction']/class[@name='Tango3dReconstructionDepthCacheOutput']/method[@name='setIntrinsics' and count(parameter)=1 and parameter[1][@type='com.google.atap.tangoservice.TangoCameraIntrinsics']]"
		[Register ("setIntrinsics", "(Lcom/google/atap/tangoservice/TangoCameraIntrinsics;)V", "GetSetIntrinsics_Lcom_google_atap_tangoservice_TangoCameraIntrinsics_Handler")]
		public virtual unsafe void SetIntrinsics (global::Com.Google.Atap.Tangoservice.TangoCameraIntrinsics p0)
		{
			if (id_setIntrinsics_Lcom_google_atap_tangoservice_TangoCameraIntrinsics_ == IntPtr.Zero)
				id_setIntrinsics_Lcom_google_atap_tangoservice_TangoCameraIntrinsics_ = JNIEnv.GetMethodID (class_ref, "setIntrinsics", "(Lcom/google/atap/tangoservice/TangoCameraIntrinsics;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setIntrinsics_Lcom_google_atap_tangoservice_TangoCameraIntrinsics_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setIntrinsics", "(Lcom/google/atap/tangoservice/TangoCameraIntrinsics;)V"), __args);
			} finally {
			}
		}

	}
}
