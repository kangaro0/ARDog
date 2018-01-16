using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Google.Atap.Tangoservice.Experimental {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.google.atap.tangoservice.experimental']/class[@name='TangoFrameOfInterest']"
	[global::Android.Runtime.Register ("com/google/atap/tangoservice/experimental/TangoFrameOfInterest", DoNotGenerateAcw=true)]
	public partial class TangoFrameOfInterest : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/google/atap/tangoservice/experimental/TangoFrameOfInterest", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (TangoFrameOfInterest); }
		}

		protected TangoFrameOfInterest (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.google.atap.tangoservice.experimental']/class[@name='TangoFrameOfInterest']/constructor[@name='TangoFrameOfInterest' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe TangoFrameOfInterest ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (TangoFrameOfInterest)) {
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

		static Delegate cb_createFrameOfInterest_DLjava_util_UUID_Lcom_google_atap_tangoservice_experimental_TangoTransformation_;
#pragma warning disable 0169
		static Delegate GetCreateFrameOfInterest_DLjava_util_UUID_Lcom_google_atap_tangoservice_experimental_TangoTransformation_Handler ()
		{
			if (cb_createFrameOfInterest_DLjava_util_UUID_Lcom_google_atap_tangoservice_experimental_TangoTransformation_ == null)
				cb_createFrameOfInterest_DLjava_util_UUID_Lcom_google_atap_tangoservice_experimental_TangoTransformation_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, double, IntPtr, IntPtr, IntPtr>) n_CreateFrameOfInterest_DLjava_util_UUID_Lcom_google_atap_tangoservice_experimental_TangoTransformation_);
			return cb_createFrameOfInterest_DLjava_util_UUID_Lcom_google_atap_tangoservice_experimental_TangoTransformation_;
		}

		static IntPtr n_CreateFrameOfInterest_DLjava_util_UUID_Lcom_google_atap_tangoservice_experimental_TangoTransformation_ (IntPtr jnienv, IntPtr native__this, double p0, IntPtr native_p1, IntPtr native_p2)
		{
			global::Com.Google.Atap.Tangoservice.Experimental.TangoFrameOfInterest __this = global::Java.Lang.Object.GetObject<global::Com.Google.Atap.Tangoservice.Experimental.TangoFrameOfInterest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Util.UUID p1 = global::Java.Lang.Object.GetObject<global::Java.Util.UUID> (native_p1, JniHandleOwnership.DoNotTransfer);
			global::Com.Google.Atap.Tangoservice.Experimental.TangoTransformation p2 = global::Java.Lang.Object.GetObject<global::Com.Google.Atap.Tangoservice.Experimental.TangoTransformation> (native_p2, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.CreateFrameOfInterest (p0, p1, p2));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_createFrameOfInterest_DLjava_util_UUID_Lcom_google_atap_tangoservice_experimental_TangoTransformation_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.atap.tangoservice.experimental']/class[@name='TangoFrameOfInterest']/method[@name='createFrameOfInterest' and count(parameter)=3 and parameter[1][@type='double'] and parameter[2][@type='java.util.UUID'] and parameter[3][@type='com.google.atap.tangoservice.experimental.TangoTransformation']]"
		[Register ("createFrameOfInterest", "(DLjava/util/UUID;Lcom/google/atap/tangoservice/experimental/TangoTransformation;)Ljava/util/UUID;", "GetCreateFrameOfInterest_DLjava_util_UUID_Lcom_google_atap_tangoservice_experimental_TangoTransformation_Handler")]
		public virtual unsafe global::Java.Util.UUID CreateFrameOfInterest (double p0, global::Java.Util.UUID p1, global::Com.Google.Atap.Tangoservice.Experimental.TangoTransformation p2)
		{
			if (id_createFrameOfInterest_DLjava_util_UUID_Lcom_google_atap_tangoservice_experimental_TangoTransformation_ == IntPtr.Zero)
				id_createFrameOfInterest_DLjava_util_UUID_Lcom_google_atap_tangoservice_experimental_TangoTransformation_ = JNIEnv.GetMethodID (class_ref, "createFrameOfInterest", "(DLjava/util/UUID;Lcom/google/atap/tangoservice/experimental/TangoTransformation;)Ljava/util/UUID;");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);

				global::Java.Util.UUID __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Java.Util.UUID> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_createFrameOfInterest_DLjava_util_UUID_Lcom_google_atap_tangoservice_experimental_TangoTransformation_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Java.Util.UUID> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "createFrameOfInterest", "(DLjava/util/UUID;Lcom/google/atap/tangoservice/experimental/TangoTransformation;)Ljava/util/UUID;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_deleteFrameOfInterest_Ljava_util_UUID_;
#pragma warning disable 0169
		static Delegate GetDeleteFrameOfInterest_Ljava_util_UUID_Handler ()
		{
			if (cb_deleteFrameOfInterest_Ljava_util_UUID_ == null)
				cb_deleteFrameOfInterest_Ljava_util_UUID_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_DeleteFrameOfInterest_Ljava_util_UUID_);
			return cb_deleteFrameOfInterest_Ljava_util_UUID_;
		}

		static void n_DeleteFrameOfInterest_Ljava_util_UUID_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Google.Atap.Tangoservice.Experimental.TangoFrameOfInterest __this = global::Java.Lang.Object.GetObject<global::Com.Google.Atap.Tangoservice.Experimental.TangoFrameOfInterest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Util.UUID p0 = global::Java.Lang.Object.GetObject<global::Java.Util.UUID> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.DeleteFrameOfInterest (p0);
		}
#pragma warning restore 0169

		static IntPtr id_deleteFrameOfInterest_Ljava_util_UUID_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.atap.tangoservice.experimental']/class[@name='TangoFrameOfInterest']/method[@name='deleteFrameOfInterest' and count(parameter)=1 and parameter[1][@type='java.util.UUID']]"
		[Register ("deleteFrameOfInterest", "(Ljava/util/UUID;)V", "GetDeleteFrameOfInterest_Ljava_util_UUID_Handler")]
		public virtual unsafe void DeleteFrameOfInterest (global::Java.Util.UUID p0)
		{
			if (id_deleteFrameOfInterest_Ljava_util_UUID_ == IntPtr.Zero)
				id_deleteFrameOfInterest_Ljava_util_UUID_ = JNIEnv.GetMethodID (class_ref, "deleteFrameOfInterest", "(Ljava/util/UUID;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_deleteFrameOfInterest_Ljava_util_UUID_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "deleteFrameOfInterest", "(Ljava/util/UUID;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_updateFrameOfInterest_DLjava_util_UUID_Lcom_google_atap_tangoservice_experimental_TangoTransformation_Ljava_util_UUID_;
#pragma warning disable 0169
		static Delegate GetUpdateFrameOfInterest_DLjava_util_UUID_Lcom_google_atap_tangoservice_experimental_TangoTransformation_Ljava_util_UUID_Handler ()
		{
			if (cb_updateFrameOfInterest_DLjava_util_UUID_Lcom_google_atap_tangoservice_experimental_TangoTransformation_Ljava_util_UUID_ == null)
				cb_updateFrameOfInterest_DLjava_util_UUID_Lcom_google_atap_tangoservice_experimental_TangoTransformation_Ljava_util_UUID_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, double, IntPtr, IntPtr, IntPtr>) n_UpdateFrameOfInterest_DLjava_util_UUID_Lcom_google_atap_tangoservice_experimental_TangoTransformation_Ljava_util_UUID_);
			return cb_updateFrameOfInterest_DLjava_util_UUID_Lcom_google_atap_tangoservice_experimental_TangoTransformation_Ljava_util_UUID_;
		}

		static void n_UpdateFrameOfInterest_DLjava_util_UUID_Lcom_google_atap_tangoservice_experimental_TangoTransformation_Ljava_util_UUID_ (IntPtr jnienv, IntPtr native__this, double p0, IntPtr native_p1, IntPtr native_p2, IntPtr native_p3)
		{
			global::Com.Google.Atap.Tangoservice.Experimental.TangoFrameOfInterest __this = global::Java.Lang.Object.GetObject<global::Com.Google.Atap.Tangoservice.Experimental.TangoFrameOfInterest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Util.UUID p1 = global::Java.Lang.Object.GetObject<global::Java.Util.UUID> (native_p1, JniHandleOwnership.DoNotTransfer);
			global::Com.Google.Atap.Tangoservice.Experimental.TangoTransformation p2 = global::Java.Lang.Object.GetObject<global::Com.Google.Atap.Tangoservice.Experimental.TangoTransformation> (native_p2, JniHandleOwnership.DoNotTransfer);
			global::Java.Util.UUID p3 = global::Java.Lang.Object.GetObject<global::Java.Util.UUID> (native_p3, JniHandleOwnership.DoNotTransfer);
			__this.UpdateFrameOfInterest (p0, p1, p2, p3);
		}
#pragma warning restore 0169

		static IntPtr id_updateFrameOfInterest_DLjava_util_UUID_Lcom_google_atap_tangoservice_experimental_TangoTransformation_Ljava_util_UUID_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.atap.tangoservice.experimental']/class[@name='TangoFrameOfInterest']/method[@name='updateFrameOfInterest' and count(parameter)=4 and parameter[1][@type='double'] and parameter[2][@type='java.util.UUID'] and parameter[3][@type='com.google.atap.tangoservice.experimental.TangoTransformation'] and parameter[4][@type='java.util.UUID']]"
		[Register ("updateFrameOfInterest", "(DLjava/util/UUID;Lcom/google/atap/tangoservice/experimental/TangoTransformation;Ljava/util/UUID;)V", "GetUpdateFrameOfInterest_DLjava_util_UUID_Lcom_google_atap_tangoservice_experimental_TangoTransformation_Ljava_util_UUID_Handler")]
		public virtual unsafe void UpdateFrameOfInterest (double p0, global::Java.Util.UUID p1, global::Com.Google.Atap.Tangoservice.Experimental.TangoTransformation p2, global::Java.Util.UUID p3)
		{
			if (id_updateFrameOfInterest_DLjava_util_UUID_Lcom_google_atap_tangoservice_experimental_TangoTransformation_Ljava_util_UUID_ == IntPtr.Zero)
				id_updateFrameOfInterest_DLjava_util_UUID_Lcom_google_atap_tangoservice_experimental_TangoTransformation_Ljava_util_UUID_ = JNIEnv.GetMethodID (class_ref, "updateFrameOfInterest", "(DLjava/util/UUID;Lcom/google/atap/tangoservice/experimental/TangoTransformation;Ljava/util/UUID;)V");
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_updateFrameOfInterest_DLjava_util_UUID_Lcom_google_atap_tangoservice_experimental_TangoTransformation_Ljava_util_UUID_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "updateFrameOfInterest", "(DLjava/util/UUID;Lcom/google/atap/tangoservice/experimental/TangoTransformation;Ljava/util/UUID;)V"), __args);
			} finally {
			}
		}

	}
}
