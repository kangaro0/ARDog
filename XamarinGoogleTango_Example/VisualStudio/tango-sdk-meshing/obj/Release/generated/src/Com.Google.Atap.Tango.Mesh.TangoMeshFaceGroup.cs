using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Google.Atap.Tango.Mesh {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.google.atap.tango.mesh']/class[@name='TangoMeshFaceGroup']"
	[global::Android.Runtime.Register ("com/google/atap/tango/mesh/TangoMeshFaceGroup", DoNotGenerateAcw=true)]
	public partial class TangoMeshFaceGroup : global::Java.Lang.Object {


		static IntPtr numFaces_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.atap.tango.mesh']/class[@name='TangoMeshFaceGroup']/field[@name='numFaces']"
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

		static IntPtr startFace_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.atap.tango.mesh']/class[@name='TangoMeshFaceGroup']/field[@name='startFace']"
		[Register ("startFace")]
		public int StartFace {
			get {
				if (startFace_jfieldId == IntPtr.Zero)
					startFace_jfieldId = JNIEnv.GetFieldID (class_ref, "startFace", "I");
				return JNIEnv.GetIntField (((global::Java.Lang.Object) this).Handle, startFace_jfieldId);
			}
			set {
				if (startFace_jfieldId == IntPtr.Zero)
					startFace_jfieldId = JNIEnv.GetFieldID (class_ref, "startFace", "I");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, startFace_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr textureId_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.atap.tango.mesh']/class[@name='TangoMeshFaceGroup']/field[@name='textureId']"
		[Register ("textureId")]
		public int TextureId {
			get {
				if (textureId_jfieldId == IntPtr.Zero)
					textureId_jfieldId = JNIEnv.GetFieldID (class_ref, "textureId", "I");
				return JNIEnv.GetIntField (((global::Java.Lang.Object) this).Handle, textureId_jfieldId);
			}
			set {
				if (textureId_jfieldId == IntPtr.Zero)
					textureId_jfieldId = JNIEnv.GetFieldID (class_ref, "textureId", "I");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, textureId_jfieldId, value);
				} finally {
				}
			}
		}
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/google/atap/tango/mesh/TangoMeshFaceGroup", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (TangoMeshFaceGroup); }
		}

		protected TangoMeshFaceGroup (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.google.atap.tango.mesh']/class[@name='TangoMeshFaceGroup']/constructor[@name='TangoMeshFaceGroup' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe TangoMeshFaceGroup ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (TangoMeshFaceGroup)) {
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

	}
}
