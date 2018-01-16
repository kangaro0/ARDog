using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Google.Atap.Tangoservice {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.google.atap.tangoservice']/class[@name='TangoVhs']"
	[global::Android.Runtime.Register ("com/google/atap/tangoservice/TangoVhs", DoNotGenerateAcw=true)]
	public partial class TangoVhs : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/google/atap/tangoservice/TangoVhs", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (TangoVhs); }
		}

		protected TangoVhs (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Landroid_content_Context_Ljava_lang_Runnable_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.google.atap.tangoservice']/class[@name='TangoVhs']/constructor[@name='TangoVhs' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.Runnable']]"
		[Register (".ctor", "(Landroid/content/Context;Ljava/lang/Runnable;)V", "")]
		public unsafe TangoVhs (global::Android.Content.Context p0, global::Java.Lang.IRunnable p1)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				if (GetType () != typeof (TangoVhs)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Landroid/content/Context;Ljava/lang/Runnable;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Landroid/content/Context;Ljava/lang/Runnable;)V", __args);
					return;
				}

				if (id_ctor_Landroid_content_Context_Ljava_lang_Runnable_ == IntPtr.Zero)
					id_ctor_Landroid_content_Context_Ljava_lang_Runnable_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/content/Context;Ljava/lang/Runnable;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_content_Context_Ljava_lang_Runnable_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Landroid_content_Context_Ljava_lang_Runnable_, __args);
			} finally {
			}
		}

		static Delegate cb_connectFeatureServer_I;
#pragma warning disable 0169
		static Delegate GetConnectFeatureServer_IHandler ()
		{
			if (cb_connectFeatureServer_I == null)
				cb_connectFeatureServer_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_ConnectFeatureServer_I);
			return cb_connectFeatureServer_I;
		}

		static void n_ConnectFeatureServer_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Google.Atap.Tangoservice.TangoVhs __this = global::Java.Lang.Object.GetObject<global::Com.Google.Atap.Tangoservice.TangoVhs> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ConnectFeatureServer (p0);
		}
#pragma warning restore 0169

		static IntPtr id_connectFeatureServer_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.atap.tangoservice']/class[@name='TangoVhs']/method[@name='connectFeatureServer' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("connectFeatureServer", "(I)V", "GetConnectFeatureServer_IHandler")]
		public virtual unsafe void ConnectFeatureServer (int p0)
		{
			if (id_connectFeatureServer_I == IntPtr.Zero)
				id_connectFeatureServer_I = JNIEnv.GetMethodID (class_ref, "connectFeatureServer", "(I)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_connectFeatureServer_I, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "connectFeatureServer", "(I)V"), __args);
			} finally {
			}
		}

		static Delegate cb_disconnect;
#pragma warning disable 0169
		static Delegate GetDisconnectHandler ()
		{
			if (cb_disconnect == null)
				cb_disconnect = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Disconnect);
			return cb_disconnect;
		}

		static void n_Disconnect (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Google.Atap.Tangoservice.TangoVhs __this = global::Java.Lang.Object.GetObject<global::Com.Google.Atap.Tangoservice.TangoVhs> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Disconnect ();
		}
#pragma warning restore 0169

		static IntPtr id_disconnect;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.atap.tangoservice']/class[@name='TangoVhs']/method[@name='disconnect' and count(parameter)=0]"
		[Register ("disconnect", "()V", "GetDisconnectHandler")]
		public virtual unsafe void Disconnect ()
		{
			if (id_disconnect == IntPtr.Zero)
				id_disconnect = JNIEnv.GetMethodID (class_ref, "disconnect", "()V");
			try {

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_disconnect);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "disconnect", "()V"));
			} finally {
			}
		}

		static Delegate cb_disconnectFeatureServer;
#pragma warning disable 0169
		static Delegate GetDisconnectFeatureServerHandler ()
		{
			if (cb_disconnectFeatureServer == null)
				cb_disconnectFeatureServer = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_DisconnectFeatureServer);
			return cb_disconnectFeatureServer;
		}

		static void n_DisconnectFeatureServer (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Google.Atap.Tangoservice.TangoVhs __this = global::Java.Lang.Object.GetObject<global::Com.Google.Atap.Tangoservice.TangoVhs> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.DisconnectFeatureServer ();
		}
#pragma warning restore 0169

		static IntPtr id_disconnectFeatureServer;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.atap.tangoservice']/class[@name='TangoVhs']/method[@name='disconnectFeatureServer' and count(parameter)=0]"
		[Register ("disconnectFeatureServer", "()V", "GetDisconnectFeatureServerHandler")]
		public virtual unsafe void DisconnectFeatureServer ()
		{
			if (id_disconnectFeatureServer == IntPtr.Zero)
				id_disconnectFeatureServer = JNIEnv.GetMethodID (class_ref, "disconnectFeatureServer", "()V");
			try {

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_disconnectFeatureServer);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "disconnectFeatureServer", "()V"));
			} finally {
			}
		}

		static Delegate cb_updateFeatureServer;
#pragma warning disable 0169
		static Delegate GetUpdateFeatureServerHandler ()
		{
			if (cb_updateFeatureServer == null)
				cb_updateFeatureServer = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_UpdateFeatureServer);
			return cb_updateFeatureServer;
		}

		static void n_UpdateFeatureServer (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Google.Atap.Tangoservice.TangoVhs __this = global::Java.Lang.Object.GetObject<global::Com.Google.Atap.Tangoservice.TangoVhs> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.UpdateFeatureServer ();
		}
#pragma warning restore 0169

		static IntPtr id_updateFeatureServer;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.atap.tangoservice']/class[@name='TangoVhs']/method[@name='updateFeatureServer' and count(parameter)=0]"
		[Register ("updateFeatureServer", "()V", "GetUpdateFeatureServerHandler")]
		public virtual unsafe void UpdateFeatureServer ()
		{
			if (id_updateFeatureServer == IntPtr.Zero)
				id_updateFeatureServer = JNIEnv.GetMethodID (class_ref, "updateFeatureServer", "()V");
			try {

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_updateFeatureServer);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "updateFeatureServer", "()V"));
			} finally {
			}
		}

	}
}
