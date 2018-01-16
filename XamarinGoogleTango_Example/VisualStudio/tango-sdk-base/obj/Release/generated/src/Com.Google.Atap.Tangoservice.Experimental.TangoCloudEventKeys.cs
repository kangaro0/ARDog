using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Google.Atap.Tangoservice.Experimental {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.google.atap.tangoservice.experimental']/class[@name='TangoCloudEventKeys']"
	[global::Android.Runtime.Register ("com/google/atap/tangoservice/experimental/TangoCloudEventKeys", DoNotGenerateAcw=true)]
	public partial class TangoCloudEventKeys : global::Java.Lang.Object {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.atap.tangoservice.experimental']/class[@name='TangoCloudEventKeys']/field[@name='KEY_STATUS_FAILURE']"
		[Register ("KEY_STATUS_FAILURE")]
		public const string KeyStatusFailure = (string) "STATUS_FAILURE";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.atap.tangoservice.experimental']/class[@name='TangoCloudEventKeys']/field[@name='KEY_STATUS_NOT_AVAILABLE']"
		[Register ("KEY_STATUS_NOT_AVAILABLE")]
		public const string KeyStatusNotAvailable = (string) "STATUS_NOT_AVAILABLE";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.atap.tangoservice.experimental']/class[@name='TangoCloudEventKeys']/field[@name='KEY_STATUS_READY']"
		[Register ("KEY_STATUS_READY")]
		public const string KeyStatusReady = (string) "STATUS_READY";
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/google/atap/tangoservice/experimental/TangoCloudEventKeys", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (TangoCloudEventKeys); }
		}

		protected TangoCloudEventKeys (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.google.atap.tangoservice.experimental']/class[@name='TangoCloudEventKeys']/constructor[@name='TangoCloudEventKeys' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe TangoCloudEventKeys ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (TangoCloudEventKeys)) {
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
