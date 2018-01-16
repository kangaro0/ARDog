using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Google.Tango.Loader {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.google.tango.loader']/class[@name='ITangoCameraNative.Stub']"
	[global::Android.Runtime.Register ("com/google/tango/loader/ITangoCameraNative$Stub", DoNotGenerateAcw=true)]
	public abstract partial class TangoCameraNativeStub : global::Android.OS.Binder, global::Com.Google.Tango.Loader.ITangoCameraNative {

		// Metadata.xml XPath class reference: path="/api/package[@name='com.google.tango.loader']/class[@name='ITangoCameraNative.Stub.Proxy']"
		[global::Android.Runtime.Register ("com/google/tango/loader/ITangoCameraNative$Stub$Proxy", DoNotGenerateAcw=true)]
		public partial class Proxy : global::Java.Lang.Object, global::Com.Google.Tango.Loader.ITangoCameraNative {

			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/google/tango/loader/ITangoCameraNative$Stub$Proxy", ref java_class_handle);
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
				global::Com.Google.Tango.Loader.TangoCameraNativeStub.Proxy __this = global::Java.Lang.Object.GetObject<global::Com.Google.Tango.Loader.TangoCameraNativeStub.Proxy> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.NewString (__this.InterfaceDescriptor);
			}
#pragma warning restore 0169

			static IntPtr id_getInterfaceDescriptor;
			public virtual unsafe string InterfaceDescriptor {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.google.tango.loader']/class[@name='ITangoCameraNative.Stub.Proxy']/method[@name='getInterfaceDescriptor' and count(parameter)=0]"
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
				global::Com.Google.Tango.Loader.TangoCameraNativeStub.Proxy __this = global::Java.Lang.Object.GetObject<global::Com.Google.Tango.Loader.TangoCameraNativeStub.Proxy> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.AsBinder ());
			}
#pragma warning restore 0169

			static IntPtr id_asBinder;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.tango.loader']/class[@name='ITangoCameraNative.Stub.Proxy']/method[@name='asBinder' and count(parameter)=0]"
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

			static Delegate cb_connectOnFrameAvailable_ILcom_google_tango_loader_IObjectWrapper_Lcom_google_tango_loader_IObjectWrapper_Z;
#pragma warning disable 0169
			static Delegate GetConnectOnFrameAvailable_ILcom_google_tango_loader_IObjectWrapper_Lcom_google_tango_loader_IObjectWrapper_ZHandler ()
			{
				if (cb_connectOnFrameAvailable_ILcom_google_tango_loader_IObjectWrapper_Lcom_google_tango_loader_IObjectWrapper_Z == null)
					cb_connectOnFrameAvailable_ILcom_google_tango_loader_IObjectWrapper_Lcom_google_tango_loader_IObjectWrapper_Z = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr, IntPtr, bool, int>) n_ConnectOnFrameAvailable_ILcom_google_tango_loader_IObjectWrapper_Lcom_google_tango_loader_IObjectWrapper_Z);
				return cb_connectOnFrameAvailable_ILcom_google_tango_loader_IObjectWrapper_Lcom_google_tango_loader_IObjectWrapper_Z;
			}

			static int n_ConnectOnFrameAvailable_ILcom_google_tango_loader_IObjectWrapper_Lcom_google_tango_loader_IObjectWrapper_Z (IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1, IntPtr native_p2, bool p3)
			{
				global::Com.Google.Tango.Loader.TangoCameraNativeStub.Proxy __this = global::Java.Lang.Object.GetObject<global::Com.Google.Tango.Loader.TangoCameraNativeStub.Proxy> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Com.Google.Tango.Loader.IObjectWrapper p1 = (global::Com.Google.Tango.Loader.IObjectWrapper)global::Java.Lang.Object.GetObject<global::Com.Google.Tango.Loader.IObjectWrapper> (native_p1, JniHandleOwnership.DoNotTransfer);
				global::Com.Google.Tango.Loader.IObjectWrapper p2 = (global::Com.Google.Tango.Loader.IObjectWrapper)global::Java.Lang.Object.GetObject<global::Com.Google.Tango.Loader.IObjectWrapper> (native_p2, JniHandleOwnership.DoNotTransfer);
				int __ret = __this.ConnectOnFrameAvailable (p0, p1, p2, p3);
				return __ret;
			}
#pragma warning restore 0169

			static IntPtr id_connectOnFrameAvailable_ILcom_google_tango_loader_IObjectWrapper_Lcom_google_tango_loader_IObjectWrapper_Z;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.tango.loader']/class[@name='ITangoCameraNative.Stub.Proxy']/method[@name='connectOnFrameAvailable' and count(parameter)=4 and parameter[1][@type='int'] and parameter[2][@type='com.google.tango.loader.IObjectWrapper'] and parameter[3][@type='com.google.tango.loader.IObjectWrapper'] and parameter[4][@type='boolean']]"
			[Register ("connectOnFrameAvailable", "(ILcom/google/tango/loader/IObjectWrapper;Lcom/google/tango/loader/IObjectWrapper;Z)I", "GetConnectOnFrameAvailable_ILcom_google_tango_loader_IObjectWrapper_Lcom_google_tango_loader_IObjectWrapper_ZHandler")]
			public virtual unsafe int ConnectOnFrameAvailable (int p0, global::Com.Google.Tango.Loader.IObjectWrapper p1, global::Com.Google.Tango.Loader.IObjectWrapper p2, bool p3)
			{
				if (id_connectOnFrameAvailable_ILcom_google_tango_loader_IObjectWrapper_Lcom_google_tango_loader_IObjectWrapper_Z == IntPtr.Zero)
					id_connectOnFrameAvailable_ILcom_google_tango_loader_IObjectWrapper_Lcom_google_tango_loader_IObjectWrapper_Z = JNIEnv.GetMethodID (class_ref, "connectOnFrameAvailable", "(ILcom/google/tango/loader/IObjectWrapper;Lcom/google/tango/loader/IObjectWrapper;Z)I");
				try {
					JValue* __args = stackalloc JValue [4];
					__args [0] = new JValue (p0);
					__args [1] = new JValue (p1);
					__args [2] = new JValue (p2);
					__args [3] = new JValue (p3);

					int __ret;
					if (GetType () == ThresholdType)
						__ret = JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_connectOnFrameAvailable_ILcom_google_tango_loader_IObjectWrapper_Lcom_google_tango_loader_IObjectWrapper_Z, __args);
					else
						__ret = JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "connectOnFrameAvailable", "(ILcom/google/tango/loader/IObjectWrapper;Lcom/google/tango/loader/IObjectWrapper;Z)I"), __args);
					return __ret;
				} finally {
				}
			}

			static Delegate cb_connectOnTextureAvailable_IZ;
#pragma warning disable 0169
			static Delegate GetConnectOnTextureAvailable_IZHandler ()
			{
				if (cb_connectOnTextureAvailable_IZ == null)
					cb_connectOnTextureAvailable_IZ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, bool, int>) n_ConnectOnTextureAvailable_IZ);
				return cb_connectOnTextureAvailable_IZ;
			}

			static int n_ConnectOnTextureAvailable_IZ (IntPtr jnienv, IntPtr native__this, int p0, bool p1)
			{
				global::Com.Google.Tango.Loader.TangoCameraNativeStub.Proxy __this = global::Java.Lang.Object.GetObject<global::Com.Google.Tango.Loader.TangoCameraNativeStub.Proxy> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return __this.ConnectOnTextureAvailable (p0, p1);
			}
#pragma warning restore 0169

			static IntPtr id_connectOnTextureAvailable_IZ;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.tango.loader']/class[@name='ITangoCameraNative.Stub.Proxy']/method[@name='connectOnTextureAvailable' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='boolean']]"
			[Register ("connectOnTextureAvailable", "(IZ)I", "GetConnectOnTextureAvailable_IZHandler")]
			public virtual unsafe int ConnectOnTextureAvailable (int p0, bool p1)
			{
				if (id_connectOnTextureAvailable_IZ == IntPtr.Zero)
					id_connectOnTextureAvailable_IZ = JNIEnv.GetMethodID (class_ref, "connectOnTextureAvailable", "(IZ)I");
				try {
					JValue* __args = stackalloc JValue [2];
					__args [0] = new JValue (p0);
					__args [1] = new JValue (p1);

					if (GetType () == ThresholdType)
						return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_connectOnTextureAvailable_IZ, __args);
					else
						return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "connectOnTextureAvailable", "(IZ)I"), __args);
				} finally {
				}
			}

			static Delegate cb_connectTextureId_IIZ;
#pragma warning disable 0169
			static Delegate GetConnectTextureId_IIZHandler ()
			{
				if (cb_connectTextureId_IIZ == null)
					cb_connectTextureId_IIZ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, int, bool, int>) n_ConnectTextureId_IIZ);
				return cb_connectTextureId_IIZ;
			}

			static int n_ConnectTextureId_IIZ (IntPtr jnienv, IntPtr native__this, int p0, int p1, bool p2)
			{
				global::Com.Google.Tango.Loader.TangoCameraNativeStub.Proxy __this = global::Java.Lang.Object.GetObject<global::Com.Google.Tango.Loader.TangoCameraNativeStub.Proxy> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return __this.ConnectTextureId (p0, p1, p2);
			}
#pragma warning restore 0169

			static IntPtr id_connectTextureId_IIZ;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.tango.loader']/class[@name='ITangoCameraNative.Stub.Proxy']/method[@name='connectTextureId' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='boolean']]"
			[Register ("connectTextureId", "(IIZ)I", "GetConnectTextureId_IIZHandler")]
			public virtual unsafe int ConnectTextureId (int p0, int p1, bool p2)
			{
				if (id_connectTextureId_IIZ == IntPtr.Zero)
					id_connectTextureId_IIZ = JNIEnv.GetMethodID (class_ref, "connectTextureId", "(IIZ)I");
				try {
					JValue* __args = stackalloc JValue [3];
					__args [0] = new JValue (p0);
					__args [1] = new JValue (p1);
					__args [2] = new JValue (p2);

					if (GetType () == ThresholdType)
						return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_connectTextureId_IIZ, __args);
					else
						return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "connectTextureId", "(IIZ)I"), __args);
				} finally {
				}
			}

			static Delegate cb_disconnectCamera_I;
#pragma warning disable 0169
			static Delegate GetDisconnectCamera_IHandler ()
			{
				if (cb_disconnectCamera_I == null)
					cb_disconnectCamera_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, int>) n_DisconnectCamera_I);
				return cb_disconnectCamera_I;
			}

			static int n_DisconnectCamera_I (IntPtr jnienv, IntPtr native__this, int p0)
			{
				global::Com.Google.Tango.Loader.TangoCameraNativeStub.Proxy __this = global::Java.Lang.Object.GetObject<global::Com.Google.Tango.Loader.TangoCameraNativeStub.Proxy> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return __this.DisconnectCamera (p0);
			}
#pragma warning restore 0169

			static IntPtr id_disconnectCamera_I;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.tango.loader']/class[@name='ITangoCameraNative.Stub.Proxy']/method[@name='disconnectCamera' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("disconnectCamera", "(I)I", "GetDisconnectCamera_IHandler")]
			public virtual unsafe int DisconnectCamera (int p0)
			{
				if (id_disconnectCamera_I == IntPtr.Zero)
					id_disconnectCamera_I = JNIEnv.GetMethodID (class_ref, "disconnectCamera", "(I)I");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (p0);

					if (GetType () == ThresholdType)
						return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_disconnectCamera_I, __args);
					else
						return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "disconnectCamera", "(I)I"), __args);
				} finally {
				}
			}

			static Delegate cb_initialize_Lcom_google_tango_loader_IObjectWrapper_Lcom_google_atap_tangoservice_ITangoListener_;
#pragma warning disable 0169
			static Delegate GetInitialize_Lcom_google_tango_loader_IObjectWrapper_Lcom_google_atap_tangoservice_ITangoListener_Handler ()
			{
				if (cb_initialize_Lcom_google_tango_loader_IObjectWrapper_Lcom_google_atap_tangoservice_ITangoListener_ == null)
					cb_initialize_Lcom_google_tango_loader_IObjectWrapper_Lcom_google_atap_tangoservice_ITangoListener_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, int>) n_Initialize_Lcom_google_tango_loader_IObjectWrapper_Lcom_google_atap_tangoservice_ITangoListener_);
				return cb_initialize_Lcom_google_tango_loader_IObjectWrapper_Lcom_google_atap_tangoservice_ITangoListener_;
			}

			static int n_Initialize_Lcom_google_tango_loader_IObjectWrapper_Lcom_google_atap_tangoservice_ITangoListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
			{
				global::Com.Google.Tango.Loader.TangoCameraNativeStub.Proxy __this = global::Java.Lang.Object.GetObject<global::Com.Google.Tango.Loader.TangoCameraNativeStub.Proxy> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Com.Google.Tango.Loader.IObjectWrapper p0 = (global::Com.Google.Tango.Loader.IObjectWrapper)global::Java.Lang.Object.GetObject<global::Com.Google.Tango.Loader.IObjectWrapper> (native_p0, JniHandleOwnership.DoNotTransfer);
				global::Com.Google.Atap.Tangoservice.ITangoListener p1 = (global::Com.Google.Atap.Tangoservice.ITangoListener)global::Java.Lang.Object.GetObject<global::Com.Google.Atap.Tangoservice.ITangoListener> (native_p1, JniHandleOwnership.DoNotTransfer);
				int __ret = __this.Initialize (p0, p1);
				return __ret;
			}
#pragma warning restore 0169

			static IntPtr id_initialize_Lcom_google_tango_loader_IObjectWrapper_Lcom_google_atap_tangoservice_ITangoListener_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.tango.loader']/class[@name='ITangoCameraNative.Stub.Proxy']/method[@name='initialize' and count(parameter)=2 and parameter[1][@type='com.google.tango.loader.IObjectWrapper'] and parameter[2][@type='com.google.atap.tangoservice.ITangoListener']]"
			[Register ("initialize", "(Lcom/google/tango/loader/IObjectWrapper;Lcom/google/atap/tangoservice/ITangoListener;)I", "GetInitialize_Lcom_google_tango_loader_IObjectWrapper_Lcom_google_atap_tangoservice_ITangoListener_Handler")]
			public virtual unsafe int Initialize (global::Com.Google.Tango.Loader.IObjectWrapper p0, global::Com.Google.Atap.Tangoservice.ITangoListener p1)
			{
				if (id_initialize_Lcom_google_tango_loader_IObjectWrapper_Lcom_google_atap_tangoservice_ITangoListener_ == IntPtr.Zero)
					id_initialize_Lcom_google_tango_loader_IObjectWrapper_Lcom_google_atap_tangoservice_ITangoListener_ = JNIEnv.GetMethodID (class_ref, "initialize", "(Lcom/google/tango/loader/IObjectWrapper;Lcom/google/atap/tangoservice/ITangoListener;)I");
				try {
					JValue* __args = stackalloc JValue [2];
					__args [0] = new JValue (p0);
					__args [1] = new JValue (p1);

					int __ret;
					if (GetType () == ThresholdType)
						__ret = JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_initialize_Lcom_google_tango_loader_IObjectWrapper_Lcom_google_atap_tangoservice_ITangoListener_, __args);
					else
						__ret = JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "initialize", "(Lcom/google/tango/loader/IObjectWrapper;Lcom/google/atap/tangoservice/ITangoListener;)I"), __args);
					return __ret;
				} finally {
				}
			}

			static Delegate cb_lockCameraBuffer_IarrayDarrayJ;
#pragma warning disable 0169
			static Delegate GetLockCameraBuffer_IarrayDarrayJHandler ()
			{
				if (cb_lockCameraBuffer_IarrayDarrayJ == null)
					cb_lockCameraBuffer_IarrayDarrayJ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr, IntPtr, int>) n_LockCameraBuffer_IarrayDarrayJ);
				return cb_lockCameraBuffer_IarrayDarrayJ;
			}

			static int n_LockCameraBuffer_IarrayDarrayJ (IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1, IntPtr native_p2)
			{
				global::Com.Google.Tango.Loader.TangoCameraNativeStub.Proxy __this = global::Java.Lang.Object.GetObject<global::Com.Google.Tango.Loader.TangoCameraNativeStub.Proxy> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				double[] p1 = (double[]) JNIEnv.GetArray (native_p1, JniHandleOwnership.DoNotTransfer, typeof (double));
				long[] p2 = (long[]) JNIEnv.GetArray (native_p2, JniHandleOwnership.DoNotTransfer, typeof (long));
				int __ret = __this.LockCameraBuffer (p0, p1, p2);
				if (p1 != null)
					JNIEnv.CopyArray (p1, native_p1);
				if (p2 != null)
					JNIEnv.CopyArray (p2, native_p2);
				return __ret;
			}
#pragma warning restore 0169

			static IntPtr id_lockCameraBuffer_IarrayDarrayJ;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.tango.loader']/class[@name='ITangoCameraNative.Stub.Proxy']/method[@name='lockCameraBuffer' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='double[]'] and parameter[3][@type='long[]']]"
			[Register ("lockCameraBuffer", "(I[D[J)I", "GetLockCameraBuffer_IarrayDarrayJHandler")]
			public virtual unsafe int LockCameraBuffer (int p0, double[] p1, long[] p2)
			{
				if (id_lockCameraBuffer_IarrayDarrayJ == IntPtr.Zero)
					id_lockCameraBuffer_IarrayDarrayJ = JNIEnv.GetMethodID (class_ref, "lockCameraBuffer", "(I[D[J)I");
				IntPtr native_p1 = JNIEnv.NewArray (p1);
				IntPtr native_p2 = JNIEnv.NewArray (p2);
				try {
					JValue* __args = stackalloc JValue [3];
					__args [0] = new JValue (p0);
					__args [1] = new JValue (native_p1);
					__args [2] = new JValue (native_p2);

					int __ret;
					if (GetType () == ThresholdType)
						__ret = JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_lockCameraBuffer_IarrayDarrayJ, __args);
					else
						__ret = JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "lockCameraBuffer", "(I[D[J)I"), __args);
					return __ret;
				} finally {
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

			static Delegate cb_startCamerasIfNeeded;
#pragma warning disable 0169
			static Delegate GetStartCamerasIfNeededHandler ()
			{
				if (cb_startCamerasIfNeeded == null)
					cb_startCamerasIfNeeded = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_StartCamerasIfNeeded);
				return cb_startCamerasIfNeeded;
			}

			static int n_StartCamerasIfNeeded (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Google.Tango.Loader.TangoCameraNativeStub.Proxy __this = global::Java.Lang.Object.GetObject<global::Com.Google.Tango.Loader.TangoCameraNativeStub.Proxy> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return __this.StartCamerasIfNeeded ();
			}
#pragma warning restore 0169

			static IntPtr id_startCamerasIfNeeded;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.tango.loader']/class[@name='ITangoCameraNative.Stub.Proxy']/method[@name='startCamerasIfNeeded' and count(parameter)=0]"
			[Register ("startCamerasIfNeeded", "()I", "GetStartCamerasIfNeededHandler")]
			public virtual unsafe int StartCamerasIfNeeded ()
			{
				if (id_startCamerasIfNeeded == IntPtr.Zero)
					id_startCamerasIfNeeded = JNIEnv.GetMethodID (class_ref, "startCamerasIfNeeded", "()I");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_startCamerasIfNeeded);
					else
						return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "startCamerasIfNeeded", "()I"));
				} finally {
				}
			}

			static Delegate cb_stopAllCameras;
#pragma warning disable 0169
			static Delegate GetStopAllCamerasHandler ()
			{
				if (cb_stopAllCameras == null)
					cb_stopAllCameras = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_StopAllCameras);
				return cb_stopAllCameras;
			}

			static int n_StopAllCameras (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Google.Tango.Loader.TangoCameraNativeStub.Proxy __this = global::Java.Lang.Object.GetObject<global::Com.Google.Tango.Loader.TangoCameraNativeStub.Proxy> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return __this.StopAllCameras ();
			}
#pragma warning restore 0169

			static IntPtr id_stopAllCameras;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.tango.loader']/class[@name='ITangoCameraNative.Stub.Proxy']/method[@name='stopAllCameras' and count(parameter)=0]"
			[Register ("stopAllCameras", "()I", "GetStopAllCamerasHandler")]
			public virtual unsafe int StopAllCameras ()
			{
				if (id_stopAllCameras == IntPtr.Zero)
					id_stopAllCameras = JNIEnv.GetMethodID (class_ref, "stopAllCameras", "()I");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_stopAllCameras);
					else
						return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "stopAllCameras", "()I"));
				} finally {
				}
			}

			static Delegate cb_unlockCameraBuffer_IJ;
#pragma warning disable 0169
			static Delegate GetUnlockCameraBuffer_IJHandler ()
			{
				if (cb_unlockCameraBuffer_IJ == null)
					cb_unlockCameraBuffer_IJ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, long, int>) n_UnlockCameraBuffer_IJ);
				return cb_unlockCameraBuffer_IJ;
			}

			static int n_UnlockCameraBuffer_IJ (IntPtr jnienv, IntPtr native__this, int p0, long p1)
			{
				global::Com.Google.Tango.Loader.TangoCameraNativeStub.Proxy __this = global::Java.Lang.Object.GetObject<global::Com.Google.Tango.Loader.TangoCameraNativeStub.Proxy> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return __this.UnlockCameraBuffer (p0, p1);
			}
#pragma warning restore 0169

			static IntPtr id_unlockCameraBuffer_IJ;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.tango.loader']/class[@name='ITangoCameraNative.Stub.Proxy']/method[@name='unlockCameraBuffer' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='long']]"
			[Register ("unlockCameraBuffer", "(IJ)I", "GetUnlockCameraBuffer_IJHandler")]
			public virtual unsafe int UnlockCameraBuffer (int p0, long p1)
			{
				if (id_unlockCameraBuffer_IJ == IntPtr.Zero)
					id_unlockCameraBuffer_IJ = JNIEnv.GetMethodID (class_ref, "unlockCameraBuffer", "(IJ)I");
				try {
					JValue* __args = stackalloc JValue [2];
					__args [0] = new JValue (p0);
					__args [1] = new JValue (p1);

					if (GetType () == ThresholdType)
						return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_unlockCameraBuffer_IJ, __args);
					else
						return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "unlockCameraBuffer", "(IJ)I"), __args);
				} finally {
				}
			}

			static Delegate cb_updateTexture_IarrayD;
#pragma warning disable 0169
			static Delegate GetUpdateTexture_IarrayDHandler ()
			{
				if (cb_updateTexture_IarrayD == null)
					cb_updateTexture_IarrayD = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr, int>) n_UpdateTexture_IarrayD);
				return cb_updateTexture_IarrayD;
			}

			static int n_UpdateTexture_IarrayD (IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1)
			{
				global::Com.Google.Tango.Loader.TangoCameraNativeStub.Proxy __this = global::Java.Lang.Object.GetObject<global::Com.Google.Tango.Loader.TangoCameraNativeStub.Proxy> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				double[] p1 = (double[]) JNIEnv.GetArray (native_p1, JniHandleOwnership.DoNotTransfer, typeof (double));
				int __ret = __this.UpdateTexture (p0, p1);
				if (p1 != null)
					JNIEnv.CopyArray (p1, native_p1);
				return __ret;
			}
#pragma warning restore 0169

			static IntPtr id_updateTexture_IarrayD;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.tango.loader']/class[@name='ITangoCameraNative.Stub.Proxy']/method[@name='updateTexture' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='double[]']]"
			[Register ("updateTexture", "(I[D)I", "GetUpdateTexture_IarrayDHandler")]
			public virtual unsafe int UpdateTexture (int p0, double[] p1)
			{
				if (id_updateTexture_IarrayD == IntPtr.Zero)
					id_updateTexture_IarrayD = JNIEnv.GetMethodID (class_ref, "updateTexture", "(I[D)I");
				IntPtr native_p1 = JNIEnv.NewArray (p1);
				try {
					JValue* __args = stackalloc JValue [2];
					__args [0] = new JValue (p0);
					__args [1] = new JValue (native_p1);

					int __ret;
					if (GetType () == ThresholdType)
						__ret = JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_updateTexture_IarrayD, __args);
					else
						__ret = JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "updateTexture", "(I[D)I"), __args);
					return __ret;
				} finally {
					if (p1 != null) {
						JNIEnv.CopyArray (native_p1, p1);
						JNIEnv.DeleteLocalRef (native_p1);
					}
				}
			}

			static Delegate cb_updateTextureExternalOes_IIarrayD;
#pragma warning disable 0169
			static Delegate GetUpdateTextureExternalOes_IIarrayDHandler ()
			{
				if (cb_updateTextureExternalOes_IIarrayD == null)
					cb_updateTextureExternalOes_IIarrayD = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, int, IntPtr, int>) n_UpdateTextureExternalOes_IIarrayD);
				return cb_updateTextureExternalOes_IIarrayD;
			}

			static int n_UpdateTextureExternalOes_IIarrayD (IntPtr jnienv, IntPtr native__this, int p0, int p1, IntPtr native_p2)
			{
				global::Com.Google.Tango.Loader.TangoCameraNativeStub.Proxy __this = global::Java.Lang.Object.GetObject<global::Com.Google.Tango.Loader.TangoCameraNativeStub.Proxy> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				double[] p2 = (double[]) JNIEnv.GetArray (native_p2, JniHandleOwnership.DoNotTransfer, typeof (double));
				int __ret = __this.UpdateTextureExternalOes (p0, p1, p2);
				if (p2 != null)
					JNIEnv.CopyArray (p2, native_p2);
				return __ret;
			}
#pragma warning restore 0169

			static IntPtr id_updateTextureExternalOes_IIarrayD;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.tango.loader']/class[@name='ITangoCameraNative.Stub.Proxy']/method[@name='updateTextureExternalOes' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='double[]']]"
			[Register ("updateTextureExternalOes", "(II[D)I", "GetUpdateTextureExternalOes_IIarrayDHandler")]
			public virtual unsafe int UpdateTextureExternalOes (int p0, int p1, double[] p2)
			{
				if (id_updateTextureExternalOes_IIarrayD == IntPtr.Zero)
					id_updateTextureExternalOes_IIarrayD = JNIEnv.GetMethodID (class_ref, "updateTextureExternalOes", "(II[D)I");
				IntPtr native_p2 = JNIEnv.NewArray (p2);
				try {
					JValue* __args = stackalloc JValue [3];
					__args [0] = new JValue (p0);
					__args [1] = new JValue (p1);
					__args [2] = new JValue (native_p2);

					int __ret;
					if (GetType () == ThresholdType)
						__ret = JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_updateTextureExternalOes_IIarrayD, __args);
					else
						__ret = JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "updateTextureExternalOes", "(II[D)I"), __args);
					return __ret;
				} finally {
					if (p2 != null) {
						JNIEnv.CopyArray (native_p2, p2);
						JNIEnv.DeleteLocalRef (native_p2);
					}
				}
			}

			static Delegate cb_updateTextureExternalOesForBuffer_IIJ;
#pragma warning disable 0169
			static Delegate GetUpdateTextureExternalOesForBuffer_IIJHandler ()
			{
				if (cb_updateTextureExternalOesForBuffer_IIJ == null)
					cb_updateTextureExternalOesForBuffer_IIJ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, int, long, int>) n_UpdateTextureExternalOesForBuffer_IIJ);
				return cb_updateTextureExternalOesForBuffer_IIJ;
			}

			static int n_UpdateTextureExternalOesForBuffer_IIJ (IntPtr jnienv, IntPtr native__this, int p0, int p1, long p2)
			{
				global::Com.Google.Tango.Loader.TangoCameraNativeStub.Proxy __this = global::Java.Lang.Object.GetObject<global::Com.Google.Tango.Loader.TangoCameraNativeStub.Proxy> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return __this.UpdateTextureExternalOesForBuffer (p0, p1, p2);
			}
#pragma warning restore 0169

			static IntPtr id_updateTextureExternalOesForBuffer_IIJ;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.tango.loader']/class[@name='ITangoCameraNative.Stub.Proxy']/method[@name='updateTextureExternalOesForBuffer' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='long']]"
			[Register ("updateTextureExternalOesForBuffer", "(IIJ)I", "GetUpdateTextureExternalOesForBuffer_IIJHandler")]
			public virtual unsafe int UpdateTextureExternalOesForBuffer (int p0, int p1, long p2)
			{
				if (id_updateTextureExternalOesForBuffer_IIJ == IntPtr.Zero)
					id_updateTextureExternalOesForBuffer_IIJ = JNIEnv.GetMethodID (class_ref, "updateTextureExternalOesForBuffer", "(IIJ)I");
				try {
					JValue* __args = stackalloc JValue [3];
					__args [0] = new JValue (p0);
					__args [1] = new JValue (p1);
					__args [2] = new JValue (p2);

					if (GetType () == ThresholdType)
						return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_updateTextureExternalOesForBuffer_IIJ, __args);
					else
						return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "updateTextureExternalOesForBuffer", "(IIJ)I"), __args);
				} finally {
				}
			}

		}

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/google/tango/loader/ITangoCameraNative$Stub", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (TangoCameraNativeStub); }
		}

		protected TangoCameraNativeStub (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.google.tango.loader']/class[@name='ITangoCameraNative.Stub']/constructor[@name='ITangoCameraNative.Stub' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe TangoCameraNativeStub ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (TangoCameraNativeStub)) {
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
			global::Com.Google.Tango.Loader.TangoCameraNativeStub __this = global::Java.Lang.Object.GetObject<global::Com.Google.Tango.Loader.TangoCameraNativeStub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.AsBinder ());
		}
#pragma warning restore 0169

		static IntPtr id_asBinder;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.tango.loader']/class[@name='ITangoCameraNative.Stub']/method[@name='asBinder' and count(parameter)=0]"
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
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.tango.loader']/class[@name='ITangoCameraNative.Stub']/method[@name='asInterface' and count(parameter)=1 and parameter[1][@type='android.os.IBinder']]"
		[Register ("asInterface", "(Landroid/os/IBinder;)Lcom/google/tango/loader/ITangoCameraNative;", "")]
		public static unsafe global::Com.Google.Tango.Loader.ITangoCameraNative AsInterface (global::Android.OS.IBinder p0)
		{
			if (id_asInterface_Landroid_os_IBinder_ == IntPtr.Zero)
				id_asInterface_Landroid_os_IBinder_ = JNIEnv.GetStaticMethodID (class_ref, "asInterface", "(Landroid/os/IBinder;)Lcom/google/tango/loader/ITangoCameraNative;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				global::Com.Google.Tango.Loader.ITangoCameraNative __ret = global::Java.Lang.Object.GetObject<global::Com.Google.Tango.Loader.ITangoCameraNative> (JNIEnv.CallStaticObjectMethod  (class_ref, id_asInterface_Landroid_os_IBinder_, __args), JniHandleOwnership.TransferLocalRef);
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
			global::Com.Google.Tango.Loader.TangoCameraNativeStub __this = global::Java.Lang.Object.GetObject<global::Com.Google.Tango.Loader.TangoCameraNativeStub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.Parcel p1 = global::Java.Lang.Object.GetObject<global::Android.OS.Parcel> (native_p1, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.Parcel p2 = global::Java.Lang.Object.GetObject<global::Android.OS.Parcel> (native_p2, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.OnTransact (p0, p1, p2, p3);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_onTransact_ILandroid_os_Parcel_Landroid_os_Parcel_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.tango.loader']/class[@name='ITangoCameraNative.Stub']/method[@name='onTransact' and count(parameter)=4 and parameter[1][@type='int'] and parameter[2][@type='android.os.Parcel'] and parameter[3][@type='android.os.Parcel'] and parameter[4][@type='int']]"
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

		static Delegate cb_connectOnFrameAvailable_ILcom_google_tango_loader_IObjectWrapper_Lcom_google_tango_loader_IObjectWrapper_Z;
#pragma warning disable 0169
		static Delegate GetConnectOnFrameAvailable_ILcom_google_tango_loader_IObjectWrapper_Lcom_google_tango_loader_IObjectWrapper_ZHandler ()
		{
			if (cb_connectOnFrameAvailable_ILcom_google_tango_loader_IObjectWrapper_Lcom_google_tango_loader_IObjectWrapper_Z == null)
				cb_connectOnFrameAvailable_ILcom_google_tango_loader_IObjectWrapper_Lcom_google_tango_loader_IObjectWrapper_Z = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr, IntPtr, bool, int>) n_ConnectOnFrameAvailable_ILcom_google_tango_loader_IObjectWrapper_Lcom_google_tango_loader_IObjectWrapper_Z);
			return cb_connectOnFrameAvailable_ILcom_google_tango_loader_IObjectWrapper_Lcom_google_tango_loader_IObjectWrapper_Z;
		}

		static int n_ConnectOnFrameAvailable_ILcom_google_tango_loader_IObjectWrapper_Lcom_google_tango_loader_IObjectWrapper_Z (IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1, IntPtr native_p2, bool p3)
		{
			global::Com.Google.Tango.Loader.TangoCameraNativeStub __this = global::Java.Lang.Object.GetObject<global::Com.Google.Tango.Loader.TangoCameraNativeStub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Google.Tango.Loader.IObjectWrapper p1 = (global::Com.Google.Tango.Loader.IObjectWrapper)global::Java.Lang.Object.GetObject<global::Com.Google.Tango.Loader.IObjectWrapper> (native_p1, JniHandleOwnership.DoNotTransfer);
			global::Com.Google.Tango.Loader.IObjectWrapper p2 = (global::Com.Google.Tango.Loader.IObjectWrapper)global::Java.Lang.Object.GetObject<global::Com.Google.Tango.Loader.IObjectWrapper> (native_p2, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.ConnectOnFrameAvailable (p0, p1, p2, p3);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.tango.loader']/interface[@name='ITangoCameraNative']/method[@name='connectOnFrameAvailable' and count(parameter)=4 and parameter[1][@type='int'] and parameter[2][@type='com.google.tango.loader.IObjectWrapper'] and parameter[3][@type='com.google.tango.loader.IObjectWrapper'] and parameter[4][@type='boolean']]"
		[Register ("connectOnFrameAvailable", "(ILcom/google/tango/loader/IObjectWrapper;Lcom/google/tango/loader/IObjectWrapper;Z)I", "GetConnectOnFrameAvailable_ILcom_google_tango_loader_IObjectWrapper_Lcom_google_tango_loader_IObjectWrapper_ZHandler")]
		public abstract int ConnectOnFrameAvailable (int p0, global::Com.Google.Tango.Loader.IObjectWrapper p1, global::Com.Google.Tango.Loader.IObjectWrapper p2, bool p3);

		static Delegate cb_connectOnTextureAvailable_IZ;
#pragma warning disable 0169
		static Delegate GetConnectOnTextureAvailable_IZHandler ()
		{
			if (cb_connectOnTextureAvailable_IZ == null)
				cb_connectOnTextureAvailable_IZ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, bool, int>) n_ConnectOnTextureAvailable_IZ);
			return cb_connectOnTextureAvailable_IZ;
		}

		static int n_ConnectOnTextureAvailable_IZ (IntPtr jnienv, IntPtr native__this, int p0, bool p1)
		{
			global::Com.Google.Tango.Loader.TangoCameraNativeStub __this = global::Java.Lang.Object.GetObject<global::Com.Google.Tango.Loader.TangoCameraNativeStub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ConnectOnTextureAvailable (p0, p1);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.tango.loader']/interface[@name='ITangoCameraNative']/method[@name='connectOnTextureAvailable' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='boolean']]"
		[Register ("connectOnTextureAvailable", "(IZ)I", "GetConnectOnTextureAvailable_IZHandler")]
		public abstract int ConnectOnTextureAvailable (int p0, bool p1);

		static Delegate cb_connectTextureId_IIZ;
#pragma warning disable 0169
		static Delegate GetConnectTextureId_IIZHandler ()
		{
			if (cb_connectTextureId_IIZ == null)
				cb_connectTextureId_IIZ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, int, bool, int>) n_ConnectTextureId_IIZ);
			return cb_connectTextureId_IIZ;
		}

		static int n_ConnectTextureId_IIZ (IntPtr jnienv, IntPtr native__this, int p0, int p1, bool p2)
		{
			global::Com.Google.Tango.Loader.TangoCameraNativeStub __this = global::Java.Lang.Object.GetObject<global::Com.Google.Tango.Loader.TangoCameraNativeStub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ConnectTextureId (p0, p1, p2);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.tango.loader']/interface[@name='ITangoCameraNative']/method[@name='connectTextureId' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='boolean']]"
		[Register ("connectTextureId", "(IIZ)I", "GetConnectTextureId_IIZHandler")]
		public abstract int ConnectTextureId (int p0, int p1, bool p2);

		static Delegate cb_disconnectCamera_I;
#pragma warning disable 0169
		static Delegate GetDisconnectCamera_IHandler ()
		{
			if (cb_disconnectCamera_I == null)
				cb_disconnectCamera_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, int>) n_DisconnectCamera_I);
			return cb_disconnectCamera_I;
		}

		static int n_DisconnectCamera_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Google.Tango.Loader.TangoCameraNativeStub __this = global::Java.Lang.Object.GetObject<global::Com.Google.Tango.Loader.TangoCameraNativeStub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.DisconnectCamera (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.tango.loader']/interface[@name='ITangoCameraNative']/method[@name='disconnectCamera' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("disconnectCamera", "(I)I", "GetDisconnectCamera_IHandler")]
		public abstract int DisconnectCamera (int p0);

		static Delegate cb_initialize_Lcom_google_tango_loader_IObjectWrapper_Lcom_google_atap_tangoservice_ITangoListener_;
#pragma warning disable 0169
		static Delegate GetInitialize_Lcom_google_tango_loader_IObjectWrapper_Lcom_google_atap_tangoservice_ITangoListener_Handler ()
		{
			if (cb_initialize_Lcom_google_tango_loader_IObjectWrapper_Lcom_google_atap_tangoservice_ITangoListener_ == null)
				cb_initialize_Lcom_google_tango_loader_IObjectWrapper_Lcom_google_atap_tangoservice_ITangoListener_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, int>) n_Initialize_Lcom_google_tango_loader_IObjectWrapper_Lcom_google_atap_tangoservice_ITangoListener_);
			return cb_initialize_Lcom_google_tango_loader_IObjectWrapper_Lcom_google_atap_tangoservice_ITangoListener_;
		}

		static int n_Initialize_Lcom_google_tango_loader_IObjectWrapper_Lcom_google_atap_tangoservice_ITangoListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Google.Tango.Loader.TangoCameraNativeStub __this = global::Java.Lang.Object.GetObject<global::Com.Google.Tango.Loader.TangoCameraNativeStub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Google.Tango.Loader.IObjectWrapper p0 = (global::Com.Google.Tango.Loader.IObjectWrapper)global::Java.Lang.Object.GetObject<global::Com.Google.Tango.Loader.IObjectWrapper> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Google.Atap.Tangoservice.ITangoListener p1 = (global::Com.Google.Atap.Tangoservice.ITangoListener)global::Java.Lang.Object.GetObject<global::Com.Google.Atap.Tangoservice.ITangoListener> (native_p1, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.Initialize (p0, p1);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.tango.loader']/interface[@name='ITangoCameraNative']/method[@name='initialize' and count(parameter)=2 and parameter[1][@type='com.google.tango.loader.IObjectWrapper'] and parameter[2][@type='com.google.atap.tangoservice.ITangoListener']]"
		[Register ("initialize", "(Lcom/google/tango/loader/IObjectWrapper;Lcom/google/atap/tangoservice/ITangoListener;)I", "GetInitialize_Lcom_google_tango_loader_IObjectWrapper_Lcom_google_atap_tangoservice_ITangoListener_Handler")]
		public abstract int Initialize (global::Com.Google.Tango.Loader.IObjectWrapper p0, global::Com.Google.Atap.Tangoservice.ITangoListener p1);

		static Delegate cb_lockCameraBuffer_IarrayDarrayJ;
#pragma warning disable 0169
		static Delegate GetLockCameraBuffer_IarrayDarrayJHandler ()
		{
			if (cb_lockCameraBuffer_IarrayDarrayJ == null)
				cb_lockCameraBuffer_IarrayDarrayJ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr, IntPtr, int>) n_LockCameraBuffer_IarrayDarrayJ);
			return cb_lockCameraBuffer_IarrayDarrayJ;
		}

		static int n_LockCameraBuffer_IarrayDarrayJ (IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1, IntPtr native_p2)
		{
			global::Com.Google.Tango.Loader.TangoCameraNativeStub __this = global::Java.Lang.Object.GetObject<global::Com.Google.Tango.Loader.TangoCameraNativeStub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			double[] p1 = (double[]) JNIEnv.GetArray (native_p1, JniHandleOwnership.DoNotTransfer, typeof (double));
			long[] p2 = (long[]) JNIEnv.GetArray (native_p2, JniHandleOwnership.DoNotTransfer, typeof (long));
			int __ret = __this.LockCameraBuffer (p0, p1, p2);
			if (p1 != null)
				JNIEnv.CopyArray (p1, native_p1);
			if (p2 != null)
				JNIEnv.CopyArray (p2, native_p2);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.tango.loader']/interface[@name='ITangoCameraNative']/method[@name='lockCameraBuffer' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='double[]'] and parameter[3][@type='long[]']]"
		[Register ("lockCameraBuffer", "(I[D[J)I", "GetLockCameraBuffer_IarrayDarrayJHandler")]
		public abstract int LockCameraBuffer (int p0, double[] p1, long[] p2);

		static Delegate cb_startCamerasIfNeeded;
#pragma warning disable 0169
		static Delegate GetStartCamerasIfNeededHandler ()
		{
			if (cb_startCamerasIfNeeded == null)
				cb_startCamerasIfNeeded = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_StartCamerasIfNeeded);
			return cb_startCamerasIfNeeded;
		}

		static int n_StartCamerasIfNeeded (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Google.Tango.Loader.TangoCameraNativeStub __this = global::Java.Lang.Object.GetObject<global::Com.Google.Tango.Loader.TangoCameraNativeStub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.StartCamerasIfNeeded ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.tango.loader']/interface[@name='ITangoCameraNative']/method[@name='startCamerasIfNeeded' and count(parameter)=0]"
		[Register ("startCamerasIfNeeded", "()I", "GetStartCamerasIfNeededHandler")]
		public abstract int StartCamerasIfNeeded ();

		static Delegate cb_stopAllCameras;
#pragma warning disable 0169
		static Delegate GetStopAllCamerasHandler ()
		{
			if (cb_stopAllCameras == null)
				cb_stopAllCameras = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_StopAllCameras);
			return cb_stopAllCameras;
		}

		static int n_StopAllCameras (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Google.Tango.Loader.TangoCameraNativeStub __this = global::Java.Lang.Object.GetObject<global::Com.Google.Tango.Loader.TangoCameraNativeStub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.StopAllCameras ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.tango.loader']/interface[@name='ITangoCameraNative']/method[@name='stopAllCameras' and count(parameter)=0]"
		[Register ("stopAllCameras", "()I", "GetStopAllCamerasHandler")]
		public abstract int StopAllCameras ();

		static Delegate cb_unlockCameraBuffer_IJ;
#pragma warning disable 0169
		static Delegate GetUnlockCameraBuffer_IJHandler ()
		{
			if (cb_unlockCameraBuffer_IJ == null)
				cb_unlockCameraBuffer_IJ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, long, int>) n_UnlockCameraBuffer_IJ);
			return cb_unlockCameraBuffer_IJ;
		}

		static int n_UnlockCameraBuffer_IJ (IntPtr jnienv, IntPtr native__this, int p0, long p1)
		{
			global::Com.Google.Tango.Loader.TangoCameraNativeStub __this = global::Java.Lang.Object.GetObject<global::Com.Google.Tango.Loader.TangoCameraNativeStub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.UnlockCameraBuffer (p0, p1);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.tango.loader']/interface[@name='ITangoCameraNative']/method[@name='unlockCameraBuffer' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='long']]"
		[Register ("unlockCameraBuffer", "(IJ)I", "GetUnlockCameraBuffer_IJHandler")]
		public abstract int UnlockCameraBuffer (int p0, long p1);

		static Delegate cb_updateTexture_IarrayD;
#pragma warning disable 0169
		static Delegate GetUpdateTexture_IarrayDHandler ()
		{
			if (cb_updateTexture_IarrayD == null)
				cb_updateTexture_IarrayD = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr, int>) n_UpdateTexture_IarrayD);
			return cb_updateTexture_IarrayD;
		}

		static int n_UpdateTexture_IarrayD (IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1)
		{
			global::Com.Google.Tango.Loader.TangoCameraNativeStub __this = global::Java.Lang.Object.GetObject<global::Com.Google.Tango.Loader.TangoCameraNativeStub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			double[] p1 = (double[]) JNIEnv.GetArray (native_p1, JniHandleOwnership.DoNotTransfer, typeof (double));
			int __ret = __this.UpdateTexture (p0, p1);
			if (p1 != null)
				JNIEnv.CopyArray (p1, native_p1);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.tango.loader']/interface[@name='ITangoCameraNative']/method[@name='updateTexture' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='double[]']]"
		[Register ("updateTexture", "(I[D)I", "GetUpdateTexture_IarrayDHandler")]
		public abstract int UpdateTexture (int p0, double[] p1);

		static Delegate cb_updateTextureExternalOes_IIarrayD;
#pragma warning disable 0169
		static Delegate GetUpdateTextureExternalOes_IIarrayDHandler ()
		{
			if (cb_updateTextureExternalOes_IIarrayD == null)
				cb_updateTextureExternalOes_IIarrayD = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, int, IntPtr, int>) n_UpdateTextureExternalOes_IIarrayD);
			return cb_updateTextureExternalOes_IIarrayD;
		}

		static int n_UpdateTextureExternalOes_IIarrayD (IntPtr jnienv, IntPtr native__this, int p0, int p1, IntPtr native_p2)
		{
			global::Com.Google.Tango.Loader.TangoCameraNativeStub __this = global::Java.Lang.Object.GetObject<global::Com.Google.Tango.Loader.TangoCameraNativeStub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			double[] p2 = (double[]) JNIEnv.GetArray (native_p2, JniHandleOwnership.DoNotTransfer, typeof (double));
			int __ret = __this.UpdateTextureExternalOes (p0, p1, p2);
			if (p2 != null)
				JNIEnv.CopyArray (p2, native_p2);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.tango.loader']/interface[@name='ITangoCameraNative']/method[@name='updateTextureExternalOes' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='double[]']]"
		[Register ("updateTextureExternalOes", "(II[D)I", "GetUpdateTextureExternalOes_IIarrayDHandler")]
		public abstract int UpdateTextureExternalOes (int p0, int p1, double[] p2);

		static Delegate cb_updateTextureExternalOesForBuffer_IIJ;
#pragma warning disable 0169
		static Delegate GetUpdateTextureExternalOesForBuffer_IIJHandler ()
		{
			if (cb_updateTextureExternalOesForBuffer_IIJ == null)
				cb_updateTextureExternalOesForBuffer_IIJ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, int, long, int>) n_UpdateTextureExternalOesForBuffer_IIJ);
			return cb_updateTextureExternalOesForBuffer_IIJ;
		}

		static int n_UpdateTextureExternalOesForBuffer_IIJ (IntPtr jnienv, IntPtr native__this, int p0, int p1, long p2)
		{
			global::Com.Google.Tango.Loader.TangoCameraNativeStub __this = global::Java.Lang.Object.GetObject<global::Com.Google.Tango.Loader.TangoCameraNativeStub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.UpdateTextureExternalOesForBuffer (p0, p1, p2);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.tango.loader']/interface[@name='ITangoCameraNative']/method[@name='updateTextureExternalOesForBuffer' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='long']]"
		[Register ("updateTextureExternalOesForBuffer", "(IIJ)I", "GetUpdateTextureExternalOesForBuffer_IIJHandler")]
		public abstract int UpdateTextureExternalOesForBuffer (int p0, int p1, long p2);

	}

	[global::Android.Runtime.Register ("com/google/tango/loader/ITangoCameraNative$Stub", DoNotGenerateAcw=true)]
	internal partial class TangoCameraNativeStubInvoker : TangoCameraNativeStub {

		public TangoCameraNativeStubInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		protected override global::System.Type ThresholdType {
			get { return typeof (TangoCameraNativeStubInvoker); }
		}

		static IntPtr id_connectOnFrameAvailable_ILcom_google_tango_loader_IObjectWrapper_Lcom_google_tango_loader_IObjectWrapper_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.tango.loader']/interface[@name='ITangoCameraNative']/method[@name='connectOnFrameAvailable' and count(parameter)=4 and parameter[1][@type='int'] and parameter[2][@type='com.google.tango.loader.IObjectWrapper'] and parameter[3][@type='com.google.tango.loader.IObjectWrapper'] and parameter[4][@type='boolean']]"
		[Register ("connectOnFrameAvailable", "(ILcom/google/tango/loader/IObjectWrapper;Lcom/google/tango/loader/IObjectWrapper;Z)I", "GetConnectOnFrameAvailable_ILcom_google_tango_loader_IObjectWrapper_Lcom_google_tango_loader_IObjectWrapper_ZHandler")]
		public override unsafe int ConnectOnFrameAvailable (int p0, global::Com.Google.Tango.Loader.IObjectWrapper p1, global::Com.Google.Tango.Loader.IObjectWrapper p2, bool p3)
		{
			if (id_connectOnFrameAvailable_ILcom_google_tango_loader_IObjectWrapper_Lcom_google_tango_loader_IObjectWrapper_Z == IntPtr.Zero)
				id_connectOnFrameAvailable_ILcom_google_tango_loader_IObjectWrapper_Lcom_google_tango_loader_IObjectWrapper_Z = JNIEnv.GetMethodID (class_ref, "connectOnFrameAvailable", "(ILcom/google/tango/loader/IObjectWrapper;Lcom/google/tango/loader/IObjectWrapper;Z)I");
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				int __ret = JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_connectOnFrameAvailable_ILcom_google_tango_loader_IObjectWrapper_Lcom_google_tango_loader_IObjectWrapper_Z, __args);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_connectOnTextureAvailable_IZ;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.tango.loader']/interface[@name='ITangoCameraNative']/method[@name='connectOnTextureAvailable' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='boolean']]"
		[Register ("connectOnTextureAvailable", "(IZ)I", "GetConnectOnTextureAvailable_IZHandler")]
		public override unsafe int ConnectOnTextureAvailable (int p0, bool p1)
		{
			if (id_connectOnTextureAvailable_IZ == IntPtr.Zero)
				id_connectOnTextureAvailable_IZ = JNIEnv.GetMethodID (class_ref, "connectOnTextureAvailable", "(IZ)I");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_connectOnTextureAvailable_IZ, __args);
			} finally {
			}
		}

		static IntPtr id_connectTextureId_IIZ;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.tango.loader']/interface[@name='ITangoCameraNative']/method[@name='connectTextureId' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='boolean']]"
		[Register ("connectTextureId", "(IIZ)I", "GetConnectTextureId_IIZHandler")]
		public override unsafe int ConnectTextureId (int p0, int p1, bool p2)
		{
			if (id_connectTextureId_IIZ == IntPtr.Zero)
				id_connectTextureId_IIZ = JNIEnv.GetMethodID (class_ref, "connectTextureId", "(IIZ)I");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_connectTextureId_IIZ, __args);
			} finally {
			}
		}

		static IntPtr id_disconnectCamera_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.tango.loader']/interface[@name='ITangoCameraNative']/method[@name='disconnectCamera' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("disconnectCamera", "(I)I", "GetDisconnectCamera_IHandler")]
		public override unsafe int DisconnectCamera (int p0)
		{
			if (id_disconnectCamera_I == IntPtr.Zero)
				id_disconnectCamera_I = JNIEnv.GetMethodID (class_ref, "disconnectCamera", "(I)I");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_disconnectCamera_I, __args);
			} finally {
			}
		}

		static IntPtr id_initialize_Lcom_google_tango_loader_IObjectWrapper_Lcom_google_atap_tangoservice_ITangoListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.tango.loader']/interface[@name='ITangoCameraNative']/method[@name='initialize' and count(parameter)=2 and parameter[1][@type='com.google.tango.loader.IObjectWrapper'] and parameter[2][@type='com.google.atap.tangoservice.ITangoListener']]"
		[Register ("initialize", "(Lcom/google/tango/loader/IObjectWrapper;Lcom/google/atap/tangoservice/ITangoListener;)I", "GetInitialize_Lcom_google_tango_loader_IObjectWrapper_Lcom_google_atap_tangoservice_ITangoListener_Handler")]
		public override unsafe int Initialize (global::Com.Google.Tango.Loader.IObjectWrapper p0, global::Com.Google.Atap.Tangoservice.ITangoListener p1)
		{
			if (id_initialize_Lcom_google_tango_loader_IObjectWrapper_Lcom_google_atap_tangoservice_ITangoListener_ == IntPtr.Zero)
				id_initialize_Lcom_google_tango_loader_IObjectWrapper_Lcom_google_atap_tangoservice_ITangoListener_ = JNIEnv.GetMethodID (class_ref, "initialize", "(Lcom/google/tango/loader/IObjectWrapper;Lcom/google/atap/tangoservice/ITangoListener;)I");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				int __ret = JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_initialize_Lcom_google_tango_loader_IObjectWrapper_Lcom_google_atap_tangoservice_ITangoListener_, __args);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_lockCameraBuffer_IarrayDarrayJ;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.tango.loader']/interface[@name='ITangoCameraNative']/method[@name='lockCameraBuffer' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='double[]'] and parameter[3][@type='long[]']]"
		[Register ("lockCameraBuffer", "(I[D[J)I", "GetLockCameraBuffer_IarrayDarrayJHandler")]
		public override unsafe int LockCameraBuffer (int p0, double[] p1, long[] p2)
		{
			if (id_lockCameraBuffer_IarrayDarrayJ == IntPtr.Zero)
				id_lockCameraBuffer_IarrayDarrayJ = JNIEnv.GetMethodID (class_ref, "lockCameraBuffer", "(I[D[J)I");
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			IntPtr native_p2 = JNIEnv.NewArray (p2);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (native_p2);
				int __ret = JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_lockCameraBuffer_IarrayDarrayJ, __args);
				return __ret;
			} finally {
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

		static IntPtr id_startCamerasIfNeeded;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.tango.loader']/interface[@name='ITangoCameraNative']/method[@name='startCamerasIfNeeded' and count(parameter)=0]"
		[Register ("startCamerasIfNeeded", "()I", "GetStartCamerasIfNeededHandler")]
		public override unsafe int StartCamerasIfNeeded ()
		{
			if (id_startCamerasIfNeeded == IntPtr.Zero)
				id_startCamerasIfNeeded = JNIEnv.GetMethodID (class_ref, "startCamerasIfNeeded", "()I");
			try {
				return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_startCamerasIfNeeded);
			} finally {
			}
		}

		static IntPtr id_stopAllCameras;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.tango.loader']/interface[@name='ITangoCameraNative']/method[@name='stopAllCameras' and count(parameter)=0]"
		[Register ("stopAllCameras", "()I", "GetStopAllCamerasHandler")]
		public override unsafe int StopAllCameras ()
		{
			if (id_stopAllCameras == IntPtr.Zero)
				id_stopAllCameras = JNIEnv.GetMethodID (class_ref, "stopAllCameras", "()I");
			try {
				return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_stopAllCameras);
			} finally {
			}
		}

		static IntPtr id_unlockCameraBuffer_IJ;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.tango.loader']/interface[@name='ITangoCameraNative']/method[@name='unlockCameraBuffer' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='long']]"
		[Register ("unlockCameraBuffer", "(IJ)I", "GetUnlockCameraBuffer_IJHandler")]
		public override unsafe int UnlockCameraBuffer (int p0, long p1)
		{
			if (id_unlockCameraBuffer_IJ == IntPtr.Zero)
				id_unlockCameraBuffer_IJ = JNIEnv.GetMethodID (class_ref, "unlockCameraBuffer", "(IJ)I");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_unlockCameraBuffer_IJ, __args);
			} finally {
			}
		}

		static IntPtr id_updateTexture_IarrayD;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.tango.loader']/interface[@name='ITangoCameraNative']/method[@name='updateTexture' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='double[]']]"
		[Register ("updateTexture", "(I[D)I", "GetUpdateTexture_IarrayDHandler")]
		public override unsafe int UpdateTexture (int p0, double[] p1)
		{
			if (id_updateTexture_IarrayD == IntPtr.Zero)
				id_updateTexture_IarrayD = JNIEnv.GetMethodID (class_ref, "updateTexture", "(I[D)I");
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				int __ret = JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_updateTexture_IarrayD, __args);
				return __ret;
			} finally {
				if (p1 != null) {
					JNIEnv.CopyArray (native_p1, p1);
					JNIEnv.DeleteLocalRef (native_p1);
				}
			}
		}

		static IntPtr id_updateTextureExternalOes_IIarrayD;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.tango.loader']/interface[@name='ITangoCameraNative']/method[@name='updateTextureExternalOes' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='double[]']]"
		[Register ("updateTextureExternalOes", "(II[D)I", "GetUpdateTextureExternalOes_IIarrayDHandler")]
		public override unsafe int UpdateTextureExternalOes (int p0, int p1, double[] p2)
		{
			if (id_updateTextureExternalOes_IIarrayD == IntPtr.Zero)
				id_updateTextureExternalOes_IIarrayD = JNIEnv.GetMethodID (class_ref, "updateTextureExternalOes", "(II[D)I");
			IntPtr native_p2 = JNIEnv.NewArray (p2);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (native_p2);
				int __ret = JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_updateTextureExternalOes_IIarrayD, __args);
				return __ret;
			} finally {
				if (p2 != null) {
					JNIEnv.CopyArray (native_p2, p2);
					JNIEnv.DeleteLocalRef (native_p2);
				}
			}
		}

		static IntPtr id_updateTextureExternalOesForBuffer_IIJ;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.tango.loader']/interface[@name='ITangoCameraNative']/method[@name='updateTextureExternalOesForBuffer' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='long']]"
		[Register ("updateTextureExternalOesForBuffer", "(IIJ)I", "GetUpdateTextureExternalOesForBuffer_IIJHandler")]
		public override unsafe int UpdateTextureExternalOesForBuffer (int p0, int p1, long p2)
		{
			if (id_updateTextureExternalOesForBuffer_IIJ == IntPtr.Zero)
				id_updateTextureExternalOesForBuffer_IIJ = JNIEnv.GetMethodID (class_ref, "updateTextureExternalOesForBuffer", "(IIJ)I");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_updateTextureExternalOesForBuffer_IIJ, __args);
			} finally {
			}
		}

	}


	// Metadata.xml XPath interface reference: path="/api/package[@name='com.google.tango.loader']/interface[@name='ITangoCameraNative']"
	[Register ("com/google/tango/loader/ITangoCameraNative", "", "Com.Google.Tango.Loader.ITangoCameraNativeInvoker")]
	public partial interface ITangoCameraNative : global::Android.OS.IInterface {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.tango.loader']/interface[@name='ITangoCameraNative']/method[@name='connectOnFrameAvailable' and count(parameter)=4 and parameter[1][@type='int'] and parameter[2][@type='com.google.tango.loader.IObjectWrapper'] and parameter[3][@type='com.google.tango.loader.IObjectWrapper'] and parameter[4][@type='boolean']]"
		[Register ("connectOnFrameAvailable", "(ILcom/google/tango/loader/IObjectWrapper;Lcom/google/tango/loader/IObjectWrapper;Z)I", "GetConnectOnFrameAvailable_ILcom_google_tango_loader_IObjectWrapper_Lcom_google_tango_loader_IObjectWrapper_ZHandler:Com.Google.Tango.Loader.ITangoCameraNativeInvoker, tango-sdk-base")]
		int ConnectOnFrameAvailable (int p0, global::Com.Google.Tango.Loader.IObjectWrapper p1, global::Com.Google.Tango.Loader.IObjectWrapper p2, bool p3);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.tango.loader']/interface[@name='ITangoCameraNative']/method[@name='connectOnTextureAvailable' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='boolean']]"
		[Register ("connectOnTextureAvailable", "(IZ)I", "GetConnectOnTextureAvailable_IZHandler:Com.Google.Tango.Loader.ITangoCameraNativeInvoker, tango-sdk-base")]
		int ConnectOnTextureAvailable (int p0, bool p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.tango.loader']/interface[@name='ITangoCameraNative']/method[@name='connectTextureId' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='boolean']]"
		[Register ("connectTextureId", "(IIZ)I", "GetConnectTextureId_IIZHandler:Com.Google.Tango.Loader.ITangoCameraNativeInvoker, tango-sdk-base")]
		int ConnectTextureId (int p0, int p1, bool p2);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.tango.loader']/interface[@name='ITangoCameraNative']/method[@name='disconnectCamera' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("disconnectCamera", "(I)I", "GetDisconnectCamera_IHandler:Com.Google.Tango.Loader.ITangoCameraNativeInvoker, tango-sdk-base")]
		int DisconnectCamera (int p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.tango.loader']/interface[@name='ITangoCameraNative']/method[@name='initialize' and count(parameter)=2 and parameter[1][@type='com.google.tango.loader.IObjectWrapper'] and parameter[2][@type='com.google.atap.tangoservice.ITangoListener']]"
		[Register ("initialize", "(Lcom/google/tango/loader/IObjectWrapper;Lcom/google/atap/tangoservice/ITangoListener;)I", "GetInitialize_Lcom_google_tango_loader_IObjectWrapper_Lcom_google_atap_tangoservice_ITangoListener_Handler:Com.Google.Tango.Loader.ITangoCameraNativeInvoker, tango-sdk-base")]
		int Initialize (global::Com.Google.Tango.Loader.IObjectWrapper p0, global::Com.Google.Atap.Tangoservice.ITangoListener p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.tango.loader']/interface[@name='ITangoCameraNative']/method[@name='lockCameraBuffer' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='double[]'] and parameter[3][@type='long[]']]"
		[Register ("lockCameraBuffer", "(I[D[J)I", "GetLockCameraBuffer_IarrayDarrayJHandler:Com.Google.Tango.Loader.ITangoCameraNativeInvoker, tango-sdk-base")]
		int LockCameraBuffer (int p0, double[] p1, long[] p2);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.tango.loader']/interface[@name='ITangoCameraNative']/method[@name='startCamerasIfNeeded' and count(parameter)=0]"
		[Register ("startCamerasIfNeeded", "()I", "GetStartCamerasIfNeededHandler:Com.Google.Tango.Loader.ITangoCameraNativeInvoker, tango-sdk-base")]
		int StartCamerasIfNeeded ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.tango.loader']/interface[@name='ITangoCameraNative']/method[@name='stopAllCameras' and count(parameter)=0]"
		[Register ("stopAllCameras", "()I", "GetStopAllCamerasHandler:Com.Google.Tango.Loader.ITangoCameraNativeInvoker, tango-sdk-base")]
		int StopAllCameras ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.tango.loader']/interface[@name='ITangoCameraNative']/method[@name='unlockCameraBuffer' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='long']]"
		[Register ("unlockCameraBuffer", "(IJ)I", "GetUnlockCameraBuffer_IJHandler:Com.Google.Tango.Loader.ITangoCameraNativeInvoker, tango-sdk-base")]
		int UnlockCameraBuffer (int p0, long p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.tango.loader']/interface[@name='ITangoCameraNative']/method[@name='updateTexture' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='double[]']]"
		[Register ("updateTexture", "(I[D)I", "GetUpdateTexture_IarrayDHandler:Com.Google.Tango.Loader.ITangoCameraNativeInvoker, tango-sdk-base")]
		int UpdateTexture (int p0, double[] p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.tango.loader']/interface[@name='ITangoCameraNative']/method[@name='updateTextureExternalOes' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='double[]']]"
		[Register ("updateTextureExternalOes", "(II[D)I", "GetUpdateTextureExternalOes_IIarrayDHandler:Com.Google.Tango.Loader.ITangoCameraNativeInvoker, tango-sdk-base")]
		int UpdateTextureExternalOes (int p0, int p1, double[] p2);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.tango.loader']/interface[@name='ITangoCameraNative']/method[@name='updateTextureExternalOesForBuffer' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='long']]"
		[Register ("updateTextureExternalOesForBuffer", "(IIJ)I", "GetUpdateTextureExternalOesForBuffer_IIJHandler:Com.Google.Tango.Loader.ITangoCameraNativeInvoker, tango-sdk-base")]
		int UpdateTextureExternalOesForBuffer (int p0, int p1, long p2);

	}

	[global::Android.Runtime.Register ("com/google/tango/loader/ITangoCameraNative", DoNotGenerateAcw=true)]
	internal class ITangoCameraNativeInvoker : global::Java.Lang.Object, ITangoCameraNative {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/google/tango/loader/ITangoCameraNative");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ITangoCameraNativeInvoker); }
		}

		IntPtr class_ref;

		public static ITangoCameraNative GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<ITangoCameraNative> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.google.tango.loader.ITangoCameraNative"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public ITangoCameraNativeInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_connectOnFrameAvailable_ILcom_google_tango_loader_IObjectWrapper_Lcom_google_tango_loader_IObjectWrapper_Z;
#pragma warning disable 0169
		static Delegate GetConnectOnFrameAvailable_ILcom_google_tango_loader_IObjectWrapper_Lcom_google_tango_loader_IObjectWrapper_ZHandler ()
		{
			if (cb_connectOnFrameAvailable_ILcom_google_tango_loader_IObjectWrapper_Lcom_google_tango_loader_IObjectWrapper_Z == null)
				cb_connectOnFrameAvailable_ILcom_google_tango_loader_IObjectWrapper_Lcom_google_tango_loader_IObjectWrapper_Z = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr, IntPtr, bool, int>) n_ConnectOnFrameAvailable_ILcom_google_tango_loader_IObjectWrapper_Lcom_google_tango_loader_IObjectWrapper_Z);
			return cb_connectOnFrameAvailable_ILcom_google_tango_loader_IObjectWrapper_Lcom_google_tango_loader_IObjectWrapper_Z;
		}

		static int n_ConnectOnFrameAvailable_ILcom_google_tango_loader_IObjectWrapper_Lcom_google_tango_loader_IObjectWrapper_Z (IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1, IntPtr native_p2, bool p3)
		{
			global::Com.Google.Tango.Loader.ITangoCameraNative __this = global::Java.Lang.Object.GetObject<global::Com.Google.Tango.Loader.ITangoCameraNative> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Google.Tango.Loader.IObjectWrapper p1 = (global::Com.Google.Tango.Loader.IObjectWrapper)global::Java.Lang.Object.GetObject<global::Com.Google.Tango.Loader.IObjectWrapper> (native_p1, JniHandleOwnership.DoNotTransfer);
			global::Com.Google.Tango.Loader.IObjectWrapper p2 = (global::Com.Google.Tango.Loader.IObjectWrapper)global::Java.Lang.Object.GetObject<global::Com.Google.Tango.Loader.IObjectWrapper> (native_p2, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.ConnectOnFrameAvailable (p0, p1, p2, p3);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_connectOnFrameAvailable_ILcom_google_tango_loader_IObjectWrapper_Lcom_google_tango_loader_IObjectWrapper_Z;
		public unsafe int ConnectOnFrameAvailable (int p0, global::Com.Google.Tango.Loader.IObjectWrapper p1, global::Com.Google.Tango.Loader.IObjectWrapper p2, bool p3)
		{
			if (id_connectOnFrameAvailable_ILcom_google_tango_loader_IObjectWrapper_Lcom_google_tango_loader_IObjectWrapper_Z == IntPtr.Zero)
				id_connectOnFrameAvailable_ILcom_google_tango_loader_IObjectWrapper_Lcom_google_tango_loader_IObjectWrapper_Z = JNIEnv.GetMethodID (class_ref, "connectOnFrameAvailable", "(ILcom/google/tango/loader/IObjectWrapper;Lcom/google/tango/loader/IObjectWrapper;Z)I");
			JValue* __args = stackalloc JValue [4];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (p1);
			__args [2] = new JValue (p2);
			__args [3] = new JValue (p3);
			int __ret = JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_connectOnFrameAvailable_ILcom_google_tango_loader_IObjectWrapper_Lcom_google_tango_loader_IObjectWrapper_Z, __args);
			return __ret;
		}

		static Delegate cb_connectOnTextureAvailable_IZ;
#pragma warning disable 0169
		static Delegate GetConnectOnTextureAvailable_IZHandler ()
		{
			if (cb_connectOnTextureAvailable_IZ == null)
				cb_connectOnTextureAvailable_IZ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, bool, int>) n_ConnectOnTextureAvailable_IZ);
			return cb_connectOnTextureAvailable_IZ;
		}

		static int n_ConnectOnTextureAvailable_IZ (IntPtr jnienv, IntPtr native__this, int p0, bool p1)
		{
			global::Com.Google.Tango.Loader.ITangoCameraNative __this = global::Java.Lang.Object.GetObject<global::Com.Google.Tango.Loader.ITangoCameraNative> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ConnectOnTextureAvailable (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_connectOnTextureAvailable_IZ;
		public unsafe int ConnectOnTextureAvailable (int p0, bool p1)
		{
			if (id_connectOnTextureAvailable_IZ == IntPtr.Zero)
				id_connectOnTextureAvailable_IZ = JNIEnv.GetMethodID (class_ref, "connectOnTextureAvailable", "(IZ)I");
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (p1);
			return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_connectOnTextureAvailable_IZ, __args);
		}

		static Delegate cb_connectTextureId_IIZ;
#pragma warning disable 0169
		static Delegate GetConnectTextureId_IIZHandler ()
		{
			if (cb_connectTextureId_IIZ == null)
				cb_connectTextureId_IIZ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, int, bool, int>) n_ConnectTextureId_IIZ);
			return cb_connectTextureId_IIZ;
		}

		static int n_ConnectTextureId_IIZ (IntPtr jnienv, IntPtr native__this, int p0, int p1, bool p2)
		{
			global::Com.Google.Tango.Loader.ITangoCameraNative __this = global::Java.Lang.Object.GetObject<global::Com.Google.Tango.Loader.ITangoCameraNative> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ConnectTextureId (p0, p1, p2);
		}
#pragma warning restore 0169

		IntPtr id_connectTextureId_IIZ;
		public unsafe int ConnectTextureId (int p0, int p1, bool p2)
		{
			if (id_connectTextureId_IIZ == IntPtr.Zero)
				id_connectTextureId_IIZ = JNIEnv.GetMethodID (class_ref, "connectTextureId", "(IIZ)I");
			JValue* __args = stackalloc JValue [3];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (p1);
			__args [2] = new JValue (p2);
			return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_connectTextureId_IIZ, __args);
		}

		static Delegate cb_disconnectCamera_I;
#pragma warning disable 0169
		static Delegate GetDisconnectCamera_IHandler ()
		{
			if (cb_disconnectCamera_I == null)
				cb_disconnectCamera_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, int>) n_DisconnectCamera_I);
			return cb_disconnectCamera_I;
		}

		static int n_DisconnectCamera_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Google.Tango.Loader.ITangoCameraNative __this = global::Java.Lang.Object.GetObject<global::Com.Google.Tango.Loader.ITangoCameraNative> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.DisconnectCamera (p0);
		}
#pragma warning restore 0169

		IntPtr id_disconnectCamera_I;
		public unsafe int DisconnectCamera (int p0)
		{
			if (id_disconnectCamera_I == IntPtr.Zero)
				id_disconnectCamera_I = JNIEnv.GetMethodID (class_ref, "disconnectCamera", "(I)I");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_disconnectCamera_I, __args);
		}

		static Delegate cb_initialize_Lcom_google_tango_loader_IObjectWrapper_Lcom_google_atap_tangoservice_ITangoListener_;
#pragma warning disable 0169
		static Delegate GetInitialize_Lcom_google_tango_loader_IObjectWrapper_Lcom_google_atap_tangoservice_ITangoListener_Handler ()
		{
			if (cb_initialize_Lcom_google_tango_loader_IObjectWrapper_Lcom_google_atap_tangoservice_ITangoListener_ == null)
				cb_initialize_Lcom_google_tango_loader_IObjectWrapper_Lcom_google_atap_tangoservice_ITangoListener_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, int>) n_Initialize_Lcom_google_tango_loader_IObjectWrapper_Lcom_google_atap_tangoservice_ITangoListener_);
			return cb_initialize_Lcom_google_tango_loader_IObjectWrapper_Lcom_google_atap_tangoservice_ITangoListener_;
		}

		static int n_Initialize_Lcom_google_tango_loader_IObjectWrapper_Lcom_google_atap_tangoservice_ITangoListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Google.Tango.Loader.ITangoCameraNative __this = global::Java.Lang.Object.GetObject<global::Com.Google.Tango.Loader.ITangoCameraNative> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Google.Tango.Loader.IObjectWrapper p0 = (global::Com.Google.Tango.Loader.IObjectWrapper)global::Java.Lang.Object.GetObject<global::Com.Google.Tango.Loader.IObjectWrapper> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Google.Atap.Tangoservice.ITangoListener p1 = (global::Com.Google.Atap.Tangoservice.ITangoListener)global::Java.Lang.Object.GetObject<global::Com.Google.Atap.Tangoservice.ITangoListener> (native_p1, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.Initialize (p0, p1);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_initialize_Lcom_google_tango_loader_IObjectWrapper_Lcom_google_atap_tangoservice_ITangoListener_;
		public unsafe int Initialize (global::Com.Google.Tango.Loader.IObjectWrapper p0, global::Com.Google.Atap.Tangoservice.ITangoListener p1)
		{
			if (id_initialize_Lcom_google_tango_loader_IObjectWrapper_Lcom_google_atap_tangoservice_ITangoListener_ == IntPtr.Zero)
				id_initialize_Lcom_google_tango_loader_IObjectWrapper_Lcom_google_atap_tangoservice_ITangoListener_ = JNIEnv.GetMethodID (class_ref, "initialize", "(Lcom/google/tango/loader/IObjectWrapper;Lcom/google/atap/tangoservice/ITangoListener;)I");
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (p1);
			int __ret = JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_initialize_Lcom_google_tango_loader_IObjectWrapper_Lcom_google_atap_tangoservice_ITangoListener_, __args);
			return __ret;
		}

		static Delegate cb_lockCameraBuffer_IarrayDarrayJ;
#pragma warning disable 0169
		static Delegate GetLockCameraBuffer_IarrayDarrayJHandler ()
		{
			if (cb_lockCameraBuffer_IarrayDarrayJ == null)
				cb_lockCameraBuffer_IarrayDarrayJ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr, IntPtr, int>) n_LockCameraBuffer_IarrayDarrayJ);
			return cb_lockCameraBuffer_IarrayDarrayJ;
		}

		static int n_LockCameraBuffer_IarrayDarrayJ (IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1, IntPtr native_p2)
		{
			global::Com.Google.Tango.Loader.ITangoCameraNative __this = global::Java.Lang.Object.GetObject<global::Com.Google.Tango.Loader.ITangoCameraNative> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			double[] p1 = (double[]) JNIEnv.GetArray (native_p1, JniHandleOwnership.DoNotTransfer, typeof (double));
			long[] p2 = (long[]) JNIEnv.GetArray (native_p2, JniHandleOwnership.DoNotTransfer, typeof (long));
			int __ret = __this.LockCameraBuffer (p0, p1, p2);
			if (p1 != null)
				JNIEnv.CopyArray (p1, native_p1);
			if (p2 != null)
				JNIEnv.CopyArray (p2, native_p2);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_lockCameraBuffer_IarrayDarrayJ;
		public unsafe int LockCameraBuffer (int p0, double[] p1, long[] p2)
		{
			if (id_lockCameraBuffer_IarrayDarrayJ == IntPtr.Zero)
				id_lockCameraBuffer_IarrayDarrayJ = JNIEnv.GetMethodID (class_ref, "lockCameraBuffer", "(I[D[J)I");
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			IntPtr native_p2 = JNIEnv.NewArray (p2);
			JValue* __args = stackalloc JValue [3];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (native_p1);
			__args [2] = new JValue (native_p2);
			int __ret = JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_lockCameraBuffer_IarrayDarrayJ, __args);
			if (p1 != null) {
				JNIEnv.CopyArray (native_p1, p1);
				JNIEnv.DeleteLocalRef (native_p1);
			}
			if (p2 != null) {
				JNIEnv.CopyArray (native_p2, p2);
				JNIEnv.DeleteLocalRef (native_p2);
			}
			return __ret;
		}

		static Delegate cb_startCamerasIfNeeded;
#pragma warning disable 0169
		static Delegate GetStartCamerasIfNeededHandler ()
		{
			if (cb_startCamerasIfNeeded == null)
				cb_startCamerasIfNeeded = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_StartCamerasIfNeeded);
			return cb_startCamerasIfNeeded;
		}

		static int n_StartCamerasIfNeeded (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Google.Tango.Loader.ITangoCameraNative __this = global::Java.Lang.Object.GetObject<global::Com.Google.Tango.Loader.ITangoCameraNative> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.StartCamerasIfNeeded ();
		}
#pragma warning restore 0169

		IntPtr id_startCamerasIfNeeded;
		public unsafe int StartCamerasIfNeeded ()
		{
			if (id_startCamerasIfNeeded == IntPtr.Zero)
				id_startCamerasIfNeeded = JNIEnv.GetMethodID (class_ref, "startCamerasIfNeeded", "()I");
			return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_startCamerasIfNeeded);
		}

		static Delegate cb_stopAllCameras;
#pragma warning disable 0169
		static Delegate GetStopAllCamerasHandler ()
		{
			if (cb_stopAllCameras == null)
				cb_stopAllCameras = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_StopAllCameras);
			return cb_stopAllCameras;
		}

		static int n_StopAllCameras (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Google.Tango.Loader.ITangoCameraNative __this = global::Java.Lang.Object.GetObject<global::Com.Google.Tango.Loader.ITangoCameraNative> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.StopAllCameras ();
		}
#pragma warning restore 0169

		IntPtr id_stopAllCameras;
		public unsafe int StopAllCameras ()
		{
			if (id_stopAllCameras == IntPtr.Zero)
				id_stopAllCameras = JNIEnv.GetMethodID (class_ref, "stopAllCameras", "()I");
			return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_stopAllCameras);
		}

		static Delegate cb_unlockCameraBuffer_IJ;
#pragma warning disable 0169
		static Delegate GetUnlockCameraBuffer_IJHandler ()
		{
			if (cb_unlockCameraBuffer_IJ == null)
				cb_unlockCameraBuffer_IJ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, long, int>) n_UnlockCameraBuffer_IJ);
			return cb_unlockCameraBuffer_IJ;
		}

		static int n_UnlockCameraBuffer_IJ (IntPtr jnienv, IntPtr native__this, int p0, long p1)
		{
			global::Com.Google.Tango.Loader.ITangoCameraNative __this = global::Java.Lang.Object.GetObject<global::Com.Google.Tango.Loader.ITangoCameraNative> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.UnlockCameraBuffer (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_unlockCameraBuffer_IJ;
		public unsafe int UnlockCameraBuffer (int p0, long p1)
		{
			if (id_unlockCameraBuffer_IJ == IntPtr.Zero)
				id_unlockCameraBuffer_IJ = JNIEnv.GetMethodID (class_ref, "unlockCameraBuffer", "(IJ)I");
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (p1);
			return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_unlockCameraBuffer_IJ, __args);
		}

		static Delegate cb_updateTexture_IarrayD;
#pragma warning disable 0169
		static Delegate GetUpdateTexture_IarrayDHandler ()
		{
			if (cb_updateTexture_IarrayD == null)
				cb_updateTexture_IarrayD = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr, int>) n_UpdateTexture_IarrayD);
			return cb_updateTexture_IarrayD;
		}

		static int n_UpdateTexture_IarrayD (IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1)
		{
			global::Com.Google.Tango.Loader.ITangoCameraNative __this = global::Java.Lang.Object.GetObject<global::Com.Google.Tango.Loader.ITangoCameraNative> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			double[] p1 = (double[]) JNIEnv.GetArray (native_p1, JniHandleOwnership.DoNotTransfer, typeof (double));
			int __ret = __this.UpdateTexture (p0, p1);
			if (p1 != null)
				JNIEnv.CopyArray (p1, native_p1);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_updateTexture_IarrayD;
		public unsafe int UpdateTexture (int p0, double[] p1)
		{
			if (id_updateTexture_IarrayD == IntPtr.Zero)
				id_updateTexture_IarrayD = JNIEnv.GetMethodID (class_ref, "updateTexture", "(I[D)I");
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (native_p1);
			int __ret = JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_updateTexture_IarrayD, __args);
			if (p1 != null) {
				JNIEnv.CopyArray (native_p1, p1);
				JNIEnv.DeleteLocalRef (native_p1);
			}
			return __ret;
		}

		static Delegate cb_updateTextureExternalOes_IIarrayD;
#pragma warning disable 0169
		static Delegate GetUpdateTextureExternalOes_IIarrayDHandler ()
		{
			if (cb_updateTextureExternalOes_IIarrayD == null)
				cb_updateTextureExternalOes_IIarrayD = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, int, IntPtr, int>) n_UpdateTextureExternalOes_IIarrayD);
			return cb_updateTextureExternalOes_IIarrayD;
		}

		static int n_UpdateTextureExternalOes_IIarrayD (IntPtr jnienv, IntPtr native__this, int p0, int p1, IntPtr native_p2)
		{
			global::Com.Google.Tango.Loader.ITangoCameraNative __this = global::Java.Lang.Object.GetObject<global::Com.Google.Tango.Loader.ITangoCameraNative> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			double[] p2 = (double[]) JNIEnv.GetArray (native_p2, JniHandleOwnership.DoNotTransfer, typeof (double));
			int __ret = __this.UpdateTextureExternalOes (p0, p1, p2);
			if (p2 != null)
				JNIEnv.CopyArray (p2, native_p2);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_updateTextureExternalOes_IIarrayD;
		public unsafe int UpdateTextureExternalOes (int p0, int p1, double[] p2)
		{
			if (id_updateTextureExternalOes_IIarrayD == IntPtr.Zero)
				id_updateTextureExternalOes_IIarrayD = JNIEnv.GetMethodID (class_ref, "updateTextureExternalOes", "(II[D)I");
			IntPtr native_p2 = JNIEnv.NewArray (p2);
			JValue* __args = stackalloc JValue [3];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (p1);
			__args [2] = new JValue (native_p2);
			int __ret = JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_updateTextureExternalOes_IIarrayD, __args);
			if (p2 != null) {
				JNIEnv.CopyArray (native_p2, p2);
				JNIEnv.DeleteLocalRef (native_p2);
			}
			return __ret;
		}

		static Delegate cb_updateTextureExternalOesForBuffer_IIJ;
#pragma warning disable 0169
		static Delegate GetUpdateTextureExternalOesForBuffer_IIJHandler ()
		{
			if (cb_updateTextureExternalOesForBuffer_IIJ == null)
				cb_updateTextureExternalOesForBuffer_IIJ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, int, long, int>) n_UpdateTextureExternalOesForBuffer_IIJ);
			return cb_updateTextureExternalOesForBuffer_IIJ;
		}

		static int n_UpdateTextureExternalOesForBuffer_IIJ (IntPtr jnienv, IntPtr native__this, int p0, int p1, long p2)
		{
			global::Com.Google.Tango.Loader.ITangoCameraNative __this = global::Java.Lang.Object.GetObject<global::Com.Google.Tango.Loader.ITangoCameraNative> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.UpdateTextureExternalOesForBuffer (p0, p1, p2);
		}
#pragma warning restore 0169

		IntPtr id_updateTextureExternalOesForBuffer_IIJ;
		public unsafe int UpdateTextureExternalOesForBuffer (int p0, int p1, long p2)
		{
			if (id_updateTextureExternalOesForBuffer_IIJ == IntPtr.Zero)
				id_updateTextureExternalOesForBuffer_IIJ = JNIEnv.GetMethodID (class_ref, "updateTextureExternalOesForBuffer", "(IIJ)I");
			JValue* __args = stackalloc JValue [3];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (p1);
			__args [2] = new JValue (p2);
			return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_updateTextureExternalOesForBuffer_IIJ, __args);
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
			global::Com.Google.Tango.Loader.ITangoCameraNative __this = global::Java.Lang.Object.GetObject<global::Com.Google.Tango.Loader.ITangoCameraNative> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
