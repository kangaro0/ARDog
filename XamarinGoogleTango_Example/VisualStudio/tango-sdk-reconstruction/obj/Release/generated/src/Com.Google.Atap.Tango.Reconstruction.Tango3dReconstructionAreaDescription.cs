using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Google.Atap.Tango.Reconstruction {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.google.atap.tango.reconstruction']/class[@name='Tango3dReconstructionAreaDescription']"
	[global::Android.Runtime.Register ("com/google/atap/tango/reconstruction/Tango3dReconstructionAreaDescription", DoNotGenerateAcw=true)]
	public partial class Tango3dReconstructionAreaDescription : global::Java.Lang.Object {

		// Metadata.xml XPath interface reference: path="/api/package[@name='com.google.atap.tango.reconstruction']/interface[@name='Tango3dReconstructionAreaDescription.ProgressCallback']"
		[Register ("com/google/atap/tango/reconstruction/Tango3dReconstructionAreaDescription$ProgressCallback", "", "Com.Google.Atap.Tango.Reconstruction.Tango3dReconstructionAreaDescription/IProgressCallbackInvoker")]
		public partial interface IProgressCallback : IJavaObject {

			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.atap.tango.reconstruction']/interface[@name='Tango3dReconstructionAreaDescription.ProgressCallback']/method[@name='onProgress' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("onProgress", "(I)V", "GetOnProgress_IHandler:Com.Google.Atap.Tango.Reconstruction.Tango3dReconstructionAreaDescription/IProgressCallbackInvoker, tango-sdk-reconstruction")]
			void OnProgress (int p0);

		}

		[global::Android.Runtime.Register ("com/google/atap/tango/reconstruction/Tango3dReconstructionAreaDescription$ProgressCallback", DoNotGenerateAcw=true)]
		internal class IProgressCallbackInvoker : global::Java.Lang.Object, IProgressCallback {

			static IntPtr java_class_ref = JNIEnv.FindClass ("com/google/atap/tango/reconstruction/Tango3dReconstructionAreaDescription$ProgressCallback");

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
								JNIEnv.GetClassNameFromInstance (handle), "com.google.atap.tango.reconstruction.Tango3dReconstructionAreaDescription.ProgressCallback"));
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
				global::Com.Google.Atap.Tango.Reconstruction.Tango3dReconstructionAreaDescription.IProgressCallback __this = global::Java.Lang.Object.GetObject<global::Com.Google.Atap.Tango.Reconstruction.Tango3dReconstructionAreaDescription.IProgressCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
				return JNIEnv.FindClass ("com/google/atap/tango/reconstruction/Tango3dReconstructionAreaDescription", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (Tango3dReconstructionAreaDescription); }
		}

		protected Tango3dReconstructionAreaDescription (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.google.atap.tango.reconstruction']/class[@name='Tango3dReconstructionAreaDescription']/constructor[@name='Tango3dReconstructionAreaDescription' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe Tango3dReconstructionAreaDescription ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (Tango3dReconstructionAreaDescription)) {
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

		static IntPtr id_createFromDataset_Lcom_google_atap_tango_dataset_TangoDataset_Ljava_lang_String_Lcom_google_atap_tango_reconstruction_Tango3dReconstructionAreaDescription_ProgressCallback_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.atap.tango.reconstruction']/class[@name='Tango3dReconstructionAreaDescription']/method[@name='createFromDataset' and count(parameter)=3 and parameter[1][@type='com.google.atap.tango.dataset.TangoDataset'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='com.google.atap.tango.reconstruction.Tango3dReconstructionAreaDescription.ProgressCallback']]"
		[Register ("createFromDataset", "(Lcom/google/atap/tango/dataset/TangoDataset;Ljava/lang/String;Lcom/google/atap/tango/reconstruction/Tango3dReconstructionAreaDescription$ProgressCallback;)Lcom/google/atap/tango/reconstruction/Tango3dReconstructionAreaDescription;", "")]
		public static unsafe global::Com.Google.Atap.Tango.Reconstruction.Tango3dReconstructionAreaDescription CreateFromDataset (global::Com.Google.Atap.Tango.Dataset.TangoDataset p0, string p1, global::Com.Google.Atap.Tango.Reconstruction.Tango3dReconstructionAreaDescription.IProgressCallback p2)
		{
			if (id_createFromDataset_Lcom_google_atap_tango_dataset_TangoDataset_Ljava_lang_String_Lcom_google_atap_tango_reconstruction_Tango3dReconstructionAreaDescription_ProgressCallback_ == IntPtr.Zero)
				id_createFromDataset_Lcom_google_atap_tango_dataset_TangoDataset_Ljava_lang_String_Lcom_google_atap_tango_reconstruction_Tango3dReconstructionAreaDescription_ProgressCallback_ = JNIEnv.GetStaticMethodID (class_ref, "createFromDataset", "(Lcom/google/atap/tango/dataset/TangoDataset;Ljava/lang/String;Lcom/google/atap/tango/reconstruction/Tango3dReconstructionAreaDescription$ProgressCallback;)Lcom/google/atap/tango/reconstruction/Tango3dReconstructionAreaDescription;");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (p2);
				global::Com.Google.Atap.Tango.Reconstruction.Tango3dReconstructionAreaDescription __ret = global::Java.Lang.Object.GetObject<global::Com.Google.Atap.Tango.Reconstruction.Tango3dReconstructionAreaDescription> (JNIEnv.CallStaticObjectMethod  (class_ref, id_createFromDataset_Lcom_google_atap_tango_dataset_TangoDataset_Ljava_lang_String_Lcom_google_atap_tango_reconstruction_Tango3dReconstructionAreaDescription_ProgressCallback_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
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
			global::Com.Google.Atap.Tango.Reconstruction.Tango3dReconstructionAreaDescription __this = global::Java.Lang.Object.GetObject<global::Com.Google.Atap.Tango.Reconstruction.Tango3dReconstructionAreaDescription> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Finalize ();
		}
#pragma warning restore 0169

		static IntPtr id_finalize;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.atap.tango.reconstruction']/class[@name='Tango3dReconstructionAreaDescription']/method[@name='finalize' and count(parameter)=0]"
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

		static IntPtr id_loadFromAdf_Ljava_io_File_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.atap.tango.reconstruction']/class[@name='Tango3dReconstructionAreaDescription']/method[@name='loadFromAdf' and count(parameter)=1 and parameter[1][@type='java.io.File']]"
		[Register ("loadFromAdf", "(Ljava/io/File;)Lcom/google/atap/tango/reconstruction/Tango3dReconstructionAreaDescription;", "")]
		public static unsafe global::Com.Google.Atap.Tango.Reconstruction.Tango3dReconstructionAreaDescription LoadFromAdf (global::Java.IO.File p0)
		{
			if (id_loadFromAdf_Ljava_io_File_ == IntPtr.Zero)
				id_loadFromAdf_Ljava_io_File_ = JNIEnv.GetStaticMethodID (class_ref, "loadFromAdf", "(Ljava/io/File;)Lcom/google/atap/tango/reconstruction/Tango3dReconstructionAreaDescription;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				global::Com.Google.Atap.Tango.Reconstruction.Tango3dReconstructionAreaDescription __ret = global::Java.Lang.Object.GetObject<global::Com.Google.Atap.Tango.Reconstruction.Tango3dReconstructionAreaDescription> (JNIEnv.CallStaticObjectMethod  (class_ref, id_loadFromAdf_Ljava_io_File_, __args), JniHandleOwnership.TransferLocalRef);
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
			global::Com.Google.Atap.Tango.Reconstruction.Tango3dReconstructionAreaDescription __this = global::Java.Lang.Object.GetObject<global::Com.Google.Atap.Tango.Reconstruction.Tango3dReconstructionAreaDescription> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Release ();
		}
#pragma warning restore 0169

		static IntPtr id_release;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.atap.tango.reconstruction']/class[@name='Tango3dReconstructionAreaDescription']/method[@name='release' and count(parameter)=0]"
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

		static Delegate cb_saveToAdf_Ljava_io_File_;
#pragma warning disable 0169
		static Delegate GetSaveToAdf_Ljava_io_File_Handler ()
		{
			if (cb_saveToAdf_Ljava_io_File_ == null)
				cb_saveToAdf_Ljava_io_File_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SaveToAdf_Ljava_io_File_);
			return cb_saveToAdf_Ljava_io_File_;
		}

		static void n_SaveToAdf_Ljava_io_File_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Google.Atap.Tango.Reconstruction.Tango3dReconstructionAreaDescription __this = global::Java.Lang.Object.GetObject<global::Com.Google.Atap.Tango.Reconstruction.Tango3dReconstructionAreaDescription> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.IO.File p0 = global::Java.Lang.Object.GetObject<global::Java.IO.File> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SaveToAdf (p0);
		}
#pragma warning restore 0169

		static IntPtr id_saveToAdf_Ljava_io_File_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.atap.tango.reconstruction']/class[@name='Tango3dReconstructionAreaDescription']/method[@name='saveToAdf' and count(parameter)=1 and parameter[1][@type='java.io.File']]"
		[Register ("saveToAdf", "(Ljava/io/File;)V", "GetSaveToAdf_Ljava_io_File_Handler")]
		public virtual unsafe void SaveToAdf (global::Java.IO.File p0)
		{
			if (id_saveToAdf_Ljava_io_File_ == IntPtr.Zero)
				id_saveToAdf_Ljava_io_File_ = JNIEnv.GetMethodID (class_ref, "saveToAdf", "(Ljava/io/File;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_saveToAdf_Ljava_io_File_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "saveToAdf", "(Ljava/io/File;)V"), __args);
			} finally {
			}
		}

	}
}
