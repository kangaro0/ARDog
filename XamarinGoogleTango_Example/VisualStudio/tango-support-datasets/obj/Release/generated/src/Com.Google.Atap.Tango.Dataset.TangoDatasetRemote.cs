using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Google.Atap.Tango.Dataset {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.google.atap.tango.dataset']/class[@name='TangoDatasetRemote']"
	[global::Android.Runtime.Register ("com/google/atap/tango/dataset/TangoDatasetRemote", DoNotGenerateAcw=true)]
	public partial class TangoDatasetRemote : global::Java.Lang.Object {

		// Metadata.xml XPath interface reference: path="/api/package[@name='com.google.atap.tango.dataset']/interface[@name='TangoDatasetRemote.ProgressCallback']"
		[Register ("com/google/atap/tango/dataset/TangoDatasetRemote$ProgressCallback", "", "Com.Google.Atap.Tango.Dataset.TangoDatasetRemote/IProgressCallbackInvoker")]
		public partial interface IProgressCallback : IJavaObject {

			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.atap.tango.dataset']/interface[@name='TangoDatasetRemote.ProgressCallback']/method[@name='onProgress' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("onProgress", "(I)V", "GetOnProgress_IHandler:Com.Google.Atap.Tango.Dataset.TangoDatasetRemote/IProgressCallbackInvoker, tango-support-datasets")]
			void OnProgress (int p0);

		}

		[global::Android.Runtime.Register ("com/google/atap/tango/dataset/TangoDatasetRemote$ProgressCallback", DoNotGenerateAcw=true)]
		internal class IProgressCallbackInvoker : global::Java.Lang.Object, IProgressCallback {

			static IntPtr java_class_ref = JNIEnv.FindClass ("com/google/atap/tango/dataset/TangoDatasetRemote$ProgressCallback");

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
								JNIEnv.GetClassNameFromInstance (handle), "com.google.atap.tango.dataset.TangoDatasetRemote.ProgressCallback"));
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
				global::Com.Google.Atap.Tango.Dataset.TangoDatasetRemote.IProgressCallback __this = global::Java.Lang.Object.GetObject<global::Com.Google.Atap.Tango.Dataset.TangoDatasetRemote.IProgressCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
				return JNIEnv.FindClass ("com/google/atap/tango/dataset/TangoDatasetRemote", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (TangoDatasetRemote); }
		}

		protected TangoDatasetRemote (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Ljava_lang_String_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.google.atap.tango.dataset']/class[@name='TangoDatasetRemote']/constructor[@name='TangoDatasetRemote' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register (".ctor", "(Ljava/lang/String;)V", "")]
		public unsafe TangoDatasetRemote (string p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				if (GetType () != typeof (TangoDatasetRemote)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Ljava/lang/String;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Ljava/lang/String;)V", __args);
					return;
				}

				if (id_ctor_Ljava_lang_String_ == IntPtr.Zero)
					id_ctor_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/lang/String;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_lang_String_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Ljava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_getUUID;
#pragma warning disable 0169
		static Delegate GetGetUUIDHandler ()
		{
			if (cb_getUUID == null)
				cb_getUUID = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetUUID);
			return cb_getUUID;
		}

		static IntPtr n_GetUUID (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Google.Atap.Tango.Dataset.TangoDatasetRemote __this = global::Java.Lang.Object.GetObject<global::Com.Google.Atap.Tango.Dataset.TangoDatasetRemote> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.UUID);
		}
#pragma warning restore 0169

		static IntPtr id_getUUID;
		public virtual unsafe string UUID {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.atap.tango.dataset']/class[@name='TangoDatasetRemote']/method[@name='getUUID' and count(parameter)=0]"
			[Register ("getUUID", "()Ljava/lang/String;", "GetGetUUIDHandler")]
			get {
				if (id_getUUID == IntPtr.Zero)
					id_getUUID = JNIEnv.GetMethodID (class_ref, "getUUID", "()Ljava/lang/String;");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getUUID), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getUUID", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_copyRemoteToLocal_Landroid_content_Context_Ljava_io_File_;
#pragma warning disable 0169
		static Delegate GetCopyRemoteToLocal_Landroid_content_Context_Ljava_io_File_Handler ()
		{
			if (cb_copyRemoteToLocal_Landroid_content_Context_Ljava_io_File_ == null)
				cb_copyRemoteToLocal_Landroid_content_Context_Ljava_io_File_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, bool>) n_CopyRemoteToLocal_Landroid_content_Context_Ljava_io_File_);
			return cb_copyRemoteToLocal_Landroid_content_Context_Ljava_io_File_;
		}

		static bool n_CopyRemoteToLocal_Landroid_content_Context_Ljava_io_File_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Google.Atap.Tango.Dataset.TangoDatasetRemote __this = global::Java.Lang.Object.GetObject<global::Com.Google.Atap.Tango.Dataset.TangoDatasetRemote> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Context p0 = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Java.IO.File p1 = global::Java.Lang.Object.GetObject<global::Java.IO.File> (native_p1, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.CopyRemoteToLocal (p0, p1);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_copyRemoteToLocal_Landroid_content_Context_Ljava_io_File_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.atap.tango.dataset']/class[@name='TangoDatasetRemote']/method[@name='copyRemoteToLocal' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.io.File']]"
		[Register ("copyRemoteToLocal", "(Landroid/content/Context;Ljava/io/File;)Z", "GetCopyRemoteToLocal_Landroid_content_Context_Ljava_io_File_Handler")]
		public virtual unsafe bool CopyRemoteToLocal (global::Android.Content.Context p0, global::Java.IO.File p1)
		{
			if (id_copyRemoteToLocal_Landroid_content_Context_Ljava_io_File_ == IntPtr.Zero)
				id_copyRemoteToLocal_Landroid_content_Context_Ljava_io_File_ = JNIEnv.GetMethodID (class_ref, "copyRemoteToLocal", "(Landroid/content/Context;Ljava/io/File;)Z");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				bool __ret;
				if (GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_copyRemoteToLocal_Landroid_content_Context_Ljava_io_File_, __args);
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "copyRemoteToLocal", "(Landroid/content/Context;Ljava/io/File;)Z"), __args);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_copyRemoteToLocal_Landroid_content_Context_Ljava_io_File_Lcom_google_atap_tango_dataset_TangoDatasetRemote_ProgressCallback_;
#pragma warning disable 0169
		static Delegate GetCopyRemoteToLocal_Landroid_content_Context_Ljava_io_File_Lcom_google_atap_tango_dataset_TangoDatasetRemote_ProgressCallback_Handler ()
		{
			if (cb_copyRemoteToLocal_Landroid_content_Context_Ljava_io_File_Lcom_google_atap_tango_dataset_TangoDatasetRemote_ProgressCallback_ == null)
				cb_copyRemoteToLocal_Landroid_content_Context_Ljava_io_File_Lcom_google_atap_tango_dataset_TangoDatasetRemote_ProgressCallback_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, bool>) n_CopyRemoteToLocal_Landroid_content_Context_Ljava_io_File_Lcom_google_atap_tango_dataset_TangoDatasetRemote_ProgressCallback_);
			return cb_copyRemoteToLocal_Landroid_content_Context_Ljava_io_File_Lcom_google_atap_tango_dataset_TangoDatasetRemote_ProgressCallback_;
		}

		static bool n_CopyRemoteToLocal_Landroid_content_Context_Ljava_io_File_Lcom_google_atap_tango_dataset_TangoDatasetRemote_ProgressCallback_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			global::Com.Google.Atap.Tango.Dataset.TangoDatasetRemote __this = global::Java.Lang.Object.GetObject<global::Com.Google.Atap.Tango.Dataset.TangoDatasetRemote> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Context p0 = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Java.IO.File p1 = global::Java.Lang.Object.GetObject<global::Java.IO.File> (native_p1, JniHandleOwnership.DoNotTransfer);
			global::Com.Google.Atap.Tango.Dataset.TangoDatasetRemote.IProgressCallback p2 = (global::Com.Google.Atap.Tango.Dataset.TangoDatasetRemote.IProgressCallback)global::Java.Lang.Object.GetObject<global::Com.Google.Atap.Tango.Dataset.TangoDatasetRemote.IProgressCallback> (native_p2, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.CopyRemoteToLocal (p0, p1, p2);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_copyRemoteToLocal_Landroid_content_Context_Ljava_io_File_Lcom_google_atap_tango_dataset_TangoDatasetRemote_ProgressCallback_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.atap.tango.dataset']/class[@name='TangoDatasetRemote']/method[@name='copyRemoteToLocal' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.io.File'] and parameter[3][@type='com.google.atap.tango.dataset.TangoDatasetRemote.ProgressCallback']]"
		[Register ("copyRemoteToLocal", "(Landroid/content/Context;Ljava/io/File;Lcom/google/atap/tango/dataset/TangoDatasetRemote$ProgressCallback;)Z", "GetCopyRemoteToLocal_Landroid_content_Context_Ljava_io_File_Lcom_google_atap_tango_dataset_TangoDatasetRemote_ProgressCallback_Handler")]
		public virtual unsafe bool CopyRemoteToLocal (global::Android.Content.Context p0, global::Java.IO.File p1, global::Com.Google.Atap.Tango.Dataset.TangoDatasetRemote.IProgressCallback p2)
		{
			if (id_copyRemoteToLocal_Landroid_content_Context_Ljava_io_File_Lcom_google_atap_tango_dataset_TangoDatasetRemote_ProgressCallback_ == IntPtr.Zero)
				id_copyRemoteToLocal_Landroid_content_Context_Ljava_io_File_Lcom_google_atap_tango_dataset_TangoDatasetRemote_ProgressCallback_ = JNIEnv.GetMethodID (class_ref, "copyRemoteToLocal", "(Landroid/content/Context;Ljava/io/File;Lcom/google/atap/tango/dataset/TangoDatasetRemote$ProgressCallback;)Z");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);

				bool __ret;
				if (GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_copyRemoteToLocal_Landroid_content_Context_Ljava_io_File_Lcom_google_atap_tango_dataset_TangoDatasetRemote_ProgressCallback_, __args);
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "copyRemoteToLocal", "(Landroid/content/Context;Ljava/io/File;Lcom/google/atap/tango/dataset/TangoDatasetRemote$ProgressCallback;)Z"), __args);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_deleteRemote_Landroid_content_Context_;
#pragma warning disable 0169
		static Delegate GetDeleteRemote_Landroid_content_Context_Handler ()
		{
			if (cb_deleteRemote_Landroid_content_Context_ == null)
				cb_deleteRemote_Landroid_content_Context_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_DeleteRemote_Landroid_content_Context_);
			return cb_deleteRemote_Landroid_content_Context_;
		}

		static bool n_DeleteRemote_Landroid_content_Context_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Google.Atap.Tango.Dataset.TangoDatasetRemote __this = global::Java.Lang.Object.GetObject<global::Com.Google.Atap.Tango.Dataset.TangoDatasetRemote> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Context p0 = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.DeleteRemote (p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_deleteRemote_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.atap.tango.dataset']/class[@name='TangoDatasetRemote']/method[@name='deleteRemote' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("deleteRemote", "(Landroid/content/Context;)Z", "GetDeleteRemote_Landroid_content_Context_Handler")]
		public virtual unsafe bool DeleteRemote (global::Android.Content.Context p0)
		{
			if (id_deleteRemote_Landroid_content_Context_ == IntPtr.Zero)
				id_deleteRemote_Landroid_content_Context_ = JNIEnv.GetMethodID (class_ref, "deleteRemote", "(Landroid/content/Context;)Z");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				bool __ret;
				if (GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_deleteRemote_Landroid_content_Context_, __args);
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "deleteRemote", "(Landroid/content/Context;)Z"), __args);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_getCurrentRemoteDataset_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.atap.tango.dataset']/class[@name='TangoDatasetRemote']/method[@name='getCurrentRemoteDataset' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("getCurrentRemoteDataset", "(Landroid/content/Context;)Lcom/google/atap/tango/dataset/TangoDatasetRemote;", "")]
		public static unsafe global::Com.Google.Atap.Tango.Dataset.TangoDatasetRemote GetCurrentRemoteDataset (global::Android.Content.Context p0)
		{
			if (id_getCurrentRemoteDataset_Landroid_content_Context_ == IntPtr.Zero)
				id_getCurrentRemoteDataset_Landroid_content_Context_ = JNIEnv.GetStaticMethodID (class_ref, "getCurrentRemoteDataset", "(Landroid/content/Context;)Lcom/google/atap/tango/dataset/TangoDatasetRemote;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				global::Com.Google.Atap.Tango.Dataset.TangoDatasetRemote __ret = global::Java.Lang.Object.GetObject<global::Com.Google.Atap.Tango.Dataset.TangoDatasetRemote> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getCurrentRemoteDataset_Landroid_content_Context_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_getRemoteDatasetsList_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.atap.tango.dataset']/class[@name='TangoDatasetRemote']/method[@name='getRemoteDatasetsList' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("getRemoteDatasetsList", "(Landroid/content/Context;)Ljava/util/List;", "")]
		public static unsafe global::System.Collections.Generic.IList<global::Com.Google.Atap.Tango.Dataset.TangoDatasetRemote> GetRemoteDatasetsList (global::Android.Content.Context p0)
		{
			if (id_getRemoteDatasetsList_Landroid_content_Context_ == IntPtr.Zero)
				id_getRemoteDatasetsList_Landroid_content_Context_ = JNIEnv.GetStaticMethodID (class_ref, "getRemoteDatasetsList", "(Landroid/content/Context;)Ljava/util/List;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				global::System.Collections.Generic.IList<global::Com.Google.Atap.Tango.Dataset.TangoDatasetRemote> __ret = global::Android.Runtime.JavaList<global::Com.Google.Atap.Tango.Dataset.TangoDatasetRemote>.FromJniHandle (JNIEnv.CallStaticObjectMethod  (class_ref, id_getRemoteDatasetsList_Landroid_content_Context_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_listRemoteFiles_Landroid_content_Context_;
#pragma warning disable 0169
		static Delegate GetListRemoteFiles_Landroid_content_Context_Handler ()
		{
			if (cb_listRemoteFiles_Landroid_content_Context_ == null)
				cb_listRemoteFiles_Landroid_content_Context_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_ListRemoteFiles_Landroid_content_Context_);
			return cb_listRemoteFiles_Landroid_content_Context_;
		}

		static IntPtr n_ListRemoteFiles_Landroid_content_Context_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Google.Atap.Tango.Dataset.TangoDatasetRemote __this = global::Java.Lang.Object.GetObject<global::Com.Google.Atap.Tango.Dataset.TangoDatasetRemote> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Context p0 = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.ListRemoteFiles (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_listRemoteFiles_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.atap.tango.dataset']/class[@name='TangoDatasetRemote']/method[@name='listRemoteFiles' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("listRemoteFiles", "(Landroid/content/Context;)Ljava/lang/Iterable;", "GetListRemoteFiles_Landroid_content_Context_Handler")]
		public virtual unsafe global::Java.Lang.IIterable ListRemoteFiles (global::Android.Content.Context p0)
		{
			if (id_listRemoteFiles_Landroid_content_Context_ == IntPtr.Zero)
				id_listRemoteFiles_Landroid_content_Context_ = JNIEnv.GetMethodID (class_ref, "listRemoteFiles", "(Landroid/content/Context;)Ljava/lang/Iterable;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				global::Java.Lang.IIterable __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Java.Lang.IIterable> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_listRemoteFiles_Landroid_content_Context_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Java.Lang.IIterable> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "listRemoteFiles", "(Landroid/content/Context;)Ljava/lang/Iterable;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_listRemoteFiles_Landroid_content_Context_Ljava_lang_String_ZZ;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.atap.tango.dataset']/class[@name='TangoDatasetRemote']/method[@name='listRemoteFiles' and count(parameter)=4 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='boolean'] and parameter[4][@type='boolean']]"
		[Register ("listRemoteFiles", "(Landroid/content/Context;Ljava/lang/String;ZZ)Ljava/util/Collection;", "")]
		public static unsafe global::System.Collections.Generic.ICollection<string> ListRemoteFiles (global::Android.Content.Context p0, string p1, bool p2, bool p3)
		{
			if (id_listRemoteFiles_Landroid_content_Context_Ljava_lang_String_ZZ == IntPtr.Zero)
				id_listRemoteFiles_Landroid_content_Context_Ljava_lang_String_ZZ = JNIEnv.GetStaticMethodID (class_ref, "listRemoteFiles", "(Landroid/content/Context;Ljava/lang/String;ZZ)Ljava/util/Collection;");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				global::System.Collections.Generic.ICollection<string> __ret = global::Android.Runtime.JavaCollection<string>.FromJniHandle (JNIEnv.CallStaticObjectMethod  (class_ref, id_listRemoteFiles_Landroid_content_Context_Ljava_lang_String_ZZ, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static Delegate cb_moveRemoteToLocal_Landroid_content_Context_Ljava_io_File_;
#pragma warning disable 0169
		static Delegate GetMoveRemoteToLocal_Landroid_content_Context_Ljava_io_File_Handler ()
		{
			if (cb_moveRemoteToLocal_Landroid_content_Context_Ljava_io_File_ == null)
				cb_moveRemoteToLocal_Landroid_content_Context_Ljava_io_File_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, bool>) n_MoveRemoteToLocal_Landroid_content_Context_Ljava_io_File_);
			return cb_moveRemoteToLocal_Landroid_content_Context_Ljava_io_File_;
		}

		static bool n_MoveRemoteToLocal_Landroid_content_Context_Ljava_io_File_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Google.Atap.Tango.Dataset.TangoDatasetRemote __this = global::Java.Lang.Object.GetObject<global::Com.Google.Atap.Tango.Dataset.TangoDatasetRemote> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Context p0 = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Java.IO.File p1 = global::Java.Lang.Object.GetObject<global::Java.IO.File> (native_p1, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.MoveRemoteToLocal (p0, p1);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_moveRemoteToLocal_Landroid_content_Context_Ljava_io_File_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.atap.tango.dataset']/class[@name='TangoDatasetRemote']/method[@name='moveRemoteToLocal' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.io.File']]"
		[Register ("moveRemoteToLocal", "(Landroid/content/Context;Ljava/io/File;)Z", "GetMoveRemoteToLocal_Landroid_content_Context_Ljava_io_File_Handler")]
		public virtual unsafe bool MoveRemoteToLocal (global::Android.Content.Context p0, global::Java.IO.File p1)
		{
			if (id_moveRemoteToLocal_Landroid_content_Context_Ljava_io_File_ == IntPtr.Zero)
				id_moveRemoteToLocal_Landroid_content_Context_Ljava_io_File_ = JNIEnv.GetMethodID (class_ref, "moveRemoteToLocal", "(Landroid/content/Context;Ljava/io/File;)Z");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				bool __ret;
				if (GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_moveRemoteToLocal_Landroid_content_Context_Ljava_io_File_, __args);
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "moveRemoteToLocal", "(Landroid/content/Context;Ljava/io/File;)Z"), __args);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_moveRemoteToLocal_Landroid_content_Context_Ljava_io_File_Lcom_google_atap_tango_dataset_TangoDatasetRemote_ProgressCallback_;
#pragma warning disable 0169
		static Delegate GetMoveRemoteToLocal_Landroid_content_Context_Ljava_io_File_Lcom_google_atap_tango_dataset_TangoDatasetRemote_ProgressCallback_Handler ()
		{
			if (cb_moveRemoteToLocal_Landroid_content_Context_Ljava_io_File_Lcom_google_atap_tango_dataset_TangoDatasetRemote_ProgressCallback_ == null)
				cb_moveRemoteToLocal_Landroid_content_Context_Ljava_io_File_Lcom_google_atap_tango_dataset_TangoDatasetRemote_ProgressCallback_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, bool>) n_MoveRemoteToLocal_Landroid_content_Context_Ljava_io_File_Lcom_google_atap_tango_dataset_TangoDatasetRemote_ProgressCallback_);
			return cb_moveRemoteToLocal_Landroid_content_Context_Ljava_io_File_Lcom_google_atap_tango_dataset_TangoDatasetRemote_ProgressCallback_;
		}

		static bool n_MoveRemoteToLocal_Landroid_content_Context_Ljava_io_File_Lcom_google_atap_tango_dataset_TangoDatasetRemote_ProgressCallback_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			global::Com.Google.Atap.Tango.Dataset.TangoDatasetRemote __this = global::Java.Lang.Object.GetObject<global::Com.Google.Atap.Tango.Dataset.TangoDatasetRemote> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Context p0 = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Java.IO.File p1 = global::Java.Lang.Object.GetObject<global::Java.IO.File> (native_p1, JniHandleOwnership.DoNotTransfer);
			global::Com.Google.Atap.Tango.Dataset.TangoDatasetRemote.IProgressCallback p2 = (global::Com.Google.Atap.Tango.Dataset.TangoDatasetRemote.IProgressCallback)global::Java.Lang.Object.GetObject<global::Com.Google.Atap.Tango.Dataset.TangoDatasetRemote.IProgressCallback> (native_p2, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.MoveRemoteToLocal (p0, p1, p2);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_moveRemoteToLocal_Landroid_content_Context_Ljava_io_File_Lcom_google_atap_tango_dataset_TangoDatasetRemote_ProgressCallback_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.atap.tango.dataset']/class[@name='TangoDatasetRemote']/method[@name='moveRemoteToLocal' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.io.File'] and parameter[3][@type='com.google.atap.tango.dataset.TangoDatasetRemote.ProgressCallback']]"
		[Register ("moveRemoteToLocal", "(Landroid/content/Context;Ljava/io/File;Lcom/google/atap/tango/dataset/TangoDatasetRemote$ProgressCallback;)Z", "GetMoveRemoteToLocal_Landroid_content_Context_Ljava_io_File_Lcom_google_atap_tango_dataset_TangoDatasetRemote_ProgressCallback_Handler")]
		public virtual unsafe bool MoveRemoteToLocal (global::Android.Content.Context p0, global::Java.IO.File p1, global::Com.Google.Atap.Tango.Dataset.TangoDatasetRemote.IProgressCallback p2)
		{
			if (id_moveRemoteToLocal_Landroid_content_Context_Ljava_io_File_Lcom_google_atap_tango_dataset_TangoDatasetRemote_ProgressCallback_ == IntPtr.Zero)
				id_moveRemoteToLocal_Landroid_content_Context_Ljava_io_File_Lcom_google_atap_tango_dataset_TangoDatasetRemote_ProgressCallback_ = JNIEnv.GetMethodID (class_ref, "moveRemoteToLocal", "(Landroid/content/Context;Ljava/io/File;Lcom/google/atap/tango/dataset/TangoDatasetRemote$ProgressCallback;)Z");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);

				bool __ret;
				if (GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_moveRemoteToLocal_Landroid_content_Context_Ljava_io_File_Lcom_google_atap_tango_dataset_TangoDatasetRemote_ProgressCallback_, __args);
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "moveRemoteToLocal", "(Landroid/content/Context;Ljava/io/File;Lcom/google/atap/tango/dataset/TangoDatasetRemote$ProgressCallback;)Z"), __args);
				return __ret;
			} finally {
			}
		}

	}
}
