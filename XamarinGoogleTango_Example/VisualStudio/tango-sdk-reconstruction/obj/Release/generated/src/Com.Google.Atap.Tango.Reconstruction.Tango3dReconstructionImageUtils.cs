using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Google.Atap.Tango.Reconstruction {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.google.atap.tango.reconstruction']/class[@name='Tango3dReconstructionImageUtils']"
	[global::Android.Runtime.Register ("com/google/atap/tango/reconstruction/Tango3dReconstructionImageUtils", DoNotGenerateAcw=true)]
	public partial class Tango3dReconstructionImageUtils : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/google/atap/tango/reconstruction/Tango3dReconstructionImageUtils", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (Tango3dReconstructionImageUtils); }
		}

		protected Tango3dReconstructionImageUtils (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.google.atap.tango.reconstruction']/class[@name='Tango3dReconstructionImageUtils']/constructor[@name='Tango3dReconstructionImageUtils' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe Tango3dReconstructionImageUtils ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (Tango3dReconstructionImageUtils)) {
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

		static IntPtr id_convertEndiannessBigToNative_Lcom_google_atap_tangoservice_experimental_TangoImageBuffer_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.atap.tango.reconstruction']/class[@name='Tango3dReconstructionImageUtils']/method[@name='convertEndiannessBigToNative' and count(parameter)=1 and parameter[1][@type='com.google.atap.tangoservice.experimental.TangoImageBuffer']]"
		[Register ("convertEndiannessBigToNative", "(Lcom/google/atap/tangoservice/experimental/TangoImageBuffer;)V", "")]
		public static unsafe void ConvertEndiannessBigToNative (global::Com.Google.Atap.Tangoservice.Experimental.TangoImageBuffer p0)
		{
			if (id_convertEndiannessBigToNative_Lcom_google_atap_tangoservice_experimental_TangoImageBuffer_ == IntPtr.Zero)
				id_convertEndiannessBigToNative_Lcom_google_atap_tangoservice_experimental_TangoImageBuffer_ = JNIEnv.GetStaticMethodID (class_ref, "convertEndiannessBigToNative", "(Lcom/google/atap/tangoservice/experimental/TangoImageBuffer;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_convertEndiannessBigToNative_Lcom_google_atap_tangoservice_experimental_TangoImageBuffer_, __args);
			} finally {
			}
		}

		static IntPtr id_convertEndiannessNativeToBig_Lcom_google_atap_tangoservice_experimental_TangoImageBuffer_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.atap.tango.reconstruction']/class[@name='Tango3dReconstructionImageUtils']/method[@name='convertEndiannessNativeToBig' and count(parameter)=1 and parameter[1][@type='com.google.atap.tangoservice.experimental.TangoImageBuffer']]"
		[Register ("convertEndiannessNativeToBig", "(Lcom/google/atap/tangoservice/experimental/TangoImageBuffer;)V", "")]
		public static unsafe void ConvertEndiannessNativeToBig (global::Com.Google.Atap.Tangoservice.Experimental.TangoImageBuffer p0)
		{
			if (id_convertEndiannessNativeToBig_Lcom_google_atap_tangoservice_experimental_TangoImageBuffer_ == IntPtr.Zero)
				id_convertEndiannessNativeToBig_Lcom_google_atap_tangoservice_experimental_TangoImageBuffer_ = JNIEnv.GetStaticMethodID (class_ref, "convertEndiannessNativeToBig", "(Lcom/google/atap/tangoservice/experimental/TangoImageBuffer;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_convertEndiannessNativeToBig_Lcom_google_atap_tangoservice_experimental_TangoImageBuffer_, __args);
			} finally {
			}
		}

		static IntPtr id_convertPointCloudToDepthImage_Lcom_google_atap_tangoservice_TangoCameraIntrinsics_Lcom_google_atap_tangoservice_TangoPointCloudData_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.atap.tango.reconstruction']/class[@name='Tango3dReconstructionImageUtils']/method[@name='convertPointCloudToDepthImage' and count(parameter)=2 and parameter[1][@type='com.google.atap.tangoservice.TangoCameraIntrinsics'] and parameter[2][@type='com.google.atap.tangoservice.TangoPointCloudData']]"
		[Register ("convertPointCloudToDepthImage", "(Lcom/google/atap/tangoservice/TangoCameraIntrinsics;Lcom/google/atap/tangoservice/TangoPointCloudData;)Lcom/google/atap/tangoservice/experimental/TangoImageBuffer;", "")]
		public static unsafe global::Com.Google.Atap.Tangoservice.Experimental.TangoImageBuffer ConvertPointCloudToDepthImage (global::Com.Google.Atap.Tangoservice.TangoCameraIntrinsics p0, global::Com.Google.Atap.Tangoservice.TangoPointCloudData p1)
		{
			if (id_convertPointCloudToDepthImage_Lcom_google_atap_tangoservice_TangoCameraIntrinsics_Lcom_google_atap_tangoservice_TangoPointCloudData_ == IntPtr.Zero)
				id_convertPointCloudToDepthImage_Lcom_google_atap_tangoservice_TangoCameraIntrinsics_Lcom_google_atap_tangoservice_TangoPointCloudData_ = JNIEnv.GetStaticMethodID (class_ref, "convertPointCloudToDepthImage", "(Lcom/google/atap/tangoservice/TangoCameraIntrinsics;Lcom/google/atap/tangoservice/TangoPointCloudData;)Lcom/google/atap/tangoservice/experimental/TangoImageBuffer;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				global::Com.Google.Atap.Tangoservice.Experimental.TangoImageBuffer __ret = global::Java.Lang.Object.GetObject<global::Com.Google.Atap.Tangoservice.Experimental.TangoImageBuffer> (JNIEnv.CallStaticObjectMethod  (class_ref, id_convertPointCloudToDepthImage_Lcom_google_atap_tangoservice_TangoCameraIntrinsics_Lcom_google_atap_tangoservice_TangoPointCloudData_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_convertPointCloudToDepthImage_Lcom_google_atap_tangoservice_TangoCameraIntrinsics_Lcom_google_atap_tangoservice_TangoPointCloudData_Lcom_google_atap_tangoservice_experimental_TangoImageBuffer_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.atap.tango.reconstruction']/class[@name='Tango3dReconstructionImageUtils']/method[@name='convertPointCloudToDepthImage' and count(parameter)=3 and parameter[1][@type='com.google.atap.tangoservice.TangoCameraIntrinsics'] and parameter[2][@type='com.google.atap.tangoservice.TangoPointCloudData'] and parameter[3][@type='com.google.atap.tangoservice.experimental.TangoImageBuffer']]"
		[Register ("convertPointCloudToDepthImage", "(Lcom/google/atap/tangoservice/TangoCameraIntrinsics;Lcom/google/atap/tangoservice/TangoPointCloudData;Lcom/google/atap/tangoservice/experimental/TangoImageBuffer;)V", "")]
		public static unsafe void ConvertPointCloudToDepthImage (global::Com.Google.Atap.Tangoservice.TangoCameraIntrinsics p0, global::Com.Google.Atap.Tangoservice.TangoPointCloudData p1, global::Com.Google.Atap.Tangoservice.Experimental.TangoImageBuffer p2)
		{
			if (id_convertPointCloudToDepthImage_Lcom_google_atap_tangoservice_TangoCameraIntrinsics_Lcom_google_atap_tangoservice_TangoPointCloudData_Lcom_google_atap_tangoservice_experimental_TangoImageBuffer_ == IntPtr.Zero)
				id_convertPointCloudToDepthImage_Lcom_google_atap_tangoservice_TangoCameraIntrinsics_Lcom_google_atap_tangoservice_TangoPointCloudData_Lcom_google_atap_tangoservice_experimental_TangoImageBuffer_ = JNIEnv.GetStaticMethodID (class_ref, "convertPointCloudToDepthImage", "(Lcom/google/atap/tangoservice/TangoCameraIntrinsics;Lcom/google/atap/tangoservice/TangoPointCloudData;Lcom/google/atap/tangoservice/experimental/TangoImageBuffer;)V");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_convertPointCloudToDepthImage_Lcom_google_atap_tangoservice_TangoCameraIntrinsics_Lcom_google_atap_tangoservice_TangoPointCloudData_Lcom_google_atap_tangoservice_experimental_TangoImageBuffer_, __args);
			} finally {
			}
		}

		static IntPtr id_createDepthImageForCamera_Lcom_google_atap_tangoservice_TangoCameraIntrinsics_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.atap.tango.reconstruction']/class[@name='Tango3dReconstructionImageUtils']/method[@name='createDepthImageForCamera' and count(parameter)=1 and parameter[1][@type='com.google.atap.tangoservice.TangoCameraIntrinsics']]"
		[Register ("createDepthImageForCamera", "(Lcom/google/atap/tangoservice/TangoCameraIntrinsics;)Lcom/google/atap/tangoservice/experimental/TangoImageBuffer;", "")]
		public static unsafe global::Com.Google.Atap.Tangoservice.Experimental.TangoImageBuffer CreateDepthImageForCamera (global::Com.Google.Atap.Tangoservice.TangoCameraIntrinsics p0)
		{
			if (id_createDepthImageForCamera_Lcom_google_atap_tangoservice_TangoCameraIntrinsics_ == IntPtr.Zero)
				id_createDepthImageForCamera_Lcom_google_atap_tangoservice_TangoCameraIntrinsics_ = JNIEnv.GetStaticMethodID (class_ref, "createDepthImageForCamera", "(Lcom/google/atap/tangoservice/TangoCameraIntrinsics;)Lcom/google/atap/tangoservice/experimental/TangoImageBuffer;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				global::Com.Google.Atap.Tangoservice.Experimental.TangoImageBuffer __ret = global::Java.Lang.Object.GetObject<global::Com.Google.Atap.Tangoservice.Experimental.TangoImageBuffer> (JNIEnv.CallStaticObjectMethod  (class_ref, id_createDepthImageForCamera_Lcom_google_atap_tangoservice_TangoCameraIntrinsics_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

	}
}
