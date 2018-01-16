using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Google.Atap.Tango.Reconstruction {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.google.atap.tango.reconstruction']/class[@name='Tango3dReconstructionBufferCache']"
	[global::Android.Runtime.Register ("com/google/atap/tango/reconstruction/Tango3dReconstructionBufferCache", DoNotGenerateAcw=true)]
	public partial class Tango3dReconstructionBufferCache : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/google/atap/tango/reconstruction/Tango3dReconstructionBufferCache", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (Tango3dReconstructionBufferCache); }
		}

		protected Tango3dReconstructionBufferCache (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Ljava_io_File_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.google.atap.tango.reconstruction']/class[@name='Tango3dReconstructionBufferCache']/constructor[@name='Tango3dReconstructionBufferCache' and count(parameter)=1 and parameter[1][@type='java.io.File']]"
		[Register (".ctor", "(Ljava/io/File;)V", "")]
		public unsafe Tango3dReconstructionBufferCache (global::Java.IO.File p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (GetType () != typeof (Tango3dReconstructionBufferCache)) {
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

		static Delegate cb_getExtrinsics;
#pragma warning disable 0169
		static Delegate GetGetExtrinsicsHandler ()
		{
			if (cb_getExtrinsics == null)
				cb_getExtrinsics = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetExtrinsics);
			return cb_getExtrinsics;
		}

		static IntPtr n_GetExtrinsics (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Google.Atap.Tango.Reconstruction.Tango3dReconstructionBufferCache __this = global::Java.Lang.Object.GetObject<global::Com.Google.Atap.Tango.Reconstruction.Tango3dReconstructionBufferCache> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Extrinsics);
		}
#pragma warning restore 0169

		static IntPtr id_getExtrinsics;
		public virtual unsafe global::Com.Google.Atap.Tangoservice.TangoPoseData Extrinsics {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.atap.tango.reconstruction']/class[@name='Tango3dReconstructionBufferCache']/method[@name='getExtrinsics' and count(parameter)=0]"
			[Register ("getExtrinsics", "()Lcom/google/atap/tangoservice/TangoPoseData;", "GetGetExtrinsicsHandler")]
			get {
				if (id_getExtrinsics == IntPtr.Zero)
					id_getExtrinsics = JNIEnv.GetMethodID (class_ref, "getExtrinsics", "()Lcom/google/atap/tangoservice/TangoPoseData;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Com.Google.Atap.Tangoservice.TangoPoseData> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getExtrinsics), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Com.Google.Atap.Tangoservice.TangoPoseData> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getExtrinsics", "()Lcom/google/atap/tangoservice/TangoPoseData;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getIntrinsics;
#pragma warning disable 0169
		static Delegate GetGetIntrinsicsHandler ()
		{
			if (cb_getIntrinsics == null)
				cb_getIntrinsics = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetIntrinsics);
			return cb_getIntrinsics;
		}

		static IntPtr n_GetIntrinsics (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Google.Atap.Tango.Reconstruction.Tango3dReconstructionBufferCache __this = global::Java.Lang.Object.GetObject<global::Com.Google.Atap.Tango.Reconstruction.Tango3dReconstructionBufferCache> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Intrinsics);
		}
#pragma warning restore 0169

		static IntPtr id_getIntrinsics;
		public virtual unsafe global::Com.Google.Atap.Tangoservice.TangoCameraIntrinsics Intrinsics {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.atap.tango.reconstruction']/class[@name='Tango3dReconstructionBufferCache']/method[@name='getIntrinsics' and count(parameter)=0]"
			[Register ("getIntrinsics", "()Lcom/google/atap/tangoservice/TangoCameraIntrinsics;", "GetGetIntrinsicsHandler")]
			get {
				if (id_getIntrinsics == IntPtr.Zero)
					id_getIntrinsics = JNIEnv.GetMethodID (class_ref, "getIntrinsics", "()Lcom/google/atap/tangoservice/TangoCameraIntrinsics;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Com.Google.Atap.Tangoservice.TangoCameraIntrinsics> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getIntrinsics), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Com.Google.Atap.Tangoservice.TangoCameraIntrinsics> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getIntrinsics", "()Lcom/google/atap/tangoservice/TangoCameraIntrinsics;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_addExtrinsics_Lcom_google_atap_tangoservice_TangoPoseData_;
#pragma warning disable 0169
		static Delegate GetAddExtrinsics_Lcom_google_atap_tangoservice_TangoPoseData_Handler ()
		{
			if (cb_addExtrinsics_Lcom_google_atap_tangoservice_TangoPoseData_ == null)
				cb_addExtrinsics_Lcom_google_atap_tangoservice_TangoPoseData_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_AddExtrinsics_Lcom_google_atap_tangoservice_TangoPoseData_);
			return cb_addExtrinsics_Lcom_google_atap_tangoservice_TangoPoseData_;
		}

		static void n_AddExtrinsics_Lcom_google_atap_tangoservice_TangoPoseData_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Google.Atap.Tango.Reconstruction.Tango3dReconstructionBufferCache __this = global::Java.Lang.Object.GetObject<global::Com.Google.Atap.Tango.Reconstruction.Tango3dReconstructionBufferCache> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Google.Atap.Tangoservice.TangoPoseData p0 = global::Java.Lang.Object.GetObject<global::Com.Google.Atap.Tangoservice.TangoPoseData> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.AddExtrinsics (p0);
		}
#pragma warning restore 0169

		static IntPtr id_addExtrinsics_Lcom_google_atap_tangoservice_TangoPoseData_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.atap.tango.reconstruction']/class[@name='Tango3dReconstructionBufferCache']/method[@name='addExtrinsics' and count(parameter)=1 and parameter[1][@type='com.google.atap.tangoservice.TangoPoseData']]"
		[Register ("addExtrinsics", "(Lcom/google/atap/tangoservice/TangoPoseData;)V", "GetAddExtrinsics_Lcom_google_atap_tangoservice_TangoPoseData_Handler")]
		public virtual unsafe void AddExtrinsics (global::Com.Google.Atap.Tangoservice.TangoPoseData p0)
		{
			if (id_addExtrinsics_Lcom_google_atap_tangoservice_TangoPoseData_ == IntPtr.Zero)
				id_addExtrinsics_Lcom_google_atap_tangoservice_TangoPoseData_ = JNIEnv.GetMethodID (class_ref, "addExtrinsics", "(Lcom/google/atap/tangoservice/TangoPoseData;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_addExtrinsics_Lcom_google_atap_tangoservice_TangoPoseData_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "addExtrinsics", "(Lcom/google/atap/tangoservice/TangoPoseData;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_addImageBuffer_Lcom_google_atap_tangoservice_experimental_TangoImageBuffer_;
#pragma warning disable 0169
		static Delegate GetAddImageBuffer_Lcom_google_atap_tangoservice_experimental_TangoImageBuffer_Handler ()
		{
			if (cb_addImageBuffer_Lcom_google_atap_tangoservice_experimental_TangoImageBuffer_ == null)
				cb_addImageBuffer_Lcom_google_atap_tangoservice_experimental_TangoImageBuffer_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_AddImageBuffer_Lcom_google_atap_tangoservice_experimental_TangoImageBuffer_);
			return cb_addImageBuffer_Lcom_google_atap_tangoservice_experimental_TangoImageBuffer_;
		}

		static void n_AddImageBuffer_Lcom_google_atap_tangoservice_experimental_TangoImageBuffer_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Google.Atap.Tango.Reconstruction.Tango3dReconstructionBufferCache __this = global::Java.Lang.Object.GetObject<global::Com.Google.Atap.Tango.Reconstruction.Tango3dReconstructionBufferCache> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Google.Atap.Tangoservice.Experimental.TangoImageBuffer p0 = global::Java.Lang.Object.GetObject<global::Com.Google.Atap.Tangoservice.Experimental.TangoImageBuffer> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.AddImageBuffer (p0);
		}
#pragma warning restore 0169

		static IntPtr id_addImageBuffer_Lcom_google_atap_tangoservice_experimental_TangoImageBuffer_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.atap.tango.reconstruction']/class[@name='Tango3dReconstructionBufferCache']/method[@name='addImageBuffer' and count(parameter)=1 and parameter[1][@type='com.google.atap.tangoservice.experimental.TangoImageBuffer']]"
		[Register ("addImageBuffer", "(Lcom/google/atap/tangoservice/experimental/TangoImageBuffer;)V", "GetAddImageBuffer_Lcom_google_atap_tangoservice_experimental_TangoImageBuffer_Handler")]
		public virtual unsafe void AddImageBuffer (global::Com.Google.Atap.Tangoservice.Experimental.TangoImageBuffer p0)
		{
			if (id_addImageBuffer_Lcom_google_atap_tangoservice_experimental_TangoImageBuffer_ == IntPtr.Zero)
				id_addImageBuffer_Lcom_google_atap_tangoservice_experimental_TangoImageBuffer_ = JNIEnv.GetMethodID (class_ref, "addImageBuffer", "(Lcom/google/atap/tangoservice/experimental/TangoImageBuffer;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_addImageBuffer_Lcom_google_atap_tangoservice_experimental_TangoImageBuffer_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "addImageBuffer", "(Lcom/google/atap/tangoservice/experimental/TangoImageBuffer;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_addIntrinsics_Lcom_google_atap_tangoservice_TangoCameraIntrinsics_;
#pragma warning disable 0169
		static Delegate GetAddIntrinsics_Lcom_google_atap_tangoservice_TangoCameraIntrinsics_Handler ()
		{
			if (cb_addIntrinsics_Lcom_google_atap_tangoservice_TangoCameraIntrinsics_ == null)
				cb_addIntrinsics_Lcom_google_atap_tangoservice_TangoCameraIntrinsics_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_AddIntrinsics_Lcom_google_atap_tangoservice_TangoCameraIntrinsics_);
			return cb_addIntrinsics_Lcom_google_atap_tangoservice_TangoCameraIntrinsics_;
		}

		static void n_AddIntrinsics_Lcom_google_atap_tangoservice_TangoCameraIntrinsics_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Google.Atap.Tango.Reconstruction.Tango3dReconstructionBufferCache __this = global::Java.Lang.Object.GetObject<global::Com.Google.Atap.Tango.Reconstruction.Tango3dReconstructionBufferCache> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Google.Atap.Tangoservice.TangoCameraIntrinsics p0 = global::Java.Lang.Object.GetObject<global::Com.Google.Atap.Tangoservice.TangoCameraIntrinsics> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.AddIntrinsics (p0);
		}
#pragma warning restore 0169

		static IntPtr id_addIntrinsics_Lcom_google_atap_tangoservice_TangoCameraIntrinsics_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.atap.tango.reconstruction']/class[@name='Tango3dReconstructionBufferCache']/method[@name='addIntrinsics' and count(parameter)=1 and parameter[1][@type='com.google.atap.tangoservice.TangoCameraIntrinsics']]"
		[Register ("addIntrinsics", "(Lcom/google/atap/tangoservice/TangoCameraIntrinsics;)V", "GetAddIntrinsics_Lcom_google_atap_tangoservice_TangoCameraIntrinsics_Handler")]
		public virtual unsafe void AddIntrinsics (global::Com.Google.Atap.Tangoservice.TangoCameraIntrinsics p0)
		{
			if (id_addIntrinsics_Lcom_google_atap_tangoservice_TangoCameraIntrinsics_ == IntPtr.Zero)
				id_addIntrinsics_Lcom_google_atap_tangoservice_TangoCameraIntrinsics_ = JNIEnv.GetMethodID (class_ref, "addIntrinsics", "(Lcom/google/atap/tangoservice/TangoCameraIntrinsics;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_addIntrinsics_Lcom_google_atap_tangoservice_TangoCameraIntrinsics_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "addIntrinsics", "(Lcom/google/atap/tangoservice/TangoCameraIntrinsics;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_addPointCloud_Lcom_google_atap_tangoservice_TangoPointCloudData_;
#pragma warning disable 0169
		static Delegate GetAddPointCloud_Lcom_google_atap_tangoservice_TangoPointCloudData_Handler ()
		{
			if (cb_addPointCloud_Lcom_google_atap_tangoservice_TangoPointCloudData_ == null)
				cb_addPointCloud_Lcom_google_atap_tangoservice_TangoPointCloudData_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_AddPointCloud_Lcom_google_atap_tangoservice_TangoPointCloudData_);
			return cb_addPointCloud_Lcom_google_atap_tangoservice_TangoPointCloudData_;
		}

		static void n_AddPointCloud_Lcom_google_atap_tangoservice_TangoPointCloudData_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Google.Atap.Tango.Reconstruction.Tango3dReconstructionBufferCache __this = global::Java.Lang.Object.GetObject<global::Com.Google.Atap.Tango.Reconstruction.Tango3dReconstructionBufferCache> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Google.Atap.Tangoservice.TangoPointCloudData p0 = global::Java.Lang.Object.GetObject<global::Com.Google.Atap.Tangoservice.TangoPointCloudData> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.AddPointCloud (p0);
		}
#pragma warning restore 0169

		static IntPtr id_addPointCloud_Lcom_google_atap_tangoservice_TangoPointCloudData_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.atap.tango.reconstruction']/class[@name='Tango3dReconstructionBufferCache']/method[@name='addPointCloud' and count(parameter)=1 and parameter[1][@type='com.google.atap.tangoservice.TangoPointCloudData']]"
		[Register ("addPointCloud", "(Lcom/google/atap/tangoservice/TangoPointCloudData;)V", "GetAddPointCloud_Lcom_google_atap_tangoservice_TangoPointCloudData_Handler")]
		public virtual unsafe void AddPointCloud (global::Com.Google.Atap.Tangoservice.TangoPointCloudData p0)
		{
			if (id_addPointCloud_Lcom_google_atap_tangoservice_TangoPointCloudData_ == IntPtr.Zero)
				id_addPointCloud_Lcom_google_atap_tangoservice_TangoPointCloudData_ = JNIEnv.GetMethodID (class_ref, "addPointCloud", "(Lcom/google/atap/tangoservice/TangoPointCloudData;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_addPointCloud_Lcom_google_atap_tangoservice_TangoPointCloudData_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "addPointCloud", "(Lcom/google/atap/tangoservice/TangoPointCloudData;)V"), __args);
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
			global::Com.Google.Atap.Tango.Reconstruction.Tango3dReconstructionBufferCache __this = global::Java.Lang.Object.GetObject<global::Com.Google.Atap.Tango.Reconstruction.Tango3dReconstructionBufferCache> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Delete ();
		}
#pragma warning restore 0169

		static IntPtr id_delete;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.atap.tango.reconstruction']/class[@name='Tango3dReconstructionBufferCache']/method[@name='delete' and count(parameter)=0]"
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

		static Delegate cb_finalize;
#pragma warning disable 0169
		static Delegate GetFinalizeHandler ()
		{
			if (cb_finalize == null)
				cb_finalize = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Finalize);
			return cb_finalize;
		}

		static void n_Finalize (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Google.Atap.Tango.Reconstruction.Tango3dReconstructionBufferCache __this = global::Java.Lang.Object.GetObject<global::Com.Google.Atap.Tango.Reconstruction.Tango3dReconstructionBufferCache> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Finalize ();
		}
#pragma warning restore 0169

		static IntPtr id_finalize;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.atap.tango.reconstruction']/class[@name='Tango3dReconstructionBufferCache']/method[@name='finalize' and count(parameter)=0]"
		[Register ("finalize", "()V", "GetFinalizeHandler")]
		public virtual unsafe void Finalize ()
		{
			if (id_finalize == IntPtr.Zero)
				id_finalize = JNIEnv.GetMethodID (class_ref, "finalize", "()V");
			try {

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_finalize);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "finalize", "()V"));
			} finally {
			}
		}

		static Delegate cb_getImageBuffer_I;
#pragma warning disable 0169
		static Delegate GetGetImageBuffer_IHandler ()
		{
			if (cb_getImageBuffer_I == null)
				cb_getImageBuffer_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_GetImageBuffer_I);
			return cb_getImageBuffer_I;
		}

		static IntPtr n_GetImageBuffer_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Google.Atap.Tango.Reconstruction.Tango3dReconstructionBufferCache __this = global::Java.Lang.Object.GetObject<global::Com.Google.Atap.Tango.Reconstruction.Tango3dReconstructionBufferCache> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.GetImageBuffer (p0));
		}
#pragma warning restore 0169

		static IntPtr id_getImageBuffer_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.atap.tango.reconstruction']/class[@name='Tango3dReconstructionBufferCache']/method[@name='getImageBuffer' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("getImageBuffer", "(I)Lcom/google/atap/tangoservice/experimental/TangoImageBuffer;", "GetGetImageBuffer_IHandler")]
		public virtual unsafe global::Com.Google.Atap.Tangoservice.Experimental.TangoImageBuffer GetImageBuffer (int p0)
		{
			if (id_getImageBuffer_I == IntPtr.Zero)
				id_getImageBuffer_I = JNIEnv.GetMethodID (class_ref, "getImageBuffer", "(I)Lcom/google/atap/tangoservice/experimental/TangoImageBuffer;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Com.Google.Atap.Tangoservice.Experimental.TangoImageBuffer> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getImageBuffer_I, __args), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Com.Google.Atap.Tangoservice.Experimental.TangoImageBuffer> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getImageBuffer", "(I)Lcom/google/atap/tangoservice/experimental/TangoImageBuffer;"), __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_getPointCloud_I;
#pragma warning disable 0169
		static Delegate GetGetPointCloud_IHandler ()
		{
			if (cb_getPointCloud_I == null)
				cb_getPointCloud_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_GetPointCloud_I);
			return cb_getPointCloud_I;
		}

		static IntPtr n_GetPointCloud_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Google.Atap.Tango.Reconstruction.Tango3dReconstructionBufferCache __this = global::Java.Lang.Object.GetObject<global::Com.Google.Atap.Tango.Reconstruction.Tango3dReconstructionBufferCache> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.GetPointCloud (p0));
		}
#pragma warning restore 0169

		static IntPtr id_getPointCloud_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.atap.tango.reconstruction']/class[@name='Tango3dReconstructionBufferCache']/method[@name='getPointCloud' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("getPointCloud", "(I)Lcom/google/atap/tangoservice/TangoPointCloudData;", "GetGetPointCloud_IHandler")]
		public virtual unsafe global::Com.Google.Atap.Tangoservice.TangoPointCloudData GetPointCloud (int p0)
		{
			if (id_getPointCloud_I == IntPtr.Zero)
				id_getPointCloud_I = JNIEnv.GetMethodID (class_ref, "getPointCloud", "(I)Lcom/google/atap/tangoservice/TangoPointCloudData;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Com.Google.Atap.Tangoservice.TangoPointCloudData> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getPointCloud_I, __args), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Com.Google.Atap.Tangoservice.TangoPointCloudData> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getPointCloud", "(I)Lcom/google/atap/tangoservice/TangoPointCloudData;"), __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_moveTo_Ljava_io_File_;
#pragma warning disable 0169
		static Delegate GetMoveTo_Ljava_io_File_Handler ()
		{
			if (cb_moveTo_Ljava_io_File_ == null)
				cb_moveTo_Ljava_io_File_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_MoveTo_Ljava_io_File_);
			return cb_moveTo_Ljava_io_File_;
		}

		static bool n_MoveTo_Ljava_io_File_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Google.Atap.Tango.Reconstruction.Tango3dReconstructionBufferCache __this = global::Java.Lang.Object.GetObject<global::Com.Google.Atap.Tango.Reconstruction.Tango3dReconstructionBufferCache> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.IO.File p0 = global::Java.Lang.Object.GetObject<global::Java.IO.File> (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.MoveTo (p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_moveTo_Ljava_io_File_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.atap.tango.reconstruction']/class[@name='Tango3dReconstructionBufferCache']/method[@name='moveTo' and count(parameter)=1 and parameter[1][@type='java.io.File']]"
		[Register ("moveTo", "(Ljava/io/File;)Z", "GetMoveTo_Ljava_io_File_Handler")]
		public virtual unsafe bool MoveTo (global::Java.IO.File p0)
		{
			if (id_moveTo_Ljava_io_File_ == IntPtr.Zero)
				id_moveTo_Ljava_io_File_ = JNIEnv.GetMethodID (class_ref, "moveTo", "(Ljava/io/File;)Z");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				bool __ret;
				if (GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_moveTo_Ljava_io_File_, __args);
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "moveTo", "(Ljava/io/File;)Z"), __args);
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
			global::Com.Google.Atap.Tango.Reconstruction.Tango3dReconstructionBufferCache __this = global::Java.Lang.Object.GetObject<global::Com.Google.Atap.Tango.Reconstruction.Tango3dReconstructionBufferCache> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Release ();
		}
#pragma warning restore 0169

		static IntPtr id_release;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.atap.tango.reconstruction']/class[@name='Tango3dReconstructionBufferCache']/method[@name='release' and count(parameter)=0]"
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
			global::Com.Google.Atap.Tango.Reconstruction.Tango3dReconstructionBufferCache __this = global::Java.Lang.Object.GetObject<global::Com.Google.Atap.Tango.Reconstruction.Tango3dReconstructionBufferCache> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Reset ();
		}
#pragma warning restore 0169

		static IntPtr id_reset;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.atap.tango.reconstruction']/class[@name='Tango3dReconstructionBufferCache']/method[@name='reset' and count(parameter)=0]"
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

		static Delegate cb_size;
#pragma warning disable 0169
		static Delegate GetSizeHandler ()
		{
			if (cb_size == null)
				cb_size = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_Size);
			return cb_size;
		}

		static int n_Size (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Google.Atap.Tango.Reconstruction.Tango3dReconstructionBufferCache __this = global::Java.Lang.Object.GetObject<global::Com.Google.Atap.Tango.Reconstruction.Tango3dReconstructionBufferCache> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Size ();
		}
#pragma warning restore 0169

		static IntPtr id_size;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.atap.tango.reconstruction']/class[@name='Tango3dReconstructionBufferCache']/method[@name='size' and count(parameter)=0]"
		[Register ("size", "()I", "GetSizeHandler")]
		public virtual unsafe int Size ()
		{
			if (id_size == IntPtr.Zero)
				id_size = JNIEnv.GetMethodID (class_ref, "size", "()I");
			try {

				if (GetType () == ThresholdType)
					return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_size);
				else
					return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "size", "()I"));
			} finally {
			}
		}

	}
}
