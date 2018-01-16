using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Google.Tango.UX {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.google.tango.ux']/class[@name='TangoUx']"
	[global::Android.Runtime.Register ("com/google/tango/ux/TangoUx", DoNotGenerateAcw=true)]
	public partial class TangoUx : global::Java.Lang.Object {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.tango.ux']/class[@name='TangoUx']/field[@name='TYPE_HOLD_POSTURE_DOWN']"
		[Register ("TYPE_HOLD_POSTURE_DOWN")]
		public const int TypeHoldPostureDown = (int) 3;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.tango.ux']/class[@name='TangoUx']/field[@name='TYPE_HOLD_POSTURE_FORWARD']"
		[Register ("TYPE_HOLD_POSTURE_FORWARD")]
		public const int TypeHoldPostureForward = (int) 1;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.tango.ux']/class[@name='TangoUx']/field[@name='TYPE_HOLD_POSTURE_NONE']"
		[Register ("TYPE_HOLD_POSTURE_NONE")]
		public const int TypeHoldPostureNone = (int) 0;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.tango.ux']/class[@name='TangoUx']/field[@name='TYPE_HOLD_POSTURE_UP']"
		[Register ("TYPE_HOLD_POSTURE_UP")]
		public const int TypeHoldPostureUp = (int) 2;
		// Metadata.xml XPath class reference: path="/api/package[@name='com.google.tango.ux']/class[@name='TangoUx.UiHandler']"
		[global::Android.Runtime.Register ("com/google/tango/ux/TangoUx$UiHandler", DoNotGenerateAcw=true)]
		public partial class UiHandler : global::Android.OS.Handler {

			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/google/tango/ux/TangoUx$UiHandler", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (UiHandler); }
			}

			protected UiHandler (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor_Lcom_google_tango_ux_TangoUx_;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.google.tango.ux']/class[@name='TangoUx.UiHandler']/constructor[@name='TangoUx.UiHandler' and count(parameter)=1 and parameter[1][@type='com.google.tango.ux.TangoUx']]"
			[Register (".ctor", "(Lcom/google/tango/ux/TangoUx;)V", "")]
			public unsafe UiHandler (global::Com.Google.Tango.UX.TangoUx __self)
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (__self);
					if (GetType () != typeof (UiHandler)) {
						SetHandle (
								global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(L" + global::Android.Runtime.JNIEnv.GetJniName (GetType ().DeclaringType) + ";)V", __args),
								JniHandleOwnership.TransferLocalRef);
						global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(L" + global::Android.Runtime.JNIEnv.GetJniName (GetType ().DeclaringType) + ";)V", __args);
						return;
					}

					if (id_ctor_Lcom_google_tango_ux_TangoUx_ == IntPtr.Zero)
						id_ctor_Lcom_google_tango_ux_TangoUx_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/google/tango/ux/TangoUx;)V");
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_google_tango_ux_TangoUx_, __args),
							JniHandleOwnership.TransferLocalRef);
					JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Lcom_google_tango_ux_TangoUx_, __args);
				} finally {
				}
			}

			static Delegate cb_removeMessages;
#pragma warning disable 0169
			static Delegate GetRemoveMessagesHandler ()
			{
				if (cb_removeMessages == null)
					cb_removeMessages = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_RemoveMessages);
				return cb_removeMessages;
			}

			static void n_RemoveMessages (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Google.Tango.UX.TangoUx.UiHandler __this = global::Java.Lang.Object.GetObject<global::Com.Google.Tango.UX.TangoUx.UiHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.RemoveMessages ();
			}
#pragma warning restore 0169

			static IntPtr id_removeMessages;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.tango.ux']/class[@name='TangoUx.UiHandler']/method[@name='removeMessages' and count(parameter)=0]"
			[Register ("removeMessages", "()V", "GetRemoveMessagesHandler")]
			public virtual unsafe void RemoveMessages ()
			{
				if (id_removeMessages == IntPtr.Zero)
					id_removeMessages = JNIEnv.GetMethodID (class_ref, "removeMessages", "()V");
				try {

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_removeMessages);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "removeMessages", "()V"));
				} finally {
				}
			}

			static Delegate cb_sendExceptionDetected_Lcom_google_tango_ux_UxExceptionEvent_;
#pragma warning disable 0169
			static Delegate GetSendExceptionDetected_Lcom_google_tango_ux_UxExceptionEvent_Handler ()
			{
				if (cb_sendExceptionDetected_Lcom_google_tango_ux_UxExceptionEvent_ == null)
					cb_sendExceptionDetected_Lcom_google_tango_ux_UxExceptionEvent_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SendExceptionDetected_Lcom_google_tango_ux_UxExceptionEvent_);
				return cb_sendExceptionDetected_Lcom_google_tango_ux_UxExceptionEvent_;
			}

			static void n_SendExceptionDetected_Lcom_google_tango_ux_UxExceptionEvent_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Google.Tango.UX.TangoUx.UiHandler __this = global::Java.Lang.Object.GetObject<global::Com.Google.Tango.UX.TangoUx.UiHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Com.Google.Tango.UX.UxExceptionEvent p0 = global::Java.Lang.Object.GetObject<global::Com.Google.Tango.UX.UxExceptionEvent> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.SendExceptionDetected (p0);
			}
#pragma warning restore 0169

			static IntPtr id_sendExceptionDetected_Lcom_google_tango_ux_UxExceptionEvent_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.tango.ux']/class[@name='TangoUx.UiHandler']/method[@name='sendExceptionDetected' and count(parameter)=1 and parameter[1][@type='com.google.tango.ux.UxExceptionEvent']]"
			[Register ("sendExceptionDetected", "(Lcom/google/tango/ux/UxExceptionEvent;)V", "GetSendExceptionDetected_Lcom_google_tango_ux_UxExceptionEvent_Handler")]
			public virtual unsafe void SendExceptionDetected (global::Com.Google.Tango.UX.UxExceptionEvent p0)
			{
				if (id_sendExceptionDetected_Lcom_google_tango_ux_UxExceptionEvent_ == IntPtr.Zero)
					id_sendExceptionDetected_Lcom_google_tango_ux_UxExceptionEvent_ = JNIEnv.GetMethodID (class_ref, "sendExceptionDetected", "(Lcom/google/tango/ux/UxExceptionEvent;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (p0);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_sendExceptionDetected_Lcom_google_tango_ux_UxExceptionEvent_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "sendExceptionDetected", "(Lcom/google/tango/ux/UxExceptionEvent;)V"), __args);
				} finally {
				}
			}

			static Delegate cb_sendExceptionDismissed_Lcom_google_tango_ux_UxExceptionEvent_;
#pragma warning disable 0169
			static Delegate GetSendExceptionDismissed_Lcom_google_tango_ux_UxExceptionEvent_Handler ()
			{
				if (cb_sendExceptionDismissed_Lcom_google_tango_ux_UxExceptionEvent_ == null)
					cb_sendExceptionDismissed_Lcom_google_tango_ux_UxExceptionEvent_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SendExceptionDismissed_Lcom_google_tango_ux_UxExceptionEvent_);
				return cb_sendExceptionDismissed_Lcom_google_tango_ux_UxExceptionEvent_;
			}

			static void n_SendExceptionDismissed_Lcom_google_tango_ux_UxExceptionEvent_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Google.Tango.UX.TangoUx.UiHandler __this = global::Java.Lang.Object.GetObject<global::Com.Google.Tango.UX.TangoUx.UiHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Com.Google.Tango.UX.UxExceptionEvent p0 = global::Java.Lang.Object.GetObject<global::Com.Google.Tango.UX.UxExceptionEvent> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.SendExceptionDismissed (p0);
			}
#pragma warning restore 0169

			static IntPtr id_sendExceptionDismissed_Lcom_google_tango_ux_UxExceptionEvent_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.tango.ux']/class[@name='TangoUx.UiHandler']/method[@name='sendExceptionDismissed' and count(parameter)=1 and parameter[1][@type='com.google.tango.ux.UxExceptionEvent']]"
			[Register ("sendExceptionDismissed", "(Lcom/google/tango/ux/UxExceptionEvent;)V", "GetSendExceptionDismissed_Lcom_google_tango_ux_UxExceptionEvent_Handler")]
			public virtual unsafe void SendExceptionDismissed (global::Com.Google.Tango.UX.UxExceptionEvent p0)
			{
				if (id_sendExceptionDismissed_Lcom_google_tango_ux_UxExceptionEvent_ == IntPtr.Zero)
					id_sendExceptionDismissed_Lcom_google_tango_ux_UxExceptionEvent_ = JNIEnv.GetMethodID (class_ref, "sendExceptionDismissed", "(Lcom/google/tango/ux/UxExceptionEvent;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (p0);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_sendExceptionDismissed_Lcom_google_tango_ux_UxExceptionEvent_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "sendExceptionDismissed", "(Lcom/google/tango/ux/UxExceptionEvent;)V"), __args);
				} finally {
				}
			}

			static Delegate cb_sendSetHoldPosture_I;
#pragma warning disable 0169
			static Delegate GetSendSetHoldPosture_IHandler ()
			{
				if (cb_sendSetHoldPosture_I == null)
					cb_sendSetHoldPosture_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SendSetHoldPosture_I);
				return cb_sendSetHoldPosture_I;
			}

			static void n_SendSetHoldPosture_I (IntPtr jnienv, IntPtr native__this, int p0)
			{
				global::Com.Google.Tango.UX.TangoUx.UiHandler __this = global::Java.Lang.Object.GetObject<global::Com.Google.Tango.UX.TangoUx.UiHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.SendSetHoldPosture (p0);
			}
#pragma warning restore 0169

			static IntPtr id_sendSetHoldPosture_I;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.tango.ux']/class[@name='TangoUx.UiHandler']/method[@name='sendSetHoldPosture' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("sendSetHoldPosture", "(I)V", "GetSendSetHoldPosture_IHandler")]
			public virtual unsafe void SendSetHoldPosture (int p0)
			{
				if (id_sendSetHoldPosture_I == IntPtr.Zero)
					id_sendSetHoldPosture_I = JNIEnv.GetMethodID (class_ref, "sendSetHoldPosture", "(I)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (p0);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_sendSetHoldPosture_I, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "sendSetHoldPosture", "(I)V"), __args);
				} finally {
				}
			}

			static Delegate cb_sendStart;
#pragma warning disable 0169
			static Delegate GetSendStartHandler ()
			{
				if (cb_sendStart == null)
					cb_sendStart = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_SendStart);
				return cb_sendStart;
			}

			static void n_SendStart (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Google.Tango.UX.TangoUx.UiHandler __this = global::Java.Lang.Object.GetObject<global::Com.Google.Tango.UX.TangoUx.UiHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.SendStart ();
			}
#pragma warning restore 0169

			static IntPtr id_sendStart;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.tango.ux']/class[@name='TangoUx.UiHandler']/method[@name='sendStart' and count(parameter)=0]"
			[Register ("sendStart", "()V", "GetSendStartHandler")]
			public virtual unsafe void SendStart ()
			{
				if (id_sendStart == IntPtr.Zero)
					id_sendStart = JNIEnv.GetMethodID (class_ref, "sendStart", "()V");
				try {

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_sendStart);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "sendStart", "()V"));
				} finally {
				}
			}

		}

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/google/tango/ux/TangoUx", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (TangoUx); }
		}

		protected TangoUx (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Landroid_content_Context_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.google.tango.ux']/class[@name='TangoUx']/constructor[@name='TangoUx' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register (".ctor", "(Landroid/content/Context;)V", "")]
		public unsafe TangoUx (global::Android.Content.Context p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (GetType () != typeof (TangoUx)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Landroid/content/Context;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Landroid/content/Context;)V", __args);
					return;
				}

				if (id_ctor_Landroid_content_Context_ == IntPtr.Zero)
					id_ctor_Landroid_content_Context_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/content/Context;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_content_Context_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Landroid_content_Context_, __args);
			} finally {
			}
		}

		static Delegate cb_setHoldPosture_I;
#pragma warning disable 0169
		static Delegate GetSetHoldPosture_IHandler ()
		{
			if (cb_setHoldPosture_I == null)
				cb_setHoldPosture_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetHoldPosture_I);
			return cb_setHoldPosture_I;
		}

		static void n_SetHoldPosture_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Google.Tango.UX.TangoUx __this = global::Java.Lang.Object.GetObject<global::Com.Google.Tango.UX.TangoUx> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetHoldPosture (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setHoldPosture_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.tango.ux']/class[@name='TangoUx']/method[@name='setHoldPosture' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setHoldPosture", "(I)V", "GetSetHoldPosture_IHandler")]
		public virtual unsafe void SetHoldPosture (int p0)
		{
			if (id_setHoldPosture_I == IntPtr.Zero)
				id_setHoldPosture_I = JNIEnv.GetMethodID (class_ref, "setHoldPosture", "(I)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setHoldPosture_I, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setHoldPosture", "(I)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setUxExceptionEventListener_Lcom_google_tango_ux_UxExceptionEventListener_;
#pragma warning disable 0169
		static Delegate GetSetUxExceptionEventListener_Lcom_google_tango_ux_UxExceptionEventListener_Handler ()
		{
			if (cb_setUxExceptionEventListener_Lcom_google_tango_ux_UxExceptionEventListener_ == null)
				cb_setUxExceptionEventListener_Lcom_google_tango_ux_UxExceptionEventListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetUxExceptionEventListener_Lcom_google_tango_ux_UxExceptionEventListener_);
			return cb_setUxExceptionEventListener_Lcom_google_tango_ux_UxExceptionEventListener_;
		}

		static void n_SetUxExceptionEventListener_Lcom_google_tango_ux_UxExceptionEventListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Google.Tango.UX.TangoUx __this = global::Java.Lang.Object.GetObject<global::Com.Google.Tango.UX.TangoUx> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Google.Tango.UX.IUxExceptionEventListener p0 = (global::Com.Google.Tango.UX.IUxExceptionEventListener)global::Java.Lang.Object.GetObject<global::Com.Google.Tango.UX.IUxExceptionEventListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetUxExceptionEventListener (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setUxExceptionEventListener_Lcom_google_tango_ux_UxExceptionEventListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.tango.ux']/class[@name='TangoUx']/method[@name='setUxExceptionEventListener' and count(parameter)=1 and parameter[1][@type='com.google.tango.ux.UxExceptionEventListener']]"
		[Register ("setUxExceptionEventListener", "(Lcom/google/tango/ux/UxExceptionEventListener;)V", "GetSetUxExceptionEventListener_Lcom_google_tango_ux_UxExceptionEventListener_Handler")]
		public virtual unsafe void SetUxExceptionEventListener (global::Com.Google.Tango.UX.IUxExceptionEventListener p0)
		{
			if (id_setUxExceptionEventListener_Lcom_google_tango_ux_UxExceptionEventListener_ == IntPtr.Zero)
				id_setUxExceptionEventListener_Lcom_google_tango_ux_UxExceptionEventListener_ = JNIEnv.GetMethodID (class_ref, "setUxExceptionEventListener", "(Lcom/google/tango/ux/UxExceptionEventListener;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setUxExceptionEventListener_Lcom_google_tango_ux_UxExceptionEventListener_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setUxExceptionEventListener", "(Lcom/google/tango/ux/UxExceptionEventListener;)V"), __args);
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
			global::Com.Google.Tango.UX.TangoUx __this = global::Java.Lang.Object.GetObject<global::Com.Google.Tango.UX.TangoUx> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Start ();
		}
#pragma warning restore 0169

		static IntPtr id_start;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.tango.ux']/class[@name='TangoUx']/method[@name='start' and count(parameter)=0]"
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
			global::Com.Google.Tango.UX.TangoUx __this = global::Java.Lang.Object.GetObject<global::Com.Google.Tango.UX.TangoUx> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Stop ();
		}
#pragma warning restore 0169

		static IntPtr id_stop;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.tango.ux']/class[@name='TangoUx']/method[@name='stop' and count(parameter)=0]"
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

		static Delegate cb_updatePointCloud_Lcom_google_atap_tangoservice_TangoPointCloudData_;
#pragma warning disable 0169
		static Delegate GetUpdatePointCloud_Lcom_google_atap_tangoservice_TangoPointCloudData_Handler ()
		{
			if (cb_updatePointCloud_Lcom_google_atap_tangoservice_TangoPointCloudData_ == null)
				cb_updatePointCloud_Lcom_google_atap_tangoservice_TangoPointCloudData_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_UpdatePointCloud_Lcom_google_atap_tangoservice_TangoPointCloudData_);
			return cb_updatePointCloud_Lcom_google_atap_tangoservice_TangoPointCloudData_;
		}

		static void n_UpdatePointCloud_Lcom_google_atap_tangoservice_TangoPointCloudData_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Google.Tango.UX.TangoUx __this = global::Java.Lang.Object.GetObject<global::Com.Google.Tango.UX.TangoUx> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Google.Atap.Tangoservice.TangoPointCloudData p0 = global::Java.Lang.Object.GetObject<global::Com.Google.Atap.Tangoservice.TangoPointCloudData> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.UpdatePointCloud (p0);
		}
#pragma warning restore 0169

		static IntPtr id_updatePointCloud_Lcom_google_atap_tangoservice_TangoPointCloudData_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.tango.ux']/class[@name='TangoUx']/method[@name='updatePointCloud' and count(parameter)=1 and parameter[1][@type='com.google.atap.tangoservice.TangoPointCloudData']]"
		[Register ("updatePointCloud", "(Lcom/google/atap/tangoservice/TangoPointCloudData;)V", "GetUpdatePointCloud_Lcom_google_atap_tangoservice_TangoPointCloudData_Handler")]
		public virtual unsafe void UpdatePointCloud (global::Com.Google.Atap.Tangoservice.TangoPointCloudData p0)
		{
			if (id_updatePointCloud_Lcom_google_atap_tangoservice_TangoPointCloudData_ == IntPtr.Zero)
				id_updatePointCloud_Lcom_google_atap_tangoservice_TangoPointCloudData_ = JNIEnv.GetMethodID (class_ref, "updatePointCloud", "(Lcom/google/atap/tangoservice/TangoPointCloudData;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_updatePointCloud_Lcom_google_atap_tangoservice_TangoPointCloudData_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "updatePointCloud", "(Lcom/google/atap/tangoservice/TangoPointCloudData;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_updatePoseStatus_I;
#pragma warning disable 0169
		static Delegate GetUpdatePoseStatus_IHandler ()
		{
			if (cb_updatePoseStatus_I == null)
				cb_updatePoseStatus_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_UpdatePoseStatus_I);
			return cb_updatePoseStatus_I;
		}

		static void n_UpdatePoseStatus_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Google.Tango.UX.TangoUx __this = global::Java.Lang.Object.GetObject<global::Com.Google.Tango.UX.TangoUx> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.UpdatePoseStatus (p0);
		}
#pragma warning restore 0169

		static IntPtr id_updatePoseStatus_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.tango.ux']/class[@name='TangoUx']/method[@name='updatePoseStatus' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("updatePoseStatus", "(I)V", "GetUpdatePoseStatus_IHandler")]
		public virtual unsafe void UpdatePoseStatus (int p0)
		{
			if (id_updatePoseStatus_I == IntPtr.Zero)
				id_updatePoseStatus_I = JNIEnv.GetMethodID (class_ref, "updatePoseStatus", "(I)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_updatePoseStatus_I, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "updatePoseStatus", "(I)V"), __args);
			} finally {
			}
		}

		static Delegate cb_updateTangoEvent_Lcom_google_atap_tangoservice_TangoEvent_;
#pragma warning disable 0169
		static Delegate GetUpdateTangoEvent_Lcom_google_atap_tangoservice_TangoEvent_Handler ()
		{
			if (cb_updateTangoEvent_Lcom_google_atap_tangoservice_TangoEvent_ == null)
				cb_updateTangoEvent_Lcom_google_atap_tangoservice_TangoEvent_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_UpdateTangoEvent_Lcom_google_atap_tangoservice_TangoEvent_);
			return cb_updateTangoEvent_Lcom_google_atap_tangoservice_TangoEvent_;
		}

		static void n_UpdateTangoEvent_Lcom_google_atap_tangoservice_TangoEvent_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Google.Tango.UX.TangoUx __this = global::Java.Lang.Object.GetObject<global::Com.Google.Tango.UX.TangoUx> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Google.Atap.Tangoservice.TangoEvent p0 = global::Java.Lang.Object.GetObject<global::Com.Google.Atap.Tangoservice.TangoEvent> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.UpdateTangoEvent (p0);
		}
#pragma warning restore 0169

		static IntPtr id_updateTangoEvent_Lcom_google_atap_tangoservice_TangoEvent_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.tango.ux']/class[@name='TangoUx']/method[@name='updateTangoEvent' and count(parameter)=1 and parameter[1][@type='com.google.atap.tangoservice.TangoEvent']]"
		[Register ("updateTangoEvent", "(Lcom/google/atap/tangoservice/TangoEvent;)V", "GetUpdateTangoEvent_Lcom_google_atap_tangoservice_TangoEvent_Handler")]
		public virtual unsafe void UpdateTangoEvent (global::Com.Google.Atap.Tangoservice.TangoEvent p0)
		{
			if (id_updateTangoEvent_Lcom_google_atap_tangoservice_TangoEvent_ == IntPtr.Zero)
				id_updateTangoEvent_Lcom_google_atap_tangoservice_TangoEvent_ = JNIEnv.GetMethodID (class_ref, "updateTangoEvent", "(Lcom/google/atap/tangoservice/TangoEvent;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_updateTangoEvent_Lcom_google_atap_tangoservice_TangoEvent_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "updateTangoEvent", "(Lcom/google/atap/tangoservice/TangoEvent;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_updateXyzCount_I;
#pragma warning disable 0169
		static Delegate GetUpdateXyzCount_IHandler ()
		{
			if (cb_updateXyzCount_I == null)
				cb_updateXyzCount_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_UpdateXyzCount_I);
			return cb_updateXyzCount_I;
		}

		static void n_UpdateXyzCount_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Google.Tango.UX.TangoUx __this = global::Java.Lang.Object.GetObject<global::Com.Google.Tango.UX.TangoUx> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.UpdateXyzCount (p0);
		}
#pragma warning restore 0169

		static IntPtr id_updateXyzCount_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.tango.ux']/class[@name='TangoUx']/method[@name='updateXyzCount' and count(parameter)=1 and parameter[1][@type='int']]"
		[Obsolete (@"deprecated")]
		[Register ("updateXyzCount", "(I)V", "GetUpdateXyzCount_IHandler")]
		public virtual unsafe void UpdateXyzCount (int p0)
		{
			if (id_updateXyzCount_I == IntPtr.Zero)
				id_updateXyzCount_I = JNIEnv.GetMethodID (class_ref, "updateXyzCount", "(I)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_updateXyzCount_I, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "updateXyzCount", "(I)V"), __args);
			} finally {
			}
		}

#region "Event implementation for Com.Google.Tango.UX.IUxExceptionEventListener"
		public event EventHandler<global::Com.Google.Tango.UX.UxExceptionEventEventArgs> UxExceptionEvent {
			add {
				global::Java.Interop.EventHelper.AddEventHandler<global::Com.Google.Tango.UX.IUxExceptionEventListener, global::Com.Google.Tango.UX.IUxExceptionEventListenerImplementor>(
						ref weak_implementor_SetUxExceptionEventListener,
						__CreateIUxExceptionEventListenerImplementor,
						SetUxExceptionEventListener,
						__h => __h.Handler += value);
			}
			remove {
				global::Java.Interop.EventHelper.RemoveEventHandler<global::Com.Google.Tango.UX.IUxExceptionEventListener, global::Com.Google.Tango.UX.IUxExceptionEventListenerImplementor>(
						ref weak_implementor_SetUxExceptionEventListener,
						global::Com.Google.Tango.UX.IUxExceptionEventListenerImplementor.__IsEmpty,
						__v => SetUxExceptionEventListener (null),
						__h => __h.Handler -= value);
			}
		}

		WeakReference weak_implementor_SetUxExceptionEventListener;

		global::Com.Google.Tango.UX.IUxExceptionEventListenerImplementor __CreateIUxExceptionEventListenerImplementor ()
		{
			return new global::Com.Google.Tango.UX.IUxExceptionEventListenerImplementor (this);
		}
#endregion
	}
}
