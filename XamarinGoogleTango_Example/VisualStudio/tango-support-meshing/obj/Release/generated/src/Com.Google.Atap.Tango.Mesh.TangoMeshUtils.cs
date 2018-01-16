using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Google.Atap.Tango.Mesh {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.google.atap.tango.mesh']/class[@name='TangoMeshUtils']"
	[global::Android.Runtime.Register ("com/google/atap/tango/mesh/TangoMeshUtils", DoNotGenerateAcw=true)]
	public partial class TangoMeshUtils : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/google/atap/tango/mesh/TangoMeshUtils", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (TangoMeshUtils); }
		}

		protected TangoMeshUtils (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.google.atap.tango.mesh']/class[@name='TangoMeshUtils']/constructor[@name='TangoMeshUtils' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe TangoMeshUtils ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (TangoMeshUtils)) {
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

		static IntPtr id_convertRGBAtoRGB_Ljava_nio_ByteBuffer_II;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.atap.tango.mesh']/class[@name='TangoMeshUtils']/method[@name='convertRGBAtoRGB' and count(parameter)=3 and parameter[1][@type='java.nio.ByteBuffer'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
		[Register ("convertRGBAtoRGB", "(Ljava/nio/ByteBuffer;II)Ljava/nio/ByteBuffer;", "")]
		public static unsafe global::Java.Nio.ByteBuffer ConvertRGBAtoRGB (global::Java.Nio.ByteBuffer p0, int p1, int p2)
		{
			if (id_convertRGBAtoRGB_Ljava_nio_ByteBuffer_II == IntPtr.Zero)
				id_convertRGBAtoRGB_Ljava_nio_ByteBuffer_II = JNIEnv.GetStaticMethodID (class_ref, "convertRGBAtoRGB", "(Ljava/nio/ByteBuffer;II)Ljava/nio/ByteBuffer;");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				global::Java.Nio.ByteBuffer __ret = global::Java.Lang.Object.GetObject<global::Java.Nio.ByteBuffer> (JNIEnv.CallStaticObjectMethod  (class_ref, id_convertRGBAtoRGB_Ljava_nio_ByteBuffer_II, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_convertRGBtoRGBA_Ljava_nio_ByteBuffer_II;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.atap.tango.mesh']/class[@name='TangoMeshUtils']/method[@name='convertRGBtoRGBA' and count(parameter)=3 and parameter[1][@type='java.nio.ByteBuffer'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
		[Register ("convertRGBtoRGBA", "(Ljava/nio/ByteBuffer;II)Ljava/nio/ByteBuffer;", "")]
		public static unsafe global::Java.Nio.ByteBuffer ConvertRGBtoRGBA (global::Java.Nio.ByteBuffer p0, int p1, int p2)
		{
			if (id_convertRGBtoRGBA_Ljava_nio_ByteBuffer_II == IntPtr.Zero)
				id_convertRGBtoRGBA_Ljava_nio_ByteBuffer_II = JNIEnv.GetStaticMethodID (class_ref, "convertRGBtoRGBA", "(Ljava/nio/ByteBuffer;II)Ljava/nio/ByteBuffer;");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				global::Java.Nio.ByteBuffer __ret = global::Java.Lang.Object.GetObject<global::Java.Nio.ByteBuffer> (JNIEnv.CallStaticObjectMethod  (class_ref, id_convertRGBtoRGBA_Ljava_nio_ByteBuffer_II, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_getAverageColor_Lcom_google_atap_tango_mesh_TangoMesh_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.atap.tango.mesh']/class[@name='TangoMeshUtils']/method[@name='getAverageColor' and count(parameter)=1 and parameter[1][@type='com.google.atap.tango.mesh.TangoMesh']]"
		[Register ("getAverageColor", "(Lcom/google/atap/tango/mesh/TangoMesh;)[F", "")]
		public static unsafe float[] GetAverageColor (global::Com.Google.Atap.Tango.Mesh.TangoMesh p0)
		{
			if (id_getAverageColor_Lcom_google_atap_tango_mesh_TangoMesh_ == IntPtr.Zero)
				id_getAverageColor_Lcom_google_atap_tango_mesh_TangoMesh_ = JNIEnv.GetStaticMethodID (class_ref, "getAverageColor", "(Lcom/google/atap/tango/mesh/TangoMesh;)[F");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				float[] __ret = (float[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_getAverageColor_Lcom_google_atap_tango_mesh_TangoMesh_, __args), JniHandleOwnership.TransferLocalRef, typeof (float));
				return __ret;
			} finally {
			}
		}

		static IntPtr id_getMeshBoundingBox_Lcom_google_atap_tango_mesh_TangoMesh_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.atap.tango.mesh']/class[@name='TangoMeshUtils']/method[@name='getMeshBoundingBox' and count(parameter)=1 and parameter[1][@type='com.google.atap.tango.mesh.TangoMesh']]"
		[Register ("getMeshBoundingBox", "(Lcom/google/atap/tango/mesh/TangoMesh;)[F", "")]
		public static unsafe float[] GetMeshBoundingBox (global::Com.Google.Atap.Tango.Mesh.TangoMesh p0)
		{
			if (id_getMeshBoundingBox_Lcom_google_atap_tango_mesh_TangoMesh_ == IntPtr.Zero)
				id_getMeshBoundingBox_Lcom_google_atap_tango_mesh_TangoMesh_ = JNIEnv.GetStaticMethodID (class_ref, "getMeshBoundingBox", "(Lcom/google/atap/tango/mesh/TangoMesh;)[F");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				float[] __ret = (float[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_getMeshBoundingBox_Lcom_google_atap_tango_mesh_TangoMesh_, __args), JniHandleOwnership.TransferLocalRef, typeof (float));
				return __ret;
			} finally {
			}
		}

		static IntPtr id_mergeFaces_Ljava_nio_ByteBuffer_ILjava_nio_ByteBuffer_II;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.atap.tango.mesh']/class[@name='TangoMeshUtils']/method[@name='mergeFaces' and count(parameter)=5 and parameter[1][@type='java.nio.ByteBuffer'] and parameter[2][@type='int'] and parameter[3][@type='java.nio.ByteBuffer'] and parameter[4][@type='int'] and parameter[5][@type='int']]"
		[Register ("mergeFaces", "(Ljava/nio/ByteBuffer;ILjava/nio/ByteBuffer;II)Ljava/nio/ByteBuffer;", "")]
		public static unsafe global::Java.Nio.ByteBuffer MergeFaces (global::Java.Nio.ByteBuffer p0, int p1, global::Java.Nio.ByteBuffer p2, int p3, int p4)
		{
			if (id_mergeFaces_Ljava_nio_ByteBuffer_ILjava_nio_ByteBuffer_II == IntPtr.Zero)
				id_mergeFaces_Ljava_nio_ByteBuffer_ILjava_nio_ByteBuffer_II = JNIEnv.GetStaticMethodID (class_ref, "mergeFaces", "(Ljava/nio/ByteBuffer;ILjava/nio/ByteBuffer;II)Ljava/nio/ByteBuffer;");
			try {
				JValue* __args = stackalloc JValue [5];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				__args [4] = new JValue (p4);
				global::Java.Nio.ByteBuffer __ret = global::Java.Lang.Object.GetObject<global::Java.Nio.ByteBuffer> (JNIEnv.CallStaticObjectMethod  (class_ref, id_mergeFaces_Ljava_nio_ByteBuffer_ILjava_nio_ByteBuffer_II, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_mergeMeshes_arrayLcom_google_atap_tango_mesh_TangoMesh_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.atap.tango.mesh']/class[@name='TangoMeshUtils']/method[@name='mergeMeshes' and count(parameter)=1 and parameter[1][@type='com.google.atap.tango.mesh.TangoMesh[]']]"
		[Register ("mergeMeshes", "([Lcom/google/atap/tango/mesh/TangoMesh;)Lcom/google/atap/tango/mesh/TangoMesh;", "")]
		public static unsafe global::Com.Google.Atap.Tango.Mesh.TangoMesh MergeMeshes (global::Com.Google.Atap.Tango.Mesh.TangoMesh[] p0)
		{
			if (id_mergeMeshes_arrayLcom_google_atap_tango_mesh_TangoMesh_ == IntPtr.Zero)
				id_mergeMeshes_arrayLcom_google_atap_tango_mesh_TangoMesh_ = JNIEnv.GetStaticMethodID (class_ref, "mergeMeshes", "([Lcom/google/atap/tango/mesh/TangoMesh;)Lcom/google/atap/tango/mesh/TangoMesh;");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				global::Com.Google.Atap.Tango.Mesh.TangoMesh __ret = global::Java.Lang.Object.GetObject<global::Com.Google.Atap.Tango.Mesh.TangoMesh> (JNIEnv.CallStaticObjectMethod  (class_ref, id_mergeMeshes_arrayLcom_google_atap_tango_mesh_TangoMesh_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}
		}

		static IntPtr id_releaseMesh_Lcom_google_atap_tango_mesh_TangoMesh_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.atap.tango.mesh']/class[@name='TangoMeshUtils']/method[@name='releaseMesh' and count(parameter)=1 and parameter[1][@type='com.google.atap.tango.mesh.TangoMesh']]"
		[Register ("releaseMesh", "(Lcom/google/atap/tango/mesh/TangoMesh;)V", "")]
		public static unsafe void ReleaseMesh (global::Com.Google.Atap.Tango.Mesh.TangoMesh p0)
		{
			if (id_releaseMesh_Lcom_google_atap_tango_mesh_TangoMesh_ == IntPtr.Zero)
				id_releaseMesh_Lcom_google_atap_tango_mesh_TangoMesh_ = JNIEnv.GetStaticMethodID (class_ref, "releaseMesh", "(Lcom/google/atap/tango/mesh/TangoMesh;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_releaseMesh_Lcom_google_atap_tango_mesh_TangoMesh_, __args);
			} finally {
			}
		}

	}
}
