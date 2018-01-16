using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Google.Atap.Tangoservice {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.google.atap.tangoservice']/class[@name='ITango.Stub']"
	[global::Android.Runtime.Register ("com/google/atap/tangoservice/ITango$Stub", DoNotGenerateAcw=true)]
	public abstract partial class TangoStub : global::Android.OS.Binder, global::Com.Google.Atap.Tangoservice.ITango {

		// Metadata.xml XPath class reference: path="/api/package[@name='com.google.atap.tangoservice']/class[@name='ITango.Stub.Proxy']"
		[global::Android.Runtime.Register ("com/google/atap/tangoservice/ITango$Stub$Proxy", DoNotGenerateAcw=true)]
		public partial class Proxy : global::Java.Lang.Object, global::Com.Google.Atap.Tangoservice.ITango {

			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/google/atap/tangoservice/ITango$Stub$Proxy", ref java_class_handle);
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
				global::Com.Google.Atap.Tangoservice.TangoStub.Proxy __this = global::Java.Lang.Object.GetObject<global::Com.Google.Atap.Tangoservice.TangoStub.Proxy> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.NewString (__this.InterfaceDescriptor);
			}
#pragma warning restore 0169

			static IntPtr id_getInterfaceDescriptor;
			public virtual unsafe string InterfaceDescriptor {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.google.atap.tangoservice']/class[@name='ITango.Stub.Proxy']/method[@name='getInterfaceDescriptor' and count(parameter)=0]"
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
				global::Com.Google.Atap.Tangoservice.TangoStub.Proxy __this = global::Java.Lang.Object.GetObject<global::Com.Google.Atap.Tangoservice.TangoStub.Proxy> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.AsBinder ());
			}
#pragma warning restore 0169

			static IntPtr id_asBinder;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.atap.tangoservice']/class[@name='ITango.Stub.Proxy']/method[@name='asBinder' and count(parameter)=0]"
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

			static Delegate cb_connect_Lcom_google_atap_tangoservice_ITangoListener_Lcom_google_atap_tangoservice_TangoConfig_;
#pragma warning disable 0169
			static Delegate GetConnect_Lcom_google_atap_tangoservice_ITangoListener_Lcom_google_atap_tangoservice_TangoConfig_Handler ()
			{
				if (cb_connect_Lcom_google_atap_tangoservice_ITangoListener_Lcom_google_atap_tangoservice_TangoConfig_ == null)
					cb_connect_Lcom_google_atap_tangoservice_ITangoListener_Lcom_google_atap_tangoservice_TangoConfig_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, int>) n_Connect_Lcom_google_atap_tangoservice_ITangoListener_Lcom_google_atap_tangoservice_TangoConfig_);
				return cb_connect_Lcom_google_atap_tangoservice_ITangoListener_Lcom_google_atap_tangoservice_TangoConfig_;
			}

			static int n_Connect_Lcom_google_atap_tangoservice_ITangoListener_Lcom_google_atap_tangoservice_TangoConfig_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
			{
				global::Com.Google.Atap.Tangoservice.TangoStub.Proxy __this = global::Java.Lang.Object.GetObject<global::Com.Google.Atap.Tangoservice.TangoStub.Proxy> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Com.Google.Atap.Tangoservice.ITangoListener p0 = (global::Com.Google.Atap.Tangoservice.ITangoListener)global::Java.Lang.Object.GetObject<global::Com.Google.Atap.Tangoservice.ITangoListener> (native_p0, JniHandleOwnership.DoNotTransfer);
				global::Com.Google.Atap.Tangoservice.TangoConfig p1 = global::Java.Lang.Object.GetObject<global::Com.Google.Atap.Tangoservice.TangoConfig> (native_p1, JniHandleOwnership.DoNotTransfer);
				int __ret = __this.Connect (p0, p1);
				return __ret;
			}
#pragma warning restore 0169

			static IntPtr id_connect_Lcom_google_atap_tangoservice_ITangoListener_Lcom_google_atap_tangoservice_TangoConfig_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.atap.tangoservice']/class[@name='ITango.Stub.Proxy']/method[@name='connect' and count(parameter)=2 and parameter[1][@type='com.google.atap.tangoservice.ITangoListener'] and parameter[2][@type='com.google.atap.tangoservice.TangoConfig']]"
			[Register ("connect", "(Lcom/google/atap/tangoservice/ITangoListener;Lcom/google/atap/tangoservice/TangoConfig;)I", "GetConnect_Lcom_google_atap_tangoservice_ITangoListener_Lcom_google_atap_tangoservice_TangoConfig_Handler")]
			public virtual unsafe int Connect (global::Com.Google.Atap.Tangoservice.ITangoListener p0, global::Com.Google.Atap.Tangoservice.TangoConfig p1)
			{
				if (id_connect_Lcom_google_atap_tangoservice_ITangoListener_Lcom_google_atap_tangoservice_TangoConfig_ == IntPtr.Zero)
					id_connect_Lcom_google_atap_tangoservice_ITangoListener_Lcom_google_atap_tangoservice_TangoConfig_ = JNIEnv.GetMethodID (class_ref, "connect", "(Lcom/google/atap/tangoservice/ITangoListener;Lcom/google/atap/tangoservice/TangoConfig;)I");
				try {
					JValue* __args = stackalloc JValue [2];
					__args [0] = new JValue (p0);
					__args [1] = new JValue (p1);

					int __ret;
					if (GetType () == ThresholdType)
						__ret = JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_connect_Lcom_google_atap_tangoservice_ITangoListener_Lcom_google_atap_tangoservice_TangoConfig_, __args);
					else
						__ret = JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "connect", "(Lcom/google/atap/tangoservice/ITangoListener;Lcom/google/atap/tangoservice/TangoConfig;)I"), __args);
					return __ret;
				} finally {
				}
			}

			static Delegate cb_connectSurface_ILandroid_view_Surface_;
#pragma warning disable 0169
			static Delegate GetConnectSurface_ILandroid_view_Surface_Handler ()
			{
				if (cb_connectSurface_ILandroid_view_Surface_ == null)
					cb_connectSurface_ILandroid_view_Surface_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr, int>) n_ConnectSurface_ILandroid_view_Surface_);
				return cb_connectSurface_ILandroid_view_Surface_;
			}

			static int n_ConnectSurface_ILandroid_view_Surface_ (IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1)
			{
				global::Com.Google.Atap.Tangoservice.TangoStub.Proxy __this = global::Java.Lang.Object.GetObject<global::Com.Google.Atap.Tangoservice.TangoStub.Proxy> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Android.Views.Surface p1 = global::Java.Lang.Object.GetObject<global::Android.Views.Surface> (native_p1, JniHandleOwnership.DoNotTransfer);
				int __ret = __this.ConnectSurface (p0, p1);
				return __ret;
			}
#pragma warning restore 0169

			static IntPtr id_connectSurface_ILandroid_view_Surface_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.atap.tangoservice']/class[@name='ITango.Stub.Proxy']/method[@name='connectSurface' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='android.view.Surface']]"
			[Register ("connectSurface", "(ILandroid/view/Surface;)I", "GetConnectSurface_ILandroid_view_Surface_Handler")]
			public virtual unsafe int ConnectSurface (int p0, global::Android.Views.Surface p1)
			{
				if (id_connectSurface_ILandroid_view_Surface_ == IntPtr.Zero)
					id_connectSurface_ILandroid_view_Surface_ = JNIEnv.GetMethodID (class_ref, "connectSurface", "(ILandroid/view/Surface;)I");
				try {
					JValue* __args = stackalloc JValue [2];
					__args [0] = new JValue (p0);
					__args [1] = new JValue (p1);

					int __ret;
					if (GetType () == ThresholdType)
						__ret = JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_connectSurface_ILandroid_view_Surface_, __args);
					else
						__ret = JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "connectSurface", "(ILandroid/view/Surface;)I"), __args);
					return __ret;
				} finally {
				}
			}

			static Delegate cb_deleteAreaDescription_Ljava_lang_String_;
#pragma warning disable 0169
			static Delegate GetDeleteAreaDescription_Ljava_lang_String_Handler ()
			{
				if (cb_deleteAreaDescription_Ljava_lang_String_ == null)
					cb_deleteAreaDescription_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, int>) n_DeleteAreaDescription_Ljava_lang_String_);
				return cb_deleteAreaDescription_Ljava_lang_String_;
			}

			static int n_DeleteAreaDescription_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Google.Atap.Tangoservice.TangoStub.Proxy __this = global::Java.Lang.Object.GetObject<global::Com.Google.Atap.Tangoservice.TangoStub.Proxy> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
				int __ret = __this.DeleteAreaDescription (p0);
				return __ret;
			}
#pragma warning restore 0169

			static IntPtr id_deleteAreaDescription_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.atap.tangoservice']/class[@name='ITango.Stub.Proxy']/method[@name='deleteAreaDescription' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("deleteAreaDescription", "(Ljava/lang/String;)I", "GetDeleteAreaDescription_Ljava_lang_String_Handler")]
			public virtual unsafe int DeleteAreaDescription (string p0)
			{
				if (id_deleteAreaDescription_Ljava_lang_String_ == IntPtr.Zero)
					id_deleteAreaDescription_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "deleteAreaDescription", "(Ljava/lang/String;)I");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_p0);

					int __ret;
					if (GetType () == ThresholdType)
						__ret = JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_deleteAreaDescription_Ljava_lang_String_, __args);
					else
						__ret = JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "deleteAreaDescription", "(Ljava/lang/String;)I"), __args);
					return __ret;
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

			static Delegate cb_deleteDataset_Ljava_lang_String_;
#pragma warning disable 0169
			static Delegate GetDeleteDataset_Ljava_lang_String_Handler ()
			{
				if (cb_deleteDataset_Ljava_lang_String_ == null)
					cb_deleteDataset_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, int>) n_DeleteDataset_Ljava_lang_String_);
				return cb_deleteDataset_Ljava_lang_String_;
			}

			static int n_DeleteDataset_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Google.Atap.Tangoservice.TangoStub.Proxy __this = global::Java.Lang.Object.GetObject<global::Com.Google.Atap.Tangoservice.TangoStub.Proxy> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
				int __ret = __this.DeleteDataset (p0);
				return __ret;
			}
#pragma warning restore 0169

			static IntPtr id_deleteDataset_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.atap.tangoservice']/class[@name='ITango.Stub.Proxy']/method[@name='deleteDataset' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("deleteDataset", "(Ljava/lang/String;)I", "GetDeleteDataset_Ljava_lang_String_Handler")]
			public virtual unsafe int DeleteDataset (string p0)
			{
				if (id_deleteDataset_Ljava_lang_String_ == IntPtr.Zero)
					id_deleteDataset_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "deleteDataset", "(Ljava/lang/String;)I");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_p0);

					int __ret;
					if (GetType () == ThresholdType)
						__ret = JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_deleteDataset_Ljava_lang_String_, __args);
					else
						__ret = JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "deleteDataset", "(Ljava/lang/String;)I"), __args);
					return __ret;
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

			static Delegate cb_disconnect;
#pragma warning disable 0169
			static Delegate GetDisconnectHandler ()
			{
				if (cb_disconnect == null)
					cb_disconnect = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_Disconnect);
				return cb_disconnect;
			}

			static int n_Disconnect (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Google.Atap.Tangoservice.TangoStub.Proxy __this = global::Java.Lang.Object.GetObject<global::Com.Google.Atap.Tangoservice.TangoStub.Proxy> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return __this.Disconnect ();
			}
#pragma warning restore 0169

			static IntPtr id_disconnect;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.atap.tangoservice']/class[@name='ITango.Stub.Proxy']/method[@name='disconnect' and count(parameter)=0]"
			[Register ("disconnect", "()I", "GetDisconnectHandler")]
			public virtual unsafe int Disconnect ()
			{
				if (id_disconnect == IntPtr.Zero)
					id_disconnect = JNIEnv.GetMethodID (class_ref, "disconnect", "()I");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_disconnect);
					else
						return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "disconnect", "()I"));
				} finally {
				}
			}

			static Delegate cb_disconnectSurface_I;
#pragma warning disable 0169
			static Delegate GetDisconnectSurface_IHandler ()
			{
				if (cb_disconnectSurface_I == null)
					cb_disconnectSurface_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, int>) n_DisconnectSurface_I);
				return cb_disconnectSurface_I;
			}

			static int n_DisconnectSurface_I (IntPtr jnienv, IntPtr native__this, int p0)
			{
				global::Com.Google.Atap.Tangoservice.TangoStub.Proxy __this = global::Java.Lang.Object.GetObject<global::Com.Google.Atap.Tangoservice.TangoStub.Proxy> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return __this.DisconnectSurface (p0);
			}
#pragma warning restore 0169

			static IntPtr id_disconnectSurface_I;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.atap.tangoservice']/class[@name='ITango.Stub.Proxy']/method[@name='disconnectSurface' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("disconnectSurface", "(I)I", "GetDisconnectSurface_IHandler")]
			public virtual unsafe int DisconnectSurface (int p0)
			{
				if (id_disconnectSurface_I == IntPtr.Zero)
					id_disconnectSurface_I = JNIEnv.GetMethodID (class_ref, "disconnectSurface", "(I)I");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (p0);

					if (GetType () == ThresholdType)
						return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_disconnectSurface_I, __args);
					else
						return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "disconnectSurface", "(I)I"), __args);
				} finally {
				}
			}

			static Delegate cb_exportAreaDescriptionFile_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
			static Delegate GetExportAreaDescriptionFile_Ljava_lang_String_Ljava_lang_String_Handler ()
			{
				if (cb_exportAreaDescriptionFile_Ljava_lang_String_Ljava_lang_String_ == null)
					cb_exportAreaDescriptionFile_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, int>) n_ExportAreaDescriptionFile_Ljava_lang_String_Ljava_lang_String_);
				return cb_exportAreaDescriptionFile_Ljava_lang_String_Ljava_lang_String_;
			}

			static int n_ExportAreaDescriptionFile_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
			{
				global::Com.Google.Atap.Tangoservice.TangoStub.Proxy __this = global::Java.Lang.Object.GetObject<global::Com.Google.Atap.Tangoservice.TangoStub.Proxy> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
				string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
				int __ret = __this.ExportAreaDescriptionFile (p0, p1);
				return __ret;
			}
#pragma warning restore 0169

			static IntPtr id_exportAreaDescriptionFile_Ljava_lang_String_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.atap.tangoservice']/class[@name='ITango.Stub.Proxy']/method[@name='exportAreaDescriptionFile' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
			[Register ("exportAreaDescriptionFile", "(Ljava/lang/String;Ljava/lang/String;)I", "GetExportAreaDescriptionFile_Ljava_lang_String_Ljava_lang_String_Handler")]
			public virtual unsafe int ExportAreaDescriptionFile (string p0, string p1)
			{
				if (id_exportAreaDescriptionFile_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
					id_exportAreaDescriptionFile_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "exportAreaDescriptionFile", "(Ljava/lang/String;Ljava/lang/String;)I");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				IntPtr native_p1 = JNIEnv.NewString (p1);
				try {
					JValue* __args = stackalloc JValue [2];
					__args [0] = new JValue (native_p0);
					__args [1] = new JValue (native_p1);

					int __ret;
					if (GetType () == ThresholdType)
						__ret = JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_exportAreaDescriptionFile_Ljava_lang_String_Ljava_lang_String_, __args);
					else
						__ret = JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "exportAreaDescriptionFile", "(Ljava/lang/String;Ljava/lang/String;)I"), __args);
					return __ret;
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
					JNIEnv.DeleteLocalRef (native_p1);
				}
			}

			static Delegate cb_foiRequest_Lcom_google_atap_tangoservice_fois_FoiRequest_;
#pragma warning disable 0169
			static Delegate GetFoiRequest_Lcom_google_atap_tangoservice_fois_FoiRequest_Handler ()
			{
				if (cb_foiRequest_Lcom_google_atap_tangoservice_fois_FoiRequest_ == null)
					cb_foiRequest_Lcom_google_atap_tangoservice_fois_FoiRequest_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, int>) n_FoiRequest_Lcom_google_atap_tangoservice_fois_FoiRequest_);
				return cb_foiRequest_Lcom_google_atap_tangoservice_fois_FoiRequest_;
			}

			static int n_FoiRequest_Lcom_google_atap_tangoservice_fois_FoiRequest_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Google.Atap.Tangoservice.TangoStub.Proxy __this = global::Java.Lang.Object.GetObject<global::Com.Google.Atap.Tangoservice.TangoStub.Proxy> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Com.Google.Atap.Tangoservice.Fois.FoiRequest p0 = global::Java.Lang.Object.GetObject<global::Com.Google.Atap.Tangoservice.Fois.FoiRequest> (native_p0, JniHandleOwnership.DoNotTransfer);
				int __ret = __this.FoiRequest (p0);
				return __ret;
			}
#pragma warning restore 0169

			static IntPtr id_foiRequest_Lcom_google_atap_tangoservice_fois_FoiRequest_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.atap.tangoservice']/class[@name='ITango.Stub.Proxy']/method[@name='foiRequest' and count(parameter)=1 and parameter[1][@type='com.google.atap.tangoservice.fois.FoiRequest']]"
			[Register ("foiRequest", "(Lcom/google/atap/tangoservice/fois/FoiRequest;)I", "GetFoiRequest_Lcom_google_atap_tangoservice_fois_FoiRequest_Handler")]
			public virtual unsafe int FoiRequest (global::Com.Google.Atap.Tangoservice.Fois.FoiRequest p0)
			{
				if (id_foiRequest_Lcom_google_atap_tangoservice_fois_FoiRequest_ == IntPtr.Zero)
					id_foiRequest_Lcom_google_atap_tangoservice_fois_FoiRequest_ = JNIEnv.GetMethodID (class_ref, "foiRequest", "(Lcom/google/atap/tangoservice/fois/FoiRequest;)I");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (p0);

					int __ret;
					if (GetType () == ThresholdType)
						__ret = JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_foiRequest_Lcom_google_atap_tangoservice_fois_FoiRequest_, __args);
					else
						__ret = JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "foiRequest", "(Lcom/google/atap/tangoservice/fois/FoiRequest;)I"), __args);
					return __ret;
				} finally {
				}
			}

			static Delegate cb_getAreaDescriptionUuidList_Ljava_util_List_;
#pragma warning disable 0169
			static Delegate GetGetAreaDescriptionUuidList_Ljava_util_List_Handler ()
			{
				if (cb_getAreaDescriptionUuidList_Ljava_util_List_ == null)
					cb_getAreaDescriptionUuidList_Ljava_util_List_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, int>) n_GetAreaDescriptionUuidList_Ljava_util_List_);
				return cb_getAreaDescriptionUuidList_Ljava_util_List_;
			}

			static int n_GetAreaDescriptionUuidList_Ljava_util_List_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Google.Atap.Tangoservice.TangoStub.Proxy __this = global::Java.Lang.Object.GetObject<global::Com.Google.Atap.Tangoservice.TangoStub.Proxy> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				var p0 = global::Android.Runtime.JavaList<string>.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
				int __ret = __this.GetAreaDescriptionUuidList (p0);
				return __ret;
			}
#pragma warning restore 0169

			static IntPtr id_getAreaDescriptionUuidList_Ljava_util_List_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.atap.tangoservice']/class[@name='ITango.Stub.Proxy']/method[@name='getAreaDescriptionUuidList' and count(parameter)=1 and parameter[1][@type='java.util.List&lt;java.lang.String&gt;']]"
			[Register ("getAreaDescriptionUuidList", "(Ljava/util/List;)I", "GetGetAreaDescriptionUuidList_Ljava_util_List_Handler")]
			public virtual unsafe int GetAreaDescriptionUuidList (global::System.Collections.Generic.IList<string> p0)
			{
				if (id_getAreaDescriptionUuidList_Ljava_util_List_ == IntPtr.Zero)
					id_getAreaDescriptionUuidList_Ljava_util_List_ = JNIEnv.GetMethodID (class_ref, "getAreaDescriptionUuidList", "(Ljava/util/List;)I");
				IntPtr native_p0 = global::Android.Runtime.JavaList<string>.ToLocalJniHandle (p0);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_p0);

					int __ret;
					if (GetType () == ThresholdType)
						__ret = JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getAreaDescriptionUuidList_Ljava_util_List_, __args);
					else
						__ret = JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getAreaDescriptionUuidList", "(Ljava/util/List;)I"), __args);
					return __ret;
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

			static Delegate cb_getCameraIntrinsics_ILcom_google_atap_tangoservice_TangoCameraIntrinsics_;
#pragma warning disable 0169
			static Delegate GetGetCameraIntrinsics_ILcom_google_atap_tangoservice_TangoCameraIntrinsics_Handler ()
			{
				if (cb_getCameraIntrinsics_ILcom_google_atap_tangoservice_TangoCameraIntrinsics_ == null)
					cb_getCameraIntrinsics_ILcom_google_atap_tangoservice_TangoCameraIntrinsics_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr, int>) n_GetCameraIntrinsics_ILcom_google_atap_tangoservice_TangoCameraIntrinsics_);
				return cb_getCameraIntrinsics_ILcom_google_atap_tangoservice_TangoCameraIntrinsics_;
			}

			static int n_GetCameraIntrinsics_ILcom_google_atap_tangoservice_TangoCameraIntrinsics_ (IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1)
			{
				global::Com.Google.Atap.Tangoservice.TangoStub.Proxy __this = global::Java.Lang.Object.GetObject<global::Com.Google.Atap.Tangoservice.TangoStub.Proxy> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Com.Google.Atap.Tangoservice.TangoCameraIntrinsics p1 = global::Java.Lang.Object.GetObject<global::Com.Google.Atap.Tangoservice.TangoCameraIntrinsics> (native_p1, JniHandleOwnership.DoNotTransfer);
				int __ret = __this.GetCameraIntrinsics (p0, p1);
				return __ret;
			}
#pragma warning restore 0169

			static IntPtr id_getCameraIntrinsics_ILcom_google_atap_tangoservice_TangoCameraIntrinsics_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.atap.tangoservice']/class[@name='ITango.Stub.Proxy']/method[@name='getCameraIntrinsics' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='com.google.atap.tangoservice.TangoCameraIntrinsics']]"
			[Register ("getCameraIntrinsics", "(ILcom/google/atap/tangoservice/TangoCameraIntrinsics;)I", "GetGetCameraIntrinsics_ILcom_google_atap_tangoservice_TangoCameraIntrinsics_Handler")]
			public virtual unsafe int GetCameraIntrinsics (int p0, global::Com.Google.Atap.Tangoservice.TangoCameraIntrinsics p1)
			{
				if (id_getCameraIntrinsics_ILcom_google_atap_tangoservice_TangoCameraIntrinsics_ == IntPtr.Zero)
					id_getCameraIntrinsics_ILcom_google_atap_tangoservice_TangoCameraIntrinsics_ = JNIEnv.GetMethodID (class_ref, "getCameraIntrinsics", "(ILcom/google/atap/tangoservice/TangoCameraIntrinsics;)I");
				try {
					JValue* __args = stackalloc JValue [2];
					__args [0] = new JValue (p0);
					__args [1] = new JValue (p1);

					int __ret;
					if (GetType () == ThresholdType)
						__ret = JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getCameraIntrinsics_ILcom_google_atap_tangoservice_TangoCameraIntrinsics_, __args);
					else
						__ret = JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getCameraIntrinsics", "(ILcom/google/atap/tangoservice/TangoCameraIntrinsics;)I"), __args);
					return __ret;
				} finally {
				}
			}

			static Delegate cb_getConfig_ILcom_google_atap_tangoservice_TangoConfig_;
#pragma warning disable 0169
			static Delegate GetGetConfig_ILcom_google_atap_tangoservice_TangoConfig_Handler ()
			{
				if (cb_getConfig_ILcom_google_atap_tangoservice_TangoConfig_ == null)
					cb_getConfig_ILcom_google_atap_tangoservice_TangoConfig_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr, int>) n_GetConfig_ILcom_google_atap_tangoservice_TangoConfig_);
				return cb_getConfig_ILcom_google_atap_tangoservice_TangoConfig_;
			}

			static int n_GetConfig_ILcom_google_atap_tangoservice_TangoConfig_ (IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1)
			{
				global::Com.Google.Atap.Tangoservice.TangoStub.Proxy __this = global::Java.Lang.Object.GetObject<global::Com.Google.Atap.Tangoservice.TangoStub.Proxy> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Com.Google.Atap.Tangoservice.TangoConfig p1 = global::Java.Lang.Object.GetObject<global::Com.Google.Atap.Tangoservice.TangoConfig> (native_p1, JniHandleOwnership.DoNotTransfer);
				int __ret = __this.GetConfig (p0, p1);
				return __ret;
			}
#pragma warning restore 0169

			static IntPtr id_getConfig_ILcom_google_atap_tangoservice_TangoConfig_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.atap.tangoservice']/class[@name='ITango.Stub.Proxy']/method[@name='getConfig' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='com.google.atap.tangoservice.TangoConfig']]"
			[Register ("getConfig", "(ILcom/google/atap/tangoservice/TangoConfig;)I", "GetGetConfig_ILcom_google_atap_tangoservice_TangoConfig_Handler")]
			public virtual unsafe int GetConfig (int p0, global::Com.Google.Atap.Tangoservice.TangoConfig p1)
			{
				if (id_getConfig_ILcom_google_atap_tangoservice_TangoConfig_ == IntPtr.Zero)
					id_getConfig_ILcom_google_atap_tangoservice_TangoConfig_ = JNIEnv.GetMethodID (class_ref, "getConfig", "(ILcom/google/atap/tangoservice/TangoConfig;)I");
				try {
					JValue* __args = stackalloc JValue [2];
					__args [0] = new JValue (p0);
					__args [1] = new JValue (p1);

					int __ret;
					if (GetType () == ThresholdType)
						__ret = JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getConfig_ILcom_google_atap_tangoservice_TangoConfig_, __args);
					else
						__ret = JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getConfig", "(ILcom/google/atap/tangoservice/TangoConfig;)I"), __args);
					return __ret;
				} finally {
				}
			}

			static Delegate cb_getCurrentDatasetUuid_Ljava_util_List_;
#pragma warning disable 0169
			static Delegate GetGetCurrentDatasetUuid_Ljava_util_List_Handler ()
			{
				if (cb_getCurrentDatasetUuid_Ljava_util_List_ == null)
					cb_getCurrentDatasetUuid_Ljava_util_List_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, int>) n_GetCurrentDatasetUuid_Ljava_util_List_);
				return cb_getCurrentDatasetUuid_Ljava_util_List_;
			}

			static int n_GetCurrentDatasetUuid_Ljava_util_List_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Google.Atap.Tangoservice.TangoStub.Proxy __this = global::Java.Lang.Object.GetObject<global::Com.Google.Atap.Tangoservice.TangoStub.Proxy> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				var p0 = global::Android.Runtime.JavaList<string>.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
				int __ret = __this.GetCurrentDatasetUuid (p0);
				return __ret;
			}
#pragma warning restore 0169

			static IntPtr id_getCurrentDatasetUuid_Ljava_util_List_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.atap.tangoservice']/class[@name='ITango.Stub.Proxy']/method[@name='getCurrentDatasetUuid' and count(parameter)=1 and parameter[1][@type='java.util.List&lt;java.lang.String&gt;']]"
			[Register ("getCurrentDatasetUuid", "(Ljava/util/List;)I", "GetGetCurrentDatasetUuid_Ljava_util_List_Handler")]
			public virtual unsafe int GetCurrentDatasetUuid (global::System.Collections.Generic.IList<string> p0)
			{
				if (id_getCurrentDatasetUuid_Ljava_util_List_ == IntPtr.Zero)
					id_getCurrentDatasetUuid_Ljava_util_List_ = JNIEnv.GetMethodID (class_ref, "getCurrentDatasetUuid", "(Ljava/util/List;)I");
				IntPtr native_p0 = global::Android.Runtime.JavaList<string>.ToLocalJniHandle (p0);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_p0);

					int __ret;
					if (GetType () == ThresholdType)
						__ret = JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getCurrentDatasetUuid_Ljava_util_List_, __args);
					else
						__ret = JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getCurrentDatasetUuid", "(Ljava/util/List;)I"), __args);
					return __ret;
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

			static Delegate cb_getDatasetUuids_Ljava_util_List_;
#pragma warning disable 0169
			static Delegate GetGetDatasetUuids_Ljava_util_List_Handler ()
			{
				if (cb_getDatasetUuids_Ljava_util_List_ == null)
					cb_getDatasetUuids_Ljava_util_List_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, int>) n_GetDatasetUuids_Ljava_util_List_);
				return cb_getDatasetUuids_Ljava_util_List_;
			}

			static int n_GetDatasetUuids_Ljava_util_List_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Google.Atap.Tangoservice.TangoStub.Proxy __this = global::Java.Lang.Object.GetObject<global::Com.Google.Atap.Tangoservice.TangoStub.Proxy> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				var p0 = global::Android.Runtime.JavaList<string>.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
				int __ret = __this.GetDatasetUuids (p0);
				return __ret;
			}
#pragma warning restore 0169

			static IntPtr id_getDatasetUuids_Ljava_util_List_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.atap.tangoservice']/class[@name='ITango.Stub.Proxy']/method[@name='getDatasetUuids' and count(parameter)=1 and parameter[1][@type='java.util.List&lt;java.lang.String&gt;']]"
			[Register ("getDatasetUuids", "(Ljava/util/List;)I", "GetGetDatasetUuids_Ljava_util_List_Handler")]
			public virtual unsafe int GetDatasetUuids (global::System.Collections.Generic.IList<string> p0)
			{
				if (id_getDatasetUuids_Ljava_util_List_ == IntPtr.Zero)
					id_getDatasetUuids_Ljava_util_List_ = JNIEnv.GetMethodID (class_ref, "getDatasetUuids", "(Ljava/util/List;)I");
				IntPtr native_p0 = global::Android.Runtime.JavaList<string>.ToLocalJniHandle (p0);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_p0);

					int __ret;
					if (GetType () == ThresholdType)
						__ret = JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getDatasetUuids_Ljava_util_List_, __args);
					else
						__ret = JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getDatasetUuids", "(Ljava/util/List;)I"), __args);
					return __ret;
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

			static Delegate cb_getPoseAtTime2_DLjava_lang_String_Ljava_lang_String_Lcom_google_atap_tangoservice_TangoPoseData_;
#pragma warning disable 0169
			static Delegate GetGetPoseAtTime2_DLjava_lang_String_Ljava_lang_String_Lcom_google_atap_tangoservice_TangoPoseData_Handler ()
			{
				if (cb_getPoseAtTime2_DLjava_lang_String_Ljava_lang_String_Lcom_google_atap_tangoservice_TangoPoseData_ == null)
					cb_getPoseAtTime2_DLjava_lang_String_Ljava_lang_String_Lcom_google_atap_tangoservice_TangoPoseData_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, double, IntPtr, IntPtr, IntPtr, int>) n_GetPoseAtTime2_DLjava_lang_String_Ljava_lang_String_Lcom_google_atap_tangoservice_TangoPoseData_);
				return cb_getPoseAtTime2_DLjava_lang_String_Ljava_lang_String_Lcom_google_atap_tangoservice_TangoPoseData_;
			}

			static int n_GetPoseAtTime2_DLjava_lang_String_Ljava_lang_String_Lcom_google_atap_tangoservice_TangoPoseData_ (IntPtr jnienv, IntPtr native__this, double p0, IntPtr native_p1, IntPtr native_p2, IntPtr native_p3)
			{
				global::Com.Google.Atap.Tangoservice.TangoStub.Proxy __this = global::Java.Lang.Object.GetObject<global::Com.Google.Atap.Tangoservice.TangoStub.Proxy> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
				string p2 = JNIEnv.GetString (native_p2, JniHandleOwnership.DoNotTransfer);
				global::Com.Google.Atap.Tangoservice.TangoPoseData p3 = global::Java.Lang.Object.GetObject<global::Com.Google.Atap.Tangoservice.TangoPoseData> (native_p3, JniHandleOwnership.DoNotTransfer);
				int __ret = __this.GetPoseAtTime2 (p0, p1, p2, p3);
				return __ret;
			}
#pragma warning restore 0169

			static IntPtr id_getPoseAtTime2_DLjava_lang_String_Ljava_lang_String_Lcom_google_atap_tangoservice_TangoPoseData_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.atap.tangoservice']/class[@name='ITango.Stub.Proxy']/method[@name='getPoseAtTime2' and count(parameter)=4 and parameter[1][@type='double'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='com.google.atap.tangoservice.TangoPoseData']]"
			[Register ("getPoseAtTime2", "(DLjava/lang/String;Ljava/lang/String;Lcom/google/atap/tangoservice/TangoPoseData;)I", "GetGetPoseAtTime2_DLjava_lang_String_Ljava_lang_String_Lcom_google_atap_tangoservice_TangoPoseData_Handler")]
			public virtual unsafe int GetPoseAtTime2 (double p0, string p1, string p2, global::Com.Google.Atap.Tangoservice.TangoPoseData p3)
			{
				if (id_getPoseAtTime2_DLjava_lang_String_Ljava_lang_String_Lcom_google_atap_tangoservice_TangoPoseData_ == IntPtr.Zero)
					id_getPoseAtTime2_DLjava_lang_String_Ljava_lang_String_Lcom_google_atap_tangoservice_TangoPoseData_ = JNIEnv.GetMethodID (class_ref, "getPoseAtTime2", "(DLjava/lang/String;Ljava/lang/String;Lcom/google/atap/tangoservice/TangoPoseData;)I");
				IntPtr native_p1 = JNIEnv.NewString (p1);
				IntPtr native_p2 = JNIEnv.NewString (p2);
				try {
					JValue* __args = stackalloc JValue [4];
					__args [0] = new JValue (p0);
					__args [1] = new JValue (native_p1);
					__args [2] = new JValue (native_p2);
					__args [3] = new JValue (p3);

					int __ret;
					if (GetType () == ThresholdType)
						__ret = JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getPoseAtTime2_DLjava_lang_String_Ljava_lang_String_Lcom_google_atap_tangoservice_TangoPoseData_, __args);
					else
						__ret = JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getPoseAtTime2", "(DLjava/lang/String;Ljava/lang/String;Lcom/google/atap/tangoservice/TangoPoseData;)I"), __args);
					return __ret;
				} finally {
					JNIEnv.DeleteLocalRef (native_p1);
					JNIEnv.DeleteLocalRef (native_p2);
				}
			}

			static Delegate cb_getPoseAtTime_DLcom_google_atap_tangoservice_TangoCoordinateFramePair_Lcom_google_atap_tangoservice_TangoPoseData_;
#pragma warning disable 0169
			static Delegate GetGetPoseAtTime_DLcom_google_atap_tangoservice_TangoCoordinateFramePair_Lcom_google_atap_tangoservice_TangoPoseData_Handler ()
			{
				if (cb_getPoseAtTime_DLcom_google_atap_tangoservice_TangoCoordinateFramePair_Lcom_google_atap_tangoservice_TangoPoseData_ == null)
					cb_getPoseAtTime_DLcom_google_atap_tangoservice_TangoCoordinateFramePair_Lcom_google_atap_tangoservice_TangoPoseData_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, double, IntPtr, IntPtr, int>) n_GetPoseAtTime_DLcom_google_atap_tangoservice_TangoCoordinateFramePair_Lcom_google_atap_tangoservice_TangoPoseData_);
				return cb_getPoseAtTime_DLcom_google_atap_tangoservice_TangoCoordinateFramePair_Lcom_google_atap_tangoservice_TangoPoseData_;
			}

			static int n_GetPoseAtTime_DLcom_google_atap_tangoservice_TangoCoordinateFramePair_Lcom_google_atap_tangoservice_TangoPoseData_ (IntPtr jnienv, IntPtr native__this, double p0, IntPtr native_p1, IntPtr native_p2)
			{
				global::Com.Google.Atap.Tangoservice.TangoStub.Proxy __this = global::Java.Lang.Object.GetObject<global::Com.Google.Atap.Tangoservice.TangoStub.Proxy> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Com.Google.Atap.Tangoservice.TangoCoordinateFramePair p1 = global::Java.Lang.Object.GetObject<global::Com.Google.Atap.Tangoservice.TangoCoordinateFramePair> (native_p1, JniHandleOwnership.DoNotTransfer);
				global::Com.Google.Atap.Tangoservice.TangoPoseData p2 = global::Java.Lang.Object.GetObject<global::Com.Google.Atap.Tangoservice.TangoPoseData> (native_p2, JniHandleOwnership.DoNotTransfer);
				int __ret = __this.GetPoseAtTime (p0, p1, p2);
				return __ret;
			}
#pragma warning restore 0169

			static IntPtr id_getPoseAtTime_DLcom_google_atap_tangoservice_TangoCoordinateFramePair_Lcom_google_atap_tangoservice_TangoPoseData_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.atap.tangoservice']/class[@name='ITango.Stub.Proxy']/method[@name='getPoseAtTime' and count(parameter)=3 and parameter[1][@type='double'] and parameter[2][@type='com.google.atap.tangoservice.TangoCoordinateFramePair'] and parameter[3][@type='com.google.atap.tangoservice.TangoPoseData']]"
			[Register ("getPoseAtTime", "(DLcom/google/atap/tangoservice/TangoCoordinateFramePair;Lcom/google/atap/tangoservice/TangoPoseData;)I", "GetGetPoseAtTime_DLcom_google_atap_tangoservice_TangoCoordinateFramePair_Lcom_google_atap_tangoservice_TangoPoseData_Handler")]
			public virtual unsafe int GetPoseAtTime (double p0, global::Com.Google.Atap.Tangoservice.TangoCoordinateFramePair p1, global::Com.Google.Atap.Tangoservice.TangoPoseData p2)
			{
				if (id_getPoseAtTime_DLcom_google_atap_tangoservice_TangoCoordinateFramePair_Lcom_google_atap_tangoservice_TangoPoseData_ == IntPtr.Zero)
					id_getPoseAtTime_DLcom_google_atap_tangoservice_TangoCoordinateFramePair_Lcom_google_atap_tangoservice_TangoPoseData_ = JNIEnv.GetMethodID (class_ref, "getPoseAtTime", "(DLcom/google/atap/tangoservice/TangoCoordinateFramePair;Lcom/google/atap/tangoservice/TangoPoseData;)I");
				try {
					JValue* __args = stackalloc JValue [3];
					__args [0] = new JValue (p0);
					__args [1] = new JValue (p1);
					__args [2] = new JValue (p2);

					int __ret;
					if (GetType () == ThresholdType)
						__ret = JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getPoseAtTime_DLcom_google_atap_tangoservice_TangoCoordinateFramePair_Lcom_google_atap_tangoservice_TangoPoseData_, __args);
					else
						__ret = JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getPoseAtTime", "(DLcom/google/atap/tangoservice/TangoCoordinateFramePair;Lcom/google/atap/tangoservice/TangoPoseData;)I"), __args);
					return __ret;
				} finally {
				}
			}

			static Delegate cb_importAreaDescriptionFile_Ljava_util_List_Ljava_lang_String_;
#pragma warning disable 0169
			static Delegate GetImportAreaDescriptionFile_Ljava_util_List_Ljava_lang_String_Handler ()
			{
				if (cb_importAreaDescriptionFile_Ljava_util_List_Ljava_lang_String_ == null)
					cb_importAreaDescriptionFile_Ljava_util_List_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, int>) n_ImportAreaDescriptionFile_Ljava_util_List_Ljava_lang_String_);
				return cb_importAreaDescriptionFile_Ljava_util_List_Ljava_lang_String_;
			}

			static int n_ImportAreaDescriptionFile_Ljava_util_List_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
			{
				global::Com.Google.Atap.Tangoservice.TangoStub.Proxy __this = global::Java.Lang.Object.GetObject<global::Com.Google.Atap.Tangoservice.TangoStub.Proxy> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				var p0 = global::Android.Runtime.JavaList<string>.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
				string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
				int __ret = __this.ImportAreaDescriptionFile (p0, p1);
				return __ret;
			}
#pragma warning restore 0169

			static IntPtr id_importAreaDescriptionFile_Ljava_util_List_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.atap.tangoservice']/class[@name='ITango.Stub.Proxy']/method[@name='importAreaDescriptionFile' and count(parameter)=2 and parameter[1][@type='java.util.List&lt;java.lang.String&gt;'] and parameter[2][@type='java.lang.String']]"
			[Register ("importAreaDescriptionFile", "(Ljava/util/List;Ljava/lang/String;)I", "GetImportAreaDescriptionFile_Ljava_util_List_Ljava_lang_String_Handler")]
			public virtual unsafe int ImportAreaDescriptionFile (global::System.Collections.Generic.IList<string> p0, string p1)
			{
				if (id_importAreaDescriptionFile_Ljava_util_List_Ljava_lang_String_ == IntPtr.Zero)
					id_importAreaDescriptionFile_Ljava_util_List_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "importAreaDescriptionFile", "(Ljava/util/List;Ljava/lang/String;)I");
				IntPtr native_p0 = global::Android.Runtime.JavaList<string>.ToLocalJniHandle (p0);
				IntPtr native_p1 = JNIEnv.NewString (p1);
				try {
					JValue* __args = stackalloc JValue [2];
					__args [0] = new JValue (native_p0);
					__args [1] = new JValue (native_p1);

					int __ret;
					if (GetType () == ThresholdType)
						__ret = JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_importAreaDescriptionFile_Ljava_util_List_Ljava_lang_String_, __args);
					else
						__ret = JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "importAreaDescriptionFile", "(Ljava/util/List;Ljava/lang/String;)I"), __args);
					return __ret;
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
					JNIEnv.DeleteLocalRef (native_p1);
				}
			}

			static Delegate cb_loadAreaDescriptionMetaData_Ljava_lang_String_Lcom_google_atap_tangoservice_TangoAreaDescriptionMetaData_;
#pragma warning disable 0169
			static Delegate GetLoadAreaDescriptionMetaData_Ljava_lang_String_Lcom_google_atap_tangoservice_TangoAreaDescriptionMetaData_Handler ()
			{
				if (cb_loadAreaDescriptionMetaData_Ljava_lang_String_Lcom_google_atap_tangoservice_TangoAreaDescriptionMetaData_ == null)
					cb_loadAreaDescriptionMetaData_Ljava_lang_String_Lcom_google_atap_tangoservice_TangoAreaDescriptionMetaData_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, int>) n_LoadAreaDescriptionMetaData_Ljava_lang_String_Lcom_google_atap_tangoservice_TangoAreaDescriptionMetaData_);
				return cb_loadAreaDescriptionMetaData_Ljava_lang_String_Lcom_google_atap_tangoservice_TangoAreaDescriptionMetaData_;
			}

			static int n_LoadAreaDescriptionMetaData_Ljava_lang_String_Lcom_google_atap_tangoservice_TangoAreaDescriptionMetaData_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
			{
				global::Com.Google.Atap.Tangoservice.TangoStub.Proxy __this = global::Java.Lang.Object.GetObject<global::Com.Google.Atap.Tangoservice.TangoStub.Proxy> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
				global::Com.Google.Atap.Tangoservice.TangoAreaDescriptionMetaData p1 = global::Java.Lang.Object.GetObject<global::Com.Google.Atap.Tangoservice.TangoAreaDescriptionMetaData> (native_p1, JniHandleOwnership.DoNotTransfer);
				int __ret = __this.LoadAreaDescriptionMetaData (p0, p1);
				return __ret;
			}
#pragma warning restore 0169

			static IntPtr id_loadAreaDescriptionMetaData_Ljava_lang_String_Lcom_google_atap_tangoservice_TangoAreaDescriptionMetaData_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.atap.tangoservice']/class[@name='ITango.Stub.Proxy']/method[@name='loadAreaDescriptionMetaData' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='com.google.atap.tangoservice.TangoAreaDescriptionMetaData']]"
			[Register ("loadAreaDescriptionMetaData", "(Ljava/lang/String;Lcom/google/atap/tangoservice/TangoAreaDescriptionMetaData;)I", "GetLoadAreaDescriptionMetaData_Ljava_lang_String_Lcom_google_atap_tangoservice_TangoAreaDescriptionMetaData_Handler")]
			public virtual unsafe int LoadAreaDescriptionMetaData (string p0, global::Com.Google.Atap.Tangoservice.TangoAreaDescriptionMetaData p1)
			{
				if (id_loadAreaDescriptionMetaData_Ljava_lang_String_Lcom_google_atap_tangoservice_TangoAreaDescriptionMetaData_ == IntPtr.Zero)
					id_loadAreaDescriptionMetaData_Ljava_lang_String_Lcom_google_atap_tangoservice_TangoAreaDescriptionMetaData_ = JNIEnv.GetMethodID (class_ref, "loadAreaDescriptionMetaData", "(Ljava/lang/String;Lcom/google/atap/tangoservice/TangoAreaDescriptionMetaData;)I");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				try {
					JValue* __args = stackalloc JValue [2];
					__args [0] = new JValue (native_p0);
					__args [1] = new JValue (p1);

					int __ret;
					if (GetType () == ThresholdType)
						__ret = JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_loadAreaDescriptionMetaData_Ljava_lang_String_Lcom_google_atap_tangoservice_TangoAreaDescriptionMetaData_, __args);
					else
						__ret = JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "loadAreaDescriptionMetaData", "(Ljava/lang/String;Lcom/google/atap/tangoservice/TangoAreaDescriptionMetaData;)I"), __args);
					return __ret;
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

			static Delegate cb_reportApiUsage_Lcom_google_atap_tangoservice_TangoConfig_;
#pragma warning disable 0169
			static Delegate GetReportApiUsage_Lcom_google_atap_tangoservice_TangoConfig_Handler ()
			{
				if (cb_reportApiUsage_Lcom_google_atap_tangoservice_TangoConfig_ == null)
					cb_reportApiUsage_Lcom_google_atap_tangoservice_TangoConfig_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, int>) n_ReportApiUsage_Lcom_google_atap_tangoservice_TangoConfig_);
				return cb_reportApiUsage_Lcom_google_atap_tangoservice_TangoConfig_;
			}

			static int n_ReportApiUsage_Lcom_google_atap_tangoservice_TangoConfig_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Google.Atap.Tangoservice.TangoStub.Proxy __this = global::Java.Lang.Object.GetObject<global::Com.Google.Atap.Tangoservice.TangoStub.Proxy> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Com.Google.Atap.Tangoservice.TangoConfig p0 = global::Java.Lang.Object.GetObject<global::Com.Google.Atap.Tangoservice.TangoConfig> (native_p0, JniHandleOwnership.DoNotTransfer);
				int __ret = __this.ReportApiUsage (p0);
				return __ret;
			}
#pragma warning restore 0169

			static IntPtr id_reportApiUsage_Lcom_google_atap_tangoservice_TangoConfig_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.atap.tangoservice']/class[@name='ITango.Stub.Proxy']/method[@name='reportApiUsage' and count(parameter)=1 and parameter[1][@type='com.google.atap.tangoservice.TangoConfig']]"
			[Register ("reportApiUsage", "(Lcom/google/atap/tangoservice/TangoConfig;)I", "GetReportApiUsage_Lcom_google_atap_tangoservice_TangoConfig_Handler")]
			public virtual unsafe int ReportApiUsage (global::Com.Google.Atap.Tangoservice.TangoConfig p0)
			{
				if (id_reportApiUsage_Lcom_google_atap_tangoservice_TangoConfig_ == IntPtr.Zero)
					id_reportApiUsage_Lcom_google_atap_tangoservice_TangoConfig_ = JNIEnv.GetMethodID (class_ref, "reportApiUsage", "(Lcom/google/atap/tangoservice/TangoConfig;)I");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (p0);

					int __ret;
					if (GetType () == ThresholdType)
						__ret = JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_reportApiUsage_Lcom_google_atap_tangoservice_TangoConfig_, __args);
					else
						__ret = JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "reportApiUsage", "(Lcom/google/atap/tangoservice/TangoConfig;)I"), __args);
					return __ret;
				} finally {
				}
			}

			static Delegate cb_resetMotionTracking;
#pragma warning disable 0169
			static Delegate GetResetMotionTrackingHandler ()
			{
				if (cb_resetMotionTracking == null)
					cb_resetMotionTracking = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_ResetMotionTracking);
				return cb_resetMotionTracking;
			}

			static int n_ResetMotionTracking (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Google.Atap.Tangoservice.TangoStub.Proxy __this = global::Java.Lang.Object.GetObject<global::Com.Google.Atap.Tangoservice.TangoStub.Proxy> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return __this.ResetMotionTracking ();
			}
#pragma warning restore 0169

			static IntPtr id_resetMotionTracking;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.atap.tangoservice']/class[@name='ITango.Stub.Proxy']/method[@name='resetMotionTracking' and count(parameter)=0]"
			[Register ("resetMotionTracking", "()I", "GetResetMotionTrackingHandler")]
			public virtual unsafe int ResetMotionTracking ()
			{
				if (id_resetMotionTracking == IntPtr.Zero)
					id_resetMotionTracking = JNIEnv.GetMethodID (class_ref, "resetMotionTracking", "()I");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_resetMotionTracking);
					else
						return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "resetMotionTracking", "()I"));
				} finally {
				}
			}

			static Delegate cb_saveAreaDescription_Ljava_util_List_;
#pragma warning disable 0169
			static Delegate GetSaveAreaDescription_Ljava_util_List_Handler ()
			{
				if (cb_saveAreaDescription_Ljava_util_List_ == null)
					cb_saveAreaDescription_Ljava_util_List_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, int>) n_SaveAreaDescription_Ljava_util_List_);
				return cb_saveAreaDescription_Ljava_util_List_;
			}

			static int n_SaveAreaDescription_Ljava_util_List_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Google.Atap.Tangoservice.TangoStub.Proxy __this = global::Java.Lang.Object.GetObject<global::Com.Google.Atap.Tangoservice.TangoStub.Proxy> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				var p0 = global::Android.Runtime.JavaList<string>.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
				int __ret = __this.SaveAreaDescription (p0);
				return __ret;
			}
#pragma warning restore 0169

			static IntPtr id_saveAreaDescription_Ljava_util_List_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.atap.tangoservice']/class[@name='ITango.Stub.Proxy']/method[@name='saveAreaDescription' and count(parameter)=1 and parameter[1][@type='java.util.List&lt;java.lang.String&gt;']]"
			[Register ("saveAreaDescription", "(Ljava/util/List;)I", "GetSaveAreaDescription_Ljava_util_List_Handler")]
			public virtual unsafe int SaveAreaDescription (global::System.Collections.Generic.IList<string> p0)
			{
				if (id_saveAreaDescription_Ljava_util_List_ == IntPtr.Zero)
					id_saveAreaDescription_Ljava_util_List_ = JNIEnv.GetMethodID (class_ref, "saveAreaDescription", "(Ljava/util/List;)I");
				IntPtr native_p0 = global::Android.Runtime.JavaList<string>.ToLocalJniHandle (p0);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_p0);

					int __ret;
					if (GetType () == ThresholdType)
						__ret = JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_saveAreaDescription_Ljava_util_List_, __args);
					else
						__ret = JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "saveAreaDescription", "(Ljava/util/List;)I"), __args);
					return __ret;
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

			static Delegate cb_saveAreaDescriptionMetaData_Ljava_lang_String_Lcom_google_atap_tangoservice_TangoAreaDescriptionMetaData_;
#pragma warning disable 0169
			static Delegate GetSaveAreaDescriptionMetaData_Ljava_lang_String_Lcom_google_atap_tangoservice_TangoAreaDescriptionMetaData_Handler ()
			{
				if (cb_saveAreaDescriptionMetaData_Ljava_lang_String_Lcom_google_atap_tangoservice_TangoAreaDescriptionMetaData_ == null)
					cb_saveAreaDescriptionMetaData_Ljava_lang_String_Lcom_google_atap_tangoservice_TangoAreaDescriptionMetaData_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, int>) n_SaveAreaDescriptionMetaData_Ljava_lang_String_Lcom_google_atap_tangoservice_TangoAreaDescriptionMetaData_);
				return cb_saveAreaDescriptionMetaData_Ljava_lang_String_Lcom_google_atap_tangoservice_TangoAreaDescriptionMetaData_;
			}

			static int n_SaveAreaDescriptionMetaData_Ljava_lang_String_Lcom_google_atap_tangoservice_TangoAreaDescriptionMetaData_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
			{
				global::Com.Google.Atap.Tangoservice.TangoStub.Proxy __this = global::Java.Lang.Object.GetObject<global::Com.Google.Atap.Tangoservice.TangoStub.Proxy> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
				global::Com.Google.Atap.Tangoservice.TangoAreaDescriptionMetaData p1 = global::Java.Lang.Object.GetObject<global::Com.Google.Atap.Tangoservice.TangoAreaDescriptionMetaData> (native_p1, JniHandleOwnership.DoNotTransfer);
				int __ret = __this.SaveAreaDescriptionMetaData (p0, p1);
				return __ret;
			}
#pragma warning restore 0169

			static IntPtr id_saveAreaDescriptionMetaData_Ljava_lang_String_Lcom_google_atap_tangoservice_TangoAreaDescriptionMetaData_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.atap.tangoservice']/class[@name='ITango.Stub.Proxy']/method[@name='saveAreaDescriptionMetaData' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='com.google.atap.tangoservice.TangoAreaDescriptionMetaData']]"
			[Register ("saveAreaDescriptionMetaData", "(Ljava/lang/String;Lcom/google/atap/tangoservice/TangoAreaDescriptionMetaData;)I", "GetSaveAreaDescriptionMetaData_Ljava_lang_String_Lcom_google_atap_tangoservice_TangoAreaDescriptionMetaData_Handler")]
			public virtual unsafe int SaveAreaDescriptionMetaData (string p0, global::Com.Google.Atap.Tangoservice.TangoAreaDescriptionMetaData p1)
			{
				if (id_saveAreaDescriptionMetaData_Ljava_lang_String_Lcom_google_atap_tangoservice_TangoAreaDescriptionMetaData_ == IntPtr.Zero)
					id_saveAreaDescriptionMetaData_Ljava_lang_String_Lcom_google_atap_tangoservice_TangoAreaDescriptionMetaData_ = JNIEnv.GetMethodID (class_ref, "saveAreaDescriptionMetaData", "(Ljava/lang/String;Lcom/google/atap/tangoservice/TangoAreaDescriptionMetaData;)I");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				try {
					JValue* __args = stackalloc JValue [2];
					__args [0] = new JValue (native_p0);
					__args [1] = new JValue (p1);

					int __ret;
					if (GetType () == ThresholdType)
						__ret = JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_saveAreaDescriptionMetaData_Ljava_lang_String_Lcom_google_atap_tangoservice_TangoAreaDescriptionMetaData_, __args);
					else
						__ret = JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "saveAreaDescriptionMetaData", "(Ljava/lang/String;Lcom/google/atap/tangoservice/TangoAreaDescriptionMetaData;)I"), __args);
					return __ret;
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

			static Delegate cb_setPoseListenerFrames_Ljava_util_List_;
#pragma warning disable 0169
			static Delegate GetSetPoseListenerFrames_Ljava_util_List_Handler ()
			{
				if (cb_setPoseListenerFrames_Ljava_util_List_ == null)
					cb_setPoseListenerFrames_Ljava_util_List_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, int>) n_SetPoseListenerFrames_Ljava_util_List_);
				return cb_setPoseListenerFrames_Ljava_util_List_;
			}

			static int n_SetPoseListenerFrames_Ljava_util_List_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Google.Atap.Tangoservice.TangoStub.Proxy __this = global::Java.Lang.Object.GetObject<global::Com.Google.Atap.Tangoservice.TangoStub.Proxy> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				var p0 = global::Android.Runtime.JavaList<global::Com.Google.Atap.Tangoservice.TangoCoordinateFramePair>.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
				int __ret = __this.SetPoseListenerFrames (p0);
				return __ret;
			}
#pragma warning restore 0169

			static IntPtr id_setPoseListenerFrames_Ljava_util_List_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.atap.tangoservice']/class[@name='ITango.Stub.Proxy']/method[@name='setPoseListenerFrames' and count(parameter)=1 and parameter[1][@type='java.util.List&lt;com.google.atap.tangoservice.TangoCoordinateFramePair&gt;']]"
			[Register ("setPoseListenerFrames", "(Ljava/util/List;)I", "GetSetPoseListenerFrames_Ljava_util_List_Handler")]
			public virtual unsafe int SetPoseListenerFrames (global::System.Collections.Generic.IList<global::Com.Google.Atap.Tangoservice.TangoCoordinateFramePair> p0)
			{
				if (id_setPoseListenerFrames_Ljava_util_List_ == IntPtr.Zero)
					id_setPoseListenerFrames_Ljava_util_List_ = JNIEnv.GetMethodID (class_ref, "setPoseListenerFrames", "(Ljava/util/List;)I");
				IntPtr native_p0 = global::Android.Runtime.JavaList<global::Com.Google.Atap.Tangoservice.TangoCoordinateFramePair>.ToLocalJniHandle (p0);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_p0);

					int __ret;
					if (GetType () == ThresholdType)
						__ret = JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_setPoseListenerFrames_Ljava_util_List_, __args);
					else
						__ret = JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setPoseListenerFrames", "(Ljava/util/List;)I"), __args);
					return __ret;
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

			static Delegate cb_setRuntimeConfig_Lcom_google_atap_tangoservice_TangoConfig_;
#pragma warning disable 0169
			static Delegate GetSetRuntimeConfig_Lcom_google_atap_tangoservice_TangoConfig_Handler ()
			{
				if (cb_setRuntimeConfig_Lcom_google_atap_tangoservice_TangoConfig_ == null)
					cb_setRuntimeConfig_Lcom_google_atap_tangoservice_TangoConfig_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, int>) n_SetRuntimeConfig_Lcom_google_atap_tangoservice_TangoConfig_);
				return cb_setRuntimeConfig_Lcom_google_atap_tangoservice_TangoConfig_;
			}

			static int n_SetRuntimeConfig_Lcom_google_atap_tangoservice_TangoConfig_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Google.Atap.Tangoservice.TangoStub.Proxy __this = global::Java.Lang.Object.GetObject<global::Com.Google.Atap.Tangoservice.TangoStub.Proxy> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Com.Google.Atap.Tangoservice.TangoConfig p0 = global::Java.Lang.Object.GetObject<global::Com.Google.Atap.Tangoservice.TangoConfig> (native_p0, JniHandleOwnership.DoNotTransfer);
				int __ret = __this.SetRuntimeConfig (p0);
				return __ret;
			}
#pragma warning restore 0169

			static IntPtr id_setRuntimeConfig_Lcom_google_atap_tangoservice_TangoConfig_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.atap.tangoservice']/class[@name='ITango.Stub.Proxy']/method[@name='setRuntimeConfig' and count(parameter)=1 and parameter[1][@type='com.google.atap.tangoservice.TangoConfig']]"
			[Register ("setRuntimeConfig", "(Lcom/google/atap/tangoservice/TangoConfig;)I", "GetSetRuntimeConfig_Lcom_google_atap_tangoservice_TangoConfig_Handler")]
			public virtual unsafe int SetRuntimeConfig (global::Com.Google.Atap.Tangoservice.TangoConfig p0)
			{
				if (id_setRuntimeConfig_Lcom_google_atap_tangoservice_TangoConfig_ == IntPtr.Zero)
					id_setRuntimeConfig_Lcom_google_atap_tangoservice_TangoConfig_ = JNIEnv.GetMethodID (class_ref, "setRuntimeConfig", "(Lcom/google/atap/tangoservice/TangoConfig;)I");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (p0);

					int __ret;
					if (GetType () == ThresholdType)
						__ret = JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_setRuntimeConfig_Lcom_google_atap_tangoservice_TangoConfig_, __args);
					else
						__ret = JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setRuntimeConfig", "(Lcom/google/atap/tangoservice/TangoConfig;)I"), __args);
					return __ret;
				} finally {
				}
			}

		}

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/google/atap/tangoservice/ITango$Stub", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (TangoStub); }
		}

		protected TangoStub (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.google.atap.tangoservice']/class[@name='ITango.Stub']/constructor[@name='ITango.Stub' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe TangoStub ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (TangoStub)) {
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
			global::Com.Google.Atap.Tangoservice.TangoStub __this = global::Java.Lang.Object.GetObject<global::Com.Google.Atap.Tangoservice.TangoStub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.AsBinder ());
		}
#pragma warning restore 0169

		static IntPtr id_asBinder;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.atap.tangoservice']/class[@name='ITango.Stub']/method[@name='asBinder' and count(parameter)=0]"
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
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.atap.tangoservice']/class[@name='ITango.Stub']/method[@name='asInterface' and count(parameter)=1 and parameter[1][@type='android.os.IBinder']]"
		[Register ("asInterface", "(Landroid/os/IBinder;)Lcom/google/atap/tangoservice/ITango;", "")]
		public static unsafe global::Com.Google.Atap.Tangoservice.ITango AsInterface (global::Android.OS.IBinder p0)
		{
			if (id_asInterface_Landroid_os_IBinder_ == IntPtr.Zero)
				id_asInterface_Landroid_os_IBinder_ = JNIEnv.GetStaticMethodID (class_ref, "asInterface", "(Landroid/os/IBinder;)Lcom/google/atap/tangoservice/ITango;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				global::Com.Google.Atap.Tangoservice.ITango __ret = global::Java.Lang.Object.GetObject<global::Com.Google.Atap.Tangoservice.ITango> (JNIEnv.CallStaticObjectMethod  (class_ref, id_asInterface_Landroid_os_IBinder_, __args), JniHandleOwnership.TransferLocalRef);
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
			global::Com.Google.Atap.Tangoservice.TangoStub __this = global::Java.Lang.Object.GetObject<global::Com.Google.Atap.Tangoservice.TangoStub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.Parcel p1 = global::Java.Lang.Object.GetObject<global::Android.OS.Parcel> (native_p1, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.Parcel p2 = global::Java.Lang.Object.GetObject<global::Android.OS.Parcel> (native_p2, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.OnTransact (p0, p1, p2, p3);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_onTransact_ILandroid_os_Parcel_Landroid_os_Parcel_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.atap.tangoservice']/class[@name='ITango.Stub']/method[@name='onTransact' and count(parameter)=4 and parameter[1][@type='int'] and parameter[2][@type='android.os.Parcel'] and parameter[3][@type='android.os.Parcel'] and parameter[4][@type='int']]"
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

		static Delegate cb_connect_Lcom_google_atap_tangoservice_ITangoListener_Lcom_google_atap_tangoservice_TangoConfig_;
#pragma warning disable 0169
		static Delegate GetConnect_Lcom_google_atap_tangoservice_ITangoListener_Lcom_google_atap_tangoservice_TangoConfig_Handler ()
		{
			if (cb_connect_Lcom_google_atap_tangoservice_ITangoListener_Lcom_google_atap_tangoservice_TangoConfig_ == null)
				cb_connect_Lcom_google_atap_tangoservice_ITangoListener_Lcom_google_atap_tangoservice_TangoConfig_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, int>) n_Connect_Lcom_google_atap_tangoservice_ITangoListener_Lcom_google_atap_tangoservice_TangoConfig_);
			return cb_connect_Lcom_google_atap_tangoservice_ITangoListener_Lcom_google_atap_tangoservice_TangoConfig_;
		}

		static int n_Connect_Lcom_google_atap_tangoservice_ITangoListener_Lcom_google_atap_tangoservice_TangoConfig_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Google.Atap.Tangoservice.TangoStub __this = global::Java.Lang.Object.GetObject<global::Com.Google.Atap.Tangoservice.TangoStub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Google.Atap.Tangoservice.ITangoListener p0 = (global::Com.Google.Atap.Tangoservice.ITangoListener)global::Java.Lang.Object.GetObject<global::Com.Google.Atap.Tangoservice.ITangoListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Google.Atap.Tangoservice.TangoConfig p1 = global::Java.Lang.Object.GetObject<global::Com.Google.Atap.Tangoservice.TangoConfig> (native_p1, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.Connect (p0, p1);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.atap.tangoservice']/interface[@name='ITango']/method[@name='connect' and count(parameter)=2 and parameter[1][@type='com.google.atap.tangoservice.ITangoListener'] and parameter[2][@type='com.google.atap.tangoservice.TangoConfig']]"
		[Register ("connect", "(Lcom/google/atap/tangoservice/ITangoListener;Lcom/google/atap/tangoservice/TangoConfig;)I", "GetConnect_Lcom_google_atap_tangoservice_ITangoListener_Lcom_google_atap_tangoservice_TangoConfig_Handler")]
		public abstract int Connect (global::Com.Google.Atap.Tangoservice.ITangoListener p0, global::Com.Google.Atap.Tangoservice.TangoConfig p1);

		static Delegate cb_connectSurface_ILandroid_view_Surface_;
#pragma warning disable 0169
		static Delegate GetConnectSurface_ILandroid_view_Surface_Handler ()
		{
			if (cb_connectSurface_ILandroid_view_Surface_ == null)
				cb_connectSurface_ILandroid_view_Surface_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr, int>) n_ConnectSurface_ILandroid_view_Surface_);
			return cb_connectSurface_ILandroid_view_Surface_;
		}

		static int n_ConnectSurface_ILandroid_view_Surface_ (IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1)
		{
			global::Com.Google.Atap.Tangoservice.TangoStub __this = global::Java.Lang.Object.GetObject<global::Com.Google.Atap.Tangoservice.TangoStub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.Surface p1 = global::Java.Lang.Object.GetObject<global::Android.Views.Surface> (native_p1, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.ConnectSurface (p0, p1);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.atap.tangoservice']/interface[@name='ITango']/method[@name='connectSurface' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='android.view.Surface']]"
		[Register ("connectSurface", "(ILandroid/view/Surface;)I", "GetConnectSurface_ILandroid_view_Surface_Handler")]
		public abstract int ConnectSurface (int p0, global::Android.Views.Surface p1);

		static Delegate cb_deleteAreaDescription_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetDeleteAreaDescription_Ljava_lang_String_Handler ()
		{
			if (cb_deleteAreaDescription_Ljava_lang_String_ == null)
				cb_deleteAreaDescription_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, int>) n_DeleteAreaDescription_Ljava_lang_String_);
			return cb_deleteAreaDescription_Ljava_lang_String_;
		}

		static int n_DeleteAreaDescription_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Google.Atap.Tangoservice.TangoStub __this = global::Java.Lang.Object.GetObject<global::Com.Google.Atap.Tangoservice.TangoStub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.DeleteAreaDescription (p0);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.atap.tangoservice']/interface[@name='ITango']/method[@name='deleteAreaDescription' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("deleteAreaDescription", "(Ljava/lang/String;)I", "GetDeleteAreaDescription_Ljava_lang_String_Handler")]
		public abstract int DeleteAreaDescription (string p0);

		static Delegate cb_deleteDataset_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetDeleteDataset_Ljava_lang_String_Handler ()
		{
			if (cb_deleteDataset_Ljava_lang_String_ == null)
				cb_deleteDataset_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, int>) n_DeleteDataset_Ljava_lang_String_);
			return cb_deleteDataset_Ljava_lang_String_;
		}

		static int n_DeleteDataset_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Google.Atap.Tangoservice.TangoStub __this = global::Java.Lang.Object.GetObject<global::Com.Google.Atap.Tangoservice.TangoStub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.DeleteDataset (p0);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.atap.tangoservice']/interface[@name='ITango']/method[@name='deleteDataset' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("deleteDataset", "(Ljava/lang/String;)I", "GetDeleteDataset_Ljava_lang_String_Handler")]
		public abstract int DeleteDataset (string p0);

		static Delegate cb_disconnect;
#pragma warning disable 0169
		static Delegate GetDisconnectHandler ()
		{
			if (cb_disconnect == null)
				cb_disconnect = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_Disconnect);
			return cb_disconnect;
		}

		static int n_Disconnect (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Google.Atap.Tangoservice.TangoStub __this = global::Java.Lang.Object.GetObject<global::Com.Google.Atap.Tangoservice.TangoStub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Disconnect ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.atap.tangoservice']/interface[@name='ITango']/method[@name='disconnect' and count(parameter)=0]"
		[Register ("disconnect", "()I", "GetDisconnectHandler")]
		public abstract int Disconnect ();

		static Delegate cb_disconnectSurface_I;
#pragma warning disable 0169
		static Delegate GetDisconnectSurface_IHandler ()
		{
			if (cb_disconnectSurface_I == null)
				cb_disconnectSurface_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, int>) n_DisconnectSurface_I);
			return cb_disconnectSurface_I;
		}

		static int n_DisconnectSurface_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Google.Atap.Tangoservice.TangoStub __this = global::Java.Lang.Object.GetObject<global::Com.Google.Atap.Tangoservice.TangoStub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.DisconnectSurface (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.atap.tangoservice']/interface[@name='ITango']/method[@name='disconnectSurface' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("disconnectSurface", "(I)I", "GetDisconnectSurface_IHandler")]
		public abstract int DisconnectSurface (int p0);

		static Delegate cb_exportAreaDescriptionFile_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetExportAreaDescriptionFile_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_exportAreaDescriptionFile_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_exportAreaDescriptionFile_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, int>) n_ExportAreaDescriptionFile_Ljava_lang_String_Ljava_lang_String_);
			return cb_exportAreaDescriptionFile_Ljava_lang_String_Ljava_lang_String_;
		}

		static int n_ExportAreaDescriptionFile_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Google.Atap.Tangoservice.TangoStub __this = global::Java.Lang.Object.GetObject<global::Com.Google.Atap.Tangoservice.TangoStub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.ExportAreaDescriptionFile (p0, p1);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.atap.tangoservice']/interface[@name='ITango']/method[@name='exportAreaDescriptionFile' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("exportAreaDescriptionFile", "(Ljava/lang/String;Ljava/lang/String;)I", "GetExportAreaDescriptionFile_Ljava_lang_String_Ljava_lang_String_Handler")]
		public abstract int ExportAreaDescriptionFile (string p0, string p1);

		static Delegate cb_foiRequest_Lcom_google_atap_tangoservice_fois_FoiRequest_;
#pragma warning disable 0169
		static Delegate GetFoiRequest_Lcom_google_atap_tangoservice_fois_FoiRequest_Handler ()
		{
			if (cb_foiRequest_Lcom_google_atap_tangoservice_fois_FoiRequest_ == null)
				cb_foiRequest_Lcom_google_atap_tangoservice_fois_FoiRequest_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, int>) n_FoiRequest_Lcom_google_atap_tangoservice_fois_FoiRequest_);
			return cb_foiRequest_Lcom_google_atap_tangoservice_fois_FoiRequest_;
		}

		static int n_FoiRequest_Lcom_google_atap_tangoservice_fois_FoiRequest_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Google.Atap.Tangoservice.TangoStub __this = global::Java.Lang.Object.GetObject<global::Com.Google.Atap.Tangoservice.TangoStub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Google.Atap.Tangoservice.Fois.FoiRequest p0 = global::Java.Lang.Object.GetObject<global::Com.Google.Atap.Tangoservice.Fois.FoiRequest> (native_p0, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.FoiRequest (p0);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.atap.tangoservice']/interface[@name='ITango']/method[@name='foiRequest' and count(parameter)=1 and parameter[1][@type='com.google.atap.tangoservice.fois.FoiRequest']]"
		[Register ("foiRequest", "(Lcom/google/atap/tangoservice/fois/FoiRequest;)I", "GetFoiRequest_Lcom_google_atap_tangoservice_fois_FoiRequest_Handler")]
		public abstract int FoiRequest (global::Com.Google.Atap.Tangoservice.Fois.FoiRequest p0);

		static Delegate cb_getAreaDescriptionUuidList_Ljava_util_List_;
#pragma warning disable 0169
		static Delegate GetGetAreaDescriptionUuidList_Ljava_util_List_Handler ()
		{
			if (cb_getAreaDescriptionUuidList_Ljava_util_List_ == null)
				cb_getAreaDescriptionUuidList_Ljava_util_List_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, int>) n_GetAreaDescriptionUuidList_Ljava_util_List_);
			return cb_getAreaDescriptionUuidList_Ljava_util_List_;
		}

		static int n_GetAreaDescriptionUuidList_Ljava_util_List_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Google.Atap.Tangoservice.TangoStub __this = global::Java.Lang.Object.GetObject<global::Com.Google.Atap.Tangoservice.TangoStub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Android.Runtime.JavaList<string>.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.GetAreaDescriptionUuidList (p0);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.atap.tangoservice']/interface[@name='ITango']/method[@name='getAreaDescriptionUuidList' and count(parameter)=1 and parameter[1][@type='java.util.List&lt;java.lang.String&gt;']]"
		[Register ("getAreaDescriptionUuidList", "(Ljava/util/List;)I", "GetGetAreaDescriptionUuidList_Ljava_util_List_Handler")]
		public abstract int GetAreaDescriptionUuidList (global::System.Collections.Generic.IList<string> p0);

		static Delegate cb_getCameraIntrinsics_ILcom_google_atap_tangoservice_TangoCameraIntrinsics_;
#pragma warning disable 0169
		static Delegate GetGetCameraIntrinsics_ILcom_google_atap_tangoservice_TangoCameraIntrinsics_Handler ()
		{
			if (cb_getCameraIntrinsics_ILcom_google_atap_tangoservice_TangoCameraIntrinsics_ == null)
				cb_getCameraIntrinsics_ILcom_google_atap_tangoservice_TangoCameraIntrinsics_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr, int>) n_GetCameraIntrinsics_ILcom_google_atap_tangoservice_TangoCameraIntrinsics_);
			return cb_getCameraIntrinsics_ILcom_google_atap_tangoservice_TangoCameraIntrinsics_;
		}

		static int n_GetCameraIntrinsics_ILcom_google_atap_tangoservice_TangoCameraIntrinsics_ (IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1)
		{
			global::Com.Google.Atap.Tangoservice.TangoStub __this = global::Java.Lang.Object.GetObject<global::Com.Google.Atap.Tangoservice.TangoStub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Google.Atap.Tangoservice.TangoCameraIntrinsics p1 = global::Java.Lang.Object.GetObject<global::Com.Google.Atap.Tangoservice.TangoCameraIntrinsics> (native_p1, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.GetCameraIntrinsics (p0, p1);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.atap.tangoservice']/interface[@name='ITango']/method[@name='getCameraIntrinsics' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='com.google.atap.tangoservice.TangoCameraIntrinsics']]"
		[Register ("getCameraIntrinsics", "(ILcom/google/atap/tangoservice/TangoCameraIntrinsics;)I", "GetGetCameraIntrinsics_ILcom_google_atap_tangoservice_TangoCameraIntrinsics_Handler")]
		public abstract int GetCameraIntrinsics (int p0, global::Com.Google.Atap.Tangoservice.TangoCameraIntrinsics p1);

		static Delegate cb_getConfig_ILcom_google_atap_tangoservice_TangoConfig_;
#pragma warning disable 0169
		static Delegate GetGetConfig_ILcom_google_atap_tangoservice_TangoConfig_Handler ()
		{
			if (cb_getConfig_ILcom_google_atap_tangoservice_TangoConfig_ == null)
				cb_getConfig_ILcom_google_atap_tangoservice_TangoConfig_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr, int>) n_GetConfig_ILcom_google_atap_tangoservice_TangoConfig_);
			return cb_getConfig_ILcom_google_atap_tangoservice_TangoConfig_;
		}

		static int n_GetConfig_ILcom_google_atap_tangoservice_TangoConfig_ (IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1)
		{
			global::Com.Google.Atap.Tangoservice.TangoStub __this = global::Java.Lang.Object.GetObject<global::Com.Google.Atap.Tangoservice.TangoStub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Google.Atap.Tangoservice.TangoConfig p1 = global::Java.Lang.Object.GetObject<global::Com.Google.Atap.Tangoservice.TangoConfig> (native_p1, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.GetConfig (p0, p1);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.atap.tangoservice']/interface[@name='ITango']/method[@name='getConfig' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='com.google.atap.tangoservice.TangoConfig']]"
		[Register ("getConfig", "(ILcom/google/atap/tangoservice/TangoConfig;)I", "GetGetConfig_ILcom_google_atap_tangoservice_TangoConfig_Handler")]
		public abstract int GetConfig (int p0, global::Com.Google.Atap.Tangoservice.TangoConfig p1);

		static Delegate cb_getCurrentDatasetUuid_Ljava_util_List_;
#pragma warning disable 0169
		static Delegate GetGetCurrentDatasetUuid_Ljava_util_List_Handler ()
		{
			if (cb_getCurrentDatasetUuid_Ljava_util_List_ == null)
				cb_getCurrentDatasetUuid_Ljava_util_List_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, int>) n_GetCurrentDatasetUuid_Ljava_util_List_);
			return cb_getCurrentDatasetUuid_Ljava_util_List_;
		}

		static int n_GetCurrentDatasetUuid_Ljava_util_List_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Google.Atap.Tangoservice.TangoStub __this = global::Java.Lang.Object.GetObject<global::Com.Google.Atap.Tangoservice.TangoStub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Android.Runtime.JavaList<string>.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.GetCurrentDatasetUuid (p0);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.atap.tangoservice']/interface[@name='ITango']/method[@name='getCurrentDatasetUuid' and count(parameter)=1 and parameter[1][@type='java.util.List&lt;java.lang.String&gt;']]"
		[Register ("getCurrentDatasetUuid", "(Ljava/util/List;)I", "GetGetCurrentDatasetUuid_Ljava_util_List_Handler")]
		public abstract int GetCurrentDatasetUuid (global::System.Collections.Generic.IList<string> p0);

		static Delegate cb_getDatasetUuids_Ljava_util_List_;
#pragma warning disable 0169
		static Delegate GetGetDatasetUuids_Ljava_util_List_Handler ()
		{
			if (cb_getDatasetUuids_Ljava_util_List_ == null)
				cb_getDatasetUuids_Ljava_util_List_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, int>) n_GetDatasetUuids_Ljava_util_List_);
			return cb_getDatasetUuids_Ljava_util_List_;
		}

		static int n_GetDatasetUuids_Ljava_util_List_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Google.Atap.Tangoservice.TangoStub __this = global::Java.Lang.Object.GetObject<global::Com.Google.Atap.Tangoservice.TangoStub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Android.Runtime.JavaList<string>.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.GetDatasetUuids (p0);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.atap.tangoservice']/interface[@name='ITango']/method[@name='getDatasetUuids' and count(parameter)=1 and parameter[1][@type='java.util.List&lt;java.lang.String&gt;']]"
		[Register ("getDatasetUuids", "(Ljava/util/List;)I", "GetGetDatasetUuids_Ljava_util_List_Handler")]
		public abstract int GetDatasetUuids (global::System.Collections.Generic.IList<string> p0);

		static Delegate cb_getPoseAtTime2_DLjava_lang_String_Ljava_lang_String_Lcom_google_atap_tangoservice_TangoPoseData_;
#pragma warning disable 0169
		static Delegate GetGetPoseAtTime2_DLjava_lang_String_Ljava_lang_String_Lcom_google_atap_tangoservice_TangoPoseData_Handler ()
		{
			if (cb_getPoseAtTime2_DLjava_lang_String_Ljava_lang_String_Lcom_google_atap_tangoservice_TangoPoseData_ == null)
				cb_getPoseAtTime2_DLjava_lang_String_Ljava_lang_String_Lcom_google_atap_tangoservice_TangoPoseData_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, double, IntPtr, IntPtr, IntPtr, int>) n_GetPoseAtTime2_DLjava_lang_String_Ljava_lang_String_Lcom_google_atap_tangoservice_TangoPoseData_);
			return cb_getPoseAtTime2_DLjava_lang_String_Ljava_lang_String_Lcom_google_atap_tangoservice_TangoPoseData_;
		}

		static int n_GetPoseAtTime2_DLjava_lang_String_Ljava_lang_String_Lcom_google_atap_tangoservice_TangoPoseData_ (IntPtr jnienv, IntPtr native__this, double p0, IntPtr native_p1, IntPtr native_p2, IntPtr native_p3)
		{
			global::Com.Google.Atap.Tangoservice.TangoStub __this = global::Java.Lang.Object.GetObject<global::Com.Google.Atap.Tangoservice.TangoStub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			string p2 = JNIEnv.GetString (native_p2, JniHandleOwnership.DoNotTransfer);
			global::Com.Google.Atap.Tangoservice.TangoPoseData p3 = global::Java.Lang.Object.GetObject<global::Com.Google.Atap.Tangoservice.TangoPoseData> (native_p3, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.GetPoseAtTime2 (p0, p1, p2, p3);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.atap.tangoservice']/interface[@name='ITango']/method[@name='getPoseAtTime2' and count(parameter)=4 and parameter[1][@type='double'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='com.google.atap.tangoservice.TangoPoseData']]"
		[Register ("getPoseAtTime2", "(DLjava/lang/String;Ljava/lang/String;Lcom/google/atap/tangoservice/TangoPoseData;)I", "GetGetPoseAtTime2_DLjava_lang_String_Ljava_lang_String_Lcom_google_atap_tangoservice_TangoPoseData_Handler")]
		public abstract int GetPoseAtTime2 (double p0, string p1, string p2, global::Com.Google.Atap.Tangoservice.TangoPoseData p3);

		static Delegate cb_getPoseAtTime_DLcom_google_atap_tangoservice_TangoCoordinateFramePair_Lcom_google_atap_tangoservice_TangoPoseData_;
#pragma warning disable 0169
		static Delegate GetGetPoseAtTime_DLcom_google_atap_tangoservice_TangoCoordinateFramePair_Lcom_google_atap_tangoservice_TangoPoseData_Handler ()
		{
			if (cb_getPoseAtTime_DLcom_google_atap_tangoservice_TangoCoordinateFramePair_Lcom_google_atap_tangoservice_TangoPoseData_ == null)
				cb_getPoseAtTime_DLcom_google_atap_tangoservice_TangoCoordinateFramePair_Lcom_google_atap_tangoservice_TangoPoseData_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, double, IntPtr, IntPtr, int>) n_GetPoseAtTime_DLcom_google_atap_tangoservice_TangoCoordinateFramePair_Lcom_google_atap_tangoservice_TangoPoseData_);
			return cb_getPoseAtTime_DLcom_google_atap_tangoservice_TangoCoordinateFramePair_Lcom_google_atap_tangoservice_TangoPoseData_;
		}

		static int n_GetPoseAtTime_DLcom_google_atap_tangoservice_TangoCoordinateFramePair_Lcom_google_atap_tangoservice_TangoPoseData_ (IntPtr jnienv, IntPtr native__this, double p0, IntPtr native_p1, IntPtr native_p2)
		{
			global::Com.Google.Atap.Tangoservice.TangoStub __this = global::Java.Lang.Object.GetObject<global::Com.Google.Atap.Tangoservice.TangoStub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Google.Atap.Tangoservice.TangoCoordinateFramePair p1 = global::Java.Lang.Object.GetObject<global::Com.Google.Atap.Tangoservice.TangoCoordinateFramePair> (native_p1, JniHandleOwnership.DoNotTransfer);
			global::Com.Google.Atap.Tangoservice.TangoPoseData p2 = global::Java.Lang.Object.GetObject<global::Com.Google.Atap.Tangoservice.TangoPoseData> (native_p2, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.GetPoseAtTime (p0, p1, p2);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.atap.tangoservice']/interface[@name='ITango']/method[@name='getPoseAtTime' and count(parameter)=3 and parameter[1][@type='double'] and parameter[2][@type='com.google.atap.tangoservice.TangoCoordinateFramePair'] and parameter[3][@type='com.google.atap.tangoservice.TangoPoseData']]"
		[Register ("getPoseAtTime", "(DLcom/google/atap/tangoservice/TangoCoordinateFramePair;Lcom/google/atap/tangoservice/TangoPoseData;)I", "GetGetPoseAtTime_DLcom_google_atap_tangoservice_TangoCoordinateFramePair_Lcom_google_atap_tangoservice_TangoPoseData_Handler")]
		public abstract int GetPoseAtTime (double p0, global::Com.Google.Atap.Tangoservice.TangoCoordinateFramePair p1, global::Com.Google.Atap.Tangoservice.TangoPoseData p2);

		static Delegate cb_importAreaDescriptionFile_Ljava_util_List_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetImportAreaDescriptionFile_Ljava_util_List_Ljava_lang_String_Handler ()
		{
			if (cb_importAreaDescriptionFile_Ljava_util_List_Ljava_lang_String_ == null)
				cb_importAreaDescriptionFile_Ljava_util_List_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, int>) n_ImportAreaDescriptionFile_Ljava_util_List_Ljava_lang_String_);
			return cb_importAreaDescriptionFile_Ljava_util_List_Ljava_lang_String_;
		}

		static int n_ImportAreaDescriptionFile_Ljava_util_List_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Google.Atap.Tangoservice.TangoStub __this = global::Java.Lang.Object.GetObject<global::Com.Google.Atap.Tangoservice.TangoStub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Android.Runtime.JavaList<string>.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.ImportAreaDescriptionFile (p0, p1);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.atap.tangoservice']/interface[@name='ITango']/method[@name='importAreaDescriptionFile' and count(parameter)=2 and parameter[1][@type='java.util.List&lt;java.lang.String&gt;'] and parameter[2][@type='java.lang.String']]"
		[Register ("importAreaDescriptionFile", "(Ljava/util/List;Ljava/lang/String;)I", "GetImportAreaDescriptionFile_Ljava_util_List_Ljava_lang_String_Handler")]
		public abstract int ImportAreaDescriptionFile (global::System.Collections.Generic.IList<string> p0, string p1);

		static Delegate cb_loadAreaDescriptionMetaData_Ljava_lang_String_Lcom_google_atap_tangoservice_TangoAreaDescriptionMetaData_;
#pragma warning disable 0169
		static Delegate GetLoadAreaDescriptionMetaData_Ljava_lang_String_Lcom_google_atap_tangoservice_TangoAreaDescriptionMetaData_Handler ()
		{
			if (cb_loadAreaDescriptionMetaData_Ljava_lang_String_Lcom_google_atap_tangoservice_TangoAreaDescriptionMetaData_ == null)
				cb_loadAreaDescriptionMetaData_Ljava_lang_String_Lcom_google_atap_tangoservice_TangoAreaDescriptionMetaData_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, int>) n_LoadAreaDescriptionMetaData_Ljava_lang_String_Lcom_google_atap_tangoservice_TangoAreaDescriptionMetaData_);
			return cb_loadAreaDescriptionMetaData_Ljava_lang_String_Lcom_google_atap_tangoservice_TangoAreaDescriptionMetaData_;
		}

		static int n_LoadAreaDescriptionMetaData_Ljava_lang_String_Lcom_google_atap_tangoservice_TangoAreaDescriptionMetaData_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Google.Atap.Tangoservice.TangoStub __this = global::Java.Lang.Object.GetObject<global::Com.Google.Atap.Tangoservice.TangoStub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Google.Atap.Tangoservice.TangoAreaDescriptionMetaData p1 = global::Java.Lang.Object.GetObject<global::Com.Google.Atap.Tangoservice.TangoAreaDescriptionMetaData> (native_p1, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.LoadAreaDescriptionMetaData (p0, p1);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.atap.tangoservice']/interface[@name='ITango']/method[@name='loadAreaDescriptionMetaData' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='com.google.atap.tangoservice.TangoAreaDescriptionMetaData']]"
		[Register ("loadAreaDescriptionMetaData", "(Ljava/lang/String;Lcom/google/atap/tangoservice/TangoAreaDescriptionMetaData;)I", "GetLoadAreaDescriptionMetaData_Ljava_lang_String_Lcom_google_atap_tangoservice_TangoAreaDescriptionMetaData_Handler")]
		public abstract int LoadAreaDescriptionMetaData (string p0, global::Com.Google.Atap.Tangoservice.TangoAreaDescriptionMetaData p1);

		static Delegate cb_reportApiUsage_Lcom_google_atap_tangoservice_TangoConfig_;
#pragma warning disable 0169
		static Delegate GetReportApiUsage_Lcom_google_atap_tangoservice_TangoConfig_Handler ()
		{
			if (cb_reportApiUsage_Lcom_google_atap_tangoservice_TangoConfig_ == null)
				cb_reportApiUsage_Lcom_google_atap_tangoservice_TangoConfig_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, int>) n_ReportApiUsage_Lcom_google_atap_tangoservice_TangoConfig_);
			return cb_reportApiUsage_Lcom_google_atap_tangoservice_TangoConfig_;
		}

		static int n_ReportApiUsage_Lcom_google_atap_tangoservice_TangoConfig_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Google.Atap.Tangoservice.TangoStub __this = global::Java.Lang.Object.GetObject<global::Com.Google.Atap.Tangoservice.TangoStub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Google.Atap.Tangoservice.TangoConfig p0 = global::Java.Lang.Object.GetObject<global::Com.Google.Atap.Tangoservice.TangoConfig> (native_p0, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.ReportApiUsage (p0);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.atap.tangoservice']/interface[@name='ITango']/method[@name='reportApiUsage' and count(parameter)=1 and parameter[1][@type='com.google.atap.tangoservice.TangoConfig']]"
		[Register ("reportApiUsage", "(Lcom/google/atap/tangoservice/TangoConfig;)I", "GetReportApiUsage_Lcom_google_atap_tangoservice_TangoConfig_Handler")]
		public abstract int ReportApiUsage (global::Com.Google.Atap.Tangoservice.TangoConfig p0);

		static Delegate cb_resetMotionTracking;
#pragma warning disable 0169
		static Delegate GetResetMotionTrackingHandler ()
		{
			if (cb_resetMotionTracking == null)
				cb_resetMotionTracking = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_ResetMotionTracking);
			return cb_resetMotionTracking;
		}

		static int n_ResetMotionTracking (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Google.Atap.Tangoservice.TangoStub __this = global::Java.Lang.Object.GetObject<global::Com.Google.Atap.Tangoservice.TangoStub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ResetMotionTracking ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.atap.tangoservice']/interface[@name='ITango']/method[@name='resetMotionTracking' and count(parameter)=0]"
		[Register ("resetMotionTracking", "()I", "GetResetMotionTrackingHandler")]
		public abstract int ResetMotionTracking ();

		static Delegate cb_saveAreaDescription_Ljava_util_List_;
#pragma warning disable 0169
		static Delegate GetSaveAreaDescription_Ljava_util_List_Handler ()
		{
			if (cb_saveAreaDescription_Ljava_util_List_ == null)
				cb_saveAreaDescription_Ljava_util_List_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, int>) n_SaveAreaDescription_Ljava_util_List_);
			return cb_saveAreaDescription_Ljava_util_List_;
		}

		static int n_SaveAreaDescription_Ljava_util_List_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Google.Atap.Tangoservice.TangoStub __this = global::Java.Lang.Object.GetObject<global::Com.Google.Atap.Tangoservice.TangoStub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Android.Runtime.JavaList<string>.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.SaveAreaDescription (p0);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.atap.tangoservice']/interface[@name='ITango']/method[@name='saveAreaDescription' and count(parameter)=1 and parameter[1][@type='java.util.List&lt;java.lang.String&gt;']]"
		[Register ("saveAreaDescription", "(Ljava/util/List;)I", "GetSaveAreaDescription_Ljava_util_List_Handler")]
		public abstract int SaveAreaDescription (global::System.Collections.Generic.IList<string> p0);

		static Delegate cb_saveAreaDescriptionMetaData_Ljava_lang_String_Lcom_google_atap_tangoservice_TangoAreaDescriptionMetaData_;
#pragma warning disable 0169
		static Delegate GetSaveAreaDescriptionMetaData_Ljava_lang_String_Lcom_google_atap_tangoservice_TangoAreaDescriptionMetaData_Handler ()
		{
			if (cb_saveAreaDescriptionMetaData_Ljava_lang_String_Lcom_google_atap_tangoservice_TangoAreaDescriptionMetaData_ == null)
				cb_saveAreaDescriptionMetaData_Ljava_lang_String_Lcom_google_atap_tangoservice_TangoAreaDescriptionMetaData_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, int>) n_SaveAreaDescriptionMetaData_Ljava_lang_String_Lcom_google_atap_tangoservice_TangoAreaDescriptionMetaData_);
			return cb_saveAreaDescriptionMetaData_Ljava_lang_String_Lcom_google_atap_tangoservice_TangoAreaDescriptionMetaData_;
		}

		static int n_SaveAreaDescriptionMetaData_Ljava_lang_String_Lcom_google_atap_tangoservice_TangoAreaDescriptionMetaData_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Google.Atap.Tangoservice.TangoStub __this = global::Java.Lang.Object.GetObject<global::Com.Google.Atap.Tangoservice.TangoStub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Google.Atap.Tangoservice.TangoAreaDescriptionMetaData p1 = global::Java.Lang.Object.GetObject<global::Com.Google.Atap.Tangoservice.TangoAreaDescriptionMetaData> (native_p1, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.SaveAreaDescriptionMetaData (p0, p1);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.atap.tangoservice']/interface[@name='ITango']/method[@name='saveAreaDescriptionMetaData' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='com.google.atap.tangoservice.TangoAreaDescriptionMetaData']]"
		[Register ("saveAreaDescriptionMetaData", "(Ljava/lang/String;Lcom/google/atap/tangoservice/TangoAreaDescriptionMetaData;)I", "GetSaveAreaDescriptionMetaData_Ljava_lang_String_Lcom_google_atap_tangoservice_TangoAreaDescriptionMetaData_Handler")]
		public abstract int SaveAreaDescriptionMetaData (string p0, global::Com.Google.Atap.Tangoservice.TangoAreaDescriptionMetaData p1);

		static Delegate cb_setPoseListenerFrames_Ljava_util_List_;
#pragma warning disable 0169
		static Delegate GetSetPoseListenerFrames_Ljava_util_List_Handler ()
		{
			if (cb_setPoseListenerFrames_Ljava_util_List_ == null)
				cb_setPoseListenerFrames_Ljava_util_List_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, int>) n_SetPoseListenerFrames_Ljava_util_List_);
			return cb_setPoseListenerFrames_Ljava_util_List_;
		}

		static int n_SetPoseListenerFrames_Ljava_util_List_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Google.Atap.Tangoservice.TangoStub __this = global::Java.Lang.Object.GetObject<global::Com.Google.Atap.Tangoservice.TangoStub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Android.Runtime.JavaList<global::Com.Google.Atap.Tangoservice.TangoCoordinateFramePair>.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.SetPoseListenerFrames (p0);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.atap.tangoservice']/interface[@name='ITango']/method[@name='setPoseListenerFrames' and count(parameter)=1 and parameter[1][@type='java.util.List&lt;com.google.atap.tangoservice.TangoCoordinateFramePair&gt;']]"
		[Register ("setPoseListenerFrames", "(Ljava/util/List;)I", "GetSetPoseListenerFrames_Ljava_util_List_Handler")]
		public abstract int SetPoseListenerFrames (global::System.Collections.Generic.IList<global::Com.Google.Atap.Tangoservice.TangoCoordinateFramePair> p0);

		static Delegate cb_setRuntimeConfig_Lcom_google_atap_tangoservice_TangoConfig_;
#pragma warning disable 0169
		static Delegate GetSetRuntimeConfig_Lcom_google_atap_tangoservice_TangoConfig_Handler ()
		{
			if (cb_setRuntimeConfig_Lcom_google_atap_tangoservice_TangoConfig_ == null)
				cb_setRuntimeConfig_Lcom_google_atap_tangoservice_TangoConfig_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, int>) n_SetRuntimeConfig_Lcom_google_atap_tangoservice_TangoConfig_);
			return cb_setRuntimeConfig_Lcom_google_atap_tangoservice_TangoConfig_;
		}

		static int n_SetRuntimeConfig_Lcom_google_atap_tangoservice_TangoConfig_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Google.Atap.Tangoservice.TangoStub __this = global::Java.Lang.Object.GetObject<global::Com.Google.Atap.Tangoservice.TangoStub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Google.Atap.Tangoservice.TangoConfig p0 = global::Java.Lang.Object.GetObject<global::Com.Google.Atap.Tangoservice.TangoConfig> (native_p0, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.SetRuntimeConfig (p0);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.atap.tangoservice']/interface[@name='ITango']/method[@name='setRuntimeConfig' and count(parameter)=1 and parameter[1][@type='com.google.atap.tangoservice.TangoConfig']]"
		[Register ("setRuntimeConfig", "(Lcom/google/atap/tangoservice/TangoConfig;)I", "GetSetRuntimeConfig_Lcom_google_atap_tangoservice_TangoConfig_Handler")]
		public abstract int SetRuntimeConfig (global::Com.Google.Atap.Tangoservice.TangoConfig p0);

	}

	[global::Android.Runtime.Register ("com/google/atap/tangoservice/ITango$Stub", DoNotGenerateAcw=true)]
	internal partial class TangoStubInvoker : TangoStub {

		public TangoStubInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		protected override global::System.Type ThresholdType {
			get { return typeof (TangoStubInvoker); }
		}

		static IntPtr id_connect_Lcom_google_atap_tangoservice_ITangoListener_Lcom_google_atap_tangoservice_TangoConfig_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.atap.tangoservice']/interface[@name='ITango']/method[@name='connect' and count(parameter)=2 and parameter[1][@type='com.google.atap.tangoservice.ITangoListener'] and parameter[2][@type='com.google.atap.tangoservice.TangoConfig']]"
		[Register ("connect", "(Lcom/google/atap/tangoservice/ITangoListener;Lcom/google/atap/tangoservice/TangoConfig;)I", "GetConnect_Lcom_google_atap_tangoservice_ITangoListener_Lcom_google_atap_tangoservice_TangoConfig_Handler")]
		public override unsafe int Connect (global::Com.Google.Atap.Tangoservice.ITangoListener p0, global::Com.Google.Atap.Tangoservice.TangoConfig p1)
		{
			if (id_connect_Lcom_google_atap_tangoservice_ITangoListener_Lcom_google_atap_tangoservice_TangoConfig_ == IntPtr.Zero)
				id_connect_Lcom_google_atap_tangoservice_ITangoListener_Lcom_google_atap_tangoservice_TangoConfig_ = JNIEnv.GetMethodID (class_ref, "connect", "(Lcom/google/atap/tangoservice/ITangoListener;Lcom/google/atap/tangoservice/TangoConfig;)I");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				int __ret = JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_connect_Lcom_google_atap_tangoservice_ITangoListener_Lcom_google_atap_tangoservice_TangoConfig_, __args);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_connectSurface_ILandroid_view_Surface_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.atap.tangoservice']/interface[@name='ITango']/method[@name='connectSurface' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='android.view.Surface']]"
		[Register ("connectSurface", "(ILandroid/view/Surface;)I", "GetConnectSurface_ILandroid_view_Surface_Handler")]
		public override unsafe int ConnectSurface (int p0, global::Android.Views.Surface p1)
		{
			if (id_connectSurface_ILandroid_view_Surface_ == IntPtr.Zero)
				id_connectSurface_ILandroid_view_Surface_ = JNIEnv.GetMethodID (class_ref, "connectSurface", "(ILandroid/view/Surface;)I");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				int __ret = JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_connectSurface_ILandroid_view_Surface_, __args);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_deleteAreaDescription_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.atap.tangoservice']/interface[@name='ITango']/method[@name='deleteAreaDescription' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("deleteAreaDescription", "(Ljava/lang/String;)I", "GetDeleteAreaDescription_Ljava_lang_String_Handler")]
		public override unsafe int DeleteAreaDescription (string p0)
		{
			if (id_deleteAreaDescription_Ljava_lang_String_ == IntPtr.Zero)
				id_deleteAreaDescription_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "deleteAreaDescription", "(Ljava/lang/String;)I");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				int __ret = JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_deleteAreaDescription_Ljava_lang_String_, __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_deleteDataset_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.atap.tangoservice']/interface[@name='ITango']/method[@name='deleteDataset' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("deleteDataset", "(Ljava/lang/String;)I", "GetDeleteDataset_Ljava_lang_String_Handler")]
		public override unsafe int DeleteDataset (string p0)
		{
			if (id_deleteDataset_Ljava_lang_String_ == IntPtr.Zero)
				id_deleteDataset_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "deleteDataset", "(Ljava/lang/String;)I");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				int __ret = JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_deleteDataset_Ljava_lang_String_, __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_disconnect;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.atap.tangoservice']/interface[@name='ITango']/method[@name='disconnect' and count(parameter)=0]"
		[Register ("disconnect", "()I", "GetDisconnectHandler")]
		public override unsafe int Disconnect ()
		{
			if (id_disconnect == IntPtr.Zero)
				id_disconnect = JNIEnv.GetMethodID (class_ref, "disconnect", "()I");
			try {
				return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_disconnect);
			} finally {
			}
		}

		static IntPtr id_disconnectSurface_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.atap.tangoservice']/interface[@name='ITango']/method[@name='disconnectSurface' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("disconnectSurface", "(I)I", "GetDisconnectSurface_IHandler")]
		public override unsafe int DisconnectSurface (int p0)
		{
			if (id_disconnectSurface_I == IntPtr.Zero)
				id_disconnectSurface_I = JNIEnv.GetMethodID (class_ref, "disconnectSurface", "(I)I");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_disconnectSurface_I, __args);
			} finally {
			}
		}

		static IntPtr id_exportAreaDescriptionFile_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.atap.tangoservice']/interface[@name='ITango']/method[@name='exportAreaDescriptionFile' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("exportAreaDescriptionFile", "(Ljava/lang/String;Ljava/lang/String;)I", "GetExportAreaDescriptionFile_Ljava_lang_String_Ljava_lang_String_Handler")]
		public override unsafe int ExportAreaDescriptionFile (string p0, string p1)
		{
			if (id_exportAreaDescriptionFile_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_exportAreaDescriptionFile_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "exportAreaDescriptionFile", "(Ljava/lang/String;Ljava/lang/String;)I");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				int __ret = JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_exportAreaDescriptionFile_Ljava_lang_String_Ljava_lang_String_, __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static IntPtr id_foiRequest_Lcom_google_atap_tangoservice_fois_FoiRequest_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.atap.tangoservice']/interface[@name='ITango']/method[@name='foiRequest' and count(parameter)=1 and parameter[1][@type='com.google.atap.tangoservice.fois.FoiRequest']]"
		[Register ("foiRequest", "(Lcom/google/atap/tangoservice/fois/FoiRequest;)I", "GetFoiRequest_Lcom_google_atap_tangoservice_fois_FoiRequest_Handler")]
		public override unsafe int FoiRequest (global::Com.Google.Atap.Tangoservice.Fois.FoiRequest p0)
		{
			if (id_foiRequest_Lcom_google_atap_tangoservice_fois_FoiRequest_ == IntPtr.Zero)
				id_foiRequest_Lcom_google_atap_tangoservice_fois_FoiRequest_ = JNIEnv.GetMethodID (class_ref, "foiRequest", "(Lcom/google/atap/tangoservice/fois/FoiRequest;)I");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				int __ret = JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_foiRequest_Lcom_google_atap_tangoservice_fois_FoiRequest_, __args);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_getAreaDescriptionUuidList_Ljava_util_List_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.atap.tangoservice']/interface[@name='ITango']/method[@name='getAreaDescriptionUuidList' and count(parameter)=1 and parameter[1][@type='java.util.List&lt;java.lang.String&gt;']]"
		[Register ("getAreaDescriptionUuidList", "(Ljava/util/List;)I", "GetGetAreaDescriptionUuidList_Ljava_util_List_Handler")]
		public override unsafe int GetAreaDescriptionUuidList (global::System.Collections.Generic.IList<string> p0)
		{
			if (id_getAreaDescriptionUuidList_Ljava_util_List_ == IntPtr.Zero)
				id_getAreaDescriptionUuidList_Ljava_util_List_ = JNIEnv.GetMethodID (class_ref, "getAreaDescriptionUuidList", "(Ljava/util/List;)I");
			IntPtr native_p0 = global::Android.Runtime.JavaList<string>.ToLocalJniHandle (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				int __ret = JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getAreaDescriptionUuidList_Ljava_util_List_, __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_getCameraIntrinsics_ILcom_google_atap_tangoservice_TangoCameraIntrinsics_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.atap.tangoservice']/interface[@name='ITango']/method[@name='getCameraIntrinsics' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='com.google.atap.tangoservice.TangoCameraIntrinsics']]"
		[Register ("getCameraIntrinsics", "(ILcom/google/atap/tangoservice/TangoCameraIntrinsics;)I", "GetGetCameraIntrinsics_ILcom_google_atap_tangoservice_TangoCameraIntrinsics_Handler")]
		public override unsafe int GetCameraIntrinsics (int p0, global::Com.Google.Atap.Tangoservice.TangoCameraIntrinsics p1)
		{
			if (id_getCameraIntrinsics_ILcom_google_atap_tangoservice_TangoCameraIntrinsics_ == IntPtr.Zero)
				id_getCameraIntrinsics_ILcom_google_atap_tangoservice_TangoCameraIntrinsics_ = JNIEnv.GetMethodID (class_ref, "getCameraIntrinsics", "(ILcom/google/atap/tangoservice/TangoCameraIntrinsics;)I");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				int __ret = JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getCameraIntrinsics_ILcom_google_atap_tangoservice_TangoCameraIntrinsics_, __args);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_getConfig_ILcom_google_atap_tangoservice_TangoConfig_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.atap.tangoservice']/interface[@name='ITango']/method[@name='getConfig' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='com.google.atap.tangoservice.TangoConfig']]"
		[Register ("getConfig", "(ILcom/google/atap/tangoservice/TangoConfig;)I", "GetGetConfig_ILcom_google_atap_tangoservice_TangoConfig_Handler")]
		public override unsafe int GetConfig (int p0, global::Com.Google.Atap.Tangoservice.TangoConfig p1)
		{
			if (id_getConfig_ILcom_google_atap_tangoservice_TangoConfig_ == IntPtr.Zero)
				id_getConfig_ILcom_google_atap_tangoservice_TangoConfig_ = JNIEnv.GetMethodID (class_ref, "getConfig", "(ILcom/google/atap/tangoservice/TangoConfig;)I");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				int __ret = JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getConfig_ILcom_google_atap_tangoservice_TangoConfig_, __args);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_getCurrentDatasetUuid_Ljava_util_List_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.atap.tangoservice']/interface[@name='ITango']/method[@name='getCurrentDatasetUuid' and count(parameter)=1 and parameter[1][@type='java.util.List&lt;java.lang.String&gt;']]"
		[Register ("getCurrentDatasetUuid", "(Ljava/util/List;)I", "GetGetCurrentDatasetUuid_Ljava_util_List_Handler")]
		public override unsafe int GetCurrentDatasetUuid (global::System.Collections.Generic.IList<string> p0)
		{
			if (id_getCurrentDatasetUuid_Ljava_util_List_ == IntPtr.Zero)
				id_getCurrentDatasetUuid_Ljava_util_List_ = JNIEnv.GetMethodID (class_ref, "getCurrentDatasetUuid", "(Ljava/util/List;)I");
			IntPtr native_p0 = global::Android.Runtime.JavaList<string>.ToLocalJniHandle (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				int __ret = JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getCurrentDatasetUuid_Ljava_util_List_, __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_getDatasetUuids_Ljava_util_List_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.atap.tangoservice']/interface[@name='ITango']/method[@name='getDatasetUuids' and count(parameter)=1 and parameter[1][@type='java.util.List&lt;java.lang.String&gt;']]"
		[Register ("getDatasetUuids", "(Ljava/util/List;)I", "GetGetDatasetUuids_Ljava_util_List_Handler")]
		public override unsafe int GetDatasetUuids (global::System.Collections.Generic.IList<string> p0)
		{
			if (id_getDatasetUuids_Ljava_util_List_ == IntPtr.Zero)
				id_getDatasetUuids_Ljava_util_List_ = JNIEnv.GetMethodID (class_ref, "getDatasetUuids", "(Ljava/util/List;)I");
			IntPtr native_p0 = global::Android.Runtime.JavaList<string>.ToLocalJniHandle (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				int __ret = JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getDatasetUuids_Ljava_util_List_, __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_getPoseAtTime2_DLjava_lang_String_Ljava_lang_String_Lcom_google_atap_tangoservice_TangoPoseData_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.atap.tangoservice']/interface[@name='ITango']/method[@name='getPoseAtTime2' and count(parameter)=4 and parameter[1][@type='double'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='com.google.atap.tangoservice.TangoPoseData']]"
		[Register ("getPoseAtTime2", "(DLjava/lang/String;Ljava/lang/String;Lcom/google/atap/tangoservice/TangoPoseData;)I", "GetGetPoseAtTime2_DLjava_lang_String_Ljava_lang_String_Lcom_google_atap_tangoservice_TangoPoseData_Handler")]
		public override unsafe int GetPoseAtTime2 (double p0, string p1, string p2, global::Com.Google.Atap.Tangoservice.TangoPoseData p3)
		{
			if (id_getPoseAtTime2_DLjava_lang_String_Ljava_lang_String_Lcom_google_atap_tangoservice_TangoPoseData_ == IntPtr.Zero)
				id_getPoseAtTime2_DLjava_lang_String_Ljava_lang_String_Lcom_google_atap_tangoservice_TangoPoseData_ = JNIEnv.GetMethodID (class_ref, "getPoseAtTime2", "(DLjava/lang/String;Ljava/lang/String;Lcom/google/atap/tangoservice/TangoPoseData;)I");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (native_p2);
				__args [3] = new JValue (p3);
				int __ret = JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getPoseAtTime2_DLjava_lang_String_Ljava_lang_String_Lcom_google_atap_tangoservice_TangoPoseData_, __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
				JNIEnv.DeleteLocalRef (native_p2);
			}
		}

		static IntPtr id_getPoseAtTime_DLcom_google_atap_tangoservice_TangoCoordinateFramePair_Lcom_google_atap_tangoservice_TangoPoseData_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.atap.tangoservice']/interface[@name='ITango']/method[@name='getPoseAtTime' and count(parameter)=3 and parameter[1][@type='double'] and parameter[2][@type='com.google.atap.tangoservice.TangoCoordinateFramePair'] and parameter[3][@type='com.google.atap.tangoservice.TangoPoseData']]"
		[Register ("getPoseAtTime", "(DLcom/google/atap/tangoservice/TangoCoordinateFramePair;Lcom/google/atap/tangoservice/TangoPoseData;)I", "GetGetPoseAtTime_DLcom_google_atap_tangoservice_TangoCoordinateFramePair_Lcom_google_atap_tangoservice_TangoPoseData_Handler")]
		public override unsafe int GetPoseAtTime (double p0, global::Com.Google.Atap.Tangoservice.TangoCoordinateFramePair p1, global::Com.Google.Atap.Tangoservice.TangoPoseData p2)
		{
			if (id_getPoseAtTime_DLcom_google_atap_tangoservice_TangoCoordinateFramePair_Lcom_google_atap_tangoservice_TangoPoseData_ == IntPtr.Zero)
				id_getPoseAtTime_DLcom_google_atap_tangoservice_TangoCoordinateFramePair_Lcom_google_atap_tangoservice_TangoPoseData_ = JNIEnv.GetMethodID (class_ref, "getPoseAtTime", "(DLcom/google/atap/tangoservice/TangoCoordinateFramePair;Lcom/google/atap/tangoservice/TangoPoseData;)I");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				int __ret = JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getPoseAtTime_DLcom_google_atap_tangoservice_TangoCoordinateFramePair_Lcom_google_atap_tangoservice_TangoPoseData_, __args);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_importAreaDescriptionFile_Ljava_util_List_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.atap.tangoservice']/interface[@name='ITango']/method[@name='importAreaDescriptionFile' and count(parameter)=2 and parameter[1][@type='java.util.List&lt;java.lang.String&gt;'] and parameter[2][@type='java.lang.String']]"
		[Register ("importAreaDescriptionFile", "(Ljava/util/List;Ljava/lang/String;)I", "GetImportAreaDescriptionFile_Ljava_util_List_Ljava_lang_String_Handler")]
		public override unsafe int ImportAreaDescriptionFile (global::System.Collections.Generic.IList<string> p0, string p1)
		{
			if (id_importAreaDescriptionFile_Ljava_util_List_Ljava_lang_String_ == IntPtr.Zero)
				id_importAreaDescriptionFile_Ljava_util_List_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "importAreaDescriptionFile", "(Ljava/util/List;Ljava/lang/String;)I");
			IntPtr native_p0 = global::Android.Runtime.JavaList<string>.ToLocalJniHandle (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				int __ret = JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_importAreaDescriptionFile_Ljava_util_List_Ljava_lang_String_, __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static IntPtr id_loadAreaDescriptionMetaData_Ljava_lang_String_Lcom_google_atap_tangoservice_TangoAreaDescriptionMetaData_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.atap.tangoservice']/interface[@name='ITango']/method[@name='loadAreaDescriptionMetaData' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='com.google.atap.tangoservice.TangoAreaDescriptionMetaData']]"
		[Register ("loadAreaDescriptionMetaData", "(Ljava/lang/String;Lcom/google/atap/tangoservice/TangoAreaDescriptionMetaData;)I", "GetLoadAreaDescriptionMetaData_Ljava_lang_String_Lcom_google_atap_tangoservice_TangoAreaDescriptionMetaData_Handler")]
		public override unsafe int LoadAreaDescriptionMetaData (string p0, global::Com.Google.Atap.Tangoservice.TangoAreaDescriptionMetaData p1)
		{
			if (id_loadAreaDescriptionMetaData_Ljava_lang_String_Lcom_google_atap_tangoservice_TangoAreaDescriptionMetaData_ == IntPtr.Zero)
				id_loadAreaDescriptionMetaData_Ljava_lang_String_Lcom_google_atap_tangoservice_TangoAreaDescriptionMetaData_ = JNIEnv.GetMethodID (class_ref, "loadAreaDescriptionMetaData", "(Ljava/lang/String;Lcom/google/atap/tangoservice/TangoAreaDescriptionMetaData;)I");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				int __ret = JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_loadAreaDescriptionMetaData_Ljava_lang_String_Lcom_google_atap_tangoservice_TangoAreaDescriptionMetaData_, __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_reportApiUsage_Lcom_google_atap_tangoservice_TangoConfig_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.atap.tangoservice']/interface[@name='ITango']/method[@name='reportApiUsage' and count(parameter)=1 and parameter[1][@type='com.google.atap.tangoservice.TangoConfig']]"
		[Register ("reportApiUsage", "(Lcom/google/atap/tangoservice/TangoConfig;)I", "GetReportApiUsage_Lcom_google_atap_tangoservice_TangoConfig_Handler")]
		public override unsafe int ReportApiUsage (global::Com.Google.Atap.Tangoservice.TangoConfig p0)
		{
			if (id_reportApiUsage_Lcom_google_atap_tangoservice_TangoConfig_ == IntPtr.Zero)
				id_reportApiUsage_Lcom_google_atap_tangoservice_TangoConfig_ = JNIEnv.GetMethodID (class_ref, "reportApiUsage", "(Lcom/google/atap/tangoservice/TangoConfig;)I");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				int __ret = JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_reportApiUsage_Lcom_google_atap_tangoservice_TangoConfig_, __args);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_resetMotionTracking;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.atap.tangoservice']/interface[@name='ITango']/method[@name='resetMotionTracking' and count(parameter)=0]"
		[Register ("resetMotionTracking", "()I", "GetResetMotionTrackingHandler")]
		public override unsafe int ResetMotionTracking ()
		{
			if (id_resetMotionTracking == IntPtr.Zero)
				id_resetMotionTracking = JNIEnv.GetMethodID (class_ref, "resetMotionTracking", "()I");
			try {
				return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_resetMotionTracking);
			} finally {
			}
		}

		static IntPtr id_saveAreaDescription_Ljava_util_List_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.atap.tangoservice']/interface[@name='ITango']/method[@name='saveAreaDescription' and count(parameter)=1 and parameter[1][@type='java.util.List&lt;java.lang.String&gt;']]"
		[Register ("saveAreaDescription", "(Ljava/util/List;)I", "GetSaveAreaDescription_Ljava_util_List_Handler")]
		public override unsafe int SaveAreaDescription (global::System.Collections.Generic.IList<string> p0)
		{
			if (id_saveAreaDescription_Ljava_util_List_ == IntPtr.Zero)
				id_saveAreaDescription_Ljava_util_List_ = JNIEnv.GetMethodID (class_ref, "saveAreaDescription", "(Ljava/util/List;)I");
			IntPtr native_p0 = global::Android.Runtime.JavaList<string>.ToLocalJniHandle (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				int __ret = JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_saveAreaDescription_Ljava_util_List_, __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_saveAreaDescriptionMetaData_Ljava_lang_String_Lcom_google_atap_tangoservice_TangoAreaDescriptionMetaData_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.atap.tangoservice']/interface[@name='ITango']/method[@name='saveAreaDescriptionMetaData' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='com.google.atap.tangoservice.TangoAreaDescriptionMetaData']]"
		[Register ("saveAreaDescriptionMetaData", "(Ljava/lang/String;Lcom/google/atap/tangoservice/TangoAreaDescriptionMetaData;)I", "GetSaveAreaDescriptionMetaData_Ljava_lang_String_Lcom_google_atap_tangoservice_TangoAreaDescriptionMetaData_Handler")]
		public override unsafe int SaveAreaDescriptionMetaData (string p0, global::Com.Google.Atap.Tangoservice.TangoAreaDescriptionMetaData p1)
		{
			if (id_saveAreaDescriptionMetaData_Ljava_lang_String_Lcom_google_atap_tangoservice_TangoAreaDescriptionMetaData_ == IntPtr.Zero)
				id_saveAreaDescriptionMetaData_Ljava_lang_String_Lcom_google_atap_tangoservice_TangoAreaDescriptionMetaData_ = JNIEnv.GetMethodID (class_ref, "saveAreaDescriptionMetaData", "(Ljava/lang/String;Lcom/google/atap/tangoservice/TangoAreaDescriptionMetaData;)I");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				int __ret = JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_saveAreaDescriptionMetaData_Ljava_lang_String_Lcom_google_atap_tangoservice_TangoAreaDescriptionMetaData_, __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_setPoseListenerFrames_Ljava_util_List_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.atap.tangoservice']/interface[@name='ITango']/method[@name='setPoseListenerFrames' and count(parameter)=1 and parameter[1][@type='java.util.List&lt;com.google.atap.tangoservice.TangoCoordinateFramePair&gt;']]"
		[Register ("setPoseListenerFrames", "(Ljava/util/List;)I", "GetSetPoseListenerFrames_Ljava_util_List_Handler")]
		public override unsafe int SetPoseListenerFrames (global::System.Collections.Generic.IList<global::Com.Google.Atap.Tangoservice.TangoCoordinateFramePair> p0)
		{
			if (id_setPoseListenerFrames_Ljava_util_List_ == IntPtr.Zero)
				id_setPoseListenerFrames_Ljava_util_List_ = JNIEnv.GetMethodID (class_ref, "setPoseListenerFrames", "(Ljava/util/List;)I");
			IntPtr native_p0 = global::Android.Runtime.JavaList<global::Com.Google.Atap.Tangoservice.TangoCoordinateFramePair>.ToLocalJniHandle (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				int __ret = JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_setPoseListenerFrames_Ljava_util_List_, __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_setRuntimeConfig_Lcom_google_atap_tangoservice_TangoConfig_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.atap.tangoservice']/interface[@name='ITango']/method[@name='setRuntimeConfig' and count(parameter)=1 and parameter[1][@type='com.google.atap.tangoservice.TangoConfig']]"
		[Register ("setRuntimeConfig", "(Lcom/google/atap/tangoservice/TangoConfig;)I", "GetSetRuntimeConfig_Lcom_google_atap_tangoservice_TangoConfig_Handler")]
		public override unsafe int SetRuntimeConfig (global::Com.Google.Atap.Tangoservice.TangoConfig p0)
		{
			if (id_setRuntimeConfig_Lcom_google_atap_tangoservice_TangoConfig_ == IntPtr.Zero)
				id_setRuntimeConfig_Lcom_google_atap_tangoservice_TangoConfig_ = JNIEnv.GetMethodID (class_ref, "setRuntimeConfig", "(Lcom/google/atap/tangoservice/TangoConfig;)I");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				int __ret = JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_setRuntimeConfig_Lcom_google_atap_tangoservice_TangoConfig_, __args);
				return __ret;
			} finally {
			}
		}

	}


	// Metadata.xml XPath interface reference: path="/api/package[@name='com.google.atap.tangoservice']/interface[@name='ITango']"
	[Register ("com/google/atap/tangoservice/ITango", "", "Com.Google.Atap.Tangoservice.ITangoInvoker")]
	public partial interface ITango : global::Android.OS.IInterface {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.atap.tangoservice']/interface[@name='ITango']/method[@name='connect' and count(parameter)=2 and parameter[1][@type='com.google.atap.tangoservice.ITangoListener'] and parameter[2][@type='com.google.atap.tangoservice.TangoConfig']]"
		[Register ("connect", "(Lcom/google/atap/tangoservice/ITangoListener;Lcom/google/atap/tangoservice/TangoConfig;)I", "GetConnect_Lcom_google_atap_tangoservice_ITangoListener_Lcom_google_atap_tangoservice_TangoConfig_Handler:Com.Google.Atap.Tangoservice.ITangoInvoker, tango-sdk-base")]
		int Connect (global::Com.Google.Atap.Tangoservice.ITangoListener p0, global::Com.Google.Atap.Tangoservice.TangoConfig p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.atap.tangoservice']/interface[@name='ITango']/method[@name='connectSurface' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='android.view.Surface']]"
		[Register ("connectSurface", "(ILandroid/view/Surface;)I", "GetConnectSurface_ILandroid_view_Surface_Handler:Com.Google.Atap.Tangoservice.ITangoInvoker, tango-sdk-base")]
		int ConnectSurface (int p0, global::Android.Views.Surface p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.atap.tangoservice']/interface[@name='ITango']/method[@name='deleteAreaDescription' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("deleteAreaDescription", "(Ljava/lang/String;)I", "GetDeleteAreaDescription_Ljava_lang_String_Handler:Com.Google.Atap.Tangoservice.ITangoInvoker, tango-sdk-base")]
		int DeleteAreaDescription (string p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.atap.tangoservice']/interface[@name='ITango']/method[@name='deleteDataset' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("deleteDataset", "(Ljava/lang/String;)I", "GetDeleteDataset_Ljava_lang_String_Handler:Com.Google.Atap.Tangoservice.ITangoInvoker, tango-sdk-base")]
		int DeleteDataset (string p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.atap.tangoservice']/interface[@name='ITango']/method[@name='disconnect' and count(parameter)=0]"
		[Register ("disconnect", "()I", "GetDisconnectHandler:Com.Google.Atap.Tangoservice.ITangoInvoker, tango-sdk-base")]
		int Disconnect ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.atap.tangoservice']/interface[@name='ITango']/method[@name='disconnectSurface' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("disconnectSurface", "(I)I", "GetDisconnectSurface_IHandler:Com.Google.Atap.Tangoservice.ITangoInvoker, tango-sdk-base")]
		int DisconnectSurface (int p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.atap.tangoservice']/interface[@name='ITango']/method[@name='exportAreaDescriptionFile' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("exportAreaDescriptionFile", "(Ljava/lang/String;Ljava/lang/String;)I", "GetExportAreaDescriptionFile_Ljava_lang_String_Ljava_lang_String_Handler:Com.Google.Atap.Tangoservice.ITangoInvoker, tango-sdk-base")]
		int ExportAreaDescriptionFile (string p0, string p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.atap.tangoservice']/interface[@name='ITango']/method[@name='foiRequest' and count(parameter)=1 and parameter[1][@type='com.google.atap.tangoservice.fois.FoiRequest']]"
		[Register ("foiRequest", "(Lcom/google/atap/tangoservice/fois/FoiRequest;)I", "GetFoiRequest_Lcom_google_atap_tangoservice_fois_FoiRequest_Handler:Com.Google.Atap.Tangoservice.ITangoInvoker, tango-sdk-base")]
		int FoiRequest (global::Com.Google.Atap.Tangoservice.Fois.FoiRequest p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.atap.tangoservice']/interface[@name='ITango']/method[@name='getAreaDescriptionUuidList' and count(parameter)=1 and parameter[1][@type='java.util.List&lt;java.lang.String&gt;']]"
		[Register ("getAreaDescriptionUuidList", "(Ljava/util/List;)I", "GetGetAreaDescriptionUuidList_Ljava_util_List_Handler:Com.Google.Atap.Tangoservice.ITangoInvoker, tango-sdk-base")]
		int GetAreaDescriptionUuidList (global::System.Collections.Generic.IList<string> p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.atap.tangoservice']/interface[@name='ITango']/method[@name='getCameraIntrinsics' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='com.google.atap.tangoservice.TangoCameraIntrinsics']]"
		[Register ("getCameraIntrinsics", "(ILcom/google/atap/tangoservice/TangoCameraIntrinsics;)I", "GetGetCameraIntrinsics_ILcom_google_atap_tangoservice_TangoCameraIntrinsics_Handler:Com.Google.Atap.Tangoservice.ITangoInvoker, tango-sdk-base")]
		int GetCameraIntrinsics (int p0, global::Com.Google.Atap.Tangoservice.TangoCameraIntrinsics p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.atap.tangoservice']/interface[@name='ITango']/method[@name='getConfig' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='com.google.atap.tangoservice.TangoConfig']]"
		[Register ("getConfig", "(ILcom/google/atap/tangoservice/TangoConfig;)I", "GetGetConfig_ILcom_google_atap_tangoservice_TangoConfig_Handler:Com.Google.Atap.Tangoservice.ITangoInvoker, tango-sdk-base")]
		int GetConfig (int p0, global::Com.Google.Atap.Tangoservice.TangoConfig p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.atap.tangoservice']/interface[@name='ITango']/method[@name='getCurrentDatasetUuid' and count(parameter)=1 and parameter[1][@type='java.util.List&lt;java.lang.String&gt;']]"
		[Register ("getCurrentDatasetUuid", "(Ljava/util/List;)I", "GetGetCurrentDatasetUuid_Ljava_util_List_Handler:Com.Google.Atap.Tangoservice.ITangoInvoker, tango-sdk-base")]
		int GetCurrentDatasetUuid (global::System.Collections.Generic.IList<string> p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.atap.tangoservice']/interface[@name='ITango']/method[@name='getDatasetUuids' and count(parameter)=1 and parameter[1][@type='java.util.List&lt;java.lang.String&gt;']]"
		[Register ("getDatasetUuids", "(Ljava/util/List;)I", "GetGetDatasetUuids_Ljava_util_List_Handler:Com.Google.Atap.Tangoservice.ITangoInvoker, tango-sdk-base")]
		int GetDatasetUuids (global::System.Collections.Generic.IList<string> p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.atap.tangoservice']/interface[@name='ITango']/method[@name='getPoseAtTime2' and count(parameter)=4 and parameter[1][@type='double'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='com.google.atap.tangoservice.TangoPoseData']]"
		[Register ("getPoseAtTime2", "(DLjava/lang/String;Ljava/lang/String;Lcom/google/atap/tangoservice/TangoPoseData;)I", "GetGetPoseAtTime2_DLjava_lang_String_Ljava_lang_String_Lcom_google_atap_tangoservice_TangoPoseData_Handler:Com.Google.Atap.Tangoservice.ITangoInvoker, tango-sdk-base")]
		int GetPoseAtTime2 (double p0, string p1, string p2, global::Com.Google.Atap.Tangoservice.TangoPoseData p3);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.atap.tangoservice']/interface[@name='ITango']/method[@name='getPoseAtTime' and count(parameter)=3 and parameter[1][@type='double'] and parameter[2][@type='com.google.atap.tangoservice.TangoCoordinateFramePair'] and parameter[3][@type='com.google.atap.tangoservice.TangoPoseData']]"
		[Register ("getPoseAtTime", "(DLcom/google/atap/tangoservice/TangoCoordinateFramePair;Lcom/google/atap/tangoservice/TangoPoseData;)I", "GetGetPoseAtTime_DLcom_google_atap_tangoservice_TangoCoordinateFramePair_Lcom_google_atap_tangoservice_TangoPoseData_Handler:Com.Google.Atap.Tangoservice.ITangoInvoker, tango-sdk-base")]
		int GetPoseAtTime (double p0, global::Com.Google.Atap.Tangoservice.TangoCoordinateFramePair p1, global::Com.Google.Atap.Tangoservice.TangoPoseData p2);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.atap.tangoservice']/interface[@name='ITango']/method[@name='importAreaDescriptionFile' and count(parameter)=2 and parameter[1][@type='java.util.List&lt;java.lang.String&gt;'] and parameter[2][@type='java.lang.String']]"
		[Register ("importAreaDescriptionFile", "(Ljava/util/List;Ljava/lang/String;)I", "GetImportAreaDescriptionFile_Ljava_util_List_Ljava_lang_String_Handler:Com.Google.Atap.Tangoservice.ITangoInvoker, tango-sdk-base")]
		int ImportAreaDescriptionFile (global::System.Collections.Generic.IList<string> p0, string p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.atap.tangoservice']/interface[@name='ITango']/method[@name='loadAreaDescriptionMetaData' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='com.google.atap.tangoservice.TangoAreaDescriptionMetaData']]"
		[Register ("loadAreaDescriptionMetaData", "(Ljava/lang/String;Lcom/google/atap/tangoservice/TangoAreaDescriptionMetaData;)I", "GetLoadAreaDescriptionMetaData_Ljava_lang_String_Lcom_google_atap_tangoservice_TangoAreaDescriptionMetaData_Handler:Com.Google.Atap.Tangoservice.ITangoInvoker, tango-sdk-base")]
		int LoadAreaDescriptionMetaData (string p0, global::Com.Google.Atap.Tangoservice.TangoAreaDescriptionMetaData p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.atap.tangoservice']/interface[@name='ITango']/method[@name='reportApiUsage' and count(parameter)=1 and parameter[1][@type='com.google.atap.tangoservice.TangoConfig']]"
		[Register ("reportApiUsage", "(Lcom/google/atap/tangoservice/TangoConfig;)I", "GetReportApiUsage_Lcom_google_atap_tangoservice_TangoConfig_Handler:Com.Google.Atap.Tangoservice.ITangoInvoker, tango-sdk-base")]
		int ReportApiUsage (global::Com.Google.Atap.Tangoservice.TangoConfig p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.atap.tangoservice']/interface[@name='ITango']/method[@name='resetMotionTracking' and count(parameter)=0]"
		[Register ("resetMotionTracking", "()I", "GetResetMotionTrackingHandler:Com.Google.Atap.Tangoservice.ITangoInvoker, tango-sdk-base")]
		int ResetMotionTracking ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.atap.tangoservice']/interface[@name='ITango']/method[@name='saveAreaDescription' and count(parameter)=1 and parameter[1][@type='java.util.List&lt;java.lang.String&gt;']]"
		[Register ("saveAreaDescription", "(Ljava/util/List;)I", "GetSaveAreaDescription_Ljava_util_List_Handler:Com.Google.Atap.Tangoservice.ITangoInvoker, tango-sdk-base")]
		int SaveAreaDescription (global::System.Collections.Generic.IList<string> p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.atap.tangoservice']/interface[@name='ITango']/method[@name='saveAreaDescriptionMetaData' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='com.google.atap.tangoservice.TangoAreaDescriptionMetaData']]"
		[Register ("saveAreaDescriptionMetaData", "(Ljava/lang/String;Lcom/google/atap/tangoservice/TangoAreaDescriptionMetaData;)I", "GetSaveAreaDescriptionMetaData_Ljava_lang_String_Lcom_google_atap_tangoservice_TangoAreaDescriptionMetaData_Handler:Com.Google.Atap.Tangoservice.ITangoInvoker, tango-sdk-base")]
		int SaveAreaDescriptionMetaData (string p0, global::Com.Google.Atap.Tangoservice.TangoAreaDescriptionMetaData p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.atap.tangoservice']/interface[@name='ITango']/method[@name='setPoseListenerFrames' and count(parameter)=1 and parameter[1][@type='java.util.List&lt;com.google.atap.tangoservice.TangoCoordinateFramePair&gt;']]"
		[Register ("setPoseListenerFrames", "(Ljava/util/List;)I", "GetSetPoseListenerFrames_Ljava_util_List_Handler:Com.Google.Atap.Tangoservice.ITangoInvoker, tango-sdk-base")]
		int SetPoseListenerFrames (global::System.Collections.Generic.IList<global::Com.Google.Atap.Tangoservice.TangoCoordinateFramePair> p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.atap.tangoservice']/interface[@name='ITango']/method[@name='setRuntimeConfig' and count(parameter)=1 and parameter[1][@type='com.google.atap.tangoservice.TangoConfig']]"
		[Register ("setRuntimeConfig", "(Lcom/google/atap/tangoservice/TangoConfig;)I", "GetSetRuntimeConfig_Lcom_google_atap_tangoservice_TangoConfig_Handler:Com.Google.Atap.Tangoservice.ITangoInvoker, tango-sdk-base")]
		int SetRuntimeConfig (global::Com.Google.Atap.Tangoservice.TangoConfig p0);

	}

	[global::Android.Runtime.Register ("com/google/atap/tangoservice/ITango", DoNotGenerateAcw=true)]
	internal class ITangoInvoker : global::Java.Lang.Object, ITango {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/google/atap/tangoservice/ITango");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ITangoInvoker); }
		}

		IntPtr class_ref;

		public static ITango GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<ITango> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.google.atap.tangoservice.ITango"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public ITangoInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_connect_Lcom_google_atap_tangoservice_ITangoListener_Lcom_google_atap_tangoservice_TangoConfig_;
#pragma warning disable 0169
		static Delegate GetConnect_Lcom_google_atap_tangoservice_ITangoListener_Lcom_google_atap_tangoservice_TangoConfig_Handler ()
		{
			if (cb_connect_Lcom_google_atap_tangoservice_ITangoListener_Lcom_google_atap_tangoservice_TangoConfig_ == null)
				cb_connect_Lcom_google_atap_tangoservice_ITangoListener_Lcom_google_atap_tangoservice_TangoConfig_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, int>) n_Connect_Lcom_google_atap_tangoservice_ITangoListener_Lcom_google_atap_tangoservice_TangoConfig_);
			return cb_connect_Lcom_google_atap_tangoservice_ITangoListener_Lcom_google_atap_tangoservice_TangoConfig_;
		}

		static int n_Connect_Lcom_google_atap_tangoservice_ITangoListener_Lcom_google_atap_tangoservice_TangoConfig_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Google.Atap.Tangoservice.ITango __this = global::Java.Lang.Object.GetObject<global::Com.Google.Atap.Tangoservice.ITango> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Google.Atap.Tangoservice.ITangoListener p0 = (global::Com.Google.Atap.Tangoservice.ITangoListener)global::Java.Lang.Object.GetObject<global::Com.Google.Atap.Tangoservice.ITangoListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Google.Atap.Tangoservice.TangoConfig p1 = global::Java.Lang.Object.GetObject<global::Com.Google.Atap.Tangoservice.TangoConfig> (native_p1, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.Connect (p0, p1);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_connect_Lcom_google_atap_tangoservice_ITangoListener_Lcom_google_atap_tangoservice_TangoConfig_;
		public unsafe int Connect (global::Com.Google.Atap.Tangoservice.ITangoListener p0, global::Com.Google.Atap.Tangoservice.TangoConfig p1)
		{
			if (id_connect_Lcom_google_atap_tangoservice_ITangoListener_Lcom_google_atap_tangoservice_TangoConfig_ == IntPtr.Zero)
				id_connect_Lcom_google_atap_tangoservice_ITangoListener_Lcom_google_atap_tangoservice_TangoConfig_ = JNIEnv.GetMethodID (class_ref, "connect", "(Lcom/google/atap/tangoservice/ITangoListener;Lcom/google/atap/tangoservice/TangoConfig;)I");
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (p1);
			int __ret = JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_connect_Lcom_google_atap_tangoservice_ITangoListener_Lcom_google_atap_tangoservice_TangoConfig_, __args);
			return __ret;
		}

		static Delegate cb_connectSurface_ILandroid_view_Surface_;
#pragma warning disable 0169
		static Delegate GetConnectSurface_ILandroid_view_Surface_Handler ()
		{
			if (cb_connectSurface_ILandroid_view_Surface_ == null)
				cb_connectSurface_ILandroid_view_Surface_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr, int>) n_ConnectSurface_ILandroid_view_Surface_);
			return cb_connectSurface_ILandroid_view_Surface_;
		}

		static int n_ConnectSurface_ILandroid_view_Surface_ (IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1)
		{
			global::Com.Google.Atap.Tangoservice.ITango __this = global::Java.Lang.Object.GetObject<global::Com.Google.Atap.Tangoservice.ITango> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.Surface p1 = global::Java.Lang.Object.GetObject<global::Android.Views.Surface> (native_p1, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.ConnectSurface (p0, p1);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_connectSurface_ILandroid_view_Surface_;
		public unsafe int ConnectSurface (int p0, global::Android.Views.Surface p1)
		{
			if (id_connectSurface_ILandroid_view_Surface_ == IntPtr.Zero)
				id_connectSurface_ILandroid_view_Surface_ = JNIEnv.GetMethodID (class_ref, "connectSurface", "(ILandroid/view/Surface;)I");
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (p1);
			int __ret = JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_connectSurface_ILandroid_view_Surface_, __args);
			return __ret;
		}

		static Delegate cb_deleteAreaDescription_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetDeleteAreaDescription_Ljava_lang_String_Handler ()
		{
			if (cb_deleteAreaDescription_Ljava_lang_String_ == null)
				cb_deleteAreaDescription_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, int>) n_DeleteAreaDescription_Ljava_lang_String_);
			return cb_deleteAreaDescription_Ljava_lang_String_;
		}

		static int n_DeleteAreaDescription_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Google.Atap.Tangoservice.ITango __this = global::Java.Lang.Object.GetObject<global::Com.Google.Atap.Tangoservice.ITango> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.DeleteAreaDescription (p0);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_deleteAreaDescription_Ljava_lang_String_;
		public unsafe int DeleteAreaDescription (string p0)
		{
			if (id_deleteAreaDescription_Ljava_lang_String_ == IntPtr.Zero)
				id_deleteAreaDescription_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "deleteAreaDescription", "(Ljava/lang/String;)I");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			int __ret = JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_deleteAreaDescription_Ljava_lang_String_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static Delegate cb_deleteDataset_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetDeleteDataset_Ljava_lang_String_Handler ()
		{
			if (cb_deleteDataset_Ljava_lang_String_ == null)
				cb_deleteDataset_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, int>) n_DeleteDataset_Ljava_lang_String_);
			return cb_deleteDataset_Ljava_lang_String_;
		}

		static int n_DeleteDataset_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Google.Atap.Tangoservice.ITango __this = global::Java.Lang.Object.GetObject<global::Com.Google.Atap.Tangoservice.ITango> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.DeleteDataset (p0);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_deleteDataset_Ljava_lang_String_;
		public unsafe int DeleteDataset (string p0)
		{
			if (id_deleteDataset_Ljava_lang_String_ == IntPtr.Zero)
				id_deleteDataset_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "deleteDataset", "(Ljava/lang/String;)I");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			int __ret = JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_deleteDataset_Ljava_lang_String_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static Delegate cb_disconnect;
#pragma warning disable 0169
		static Delegate GetDisconnectHandler ()
		{
			if (cb_disconnect == null)
				cb_disconnect = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_Disconnect);
			return cb_disconnect;
		}

		static int n_Disconnect (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Google.Atap.Tangoservice.ITango __this = global::Java.Lang.Object.GetObject<global::Com.Google.Atap.Tangoservice.ITango> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Disconnect ();
		}
#pragma warning restore 0169

		IntPtr id_disconnect;
		public unsafe int Disconnect ()
		{
			if (id_disconnect == IntPtr.Zero)
				id_disconnect = JNIEnv.GetMethodID (class_ref, "disconnect", "()I");
			return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_disconnect);
		}

		static Delegate cb_disconnectSurface_I;
#pragma warning disable 0169
		static Delegate GetDisconnectSurface_IHandler ()
		{
			if (cb_disconnectSurface_I == null)
				cb_disconnectSurface_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, int>) n_DisconnectSurface_I);
			return cb_disconnectSurface_I;
		}

		static int n_DisconnectSurface_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Google.Atap.Tangoservice.ITango __this = global::Java.Lang.Object.GetObject<global::Com.Google.Atap.Tangoservice.ITango> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.DisconnectSurface (p0);
		}
#pragma warning restore 0169

		IntPtr id_disconnectSurface_I;
		public unsafe int DisconnectSurface (int p0)
		{
			if (id_disconnectSurface_I == IntPtr.Zero)
				id_disconnectSurface_I = JNIEnv.GetMethodID (class_ref, "disconnectSurface", "(I)I");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_disconnectSurface_I, __args);
		}

		static Delegate cb_exportAreaDescriptionFile_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetExportAreaDescriptionFile_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_exportAreaDescriptionFile_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_exportAreaDescriptionFile_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, int>) n_ExportAreaDescriptionFile_Ljava_lang_String_Ljava_lang_String_);
			return cb_exportAreaDescriptionFile_Ljava_lang_String_Ljava_lang_String_;
		}

		static int n_ExportAreaDescriptionFile_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Google.Atap.Tangoservice.ITango __this = global::Java.Lang.Object.GetObject<global::Com.Google.Atap.Tangoservice.ITango> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.ExportAreaDescriptionFile (p0, p1);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_exportAreaDescriptionFile_Ljava_lang_String_Ljava_lang_String_;
		public unsafe int ExportAreaDescriptionFile (string p0, string p1)
		{
			if (id_exportAreaDescriptionFile_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_exportAreaDescriptionFile_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "exportAreaDescriptionFile", "(Ljava/lang/String;Ljava/lang/String;)I");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue (native_p1);
			int __ret = JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_exportAreaDescriptionFile_Ljava_lang_String_Ljava_lang_String_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
			JNIEnv.DeleteLocalRef (native_p1);
			return __ret;
		}

		static Delegate cb_foiRequest_Lcom_google_atap_tangoservice_fois_FoiRequest_;
#pragma warning disable 0169
		static Delegate GetFoiRequest_Lcom_google_atap_tangoservice_fois_FoiRequest_Handler ()
		{
			if (cb_foiRequest_Lcom_google_atap_tangoservice_fois_FoiRequest_ == null)
				cb_foiRequest_Lcom_google_atap_tangoservice_fois_FoiRequest_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, int>) n_FoiRequest_Lcom_google_atap_tangoservice_fois_FoiRequest_);
			return cb_foiRequest_Lcom_google_atap_tangoservice_fois_FoiRequest_;
		}

		static int n_FoiRequest_Lcom_google_atap_tangoservice_fois_FoiRequest_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Google.Atap.Tangoservice.ITango __this = global::Java.Lang.Object.GetObject<global::Com.Google.Atap.Tangoservice.ITango> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Google.Atap.Tangoservice.Fois.FoiRequest p0 = global::Java.Lang.Object.GetObject<global::Com.Google.Atap.Tangoservice.Fois.FoiRequest> (native_p0, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.FoiRequest (p0);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_foiRequest_Lcom_google_atap_tangoservice_fois_FoiRequest_;
		public unsafe int FoiRequest (global::Com.Google.Atap.Tangoservice.Fois.FoiRequest p0)
		{
			if (id_foiRequest_Lcom_google_atap_tangoservice_fois_FoiRequest_ == IntPtr.Zero)
				id_foiRequest_Lcom_google_atap_tangoservice_fois_FoiRequest_ = JNIEnv.GetMethodID (class_ref, "foiRequest", "(Lcom/google/atap/tangoservice/fois/FoiRequest;)I");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			int __ret = JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_foiRequest_Lcom_google_atap_tangoservice_fois_FoiRequest_, __args);
			return __ret;
		}

		static Delegate cb_getAreaDescriptionUuidList_Ljava_util_List_;
#pragma warning disable 0169
		static Delegate GetGetAreaDescriptionUuidList_Ljava_util_List_Handler ()
		{
			if (cb_getAreaDescriptionUuidList_Ljava_util_List_ == null)
				cb_getAreaDescriptionUuidList_Ljava_util_List_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, int>) n_GetAreaDescriptionUuidList_Ljava_util_List_);
			return cb_getAreaDescriptionUuidList_Ljava_util_List_;
		}

		static int n_GetAreaDescriptionUuidList_Ljava_util_List_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Google.Atap.Tangoservice.ITango __this = global::Java.Lang.Object.GetObject<global::Com.Google.Atap.Tangoservice.ITango> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Android.Runtime.JavaList<string>.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.GetAreaDescriptionUuidList (p0);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_getAreaDescriptionUuidList_Ljava_util_List_;
		public unsafe int GetAreaDescriptionUuidList (global::System.Collections.Generic.IList<string> p0)
		{
			if (id_getAreaDescriptionUuidList_Ljava_util_List_ == IntPtr.Zero)
				id_getAreaDescriptionUuidList_Ljava_util_List_ = JNIEnv.GetMethodID (class_ref, "getAreaDescriptionUuidList", "(Ljava/util/List;)I");
			IntPtr native_p0 = global::Android.Runtime.JavaList<string>.ToLocalJniHandle (p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			int __ret = JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getAreaDescriptionUuidList_Ljava_util_List_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static Delegate cb_getCameraIntrinsics_ILcom_google_atap_tangoservice_TangoCameraIntrinsics_;
#pragma warning disable 0169
		static Delegate GetGetCameraIntrinsics_ILcom_google_atap_tangoservice_TangoCameraIntrinsics_Handler ()
		{
			if (cb_getCameraIntrinsics_ILcom_google_atap_tangoservice_TangoCameraIntrinsics_ == null)
				cb_getCameraIntrinsics_ILcom_google_atap_tangoservice_TangoCameraIntrinsics_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr, int>) n_GetCameraIntrinsics_ILcom_google_atap_tangoservice_TangoCameraIntrinsics_);
			return cb_getCameraIntrinsics_ILcom_google_atap_tangoservice_TangoCameraIntrinsics_;
		}

		static int n_GetCameraIntrinsics_ILcom_google_atap_tangoservice_TangoCameraIntrinsics_ (IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1)
		{
			global::Com.Google.Atap.Tangoservice.ITango __this = global::Java.Lang.Object.GetObject<global::Com.Google.Atap.Tangoservice.ITango> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Google.Atap.Tangoservice.TangoCameraIntrinsics p1 = global::Java.Lang.Object.GetObject<global::Com.Google.Atap.Tangoservice.TangoCameraIntrinsics> (native_p1, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.GetCameraIntrinsics (p0, p1);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_getCameraIntrinsics_ILcom_google_atap_tangoservice_TangoCameraIntrinsics_;
		public unsafe int GetCameraIntrinsics (int p0, global::Com.Google.Atap.Tangoservice.TangoCameraIntrinsics p1)
		{
			if (id_getCameraIntrinsics_ILcom_google_atap_tangoservice_TangoCameraIntrinsics_ == IntPtr.Zero)
				id_getCameraIntrinsics_ILcom_google_atap_tangoservice_TangoCameraIntrinsics_ = JNIEnv.GetMethodID (class_ref, "getCameraIntrinsics", "(ILcom/google/atap/tangoservice/TangoCameraIntrinsics;)I");
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (p1);
			int __ret = JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getCameraIntrinsics_ILcom_google_atap_tangoservice_TangoCameraIntrinsics_, __args);
			return __ret;
		}

		static Delegate cb_getConfig_ILcom_google_atap_tangoservice_TangoConfig_;
#pragma warning disable 0169
		static Delegate GetGetConfig_ILcom_google_atap_tangoservice_TangoConfig_Handler ()
		{
			if (cb_getConfig_ILcom_google_atap_tangoservice_TangoConfig_ == null)
				cb_getConfig_ILcom_google_atap_tangoservice_TangoConfig_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr, int>) n_GetConfig_ILcom_google_atap_tangoservice_TangoConfig_);
			return cb_getConfig_ILcom_google_atap_tangoservice_TangoConfig_;
		}

		static int n_GetConfig_ILcom_google_atap_tangoservice_TangoConfig_ (IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1)
		{
			global::Com.Google.Atap.Tangoservice.ITango __this = global::Java.Lang.Object.GetObject<global::Com.Google.Atap.Tangoservice.ITango> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Google.Atap.Tangoservice.TangoConfig p1 = global::Java.Lang.Object.GetObject<global::Com.Google.Atap.Tangoservice.TangoConfig> (native_p1, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.GetConfig (p0, p1);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_getConfig_ILcom_google_atap_tangoservice_TangoConfig_;
		public unsafe int GetConfig (int p0, global::Com.Google.Atap.Tangoservice.TangoConfig p1)
		{
			if (id_getConfig_ILcom_google_atap_tangoservice_TangoConfig_ == IntPtr.Zero)
				id_getConfig_ILcom_google_atap_tangoservice_TangoConfig_ = JNIEnv.GetMethodID (class_ref, "getConfig", "(ILcom/google/atap/tangoservice/TangoConfig;)I");
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (p1);
			int __ret = JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getConfig_ILcom_google_atap_tangoservice_TangoConfig_, __args);
			return __ret;
		}

		static Delegate cb_getCurrentDatasetUuid_Ljava_util_List_;
#pragma warning disable 0169
		static Delegate GetGetCurrentDatasetUuid_Ljava_util_List_Handler ()
		{
			if (cb_getCurrentDatasetUuid_Ljava_util_List_ == null)
				cb_getCurrentDatasetUuid_Ljava_util_List_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, int>) n_GetCurrentDatasetUuid_Ljava_util_List_);
			return cb_getCurrentDatasetUuid_Ljava_util_List_;
		}

		static int n_GetCurrentDatasetUuid_Ljava_util_List_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Google.Atap.Tangoservice.ITango __this = global::Java.Lang.Object.GetObject<global::Com.Google.Atap.Tangoservice.ITango> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Android.Runtime.JavaList<string>.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.GetCurrentDatasetUuid (p0);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_getCurrentDatasetUuid_Ljava_util_List_;
		public unsafe int GetCurrentDatasetUuid (global::System.Collections.Generic.IList<string> p0)
		{
			if (id_getCurrentDatasetUuid_Ljava_util_List_ == IntPtr.Zero)
				id_getCurrentDatasetUuid_Ljava_util_List_ = JNIEnv.GetMethodID (class_ref, "getCurrentDatasetUuid", "(Ljava/util/List;)I");
			IntPtr native_p0 = global::Android.Runtime.JavaList<string>.ToLocalJniHandle (p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			int __ret = JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getCurrentDatasetUuid_Ljava_util_List_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static Delegate cb_getDatasetUuids_Ljava_util_List_;
#pragma warning disable 0169
		static Delegate GetGetDatasetUuids_Ljava_util_List_Handler ()
		{
			if (cb_getDatasetUuids_Ljava_util_List_ == null)
				cb_getDatasetUuids_Ljava_util_List_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, int>) n_GetDatasetUuids_Ljava_util_List_);
			return cb_getDatasetUuids_Ljava_util_List_;
		}

		static int n_GetDatasetUuids_Ljava_util_List_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Google.Atap.Tangoservice.ITango __this = global::Java.Lang.Object.GetObject<global::Com.Google.Atap.Tangoservice.ITango> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Android.Runtime.JavaList<string>.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.GetDatasetUuids (p0);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_getDatasetUuids_Ljava_util_List_;
		public unsafe int GetDatasetUuids (global::System.Collections.Generic.IList<string> p0)
		{
			if (id_getDatasetUuids_Ljava_util_List_ == IntPtr.Zero)
				id_getDatasetUuids_Ljava_util_List_ = JNIEnv.GetMethodID (class_ref, "getDatasetUuids", "(Ljava/util/List;)I");
			IntPtr native_p0 = global::Android.Runtime.JavaList<string>.ToLocalJniHandle (p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			int __ret = JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getDatasetUuids_Ljava_util_List_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static Delegate cb_getPoseAtTime2_DLjava_lang_String_Ljava_lang_String_Lcom_google_atap_tangoservice_TangoPoseData_;
#pragma warning disable 0169
		static Delegate GetGetPoseAtTime2_DLjava_lang_String_Ljava_lang_String_Lcom_google_atap_tangoservice_TangoPoseData_Handler ()
		{
			if (cb_getPoseAtTime2_DLjava_lang_String_Ljava_lang_String_Lcom_google_atap_tangoservice_TangoPoseData_ == null)
				cb_getPoseAtTime2_DLjava_lang_String_Ljava_lang_String_Lcom_google_atap_tangoservice_TangoPoseData_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, double, IntPtr, IntPtr, IntPtr, int>) n_GetPoseAtTime2_DLjava_lang_String_Ljava_lang_String_Lcom_google_atap_tangoservice_TangoPoseData_);
			return cb_getPoseAtTime2_DLjava_lang_String_Ljava_lang_String_Lcom_google_atap_tangoservice_TangoPoseData_;
		}

		static int n_GetPoseAtTime2_DLjava_lang_String_Ljava_lang_String_Lcom_google_atap_tangoservice_TangoPoseData_ (IntPtr jnienv, IntPtr native__this, double p0, IntPtr native_p1, IntPtr native_p2, IntPtr native_p3)
		{
			global::Com.Google.Atap.Tangoservice.ITango __this = global::Java.Lang.Object.GetObject<global::Com.Google.Atap.Tangoservice.ITango> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			string p2 = JNIEnv.GetString (native_p2, JniHandleOwnership.DoNotTransfer);
			global::Com.Google.Atap.Tangoservice.TangoPoseData p3 = global::Java.Lang.Object.GetObject<global::Com.Google.Atap.Tangoservice.TangoPoseData> (native_p3, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.GetPoseAtTime2 (p0, p1, p2, p3);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_getPoseAtTime2_DLjava_lang_String_Ljava_lang_String_Lcom_google_atap_tangoservice_TangoPoseData_;
		public unsafe int GetPoseAtTime2 (double p0, string p1, string p2, global::Com.Google.Atap.Tangoservice.TangoPoseData p3)
		{
			if (id_getPoseAtTime2_DLjava_lang_String_Ljava_lang_String_Lcom_google_atap_tangoservice_TangoPoseData_ == IntPtr.Zero)
				id_getPoseAtTime2_DLjava_lang_String_Ljava_lang_String_Lcom_google_atap_tangoservice_TangoPoseData_ = JNIEnv.GetMethodID (class_ref, "getPoseAtTime2", "(DLjava/lang/String;Ljava/lang/String;Lcom/google/atap/tangoservice/TangoPoseData;)I");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			JValue* __args = stackalloc JValue [4];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (native_p1);
			__args [2] = new JValue (native_p2);
			__args [3] = new JValue (p3);
			int __ret = JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getPoseAtTime2_DLjava_lang_String_Ljava_lang_String_Lcom_google_atap_tangoservice_TangoPoseData_, __args);
			JNIEnv.DeleteLocalRef (native_p1);
			JNIEnv.DeleteLocalRef (native_p2);
			return __ret;
		}

		static Delegate cb_getPoseAtTime_DLcom_google_atap_tangoservice_TangoCoordinateFramePair_Lcom_google_atap_tangoservice_TangoPoseData_;
#pragma warning disable 0169
		static Delegate GetGetPoseAtTime_DLcom_google_atap_tangoservice_TangoCoordinateFramePair_Lcom_google_atap_tangoservice_TangoPoseData_Handler ()
		{
			if (cb_getPoseAtTime_DLcom_google_atap_tangoservice_TangoCoordinateFramePair_Lcom_google_atap_tangoservice_TangoPoseData_ == null)
				cb_getPoseAtTime_DLcom_google_atap_tangoservice_TangoCoordinateFramePair_Lcom_google_atap_tangoservice_TangoPoseData_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, double, IntPtr, IntPtr, int>) n_GetPoseAtTime_DLcom_google_atap_tangoservice_TangoCoordinateFramePair_Lcom_google_atap_tangoservice_TangoPoseData_);
			return cb_getPoseAtTime_DLcom_google_atap_tangoservice_TangoCoordinateFramePair_Lcom_google_atap_tangoservice_TangoPoseData_;
		}

		static int n_GetPoseAtTime_DLcom_google_atap_tangoservice_TangoCoordinateFramePair_Lcom_google_atap_tangoservice_TangoPoseData_ (IntPtr jnienv, IntPtr native__this, double p0, IntPtr native_p1, IntPtr native_p2)
		{
			global::Com.Google.Atap.Tangoservice.ITango __this = global::Java.Lang.Object.GetObject<global::Com.Google.Atap.Tangoservice.ITango> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Google.Atap.Tangoservice.TangoCoordinateFramePair p1 = global::Java.Lang.Object.GetObject<global::Com.Google.Atap.Tangoservice.TangoCoordinateFramePair> (native_p1, JniHandleOwnership.DoNotTransfer);
			global::Com.Google.Atap.Tangoservice.TangoPoseData p2 = global::Java.Lang.Object.GetObject<global::Com.Google.Atap.Tangoservice.TangoPoseData> (native_p2, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.GetPoseAtTime (p0, p1, p2);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_getPoseAtTime_DLcom_google_atap_tangoservice_TangoCoordinateFramePair_Lcom_google_atap_tangoservice_TangoPoseData_;
		public unsafe int GetPoseAtTime (double p0, global::Com.Google.Atap.Tangoservice.TangoCoordinateFramePair p1, global::Com.Google.Atap.Tangoservice.TangoPoseData p2)
		{
			if (id_getPoseAtTime_DLcom_google_atap_tangoservice_TangoCoordinateFramePair_Lcom_google_atap_tangoservice_TangoPoseData_ == IntPtr.Zero)
				id_getPoseAtTime_DLcom_google_atap_tangoservice_TangoCoordinateFramePair_Lcom_google_atap_tangoservice_TangoPoseData_ = JNIEnv.GetMethodID (class_ref, "getPoseAtTime", "(DLcom/google/atap/tangoservice/TangoCoordinateFramePair;Lcom/google/atap/tangoservice/TangoPoseData;)I");
			JValue* __args = stackalloc JValue [3];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (p1);
			__args [2] = new JValue (p2);
			int __ret = JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getPoseAtTime_DLcom_google_atap_tangoservice_TangoCoordinateFramePair_Lcom_google_atap_tangoservice_TangoPoseData_, __args);
			return __ret;
		}

		static Delegate cb_importAreaDescriptionFile_Ljava_util_List_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetImportAreaDescriptionFile_Ljava_util_List_Ljava_lang_String_Handler ()
		{
			if (cb_importAreaDescriptionFile_Ljava_util_List_Ljava_lang_String_ == null)
				cb_importAreaDescriptionFile_Ljava_util_List_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, int>) n_ImportAreaDescriptionFile_Ljava_util_List_Ljava_lang_String_);
			return cb_importAreaDescriptionFile_Ljava_util_List_Ljava_lang_String_;
		}

		static int n_ImportAreaDescriptionFile_Ljava_util_List_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Google.Atap.Tangoservice.ITango __this = global::Java.Lang.Object.GetObject<global::Com.Google.Atap.Tangoservice.ITango> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Android.Runtime.JavaList<string>.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.ImportAreaDescriptionFile (p0, p1);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_importAreaDescriptionFile_Ljava_util_List_Ljava_lang_String_;
		public unsafe int ImportAreaDescriptionFile (global::System.Collections.Generic.IList<string> p0, string p1)
		{
			if (id_importAreaDescriptionFile_Ljava_util_List_Ljava_lang_String_ == IntPtr.Zero)
				id_importAreaDescriptionFile_Ljava_util_List_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "importAreaDescriptionFile", "(Ljava/util/List;Ljava/lang/String;)I");
			IntPtr native_p0 = global::Android.Runtime.JavaList<string>.ToLocalJniHandle (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue (native_p1);
			int __ret = JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_importAreaDescriptionFile_Ljava_util_List_Ljava_lang_String_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
			JNIEnv.DeleteLocalRef (native_p1);
			return __ret;
		}

		static Delegate cb_loadAreaDescriptionMetaData_Ljava_lang_String_Lcom_google_atap_tangoservice_TangoAreaDescriptionMetaData_;
#pragma warning disable 0169
		static Delegate GetLoadAreaDescriptionMetaData_Ljava_lang_String_Lcom_google_atap_tangoservice_TangoAreaDescriptionMetaData_Handler ()
		{
			if (cb_loadAreaDescriptionMetaData_Ljava_lang_String_Lcom_google_atap_tangoservice_TangoAreaDescriptionMetaData_ == null)
				cb_loadAreaDescriptionMetaData_Ljava_lang_String_Lcom_google_atap_tangoservice_TangoAreaDescriptionMetaData_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, int>) n_LoadAreaDescriptionMetaData_Ljava_lang_String_Lcom_google_atap_tangoservice_TangoAreaDescriptionMetaData_);
			return cb_loadAreaDescriptionMetaData_Ljava_lang_String_Lcom_google_atap_tangoservice_TangoAreaDescriptionMetaData_;
		}

		static int n_LoadAreaDescriptionMetaData_Ljava_lang_String_Lcom_google_atap_tangoservice_TangoAreaDescriptionMetaData_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Google.Atap.Tangoservice.ITango __this = global::Java.Lang.Object.GetObject<global::Com.Google.Atap.Tangoservice.ITango> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Google.Atap.Tangoservice.TangoAreaDescriptionMetaData p1 = global::Java.Lang.Object.GetObject<global::Com.Google.Atap.Tangoservice.TangoAreaDescriptionMetaData> (native_p1, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.LoadAreaDescriptionMetaData (p0, p1);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_loadAreaDescriptionMetaData_Ljava_lang_String_Lcom_google_atap_tangoservice_TangoAreaDescriptionMetaData_;
		public unsafe int LoadAreaDescriptionMetaData (string p0, global::Com.Google.Atap.Tangoservice.TangoAreaDescriptionMetaData p1)
		{
			if (id_loadAreaDescriptionMetaData_Ljava_lang_String_Lcom_google_atap_tangoservice_TangoAreaDescriptionMetaData_ == IntPtr.Zero)
				id_loadAreaDescriptionMetaData_Ljava_lang_String_Lcom_google_atap_tangoservice_TangoAreaDescriptionMetaData_ = JNIEnv.GetMethodID (class_ref, "loadAreaDescriptionMetaData", "(Ljava/lang/String;Lcom/google/atap/tangoservice/TangoAreaDescriptionMetaData;)I");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue (p1);
			int __ret = JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_loadAreaDescriptionMetaData_Ljava_lang_String_Lcom_google_atap_tangoservice_TangoAreaDescriptionMetaData_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static Delegate cb_reportApiUsage_Lcom_google_atap_tangoservice_TangoConfig_;
#pragma warning disable 0169
		static Delegate GetReportApiUsage_Lcom_google_atap_tangoservice_TangoConfig_Handler ()
		{
			if (cb_reportApiUsage_Lcom_google_atap_tangoservice_TangoConfig_ == null)
				cb_reportApiUsage_Lcom_google_atap_tangoservice_TangoConfig_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, int>) n_ReportApiUsage_Lcom_google_atap_tangoservice_TangoConfig_);
			return cb_reportApiUsage_Lcom_google_atap_tangoservice_TangoConfig_;
		}

		static int n_ReportApiUsage_Lcom_google_atap_tangoservice_TangoConfig_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Google.Atap.Tangoservice.ITango __this = global::Java.Lang.Object.GetObject<global::Com.Google.Atap.Tangoservice.ITango> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Google.Atap.Tangoservice.TangoConfig p0 = global::Java.Lang.Object.GetObject<global::Com.Google.Atap.Tangoservice.TangoConfig> (native_p0, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.ReportApiUsage (p0);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_reportApiUsage_Lcom_google_atap_tangoservice_TangoConfig_;
		public unsafe int ReportApiUsage (global::Com.Google.Atap.Tangoservice.TangoConfig p0)
		{
			if (id_reportApiUsage_Lcom_google_atap_tangoservice_TangoConfig_ == IntPtr.Zero)
				id_reportApiUsage_Lcom_google_atap_tangoservice_TangoConfig_ = JNIEnv.GetMethodID (class_ref, "reportApiUsage", "(Lcom/google/atap/tangoservice/TangoConfig;)I");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			int __ret = JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_reportApiUsage_Lcom_google_atap_tangoservice_TangoConfig_, __args);
			return __ret;
		}

		static Delegate cb_resetMotionTracking;
#pragma warning disable 0169
		static Delegate GetResetMotionTrackingHandler ()
		{
			if (cb_resetMotionTracking == null)
				cb_resetMotionTracking = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_ResetMotionTracking);
			return cb_resetMotionTracking;
		}

		static int n_ResetMotionTracking (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Google.Atap.Tangoservice.ITango __this = global::Java.Lang.Object.GetObject<global::Com.Google.Atap.Tangoservice.ITango> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ResetMotionTracking ();
		}
#pragma warning restore 0169

		IntPtr id_resetMotionTracking;
		public unsafe int ResetMotionTracking ()
		{
			if (id_resetMotionTracking == IntPtr.Zero)
				id_resetMotionTracking = JNIEnv.GetMethodID (class_ref, "resetMotionTracking", "()I");
			return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_resetMotionTracking);
		}

		static Delegate cb_saveAreaDescription_Ljava_util_List_;
#pragma warning disable 0169
		static Delegate GetSaveAreaDescription_Ljava_util_List_Handler ()
		{
			if (cb_saveAreaDescription_Ljava_util_List_ == null)
				cb_saveAreaDescription_Ljava_util_List_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, int>) n_SaveAreaDescription_Ljava_util_List_);
			return cb_saveAreaDescription_Ljava_util_List_;
		}

		static int n_SaveAreaDescription_Ljava_util_List_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Google.Atap.Tangoservice.ITango __this = global::Java.Lang.Object.GetObject<global::Com.Google.Atap.Tangoservice.ITango> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Android.Runtime.JavaList<string>.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.SaveAreaDescription (p0);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_saveAreaDescription_Ljava_util_List_;
		public unsafe int SaveAreaDescription (global::System.Collections.Generic.IList<string> p0)
		{
			if (id_saveAreaDescription_Ljava_util_List_ == IntPtr.Zero)
				id_saveAreaDescription_Ljava_util_List_ = JNIEnv.GetMethodID (class_ref, "saveAreaDescription", "(Ljava/util/List;)I");
			IntPtr native_p0 = global::Android.Runtime.JavaList<string>.ToLocalJniHandle (p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			int __ret = JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_saveAreaDescription_Ljava_util_List_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static Delegate cb_saveAreaDescriptionMetaData_Ljava_lang_String_Lcom_google_atap_tangoservice_TangoAreaDescriptionMetaData_;
#pragma warning disable 0169
		static Delegate GetSaveAreaDescriptionMetaData_Ljava_lang_String_Lcom_google_atap_tangoservice_TangoAreaDescriptionMetaData_Handler ()
		{
			if (cb_saveAreaDescriptionMetaData_Ljava_lang_String_Lcom_google_atap_tangoservice_TangoAreaDescriptionMetaData_ == null)
				cb_saveAreaDescriptionMetaData_Ljava_lang_String_Lcom_google_atap_tangoservice_TangoAreaDescriptionMetaData_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, int>) n_SaveAreaDescriptionMetaData_Ljava_lang_String_Lcom_google_atap_tangoservice_TangoAreaDescriptionMetaData_);
			return cb_saveAreaDescriptionMetaData_Ljava_lang_String_Lcom_google_atap_tangoservice_TangoAreaDescriptionMetaData_;
		}

		static int n_SaveAreaDescriptionMetaData_Ljava_lang_String_Lcom_google_atap_tangoservice_TangoAreaDescriptionMetaData_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Google.Atap.Tangoservice.ITango __this = global::Java.Lang.Object.GetObject<global::Com.Google.Atap.Tangoservice.ITango> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Google.Atap.Tangoservice.TangoAreaDescriptionMetaData p1 = global::Java.Lang.Object.GetObject<global::Com.Google.Atap.Tangoservice.TangoAreaDescriptionMetaData> (native_p1, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.SaveAreaDescriptionMetaData (p0, p1);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_saveAreaDescriptionMetaData_Ljava_lang_String_Lcom_google_atap_tangoservice_TangoAreaDescriptionMetaData_;
		public unsafe int SaveAreaDescriptionMetaData (string p0, global::Com.Google.Atap.Tangoservice.TangoAreaDescriptionMetaData p1)
		{
			if (id_saveAreaDescriptionMetaData_Ljava_lang_String_Lcom_google_atap_tangoservice_TangoAreaDescriptionMetaData_ == IntPtr.Zero)
				id_saveAreaDescriptionMetaData_Ljava_lang_String_Lcom_google_atap_tangoservice_TangoAreaDescriptionMetaData_ = JNIEnv.GetMethodID (class_ref, "saveAreaDescriptionMetaData", "(Ljava/lang/String;Lcom/google/atap/tangoservice/TangoAreaDescriptionMetaData;)I");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue (p1);
			int __ret = JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_saveAreaDescriptionMetaData_Ljava_lang_String_Lcom_google_atap_tangoservice_TangoAreaDescriptionMetaData_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static Delegate cb_setPoseListenerFrames_Ljava_util_List_;
#pragma warning disable 0169
		static Delegate GetSetPoseListenerFrames_Ljava_util_List_Handler ()
		{
			if (cb_setPoseListenerFrames_Ljava_util_List_ == null)
				cb_setPoseListenerFrames_Ljava_util_List_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, int>) n_SetPoseListenerFrames_Ljava_util_List_);
			return cb_setPoseListenerFrames_Ljava_util_List_;
		}

		static int n_SetPoseListenerFrames_Ljava_util_List_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Google.Atap.Tangoservice.ITango __this = global::Java.Lang.Object.GetObject<global::Com.Google.Atap.Tangoservice.ITango> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Android.Runtime.JavaList<global::Com.Google.Atap.Tangoservice.TangoCoordinateFramePair>.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.SetPoseListenerFrames (p0);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_setPoseListenerFrames_Ljava_util_List_;
		public unsafe int SetPoseListenerFrames (global::System.Collections.Generic.IList<global::Com.Google.Atap.Tangoservice.TangoCoordinateFramePair> p0)
		{
			if (id_setPoseListenerFrames_Ljava_util_List_ == IntPtr.Zero)
				id_setPoseListenerFrames_Ljava_util_List_ = JNIEnv.GetMethodID (class_ref, "setPoseListenerFrames", "(Ljava/util/List;)I");
			IntPtr native_p0 = global::Android.Runtime.JavaList<global::Com.Google.Atap.Tangoservice.TangoCoordinateFramePair>.ToLocalJniHandle (p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			int __ret = JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_setPoseListenerFrames_Ljava_util_List_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static Delegate cb_setRuntimeConfig_Lcom_google_atap_tangoservice_TangoConfig_;
#pragma warning disable 0169
		static Delegate GetSetRuntimeConfig_Lcom_google_atap_tangoservice_TangoConfig_Handler ()
		{
			if (cb_setRuntimeConfig_Lcom_google_atap_tangoservice_TangoConfig_ == null)
				cb_setRuntimeConfig_Lcom_google_atap_tangoservice_TangoConfig_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, int>) n_SetRuntimeConfig_Lcom_google_atap_tangoservice_TangoConfig_);
			return cb_setRuntimeConfig_Lcom_google_atap_tangoservice_TangoConfig_;
		}

		static int n_SetRuntimeConfig_Lcom_google_atap_tangoservice_TangoConfig_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Google.Atap.Tangoservice.ITango __this = global::Java.Lang.Object.GetObject<global::Com.Google.Atap.Tangoservice.ITango> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Google.Atap.Tangoservice.TangoConfig p0 = global::Java.Lang.Object.GetObject<global::Com.Google.Atap.Tangoservice.TangoConfig> (native_p0, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.SetRuntimeConfig (p0);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_setRuntimeConfig_Lcom_google_atap_tangoservice_TangoConfig_;
		public unsafe int SetRuntimeConfig (global::Com.Google.Atap.Tangoservice.TangoConfig p0)
		{
			if (id_setRuntimeConfig_Lcom_google_atap_tangoservice_TangoConfig_ == IntPtr.Zero)
				id_setRuntimeConfig_Lcom_google_atap_tangoservice_TangoConfig_ = JNIEnv.GetMethodID (class_ref, "setRuntimeConfig", "(Lcom/google/atap/tangoservice/TangoConfig;)I");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			int __ret = JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_setRuntimeConfig_Lcom_google_atap_tangoservice_TangoConfig_, __args);
			return __ret;
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
			global::Com.Google.Atap.Tangoservice.ITango __this = global::Java.Lang.Object.GetObject<global::Com.Google.Atap.Tangoservice.ITango> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
