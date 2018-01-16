using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Google.Atap.Tango.Reconstruction {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.google.atap.tango.reconstruction']/class[@name='Tango3dReconstruction']"
	[global::Android.Runtime.Register ("com/google/atap/tango/reconstruction/Tango3dReconstruction", DoNotGenerateAcw=true)]
	public partial class Tango3dReconstruction : global::Java.Lang.Object {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.atap.tango.reconstruction']/class[@name='Tango3dReconstruction']/field[@name='TANGO_3DR_ERROR']"
		[Register ("TANGO_3DR_ERROR")]
		public const int Tango3drError = (int) -3;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.atap.tango.reconstruction']/class[@name='Tango3dReconstruction']/field[@name='TANGO_3DR_INSUFFICIENT_SPACE']"
		[Register ("TANGO_3DR_INSUFFICIENT_SPACE")]
		public const int Tango3drInsufficientSpace = (int) -2;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.atap.tango.reconstruction']/class[@name='Tango3dReconstruction']/field[@name='TANGO_3DR_INVALID']"
		[Register ("TANGO_3DR_INVALID")]
		public const int Tango3drInvalid = (int) -1;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.atap.tango.reconstruction']/class[@name='Tango3dReconstruction']/field[@name='TANGO_3DR_SUCCESS']"
		[Register ("TANGO_3DR_SUCCESS")]
		public const int Tango3drSuccess = (int) 0;
		// Metadata.xml XPath interface reference: path="/api/package[@name='com.google.atap.tango.reconstruction']/interface[@name='Tango3dReconstruction.ProgressCallback']"
		[Register ("com/google/atap/tango/reconstruction/Tango3dReconstruction$ProgressCallback", "", "Com.Google.Atap.Tango.Reconstruction.Tango3dReconstruction/IProgressCallbackInvoker")]
		public partial interface IProgressCallback : IJavaObject {

			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.atap.tango.reconstruction']/interface[@name='Tango3dReconstruction.ProgressCallback']/method[@name='onProgress' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("onProgress", "(I)V", "GetOnProgress_IHandler:Com.Google.Atap.Tango.Reconstruction.Tango3dReconstruction/IProgressCallbackInvoker, tango-sdk-reconstruction")]
			void OnProgress (int p0);

		}

		[global::Android.Runtime.Register ("com/google/atap/tango/reconstruction/Tango3dReconstruction$ProgressCallback", DoNotGenerateAcw=true)]
		internal class IProgressCallbackInvoker : global::Java.Lang.Object, IProgressCallback {

			static IntPtr java_class_ref = JNIEnv.FindClass ("com/google/atap/tango/reconstruction/Tango3dReconstruction$ProgressCallback");

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
								JNIEnv.GetClassNameFromInstance (handle), "com.google.atap.tango.reconstruction.Tango3dReconstruction.ProgressCallback"));
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
				global::Com.Google.Atap.Tango.Reconstruction.Tango3dReconstruction.IProgressCallback __this = global::Java.Lang.Object.GetObject<global::Com.Google.Atap.Tango.Reconstruction.Tango3dReconstruction.IProgressCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
				return JNIEnv.FindClass ("com/google/atap/tango/reconstruction/Tango3dReconstruction", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (Tango3dReconstruction); }
		}

		protected Tango3dReconstruction (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Lcom_google_atap_tango_reconstruction_Tango3dReconstructionConfig_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.google.atap.tango.reconstruction']/class[@name='Tango3dReconstruction']/constructor[@name='Tango3dReconstruction' and count(parameter)=1 and parameter[1][@type='com.google.atap.tango.reconstruction.Tango3dReconstructionConfig']]"
		[Register (".ctor", "(Lcom/google/atap/tango/reconstruction/Tango3dReconstructionConfig;)V", "")]
		public unsafe Tango3dReconstruction (global::Com.Google.Atap.Tango.Reconstruction.Tango3dReconstructionConfig p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (GetType () != typeof (Tango3dReconstruction)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Lcom/google/atap/tango/reconstruction/Tango3dReconstructionConfig;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Lcom/google/atap/tango/reconstruction/Tango3dReconstructionConfig;)V", __args);
					return;
				}

				if (id_ctor_Lcom_google_atap_tango_reconstruction_Tango3dReconstructionConfig_ == IntPtr.Zero)
					id_ctor_Lcom_google_atap_tango_reconstruction_Tango3dReconstructionConfig_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/google/atap/tango/reconstruction/Tango3dReconstructionConfig;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_google_atap_tango_reconstruction_Tango3dReconstructionConfig_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Lcom_google_atap_tango_reconstruction_Tango3dReconstructionConfig_, __args);
			} finally {
			}
		}

		static Delegate cb_getActiveIndices;
#pragma warning disable 0169
		static Delegate GetGetActiveIndicesHandler ()
		{
			if (cb_getActiveIndices == null)
				cb_getActiveIndices = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetActiveIndices);
			return cb_getActiveIndices;
		}

		static IntPtr n_GetActiveIndices (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Google.Atap.Tango.Reconstruction.Tango3dReconstruction __this = global::Java.Lang.Object.GetObject<global::Com.Google.Atap.Tango.Reconstruction.Tango3dReconstruction> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList<int[]>.ToLocalJniHandle (__this.ActiveIndices);
		}
#pragma warning restore 0169

		static IntPtr id_getActiveIndices;
		public virtual unsafe global::System.Collections.Generic.IList<int[]> ActiveIndices {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.atap.tango.reconstruction']/class[@name='Tango3dReconstruction']/method[@name='getActiveIndices' and count(parameter)=0]"
			[Register ("getActiveIndices", "()Ljava/util/List;", "GetGetActiveIndicesHandler")]
			get {
				if (id_getActiveIndices == IntPtr.Zero)
					id_getActiveIndices = JNIEnv.GetMethodID (class_ref, "getActiveIndices", "()Ljava/util/List;");
				try {

					if (GetType () == ThresholdType)
						return global::Android.Runtime.JavaList<int[]>.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getActiveIndices), JniHandleOwnership.TransferLocalRef);
					else
						return global::Android.Runtime.JavaList<int[]>.FromJniHandle (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getActiveIndices", "()Ljava/util/List;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_clear;
#pragma warning disable 0169
		static Delegate GetClearHandler ()
		{
			if (cb_clear == null)
				cb_clear = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Clear);
			return cb_clear;
		}

		static void n_Clear (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Google.Atap.Tango.Reconstruction.Tango3dReconstruction __this = global::Java.Lang.Object.GetObject<global::Com.Google.Atap.Tango.Reconstruction.Tango3dReconstruction> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Clear ();
		}
#pragma warning restore 0169

		static IntPtr id_clear;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.atap.tango.reconstruction']/class[@name='Tango3dReconstruction']/method[@name='clear' and count(parameter)=0]"
		[Register ("clear", "()V", "GetClearHandler")]
		public virtual unsafe void Clear ()
		{
			if (id_clear == IntPtr.Zero)
				id_clear = JNIEnv.GetMethodID (class_ref, "clear", "()V");
			try {

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_clear);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "clear", "()V"));
			} finally {
			}
		}

		static Delegate cb_decimatePlanes_Lcom_google_atap_tango_mesh_TangoMesh_;
#pragma warning disable 0169
		static Delegate GetDecimatePlanes_Lcom_google_atap_tango_mesh_TangoMesh_Handler ()
		{
			if (cb_decimatePlanes_Lcom_google_atap_tango_mesh_TangoMesh_ == null)
				cb_decimatePlanes_Lcom_google_atap_tango_mesh_TangoMesh_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_DecimatePlanes_Lcom_google_atap_tango_mesh_TangoMesh_);
			return cb_decimatePlanes_Lcom_google_atap_tango_mesh_TangoMesh_;
		}

		static void n_DecimatePlanes_Lcom_google_atap_tango_mesh_TangoMesh_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Google.Atap.Tango.Reconstruction.Tango3dReconstruction __this = global::Java.Lang.Object.GetObject<global::Com.Google.Atap.Tango.Reconstruction.Tango3dReconstruction> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Google.Atap.Tango.Mesh.TangoMesh p0 = global::Java.Lang.Object.GetObject<global::Com.Google.Atap.Tango.Mesh.TangoMesh> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.DecimatePlanes (p0);
		}
#pragma warning restore 0169

		static IntPtr id_decimatePlanes_Lcom_google_atap_tango_mesh_TangoMesh_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.atap.tango.reconstruction']/class[@name='Tango3dReconstruction']/method[@name='decimatePlanes' and count(parameter)=1 and parameter[1][@type='com.google.atap.tango.mesh.TangoMesh']]"
		[Register ("decimatePlanes", "(Lcom/google/atap/tango/mesh/TangoMesh;)V", "GetDecimatePlanes_Lcom_google_atap_tango_mesh_TangoMesh_Handler")]
		public virtual unsafe void DecimatePlanes (global::Com.Google.Atap.Tango.Mesh.TangoMesh p0)
		{
			if (id_decimatePlanes_Lcom_google_atap_tango_mesh_TangoMesh_ == IntPtr.Zero)
				id_decimatePlanes_Lcom_google_atap_tango_mesh_TangoMesh_ = JNIEnv.GetMethodID (class_ref, "decimatePlanes", "(Lcom/google/atap/tango/mesh/TangoMesh;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_decimatePlanes_Lcom_google_atap_tango_mesh_TangoMesh_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "decimatePlanes", "(Lcom/google/atap/tango/mesh/TangoMesh;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_extractFloorplan;
#pragma warning disable 0169
		static Delegate GetExtractFloorplanHandler ()
		{
			if (cb_extractFloorplan == null)
				cb_extractFloorplan = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_ExtractFloorplan);
			return cb_extractFloorplan;
		}

		static IntPtr n_ExtractFloorplan (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Google.Atap.Tango.Reconstruction.Tango3dReconstruction __this = global::Java.Lang.Object.GetObject<global::Com.Google.Atap.Tango.Reconstruction.Tango3dReconstruction> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList<global::Com.Google.Atap.Tango.Reconstruction.TangoPolygon>.ToLocalJniHandle (__this.ExtractFloorplan ());
		}
#pragma warning restore 0169

		static IntPtr id_extractFloorplan;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.atap.tango.reconstruction']/class[@name='Tango3dReconstruction']/method[@name='extractFloorplan' and count(parameter)=0]"
		[Register ("extractFloorplan", "()Ljava/util/List;", "GetExtractFloorplanHandler")]
		public virtual unsafe global::System.Collections.Generic.IList<global::Com.Google.Atap.Tango.Reconstruction.TangoPolygon> ExtractFloorplan ()
		{
			if (id_extractFloorplan == IntPtr.Zero)
				id_extractFloorplan = JNIEnv.GetMethodID (class_ref, "extractFloorplan", "()Ljava/util/List;");
			try {

				if (GetType () == ThresholdType)
					return global::Android.Runtime.JavaList<global::Com.Google.Atap.Tango.Reconstruction.TangoPolygon>.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_extractFloorplan), JniHandleOwnership.TransferLocalRef);
				else
					return global::Android.Runtime.JavaList<global::Com.Google.Atap.Tango.Reconstruction.TangoPolygon>.FromJniHandle (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "extractFloorplan", "()Ljava/util/List;")), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_extractFloorplanLevels;
#pragma warning disable 0169
		static Delegate GetExtractFloorplanLevelsHandler ()
		{
			if (cb_extractFloorplanLevels == null)
				cb_extractFloorplanLevels = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_ExtractFloorplanLevels);
			return cb_extractFloorplanLevels;
		}

		static IntPtr n_ExtractFloorplanLevels (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Google.Atap.Tango.Reconstruction.Tango3dReconstruction __this = global::Java.Lang.Object.GetObject<global::Com.Google.Atap.Tango.Reconstruction.Tango3dReconstruction> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList<global::Com.Google.Atap.Tango.Reconstruction.TangoFloorplanLevel>.ToLocalJniHandle (__this.ExtractFloorplanLevels ());
		}
#pragma warning restore 0169

		static IntPtr id_extractFloorplanLevels;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.atap.tango.reconstruction']/class[@name='Tango3dReconstruction']/method[@name='extractFloorplanLevels' and count(parameter)=0]"
		[Register ("extractFloorplanLevels", "()Ljava/util/List;", "GetExtractFloorplanLevelsHandler")]
		public virtual unsafe global::System.Collections.Generic.IList<global::Com.Google.Atap.Tango.Reconstruction.TangoFloorplanLevel> ExtractFloorplanLevels ()
		{
			if (id_extractFloorplanLevels == IntPtr.Zero)
				id_extractFloorplanLevels = JNIEnv.GetMethodID (class_ref, "extractFloorplanLevels", "()Ljava/util/List;");
			try {

				if (GetType () == ThresholdType)
					return global::Android.Runtime.JavaList<global::Com.Google.Atap.Tango.Reconstruction.TangoFloorplanLevel>.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_extractFloorplanLevels), JniHandleOwnership.TransferLocalRef);
				else
					return global::Android.Runtime.JavaList<global::Com.Google.Atap.Tango.Reconstruction.TangoFloorplanLevel>.FromJniHandle (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "extractFloorplanLevels", "()Ljava/util/List;")), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_extractFloorplanSegment_arrayI;
#pragma warning disable 0169
		static Delegate GetExtractFloorplanSegment_arrayIHandler ()
		{
			if (cb_extractFloorplanSegment_arrayI == null)
				cb_extractFloorplanSegment_arrayI = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_ExtractFloorplanSegment_arrayI);
			return cb_extractFloorplanSegment_arrayI;
		}

		static IntPtr n_ExtractFloorplanSegment_arrayI (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Google.Atap.Tango.Reconstruction.Tango3dReconstruction __this = global::Java.Lang.Object.GetObject<global::Com.Google.Atap.Tango.Reconstruction.Tango3dReconstruction> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			int[] p0 = (int[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (int));
			IntPtr __ret = global::Android.Runtime.JavaList<global::Com.Google.Atap.Tango.Reconstruction.TangoPolygon>.ToLocalJniHandle (__this.ExtractFloorplanSegment (p0));
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_extractFloorplanSegment_arrayI;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.atap.tango.reconstruction']/class[@name='Tango3dReconstruction']/method[@name='extractFloorplanSegment' and count(parameter)=1 and parameter[1][@type='int[]']]"
		[Register ("extractFloorplanSegment", "([I)Ljava/util/List;", "GetExtractFloorplanSegment_arrayIHandler")]
		public virtual unsafe global::System.Collections.Generic.IList<global::Com.Google.Atap.Tango.Reconstruction.TangoPolygon> ExtractFloorplanSegment (int[] p0)
		{
			if (id_extractFloorplanSegment_arrayI == IntPtr.Zero)
				id_extractFloorplanSegment_arrayI = JNIEnv.GetMethodID (class_ref, "extractFloorplanSegment", "([I)Ljava/util/List;");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				global::System.Collections.Generic.IList<global::Com.Google.Atap.Tango.Reconstruction.TangoPolygon> __ret;
				if (GetType () == ThresholdType)
					__ret = global::Android.Runtime.JavaList<global::Com.Google.Atap.Tango.Reconstruction.TangoPolygon>.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_extractFloorplanSegment_arrayI, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Android.Runtime.JavaList<global::Com.Google.Atap.Tango.Reconstruction.TangoPolygon>.FromJniHandle (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "extractFloorplanSegment", "([I)Ljava/util/List;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}
		}

		static Delegate cb_extractFullMesh;
#pragma warning disable 0169
		static Delegate GetExtractFullMeshHandler ()
		{
			if (cb_extractFullMesh == null)
				cb_extractFullMesh = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_ExtractFullMesh);
			return cb_extractFullMesh;
		}

		static IntPtr n_ExtractFullMesh (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Google.Atap.Tango.Reconstruction.Tango3dReconstruction __this = global::Java.Lang.Object.GetObject<global::Com.Google.Atap.Tango.Reconstruction.Tango3dReconstruction> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ExtractFullMesh ());
		}
#pragma warning restore 0169

		static IntPtr id_extractFullMesh;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.atap.tango.reconstruction']/class[@name='Tango3dReconstruction']/method[@name='extractFullMesh' and count(parameter)=0]"
		[Register ("extractFullMesh", "()Lcom/google/atap/tango/mesh/TangoMesh;", "GetExtractFullMeshHandler")]
		public virtual unsafe global::Com.Google.Atap.Tango.Mesh.TangoMesh ExtractFullMesh ()
		{
			if (id_extractFullMesh == IntPtr.Zero)
				id_extractFullMesh = JNIEnv.GetMethodID (class_ref, "extractFullMesh", "()Lcom/google/atap/tango/mesh/TangoMesh;");
			try {

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Com.Google.Atap.Tango.Mesh.TangoMesh> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_extractFullMesh), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Com.Google.Atap.Tango.Mesh.TangoMesh> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "extractFullMesh", "()Lcom/google/atap/tango/mesh/TangoMesh;")), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_extractMesh_Ljava_util_List_;
#pragma warning disable 0169
		static Delegate GetExtractMesh_Ljava_util_List_Handler ()
		{
			if (cb_extractMesh_Ljava_util_List_ == null)
				cb_extractMesh_Ljava_util_List_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_ExtractMesh_Ljava_util_List_);
			return cb_extractMesh_Ljava_util_List_;
		}

		static IntPtr n_ExtractMesh_Ljava_util_List_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Google.Atap.Tango.Reconstruction.Tango3dReconstruction __this = global::Java.Lang.Object.GetObject<global::Com.Google.Atap.Tango.Reconstruction.Tango3dReconstruction> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Android.Runtime.JavaList<int[]>.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.ExtractMesh (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_extractMesh_Ljava_util_List_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.atap.tango.reconstruction']/class[@name='Tango3dReconstruction']/method[@name='extractMesh' and count(parameter)=1 and parameter[1][@type='java.util.List&lt;int[]&gt;']]"
		[Register ("extractMesh", "(Ljava/util/List;)Lcom/google/atap/tango/mesh/TangoMesh;", "GetExtractMesh_Ljava_util_List_Handler")]
		public virtual unsafe global::Com.Google.Atap.Tango.Mesh.TangoMesh ExtractMesh (global::System.Collections.Generic.IList<int[]> p0)
		{
			if (id_extractMesh_Ljava_util_List_ == IntPtr.Zero)
				id_extractMesh_Ljava_util_List_ = JNIEnv.GetMethodID (class_ref, "extractMesh", "(Ljava/util/List;)Lcom/google/atap/tango/mesh/TangoMesh;");
			IntPtr native_p0 = global::Android.Runtime.JavaList<int[]>.ToLocalJniHandle (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				global::Com.Google.Atap.Tango.Mesh.TangoMesh __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Google.Atap.Tango.Mesh.TangoMesh> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_extractMesh_Ljava_util_List_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Google.Atap.Tango.Mesh.TangoMesh> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "extractMesh", "(Ljava/util/List;)Lcom/google/atap/tango/mesh/TangoMesh;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_extractMeshSegment_arrayI;
#pragma warning disable 0169
		static Delegate GetExtractMeshSegment_arrayIHandler ()
		{
			if (cb_extractMeshSegment_arrayI == null)
				cb_extractMeshSegment_arrayI = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_ExtractMeshSegment_arrayI);
			return cb_extractMeshSegment_arrayI;
		}

		static IntPtr n_ExtractMeshSegment_arrayI (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Google.Atap.Tango.Reconstruction.Tango3dReconstruction __this = global::Java.Lang.Object.GetObject<global::Com.Google.Atap.Tango.Reconstruction.Tango3dReconstruction> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			int[] p0 = (int[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (int));
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.ExtractMeshSegment (p0));
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_extractMeshSegment_arrayI;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.atap.tango.reconstruction']/class[@name='Tango3dReconstruction']/method[@name='extractMeshSegment' and count(parameter)=1 and parameter[1][@type='int[]']]"
		[Register ("extractMeshSegment", "([I)Lcom/google/atap/tango/mesh/TangoMesh;", "GetExtractMeshSegment_arrayIHandler")]
		public virtual unsafe global::Com.Google.Atap.Tango.Mesh.TangoMesh ExtractMeshSegment (int[] p0)
		{
			if (id_extractMeshSegment_arrayI == IntPtr.Zero)
				id_extractMeshSegment_arrayI = JNIEnv.GetMethodID (class_ref, "extractMeshSegment", "([I)Lcom/google/atap/tango/mesh/TangoMesh;");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				global::Com.Google.Atap.Tango.Mesh.TangoMesh __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Google.Atap.Tango.Mesh.TangoMesh> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_extractMeshSegment_arrayI, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Google.Atap.Tango.Mesh.TangoMesh> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "extractMeshSegment", "([I)Lcom/google/atap/tango/mesh/TangoMesh;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
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
			global::Com.Google.Atap.Tango.Reconstruction.Tango3dReconstruction __this = global::Java.Lang.Object.GetObject<global::Com.Google.Atap.Tango.Reconstruction.Tango3dReconstruction> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Finalize ();
		}
#pragma warning restore 0169

		static IntPtr id_finalize;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.atap.tango.reconstruction']/class[@name='Tango3dReconstruction']/method[@name='finalize' and count(parameter)=0]"
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

		static Delegate cb_getGridSegmentBoundingBox_arrayIarrayFarrayF;
#pragma warning disable 0169
		static Delegate GetGetGridSegmentBoundingBox_arrayIarrayFarrayFHandler ()
		{
			if (cb_getGridSegmentBoundingBox_arrayIarrayFarrayF == null)
				cb_getGridSegmentBoundingBox_arrayIarrayFarrayF = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_GetGridSegmentBoundingBox_arrayIarrayFarrayF);
			return cb_getGridSegmentBoundingBox_arrayIarrayFarrayF;
		}

		static void n_GetGridSegmentBoundingBox_arrayIarrayFarrayF (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			global::Com.Google.Atap.Tango.Reconstruction.Tango3dReconstruction __this = global::Java.Lang.Object.GetObject<global::Com.Google.Atap.Tango.Reconstruction.Tango3dReconstruction> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			int[] p0 = (int[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (int));
			float[] p1 = (float[]) JNIEnv.GetArray (native_p1, JniHandleOwnership.DoNotTransfer, typeof (float));
			float[] p2 = (float[]) JNIEnv.GetArray (native_p2, JniHandleOwnership.DoNotTransfer, typeof (float));
			__this.GetGridSegmentBoundingBox (p0, p1, p2);
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
			if (p1 != null)
				JNIEnv.CopyArray (p1, native_p1);
			if (p2 != null)
				JNIEnv.CopyArray (p2, native_p2);
		}
#pragma warning restore 0169

		static IntPtr id_getGridSegmentBoundingBox_arrayIarrayFarrayF;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.atap.tango.reconstruction']/class[@name='Tango3dReconstruction']/method[@name='getGridSegmentBoundingBox' and count(parameter)=3 and parameter[1][@type='int[]'] and parameter[2][@type='float[]'] and parameter[3][@type='float[]']]"
		[Register ("getGridSegmentBoundingBox", "([I[F[F)V", "GetGetGridSegmentBoundingBox_arrayIarrayFarrayFHandler")]
		public virtual unsafe void GetGridSegmentBoundingBox (int[] p0, float[] p1, float[] p2)
		{
			if (id_getGridSegmentBoundingBox_arrayIarrayFarrayF == IntPtr.Zero)
				id_getGridSegmentBoundingBox_arrayIarrayFarrayF = JNIEnv.GetMethodID (class_ref, "getGridSegmentBoundingBox", "([I[F[F)V");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			IntPtr native_p2 = JNIEnv.NewArray (p2);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (native_p2);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_getGridSegmentBoundingBox_arrayIarrayFarrayF, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getGridSegmentBoundingBox", "([I[F[F)V"), __args);
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
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

		static Delegate cb_getMeshSegmentBoundingBox_arrayIarrayFarrayF;
#pragma warning disable 0169
		static Delegate GetGetMeshSegmentBoundingBox_arrayIarrayFarrayFHandler ()
		{
			if (cb_getMeshSegmentBoundingBox_arrayIarrayFarrayF == null)
				cb_getMeshSegmentBoundingBox_arrayIarrayFarrayF = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_GetMeshSegmentBoundingBox_arrayIarrayFarrayF);
			return cb_getMeshSegmentBoundingBox_arrayIarrayFarrayF;
		}

		static void n_GetMeshSegmentBoundingBox_arrayIarrayFarrayF (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			global::Com.Google.Atap.Tango.Reconstruction.Tango3dReconstruction __this = global::Java.Lang.Object.GetObject<global::Com.Google.Atap.Tango.Reconstruction.Tango3dReconstruction> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			int[] p0 = (int[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (int));
			float[] p1 = (float[]) JNIEnv.GetArray (native_p1, JniHandleOwnership.DoNotTransfer, typeof (float));
			float[] p2 = (float[]) JNIEnv.GetArray (native_p2, JniHandleOwnership.DoNotTransfer, typeof (float));
			__this.GetMeshSegmentBoundingBox (p0, p1, p2);
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
			if (p1 != null)
				JNIEnv.CopyArray (p1, native_p1);
			if (p2 != null)
				JNIEnv.CopyArray (p2, native_p2);
		}
#pragma warning restore 0169

		static IntPtr id_getMeshSegmentBoundingBox_arrayIarrayFarrayF;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.atap.tango.reconstruction']/class[@name='Tango3dReconstruction']/method[@name='getMeshSegmentBoundingBox' and count(parameter)=3 and parameter[1][@type='int[]'] and parameter[2][@type='float[]'] and parameter[3][@type='float[]']]"
		[Register ("getMeshSegmentBoundingBox", "([I[F[F)V", "GetGetMeshSegmentBoundingBox_arrayIarrayFarrayFHandler")]
		public virtual unsafe void GetMeshSegmentBoundingBox (int[] p0, float[] p1, float[] p2)
		{
			if (id_getMeshSegmentBoundingBox_arrayIarrayFarrayF == IntPtr.Zero)
				id_getMeshSegmentBoundingBox_arrayIarrayFarrayF = JNIEnv.GetMethodID (class_ref, "getMeshSegmentBoundingBox", "([I[F[F)V");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			IntPtr native_p2 = JNIEnv.NewArray (p2);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (native_p2);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_getMeshSegmentBoundingBox_arrayIarrayFarrayF, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getMeshSegmentBoundingBox", "([I[F[F)V"), __args);
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
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
			global::Com.Google.Atap.Tango.Reconstruction.Tango3dReconstruction __this = global::Java.Lang.Object.GetObject<global::Com.Google.Atap.Tango.Reconstruction.Tango3dReconstruction> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Release ();
		}
#pragma warning restore 0169

		static IntPtr id_release;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.atap.tango.reconstruction']/class[@name='Tango3dReconstruction']/method[@name='release' and count(parameter)=0]"
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

		static IntPtr id_rescaleCalibration_IILcom_google_atap_tangoservice_TangoCameraIntrinsics_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.atap.tango.reconstruction']/class[@name='Tango3dReconstruction']/method[@name='rescaleCalibration' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='com.google.atap.tangoservice.TangoCameraIntrinsics']]"
		[Register ("rescaleCalibration", "(IILcom/google/atap/tangoservice/TangoCameraIntrinsics;)V", "")]
		public static unsafe void RescaleCalibration (int p0, int p1, global::Com.Google.Atap.Tangoservice.TangoCameraIntrinsics p2)
		{
			if (id_rescaleCalibration_IILcom_google_atap_tangoservice_TangoCameraIntrinsics_ == IntPtr.Zero)
				id_rescaleCalibration_IILcom_google_atap_tangoservice_TangoCameraIntrinsics_ = JNIEnv.GetStaticMethodID (class_ref, "rescaleCalibration", "(IILcom/google/atap/tangoservice/TangoCameraIntrinsics;)V");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_rescaleCalibration_IILcom_google_atap_tangoservice_TangoCameraIntrinsics_, __args);
			} finally {
			}
		}

		static Delegate cb_resetFloorplanLevelsEstimator;
#pragma warning disable 0169
		static Delegate GetResetFloorplanLevelsEstimatorHandler ()
		{
			if (cb_resetFloorplanLevelsEstimator == null)
				cb_resetFloorplanLevelsEstimator = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_ResetFloorplanLevelsEstimator);
			return cb_resetFloorplanLevelsEstimator;
		}

		static void n_ResetFloorplanLevelsEstimator (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Google.Atap.Tango.Reconstruction.Tango3dReconstruction __this = global::Java.Lang.Object.GetObject<global::Com.Google.Atap.Tango.Reconstruction.Tango3dReconstruction> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ResetFloorplanLevelsEstimator ();
		}
#pragma warning restore 0169

		static IntPtr id_resetFloorplanLevelsEstimator;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.atap.tango.reconstruction']/class[@name='Tango3dReconstruction']/method[@name='resetFloorplanLevelsEstimator' and count(parameter)=0]"
		[Register ("resetFloorplanLevelsEstimator", "()V", "GetResetFloorplanLevelsEstimatorHandler")]
		public virtual unsafe void ResetFloorplanLevelsEstimator ()
		{
			if (id_resetFloorplanLevelsEstimator == IntPtr.Zero)
				id_resetFloorplanLevelsEstimator = JNIEnv.GetMethodID (class_ref, "resetFloorplanLevelsEstimator", "()V");
			try {

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_resetFloorplanLevelsEstimator);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "resetFloorplanLevelsEstimator", "()V"));
			} finally {
			}
		}

		static Delegate cb_selectFloorplanLevel_Lcom_google_atap_tango_reconstruction_TangoFloorplanLevel_;
#pragma warning disable 0169
		static Delegate GetSelectFloorplanLevel_Lcom_google_atap_tango_reconstruction_TangoFloorplanLevel_Handler ()
		{
			if (cb_selectFloorplanLevel_Lcom_google_atap_tango_reconstruction_TangoFloorplanLevel_ == null)
				cb_selectFloorplanLevel_Lcom_google_atap_tango_reconstruction_TangoFloorplanLevel_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SelectFloorplanLevel_Lcom_google_atap_tango_reconstruction_TangoFloorplanLevel_);
			return cb_selectFloorplanLevel_Lcom_google_atap_tango_reconstruction_TangoFloorplanLevel_;
		}

		static void n_SelectFloorplanLevel_Lcom_google_atap_tango_reconstruction_TangoFloorplanLevel_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Google.Atap.Tango.Reconstruction.Tango3dReconstruction __this = global::Java.Lang.Object.GetObject<global::Com.Google.Atap.Tango.Reconstruction.Tango3dReconstruction> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Google.Atap.Tango.Reconstruction.TangoFloorplanLevel p0 = global::Java.Lang.Object.GetObject<global::Com.Google.Atap.Tango.Reconstruction.TangoFloorplanLevel> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SelectFloorplanLevel (p0);
		}
#pragma warning restore 0169

		static IntPtr id_selectFloorplanLevel_Lcom_google_atap_tango_reconstruction_TangoFloorplanLevel_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.atap.tango.reconstruction']/class[@name='Tango3dReconstruction']/method[@name='selectFloorplanLevel' and count(parameter)=1 and parameter[1][@type='com.google.atap.tango.reconstruction.TangoFloorplanLevel']]"
		[Register ("selectFloorplanLevel", "(Lcom/google/atap/tango/reconstruction/TangoFloorplanLevel;)V", "GetSelectFloorplanLevel_Lcom_google_atap_tango_reconstruction_TangoFloorplanLevel_Handler")]
		public virtual unsafe void SelectFloorplanLevel (global::Com.Google.Atap.Tango.Reconstruction.TangoFloorplanLevel p0)
		{
			if (id_selectFloorplanLevel_Lcom_google_atap_tango_reconstruction_TangoFloorplanLevel_ == IntPtr.Zero)
				id_selectFloorplanLevel_Lcom_google_atap_tango_reconstruction_TangoFloorplanLevel_ = JNIEnv.GetMethodID (class_ref, "selectFloorplanLevel", "(Lcom/google/atap/tango/reconstruction/TangoFloorplanLevel;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_selectFloorplanLevel_Lcom_google_atap_tango_reconstruction_TangoFloorplanLevel_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "selectFloorplanLevel", "(Lcom/google/atap/tango/reconstruction/TangoFloorplanLevel;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setColorCameraCalibration_Lcom_google_atap_tangoservice_TangoCameraIntrinsics_;
#pragma warning disable 0169
		static Delegate GetSetColorCameraCalibration_Lcom_google_atap_tangoservice_TangoCameraIntrinsics_Handler ()
		{
			if (cb_setColorCameraCalibration_Lcom_google_atap_tangoservice_TangoCameraIntrinsics_ == null)
				cb_setColorCameraCalibration_Lcom_google_atap_tangoservice_TangoCameraIntrinsics_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetColorCameraCalibration_Lcom_google_atap_tangoservice_TangoCameraIntrinsics_);
			return cb_setColorCameraCalibration_Lcom_google_atap_tangoservice_TangoCameraIntrinsics_;
		}

		static void n_SetColorCameraCalibration_Lcom_google_atap_tangoservice_TangoCameraIntrinsics_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Google.Atap.Tango.Reconstruction.Tango3dReconstruction __this = global::Java.Lang.Object.GetObject<global::Com.Google.Atap.Tango.Reconstruction.Tango3dReconstruction> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Google.Atap.Tangoservice.TangoCameraIntrinsics p0 = global::Java.Lang.Object.GetObject<global::Com.Google.Atap.Tangoservice.TangoCameraIntrinsics> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetColorCameraCalibration (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setColorCameraCalibration_Lcom_google_atap_tangoservice_TangoCameraIntrinsics_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.atap.tango.reconstruction']/class[@name='Tango3dReconstruction']/method[@name='setColorCameraCalibration' and count(parameter)=1 and parameter[1][@type='com.google.atap.tangoservice.TangoCameraIntrinsics']]"
		[Register ("setColorCameraCalibration", "(Lcom/google/atap/tangoservice/TangoCameraIntrinsics;)V", "GetSetColorCameraCalibration_Lcom_google_atap_tangoservice_TangoCameraIntrinsics_Handler")]
		public virtual unsafe void SetColorCameraCalibration (global::Com.Google.Atap.Tangoservice.TangoCameraIntrinsics p0)
		{
			if (id_setColorCameraCalibration_Lcom_google_atap_tangoservice_TangoCameraIntrinsics_ == IntPtr.Zero)
				id_setColorCameraCalibration_Lcom_google_atap_tangoservice_TangoCameraIntrinsics_ = JNIEnv.GetMethodID (class_ref, "setColorCameraCalibration", "(Lcom/google/atap/tangoservice/TangoCameraIntrinsics;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setColorCameraCalibration_Lcom_google_atap_tangoservice_TangoCameraIntrinsics_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setColorCameraCalibration", "(Lcom/google/atap/tangoservice/TangoCameraIntrinsics;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setDepthCameraCalibration_Lcom_google_atap_tangoservice_TangoCameraIntrinsics_;
#pragma warning disable 0169
		static Delegate GetSetDepthCameraCalibration_Lcom_google_atap_tangoservice_TangoCameraIntrinsics_Handler ()
		{
			if (cb_setDepthCameraCalibration_Lcom_google_atap_tangoservice_TangoCameraIntrinsics_ == null)
				cb_setDepthCameraCalibration_Lcom_google_atap_tangoservice_TangoCameraIntrinsics_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetDepthCameraCalibration_Lcom_google_atap_tangoservice_TangoCameraIntrinsics_);
			return cb_setDepthCameraCalibration_Lcom_google_atap_tangoservice_TangoCameraIntrinsics_;
		}

		static void n_SetDepthCameraCalibration_Lcom_google_atap_tangoservice_TangoCameraIntrinsics_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Google.Atap.Tango.Reconstruction.Tango3dReconstruction __this = global::Java.Lang.Object.GetObject<global::Com.Google.Atap.Tango.Reconstruction.Tango3dReconstruction> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Google.Atap.Tangoservice.TangoCameraIntrinsics p0 = global::Java.Lang.Object.GetObject<global::Com.Google.Atap.Tangoservice.TangoCameraIntrinsics> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetDepthCameraCalibration (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setDepthCameraCalibration_Lcom_google_atap_tangoservice_TangoCameraIntrinsics_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.atap.tango.reconstruction']/class[@name='Tango3dReconstruction']/method[@name='setDepthCameraCalibration' and count(parameter)=1 and parameter[1][@type='com.google.atap.tangoservice.TangoCameraIntrinsics']]"
		[Register ("setDepthCameraCalibration", "(Lcom/google/atap/tangoservice/TangoCameraIntrinsics;)V", "GetSetDepthCameraCalibration_Lcom_google_atap_tangoservice_TangoCameraIntrinsics_Handler")]
		public virtual unsafe void SetDepthCameraCalibration (global::Com.Google.Atap.Tangoservice.TangoCameraIntrinsics p0)
		{
			if (id_setDepthCameraCalibration_Lcom_google_atap_tangoservice_TangoCameraIntrinsics_ == IntPtr.Zero)
				id_setDepthCameraCalibration_Lcom_google_atap_tangoservice_TangoCameraIntrinsics_ = JNIEnv.GetMethodID (class_ref, "setDepthCameraCalibration", "(Lcom/google/atap/tangoservice/TangoCameraIntrinsics;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setDepthCameraCalibration_Lcom_google_atap_tangoservice_TangoCameraIntrinsics_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setDepthCameraCalibration", "(Lcom/google/atap/tangoservice/TangoCameraIntrinsics;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_update_Lcom_google_atap_tangoservice_TangoPointCloudData_Lcom_google_atap_tangoservice_TangoPoseData_;
#pragma warning disable 0169
		static Delegate GetUpdate_Lcom_google_atap_tangoservice_TangoPointCloudData_Lcom_google_atap_tangoservice_TangoPoseData_Handler ()
		{
			if (cb_update_Lcom_google_atap_tangoservice_TangoPointCloudData_Lcom_google_atap_tangoservice_TangoPoseData_ == null)
				cb_update_Lcom_google_atap_tangoservice_TangoPointCloudData_Lcom_google_atap_tangoservice_TangoPoseData_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_Update_Lcom_google_atap_tangoservice_TangoPointCloudData_Lcom_google_atap_tangoservice_TangoPoseData_);
			return cb_update_Lcom_google_atap_tangoservice_TangoPointCloudData_Lcom_google_atap_tangoservice_TangoPoseData_;
		}

		static IntPtr n_Update_Lcom_google_atap_tangoservice_TangoPointCloudData_Lcom_google_atap_tangoservice_TangoPoseData_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Google.Atap.Tango.Reconstruction.Tango3dReconstruction __this = global::Java.Lang.Object.GetObject<global::Com.Google.Atap.Tango.Reconstruction.Tango3dReconstruction> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Google.Atap.Tangoservice.TangoPointCloudData p0 = global::Java.Lang.Object.GetObject<global::Com.Google.Atap.Tangoservice.TangoPointCloudData> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Google.Atap.Tangoservice.TangoPoseData p1 = global::Java.Lang.Object.GetObject<global::Com.Google.Atap.Tangoservice.TangoPoseData> (native_p1, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = global::Android.Runtime.JavaList<int[]>.ToLocalJniHandle (__this.Update (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_update_Lcom_google_atap_tangoservice_TangoPointCloudData_Lcom_google_atap_tangoservice_TangoPoseData_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.atap.tango.reconstruction']/class[@name='Tango3dReconstruction']/method[@name='update' and count(parameter)=2 and parameter[1][@type='com.google.atap.tangoservice.TangoPointCloudData'] and parameter[2][@type='com.google.atap.tangoservice.TangoPoseData']]"
		[Register ("update", "(Lcom/google/atap/tangoservice/TangoPointCloudData;Lcom/google/atap/tangoservice/TangoPoseData;)Ljava/util/List;", "GetUpdate_Lcom_google_atap_tangoservice_TangoPointCloudData_Lcom_google_atap_tangoservice_TangoPoseData_Handler")]
		public virtual unsafe global::System.Collections.Generic.IList<int[]> Update (global::Com.Google.Atap.Tangoservice.TangoPointCloudData p0, global::Com.Google.Atap.Tangoservice.TangoPoseData p1)
		{
			if (id_update_Lcom_google_atap_tangoservice_TangoPointCloudData_Lcom_google_atap_tangoservice_TangoPoseData_ == IntPtr.Zero)
				id_update_Lcom_google_atap_tangoservice_TangoPointCloudData_Lcom_google_atap_tangoservice_TangoPoseData_ = JNIEnv.GetMethodID (class_ref, "update", "(Lcom/google/atap/tangoservice/TangoPointCloudData;Lcom/google/atap/tangoservice/TangoPoseData;)Ljava/util/List;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				global::System.Collections.Generic.IList<int[]> __ret;
				if (GetType () == ThresholdType)
					__ret = global::Android.Runtime.JavaList<int[]>.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_update_Lcom_google_atap_tangoservice_TangoPointCloudData_Lcom_google_atap_tangoservice_TangoPoseData_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Android.Runtime.JavaList<int[]>.FromJniHandle (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "update", "(Lcom/google/atap/tangoservice/TangoPointCloudData;Lcom/google/atap/tangoservice/TangoPoseData;)Ljava/util/List;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_update_Lcom_google_atap_tangoservice_TangoPointCloudData_Lcom_google_atap_tangoservice_TangoPoseData_Lcom_google_atap_tangoservice_experimental_TangoImageBuffer_Lcom_google_atap_tangoservice_TangoPoseData_;
#pragma warning disable 0169
		static Delegate GetUpdate_Lcom_google_atap_tangoservice_TangoPointCloudData_Lcom_google_atap_tangoservice_TangoPoseData_Lcom_google_atap_tangoservice_experimental_TangoImageBuffer_Lcom_google_atap_tangoservice_TangoPoseData_Handler ()
		{
			if (cb_update_Lcom_google_atap_tangoservice_TangoPointCloudData_Lcom_google_atap_tangoservice_TangoPoseData_Lcom_google_atap_tangoservice_experimental_TangoImageBuffer_Lcom_google_atap_tangoservice_TangoPoseData_ == null)
				cb_update_Lcom_google_atap_tangoservice_TangoPointCloudData_Lcom_google_atap_tangoservice_TangoPoseData_Lcom_google_atap_tangoservice_experimental_TangoImageBuffer_Lcom_google_atap_tangoservice_TangoPoseData_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_Update_Lcom_google_atap_tangoservice_TangoPointCloudData_Lcom_google_atap_tangoservice_TangoPoseData_Lcom_google_atap_tangoservice_experimental_TangoImageBuffer_Lcom_google_atap_tangoservice_TangoPoseData_);
			return cb_update_Lcom_google_atap_tangoservice_TangoPointCloudData_Lcom_google_atap_tangoservice_TangoPoseData_Lcom_google_atap_tangoservice_experimental_TangoImageBuffer_Lcom_google_atap_tangoservice_TangoPoseData_;
		}

		static IntPtr n_Update_Lcom_google_atap_tangoservice_TangoPointCloudData_Lcom_google_atap_tangoservice_TangoPoseData_Lcom_google_atap_tangoservice_experimental_TangoImageBuffer_Lcom_google_atap_tangoservice_TangoPoseData_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2, IntPtr native_p3)
		{
			global::Com.Google.Atap.Tango.Reconstruction.Tango3dReconstruction __this = global::Java.Lang.Object.GetObject<global::Com.Google.Atap.Tango.Reconstruction.Tango3dReconstruction> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Google.Atap.Tangoservice.TangoPointCloudData p0 = global::Java.Lang.Object.GetObject<global::Com.Google.Atap.Tangoservice.TangoPointCloudData> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Google.Atap.Tangoservice.TangoPoseData p1 = global::Java.Lang.Object.GetObject<global::Com.Google.Atap.Tangoservice.TangoPoseData> (native_p1, JniHandleOwnership.DoNotTransfer);
			global::Com.Google.Atap.Tangoservice.Experimental.TangoImageBuffer p2 = global::Java.Lang.Object.GetObject<global::Com.Google.Atap.Tangoservice.Experimental.TangoImageBuffer> (native_p2, JniHandleOwnership.DoNotTransfer);
			global::Com.Google.Atap.Tangoservice.TangoPoseData p3 = global::Java.Lang.Object.GetObject<global::Com.Google.Atap.Tangoservice.TangoPoseData> (native_p3, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = global::Android.Runtime.JavaList<int[]>.ToLocalJniHandle (__this.Update (p0, p1, p2, p3));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_update_Lcom_google_atap_tangoservice_TangoPointCloudData_Lcom_google_atap_tangoservice_TangoPoseData_Lcom_google_atap_tangoservice_experimental_TangoImageBuffer_Lcom_google_atap_tangoservice_TangoPoseData_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.atap.tango.reconstruction']/class[@name='Tango3dReconstruction']/method[@name='update' and count(parameter)=4 and parameter[1][@type='com.google.atap.tangoservice.TangoPointCloudData'] and parameter[2][@type='com.google.atap.tangoservice.TangoPoseData'] and parameter[3][@type='com.google.atap.tangoservice.experimental.TangoImageBuffer'] and parameter[4][@type='com.google.atap.tangoservice.TangoPoseData']]"
		[Register ("update", "(Lcom/google/atap/tangoservice/TangoPointCloudData;Lcom/google/atap/tangoservice/TangoPoseData;Lcom/google/atap/tangoservice/experimental/TangoImageBuffer;Lcom/google/atap/tangoservice/TangoPoseData;)Ljava/util/List;", "GetUpdate_Lcom_google_atap_tangoservice_TangoPointCloudData_Lcom_google_atap_tangoservice_TangoPoseData_Lcom_google_atap_tangoservice_experimental_TangoImageBuffer_Lcom_google_atap_tangoservice_TangoPoseData_Handler")]
		public virtual unsafe global::System.Collections.Generic.IList<int[]> Update (global::Com.Google.Atap.Tangoservice.TangoPointCloudData p0, global::Com.Google.Atap.Tangoservice.TangoPoseData p1, global::Com.Google.Atap.Tangoservice.Experimental.TangoImageBuffer p2, global::Com.Google.Atap.Tangoservice.TangoPoseData p3)
		{
			if (id_update_Lcom_google_atap_tangoservice_TangoPointCloudData_Lcom_google_atap_tangoservice_TangoPoseData_Lcom_google_atap_tangoservice_experimental_TangoImageBuffer_Lcom_google_atap_tangoservice_TangoPoseData_ == IntPtr.Zero)
				id_update_Lcom_google_atap_tangoservice_TangoPointCloudData_Lcom_google_atap_tangoservice_TangoPoseData_Lcom_google_atap_tangoservice_experimental_TangoImageBuffer_Lcom_google_atap_tangoservice_TangoPoseData_ = JNIEnv.GetMethodID (class_ref, "update", "(Lcom/google/atap/tangoservice/TangoPointCloudData;Lcom/google/atap/tangoservice/TangoPoseData;Lcom/google/atap/tangoservice/experimental/TangoImageBuffer;Lcom/google/atap/tangoservice/TangoPoseData;)Ljava/util/List;");
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);

				global::System.Collections.Generic.IList<int[]> __ret;
				if (GetType () == ThresholdType)
					__ret = global::Android.Runtime.JavaList<int[]>.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_update_Lcom_google_atap_tangoservice_TangoPointCloudData_Lcom_google_atap_tangoservice_TangoPoseData_Lcom_google_atap_tangoservice_experimental_TangoImageBuffer_Lcom_google_atap_tangoservice_TangoPoseData_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Android.Runtime.JavaList<int[]>.FromJniHandle (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "update", "(Lcom/google/atap/tangoservice/TangoPointCloudData;Lcom/google/atap/tangoservice/TangoPoseData;Lcom/google/atap/tangoservice/experimental/TangoImageBuffer;Lcom/google/atap/tangoservice/TangoPoseData;)Ljava/util/List;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_update_Lcom_google_atap_tangoservice_experimental_TangoImageBuffer_Lcom_google_atap_tangoservice_TangoPoseData_;
#pragma warning disable 0169
		static Delegate GetUpdate_Lcom_google_atap_tangoservice_experimental_TangoImageBuffer_Lcom_google_atap_tangoservice_TangoPoseData_Handler ()
		{
			if (cb_update_Lcom_google_atap_tangoservice_experimental_TangoImageBuffer_Lcom_google_atap_tangoservice_TangoPoseData_ == null)
				cb_update_Lcom_google_atap_tangoservice_experimental_TangoImageBuffer_Lcom_google_atap_tangoservice_TangoPoseData_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_Update_Lcom_google_atap_tangoservice_experimental_TangoImageBuffer_Lcom_google_atap_tangoservice_TangoPoseData_);
			return cb_update_Lcom_google_atap_tangoservice_experimental_TangoImageBuffer_Lcom_google_atap_tangoservice_TangoPoseData_;
		}

		static IntPtr n_Update_Lcom_google_atap_tangoservice_experimental_TangoImageBuffer_Lcom_google_atap_tangoservice_TangoPoseData_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Google.Atap.Tango.Reconstruction.Tango3dReconstruction __this = global::Java.Lang.Object.GetObject<global::Com.Google.Atap.Tango.Reconstruction.Tango3dReconstruction> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Google.Atap.Tangoservice.Experimental.TangoImageBuffer p0 = global::Java.Lang.Object.GetObject<global::Com.Google.Atap.Tangoservice.Experimental.TangoImageBuffer> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Google.Atap.Tangoservice.TangoPoseData p1 = global::Java.Lang.Object.GetObject<global::Com.Google.Atap.Tangoservice.TangoPoseData> (native_p1, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = global::Android.Runtime.JavaList<int[]>.ToLocalJniHandle (__this.Update (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_update_Lcom_google_atap_tangoservice_experimental_TangoImageBuffer_Lcom_google_atap_tangoservice_TangoPoseData_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.atap.tango.reconstruction']/class[@name='Tango3dReconstruction']/method[@name='update' and count(parameter)=2 and parameter[1][@type='com.google.atap.tangoservice.experimental.TangoImageBuffer'] and parameter[2][@type='com.google.atap.tangoservice.TangoPoseData']]"
		[Register ("update", "(Lcom/google/atap/tangoservice/experimental/TangoImageBuffer;Lcom/google/atap/tangoservice/TangoPoseData;)Ljava/util/List;", "GetUpdate_Lcom_google_atap_tangoservice_experimental_TangoImageBuffer_Lcom_google_atap_tangoservice_TangoPoseData_Handler")]
		public virtual unsafe global::System.Collections.Generic.IList<int[]> Update (global::Com.Google.Atap.Tangoservice.Experimental.TangoImageBuffer p0, global::Com.Google.Atap.Tangoservice.TangoPoseData p1)
		{
			if (id_update_Lcom_google_atap_tangoservice_experimental_TangoImageBuffer_Lcom_google_atap_tangoservice_TangoPoseData_ == IntPtr.Zero)
				id_update_Lcom_google_atap_tangoservice_experimental_TangoImageBuffer_Lcom_google_atap_tangoservice_TangoPoseData_ = JNIEnv.GetMethodID (class_ref, "update", "(Lcom/google/atap/tangoservice/experimental/TangoImageBuffer;Lcom/google/atap/tangoservice/TangoPoseData;)Ljava/util/List;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				global::System.Collections.Generic.IList<int[]> __ret;
				if (GetType () == ThresholdType)
					__ret = global::Android.Runtime.JavaList<int[]>.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_update_Lcom_google_atap_tangoservice_experimental_TangoImageBuffer_Lcom_google_atap_tangoservice_TangoPoseData_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Android.Runtime.JavaList<int[]>.FromJniHandle (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "update", "(Lcom/google/atap/tangoservice/experimental/TangoImageBuffer;Lcom/google/atap/tangoservice/TangoPoseData;)Ljava/util/List;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_update_Lcom_google_atap_tangoservice_experimental_TangoImageBuffer_Lcom_google_atap_tangoservice_TangoPoseData_Lcom_google_atap_tangoservice_experimental_TangoImageBuffer_Lcom_google_atap_tangoservice_TangoPoseData_;
#pragma warning disable 0169
		static Delegate GetUpdate_Lcom_google_atap_tangoservice_experimental_TangoImageBuffer_Lcom_google_atap_tangoservice_TangoPoseData_Lcom_google_atap_tangoservice_experimental_TangoImageBuffer_Lcom_google_atap_tangoservice_TangoPoseData_Handler ()
		{
			if (cb_update_Lcom_google_atap_tangoservice_experimental_TangoImageBuffer_Lcom_google_atap_tangoservice_TangoPoseData_Lcom_google_atap_tangoservice_experimental_TangoImageBuffer_Lcom_google_atap_tangoservice_TangoPoseData_ == null)
				cb_update_Lcom_google_atap_tangoservice_experimental_TangoImageBuffer_Lcom_google_atap_tangoservice_TangoPoseData_Lcom_google_atap_tangoservice_experimental_TangoImageBuffer_Lcom_google_atap_tangoservice_TangoPoseData_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_Update_Lcom_google_atap_tangoservice_experimental_TangoImageBuffer_Lcom_google_atap_tangoservice_TangoPoseData_Lcom_google_atap_tangoservice_experimental_TangoImageBuffer_Lcom_google_atap_tangoservice_TangoPoseData_);
			return cb_update_Lcom_google_atap_tangoservice_experimental_TangoImageBuffer_Lcom_google_atap_tangoservice_TangoPoseData_Lcom_google_atap_tangoservice_experimental_TangoImageBuffer_Lcom_google_atap_tangoservice_TangoPoseData_;
		}

		static IntPtr n_Update_Lcom_google_atap_tangoservice_experimental_TangoImageBuffer_Lcom_google_atap_tangoservice_TangoPoseData_Lcom_google_atap_tangoservice_experimental_TangoImageBuffer_Lcom_google_atap_tangoservice_TangoPoseData_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2, IntPtr native_p3)
		{
			global::Com.Google.Atap.Tango.Reconstruction.Tango3dReconstruction __this = global::Java.Lang.Object.GetObject<global::Com.Google.Atap.Tango.Reconstruction.Tango3dReconstruction> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Google.Atap.Tangoservice.Experimental.TangoImageBuffer p0 = global::Java.Lang.Object.GetObject<global::Com.Google.Atap.Tangoservice.Experimental.TangoImageBuffer> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Google.Atap.Tangoservice.TangoPoseData p1 = global::Java.Lang.Object.GetObject<global::Com.Google.Atap.Tangoservice.TangoPoseData> (native_p1, JniHandleOwnership.DoNotTransfer);
			global::Com.Google.Atap.Tangoservice.Experimental.TangoImageBuffer p2 = global::Java.Lang.Object.GetObject<global::Com.Google.Atap.Tangoservice.Experimental.TangoImageBuffer> (native_p2, JniHandleOwnership.DoNotTransfer);
			global::Com.Google.Atap.Tangoservice.TangoPoseData p3 = global::Java.Lang.Object.GetObject<global::Com.Google.Atap.Tangoservice.TangoPoseData> (native_p3, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = global::Android.Runtime.JavaList<int[]>.ToLocalJniHandle (__this.Update (p0, p1, p2, p3));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_update_Lcom_google_atap_tangoservice_experimental_TangoImageBuffer_Lcom_google_atap_tangoservice_TangoPoseData_Lcom_google_atap_tangoservice_experimental_TangoImageBuffer_Lcom_google_atap_tangoservice_TangoPoseData_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.atap.tango.reconstruction']/class[@name='Tango3dReconstruction']/method[@name='update' and count(parameter)=4 and parameter[1][@type='com.google.atap.tangoservice.experimental.TangoImageBuffer'] and parameter[2][@type='com.google.atap.tangoservice.TangoPoseData'] and parameter[3][@type='com.google.atap.tangoservice.experimental.TangoImageBuffer'] and parameter[4][@type='com.google.atap.tangoservice.TangoPoseData']]"
		[Register ("update", "(Lcom/google/atap/tangoservice/experimental/TangoImageBuffer;Lcom/google/atap/tangoservice/TangoPoseData;Lcom/google/atap/tangoservice/experimental/TangoImageBuffer;Lcom/google/atap/tangoservice/TangoPoseData;)Ljava/util/List;", "GetUpdate_Lcom_google_atap_tangoservice_experimental_TangoImageBuffer_Lcom_google_atap_tangoservice_TangoPoseData_Lcom_google_atap_tangoservice_experimental_TangoImageBuffer_Lcom_google_atap_tangoservice_TangoPoseData_Handler")]
		public virtual unsafe global::System.Collections.Generic.IList<int[]> Update (global::Com.Google.Atap.Tangoservice.Experimental.TangoImageBuffer p0, global::Com.Google.Atap.Tangoservice.TangoPoseData p1, global::Com.Google.Atap.Tangoservice.Experimental.TangoImageBuffer p2, global::Com.Google.Atap.Tangoservice.TangoPoseData p3)
		{
			if (id_update_Lcom_google_atap_tangoservice_experimental_TangoImageBuffer_Lcom_google_atap_tangoservice_TangoPoseData_Lcom_google_atap_tangoservice_experimental_TangoImageBuffer_Lcom_google_atap_tangoservice_TangoPoseData_ == IntPtr.Zero)
				id_update_Lcom_google_atap_tangoservice_experimental_TangoImageBuffer_Lcom_google_atap_tangoservice_TangoPoseData_Lcom_google_atap_tangoservice_experimental_TangoImageBuffer_Lcom_google_atap_tangoservice_TangoPoseData_ = JNIEnv.GetMethodID (class_ref, "update", "(Lcom/google/atap/tangoservice/experimental/TangoImageBuffer;Lcom/google/atap/tangoservice/TangoPoseData;Lcom/google/atap/tangoservice/experimental/TangoImageBuffer;Lcom/google/atap/tangoservice/TangoPoseData;)Ljava/util/List;");
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);

				global::System.Collections.Generic.IList<int[]> __ret;
				if (GetType () == ThresholdType)
					__ret = global::Android.Runtime.JavaList<int[]>.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_update_Lcom_google_atap_tangoservice_experimental_TangoImageBuffer_Lcom_google_atap_tangoservice_TangoPoseData_Lcom_google_atap_tangoservice_experimental_TangoImageBuffer_Lcom_google_atap_tangoservice_TangoPoseData_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Android.Runtime.JavaList<int[]>.FromJniHandle (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "update", "(Lcom/google/atap/tangoservice/experimental/TangoImageBuffer;Lcom/google/atap/tangoservice/TangoPoseData;Lcom/google/atap/tangoservice/experimental/TangoImageBuffer;Lcom/google/atap/tangoservice/TangoPoseData;)Ljava/util/List;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_updateFloorplan_Lcom_google_atap_tangoservice_TangoPointCloudData_Lcom_google_atap_tangoservice_TangoPoseData_;
#pragma warning disable 0169
		static Delegate GetUpdateFloorplan_Lcom_google_atap_tangoservice_TangoPointCloudData_Lcom_google_atap_tangoservice_TangoPoseData_Handler ()
		{
			if (cb_updateFloorplan_Lcom_google_atap_tangoservice_TangoPointCloudData_Lcom_google_atap_tangoservice_TangoPoseData_ == null)
				cb_updateFloorplan_Lcom_google_atap_tangoservice_TangoPointCloudData_Lcom_google_atap_tangoservice_TangoPoseData_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_UpdateFloorplan_Lcom_google_atap_tangoservice_TangoPointCloudData_Lcom_google_atap_tangoservice_TangoPoseData_);
			return cb_updateFloorplan_Lcom_google_atap_tangoservice_TangoPointCloudData_Lcom_google_atap_tangoservice_TangoPoseData_;
		}

		static IntPtr n_UpdateFloorplan_Lcom_google_atap_tangoservice_TangoPointCloudData_Lcom_google_atap_tangoservice_TangoPoseData_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Google.Atap.Tango.Reconstruction.Tango3dReconstruction __this = global::Java.Lang.Object.GetObject<global::Com.Google.Atap.Tango.Reconstruction.Tango3dReconstruction> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Google.Atap.Tangoservice.TangoPointCloudData p0 = global::Java.Lang.Object.GetObject<global::Com.Google.Atap.Tangoservice.TangoPointCloudData> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Google.Atap.Tangoservice.TangoPoseData p1 = global::Java.Lang.Object.GetObject<global::Com.Google.Atap.Tangoservice.TangoPoseData> (native_p1, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = global::Android.Runtime.JavaList<int[]>.ToLocalJniHandle (__this.UpdateFloorplan (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_updateFloorplan_Lcom_google_atap_tangoservice_TangoPointCloudData_Lcom_google_atap_tangoservice_TangoPoseData_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.atap.tango.reconstruction']/class[@name='Tango3dReconstruction']/method[@name='updateFloorplan' and count(parameter)=2 and parameter[1][@type='com.google.atap.tangoservice.TangoPointCloudData'] and parameter[2][@type='com.google.atap.tangoservice.TangoPoseData']]"
		[Register ("updateFloorplan", "(Lcom/google/atap/tangoservice/TangoPointCloudData;Lcom/google/atap/tangoservice/TangoPoseData;)Ljava/util/List;", "GetUpdateFloorplan_Lcom_google_atap_tangoservice_TangoPointCloudData_Lcom_google_atap_tangoservice_TangoPoseData_Handler")]
		public virtual unsafe global::System.Collections.Generic.IList<int[]> UpdateFloorplan (global::Com.Google.Atap.Tangoservice.TangoPointCloudData p0, global::Com.Google.Atap.Tangoservice.TangoPoseData p1)
		{
			if (id_updateFloorplan_Lcom_google_atap_tangoservice_TangoPointCloudData_Lcom_google_atap_tangoservice_TangoPoseData_ == IntPtr.Zero)
				id_updateFloorplan_Lcom_google_atap_tangoservice_TangoPointCloudData_Lcom_google_atap_tangoservice_TangoPoseData_ = JNIEnv.GetMethodID (class_ref, "updateFloorplan", "(Lcom/google/atap/tangoservice/TangoPointCloudData;Lcom/google/atap/tangoservice/TangoPoseData;)Ljava/util/List;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				global::System.Collections.Generic.IList<int[]> __ret;
				if (GetType () == ThresholdType)
					__ret = global::Android.Runtime.JavaList<int[]>.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_updateFloorplan_Lcom_google_atap_tangoservice_TangoPointCloudData_Lcom_google_atap_tangoservice_TangoPoseData_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Android.Runtime.JavaList<int[]>.FromJniHandle (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "updateFloorplan", "(Lcom/google/atap/tangoservice/TangoPointCloudData;Lcom/google/atap/tangoservice/TangoPoseData;)Ljava/util/List;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_updateFromTrajectoryAndDataset_Lcom_google_atap_tango_dataset_TangoDataset_Lcom_google_atap_tango_reconstruction_Tango3dReconstructionTrajectory_Lcom_google_atap_tango_reconstruction_Tango3dReconstruction_ProgressCallback_;
#pragma warning disable 0169
		static Delegate GetUpdateFromTrajectoryAndDataset_Lcom_google_atap_tango_dataset_TangoDataset_Lcom_google_atap_tango_reconstruction_Tango3dReconstructionTrajectory_Lcom_google_atap_tango_reconstruction_Tango3dReconstruction_ProgressCallback_Handler ()
		{
			if (cb_updateFromTrajectoryAndDataset_Lcom_google_atap_tango_dataset_TangoDataset_Lcom_google_atap_tango_reconstruction_Tango3dReconstructionTrajectory_Lcom_google_atap_tango_reconstruction_Tango3dReconstruction_ProgressCallback_ == null)
				cb_updateFromTrajectoryAndDataset_Lcom_google_atap_tango_dataset_TangoDataset_Lcom_google_atap_tango_reconstruction_Tango3dReconstructionTrajectory_Lcom_google_atap_tango_reconstruction_Tango3dReconstruction_ProgressCallback_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_UpdateFromTrajectoryAndDataset_Lcom_google_atap_tango_dataset_TangoDataset_Lcom_google_atap_tango_reconstruction_Tango3dReconstructionTrajectory_Lcom_google_atap_tango_reconstruction_Tango3dReconstruction_ProgressCallback_);
			return cb_updateFromTrajectoryAndDataset_Lcom_google_atap_tango_dataset_TangoDataset_Lcom_google_atap_tango_reconstruction_Tango3dReconstructionTrajectory_Lcom_google_atap_tango_reconstruction_Tango3dReconstruction_ProgressCallback_;
		}

		static void n_UpdateFromTrajectoryAndDataset_Lcom_google_atap_tango_dataset_TangoDataset_Lcom_google_atap_tango_reconstruction_Tango3dReconstructionTrajectory_Lcom_google_atap_tango_reconstruction_Tango3dReconstruction_ProgressCallback_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			global::Com.Google.Atap.Tango.Reconstruction.Tango3dReconstruction __this = global::Java.Lang.Object.GetObject<global::Com.Google.Atap.Tango.Reconstruction.Tango3dReconstruction> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Google.Atap.Tango.Dataset.TangoDataset p0 = global::Java.Lang.Object.GetObject<global::Com.Google.Atap.Tango.Dataset.TangoDataset> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Google.Atap.Tango.Reconstruction.Tango3dReconstructionTrajectory p1 = global::Java.Lang.Object.GetObject<global::Com.Google.Atap.Tango.Reconstruction.Tango3dReconstructionTrajectory> (native_p1, JniHandleOwnership.DoNotTransfer);
			global::Com.Google.Atap.Tango.Reconstruction.Tango3dReconstruction.IProgressCallback p2 = (global::Com.Google.Atap.Tango.Reconstruction.Tango3dReconstruction.IProgressCallback)global::Java.Lang.Object.GetObject<global::Com.Google.Atap.Tango.Reconstruction.Tango3dReconstruction.IProgressCallback> (native_p2, JniHandleOwnership.DoNotTransfer);
			__this.UpdateFromTrajectoryAndDataset (p0, p1, p2);
		}
#pragma warning restore 0169

		static IntPtr id_updateFromTrajectoryAndDataset_Lcom_google_atap_tango_dataset_TangoDataset_Lcom_google_atap_tango_reconstruction_Tango3dReconstructionTrajectory_Lcom_google_atap_tango_reconstruction_Tango3dReconstruction_ProgressCallback_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.atap.tango.reconstruction']/class[@name='Tango3dReconstruction']/method[@name='updateFromTrajectoryAndDataset' and count(parameter)=3 and parameter[1][@type='com.google.atap.tango.dataset.TangoDataset'] and parameter[2][@type='com.google.atap.tango.reconstruction.Tango3dReconstructionTrajectory'] and parameter[3][@type='com.google.atap.tango.reconstruction.Tango3dReconstruction.ProgressCallback']]"
		[Register ("updateFromTrajectoryAndDataset", "(Lcom/google/atap/tango/dataset/TangoDataset;Lcom/google/atap/tango/reconstruction/Tango3dReconstructionTrajectory;Lcom/google/atap/tango/reconstruction/Tango3dReconstruction$ProgressCallback;)V", "GetUpdateFromTrajectoryAndDataset_Lcom_google_atap_tango_dataset_TangoDataset_Lcom_google_atap_tango_reconstruction_Tango3dReconstructionTrajectory_Lcom_google_atap_tango_reconstruction_Tango3dReconstruction_ProgressCallback_Handler")]
		public virtual unsafe void UpdateFromTrajectoryAndDataset (global::Com.Google.Atap.Tango.Dataset.TangoDataset p0, global::Com.Google.Atap.Tango.Reconstruction.Tango3dReconstructionTrajectory p1, global::Com.Google.Atap.Tango.Reconstruction.Tango3dReconstruction.IProgressCallback p2)
		{
			if (id_updateFromTrajectoryAndDataset_Lcom_google_atap_tango_dataset_TangoDataset_Lcom_google_atap_tango_reconstruction_Tango3dReconstructionTrajectory_Lcom_google_atap_tango_reconstruction_Tango3dReconstruction_ProgressCallback_ == IntPtr.Zero)
				id_updateFromTrajectoryAndDataset_Lcom_google_atap_tango_dataset_TangoDataset_Lcom_google_atap_tango_reconstruction_Tango3dReconstructionTrajectory_Lcom_google_atap_tango_reconstruction_Tango3dReconstruction_ProgressCallback_ = JNIEnv.GetMethodID (class_ref, "updateFromTrajectoryAndDataset", "(Lcom/google/atap/tango/dataset/TangoDataset;Lcom/google/atap/tango/reconstruction/Tango3dReconstructionTrajectory;Lcom/google/atap/tango/reconstruction/Tango3dReconstruction$ProgressCallback;)V");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_updateFromTrajectoryAndDataset_Lcom_google_atap_tango_dataset_TangoDataset_Lcom_google_atap_tango_reconstruction_Tango3dReconstructionTrajectory_Lcom_google_atap_tango_reconstruction_Tango3dReconstruction_ProgressCallback_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "updateFromTrajectoryAndDataset", "(Lcom/google/atap/tango/dataset/TangoDataset;Lcom/google/atap/tango/reconstruction/Tango3dReconstructionTrajectory;Lcom/google/atap/tango/reconstruction/Tango3dReconstruction$ProgressCallback;)V"), __args);
			} finally {
			}
		}

	}
}
