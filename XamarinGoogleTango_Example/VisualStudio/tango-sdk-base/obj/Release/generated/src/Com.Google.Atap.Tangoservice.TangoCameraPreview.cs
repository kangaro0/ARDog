using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Google.Atap.Tangoservice {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.google.atap.tangoservice']/class[@name='TangoCameraPreview']"
	[global::Android.Runtime.Register ("com/google/atap/tangoservice/TangoCameraPreview", DoNotGenerateAcw=true)]
	public partial class TangoCameraPreview : global::Android.Opengl.GLSurfaceView {

		// Metadata.xml XPath class reference: path="/api/package[@name='com.google.atap.tangoservice']/class[@name='TangoCameraPreview.MainRenderer']"
		[global::Android.Runtime.Register ("com/google/atap/tangoservice/TangoCameraPreview$MainRenderer", DoNotGenerateAcw=true)]
		public partial class MainRenderer : global::Java.Lang.Object, global::Android.Opengl.GLSurfaceView.IRenderer {

			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/google/atap/tangoservice/TangoCameraPreview$MainRenderer", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (MainRenderer); }
			}

			protected MainRenderer (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

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
				global::Com.Google.Atap.Tangoservice.TangoCameraPreview.MainRenderer __this = global::Java.Lang.Object.GetObject<global::Com.Google.Atap.Tangoservice.TangoCameraPreview.MainRenderer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return __this.TextureId;
			}
#pragma warning restore 0169

			static IntPtr id_getTextureId;
			public virtual unsafe int TextureId {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.google.atap.tangoservice']/class[@name='TangoCameraPreview.MainRenderer']/method[@name='getTextureId' and count(parameter)=0]"
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

			static Delegate cb_close;
#pragma warning disable 0169
			static Delegate GetCloseHandler ()
			{
				if (cb_close == null)
					cb_close = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Close);
				return cb_close;
			}

			static void n_Close (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Google.Atap.Tangoservice.TangoCameraPreview.MainRenderer __this = global::Java.Lang.Object.GetObject<global::Com.Google.Atap.Tangoservice.TangoCameraPreview.MainRenderer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.Close ();
			}
#pragma warning restore 0169

			static IntPtr id_close;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.atap.tangoservice']/class[@name='TangoCameraPreview.MainRenderer']/method[@name='close' and count(parameter)=0]"
			[Register ("close", "()V", "GetCloseHandler")]
			public virtual unsafe void Close ()
			{
				if (id_close == IntPtr.Zero)
					id_close = JNIEnv.GetMethodID (class_ref, "close", "()V");
				try {

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_close);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "close", "()V"));
				} finally {
				}
			}

			static Delegate cb_onDrawFrame_Ljavax_microedition_khronos_opengles_GL10_;
#pragma warning disable 0169
			static Delegate GetOnDrawFrame_Ljavax_microedition_khronos_opengles_GL10_Handler ()
			{
				if (cb_onDrawFrame_Ljavax_microedition_khronos_opengles_GL10_ == null)
					cb_onDrawFrame_Ljavax_microedition_khronos_opengles_GL10_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnDrawFrame_Ljavax_microedition_khronos_opengles_GL10_);
				return cb_onDrawFrame_Ljavax_microedition_khronos_opengles_GL10_;
			}

			static void n_OnDrawFrame_Ljavax_microedition_khronos_opengles_GL10_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Google.Atap.Tangoservice.TangoCameraPreview.MainRenderer __this = global::Java.Lang.Object.GetObject<global::Com.Google.Atap.Tangoservice.TangoCameraPreview.MainRenderer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Javax.Microedition.Khronos.Opengles.IGL10 p0 = (global::Javax.Microedition.Khronos.Opengles.IGL10)global::Java.Lang.Object.GetObject<global::Javax.Microedition.Khronos.Opengles.IGL10> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.OnDrawFrame (p0);
			}
#pragma warning restore 0169

			static IntPtr id_onDrawFrame_Ljavax_microedition_khronos_opengles_GL10_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.atap.tangoservice']/class[@name='TangoCameraPreview.MainRenderer']/method[@name='onDrawFrame' and count(parameter)=1 and parameter[1][@type='javax.microedition.khronos.opengles.GL10']]"
			[Register ("onDrawFrame", "(Ljavax/microedition/khronos/opengles/GL10;)V", "GetOnDrawFrame_Ljavax_microedition_khronos_opengles_GL10_Handler")]
			public virtual unsafe void OnDrawFrame (global::Javax.Microedition.Khronos.Opengles.IGL10 p0)
			{
				if (id_onDrawFrame_Ljavax_microedition_khronos_opengles_GL10_ == IntPtr.Zero)
					id_onDrawFrame_Ljavax_microedition_khronos_opengles_GL10_ = JNIEnv.GetMethodID (class_ref, "onDrawFrame", "(Ljavax/microedition/khronos/opengles/GL10;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (p0);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onDrawFrame_Ljavax_microedition_khronos_opengles_GL10_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onDrawFrame", "(Ljavax/microedition/khronos/opengles/GL10;)V"), __args);
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
				global::Com.Google.Atap.Tangoservice.TangoCameraPreview.MainRenderer __this = global::Java.Lang.Object.GetObject<global::Com.Google.Atap.Tangoservice.TangoCameraPreview.MainRenderer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.OnFrameAvailable ();
			}
#pragma warning restore 0169

			static IntPtr id_onFrameAvailable;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.atap.tangoservice']/class[@name='TangoCameraPreview.MainRenderer']/method[@name='onFrameAvailable' and count(parameter)=0]"
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

			static Delegate cb_onSurfaceChanged_Ljavax_microedition_khronos_opengles_GL10_II;
#pragma warning disable 0169
			static Delegate GetOnSurfaceChanged_Ljavax_microedition_khronos_opengles_GL10_IIHandler ()
			{
				if (cb_onSurfaceChanged_Ljavax_microedition_khronos_opengles_GL10_II == null)
					cb_onSurfaceChanged_Ljavax_microedition_khronos_opengles_GL10_II = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, int, int>) n_OnSurfaceChanged_Ljavax_microedition_khronos_opengles_GL10_II);
				return cb_onSurfaceChanged_Ljavax_microedition_khronos_opengles_GL10_II;
			}

			static void n_OnSurfaceChanged_Ljavax_microedition_khronos_opengles_GL10_II (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1, int p2)
			{
				global::Com.Google.Atap.Tangoservice.TangoCameraPreview.MainRenderer __this = global::Java.Lang.Object.GetObject<global::Com.Google.Atap.Tangoservice.TangoCameraPreview.MainRenderer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Javax.Microedition.Khronos.Opengles.IGL10 p0 = (global::Javax.Microedition.Khronos.Opengles.IGL10)global::Java.Lang.Object.GetObject<global::Javax.Microedition.Khronos.Opengles.IGL10> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.OnSurfaceChanged (p0, p1, p2);
			}
#pragma warning restore 0169

			static IntPtr id_onSurfaceChanged_Ljavax_microedition_khronos_opengles_GL10_II;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.atap.tangoservice']/class[@name='TangoCameraPreview.MainRenderer']/method[@name='onSurfaceChanged' and count(parameter)=3 and parameter[1][@type='javax.microedition.khronos.opengles.GL10'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
			[Register ("onSurfaceChanged", "(Ljavax/microedition/khronos/opengles/GL10;II)V", "GetOnSurfaceChanged_Ljavax_microedition_khronos_opengles_GL10_IIHandler")]
			public virtual unsafe void OnSurfaceChanged (global::Javax.Microedition.Khronos.Opengles.IGL10 p0, int p1, int p2)
			{
				if (id_onSurfaceChanged_Ljavax_microedition_khronos_opengles_GL10_II == IntPtr.Zero)
					id_onSurfaceChanged_Ljavax_microedition_khronos_opengles_GL10_II = JNIEnv.GetMethodID (class_ref, "onSurfaceChanged", "(Ljavax/microedition/khronos/opengles/GL10;II)V");
				try {
					JValue* __args = stackalloc JValue [3];
					__args [0] = new JValue (p0);
					__args [1] = new JValue (p1);
					__args [2] = new JValue (p2);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onSurfaceChanged_Ljavax_microedition_khronos_opengles_GL10_II, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onSurfaceChanged", "(Ljavax/microedition/khronos/opengles/GL10;II)V"), __args);
				} finally {
				}
			}

			static Delegate cb_onSurfaceCreated_Ljavax_microedition_khronos_opengles_GL10_Ljavax_microedition_khronos_egl_EGLConfig_;
#pragma warning disable 0169
			static Delegate GetOnSurfaceCreated_Ljavax_microedition_khronos_opengles_GL10_Ljavax_microedition_khronos_egl_EGLConfig_Handler ()
			{
				if (cb_onSurfaceCreated_Ljavax_microedition_khronos_opengles_GL10_Ljavax_microedition_khronos_egl_EGLConfig_ == null)
					cb_onSurfaceCreated_Ljavax_microedition_khronos_opengles_GL10_Ljavax_microedition_khronos_egl_EGLConfig_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_OnSurfaceCreated_Ljavax_microedition_khronos_opengles_GL10_Ljavax_microedition_khronos_egl_EGLConfig_);
				return cb_onSurfaceCreated_Ljavax_microedition_khronos_opengles_GL10_Ljavax_microedition_khronos_egl_EGLConfig_;
			}

			static void n_OnSurfaceCreated_Ljavax_microedition_khronos_opengles_GL10_Ljavax_microedition_khronos_egl_EGLConfig_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
			{
				global::Com.Google.Atap.Tangoservice.TangoCameraPreview.MainRenderer __this = global::Java.Lang.Object.GetObject<global::Com.Google.Atap.Tangoservice.TangoCameraPreview.MainRenderer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Javax.Microedition.Khronos.Opengles.IGL10 p0 = (global::Javax.Microedition.Khronos.Opengles.IGL10)global::Java.Lang.Object.GetObject<global::Javax.Microedition.Khronos.Opengles.IGL10> (native_p0, JniHandleOwnership.DoNotTransfer);
				global::Javax.Microedition.Khronos.Egl.EGLConfig p1 = global::Java.Lang.Object.GetObject<global::Javax.Microedition.Khronos.Egl.EGLConfig> (native_p1, JniHandleOwnership.DoNotTransfer);
				__this.OnSurfaceCreated (p0, p1);
			}
#pragma warning restore 0169

			static IntPtr id_onSurfaceCreated_Ljavax_microedition_khronos_opengles_GL10_Ljavax_microedition_khronos_egl_EGLConfig_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.atap.tangoservice']/class[@name='TangoCameraPreview.MainRenderer']/method[@name='onSurfaceCreated' and count(parameter)=2 and parameter[1][@type='javax.microedition.khronos.opengles.GL10'] and parameter[2][@type='javax.microedition.khronos.egl.EGLConfig']]"
			[Register ("onSurfaceCreated", "(Ljavax/microedition/khronos/opengles/GL10;Ljavax/microedition/khronos/egl/EGLConfig;)V", "GetOnSurfaceCreated_Ljavax_microedition_khronos_opengles_GL10_Ljavax_microedition_khronos_egl_EGLConfig_Handler")]
			public virtual unsafe void OnSurfaceCreated (global::Javax.Microedition.Khronos.Opengles.IGL10 p0, global::Javax.Microedition.Khronos.Egl.EGLConfig p1)
			{
				if (id_onSurfaceCreated_Ljavax_microedition_khronos_opengles_GL10_Ljavax_microedition_khronos_egl_EGLConfig_ == IntPtr.Zero)
					id_onSurfaceCreated_Ljavax_microedition_khronos_opengles_GL10_Ljavax_microedition_khronos_egl_EGLConfig_ = JNIEnv.GetMethodID (class_ref, "onSurfaceCreated", "(Ljavax/microedition/khronos/opengles/GL10;Ljavax/microedition/khronos/egl/EGLConfig;)V");
				try {
					JValue* __args = stackalloc JValue [2];
					__args [0] = new JValue (p0);
					__args [1] = new JValue (p1);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onSurfaceCreated_Ljavax_microedition_khronos_opengles_GL10_Ljavax_microedition_khronos_egl_EGLConfig_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onSurfaceCreated", "(Ljavax/microedition/khronos/opengles/GL10;Ljavax/microedition/khronos/egl/EGLConfig;)V"), __args);
				} finally {
				}
			}

		}

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/google/atap/tangoservice/TangoCameraPreview", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (TangoCameraPreview); }
		}

		protected TangoCameraPreview (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Landroid_content_Context_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.google.atap.tangoservice']/class[@name='TangoCameraPreview']/constructor[@name='TangoCameraPreview' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register (".ctor", "(Landroid/content/Context;)V", "")]
		public unsafe TangoCameraPreview (global::Android.Content.Context p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (GetType () != typeof (TangoCameraPreview)) {
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

		static IntPtr id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.google.atap.tangoservice']/class[@name='TangoCameraPreview']/constructor[@name='TangoCameraPreview' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='android.util.AttributeSet']]"
		[Register (".ctor", "(Landroid/content/Context;Landroid/util/AttributeSet;)V", "")]
		public unsafe TangoCameraPreview (global::Android.Content.Context p0, global::Android.Util.IAttributeSet p1)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				if (GetType () != typeof (TangoCameraPreview)) {
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
			global::Com.Google.Atap.Tangoservice.TangoCameraPreview __this = global::Java.Lang.Object.GetObject<global::Com.Google.Atap.Tangoservice.TangoCameraPreview> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Timestamp;
		}
#pragma warning restore 0169

		static IntPtr id_getTimestamp;
		public virtual unsafe double Timestamp {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.atap.tangoservice']/class[@name='TangoCameraPreview']/method[@name='getTimestamp' and count(parameter)=0]"
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
			global::Com.Google.Atap.Tangoservice.TangoCameraPreview __this = global::Java.Lang.Object.GetObject<global::Com.Google.Atap.Tangoservice.TangoCameraPreview> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Google.Atap.Tangoservice.Tango p0 = global::Java.Lang.Object.GetObject<global::Com.Google.Atap.Tangoservice.Tango> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.ConnectToTangoCamera (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_connectToTangoCamera_Lcom_google_atap_tangoservice_Tango_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.atap.tangoservice']/class[@name='TangoCameraPreview']/method[@name='connectToTangoCamera' and count(parameter)=2 and parameter[1][@type='com.google.atap.tangoservice.Tango'] and parameter[2][@type='int']]"
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

		static Delegate cb_disconnectFromTangoCamera;
#pragma warning disable 0169
		static Delegate GetDisconnectFromTangoCameraHandler ()
		{
			if (cb_disconnectFromTangoCamera == null)
				cb_disconnectFromTangoCamera = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_DisconnectFromTangoCamera);
			return cb_disconnectFromTangoCamera;
		}

		static void n_DisconnectFromTangoCamera (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Google.Atap.Tangoservice.TangoCameraPreview __this = global::Java.Lang.Object.GetObject<global::Com.Google.Atap.Tangoservice.TangoCameraPreview> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.DisconnectFromTangoCamera ();
		}
#pragma warning restore 0169

		static IntPtr id_disconnectFromTangoCamera;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.atap.tangoservice']/class[@name='TangoCameraPreview']/method[@name='disconnectFromTangoCamera' and count(parameter)=0]"
		[Register ("disconnectFromTangoCamera", "()V", "GetDisconnectFromTangoCameraHandler")]
		public virtual unsafe void DisconnectFromTangoCamera ()
		{
			if (id_disconnectFromTangoCamera == IntPtr.Zero)
				id_disconnectFromTangoCamera = JNIEnv.GetMethodID (class_ref, "disconnectFromTangoCamera", "()V");
			try {

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_disconnectFromTangoCamera);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "disconnectFromTangoCamera", "()V"));
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
			global::Com.Google.Atap.Tangoservice.TangoCameraPreview __this = global::Java.Lang.Object.GetObject<global::Com.Google.Atap.Tangoservice.TangoCameraPreview> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnFrameAvailable ();
		}
#pragma warning restore 0169

		static IntPtr id_onFrameAvailable;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.atap.tangoservice']/class[@name='TangoCameraPreview']/method[@name='onFrameAvailable' and count(parameter)=0]"
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
			global::Com.Google.Atap.Tangoservice.TangoCameraPreview __this = global::Java.Lang.Object.GetObject<global::Com.Google.Atap.Tangoservice.TangoCameraPreview> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.UpdateTexture ();
		}
#pragma warning restore 0169

		static IntPtr id_updateTexture;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.atap.tangoservice']/class[@name='TangoCameraPreview']/method[@name='updateTexture' and count(parameter)=0]"
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
