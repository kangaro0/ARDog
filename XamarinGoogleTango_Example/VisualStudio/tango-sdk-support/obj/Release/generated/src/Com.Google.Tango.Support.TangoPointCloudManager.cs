using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Google.Tango.Support {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.google.tango.support']/class[@name='TangoPointCloudManager']"
	[global::Android.Runtime.Register ("com/google/tango/support/TangoPointCloudManager", DoNotGenerateAcw=true)]
	public partial class TangoPointCloudManager : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/google/tango/support/TangoPointCloudManager", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (TangoPointCloudManager); }
		}

		protected TangoPointCloudManager (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.google.tango.support']/class[@name='TangoPointCloudManager']/constructor[@name='TangoPointCloudManager' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe TangoPointCloudManager ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (TangoPointCloudManager)) {
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

		static Delegate cb_getLatestPointCloud;
#pragma warning disable 0169
		static Delegate GetGetLatestPointCloudHandler ()
		{
			if (cb_getLatestPointCloud == null)
				cb_getLatestPointCloud = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetLatestPointCloud);
			return cb_getLatestPointCloud;
		}

		static IntPtr n_GetLatestPointCloud (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Google.Tango.Support.TangoPointCloudManager __this = global::Java.Lang.Object.GetObject<global::Com.Google.Tango.Support.TangoPointCloudManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.LatestPointCloud);
		}
#pragma warning restore 0169

		static IntPtr id_getLatestPointCloud;
		public virtual unsafe global::Com.Google.Atap.Tangoservice.TangoPointCloudData LatestPointCloud {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.tango.support']/class[@name='TangoPointCloudManager']/method[@name='getLatestPointCloud' and count(parameter)=0]"
			[Register ("getLatestPointCloud", "()Lcom/google/atap/tangoservice/TangoPointCloudData;", "GetGetLatestPointCloudHandler")]
			get {
				if (id_getLatestPointCloud == IntPtr.Zero)
					id_getLatestPointCloud = JNIEnv.GetMethodID (class_ref, "getLatestPointCloud", "()Lcom/google/atap/tangoservice/TangoPointCloudData;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Com.Google.Atap.Tangoservice.TangoPointCloudData> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getLatestPointCloud), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Com.Google.Atap.Tangoservice.TangoPointCloudData> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getLatestPointCloud", "()Lcom/google/atap/tangoservice/TangoPointCloudData;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_updatePointCloud_Lcom_google_atap_tangoservice_TangoPointCloudData_;
#pragma warning disable 0169
		static Delegate GetUpdatePointCloud_Lcom_google_atap_tangoservice_TangoPointCloudData_Handler ()
		{
			if (cb_updatePointCloud_Lcom_google_atap_tangoservice_TangoPointCloudData_ == null)
				cb_updatePointCloud_Lcom_google_atap_tangoservice_TangoPointCloudData_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_UpdatePointCloud_Lcom_google_atap_tangoservice_TangoPointCloudData_);
			return cb_updatePointCloud_Lcom_google_atap_tangoservice_TangoPointCloudData_;
		}

		static void n_UpdatePointCloud_Lcom_google_atap_tangoservice_TangoPointCloudData_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Google.Tango.Support.TangoPointCloudManager __this = global::Java.Lang.Object.GetObject<global::Com.Google.Tango.Support.TangoPointCloudManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Google.Atap.Tangoservice.TangoPointCloudData p0 = global::Java.Lang.Object.GetObject<global::Com.Google.Atap.Tangoservice.TangoPointCloudData> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.UpdatePointCloud (p0);
		}
#pragma warning restore 0169

		static IntPtr id_updatePointCloud_Lcom_google_atap_tangoservice_TangoPointCloudData_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.tango.support']/class[@name='TangoPointCloudManager']/method[@name='updatePointCloud' and count(parameter)=1 and parameter[1][@type='com.google.atap.tangoservice.TangoPointCloudData']]"
		[Register ("updatePointCloud", "(Lcom/google/atap/tangoservice/TangoPointCloudData;)V", "GetUpdatePointCloud_Lcom_google_atap_tangoservice_TangoPointCloudData_Handler")]
		public virtual unsafe void UpdatePointCloud (global::Com.Google.Atap.Tangoservice.TangoPointCloudData p0)
		{
			if (id_updatePointCloud_Lcom_google_atap_tangoservice_TangoPointCloudData_ == IntPtr.Zero)
				id_updatePointCloud_Lcom_google_atap_tangoservice_TangoPointCloudData_ = JNIEnv.GetMethodID (class_ref, "updatePointCloud", "(Lcom/google/atap/tangoservice/TangoPointCloudData;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_updatePointCloud_Lcom_google_atap_tangoservice_TangoPointCloudData_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "updatePointCloud", "(Lcom/google/atap/tangoservice/TangoPointCloudData;)V"), __args);
			} finally {
			}
		}

	}
}
