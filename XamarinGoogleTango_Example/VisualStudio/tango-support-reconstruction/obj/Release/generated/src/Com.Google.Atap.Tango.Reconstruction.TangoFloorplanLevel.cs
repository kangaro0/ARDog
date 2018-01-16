using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Google.Atap.Tango.Reconstruction {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.google.atap.tango.reconstruction']/class[@name='TangoFloorplanLevel']"
	[global::Android.Runtime.Register ("com/google/atap/tango/reconstruction/TangoFloorplanLevel", DoNotGenerateAcw=true)]
	public partial class TangoFloorplanLevel : global::Java.Lang.Object {


		static IntPtr maxZ_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.atap.tango.reconstruction']/class[@name='TangoFloorplanLevel']/field[@name='maxZ']"
		[Register ("maxZ")]
		public float MaxZ {
			get {
				if (maxZ_jfieldId == IntPtr.Zero)
					maxZ_jfieldId = JNIEnv.GetFieldID (class_ref, "maxZ", "F");
				return JNIEnv.GetFloatField (((global::Java.Lang.Object) this).Handle, maxZ_jfieldId);
			}
			set {
				if (maxZ_jfieldId == IntPtr.Zero)
					maxZ_jfieldId = JNIEnv.GetFieldID (class_ref, "maxZ", "F");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, maxZ_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr minZ_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.atap.tango.reconstruction']/class[@name='TangoFloorplanLevel']/field[@name='minZ']"
		[Register ("minZ")]
		public float MinZ {
			get {
				if (minZ_jfieldId == IntPtr.Zero)
					minZ_jfieldId = JNIEnv.GetFieldID (class_ref, "minZ", "F");
				return JNIEnv.GetFloatField (((global::Java.Lang.Object) this).Handle, minZ_jfieldId);
			}
			set {
				if (minZ_jfieldId == IntPtr.Zero)
					minZ_jfieldId = JNIEnv.GetFieldID (class_ref, "minZ", "F");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, minZ_jfieldId, value);
				} finally {
				}
			}
		}
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/google/atap/tango/reconstruction/TangoFloorplanLevel", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (TangoFloorplanLevel); }
		}

		protected TangoFloorplanLevel (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.google.atap.tango.reconstruction']/class[@name='TangoFloorplanLevel']/constructor[@name='TangoFloorplanLevel' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe TangoFloorplanLevel ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (TangoFloorplanLevel)) {
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
