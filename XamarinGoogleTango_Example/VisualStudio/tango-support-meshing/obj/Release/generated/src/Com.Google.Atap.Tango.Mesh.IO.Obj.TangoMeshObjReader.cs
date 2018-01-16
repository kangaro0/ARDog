using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Google.Atap.Tango.Mesh.IO.Obj {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.google.atap.tango.mesh.io.obj']/class[@name='TangoMeshObjReader']"
	[global::Android.Runtime.Register ("com/google/atap/tango/mesh/io/obj/TangoMeshObjReader", DoNotGenerateAcw=true)]
	public partial class TangoMeshObjReader : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/google/atap/tango/mesh/io/obj/TangoMeshObjReader", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (TangoMeshObjReader); }
		}

		protected TangoMeshObjReader (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.google.atap.tango.mesh.io.obj']/class[@name='TangoMeshObjReader']/constructor[@name='TangoMeshObjReader' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe TangoMeshObjReader ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (TangoMeshObjReader)) {
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

		static Delegate cb_loadMesh_Ljava_lang_String_Lcom_google_atap_tango_mesh_io_TangoMeshIOProgressListener_;
#pragma warning disable 0169
		static Delegate GetLoadMesh_Ljava_lang_String_Lcom_google_atap_tango_mesh_io_TangoMeshIOProgressListener_Handler ()
		{
			if (cb_loadMesh_Ljava_lang_String_Lcom_google_atap_tango_mesh_io_TangoMeshIOProgressListener_ == null)
				cb_loadMesh_Ljava_lang_String_Lcom_google_atap_tango_mesh_io_TangoMeshIOProgressListener_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_LoadMesh_Ljava_lang_String_Lcom_google_atap_tango_mesh_io_TangoMeshIOProgressListener_);
			return cb_loadMesh_Ljava_lang_String_Lcom_google_atap_tango_mesh_io_TangoMeshIOProgressListener_;
		}

		static IntPtr n_LoadMesh_Ljava_lang_String_Lcom_google_atap_tango_mesh_io_TangoMeshIOProgressListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Google.Atap.Tango.Mesh.IO.Obj.TangoMeshObjReader __this = global::Java.Lang.Object.GetObject<global::Com.Google.Atap.Tango.Mesh.IO.Obj.TangoMeshObjReader> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Google.Atap.Tango.Mesh.IO.ITangoMeshIOProgressListener p1 = (global::Com.Google.Atap.Tango.Mesh.IO.ITangoMeshIOProgressListener)global::Java.Lang.Object.GetObject<global::Com.Google.Atap.Tango.Mesh.IO.ITangoMeshIOProgressListener> (native_p1, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.LoadMesh (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_loadMesh_Ljava_lang_String_Lcom_google_atap_tango_mesh_io_TangoMeshIOProgressListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.atap.tango.mesh.io.obj']/class[@name='TangoMeshObjReader']/method[@name='loadMesh' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='com.google.atap.tango.mesh.io.TangoMeshIOProgressListener']]"
		[Register ("loadMesh", "(Ljava/lang/String;Lcom/google/atap/tango/mesh/io/TangoMeshIOProgressListener;)Lcom/google/atap/tango/mesh/TangoMesh;", "GetLoadMesh_Ljava_lang_String_Lcom_google_atap_tango_mesh_io_TangoMeshIOProgressListener_Handler")]
		public virtual unsafe global::Com.Google.Atap.Tango.Mesh.TangoMesh LoadMesh (string p0, global::Com.Google.Atap.Tango.Mesh.IO.ITangoMeshIOProgressListener p1)
		{
			if (id_loadMesh_Ljava_lang_String_Lcom_google_atap_tango_mesh_io_TangoMeshIOProgressListener_ == IntPtr.Zero)
				id_loadMesh_Ljava_lang_String_Lcom_google_atap_tango_mesh_io_TangoMeshIOProgressListener_ = JNIEnv.GetMethodID (class_ref, "loadMesh", "(Ljava/lang/String;Lcom/google/atap/tango/mesh/io/TangoMeshIOProgressListener;)Lcom/google/atap/tango/mesh/TangoMesh;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);

				global::Com.Google.Atap.Tango.Mesh.TangoMesh __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Google.Atap.Tango.Mesh.TangoMesh> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_loadMesh_Ljava_lang_String_Lcom_google_atap_tango_mesh_io_TangoMeshIOProgressListener_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Google.Atap.Tango.Mesh.TangoMesh> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "loadMesh", "(Ljava/lang/String;Lcom/google/atap/tango/mesh/io/TangoMeshIOProgressListener;)Lcom/google/atap/tango/mesh/TangoMesh;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

	}
}
