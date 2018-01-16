using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Google.Atap.Tangoservice {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.google.atap.tangoservice']/class[@name='TangoTextureCameraPreview']"
	[global::Android.Runtime.Register ("com/google/atap/tangoservice/TangoTextureCameraPreview", DoNotGenerateAcw=true)]
	public partial class TangoTextureCameraPreview : global::Android.Views.TextureView, global::Android.Views.TextureView.ISurfaceTextureListener {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/google/atap/tangoservice/TangoTextureCameraPreview", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (TangoTextureCameraPreview); }
		}

		protected TangoTextureCameraPreview (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.google.atap.tangoservice']/class[@name='TangoTextureCameraPreview']/constructor[@name='TangoTextureCameraPreview' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='android.util.AttributeSet']]"
		[Register (".ctor", "(Landroid/content/Context;Landroid/util/AttributeSet;)V", "")]
		public unsafe TangoTextureCameraPreview (global::Android.Content.Context p0, global::Android.Util.IAttributeSet p1)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				if (GetType () != typeof (TangoTextureCameraPreview)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Landroid/content/Context;Landroid/util/AttributeSet;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Landroid/content/Context;Landroid/util/AttributeSet;)V", __args);
					return;
				}

				if (id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_ == IntPtr.Zero)
					id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_, __args);
			} finally {
			}
		}

		static IntPtr id_ctor_Landroid_content_Context_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.google.atap.tangoservice']/class[@name='TangoTextureCameraPreview']/constructor[@name='TangoTextureCameraPreview' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register (".ctor", "(Landroid/content/Context;)V", "")]
		public unsafe TangoTextureCameraPreview (global::Android.Content.Context p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (GetType () != typeof (TangoTextureCameraPreview)) {
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

		static Delegate cb_getTimestamp;
#pragma warning disable 0169
		static Delegate GetGetTimestampHandler ()
		{
			if (cb_getTimestamp == null)
				cb_getTimestamp = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, double>) n_GetTimestamp);
			return cb_getTimestamp;
		}

		static double n_GetTimestamp (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Google.Atap.Tangoservice.TangoTextureCameraPreview __this = global::Java.Lang.Object.GetObject<global::Com.Google.Atap.Tangoservice.TangoTextureCameraPreview> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Timestamp;
		}
#pragma warning restore 0169

		static IntPtr id_getTimestamp;
		public virtual unsafe double Timestamp {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.atap.tangoservice']/class[@name='TangoTextureCameraPreview']/method[@name='getTimestamp' and count(parameter)=0]"
			[Register ("getTimestamp", "()D", "GetGetTimestampHandler")]
			get {
				if (id_getTimestamp == IntPtr.Zero)
					id_getTimestamp = JNIEnv.GetMethodID (class_ref, "getTimestamp", "()D");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallDoubleMethod (((global::Java.Lang.Object) this).Handle, id_getTimestamp);
					else
						return JNIEnv.CallNonvirtualDoubleMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getTimestamp", "()D"));
				} finally {
				}
			}
		}

		static Delegate cb_connectToTangoCamera_Lcom_google_atap_tangoservice_Tango_I;
#pragma warning disable 0169
		static Delegate GetConnectToTangoCamera_Lcom_google_atap_tangoservice_Tango_IHandler ()
		{
			if (cb_connectToTangoCamera_Lcom_google_atap_tangoservice_Tango_I == null)
				cb_connectToTangoCamera_Lcom_google_atap_tangoservice_Tango_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, int>) n_ConnectToTangoCamera_Lcom_google_atap_tangoservice_Tango_I);
			return cb_connectToTangoCamera_Lcom_google_atap_tangoservice_Tango_I;
		}

		static void n_ConnectToTangoCamera_Lcom_google_atap_tangoservice_Tango_I (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1)
		{
			global::Com.Google.Atap.Tangoservice.TangoTextureCameraPreview __this = global::Java.Lang.Object.GetObject<global::Com.Google.Atap.Tangoservice.TangoTextureCameraPreview> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Google.Atap.Tangoservice.Tango p0 = global::Java.Lang.Object.GetObject<global::Com.Google.Atap.Tangoservice.Tango> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.ConnectToTangoCamera (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_connectToTangoCamera_Lcom_google_atap_tangoservice_Tango_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.atap.tangoservice']/class[@name='TangoTextureCameraPreview']/method[@name='connectToTangoCamera' and count(parameter)=2 and parameter[1][@type='com.google.atap.tangoservice.Tango'] and parameter[2][@type='int']]"
		[Register ("connectToTangoCamera", "(Lcom/google/atap/tangoservice/Tango;I)V", "GetConnectToTangoCamera_Lcom_google_atap_tangoservice_Tango_IHandler")]
		public virtual unsafe void ConnectToTangoCamera (global::Com.Google.Atap.Tangoservice.Tango p0, int p1)
		{
			if (id_connectToTangoCamera_Lcom_google_atap_tangoservice_Tango_I == IntPtr.Zero)
				id_connectToTangoCamera_Lcom_google_atap_tangoservice_Tango_I = JNIEnv.GetMethodID (class_ref, "connectToTangoCamera", "(Lcom/google/atap/tangoservice/Tango;I)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_connectToTangoCamera_Lcom_google_atap_tangoservice_Tango_I, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "connectToTangoCamera", "(Lcom/google/atap/tangoservice/Tango;I)V"), __args);
			} finally {
			}
		}

		static Delegate cb_onFrameAvailable;
#pragma warning disable 0169
		static Delegate GetOnFrameAvailableHandler ()
		{
			if (cb_onFrameAvailable == null)
				cb_onFrameAvailable = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnFrameAvailable);
			return cb_onFrameAvailable;
		}

		static void n_OnFrameAvailable (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Google.Atap.Tangoservice.TangoTextureCameraPreview __this = global::Java.Lang.Object.GetObject<global::Com.Google.Atap.Tangoservice.TangoTextureCameraPreview> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnFrameAvailable ();
		}
#pragma warning restore 0169

		static IntPtr id_onFrameAvailable;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.atap.tangoservice']/class[@name='TangoTextureCameraPreview']/method[@name='onFrameAvailable' and count(parameter)=0]"
		[Register ("onFrameAvailable", "()V", "GetOnFrameAvailableHandler")]
		public virtual unsafe void OnFrameAvailable ()
		{
			if (id_onFrameAvailable == IntPtr.Zero)
				id_onFrameAvailable = JNIEnv.GetMethodID (class_ref, "onFrameAvailable", "()V");
			try {

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onFrameAvailable);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onFrameAvailable", "()V"));
			} finally {
			}
		}

		static Delegate cb_onSurfaceTextureAvailable_Landroid_graphics_SurfaceTexture_II;
#pragma warning disable 0169
		static Delegate GetOnSurfaceTextureAvailable_Landroid_graphics_SurfaceTexture_IIHandler ()
		{
			if (cb_onSurfaceTextureAvailable_Landroid_graphics_SurfaceTexture_II == null)
				cb_onSurfaceTextureAvailable_Landroid_graphics_SurfaceTexture_II = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, int, int>) n_OnSurfaceTextureAvailable_Landroid_graphics_SurfaceTexture_II);
			return cb_onSurfaceTextureAvailable_Landroid_graphics_SurfaceTexture_II;
		}

		static void n_OnSurfaceTextureAvailable_Landroid_graphics_SurfaceTexture_II (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1, int p2)
		{
			global::Com.Google.Atap.Tangoservice.TangoTextureCameraPreview __this = global::Java.Lang.Object.GetObject<global::Com.Google.Atap.Tangoservice.TangoTextureCameraPreview> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.SurfaceTexture p0 = global::Java.Lang.Object.GetObject<global::Android.Graphics.SurfaceTexture> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnSurfaceTextureAvailable (p0, p1, p2);
		}
#pragma warning restore 0169

		static IntPtr id_onSurfaceTextureAvailable_Landroid_graphics_SurfaceTexture_II;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.atap.tangoservice']/class[@name='TangoTextureCameraPreview']/method[@name='onSurfaceTextureAvailable' and count(parameter)=3 and parameter[1][@type='android.graphics.SurfaceTexture'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
		[Register ("onSurfaceTextureAvailable", "(Landroid/graphics/SurfaceTexture;II)V", "GetOnSurfaceTextureAvailable_Landroid_graphics_SurfaceTexture_IIHandler")]
		public virtual unsafe void OnSurfaceTextureAvailable (global::Android.Graphics.SurfaceTexture p0, int p1, int p2)
		{
			if (id_onSurfaceTextureAvailable_Landroid_graphics_SurfaceTexture_II == IntPtr.Zero)
				id_onSurfaceTextureAvailable_Landroid_graphics_SurfaceTexture_II = JNIEnv.GetMethodID (class_ref, "onSurfaceTextureAvailable", "(Landroid/graphics/SurfaceTexture;II)V");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onSurfaceTextureAvailable_Landroid_graphics_SurfaceTexture_II, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onSurfaceTextureAvailable", "(Landroid/graphics/SurfaceTexture;II)V"), __args);
			} finally {
			}
		}

		static Delegate cb_onSurfaceTextureDestroyed_Landroid_graphics_SurfaceTexture_;
#pragma warning disable 0169
		static Delegate GetOnSurfaceTextureDestroyed_Landroid_graphics_SurfaceTexture_Handler ()
		{
			if (cb_onSurfaceTextureDestroyed_Landroid_graphics_SurfaceTexture_ == null)
				cb_onSurfaceTextureDestroyed_Landroid_graphics_SurfaceTexture_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_OnSurfaceTextureDestroyed_Landroid_graphics_SurfaceTexture_);
			return cb_onSurfaceTextureDestroyed_Landroid_graphics_SurfaceTexture_;
		}

		static bool n_OnSurfaceTextureDestroyed_Landroid_graphics_SurfaceTexture_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Google.Atap.Tangoservice.TangoTextureCameraPreview __this = global::Java.Lang.Object.GetObject<global::Com.Google.Atap.Tangoservice.TangoTextureCameraPreview> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.SurfaceTexture p0 = global::Java.Lang.Object.GetObject<global::Android.Graphics.SurfaceTexture> (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.OnSurfaceTextureDestroyed (p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_onSurfaceTextureDestroyed_Landroid_graphics_SurfaceTexture_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.atap.tangoservice']/class[@name='TangoTextureCameraPreview']/method[@name='onSurfaceTextureDestroyed' and count(parameter)=1 and parameter[1][@type='android.graphics.SurfaceTexture']]"
		[Register ("onSurfaceTextureDestroyed", "(Landroid/graphics/SurfaceTexture;)Z", "GetOnSurfaceTextureDestroyed_Landroid_graphics_SurfaceTexture_Handler")]
		public virtual unsafe bool OnSurfaceTextureDestroyed (global::Android.Graphics.SurfaceTexture p0)
		{
			if (id_onSurfaceTextureDestroyed_Landroid_graphics_SurfaceTexture_ == IntPtr.Zero)
				id_onSurfaceTextureDestroyed_Landroid_graphics_SurfaceTexture_ = JNIEnv.GetMethodID (class_ref, "onSurfaceTextureDestroyed", "(Landroid/graphics/SurfaceTexture;)Z");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				bool __ret;
				if (GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_onSurfaceTextureDestroyed_Landroid_graphics_SurfaceTexture_, __args);
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onSurfaceTextureDestroyed", "(Landroid/graphics/SurfaceTexture;)Z"), __args);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_onSurfaceTextureSizeChanged_Landroid_graphics_SurfaceTexture_II;
#pragma warning disable 0169
		static Delegate GetOnSurfaceTextureSizeChanged_Landroid_graphics_SurfaceTexture_IIHandler ()
		{
			if (cb_onSurfaceTextureSizeChanged_Landroid_graphics_SurfaceTexture_II == null)
				cb_onSurfaceTextureSizeChanged_Landroid_graphics_SurfaceTexture_II = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, int, int>) n_OnSurfaceTextureSizeChanged_Landroid_graphics_SurfaceTexture_II);
			return cb_onSurfaceTextureSizeChanged_Landroid_graphics_SurfaceTexture_II;
		}

		static void n_OnSurfaceTextureSizeChanged_Landroid_graphics_SurfaceTexture_II (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1, int p2)
		{
			global::Com.Google.Atap.Tangoservice.TangoTextureCameraPreview __this = global::Java.Lang.Object.GetObject<global::Com.Google.Atap.Tangoservice.TangoTextureCameraPreview> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.SurfaceTexture p0 = global::Java.Lang.Object.GetObject<global::Android.Graphics.SurfaceTexture> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnSurfaceTextureSizeChanged (p0, p1, p2);
		}
#pragma warning restore 0169

		static IntPtr id_onSurfaceTextureSizeChanged_Landroid_graphics_SurfaceTexture_II;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.atap.tangoservice']/class[@name='TangoTextureCameraPreview']/method[@name='onSurfaceTextureSizeChanged' and count(parameter)=3 and parameter[1][@type='android.graphics.SurfaceTexture'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
		[Register ("onSurfaceTextureSizeChanged", "(Landroid/graphics/SurfaceTexture;II)V", "GetOnSurfaceTextureSizeChanged_Landroid_graphics_SurfaceTexture_IIHandler")]
		public virtual unsafe void OnSurfaceTextureSizeChanged (global::Android.Graphics.SurfaceTexture p0, int p1, int p2)
		{
			if (id_onSurfaceTextureSizeChanged_Landroid_graphics_SurfaceTexture_II == IntPtr.Zero)
				id_onSurfaceTextureSizeChanged_Landroid_graphics_SurfaceTexture_II = JNIEnv.GetMethodID (class_ref, "onSurfaceTextureSizeChanged", "(Landroid/graphics/SurfaceTexture;II)V");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onSurfaceTextureSizeChanged_Landroid_graphics_SurfaceTexture_II, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onSurfaceTextureSizeChanged", "(Landroid/graphics/SurfaceTexture;II)V"), __args);
			} finally {
			}
		}

		static Delegate cb_onSurfaceTextureUpdated_Landroid_graphics_SurfaceTexture_;
#pragma warning disable 0169
		static Delegate GetOnSurfaceTextureUpdated_Landroid_graphics_SurfaceTexture_Handler ()
		{
			if (cb_onSurfaceTextureUpdated_Landroid_graphics_SurfaceTexture_ == null)
				cb_onSurfaceTextureUpdated_Landroid_graphics_SurfaceTexture_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnSurfaceTextureUpdated_Landroid_graphics_SurfaceTexture_);
			return cb_onSurfaceTextureUpdated_Landroid_graphics_SurfaceTexture_;
		}

		static void n_OnSurfaceTextureUpdated_Landroid_graphics_SurfaceTexture_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Google.Atap.Tangoservice.TangoTextureCameraPreview __this = global::Java.Lang.Object.GetObject<global::Com.Google.Atap.Tangoservice.TangoTextureCameraPreview> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.SurfaceTexture p0 = global::Java.Lang.Object.GetObject<global::Android.Graphics.SurfaceTexture> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnSurfaceTextureUpdated (p0);
		}
#pragma warning restore 0169

		static IntPtr id_onSurfaceTextureUpdated_Landroid_graphics_SurfaceTexture_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.atap.tangoservice']/class[@name='TangoTextureCameraPreview']/method[@name='onSurfaceTextureUpdated' and count(parameter)=1 and parameter[1][@type='android.graphics.SurfaceTexture']]"
		[Register ("onSurfaceTextureUpdated", "(Landroid/graphics/SurfaceTexture;)V", "GetOnSurfaceTextureUpdated_Landroid_graphics_SurfaceTexture_Handler")]
		public virtual unsafe void OnSurfaceTextureUpdated (global::Android.Graphics.SurfaceTexture p0)
		{
			if (id_onSurfaceTextureUpdated_Landroid_graphics_SurfaceTexture_ == IntPtr.Zero)
				id_onSurfaceTextureUpdated_Landroid_graphics_SurfaceTexture_ = JNIEnv.GetMethodID (class_ref, "onSurfaceTextureUpdated", "(Landroid/graphics/SurfaceTexture;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onSurfaceTextureUpdated_Landroid_graphics_SurfaceTexture_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onSurfaceTextureUpdated", "(Landroid/graphics/SurfaceTexture;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_updateTexture;
#pragma warning disable 0169
		static Delegate GetUpdateTextureHandler ()
		{
			if (cb_updateTexture == null)
				cb_updateTexture = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_UpdateTexture);
			return cb_updateTexture;
		}

		static void n_UpdateTexture (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Google.Atap.Tangoservice.TangoTextureCameraPreview __this = global::Java.Lang.Object.GetObject<global::Com.Google.Atap.Tangoservice.TangoTextureCameraPreview> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.UpdateTexture ();
		}
#pragma warning restore 0169

		static IntPtr id_updateTexture;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.atap.tangoservice']/class[@name='TangoTextureCameraPreview']/method[@name='updateTexture' and count(parameter)=0]"
		[Register ("updateTexture", "()V", "GetUpdateTextureHandler")]
		public virtual unsafe void UpdateTexture ()
		{
			if (id_updateTexture == IntPtr.Zero)
				id_updateTexture = JNIEnv.GetMethodID (class_ref, "updateTexture", "()V");
			try {

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_updateTexture);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "updateTexture", "()V"));
			} finally {
			}
		}

	}
}
