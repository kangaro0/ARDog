using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Google.Atap.Tango {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.google.atap.tango']/class[@name='TangoJNINative']"
	[global::Android.Runtime.Register ("com/google/atap/tango/TangoJNINative", DoNotGenerateAcw=true)]
	public partial class TangoJNINative : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/google/atap/tango/TangoJNINative", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (TangoJNINative); }
		}

		protected TangoJNINative (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.google.atap.tango']/class[@name='TangoJNINative']/constructor[@name='TangoJNINative' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe TangoJNINative ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (TangoJNINative)) {
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

		static IntPtr id_GetBinder;
		public static unsafe global::Android.OS.IBinder Binder {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.atap.tango']/class[@name='TangoJNINative']/method[@name='GetBinder' and count(parameter)=0]"
			[Register ("GetBinder", "()Landroid/os/IBinder;", "GetGetBinderHandler")]
			get {
				if (id_GetBinder == IntPtr.Zero)
					id_GetBinder = JNIEnv.GetStaticMethodID (class_ref, "GetBinder", "()Landroid/os/IBinder;");
				try {
					return global::Java.Lang.Object.GetObject<global::Android.OS.IBinder> (JNIEnv.CallStaticObjectMethod  (class_ref, id_GetBinder), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_Connect_Lcom_google_atap_tangoservice_TangoConfig_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.atap.tango']/class[@name='TangoJNINative']/method[@name='Connect' and count(parameter)=1 and parameter[1][@type='com.google.atap.tangoservice.TangoConfig']]"
		[Register ("Connect", "(Lcom/google/atap/tangoservice/TangoConfig;)I", "")]
		public static unsafe int Connect (global::Com.Google.Atap.Tangoservice.TangoConfig p0)
		{
			if (id_Connect_Lcom_google_atap_tangoservice_TangoConfig_ == IntPtr.Zero)
				id_Connect_Lcom_google_atap_tangoservice_TangoConfig_ = JNIEnv.GetStaticMethodID (class_ref, "Connect", "(Lcom/google/atap/tangoservice/TangoConfig;)I");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				int __ret = JNIEnv.CallStaticIntMethod  (class_ref, id_Connect_Lcom_google_atap_tangoservice_TangoConfig_, __args);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_ConnectListener_arrayILcom_google_atap_tangoservice_Tango_TangoUpdateCallback_Lcom_google_atap_tangoservice_TangoPoseData_Lcom_google_atap_tangoservice_TangoPointCloudData_Lcom_google_atap_tangoservice_TangoEvent_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.atap.tango']/class[@name='TangoJNINative']/method[@name='ConnectListener' and count(parameter)=5 and parameter[1][@type='int[]'] and parameter[2][@type='com.google.atap.tangoservice.Tango.TangoUpdateCallback'] and parameter[3][@type='com.google.atap.tangoservice.TangoPoseData'] and parameter[4][@type='com.google.atap.tangoservice.TangoPointCloudData'] and parameter[5][@type='com.google.atap.tangoservice.TangoEvent']]"
		[Register ("ConnectListener", "([ILcom/google/atap/tangoservice/Tango$TangoUpdateCallback;Lcom/google/atap/tangoservice/TangoPoseData;Lcom/google/atap/tangoservice/TangoPointCloudData;Lcom/google/atap/tangoservice/TangoEvent;)I", "")]
		public static unsafe int ConnectListener (int[] p0, global::Com.Google.Atap.Tangoservice.Tango.TangoUpdateCallback p1, global::Com.Google.Atap.Tangoservice.TangoPoseData p2, global::Com.Google.Atap.Tangoservice.TangoPointCloudData p3, global::Com.Google.Atap.Tangoservice.TangoEvent p4)
		{
			if (id_ConnectListener_arrayILcom_google_atap_tangoservice_Tango_TangoUpdateCallback_Lcom_google_atap_tangoservice_TangoPoseData_Lcom_google_atap_tangoservice_TangoPointCloudData_Lcom_google_atap_tangoservice_TangoEvent_ == IntPtr.Zero)
				id_ConnectListener_arrayILcom_google_atap_tangoservice_Tango_TangoUpdateCallback_Lcom_google_atap_tangoservice_TangoPoseData_Lcom_google_atap_tangoservice_TangoPointCloudData_Lcom_google_atap_tangoservice_TangoEvent_ = JNIEnv.GetStaticMethodID (class_ref, "ConnectListener", "([ILcom/google/atap/tangoservice/Tango$TangoUpdateCallback;Lcom/google/atap/tangoservice/TangoPoseData;Lcom/google/atap/tangoservice/TangoPointCloudData;Lcom/google/atap/tangoservice/TangoEvent;)I");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JValue* __args = stackalloc JValue [5];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				__args [4] = new JValue (p4);
				int __ret = JNIEnv.CallStaticIntMethod  (class_ref, id_ConnectListener_arrayILcom_google_atap_tangoservice_Tango_TangoUpdateCallback_Lcom_google_atap_tangoservice_TangoPoseData_Lcom_google_atap_tangoservice_TangoPointCloudData_Lcom_google_atap_tangoservice_TangoEvent_, __args);
				return __ret;
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}
		}

		static IntPtr id_ConnectOnFrameAvailable_ILcom_google_atap_tangoservice_Tango_OnFrameAvailableListener_Lcom_google_atap_tangoservice_experimental_TangoImageBuffer_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.atap.tango']/class[@name='TangoJNINative']/method[@name='ConnectOnFrameAvailable' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='com.google.atap.tangoservice.Tango.OnFrameAvailableListener'] and parameter[3][@type='com.google.atap.tangoservice.experimental.TangoImageBuffer']]"
		[Register ("ConnectOnFrameAvailable", "(ILcom/google/atap/tangoservice/Tango$OnFrameAvailableListener;Lcom/google/atap/tangoservice/experimental/TangoImageBuffer;)I", "")]
		public static unsafe int ConnectOnFrameAvailable (int p0, global::Com.Google.Atap.Tangoservice.Tango.IOnFrameAvailableListener p1, global::Com.Google.Atap.Tangoservice.Experimental.TangoImageBuffer p2)
		{
			if (id_ConnectOnFrameAvailable_ILcom_google_atap_tangoservice_Tango_OnFrameAvailableListener_Lcom_google_atap_tangoservice_experimental_TangoImageBuffer_ == IntPtr.Zero)
				id_ConnectOnFrameAvailable_ILcom_google_atap_tangoservice_Tango_OnFrameAvailableListener_Lcom_google_atap_tangoservice_experimental_TangoImageBuffer_ = JNIEnv.GetStaticMethodID (class_ref, "ConnectOnFrameAvailable", "(ILcom/google/atap/tangoservice/Tango$OnFrameAvailableListener;Lcom/google/atap/tangoservice/experimental/TangoImageBuffer;)I");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				int __ret = JNIEnv.CallStaticIntMethod  (class_ref, id_ConnectOnFrameAvailable_ILcom_google_atap_tangoservice_Tango_OnFrameAvailableListener_Lcom_google_atap_tangoservice_experimental_TangoImageBuffer_, __args);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_ConnectTextureId_II;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.atap.tango']/class[@name='TangoJNINative']/method[@name='ConnectTextureId' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
		[Register ("ConnectTextureId", "(II)I", "")]
		public static unsafe int ConnectTextureId (int p0, int p1)
		{
			if (id_ConnectTextureId_II == IntPtr.Zero)
				id_ConnectTextureId_II = JNIEnv.GetStaticMethodID (class_ref, "ConnectTextureId", "(II)I");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				return JNIEnv.CallStaticIntMethod  (class_ref, id_ConnectTextureId_II, __args);
			} finally {
			}
		}

		static IntPtr id_CreateFrameOfInterest2_DLjava_lang_String_Lcom_google_atap_tangoservice_experimental_TangoTransformation_Lcom_google_atap_tangoservice_Tango_FoiListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.atap.tango']/class[@name='TangoJNINative']/method[@name='CreateFrameOfInterest2' and count(parameter)=4 and parameter[1][@type='double'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='com.google.atap.tangoservice.experimental.TangoTransformation'] and parameter[4][@type='com.google.atap.tangoservice.Tango.FoiListener']]"
		[Register ("CreateFrameOfInterest2", "(DLjava/lang/String;Lcom/google/atap/tangoservice/experimental/TangoTransformation;Lcom/google/atap/tangoservice/Tango$FoiListener;)I", "")]
		public static unsafe int CreateFrameOfInterest2 (double p0, string p1, global::Com.Google.Atap.Tangoservice.Experimental.TangoTransformation p2, global::Com.Google.Atap.Tangoservice.Tango.IFoiListener p3)
		{
			if (id_CreateFrameOfInterest2_DLjava_lang_String_Lcom_google_atap_tangoservice_experimental_TangoTransformation_Lcom_google_atap_tangoservice_Tango_FoiListener_ == IntPtr.Zero)
				id_CreateFrameOfInterest2_DLjava_lang_String_Lcom_google_atap_tangoservice_experimental_TangoTransformation_Lcom_google_atap_tangoservice_Tango_FoiListener_ = JNIEnv.GetStaticMethodID (class_ref, "CreateFrameOfInterest2", "(DLjava/lang/String;Lcom/google/atap/tangoservice/experimental/TangoTransformation;Lcom/google/atap/tangoservice/Tango$FoiListener;)I");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				int __ret = JNIEnv.CallStaticIntMethod  (class_ref, id_CreateFrameOfInterest2_DLjava_lang_String_Lcom_google_atap_tangoservice_experimental_TangoTransformation_Lcom_google_atap_tangoservice_Tango_FoiListener_, __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static IntPtr id_DeleteAreaDescription_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.atap.tango']/class[@name='TangoJNINative']/method[@name='DeleteAreaDescription' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("DeleteAreaDescription", "(Ljava/lang/String;)I", "")]
		public static unsafe int DeleteAreaDescription (string p0)
		{
			if (id_DeleteAreaDescription_Ljava_lang_String_ == IntPtr.Zero)
				id_DeleteAreaDescription_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "DeleteAreaDescription", "(Ljava/lang/String;)I");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				int __ret = JNIEnv.CallStaticIntMethod  (class_ref, id_DeleteAreaDescription_Ljava_lang_String_, __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_DeleteDataset_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.atap.tango']/class[@name='TangoJNINative']/method[@name='DeleteDataset' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("DeleteDataset", "(Ljava/lang/String;)I", "")]
		public static unsafe int DeleteDataset (string p0)
		{
			if (id_DeleteDataset_Ljava_lang_String_ == IntPtr.Zero)
				id_DeleteDataset_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "DeleteDataset", "(Ljava/lang/String;)I");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				int __ret = JNIEnv.CallStaticIntMethod  (class_ref, id_DeleteDataset_Ljava_lang_String_, __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_DeleteFramesOfInterest_arrayLjava_lang_String_Lcom_google_atap_tangoservice_Tango_FoiListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.atap.tango']/class[@name='TangoJNINative']/method[@name='DeleteFramesOfInterest' and count(parameter)=2 and parameter[1][@type='java.lang.String[]'] and parameter[2][@type='com.google.atap.tangoservice.Tango.FoiListener']]"
		[Register ("DeleteFramesOfInterest", "([Ljava/lang/String;Lcom/google/atap/tangoservice/Tango$FoiListener;)I", "")]
		public static unsafe int DeleteFramesOfInterest (string[] p0, global::Com.Google.Atap.Tangoservice.Tango.IFoiListener p1)
		{
			if (id_DeleteFramesOfInterest_arrayLjava_lang_String_Lcom_google_atap_tangoservice_Tango_FoiListener_ == IntPtr.Zero)
				id_DeleteFramesOfInterest_arrayLjava_lang_String_Lcom_google_atap_tangoservice_Tango_FoiListener_ = JNIEnv.GetStaticMethodID (class_ref, "DeleteFramesOfInterest", "([Ljava/lang/String;Lcom/google/atap/tangoservice/Tango$FoiListener;)I");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				int __ret = JNIEnv.CallStaticIntMethod  (class_ref, id_DeleteFramesOfInterest_arrayLjava_lang_String_Lcom_google_atap_tangoservice_Tango_FoiListener_, __args);
				return __ret;
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}
		}

		static IntPtr id_Disconnect;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.atap.tango']/class[@name='TangoJNINative']/method[@name='Disconnect' and count(parameter)=0]"
		[Register ("Disconnect", "()V", "")]
		public static unsafe void Disconnect ()
		{
			if (id_Disconnect == IntPtr.Zero)
				id_Disconnect = JNIEnv.GetStaticMethodID (class_ref, "Disconnect", "()V");
			try {
				JNIEnv.CallStaticVoidMethod  (class_ref, id_Disconnect);
			} finally {
			}
		}

		static IntPtr id_DisconnectCamera_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.atap.tango']/class[@name='TangoJNINative']/method[@name='DisconnectCamera' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("DisconnectCamera", "(I)I", "")]
		public static unsafe int DisconnectCamera (int p0)
		{
			if (id_DisconnectCamera_I == IntPtr.Zero)
				id_DisconnectCamera_I = JNIEnv.GetStaticMethodID (class_ref, "DisconnectCamera", "(I)I");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				return JNIEnv.CallStaticIntMethod  (class_ref, id_DisconnectCamera_I, __args);
			} finally {
			}
		}

		static IntPtr id_GetAreaDescriptionMetadata_Ljava_lang_String_Lcom_google_atap_tangoservice_TangoAreaDescriptionMetaData_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.atap.tango']/class[@name='TangoJNINative']/method[@name='GetAreaDescriptionMetadata' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='com.google.atap.tangoservice.TangoAreaDescriptionMetaData']]"
		[Register ("GetAreaDescriptionMetadata", "(Ljava/lang/String;Lcom/google/atap/tangoservice/TangoAreaDescriptionMetaData;)I", "")]
		public static unsafe int GetAreaDescriptionMetadata (string p0, global::Com.Google.Atap.Tangoservice.TangoAreaDescriptionMetaData p1)
		{
			if (id_GetAreaDescriptionMetadata_Ljava_lang_String_Lcom_google_atap_tangoservice_TangoAreaDescriptionMetaData_ == IntPtr.Zero)
				id_GetAreaDescriptionMetadata_Ljava_lang_String_Lcom_google_atap_tangoservice_TangoAreaDescriptionMetaData_ = JNIEnv.GetStaticMethodID (class_ref, "GetAreaDescriptionMetadata", "(Ljava/lang/String;Lcom/google/atap/tangoservice/TangoAreaDescriptionMetaData;)I");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				int __ret = JNIEnv.CallStaticIntMethod  (class_ref, id_GetAreaDescriptionMetadata_Ljava_lang_String_Lcom_google_atap_tangoservice_TangoAreaDescriptionMetaData_, __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_GetAreaDescriptionUUIDList_arrayLjava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.atap.tango']/class[@name='TangoJNINative']/method[@name='GetAreaDescriptionUUIDList' and count(parameter)=1 and parameter[1][@type='java.lang.String[]']]"
		[Register ("GetAreaDescriptionUUIDList", "([Ljava/lang/String;)I", "")]
		public static unsafe int GetAreaDescriptionUUIDList (string[] p0)
		{
			if (id_GetAreaDescriptionUUIDList_arrayLjava_lang_String_ == IntPtr.Zero)
				id_GetAreaDescriptionUUIDList_arrayLjava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "GetAreaDescriptionUUIDList", "([Ljava/lang/String;)I");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				int __ret = JNIEnv.CallStaticIntMethod  (class_ref, id_GetAreaDescriptionUUIDList_arrayLjava_lang_String_, __args);
				return __ret;
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}
		}

		static IntPtr id_GetCameraIntrinsics_ILcom_google_atap_tangoservice_TangoCameraIntrinsics_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.atap.tango']/class[@name='TangoJNINative']/method[@name='GetCameraIntrinsics' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='com.google.atap.tangoservice.TangoCameraIntrinsics']]"
		[Register ("GetCameraIntrinsics", "(ILcom/google/atap/tangoservice/TangoCameraIntrinsics;)I", "")]
		public static unsafe int GetCameraIntrinsics (int p0, global::Com.Google.Atap.Tangoservice.TangoCameraIntrinsics p1)
		{
			if (id_GetCameraIntrinsics_ILcom_google_atap_tangoservice_TangoCameraIntrinsics_ == IntPtr.Zero)
				id_GetCameraIntrinsics_ILcom_google_atap_tangoservice_TangoCameraIntrinsics_ = JNIEnv.GetStaticMethodID (class_ref, "GetCameraIntrinsics", "(ILcom/google/atap/tangoservice/TangoCameraIntrinsics;)I");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				int __ret = JNIEnv.CallStaticIntMethod  (class_ref, id_GetCameraIntrinsics_ILcom_google_atap_tangoservice_TangoCameraIntrinsics_, __args);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_GetConfig_ILcom_google_atap_tangoservice_TangoConfig_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.atap.tango']/class[@name='TangoJNINative']/method[@name='GetConfig' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='com.google.atap.tangoservice.TangoConfig']]"
		[Register ("GetConfig", "(ILcom/google/atap/tangoservice/TangoConfig;)V", "")]
		public static unsafe void GetConfig (int p0, global::Com.Google.Atap.Tangoservice.TangoConfig p1)
		{
			if (id_GetConfig_ILcom_google_atap_tangoservice_TangoConfig_ == IntPtr.Zero)
				id_GetConfig_ILcom_google_atap_tangoservice_TangoConfig_ = JNIEnv.GetStaticMethodID (class_ref, "GetConfig", "(ILcom/google/atap/tangoservice/TangoConfig;)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_GetConfig_ILcom_google_atap_tangoservice_TangoConfig_, __args);
			} finally {
			}
		}

		static IntPtr id_GetCurrentDatasetUUID_arrayLjava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.atap.tango']/class[@name='TangoJNINative']/method[@name='GetCurrentDatasetUUID' and count(parameter)=1 and parameter[1][@type='java.lang.String[]']]"
		[Register ("GetCurrentDatasetUUID", "([Ljava/lang/String;)I", "")]
		public static unsafe int GetCurrentDatasetUUID (string[] p0)
		{
			if (id_GetCurrentDatasetUUID_arrayLjava_lang_String_ == IntPtr.Zero)
				id_GetCurrentDatasetUUID_arrayLjava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "GetCurrentDatasetUUID", "([Ljava/lang/String;)I");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				int __ret = JNIEnv.CallStaticIntMethod  (class_ref, id_GetCurrentDatasetUUID_arrayLjava_lang_String_, __args);
				return __ret;
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}
		}

		static IntPtr id_GetDatasets_arrayLjava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.atap.tango']/class[@name='TangoJNINative']/method[@name='GetDatasets' and count(parameter)=1 and parameter[1][@type='java.lang.String[]']]"
		[Register ("GetDatasets", "([Ljava/lang/String;)I", "")]
		public static unsafe int GetDatasets (string[] p0)
		{
			if (id_GetDatasets_arrayLjava_lang_String_ == IntPtr.Zero)
				id_GetDatasets_arrayLjava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "GetDatasets", "([Ljava/lang/String;)I");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				int __ret = JNIEnv.CallStaticIntMethod  (class_ref, id_GetDatasets_arrayLjava_lang_String_, __args);
				return __ret;
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}
		}

		static IntPtr id_GetPoseAtTime2_DLjava_lang_String_Ljava_lang_String_Lcom_google_atap_tangoservice_TangoPoseData_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.atap.tango']/class[@name='TangoJNINative']/method[@name='GetPoseAtTime2' and count(parameter)=4 and parameter[1][@type='double'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='com.google.atap.tangoservice.TangoPoseData']]"
		[Register ("GetPoseAtTime2", "(DLjava/lang/String;Ljava/lang/String;Lcom/google/atap/tangoservice/TangoPoseData;)I", "")]
		public static unsafe int GetPoseAtTime2 (double p0, string p1, string p2, global::Com.Google.Atap.Tangoservice.TangoPoseData p3)
		{
			if (id_GetPoseAtTime2_DLjava_lang_String_Ljava_lang_String_Lcom_google_atap_tangoservice_TangoPoseData_ == IntPtr.Zero)
				id_GetPoseAtTime2_DLjava_lang_String_Ljava_lang_String_Lcom_google_atap_tangoservice_TangoPoseData_ = JNIEnv.GetStaticMethodID (class_ref, "GetPoseAtTime2", "(DLjava/lang/String;Ljava/lang/String;Lcom/google/atap/tangoservice/TangoPoseData;)I");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (native_p2);
				__args [3] = new JValue (p3);
				int __ret = JNIEnv.CallStaticIntMethod  (class_ref, id_GetPoseAtTime2_DLjava_lang_String_Ljava_lang_String_Lcom_google_atap_tangoservice_TangoPoseData_, __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
				JNIEnv.DeleteLocalRef (native_p2);
			}
		}

		static IntPtr id_GetPoseAtTime_DIILcom_google_atap_tangoservice_TangoPoseData_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.atap.tango']/class[@name='TangoJNINative']/method[@name='GetPoseAtTime' and count(parameter)=4 and parameter[1][@type='double'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='com.google.atap.tangoservice.TangoPoseData']]"
		[Register ("GetPoseAtTime", "(DIILcom/google/atap/tangoservice/TangoPoseData;)I", "")]
		public static unsafe int GetPoseAtTime (double p0, int p1, int p2, global::Com.Google.Atap.Tangoservice.TangoPoseData p3)
		{
			if (id_GetPoseAtTime_DIILcom_google_atap_tangoservice_TangoPoseData_ == IntPtr.Zero)
				id_GetPoseAtTime_DIILcom_google_atap_tangoservice_TangoPoseData_ = JNIEnv.GetStaticMethodID (class_ref, "GetPoseAtTime", "(DIILcom/google/atap/tangoservice/TangoPoseData;)I");
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				int __ret = JNIEnv.CallStaticIntMethod  (class_ref, id_GetPoseAtTime_DIILcom_google_atap_tangoservice_TangoPoseData_, __args);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_Initialize_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.atap.tango']/class[@name='TangoJNINative']/method[@name='Initialize' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("Initialize", "(Landroid/content/Context;)I", "")]
		public static unsafe int Initialize (global::Android.Content.Context p0)
		{
			if (id_Initialize_Landroid_content_Context_ == IntPtr.Zero)
				id_Initialize_Landroid_content_Context_ = JNIEnv.GetStaticMethodID (class_ref, "Initialize", "(Landroid/content/Context;)I");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				int __ret = JNIEnv.CallStaticIntMethod  (class_ref, id_Initialize_Landroid_content_Context_, __args);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_LoadFramesOfInterest_arrayLjava_lang_String_Lcom_google_atap_tangoservice_Tango_FoiListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.atap.tango']/class[@name='TangoJNINative']/method[@name='LoadFramesOfInterest' and count(parameter)=2 and parameter[1][@type='java.lang.String[]'] and parameter[2][@type='com.google.atap.tangoservice.Tango.FoiListener']]"
		[Register ("LoadFramesOfInterest", "([Ljava/lang/String;Lcom/google/atap/tangoservice/Tango$FoiListener;)I", "")]
		public static unsafe int LoadFramesOfInterest (string[] p0, global::Com.Google.Atap.Tangoservice.Tango.IFoiListener p1)
		{
			if (id_LoadFramesOfInterest_arrayLjava_lang_String_Lcom_google_atap_tangoservice_Tango_FoiListener_ == IntPtr.Zero)
				id_LoadFramesOfInterest_arrayLjava_lang_String_Lcom_google_atap_tangoservice_Tango_FoiListener_ = JNIEnv.GetStaticMethodID (class_ref, "LoadFramesOfInterest", "([Ljava/lang/String;Lcom/google/atap/tangoservice/Tango$FoiListener;)I");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				int __ret = JNIEnv.CallStaticIntMethod  (class_ref, id_LoadFramesOfInterest_arrayLjava_lang_String_Lcom_google_atap_tangoservice_Tango_FoiListener_, __args);
				return __ret;
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}
		}

		static IntPtr id_ResetMotionTracking;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.atap.tango']/class[@name='TangoJNINative']/method[@name='ResetMotionTracking' and count(parameter)=0]"
		[Register ("ResetMotionTracking", "()V", "")]
		public static unsafe void ResetMotionTracking ()
		{
			if (id_ResetMotionTracking == IntPtr.Zero)
				id_ResetMotionTracking = JNIEnv.GetStaticMethodID (class_ref, "ResetMotionTracking", "()V");
			try {
				JNIEnv.CallStaticVoidMethod  (class_ref, id_ResetMotionTracking);
			} finally {
			}
		}

		static IntPtr id_SaveAreaDescription_arrayLjava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.atap.tango']/class[@name='TangoJNINative']/method[@name='SaveAreaDescription' and count(parameter)=1 and parameter[1][@type='java.lang.String[]']]"
		[Register ("SaveAreaDescription", "([Ljava/lang/String;)I", "")]
		public static unsafe int SaveAreaDescription (string[] p0)
		{
			if (id_SaveAreaDescription_arrayLjava_lang_String_ == IntPtr.Zero)
				id_SaveAreaDescription_arrayLjava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "SaveAreaDescription", "([Ljava/lang/String;)I");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				int __ret = JNIEnv.CallStaticIntMethod  (class_ref, id_SaveAreaDescription_arrayLjava_lang_String_, __args);
				return __ret;
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}
		}

		static IntPtr id_SaveAreaDescriptionMetadata_Ljava_lang_String_Lcom_google_atap_tangoservice_TangoAreaDescriptionMetaData_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.atap.tango']/class[@name='TangoJNINative']/method[@name='SaveAreaDescriptionMetadata' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='com.google.atap.tangoservice.TangoAreaDescriptionMetaData']]"
		[Register ("SaveAreaDescriptionMetadata", "(Ljava/lang/String;Lcom/google/atap/tangoservice/TangoAreaDescriptionMetaData;)I", "")]
		public static unsafe int SaveAreaDescriptionMetadata (string p0, global::Com.Google.Atap.Tangoservice.TangoAreaDescriptionMetaData p1)
		{
			if (id_SaveAreaDescriptionMetadata_Ljava_lang_String_Lcom_google_atap_tangoservice_TangoAreaDescriptionMetaData_ == IntPtr.Zero)
				id_SaveAreaDescriptionMetadata_Ljava_lang_String_Lcom_google_atap_tangoservice_TangoAreaDescriptionMetaData_ = JNIEnv.GetStaticMethodID (class_ref, "SaveAreaDescriptionMetadata", "(Ljava/lang/String;Lcom/google/atap/tangoservice/TangoAreaDescriptionMetaData;)I");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				int __ret = JNIEnv.CallStaticIntMethod  (class_ref, id_SaveAreaDescriptionMetadata_Ljava_lang_String_Lcom_google_atap_tangoservice_TangoAreaDescriptionMetaData_, __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_SetBinder_Landroid_os_IBinder_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.atap.tango']/class[@name='TangoJNINative']/method[@name='SetBinder' and count(parameter)=1 and parameter[1][@type='android.os.IBinder']]"
		[Register ("SetBinder", "(Landroid/os/IBinder;)I", "")]
		public static unsafe int SetBinder (global::Android.OS.IBinder p0)
		{
			if (id_SetBinder_Landroid_os_IBinder_ == IntPtr.Zero)
				id_SetBinder_Landroid_os_IBinder_ = JNIEnv.GetStaticMethodID (class_ref, "SetBinder", "(Landroid/os/IBinder;)I");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				int __ret = JNIEnv.CallStaticIntMethod  (class_ref, id_SetBinder_Landroid_os_IBinder_, __args);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_SetRuntimeConfig_Lcom_google_atap_tangoservice_TangoConfig_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.atap.tango']/class[@name='TangoJNINative']/method[@name='SetRuntimeConfig' and count(parameter)=1 and parameter[1][@type='com.google.atap.tangoservice.TangoConfig']]"
		[Register ("SetRuntimeConfig", "(Lcom/google/atap/tangoservice/TangoConfig;)I", "")]
		public static unsafe int SetRuntimeConfig (global::Com.Google.Atap.Tangoservice.TangoConfig p0)
		{
			if (id_SetRuntimeConfig_Lcom_google_atap_tangoservice_TangoConfig_ == IntPtr.Zero)
				id_SetRuntimeConfig_Lcom_google_atap_tangoservice_TangoConfig_ = JNIEnv.GetStaticMethodID (class_ref, "SetRuntimeConfig", "(Lcom/google/atap/tangoservice/TangoConfig;)I");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				int __ret = JNIEnv.CallStaticIntMethod  (class_ref, id_SetRuntimeConfig_Lcom_google_atap_tangoservice_TangoConfig_, __args);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_UpdateTexture_IarrayD;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.atap.tango']/class[@name='TangoJNINative']/method[@name='UpdateTexture' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='double[]']]"
		[Register ("UpdateTexture", "(I[D)I", "")]
		public static unsafe int UpdateTexture (int p0, double[] p1)
		{
			if (id_UpdateTexture_IarrayD == IntPtr.Zero)
				id_UpdateTexture_IarrayD = JNIEnv.GetStaticMethodID (class_ref, "UpdateTexture", "(I[D)I");
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				int __ret = JNIEnv.CallStaticIntMethod  (class_ref, id_UpdateTexture_IarrayD, __args);
				return __ret;
			} finally {
				if (p1 != null) {
					JNIEnv.CopyArray (native_p1, p1);
					JNIEnv.DeleteLocalRef (native_p1);
				}
			}
		}

	}
}
