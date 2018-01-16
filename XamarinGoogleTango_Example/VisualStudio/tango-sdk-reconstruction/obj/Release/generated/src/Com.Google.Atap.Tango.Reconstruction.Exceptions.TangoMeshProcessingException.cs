using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Google.Atap.Tango.Reconstruction.Exceptions {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.google.atap.tango.reconstruction.exceptions']/class[@name='TangoMeshProcessingException']"
	[global::Android.Runtime.Register ("com/google/atap/tango/reconstruction/exceptions/TangoMeshProcessingException", DoNotGenerateAcw=true)]
	public partial class TangoMeshProcessingException : global::Android.Util.AndroidRuntimeException {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/google/atap/tango/reconstruction/exceptions/TangoMeshProcessingException", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (TangoMeshProcessingException); }
		}

		protected TangoMeshProcessingException (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Ljava_lang_String_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.google.atap.tango.reconstruction.exceptions']/class[@name='TangoMeshProcessingException']/constructor[@name='TangoMeshProcessingException' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register (".ctor", "(Ljava/lang/String;)V", "")]
		public unsafe TangoMeshProcessingException (string p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Throwable) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				if (GetType () != typeof (TangoMeshProcessingException)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Ljava/lang/String;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Throwable) this).Handle, "(Ljava/lang/String;)V", __args);
					return;
				}

				if (id_ctor_Ljava_lang_String_ == IntPtr.Zero)
					id_ctor_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/lang/String;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_lang_String_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Throwable) this).Handle, class_ref, id_ctor_Ljava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_throwTangoExceptionIfNeeded_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.atap.tango.reconstruction.exceptions']/class[@name='TangoMeshProcessingException']/method[@name='throwTangoExceptionIfNeeded' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("throwTangoExceptionIfNeeded", "(I)V", "")]
		public static unsafe void ThrowTangoExceptionIfNeeded (int p0)
		{
			if (id_throwTangoExceptionIfNeeded_I == IntPtr.Zero)
				id_throwTangoExceptionIfNeeded_I = JNIEnv.GetStaticMethodID (class_ref, "throwTangoExceptionIfNeeded", "(I)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_throwTangoExceptionIfNeeded_I, __args);
			} finally {
			}
		}

	}
}
