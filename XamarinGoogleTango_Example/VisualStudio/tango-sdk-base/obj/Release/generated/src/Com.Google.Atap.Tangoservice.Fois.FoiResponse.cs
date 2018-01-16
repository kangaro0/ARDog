using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Google.Atap.Tangoservice.Fois {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.google.atap.tangoservice.fois']/class[@name='FoiResponse']"
	[global::Android.Runtime.Register ("com/google/atap/tangoservice/fois/FoiResponse", DoNotGenerateAcw=true)]
	public abstract partial class FoiResponse : global::Java.Lang.Object, global::Android.OS.IParcelable {


		static IntPtr CREATOR_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.atap.tangoservice.fois']/class[@name='FoiResponse']/field[@name='CREATOR']"
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

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.atap.tangoservice.fois']/class[@name='FoiResponse']/field[@name='mId']"
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

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.atap.tangoservice.fois']/class[@name='FoiResponse']/field[@name='mType']"
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
		// Metadata.xml XPath class reference: path="/api/package[@name='com.google.atap.tangoservice.fois']/class[@name='FoiResponse.Create']"
		[global::Android.Runtime.Register ("com/google/atap/tangoservice/fois/FoiResponse$Create", DoNotGenerateAcw=true)]
		public partial class Create : global::Com.Google.Atap.Tangoservice.Fois.FoiResponse {


			static IntPtr mFrameId_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.google.atap.tangoservice.fois']/class[@name='FoiResponse.Create']/field[@name='mFrameId']"
			[Register ("mFrameId")]
			public string MFrameId {
				get {
					if (mFrameId_jfieldId == IntPtr.Zero)
						mFrameId_jfieldId = JNIEnv.GetFieldID (class_ref, "mFrameId", "Ljava/lang/String;");
					IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, mFrameId_jfieldId);
					return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (mFrameId_jfieldId == IntPtr.Zero)
						mFrameId_jfieldId = JNIEnv.GetFieldID (class_ref, "mFrameId", "Ljava/lang/String;");
					IntPtr native_value = JNIEnv.NewString (value);
					try {
						JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, mFrameId_jfieldId, native_value);
					} finally {
						JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}

			static IntPtr mStatus_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.google.atap.tangoservice.fois']/class[@name='FoiResponse.Create']/field[@name='mStatus']"
			[Register ("mStatus")]
			public int MStatus {
				get {
					if (mStatus_jfieldId == IntPtr.Zero)
						mStatus_jfieldId = JNIEnv.GetFieldID (class_ref, "mStatus", "I");
					return JNIEnv.GetIntField (((global::Java.Lang.Object) this).Handle, mStatus_jfieldId);
				}
				set {
					if (mStatus_jfieldId == IntPtr.Zero)
						mStatus_jfieldId = JNIEnv.GetFieldID (class_ref, "mStatus", "I");
					try {
						JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, mStatus_jfieldId, value);
					} finally {
					}
				}
			}
			internal static new IntPtr java_class_handle;
			internal static new IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/google/atap/tangoservice/fois/FoiResponse$Create", ref java_class_handle);
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
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.google.atap.tangoservice.fois']/class[@name='FoiResponse.Create']/constructor[@name='FoiResponse.Create' and count(parameter)=0]"
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
				global::Com.Google.Atap.Tangoservice.Fois.FoiResponse.Create __this = global::Java.Lang.Object.GetObject<global::Com.Google.Atap.Tangoservice.Fois.FoiResponse.Create> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Android.OS.Parcel p0 = global::Java.Lang.Object.GetObject<global::Android.OS.Parcel> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.ParcelRead (p0);
			}
#pragma warning restore 0169

			static IntPtr id_parcelRead_Landroid_os_Parcel_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.atap.tangoservice.fois']/class[@name='FoiResponse.Create']/method[@name='parcelRead' and count(parameter)=1 and parameter[1][@type='android.os.Parcel']]"
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
				global::Com.Google.Atap.Tangoservice.Fois.FoiResponse.Create __this = global::Java.Lang.Object.GetObject<global::Com.Google.Atap.Tangoservice.Fois.FoiResponse.Create> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Android.OS.Parcel p0 = global::Java.Lang.Object.GetObject<global::Android.OS.Parcel> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.ParcelWrite (p0);
			}
#pragma warning restore 0169

			static IntPtr id_parcelWrite_Landroid_os_Parcel_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.atap.tangoservice.fois']/class[@name='FoiResponse.Create']/method[@name='parcelWrite' and count(parameter)=1 and parameter[1][@type='android.os.Parcel']]"
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

		// Metadata.xml XPath class reference: path="/api/package[@name='com.google.atap.tangoservice.fois']/class[@name='FoiResponse.Delete']"
		[global::Android.Runtime.Register ("com/google/atap/tangoservice/fois/FoiResponse$Delete", DoNotGenerateAcw=true)]
		public partial class Delete : global::Com.Google.Atap.Tangoservice.Fois.FoiResponse {


			static IntPtr mFrameIds_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.google.atap.tangoservice.fois']/class[@name='FoiResponse.Delete']/field[@name='mFrameIds']"
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

			static IntPtr mStatuses_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.google.atap.tangoservice.fois']/class[@name='FoiResponse.Delete']/field[@name='mStatuses']"
			[Register ("mStatuses")]
			public IList<int> MStatuses {
				get {
					if (mStatuses_jfieldId == IntPtr.Zero)
						mStatuses_jfieldId = JNIEnv.GetFieldID (class_ref, "mStatuses", "[I");
					return global::Android.Runtime.JavaArray<int>.FromJniHandle (JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, mStatuses_jfieldId), JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (mStatuses_jfieldId == IntPtr.Zero)
						mStatuses_jfieldId = JNIEnv.GetFieldID (class_ref, "mStatuses", "[I");
					IntPtr native_value = global::Android.Runtime.JavaArray<int>.ToLocalJniHandle (value);
					try {
						JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, mStatuses_jfieldId, native_value);
					} finally {
						JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}
			internal static new IntPtr java_class_handle;
			internal static new IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/google/atap/tangoservice/fois/FoiResponse$Delete", ref java_class_handle);
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
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.google.atap.tangoservice.fois']/class[@name='FoiResponse.Delete']/constructor[@name='FoiResponse.Delete' and count(parameter)=0]"
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
				global::Com.Google.Atap.Tangoservice.Fois.FoiResponse.Delete __this = global::Java.Lang.Object.GetObject<global::Com.Google.Atap.Tangoservice.Fois.FoiResponse.Delete> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Android.OS.Parcel p0 = global::Java.Lang.Object.GetObject<global::Android.OS.Parcel> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.ParcelRead (p0);
			}
#pragma warning restore 0169

			static IntPtr id_parcelRead_Landroid_os_Parcel_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.atap.tangoservice.fois']/class[@name='FoiResponse.Delete']/method[@name='parcelRead' and count(parameter)=1 and parameter[1][@type='android.os.Parcel']]"
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
				global::Com.Google.Atap.Tangoservice.Fois.FoiResponse.Delete __this = global::Java.Lang.Object.GetObject<global::Com.Google.Atap.Tangoservice.Fois.FoiResponse.Delete> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Android.OS.Parcel p0 = global::Java.Lang.Object.GetObject<global::Android.OS.Parcel> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.ParcelWrite (p0);
			}
#pragma warning restore 0169

			static IntPtr id_parcelWrite_Landroid_os_Parcel_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.atap.tangoservice.fois']/class[@name='FoiResponse.Delete']/method[@name='parcelWrite' and count(parameter)=1 and parameter[1][@type='android.os.Parcel']]"
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

		// Metadata.xml XPath class reference: path="/api/package[@name='com.google.atap.tangoservice.fois']/class[@name='FoiResponse.Load']"
		[global::Android.Runtime.Register ("com/google/atap/tangoservice/fois/FoiResponse$Load", DoNotGenerateAcw=true)]
		public partial class Load : global::Com.Google.Atap.Tangoservice.Fois.FoiResponse {


			static IntPtr mFrameIds_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.google.atap.tangoservice.fois']/class[@name='FoiResponse.Load']/field[@name='mFrameIds']"
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

			static IntPtr mStatuses_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.google.atap.tangoservice.fois']/class[@name='FoiResponse.Load']/field[@name='mStatuses']"
			[Register ("mStatuses")]
			public IList<int> MStatuses {
				get {
					if (mStatuses_jfieldId == IntPtr.Zero)
						mStatuses_jfieldId = JNIEnv.GetFieldID (class_ref, "mStatuses", "[I");
					return global::Android.Runtime.JavaArray<int>.FromJniHandle (JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, mStatuses_jfieldId), JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (mStatuses_jfieldId == IntPtr.Zero)
						mStatuses_jfieldId = JNIEnv.GetFieldID (class_ref, "mStatuses", "[I");
					IntPtr native_value = global::Android.Runtime.JavaArray<int>.ToLocalJniHandle (value);
					try {
						JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, mStatuses_jfieldId, native_value);
					} finally {
						JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}
			internal static new IntPtr java_class_handle;
			internal static new IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/google/atap/tangoservice/fois/FoiResponse$Load", ref java_class_handle);
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
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.google.atap.tangoservice.fois']/class[@name='FoiResponse.Load']/constructor[@name='FoiResponse.Load' and count(parameter)=0]"
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
				global::Com.Google.Atap.Tangoservice.Fois.FoiResponse.Load __this = global::Java.Lang.Object.GetObject<global::Com.Google.Atap.Tangoservice.Fois.FoiResponse.Load> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Android.OS.Parcel p0 = global::Java.Lang.Object.GetObject<global::Android.OS.Parcel> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.ParcelRead (p0);
			}
#pragma warning restore 0169

			static IntPtr id_parcelRead_Landroid_os_Parcel_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.atap.tangoservice.fois']/class[@name='FoiResponse.Load']/method[@name='parcelRead' and count(parameter)=1 and parameter[1][@type='android.os.Parcel']]"
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
				global::Com.Google.Atap.Tangoservice.Fois.FoiResponse.Load __this = global::Java.Lang.Object.GetObject<global::Com.Google.Atap.Tangoservice.Fois.FoiResponse.Load> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Android.OS.Parcel p0 = global::Java.Lang.Object.GetObject<global::Android.OS.Parcel> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.ParcelWrite (p0);
			}
#pragma warning restore 0169

			static IntPtr id_parcelWrite_Landroid_os_Parcel_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.atap.tangoservice.fois']/class[@name='FoiResponse.Load']/method[@name='parcelWrite' and count(parameter)=1 and parameter[1][@type='android.os.Parcel']]"
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

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/google/atap/tangoservice/fois/FoiResponse", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (FoiResponse); }
		}

		protected FoiResponse (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

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
			global::Com.Google.Atap.Tangoservice.Fois.FoiResponse __this = global::Java.Lang.Object.GetObject<global::Com.Google.Atap.Tangoservice.Fois.FoiResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.DescribeContents ();
		}
#pragma warning restore 0169

		static IntPtr id_describeContents;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.atap.tangoservice.fois']/class[@name='FoiResponse']/method[@name='describeContents' and count(parameter)=0]"
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
			global::Com.Google.Atap.Tangoservice.Fois.FoiResponse __this = global::Java.Lang.Object.GetObject<global::Com.Google.Atap.Tangoservice.Fois.FoiResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.Parcel p0 = global::Java.Lang.Object.GetObject<global::Android.OS.Parcel> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.ParcelRead (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.atap.tangoservice.fois']/class[@name='FoiResponse']/method[@name='parcelRead' and count(parameter)=1 and parameter[1][@type='android.os.Parcel']]"
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
			global::Com.Google.Atap.Tangoservice.Fois.FoiResponse __this = global::Java.Lang.Object.GetObject<global::Com.Google.Atap.Tangoservice.Fois.FoiResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.Parcel p0 = global::Java.Lang.Object.GetObject<global::Android.OS.Parcel> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.ParcelWrite (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.atap.tangoservice.fois']/class[@name='FoiResponse']/method[@name='parcelWrite' and count(parameter)=1 and parameter[1][@type='android.os.Parcel']]"
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
			global::Com.Google.Atap.Tangoservice.Fois.FoiResponse __this = global::Java.Lang.Object.GetObject<global::Com.Google.Atap.Tangoservice.Fois.FoiResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.Parcel p0 = global::Java.Lang.Object.GetObject<global::Android.OS.Parcel> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.ParcelableWriteFlags p1 = (global::Android.OS.ParcelableWriteFlags) native_p1;
			__this.WriteToParcel (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_writeToParcel_Landroid_os_Parcel_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.atap.tangoservice.fois']/class[@name='FoiResponse']/method[@name='writeToParcel' and count(parameter)=2 and parameter[1][@type='android.os.Parcel'] and parameter[2][@type='int']]"
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

	[global::Android.Runtime.Register ("com/google/atap/tangoservice/fois/FoiResponse", DoNotGenerateAcw=true)]
	internal partial class FoiResponseInvoker : FoiResponse {

		public FoiResponseInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		protected override global::System.Type ThresholdType {
			get { return typeof (FoiResponseInvoker); }
		}

		static IntPtr id_parcelRead_Landroid_os_Parcel_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.atap.tangoservice.fois']/class[@name='FoiResponse']/method[@name='parcelRead' and count(parameter)=1 and parameter[1][@type='android.os.Parcel']]"
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
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.atap.tangoservice.fois']/class[@name='FoiResponse']/method[@name='parcelWrite' and count(parameter)=1 and parameter[1][@type='android.os.Parcel']]"
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
