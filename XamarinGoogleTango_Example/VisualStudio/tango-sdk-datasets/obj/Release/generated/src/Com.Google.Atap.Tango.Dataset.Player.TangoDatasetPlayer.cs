using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Google.Atap.Tango.Dataset.Player {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.google.atap.tango.dataset.player']/class[@name='TangoDatasetPlayer']"
	[global::Android.Runtime.Register ("com/google/atap/tango/dataset/player/TangoDatasetPlayer", DoNotGenerateAcw=true)]
	public partial class TangoDatasetPlayer : global::Java.Lang.Object, global::Android.Media.ImageReader.IOnImageAvailableListener {

		// Metadata.xml XPath interface reference: path="/api/package[@name='com.google.atap.tango.dataset.player']/interface[@name='TangoDatasetPlayer.Callback']"
		[Register ("com/google/atap/tango/dataset/player/TangoDatasetPlayer$Callback", "", "Com.Google.Atap.Tango.Dataset.Player.TangoDatasetPlayer/ICallbackInvoker")]
		public partial interface ICallback : IJavaObject {

			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.atap.tango.dataset.player']/interface[@name='TangoDatasetPlayer.Callback']/method[@name='onDurationAvailable' and count(parameter)=1 and parameter[1][@type='long']]"
			[Register ("onDurationAvailable", "(J)V", "GetOnDurationAvailable_JHandler:Com.Google.Atap.Tango.Dataset.Player.TangoDatasetPlayer/ICallbackInvoker, tango-sdk-datasets")]
			void OnDurationAvailable (long p0);

			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.atap.tango.dataset.player']/interface[@name='TangoDatasetPlayer.Callback']/method[@name='onFrameReady' and count(parameter)=1 and parameter[1][@type='com.google.atap.tangoservice.experimental.TangoImageBuffer']]"
			[Register ("onFrameReady", "(Lcom/google/atap/tangoservice/experimental/TangoImageBuffer;)V", "GetOnFrameReady_Lcom_google_atap_tangoservice_experimental_TangoImageBuffer_Handler:Com.Google.Atap.Tango.Dataset.Player.TangoDatasetPlayer/ICallbackInvoker, tango-sdk-datasets")]
			void OnFrameReady (global::Com.Google.Atap.Tangoservice.Experimental.TangoImageBuffer p0);

			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.atap.tango.dataset.player']/interface[@name='TangoDatasetPlayer.Callback']/method[@name='onVideoCompleted' and count(parameter)=0]"
			[Register ("onVideoCompleted", "()V", "GetOnVideoCompletedHandler:Com.Google.Atap.Tango.Dataset.Player.TangoDatasetPlayer/ICallbackInvoker, tango-sdk-datasets")]
			void OnVideoCompleted ();

		}

		[global::Android.Runtime.Register ("com/google/atap/tango/dataset/player/TangoDatasetPlayer$Callback", DoNotGenerateAcw=true)]
		internal class ICallbackInvoker : global::Java.Lang.Object, ICallback {

			static IntPtr java_class_ref = JNIEnv.FindClass ("com/google/atap/tango/dataset/player/TangoDatasetPlayer$Callback");

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
								JNIEnv.GetClassNameFromInstance (handle), "com.google.atap.tango.dataset.player.TangoDatasetPlayer.Callback"));
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

			static Delegate cb_onDurationAvailable_J;
#pragma warning disable 0169
			static Delegate GetOnDurationAvailable_JHandler ()
			{
				if (cb_onDurationAvailable_J == null)
					cb_onDurationAvailable_J = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, long>) n_OnDurationAvailable_J);
				return cb_onDurationAvailable_J;
			}

			static void n_OnDurationAvailable_J (IntPtr jnienv, IntPtr native__this, long p0)
			{
				global::Com.Google.Atap.Tango.Dataset.Player.TangoDatasetPlayer.ICallback __this = global::Java.Lang.Object.GetObject<global::Com.Google.Atap.Tango.Dataset.Player.TangoDatasetPlayer.ICallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.OnDurationAvailable (p0);
			}
#pragma warning restore 0169

			IntPtr id_onDurationAvailable_J;
			public unsafe void OnDurationAvailable (long p0)
			{
				if (id_onDurationAvailable_J == IntPtr.Zero)
					id_onDurationAvailable_J = JNIEnv.GetMethodID (class_ref, "onDurationAvailable", "(J)V");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onDurationAvailable_J, __args);
			}

			static Delegate cb_onFrameReady_Lcom_google_atap_tangoservice_experimental_TangoImageBuffer_;
#pragma warning disable 0169
			static Delegate GetOnFrameReady_Lcom_google_atap_tangoservice_experimental_TangoImageBuffer_Handler ()
			{
				if (cb_onFrameReady_Lcom_google_atap_tangoservice_experimental_TangoImageBuffer_ == null)
					cb_onFrameReady_Lcom_google_atap_tangoservice_experimental_TangoImageBuffer_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnFrameReady_Lcom_google_atap_tangoservice_experimental_TangoImageBuffer_);
				return cb_onFrameReady_Lcom_google_atap_tangoservice_experimental_TangoImageBuffer_;
			}

			static void n_OnFrameReady_Lcom_google_atap_tangoservice_experimental_TangoImageBuffer_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Google.Atap.Tango.Dataset.Player.TangoDatasetPlayer.ICallback __this = global::Java.Lang.Object.GetObject<global::Com.Google.Atap.Tango.Dataset.Player.TangoDatasetPlayer.ICallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Com.Google.Atap.Tangoservice.Experimental.TangoImageBuffer p0 = global::Java.Lang.Object.GetObject<global::Com.Google.Atap.Tangoservice.Experimental.TangoImageBuffer> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.OnFrameReady (p0);
			}
#pragma warning restore 0169

			IntPtr id_onFrameReady_Lcom_google_atap_tangoservice_experimental_TangoImageBuffer_;
			public unsafe void OnFrameReady (global::Com.Google.Atap.Tangoservice.Experimental.TangoImageBuffer p0)
			{
				if (id_onFrameReady_Lcom_google_atap_tangoservice_experimental_TangoImageBuffer_ == IntPtr.Zero)
					id_onFrameReady_Lcom_google_atap_tangoservice_experimental_TangoImageBuffer_ = JNIEnv.GetMethodID (class_ref, "onFrameReady", "(Lcom/google/atap/tangoservice/experimental/TangoImageBuffer;)V");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onFrameReady_Lcom_google_atap_tangoservice_experimental_TangoImageBuffer_, __args);
			}

			static Delegate cb_onVideoCompleted;
#pragma warning disable 0169
			static Delegate GetOnVideoCompletedHandler ()
			{
				if (cb_onVideoCompleted == null)
					cb_onVideoCompleted = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnVideoCompleted);
				return cb_onVideoCompleted;
			}

			static void n_OnVideoCompleted (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Google.Atap.Tango.Dataset.Player.TangoDatasetPlayer.ICallback __this = global::Java.Lang.Object.GetObject<global::Com.Google.Atap.Tango.Dataset.Player.TangoDatasetPlayer.ICallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.OnVideoCompleted ();
			}
#pragma warning restore 0169

			IntPtr id_onVideoCompleted;
			public unsafe void OnVideoCompleted ()
			{
				if (id_onVideoCompleted == IntPtr.Zero)
					id_onVideoCompleted = JNIEnv.GetMethodID (class_ref, "onVideoCompleted", "()V");
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onVideoCompleted);
			}

		}


		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/google/atap/tango/dataset/player/TangoDatasetPlayer", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (TangoDatasetPlayer); }
		}

		protected TangoDatasetPlayer (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Ljava_io_File_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.google.atap.tango.dataset.player']/class[@name='TangoDatasetPlayer']/constructor[@name='TangoDatasetPlayer' and count(parameter)=1 and parameter[1][@type='java.io.File']]"
		[Register (".ctor", "(Ljava/io/File;)V", "")]
		public unsafe TangoDatasetPlayer (global::Java.IO.File p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (GetType () != typeof (TangoDatasetPlayer)) {
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
			global::Com.Google.Atap.Tango.Dataset.Player.TangoDatasetPlayer __this = global::Java.Lang.Object.GetObject<global::Com.Google.Atap.Tango.Dataset.Player.TangoDatasetPlayer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Extrinsics);
		}
#pragma warning restore 0169

		static IntPtr id_getExtrinsics;
		public virtual unsafe global::Com.Google.Atap.Tangoservice.TangoPoseData Extrinsics {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.atap.tango.dataset.player']/class[@name='TangoDatasetPlayer']/method[@name='getExtrinsics' and count(parameter)=0]"
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
			global::Com.Google.Atap.Tango.Dataset.Player.TangoDatasetPlayer __this = global::Java.Lang.Object.GetObject<global::Com.Google.Atap.Tango.Dataset.Player.TangoDatasetPlayer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Intrinsics);
		}
#pragma warning restore 0169

		static IntPtr id_getIntrinsics;
		public virtual unsafe global::Com.Google.Atap.Tangoservice.TangoCameraIntrinsics Intrinsics {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.atap.tango.dataset.player']/class[@name='TangoDatasetPlayer']/method[@name='getIntrinsics' and count(parameter)=0]"
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

		static Delegate cb_onImageAvailable_Landroid_media_ImageReader_;
#pragma warning disable 0169
		static Delegate GetOnImageAvailable_Landroid_media_ImageReader_Handler ()
		{
			if (cb_onImageAvailable_Landroid_media_ImageReader_ == null)
				cb_onImageAvailable_Landroid_media_ImageReader_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnImageAvailable_Landroid_media_ImageReader_);
			return cb_onImageAvailable_Landroid_media_ImageReader_;
		}

		static void n_OnImageAvailable_Landroid_media_ImageReader_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Google.Atap.Tango.Dataset.Player.TangoDatasetPlayer __this = global::Java.Lang.Object.GetObject<global::Com.Google.Atap.Tango.Dataset.Player.TangoDatasetPlayer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Media.ImageReader p0 = global::Java.Lang.Object.GetObject<global::Android.Media.ImageReader> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnImageAvailable (p0);
		}
#pragma warning restore 0169

		static IntPtr id_onImageAvailable_Landroid_media_ImageReader_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.atap.tango.dataset.player']/class[@name='TangoDatasetPlayer']/method[@name='onImageAvailable' and count(parameter)=1 and parameter[1][@type='android.media.ImageReader']]"
		[Register ("onImageAvailable", "(Landroid/media/ImageReader;)V", "GetOnImageAvailable_Landroid_media_ImageReader_Handler")]
		public virtual unsafe void OnImageAvailable (global::Android.Media.ImageReader p0)
		{
			if (id_onImageAvailable_Landroid_media_ImageReader_ == IntPtr.Zero)
				id_onImageAvailable_Landroid_media_ImageReader_ = JNIEnv.GetMethodID (class_ref, "onImageAvailable", "(Landroid/media/ImageReader;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onImageAvailable_Landroid_media_ImageReader_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onImageAvailable", "(Landroid/media/ImageReader;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setCallback_Lcom_google_atap_tango_dataset_player_TangoDatasetPlayer_Callback_;
#pragma warning disable 0169
		static Delegate GetSetCallback_Lcom_google_atap_tango_dataset_player_TangoDatasetPlayer_Callback_Handler ()
		{
			if (cb_setCallback_Lcom_google_atap_tango_dataset_player_TangoDatasetPlayer_Callback_ == null)
				cb_setCallback_Lcom_google_atap_tango_dataset_player_TangoDatasetPlayer_Callback_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetCallback_Lcom_google_atap_tango_dataset_player_TangoDatasetPlayer_Callback_);
			return cb_setCallback_Lcom_google_atap_tango_dataset_player_TangoDatasetPlayer_Callback_;
		}

		static void n_SetCallback_Lcom_google_atap_tango_dataset_player_TangoDatasetPlayer_Callback_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Google.Atap.Tango.Dataset.Player.TangoDatasetPlayer __this = global::Java.Lang.Object.GetObject<global::Com.Google.Atap.Tango.Dataset.Player.TangoDatasetPlayer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Google.Atap.Tango.Dataset.Player.TangoDatasetPlayer.ICallback p0 = (global::Com.Google.Atap.Tango.Dataset.Player.TangoDatasetPlayer.ICallback)global::Java.Lang.Object.GetObject<global::Com.Google.Atap.Tango.Dataset.Player.TangoDatasetPlayer.ICallback> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetCallback (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setCallback_Lcom_google_atap_tango_dataset_player_TangoDatasetPlayer_Callback_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.atap.tango.dataset.player']/class[@name='TangoDatasetPlayer']/method[@name='setCallback' and count(parameter)=1 and parameter[1][@type='com.google.atap.tango.dataset.player.TangoDatasetPlayer.Callback']]"
		[Register ("setCallback", "(Lcom/google/atap/tango/dataset/player/TangoDatasetPlayer$Callback;)V", "GetSetCallback_Lcom_google_atap_tango_dataset_player_TangoDatasetPlayer_Callback_Handler")]
		public virtual unsafe void SetCallback (global::Com.Google.Atap.Tango.Dataset.Player.TangoDatasetPlayer.ICallback p0)
		{
			if (id_setCallback_Lcom_google_atap_tango_dataset_player_TangoDatasetPlayer_Callback_ == IntPtr.Zero)
				id_setCallback_Lcom_google_atap_tango_dataset_player_TangoDatasetPlayer_Callback_ = JNIEnv.GetMethodID (class_ref, "setCallback", "(Lcom/google/atap/tango/dataset/player/TangoDatasetPlayer$Callback;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setCallback_Lcom_google_atap_tango_dataset_player_TangoDatasetPlayer_Callback_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setCallback", "(Lcom/google/atap/tango/dataset/player/TangoDatasetPlayer$Callback;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_start;
#pragma warning disable 0169
		static Delegate GetStartHandler ()
		{
			if (cb_start == null)
				cb_start = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Start);
			return cb_start;
		}

		static void n_Start (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Google.Atap.Tango.Dataset.Player.TangoDatasetPlayer __this = global::Java.Lang.Object.GetObject<global::Com.Google.Atap.Tango.Dataset.Player.TangoDatasetPlayer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Start ();
		}
#pragma warning restore 0169

		static IntPtr id_start;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.atap.tango.dataset.player']/class[@name='TangoDatasetPlayer']/method[@name='start' and count(parameter)=0]"
		[Register ("start", "()V", "GetStartHandler")]
		public virtual unsafe void Start ()
		{
			if (id_start == IntPtr.Zero)
				id_start = JNIEnv.GetMethodID (class_ref, "start", "()V");
			try {

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_start);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "start", "()V"));
			} finally {
			}
		}

		static Delegate cb_stop;
#pragma warning disable 0169
		static Delegate GetStopHandler ()
		{
			if (cb_stop == null)
				cb_stop = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Stop);
			return cb_stop;
		}

		static void n_Stop (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Google.Atap.Tango.Dataset.Player.TangoDatasetPlayer __this = global::Java.Lang.Object.GetObject<global::Com.Google.Atap.Tango.Dataset.Player.TangoDatasetPlayer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Stop ();
		}
#pragma warning restore 0169

		static IntPtr id_stop;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.atap.tango.dataset.player']/class[@name='TangoDatasetPlayer']/method[@name='stop' and count(parameter)=0]"
		[Register ("stop", "()V", "GetStopHandler")]
		public virtual unsafe void Stop ()
		{
			if (id_stop == IntPtr.Zero)
				id_stop = JNIEnv.GetMethodID (class_ref, "stop", "()V");
			try {

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_stop);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "stop", "()V"));
			} finally {
			}
		}

	}
}
