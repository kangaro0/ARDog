using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Google.Tango.Loader {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.google.tango.loader']/class[@name='ObjectWrapper']"
	[global::Android.Runtime.Register ("com/google/tango/loader/ObjectWrapper", DoNotGenerateAcw=true)]
	[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
	public sealed partial class ObjectWrapper : global::Com.Google.Tango.Loader.ObjectWrapperStub {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/google/tango/loader/ObjectWrapper", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ObjectWrapper); }
		}

		internal ObjectWrapper (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_unwrap_Lcom_google_tango_loader_IObjectWrapper_Ljava_lang_Class_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.tango.loader']/class[@name='ObjectWrapper']/method[@name='unwrap' and count(parameter)=2 and parameter[1][@type='com.google.tango.loader.IObjectWrapper'] and parameter[2][@type='java.lang.Class&lt;T&gt;']]"
		[Register ("unwrap", "(Lcom/google/tango/loader/IObjectWrapper;Ljava/lang/Class;)Ljava/lang/Object;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
		public static unsafe global::Java.Lang.Object Unwrap (global::Com.Google.Tango.Loader.IObjectWrapper p0, global::Java.Lang.Class p1)
		{
			if (id_unwrap_Lcom_google_tango_loader_IObjectWrapper_Ljava_lang_Class_ == IntPtr.Zero)
				id_unwrap_Lcom_google_tango_loader_IObjectWrapper_Ljava_lang_Class_ = JNIEnv.GetStaticMethodID (class_ref, "unwrap", "(Lcom/google/tango/loader/IObjectWrapper;Ljava/lang/Class;)Ljava/lang/Object;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				global::Java.Lang.Object __ret = (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallStaticObjectMethod  (class_ref, id_unwrap_Lcom_google_tango_loader_IObjectWrapper_Ljava_lang_Class_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_wrap_Ljava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.tango.loader']/class[@name='ObjectWrapper']/method[@name='wrap' and count(parameter)=1 and parameter[1][@type='T']]"
		[Register ("wrap", "(Ljava/lang/Object;)Lcom/google/tango/loader/IObjectWrapper;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
		public static unsafe global::Com.Google.Tango.Loader.IObjectWrapper Wrap (global::Java.Lang.Object p0)
		{
			if (id_wrap_Ljava_lang_Object_ == IntPtr.Zero)
				id_wrap_Ljava_lang_Object_ = JNIEnv.GetStaticMethodID (class_ref, "wrap", "(Ljava/lang/Object;)Lcom/google/tango/loader/IObjectWrapper;");
			IntPtr native_p0 = JNIEnv.ToLocalJniHandle (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				global::Com.Google.Tango.Loader.IObjectWrapper __ret = global::Java.Lang.Object.GetObject<global::Com.Google.Tango.Loader.IObjectWrapper> (JNIEnv.CallStaticObjectMethod  (class_ref, id_wrap_Ljava_lang_Object_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

	}
}
