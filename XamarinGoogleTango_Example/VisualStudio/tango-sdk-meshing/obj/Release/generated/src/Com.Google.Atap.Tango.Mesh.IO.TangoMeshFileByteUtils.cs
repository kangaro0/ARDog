using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Google.Atap.Tango.Mesh.IO {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.google.atap.tango.mesh.io']/class[@name='TangoMeshFileByteUtils']"
	[global::Android.Runtime.Register ("com/google/atap/tango/mesh/io/TangoMeshFileByteUtils", DoNotGenerateAcw=true)]
	public partial class TangoMeshFileByteUtils : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/google/atap/tango/mesh/io/TangoMeshFileByteUtils", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (TangoMeshFileByteUtils); }
		}

		protected TangoMeshFileByteUtils (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.google.atap.tango.mesh.io']/class[@name='TangoMeshFileByteUtils']/constructor[@name='TangoMeshFileByteUtils' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe TangoMeshFileByteUtils ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (TangoMeshFileByteUtils)) {
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

		static IntPtr id_convertFloatColorToUByte_F;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.atap.tango.mesh.io']/class[@name='TangoMeshFileByteUtils']/method[@name='convertFloatColorToUByte' and count(parameter)=1 and parameter[1][@type='float']]"
		[Register ("convertFloatColorToUByte", "(F)B", "")]
		public static unsafe sbyte ConvertFloatColorToUByte (float p0)
		{
			if (id_convertFloatColorToUByte_F == IntPtr.Zero)
				id_convertFloatColorToUByte_F = JNIEnv.GetStaticMethodID (class_ref, "convertFloatColorToUByte", "(F)B");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				return JNIEnv.CallStaticByteMethod  (class_ref, id_convertFloatColorToUByte_F, __args);
			} finally {
			}
		}

		static IntPtr id_convertUByteToFloat_B;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.atap.tango.mesh.io']/class[@name='TangoMeshFileByteUtils']/method[@name='convertUByteToFloat' and count(parameter)=1 and parameter[1][@type='byte']]"
		[Register ("convertUByteToFloat", "(B)F", "")]
		public static unsafe float ConvertUByteToFloat (sbyte p0)
		{
			if (id_convertUByteToFloat_B == IntPtr.Zero)
				id_convertUByteToFloat_B = JNIEnv.GetStaticMethodID (class_ref, "convertUByteToFloat", "(B)F");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				return JNIEnv.CallStaticFloatMethod  (class_ref, id_convertUByteToFloat_B, __args);
			} finally {
			}
		}

		static IntPtr id_formatBytes_J;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.atap.tango.mesh.io']/class[@name='TangoMeshFileByteUtils']/method[@name='formatBytes' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("formatBytes", "(J)Ljava/lang/String;", "")]
		public static unsafe string FormatBytes (long p0)
		{
			if (id_formatBytes_J == IntPtr.Zero)
				id_formatBytes_J = JNIEnv.GetStaticMethodID (class_ref, "formatBytes", "(J)Ljava/lang/String;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				return JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_formatBytes_J, __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_formatBytes_JZ;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.atap.tango.mesh.io']/class[@name='TangoMeshFileByteUtils']/method[@name='formatBytes' and count(parameter)=2 and parameter[1][@type='long'] and parameter[2][@type='boolean']]"
		[Register ("formatBytes", "(JZ)Ljava/lang/String;", "")]
		public static unsafe string FormatBytes (long p0, bool p1)
		{
			if (id_formatBytes_JZ == IntPtr.Zero)
				id_formatBytes_JZ = JNIEnv.GetStaticMethodID (class_ref, "formatBytes", "(JZ)Ljava/lang/String;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				return JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_formatBytes_JZ, __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}
