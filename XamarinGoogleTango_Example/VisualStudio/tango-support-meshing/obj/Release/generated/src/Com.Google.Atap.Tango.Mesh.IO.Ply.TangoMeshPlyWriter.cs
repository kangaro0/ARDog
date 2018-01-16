using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Google.Atap.Tango.Mesh.IO.Ply {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.google.atap.tango.mesh.io.ply']/class[@name='TangoMeshPlyWriter']"
	[global::Android.Runtime.Register ("com/google/atap/tango/mesh/io/ply/TangoMeshPlyWriter", DoNotGenerateAcw=true)]
	public partial class TangoMeshPlyWriter : global::Java.Lang.Object, global::Com.Google.Atap.Tango.Mesh.IO.ITangoMeshFileWriter {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/google/atap/tango/mesh/io/ply/TangoMeshPlyWriter", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (TangoMeshPlyWriter); }
		}

		protected TangoMeshPlyWriter (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.google.atap.tango.mesh.io.ply']/class[@name='TangoMeshPlyWriter']/constructor[@name='TangoMeshPlyWriter' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe TangoMeshPlyWriter ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (TangoMeshPlyWriter)) {
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

		static Delegate cb_calculateMeshFileSizeInBytes_Lcom_google_atap_tango_mesh_TangoMesh_;
#pragma warning disable 0169
		static Delegate GetCalculateMeshFileSizeInBytes_Lcom_google_atap_tango_mesh_TangoMesh_Handler ()
		{
			if (cb_calculateMeshFileSizeInBytes_Lcom_google_atap_tango_mesh_TangoMesh_ == null)
				cb_calculateMeshFileSizeInBytes_Lcom_google_atap_tango_mesh_TangoMesh_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, long>) n_CalculateMeshFileSizeInBytes_Lcom_google_atap_tango_mesh_TangoMesh_);
			return cb_calculateMeshFileSizeInBytes_Lcom_google_atap_tango_mesh_TangoMesh_;
		}

		static long n_CalculateMeshFileSizeInBytes_Lcom_google_atap_tango_mesh_TangoMesh_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Google.Atap.Tango.Mesh.IO.Ply.TangoMeshPlyWriter __this = global::Java.Lang.Object.GetObject<global::Com.Google.Atap.Tango.Mesh.IO.Ply.TangoMeshPlyWriter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Google.Atap.Tango.Mesh.TangoMesh p0 = global::Java.Lang.Object.GetObject<global::Com.Google.Atap.Tango.Mesh.TangoMesh> (native_p0, JniHandleOwnership.DoNotTransfer);
			long __ret = __this.CalculateMeshFileSizeInBytes (p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_calculateMeshFileSizeInBytes_Lcom_google_atap_tango_mesh_TangoMesh_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.atap.tango.mesh.io.ply']/class[@name='TangoMeshPlyWriter']/method[@name='calculateMeshFileSizeInBytes' and count(parameter)=1 and parameter[1][@type='com.google.atap.tango.mesh.TangoMesh']]"
		[Register ("calculateMeshFileSizeInBytes", "(Lcom/google/atap/tango/mesh/TangoMesh;)J", "GetCalculateMeshFileSizeInBytes_Lcom_google_atap_tango_mesh_TangoMesh_Handler")]
		public virtual unsafe long CalculateMeshFileSizeInBytes (global::Com.Google.Atap.Tango.Mesh.TangoMesh p0)
		{
			if (id_calculateMeshFileSizeInBytes_Lcom_google_atap_tango_mesh_TangoMesh_ == IntPtr.Zero)
				id_calculateMeshFileSizeInBytes_Lcom_google_atap_tango_mesh_TangoMesh_ = JNIEnv.GetMethodID (class_ref, "calculateMeshFileSizeInBytes", "(Lcom/google/atap/tango/mesh/TangoMesh;)J");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				long __ret;
				if (GetType () == ThresholdType)
					__ret = JNIEnv.CallLongMethod (((global::Java.Lang.Object) this).Handle, id_calculateMeshFileSizeInBytes_Lcom_google_atap_tango_mesh_TangoMesh_, __args);
				else
					__ret = JNIEnv.CallNonvirtualLongMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "calculateMeshFileSizeInBytes", "(Lcom/google/atap/tango/mesh/TangoMesh;)J"), __args);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_writeMesh_Lcom_google_atap_tango_mesh_TangoMesh_Ljava_lang_String_Lcom_google_atap_tango_mesh_io_TangoMeshIOProgressListener_;
#pragma warning disable 0169
		static Delegate GetWriteMesh_Lcom_google_atap_tango_mesh_TangoMesh_Ljava_lang_String_Lcom_google_atap_tango_mesh_io_TangoMeshIOProgressListener_Handler ()
		{
			if (cb_writeMesh_Lcom_google_atap_tango_mesh_TangoMesh_Ljava_lang_String_Lcom_google_atap_tango_mesh_io_TangoMeshIOProgressListener_ == null)
				cb_writeMesh_Lcom_google_atap_tango_mesh_TangoMesh_Ljava_lang_String_Lcom_google_atap_tango_mesh_io_TangoMeshIOProgressListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_WriteMesh_Lcom_google_atap_tango_mesh_TangoMesh_Ljava_lang_String_Lcom_google_atap_tango_mesh_io_TangoMeshIOProgressListener_);
			return cb_writeMesh_Lcom_google_atap_tango_mesh_TangoMesh_Ljava_lang_String_Lcom_google_atap_tango_mesh_io_TangoMeshIOProgressListener_;
		}

		static void n_WriteMesh_Lcom_google_atap_tango_mesh_TangoMesh_Ljava_lang_String_Lcom_google_atap_tango_mesh_io_TangoMeshIOProgressListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			global::Com.Google.Atap.Tango.Mesh.IO.Ply.TangoMeshPlyWriter __this = global::Java.Lang.Object.GetObject<global::Com.Google.Atap.Tango.Mesh.IO.Ply.TangoMeshPlyWriter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Google.Atap.Tango.Mesh.TangoMesh p0 = global::Java.Lang.Object.GetObject<global::Com.Google.Atap.Tango.Mesh.TangoMesh> (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			global::Com.Google.Atap.Tango.Mesh.IO.ITangoMeshIOProgressListener p2 = (global::Com.Google.Atap.Tango.Mesh.IO.ITangoMeshIOProgressListener)global::Java.Lang.Object.GetObject<global::Com.Google.Atap.Tango.Mesh.IO.ITangoMeshIOProgressListener> (native_p2, JniHandleOwnership.DoNotTransfer);
			__this.WriteMesh (p0, p1, p2);
		}
#pragma warning restore 0169

		static IntPtr id_writeMesh_Lcom_google_atap_tango_mesh_TangoMesh_Ljava_lang_String_Lcom_google_atap_tango_mesh_io_TangoMeshIOProgressListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.atap.tango.mesh.io.ply']/class[@name='TangoMeshPlyWriter']/method[@name='writeMesh' and count(parameter)=3 and parameter[1][@type='com.google.atap.tango.mesh.TangoMesh'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='com.google.atap.tango.mesh.io.TangoMeshIOProgressListener']]"
		[Register ("writeMesh", "(Lcom/google/atap/tango/mesh/TangoMesh;Ljava/lang/String;Lcom/google/atap/tango/mesh/io/TangoMeshIOProgressListener;)V", "GetWriteMesh_Lcom_google_atap_tango_mesh_TangoMesh_Ljava_lang_String_Lcom_google_atap_tango_mesh_io_TangoMeshIOProgressListener_Handler")]
		public virtual unsafe void WriteMesh (global::Com.Google.Atap.Tango.Mesh.TangoMesh p0, string p1, global::Com.Google.Atap.Tango.Mesh.IO.ITangoMeshIOProgressListener p2)
		{
			if (id_writeMesh_Lcom_google_atap_tango_mesh_TangoMesh_Ljava_lang_String_Lcom_google_atap_tango_mesh_io_TangoMeshIOProgressListener_ == IntPtr.Zero)
				id_writeMesh_Lcom_google_atap_tango_mesh_TangoMesh_Ljava_lang_String_Lcom_google_atap_tango_mesh_io_TangoMeshIOProgressListener_ = JNIEnv.GetMethodID (class_ref, "writeMesh", "(Lcom/google/atap/tango/mesh/TangoMesh;Ljava/lang/String;Lcom/google/atap/tango/mesh/io/TangoMeshIOProgressListener;)V");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (p2);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_writeMesh_Lcom_google_atap_tango_mesh_TangoMesh_Ljava_lang_String_Lcom_google_atap_tango_mesh_io_TangoMeshIOProgressListener_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "writeMesh", "(Lcom/google/atap/tango/mesh/TangoMesh;Ljava/lang/String;Lcom/google/atap/tango/mesh/io/TangoMeshIOProgressListener;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

	}
}
