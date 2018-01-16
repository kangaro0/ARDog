using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Google.Atap.Tango.Mesh.IO.Primitives {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.google.atap.tango.mesh.io.primitives']/class[@name='CubeTangoMesh']"
	[global::Android.Runtime.Register ("com/google/atap/tango/mesh/io/primitives/CubeTangoMesh", DoNotGenerateAcw=true)]
	public partial class CubeTangoMesh : global::Com.Google.Atap.Tango.Mesh.TangoMesh {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/google/atap/tango/mesh/io/primitives/CubeTangoMesh", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (CubeTangoMesh); }
		}

		protected CubeTangoMesh (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.google.atap.tango.mesh.io.primitives']/class[@name='CubeTangoMesh']/constructor[@name='CubeTangoMesh' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe CubeTangoMesh ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (CubeTangoMesh)) {
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

		static IntPtr id_ctor_ZZI;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.google.atap.tango.mesh.io.primitives']/class[@name='CubeTangoMesh']/constructor[@name='CubeTangoMesh' and count(parameter)=3 and parameter[1][@type='boolean'] and parameter[2][@type='boolean'] and parameter[3][@type='int']]"
		[Register (".ctor", "(ZZI)V", "")]
		public unsafe CubeTangoMesh (bool p0, bool p1, int p2)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				if (GetType () != typeof (CubeTangoMesh)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(ZZI)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(ZZI)V", __args);
					return;
				}

				if (id_ctor_ZZI == IntPtr.Zero)
					id_ctor_ZZI = JNIEnv.GetMethodID (class_ref, "<init>", "(ZZI)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_ZZI, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_ZZI, __args);
			} finally {
			}
		}

	}
}
