using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Google.Atap.Tango.Mesh.IO {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.google.atap.tango.mesh.io']/class[@name='TangoMeshFileUtils']"
	[global::Android.Runtime.Register ("com/google/atap/tango/mesh/io/TangoMeshFileUtils", DoNotGenerateAcw=true)]
	public partial class TangoMeshFileUtils : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/google/atap/tango/mesh/io/TangoMeshFileUtils", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (TangoMeshFileUtils); }
		}

		protected TangoMeshFileUtils (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.google.atap.tango.mesh.io']/class[@name='TangoMeshFileUtils']/constructor[@name='TangoMeshFileUtils' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe TangoMeshFileUtils ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (TangoMeshFileUtils)) {
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

		static IntPtr id_getAvailablePartitionSizeInBytes_Ljava_io_File_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.atap.tango.mesh.io']/class[@name='TangoMeshFileUtils']/method[@name='getAvailablePartitionSizeInBytes' and count(parameter)=1 and parameter[1][@type='java.io.File']]"
		[Register ("getAvailablePartitionSizeInBytes", "(Ljava/io/File;)J", "")]
		public static unsafe long GetAvailablePartitionSizeInBytes (global::Java.IO.File p0)
		{
			if (id_getAvailablePartitionSizeInBytes_Ljava_io_File_ == IntPtr.Zero)
				id_getAvailablePartitionSizeInBytes_Ljava_io_File_ = JNIEnv.GetStaticMethodID (class_ref, "getAvailablePartitionSizeInBytes", "(Ljava/io/File;)J");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				long __ret = JNIEnv.CallStaticLongMethod  (class_ref, id_getAvailablePartitionSizeInBytes_Ljava_io_File_, __args);
				return __ret;
			} finally {
			}
		}

	}
}
