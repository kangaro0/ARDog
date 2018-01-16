using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Google.Atap.Tangoservice {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.google.atap.tangoservice']/class[@name='TangoCameraNativeLoader']"
	[global::Android.Runtime.Register ("com/google/atap/tangoservice/TangoCameraNativeLoader", DoNotGenerateAcw=true)]
	public partial class TangoCameraNativeLoader : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/google/atap/tangoservice/TangoCameraNativeLoader", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (TangoCameraNativeLoader); }
		}

		protected TangoCameraNativeLoader (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.google.atap.tangoservice']/class[@name='TangoCameraNativeLoader']/constructor[@name='TangoCameraNativeLoader' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe TangoCameraNativeLoader ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (TangoCameraNativeLoader)) {
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

		static IntPtr id_connectOnFrameAvailable_ILcom_google_atap_tangoservice_Tango_OnFrameAvailableListener_Lcom_google_atap_tangoservice_experimental_TangoImageBuffer_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.atap.tangoservice']/class[@name='TangoCameraNativeLoader']/method[@name='connectOnFrameAvailable' and count(parameter)=4 and parameter[1][@type='int'] and parameter[2][@type='com.google.atap.tangoservice.Tango.OnFrameAvailableListener'] and parameter[3][@type='com.google.atap.tangoservice.experimental.TangoImageBuffer'] and parameter[4][@type='boolean']]"
		[Register ("connectOnFrameAvailable", "(ILcom/google/atap/tangoservice/Tango$OnFrameAvailableListener;Lcom/google/atap/tangoservice/experimental/TangoImageBuffer;Z)I", "")]
		public static unsafe int ConnectOnFrameAvailable (int p0, global::Com.Google.Atap.Tangoservice.Tango.IOnFrameAvailableListener p1, global::Com.Google.Atap.Tangoservice.Experimental.TangoImageBuffer p2, bool p3)
		{
			if (id_connectOnFrameAvailable_ILcom_google_atap_tangoservice_Tango_OnFrameAvailableListener_Lcom_google_atap_tangoservice_experimental_TangoImageBuffer_Z == IntPtr.Zero)
				id_connectOnFrameAvailable_ILcom_google_atap_tangoservice_Tango_OnFrameAvailableListener_Lcom_google_atap_tangoservice_experimental_TangoImageBuffer_Z = JNIEnv.GetStaticMethodID (class_ref, "connectOnFrameAvailable", "(ILcom/google/atap/tangoservice/Tango$OnFrameAvailableListener;Lcom/google/atap/tangoservice/experimental/TangoImageBuffer;Z)I");
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				int __ret = JNIEnv.CallStaticIntMethod  (class_ref, id_connectOnFrameAvailable_ILcom_google_atap_tangoservice_Tango_OnFrameAvailableListener_Lcom_google_atap_tangoservice_experimental_TangoImageBuffer_Z, __args);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_connectOnTextureAvailable_IZ;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.atap.tangoservice']/class[@name='TangoCameraNativeLoader']/method[@name='connectOnTextureAvailable' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='boolean']]"
		[Register ("connectOnTextureAvailable", "(IZ)I", "")]
		public static unsafe int ConnectOnTextureAvailable (int p0, bool p1)
		{
			if (id_connectOnTextureAvailable_IZ == IntPtr.Zero)
				id_connectOnTextureAvailable_IZ = JNIEnv.GetStaticMethodID (class_ref, "connectOnTextureAvailable", "(IZ)I");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				return JNIEnv.CallStaticIntMethod  (class_ref, id_connectOnTextureAvailable_IZ, __args);
			} finally {
			}
		}

		static IntPtr id_connectTextureId_IIZ;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.atap.tangoservice']/class[@name='TangoCameraNativeLoader']/method[@name='connectTextureId' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='boolean']]"
		[Register ("connectTextureId", "(IIZ)I", "")]
		public static unsafe int ConnectTextureId (int p0, int p1, bool p2)
		{
			if (id_connectTextureId_IIZ == IntPtr.Zero)
				id_connectTextureId_IIZ = JNIEnv.GetStaticMethodID (class_ref, "connectTextureId", "(IIZ)I");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				return JNIEnv.CallStaticIntMethod  (class_ref, id_connectTextureId_IIZ, __args);
			} finally {
			}
		}

		static IntPtr id_disconnectCamera_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.atap.tangoservice']/class[@name='TangoCameraNativeLoader']/method[@name='disconnectCamera' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("disconnectCamera", "(I)I", "")]
		public static unsafe int DisconnectCamera (int p0)
		{
			if (id_disconnectCamera_I == IntPtr.Zero)
				id_disconnectCamera_I = JNIEnv.GetStaticMethodID (class_ref, "disconnectCamera", "(I)I");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				return JNIEnv.CallStaticIntMethod  (class_ref, id_disconnectCamera_I, __args);
			} finally {
			}
		}

		static IntPtr id_initialize_Landroid_content_Context_Lcom_google_atap_tangoservice_ITangoListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.atap.tangoservice']/class[@name='TangoCameraNativeLoader']/method[@name='initialize' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='com.google.atap.tangoservice.ITangoListener']]"
		[Register ("initialize", "(Landroid/content/Context;Lcom/google/atap/tangoservice/ITangoListener;)I", "")]
		public static unsafe int Initialize (global::Android.Content.Context p0, global::Com.Google.Atap.Tangoservice.ITangoListener p1)
		{
			if (id_initialize_Landroid_content_Context_Lcom_google_atap_tangoservice_ITangoListener_ == IntPtr.Zero)
				id_initialize_Landroid_content_Context_Lcom_google_atap_tangoservice_ITangoListener_ = JNIEnv.GetStaticMethodID (class_ref, "initialize", "(Landroid/content/Context;Lcom/google/atap/tangoservice/ITangoListener;)I");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				int __ret = JNIEnv.CallStaticIntMethod  (class_ref, id_initialize_Landroid_content_Context_Lcom_google_atap_tangoservice_ITangoListener_, __args);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_lockCameraBuffer_IarrayDarrayJ;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.atap.tangoservice']/class[@name='TangoCameraNativeLoader']/method[@name='lockCameraBuffer' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='double[]'] and parameter[3][@type='long[]']]"
		[Register ("lockCameraBuffer", "(I[D[J)I", "")]
		public static unsafe int LockCameraBuffer (int p0, double[] p1, long[] p2)
		{
			if (id_lockCameraBuffer_IarrayDarrayJ == IntPtr.Zero)
				id_lockCameraBuffer_IarrayDarrayJ = JNIEnv.GetStaticMethodID (class_ref, "lockCameraBuffer", "(I[D[J)I");
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			IntPtr native_p2 = JNIEnv.NewArray (p2);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (native_p2);
				int __ret = JNIEnv.CallStaticIntMethod  (class_ref, id_lockCameraBuffer_IarrayDarrayJ, __args);
				return __ret;
			} finally {
				if (p1 != null) {
					JNIEnv.CopyArray (native_p1, p1);
					JNIEnv.DeleteLocalRef (native_p1);
				}
				if (p2 != null) {
					JNIEnv.CopyArray (native_p2, p2);
					JNIEnv.DeleteLocalRef (native_p2);
				}
			}
		}

		static IntPtr id_startCamerasIfNeeded;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.atap.tangoservice']/class[@name='TangoCameraNativeLoader']/method[@name='startCamerasIfNeeded' and count(parameter)=0]"
		[Register ("startCamerasIfNeeded", "()I", "")]
		public static unsafe int StartCamerasIfNeeded ()
		{
			if (id_startCamerasIfNeeded == IntPtr.Zero)
				id_startCamerasIfNeeded = JNIEnv.GetStaticMethodID (class_ref, "startCamerasIfNeeded", "()I");
			try {
				return JNIEnv.CallStaticIntMethod  (class_ref, id_startCamerasIfNeeded);
			} finally {
			}
		}

		static IntPtr id_stopAllCameras;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.atap.tangoservice']/class[@name='TangoCameraNativeLoader']/method[@name='stopAllCameras' and count(parameter)=0]"
		[Register ("stopAllCameras", "()I", "")]
		public static unsafe int StopAllCameras ()
		{
			if (id_stopAllCameras == IntPtr.Zero)
				id_stopAllCameras = JNIEnv.GetStaticMethodID (class_ref, "stopAllCameras", "()I");
			try {
				return JNIEnv.CallStaticIntMethod  (class_ref, id_stopAllCameras);
			} finally {
			}
		}

		static IntPtr id_unlockCameraBuffer_IJ;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.atap.tangoservice']/class[@name='TangoCameraNativeLoader']/method[@name='unlockCameraBuffer' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='long']]"
		[Register ("unlockCameraBuffer", "(IJ)I", "")]
		public static unsafe int UnlockCameraBuffer (int p0, long p1)
		{
			if (id_unlockCameraBuffer_IJ == IntPtr.Zero)
				id_unlockCameraBuffer_IJ = JNIEnv.GetStaticMethodID (class_ref, "unlockCameraBuffer", "(IJ)I");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				return JNIEnv.CallStaticIntMethod  (class_ref, id_unlockCameraBuffer_IJ, __args);
			} finally {
			}
		}

		static IntPtr id_updateTexture_IarrayD;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.atap.tangoservice']/class[@name='TangoCameraNativeLoader']/method[@name='updateTexture' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='double[]']]"
		[Register ("updateTexture", "(I[D)I", "")]
		public static unsafe int UpdateTexture (int p0, double[] p1)
		{
			if (id_updateTexture_IarrayD == IntPtr.Zero)
				id_updateTexture_IarrayD = JNIEnv.GetStaticMethodID (class_ref, "updateTexture", "(I[D)I");
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				int __ret = JNIEnv.CallStaticIntMethod  (class_ref, id_updateTexture_IarrayD, __args);
				return __ret;
			} finally {
				if (p1 != null) {
					JNIEnv.CopyArray (native_p1, p1);
					JNIEnv.DeleteLocalRef (native_p1);
				}
			}
		}

		static IntPtr id_updateTextureExternalOes_IIarrayD;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.atap.tangoservice']/class[@name='TangoCameraNativeLoader']/method[@name='updateTextureExternalOes' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='double[]']]"
		[Register ("updateTextureExternalOes", "(II[D)I", "")]
		public static unsafe int UpdateTextureExternalOes (int p0, int p1, double[] p2)
		{
			if (id_updateTextureExternalOes_IIarrayD == IntPtr.Zero)
				id_updateTextureExternalOes_IIarrayD = JNIEnv.GetStaticMethodID (class_ref, "updateTextureExternalOes", "(II[D)I");
			IntPtr native_p2 = JNIEnv.NewArray (p2);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (native_p2);
				int __ret = JNIEnv.CallStaticIntMethod  (class_ref, id_updateTextureExternalOes_IIarrayD, __args);
				return __ret;
			} finally {
				if (p2 != null) {
					JNIEnv.CopyArray (native_p2, p2);
					JNIEnv.DeleteLocalRef (native_p2);
				}
			}
		}

		static IntPtr id_updateTextureExternalOesForBuffer_IIJ;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.atap.tangoservice']/class[@name='TangoCameraNativeLoader']/method[@name='updateTextureExternalOesForBuffer' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='long']]"
		[Register ("updateTextureExternalOesForBuffer", "(IIJ)I", "")]
		public static unsafe int UpdateTextureExternalOesForBuffer (int p0, int p1, long p2)
		{
			if (id_updateTextureExternalOesForBuffer_IIJ == IntPtr.Zero)
				id_updateTextureExternalOesForBuffer_IIJ = JNIEnv.GetStaticMethodID (class_ref, "updateTextureExternalOesForBuffer", "(IIJ)I");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				return JNIEnv.CallStaticIntMethod  (class_ref, id_updateTextureExternalOesForBuffer_IIJ, __args);
			} finally {
			}
		}

	}
}
