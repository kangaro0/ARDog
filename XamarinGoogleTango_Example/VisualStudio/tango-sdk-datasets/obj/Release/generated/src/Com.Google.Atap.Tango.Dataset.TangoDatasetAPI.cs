using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Google.Atap.Tango.Dataset {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.google.atap.tango.dataset']/class[@name='TangoDatasetAPI']"
	[global::Android.Runtime.Register ("com/google/atap/tango/dataset/TangoDatasetAPI", DoNotGenerateAcw=true)]
	public partial class TangoDatasetAPI : global::Java.Lang.Object {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.atap.tango.dataset']/class[@name='TangoDatasetAPI']/field[@name='TANGO_FILEPROVIDER_AUTHORITY_V1']"
		[Register ("TANGO_FILEPROVIDER_AUTHORITY_V1")]
		public const string TangoFileproviderAuthorityV1 = (string) "com.google.tango.fileprovider.v1";
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/google/atap/tango/dataset/TangoDatasetAPI", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (TangoDatasetAPI); }
		}

		protected TangoDatasetAPI (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.google.atap.tango.dataset']/class[@name='TangoDatasetAPI']/constructor[@name='TangoDatasetAPI' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe TangoDatasetAPI ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (TangoDatasetAPI)) {
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

		static IntPtr id_deleteDataset_Lcom_google_atap_tango_dataset_TangoDataset_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.atap.tango.dataset']/class[@name='TangoDatasetAPI']/method[@name='deleteDataset' and count(parameter)=1 and parameter[1][@type='com.google.atap.tango.dataset.TangoDataset']]"
		[Register ("deleteDataset", "(Lcom/google/atap/tango/dataset/TangoDataset;)V", "")]
		public static unsafe void DeleteDataset (global::Com.Google.Atap.Tango.Dataset.TangoDataset p0)
		{
			if (id_deleteDataset_Lcom_google_atap_tango_dataset_TangoDataset_ == IntPtr.Zero)
				id_deleteDataset_Lcom_google_atap_tango_dataset_TangoDataset_ = JNIEnv.GetStaticMethodID (class_ref, "deleteDataset", "(Lcom/google/atap/tango/dataset/TangoDataset;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_deleteDataset_Lcom_google_atap_tango_dataset_TangoDataset_, __args);
			} finally {
			}
		}

		static IntPtr id_getDatasetsList_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.atap.tango.dataset']/class[@name='TangoDatasetAPI']/method[@name='getDatasetsList' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getDatasetsList", "(Ljava/lang/String;)Ljava/util/List;", "")]
		public static unsafe global::System.Collections.Generic.IList<global::Com.Google.Atap.Tango.Dataset.TangoDataset> GetDatasetsList (string p0)
		{
			if (id_getDatasetsList_Ljava_lang_String_ == IntPtr.Zero)
				id_getDatasetsList_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "getDatasetsList", "(Ljava/lang/String;)Ljava/util/List;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				global::System.Collections.Generic.IList<global::Com.Google.Atap.Tango.Dataset.TangoDataset> __ret = global::Android.Runtime.JavaList<global::Com.Google.Atap.Tango.Dataset.TangoDataset>.FromJniHandle (JNIEnv.CallStaticObjectMethod  (class_ref, id_getDatasetsList_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

	}
}
