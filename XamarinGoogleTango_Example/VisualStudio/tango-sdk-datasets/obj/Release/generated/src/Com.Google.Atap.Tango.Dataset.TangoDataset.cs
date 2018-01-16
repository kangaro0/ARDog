using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Google.Atap.Tango.Dataset {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.google.atap.tango.dataset']/class[@name='TangoDataset']"
	[global::Android.Runtime.Register ("com/google/atap/tango/dataset/TangoDataset", DoNotGenerateAcw=true)]
	public partial class TangoDataset : global::Java.Lang.Object, global::Android.OS.IParcelable {


		static IntPtr CREATOR_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.atap.tango.dataset']/class[@name='TangoDataset']/field[@name='CREATOR']"
		[Register ("CREATOR")]
		public static global::Android.OS.IParcelableCreator Creator {
			get {
				if (CREATOR_jfieldId == IntPtr.Zero)
					CREATOR_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "CREATOR", "Landroid/os/Parcelable$Creator;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, CREATOR_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Android.OS.IParcelableCreator> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr TANGO_DEFAULT_EXPORT_DIRECTORY_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.atap.tango.dataset']/class[@name='TangoDataset']/field[@name='TANGO_DEFAULT_EXPORT_DIRECTORY']"
		[Register ("TANGO_DEFAULT_EXPORT_DIRECTORY")]
		public static string TangoDefaultExportDirectory {
			get {
				if (TANGO_DEFAULT_EXPORT_DIRECTORY_jfieldId == IntPtr.Zero)
					TANGO_DEFAULT_EXPORT_DIRECTORY_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "TANGO_DEFAULT_EXPORT_DIRECTORY", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, TANGO_DEFAULT_EXPORT_DIRECTORY_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}
		// Metadata.xml XPath interface reference: path="/api/package[@name='com.google.atap.tango.dataset']/interface[@name='TangoDataset.Callback']"
		[Register ("com/google/atap/tango/dataset/TangoDataset$Callback", "", "Com.Google.Atap.Tango.Dataset.TangoDataset/ICallbackInvoker")]
		public partial interface ICallback : IJavaObject {

			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.atap.tango.dataset']/interface[@name='TangoDataset.Callback']/method[@name='onProgress' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("onProgress", "(I)V", "GetOnProgress_IHandler:Com.Google.Atap.Tango.Dataset.TangoDataset/ICallbackInvoker, tango-sdk-datasets")]
			void OnProgress (int p0);

		}

		[global::Android.Runtime.Register ("com/google/atap/tango/dataset/TangoDataset$Callback", DoNotGenerateAcw=true)]
		internal class ICallbackInvoker : global::Java.Lang.Object, ICallback {

			static IntPtr java_class_ref = JNIEnv.FindClass ("com/google/atap/tango/dataset/TangoDataset$Callback");

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (ICallbackInvoker); }
			}

			IntPtr class_ref;

			public static ICallback GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<ICallback> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.google.atap.tango.dataset.TangoDataset.Callback"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public ICallbackInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
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
				global::Com.Google.Atap.Tango.Dataset.TangoDataset.ICallback __this = global::Java.Lang.Object.GetObject<global::Com.Google.Atap.Tango.Dataset.TangoDataset.ICallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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


		// Metadata.xml XPath class reference: path="/api/package[@name='com.google.atap.tango.dataset']/class[@name='TangoDataset.ExportFormat']"
		[global::Android.Runtime.Register ("com/google/atap/tango/dataset/TangoDataset$ExportFormat", DoNotGenerateAcw=true)]
		public sealed partial class ExportFormat : global::Java.Lang.Enum {


			static IntPtr COMPRESSED_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.google.atap.tango.dataset']/class[@name='TangoDataset.ExportFormat']/field[@name='COMPRESSED']"
			[Register ("COMPRESSED")]
			public static global::Com.Google.Atap.Tango.Dataset.TangoDataset.ExportFormat Compressed {
				get {
					if (COMPRESSED_jfieldId == IntPtr.Zero)
						COMPRESSED_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "COMPRESSED", "Lcom/google/atap/tango/dataset/TangoDataset$ExportFormat;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, COMPRESSED_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Google.Atap.Tango.Dataset.TangoDataset.ExportFormat> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr UNCOMPRESSED_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.google.atap.tango.dataset']/class[@name='TangoDataset.ExportFormat']/field[@name='UNCOMPRESSED']"
			[Register ("UNCOMPRESSED")]
			public static global::Com.Google.Atap.Tango.Dataset.TangoDataset.ExportFormat Uncompressed {
				get {
					if (UNCOMPRESSED_jfieldId == IntPtr.Zero)
						UNCOMPRESSED_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "UNCOMPRESSED", "Lcom/google/atap/tango/dataset/TangoDataset$ExportFormat;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, UNCOMPRESSED_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Google.Atap.Tango.Dataset.TangoDataset.ExportFormat> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}
			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/google/atap/tango/dataset/TangoDataset$ExportFormat", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (ExportFormat); }
			}

			internal ExportFormat (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_valueOf_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.atap.tango.dataset']/class[@name='TangoDataset.ExportFormat']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lcom/google/atap/tango/dataset/TangoDataset$ExportFormat;", "")]
			public static unsafe global::Com.Google.Atap.Tango.Dataset.TangoDataset.ExportFormat ValueOf (string p0)
			{
				if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
					id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lcom/google/atap/tango/dataset/TangoDataset$ExportFormat;");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_p0);
					global::Com.Google.Atap.Tango.Dataset.TangoDataset.ExportFormat __ret = global::Java.Lang.Object.GetObject<global::Com.Google.Atap.Tango.Dataset.TangoDataset.ExportFormat> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

			static IntPtr id_values;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.atap.tango.dataset']/class[@name='TangoDataset.ExportFormat']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lcom/google/atap/tango/dataset/TangoDataset$ExportFormat;", "")]
			public static unsafe global::Com.Google.Atap.Tango.Dataset.TangoDataset.ExportFormat[] Values ()
			{
				if (id_values == IntPtr.Zero)
					id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lcom/google/atap/tango/dataset/TangoDataset$ExportFormat;");
				try {
					return (global::Com.Google.Atap.Tango.Dataset.TangoDataset.ExportFormat[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Com.Google.Atap.Tango.Dataset.TangoDataset.ExportFormat));
				} finally {
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.google.atap.tango.dataset']/class[@name='TangoDataset.RecordingMode']"
		[global::Android.Runtime.Register ("com/google/atap/tango/dataset/TangoDataset$RecordingMode", DoNotGenerateAcw=true)]
		public sealed partial class RecordingMode : global::Java.Lang.Enum {


			static IntPtr ALL_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.google.atap.tango.dataset']/class[@name='TangoDataset.RecordingMode']/field[@name='ALL']"
			[Register ("ALL")]
			public static global::Com.Google.Atap.Tango.Dataset.TangoDataset.RecordingMode All {
				get {
					if (ALL_jfieldId == IntPtr.Zero)
						ALL_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "ALL", "Lcom/google/atap/tango/dataset/TangoDataset$RecordingMode;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, ALL_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Google.Atap.Tango.Dataset.TangoDataset.RecordingMode> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr MOTION_TRACKING_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.google.atap.tango.dataset']/class[@name='TangoDataset.RecordingMode']/field[@name='MOTION_TRACKING']"
			[Register ("MOTION_TRACKING")]
			public static global::Com.Google.Atap.Tango.Dataset.TangoDataset.RecordingMode MotionTracking {
				get {
					if (MOTION_TRACKING_jfieldId == IntPtr.Zero)
						MOTION_TRACKING_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "MOTION_TRACKING", "Lcom/google/atap/tango/dataset/TangoDataset$RecordingMode;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, MOTION_TRACKING_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Google.Atap.Tango.Dataset.TangoDataset.RecordingMode> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr MOTION_TRACKING_AND_FISHEYE_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.google.atap.tango.dataset']/class[@name='TangoDataset.RecordingMode']/field[@name='MOTION_TRACKING_AND_FISHEYE']"
			[Register ("MOTION_TRACKING_AND_FISHEYE")]
			public static global::Com.Google.Atap.Tango.Dataset.TangoDataset.RecordingMode MotionTrackingAndFisheye {
				get {
					if (MOTION_TRACKING_AND_FISHEYE_jfieldId == IntPtr.Zero)
						MOTION_TRACKING_AND_FISHEYE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "MOTION_TRACKING_AND_FISHEYE", "Lcom/google/atap/tango/dataset/TangoDataset$RecordingMode;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, MOTION_TRACKING_AND_FISHEYE_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Google.Atap.Tango.Dataset.TangoDataset.RecordingMode> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr SCENE_RECONSTRUCTION_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.google.atap.tango.dataset']/class[@name='TangoDataset.RecordingMode']/field[@name='SCENE_RECONSTRUCTION']"
			[Register ("SCENE_RECONSTRUCTION")]
			public static global::Com.Google.Atap.Tango.Dataset.TangoDataset.RecordingMode SceneReconstruction {
				get {
					if (SCENE_RECONSTRUCTION_jfieldId == IntPtr.Zero)
						SCENE_RECONSTRUCTION_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "SCENE_RECONSTRUCTION", "Lcom/google/atap/tango/dataset/TangoDataset$RecordingMode;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, SCENE_RECONSTRUCTION_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Google.Atap.Tango.Dataset.TangoDataset.RecordingMode> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr UNKNOWN_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.google.atap.tango.dataset']/class[@name='TangoDataset.RecordingMode']/field[@name='UNKNOWN']"
			[Register ("UNKNOWN")]
			public static global::Com.Google.Atap.Tango.Dataset.TangoDataset.RecordingMode Unknown {
				get {
					if (UNKNOWN_jfieldId == IntPtr.Zero)
						UNKNOWN_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "UNKNOWN", "Lcom/google/atap/tango/dataset/TangoDataset$RecordingMode;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, UNKNOWN_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Google.Atap.Tango.Dataset.TangoDataset.RecordingMode> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}
			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/google/atap/tango/dataset/TangoDataset$RecordingMode", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (RecordingMode); }
			}

			internal RecordingMode (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_getName;
			public unsafe string Name {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.google.atap.tango.dataset']/class[@name='TangoDataset.RecordingMode']/method[@name='getName' and count(parameter)=0]"
				[Register ("getName", "()Ljava/lang/String;", "GetGetNameHandler")]
				get {
					if (id_getName == IntPtr.Zero)
						id_getName = JNIEnv.GetMethodID (class_ref, "getName", "()Ljava/lang/String;");
					try {
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getName), JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
			}

			static IntPtr id_getOrdinal;
			public unsafe int Ordinal {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.google.atap.tango.dataset']/class[@name='TangoDataset.RecordingMode']/method[@name='getOrdinal' and count(parameter)=0]"
				[Register ("getOrdinal", "()I", "GetGetOrdinalHandler")]
				get {
					if (id_getOrdinal == IntPtr.Zero)
						id_getOrdinal = JNIEnv.GetMethodID (class_ref, "getOrdinal", "()I");
					try {
						return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getOrdinal);
					} finally {
					}
				}
			}

			static IntPtr id_getByOrdinal_I;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.atap.tango.dataset']/class[@name='TangoDataset.RecordingMode']/method[@name='getByOrdinal' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("getByOrdinal", "(I)Lcom/google/atap/tango/dataset/TangoDataset$RecordingMode;", "")]
			public static unsafe global::Com.Google.Atap.Tango.Dataset.TangoDataset.RecordingMode GetByOrdinal (int p0)
			{
				if (id_getByOrdinal_I == IntPtr.Zero)
					id_getByOrdinal_I = JNIEnv.GetStaticMethodID (class_ref, "getByOrdinal", "(I)Lcom/google/atap/tango/dataset/TangoDataset$RecordingMode;");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (p0);
					return global::Java.Lang.Object.GetObject<global::Com.Google.Atap.Tango.Dataset.TangoDataset.RecordingMode> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getByOrdinal_I, __args), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			static IntPtr id_valueOf_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.atap.tango.dataset']/class[@name='TangoDataset.RecordingMode']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lcom/google/atap/tango/dataset/TangoDataset$RecordingMode;", "")]
			public static unsafe global::Com.Google.Atap.Tango.Dataset.TangoDataset.RecordingMode ValueOf (string p0)
			{
				if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
					id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lcom/google/atap/tango/dataset/TangoDataset$RecordingMode;");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_p0);
					global::Com.Google.Atap.Tango.Dataset.TangoDataset.RecordingMode __ret = global::Java.Lang.Object.GetObject<global::Com.Google.Atap.Tango.Dataset.TangoDataset.RecordingMode> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

			static IntPtr id_values;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.atap.tango.dataset']/class[@name='TangoDataset.RecordingMode']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lcom/google/atap/tango/dataset/TangoDataset$RecordingMode;", "")]
			public static unsafe global::Com.Google.Atap.Tango.Dataset.TangoDataset.RecordingMode[] Values ()
			{
				if (id_values == IntPtr.Zero)
					id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lcom/google/atap/tango/dataset/TangoDataset$RecordingMode;");
				try {
					return (global::Com.Google.Atap.Tango.Dataset.TangoDataset.RecordingMode[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Com.Google.Atap.Tango.Dataset.TangoDataset.RecordingMode));
				} finally {
				}
			}

		}

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/google/atap/tango/dataset/TangoDataset", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (TangoDataset); }
		}

		protected TangoDataset (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.google.atap.tango.dataset']/class[@name='TangoDataset']/constructor[@name='TangoDataset' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register (".ctor", "(Ljava/lang/String;Ljava/lang/String;)V", "")]
		public unsafe TangoDataset (string p0, string p1)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				if (GetType () != typeof (TangoDataset)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Ljava/lang/String;Ljava/lang/String;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Ljava/lang/String;Ljava/lang/String;)V", __args);
					return;
				}

				if (id_ctor_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
					id_ctor_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/lang/String;Ljava/lang/String;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_lang_String_Ljava_lang_String_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Ljava_lang_String_Ljava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static IntPtr id_ctor_Landroid_os_Parcel_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.google.atap.tango.dataset']/class[@name='TangoDataset']/constructor[@name='TangoDataset' and count(parameter)=1 and parameter[1][@type='android.os.Parcel']]"
		[Register (".ctor", "(Landroid/os/Parcel;)V", "")]
		protected unsafe TangoDataset (global::Android.OS.Parcel p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (GetType () != typeof (TangoDataset)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Landroid/os/Parcel;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Landroid/os/Parcel;)V", __args);
					return;
				}

				if (id_ctor_Landroid_os_Parcel_ == IntPtr.Zero)
					id_ctor_Landroid_os_Parcel_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/os/Parcel;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_os_Parcel_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Landroid_os_Parcel_, __args);
			} finally {
			}
		}

		static Delegate cb_getBaseDirectory;
#pragma warning disable 0169
		static Delegate GetGetBaseDirectoryHandler ()
		{
			if (cb_getBaseDirectory == null)
				cb_getBaseDirectory = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetBaseDirectory);
			return cb_getBaseDirectory;
		}

		static IntPtr n_GetBaseDirectory (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Google.Atap.Tango.Dataset.TangoDataset __this = global::Java.Lang.Object.GetObject<global::Com.Google.Atap.Tango.Dataset.TangoDataset> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.BaseDirectory);
		}
#pragma warning restore 0169

		static IntPtr id_getBaseDirectory;
		public virtual unsafe string BaseDirectory {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.atap.tango.dataset']/class[@name='TangoDataset']/method[@name='getBaseDirectory' and count(parameter)=0]"
			[Register ("getBaseDirectory", "()Ljava/lang/String;", "GetGetBaseDirectoryHandler")]
			get {
				if (id_getBaseDirectory == IntPtr.Zero)
					id_getBaseDirectory = JNIEnv.GetMethodID (class_ref, "getBaseDirectory", "()Ljava/lang/String;");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getBaseDirectory), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getBaseDirectory", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getDatasetPath;
#pragma warning disable 0169
		static Delegate GetGetDatasetPathHandler ()
		{
			if (cb_getDatasetPath == null)
				cb_getDatasetPath = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetDatasetPath);
			return cb_getDatasetPath;
		}

		static IntPtr n_GetDatasetPath (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Google.Atap.Tango.Dataset.TangoDataset __this = global::Java.Lang.Object.GetObject<global::Com.Google.Atap.Tango.Dataset.TangoDataset> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.DatasetPath);
		}
#pragma warning restore 0169

		static IntPtr id_getDatasetPath;
		public virtual unsafe string DatasetPath {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.atap.tango.dataset']/class[@name='TangoDataset']/method[@name='getDatasetPath' and count(parameter)=0]"
			[Register ("getDatasetPath", "()Ljava/lang/String;", "GetGetDatasetPathHandler")]
			get {
				if (id_getDatasetPath == IntPtr.Zero)
					id_getDatasetPath = JNIEnv.GetMethodID (class_ref, "getDatasetPath", "()Ljava/lang/String;");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getDatasetPath), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getDatasetPath", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getNotes;
#pragma warning disable 0169
		static Delegate GetGetNotesHandler ()
		{
			if (cb_getNotes == null)
				cb_getNotes = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetNotes);
			return cb_getNotes;
		}

		static IntPtr n_GetNotes (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Google.Atap.Tango.Dataset.TangoDataset __this = global::Java.Lang.Object.GetObject<global::Com.Google.Atap.Tango.Dataset.TangoDataset> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Notes);
		}
#pragma warning restore 0169

		static Delegate cb_setNotes_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetNotes_Ljava_lang_String_Handler ()
		{
			if (cb_setNotes_Ljava_lang_String_ == null)
				cb_setNotes_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetNotes_Ljava_lang_String_);
			return cb_setNotes_Ljava_lang_String_;
		}

		static void n_SetNotes_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Google.Atap.Tango.Dataset.TangoDataset __this = global::Java.Lang.Object.GetObject<global::Com.Google.Atap.Tango.Dataset.TangoDataset> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Notes = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getNotes;
		static IntPtr id_setNotes_Ljava_lang_String_;
		public virtual unsafe string Notes {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.atap.tango.dataset']/class[@name='TangoDataset']/method[@name='getNotes' and count(parameter)=0]"
			[Register ("getNotes", "()Ljava/lang/String;", "GetGetNotesHandler")]
			get {
				if (id_getNotes == IntPtr.Zero)
					id_getNotes = JNIEnv.GetMethodID (class_ref, "getNotes", "()Ljava/lang/String;");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getNotes), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getNotes", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.atap.tango.dataset']/class[@name='TangoDataset']/method[@name='setNotes' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setNotes", "(Ljava/lang/String;)V", "GetSetNotes_Ljava_lang_String_Handler")]
			set {
				if (id_setNotes_Ljava_lang_String_ == IntPtr.Zero)
					id_setNotes_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setNotes", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setNotes_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setNotes", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getTimestamp;
#pragma warning disable 0169
		static Delegate GetGetTimestampHandler ()
		{
			if (cb_getTimestamp == null)
				cb_getTimestamp = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long>) n_GetTimestamp);
			return cb_getTimestamp;
		}

		static long n_GetTimestamp (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Google.Atap.Tango.Dataset.TangoDataset __this = global::Java.Lang.Object.GetObject<global::Com.Google.Atap.Tango.Dataset.TangoDataset> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Timestamp;
		}
#pragma warning restore 0169

		static IntPtr id_getTimestamp;
		public virtual unsafe long Timestamp {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.atap.tango.dataset']/class[@name='TangoDataset']/method[@name='getTimestamp' and count(parameter)=0]"
			[Register ("getTimestamp", "()J", "GetGetTimestampHandler")]
			get {
				if (id_getTimestamp == IntPtr.Zero)
					id_getTimestamp = JNIEnv.GetMethodID (class_ref, "getTimestamp", "()J");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallLongMethod (((global::Java.Lang.Object) this).Handle, id_getTimestamp);
					else
						return JNIEnv.CallNonvirtualLongMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getTimestamp", "()J"));
				} finally {
				}
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
			global::Com.Google.Atap.Tango.Dataset.TangoDataset __this = global::Java.Lang.Object.GetObject<global::Com.Google.Atap.Tango.Dataset.TangoDataset> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.UUID);
		}
#pragma warning restore 0169

		static IntPtr id_getUUID;
		public virtual unsafe string UUID {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.atap.tango.dataset']/class[@name='TangoDataset']/method[@name='getUUID' and count(parameter)=0]"
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

		static Delegate cb_describeContents;
#pragma warning disable 0169
		static Delegate GetDescribeContentsHandler ()
		{
			if (cb_describeContents == null)
				cb_describeContents = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_DescribeContents);
			return cb_describeContents;
		}

		static int n_DescribeContents (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Google.Atap.Tango.Dataset.TangoDataset __this = global::Java.Lang.Object.GetObject<global::Com.Google.Atap.Tango.Dataset.TangoDataset> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.DescribeContents ();
		}
#pragma warning restore 0169

		static IntPtr id_describeContents;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.atap.tango.dataset']/class[@name='TangoDataset']/method[@name='describeContents' and count(parameter)=0]"
		[Register ("describeContents", "()I", "GetDescribeContentsHandler")]
		public virtual unsafe int DescribeContents ()
		{
			if (id_describeContents == IntPtr.Zero)
				id_describeContents = JNIEnv.GetMethodID (class_ref, "describeContents", "()I");
			try {

				if (GetType () == ThresholdType)
					return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_describeContents);
				else
					return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "describeContents", "()I"));
			} finally {
			}
		}

		static Delegate cb_export_Lcom_google_atap_tango_dataset_TangoDataset_ExportFormat_Lcom_google_atap_tango_dataset_TangoDataset_Callback_;
#pragma warning disable 0169
		static Delegate GetExport_Lcom_google_atap_tango_dataset_TangoDataset_ExportFormat_Lcom_google_atap_tango_dataset_TangoDataset_Callback_Handler ()
		{
			if (cb_export_Lcom_google_atap_tango_dataset_TangoDataset_ExportFormat_Lcom_google_atap_tango_dataset_TangoDataset_Callback_ == null)
				cb_export_Lcom_google_atap_tango_dataset_TangoDataset_ExportFormat_Lcom_google_atap_tango_dataset_TangoDataset_Callback_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_Export_Lcom_google_atap_tango_dataset_TangoDataset_ExportFormat_Lcom_google_atap_tango_dataset_TangoDataset_Callback_);
			return cb_export_Lcom_google_atap_tango_dataset_TangoDataset_ExportFormat_Lcom_google_atap_tango_dataset_TangoDataset_Callback_;
		}

		static void n_Export_Lcom_google_atap_tango_dataset_TangoDataset_ExportFormat_Lcom_google_atap_tango_dataset_TangoDataset_Callback_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Google.Atap.Tango.Dataset.TangoDataset __this = global::Java.Lang.Object.GetObject<global::Com.Google.Atap.Tango.Dataset.TangoDataset> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Google.Atap.Tango.Dataset.TangoDataset.ExportFormat p0 = global::Java.Lang.Object.GetObject<global::Com.Google.Atap.Tango.Dataset.TangoDataset.ExportFormat> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Google.Atap.Tango.Dataset.TangoDataset.ICallback p1 = (global::Com.Google.Atap.Tango.Dataset.TangoDataset.ICallback)global::Java.Lang.Object.GetObject<global::Com.Google.Atap.Tango.Dataset.TangoDataset.ICallback> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.Export (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_export_Lcom_google_atap_tango_dataset_TangoDataset_ExportFormat_Lcom_google_atap_tango_dataset_TangoDataset_Callback_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.atap.tango.dataset']/class[@name='TangoDataset']/method[@name='export' and count(parameter)=2 and parameter[1][@type='com.google.atap.tango.dataset.TangoDataset.ExportFormat'] and parameter[2][@type='com.google.atap.tango.dataset.TangoDataset.Callback']]"
		[Register ("export", "(Lcom/google/atap/tango/dataset/TangoDataset$ExportFormat;Lcom/google/atap/tango/dataset/TangoDataset$Callback;)V", "GetExport_Lcom_google_atap_tango_dataset_TangoDataset_ExportFormat_Lcom_google_atap_tango_dataset_TangoDataset_Callback_Handler")]
		public virtual unsafe void Export (global::Com.Google.Atap.Tango.Dataset.TangoDataset.ExportFormat p0, global::Com.Google.Atap.Tango.Dataset.TangoDataset.ICallback p1)
		{
			if (id_export_Lcom_google_atap_tango_dataset_TangoDataset_ExportFormat_Lcom_google_atap_tango_dataset_TangoDataset_Callback_ == IntPtr.Zero)
				id_export_Lcom_google_atap_tango_dataset_TangoDataset_ExportFormat_Lcom_google_atap_tango_dataset_TangoDataset_Callback_ = JNIEnv.GetMethodID (class_ref, "export", "(Lcom/google/atap/tango/dataset/TangoDataset$ExportFormat;Lcom/google/atap/tango/dataset/TangoDataset$Callback;)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_export_Lcom_google_atap_tango_dataset_TangoDataset_ExportFormat_Lcom_google_atap_tango_dataset_TangoDataset_Callback_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "export", "(Lcom/google/atap/tango/dataset/TangoDataset$ExportFormat;Lcom/google/atap/tango/dataset/TangoDataset$Callback;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_getRecordingMode;
#pragma warning disable 0169
		static Delegate GetGetRecordingModeHandler ()
		{
			if (cb_getRecordingMode == null)
				cb_getRecordingMode = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetRecordingMode);
			return cb_getRecordingMode;
		}

		static IntPtr n_GetRecordingMode (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Google.Atap.Tango.Dataset.TangoDataset __this = global::Java.Lang.Object.GetObject<global::Com.Google.Atap.Tango.Dataset.TangoDataset> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.GetRecordingMode ());
		}
#pragma warning restore 0169

		static IntPtr id_getRecordingMode;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.atap.tango.dataset']/class[@name='TangoDataset']/method[@name='getRecordingMode' and count(parameter)=0]"
		[Register ("getRecordingMode", "()Lcom/google/atap/tango/dataset/TangoDataset$RecordingMode;", "GetGetRecordingModeHandler")]
		public virtual unsafe global::Com.Google.Atap.Tango.Dataset.TangoDataset.RecordingMode GetRecordingMode ()
		{
			if (id_getRecordingMode == IntPtr.Zero)
				id_getRecordingMode = JNIEnv.GetMethodID (class_ref, "getRecordingMode", "()Lcom/google/atap/tango/dataset/TangoDataset$RecordingMode;");
			try {

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Com.Google.Atap.Tango.Dataset.TangoDataset.RecordingMode> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getRecordingMode), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Com.Google.Atap.Tango.Dataset.TangoDataset.RecordingMode> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getRecordingMode", "()Lcom/google/atap/tango/dataset/TangoDataset$RecordingMode;")), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_validate_Lcom_google_atap_tango_dataset_TangoDataset_Callback_;
#pragma warning disable 0169
		static Delegate GetValidate_Lcom_google_atap_tango_dataset_TangoDataset_Callback_Handler ()
		{
			if (cb_validate_Lcom_google_atap_tango_dataset_TangoDataset_Callback_ == null)
				cb_validate_Lcom_google_atap_tango_dataset_TangoDataset_Callback_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_Validate_Lcom_google_atap_tango_dataset_TangoDataset_Callback_);
			return cb_validate_Lcom_google_atap_tango_dataset_TangoDataset_Callback_;
		}

		static bool n_Validate_Lcom_google_atap_tango_dataset_TangoDataset_Callback_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Google.Atap.Tango.Dataset.TangoDataset __this = global::Java.Lang.Object.GetObject<global::Com.Google.Atap.Tango.Dataset.TangoDataset> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Google.Atap.Tango.Dataset.TangoDataset.ICallback p0 = (global::Com.Google.Atap.Tango.Dataset.TangoDataset.ICallback)global::Java.Lang.Object.GetObject<global::Com.Google.Atap.Tango.Dataset.TangoDataset.ICallback> (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.Validate (p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_validate_Lcom_google_atap_tango_dataset_TangoDataset_Callback_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.atap.tango.dataset']/class[@name='TangoDataset']/method[@name='validate' and count(parameter)=1 and parameter[1][@type='com.google.atap.tango.dataset.TangoDataset.Callback']]"
		[Register ("validate", "(Lcom/google/atap/tango/dataset/TangoDataset$Callback;)Z", "GetValidate_Lcom_google_atap_tango_dataset_TangoDataset_Callback_Handler")]
		public virtual unsafe bool Validate (global::Com.Google.Atap.Tango.Dataset.TangoDataset.ICallback p0)
		{
			if (id_validate_Lcom_google_atap_tango_dataset_TangoDataset_Callback_ == IntPtr.Zero)
				id_validate_Lcom_google_atap_tango_dataset_TangoDataset_Callback_ = JNIEnv.GetMethodID (class_ref, "validate", "(Lcom/google/atap/tango/dataset/TangoDataset$Callback;)Z");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				bool __ret;
				if (GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_validate_Lcom_google_atap_tango_dataset_TangoDataset_Callback_, __args);
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "validate", "(Lcom/google/atap/tango/dataset/TangoDataset$Callback;)Z"), __args);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_writeToParcel_Landroid_os_Parcel_I;
#pragma warning disable 0169
		static Delegate GetWriteToParcel_Landroid_os_Parcel_IHandler ()
		{
			if (cb_writeToParcel_Landroid_os_Parcel_I == null)
				cb_writeToParcel_Landroid_os_Parcel_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, int>) n_WriteToParcel_Landroid_os_Parcel_I);
			return cb_writeToParcel_Landroid_os_Parcel_I;
		}

		static void n_WriteToParcel_Landroid_os_Parcel_I (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int native_p1)
		{
			global::Com.Google.Atap.Tango.Dataset.TangoDataset __this = global::Java.Lang.Object.GetObject<global::Com.Google.Atap.Tango.Dataset.TangoDataset> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.Parcel p0 = global::Java.Lang.Object.GetObject<global::Android.OS.Parcel> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.ParcelableWriteFlags p1 = (global::Android.OS.ParcelableWriteFlags) native_p1;
			__this.WriteToParcel (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_writeToParcel_Landroid_os_Parcel_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.atap.tango.dataset']/class[@name='TangoDataset']/method[@name='writeToParcel' and count(parameter)=2 and parameter[1][@type='android.os.Parcel'] and parameter[2][@type='int']]"
		[Register ("writeToParcel", "(Landroid/os/Parcel;I)V", "GetWriteToParcel_Landroid_os_Parcel_IHandler")]
		public virtual unsafe void WriteToParcel (global::Android.OS.Parcel p0, [global::Android.Runtime.GeneratedEnum] global::Android.OS.ParcelableWriteFlags p1)
		{
			if (id_writeToParcel_Landroid_os_Parcel_I == IntPtr.Zero)
				id_writeToParcel_Landroid_os_Parcel_I = JNIEnv.GetMethodID (class_ref, "writeToParcel", "(Landroid/os/Parcel;I)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue ((int) p1);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_writeToParcel_Landroid_os_Parcel_I, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "writeToParcel", "(Landroid/os/Parcel;I)V"), __args);
			} finally {
			}
		}

	}
}
