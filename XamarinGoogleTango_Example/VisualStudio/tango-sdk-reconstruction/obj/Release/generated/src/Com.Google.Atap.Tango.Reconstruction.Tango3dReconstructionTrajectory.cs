using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Google.Atap.Tango.Reconstruction {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.google.atap.tango.reconstruction']/class[@name='Tango3dReconstructionTrajectory']"
	[global::Android.Runtime.Register ("com/google/atap/tango/reconstruction/Tango3dReconstructionTrajectory", DoNotGenerateAcw=true)]
	public partial class Tango3dReconstructionTrajectory : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/google/atap/tango/reconstruction/Tango3dReconstructionTrajectory", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (Tango3dReconstructionTrajectory); }
		}

		protected Tango3dReconstructionTrajectory (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.google.atap.tango.reconstruction']/class[@name='Tango3dReconstructionTrajectory']/constructor[@name='Tango3dReconstructionTrajectory' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe Tango3dReconstructionTrajectory ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (Tango3dReconstructionTrajectory)) {
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

		static Delegate cb_getEarliestTime;
#pragma warning disable 0169
		static Delegate GetGetEarliestTimeHandler ()
		{
			if (cb_getEarliestTime == null)
				cb_getEarliestTime = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, double>) n_GetEarliestTime);
			return cb_getEarliestTime;
		}

		static double n_GetEarliestTime (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Google.Atap.Tango.Reconstruction.Tango3dReconstructionTrajectory __this = global::Java.Lang.Object.GetObject<global::Com.Google.Atap.Tango.Reconstruction.Tango3dReconstructionTrajectory> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.EarliestTime;
		}
#pragma warning restore 0169

		static IntPtr id_getEarliestTime;
		public virtual unsafe double EarliestTime {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.atap.tango.reconstruction']/class[@name='Tango3dReconstructionTrajectory']/method[@name='getEarliestTime' and count(parameter)=0]"
			[Register ("getEarliestTime", "()D", "GetGetEarliestTimeHandler")]
			get {
				if (id_getEarliestTime == IntPtr.Zero)
					id_getEarliestTime = JNIEnv.GetMethodID (class_ref, "getEarliestTime", "()D");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallDoubleMethod (((global::Java.Lang.Object) this).Handle, id_getEarliestTime);
					else
						return JNIEnv.CallNonvirtualDoubleMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getEarliestTime", "()D"));
				} finally {
				}
			}
		}

		static Delegate cb_getLatestTime;
#pragma warning disable 0169
		static Delegate GetGetLatestTimeHandler ()
		{
			if (cb_getLatestTime == null)
				cb_getLatestTime = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, double>) n_GetLatestTime);
			return cb_getLatestTime;
		}

		static double n_GetLatestTime (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Google.Atap.Tango.Reconstruction.Tango3dReconstructionTrajectory __this = global::Java.Lang.Object.GetObject<global::Com.Google.Atap.Tango.Reconstruction.Tango3dReconstructionTrajectory> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.LatestTime;
		}
#pragma warning restore 0169

		static IntPtr id_getLatestTime;
		public virtual unsafe double LatestTime {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.atap.tango.reconstruction']/class[@name='Tango3dReconstructionTrajectory']/method[@name='getLatestTime' and count(parameter)=0]"
			[Register ("getLatestTime", "()D", "GetGetLatestTimeHandler")]
			get {
				if (id_getLatestTime == IntPtr.Zero)
					id_getLatestTime = JNIEnv.GetMethodID (class_ref, "getLatestTime", "()D");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallDoubleMethod (((global::Java.Lang.Object) this).Handle, id_getLatestTime);
					else
						return JNIEnv.CallNonvirtualDoubleMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getLatestTime", "()D"));
				} finally {
				}
			}
		}

		static IntPtr id_createFromAreaDescription_Lcom_google_atap_tango_reconstruction_Tango3dReconstructionAreaDescription_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.atap.tango.reconstruction']/class[@name='Tango3dReconstructionTrajectory']/method[@name='createFromAreaDescription' and count(parameter)=1 and parameter[1][@type='com.google.atap.tango.reconstruction.Tango3dReconstructionAreaDescription']]"
		[Register ("createFromAreaDescription", "(Lcom/google/atap/tango/reconstruction/Tango3dReconstructionAreaDescription;)Lcom/google/atap/tango/reconstruction/Tango3dReconstructionTrajectory;", "")]
		public static unsafe global::Com.Google.Atap.Tango.Reconstruction.Tango3dReconstructionTrajectory CreateFromAreaDescription (global::Com.Google.Atap.Tango.Reconstruction.Tango3dReconstructionAreaDescription p0)
		{
			if (id_createFromAreaDescription_Lcom_google_atap_tango_reconstruction_Tango3dReconstructionAreaDescription_ == IntPtr.Zero)
				id_createFromAreaDescription_Lcom_google_atap_tango_reconstruction_Tango3dReconstructionAreaDescription_ = JNIEnv.GetStaticMethodID (class_ref, "createFromAreaDescription", "(Lcom/google/atap/tango/reconstruction/Tango3dReconstructionAreaDescription;)Lcom/google/atap/tango/reconstruction/Tango3dReconstructionTrajectory;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				global::Com.Google.Atap.Tango.Reconstruction.Tango3dReconstructionTrajectory __ret = global::Java.Lang.Object.GetObject<global::Com.Google.Atap.Tango.Reconstruction.Tango3dReconstructionTrajectory> (JNIEnv.CallStaticObjectMethod  (class_ref, id_createFromAreaDescription_Lcom_google_atap_tango_reconstruction_Tango3dReconstructionAreaDescription_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_finalize;
#pragma warning disable 0169
		static Delegate GetFinalizeHandler ()
		{
			if (cb_finalize == null)
				cb_finalize = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Finalize);
			return cb_finalize;
		}

		static void n_Finalize (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Google.Atap.Tango.Reconstruction.Tango3dReconstructionTrajectory __this = global::Java.Lang.Object.GetObject<global::Com.Google.Atap.Tango.Reconstruction.Tango3dReconstructionTrajectory> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Finalize ();
		}
#pragma warning restore 0169

		static IntPtr id_finalize;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.atap.tango.reconstruction']/class[@name='Tango3dReconstructionTrajectory']/method[@name='finalize' and count(parameter)=0]"
		[Register ("finalize", "()V", "GetFinalizeHandler")]
		public virtual unsafe void Finalize ()
		{
			if (id_finalize == IntPtr.Zero)
				id_finalize = JNIEnv.GetMethodID (class_ref, "finalize", "()V");
			try {

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_finalize);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "finalize", "()V"));
			} finally {
			}
		}

		static Delegate cb_getPoseAtTime_D;
#pragma warning disable 0169
		static Delegate GetGetPoseAtTime_DHandler ()
		{
			if (cb_getPoseAtTime_D == null)
				cb_getPoseAtTime_D = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, double, IntPtr>) n_GetPoseAtTime_D);
			return cb_getPoseAtTime_D;
		}

		static IntPtr n_GetPoseAtTime_D (IntPtr jnienv, IntPtr native__this, double p0)
		{
			global::Com.Google.Atap.Tango.Reconstruction.Tango3dReconstructionTrajectory __this = global::Java.Lang.Object.GetObject<global::Com.Google.Atap.Tango.Reconstruction.Tango3dReconstructionTrajectory> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.GetPoseAtTime (p0));
		}
#pragma warning restore 0169

		static IntPtr id_getPoseAtTime_D;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.atap.tango.reconstruction']/class[@name='Tango3dReconstructionTrajectory']/method[@name='getPoseAtTime' and count(parameter)=1 and parameter[1][@type='double']]"
		[Register ("getPoseAtTime", "(D)Lcom/google/atap/tangoservice/TangoPoseData;", "GetGetPoseAtTime_DHandler")]
		public virtual unsafe global::Com.Google.Atap.Tangoservice.TangoPoseData GetPoseAtTime (double p0)
		{
			if (id_getPoseAtTime_D == IntPtr.Zero)
				id_getPoseAtTime_D = JNIEnv.GetMethodID (class_ref, "getPoseAtTime", "(D)Lcom/google/atap/tangoservice/TangoPoseData;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Com.Google.Atap.Tangoservice.TangoPoseData> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getPoseAtTime_D, __args), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Com.Google.Atap.Tangoservice.TangoPoseData> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getPoseAtTime", "(D)Lcom/google/atap/tangoservice/TangoPoseData;"), __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_loadFromAdf_Ljava_io_File_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.atap.tango.reconstruction']/class[@name='Tango3dReconstructionTrajectory']/method[@name='loadFromAdf' and count(parameter)=1 and parameter[1][@type='java.io.File']]"
		[Register ("loadFromAdf", "(Ljava/io/File;)Lcom/google/atap/tango/reconstruction/Tango3dReconstructionTrajectory;", "")]
		public static unsafe global::Com.Google.Atap.Tango.Reconstruction.Tango3dReconstructionTrajectory LoadFromAdf (global::Java.IO.File p0)
		{
			if (id_loadFromAdf_Ljava_io_File_ == IntPtr.Zero)
				id_loadFromAdf_Ljava_io_File_ = JNIEnv.GetStaticMethodID (class_ref, "loadFromAdf", "(Ljava/io/File;)Lcom/google/atap/tango/reconstruction/Tango3dReconstructionTrajectory;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				global::Com.Google.Atap.Tango.Reconstruction.Tango3dReconstructionTrajectory __ret = global::Java.Lang.Object.GetObject<global::Com.Google.Atap.Tango.Reconstruction.Tango3dReconstructionTrajectory> (JNIEnv.CallStaticObjectMethod  (class_ref, id_loadFromAdf_Ljava_io_File_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_release;
#pragma warning disable 0169
		static Delegate GetReleaseHandler ()
		{
			if (cb_release == null)
				cb_release = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Release);
			return cb_release;
		}

		static void n_Release (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Google.Atap.Tango.Reconstruction.Tango3dReconstructionTrajectory __this = global::Java.Lang.Object.GetObject<global::Com.Google.Atap.Tango.Reconstruction.Tango3dReconstructionTrajectory> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Release ();
		}
#pragma warning restore 0169

		static IntPtr id_release;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.atap.tango.reconstruction']/class[@name='Tango3dReconstructionTrajectory']/method[@name='release' and count(parameter)=0]"
		[Register ("release", "()V", "GetReleaseHandler")]
		public virtual unsafe void Release ()
		{
			if (id_release == IntPtr.Zero)
				id_release = JNIEnv.GetMethodID (class_ref, "release", "()V");
			try {

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_release);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "release", "()V"));
			} finally {
			}
		}

	}
}
