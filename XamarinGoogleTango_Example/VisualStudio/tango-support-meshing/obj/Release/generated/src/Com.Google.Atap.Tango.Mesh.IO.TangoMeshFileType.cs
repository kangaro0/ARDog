using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Google.Atap.Tango.Mesh.IO {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.google.atap.tango.mesh.io']/class[@name='TangoMeshFileType']"
	[global::Android.Runtime.Register ("com/google/atap/tango/mesh/io/TangoMeshFileType", DoNotGenerateAcw=true)]
	public sealed partial class TangoMeshFileType : global::Java.Lang.Object {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.atap.tango.mesh.io']/class[@name='TangoMeshFileType']/field[@name='OBJ']"
		[Register ("OBJ")]
		public const int Obj = (int) 0;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.atap.tango.mesh.io']/class[@name='TangoMeshFileType']/field[@name='PLY']"
		[Register ("PLY")]
		public const int Ply = (int) 1;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.atap.tango.mesh.io']/class[@name='TangoMeshFileType']/field[@name='UNSUPPORTED_EXTENSION']"
		[Register ("UNSUPPORTED_EXTENSION")]
		public const int UnsupportedExtension = (int) -1;
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/google/atap/tango/mesh/io/TangoMeshFileType", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (TangoMeshFileType); }
		}

		internal TangoMeshFileType (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_getFileExtension_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.atap.tango.mesh.io']/class[@name='TangoMeshFileType']/method[@name='getFileExtension' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("getFileExtension", "(I)Ljava/lang/String;", "")]
		public static unsafe string GetFileExtension (int p0)
		{
			if (id_getFileExtension_I == IntPtr.Zero)
				id_getFileExtension_I = JNIEnv.GetStaticMethodID (class_ref, "getFileExtension", "(I)Ljava/lang/String;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				return JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_getFileExtension_I, __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_getFileExtension_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.atap.tango.mesh.io']/class[@name='TangoMeshFileType']/method[@name='getFileExtension' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getFileExtension", "(Ljava/lang/String;)I", "")]
		public static unsafe int GetFileExtension (string p0)
		{
			if (id_getFileExtension_Ljava_lang_String_ == IntPtr.Zero)
				id_getFileExtension_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "getFileExtension", "(Ljava/lang/String;)I");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				int __ret = JNIEnv.CallStaticIntMethod  (class_ref, id_getFileExtension_Ljava_lang_String_, __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_getSupportedFileTypeExtensions;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.atap.tango.mesh.io']/class[@name='TangoMeshFileType']/method[@name='getSupportedFileTypeExtensions' and count(parameter)=0]"
		[Register ("getSupportedFileTypeExtensions", "()[Ljava/lang/String;", "")]
		public static unsafe string[] GetSupportedFileTypeExtensions ()
		{
			if (id_getSupportedFileTypeExtensions == IntPtr.Zero)
				id_getSupportedFileTypeExtensions = JNIEnv.GetStaticMethodID (class_ref, "getSupportedFileTypeExtensions", "()[Ljava/lang/String;");
			try {
				return (string[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_getSupportedFileTypeExtensions), JniHandleOwnership.TransferLocalRef, typeof (string));
			} finally {
			}
		}

	}
}
