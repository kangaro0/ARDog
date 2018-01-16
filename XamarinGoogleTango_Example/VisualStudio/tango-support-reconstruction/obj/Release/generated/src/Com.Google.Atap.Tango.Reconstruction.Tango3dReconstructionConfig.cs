using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Google.Atap.Tango.Reconstruction {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.google.atap.tango.reconstruction']/class[@name='Tango3dReconstructionConfig']"
	[global::Android.Runtime.Register ("com/google/atap/tango/reconstruction/Tango3dReconstructionConfig", DoNotGenerateAcw=true)]
	public partial class Tango3dReconstructionConfig : global::Java.Lang.Object {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.atap.tango.reconstruction']/class[@name='Tango3dReconstructionConfig']/field[@name='BEVEL']"
		[Register ("BEVEL")]
		public const string Bevel = (string) "bevel";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.atap.tango.reconstruction']/class[@name='Tango3dReconstructionConfig']/field[@name='MAX_DEPTH']"
		[Register ("MAX_DEPTH")]
		public const string MaxDepth = (string) "max_depth";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.atap.tango.reconstruction']/class[@name='Tango3dReconstructionConfig']/field[@name='MAX_NUM_TEXTURES']"
		[Register ("MAX_NUM_TEXTURES")]
		public const string MaxNumTextures = (string) "max_num_textures";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.atap.tango.reconstruction']/class[@name='Tango3dReconstructionConfig']/field[@name='MIN_DEPTH']"
		[Register ("MIN_DEPTH")]
		public const string MinDepth = (string) "min_depth";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.atap.tango.reconstruction']/class[@name='Tango3dReconstructionConfig']/field[@name='MIN_RESOLUTION']"
		[Register ("MIN_RESOLUTION")]
		public const string MinResolution = (string) "min_resolution";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.atap.tango.reconstruction']/class[@name='Tango3dReconstructionConfig']/field[@name='PROJECTIVE_UPDATE_METHOD']"
		[Register ("PROJECTIVE_UPDATE_METHOD")]
		public const int ProjectiveUpdateMethod = (int) 1;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.atap.tango.reconstruction']/class[@name='Tango3dReconstructionConfig']/field[@name='TANGO_3DR_CONFIG_CONTEXT']"
		[Register ("TANGO_3DR_CONFIG_CONTEXT")]
		public const int Tango3drConfigContext = (int) 0;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.atap.tango.reconstruction']/class[@name='Tango3dReconstructionConfig']/field[@name='TANGO_3DR_CONFIG_TEXTURING']"
		[Register ("TANGO_3DR_CONFIG_TEXTURING")]
		public const int Tango3drConfigTexturing = (int) 1;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.atap.tango.reconstruction']/class[@name='Tango3dReconstructionConfig']/field[@name='TANGO_3DR_CPU_TEXTURING']"
		[Register ("TANGO_3DR_CPU_TEXTURING")]
		public const int Tango3drCpuTexturing = (int) 0;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.atap.tango.reconstruction']/class[@name='Tango3dReconstructionConfig']/field[@name='TANGO_3DR_GL_TEXTURING']"
		[Register ("TANGO_3DR_GL_TEXTURING")]
		public const int Tango3drGlTexturing = (int) 1;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.atap.tango.reconstruction']/class[@name='Tango3dReconstructionConfig']/field[@name='TEXTURE_SIZE']"
		[Register ("TEXTURE_SIZE")]
		public const string TextureSize = (string) "texture_size";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.atap.tango.reconstruction']/class[@name='Tango3dReconstructionConfig']/field[@name='TEXTURING_BACKEND']"
		[Register ("TEXTURING_BACKEND")]
		public const string TexturingBackend = (string) "texturing_backend";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.atap.tango.reconstruction']/class[@name='Tango3dReconstructionConfig']/field[@name='TRAVERSAL_UPDATE_METHOD']"
		[Register ("TRAVERSAL_UPDATE_METHOD")]
		public const int TraversalUpdateMethod = (int) 0;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.atap.tango.reconstruction']/class[@name='Tango3dReconstructionConfig']/field[@name='UPDATE_METHOD']"
		[Register ("UPDATE_METHOD")]
		public const string UpdateMethod = (string) "update_method";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.atap.tango.reconstruction']/class[@name='Tango3dReconstructionConfig']/field[@name='USE_SPACE_CLEARING']"
		[Register ("USE_SPACE_CLEARING")]
		public const string UseSpaceClearing = (string) "use_space_clearing";
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/google/atap/tango/reconstruction/Tango3dReconstructionConfig", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (Tango3dReconstructionConfig); }
		}

		protected Tango3dReconstructionConfig (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.google.atap.tango.reconstruction']/class[@name='Tango3dReconstructionConfig']/constructor[@name='Tango3dReconstructionConfig' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe Tango3dReconstructionConfig ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (Tango3dReconstructionConfig)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "()V"),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
					return;
				}

				if (id_ctor == IntPtr.Zero)
					id_ctor = JNIEnv.GetMethodID (class_ref, "<init>", "()V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor);
			} finally {
			}
		}

		static IntPtr id_ctor_I;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.google.atap.tango.reconstruction']/class[@name='Tango3dReconstructionConfig']/constructor[@name='Tango3dReconstructionConfig' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register (".ctor", "(I)V", "")]
		public unsafe Tango3dReconstructionConfig (int p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (GetType () != typeof (Tango3dReconstructionConfig)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(I)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(I)V", __args);
					return;
				}

				if (id_ctor_I == IntPtr.Zero)
					id_ctor_I = JNIEnv.GetMethodID (class_ref, "<init>", "(I)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_I, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_I, __args);
			} finally {
			}
		}

		static Delegate cb_getNativeHandle;
#pragma warning disable 0169
		static Delegate GetGetNativeHandleHandler ()
		{
			if (cb_getNativeHandle == null)
				cb_getNativeHandle = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long>) n_GetNativeHandle);
			return cb_getNativeHandle;
		}

		static long n_GetNativeHandle (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Google.Atap.Tango.Reconstruction.Tango3dReconstructionConfig __this = global::Java.Lang.Object.GetObject<global::Com.Google.Atap.Tango.Reconstruction.Tango3dReconstructionConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.NativeHandle;
		}
#pragma warning restore 0169

		static IntPtr id_getNativeHandle;
		public virtual unsafe long NativeHandle {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.atap.tango.reconstruction']/class[@name='Tango3dReconstructionConfig']/method[@name='getNativeHandle' and count(parameter)=0]"
			[Register ("getNativeHandle", "()J", "GetGetNativeHandleHandler")]
			get {
				if (id_getNativeHandle == IntPtr.Zero)
					id_getNativeHandle = JNIEnv.GetMethodID (class_ref, "getNativeHandle", "()J");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallLongMethod (((global::Java.Lang.Object) this).Handle, id_getNativeHandle);
					else
						return JNIEnv.CallNonvirtualLongMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getNativeHandle", "()J"));
				} finally {
				}
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
			global::Com.Google.Atap.Tango.Reconstruction.Tango3dReconstructionConfig __this = global::Java.Lang.Object.GetObject<global::Com.Google.Atap.Tango.Reconstruction.Tango3dReconstructionConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Finalize ();
		}
#pragma warning restore 0169

		static IntPtr id_finalize;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.atap.tango.reconstruction']/class[@name='Tango3dReconstructionConfig']/method[@name='finalize' and count(parameter)=0]"
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

		static Delegate cb_getBoolean_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGetBoolean_Ljava_lang_String_Handler ()
		{
			if (cb_getBoolean_Ljava_lang_String_ == null)
				cb_getBoolean_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_GetBoolean_Ljava_lang_String_);
			return cb_getBoolean_Ljava_lang_String_;
		}

		static bool n_GetBoolean_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Google.Atap.Tango.Reconstruction.Tango3dReconstructionConfig __this = global::Java.Lang.Object.GetObject<global::Com.Google.Atap.Tango.Reconstruction.Tango3dReconstructionConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.GetBoolean (p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getBoolean_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.atap.tango.reconstruction']/class[@name='Tango3dReconstructionConfig']/method[@name='getBoolean' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getBoolean", "(Ljava/lang/String;)Z", "GetGetBoolean_Ljava_lang_String_Handler")]
		public virtual unsafe bool GetBoolean (string p0)
		{
			if (id_getBoolean_Ljava_lang_String_ == IntPtr.Zero)
				id_getBoolean_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "getBoolean", "(Ljava/lang/String;)Z");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				bool __ret;
				if (GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_getBoolean_Ljava_lang_String_, __args);
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getBoolean", "(Ljava/lang/String;)Z"), __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_getDouble_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGetDouble_Ljava_lang_String_Handler ()
		{
			if (cb_getDouble_Ljava_lang_String_ == null)
				cb_getDouble_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, double>) n_GetDouble_Ljava_lang_String_);
			return cb_getDouble_Ljava_lang_String_;
		}

		static double n_GetDouble_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Google.Atap.Tango.Reconstruction.Tango3dReconstructionConfig __this = global::Java.Lang.Object.GetObject<global::Com.Google.Atap.Tango.Reconstruction.Tango3dReconstructionConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			double __ret = __this.GetDouble (p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getDouble_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.atap.tango.reconstruction']/class[@name='Tango3dReconstructionConfig']/method[@name='getDouble' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getDouble", "(Ljava/lang/String;)D", "GetGetDouble_Ljava_lang_String_Handler")]
		public virtual unsafe double GetDouble (string p0)
		{
			if (id_getDouble_Ljava_lang_String_ == IntPtr.Zero)
				id_getDouble_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "getDouble", "(Ljava/lang/String;)D");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				double __ret;
				if (GetType () == ThresholdType)
					__ret = JNIEnv.CallDoubleMethod (((global::Java.Lang.Object) this).Handle, id_getDouble_Ljava_lang_String_, __args);
				else
					__ret = JNIEnv.CallNonvirtualDoubleMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getDouble", "(Ljava/lang/String;)D"), __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_getInt_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGetInt_Ljava_lang_String_Handler ()
		{
			if (cb_getInt_Ljava_lang_String_ == null)
				cb_getInt_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, int>) n_GetInt_Ljava_lang_String_);
			return cb_getInt_Ljava_lang_String_;
		}

		static int n_GetInt_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Google.Atap.Tango.Reconstruction.Tango3dReconstructionConfig __this = global::Java.Lang.Object.GetObject<global::Com.Google.Atap.Tango.Reconstruction.Tango3dReconstructionConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.GetInt (p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getInt_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.atap.tango.reconstruction']/class[@name='Tango3dReconstructionConfig']/method[@name='getInt' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getInt", "(Ljava/lang/String;)I", "GetGetInt_Ljava_lang_String_Handler")]
		public virtual unsafe int GetInt (string p0)
		{
			if (id_getInt_Ljava_lang_String_ == IntPtr.Zero)
				id_getInt_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "getInt", "(Ljava/lang/String;)I");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				int __ret;
				if (GetType () == ThresholdType)
					__ret = JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getInt_Ljava_lang_String_, __args);
				else
					__ret = JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getInt", "(Ljava/lang/String;)I"), __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_getLong_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGetLong_Ljava_lang_String_Handler ()
		{
			if (cb_getLong_Ljava_lang_String_ == null)
				cb_getLong_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, long>) n_GetLong_Ljava_lang_String_);
			return cb_getLong_Ljava_lang_String_;
		}

		static long n_GetLong_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Google.Atap.Tango.Reconstruction.Tango3dReconstructionConfig __this = global::Java.Lang.Object.GetObject<global::Com.Google.Atap.Tango.Reconstruction.Tango3dReconstructionConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			long __ret = __this.GetLong (p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getLong_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.atap.tango.reconstruction']/class[@name='Tango3dReconstructionConfig']/method[@name='getLong' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getLong", "(Ljava/lang/String;)J", "GetGetLong_Ljava_lang_String_Handler")]
		public virtual unsafe long GetLong (string p0)
		{
			if (id_getLong_Ljava_lang_String_ == IntPtr.Zero)
				id_getLong_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "getLong", "(Ljava/lang/String;)J");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				long __ret;
				if (GetType () == ThresholdType)
					__ret = JNIEnv.CallLongMethod (((global::Java.Lang.Object) this).Handle, id_getLong_Ljava_lang_String_, __args);
				else
					__ret = JNIEnv.CallNonvirtualLongMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getLong", "(Ljava/lang/String;)J"), __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_putBoolean_Ljava_lang_String_Z;
#pragma warning disable 0169
		static Delegate GetPutBoolean_Ljava_lang_String_ZHandler ()
		{
			if (cb_putBoolean_Ljava_lang_String_Z == null)
				cb_putBoolean_Ljava_lang_String_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, bool>) n_PutBoolean_Ljava_lang_String_Z);
			return cb_putBoolean_Ljava_lang_String_Z;
		}

		static void n_PutBoolean_Ljava_lang_String_Z (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, bool p1)
		{
			global::Com.Google.Atap.Tango.Reconstruction.Tango3dReconstructionConfig __this = global::Java.Lang.Object.GetObject<global::Com.Google.Atap.Tango.Reconstruction.Tango3dReconstructionConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.PutBoolean (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_putBoolean_Ljava_lang_String_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.atap.tango.reconstruction']/class[@name='Tango3dReconstructionConfig']/method[@name='putBoolean' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='boolean']]"
		[Register ("putBoolean", "(Ljava/lang/String;Z)V", "GetPutBoolean_Ljava_lang_String_ZHandler")]
		public virtual unsafe void PutBoolean (string p0, bool p1)
		{
			if (id_putBoolean_Ljava_lang_String_Z == IntPtr.Zero)
				id_putBoolean_Ljava_lang_String_Z = JNIEnv.GetMethodID (class_ref, "putBoolean", "(Ljava/lang/String;Z)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_putBoolean_Ljava_lang_String_Z, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "putBoolean", "(Ljava/lang/String;Z)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_putDouble_Ljava_lang_String_D;
#pragma warning disable 0169
		static Delegate GetPutDouble_Ljava_lang_String_DHandler ()
		{
			if (cb_putDouble_Ljava_lang_String_D == null)
				cb_putDouble_Ljava_lang_String_D = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, double>) n_PutDouble_Ljava_lang_String_D);
			return cb_putDouble_Ljava_lang_String_D;
		}

		static void n_PutDouble_Ljava_lang_String_D (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, double p1)
		{
			global::Com.Google.Atap.Tango.Reconstruction.Tango3dReconstructionConfig __this = global::Java.Lang.Object.GetObject<global::Com.Google.Atap.Tango.Reconstruction.Tango3dReconstructionConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.PutDouble (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_putDouble_Ljava_lang_String_D;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.atap.tango.reconstruction']/class[@name='Tango3dReconstructionConfig']/method[@name='putDouble' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='double']]"
		[Register ("putDouble", "(Ljava/lang/String;D)V", "GetPutDouble_Ljava_lang_String_DHandler")]
		public virtual unsafe void PutDouble (string p0, double p1)
		{
			if (id_putDouble_Ljava_lang_String_D == IntPtr.Zero)
				id_putDouble_Ljava_lang_String_D = JNIEnv.GetMethodID (class_ref, "putDouble", "(Ljava/lang/String;D)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_putDouble_Ljava_lang_String_D, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "putDouble", "(Ljava/lang/String;D)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_putInt_Ljava_lang_String_I;
#pragma warning disable 0169
		static Delegate GetPutInt_Ljava_lang_String_IHandler ()
		{
			if (cb_putInt_Ljava_lang_String_I == null)
				cb_putInt_Ljava_lang_String_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, int>) n_PutInt_Ljava_lang_String_I);
			return cb_putInt_Ljava_lang_String_I;
		}

		static void n_PutInt_Ljava_lang_String_I (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1)
		{
			global::Com.Google.Atap.Tango.Reconstruction.Tango3dReconstructionConfig __this = global::Java.Lang.Object.GetObject<global::Com.Google.Atap.Tango.Reconstruction.Tango3dReconstructionConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.PutInt (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_putInt_Ljava_lang_String_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.atap.tango.reconstruction']/class[@name='Tango3dReconstructionConfig']/method[@name='putInt' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='int']]"
		[Register ("putInt", "(Ljava/lang/String;I)V", "GetPutInt_Ljava_lang_String_IHandler")]
		public virtual unsafe void PutInt (string p0, int p1)
		{
			if (id_putInt_Ljava_lang_String_I == IntPtr.Zero)
				id_putInt_Ljava_lang_String_I = JNIEnv.GetMethodID (class_ref, "putInt", "(Ljava/lang/String;I)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_putInt_Ljava_lang_String_I, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "putInt", "(Ljava/lang/String;I)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_putLong_Ljava_lang_String_J;
#pragma warning disable 0169
		static Delegate GetPutLong_Ljava_lang_String_JHandler ()
		{
			if (cb_putLong_Ljava_lang_String_J == null)
				cb_putLong_Ljava_lang_String_J = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, long>) n_PutLong_Ljava_lang_String_J);
			return cb_putLong_Ljava_lang_String_J;
		}

		static void n_PutLong_Ljava_lang_String_J (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, long p1)
		{
			global::Com.Google.Atap.Tango.Reconstruction.Tango3dReconstructionConfig __this = global::Java.Lang.Object.GetObject<global::Com.Google.Atap.Tango.Reconstruction.Tango3dReconstructionConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.PutLong (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_putLong_Ljava_lang_String_J;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.atap.tango.reconstruction']/class[@name='Tango3dReconstructionConfig']/method[@name='putLong' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='long']]"
		[Register ("putLong", "(Ljava/lang/String;J)V", "GetPutLong_Ljava_lang_String_JHandler")]
		public virtual unsafe void PutLong (string p0, long p1)
		{
			if (id_putLong_Ljava_lang_String_J == IntPtr.Zero)
				id_putLong_Ljava_lang_String_J = JNIEnv.GetMethodID (class_ref, "putLong", "(Ljava/lang/String;J)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_putLong_Ljava_lang_String_J, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "putLong", "(Ljava/lang/String;J)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

	}
}
