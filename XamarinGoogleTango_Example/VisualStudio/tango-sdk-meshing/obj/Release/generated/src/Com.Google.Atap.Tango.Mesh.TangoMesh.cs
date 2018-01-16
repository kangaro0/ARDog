using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Google.Atap.Tango.Mesh {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.google.atap.tango.mesh']/class[@name='TangoMesh']"
	[global::Android.Runtime.Register ("com/google/atap/tango/mesh/TangoMesh", DoNotGenerateAcw=true)]
	public partial class TangoMesh : global::Java.Lang.Object {


		static IntPtr colors_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.atap.tango.mesh']/class[@name='TangoMesh']/field[@name='colors']"
		[Register ("colors")]
		public global::Java.Nio.ByteBuffer Colors {
			get {
				if (colors_jfieldId == IntPtr.Zero)
					colors_jfieldId = JNIEnv.GetFieldID (class_ref, "colors", "Ljava/nio/ByteBuffer;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, colors_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Java.Nio.ByteBuffer> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (colors_jfieldId == IntPtr.Zero)
					colors_jfieldId = JNIEnv.GetFieldID (class_ref, "colors", "Ljava/nio/ByteBuffer;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, colors_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr faceGroups_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.atap.tango.mesh']/class[@name='TangoMesh']/field[@name='faceGroups']"
		[Register ("faceGroups")]
		public IList<Com.Google.Atap.Tango.Mesh.TangoMeshFaceGroup> FaceGroups {
			get {
				if (faceGroups_jfieldId == IntPtr.Zero)
					faceGroups_jfieldId = JNIEnv.GetFieldID (class_ref, "faceGroups", "[Lcom/google/atap/tango/mesh/TangoMeshFaceGroup;");
				return global::Android.Runtime.JavaArray<global::Com.Google.Atap.Tango.Mesh.TangoMeshFaceGroup>.FromJniHandle (JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, faceGroups_jfieldId), JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (faceGroups_jfieldId == IntPtr.Zero)
					faceGroups_jfieldId = JNIEnv.GetFieldID (class_ref, "faceGroups", "[Lcom/google/atap/tango/mesh/TangoMeshFaceGroup;");
				IntPtr native_value = global::Android.Runtime.JavaArray<global::Com.Google.Atap.Tango.Mesh.TangoMeshFaceGroup>.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, faceGroups_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr faces_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.atap.tango.mesh']/class[@name='TangoMesh']/field[@name='faces']"
		[Register ("faces")]
		public global::Java.Nio.IntBuffer Faces {
			get {
				if (faces_jfieldId == IntPtr.Zero)
					faces_jfieldId = JNIEnv.GetFieldID (class_ref, "faces", "Ljava/nio/IntBuffer;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, faces_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Java.Nio.IntBuffer> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (faces_jfieldId == IntPtr.Zero)
					faces_jfieldId = JNIEnv.GetFieldID (class_ref, "faces", "Ljava/nio/IntBuffer;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, faces_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr facesByteBuffer_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.atap.tango.mesh']/class[@name='TangoMesh']/field[@name='facesByteBuffer']"
		[Register ("facesByteBuffer")]
		public global::Java.Nio.ByteBuffer FacesByteBuffer {
			get {
				if (facesByteBuffer_jfieldId == IntPtr.Zero)
					facesByteBuffer_jfieldId = JNIEnv.GetFieldID (class_ref, "facesByteBuffer", "Ljava/nio/ByteBuffer;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, facesByteBuffer_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Java.Nio.ByteBuffer> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (facesByteBuffer_jfieldId == IntPtr.Zero)
					facesByteBuffer_jfieldId = JNIEnv.GetFieldID (class_ref, "facesByteBuffer", "Ljava/nio/ByteBuffer;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, facesByteBuffer_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr hasColors_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.atap.tango.mesh']/class[@name='TangoMesh']/field[@name='hasColors']"
		[Register ("hasColors")]
		public bool HasColors {
			get {
				if (hasColors_jfieldId == IntPtr.Zero)
					hasColors_jfieldId = JNIEnv.GetFieldID (class_ref, "hasColors", "Z");
				return JNIEnv.GetBooleanField (((global::Java.Lang.Object) this).Handle, hasColors_jfieldId);
			}
			set {
				if (hasColors_jfieldId == IntPtr.Zero)
					hasColors_jfieldId = JNIEnv.GetFieldID (class_ref, "hasColors", "Z");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, hasColors_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr hasNormals_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.atap.tango.mesh']/class[@name='TangoMesh']/field[@name='hasNormals']"
		[Register ("hasNormals")]
		public bool HasNormals {
			get {
				if (hasNormals_jfieldId == IntPtr.Zero)
					hasNormals_jfieldId = JNIEnv.GetFieldID (class_ref, "hasNormals", "Z");
				return JNIEnv.GetBooleanField (((global::Java.Lang.Object) this).Handle, hasNormals_jfieldId);
			}
			set {
				if (hasNormals_jfieldId == IntPtr.Zero)
					hasNormals_jfieldId = JNIEnv.GetFieldID (class_ref, "hasNormals", "Z");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, hasNormals_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr hasTexCoords_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.atap.tango.mesh']/class[@name='TangoMesh']/field[@name='hasTexCoords']"
		[Register ("hasTexCoords")]
		public bool HasTexCoords {
			get {
				if (hasTexCoords_jfieldId == IntPtr.Zero)
					hasTexCoords_jfieldId = JNIEnv.GetFieldID (class_ref, "hasTexCoords", "Z");
				return JNIEnv.GetBooleanField (((global::Java.Lang.Object) this).Handle, hasTexCoords_jfieldId);
			}
			set {
				if (hasTexCoords_jfieldId == IntPtr.Zero)
					hasTexCoords_jfieldId = JNIEnv.GetFieldID (class_ref, "hasTexCoords", "Z");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, hasTexCoords_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr hasTextures_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.atap.tango.mesh']/class[@name='TangoMesh']/field[@name='hasTextures']"
		[Register ("hasTextures")]
		public bool HasTextures {
			get {
				if (hasTextures_jfieldId == IntPtr.Zero)
					hasTextures_jfieldId = JNIEnv.GetFieldID (class_ref, "hasTextures", "Z");
				return JNIEnv.GetBooleanField (((global::Java.Lang.Object) this).Handle, hasTextures_jfieldId);
			}
			set {
				if (hasTextures_jfieldId == IntPtr.Zero)
					hasTextures_jfieldId = JNIEnv.GetFieldID (class_ref, "hasTextures", "Z");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, hasTextures_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr index_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.atap.tango.mesh']/class[@name='TangoMesh']/field[@name='index']"
		[Register ("index")]
		public IList<int> Index {
			get {
				if (index_jfieldId == IntPtr.Zero)
					index_jfieldId = JNIEnv.GetFieldID (class_ref, "index", "[I");
				return global::Android.Runtime.JavaArray<int>.FromJniHandle (JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, index_jfieldId), JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (index_jfieldId == IntPtr.Zero)
					index_jfieldId = JNIEnv.GetFieldID (class_ref, "index", "[I");
				IntPtr native_value = global::Android.Runtime.JavaArray<int>.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, index_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr mNativeHandle_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.atap.tango.mesh']/class[@name='TangoMesh']/field[@name='mNativeHandle']"
		[Register ("mNativeHandle")]
		public long MNativeHandle {
			get {
				if (mNativeHandle_jfieldId == IntPtr.Zero)
					mNativeHandle_jfieldId = JNIEnv.GetFieldID (class_ref, "mNativeHandle", "J");
				return JNIEnv.GetLongField (((global::Java.Lang.Object) this).Handle, mNativeHandle_jfieldId);
			}
			set {
				if (mNativeHandle_jfieldId == IntPtr.Zero)
					mNativeHandle_jfieldId = JNIEnv.GetFieldID (class_ref, "mNativeHandle", "J");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, mNativeHandle_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr normals_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.atap.tango.mesh']/class[@name='TangoMesh']/field[@name='normals']"
		[Register ("normals")]
		public global::Java.Nio.FloatBuffer Normals {
			get {
				if (normals_jfieldId == IntPtr.Zero)
					normals_jfieldId = JNIEnv.GetFieldID (class_ref, "normals", "Ljava/nio/FloatBuffer;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, normals_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Java.Nio.FloatBuffer> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (normals_jfieldId == IntPtr.Zero)
					normals_jfieldId = JNIEnv.GetFieldID (class_ref, "normals", "Ljava/nio/FloatBuffer;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, normals_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr normalsByteBuffer_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.atap.tango.mesh']/class[@name='TangoMesh']/field[@name='normalsByteBuffer']"
		[Register ("normalsByteBuffer")]
		public global::Java.Nio.ByteBuffer NormalsByteBuffer {
			get {
				if (normalsByteBuffer_jfieldId == IntPtr.Zero)
					normalsByteBuffer_jfieldId = JNIEnv.GetFieldID (class_ref, "normalsByteBuffer", "Ljava/nio/ByteBuffer;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, normalsByteBuffer_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Java.Nio.ByteBuffer> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (normalsByteBuffer_jfieldId == IntPtr.Zero)
					normalsByteBuffer_jfieldId = JNIEnv.GetFieldID (class_ref, "normalsByteBuffer", "Ljava/nio/ByteBuffer;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, normalsByteBuffer_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr numColorChannels_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.atap.tango.mesh']/class[@name='TangoMesh']/field[@name='numColorChannels']"
		[Register ("numColorChannels")]
		public int NumColorChannels {
			get {
				if (numColorChannels_jfieldId == IntPtr.Zero)
					numColorChannels_jfieldId = JNIEnv.GetFieldID (class_ref, "numColorChannels", "I");
				return JNIEnv.GetIntField (((global::Java.Lang.Object) this).Handle, numColorChannels_jfieldId);
			}
			set {
				if (numColorChannels_jfieldId == IntPtr.Zero)
					numColorChannels_jfieldId = JNIEnv.GetFieldID (class_ref, "numColorChannels", "I");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, numColorChannels_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr numFaces_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.atap.tango.mesh']/class[@name='TangoMesh']/field[@name='numFaces']"
		[Register ("numFaces")]
		public int NumFaces {
			get {
				if (numFaces_jfieldId == IntPtr.Zero)
					numFaces_jfieldId = JNIEnv.GetFieldID (class_ref, "numFaces", "I");
				return JNIEnv.GetIntField (((global::Java.Lang.Object) this).Handle, numFaces_jfieldId);
			}
			set {
				if (numFaces_jfieldId == IntPtr.Zero)
					numFaces_jfieldId = JNIEnv.GetFieldID (class_ref, "numFaces", "I");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, numFaces_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr numVertices_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.atap.tango.mesh']/class[@name='TangoMesh']/field[@name='numVertices']"
		[Register ("numVertices")]
		public int NumVertices {
			get {
				if (numVertices_jfieldId == IntPtr.Zero)
					numVertices_jfieldId = JNIEnv.GetFieldID (class_ref, "numVertices", "I");
				return JNIEnv.GetIntField (((global::Java.Lang.Object) this).Handle, numVertices_jfieldId);
			}
			set {
				if (numVertices_jfieldId == IntPtr.Zero)
					numVertices_jfieldId = JNIEnv.GetFieldID (class_ref, "numVertices", "I");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, numVertices_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr texCoords_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.atap.tango.mesh']/class[@name='TangoMesh']/field[@name='texCoords']"
		[Register ("texCoords")]
		public global::Java.Nio.FloatBuffer TexCoords {
			get {
				if (texCoords_jfieldId == IntPtr.Zero)
					texCoords_jfieldId = JNIEnv.GetFieldID (class_ref, "texCoords", "Ljava/nio/FloatBuffer;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, texCoords_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Java.Nio.FloatBuffer> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (texCoords_jfieldId == IntPtr.Zero)
					texCoords_jfieldId = JNIEnv.GetFieldID (class_ref, "texCoords", "Ljava/nio/FloatBuffer;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, texCoords_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr texCoordsByteBuffer_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.atap.tango.mesh']/class[@name='TangoMesh']/field[@name='texCoordsByteBuffer']"
		[Register ("texCoordsByteBuffer")]
		public global::Java.Nio.ByteBuffer TexCoordsByteBuffer {
			get {
				if (texCoordsByteBuffer_jfieldId == IntPtr.Zero)
					texCoordsByteBuffer_jfieldId = JNIEnv.GetFieldID (class_ref, "texCoordsByteBuffer", "Ljava/nio/ByteBuffer;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, texCoordsByteBuffer_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Java.Nio.ByteBuffer> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (texCoordsByteBuffer_jfieldId == IntPtr.Zero)
					texCoordsByteBuffer_jfieldId = JNIEnv.GetFieldID (class_ref, "texCoordsByteBuffer", "Ljava/nio/ByteBuffer;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, texCoordsByteBuffer_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr textures_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.atap.tango.mesh']/class[@name='TangoMesh']/field[@name='textures']"
		[Register ("textures")]
		public IList<Com.Google.Atap.Tango.Mesh.TangoTexture> Textures {
			get {
				if (textures_jfieldId == IntPtr.Zero)
					textures_jfieldId = JNIEnv.GetFieldID (class_ref, "textures", "[Lcom/google/atap/tango/mesh/TangoTexture;");
				return global::Android.Runtime.JavaArray<global::Com.Google.Atap.Tango.Mesh.TangoTexture>.FromJniHandle (JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, textures_jfieldId), JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (textures_jfieldId == IntPtr.Zero)
					textures_jfieldId = JNIEnv.GetFieldID (class_ref, "textures", "[Lcom/google/atap/tango/mesh/TangoTexture;");
				IntPtr native_value = global::Android.Runtime.JavaArray<global::Com.Google.Atap.Tango.Mesh.TangoTexture>.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, textures_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr vertices_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.atap.tango.mesh']/class[@name='TangoMesh']/field[@name='vertices']"
		[Register ("vertices")]
		public global::Java.Nio.FloatBuffer Vertices {
			get {
				if (vertices_jfieldId == IntPtr.Zero)
					vertices_jfieldId = JNIEnv.GetFieldID (class_ref, "vertices", "Ljava/nio/FloatBuffer;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, vertices_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Java.Nio.FloatBuffer> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (vertices_jfieldId == IntPtr.Zero)
					vertices_jfieldId = JNIEnv.GetFieldID (class_ref, "vertices", "Ljava/nio/FloatBuffer;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, vertices_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr verticesByteBuffer_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.atap.tango.mesh']/class[@name='TangoMesh']/field[@name='verticesByteBuffer']"
		[Register ("verticesByteBuffer")]
		public global::Java.Nio.ByteBuffer VerticesByteBuffer {
			get {
				if (verticesByteBuffer_jfieldId == IntPtr.Zero)
					verticesByteBuffer_jfieldId = JNIEnv.GetFieldID (class_ref, "verticesByteBuffer", "Ljava/nio/ByteBuffer;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, verticesByteBuffer_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Java.Nio.ByteBuffer> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (verticesByteBuffer_jfieldId == IntPtr.Zero)
					verticesByteBuffer_jfieldId = JNIEnv.GetFieldID (class_ref, "verticesByteBuffer", "Ljava/nio/ByteBuffer;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, verticesByteBuffer_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/google/atap/tango/mesh/TangoMesh", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (TangoMesh); }
		}

		protected TangoMesh (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.google.atap.tango.mesh']/class[@name='TangoMesh']/constructor[@name='TangoMesh' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe TangoMesh ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (TangoMesh)) {
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

		static Delegate cb_getNativeHandle;
#pragma warning disable 0169
		static Delegate GetGetNativeHandleHandler ()
		{
			if (cb_getNativeHandle == null)
				cb_getNativeHandle = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long>) n_GetNativeHandle);
			return cb_getNativeHandle;
		}

		static long n_GetNativeHandle (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Google.Atap.Tango.Mesh.TangoMesh __this = global::Java.Lang.Object.GetObject<global::Com.Google.Atap.Tango.Mesh.TangoMesh> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.NativeHandle;
		}
#pragma warning restore 0169

		static IntPtr id_getNativeHandle;
		public virtual unsafe long NativeHandle {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.atap.tango.mesh']/class[@name='TangoMesh']/method[@name='getNativeHandle' and count(parameter)=0]"
			[Register ("getNativeHandle", "()J", "GetGetNativeHandleHandler")]
			get {
				if (id_getNativeHandle == IntPtr.Zero)
					id_getNativeHandle = JNIEnv.GetMethodID (class_ref, "getNativeHandle", "()J");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallLongMethod (((global::Java.Lang.Object) this).Handle, id_getNativeHandle);
					else
						return JNIEnv.CallNonvirtualLongMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getNativeHandle", "()J"));
				} finally {
				}
			}
		}

		static Delegate cb_finalize;
#pragma warning disable 0169
		static Delegate GetFinalizeHandler ()
		{
			if (cb_finalize == null)
				cb_finalize = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Finalize);
			return cb_finalize;
		}

		static void n_Finalize (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Google.Atap.Tango.Mesh.TangoMesh __this = global::Java.Lang.Object.GetObject<global::Com.Google.Atap.Tango.Mesh.TangoMesh> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Finalize ();
		}
#pragma warning restore 0169

		static IntPtr id_finalize;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.atap.tango.mesh']/class[@name='TangoMesh']/method[@name='finalize' and count(parameter)=0]"
		[Register ("finalize", "()V", "GetFinalizeHandler")]
		public virtual unsafe void Finalize ()
		{
			if (id_finalize == IntPtr.Zero)
				id_finalize = JNIEnv.GetMethodID (class_ref, "finalize", "()V");
			try {

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_finalize);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "finalize", "()V"));
			} finally {
			}
		}

		static Delegate cb_resetMesh;
#pragma warning disable 0169
		static Delegate GetResetMeshHandler ()
		{
			if (cb_resetMesh == null)
				cb_resetMesh = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_ResetMesh);
			return cb_resetMesh;
		}

		static void n_ResetMesh (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Google.Atap.Tango.Mesh.TangoMesh __this = global::Java.Lang.Object.GetObject<global::Com.Google.Atap.Tango.Mesh.TangoMesh> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ResetMesh ();
		}
#pragma warning restore 0169

		static IntPtr id_resetMesh;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.atap.tango.mesh']/class[@name='TangoMesh']/method[@name='resetMesh' and count(parameter)=0]"
		[Register ("resetMesh", "()V", "GetResetMeshHandler")]
		public virtual unsafe void ResetMesh ()
		{
			if (id_resetMesh == IntPtr.Zero)
				id_resetMesh = JNIEnv.GetMethodID (class_ref, "resetMesh", "()V");
			try {

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_resetMesh);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "resetMesh", "()V"));
			} finally {
			}
		}

		static Delegate cb_sizeOfColors;
#pragma warning disable 0169
		static Delegate GetSizeOfColorsHandler ()
		{
			if (cb_sizeOfColors == null)
				cb_sizeOfColors = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_SizeOfColors);
			return cb_sizeOfColors;
		}

		static int n_SizeOfColors (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Google.Atap.Tango.Mesh.TangoMesh __this = global::Java.Lang.Object.GetObject<global::Com.Google.Atap.Tango.Mesh.TangoMesh> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.SizeOfColors ();
		}
#pragma warning restore 0169

		static IntPtr id_sizeOfColors;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.atap.tango.mesh']/class[@name='TangoMesh']/method[@name='sizeOfColors' and count(parameter)=0]"
		[Register ("sizeOfColors", "()I", "GetSizeOfColorsHandler")]
		public virtual unsafe int SizeOfColors ()
		{
			if (id_sizeOfColors == IntPtr.Zero)
				id_sizeOfColors = JNIEnv.GetMethodID (class_ref, "sizeOfColors", "()I");
			try {

				if (GetType () == ThresholdType)
					return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_sizeOfColors);
				else
					return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "sizeOfColors", "()I"));
			} finally {
			}
		}

		static Delegate cb_sizeOfFaces;
#pragma warning disable 0169
		static Delegate GetSizeOfFacesHandler ()
		{
			if (cb_sizeOfFaces == null)
				cb_sizeOfFaces = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_SizeOfFaces);
			return cb_sizeOfFaces;
		}

		static int n_SizeOfFaces (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Google.Atap.Tango.Mesh.TangoMesh __this = global::Java.Lang.Object.GetObject<global::Com.Google.Atap.Tango.Mesh.TangoMesh> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.SizeOfFaces ();
		}
#pragma warning restore 0169

		static IntPtr id_sizeOfFaces;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.atap.tango.mesh']/class[@name='TangoMesh']/method[@name='sizeOfFaces' and count(parameter)=0]"
		[Register ("sizeOfFaces", "()I", "GetSizeOfFacesHandler")]
		public virtual unsafe int SizeOfFaces ()
		{
			if (id_sizeOfFaces == IntPtr.Zero)
				id_sizeOfFaces = JNIEnv.GetMethodID (class_ref, "sizeOfFaces", "()I");
			try {

				if (GetType () == ThresholdType)
					return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_sizeOfFaces);
				else
					return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "sizeOfFaces", "()I"));
			} finally {
			}
		}

		static Delegate cb_sizeOfNormals;
#pragma warning disable 0169
		static Delegate GetSizeOfNormalsHandler ()
		{
			if (cb_sizeOfNormals == null)
				cb_sizeOfNormals = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_SizeOfNormals);
			return cb_sizeOfNormals;
		}

		static int n_SizeOfNormals (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Google.Atap.Tango.Mesh.TangoMesh __this = global::Java.Lang.Object.GetObject<global::Com.Google.Atap.Tango.Mesh.TangoMesh> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.SizeOfNormals ();
		}
#pragma warning restore 0169

		static IntPtr id_sizeOfNormals;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.atap.tango.mesh']/class[@name='TangoMesh']/method[@name='sizeOfNormals' and count(parameter)=0]"
		[Register ("sizeOfNormals", "()I", "GetSizeOfNormalsHandler")]
		public virtual unsafe int SizeOfNormals ()
		{
			if (id_sizeOfNormals == IntPtr.Zero)
				id_sizeOfNormals = JNIEnv.GetMethodID (class_ref, "sizeOfNormals", "()I");
			try {

				if (GetType () == ThresholdType)
					return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_sizeOfNormals);
				else
					return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "sizeOfNormals", "()I"));
			} finally {
			}
		}

		static Delegate cb_sizeOfTexCoords;
#pragma warning disable 0169
		static Delegate GetSizeOfTexCoordsHandler ()
		{
			if (cb_sizeOfTexCoords == null)
				cb_sizeOfTexCoords = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_SizeOfTexCoords);
			return cb_sizeOfTexCoords;
		}

		static int n_SizeOfTexCoords (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Google.Atap.Tango.Mesh.TangoMesh __this = global::Java.Lang.Object.GetObject<global::Com.Google.Atap.Tango.Mesh.TangoMesh> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.SizeOfTexCoords ();
		}
#pragma warning restore 0169

		static IntPtr id_sizeOfTexCoords;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.atap.tango.mesh']/class[@name='TangoMesh']/method[@name='sizeOfTexCoords' and count(parameter)=0]"
		[Register ("sizeOfTexCoords", "()I", "GetSizeOfTexCoordsHandler")]
		public virtual unsafe int SizeOfTexCoords ()
		{
			if (id_sizeOfTexCoords == IntPtr.Zero)
				id_sizeOfTexCoords = JNIEnv.GetMethodID (class_ref, "sizeOfTexCoords", "()I");
			try {

				if (GetType () == ThresholdType)
					return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_sizeOfTexCoords);
				else
					return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "sizeOfTexCoords", "()I"));
			} finally {
			}
		}

		static Delegate cb_sizeOfVertices;
#pragma warning disable 0169
		static Delegate GetSizeOfVerticesHandler ()
		{
			if (cb_sizeOfVertices == null)
				cb_sizeOfVertices = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_SizeOfVertices);
			return cb_sizeOfVertices;
		}

		static int n_SizeOfVertices (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Google.Atap.Tango.Mesh.TangoMesh __this = global::Java.Lang.Object.GetObject<global::Com.Google.Atap.Tango.Mesh.TangoMesh> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.SizeOfVertices ();
		}
#pragma warning restore 0169

		static IntPtr id_sizeOfVertices;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.atap.tango.mesh']/class[@name='TangoMesh']/method[@name='sizeOfVertices' and count(parameter)=0]"
		[Register ("sizeOfVertices", "()I", "GetSizeOfVerticesHandler")]
		public virtual unsafe int SizeOfVertices ()
		{
			if (id_sizeOfVertices == IntPtr.Zero)
				id_sizeOfVertices = JNIEnv.GetMethodID (class_ref, "sizeOfVertices", "()I");
			try {

				if (GetType () == ThresholdType)
					return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_sizeOfVertices);
				else
					return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "sizeOfVertices", "()I"));
			} finally {
			}
		}

	}
}
