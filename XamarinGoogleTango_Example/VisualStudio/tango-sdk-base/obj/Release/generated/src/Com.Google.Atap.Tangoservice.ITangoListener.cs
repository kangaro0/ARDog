using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Google.Atap.Tangoservice {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.google.atap.tangoservice']/class[@name='ITangoListener.Stub']"
	[global::Android.Runtime.Register ("com/google/atap/tangoservice/ITangoListener$Stub", DoNotGenerateAcw=true)]
	public abstract partial class TangoListenerStub : global::Android.OS.Binder, global::Com.Google.Atap.Tangoservice.ITangoListener {

		// Metadata.xml XPath class reference: path="/api/package[@name='com.google.atap.tangoservice']/class[@name='ITangoListener.Stub.Proxy']"
		[global::Android.Runtime.Register ("com/google/atap/tangoservice/ITangoListener$Stub$Proxy", DoNotGenerateAcw=true)]
		public partial class Proxy : global::Java.Lang.Object, global::Com.Google.Atap.Tangoservice.ITangoListener {

			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/google/atap/tangoservice/ITangoListener$Stub$Proxy", ref java_class_handle);
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
				global::Com.Google.Atap.Tangoservice.TangoListenerStub.Proxy __this = global::Java.Lang.Object.GetObject<global::Com.Google.Atap.Tangoservice.TangoListenerStub.Proxy> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.NewString (__this.InterfaceDescriptor);
			}
#pragma warning restore 0169

			static IntPtr id_getInterfaceDescriptor;
			public virtual unsafe string InterfaceDescriptor {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.google.atap.tangoservice']/class[@name='ITangoListener.Stub.Proxy']/method[@name='getInterfaceDescriptor' and count(parameter)=0]"
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
				global::Com.Google.Atap.Tangoservice.TangoListenerStub.Proxy __this = global::Java.Lang.Object.GetObject<global::Com.Google.Atap.Tangoservice.TangoListenerStub.Proxy> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.AsBinder ());
			}
#pragma warning restore 0169

			static IntPtr id_asBinder;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.atap.tangoservice']/class[@name='ITangoListener.Stub.Proxy']/method[@name='asBinder' and count(parameter)=0]"
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

			static Delegate cb_onFoiResponse_Lcom_google_atap_tangoservice_fois_FoiResponse_;
#pragma warning disable 0169
			static Delegate GetOnFoiResponse_Lcom_google_atap_tangoservice_fois_FoiResponse_Handler ()
			{
				if (cb_onFoiResponse_Lcom_google_atap_tangoservice_fois_FoiResponse_ == null)
					cb_onFoiResponse_Lcom_google_atap_tangoservice_fois_FoiResponse_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnFoiResponse_Lcom_google_atap_tangoservice_fois_FoiResponse_);
				return cb_onFoiResponse_Lcom_google_atap_tangoservice_fois_FoiResponse_;
			}

			static void n_OnFoiResponse_Lcom_google_atap_tangoservice_fois_FoiResponse_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Google.Atap.Tangoservice.TangoListenerStub.Proxy __this = global::Java.Lang.Object.GetObject<global::Com.Google.Atap.Tangoservice.TangoListenerStub.Proxy> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Com.Google.Atap.Tangoservice.Fois.FoiResponse p0 = global::Java.Lang.Object.GetObject<global::Com.Google.Atap.Tangoservice.Fois.FoiResponse> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.OnFoiResponse (p0);
			}
#pragma warning restore 0169

			static IntPtr id_onFoiResponse_Lcom_google_atap_tangoservice_fois_FoiResponse_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.atap.tangoservice']/class[@name='ITangoListener.Stub.Proxy']/method[@name='onFoiResponse' and count(parameter)=1 and parameter[1][@type='com.google.atap.tangoservice.fois.FoiResponse']]"
			[Register ("onFoiResponse", "(Lcom/google/atap/tangoservice/fois/FoiResponse;)V", "GetOnFoiResponse_Lcom_google_atap_tangoservice_fois_FoiResponse_Handler")]
			public virtual unsafe void OnFoiResponse (global::Com.Google.Atap.Tangoservice.Fois.FoiResponse p0)
			{
				if (id_onFoiResponse_Lcom_google_atap_tangoservice_fois_FoiResponse_ == IntPtr.Zero)
					id_onFoiResponse_Lcom_google_atap_tangoservice_fois_FoiResponse_ = JNIEnv.GetMethodID (class_ref, "onFoiResponse", "(Lcom/google/atap/tangoservice/fois/FoiResponse;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (p0);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onFoiResponse_Lcom_google_atap_tangoservice_fois_FoiResponse_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onFoiResponse", "(Lcom/google/atap/tangoservice/fois/FoiResponse;)V"), __args);
				} finally {
				}
			}

			static Delegate cb_onGraphicBufferAvailable_I;
#pragma warning disable 0169
			static Delegate GetOnGraphicBufferAvailable_IHandler ()
			{
				if (cb_onGraphicBufferAvailable_I == null)
					cb_onGraphicBufferAvailable_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_OnGraphicBufferAvailable_I);
				return cb_onGraphicBufferAvailable_I;
			}

			static void n_OnGraphicBufferAvailable_I (IntPtr jnienv, IntPtr native__this, int p0)
			{
				global::Com.Google.Atap.Tangoservice.TangoListenerStub.Proxy __this = global::Java.Lang.Object.GetObject<global::Com.Google.Atap.Tangoservice.TangoListenerStub.Proxy> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.OnGraphicBufferAvailable (p0);
			}
#pragma warning restore 0169

			static IntPtr id_onGraphicBufferAvailable_I;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.atap.tangoservice']/class[@name='ITangoListener.Stub.Proxy']/method[@name='onGraphicBufferAvailable' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("onGraphicBufferAvailable", "(I)V", "GetOnGraphicBufferAvailable_IHandler")]
			public virtual unsafe void OnGraphicBufferAvailable (int p0)
			{
				if (id_onGraphicBufferAvailable_I == IntPtr.Zero)
					id_onGraphicBufferAvailable_I = JNIEnv.GetMethodID (class_ref, "onGraphicBufferAvailable", "(I)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (p0);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onGraphicBufferAvailable_I, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onGraphicBufferAvailable", "(I)V"), __args);
				} finally {
				}
			}

			static Delegate cb_onPointCloudAvailable_Lcom_google_atap_tangoservice_TangoPointCloudData_;
#pragma warning disable 0169
			static Delegate GetOnPointCloudAvailable_Lcom_google_atap_tangoservice_TangoPointCloudData_Handler ()
			{
				if (cb_onPointCloudAvailable_Lcom_google_atap_tangoservice_TangoPointCloudData_ == null)
					cb_onPointCloudAvailable_Lcom_google_atap_tangoservice_TangoPointCloudData_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnPointCloudAvailable_Lcom_google_atap_tangoservice_TangoPointCloudData_);
				return cb_onPointCloudAvailable_Lcom_google_atap_tangoservice_TangoPointCloudData_;
			}

			static void n_OnPointCloudAvailable_Lcom_google_atap_tangoservice_TangoPointCloudData_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Google.Atap.Tangoservice.TangoListenerStub.Proxy __this = global::Java.Lang.Object.GetObject<global::Com.Google.Atap.Tangoservice.TangoListenerStub.Proxy> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Com.Google.Atap.Tangoservice.TangoPointCloudData p0 = global::Java.Lang.Object.GetObject<global::Com.Google.Atap.Tangoservice.TangoPointCloudData> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.OnPointCloudAvailable (p0);
			}
#pragma warning restore 0169

			static IntPtr id_onPointCloudAvailable_Lcom_google_atap_tangoservice_TangoPointCloudData_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.atap.tangoservice']/class[@name='ITangoListener.Stub.Proxy']/method[@name='onPointCloudAvailable' and count(parameter)=1 and parameter[1][@type='com.google.atap.tangoservice.TangoPointCloudData']]"
			[Register ("onPointCloudAvailable", "(Lcom/google/atap/tangoservice/TangoPointCloudData;)V", "GetOnPointCloudAvailable_Lcom_google_atap_tangoservice_TangoPointCloudData_Handler")]
			public virtual unsafe void OnPointCloudAvailable (global::Com.Google.Atap.Tangoservice.TangoPointCloudData p0)
			{
				if (id_onPointCloudAvailable_Lcom_google_atap_tangoservice_TangoPointCloudData_ == IntPtr.Zero)
					id_onPointCloudAvailable_Lcom_google_atap_tangoservice_TangoPointCloudData_ = JNIEnv.GetMethodID (class_ref, "onPointCloudAvailable", "(Lcom/google/atap/tangoservice/TangoPointCloudData;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (p0);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onPointCloudAvailable_Lcom_google_atap_tangoservice_TangoPointCloudData_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onPointCloudAvailable", "(Lcom/google/atap/tangoservice/TangoPointCloudData;)V"), __args);
				} finally {
				}
			}

			static Delegate cb_onPoseAvailable_Lcom_google_atap_tangoservice_TangoPoseData_;
#pragma warning disable 0169
			static Delegate GetOnPoseAvailable_Lcom_google_atap_tangoservice_TangoPoseData_Handler ()
			{
				if (cb_onPoseAvailable_Lcom_google_atap_tangoservice_TangoPoseData_ == null)
					cb_onPoseAvailable_Lcom_google_atap_tangoservice_TangoPoseData_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnPoseAvailable_Lcom_google_atap_tangoservice_TangoPoseData_);
				return cb_onPoseAvailable_Lcom_google_atap_tangoservice_TangoPoseData_;
			}

			static void n_OnPoseAvailable_Lcom_google_atap_tangoservice_TangoPoseData_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Google.Atap.Tangoservice.TangoListenerStub.Proxy __this = global::Java.Lang.Object.GetObject<global::Com.Google.Atap.Tangoservice.TangoListenerStub.Proxy> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Com.Google.Atap.Tangoservice.TangoPoseData p0 = global::Java.Lang.Object.GetObject<global::Com.Google.Atap.Tangoservice.TangoPoseData> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.OnPoseAvailable (p0);
			}
#pragma warning restore 0169

			static IntPtr id_onPoseAvailable_Lcom_google_atap_tangoservice_TangoPoseData_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.atap.tangoservice']/class[@name='ITangoListener.Stub.Proxy']/method[@name='onPoseAvailable' and count(parameter)=1 and parameter[1][@type='com.google.atap.tangoservice.TangoPoseData']]"
			[Register ("onPoseAvailable", "(Lcom/google/atap/tangoservice/TangoPoseData;)V", "GetOnPoseAvailable_Lcom_google_atap_tangoservice_TangoPoseData_Handler")]
			public virtual unsafe void OnPoseAvailable (global::Com.Google.Atap.Tangoservice.TangoPoseData p0)
			{
				if (id_onPoseAvailable_Lcom_google_atap_tangoservice_TangoPoseData_ == IntPtr.Zero)
					id_onPoseAvailable_Lcom_google_atap_tangoservice_TangoPoseData_ = JNIEnv.GetMethodID (class_ref, "onPoseAvailable", "(Lcom/google/atap/tangoservice/TangoPoseData;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (p0);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onPoseAvailable_Lcom_google_atap_tangoservice_TangoPoseData_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onPoseAvailable", "(Lcom/google/atap/tangoservice/TangoPoseData;)V"), __args);
				} finally {
				}
			}

			static Delegate cb_onTangoEvent_Lcom_google_atap_tangoservice_TangoEvent_;
#pragma warning disable 0169
			static Delegate GetOnTangoEvent_Lcom_google_atap_tangoservice_TangoEvent_Handler ()
			{
				if (cb_onTangoEvent_Lcom_google_atap_tangoservice_TangoEvent_ == null)
					cb_onTangoEvent_Lcom_google_atap_tangoservice_TangoEvent_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnTangoEvent_Lcom_google_atap_tangoservice_TangoEvent_);
				return cb_onTangoEvent_Lcom_google_atap_tangoservice_TangoEvent_;
			}

			static void n_OnTangoEvent_Lcom_google_atap_tangoservice_TangoEvent_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Google.Atap.Tangoservice.TangoListenerStub.Proxy __this = global::Java.Lang.Object.GetObject<global::Com.Google.Atap.Tangoservice.TangoListenerStub.Proxy> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Com.Google.Atap.Tangoservice.TangoEvent p0 = global::Java.Lang.Object.GetObject<global::Com.Google.Atap.Tangoservice.TangoEvent> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.OnTangoEvent (p0);
			}
#pragma warning restore 0169

			static IntPtr id_onTangoEvent_Lcom_google_atap_tangoservice_TangoEvent_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.atap.tangoservice']/class[@name='ITangoListener.Stub.Proxy']/method[@name='onTangoEvent' and count(parameter)=1 and parameter[1][@type='com.google.atap.tangoservice.TangoEvent']]"
			[Register ("onTangoEvent", "(Lcom/google/atap/tangoservice/TangoEvent;)V", "GetOnTangoEvent_Lcom_google_atap_tangoservice_TangoEvent_Handler")]
			public virtual unsafe void OnTangoEvent (global::Com.Google.Atap.Tangoservice.TangoEvent p0)
			{
				if (id_onTangoEvent_Lcom_google_atap_tangoservice_TangoEvent_ == IntPtr.Zero)
					id_onTangoEvent_Lcom_google_atap_tangoservice_TangoEvent_ = JNIEnv.GetMethodID (class_ref, "onTangoEvent", "(Lcom/google/atap/tangoservice/TangoEvent;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (p0);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onTangoEvent_Lcom_google_atap_tangoservice_TangoEvent_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onTangoEvent", "(Lcom/google/atap/tangoservice/TangoEvent;)V"), __args);
				} finally {
				}
			}

			static Delegate cb_onXyzIjAvailable;
#pragma warning disable 0169
			static Delegate GetOnXyzIjAvailableHandler ()
			{
				if (cb_onXyzIjAvailable == null)
					cb_onXyzIjAvailable = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnXyzIjAvailable);
				return cb_onXyzIjAvailable;
			}

			static void n_OnXyzIjAvailable (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Google.Atap.Tangoservice.TangoListenerStub.Proxy __this = global::Java.Lang.Object.GetObject<global::Com.Google.Atap.Tangoservice.TangoListenerStub.Proxy> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.OnXyzIjAvailable ();
			}
#pragma warning restore 0169

			static IntPtr id_onXyzIjAvailable;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.atap.tangoservice']/class[@name='ITangoListener.Stub.Proxy']/method[@name='onXyzIjAvailable' and count(parameter)=0]"
			[Register ("onXyzIjAvailable", "()V", "GetOnXyzIjAvailableHandler")]
			public virtual unsafe void OnXyzIjAvailable ()
			{
				if (id_onXyzIjAvailable == IntPtr.Zero)
					id_onXyzIjAvailable = JNIEnv.GetMethodID (class_ref, "onXyzIjAvailable", "()V");
				try {

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onXyzIjAvailable);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onXyzIjAvailable", "()V"));
				} finally {
				}
			}

		}

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/google/atap/tangoservice/ITangoListener$Stub", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (TangoListenerStub); }
		}

		protected TangoListenerStub (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.google.atap.tangoservice']/class[@name='ITangoListener.Stub']/constructor[@name='ITangoListener.Stub' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe TangoListenerStub ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (TangoListenerStub)) {
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
			global::Com.Google.Atap.Tangoservice.TangoListenerStub __this = global::Java.Lang.Object.GetObject<global::Com.Google.Atap.Tangoservice.TangoListenerStub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.AsBinder ());
		}
#pragma warning restore 0169

		static IntPtr id_asBinder;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.atap.tangoservice']/class[@name='ITangoListener.Stub']/method[@name='asBinder' and count(parameter)=0]"
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
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.atap.tangoservice']/class[@name='ITangoListener.Stub']/method[@name='asInterface' and count(parameter)=1 and parameter[1][@type='android.os.IBinder']]"
		[Register ("asInterface", "(Landroid/os/IBinder;)Lcom/google/atap/tangoservice/ITangoListener;", "")]
		public static unsafe global::Com.Google.Atap.Tangoservice.ITangoListener AsInterface (global::Android.OS.IBinder p0)
		{
			if (id_asInterface_Landroid_os_IBinder_ == IntPtr.Zero)
				id_asInterface_Landroid_os_IBinder_ = JNIEnv.GetStaticMethodID (class_ref, "asInterface", "(Landroid/os/IBinder;)Lcom/google/atap/tangoservice/ITangoListener;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				global::Com.Google.Atap.Tangoservice.ITangoListener __ret = global::Java.Lang.Object.GetObject<global::Com.Google.Atap.Tangoservice.ITangoListener> (JNIEnv.CallStaticObjectMethod  (class_ref, id_asInterface_Landroid_os_IBinder_, __args), JniHandleOwnership.TransferLocalRef);
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
			global::Com.Google.Atap.Tangoservice.TangoListenerStub __this = global::Java.Lang.Object.GetObject<global::Com.Google.Atap.Tangoservice.TangoListenerStub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.Parcel p1 = global::Java.Lang.Object.GetObject<global::Android.OS.Parcel> (native_p1, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.Parcel p2 = global::Java.Lang.Object.GetObject<global::Android.OS.Parcel> (native_p2, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.OnTransact (p0, p1, p2, p3);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_onTransact_ILandroid_os_Parcel_Landroid_os_Parcel_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.atap.tangoservice']/class[@name='ITangoListener.Stub']/method[@name='onTransact' and count(parameter)=4 and parameter[1][@type='int'] and parameter[2][@type='android.os.Parcel'] and parameter[3][@type='android.os.Parcel'] and parameter[4][@type='int']]"
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

		static Delegate cb_onFoiResponse_Lcom_google_atap_tangoservice_fois_FoiResponse_;
#pragma warning disable 0169
		static Delegate GetOnFoiResponse_Lcom_google_atap_tangoservice_fois_FoiResponse_Handler ()
		{
			if (cb_onFoiResponse_Lcom_google_atap_tangoservice_fois_FoiResponse_ == null)
				cb_onFoiResponse_Lcom_google_atap_tangoservice_fois_FoiResponse_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnFoiResponse_Lcom_google_atap_tangoservice_fois_FoiResponse_);
			return cb_onFoiResponse_Lcom_google_atap_tangoservice_fois_FoiResponse_;
		}

		static void n_OnFoiResponse_Lcom_google_atap_tangoservice_fois_FoiResponse_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Google.Atap.Tangoservice.TangoListenerStub __this = global::Java.Lang.Object.GetObject<global::Com.Google.Atap.Tangoservice.TangoListenerStub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Google.Atap.Tangoservice.Fois.FoiResponse p0 = global::Java.Lang.Object.GetObject<global::Com.Google.Atap.Tangoservice.Fois.FoiResponse> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnFoiResponse (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.atap.tangoservice']/interface[@name='ITangoListener']/method[@name='onFoiResponse' and count(parameter)=1 and parameter[1][@type='com.google.atap.tangoservice.fois.FoiResponse']]"
		[Register ("onFoiResponse", "(Lcom/google/atap/tangoservice/fois/FoiResponse;)V", "GetOnFoiResponse_Lcom_google_atap_tangoservice_fois_FoiResponse_Handler")]
		public abstract void OnFoiResponse (global::Com.Google.Atap.Tangoservice.Fois.FoiResponse p0);

		static Delegate cb_onGraphicBufferAvailable_I;
#pragma warning disable 0169
		static Delegate GetOnGraphicBufferAvailable_IHandler ()
		{
			if (cb_onGraphicBufferAvailable_I == null)
				cb_onGraphicBufferAvailable_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_OnGraphicBufferAvailable_I);
			return cb_onGraphicBufferAvailable_I;
		}

		static void n_OnGraphicBufferAvailable_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Google.Atap.Tangoservice.TangoListenerStub __this = global::Java.Lang.Object.GetObject<global::Com.Google.Atap.Tangoservice.TangoListenerStub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnGraphicBufferAvailable (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.atap.tangoservice']/interface[@name='ITangoListener']/method[@name='onGraphicBufferAvailable' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("onGraphicBufferAvailable", "(I)V", "GetOnGraphicBufferAvailable_IHandler")]
		public abstract void OnGraphicBufferAvailable (int p0);

		static Delegate cb_onPointCloudAvailable_Lcom_google_atap_tangoservice_TangoPointCloudData_;
#pragma warning disable 0169
		static Delegate GetOnPointCloudAvailable_Lcom_google_atap_tangoservice_TangoPointCloudData_Handler ()
		{
			if (cb_onPointCloudAvailable_Lcom_google_atap_tangoservice_TangoPointCloudData_ == null)
				cb_onPointCloudAvailable_Lcom_google_atap_tangoservice_TangoPointCloudData_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnPointCloudAvailable_Lcom_google_atap_tangoservice_TangoPointCloudData_);
			return cb_onPointCloudAvailable_Lcom_google_atap_tangoservice_TangoPointCloudData_;
		}

		static void n_OnPointCloudAvailable_Lcom_google_atap_tangoservice_TangoPointCloudData_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Google.Atap.Tangoservice.TangoListenerStub __this = global::Java.Lang.Object.GetObject<global::Com.Google.Atap.Tangoservice.TangoListenerStub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Google.Atap.Tangoservice.TangoPointCloudData p0 = global::Java.Lang.Object.GetObject<global::Com.Google.Atap.Tangoservice.TangoPointCloudData> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnPointCloudAvailable (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.atap.tangoservice']/interface[@name='ITangoListener']/method[@name='onPointCloudAvailable' and count(parameter)=1 and parameter[1][@type='com.google.atap.tangoservice.TangoPointCloudData']]"
		[Register ("onPointCloudAvailable", "(Lcom/google/atap/tangoservice/TangoPointCloudData;)V", "GetOnPointCloudAvailable_Lcom_google_atap_tangoservice_TangoPointCloudData_Handler")]
		public abstract void OnPointCloudAvailable (global::Com.Google.Atap.Tangoservice.TangoPointCloudData p0);

		static Delegate cb_onPoseAvailable_Lcom_google_atap_tangoservice_TangoPoseData_;
#pragma warning disable 0169
		static Delegate GetOnPoseAvailable_Lcom_google_atap_tangoservice_TangoPoseData_Handler ()
		{
			if (cb_onPoseAvailable_Lcom_google_atap_tangoservice_TangoPoseData_ == null)
				cb_onPoseAvailable_Lcom_google_atap_tangoservice_TangoPoseData_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnPoseAvailable_Lcom_google_atap_tangoservice_TangoPoseData_);
			return cb_onPoseAvailable_Lcom_google_atap_tangoservice_TangoPoseData_;
		}

		static void n_OnPoseAvailable_Lcom_google_atap_tangoservice_TangoPoseData_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Google.Atap.Tangoservice.TangoListenerStub __this = global::Java.Lang.Object.GetObject<global::Com.Google.Atap.Tangoservice.TangoListenerStub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Google.Atap.Tangoservice.TangoPoseData p0 = global::Java.Lang.Object.GetObject<global::Com.Google.Atap.Tangoservice.TangoPoseData> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnPoseAvailable (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.atap.tangoservice']/interface[@name='ITangoListener']/method[@name='onPoseAvailable' and count(parameter)=1 and parameter[1][@type='com.google.atap.tangoservice.TangoPoseData']]"
		[Register ("onPoseAvailable", "(Lcom/google/atap/tangoservice/TangoPoseData;)V", "GetOnPoseAvailable_Lcom_google_atap_tangoservice_TangoPoseData_Handler")]
		public abstract void OnPoseAvailable (global::Com.Google.Atap.Tangoservice.TangoPoseData p0);

		static Delegate cb_onTangoEvent_Lcom_google_atap_tangoservice_TangoEvent_;
#pragma warning disable 0169
		static Delegate GetOnTangoEvent_Lcom_google_atap_tangoservice_TangoEvent_Handler ()
		{
			if (cb_onTangoEvent_Lcom_google_atap_tangoservice_TangoEvent_ == null)
				cb_onTangoEvent_Lcom_google_atap_tangoservice_TangoEvent_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnTangoEvent_Lcom_google_atap_tangoservice_TangoEvent_);
			return cb_onTangoEvent_Lcom_google_atap_tangoservice_TangoEvent_;
		}

		static void n_OnTangoEvent_Lcom_google_atap_tangoservice_TangoEvent_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Google.Atap.Tangoservice.TangoListenerStub __this = global::Java.Lang.Object.GetObject<global::Com.Google.Atap.Tangoservice.TangoListenerStub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Google.Atap.Tangoservice.TangoEvent p0 = global::Java.Lang.Object.GetObject<global::Com.Google.Atap.Tangoservice.TangoEvent> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnTangoEvent (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.atap.tangoservice']/interface[@name='ITangoListener']/method[@name='onTangoEvent' and count(parameter)=1 and parameter[1][@type='com.google.atap.tangoservice.TangoEvent']]"
		[Register ("onTangoEvent", "(Lcom/google/atap/tangoservice/TangoEvent;)V", "GetOnTangoEvent_Lcom_google_atap_tangoservice_TangoEvent_Handler")]
		public abstract void OnTangoEvent (global::Com.Google.Atap.Tangoservice.TangoEvent p0);

		static Delegate cb_onXyzIjAvailable;
#pragma warning disable 0169
		static Delegate GetOnXyzIjAvailableHandler ()
		{
			if (cb_onXyzIjAvailable == null)
				cb_onXyzIjAvailable = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnXyzIjAvailable);
			return cb_onXyzIjAvailable;
		}

		static void n_OnXyzIjAvailable (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Google.Atap.Tangoservice.TangoListenerStub __this = global::Java.Lang.Object.GetObject<global::Com.Google.Atap.Tangoservice.TangoListenerStub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnXyzIjAvailable ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.atap.tangoservice']/interface[@name='ITangoListener']/method[@name='onXyzIjAvailable' and count(parameter)=0]"
		[Register ("onXyzIjAvailable", "()V", "GetOnXyzIjAvailableHandler")]
		public abstract void OnXyzIjAvailable ();

	}

	[global::Android.Runtime.Register ("com/google/atap/tangoservice/ITangoListener$Stub", DoNotGenerateAcw=true)]
	internal partial class TangoListenerStubInvoker : TangoListenerStub {

		public TangoListenerStubInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		protected override global::System.Type ThresholdType {
			get { return typeof (TangoListenerStubInvoker); }
		}

		static IntPtr id_onFoiResponse_Lcom_google_atap_tangoservice_fois_FoiResponse_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.atap.tangoservice']/interface[@name='ITangoListener']/method[@name='onFoiResponse' and count(parameter)=1 and parameter[1][@type='com.google.atap.tangoservice.fois.FoiResponse']]"
		[Register ("onFoiResponse", "(Lcom/google/atap/tangoservice/fois/FoiResponse;)V", "GetOnFoiResponse_Lcom_google_atap_tangoservice_fois_FoiResponse_Handler")]
		public override unsafe void OnFoiResponse (global::Com.Google.Atap.Tangoservice.Fois.FoiResponse p0)
		{
			if (id_onFoiResponse_Lcom_google_atap_tangoservice_fois_FoiResponse_ == IntPtr.Zero)
				id_onFoiResponse_Lcom_google_atap_tangoservice_fois_FoiResponse_ = JNIEnv.GetMethodID (class_ref, "onFoiResponse", "(Lcom/google/atap/tangoservice/fois/FoiResponse;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onFoiResponse_Lcom_google_atap_tangoservice_fois_FoiResponse_, __args);
			} finally {
			}
		}

		static IntPtr id_onGraphicBufferAvailable_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.atap.tangoservice']/interface[@name='ITangoListener']/method[@name='onGraphicBufferAvailable' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("onGraphicBufferAvailable", "(I)V", "GetOnGraphicBufferAvailable_IHandler")]
		public override unsafe void OnGraphicBufferAvailable (int p0)
		{
			if (id_onGraphicBufferAvailable_I == IntPtr.Zero)
				id_onGraphicBufferAvailable_I = JNIEnv.GetMethodID (class_ref, "onGraphicBufferAvailable", "(I)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onGraphicBufferAvailable_I, __args);
			} finally {
			}
		}

		static IntPtr id_onPointCloudAvailable_Lcom_google_atap_tangoservice_TangoPointCloudData_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.atap.tangoservice']/interface[@name='ITangoListener']/method[@name='onPointCloudAvailable' and count(parameter)=1 and parameter[1][@type='com.google.atap.tangoservice.TangoPointCloudData']]"
		[Register ("onPointCloudAvailable", "(Lcom/google/atap/tangoservice/TangoPointCloudData;)V", "GetOnPointCloudAvailable_Lcom_google_atap_tangoservice_TangoPointCloudData_Handler")]
		public override unsafe void OnPointCloudAvailable (global::Com.Google.Atap.Tangoservice.TangoPointCloudData p0)
		{
			if (id_onPointCloudAvailable_Lcom_google_atap_tangoservice_TangoPointCloudData_ == IntPtr.Zero)
				id_onPointCloudAvailable_Lcom_google_atap_tangoservice_TangoPointCloudData_ = JNIEnv.GetMethodID (class_ref, "onPointCloudAvailable", "(Lcom/google/atap/tangoservice/TangoPointCloudData;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onPointCloudAvailable_Lcom_google_atap_tangoservice_TangoPointCloudData_, __args);
			} finally {
			}
		}

		static IntPtr id_onPoseAvailable_Lcom_google_atap_tangoservice_TangoPoseData_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.atap.tangoservice']/interface[@name='ITangoListener']/method[@name='onPoseAvailable' and count(parameter)=1 and parameter[1][@type='com.google.atap.tangoservice.TangoPoseData']]"
		[Register ("onPoseAvailable", "(Lcom/google/atap/tangoservice/TangoPoseData;)V", "GetOnPoseAvailable_Lcom_google_atap_tangoservice_TangoPoseData_Handler")]
		public override unsafe void OnPoseAvailable (global::Com.Google.Atap.Tangoservice.TangoPoseData p0)
		{
			if (id_onPoseAvailable_Lcom_google_atap_tangoservice_TangoPoseData_ == IntPtr.Zero)
				id_onPoseAvailable_Lcom_google_atap_tangoservice_TangoPoseData_ = JNIEnv.GetMethodID (class_ref, "onPoseAvailable", "(Lcom/google/atap/tangoservice/TangoPoseData;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onPoseAvailable_Lcom_google_atap_tangoservice_TangoPoseData_, __args);
			} finally {
			}
		}

		static IntPtr id_onTangoEvent_Lcom_google_atap_tangoservice_TangoEvent_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.atap.tangoservice']/interface[@name='ITangoListener']/method[@name='onTangoEvent' and count(parameter)=1 and parameter[1][@type='com.google.atap.tangoservice.TangoEvent']]"
		[Register ("onTangoEvent", "(Lcom/google/atap/tangoservice/TangoEvent;)V", "GetOnTangoEvent_Lcom_google_atap_tangoservice_TangoEvent_Handler")]
		public override unsafe void OnTangoEvent (global::Com.Google.Atap.Tangoservice.TangoEvent p0)
		{
			if (id_onTangoEvent_Lcom_google_atap_tangoservice_TangoEvent_ == IntPtr.Zero)
				id_onTangoEvent_Lcom_google_atap_tangoservice_TangoEvent_ = JNIEnv.GetMethodID (class_ref, "onTangoEvent", "(Lcom/google/atap/tangoservice/TangoEvent;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onTangoEvent_Lcom_google_atap_tangoservice_TangoEvent_, __args);
			} finally {
			}
		}

		static IntPtr id_onXyzIjAvailable;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.atap.tangoservice']/interface[@name='ITangoListener']/method[@name='onXyzIjAvailable' and count(parameter)=0]"
		[Register ("onXyzIjAvailable", "()V", "GetOnXyzIjAvailableHandler")]
		public override unsafe void OnXyzIjAvailable ()
		{
			if (id_onXyzIjAvailable == IntPtr.Zero)
				id_onXyzIjAvailable = JNIEnv.GetMethodID (class_ref, "onXyzIjAvailable", "()V");
			try {
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onXyzIjAvailable);
			} finally {
			}
		}

	}


	// Metadata.xml XPath interface reference: path="/api/package[@name='com.google.atap.tangoservice']/interface[@name='ITangoListener']"
	[Register ("com/google/atap/tangoservice/ITangoListener", "", "Com.Google.Atap.Tangoservice.ITangoListenerInvoker")]
	public partial interface ITangoListener : global::Android.OS.IInterface {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.atap.tangoservice']/interface[@name='ITangoListener']/method[@name='onFoiResponse' and count(parameter)=1 and parameter[1][@type='com.google.atap.tangoservice.fois.FoiResponse']]"
		[Register ("onFoiResponse", "(Lcom/google/atap/tangoservice/fois/FoiResponse;)V", "GetOnFoiResponse_Lcom_google_atap_tangoservice_fois_FoiResponse_Handler:Com.Google.Atap.Tangoservice.ITangoListenerInvoker, tango-sdk-base")]
		void OnFoiResponse (global::Com.Google.Atap.Tangoservice.Fois.FoiResponse p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.atap.tangoservice']/interface[@name='ITangoListener']/method[@name='onGraphicBufferAvailable' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("onGraphicBufferAvailable", "(I)V", "GetOnGraphicBufferAvailable_IHandler:Com.Google.Atap.Tangoservice.ITangoListenerInvoker, tango-sdk-base")]
		void OnGraphicBufferAvailable (int p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.atap.tangoservice']/interface[@name='ITangoListener']/method[@name='onPointCloudAvailable' and count(parameter)=1 and parameter[1][@type='com.google.atap.tangoservice.TangoPointCloudData']]"
		[Register ("onPointCloudAvailable", "(Lcom/google/atap/tangoservice/TangoPointCloudData;)V", "GetOnPointCloudAvailable_Lcom_google_atap_tangoservice_TangoPointCloudData_Handler:Com.Google.Atap.Tangoservice.ITangoListenerInvoker, tango-sdk-base")]
		void OnPointCloudAvailable (global::Com.Google.Atap.Tangoservice.TangoPointCloudData p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.atap.tangoservice']/interface[@name='ITangoListener']/method[@name='onPoseAvailable' and count(parameter)=1 and parameter[1][@type='com.google.atap.tangoservice.TangoPoseData']]"
		[Register ("onPoseAvailable", "(Lcom/google/atap/tangoservice/TangoPoseData;)V", "GetOnPoseAvailable_Lcom_google_atap_tangoservice_TangoPoseData_Handler:Com.Google.Atap.Tangoservice.ITangoListenerInvoker, tango-sdk-base")]
		void OnPoseAvailable (global::Com.Google.Atap.Tangoservice.TangoPoseData p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.atap.tangoservice']/interface[@name='ITangoListener']/method[@name='onTangoEvent' and count(parameter)=1 and parameter[1][@type='com.google.atap.tangoservice.TangoEvent']]"
		[Register ("onTangoEvent", "(Lcom/google/atap/tangoservice/TangoEvent;)V", "GetOnTangoEvent_Lcom_google_atap_tangoservice_TangoEvent_Handler:Com.Google.Atap.Tangoservice.ITangoListenerInvoker, tango-sdk-base")]
		void OnTangoEvent (global::Com.Google.Atap.Tangoservice.TangoEvent p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.atap.tangoservice']/interface[@name='ITangoListener']/method[@name='onXyzIjAvailable' and count(parameter)=0]"
		[Register ("onXyzIjAvailable", "()V", "GetOnXyzIjAvailableHandler:Com.Google.Atap.Tangoservice.ITangoListenerInvoker, tango-sdk-base")]
		void OnXyzIjAvailable ();

	}

	[global::Android.Runtime.Register ("com/google/atap/tangoservice/ITangoListener", DoNotGenerateAcw=true)]
	internal class ITangoListenerInvoker : global::Java.Lang.Object, ITangoListener {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/google/atap/tangoservice/ITangoListener");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ITangoListenerInvoker); }
		}

		IntPtr class_ref;

		public static ITangoListener GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<ITangoListener> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.google.atap.tangoservice.ITangoListener"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public ITangoListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_onFoiResponse_Lcom_google_atap_tangoservice_fois_FoiResponse_;
#pragma warning disable 0169
		static Delegate GetOnFoiResponse_Lcom_google_atap_tangoservice_fois_FoiResponse_Handler ()
		{
			if (cb_onFoiResponse_Lcom_google_atap_tangoservice_fois_FoiResponse_ == null)
				cb_onFoiResponse_Lcom_google_atap_tangoservice_fois_FoiResponse_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnFoiResponse_Lcom_google_atap_tangoservice_fois_FoiResponse_);
			return cb_onFoiResponse_Lcom_google_atap_tangoservice_fois_FoiResponse_;
		}

		static void n_OnFoiResponse_Lcom_google_atap_tangoservice_fois_FoiResponse_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Google.Atap.Tangoservice.ITangoListener __this = global::Java.Lang.Object.GetObject<global::Com.Google.Atap.Tangoservice.ITangoListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Google.Atap.Tangoservice.Fois.FoiResponse p0 = global::Java.Lang.Object.GetObject<global::Com.Google.Atap.Tangoservice.Fois.FoiResponse> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnFoiResponse (p0);
		}
#pragma warning restore 0169

		IntPtr id_onFoiResponse_Lcom_google_atap_tangoservice_fois_FoiResponse_;
		public unsafe void OnFoiResponse (global::Com.Google.Atap.Tangoservice.Fois.FoiResponse p0)
		{
			if (id_onFoiResponse_Lcom_google_atap_tangoservice_fois_FoiResponse_ == IntPtr.Zero)
				id_onFoiResponse_Lcom_google_atap_tangoservice_fois_FoiResponse_ = JNIEnv.GetMethodID (class_ref, "onFoiResponse", "(Lcom/google/atap/tangoservice/fois/FoiResponse;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onFoiResponse_Lcom_google_atap_tangoservice_fois_FoiResponse_, __args);
		}

		static Delegate cb_onGraphicBufferAvailable_I;
#pragma warning disable 0169
		static Delegate GetOnGraphicBufferAvailable_IHandler ()
		{
			if (cb_onGraphicBufferAvailable_I == null)
				cb_onGraphicBufferAvailable_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_OnGraphicBufferAvailable_I);
			return cb_onGraphicBufferAvailable_I;
		}

		static void n_OnGraphicBufferAvailable_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Google.Atap.Tangoservice.ITangoListener __this = global::Java.Lang.Object.GetObject<global::Com.Google.Atap.Tangoservice.ITangoListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnGraphicBufferAvailable (p0);
		}
#pragma warning restore 0169

		IntPtr id_onGraphicBufferAvailable_I;
		public unsafe void OnGraphicBufferAvailable (int p0)
		{
			if (id_onGraphicBufferAvailable_I == IntPtr.Zero)
				id_onGraphicBufferAvailable_I = JNIEnv.GetMethodID (class_ref, "onGraphicBufferAvailable", "(I)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onGraphicBufferAvailable_I, __args);
		}

		static Delegate cb_onPointCloudAvailable_Lcom_google_atap_tangoservice_TangoPointCloudData_;
#pragma warning disable 0169
		static Delegate GetOnPointCloudAvailable_Lcom_google_atap_tangoservice_TangoPointCloudData_Handler ()
		{
			if (cb_onPointCloudAvailable_Lcom_google_atap_tangoservice_TangoPointCloudData_ == null)
				cb_onPointCloudAvailable_Lcom_google_atap_tangoservice_TangoPointCloudData_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnPointCloudAvailable_Lcom_google_atap_tangoservice_TangoPointCloudData_);
			return cb_onPointCloudAvailable_Lcom_google_atap_tangoservice_TangoPointCloudData_;
		}

		static void n_OnPointCloudAvailable_Lcom_google_atap_tangoservice_TangoPointCloudData_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Google.Atap.Tangoservice.ITangoListener __this = global::Java.Lang.Object.GetObject<global::Com.Google.Atap.Tangoservice.ITangoListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Google.Atap.Tangoservice.TangoPointCloudData p0 = global::Java.Lang.Object.GetObject<global::Com.Google.Atap.Tangoservice.TangoPointCloudData> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnPointCloudAvailable (p0);
		}
#pragma warning restore 0169

		IntPtr id_onPointCloudAvailable_Lcom_google_atap_tangoservice_TangoPointCloudData_;
		public unsafe void OnPointCloudAvailable (global::Com.Google.Atap.Tangoservice.TangoPointCloudData p0)
		{
			if (id_onPointCloudAvailable_Lcom_google_atap_tangoservice_TangoPointCloudData_ == IntPtr.Zero)
				id_onPointCloudAvailable_Lcom_google_atap_tangoservice_TangoPointCloudData_ = JNIEnv.GetMethodID (class_ref, "onPointCloudAvailable", "(Lcom/google/atap/tangoservice/TangoPointCloudData;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onPointCloudAvailable_Lcom_google_atap_tangoservice_TangoPointCloudData_, __args);
		}

		static Delegate cb_onPoseAvailable_Lcom_google_atap_tangoservice_TangoPoseData_;
#pragma warning disable 0169
		static Delegate GetOnPoseAvailable_Lcom_google_atap_tangoservice_TangoPoseData_Handler ()
		{
			if (cb_onPoseAvailable_Lcom_google_atap_tangoservice_TangoPoseData_ == null)
				cb_onPoseAvailable_Lcom_google_atap_tangoservice_TangoPoseData_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnPoseAvailable_Lcom_google_atap_tangoservice_TangoPoseData_);
			return cb_onPoseAvailable_Lcom_google_atap_tangoservice_TangoPoseData_;
		}

		static void n_OnPoseAvailable_Lcom_google_atap_tangoservice_TangoPoseData_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Google.Atap.Tangoservice.ITangoListener __this = global::Java.Lang.Object.GetObject<global::Com.Google.Atap.Tangoservice.ITangoListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Google.Atap.Tangoservice.TangoPoseData p0 = global::Java.Lang.Object.GetObject<global::Com.Google.Atap.Tangoservice.TangoPoseData> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnPoseAvailable (p0);
		}
#pragma warning restore 0169

		IntPtr id_onPoseAvailable_Lcom_google_atap_tangoservice_TangoPoseData_;
		public unsafe void OnPoseAvailable (global::Com.Google.Atap.Tangoservice.TangoPoseData p0)
		{
			if (id_onPoseAvailable_Lcom_google_atap_tangoservice_TangoPoseData_ == IntPtr.Zero)
				id_onPoseAvailable_Lcom_google_atap_tangoservice_TangoPoseData_ = JNIEnv.GetMethodID (class_ref, "onPoseAvailable", "(Lcom/google/atap/tangoservice/TangoPoseData;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onPoseAvailable_Lcom_google_atap_tangoservice_TangoPoseData_, __args);
		}

		static Delegate cb_onTangoEvent_Lcom_google_atap_tangoservice_TangoEvent_;
#pragma warning disable 0169
		static Delegate GetOnTangoEvent_Lcom_google_atap_tangoservice_TangoEvent_Handler ()
		{
			if (cb_onTangoEvent_Lcom_google_atap_tangoservice_TangoEvent_ == null)
				cb_onTangoEvent_Lcom_google_atap_tangoservice_TangoEvent_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnTangoEvent_Lcom_google_atap_tangoservice_TangoEvent_);
			return cb_onTangoEvent_Lcom_google_atap_tangoservice_TangoEvent_;
		}

		static void n_OnTangoEvent_Lcom_google_atap_tangoservice_TangoEvent_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Google.Atap.Tangoservice.ITangoListener __this = global::Java.Lang.Object.GetObject<global::Com.Google.Atap.Tangoservice.ITangoListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Google.Atap.Tangoservice.TangoEvent p0 = global::Java.Lang.Object.GetObject<global::Com.Google.Atap.Tangoservice.TangoEvent> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnTangoEvent (p0);
		}
#pragma warning restore 0169

		IntPtr id_onTangoEvent_Lcom_google_atap_tangoservice_TangoEvent_;
		public unsafe void OnTangoEvent (global::Com.Google.Atap.Tangoservice.TangoEvent p0)
		{
			if (id_onTangoEvent_Lcom_google_atap_tangoservice_TangoEvent_ == IntPtr.Zero)
				id_onTangoEvent_Lcom_google_atap_tangoservice_TangoEvent_ = JNIEnv.GetMethodID (class_ref, "onTangoEvent", "(Lcom/google/atap/tangoservice/TangoEvent;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onTangoEvent_Lcom_google_atap_tangoservice_TangoEvent_, __args);
		}

		static Delegate cb_onXyzIjAvailable;
#pragma warning disable 0169
		static Delegate GetOnXyzIjAvailableHandler ()
		{
			if (cb_onXyzIjAvailable == null)
				cb_onXyzIjAvailable = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnXyzIjAvailable);
			return cb_onXyzIjAvailable;
		}

		static void n_OnXyzIjAvailable (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Google.Atap.Tangoservice.ITangoListener __this = global::Java.Lang.Object.GetObject<global::Com.Google.Atap.Tangoservice.ITangoListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnXyzIjAvailable ();
		}
#pragma warning restore 0169

		IntPtr id_onXyzIjAvailable;
		public unsafe void OnXyzIjAvailable ()
		{
			if (id_onXyzIjAvailable == IntPtr.Zero)
				id_onXyzIjAvailable = JNIEnv.GetMethodID (class_ref, "onXyzIjAvailable", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onXyzIjAvailable);
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
			global::Com.Google.Atap.Tangoservice.ITangoListener __this = global::Java.Lang.Object.GetObject<global::Com.Google.Atap.Tangoservice.ITangoListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
