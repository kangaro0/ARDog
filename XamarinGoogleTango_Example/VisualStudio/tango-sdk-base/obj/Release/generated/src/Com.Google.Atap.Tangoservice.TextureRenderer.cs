using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Google.Atap.Tangoservice {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.google.atap.tangoservice']/class[@name='TextureRenderer']"
	[global::Android.Runtime.Register ("com/google/atap/tangoservice/TextureRenderer", DoNotGenerateAcw=true)]
	public partial class TextureRenderer : global::Java.Lang.Thread {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/google/atap/tangoservice/TextureRenderer", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (TextureRenderer); }
		}

		protected TextureRenderer (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static Delegate cb_getTextureId;
#pragma warning disable 0169
		static Delegate GetGetTextureIdHandler ()
		{
			if (cb_getTextureId == null)
				cb_getTextureId = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetTextureId);
			return cb_getTextureId;
		}

		static int n_GetTextureId (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Google.Atap.Tangoservice.TextureRenderer __this = global::Java.Lang.Object.GetObject<global::Com.Google.Atap.Tangoservice.TextureRenderer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.TextureId;
		}
#pragma warning restore 0169

		static IntPtr id_getTextureId;
		public virtual unsafe int TextureId {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.atap.tangoservice']/class[@name='TextureRenderer']/method[@name='getTextureId' and count(parameter)=0]"
			[Register ("getTextureId", "()I", "GetGetTextureIdHandler")]
			get {
				if (id_getTextureId == IntPtr.Zero)
					id_getTextureId = JNIEnv.GetMethodID (class_ref, "getTextureId", "()I");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getTextureId);
					else
						return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getTextureId", "()I"));
				} finally {
				}
			}
		}

		static Delegate cb_initTexture;
#pragma warning disable 0169
		static Delegate GetInitTextureHandler ()
		{
			if (cb_initTexture == null)
				cb_initTexture = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_InitTexture);
			return cb_initTexture;
		}

		static int n_InitTexture (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Google.Atap.Tangoservice.TextureRenderer __this = global::Java.Lang.Object.GetObject<global::Com.Google.Atap.Tangoservice.TextureRenderer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.InitTexture ();
		}
#pragma warning restore 0169

		static IntPtr id_initTexture;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.atap.tangoservice']/class[@name='TextureRenderer']/method[@name='initTexture' and count(parameter)=0]"
		[Register ("initTexture", "()I", "GetInitTextureHandler")]
		public virtual unsafe int InitTexture ()
		{
			if (id_initTexture == IntPtr.Zero)
				id_initTexture = JNIEnv.GetMethodID (class_ref, "initTexture", "()I");
			try {

				if (GetType () == ThresholdType)
					return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_initTexture);
				else
					return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "initTexture", "()I"));
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
			global::Com.Google.Atap.Tangoservice.TextureRenderer __this = global::Java.Lang.Object.GetObject<global::Com.Google.Atap.Tangoservice.TextureRenderer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnFrameAvailable ();
		}
#pragma warning restore 0169

		static IntPtr id_onFrameAvailable;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.atap.tangoservice']/class[@name='TextureRenderer']/method[@name='onFrameAvailable' and count(parameter)=0]"
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

		static Delegate cb_setSurfaceTexture_Landroid_graphics_SurfaceTexture_;
#pragma warning disable 0169
		static Delegate GetSetSurfaceTexture_Landroid_graphics_SurfaceTexture_Handler ()
		{
			if (cb_setSurfaceTexture_Landroid_graphics_SurfaceTexture_ == null)
				cb_setSurfaceTexture_Landroid_graphics_SurfaceTexture_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetSurfaceTexture_Landroid_graphics_SurfaceTexture_);
			return cb_setSurfaceTexture_Landroid_graphics_SurfaceTexture_;
		}

		static void n_SetSurfaceTexture_Landroid_graphics_SurfaceTexture_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Google.Atap.Tangoservice.TextureRenderer __this = global::Java.Lang.Object.GetObject<global::Com.Google.Atap.Tangoservice.TextureRenderer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.SurfaceTexture p0 = global::Java.Lang.Object.GetObject<global::Android.Graphics.SurfaceTexture> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetSurfaceTexture (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setSurfaceTexture_Landroid_graphics_SurfaceTexture_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.atap.tangoservice']/class[@name='TextureRenderer']/method[@name='setSurfaceTexture' and count(parameter)=1 and parameter[1][@type='android.graphics.SurfaceTexture']]"
		[Register ("setSurfaceTexture", "(Landroid/graphics/SurfaceTexture;)V", "GetSetSurfaceTexture_Landroid_graphics_SurfaceTexture_Handler")]
		public virtual unsafe void SetSurfaceTexture (global::Android.Graphics.SurfaceTexture p0)
		{
			if (id_setSurfaceTexture_Landroid_graphics_SurfaceTexture_ == IntPtr.Zero)
				id_setSurfaceTexture_Landroid_graphics_SurfaceTexture_ = JNIEnv.GetMethodID (class_ref, "setSurfaceTexture", "(Landroid/graphics/SurfaceTexture;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setSurfaceTexture_Landroid_graphics_SurfaceTexture_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setSurfaceTexture", "(Landroid/graphics/SurfaceTexture;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setViewport_II;
#pragma warning disable 0169
		static Delegate GetSetViewport_IIHandler ()
		{
			if (cb_setViewport_II == null)
				cb_setViewport_II = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, int>) n_SetViewport_II);
			return cb_setViewport_II;
		}

		static void n_SetViewport_II (IntPtr jnienv, IntPtr native__this, int p0, int p1)
		{
			global::Com.Google.Atap.Tangoservice.TextureRenderer __this = global::Java.Lang.Object.GetObject<global::Com.Google.Atap.Tangoservice.TextureRenderer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetViewport (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_setViewport_II;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.atap.tangoservice']/class[@name='TextureRenderer']/method[@name='setViewport' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
		[Register ("setViewport", "(II)V", "GetSetViewport_IIHandler")]
		public virtual unsafe void SetViewport (int p0, int p1)
		{
			if (id_setViewport_II == IntPtr.Zero)
				id_setViewport_II = JNIEnv.GetMethodID (class_ref, "setViewport", "(II)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setViewport_II, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setViewport", "(II)V"), __args);
			} finally {
			}
		}

	}
}
