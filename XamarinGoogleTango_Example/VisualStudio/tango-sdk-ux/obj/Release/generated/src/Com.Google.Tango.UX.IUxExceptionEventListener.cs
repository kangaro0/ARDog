using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Google.Tango.UX {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.google.tango.ux']/interface[@name='UxExceptionEventListener']"
	[Register ("com/google/tango/ux/UxExceptionEventListener", "", "Com.Google.Tango.UX.IUxExceptionEventListenerInvoker")]
	public partial interface IUxExceptionEventListener : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.tango.ux']/interface[@name='UxExceptionEventListener']/method[@name='onUxExceptionEvent' and count(parameter)=1 and parameter[1][@type='com.google.tango.ux.UxExceptionEvent']]"
		[Register ("onUxExceptionEvent", "(Lcom/google/tango/ux/UxExceptionEvent;)V", "GetOnUxExceptionEvent_Lcom_google_tango_ux_UxExceptionEvent_Handler:Com.Google.Tango.UX.IUxExceptionEventListenerInvoker, tango-sdk-ux")]
		void OnUxExceptionEvent (global::Com.Google.Tango.UX.UxExceptionEvent p0);

	}

	[global::Android.Runtime.Register ("com/google/tango/ux/UxExceptionEventListener", DoNotGenerateAcw=true)]
	internal class IUxExceptionEventListenerInvoker : global::Java.Lang.Object, IUxExceptionEventListener {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/google/tango/ux/UxExceptionEventListener");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IUxExceptionEventListenerInvoker); }
		}

		IntPtr class_ref;

		public static IUxExceptionEventListener GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IUxExceptionEventListener> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.google.tango.ux.UxExceptionEventListener"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IUxExceptionEventListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_onUxExceptionEvent_Lcom_google_tango_ux_UxExceptionEvent_;
#pragma warning disable 0169
		static Delegate GetOnUxExceptionEvent_Lcom_google_tango_ux_UxExceptionEvent_Handler ()
		{
			if (cb_onUxExceptionEvent_Lcom_google_tango_ux_UxExceptionEvent_ == null)
				cb_onUxExceptionEvent_Lcom_google_tango_ux_UxExceptionEvent_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnUxExceptionEvent_Lcom_google_tango_ux_UxExceptionEvent_);
			return cb_onUxExceptionEvent_Lcom_google_tango_ux_UxExceptionEvent_;
		}

		static void n_OnUxExceptionEvent_Lcom_google_tango_ux_UxExceptionEvent_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Google.Tango.UX.IUxExceptionEventListener __this = global::Java.Lang.Object.GetObject<global::Com.Google.Tango.UX.IUxExceptionEventListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Google.Tango.UX.UxExceptionEvent p0 = global::Java.Lang.Object.GetObject<global::Com.Google.Tango.UX.UxExceptionEvent> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnUxExceptionEvent (p0);
		}
#pragma warning restore 0169

		IntPtr id_onUxExceptionEvent_Lcom_google_tango_ux_UxExceptionEvent_;
		public unsafe void OnUxExceptionEvent (global::Com.Google.Tango.UX.UxExceptionEvent p0)
		{
			if (id_onUxExceptionEvent_Lcom_google_tango_ux_UxExceptionEvent_ == IntPtr.Zero)
				id_onUxExceptionEvent_Lcom_google_tango_ux_UxExceptionEvent_ = JNIEnv.GetMethodID (class_ref, "onUxExceptionEvent", "(Lcom/google/tango/ux/UxExceptionEvent;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onUxExceptionEvent_Lcom_google_tango_ux_UxExceptionEvent_, __args);
		}

	}

	public partial class UxExceptionEventEventArgs : global::System.EventArgs {

		public UxExceptionEventEventArgs (global::Com.Google.Tango.UX.UxExceptionEvent p0)
		{
			this.p0 = p0;
		}

		global::Com.Google.Tango.UX.UxExceptionEvent p0;
		public global::Com.Google.Tango.UX.UxExceptionEvent P0 {
			get { return p0; }
		}
	}

	[global::Android.Runtime.Register ("mono/com/google/tango/ux/UxExceptionEventListenerImplementor")]
	internal sealed partial class IUxExceptionEventListenerImplementor : global::Java.Lang.Object, IUxExceptionEventListener {

		object sender;

		public IUxExceptionEventListenerImplementor (object sender)
			: base (
				global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/google/tango/ux/UxExceptionEventListenerImplementor", "()V"),
				JniHandleOwnership.TransferLocalRef)
		{
			global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
			this.sender = sender;
		}

#pragma warning disable 0649
		public EventHandler<UxExceptionEventEventArgs> Handler;
#pragma warning restore 0649

		public void OnUxExceptionEvent (global::Com.Google.Tango.UX.UxExceptionEvent p0)
		{
			var __h = Handler;
			if (__h != null)
				__h (sender, new UxExceptionEventEventArgs (p0));
		}

		internal static bool __IsEmpty (IUxExceptionEventListenerImplementor value)
		{
			return value.Handler == null;
		}
	}

}
