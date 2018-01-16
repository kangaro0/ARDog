using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Google.Atap.Tango.Dataset.Exceptions {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.google.atap.tango.dataset.exceptions']/class[@name='TangoDatasetNotFoundException']"
	[global::Android.Runtime.Register ("com/google/atap/tango/dataset/exceptions/TangoDatasetNotFoundException", DoNotGenerateAcw=true)]
	public partial class TangoDatasetNotFoundException : global::Com.Google.Atap.Tango.Dataset.Exceptions.TangoDatasetException {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/google/atap/tango/dataset/exceptions/TangoDatasetNotFoundException", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (TangoDatasetNotFoundException); }
		}

		protected TangoDatasetNotFoundException (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.google.atap.tango.dataset.exceptions']/class[@name='TangoDatasetNotFoundException']/constructor[@name='TangoDatasetNotFoundException' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe TangoDatasetNotFoundException ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Throwable) this).Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (TangoDatasetNotFoundException)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "()V"),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Throwable) this).Handle, "()V");
					return;
				}

				if (id_ctor == IntPtr.Zero)
					id_ctor = JNIEnv.GetMethodID (class_ref, "<init>", "()V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Throwable) this).Handle, class_ref, id_ctor);
			} finally {
			}
		}

	}
}
