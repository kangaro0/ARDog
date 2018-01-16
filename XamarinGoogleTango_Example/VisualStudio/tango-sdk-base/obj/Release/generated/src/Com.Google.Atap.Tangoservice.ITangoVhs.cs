using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Google.Atap.Tangoservice {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.google.atap.tangoservice']/class[@name='ITangoVhs.Stub']"
	[global::Android.Runtime.Register ("com/google/atap/tangoservice/ITangoVhs$Stub", DoNotGenerateAcw=true)]
	public abstract partial class TangoVhsStub : global::Android.OS.Binder, global::Com.Google.Atap.Tangoservice.ITangoVhs {

		// Metadata.xml XPath class reference: path="/api/package[@name='com.google.atap.tangoservice']/class[@name='ITangoVhs.Stub.Proxy']"
		[global::Android.Runtime.Register ("com/google/atap/tangoservice/ITangoVhs$Stub$Proxy", DoNotGenerateAcw=true)]
		public partial class Proxy : global::Java.Lang.Object, global::Com.Google.Atap.Tangoservice.ITangoVhs {

			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/google/atap/tangoservice/ITangoVhs$Stub$Proxy", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (Proxy); }
			}

			protected Proxy (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static Delegate cb_getInterfaceDescriptor;
#pragma warning disable 0169
			static Delegate GetGetInterfaceDescriptorHandler ()
			{
				if (cb_getInterfaceDescriptor == null)
					cb_getInterfaceDescriptor = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetInterfaceDescriptor);
				return cb_getInterfaceDescriptor;
			}

			static IntPtr n_GetInterfaceDescriptor (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Google.Atap.Tangoservice.TangoVhsStub.Proxy __this = global::Java.Lang.Object.GetObject<global::Com.Google.Atap.Tangoservice.TangoVhsStub.Proxy> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.NewString (__this.InterfaceDescriptor);
			}
#pragma warning restore 0169

			static IntPtr id_getInterfaceDescriptor;
			public virtual unsafe string InterfaceDescriptor {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.google.atap.tangoservice']/class[@name='ITangoVhs.Stub.Proxy']/method[@name='getInterfaceDescriptor' and count(parameter)=0]"
				[Register ("getInterfaceDescriptor", "()Ljava/lang/String;", "GetGetInterfaceDescriptorHandler")]
				get {
					if (id_getInterfaceDescriptor == IntPtr.Zero)
						id_getInterfaceDescriptor = JNIEnv.GetMethodID (class_ref, "getInterfaceDescriptor", "()Ljava/lang/String;");
					try {

						if (GetType () == ThresholdType)
							return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getInterfaceDescriptor), JniHandleOwnership.TransferLocalRef);
						else
							return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getInterfaceDescriptor", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
			}

			static Delegate cb_asBinder;
#pragma warning disable 0169
			static Delegate GetAsBinderHandler ()
			{
				if (cb_asBinder == null)
					cb_asBinder = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_AsBinder);
				return cb_asBinder;
			}

			static IntPtr n_AsBinder (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Google.Atap.Tangoservice.TangoVhsStub.Proxy __this = global::Java.Lang.Object.GetObject<global::Com.Google.Atap.Tangoservice.TangoVhsStub.Proxy> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.AsBinder ());
			}
#pragma warning restore 0169

			static IntPtr id_asBinder;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.atap.tangoservice']/class[@name='ITangoVhs.Stub.Proxy']/method[@name='asBinder' and count(parameter)=0]"
			[Register ("asBinder", "()Landroid/os/IBinder;", "GetAsBinderHandler")]
			public virtual unsafe global::Android.OS.IBinder AsBinder ()
			{
				if (id_asBinder == IntPtr.Zero)
					id_asBinder = JNIEnv.GetMethodID (class_ref, "asBinder", "()Landroid/os/IBinder;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Android.OS.IBinder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_asBinder), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Android.OS.IBinder> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "asBinder", "()Landroid/os/IBinder;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			static Delegate cb_connectFeatureServer_Landroid_os_ParcelFileDescriptor_;
#pragma warning disable 0169
			static Delegate GetConnectFeatureServer_Landroid_os_ParcelFileDescriptor_Handler ()
			{
				if (cb_connectFeatureServer_Landroid_os_ParcelFileDescriptor_ == null)
					cb_connectFeatureServer_Landroid_os_ParcelFileDescriptor_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, int>) n_ConnectFeatureServer_Landroid_os_ParcelFileDescriptor_);
				return cb_connectFeatureServer_Landroid_os_ParcelFileDescriptor_;
			}

			static int n_ConnectFeatureServer_Landroid_os_ParcelFileDescriptor_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Google.Atap.Tangoservice.TangoVhsStub.Proxy __this = global::Java.Lang.Object.GetObject<global::Com.Google.Atap.Tangoservice.TangoVhsStub.Proxy> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Android.OS.ParcelFileDescriptor p0 = global::Java.Lang.Object.GetObject<global::Android.OS.ParcelFileDescriptor> (native_p0, JniHandleOwnership.DoNotTransfer);
				int __ret = __this.ConnectFeatureServer (p0);
				return __ret;
			}
#pragma warning restore 0169

			static IntPtr id_connectFeatureServer_Landroid_os_ParcelFileDescriptor_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.atap.tangoservice']/class[@name='ITangoVhs.Stub.Proxy']/method[@name='connectFeatureServer' and count(parameter)=1 and parameter[1][@type='android.os.ParcelFileDescriptor']]"
			[Register ("connectFeatureServer", "(Landroid/os/ParcelFileDescriptor;)I", "GetConnectFeatureServer_Landroid_os_ParcelFileDescriptor_Handler")]
			public virtual unsafe int ConnectFeatureServer (global::Android.OS.ParcelFileDescriptor p0)
			{
				if (id_connectFeatureServer_Landroid_os_ParcelFileDescriptor_ == IntPtr.Zero)
					id_connectFeatureServer_Landroid_os_ParcelFileDescriptor_ = JNIEnv.GetMethodID (class_ref, "connectFeatureServer", "(Landroid/os/ParcelFileDescriptor;)I");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (p0);

					int __ret;
					if (GetType () == ThresholdType)
						__ret = JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_connectFeatureServer_Landroid_os_ParcelFileDescriptor_, __args);
					else
						__ret = JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "connectFeatureServer", "(Landroid/os/ParcelFileDescriptor;)I"), __args);
					return __ret;
				} finally {
				}
			}

			static Delegate cb_disconnectFeatureServer;
#pragma warning disable 0169
			static Delegate GetDisconnectFeatureServerHandler ()
			{
				if (cb_disconnectFeatureServer == null)
					cb_disconnectFeatureServer = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_DisconnectFeatureServer);
				return cb_disconnectFeatureServer;
			}

			static int n_DisconnectFeatureServer (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Google.Atap.Tangoservice.TangoVhsStub.Proxy __this = global::Java.Lang.Object.GetObject<global::Com.Google.Atap.Tangoservice.TangoVhsStub.Proxy> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return __this.DisconnectFeatureServer ();
			}
#pragma warning restore 0169

			static IntPtr id_disconnectFeatureServer;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.atap.tangoservice']/class[@name='ITangoVhs.Stub.Proxy']/method[@name='disconnectFeatureServer' and count(parameter)=0]"
			[Register ("disconnectFeatureServer", "()I", "GetDisconnectFeatureServerHandler")]
			public virtual unsafe int DisconnectFeatureServer ()
			{
				if (id_disconnectFeatureServer == IntPtr.Zero)
					id_disconnectFeatureServer = JNIEnv.GetMethodID (class_ref, "disconnectFeatureServer", "()I");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_disconnectFeatureServer);
					else
						return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "disconnectFeatureServer", "()I"));
				} finally {
				}
			}

			static Delegate cb_updateFeatureServer;
#pragma warning disable 0169
			static Delegate GetUpdateFeatureServerHandler ()
			{
				if (cb_updateFeatureServer == null)
					cb_updateFeatureServer = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_UpdateFeatureServer);
				return cb_updateFeatureServer;
			}

			static int n_UpdateFeatureServer (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Google.Atap.Tangoservice.TangoVhsStub.Proxy __this = global::Java.Lang.Object.GetObject<global::Com.Google.Atap.Tangoservice.TangoVhsStub.Proxy> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return __this.UpdateFeatureServer ();
			}
#pragma warning restore 0169

			static IntPtr id_updateFeatureServer;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.atap.tangoservice']/class[@name='ITangoVhs.Stub.Proxy']/method[@name='updateFeatureServer' and count(parameter)=0]"
			[Register ("updateFeatureServer", "()I", "GetUpdateFeatureServerHandler")]
			public virtual unsafe int UpdateFeatureServer ()
			{
				if (id_updateFeatureServer == IntPtr.Zero)
					id_updateFeatureServer = JNIEnv.GetMethodID (class_ref, "updateFeatureServer", "()I");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_updateFeatureServer);
					else
						return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "updateFeatureServer", "()I"));
				} finally {
				}
			}

		}

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/google/atap/tangoservice/ITangoVhs$Stub", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (TangoVhsStub); }
		}

		protected TangoVhsStub (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.google.atap.tangoservice']/class[@name='ITangoVhs.Stub']/constructor[@name='ITangoVhs.Stub' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe TangoVhsStub ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (TangoVhsStub)) {
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

		static Delegate cb_asBinder;
#pragma warning disable 0169
		static Delegate GetAsBinderHandler ()
		{
			if (cb_asBinder == null)
				cb_asBinder = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_AsBinder);
			return cb_asBinder;
		}

		static IntPtr n_AsBinder (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Google.Atap.Tangoservice.TangoVhsStub __this = global::Java.Lang.Object.GetObject<global::Com.Google.Atap.Tangoservice.TangoVhsStub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.AsBinder ());
		}
#pragma warning restore 0169

		static IntPtr id_asBinder;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.atap.tangoservice']/class[@name='ITangoVhs.Stub']/method[@name='asBinder' and count(parameter)=0]"
		[Register ("asBinder", "()Landroid/os/IBinder;", "GetAsBinderHandler")]
		public virtual unsafe global::Android.OS.IBinder AsBinder ()
		{
			if (id_asBinder == IntPtr.Zero)
				id_asBinder = JNIEnv.GetMethodID (class_ref, "asBinder", "()Landroid/os/IBinder;");
			try {

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Android.OS.IBinder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_asBinder), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Android.OS.IBinder> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "asBinder", "()Landroid/os/IBinder;")), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_asInterface_Landroid_os_IBinder_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.atap.tangoservice']/class[@name='ITangoVhs.Stub']/method[@name='asInterface' and count(parameter)=1 and parameter[1][@type='android.os.IBinder']]"
		[Register ("asInterface", "(Landroid/os/IBinder;)Lcom/google/atap/tangoservice/ITangoVhs;", "")]
		public static unsafe global::Com.Google.Atap.Tangoservice.ITangoVhs AsInterface (global::Android.OS.IBinder p0)
		{
			if (id_asInterface_Landroid_os_IBinder_ == IntPtr.Zero)
				id_asInterface_Landroid_os_IBinder_ = JNIEnv.GetStaticMethodID (class_ref, "asInterface", "(Landroid/os/IBinder;)Lcom/google/atap/tangoservice/ITangoVhs;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				global::Com.Google.Atap.Tangoservice.ITangoVhs __ret = global::Java.Lang.Object.GetObject<global::Com.Google.Atap.Tangoservice.ITangoVhs> (JNIEnv.CallStaticObjectMethod  (class_ref, id_asInterface_Landroid_os_IBinder_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_onTransact_ILandroid_os_Parcel_Landroid_os_Parcel_I;
#pragma warning disable 0169
		static Delegate GetOnTransact_ILandroid_os_Parcel_Landroid_os_Parcel_IHandler ()
		{
			if (cb_onTransact_ILandroid_os_Parcel_Landroid_os_Parcel_I == null)
				cb_onTransact_ILandroid_os_Parcel_Landroid_os_Parcel_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr, IntPtr, int, bool>) n_OnTransact_ILandroid_os_Parcel_Landroid_os_Parcel_I);
			return cb_onTransact_ILandroid_os_Parcel_Landroid_os_Parcel_I;
		}

		static bool n_OnTransact_ILandroid_os_Parcel_Landroid_os_Parcel_I (IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1, IntPtr native_p2, int p3)
		{
			global::Com.Google.Atap.Tangoservice.TangoVhsStub __this = global::Java.Lang.Object.GetObject<global::Com.Google.Atap.Tangoservice.TangoVhsStub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.Parcel p1 = global::Java.Lang.Object.GetObject<global::Android.OS.Parcel> (native_p1, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.Parcel p2 = global::Java.Lang.Object.GetObject<global::Android.OS.Parcel> (native_p2, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.OnTransact (p0, p1, p2, p3);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_onTransact_ILandroid_os_Parcel_Landroid_os_Parcel_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.atap.tangoservice']/class[@name='ITangoVhs.Stub']/method[@name='onTransact' and count(parameter)=4 and parameter[1][@type='int'] and parameter[2][@type='android.os.Parcel'] and parameter[3][@type='android.os.Parcel'] and parameter[4][@type='int']]"
		[Register ("onTransact", "(ILandroid/os/Parcel;Landroid/os/Parcel;I)Z", "GetOnTransact_ILandroid_os_Parcel_Landroid_os_Parcel_IHandler")]
		public virtual unsafe bool OnTransact (int p0, global::Android.OS.Parcel p1, global::Android.OS.Parcel p2, int p3)
		{
			if (id_onTransact_ILandroid_os_Parcel_Landroid_os_Parcel_I == IntPtr.Zero)
				id_onTransact_ILandroid_os_Parcel_Landroid_os_Parcel_I = JNIEnv.GetMethodID (class_ref, "onTransact", "(ILandroid/os/Parcel;Landroid/os/Parcel;I)Z");
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);

				bool __ret;
				if (GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_onTransact_ILandroid_os_Parcel_Landroid_os_Parcel_I, __args);
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onTransact", "(ILandroid/os/Parcel;Landroid/os/Parcel;I)Z"), __args);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_connectFeatureServer_Landroid_os_ParcelFileDescriptor_;
#pragma warning disable 0169
		static Delegate GetConnectFeatureServer_Landroid_os_ParcelFileDescriptor_Handler ()
		{
			if (cb_connectFeatureServer_Landroid_os_ParcelFileDescriptor_ == null)
				cb_connectFeatureServer_Landroid_os_ParcelFileDescriptor_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, int>) n_ConnectFeatureServer_Landroid_os_ParcelFileDescriptor_);
			return cb_connectFeatureServer_Landroid_os_ParcelFileDescriptor_;
		}

		static int n_ConnectFeatureServer_Landroid_os_ParcelFileDescriptor_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Google.Atap.Tangoservice.TangoVhsStub __this = global::Java.Lang.Object.GetObject<global::Com.Google.Atap.Tangoservice.TangoVhsStub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.ParcelFileDescriptor p0 = global::Java.Lang.Object.GetObject<global::Android.OS.ParcelFileDescriptor> (native_p0, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.ConnectFeatureServer (p0);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.atap.tangoservice']/interface[@name='ITangoVhs']/method[@name='connectFeatureServer' and count(parameter)=1 and parameter[1][@type='android.os.ParcelFileDescriptor']]"
		[Register ("connectFeatureServer", "(Landroid/os/ParcelFileDescriptor;)I", "GetConnectFeatureServer_Landroid_os_ParcelFileDescriptor_Handler")]
		public abstract int ConnectFeatureServer (global::Android.OS.ParcelFileDescriptor p0);

		static Delegate cb_disconnectFeatureServer;
#pragma warning disable 0169
		static Delegate GetDisconnectFeatureServerHandler ()
		{
			if (cb_disconnectFeatureServer == null)
				cb_disconnectFeatureServer = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_DisconnectFeatureServer);
			return cb_disconnectFeatureServer;
		}

		static int n_DisconnectFeatureServer (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Google.Atap.Tangoservice.TangoVhsStub __this = global::Java.Lang.Object.GetObject<global::Com.Google.Atap.Tangoservice.TangoVhsStub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.DisconnectFeatureServer ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.atap.tangoservice']/interface[@name='ITangoVhs']/method[@name='disconnectFeatureServer' and count(parameter)=0]"
		[Register ("disconnectFeatureServer", "()I", "GetDisconnectFeatureServerHandler")]
		public abstract int DisconnectFeatureServer ();

		static Delegate cb_updateFeatureServer;
#pragma warning disable 0169
		static Delegate GetUpdateFeatureServerHandler ()
		{
			if (cb_updateFeatureServer == null)
				cb_updateFeatureServer = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_UpdateFeatureServer);
			return cb_updateFeatureServer;
		}

		static int n_UpdateFeatureServer (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Google.Atap.Tangoservice.TangoVhsStub __this = global::Java.Lang.Object.GetObject<global::Com.Google.Atap.Tangoservice.TangoVhsStub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.UpdateFeatureServer ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.atap.tangoservice']/interface[@name='ITangoVhs']/method[@name='updateFeatureServer' and count(parameter)=0]"
		[Register ("updateFeatureServer", "()I", "GetUpdateFeatureServerHandler")]
		public abstract int UpdateFeatureServer ();

	}

	[global::Android.Runtime.Register ("com/google/atap/tangoservice/ITangoVhs$Stub", DoNotGenerateAcw=true)]
	internal partial class TangoVhsStubInvoker : TangoVhsStub {

		public TangoVhsStubInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		protected override global::System.Type ThresholdType {
			get { return typeof (TangoVhsStubInvoker); }
		}

		static IntPtr id_connectFeatureServer_Landroid_os_ParcelFileDescriptor_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.atap.tangoservice']/interface[@name='ITangoVhs']/method[@name='connectFeatureServer' and count(parameter)=1 and parameter[1][@type='android.os.ParcelFileDescriptor']]"
		[Register ("connectFeatureServer", "(Landroid/os/ParcelFileDescriptor;)I", "GetConnectFeatureServer_Landroid_os_ParcelFileDescriptor_Handler")]
		public override unsafe int ConnectFeatureServer (global::Android.OS.ParcelFileDescriptor p0)
		{
			if (id_connectFeatureServer_Landroid_os_ParcelFileDescriptor_ == IntPtr.Zero)
				id_connectFeatureServer_Landroid_os_ParcelFileDescriptor_ = JNIEnv.GetMethodID (class_ref, "connectFeatureServer", "(Landroid/os/ParcelFileDescriptor;)I");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				int __ret = JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_connectFeatureServer_Landroid_os_ParcelFileDescriptor_, __args);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_disconnectFeatureServer;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.atap.tangoservice']/interface[@name='ITangoVhs']/method[@name='disconnectFeatureServer' and count(parameter)=0]"
		[Register ("disconnectFeatureServer", "()I", "GetDisconnectFeatureServerHandler")]
		public override unsafe int DisconnectFeatureServer ()
		{
			if (id_disconnectFeatureServer == IntPtr.Zero)
				id_disconnectFeatureServer = JNIEnv.GetMethodID (class_ref, "disconnectFeatureServer", "()I");
			try {
				return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_disconnectFeatureServer);
			} finally {
			}
		}

		static IntPtr id_updateFeatureServer;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.atap.tangoservice']/interface[@name='ITangoVhs']/method[@name='updateFeatureServer' and count(parameter)=0]"
		[Register ("updateFeatureServer", "()I", "GetUpdateFeatureServerHandler")]
		public override unsafe int UpdateFeatureServer ()
		{
			if (id_updateFeatureServer == IntPtr.Zero)
				id_updateFeatureServer = JNIEnv.GetMethodID (class_ref, "updateFeatureServer", "()I");
			try {
				return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_updateFeatureServer);
			} finally {
			}
		}

	}


	// Metadata.xml XPath interface reference: path="/api/package[@name='com.google.atap.tangoservice']/interface[@name='ITangoVhs']"
	[Register ("com/google/atap/tangoservice/ITangoVhs", "", "Com.Google.Atap.Tangoservice.ITangoVhsInvoker")]
	public partial interface ITangoVhs : global::Android.OS.IInterface {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.atap.tangoservice']/interface[@name='ITangoVhs']/method[@name='connectFeatureServer' and count(parameter)=1 and parameter[1][@type='android.os.ParcelFileDescriptor']]"
		[Register ("connectFeatureServer", "(Landroid/os/ParcelFileDescriptor;)I", "GetConnectFeatureServer_Landroid_os_ParcelFileDescriptor_Handler:Com.Google.Atap.Tangoservice.ITangoVhsInvoker, tango-sdk-base")]
		int ConnectFeatureServer (global::Android.OS.ParcelFileDescriptor p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.atap.tangoservice']/interface[@name='ITangoVhs']/method[@name='disconnectFeatureServer' and count(parameter)=0]"
		[Register ("disconnectFeatureServer", "()I", "GetDisconnectFeatureServerHandler:Com.Google.Atap.Tangoservice.ITangoVhsInvoker, tango-sdk-base")]
		int DisconnectFeatureServer ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.atap.tangoservice']/interface[@name='ITangoVhs']/method[@name='updateFeatureServer' and count(parameter)=0]"
		[Register ("updateFeatureServer", "()I", "GetUpdateFeatureServerHandler:Com.Google.Atap.Tangoservice.ITangoVhsInvoker, tango-sdk-base")]
		int UpdateFeatureServer ();

	}

	[global::Android.Runtime.Register ("com/google/atap/tangoservice/ITangoVhs", DoNotGenerateAcw=true)]
	internal class ITangoVhsInvoker : global::Java.Lang.Object, ITangoVhs {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/google/atap/tangoservice/ITangoVhs");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ITangoVhsInvoker); }
		}

		IntPtr class_ref;

		public static ITangoVhs GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<ITangoVhs> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.google.atap.tangoservice.ITangoVhs"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public ITangoVhsInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_connectFeatureServer_Landroid_os_ParcelFileDescriptor_;
#pragma warning disable 0169
		static Delegate GetConnectFeatureServer_Landroid_os_ParcelFileDescriptor_Handler ()
		{
			if (cb_connectFeatureServer_Landroid_os_ParcelFileDescriptor_ == null)
				cb_connectFeatureServer_Landroid_os_ParcelFileDescriptor_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, int>) n_ConnectFeatureServer_Landroid_os_ParcelFileDescriptor_);
			return cb_connectFeatureServer_Landroid_os_ParcelFileDescriptor_;
		}

		static int n_ConnectFeatureServer_Landroid_os_ParcelFileDescriptor_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Google.Atap.Tangoservice.ITangoVhs __this = global::Java.Lang.Object.GetObject<global::Com.Google.Atap.Tangoservice.ITangoVhs> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.ParcelFileDescriptor p0 = global::Java.Lang.Object.GetObject<global::Android.OS.ParcelFileDescriptor> (native_p0, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.ConnectFeatureServer (p0);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_connectFeatureServer_Landroid_os_ParcelFileDescriptor_;
		public unsafe int ConnectFeatureServer (global::Android.OS.ParcelFileDescriptor p0)
		{
			if (id_connectFeatureServer_Landroid_os_ParcelFileDescriptor_ == IntPtr.Zero)
				id_connectFeatureServer_Landroid_os_ParcelFileDescriptor_ = JNIEnv.GetMethodID (class_ref, "connectFeatureServer", "(Landroid/os/ParcelFileDescriptor;)I");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			int __ret = JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_connectFeatureServer_Landroid_os_ParcelFileDescriptor_, __args);
			return __ret;
		}

		static Delegate cb_disconnectFeatureServer;
#pragma warning disable 0169
		static Delegate GetDisconnectFeatureServerHandler ()
		{
			if (cb_disconnectFeatureServer == null)
				cb_disconnectFeatureServer = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_DisconnectFeatureServer);
			return cb_disconnectFeatureServer;
		}

		static int n_DisconnectFeatureServer (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Google.Atap.Tangoservice.ITangoVhs __this = global::Java.Lang.Object.GetObject<global::Com.Google.Atap.Tangoservice.ITangoVhs> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.DisconnectFeatureServer ();
		}
#pragma warning restore 0169

		IntPtr id_disconnectFeatureServer;
		public unsafe int DisconnectFeatureServer ()
		{
			if (id_disconnectFeatureServer == IntPtr.Zero)
				id_disconnectFeatureServer = JNIEnv.GetMethodID (class_ref, "disconnectFeatureServer", "()I");
			return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_disconnectFeatureServer);
		}

		static Delegate cb_updateFeatureServer;
#pragma warning disable 0169
		static Delegate GetUpdateFeatureServerHandler ()
		{
			if (cb_updateFeatureServer == null)
				cb_updateFeatureServer = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_UpdateFeatureServer);
			return cb_updateFeatureServer;
		}

		static int n_UpdateFeatureServer (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Google.Atap.Tangoservice.ITangoVhs __this = global::Java.Lang.Object.GetObject<global::Com.Google.Atap.Tangoservice.ITangoVhs> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.UpdateFeatureServer ();
		}
#pragma warning restore 0169

		IntPtr id_updateFeatureServer;
		public unsafe int UpdateFeatureServer ()
		{
			if (id_updateFeatureServer == IntPtr.Zero)
				id_updateFeatureServer = JNIEnv.GetMethodID (class_ref, "updateFeatureServer", "()I");
			return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_updateFeatureServer);
		}

		static Delegate cb_asBinder;
#pragma warning disable 0169
		static Delegate GetAsBinderHandler ()
		{
			if (cb_asBinder == null)
				cb_asBinder = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_AsBinder);
			return cb_asBinder;
		}

		static IntPtr n_AsBinder (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Google.Atap.Tangoservice.ITangoVhs __this = global::Java.Lang.Object.GetObject<global::Com.Google.Atap.Tangoservice.ITangoVhs> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.AsBinder ());
		}
#pragma warning restore 0169

		IntPtr id_asBinder;
		public unsafe global::Android.OS.IBinder AsBinder ()
		{
			if (id_asBinder == IntPtr.Zero)
				id_asBinder = JNIEnv.GetMethodID (class_ref, "asBinder", "()Landroid/os/IBinder;");
			return global::Java.Lang.Object.GetObject<global::Android.OS.IBinder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_asBinder), JniHandleOwnership.TransferLocalRef);
		}

	}

}
