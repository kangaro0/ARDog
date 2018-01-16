using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Google.Atap.Tango.Reconstruction {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.google.atap.tango.reconstruction']/class[@name='Tango3dReconstructionTexturing']"
	[global::Android.Runtime.Register ("com/google/atap/tango/reconstruction/Tango3dReconstructionTexturing", DoNotGenerateAcw=true)]
	public partial class Tango3dReconstructionTexturing : global::Java.Lang.Object {

		// Metadata.xml XPath interface reference: path="/api/package[@name='com.google.atap.tango.reconstruction']/interface[@name='Tango3dReconstructionTexturing.ProgressCallback']"
		[Register ("com/google/atap/tango/reconstruction/Tango3dReconstructionTexturing$ProgressCallback", "", "Com.Google.Atap.Tango.Reconstruction.Tango3dReconstructionTexturing/IProgressCallbackInvoker")]
		public partial interface IProgressCallback : IJavaObject {

			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.atap.tango.reconstruction']/interface[@name='Tango3dReconstructionTexturing.ProgressCallback']/method[@name='onProgress' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("onProgress", "(I)V", "GetOnProgress_IHandler:Com.Google.Atap.Tango.Reconstruction.Tango3dReconstructionTexturing/IProgressCallbackInvoker, tango-sdk-reconstruction")]
			void OnProgress (int p0);

		}

		[global::Android.Runtime.Register ("com/google/atap/tango/reconstruction/Tango3dReconstructionTexturing$ProgressCallback", DoNotGenerateAcw=true)]
		internal class IProgressCallbackInvoker : global::Java.Lang.Object, IProgressCallback {

			static IntPtr java_class_ref = JNIEnv.FindClass ("com/google/atap/tango/reconstruction/Tango3dReconstructionTexturing$ProgressCallback");

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (IProgressCallbackInvoker); }
			}

			IntPtr class_ref;

			public static IProgressCallback GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IProgressCallback> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.google.atap.tango.reconstruction.Tango3dReconstructionTexturing.ProgressCallback"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IProgressCallbackInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			static Delegate cb_onProgress_I;
#pragma warning disable 0169
			static Delegate GetOnProgress_IHandler ()
			{
				if (cb_onProgress_I == null)
					cb_onProgress_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_OnProgress_I);
				return cb_onProgress_I;
			}

			static void n_OnProgress_I (IntPtr jnienv, IntPtr native__this, int p0)
			{
				global::Com.Google.Atap.Tango.Reconstruction.Tango3dReconstructionTexturing.IProgressCallback __this = global::Java.Lang.Object.GetObject<global::Com.Google.Atap.Tango.Reconstruction.Tango3dReconstructionTexturing.IProgressCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.OnProgress (p0);
			}
#pragma warning restore 0169

			IntPtr id_onProgress_I;
			public unsafe void OnProgress (int p0)
			{
				if (id_onProgress_I == IntPtr.Zero)
					id_onProgress_I = JNIEnv.GetMethodID (class_ref, "onProgress", "(I)V");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onProgress_I, __args);
			}

		}


		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/google/atap/tango/reconstruction/Tango3dReconstructionTexturing", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (Tango3dReconstructionTexturing); }
		}

		protected Tango3dReconstructionTexturing (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Lcom_google_atap_tango_reconstruction_Tango3dReconstructionConfig_Lcom_google_atap_tango_mesh_TangoMesh_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.google.atap.tango.reconstruction']/class[@name='Tango3dReconstructionTexturing']/constructor[@name='Tango3dReconstructionTexturing' and count(parameter)=2 and parameter[1][@type='com.google.atap.tango.reconstruction.Tango3dReconstructionConfig'] and parameter[2][@type='com.google.atap.tango.mesh.TangoMesh']]"
		[Register (".ctor", "(Lcom/google/atap/tango/reconstruction/Tango3dReconstructionConfig;Lcom/google/atap/tango/mesh/TangoMesh;)V", "")]
		public unsafe Tango3dReconstructionTexturing (global::Com.Google.Atap.Tango.Reconstruction.Tango3dReconstructionConfig p0, global::Com.Google.Atap.Tango.Mesh.TangoMesh p1)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				if (GetType () != typeof (Tango3dReconstructionTexturing)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Lcom/google/atap/tango/reconstruction/Tango3dReconstructionConfig;Lcom/google/atap/tango/mesh/TangoMesh;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Lcom/google/atap/tango/reconstruction/Tango3dReconstructionConfig;Lcom/google/atap/tango/mesh/TangoMesh;)V", __args);
					return;
				}

				if (id_ctor_Lcom_google_atap_tango_reconstruction_Tango3dReconstructionConfig_Lcom_google_atap_tango_mesh_TangoMesh_ == IntPtr.Zero)
					id_ctor_Lcom_google_atap_tango_reconstruction_Tango3dReconstructionConfig_Lcom_google_atap_tango_mesh_TangoMesh_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/google/atap/tango/reconstruction/Tango3dReconstructionConfig;Lcom/google/atap/tango/mesh/TangoMesh;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_google_atap_tango_reconstruction_Tango3dReconstructionConfig_Lcom_google_atap_tango_mesh_TangoMesh_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Lcom_google_atap_tango_reconstruction_Tango3dReconstructionConfig_Lcom_google_atap_tango_mesh_TangoMesh_, __args);
			} finally {
			}
		}

		static Delegate cb_getTexturedMesh;
#pragma warning disable 0169
		static Delegate GetGetTexturedMeshHandler ()
		{
			if (cb_getTexturedMesh == null)
				cb_getTexturedMesh = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetTexturedMesh);
			return cb_getTexturedMesh;
		}

		static IntPtr n_GetTexturedMesh (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Google.Atap.Tango.Reconstruction.Tango3dReconstructionTexturing __this = global::Java.Lang.Object.GetObject<global::Com.Google.Atap.Tango.Reconstruction.Tango3dReconstructionTexturing> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.TexturedMesh);
		}
#pragma warning restore 0169

		static IntPtr id_getTexturedMesh;
		public virtual unsafe global::Com.Google.Atap.Tango.Mesh.TangoMesh TexturedMesh {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.atap.tango.reconstruction']/class[@name='Tango3dReconstructionTexturing']/method[@name='getTexturedMesh' and count(parameter)=0]"
			[Register ("getTexturedMesh", "()Lcom/google/atap/tango/mesh/TangoMesh;", "GetGetTexturedMeshHandler")]
			get {
				if (id_getTexturedMesh == IntPtr.Zero)
					id_getTexturedMesh = JNIEnv.GetMethodID (class_ref, "getTexturedMesh", "()Lcom/google/atap/tango/mesh/TangoMesh;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Com.Google.Atap.Tango.Mesh.TangoMesh> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getTexturedMesh), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Com.Google.Atap.Tango.Mesh.TangoMesh> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getTexturedMesh", "()Lcom/google/atap/tango/mesh/TangoMesh;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
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
			global::Com.Google.Atap.Tango.Reconstruction.Tango3dReconstructionTexturing __this = global::Java.Lang.Object.GetObject<global::Com.Google.Atap.Tango.Reconstruction.Tango3dReconstructionTexturing> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Finalize ();
		}
#pragma warning restore 0169

		static IntPtr id_finalize;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.atap.tango.reconstruction']/class[@name='Tango3dReconstructionTexturing']/method[@name='finalize' and count(parameter)=0]"
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
			global::Com.Google.Atap.Tango.Reconstruction.Tango3dReconstructionTexturing __this = global::Java.Lang.Object.GetObject<global::Com.Google.Atap.Tango.Reconstruction.Tango3dReconstructionTexturing> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Release ();
		}
#pragma warning restore 0169

		static IntPtr id_release;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.atap.tango.reconstruction']/class[@name='Tango3dReconstructionTexturing']/method[@name='release' and count(parameter)=0]"
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

		static Delegate cb_setColorCalibration_Lcom_google_atap_tangoservice_TangoCameraIntrinsics_;
#pragma warning disable 0169
		static Delegate GetSetColorCalibration_Lcom_google_atap_tangoservice_TangoCameraIntrinsics_Handler ()
		{
			if (cb_setColorCalibration_Lcom_google_atap_tangoservice_TangoCameraIntrinsics_ == null)
				cb_setColorCalibration_Lcom_google_atap_tangoservice_TangoCameraIntrinsics_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetColorCalibration_Lcom_google_atap_tangoservice_TangoCameraIntrinsics_);
			return cb_setColorCalibration_Lcom_google_atap_tangoservice_TangoCameraIntrinsics_;
		}

		static void n_SetColorCalibration_Lcom_google_atap_tangoservice_TangoCameraIntrinsics_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Google.Atap.Tango.Reconstruction.Tango3dReconstructionTexturing __this = global::Java.Lang.Object.GetObject<global::Com.Google.Atap.Tango.Reconstruction.Tango3dReconstructionTexturing> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Google.Atap.Tangoservice.TangoCameraIntrinsics p0 = global::Java.Lang.Object.GetObject<global::Com.Google.Atap.Tangoservice.TangoCameraIntrinsics> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetColorCalibration (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setColorCalibration_Lcom_google_atap_tangoservice_TangoCameraIntrinsics_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.atap.tango.reconstruction']/class[@name='Tango3dReconstructionTexturing']/method[@name='setColorCalibration' and count(parameter)=1 and parameter[1][@type='com.google.atap.tangoservice.TangoCameraIntrinsics']]"
		[Register ("setColorCalibration", "(Lcom/google/atap/tangoservice/TangoCameraIntrinsics;)V", "GetSetColorCalibration_Lcom_google_atap_tangoservice_TangoCameraIntrinsics_Handler")]
		public virtual unsafe void SetColorCalibration (global::Com.Google.Atap.Tangoservice.TangoCameraIntrinsics p0)
		{
			if (id_setColorCalibration_Lcom_google_atap_tangoservice_TangoCameraIntrinsics_ == IntPtr.Zero)
				id_setColorCalibration_Lcom_google_atap_tangoservice_TangoCameraIntrinsics_ = JNIEnv.GetMethodID (class_ref, "setColorCalibration", "(Lcom/google/atap/tangoservice/TangoCameraIntrinsics;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setColorCalibration_Lcom_google_atap_tangoservice_TangoCameraIntrinsics_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setColorCalibration", "(Lcom/google/atap/tangoservice/TangoCameraIntrinsics;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_textureMeshFromDataset_Lcom_google_atap_tango_reconstruction_Tango3dReconstructionConfig_Lcom_google_atap_tango_reconstruction_Tango3dReconstructionTrajectory_Lcom_google_atap_tango_dataset_TangoDataset_Lcom_google_atap_tango_mesh_TangoMesh_Lcom_google_atap_tango_reconstruction_Tango3dReconstructionTexturing_ProgressCallback_;
#pragma warning disable 0169
		static Delegate GetTextureMeshFromDataset_Lcom_google_atap_tango_reconstruction_Tango3dReconstructionConfig_Lcom_google_atap_tango_reconstruction_Tango3dReconstructionTrajectory_Lcom_google_atap_tango_dataset_TangoDataset_Lcom_google_atap_tango_mesh_TangoMesh_Lcom_google_atap_tango_reconstruction_Tango3dReconstructionTexturing_ProgressCallback_Handler ()
		{
			if (cb_textureMeshFromDataset_Lcom_google_atap_tango_reconstruction_Tango3dReconstructionConfig_Lcom_google_atap_tango_reconstruction_Tango3dReconstructionTrajectory_Lcom_google_atap_tango_dataset_TangoDataset_Lcom_google_atap_tango_mesh_TangoMesh_Lcom_google_atap_tango_reconstruction_Tango3dReconstructionTexturing_ProgressCallback_ == null)
				cb_textureMeshFromDataset_Lcom_google_atap_tango_reconstruction_Tango3dReconstructionConfig_Lcom_google_atap_tango_reconstruction_Tango3dReconstructionTrajectory_Lcom_google_atap_tango_dataset_TangoDataset_Lcom_google_atap_tango_mesh_TangoMesh_Lcom_google_atap_tango_reconstruction_Tango3dReconstructionTexturing_ProgressCallback_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_TextureMeshFromDataset_Lcom_google_atap_tango_reconstruction_Tango3dReconstructionConfig_Lcom_google_atap_tango_reconstruction_Tango3dReconstructionTrajectory_Lcom_google_atap_tango_dataset_TangoDataset_Lcom_google_atap_tango_mesh_TangoMesh_Lcom_google_atap_tango_reconstruction_Tango3dReconstructionTexturing_ProgressCallback_);
			return cb_textureMeshFromDataset_Lcom_google_atap_tango_reconstruction_Tango3dReconstructionConfig_Lcom_google_atap_tango_reconstruction_Tango3dReconstructionTrajectory_Lcom_google_atap_tango_dataset_TangoDataset_Lcom_google_atap_tango_mesh_TangoMesh_Lcom_google_atap_tango_reconstruction_Tango3dReconstructionTexturing_ProgressCallback_;
		}

		static IntPtr n_TextureMeshFromDataset_Lcom_google_atap_tango_reconstruction_Tango3dReconstructionConfig_Lcom_google_atap_tango_reconstruction_Tango3dReconstructionTrajectory_Lcom_google_atap_tango_dataset_TangoDataset_Lcom_google_atap_tango_mesh_TangoMesh_Lcom_google_atap_tango_reconstruction_Tango3dReconstructionTexturing_ProgressCallback_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2, IntPtr native_p3, IntPtr native_p4)
		{
			global::Com.Google.Atap.Tango.Reconstruction.Tango3dReconstructionTexturing __this = global::Java.Lang.Object.GetObject<global::Com.Google.Atap.Tango.Reconstruction.Tango3dReconstructionTexturing> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Google.Atap.Tango.Reconstruction.Tango3dReconstructionConfig p0 = global::Java.Lang.Object.GetObject<global::Com.Google.Atap.Tango.Reconstruction.Tango3dReconstructionConfig> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Google.Atap.Tango.Reconstruction.Tango3dReconstructionTrajectory p1 = global::Java.Lang.Object.GetObject<global::Com.Google.Atap.Tango.Reconstruction.Tango3dReconstructionTrajectory> (native_p1, JniHandleOwnership.DoNotTransfer);
			global::Com.Google.Atap.Tango.Dataset.TangoDataset p2 = global::Java.Lang.Object.GetObject<global::Com.Google.Atap.Tango.Dataset.TangoDataset> (native_p2, JniHandleOwnership.DoNotTransfer);
			global::Com.Google.Atap.Tango.Mesh.TangoMesh p3 = global::Java.Lang.Object.GetObject<global::Com.Google.Atap.Tango.Mesh.TangoMesh> (native_p3, JniHandleOwnership.DoNotTransfer);
			global::Com.Google.Atap.Tango.Reconstruction.Tango3dReconstructionTexturing.IProgressCallback p4 = (global::Com.Google.Atap.Tango.Reconstruction.Tango3dReconstructionTexturing.IProgressCallback)global::Java.Lang.Object.GetObject<global::Com.Google.Atap.Tango.Reconstruction.Tango3dReconstructionTexturing.IProgressCallback> (native_p4, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.TextureMeshFromDataset (p0, p1, p2, p3, p4));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_textureMeshFromDataset_Lcom_google_atap_tango_reconstruction_Tango3dReconstructionConfig_Lcom_google_atap_tango_reconstruction_Tango3dReconstructionTrajectory_Lcom_google_atap_tango_dataset_TangoDataset_Lcom_google_atap_tango_mesh_TangoMesh_Lcom_google_atap_tango_reconstruction_Tango3dReconstructionTexturing_ProgressCallback_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.atap.tango.reconstruction']/class[@name='Tango3dReconstructionTexturing']/method[@name='textureMeshFromDataset' and count(parameter)=5 and parameter[1][@type='com.google.atap.tango.reconstruction.Tango3dReconstructionConfig'] and parameter[2][@type='com.google.atap.tango.reconstruction.Tango3dReconstructionTrajectory'] and parameter[3][@type='com.google.atap.tango.dataset.TangoDataset'] and parameter[4][@type='com.google.atap.tango.mesh.TangoMesh'] and parameter[5][@type='com.google.atap.tango.reconstruction.Tango3dReconstructionTexturing.ProgressCallback']]"
		[Register ("textureMeshFromDataset", "(Lcom/google/atap/tango/reconstruction/Tango3dReconstructionConfig;Lcom/google/atap/tango/reconstruction/Tango3dReconstructionTrajectory;Lcom/google/atap/tango/dataset/TangoDataset;Lcom/google/atap/tango/mesh/TangoMesh;Lcom/google/atap/tango/reconstruction/Tango3dReconstructionTexturing$ProgressCallback;)Lcom/google/atap/tango/mesh/TangoMesh;", "GetTextureMeshFromDataset_Lcom_google_atap_tango_reconstruction_Tango3dReconstructionConfig_Lcom_google_atap_tango_reconstruction_Tango3dReconstructionTrajectory_Lcom_google_atap_tango_dataset_TangoDataset_Lcom_google_atap_tango_mesh_TangoMesh_Lcom_google_atap_tango_reconstruction_Tango3dReconstructionTexturing_ProgressCallback_Handler")]
		public virtual unsafe global::Com.Google.Atap.Tango.Mesh.TangoMesh TextureMeshFromDataset (global::Com.Google.Atap.Tango.Reconstruction.Tango3dReconstructionConfig p0, global::Com.Google.Atap.Tango.Reconstruction.Tango3dReconstructionTrajectory p1, global::Com.Google.Atap.Tango.Dataset.TangoDataset p2, global::Com.Google.Atap.Tango.Mesh.TangoMesh p3, global::Com.Google.Atap.Tango.Reconstruction.Tango3dReconstructionTexturing.IProgressCallback p4)
		{
			if (id_textureMeshFromDataset_Lcom_google_atap_tango_reconstruction_Tango3dReconstructionConfig_Lcom_google_atap_tango_reconstruction_Tango3dReconstructionTrajectory_Lcom_google_atap_tango_dataset_TangoDataset_Lcom_google_atap_tango_mesh_TangoMesh_Lcom_google_atap_tango_reconstruction_Tango3dReconstructionTexturing_ProgressCallback_ == IntPtr.Zero)
				id_textureMeshFromDataset_Lcom_google_atap_tango_reconstruction_Tango3dReconstructionConfig_Lcom_google_atap_tango_reconstruction_Tango3dReconstructionTrajectory_Lcom_google_atap_tango_dataset_TangoDataset_Lcom_google_atap_tango_mesh_TangoMesh_Lcom_google_atap_tango_reconstruction_Tango3dReconstructionTexturing_ProgressCallback_ = JNIEnv.GetMethodID (class_ref, "textureMeshFromDataset", "(Lcom/google/atap/tango/reconstruction/Tango3dReconstructionConfig;Lcom/google/atap/tango/reconstruction/Tango3dReconstructionTrajectory;Lcom/google/atap/tango/dataset/TangoDataset;Lcom/google/atap/tango/mesh/TangoMesh;Lcom/google/atap/tango/reconstruction/Tango3dReconstructionTexturing$ProgressCallback;)Lcom/google/atap/tango/mesh/TangoMesh;");
			try {
				JValue* __args = stackalloc JValue [5];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				__args [4] = new JValue (p4);

				global::Com.Google.Atap.Tango.Mesh.TangoMesh __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Google.Atap.Tango.Mesh.TangoMesh> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_textureMeshFromDataset_Lcom_google_atap_tango_reconstruction_Tango3dReconstructionConfig_Lcom_google_atap_tango_reconstruction_Tango3dReconstructionTrajectory_Lcom_google_atap_tango_dataset_TangoDataset_Lcom_google_atap_tango_mesh_TangoMesh_Lcom_google_atap_tango_reconstruction_Tango3dReconstructionTexturing_ProgressCallback_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Google.Atap.Tango.Mesh.TangoMesh> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "textureMeshFromDataset", "(Lcom/google/atap/tango/reconstruction/Tango3dReconstructionConfig;Lcom/google/atap/tango/reconstruction/Tango3dReconstructionTrajectory;Lcom/google/atap/tango/dataset/TangoDataset;Lcom/google/atap/tango/mesh/TangoMesh;Lcom/google/atap/tango/reconstruction/Tango3dReconstructionTexturing$ProgressCallback;)Lcom/google/atap/tango/mesh/TangoMesh;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_updateTexture_Lcom_google_atap_tangoservice_TangoPoseData_Lcom_google_atap_tangoservice_experimental_TangoImageBuffer_;
#pragma warning disable 0169
		static Delegate GetUpdateTexture_Lcom_google_atap_tangoservice_TangoPoseData_Lcom_google_atap_tangoservice_experimental_TangoImageBuffer_Handler ()
		{
			if (cb_updateTexture_Lcom_google_atap_tangoservice_TangoPoseData_Lcom_google_atap_tangoservice_experimental_TangoImageBuffer_ == null)
				cb_updateTexture_Lcom_google_atap_tangoservice_TangoPoseData_Lcom_google_atap_tangoservice_experimental_TangoImageBuffer_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_UpdateTexture_Lcom_google_atap_tangoservice_TangoPoseData_Lcom_google_atap_tangoservice_experimental_TangoImageBuffer_);
			return cb_updateTexture_Lcom_google_atap_tangoservice_TangoPoseData_Lcom_google_atap_tangoservice_experimental_TangoImageBuffer_;
		}

		static void n_UpdateTexture_Lcom_google_atap_tangoservice_TangoPoseData_Lcom_google_atap_tangoservice_experimental_TangoImageBuffer_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Google.Atap.Tango.Reconstruction.Tango3dReconstructionTexturing __this = global::Java.Lang.Object.GetObject<global::Com.Google.Atap.Tango.Reconstruction.Tango3dReconstructionTexturing> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Google.Atap.Tangoservice.TangoPoseData p0 = global::Java.Lang.Object.GetObject<global::Com.Google.Atap.Tangoservice.TangoPoseData> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Google.Atap.Tangoservice.Experimental.TangoImageBuffer p1 = global::Java.Lang.Object.GetObject<global::Com.Google.Atap.Tangoservice.Experimental.TangoImageBuffer> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.UpdateTexture (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_updateTexture_Lcom_google_atap_tangoservice_TangoPoseData_Lcom_google_atap_tangoservice_experimental_TangoImageBuffer_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.atap.tango.reconstruction']/class[@name='Tango3dReconstructionTexturing']/method[@name='updateTexture' and count(parameter)=2 and parameter[1][@type='com.google.atap.tangoservice.TangoPoseData'] and parameter[2][@type='com.google.atap.tangoservice.experimental.TangoImageBuffer']]"
		[Register ("updateTexture", "(Lcom/google/atap/tangoservice/TangoPoseData;Lcom/google/atap/tangoservice/experimental/TangoImageBuffer;)V", "GetUpdateTexture_Lcom_google_atap_tangoservice_TangoPoseData_Lcom_google_atap_tangoservice_experimental_TangoImageBuffer_Handler")]
		public virtual unsafe void UpdateTexture (global::Com.Google.Atap.Tangoservice.TangoPoseData p0, global::Com.Google.Atap.Tangoservice.Experimental.TangoImageBuffer p1)
		{
			if (id_updateTexture_Lcom_google_atap_tangoservice_TangoPoseData_Lcom_google_atap_tangoservice_experimental_TangoImageBuffer_ == IntPtr.Zero)
				id_updateTexture_Lcom_google_atap_tangoservice_TangoPoseData_Lcom_google_atap_tangoservice_experimental_TangoImageBuffer_ = JNIEnv.GetMethodID (class_ref, "updateTexture", "(Lcom/google/atap/tangoservice/TangoPoseData;Lcom/google/atap/tangoservice/experimental/TangoImageBuffer;)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_updateTexture_Lcom_google_atap_tangoservice_TangoPoseData_Lcom_google_atap_tangoservice_experimental_TangoImageBuffer_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "updateTexture", "(Lcom/google/atap/tangoservice/TangoPoseData;Lcom/google/atap/tangoservice/experimental/TangoImageBuffer;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_updateTextureGl_ILcom_google_atap_tangoservice_TangoPoseData_;
#pragma warning disable 0169
		static Delegate GetUpdateTextureGl_ILcom_google_atap_tangoservice_TangoPoseData_Handler ()
		{
			if (cb_updateTextureGl_ILcom_google_atap_tangoservice_TangoPoseData_ == null)
				cb_updateTextureGl_ILcom_google_atap_tangoservice_TangoPoseData_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, IntPtr>) n_UpdateTextureGl_ILcom_google_atap_tangoservice_TangoPoseData_);
			return cb_updateTextureGl_ILcom_google_atap_tangoservice_TangoPoseData_;
		}

		static void n_UpdateTextureGl_ILcom_google_atap_tangoservice_TangoPoseData_ (IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1)
		{
			global::Com.Google.Atap.Tango.Reconstruction.Tango3dReconstructionTexturing __this = global::Java.Lang.Object.GetObject<global::Com.Google.Atap.Tango.Reconstruction.Tango3dReconstructionTexturing> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Google.Atap.Tangoservice.TangoPoseData p1 = global::Java.Lang.Object.GetObject<global::Com.Google.Atap.Tangoservice.TangoPoseData> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.UpdateTextureGl (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_updateTextureGl_ILcom_google_atap_tangoservice_TangoPoseData_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.atap.tango.reconstruction']/class[@name='Tango3dReconstructionTexturing']/method[@name='updateTextureGl' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='com.google.atap.tangoservice.TangoPoseData']]"
		[Register ("updateTextureGl", "(ILcom/google/atap/tangoservice/TangoPoseData;)V", "GetUpdateTextureGl_ILcom_google_atap_tangoservice_TangoPoseData_Handler")]
		public virtual unsafe void UpdateTextureGl (int p0, global::Com.Google.Atap.Tangoservice.TangoPoseData p1)
		{
			if (id_updateTextureGl_ILcom_google_atap_tangoservice_TangoPoseData_ == IntPtr.Zero)
				id_updateTextureGl_ILcom_google_atap_tangoservice_TangoPoseData_ = JNIEnv.GetMethodID (class_ref, "updateTextureGl", "(ILcom/google/atap/tangoservice/TangoPoseData;)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_updateTextureGl_ILcom_google_atap_tangoservice_TangoPoseData_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "updateTextureGl", "(ILcom/google/atap/tangoservice/TangoPoseData;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_updateTextureGl_IILcom_google_atap_tangoservice_TangoPoseData_;
#pragma warning disable 0169
		static Delegate GetUpdateTextureGl_IILcom_google_atap_tangoservice_TangoPoseData_Handler ()
		{
			if (cb_updateTextureGl_IILcom_google_atap_tangoservice_TangoPoseData_ == null)
				cb_updateTextureGl_IILcom_google_atap_tangoservice_TangoPoseData_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, int, IntPtr>) n_UpdateTextureGl_IILcom_google_atap_tangoservice_TangoPoseData_);
			return cb_updateTextureGl_IILcom_google_atap_tangoservice_TangoPoseData_;
		}

		static void n_UpdateTextureGl_IILcom_google_atap_tangoservice_TangoPoseData_ (IntPtr jnienv, IntPtr native__this, int p0, int p1, IntPtr native_p2)
		{
			global::Com.Google.Atap.Tango.Reconstruction.Tango3dReconstructionTexturing __this = global::Java.Lang.Object.GetObject<global::Com.Google.Atap.Tango.Reconstruction.Tango3dReconstructionTexturing> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Google.Atap.Tangoservice.TangoPoseData p2 = global::Java.Lang.Object.GetObject<global::Com.Google.Atap.Tangoservice.TangoPoseData> (native_p2, JniHandleOwnership.DoNotTransfer);
			__this.UpdateTextureGl (p0, p1, p2);
		}
#pragma warning restore 0169

		static IntPtr id_updateTextureGl_IILcom_google_atap_tangoservice_TangoPoseData_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.atap.tango.reconstruction']/class[@name='Tango3dReconstructionTexturing']/method[@name='updateTextureGl' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='com.google.atap.tangoservice.TangoPoseData']]"
		[Register ("updateTextureGl", "(IILcom/google/atap/tangoservice/TangoPoseData;)V", "GetUpdateTextureGl_IILcom_google_atap_tangoservice_TangoPoseData_Handler")]
		public virtual unsafe void UpdateTextureGl (int p0, int p1, global::Com.Google.Atap.Tangoservice.TangoPoseData p2)
		{
			if (id_updateTextureGl_IILcom_google_atap_tangoservice_TangoPoseData_ == IntPtr.Zero)
				id_updateTextureGl_IILcom_google_atap_tangoservice_TangoPoseData_ = JNIEnv.GetMethodID (class_ref, "updateTextureGl", "(IILcom/google/atap/tangoservice/TangoPoseData;)V");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_updateTextureGl_IILcom_google_atap_tangoservice_TangoPoseData_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "updateTextureGl", "(IILcom/google/atap/tangoservice/TangoPoseData;)V"), __args);
			} finally {
			}
		}

	}
}
