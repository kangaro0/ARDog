using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Google.Atap.Tango.Mesh.IO {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.google.atap.tango.mesh.io']/interface[@name='TangoMeshFileWriter']"
	[Register ("com/google/atap/tango/mesh/io/TangoMeshFileWriter", "", "Com.Google.Atap.Tango.Mesh.IO.ITangoMeshFileWriterInvoker")]
	public partial interface ITangoMeshFileWriter : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.atap.tango.mesh.io']/interface[@name='TangoMeshFileWriter']/method[@name='calculateMeshFileSizeInBytes' and count(parameter)=1 and parameter[1][@type='com.google.atap.tango.mesh.TangoMesh']]"
		[Register ("calculateMeshFileSizeInBytes", "(Lcom/google/atap/tango/mesh/TangoMesh;)J", "GetCalculateMeshFileSizeInBytes_Lcom_google_atap_tango_mesh_TangoMesh_Handler:Com.Google.Atap.Tango.Mesh.IO.ITangoMeshFileWriterInvoker, tango-sdk-meshing")]
		long CalculateMeshFileSizeInBytes (global::Com.Google.Atap.Tango.Mesh.TangoMesh p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.atap.tango.mesh.io']/interface[@name='TangoMeshFileWriter']/method[@name='writeMesh' and count(parameter)=3 and parameter[1][@type='com.google.atap.tango.mesh.TangoMesh'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='com.google.atap.tango.mesh.io.TangoMeshIOProgressListener']]"
		[Register ("writeMesh", "(Lcom/google/atap/tango/mesh/TangoMesh;Ljava/lang/String;Lcom/google/atap/tango/mesh/io/TangoMeshIOProgressListener;)V", "GetWriteMesh_Lcom_google_atap_tango_mesh_TangoMesh_Ljava_lang_String_Lcom_google_atap_tango_mesh_io_TangoMeshIOProgressListener_Handler:Com.Google.Atap.Tango.Mesh.IO.ITangoMeshFileWriterInvoker, tango-sdk-meshing")]
		void WriteMesh (global::Com.Google.Atap.Tango.Mesh.TangoMesh p0, string p1, global::Com.Google.Atap.Tango.Mesh.IO.ITangoMeshIOProgressListener p2);

	}

	[global::Android.Runtime.Register ("com/google/atap/tango/mesh/io/TangoMeshFileWriter", DoNotGenerateAcw=true)]
	internal class ITangoMeshFileWriterInvoker : global::Java.Lang.Object, ITangoMeshFileWriter {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/google/atap/tango/mesh/io/TangoMeshFileWriter");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ITangoMeshFileWriterInvoker); }
		}

		IntPtr class_ref;

		public static ITangoMeshFileWriter GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<ITangoMeshFileWriter> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.google.atap.tango.mesh.io.TangoMeshFileWriter"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public ITangoMeshFileWriterInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
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
			global::Com.Google.Atap.Tango.Mesh.IO.ITangoMeshFileWriter __this = global::Java.Lang.Object.GetObject<global::Com.Google.Atap.Tango.Mesh.IO.ITangoMeshFileWriter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Google.Atap.Tango.Mesh.TangoMesh p0 = global::Java.Lang.Object.GetObject<global::Com.Google.Atap.Tango.Mesh.TangoMesh> (native_p0, JniHandleOwnership.DoNotTransfer);
			long __ret = __this.CalculateMeshFileSizeInBytes (p0);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_calculateMeshFileSizeInBytes_Lcom_google_atap_tango_mesh_TangoMesh_;
		public unsafe long CalculateMeshFileSizeInBytes (global::Com.Google.Atap.Tango.Mesh.TangoMesh p0)
		{
			if (id_calculateMeshFileSizeInBytes_Lcom_google_atap_tango_mesh_TangoMesh_ == IntPtr.Zero)
				id_calculateMeshFileSizeInBytes_Lcom_google_atap_tango_mesh_TangoMesh_ = JNIEnv.GetMethodID (class_ref, "calculateMeshFileSizeInBytes", "(Lcom/google/atap/tango/mesh/TangoMesh;)J");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			long __ret = JNIEnv.CallLongMethod (((global::Java.Lang.Object) this).Handle, id_calculateMeshFileSizeInBytes_Lcom_google_atap_tango_mesh_TangoMesh_, __args);
			return __ret;
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
			global::Com.Google.Atap.Tango.Mesh.IO.ITangoMeshFileWriter __this = global::Java.Lang.Object.GetObject<global::Com.Google.Atap.Tango.Mesh.IO.ITangoMeshFileWriter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Google.Atap.Tango.Mesh.TangoMesh p0 = global::Java.Lang.Object.GetObject<global::Com.Google.Atap.Tango.Mesh.TangoMesh> (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			global::Com.Google.Atap.Tango.Mesh.IO.ITangoMeshIOProgressListener p2 = (global::Com.Google.Atap.Tango.Mesh.IO.ITangoMeshIOProgressListener)global::Java.Lang.Object.GetObject<global::Com.Google.Atap.Tango.Mesh.IO.ITangoMeshIOProgressListener> (native_p2, JniHandleOwnership.DoNotTransfer);
			__this.WriteMesh (p0, p1, p2);
		}
#pragma warning restore 0169

		IntPtr id_writeMesh_Lcom_google_atap_tango_mesh_TangoMesh_Ljava_lang_String_Lcom_google_atap_tango_mesh_io_TangoMeshIOProgressListener_;
		public unsafe void WriteMesh (global::Com.Google.Atap.Tango.Mesh.TangoMesh p0, string p1, global::Com.Google.Atap.Tango.Mesh.IO.ITangoMeshIOProgressListener p2)
		{
			if (id_writeMesh_Lcom_google_atap_tango_mesh_TangoMesh_Ljava_lang_String_Lcom_google_atap_tango_mesh_io_TangoMeshIOProgressListener_ == IntPtr.Zero)
				id_writeMesh_Lcom_google_atap_tango_mesh_TangoMesh_Ljava_lang_String_Lcom_google_atap_tango_mesh_io_TangoMeshIOProgressListener_ = JNIEnv.GetMethodID (class_ref, "writeMesh", "(Lcom/google/atap/tango/mesh/TangoMesh;Ljava/lang/String;Lcom/google/atap/tango/mesh/io/TangoMeshIOProgressListener;)V");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			JValue* __args = stackalloc JValue [3];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (native_p1);
			__args [2] = new JValue (p2);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_writeMesh_Lcom_google_atap_tango_mesh_TangoMesh_Ljava_lang_String_Lcom_google_atap_tango_mesh_io_TangoMeshIOProgressListener_, __args);
			JNIEnv.DeleteLocalRef (native_p1);
		}

	}

}
