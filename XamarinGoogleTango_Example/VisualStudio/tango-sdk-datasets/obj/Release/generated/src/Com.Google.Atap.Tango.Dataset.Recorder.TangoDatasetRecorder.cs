using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Google.Atap.Tango.Dataset.Recorder {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.google.atap.tango.dataset.recorder']/class[@name='TangoDatasetRecorder']"
	[global::Android.Runtime.Register ("com/google/atap/tango/dataset/recorder/TangoDatasetRecorder", DoNotGenerateAcw=true)]
	public partial class TangoDatasetRecorder : global::Java.Lang.Object {

		// Metadata.xml XPath interface reference: path="/api/package[@name='com.google.atap.tango.dataset.recorder']/interface[@name='TangoDatasetRecorder.Callback']"
		[Register ("com/google/atap/tango/dataset/recorder/TangoDatasetRecorder$Callback", "", "Com.Google.Atap.Tango.Dataset.Recorder.TangoDatasetRecorder/ICallbackInvoker")]
		public partial interface ICallback : IJavaObject {

			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.atap.tango.dataset.recorder']/interface[@name='TangoDatasetRecorder.Callback']/method[@name='onTextureReady' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("onTextureReady", "(I)V", "GetOnTextureReady_IHandler:Com.Google.Atap.Tango.Dataset.Recorder.TangoDatasetRecorder/ICallbackInvoker, tango-sdk-datasets")]
			void OnTextureReady (int p0);

		}

		[global::Android.Runtime.Register ("com/google/atap/tango/dataset/recorder/TangoDatasetRecorder$Callback", DoNotGenerateAcw=true)]
		internal class ICallbackInvoker : global::Java.Lang.Object, ICallback {

			static IntPtr java_class_ref = JNIEnv.FindClass ("com/google/atap/tango/dataset/recorder/TangoDatasetRecorder$Callback");

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (ICallbackInvoker); }
			}

			IntPtr class_ref;

			public static ICallback GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<ICallback> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.google.atap.tango.dataset.recorder.TangoDatasetRecorder.Callback"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public ICallbackInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			static Delegate cb_onTextureReady_I;
#pragma warning disable 0169
			static Delegate GetOnTextureReady_IHandler ()
			{
				if (cb_onTextureReady_I == null)
					cb_onTextureReady_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_OnTextureReady_I);
				return cb_onTextureReady_I;
			}

			static void n_OnTextureReady_I (IntPtr jnienv, IntPtr native__this, int p0)
			{
				global::Com.Google.Atap.Tango.Dataset.Recorder.TangoDatasetRecorder.ICallback __this = global::Java.Lang.Object.GetObject<global::Com.Google.Atap.Tango.Dataset.Recorder.TangoDatasetRecorder.ICallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.OnTextureReady (p0);
			}
#pragma warning restore 0169

			IntPtr id_onTextureReady_I;
			public unsafe void OnTextureReady (int p0)
			{
				if (id_onTextureReady_I == IntPtr.Zero)
					id_onTextureReady_I = JNIEnv.GetMethodID (class_ref, "onTextureReady", "(I)V");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onTextureReady_I, __args);
			}

		}


		// Metadata.xml XPath interface reference: path="/api/package[@name='com.google.atap.tango.dataset.recorder']/interface[@name='TangoDatasetRecorder.FrameCallback']"
		[Register ("com/google/atap/tango/dataset/recorder/TangoDatasetRecorder$FrameCallback", "", "Com.Google.Atap.Tango.Dataset.Recorder.TangoDatasetRecorder/IFrameCallbackInvoker")]
		public partial interface IFrameCallback : IJavaObject {

			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.atap.tango.dataset.recorder']/interface[@name='TangoDatasetRecorder.FrameCallback']/method[@name='onTextureDrawn' and count(parameter)=0]"
			[Register ("onTextureDrawn", "()V", "GetOnTextureDrawnHandler:Com.Google.Atap.Tango.Dataset.Recorder.TangoDatasetRecorder/IFrameCallbackInvoker, tango-sdk-datasets")]
			void OnTextureDrawn ();

			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.atap.tango.dataset.recorder']/interface[@name='TangoDatasetRecorder.FrameCallback']/method[@name='onUpdateTexture' and count(parameter)=0]"
			[Register ("onUpdateTexture", "()J", "GetOnUpdateTextureHandler:Com.Google.Atap.Tango.Dataset.Recorder.TangoDatasetRecorder/IFrameCallbackInvoker, tango-sdk-datasets")]
			long OnUpdateTexture ();

		}

		[global::Android.Runtime.Register ("com/google/atap/tango/dataset/recorder/TangoDatasetRecorder$FrameCallback", DoNotGenerateAcw=true)]
		internal class IFrameCallbackInvoker : global::Java.Lang.Object, IFrameCallback {

			static IntPtr java_class_ref = JNIEnv.FindClass ("com/google/atap/tango/dataset/recorder/TangoDatasetRecorder$FrameCallback");

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (IFrameCallbackInvoker); }
			}

			IntPtr class_ref;

			public static IFrameCallback GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IFrameCallback> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.google.atap.tango.dataset.recorder.TangoDatasetRecorder.FrameCallback"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IFrameCallbackInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			static Delegate cb_onTextureDrawn;
#pragma warning disable 0169
			static Delegate GetOnTextureDrawnHandler ()
			{
				if (cb_onTextureDrawn == null)
					cb_onTextureDrawn = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnTextureDrawn);
				return cb_onTextureDrawn;
			}

			static void n_OnTextureDrawn (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Google.Atap.Tango.Dataset.Recorder.TangoDatasetRecorder.IFrameCallback __this = global::Java.Lang.Object.GetObject<global::Com.Google.Atap.Tango.Dataset.Recorder.TangoDatasetRecorder.IFrameCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.OnTextureDrawn ();
			}
#pragma warning restore 0169

			IntPtr id_onTextureDrawn;
			public unsafe void OnTextureDrawn ()
			{
				if (id_onTextureDrawn == IntPtr.Zero)
					id_onTextureDrawn = JNIEnv.GetMethodID (class_ref, "onTextureDrawn", "()V");
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onTextureDrawn);
			}

			static Delegate cb_onUpdateTexture;
#pragma warning disable 0169
			static Delegate GetOnUpdateTextureHandler ()
			{
				if (cb_onUpdateTexture == null)
					cb_onUpdateTexture = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long>) n_OnUpdateTexture);
				return cb_onUpdateTexture;
			}

			static long n_OnUpdateTexture (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Google.Atap.Tango.Dataset.Recorder.TangoDatasetRecorder.IFrameCallback __this = global::Java.Lang.Object.GetObject<global::Com.Google.Atap.Tango.Dataset.Recorder.TangoDatasetRecorder.IFrameCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return __this.OnUpdateTexture ();
			}
#pragma warning restore 0169

			IntPtr id_onUpdateTexture;
			public unsafe long OnUpdateTexture ()
			{
				if (id_onUpdateTexture == IntPtr.Zero)
					id_onUpdateTexture = JNIEnv.GetMethodID (class_ref, "onUpdateTexture", "()J");
				return JNIEnv.CallLongMethod (((global::Java.Lang.Object) this).Handle, id_onUpdateTexture);
			}

		}


		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/google/atap/tango/dataset/recorder/TangoDatasetRecorder", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (TangoDatasetRecorder); }
		}

		protected TangoDatasetRecorder (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Ljava_io_File_Lcom_google_atap_tangoservice_TangoCameraIntrinsics_Lcom_google_atap_tangoservice_TangoPoseData_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.google.atap.tango.dataset.recorder']/class[@name='TangoDatasetRecorder']/constructor[@name='TangoDatasetRecorder' and count(parameter)=3 and parameter[1][@type='java.io.File'] and parameter[2][@type='com.google.atap.tangoservice.TangoCameraIntrinsics'] and parameter[3][@type='com.google.atap.tangoservice.TangoPoseData']]"
		[Register (".ctor", "(Ljava/io/File;Lcom/google/atap/tangoservice/TangoCameraIntrinsics;Lcom/google/atap/tangoservice/TangoPoseData;)V", "")]
		public unsafe TangoDatasetRecorder (global::Java.IO.File p0, global::Com.Google.Atap.Tangoservice.TangoCameraIntrinsics p1, global::Com.Google.Atap.Tangoservice.TangoPoseData p2)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				if (GetType () != typeof (TangoDatasetRecorder)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Ljava/io/File;Lcom/google/atap/tangoservice/TangoCameraIntrinsics;Lcom/google/atap/tangoservice/TangoPoseData;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Ljava/io/File;Lcom/google/atap/tangoservice/TangoCameraIntrinsics;Lcom/google/atap/tangoservice/TangoPoseData;)V", __args);
					return;
				}

				if (id_ctor_Ljava_io_File_Lcom_google_atap_tangoservice_TangoCameraIntrinsics_Lcom_google_atap_tangoservice_TangoPoseData_ == IntPtr.Zero)
					id_ctor_Ljava_io_File_Lcom_google_atap_tangoservice_TangoCameraIntrinsics_Lcom_google_atap_tangoservice_TangoPoseData_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/io/File;Lcom/google/atap/tangoservice/TangoCameraIntrinsics;Lcom/google/atap/tangoservice/TangoPoseData;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_io_File_Lcom_google_atap_tangoservice_TangoCameraIntrinsics_Lcom_google_atap_tangoservice_TangoPoseData_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Ljava_io_File_Lcom_google_atap_tangoservice_TangoCameraIntrinsics_Lcom_google_atap_tangoservice_TangoPoseData_, __args);
			} finally {
			}
		}

		static Delegate cb_addColorImage_Lcom_google_atap_tangoservice_experimental_TangoImageBuffer_;
#pragma warning disable 0169
		static Delegate GetAddColorImage_Lcom_google_atap_tangoservice_experimental_TangoImageBuffer_Handler ()
		{
			if (cb_addColorImage_Lcom_google_atap_tangoservice_experimental_TangoImageBuffer_ == null)
				cb_addColorImage_Lcom_google_atap_tangoservice_experimental_TangoImageBuffer_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_AddColorImage_Lcom_google_atap_tangoservice_experimental_TangoImageBuffer_);
			return cb_addColorImage_Lcom_google_atap_tangoservice_experimental_TangoImageBuffer_;
		}

		static void n_AddColorImage_Lcom_google_atap_tangoservice_experimental_TangoImageBuffer_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Google.Atap.Tango.Dataset.Recorder.TangoDatasetRecorder __this = global::Java.Lang.Object.GetObject<global::Com.Google.Atap.Tango.Dataset.Recorder.TangoDatasetRecorder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Google.Atap.Tangoservice.Experimental.TangoImageBuffer p0 = global::Java.Lang.Object.GetObject<global::Com.Google.Atap.Tangoservice.Experimental.TangoImageBuffer> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.AddColorImage (p0);
		}
#pragma warning restore 0169

		static IntPtr id_addColorImage_Lcom_google_atap_tangoservice_experimental_TangoImageBuffer_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.atap.tango.dataset.recorder']/class[@name='TangoDatasetRecorder']/method[@name='addColorImage' and count(parameter)=1 and parameter[1][@type='com.google.atap.tangoservice.experimental.TangoImageBuffer']]"
		[Register ("addColorImage", "(Lcom/google/atap/tangoservice/experimental/TangoImageBuffer;)V", "GetAddColorImage_Lcom_google_atap_tangoservice_experimental_TangoImageBuffer_Handler")]
		public virtual unsafe void AddColorImage (global::Com.Google.Atap.Tangoservice.Experimental.TangoImageBuffer p0)
		{
			if (id_addColorImage_Lcom_google_atap_tangoservice_experimental_TangoImageBuffer_ == IntPtr.Zero)
				id_addColorImage_Lcom_google_atap_tangoservice_experimental_TangoImageBuffer_ = JNIEnv.GetMethodID (class_ref, "addColorImage", "(Lcom/google/atap/tangoservice/experimental/TangoImageBuffer;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_addColorImage_Lcom_google_atap_tangoservice_experimental_TangoImageBuffer_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "addColorImage", "(Lcom/google/atap/tangoservice/experimental/TangoImageBuffer;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_frameAvailable_Lcom_google_atap_tango_dataset_recorder_TangoDatasetRecorder_FrameCallback_;
#pragma warning disable 0169
		static Delegate GetFrameAvailable_Lcom_google_atap_tango_dataset_recorder_TangoDatasetRecorder_FrameCallback_Handler ()
		{
			if (cb_frameAvailable_Lcom_google_atap_tango_dataset_recorder_TangoDatasetRecorder_FrameCallback_ == null)
				cb_frameAvailable_Lcom_google_atap_tango_dataset_recorder_TangoDatasetRecorder_FrameCallback_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_FrameAvailable_Lcom_google_atap_tango_dataset_recorder_TangoDatasetRecorder_FrameCallback_);
			return cb_frameAvailable_Lcom_google_atap_tango_dataset_recorder_TangoDatasetRecorder_FrameCallback_;
		}

		static void n_FrameAvailable_Lcom_google_atap_tango_dataset_recorder_TangoDatasetRecorder_FrameCallback_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Google.Atap.Tango.Dataset.Recorder.TangoDatasetRecorder __this = global::Java.Lang.Object.GetObject<global::Com.Google.Atap.Tango.Dataset.Recorder.TangoDatasetRecorder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Google.Atap.Tango.Dataset.Recorder.TangoDatasetRecorder.IFrameCallback p0 = (global::Com.Google.Atap.Tango.Dataset.Recorder.TangoDatasetRecorder.IFrameCallback)global::Java.Lang.Object.GetObject<global::Com.Google.Atap.Tango.Dataset.Recorder.TangoDatasetRecorder.IFrameCallback> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.FrameAvailable (p0);
		}
#pragma warning restore 0169

		static IntPtr id_frameAvailable_Lcom_google_atap_tango_dataset_recorder_TangoDatasetRecorder_FrameCallback_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.atap.tango.dataset.recorder']/class[@name='TangoDatasetRecorder']/method[@name='frameAvailable' and count(parameter)=1 and parameter[1][@type='com.google.atap.tango.dataset.recorder.TangoDatasetRecorder.FrameCallback']]"
		[Register ("frameAvailable", "(Lcom/google/atap/tango/dataset/recorder/TangoDatasetRecorder$FrameCallback;)V", "GetFrameAvailable_Lcom_google_atap_tango_dataset_recorder_TangoDatasetRecorder_FrameCallback_Handler")]
		public virtual unsafe void FrameAvailable (global::Com.Google.Atap.Tango.Dataset.Recorder.TangoDatasetRecorder.IFrameCallback p0)
		{
			if (id_frameAvailable_Lcom_google_atap_tango_dataset_recorder_TangoDatasetRecorder_FrameCallback_ == IntPtr.Zero)
				id_frameAvailable_Lcom_google_atap_tango_dataset_recorder_TangoDatasetRecorder_FrameCallback_ = JNIEnv.GetMethodID (class_ref, "frameAvailable", "(Lcom/google/atap/tango/dataset/recorder/TangoDatasetRecorder$FrameCallback;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_frameAvailable_Lcom_google_atap_tango_dataset_recorder_TangoDatasetRecorder_FrameCallback_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "frameAvailable", "(Lcom/google/atap/tango/dataset/recorder/TangoDatasetRecorder$FrameCallback;)V"), __args);
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
			global::Com.Google.Atap.Tango.Dataset.Recorder.TangoDatasetRecorder __this = global::Java.Lang.Object.GetObject<global::Com.Google.Atap.Tango.Dataset.Recorder.TangoDatasetRecorder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Reset ();
		}
#pragma warning restore 0169

		static IntPtr id_reset;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.atap.tango.dataset.recorder']/class[@name='TangoDatasetRecorder']/method[@name='reset' and count(parameter)=0]"
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

		static Delegate cb_runOnGlContext_Ljava_lang_Runnable_;
#pragma warning disable 0169
		static Delegate GetRunOnGlContext_Ljava_lang_Runnable_Handler ()
		{
			if (cb_runOnGlContext_Ljava_lang_Runnable_ == null)
				cb_runOnGlContext_Ljava_lang_Runnable_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_RunOnGlContext_Ljava_lang_Runnable_);
			return cb_runOnGlContext_Ljava_lang_Runnable_;
		}

		static void n_RunOnGlContext_Ljava_lang_Runnable_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Google.Atap.Tango.Dataset.Recorder.TangoDatasetRecorder __this = global::Java.Lang.Object.GetObject<global::Com.Google.Atap.Tango.Dataset.Recorder.TangoDatasetRecorder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.IRunnable p0 = (global::Java.Lang.IRunnable)global::Java.Lang.Object.GetObject<global::Java.Lang.IRunnable> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.RunOnGlContext (p0);
		}
#pragma warning restore 0169

		static IntPtr id_runOnGlContext_Ljava_lang_Runnable_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.atap.tango.dataset.recorder']/class[@name='TangoDatasetRecorder']/method[@name='runOnGlContext' and count(parameter)=1 and parameter[1][@type='java.lang.Runnable']]"
		[Register ("runOnGlContext", "(Ljava/lang/Runnable;)V", "GetRunOnGlContext_Ljava_lang_Runnable_Handler")]
		public virtual unsafe void RunOnGlContext (global::Java.Lang.IRunnable p0)
		{
			if (id_runOnGlContext_Ljava_lang_Runnable_ == IntPtr.Zero)
				id_runOnGlContext_Ljava_lang_Runnable_ = JNIEnv.GetMethodID (class_ref, "runOnGlContext", "(Ljava/lang/Runnable;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_runOnGlContext_Ljava_lang_Runnable_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "runOnGlContext", "(Ljava/lang/Runnable;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setCallback_Lcom_google_atap_tango_dataset_recorder_TangoDatasetRecorder_Callback_;
#pragma warning disable 0169
		static Delegate GetSetCallback_Lcom_google_atap_tango_dataset_recorder_TangoDatasetRecorder_Callback_Handler ()
		{
			if (cb_setCallback_Lcom_google_atap_tango_dataset_recorder_TangoDatasetRecorder_Callback_ == null)
				cb_setCallback_Lcom_google_atap_tango_dataset_recorder_TangoDatasetRecorder_Callback_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetCallback_Lcom_google_atap_tango_dataset_recorder_TangoDatasetRecorder_Callback_);
			return cb_setCallback_Lcom_google_atap_tango_dataset_recorder_TangoDatasetRecorder_Callback_;
		}

		static void n_SetCallback_Lcom_google_atap_tango_dataset_recorder_TangoDatasetRecorder_Callback_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Google.Atap.Tango.Dataset.Recorder.TangoDatasetRecorder __this = global::Java.Lang.Object.GetObject<global::Com.Google.Atap.Tango.Dataset.Recorder.TangoDatasetRecorder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Google.Atap.Tango.Dataset.Recorder.TangoDatasetRecorder.ICallback p0 = (global::Com.Google.Atap.Tango.Dataset.Recorder.TangoDatasetRecorder.ICallback)global::Java.Lang.Object.GetObject<global::Com.Google.Atap.Tango.Dataset.Recorder.TangoDatasetRecorder.ICallback> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetCallback (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setCallback_Lcom_google_atap_tango_dataset_recorder_TangoDatasetRecorder_Callback_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.atap.tango.dataset.recorder']/class[@name='TangoDatasetRecorder']/method[@name='setCallback' and count(parameter)=1 and parameter[1][@type='com.google.atap.tango.dataset.recorder.TangoDatasetRecorder.Callback']]"
		[Register ("setCallback", "(Lcom/google/atap/tango/dataset/recorder/TangoDatasetRecorder$Callback;)V", "GetSetCallback_Lcom_google_atap_tango_dataset_recorder_TangoDatasetRecorder_Callback_Handler")]
		public virtual unsafe void SetCallback (global::Com.Google.Atap.Tango.Dataset.Recorder.TangoDatasetRecorder.ICallback p0)
		{
			if (id_setCallback_Lcom_google_atap_tango_dataset_recorder_TangoDatasetRecorder_Callback_ == IntPtr.Zero)
				id_setCallback_Lcom_google_atap_tango_dataset_recorder_TangoDatasetRecorder_Callback_ = JNIEnv.GetMethodID (class_ref, "setCallback", "(Lcom/google/atap/tango/dataset/recorder/TangoDatasetRecorder$Callback;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setCallback_Lcom_google_atap_tango_dataset_recorder_TangoDatasetRecorder_Callback_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setCallback", "(Lcom/google/atap/tango/dataset/recorder/TangoDatasetRecorder$Callback;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_stop;
#pragma warning disable 0169
		static Delegate GetStopHandler ()
		{
			if (cb_stop == null)
				cb_stop = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_Stop);
			return cb_stop;
		}

		static IntPtr n_Stop (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Google.Atap.Tango.Dataset.Recorder.TangoDatasetRecorder __this = global::Java.Lang.Object.GetObject<global::Com.Google.Atap.Tango.Dataset.Recorder.TangoDatasetRecorder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Stop ());
		}
#pragma warning restore 0169

		static IntPtr id_stop;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.atap.tango.dataset.recorder']/class[@name='TangoDatasetRecorder']/method[@name='stop' and count(parameter)=0]"
		[Register ("stop", "()Ljava/io/File;", "GetStopHandler")]
		public virtual unsafe global::Java.IO.File Stop ()
		{
			if (id_stop == IntPtr.Zero)
				id_stop = JNIEnv.GetMethodID (class_ref, "stop", "()Ljava/io/File;");
			try {

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Java.IO.File> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_stop), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Java.IO.File> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "stop", "()Ljava/io/File;")), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}
