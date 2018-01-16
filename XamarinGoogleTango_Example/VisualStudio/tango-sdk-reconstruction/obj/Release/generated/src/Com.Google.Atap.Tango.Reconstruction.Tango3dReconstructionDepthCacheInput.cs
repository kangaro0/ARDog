using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Google.Atap.Tango.Reconstruction {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.google.atap.tango.reconstruction']/class[@name='Tango3dReconstructionDepthCacheInput']"
	[global::Android.Runtime.Register ("com/google/atap/tango/reconstruction/Tango3dReconstructionDepthCacheInput", DoNotGenerateAcw=true)]
	public partial class Tango3dReconstructionDepthCacheInput : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/google/atap/tango/reconstruction/Tango3dReconstructionDepthCacheInput", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (Tango3dReconstructionDepthCacheInput); }
		}

		protected Tango3dReconstructionDepthCacheInput (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Ljava_io_File_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.google.atap.tango.reconstruction']/class[@name='Tango3dReconstructionDepthCacheInput']/constructor[@name='Tango3dReconstructionDepthCacheInput' and count(parameter)=1 and parameter[1][@type='java.io.File']]"
		[Register (".ctor", "(Ljava/io/File;)V", "")]
		public unsafe Tango3dReconstructionDepthCacheInput (global::Java.IO.File p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (GetType () != typeof (Tango3dReconstructionDepthCacheInput)) {
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

		static Delegate cb_getNextDepthImage;
#pragma warning disable 0169
		static Delegate GetGetNextDepthImageHandler ()
		{
			if (cb_getNextDepthImage == null)
				cb_getNextDepthImage = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetNextDepthImage);
			return cb_getNextDepthImage;
		}

		static IntPtr n_GetNextDepthImage (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Google.Atap.Tango.Reconstruction.Tango3dReconstructionDepthCacheInput __this = global::Java.Lang.Object.GetObject<global::Com.Google.Atap.Tango.Reconstruction.Tango3dReconstructionDepthCacheInput> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.NextDepthImage);
		}
#pragma warning restore 0169

		static IntPtr id_getNextDepthImage;
		public virtual unsafe global::Com.Google.Atap.Tangoservice.Experimental.TangoImageBuffer NextDepthImage {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.atap.tango.reconstruction']/class[@name='Tango3dReconstructionDepthCacheInput']/method[@name='getNextDepthImage' and count(parameter)=0]"
			[Register ("getNextDepthImage", "()Lcom/google/atap/tangoservice/experimental/TangoImageBuffer;", "GetGetNextDepthImageHandler")]
			get {
				if (id_getNextDepthImage == IntPtr.Zero)
					id_getNextDepthImage = JNIEnv.GetMethodID (class_ref, "getNextDepthImage", "()Lcom/google/atap/tangoservice/experimental/TangoImageBuffer;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Com.Google.Atap.Tangoservice.Experimental.TangoImageBuffer> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getNextDepthImage), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Com.Google.Atap.Tangoservice.Experimental.TangoImageBuffer> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getNextDepthImage", "()Lcom/google/atap/tangoservice/experimental/TangoImageBuffer;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getNumEntries;
#pragma warning disable 0169
		static Delegate GetGetNumEntriesHandler ()
		{
			if (cb_getNumEntries == null)
				cb_getNumEntries = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetNumEntries);
			return cb_getNumEntries;
		}

		static int n_GetNumEntries (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Google.Atap.Tango.Reconstruction.Tango3dReconstructionDepthCacheInput __this = global::Java.Lang.Object.GetObject<global::Com.Google.Atap.Tango.Reconstruction.Tango3dReconstructionDepthCacheInput> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.NumEntries;
		}
#pragma warning restore 0169

		static IntPtr id_getNumEntries;
		public virtual unsafe int NumEntries {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.atap.tango.reconstruction']/class[@name='Tango3dReconstructionDepthCacheInput']/method[@name='getNumEntries' and count(parameter)=0]"
			[Register ("getNumEntries", "()I", "GetGetNumEntriesHandler")]
			get {
				if (id_getNumEntries == IntPtr.Zero)
					id_getNumEntries = JNIEnv.GetMethodID (class_ref, "getNumEntries", "()I");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getNumEntries);
					else
						return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getNumEntries", "()I"));
				} finally {
				}
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
			global::Com.Google.Atap.Tango.Reconstruction.Tango3dReconstructionDepthCacheInput __this = global::Java.Lang.Object.GetObject<global::Com.Google.Atap.Tango.Reconstruction.Tango3dReconstructionDepthCacheInput> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Google.Atap.Tangoservice.TangoCameraIntrinsics p0 = global::Java.Lang.Object.GetObject<global::Com.Google.Atap.Tangoservice.TangoCameraIntrinsics> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetIntrinsics (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setIntrinsics_Lcom_google_atap_tangoservice_TangoCameraIntrinsics_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.atap.tango.reconstruction']/class[@name='Tango3dReconstructionDepthCacheInput']/method[@name='setIntrinsics' and count(parameter)=1 and parameter[1][@type='com.google.atap.tangoservice.TangoCameraIntrinsics']]"
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
