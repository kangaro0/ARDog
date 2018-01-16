using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Google.Atap.Tango.Reconstruction {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.google.atap.tango.reconstruction']/class[@name='TangoPolygon']"
	[global::Android.Runtime.Register ("com/google/atap/tango/reconstruction/TangoPolygon", DoNotGenerateAcw=true)]
	public partial class TangoPolygon : global::Java.Lang.Object {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.atap.tango.reconstruction']/class[@name='TangoPolygon']/field[@name='TANGO_3DR_LAYER_FURNITURE']"
		[Register ("TANGO_3DR_LAYER_FURNITURE")]
		public const int Tango3drLayerFurniture = (int) 2;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.atap.tango.reconstruction']/class[@name='TangoPolygon']/field[@name='TANGO_3DR_LAYER_SPACE']"
		[Register ("TANGO_3DR_LAYER_SPACE")]
		public const int Tango3drLayerSpace = (int) 0;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.atap.tango.reconstruction']/class[@name='TangoPolygon']/field[@name='TANGO_3DR_LAYER_WALLS']"
		[Register ("TANGO_3DR_LAYER_WALLS")]
		public const int Tango3drLayerWalls = (int) 1;

		static IntPtr area_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.atap.tango.reconstruction']/class[@name='TangoPolygon']/field[@name='area']"
		[Register ("area")]
		public double Area {
			get {
				if (area_jfieldId == IntPtr.Zero)
					area_jfieldId = JNIEnv.GetFieldID (class_ref, "area", "D");
				return JNIEnv.GetDoubleField (((global::Java.Lang.Object) this).Handle, area_jfieldId);
			}
			set {
				if (area_jfieldId == IntPtr.Zero)
					area_jfieldId = JNIEnv.GetFieldID (class_ref, "area", "D");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, area_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr isClosed_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.atap.tango.reconstruction']/class[@name='TangoPolygon']/field[@name='isClosed']"
		[Register ("isClosed")]
		public bool IsClosed {
			get {
				if (isClosed_jfieldId == IntPtr.Zero)
					isClosed_jfieldId = JNIEnv.GetFieldID (class_ref, "isClosed", "Z");
				return JNIEnv.GetBooleanField (((global::Java.Lang.Object) this).Handle, isClosed_jfieldId);
			}
			set {
				if (isClosed_jfieldId == IntPtr.Zero)
					isClosed_jfieldId = JNIEnv.GetFieldID (class_ref, "isClosed", "Z");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, isClosed_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr layer_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.atap.tango.reconstruction']/class[@name='TangoPolygon']/field[@name='layer']"
		[Register ("layer")]
		public int Layer {
			get {
				if (layer_jfieldId == IntPtr.Zero)
					layer_jfieldId = JNIEnv.GetFieldID (class_ref, "layer", "I");
				return JNIEnv.GetIntField (((global::Java.Lang.Object) this).Handle, layer_jfieldId);
			}
			set {
				if (layer_jfieldId == IntPtr.Zero)
					layer_jfieldId = JNIEnv.GetFieldID (class_ref, "layer", "I");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, layer_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr vertices2d_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.atap.tango.reconstruction']/class[@name='TangoPolygon']/field[@name='vertices2d']"
		[Register ("vertices2d")]
		public global::System.Collections.IList Vertices2d {
			get {
				if (vertices2d_jfieldId == IntPtr.Zero)
					vertices2d_jfieldId = JNIEnv.GetFieldID (class_ref, "vertices2d", "Ljava/util/List;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, vertices2d_jfieldId);
				return global::Android.Runtime.JavaList.FromJniHandle (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (vertices2d_jfieldId == IntPtr.Zero)
					vertices2d_jfieldId = JNIEnv.GetFieldID (class_ref, "vertices2d", "Ljava/util/List;");
				IntPtr native_value = global::Android.Runtime.JavaList.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, vertices2d_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/google/atap/tango/reconstruction/TangoPolygon", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (TangoPolygon); }
		}

		protected TangoPolygon (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.google.atap.tango.reconstruction']/class[@name='TangoPolygon']/constructor[@name='TangoPolygon' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe TangoPolygon ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (TangoPolygon)) {
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
