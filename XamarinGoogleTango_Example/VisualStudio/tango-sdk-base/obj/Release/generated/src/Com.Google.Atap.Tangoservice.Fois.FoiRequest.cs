using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Google.Atap.Tangoservice.Fois {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.google.atap.tangoservice.fois']/class[@name='FoiRequest']"
	[global::Android.Runtime.Register ("com/google/atap/tangoservice/fois/FoiRequest", DoNotGenerateAcw=true)]
	public abstract partial class FoiRequest : global::Java.Lang.Object, global::Android.OS.IParcelable {


		static IntPtr CREATOR_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.atap.tangoservice.fois']/class[@name='FoiRequest']/field[@name='CREATOR']"
		[Register ("CREATOR")]
		public static global::Android.OS.IParcelableCreator Creator {
			get {
				if (CREATOR_jfieldId == IntPtr.Zero)
					CREATOR_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "CREATOR", "Landroid/os/Parcelable$Creator;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, CREATOR_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Android.OS.IParcelableCreator> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr mId_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.atap.tangoservice.fois']/class[@name='FoiRequest']/field[@name='mId']"
		[Register ("mId")]
		public string MId {
			get {
				if (mId_jfieldId == IntPtr.Zero)
					mId_jfieldId = JNIEnv.GetFieldID (class_ref, "mId", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, mId_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (mId_jfieldId == IntPtr.Zero)
					mId_jfieldId = JNIEnv.GetFieldID (class_ref, "mId", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, mId_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr mType_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.atap.tangoservice.fois']/class[@name='FoiRequest']/field[@name='mType']"
		[Register ("mType")]
		public global::Com.Google.Atap.Tangoservice.Fois.FoiRequest.Type MType {
			get {
				if (mType_jfieldId == IntPtr.Zero)
					mType_jfieldId = JNIEnv.GetFieldID (class_ref, "mType", "Lcom/google/atap/tangoservice/fois/FoiRequest$Type;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, mType_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Google.Atap.Tangoservice.Fois.FoiRequest.Type> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (mType_jfieldId == IntPtr.Zero)
					mType_jfieldId = JNIEnv.GetFieldID (class_ref, "mType", "Lcom/google/atap/tangoservice/fois/FoiRequest$Type;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, mType_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}
		// Metadata.xml XPath class reference: path="/api/package[@name='com.google.atap.tangoservice.fois']/class[@name='FoiRequest.Create']"
		[global::Android.Runtime.Register ("com/google/atap/tangoservice/fois/FoiRequest$Create", DoNotGenerateAcw=true)]
		public partial class Create : global::Com.Google.Atap.Tangoservice.Fois.FoiRequest {


			static IntPtr mBaseFrameId_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.google.atap.tangoservice.fois']/class[@name='FoiRequest.Create']/field[@name='mBaseFrameId']"
			[Register ("mBaseFrameId")]
			public string MBaseFrameId {
				get {
					if (mBaseFrameId_jfieldId == IntPtr.Zero)
						mBaseFrameId_jfieldId = JNIEnv.GetFieldID (class_ref, "mBaseFrameId", "Ljava/lang/String;");
					IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, mBaseFrameId_jfieldId);
					return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (mBaseFrameId_jfieldId == IntPtr.Zero)
						mBaseFrameId_jfieldId = JNIEnv.GetFieldID (class_ref, "mBaseFrameId", "Ljava/lang/String;");
					IntPtr native_value = JNIEnv.NewString (value);
					try {
						JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, mBaseFrameId_jfieldId, native_value);
					} finally {
						JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}

			static IntPtr mTimestamp_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.google.atap.tangoservice.fois']/class[@name='FoiRequest.Create']/field[@name='mTimestamp']"
			[Register ("mTimestamp")]
			public double MTimestamp {
				get {
					if (mTimestamp_jfieldId == IntPtr.Zero)
						mTimestamp_jfieldId = JNIEnv.GetFieldID (class_ref, "mTimestamp", "D");
					return JNIEnv.GetDoubleField (((global::Java.Lang.Object) this).Handle, mTimestamp_jfieldId);
				}
				set {
					if (mTimestamp_jfieldId == IntPtr.Zero)
						mTimestamp_jfieldId = JNIEnv.GetFieldID (class_ref, "mTimestamp", "D");
					try {
						JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, mTimestamp_jfieldId, value);
					} finally {
					}
				}
			}

			static IntPtr mTransformation_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.google.atap.tangoservice.fois']/class[@name='FoiRequest.Create']/field[@name='mTransformation']"
			[Register ("mTransformation")]
			public global::Com.Google.Atap.Tangoservice.Experimental.TangoTransformation MTransformation {
				get {
					if (mTransformation_jfieldId == IntPtr.Zero)
						mTransformation_jfieldId = JNIEnv.GetFieldID (class_ref, "mTransformation", "Lcom/google/atap/tangoservice/experimental/TangoTransformation;");
					IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, mTransformation_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Google.Atap.Tangoservice.Experimental.TangoTransformation> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (mTransformation_jfieldId == IntPtr.Zero)
						mTransformation_jfieldId = JNIEnv.GetFieldID (class_ref, "mTransformation", "Lcom/google/atap/tangoservice/experimental/TangoTransformation;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					try {
						JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, mTransformation_jfieldId, native_value);
					} finally {
						JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}
			internal static new IntPtr java_class_handle;
			internal static new IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/google/atap/tangoservice/fois/FoiRequest$Create", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (Create); }
			}

			protected Create (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.google.atap.tangoservice.fois']/class[@name='FoiRequest.Create']/constructor[@name='FoiRequest.Create' and count(parameter)=0]"
			[Register (".ctor", "()V", "")]
			public unsafe Create ()
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				try {
					if (GetType () != typeof (Create)) {
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

			static Delegate cb_parcelRead_Landroid_os_Parcel_;
#pragma warning disable 0169
			static Delegate GetParcelRead_Landroid_os_Parcel_Handler ()
			{
				if (cb_parcelRead_Landroid_os_Parcel_ == null)
					cb_parcelRead_Landroid_os_Parcel_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_ParcelRead_Landroid_os_Parcel_);
				return cb_parcelRead_Landroid_os_Parcel_;
			}

			static void n_ParcelRead_Landroid_os_Parcel_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Google.Atap.Tangoservice.Fois.FoiRequest.Create __this = global::Java.Lang.Object.GetObject<global::Com.Google.Atap.Tangoservice.Fois.FoiRequest.Create> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Android.OS.Parcel p0 = global::Java.Lang.Object.GetObject<global::Android.OS.Parcel> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.ParcelRead (p0);
			}
#pragma warning restore 0169

			static IntPtr id_parcelRead_Landroid_os_Parcel_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.atap.tangoservice.fois']/class[@name='FoiRequest.Create']/method[@name='parcelRead' and count(parameter)=1 and parameter[1][@type='android.os.Parcel']]"
			[Register ("parcelRead", "(Landroid/os/Parcel;)V", "GetParcelRead_Landroid_os_Parcel_Handler")]
			protected override unsafe void ParcelRead (global::Android.OS.Parcel p0)
			{
				if (id_parcelRead_Landroid_os_Parcel_ == IntPtr.Zero)
					id_parcelRead_Landroid_os_Parcel_ = JNIEnv.GetMethodID (class_ref, "parcelRead", "(Landroid/os/Parcel;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (p0);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_parcelRead_Landroid_os_Parcel_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "parcelRead", "(Landroid/os/Parcel;)V"), __args);
				} finally {
				}
			}

			static Delegate cb_parcelWrite_Landroid_os_Parcel_;
#pragma warning disable 0169
			static Delegate GetParcelWrite_Landroid_os_Parcel_Handler ()
			{
				if (cb_parcelWrite_Landroid_os_Parcel_ == null)
					cb_parcelWrite_Landroid_os_Parcel_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_ParcelWrite_Landroid_os_Parcel_);
				return cb_parcelWrite_Landroid_os_Parcel_;
			}

			static void n_ParcelWrite_Landroid_os_Parcel_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Google.Atap.Tangoservice.Fois.FoiRequest.Create __this = global::Java.Lang.Object.GetObject<global::Com.Google.Atap.Tangoservice.Fois.FoiRequest.Create> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Android.OS.Parcel p0 = global::Java.Lang.Object.GetObject<global::Android.OS.Parcel> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.ParcelWrite (p0);
			}
#pragma warning restore 0169

			static IntPtr id_parcelWrite_Landroid_os_Parcel_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.atap.tangoservice.fois']/class[@name='FoiRequest.Create']/method[@name='parcelWrite' and count(parameter)=1 and parameter[1][@type='android.os.Parcel']]"
			[Register ("parcelWrite", "(Landroid/os/Parcel;)V", "GetParcelWrite_Landroid_os_Parcel_Handler")]
			protected override unsafe void ParcelWrite (global::Android.OS.Parcel p0)
			{
				if (id_parcelWrite_Landroid_os_Parcel_ == IntPtr.Zero)
					id_parcelWrite_Landroid_os_Parcel_ = JNIEnv.GetMethodID (class_ref, "parcelWrite", "(Landroid/os/Parcel;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (p0);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_parcelWrite_Landroid_os_Parcel_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "parcelWrite", "(Landroid/os/Parcel;)V"), __args);
				} finally {
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.google.atap.tangoservice.fois']/class[@name='FoiRequest.Delete']"
		[global::Android.Runtime.Register ("com/google/atap/tangoservice/fois/FoiRequest$Delete", DoNotGenerateAcw=true)]
		public partial class Delete : global::Com.Google.Atap.Tangoservice.Fois.FoiRequest {


			static IntPtr mFrameIds_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.google.atap.tangoservice.fois']/class[@name='FoiRequest.Delete']/field[@name='mFrameIds']"
			[Register ("mFrameIds")]
			public IList<string> MFrameIds {
				get {
					if (mFrameIds_jfieldId == IntPtr.Zero)
						mFrameIds_jfieldId = JNIEnv.GetFieldID (class_ref, "mFrameIds", "[Ljava/lang/String;");
					return global::Android.Runtime.JavaArray<string>.FromJniHandle (JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, mFrameIds_jfieldId), JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (mFrameIds_jfieldId == IntPtr.Zero)
						mFrameIds_jfieldId = JNIEnv.GetFieldID (class_ref, "mFrameIds", "[Ljava/lang/String;");
					IntPtr native_value = global::Android.Runtime.JavaArray<string>.ToLocalJniHandle (value);
					try {
						JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, mFrameIds_jfieldId, native_value);
					} finally {
						JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}
			internal static new IntPtr java_class_handle;
			internal static new IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/google/atap/tangoservice/fois/FoiRequest$Delete", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (Delete); }
			}

			protected Delete (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.google.atap.tangoservice.fois']/class[@name='FoiRequest.Delete']/constructor[@name='FoiRequest.Delete' and count(parameter)=0]"
			[Register (".ctor", "()V", "")]
			public unsafe Delete ()
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				try {
					if (GetType () != typeof (Delete)) {
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

			static Delegate cb_parcelRead_Landroid_os_Parcel_;
#pragma warning disable 0169
			static Delegate GetParcelRead_Landroid_os_Parcel_Handler ()
			{
				if (cb_parcelRead_Landroid_os_Parcel_ == null)
					cb_parcelRead_Landroid_os_Parcel_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_ParcelRead_Landroid_os_Parcel_);
				return cb_parcelRead_Landroid_os_Parcel_;
			}

			static void n_ParcelRead_Landroid_os_Parcel_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Google.Atap.Tangoservice.Fois.FoiRequest.Delete __this = global::Java.Lang.Object.GetObject<global::Com.Google.Atap.Tangoservice.Fois.FoiRequest.Delete> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Android.OS.Parcel p0 = global::Java.Lang.Object.GetObject<global::Android.OS.Parcel> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.ParcelRead (p0);
			}
#pragma warning restore 0169

			static IntPtr id_parcelRead_Landroid_os_Parcel_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.atap.tangoservice.fois']/class[@name='FoiRequest.Delete']/method[@name='parcelRead' and count(parameter)=1 and parameter[1][@type='android.os.Parcel']]"
			[Register ("parcelRead", "(Landroid/os/Parcel;)V", "GetParcelRead_Landroid_os_Parcel_Handler")]
			protected override unsafe void ParcelRead (global::Android.OS.Parcel p0)
			{
				if (id_parcelRead_Landroid_os_Parcel_ == IntPtr.Zero)
					id_parcelRead_Landroid_os_Parcel_ = JNIEnv.GetMethodID (class_ref, "parcelRead", "(Landroid/os/Parcel;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (p0);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_parcelRead_Landroid_os_Parcel_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "parcelRead", "(Landroid/os/Parcel;)V"), __args);
				} finally {
				}
			}

			static Delegate cb_parcelWrite_Landroid_os_Parcel_;
#pragma warning disable 0169
			static Delegate GetParcelWrite_Landroid_os_Parcel_Handler ()
			{
				if (cb_parcelWrite_Landroid_os_Parcel_ == null)
					cb_parcelWrite_Landroid_os_Parcel_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_ParcelWrite_Landroid_os_Parcel_);
				return cb_parcelWrite_Landroid_os_Parcel_;
			}

			static void n_ParcelWrite_Landroid_os_Parcel_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Google.Atap.Tangoservice.Fois.FoiRequest.Delete __this = global::Java.Lang.Object.GetObject<global::Com.Google.Atap.Tangoservice.Fois.FoiRequest.Delete> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Android.OS.Parcel p0 = global::Java.Lang.Object.GetObject<global::Android.OS.Parcel> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.ParcelWrite (p0);
			}
#pragma warning restore 0169

			static IntPtr id_parcelWrite_Landroid_os_Parcel_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.atap.tangoservice.fois']/class[@name='FoiRequest.Delete']/method[@name='parcelWrite' and count(parameter)=1 and parameter[1][@type='android.os.Parcel']]"
			[Register ("parcelWrite", "(Landroid/os/Parcel;)V", "GetParcelWrite_Landroid_os_Parcel_Handler")]
			protected override unsafe void ParcelWrite (global::Android.OS.Parcel p0)
			{
				if (id_parcelWrite_Landroid_os_Parcel_ == IntPtr.Zero)
					id_parcelWrite_Landroid_os_Parcel_ = JNIEnv.GetMethodID (class_ref, "parcelWrite", "(Landroid/os/Parcel;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (p0);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_parcelWrite_Landroid_os_Parcel_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "parcelWrite", "(Landroid/os/Parcel;)V"), __args);
				} finally {
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.google.atap.tangoservice.fois']/class[@name='FoiRequest.Load']"
		[global::Android.Runtime.Register ("com/google/atap/tangoservice/fois/FoiRequest$Load", DoNotGenerateAcw=true)]
		public partial class Load : global::Com.Google.Atap.Tangoservice.Fois.FoiRequest {


			static IntPtr mFrameIds_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.google.atap.tangoservice.fois']/class[@name='FoiRequest.Load']/field[@name='mFrameIds']"
			[Register ("mFrameIds")]
			public IList<string> MFrameIds {
				get {
					if (mFrameIds_jfieldId == IntPtr.Zero)
						mFrameIds_jfieldId = JNIEnv.GetFieldID (class_ref, "mFrameIds", "[Ljava/lang/String;");
					return global::Android.Runtime.JavaArray<string>.FromJniHandle (JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, mFrameIds_jfieldId), JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (mFrameIds_jfieldId == IntPtr.Zero)
						mFrameIds_jfieldId = JNIEnv.GetFieldID (class_ref, "mFrameIds", "[Ljava/lang/String;");
					IntPtr native_value = global::Android.Runtime.JavaArray<string>.ToLocalJniHandle (value);
					try {
						JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, mFrameIds_jfieldId, native_value);
					} finally {
						JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}
			internal static new IntPtr java_class_handle;
			internal static new IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/google/atap/tangoservice/fois/FoiRequest$Load", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (Load); }
			}

			protected Load (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.google.atap.tangoservice.fois']/class[@name='FoiRequest.Load']/constructor[@name='FoiRequest.Load' and count(parameter)=0]"
			[Register (".ctor", "()V", "")]
			public unsafe Load ()
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				try {
					if (GetType () != typeof (Load)) {
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

			static Delegate cb_parcelRead_Landroid_os_Parcel_;
#pragma warning disable 0169
			static Delegate GetParcelRead_Landroid_os_Parcel_Handler ()
			{
				if (cb_parcelRead_Landroid_os_Parcel_ == null)
					cb_parcelRead_Landroid_os_Parcel_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_ParcelRead_Landroid_os_Parcel_);
				return cb_parcelRead_Landroid_os_Parcel_;
			}

			static void n_ParcelRead_Landroid_os_Parcel_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Google.Atap.Tangoservice.Fois.FoiRequest.Load __this = global::Java.Lang.Object.GetObject<global::Com.Google.Atap.Tangoservice.Fois.FoiRequest.Load> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Android.OS.Parcel p0 = global::Java.Lang.Object.GetObject<global::Android.OS.Parcel> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.ParcelRead (p0);
			}
#pragma warning restore 0169

			static IntPtr id_parcelRead_Landroid_os_Parcel_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.atap.tangoservice.fois']/class[@name='FoiRequest.Load']/method[@name='parcelRead' and count(parameter)=1 and parameter[1][@type='android.os.Parcel']]"
			[Register ("parcelRead", "(Landroid/os/Parcel;)V", "GetParcelRead_Landroid_os_Parcel_Handler")]
			protected override unsafe void ParcelRead (global::Android.OS.Parcel p0)
			{
				if (id_parcelRead_Landroid_os_Parcel_ == IntPtr.Zero)
					id_parcelRead_Landroid_os_Parcel_ = JNIEnv.GetMethodID (class_ref, "parcelRead", "(Landroid/os/Parcel;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (p0);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_parcelRead_Landroid_os_Parcel_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "parcelRead", "(Landroid/os/Parcel;)V"), __args);
				} finally {
				}
			}

			static Delegate cb_parcelWrite_Landroid_os_Parcel_;
#pragma warning disable 0169
			static Delegate GetParcelWrite_Landroid_os_Parcel_Handler ()
			{
				if (cb_parcelWrite_Landroid_os_Parcel_ == null)
					cb_parcelWrite_Landroid_os_Parcel_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_ParcelWrite_Landroid_os_Parcel_);
				return cb_parcelWrite_Landroid_os_Parcel_;
			}

			static void n_ParcelWrite_Landroid_os_Parcel_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Google.Atap.Tangoservice.Fois.FoiRequest.Load __this = global::Java.Lang.Object.GetObject<global::Com.Google.Atap.Tangoservice.Fois.FoiRequest.Load> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Android.OS.Parcel p0 = global::Java.Lang.Object.GetObject<global::Android.OS.Parcel> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.ParcelWrite (p0);
			}
#pragma warning restore 0169

			static IntPtr id_parcelWrite_Landroid_os_Parcel_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.atap.tangoservice.fois']/class[@name='FoiRequest.Load']/method[@name='parcelWrite' and count(parameter)=1 and parameter[1][@type='android.os.Parcel']]"
			[Register ("parcelWrite", "(Landroid/os/Parcel;)V", "GetParcelWrite_Landroid_os_Parcel_Handler")]
			protected override unsafe void ParcelWrite (global::Android.OS.Parcel p0)
			{
				if (id_parcelWrite_Landroid_os_Parcel_ == IntPtr.Zero)
					id_parcelWrite_Landroid_os_Parcel_ = JNIEnv.GetMethodID (class_ref, "parcelWrite", "(Landroid/os/Parcel;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (p0);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_parcelWrite_Landroid_os_Parcel_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "parcelWrite", "(Landroid/os/Parcel;)V"), __args);
				} finally {
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.google.atap.tangoservice.fois']/class[@name='FoiRequest.Type']"
		[global::Android.Runtime.Register ("com/google/atap/tangoservice/fois/FoiRequest$Type", DoNotGenerateAcw=true)]
		public sealed partial class Type : global::Java.Lang.Enum {


			static IntPtr CREATE_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.google.atap.tangoservice.fois']/class[@name='FoiRequest.Type']/field[@name='CREATE']"
			[Register ("CREATE")]
			public static global::Com.Google.Atap.Tangoservice.Fois.FoiRequest.Type Create {
				get {
					if (CREATE_jfieldId == IntPtr.Zero)
						CREATE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "CREATE", "Lcom/google/atap/tangoservice/fois/FoiRequest$Type;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, CREATE_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Google.Atap.Tangoservice.Fois.FoiRequest.Type> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr DELETE_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.google.atap.tangoservice.fois']/class[@name='FoiRequest.Type']/field[@name='DELETE']"
			[Register ("DELETE")]
			public static global::Com.Google.Atap.Tangoservice.Fois.FoiRequest.Type Delete {
				get {
					if (DELETE_jfieldId == IntPtr.Zero)
						DELETE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "DELETE", "Lcom/google/atap/tangoservice/fois/FoiRequest$Type;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, DELETE_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Google.Atap.Tangoservice.Fois.FoiRequest.Type> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr INVALID_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.google.atap.tangoservice.fois']/class[@name='FoiRequest.Type']/field[@name='INVALID']"
			[Register ("INVALID")]
			public static global::Com.Google.Atap.Tangoservice.Fois.FoiRequest.Type Invalid {
				get {
					if (INVALID_jfieldId == IntPtr.Zero)
						INVALID_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "INVALID", "Lcom/google/atap/tangoservice/fois/FoiRequest$Type;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, INVALID_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Google.Atap.Tangoservice.Fois.FoiRequest.Type> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr LOAD_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.google.atap.tangoservice.fois']/class[@name='FoiRequest.Type']/field[@name='LOAD']"
			[Register ("LOAD")]
			public static global::Com.Google.Atap.Tangoservice.Fois.FoiRequest.Type Load {
				get {
					if (LOAD_jfieldId == IntPtr.Zero)
						LOAD_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "LOAD", "Lcom/google/atap/tangoservice/fois/FoiRequest$Type;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, LOAD_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Google.Atap.Tangoservice.Fois.FoiRequest.Type> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}
			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/google/atap/tangoservice/fois/FoiRequest$Type", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (Type); }
			}

			internal Type (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_fromInt_I;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.atap.tangoservice.fois']/class[@name='FoiRequest.Type']/method[@name='fromInt' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("fromInt", "(I)Lcom/google/atap/tangoservice/fois/FoiRequest$Type;", "")]
			public static unsafe global::Com.Google.Atap.Tangoservice.Fois.FoiRequest.Type FromInt (int p0)
			{
				if (id_fromInt_I == IntPtr.Zero)
					id_fromInt_I = JNIEnv.GetStaticMethodID (class_ref, "fromInt", "(I)Lcom/google/atap/tangoservice/fois/FoiRequest$Type;");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (p0);
					return global::Java.Lang.Object.GetObject<global::Com.Google.Atap.Tangoservice.Fois.FoiRequest.Type> (JNIEnv.CallStaticObjectMethod  (class_ref, id_fromInt_I, __args), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			static IntPtr id_valueOf_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.atap.tangoservice.fois']/class[@name='FoiRequest.Type']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lcom/google/atap/tangoservice/fois/FoiRequest$Type;", "")]
			public static unsafe global::Com.Google.Atap.Tangoservice.Fois.FoiRequest.Type ValueOf (string p0)
			{
				if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
					id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lcom/google/atap/tangoservice/fois/FoiRequest$Type;");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_p0);
					global::Com.Google.Atap.Tangoservice.Fois.FoiRequest.Type __ret = global::Java.Lang.Object.GetObject<global::Com.Google.Atap.Tangoservice.Fois.FoiRequest.Type> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

			static IntPtr id_values;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.atap.tangoservice.fois']/class[@name='FoiRequest.Type']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lcom/google/atap/tangoservice/fois/FoiRequest$Type;", "")]
			public static unsafe global::Com.Google.Atap.Tangoservice.Fois.FoiRequest.Type[] Values ()
			{
				if (id_values == IntPtr.Zero)
					id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lcom/google/atap/tangoservice/fois/FoiRequest$Type;");
				try {
					return (global::Com.Google.Atap.Tangoservice.Fois.FoiRequest.Type[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Com.Google.Atap.Tangoservice.Fois.FoiRequest.Type));
				} finally {
				}
			}

		}

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/google/atap/tangoservice/fois/FoiRequest", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (FoiRequest); }
		}

		protected FoiRequest (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

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
			global::Com.Google.Atap.Tangoservice.Fois.FoiRequest __this = global::Java.Lang.Object.GetObject<global::Com.Google.Atap.Tangoservice.Fois.FoiRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.DescribeContents ();
		}
#pragma warning restore 0169

		static IntPtr id_describeContents;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.atap.tangoservice.fois']/class[@name='FoiRequest']/method[@name='describeContents' and count(parameter)=0]"
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

		static Delegate cb_parcelRead_Landroid_os_Parcel_;
#pragma warning disable 0169
		static Delegate GetParcelRead_Landroid_os_Parcel_Handler ()
		{
			if (cb_parcelRead_Landroid_os_Parcel_ == null)
				cb_parcelRead_Landroid_os_Parcel_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_ParcelRead_Landroid_os_Parcel_);
			return cb_parcelRead_Landroid_os_Parcel_;
		}

		static void n_ParcelRead_Landroid_os_Parcel_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Google.Atap.Tangoservice.Fois.FoiRequest __this = global::Java.Lang.Object.GetObject<global::Com.Google.Atap.Tangoservice.Fois.FoiRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.Parcel p0 = global::Java.Lang.Object.GetObject<global::Android.OS.Parcel> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.ParcelRead (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.atap.tangoservice.fois']/class[@name='FoiRequest']/method[@name='parcelRead' and count(parameter)=1 and parameter[1][@type='android.os.Parcel']]"
		[Register ("parcelRead", "(Landroid/os/Parcel;)V", "GetParcelRead_Landroid_os_Parcel_Handler")]
		protected abstract void ParcelRead (global::Android.OS.Parcel p0);

		static Delegate cb_parcelWrite_Landroid_os_Parcel_;
#pragma warning disable 0169
		static Delegate GetParcelWrite_Landroid_os_Parcel_Handler ()
		{
			if (cb_parcelWrite_Landroid_os_Parcel_ == null)
				cb_parcelWrite_Landroid_os_Parcel_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_ParcelWrite_Landroid_os_Parcel_);
			return cb_parcelWrite_Landroid_os_Parcel_;
		}

		static void n_ParcelWrite_Landroid_os_Parcel_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Google.Atap.Tangoservice.Fois.FoiRequest __this = global::Java.Lang.Object.GetObject<global::Com.Google.Atap.Tangoservice.Fois.FoiRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.Parcel p0 = global::Java.Lang.Object.GetObject<global::Android.OS.Parcel> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.ParcelWrite (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.atap.tangoservice.fois']/class[@name='FoiRequest']/method[@name='parcelWrite' and count(parameter)=1 and parameter[1][@type='android.os.Parcel']]"
		[Register ("parcelWrite", "(Landroid/os/Parcel;)V", "GetParcelWrite_Landroid_os_Parcel_Handler")]
		protected abstract void ParcelWrite (global::Android.OS.Parcel p0);

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
			global::Com.Google.Atap.Tangoservice.Fois.FoiRequest __this = global::Java.Lang.Object.GetObject<global::Com.Google.Atap.Tangoservice.Fois.FoiRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.Parcel p0 = global::Java.Lang.Object.GetObject<global::Android.OS.Parcel> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.ParcelableWriteFlags p1 = (global::Android.OS.ParcelableWriteFlags) native_p1;
			__this.WriteToParcel (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_writeToParcel_Landroid_os_Parcel_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.atap.tangoservice.fois']/class[@name='FoiRequest']/method[@name='writeToParcel' and count(parameter)=2 and parameter[1][@type='android.os.Parcel'] and parameter[2][@type='int']]"
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

	[global::Android.Runtime.Register ("com/google/atap/tangoservice/fois/FoiRequest", DoNotGenerateAcw=true)]
	internal partial class FoiRequestInvoker : FoiRequest {

		public FoiRequestInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		protected override global::System.Type ThresholdType {
			get { return typeof (FoiRequestInvoker); }
		}

		static IntPtr id_parcelRead_Landroid_os_Parcel_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.atap.tangoservice.fois']/class[@name='FoiRequest']/method[@name='parcelRead' and count(parameter)=1 and parameter[1][@type='android.os.Parcel']]"
		[Register ("parcelRead", "(Landroid/os/Parcel;)V", "GetParcelRead_Landroid_os_Parcel_Handler")]
		protected override unsafe void ParcelRead (global::Android.OS.Parcel p0)
		{
			if (id_parcelRead_Landroid_os_Parcel_ == IntPtr.Zero)
				id_parcelRead_Landroid_os_Parcel_ = JNIEnv.GetMethodID (class_ref, "parcelRead", "(Landroid/os/Parcel;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_parcelRead_Landroid_os_Parcel_, __args);
			} finally {
			}
		}

		static IntPtr id_parcelWrite_Landroid_os_Parcel_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.atap.tangoservice.fois']/class[@name='FoiRequest']/method[@name='parcelWrite' and count(parameter)=1 and parameter[1][@type='android.os.Parcel']]"
		[Register ("parcelWrite", "(Landroid/os/Parcel;)V", "GetParcelWrite_Landroid_os_Parcel_Handler")]
		protected override unsafe void ParcelWrite (global::Android.OS.Parcel p0)
		{
			if (id_parcelWrite_Landroid_os_Parcel_ == IntPtr.Zero)
				id_parcelWrite_Landroid_os_Parcel_ = JNIEnv.GetMethodID (class_ref, "parcelWrite", "(Landroid/os/Parcel;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_parcelWrite_Landroid_os_Parcel_, __args);
			} finally {
			}
		}

	}

}
