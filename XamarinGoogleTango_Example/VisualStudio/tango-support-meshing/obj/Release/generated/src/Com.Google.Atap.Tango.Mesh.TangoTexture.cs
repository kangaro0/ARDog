using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Google.Atap.Tango.Mesh {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.google.atap.tango.mesh']/class[@name='TangoTexture']"
	[global::Android.Runtime.Register ("com/google/atap/tango/mesh/TangoTexture", DoNotGenerateAcw=true)]
	public partial class TangoTexture : global::Java.Lang.Object {


		static IntPtr data_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.atap.tango.mesh']/class[@name='TangoTexture']/field[@name='data']"
		[Register ("data")]
		public global::Java.Nio.ByteBuffer Data {
			get {
				if (data_jfieldId == IntPtr.Zero)
					data_jfieldId = JNIEnv.GetFieldID (class_ref, "data", "Ljava/nio/ByteBuffer;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, data_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Java.Nio.ByteBuffer> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (data_jfieldId == IntPtr.Zero)
					data_jfieldId = JNIEnv.GetFieldID (class_ref, "data", "Ljava/nio/ByteBuffer;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, data_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr height_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.atap.tango.mesh']/class[@name='TangoTexture']/field[@name='height']"
		[Register ("height")]
		public int Height {
			get {
				if (height_jfieldId == IntPtr.Zero)
					height_jfieldId = JNIEnv.GetFieldID (class_ref, "height", "I");
				return JNIEnv.GetIntField (((global::Java.Lang.Object) this).Handle, height_jfieldId);
			}
			set {
				if (height_jfieldId == IntPtr.Zero)
					height_jfieldId = JNIEnv.GetFieldID (class_ref, "height", "I");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, height_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr stride_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.atap.tango.mesh']/class[@name='TangoTexture']/field[@name='stride']"
		[Register ("stride")]
		public int Stride {
			get {
				if (stride_jfieldId == IntPtr.Zero)
					stride_jfieldId = JNIEnv.GetFieldID (class_ref, "stride", "I");
				return JNIEnv.GetIntField (((global::Java.Lang.Object) this).Handle, stride_jfieldId);
			}
			set {
				if (stride_jfieldId == IntPtr.Zero)
					stride_jfieldId = JNIEnv.GetFieldID (class_ref, "stride", "I");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, stride_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr width_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.atap.tango.mesh']/class[@name='TangoTexture']/field[@name='width']"
		[Register ("width")]
		public int Width {
			get {
				if (width_jfieldId == IntPtr.Zero)
					width_jfieldId = JNIEnv.GetFieldID (class_ref, "width", "I");
				return JNIEnv.GetIntField (((global::Java.Lang.Object) this).Handle, width_jfieldId);
			}
			set {
				if (width_jfieldId == IntPtr.Zero)
					width_jfieldId = JNIEnv.GetFieldID (class_ref, "width", "I");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, width_jfieldId, value);
				} finally {
				}
			}
		}
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/google/atap/tango/mesh/TangoTexture", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (TangoTexture); }
		}

		protected TangoTexture (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.google.atap.tango.mesh']/class[@name='TangoTexture']/constructor[@name='TangoTexture' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe TangoTexture ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (TangoTexture)) {
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
