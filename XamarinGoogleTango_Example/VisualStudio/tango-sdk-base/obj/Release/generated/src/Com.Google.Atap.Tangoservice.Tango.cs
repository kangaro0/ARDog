using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Google.Atap.Tangoservice {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.google.atap.tangoservice']/class[@name='Tango']"
	[global::Android.Runtime.Register ("com/google/atap/tangoservice/Tango", DoNotGenerateAcw=true)]
	public partial class Tango : global::Java.Lang.Object {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.atap.tangoservice']/class[@name='Tango']/field[@name='ANDROID_PERMISSION_DATASET']"
		[Register ("ANDROID_PERMISSION_DATASET")]
		public const string AndroidPermissionDataset = (string) "com.google.tango.permission.DATASETS";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.atap.tangoservice']/class[@name='Tango']/field[@name='COORDINATE_FRAME_CAMERA_DEPTH']"
		[Register ("COORDINATE_FRAME_CAMERA_DEPTH")]
		public const string CoordinateFrameCameraDepth = (string) "10000000-0000-0000-0000-000000000008";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.atap.tangoservice']/class[@name='Tango']/field[@name='COORDINATE_FRAME_CAMERA_FISHEYE']"
		[Register ("COORDINATE_FRAME_CAMERA_FISHEYE")]
		public const string CoordinateFrameCameraFisheye = (string) "10000000-0000-0000-0000-000000000009";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.atap.tangoservice']/class[@name='Tango']/field[@name='COORDINATE_FRAME_ID_AREA_DESCRIPTION']"
		[Register ("COORDINATE_FRAME_ID_AREA_DESCRIPTION")]
		public const string CoordinateFrameIdAreaDescription = (string) "10000000-0000-0000-0000-000000000001";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.atap.tangoservice']/class[@name='Tango']/field[@name='COORDINATE_FRAME_ID_CAMERA_COLOR']"
		[Register ("COORDINATE_FRAME_ID_CAMERA_COLOR")]
		public const string CoordinateFrameIdCameraColor = (string) "10000000-0000-0000-0000-000000000007";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.atap.tangoservice']/class[@name='Tango']/field[@name='COORDINATE_FRAME_ID_DEVICE']"
		[Register ("COORDINATE_FRAME_ID_DEVICE")]
		public const string CoordinateFrameIdDevice = (string) "10000000-0000-0000-0000-000000000004";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.atap.tangoservice']/class[@name='Tango']/field[@name='COORDINATE_FRAME_ID_DISPLAY']"
		[Register ("COORDINATE_FRAME_ID_DISPLAY")]
		public const string CoordinateFrameIdDisplay = (string) "10000000-0000-0000-0000-000000000006";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.atap.tangoservice']/class[@name='Tango']/field[@name='COORDINATE_FRAME_ID_GLOBAL_WGS84']"
		[Register ("COORDINATE_FRAME_ID_GLOBAL_WGS84")]
		public const string CoordinateFrameIdGlobalWgs84 = (string) "10000000-0000-0000-0000-000000000000";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.atap.tangoservice']/class[@name='Tango']/field[@name='COORDINATE_FRAME_ID_IMU']"
		[Register ("COORDINATE_FRAME_ID_IMU")]
		public const string CoordinateFrameIdImu = (string) "10000000-0000-0000-0000-000000000005";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.atap.tangoservice']/class[@name='Tango']/field[@name='COORDINATE_FRAME_ID_NONE']"
		[Register ("COORDINATE_FRAME_ID_NONE")]
		public const string CoordinateFrameIdNone = (string) "10000000-0000-0000-0000-0000000000ff";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.atap.tangoservice']/class[@name='Tango']/field[@name='COORDINATE_FRAME_ID_PREVIOUS_DEVICE_POSE']"
		[Register ("COORDINATE_FRAME_ID_PREVIOUS_DEVICE_POSE")]
		public const string CoordinateFrameIdPreviousDevicePose = (string) "10000000-0000-0000-0000-000000000003";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.atap.tangoservice']/class[@name='Tango']/field[@name='COORDINATE_FRAME_ID_START_OF_SERVICE']"
		[Register ("COORDINATE_FRAME_ID_START_OF_SERVICE")]
		public const string CoordinateFrameIdStartOfService = (string) "10000000-0000-0000-0000-000000000002";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.atap.tangoservice']/class[@name='Tango']/field[@name='EXTRA_KEY_DESTINATIONUUID']"
		[Register ("EXTRA_KEY_DESTINATIONUUID")]
		public const string ExtraKeyDestinationuuid = (string) "DESTINATION_UUID";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.atap.tangoservice']/class[@name='Tango']/field[@name='PERMISSIONTYPE_ADF_LOAD_SAVE']"
		[Register ("PERMISSIONTYPE_ADF_LOAD_SAVE")]
		public const string PermissiontypeAdfLoadSave = (string) "ADF_LOAD_SAVE_PERMISSION";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.atap.tangoservice']/class[@name='Tango']/field[@name='PERMISSIONTYPE_DATASET']"
		[Register ("PERMISSIONTYPE_DATASET")]
		public const string PermissiontypeDataset = (string) "DATASET_PERMISSION";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.atap.tangoservice']/class[@name='Tango']/field[@name='PERMISSIONTYPE_MOTION_TRACKING']"
		[Register ("PERMISSIONTYPE_MOTION_TRACKING")]
		public const string PermissiontypeMotionTracking = (string) "MOTION_TRACKING_PERMISSION";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.atap.tangoservice']/class[@name='Tango']/field[@name='STATUS_ERROR']"
		[Register ("STATUS_ERROR")]
		public const int StatusError = (int) -1;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.atap.tangoservice']/class[@name='Tango']/field[@name='STATUS_INVALID']"
		[Register ("STATUS_INVALID")]
		public const int StatusInvalid = (int) -2;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.atap.tangoservice']/class[@name='Tango']/field[@name='STATUS_SUCCESS']"
		[Register ("STATUS_SUCCESS")]
		public const int StatusSuccess = (int) 0;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.atap.tangoservice']/class[@name='Tango']/field[@name='TANGO_INTENT_ACTIVITYCODE']"
		[Register ("TANGO_INTENT_ACTIVITYCODE")]
		public const int TangoIntentActivitycode = (int) 1129;
		// Metadata.xml XPath interface reference: path="/api/package[@name='com.google.atap.tangoservice']/interface[@name='Tango.FoiListener']"
		[Register ("com/google/atap/tangoservice/Tango$FoiListener", "", "Com.Google.Atap.Tangoservice.Tango/IFoiListenerInvoker")]
		public partial interface IFoiListener : IJavaObject {

			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.atap.tangoservice']/interface[@name='Tango.FoiListener']/method[@name='onFoiResult' and count(parameter)=1 and parameter[1][@type='com.google.atap.tangoservice.TangoFoiResult[]']]"
			[Register ("onFoiResult", "([Lcom/google/atap/tangoservice/TangoFoiResult;)V", "GetOnFoiResult_arrayLcom_google_atap_tangoservice_TangoFoiResult_Handler:Com.Google.Atap.Tangoservice.Tango/IFoiListenerInvoker, tango-sdk-base")]
			void OnFoiResult (global::Com.Google.Atap.Tangoservice.TangoFoiResult[] p0);

		}

		[global::Android.Runtime.Register ("com/google/atap/tangoservice/Tango$FoiListener", DoNotGenerateAcw=true)]
		internal class IFoiListenerInvoker : global::Java.Lang.Object, IFoiListener {

			static IntPtr java_class_ref = JNIEnv.FindClass ("com/google/atap/tangoservice/Tango$FoiListener");

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (IFoiListenerInvoker); }
			}

			IntPtr class_ref;

			public static IFoiListener GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IFoiListener> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.google.atap.tangoservice.Tango.FoiListener"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IFoiListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			static Delegate cb_onFoiResult_arrayLcom_google_atap_tangoservice_TangoFoiResult_;
#pragma warning disable 0169
			static Delegate GetOnFoiResult_arrayLcom_google_atap_tangoservice_TangoFoiResult_Handler ()
			{
				if (cb_onFoiResult_arrayLcom_google_atap_tangoservice_TangoFoiResult_ == null)
					cb_onFoiResult_arrayLcom_google_atap_tangoservice_TangoFoiResult_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnFoiResult_arrayLcom_google_atap_tangoservice_TangoFoiResult_);
				return cb_onFoiResult_arrayLcom_google_atap_tangoservice_TangoFoiResult_;
			}

			static void n_OnFoiResult_arrayLcom_google_atap_tangoservice_TangoFoiResult_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Google.Atap.Tangoservice.Tango.IFoiListener __this = global::Java.Lang.Object.GetObject<global::Com.Google.Atap.Tangoservice.Tango.IFoiListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Com.Google.Atap.Tangoservice.TangoFoiResult[] p0 = (global::Com.Google.Atap.Tangoservice.TangoFoiResult[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (global::Com.Google.Atap.Tangoservice.TangoFoiResult));
				__this.OnFoiResult (p0);
				if (p0 != null)
					JNIEnv.CopyArray (p0, native_p0);
			}
#pragma warning restore 0169

			IntPtr id_onFoiResult_arrayLcom_google_atap_tangoservice_TangoFoiResult_;
			public unsafe void OnFoiResult (global::Com.Google.Atap.Tangoservice.TangoFoiResult[] p0)
			{
				if (id_onFoiResult_arrayLcom_google_atap_tangoservice_TangoFoiResult_ == IntPtr.Zero)
					id_onFoiResult_arrayLcom_google_atap_tangoservice_TangoFoiResult_ = JNIEnv.GetMethodID (class_ref, "onFoiResult", "([Lcom/google/atap/tangoservice/TangoFoiResult;)V");
				IntPtr native_p0 = JNIEnv.NewArray (p0);
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onFoiResult_arrayLcom_google_atap_tangoservice_TangoFoiResult_, __args);
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

		}

		public partial class FoiEventArgs : global::System.EventArgs {

			public FoiEventArgs (global::Com.Google.Atap.Tangoservice.TangoFoiResult[] p0)
			{
				this.p0 = p0;
			}

			global::Com.Google.Atap.Tangoservice.TangoFoiResult[] p0;
			public global::Com.Google.Atap.Tangoservice.TangoFoiResult[] P0 {
				get { return p0; }
			}
		}

		[global::Android.Runtime.Register ("mono/com/google/atap/tangoservice/Tango_FoiListenerImplementor")]
		internal sealed partial class IFoiListenerImplementor : global::Java.Lang.Object, IFoiListener {

			object sender;

			public IFoiListenerImplementor (object sender)
				: base (
					global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/google/atap/tangoservice/Tango_FoiListenerImplementor", "()V"),
					JniHandleOwnership.TransferLocalRef)
			{
				global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
				this.sender = sender;
			}

#pragma warning disable 0649
			public EventHandler<FoiEventArgs> Handler;
#pragma warning restore 0649

			public void OnFoiResult (global::Com.Google.Atap.Tangoservice.TangoFoiResult[] p0)
			{
				var __h = Handler;
				if (__h != null)
					__h (sender, new FoiEventArgs (p0));
			}

			internal static bool __IsEmpty (IFoiListenerImplementor value)
			{
				return value.Handler == null;
			}
		}


		// Metadata.xml XPath interface reference: path="/api/package[@name='com.google.atap.tangoservice']/interface[@name='Tango.OnFrameAvailableListener']"
		[Register ("com/google/atap/tangoservice/Tango$OnFrameAvailableListener", "", "Com.Google.Atap.Tangoservice.Tango/IOnFrameAvailableListenerInvoker")]
		public partial interface IOnFrameAvailableListener : IJavaObject {

			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.atap.tangoservice']/interface[@name='Tango.OnFrameAvailableListener']/method[@name='onFrameAvailable' and count(parameter)=2 and parameter[1][@type='com.google.atap.tangoservice.experimental.TangoImageBuffer'] and parameter[2][@type='int']]"
			[Register ("onFrameAvailable", "(Lcom/google/atap/tangoservice/experimental/TangoImageBuffer;I)V", "GetOnFrameAvailable_Lcom_google_atap_tangoservice_experimental_TangoImageBuffer_IHandler:Com.Google.Atap.Tangoservice.Tango/IOnFrameAvailableListenerInvoker, tango-sdk-base")]
			void OnFrameAvailable (global::Com.Google.Atap.Tangoservice.Experimental.TangoImageBuffer p0, int p1);

		}

		[global::Android.Runtime.Register ("com/google/atap/tangoservice/Tango$OnFrameAvailableListener", DoNotGenerateAcw=true)]
		internal class IOnFrameAvailableListenerInvoker : global::Java.Lang.Object, IOnFrameAvailableListener {

			static IntPtr java_class_ref = JNIEnv.FindClass ("com/google/atap/tangoservice/Tango$OnFrameAvailableListener");

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (IOnFrameAvailableListenerInvoker); }
			}

			IntPtr class_ref;

			public static IOnFrameAvailableListener GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IOnFrameAvailableListener> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.google.atap.tangoservice.Tango.OnFrameAvailableListener"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IOnFrameAvailableListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			static Delegate cb_onFrameAvailable_Lcom_google_atap_tangoservice_experimental_TangoImageBuffer_I;
#pragma warning disable 0169
			static Delegate GetOnFrameAvailable_Lcom_google_atap_tangoservice_experimental_TangoImageBuffer_IHandler ()
			{
				if (cb_onFrameAvailable_Lcom_google_atap_tangoservice_experimental_TangoImageBuffer_I == null)
					cb_onFrameAvailable_Lcom_google_atap_tangoservice_experimental_TangoImageBuffer_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, int>) n_OnFrameAvailable_Lcom_google_atap_tangoservice_experimental_TangoImageBuffer_I);
				return cb_onFrameAvailable_Lcom_google_atap_tangoservice_experimental_TangoImageBuffer_I;
			}

			static void n_OnFrameAvailable_Lcom_google_atap_tangoservice_experimental_TangoImageBuffer_I (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1)
			{
				global::Com.Google.Atap.Tangoservice.Tango.IOnFrameAvailableListener __this = global::Java.Lang.Object.GetObject<global::Com.Google.Atap.Tangoservice.Tango.IOnFrameAvailableListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Com.Google.Atap.Tangoservice.Experimental.TangoImageBuffer p0 = global::Java.Lang.Object.GetObject<global::Com.Google.Atap.Tangoservice.Experimental.TangoImageBuffer> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.OnFrameAvailable (p0, p1);
			}
#pragma warning restore 0169

			IntPtr id_onFrameAvailable_Lcom_google_atap_tangoservice_experimental_TangoImageBuffer_I;
			public unsafe void OnFrameAvailable (global::Com.Google.Atap.Tangoservice.Experimental.TangoImageBuffer p0, int p1)
			{
				if (id_onFrameAvailable_Lcom_google_atap_tangoservice_experimental_TangoImageBuffer_I == IntPtr.Zero)
					id_onFrameAvailable_Lcom_google_atap_tangoservice_experimental_TangoImageBuffer_I = JNIEnv.GetMethodID (class_ref, "onFrameAvailable", "(Lcom/google/atap/tangoservice/experimental/TangoImageBuffer;I)V");
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onFrameAvailable_Lcom_google_atap_tangoservice_experimental_TangoImageBuffer_I, __args);
			}

		}

		public partial class FrameAvailableEventArgs : global::System.EventArgs {

			public FrameAvailableEventArgs (global::Com.Google.Atap.Tangoservice.Experimental.TangoImageBuffer p0, int p1)
			{
				this.p0 = p0;
				this.p1 = p1;
			}

			global::Com.Google.Atap.Tangoservice.Experimental.TangoImageBuffer p0;
			public global::Com.Google.Atap.Tangoservice.Experimental.TangoImageBuffer P0 {
				get { return p0; }
			}

			int p1;
			public int P1 {
				get { return p1; }
			}
		}

		[global::Android.Runtime.Register ("mono/com/google/atap/tangoservice/Tango_OnFrameAvailableListenerImplementor")]
		internal sealed partial class IOnFrameAvailableListenerImplementor : global::Java.Lang.Object, IOnFrameAvailableListener {

			object sender;

			public IOnFrameAvailableListenerImplementor (object sender)
				: base (
					global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/google/atap/tangoservice/Tango_OnFrameAvailableListenerImplementor", "()V"),
					JniHandleOwnership.TransferLocalRef)
			{
				global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
				this.sender = sender;
			}

#pragma warning disable 0649
			public EventHandler<FrameAvailableEventArgs> Handler;
#pragma warning restore 0649

			public void OnFrameAvailable (global::Com.Google.Atap.Tangoservice.Experimental.TangoImageBuffer p0, int p1)
			{
				var __h = Handler;
				if (__h != null)
					__h (sender, new FrameAvailableEventArgs (p0, p1));
			}

			internal static bool __IsEmpty (IOnFrameAvailableListenerImplementor value)
			{
				return value.Handler == null;
			}
		}


		// Metadata.xml XPath class reference: path="/api/package[@name='com.google.atap.tangoservice']/class[@name='Tango.OnTangoUpdateListener']"
		[global::Android.Runtime.Register ("com/google/atap/tangoservice/Tango$OnTangoUpdateListener", DoNotGenerateAcw=true)]
		public abstract partial class OnTangoUpdateListener : global::Com.Google.Atap.Tangoservice.Tango.TangoUpdateCallback {

			internal static new IntPtr java_class_handle;
			internal static new IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/google/atap/tangoservice/Tango$OnTangoUpdateListener", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (OnTangoUpdateListener); }
			}

			protected OnTangoUpdateListener (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.google.atap.tangoservice']/class[@name='Tango.OnTangoUpdateListener']/constructor[@name='Tango.OnTangoUpdateListener' and count(parameter)=0]"
			[Register (".ctor", "()V", "")]
			public unsafe OnTangoUpdateListener ()
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				try {
					if (GetType () != typeof (OnTangoUpdateListener)) {
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

		}

		[global::Android.Runtime.Register ("com/google/atap/tangoservice/Tango$OnTangoUpdateListener", DoNotGenerateAcw=true)]
		internal partial class OnTangoUpdateListenerInvoker : OnTangoUpdateListener {

			public OnTangoUpdateListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

			protected override global::System.Type ThresholdType {
				get { return typeof (OnTangoUpdateListenerInvoker); }
			}

		}


		// Metadata.xml XPath class reference: path="/api/package[@name='com.google.atap.tangoservice']/class[@name='Tango.TangoUpdateCallback']"
		[global::Android.Runtime.Register ("com/google/atap/tangoservice/Tango$TangoUpdateCallback", DoNotGenerateAcw=true)]
		public abstract partial class TangoUpdateCallback : global::Java.Lang.Object {

			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/google/atap/tangoservice/Tango$TangoUpdateCallback", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (TangoUpdateCallback); }
			}

			protected TangoUpdateCallback (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.google.atap.tangoservice']/class[@name='Tango.TangoUpdateCallback']/constructor[@name='Tango.TangoUpdateCallback' and count(parameter)=0]"
			[Register (".ctor", "()V", "")]
			public unsafe TangoUpdateCallback ()
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				try {
					if (GetType () != typeof (TangoUpdateCallback)) {
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

			static Delegate cb_onFrameAvailable_I;
#pragma warning disable 0169
			static Delegate GetOnFrameAvailable_IHandler ()
			{
				if (cb_onFrameAvailable_I == null)
					cb_onFrameAvailable_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_OnFrameAvailable_I);
				return cb_onFrameAvailable_I;
			}

			static void n_OnFrameAvailable_I (IntPtr jnienv, IntPtr native__this, int p0)
			{
				global::Com.Google.Atap.Tangoservice.Tango.TangoUpdateCallback __this = global::Java.Lang.Object.GetObject<global::Com.Google.Atap.Tangoservice.Tango.TangoUpdateCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.OnFrameAvailable (p0);
			}
#pragma warning restore 0169

			static IntPtr id_onFrameAvailable_I;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.atap.tangoservice']/class[@name='Tango.TangoUpdateCallback']/method[@name='onFrameAvailable' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("onFrameAvailable", "(I)V", "GetOnFrameAvailable_IHandler")]
			public virtual unsafe void OnFrameAvailable (int p0)
			{
				if (id_onFrameAvailable_I == IntPtr.Zero)
					id_onFrameAvailable_I = JNIEnv.GetMethodID (class_ref, "onFrameAvailable", "(I)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (p0);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onFrameAvailable_I, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onFrameAvailable", "(I)V"), __args);
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
				global::Com.Google.Atap.Tangoservice.Tango.TangoUpdateCallback __this = global::Java.Lang.Object.GetObject<global::Com.Google.Atap.Tangoservice.Tango.TangoUpdateCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Com.Google.Atap.Tangoservice.TangoPointCloudData p0 = global::Java.Lang.Object.GetObject<global::Com.Google.Atap.Tangoservice.TangoPointCloudData> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.OnPointCloudAvailable (p0);
			}
#pragma warning restore 0169

			static IntPtr id_onPointCloudAvailable_Lcom_google_atap_tangoservice_TangoPointCloudData_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.atap.tangoservice']/class[@name='Tango.TangoUpdateCallback']/method[@name='onPointCloudAvailable' and count(parameter)=1 and parameter[1][@type='com.google.atap.tangoservice.TangoPointCloudData']]"
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
				global::Com.Google.Atap.Tangoservice.Tango.TangoUpdateCallback __this = global::Java.Lang.Object.GetObject<global::Com.Google.Atap.Tangoservice.Tango.TangoUpdateCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Com.Google.Atap.Tangoservice.TangoPoseData p0 = global::Java.Lang.Object.GetObject<global::Com.Google.Atap.Tangoservice.TangoPoseData> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.OnPoseAvailable (p0);
			}
#pragma warning restore 0169

			static IntPtr id_onPoseAvailable_Lcom_google_atap_tangoservice_TangoPoseData_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.atap.tangoservice']/class[@name='Tango.TangoUpdateCallback']/method[@name='onPoseAvailable' and count(parameter)=1 and parameter[1][@type='com.google.atap.tangoservice.TangoPoseData']]"
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
				global::Com.Google.Atap.Tangoservice.Tango.TangoUpdateCallback __this = global::Java.Lang.Object.GetObject<global::Com.Google.Atap.Tangoservice.Tango.TangoUpdateCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Com.Google.Atap.Tangoservice.TangoEvent p0 = global::Java.Lang.Object.GetObject<global::Com.Google.Atap.Tangoservice.TangoEvent> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.OnTangoEvent (p0);
			}
#pragma warning restore 0169

			static IntPtr id_onTangoEvent_Lcom_google_atap_tangoservice_TangoEvent_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.atap.tangoservice']/class[@name='Tango.TangoUpdateCallback']/method[@name='onTangoEvent' and count(parameter)=1 and parameter[1][@type='com.google.atap.tangoservice.TangoEvent']]"
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

			static Delegate cb_onXyzIjAvailable_Lcom_google_atap_tangoservice_TangoXyzIjData_;
#pragma warning disable 0169
			static Delegate GetOnXyzIjAvailable_Lcom_google_atap_tangoservice_TangoXyzIjData_Handler ()
			{
				if (cb_onXyzIjAvailable_Lcom_google_atap_tangoservice_TangoXyzIjData_ == null)
					cb_onXyzIjAvailable_Lcom_google_atap_tangoservice_TangoXyzIjData_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnXyzIjAvailable_Lcom_google_atap_tangoservice_TangoXyzIjData_);
				return cb_onXyzIjAvailable_Lcom_google_atap_tangoservice_TangoXyzIjData_;
			}

			static void n_OnXyzIjAvailable_Lcom_google_atap_tangoservice_TangoXyzIjData_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Google.Atap.Tangoservice.Tango.TangoUpdateCallback __this = global::Java.Lang.Object.GetObject<global::Com.Google.Atap.Tangoservice.Tango.TangoUpdateCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Com.Google.Atap.Tangoservice.TangoXyzIjData p0 = global::Java.Lang.Object.GetObject<global::Com.Google.Atap.Tangoservice.TangoXyzIjData> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.OnXyzIjAvailable (p0);
			}
#pragma warning restore 0169

			static IntPtr id_onXyzIjAvailable_Lcom_google_atap_tangoservice_TangoXyzIjData_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.atap.tangoservice']/class[@name='Tango.TangoUpdateCallback']/method[@name='onXyzIjAvailable' and count(parameter)=1 and parameter[1][@type='com.google.atap.tangoservice.TangoXyzIjData']]"
			[Register ("onXyzIjAvailable", "(Lcom/google/atap/tangoservice/TangoXyzIjData;)V", "GetOnXyzIjAvailable_Lcom_google_atap_tangoservice_TangoXyzIjData_Handler")]
			public virtual unsafe void OnXyzIjAvailable (global::Com.Google.Atap.Tangoservice.TangoXyzIjData p0)
			{
				if (id_onXyzIjAvailable_Lcom_google_atap_tangoservice_TangoXyzIjData_ == IntPtr.Zero)
					id_onXyzIjAvailable_Lcom_google_atap_tangoservice_TangoXyzIjData_ = JNIEnv.GetMethodID (class_ref, "onXyzIjAvailable", "(Lcom/google/atap/tangoservice/TangoXyzIjData;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (p0);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onXyzIjAvailable_Lcom_google_atap_tangoservice_TangoXyzIjData_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onXyzIjAvailable", "(Lcom/google/atap/tangoservice/TangoXyzIjData;)V"), __args);
				} finally {
				}
			}

		}

		[global::Android.Runtime.Register ("com/google/atap/tangoservice/Tango$TangoUpdateCallback", DoNotGenerateAcw=true)]
		internal partial class TangoUpdateCallbackInvoker : TangoUpdateCallback {

			public TangoUpdateCallbackInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

			protected override global::System.Type ThresholdType {
				get { return typeof (TangoUpdateCallbackInvoker); }
			}

		}


		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/google/atap/tangoservice/Tango", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (Tango); }
		}

		protected Tango (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Landroid_content_Context_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.google.atap.tangoservice']/class[@name='Tango']/constructor[@name='Tango' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register (".ctor", "(Landroid/content/Context;)V", "")]
		public unsafe Tango (global::Android.Content.Context p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (GetType () != typeof (Tango)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Landroid/content/Context;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Landroid/content/Context;)V", __args);
					return;
				}

				if (id_ctor_Landroid_content_Context_ == IntPtr.Zero)
					id_ctor_Landroid_content_Context_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/content/Context;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_content_Context_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Landroid_content_Context_, __args);
			} finally {
			}
		}

		static IntPtr id_ctor_Landroid_content_Context_Ljava_lang_Runnable_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.google.atap.tangoservice']/class[@name='Tango']/constructor[@name='Tango' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.Runnable']]"
		[Register (".ctor", "(Landroid/content/Context;Ljava/lang/Runnable;)V", "")]
		public unsafe Tango (global::Android.Content.Context p0, global::Java.Lang.IRunnable p1)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				if (GetType () != typeof (Tango)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Landroid/content/Context;Ljava/lang/Runnable;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Landroid/content/Context;Ljava/lang/Runnable;)V", __args);
					return;
				}

				if (id_ctor_Landroid_content_Context_Ljava_lang_Runnable_ == IntPtr.Zero)
					id_ctor_Landroid_content_Context_Ljava_lang_Runnable_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/content/Context;Ljava/lang/Runnable;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_content_Context_Ljava_lang_Runnable_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Landroid_content_Context_Ljava_lang_Runnable_, __args);
			} finally {
			}
		}

		static Delegate cb_connect_Lcom_google_atap_tangoservice_TangoConfig_;
#pragma warning disable 0169
		static Delegate GetConnect_Lcom_google_atap_tangoservice_TangoConfig_Handler ()
		{
			if (cb_connect_Lcom_google_atap_tangoservice_TangoConfig_ == null)
				cb_connect_Lcom_google_atap_tangoservice_TangoConfig_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Connect_Lcom_google_atap_tangoservice_TangoConfig_);
			return cb_connect_Lcom_google_atap_tangoservice_TangoConfig_;
		}

		static void n_Connect_Lcom_google_atap_tangoservice_TangoConfig_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Google.Atap.Tangoservice.Tango __this = global::Java.Lang.Object.GetObject<global::Com.Google.Atap.Tangoservice.Tango> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Google.Atap.Tangoservice.TangoConfig p0 = global::Java.Lang.Object.GetObject<global::Com.Google.Atap.Tangoservice.TangoConfig> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Connect (p0);
		}
#pragma warning restore 0169

		static IntPtr id_connect_Lcom_google_atap_tangoservice_TangoConfig_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.atap.tangoservice']/class[@name='Tango']/method[@name='connect' and count(parameter)=1 and parameter[1][@type='com.google.atap.tangoservice.TangoConfig']]"
		[Register ("connect", "(Lcom/google/atap/tangoservice/TangoConfig;)V", "GetConnect_Lcom_google_atap_tangoservice_TangoConfig_Handler")]
		public virtual unsafe void Connect (global::Com.Google.Atap.Tangoservice.TangoConfig p0)
		{
			if (id_connect_Lcom_google_atap_tangoservice_TangoConfig_ == IntPtr.Zero)
				id_connect_Lcom_google_atap_tangoservice_TangoConfig_ = JNIEnv.GetMethodID (class_ref, "connect", "(Lcom/google/atap/tangoservice/TangoConfig;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_connect_Lcom_google_atap_tangoservice_TangoConfig_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "connect", "(Lcom/google/atap/tangoservice/TangoConfig;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_connectListener_Ljava_util_List_Lcom_google_atap_tangoservice_Tango_TangoUpdateCallback_;
#pragma warning disable 0169
		static Delegate GetConnectListener_Ljava_util_List_Lcom_google_atap_tangoservice_Tango_TangoUpdateCallback_Handler ()
		{
			if (cb_connectListener_Ljava_util_List_Lcom_google_atap_tangoservice_Tango_TangoUpdateCallback_ == null)
				cb_connectListener_Ljava_util_List_Lcom_google_atap_tangoservice_Tango_TangoUpdateCallback_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_ConnectListener_Ljava_util_List_Lcom_google_atap_tangoservice_Tango_TangoUpdateCallback_);
			return cb_connectListener_Ljava_util_List_Lcom_google_atap_tangoservice_Tango_TangoUpdateCallback_;
		}

		static void n_ConnectListener_Ljava_util_List_Lcom_google_atap_tangoservice_Tango_TangoUpdateCallback_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Google.Atap.Tangoservice.Tango __this = global::Java.Lang.Object.GetObject<global::Com.Google.Atap.Tangoservice.Tango> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Android.Runtime.JavaList<global::Com.Google.Atap.Tangoservice.TangoCoordinateFramePair>.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Google.Atap.Tangoservice.Tango.TangoUpdateCallback p1 = global::Java.Lang.Object.GetObject<global::Com.Google.Atap.Tangoservice.Tango.TangoUpdateCallback> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.ConnectListener (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_connectListener_Ljava_util_List_Lcom_google_atap_tangoservice_Tango_TangoUpdateCallback_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.atap.tangoservice']/class[@name='Tango']/method[@name='connectListener' and count(parameter)=2 and parameter[1][@type='java.util.List&lt;com.google.atap.tangoservice.TangoCoordinateFramePair&gt;'] and parameter[2][@type='com.google.atap.tangoservice.Tango.TangoUpdateCallback']]"
		[Register ("connectListener", "(Ljava/util/List;Lcom/google/atap/tangoservice/Tango$TangoUpdateCallback;)V", "GetConnectListener_Ljava_util_List_Lcom_google_atap_tangoservice_Tango_TangoUpdateCallback_Handler")]
		public virtual unsafe void ConnectListener (global::System.Collections.Generic.IList<global::Com.Google.Atap.Tangoservice.TangoCoordinateFramePair> p0, global::Com.Google.Atap.Tangoservice.Tango.TangoUpdateCallback p1)
		{
			if (id_connectListener_Ljava_util_List_Lcom_google_atap_tangoservice_Tango_TangoUpdateCallback_ == IntPtr.Zero)
				id_connectListener_Ljava_util_List_Lcom_google_atap_tangoservice_Tango_TangoUpdateCallback_ = JNIEnv.GetMethodID (class_ref, "connectListener", "(Ljava/util/List;Lcom/google/atap/tangoservice/Tango$TangoUpdateCallback;)V");
			IntPtr native_p0 = global::Android.Runtime.JavaList<global::Com.Google.Atap.Tangoservice.TangoCoordinateFramePair>.ToLocalJniHandle (p0);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_connectListener_Ljava_util_List_Lcom_google_atap_tangoservice_Tango_TangoUpdateCallback_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "connectListener", "(Ljava/util/List;Lcom/google/atap/tangoservice/Tango$TangoUpdateCallback;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_connectOnTextureAvailable_I;
#pragma warning disable 0169
		static Delegate GetConnectOnTextureAvailable_IHandler ()
		{
			if (cb_connectOnTextureAvailable_I == null)
				cb_connectOnTextureAvailable_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_ConnectOnTextureAvailable_I);
			return cb_connectOnTextureAvailable_I;
		}

		static void n_ConnectOnTextureAvailable_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Google.Atap.Tangoservice.Tango __this = global::Java.Lang.Object.GetObject<global::Com.Google.Atap.Tangoservice.Tango> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ConnectOnTextureAvailable (p0);
		}
#pragma warning restore 0169

		static IntPtr id_connectOnTextureAvailable_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.atap.tangoservice']/class[@name='Tango']/method[@name='connectOnTextureAvailable' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("connectOnTextureAvailable", "(I)V", "GetConnectOnTextureAvailable_IHandler")]
		public virtual unsafe void ConnectOnTextureAvailable (int p0)
		{
			if (id_connectOnTextureAvailable_I == IntPtr.Zero)
				id_connectOnTextureAvailable_I = JNIEnv.GetMethodID (class_ref, "connectOnTextureAvailable", "(I)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_connectOnTextureAvailable_I, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "connectOnTextureAvailable", "(I)V"), __args);
			} finally {
			}
		}

		static Delegate cb_connectTextureId_II;
#pragma warning disable 0169
		static Delegate GetConnectTextureId_IIHandler ()
		{
			if (cb_connectTextureId_II == null)
				cb_connectTextureId_II = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, int>) n_ConnectTextureId_II);
			return cb_connectTextureId_II;
		}

		static void n_ConnectTextureId_II (IntPtr jnienv, IntPtr native__this, int p0, int p1)
		{
			global::Com.Google.Atap.Tangoservice.Tango __this = global::Java.Lang.Object.GetObject<global::Com.Google.Atap.Tangoservice.Tango> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ConnectTextureId (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_connectTextureId_II;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.atap.tangoservice']/class[@name='Tango']/method[@name='connectTextureId' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
		[Register ("connectTextureId", "(II)V", "GetConnectTextureId_IIHandler")]
		public virtual unsafe void ConnectTextureId (int p0, int p1)
		{
			if (id_connectTextureId_II == IntPtr.Zero)
				id_connectTextureId_II = JNIEnv.GetMethodID (class_ref, "connectTextureId", "(II)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_connectTextureId_II, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "connectTextureId", "(II)V"), __args);
			} finally {
			}
		}

		static Delegate cb_createFrameOfInterest_DLjava_lang_String_Lcom_google_atap_tangoservice_experimental_TangoTransformation_Lcom_google_atap_tangoservice_Tango_FoiListener_;
#pragma warning disable 0169
		static Delegate GetCreateFrameOfInterest_DLjava_lang_String_Lcom_google_atap_tangoservice_experimental_TangoTransformation_Lcom_google_atap_tangoservice_Tango_FoiListener_Handler ()
		{
			if (cb_createFrameOfInterest_DLjava_lang_String_Lcom_google_atap_tangoservice_experimental_TangoTransformation_Lcom_google_atap_tangoservice_Tango_FoiListener_ == null)
				cb_createFrameOfInterest_DLjava_lang_String_Lcom_google_atap_tangoservice_experimental_TangoTransformation_Lcom_google_atap_tangoservice_Tango_FoiListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, double, IntPtr, IntPtr, IntPtr>) n_CreateFrameOfInterest_DLjava_lang_String_Lcom_google_atap_tangoservice_experimental_TangoTransformation_Lcom_google_atap_tangoservice_Tango_FoiListener_);
			return cb_createFrameOfInterest_DLjava_lang_String_Lcom_google_atap_tangoservice_experimental_TangoTransformation_Lcom_google_atap_tangoservice_Tango_FoiListener_;
		}

		static void n_CreateFrameOfInterest_DLjava_lang_String_Lcom_google_atap_tangoservice_experimental_TangoTransformation_Lcom_google_atap_tangoservice_Tango_FoiListener_ (IntPtr jnienv, IntPtr native__this, double p0, IntPtr native_p1, IntPtr native_p2, IntPtr native_p3)
		{
			global::Com.Google.Atap.Tangoservice.Tango __this = global::Java.Lang.Object.GetObject<global::Com.Google.Atap.Tangoservice.Tango> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			global::Com.Google.Atap.Tangoservice.Experimental.TangoTransformation p2 = global::Java.Lang.Object.GetObject<global::Com.Google.Atap.Tangoservice.Experimental.TangoTransformation> (native_p2, JniHandleOwnership.DoNotTransfer);
			global::Com.Google.Atap.Tangoservice.Tango.IFoiListener p3 = (global::Com.Google.Atap.Tangoservice.Tango.IFoiListener)global::Java.Lang.Object.GetObject<global::Com.Google.Atap.Tangoservice.Tango.IFoiListener> (native_p3, JniHandleOwnership.DoNotTransfer);
			__this.CreateFrameOfInterest (p0, p1, p2, p3);
		}
#pragma warning restore 0169

		static IntPtr id_createFrameOfInterest_DLjava_lang_String_Lcom_google_atap_tangoservice_experimental_TangoTransformation_Lcom_google_atap_tangoservice_Tango_FoiListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.atap.tangoservice']/class[@name='Tango']/method[@name='createFrameOfInterest' and count(parameter)=4 and parameter[1][@type='double'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='com.google.atap.tangoservice.experimental.TangoTransformation'] and parameter[4][@type='com.google.atap.tangoservice.Tango.FoiListener']]"
		[Register ("createFrameOfInterest", "(DLjava/lang/String;Lcom/google/atap/tangoservice/experimental/TangoTransformation;Lcom/google/atap/tangoservice/Tango$FoiListener;)V", "GetCreateFrameOfInterest_DLjava_lang_String_Lcom_google_atap_tangoservice_experimental_TangoTransformation_Lcom_google_atap_tangoservice_Tango_FoiListener_Handler")]
		public virtual unsafe void CreateFrameOfInterest (double p0, string p1, global::Com.Google.Atap.Tangoservice.Experimental.TangoTransformation p2, global::Com.Google.Atap.Tangoservice.Tango.IFoiListener p3)
		{
			if (id_createFrameOfInterest_DLjava_lang_String_Lcom_google_atap_tangoservice_experimental_TangoTransformation_Lcom_google_atap_tangoservice_Tango_FoiListener_ == IntPtr.Zero)
				id_createFrameOfInterest_DLjava_lang_String_Lcom_google_atap_tangoservice_experimental_TangoTransformation_Lcom_google_atap_tangoservice_Tango_FoiListener_ = JNIEnv.GetMethodID (class_ref, "createFrameOfInterest", "(DLjava/lang/String;Lcom/google/atap/tangoservice/experimental/TangoTransformation;Lcom/google/atap/tangoservice/Tango$FoiListener;)V");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_createFrameOfInterest_DLjava_lang_String_Lcom_google_atap_tangoservice_experimental_TangoTransformation_Lcom_google_atap_tangoservice_Tango_FoiListener_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "createFrameOfInterest", "(DLjava/lang/String;Lcom/google/atap/tangoservice/experimental/TangoTransformation;Lcom/google/atap/tangoservice/Tango$FoiListener;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static Delegate cb_deleteAreaDescription_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetDeleteAreaDescription_Ljava_lang_String_Handler ()
		{
			if (cb_deleteAreaDescription_Ljava_lang_String_ == null)
				cb_deleteAreaDescription_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_DeleteAreaDescription_Ljava_lang_String_);
			return cb_deleteAreaDescription_Ljava_lang_String_;
		}

		static void n_DeleteAreaDescription_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Google.Atap.Tangoservice.Tango __this = global::Java.Lang.Object.GetObject<global::Com.Google.Atap.Tangoservice.Tango> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.DeleteAreaDescription (p0);
		}
#pragma warning restore 0169

		static IntPtr id_deleteAreaDescription_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.atap.tangoservice']/class[@name='Tango']/method[@name='deleteAreaDescription' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("deleteAreaDescription", "(Ljava/lang/String;)V", "GetDeleteAreaDescription_Ljava_lang_String_Handler")]
		public virtual unsafe void DeleteAreaDescription (string p0)
		{
			if (id_deleteAreaDescription_Ljava_lang_String_ == IntPtr.Zero)
				id_deleteAreaDescription_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "deleteAreaDescription", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_deleteAreaDescription_Ljava_lang_String_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "deleteAreaDescription", "(Ljava/lang/String;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_deleteFramesOfInterest_arrayLjava_lang_String_Lcom_google_atap_tangoservice_Tango_FoiListener_;
#pragma warning disable 0169
		static Delegate GetDeleteFramesOfInterest_arrayLjava_lang_String_Lcom_google_atap_tangoservice_Tango_FoiListener_Handler ()
		{
			if (cb_deleteFramesOfInterest_arrayLjava_lang_String_Lcom_google_atap_tangoservice_Tango_FoiListener_ == null)
				cb_deleteFramesOfInterest_arrayLjava_lang_String_Lcom_google_atap_tangoservice_Tango_FoiListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_DeleteFramesOfInterest_arrayLjava_lang_String_Lcom_google_atap_tangoservice_Tango_FoiListener_);
			return cb_deleteFramesOfInterest_arrayLjava_lang_String_Lcom_google_atap_tangoservice_Tango_FoiListener_;
		}

		static void n_DeleteFramesOfInterest_arrayLjava_lang_String_Lcom_google_atap_tangoservice_Tango_FoiListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Google.Atap.Tangoservice.Tango __this = global::Java.Lang.Object.GetObject<global::Com.Google.Atap.Tangoservice.Tango> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string[] p0 = (string[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (string));
			global::Com.Google.Atap.Tangoservice.Tango.IFoiListener p1 = (global::Com.Google.Atap.Tangoservice.Tango.IFoiListener)global::Java.Lang.Object.GetObject<global::Com.Google.Atap.Tangoservice.Tango.IFoiListener> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.DeleteFramesOfInterest (p0, p1);
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
		}
#pragma warning restore 0169

		static IntPtr id_deleteFramesOfInterest_arrayLjava_lang_String_Lcom_google_atap_tangoservice_Tango_FoiListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.atap.tangoservice']/class[@name='Tango']/method[@name='deleteFramesOfInterest' and count(parameter)=2 and parameter[1][@type='java.lang.String[]'] and parameter[2][@type='com.google.atap.tangoservice.Tango.FoiListener']]"
		[Register ("deleteFramesOfInterest", "([Ljava/lang/String;Lcom/google/atap/tangoservice/Tango$FoiListener;)V", "GetDeleteFramesOfInterest_arrayLjava_lang_String_Lcom_google_atap_tangoservice_Tango_FoiListener_Handler")]
		public virtual unsafe void DeleteFramesOfInterest (string[] p0, global::Com.Google.Atap.Tangoservice.Tango.IFoiListener p1)
		{
			if (id_deleteFramesOfInterest_arrayLjava_lang_String_Lcom_google_atap_tangoservice_Tango_FoiListener_ == IntPtr.Zero)
				id_deleteFramesOfInterest_arrayLjava_lang_String_Lcom_google_atap_tangoservice_Tango_FoiListener_ = JNIEnv.GetMethodID (class_ref, "deleteFramesOfInterest", "([Ljava/lang/String;Lcom/google/atap/tangoservice/Tango$FoiListener;)V");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_deleteFramesOfInterest_arrayLjava_lang_String_Lcom_google_atap_tangoservice_Tango_FoiListener_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "deleteFramesOfInterest", "([Ljava/lang/String;Lcom/google/atap/tangoservice/Tango$FoiListener;)V"), __args);
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}
		}

		static Delegate cb_disconnect;
#pragma warning disable 0169
		static Delegate GetDisconnectHandler ()
		{
			if (cb_disconnect == null)
				cb_disconnect = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Disconnect);
			return cb_disconnect;
		}

		static void n_Disconnect (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Google.Atap.Tangoservice.Tango __this = global::Java.Lang.Object.GetObject<global::Com.Google.Atap.Tangoservice.Tango> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Disconnect ();
		}
#pragma warning restore 0169

		static IntPtr id_disconnect;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.atap.tangoservice']/class[@name='Tango']/method[@name='disconnect' and count(parameter)=0]"
		[Register ("disconnect", "()V", "GetDisconnectHandler")]
		public virtual unsafe void Disconnect ()
		{
			if (id_disconnect == IntPtr.Zero)
				id_disconnect = JNIEnv.GetMethodID (class_ref, "disconnect", "()V");
			try {

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_disconnect);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "disconnect", "()V"));
			} finally {
			}
		}

		static Delegate cb_disconnectCamera_I;
#pragma warning disable 0169
		static Delegate GetDisconnectCamera_IHandler ()
		{
			if (cb_disconnectCamera_I == null)
				cb_disconnectCamera_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_DisconnectCamera_I);
			return cb_disconnectCamera_I;
		}

		static void n_DisconnectCamera_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Google.Atap.Tangoservice.Tango __this = global::Java.Lang.Object.GetObject<global::Com.Google.Atap.Tangoservice.Tango> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.DisconnectCamera (p0);
		}
#pragma warning restore 0169

		static IntPtr id_disconnectCamera_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.atap.tangoservice']/class[@name='Tango']/method[@name='disconnectCamera' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("disconnectCamera", "(I)V", "GetDisconnectCamera_IHandler")]
		public virtual unsafe void DisconnectCamera (int p0)
		{
			if (id_disconnectCamera_I == IntPtr.Zero)
				id_disconnectCamera_I = JNIEnv.GetMethodID (class_ref, "disconnectCamera", "(I)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_disconnectCamera_I, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "disconnectCamera", "(I)V"), __args);
			} finally {
			}
		}

		static Delegate cb_experimentalConnectOnFrameListener_ILcom_google_atap_tangoservice_Tango_OnFrameAvailableListener_;
#pragma warning disable 0169
		static Delegate GetExperimentalConnectOnFrameListener_ILcom_google_atap_tangoservice_Tango_OnFrameAvailableListener_Handler ()
		{
			if (cb_experimentalConnectOnFrameListener_ILcom_google_atap_tangoservice_Tango_OnFrameAvailableListener_ == null)
				cb_experimentalConnectOnFrameListener_ILcom_google_atap_tangoservice_Tango_OnFrameAvailableListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, IntPtr>) n_ExperimentalConnectOnFrameListener_ILcom_google_atap_tangoservice_Tango_OnFrameAvailableListener_);
			return cb_experimentalConnectOnFrameListener_ILcom_google_atap_tangoservice_Tango_OnFrameAvailableListener_;
		}

		static void n_ExperimentalConnectOnFrameListener_ILcom_google_atap_tangoservice_Tango_OnFrameAvailableListener_ (IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1)
		{
			global::Com.Google.Atap.Tangoservice.Tango __this = global::Java.Lang.Object.GetObject<global::Com.Google.Atap.Tangoservice.Tango> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Google.Atap.Tangoservice.Tango.IOnFrameAvailableListener p1 = (global::Com.Google.Atap.Tangoservice.Tango.IOnFrameAvailableListener)global::Java.Lang.Object.GetObject<global::Com.Google.Atap.Tangoservice.Tango.IOnFrameAvailableListener> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.ExperimentalConnectOnFrameListener (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_experimentalConnectOnFrameListener_ILcom_google_atap_tangoservice_Tango_OnFrameAvailableListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.atap.tangoservice']/class[@name='Tango']/method[@name='experimentalConnectOnFrameListener' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='com.google.atap.tangoservice.Tango.OnFrameAvailableListener']]"
		[Register ("experimentalConnectOnFrameListener", "(ILcom/google/atap/tangoservice/Tango$OnFrameAvailableListener;)V", "GetExperimentalConnectOnFrameListener_ILcom_google_atap_tangoservice_Tango_OnFrameAvailableListener_Handler")]
		public virtual unsafe void ExperimentalConnectOnFrameListener (int p0, global::Com.Google.Atap.Tangoservice.Tango.IOnFrameAvailableListener p1)
		{
			if (id_experimentalConnectOnFrameListener_ILcom_google_atap_tangoservice_Tango_OnFrameAvailableListener_ == IntPtr.Zero)
				id_experimentalConnectOnFrameListener_ILcom_google_atap_tangoservice_Tango_OnFrameAvailableListener_ = JNIEnv.GetMethodID (class_ref, "experimentalConnectOnFrameListener", "(ILcom/google/atap/tangoservice/Tango$OnFrameAvailableListener;)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_experimentalConnectOnFrameListener_ILcom_google_atap_tangoservice_Tango_OnFrameAvailableListener_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "experimentalConnectOnFrameListener", "(ILcom/google/atap/tangoservice/Tango$OnFrameAvailableListener;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_experimentalDeleteDataset_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetExperimentalDeleteDataset_Ljava_lang_String_Handler ()
		{
			if (cb_experimentalDeleteDataset_Ljava_lang_String_ == null)
				cb_experimentalDeleteDataset_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_ExperimentalDeleteDataset_Ljava_lang_String_);
			return cb_experimentalDeleteDataset_Ljava_lang_String_;
		}

		static void n_ExperimentalDeleteDataset_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Google.Atap.Tangoservice.Tango __this = global::Java.Lang.Object.GetObject<global::Com.Google.Atap.Tangoservice.Tango> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.ExperimentalDeleteDataset (p0);
		}
#pragma warning restore 0169

		static IntPtr id_experimentalDeleteDataset_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.atap.tangoservice']/class[@name='Tango']/method[@name='experimentalDeleteDataset' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("experimentalDeleteDataset", "(Ljava/lang/String;)V", "GetExperimentalDeleteDataset_Ljava_lang_String_Handler")]
		public virtual unsafe void ExperimentalDeleteDataset (string p0)
		{
			if (id_experimentalDeleteDataset_Ljava_lang_String_ == IntPtr.Zero)
				id_experimentalDeleteDataset_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "experimentalDeleteDataset", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_experimentalDeleteDataset_Ljava_lang_String_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "experimentalDeleteDataset", "(Ljava/lang/String;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_experimentalGetCurrentDatasetUuid;
#pragma warning disable 0169
		static Delegate GetExperimentalGetCurrentDatasetUuidHandler ()
		{
			if (cb_experimentalGetCurrentDatasetUuid == null)
				cb_experimentalGetCurrentDatasetUuid = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_ExperimentalGetCurrentDatasetUuid);
			return cb_experimentalGetCurrentDatasetUuid;
		}

		static IntPtr n_ExperimentalGetCurrentDatasetUuid (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Google.Atap.Tangoservice.Tango __this = global::Java.Lang.Object.GetObject<global::Com.Google.Atap.Tangoservice.Tango> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.ExperimentalGetCurrentDatasetUuid ());
		}
#pragma warning restore 0169

		static IntPtr id_experimentalGetCurrentDatasetUuid;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.atap.tangoservice']/class[@name='Tango']/method[@name='experimentalGetCurrentDatasetUuid' and count(parameter)=0]"
		[Register ("experimentalGetCurrentDatasetUuid", "()Ljava/lang/String;", "GetExperimentalGetCurrentDatasetUuidHandler")]
		public virtual unsafe string ExperimentalGetCurrentDatasetUuid ()
		{
			if (id_experimentalGetCurrentDatasetUuid == IntPtr.Zero)
				id_experimentalGetCurrentDatasetUuid = JNIEnv.GetMethodID (class_ref, "experimentalGetCurrentDatasetUuid", "()Ljava/lang/String;");
			try {

				if (GetType () == ThresholdType)
					return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_experimentalGetCurrentDatasetUuid), JniHandleOwnership.TransferLocalRef);
				else
					return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "experimentalGetCurrentDatasetUuid", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_experimentalListDatasets;
#pragma warning disable 0169
		static Delegate GetExperimentalListDatasetsHandler ()
		{
			if (cb_experimentalListDatasets == null)
				cb_experimentalListDatasets = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_ExperimentalListDatasets);
			return cb_experimentalListDatasets;
		}

		static IntPtr n_ExperimentalListDatasets (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Google.Atap.Tangoservice.Tango __this = global::Java.Lang.Object.GetObject<global::Com.Google.Atap.Tangoservice.Tango> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList<string>.ToLocalJniHandle (__this.ExperimentalListDatasets ());
		}
#pragma warning restore 0169

		static IntPtr id_experimentalListDatasets;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.atap.tangoservice']/class[@name='Tango']/method[@name='experimentalListDatasets' and count(parameter)=0]"
		[Register ("experimentalListDatasets", "()Ljava/util/List;", "GetExperimentalListDatasetsHandler")]
		public virtual unsafe global::System.Collections.Generic.IList<string> ExperimentalListDatasets ()
		{
			if (id_experimentalListDatasets == IntPtr.Zero)
				id_experimentalListDatasets = JNIEnv.GetMethodID (class_ref, "experimentalListDatasets", "()Ljava/util/List;");
			try {

				if (GetType () == ThresholdType)
					return global::Android.Runtime.JavaList<string>.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_experimentalListDatasets), JniHandleOwnership.TransferLocalRef);
				else
					return global::Android.Runtime.JavaList<string>.FromJniHandle (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "experimentalListDatasets", "()Ljava/util/List;")), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_exportAreaDescriptionFile_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetExportAreaDescriptionFile_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_exportAreaDescriptionFile_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_exportAreaDescriptionFile_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_ExportAreaDescriptionFile_Ljava_lang_String_Ljava_lang_String_);
			return cb_exportAreaDescriptionFile_Ljava_lang_String_Ljava_lang_String_;
		}

		static void n_ExportAreaDescriptionFile_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Google.Atap.Tangoservice.Tango __this = global::Java.Lang.Object.GetObject<global::Com.Google.Atap.Tangoservice.Tango> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.ExportAreaDescriptionFile (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_exportAreaDescriptionFile_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.atap.tangoservice']/class[@name='Tango']/method[@name='exportAreaDescriptionFile' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("exportAreaDescriptionFile", "(Ljava/lang/String;Ljava/lang/String;)V", "GetExportAreaDescriptionFile_Ljava_lang_String_Ljava_lang_String_Handler")]
		public virtual unsafe void ExportAreaDescriptionFile (string p0, string p1)
		{
			if (id_exportAreaDescriptionFile_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_exportAreaDescriptionFile_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "exportAreaDescriptionFile", "(Ljava/lang/String;Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_exportAreaDescriptionFile_Ljava_lang_String_Ljava_lang_String_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "exportAreaDescriptionFile", "(Ljava/lang/String;Ljava/lang/String;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static Delegate cb_getCameraIntrinsics_I;
#pragma warning disable 0169
		static Delegate GetGetCameraIntrinsics_IHandler ()
		{
			if (cb_getCameraIntrinsics_I == null)
				cb_getCameraIntrinsics_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_GetCameraIntrinsics_I);
			return cb_getCameraIntrinsics_I;
		}

		static IntPtr n_GetCameraIntrinsics_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Google.Atap.Tangoservice.Tango __this = global::Java.Lang.Object.GetObject<global::Com.Google.Atap.Tangoservice.Tango> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.GetCameraIntrinsics (p0));
		}
#pragma warning restore 0169

		static IntPtr id_getCameraIntrinsics_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.atap.tangoservice']/class[@name='Tango']/method[@name='getCameraIntrinsics' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("getCameraIntrinsics", "(I)Lcom/google/atap/tangoservice/TangoCameraIntrinsics;", "GetGetCameraIntrinsics_IHandler")]
		public virtual unsafe global::Com.Google.Atap.Tangoservice.TangoCameraIntrinsics GetCameraIntrinsics (int p0)
		{
			if (id_getCameraIntrinsics_I == IntPtr.Zero)
				id_getCameraIntrinsics_I = JNIEnv.GetMethodID (class_ref, "getCameraIntrinsics", "(I)Lcom/google/atap/tangoservice/TangoCameraIntrinsics;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Com.Google.Atap.Tangoservice.TangoCameraIntrinsics> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getCameraIntrinsics_I, __args), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Com.Google.Atap.Tangoservice.TangoCameraIntrinsics> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getCameraIntrinsics", "(I)Lcom/google/atap/tangoservice/TangoCameraIntrinsics;"), __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_getConfig_I;
#pragma warning disable 0169
		static Delegate GetGetConfig_IHandler ()
		{
			if (cb_getConfig_I == null)
				cb_getConfig_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_GetConfig_I);
			return cb_getConfig_I;
		}

		static IntPtr n_GetConfig_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Google.Atap.Tangoservice.Tango __this = global::Java.Lang.Object.GetObject<global::Com.Google.Atap.Tangoservice.Tango> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.GetConfig (p0));
		}
#pragma warning restore 0169

		static IntPtr id_getConfig_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.atap.tangoservice']/class[@name='Tango']/method[@name='getConfig' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("getConfig", "(I)Lcom/google/atap/tangoservice/TangoConfig;", "GetGetConfig_IHandler")]
		public virtual unsafe global::Com.Google.Atap.Tangoservice.TangoConfig GetConfig (int p0)
		{
			if (id_getConfig_I == IntPtr.Zero)
				id_getConfig_I = JNIEnv.GetMethodID (class_ref, "getConfig", "(I)Lcom/google/atap/tangoservice/TangoConfig;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Com.Google.Atap.Tangoservice.TangoConfig> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getConfig_I, __args), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Com.Google.Atap.Tangoservice.TangoConfig> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getConfig", "(I)Lcom/google/atap/tangoservice/TangoConfig;"), __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_getPoseAtTime_DLcom_google_atap_tangoservice_TangoCoordinateFramePair_;
#pragma warning disable 0169
		static Delegate GetGetPoseAtTime_DLcom_google_atap_tangoservice_TangoCoordinateFramePair_Handler ()
		{
			if (cb_getPoseAtTime_DLcom_google_atap_tangoservice_TangoCoordinateFramePair_ == null)
				cb_getPoseAtTime_DLcom_google_atap_tangoservice_TangoCoordinateFramePair_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, double, IntPtr, IntPtr>) n_GetPoseAtTime_DLcom_google_atap_tangoservice_TangoCoordinateFramePair_);
			return cb_getPoseAtTime_DLcom_google_atap_tangoservice_TangoCoordinateFramePair_;
		}

		static IntPtr n_GetPoseAtTime_DLcom_google_atap_tangoservice_TangoCoordinateFramePair_ (IntPtr jnienv, IntPtr native__this, double p0, IntPtr native_p1)
		{
			global::Com.Google.Atap.Tangoservice.Tango __this = global::Java.Lang.Object.GetObject<global::Com.Google.Atap.Tangoservice.Tango> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Google.Atap.Tangoservice.TangoCoordinateFramePair p1 = global::Java.Lang.Object.GetObject<global::Com.Google.Atap.Tangoservice.TangoCoordinateFramePair> (native_p1, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetPoseAtTime (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getPoseAtTime_DLcom_google_atap_tangoservice_TangoCoordinateFramePair_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.atap.tangoservice']/class[@name='Tango']/method[@name='getPoseAtTime' and count(parameter)=2 and parameter[1][@type='double'] and parameter[2][@type='com.google.atap.tangoservice.TangoCoordinateFramePair']]"
		[Register ("getPoseAtTime", "(DLcom/google/atap/tangoservice/TangoCoordinateFramePair;)Lcom/google/atap/tangoservice/TangoPoseData;", "GetGetPoseAtTime_DLcom_google_atap_tangoservice_TangoCoordinateFramePair_Handler")]
		public virtual unsafe global::Com.Google.Atap.Tangoservice.TangoPoseData GetPoseAtTime (double p0, global::Com.Google.Atap.Tangoservice.TangoCoordinateFramePair p1)
		{
			if (id_getPoseAtTime_DLcom_google_atap_tangoservice_TangoCoordinateFramePair_ == IntPtr.Zero)
				id_getPoseAtTime_DLcom_google_atap_tangoservice_TangoCoordinateFramePair_ = JNIEnv.GetMethodID (class_ref, "getPoseAtTime", "(DLcom/google/atap/tangoservice/TangoCoordinateFramePair;)Lcom/google/atap/tangoservice/TangoPoseData;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				global::Com.Google.Atap.Tangoservice.TangoPoseData __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Google.Atap.Tangoservice.TangoPoseData> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getPoseAtTime_DLcom_google_atap_tangoservice_TangoCoordinateFramePair_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Google.Atap.Tangoservice.TangoPoseData> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getPoseAtTime", "(DLcom/google/atap/tangoservice/TangoCoordinateFramePair;)Lcom/google/atap/tangoservice/TangoPoseData;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_getPoseAtTime_DLjava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGetPoseAtTime_DLjava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_getPoseAtTime_DLjava_lang_String_Ljava_lang_String_ == null)
				cb_getPoseAtTime_DLjava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, double, IntPtr, IntPtr, IntPtr>) n_GetPoseAtTime_DLjava_lang_String_Ljava_lang_String_);
			return cb_getPoseAtTime_DLjava_lang_String_Ljava_lang_String_;
		}

		static IntPtr n_GetPoseAtTime_DLjava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, double p0, IntPtr native_p1, IntPtr native_p2)
		{
			global::Com.Google.Atap.Tangoservice.Tango __this = global::Java.Lang.Object.GetObject<global::Com.Google.Atap.Tangoservice.Tango> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			string p2 = JNIEnv.GetString (native_p2, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetPoseAtTime (p0, p1, p2));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getPoseAtTime_DLjava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.atap.tangoservice']/class[@name='Tango']/method[@name='getPoseAtTime' and count(parameter)=3 and parameter[1][@type='double'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String']]"
		[Register ("getPoseAtTime", "(DLjava/lang/String;Ljava/lang/String;)Lcom/google/atap/tangoservice/TangoPoseData;", "GetGetPoseAtTime_DLjava_lang_String_Ljava_lang_String_Handler")]
		public virtual unsafe global::Com.Google.Atap.Tangoservice.TangoPoseData GetPoseAtTime (double p0, string p1, string p2)
		{
			if (id_getPoseAtTime_DLjava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_getPoseAtTime_DLjava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "getPoseAtTime", "(DLjava/lang/String;Ljava/lang/String;)Lcom/google/atap/tangoservice/TangoPoseData;");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (native_p2);

				global::Com.Google.Atap.Tangoservice.TangoPoseData __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Google.Atap.Tangoservice.TangoPoseData> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getPoseAtTime_DLjava_lang_String_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Google.Atap.Tangoservice.TangoPoseData> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getPoseAtTime", "(DLjava/lang/String;Ljava/lang/String;)Lcom/google/atap/tangoservice/TangoPoseData;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
				JNIEnv.DeleteLocalRef (native_p2);
			}
		}

		static IntPtr id_getRequestPermissionIntent_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.atap.tangoservice']/class[@name='Tango']/method[@name='getRequestPermissionIntent' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getRequestPermissionIntent", "(Ljava/lang/String;)Landroid/content/Intent;", "")]
		public static unsafe global::Android.Content.Intent GetRequestPermissionIntent (string p0)
		{
			if (id_getRequestPermissionIntent_Ljava_lang_String_ == IntPtr.Zero)
				id_getRequestPermissionIntent_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "getRequestPermissionIntent", "(Ljava/lang/String;)Landroid/content/Intent;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				global::Android.Content.Intent __ret = global::Java.Lang.Object.GetObject<global::Android.Content.Intent> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getRequestPermissionIntent_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_getVersion_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.atap.tangoservice']/class[@name='Tango']/method[@name='getVersion' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("getVersion", "(Landroid/content/Context;)I", "")]
		public static unsafe int GetVersion (global::Android.Content.Context p0)
		{
			if (id_getVersion_Landroid_content_Context_ == IntPtr.Zero)
				id_getVersion_Landroid_content_Context_ = JNIEnv.GetStaticMethodID (class_ref, "getVersion", "(Landroid/content/Context;)I");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				int __ret = JNIEnv.CallStaticIntMethod  (class_ref, id_getVersion_Landroid_content_Context_, __args);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_hasPermission_Landroid_content_Context_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.atap.tangoservice']/class[@name='Tango']/method[@name='hasPermission' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String']]"
		[Register ("hasPermission", "(Landroid/content/Context;Ljava/lang/String;)Z", "")]
		public static unsafe bool HasPermission (global::Android.Content.Context p0, string p1)
		{
			if (id_hasPermission_Landroid_content_Context_Ljava_lang_String_ == IntPtr.Zero)
				id_hasPermission_Landroid_content_Context_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "hasPermission", "(Landroid/content/Context;Ljava/lang/String;)Z");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				bool __ret = JNIEnv.CallStaticBooleanMethod  (class_ref, id_hasPermission_Landroid_content_Context_Ljava_lang_String_, __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static Delegate cb_importAreaDescriptionFile_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetImportAreaDescriptionFile_Ljava_lang_String_Handler ()
		{
			if (cb_importAreaDescriptionFile_Ljava_lang_String_ == null)
				cb_importAreaDescriptionFile_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_ImportAreaDescriptionFile_Ljava_lang_String_);
			return cb_importAreaDescriptionFile_Ljava_lang_String_;
		}

		static void n_ImportAreaDescriptionFile_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Google.Atap.Tangoservice.Tango __this = global::Java.Lang.Object.GetObject<global::Com.Google.Atap.Tangoservice.Tango> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.ImportAreaDescriptionFile (p0);
		}
#pragma warning restore 0169

		static IntPtr id_importAreaDescriptionFile_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.atap.tangoservice']/class[@name='Tango']/method[@name='importAreaDescriptionFile' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("importAreaDescriptionFile", "(Ljava/lang/String;)V", "GetImportAreaDescriptionFile_Ljava_lang_String_Handler")]
		public virtual unsafe void ImportAreaDescriptionFile (string p0)
		{
			if (id_importAreaDescriptionFile_Ljava_lang_String_ == IntPtr.Zero)
				id_importAreaDescriptionFile_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "importAreaDescriptionFile", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_importAreaDescriptionFile_Ljava_lang_String_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "importAreaDescriptionFile", "(Ljava/lang/String;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_listAreaDescriptions;
#pragma warning disable 0169
		static Delegate GetListAreaDescriptionsHandler ()
		{
			if (cb_listAreaDescriptions == null)
				cb_listAreaDescriptions = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_ListAreaDescriptions);
			return cb_listAreaDescriptions;
		}

		static IntPtr n_ListAreaDescriptions (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Google.Atap.Tangoservice.Tango __this = global::Java.Lang.Object.GetObject<global::Com.Google.Atap.Tangoservice.Tango> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList<string>.ToLocalJniHandle (__this.ListAreaDescriptions ());
		}
#pragma warning restore 0169

		static IntPtr id_listAreaDescriptions;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.atap.tangoservice']/class[@name='Tango']/method[@name='listAreaDescriptions' and count(parameter)=0]"
		[Register ("listAreaDescriptions", "()Ljava/util/ArrayList;", "GetListAreaDescriptionsHandler")]
		public virtual unsafe global::System.Collections.Generic.IList<string> ListAreaDescriptions ()
		{
			if (id_listAreaDescriptions == IntPtr.Zero)
				id_listAreaDescriptions = JNIEnv.GetMethodID (class_ref, "listAreaDescriptions", "()Ljava/util/ArrayList;");
			try {

				if (GetType () == ThresholdType)
					return global::Android.Runtime.JavaList<string>.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_listAreaDescriptions), JniHandleOwnership.TransferLocalRef);
				else
					return global::Android.Runtime.JavaList<string>.FromJniHandle (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "listAreaDescriptions", "()Ljava/util/ArrayList;")), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_loadAreaDescriptionMetaData_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetLoadAreaDescriptionMetaData_Ljava_lang_String_Handler ()
		{
			if (cb_loadAreaDescriptionMetaData_Ljava_lang_String_ == null)
				cb_loadAreaDescriptionMetaData_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_LoadAreaDescriptionMetaData_Ljava_lang_String_);
			return cb_loadAreaDescriptionMetaData_Ljava_lang_String_;
		}

		static IntPtr n_LoadAreaDescriptionMetaData_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Google.Atap.Tangoservice.Tango __this = global::Java.Lang.Object.GetObject<global::Com.Google.Atap.Tangoservice.Tango> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.LoadAreaDescriptionMetaData (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_loadAreaDescriptionMetaData_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.atap.tangoservice']/class[@name='Tango']/method[@name='loadAreaDescriptionMetaData' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("loadAreaDescriptionMetaData", "(Ljava/lang/String;)Lcom/google/atap/tangoservice/TangoAreaDescriptionMetaData;", "GetLoadAreaDescriptionMetaData_Ljava_lang_String_Handler")]
		public virtual unsafe global::Com.Google.Atap.Tangoservice.TangoAreaDescriptionMetaData LoadAreaDescriptionMetaData (string p0)
		{
			if (id_loadAreaDescriptionMetaData_Ljava_lang_String_ == IntPtr.Zero)
				id_loadAreaDescriptionMetaData_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "loadAreaDescriptionMetaData", "(Ljava/lang/String;)Lcom/google/atap/tangoservice/TangoAreaDescriptionMetaData;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				global::Com.Google.Atap.Tangoservice.TangoAreaDescriptionMetaData __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Google.Atap.Tangoservice.TangoAreaDescriptionMetaData> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_loadAreaDescriptionMetaData_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Google.Atap.Tangoservice.TangoAreaDescriptionMetaData> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "loadAreaDescriptionMetaData", "(Ljava/lang/String;)Lcom/google/atap/tangoservice/TangoAreaDescriptionMetaData;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_loadFramesOfInterest_arrayLjava_lang_String_Lcom_google_atap_tangoservice_Tango_FoiListener_;
#pragma warning disable 0169
		static Delegate GetLoadFramesOfInterest_arrayLjava_lang_String_Lcom_google_atap_tangoservice_Tango_FoiListener_Handler ()
		{
			if (cb_loadFramesOfInterest_arrayLjava_lang_String_Lcom_google_atap_tangoservice_Tango_FoiListener_ == null)
				cb_loadFramesOfInterest_arrayLjava_lang_String_Lcom_google_atap_tangoservice_Tango_FoiListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_LoadFramesOfInterest_arrayLjava_lang_String_Lcom_google_atap_tangoservice_Tango_FoiListener_);
			return cb_loadFramesOfInterest_arrayLjava_lang_String_Lcom_google_atap_tangoservice_Tango_FoiListener_;
		}

		static void n_LoadFramesOfInterest_arrayLjava_lang_String_Lcom_google_atap_tangoservice_Tango_FoiListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Google.Atap.Tangoservice.Tango __this = global::Java.Lang.Object.GetObject<global::Com.Google.Atap.Tangoservice.Tango> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string[] p0 = (string[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (string));
			global::Com.Google.Atap.Tangoservice.Tango.IFoiListener p1 = (global::Com.Google.Atap.Tangoservice.Tango.IFoiListener)global::Java.Lang.Object.GetObject<global::Com.Google.Atap.Tangoservice.Tango.IFoiListener> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.LoadFramesOfInterest (p0, p1);
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
		}
#pragma warning restore 0169

		static IntPtr id_loadFramesOfInterest_arrayLjava_lang_String_Lcom_google_atap_tangoservice_Tango_FoiListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.atap.tangoservice']/class[@name='Tango']/method[@name='loadFramesOfInterest' and count(parameter)=2 and parameter[1][@type='java.lang.String[]'] and parameter[2][@type='com.google.atap.tangoservice.Tango.FoiListener']]"
		[Register ("loadFramesOfInterest", "([Ljava/lang/String;Lcom/google/atap/tangoservice/Tango$FoiListener;)V", "GetLoadFramesOfInterest_arrayLjava_lang_String_Lcom_google_atap_tangoservice_Tango_FoiListener_Handler")]
		public virtual unsafe void LoadFramesOfInterest (string[] p0, global::Com.Google.Atap.Tangoservice.Tango.IFoiListener p1)
		{
			if (id_loadFramesOfInterest_arrayLjava_lang_String_Lcom_google_atap_tangoservice_Tango_FoiListener_ == IntPtr.Zero)
				id_loadFramesOfInterest_arrayLjava_lang_String_Lcom_google_atap_tangoservice_Tango_FoiListener_ = JNIEnv.GetMethodID (class_ref, "loadFramesOfInterest", "([Ljava/lang/String;Lcom/google/atap/tangoservice/Tango$FoiListener;)V");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_loadFramesOfInterest_arrayLjava_lang_String_Lcom_google_atap_tangoservice_Tango_FoiListener_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "loadFramesOfInterest", "([Ljava/lang/String;Lcom/google/atap/tangoservice/Tango$FoiListener;)V"), __args);
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}
		}

		static Delegate cb_lockCameraBuffer_IarrayJ;
#pragma warning disable 0169
		static Delegate GetLockCameraBuffer_IarrayJHandler ()
		{
			if (cb_lockCameraBuffer_IarrayJ == null)
				cb_lockCameraBuffer_IarrayJ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr, double>) n_LockCameraBuffer_IarrayJ);
			return cb_lockCameraBuffer_IarrayJ;
		}

		static double n_LockCameraBuffer_IarrayJ (IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1)
		{
			global::Com.Google.Atap.Tangoservice.Tango __this = global::Java.Lang.Object.GetObject<global::Com.Google.Atap.Tangoservice.Tango> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			long[] p1 = (long[]) JNIEnv.GetArray (native_p1, JniHandleOwnership.DoNotTransfer, typeof (long));
			double __ret = __this.LockCameraBuffer (p0, p1);
			if (p1 != null)
				JNIEnv.CopyArray (p1, native_p1);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_lockCameraBuffer_IarrayJ;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.atap.tangoservice']/class[@name='Tango']/method[@name='lockCameraBuffer' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='long[]']]"
		[Register ("lockCameraBuffer", "(I[J)D", "GetLockCameraBuffer_IarrayJHandler")]
		public virtual unsafe double LockCameraBuffer (int p0, long[] p1)
		{
			if (id_lockCameraBuffer_IarrayJ == IntPtr.Zero)
				id_lockCameraBuffer_IarrayJ = JNIEnv.GetMethodID (class_ref, "lockCameraBuffer", "(I[J)D");
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);

				double __ret;
				if (GetType () == ThresholdType)
					__ret = JNIEnv.CallDoubleMethod (((global::Java.Lang.Object) this).Handle, id_lockCameraBuffer_IarrayJ, __args);
				else
					__ret = JNIEnv.CallNonvirtualDoubleMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "lockCameraBuffer", "(I[J)D"), __args);
				return __ret;
			} finally {
				if (p1 != null) {
					JNIEnv.CopyArray (native_p1, p1);
					JNIEnv.DeleteLocalRef (native_p1);
				}
			}
		}

		static Delegate cb_resetMotionTracking;
#pragma warning disable 0169
		static Delegate GetResetMotionTrackingHandler ()
		{
			if (cb_resetMotionTracking == null)
				cb_resetMotionTracking = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_ResetMotionTracking);
			return cb_resetMotionTracking;
		}

		static void n_ResetMotionTracking (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Google.Atap.Tangoservice.Tango __this = global::Java.Lang.Object.GetObject<global::Com.Google.Atap.Tangoservice.Tango> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ResetMotionTracking ();
		}
#pragma warning restore 0169

		static IntPtr id_resetMotionTracking;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.atap.tangoservice']/class[@name='Tango']/method[@name='resetMotionTracking' and count(parameter)=0]"
		[Register ("resetMotionTracking", "()V", "GetResetMotionTrackingHandler")]
		public virtual unsafe void ResetMotionTracking ()
		{
			if (id_resetMotionTracking == IntPtr.Zero)
				id_resetMotionTracking = JNIEnv.GetMethodID (class_ref, "resetMotionTracking", "()V");
			try {

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_resetMotionTracking);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "resetMotionTracking", "()V"));
			} finally {
			}
		}

		static Delegate cb_saveAreaDescription;
#pragma warning disable 0169
		static Delegate GetSaveAreaDescriptionHandler ()
		{
			if (cb_saveAreaDescription == null)
				cb_saveAreaDescription = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_SaveAreaDescription);
			return cb_saveAreaDescription;
		}

		static IntPtr n_SaveAreaDescription (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Google.Atap.Tangoservice.Tango __this = global::Java.Lang.Object.GetObject<global::Com.Google.Atap.Tangoservice.Tango> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.SaveAreaDescription ());
		}
#pragma warning restore 0169

		static IntPtr id_saveAreaDescription;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.atap.tangoservice']/class[@name='Tango']/method[@name='saveAreaDescription' and count(parameter)=0]"
		[Register ("saveAreaDescription", "()Ljava/lang/String;", "GetSaveAreaDescriptionHandler")]
		public virtual unsafe string SaveAreaDescription ()
		{
			if (id_saveAreaDescription == IntPtr.Zero)
				id_saveAreaDescription = JNIEnv.GetMethodID (class_ref, "saveAreaDescription", "()Ljava/lang/String;");
			try {

				if (GetType () == ThresholdType)
					return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_saveAreaDescription), JniHandleOwnership.TransferLocalRef);
				else
					return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "saveAreaDescription", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_saveAreaDescriptionMetadata_Ljava_lang_String_Lcom_google_atap_tangoservice_TangoAreaDescriptionMetaData_;
#pragma warning disable 0169
		static Delegate GetSaveAreaDescriptionMetadata_Ljava_lang_String_Lcom_google_atap_tangoservice_TangoAreaDescriptionMetaData_Handler ()
		{
			if (cb_saveAreaDescriptionMetadata_Ljava_lang_String_Lcom_google_atap_tangoservice_TangoAreaDescriptionMetaData_ == null)
				cb_saveAreaDescriptionMetadata_Ljava_lang_String_Lcom_google_atap_tangoservice_TangoAreaDescriptionMetaData_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_SaveAreaDescriptionMetadata_Ljava_lang_String_Lcom_google_atap_tangoservice_TangoAreaDescriptionMetaData_);
			return cb_saveAreaDescriptionMetadata_Ljava_lang_String_Lcom_google_atap_tangoservice_TangoAreaDescriptionMetaData_;
		}

		static void n_SaveAreaDescriptionMetadata_Ljava_lang_String_Lcom_google_atap_tangoservice_TangoAreaDescriptionMetaData_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Google.Atap.Tangoservice.Tango __this = global::Java.Lang.Object.GetObject<global::Com.Google.Atap.Tangoservice.Tango> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Google.Atap.Tangoservice.TangoAreaDescriptionMetaData p1 = global::Java.Lang.Object.GetObject<global::Com.Google.Atap.Tangoservice.TangoAreaDescriptionMetaData> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.SaveAreaDescriptionMetadata (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_saveAreaDescriptionMetadata_Ljava_lang_String_Lcom_google_atap_tangoservice_TangoAreaDescriptionMetaData_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.atap.tangoservice']/class[@name='Tango']/method[@name='saveAreaDescriptionMetadata' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='com.google.atap.tangoservice.TangoAreaDescriptionMetaData']]"
		[Register ("saveAreaDescriptionMetadata", "(Ljava/lang/String;Lcom/google/atap/tangoservice/TangoAreaDescriptionMetaData;)V", "GetSaveAreaDescriptionMetadata_Ljava_lang_String_Lcom_google_atap_tangoservice_TangoAreaDescriptionMetaData_Handler")]
		public virtual unsafe void SaveAreaDescriptionMetadata (string p0, global::Com.Google.Atap.Tangoservice.TangoAreaDescriptionMetaData p1)
		{
			if (id_saveAreaDescriptionMetadata_Ljava_lang_String_Lcom_google_atap_tangoservice_TangoAreaDescriptionMetaData_ == IntPtr.Zero)
				id_saveAreaDescriptionMetadata_Ljava_lang_String_Lcom_google_atap_tangoservice_TangoAreaDescriptionMetaData_ = JNIEnv.GetMethodID (class_ref, "saveAreaDescriptionMetadata", "(Ljava/lang/String;Lcom/google/atap/tangoservice/TangoAreaDescriptionMetaData;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_saveAreaDescriptionMetadata_Ljava_lang_String_Lcom_google_atap_tangoservice_TangoAreaDescriptionMetaData_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "saveAreaDescriptionMetadata", "(Ljava/lang/String;Lcom/google/atap/tangoservice/TangoAreaDescriptionMetaData;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_setRuntimeConfig_Lcom_google_atap_tangoservice_TangoConfig_;
#pragma warning disable 0169
		static Delegate GetSetRuntimeConfig_Lcom_google_atap_tangoservice_TangoConfig_Handler ()
		{
			if (cb_setRuntimeConfig_Lcom_google_atap_tangoservice_TangoConfig_ == null)
				cb_setRuntimeConfig_Lcom_google_atap_tangoservice_TangoConfig_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetRuntimeConfig_Lcom_google_atap_tangoservice_TangoConfig_);
			return cb_setRuntimeConfig_Lcom_google_atap_tangoservice_TangoConfig_;
		}

		static void n_SetRuntimeConfig_Lcom_google_atap_tangoservice_TangoConfig_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Google.Atap.Tangoservice.Tango __this = global::Java.Lang.Object.GetObject<global::Com.Google.Atap.Tangoservice.Tango> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Google.Atap.Tangoservice.TangoConfig p0 = global::Java.Lang.Object.GetObject<global::Com.Google.Atap.Tangoservice.TangoConfig> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetRuntimeConfig (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setRuntimeConfig_Lcom_google_atap_tangoservice_TangoConfig_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.atap.tangoservice']/class[@name='Tango']/method[@name='setRuntimeConfig' and count(parameter)=1 and parameter[1][@type='com.google.atap.tangoservice.TangoConfig']]"
		[Register ("setRuntimeConfig", "(Lcom/google/atap/tangoservice/TangoConfig;)V", "GetSetRuntimeConfig_Lcom_google_atap_tangoservice_TangoConfig_Handler")]
		public virtual unsafe void SetRuntimeConfig (global::Com.Google.Atap.Tangoservice.TangoConfig p0)
		{
			if (id_setRuntimeConfig_Lcom_google_atap_tangoservice_TangoConfig_ == IntPtr.Zero)
				id_setRuntimeConfig_Lcom_google_atap_tangoservice_TangoConfig_ = JNIEnv.GetMethodID (class_ref, "setRuntimeConfig", "(Lcom/google/atap/tangoservice/TangoConfig;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setRuntimeConfig_Lcom_google_atap_tangoservice_TangoConfig_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setRuntimeConfig", "(Lcom/google/atap/tangoservice/TangoConfig;)V"), __args);
			} finally {
			}
		}

		static IntPtr id_throwTangoExceptionIfNeeded_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.atap.tangoservice']/class[@name='Tango']/method[@name='throwTangoExceptionIfNeeded' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("throwTangoExceptionIfNeeded", "(I)V", "")]
		public static unsafe void ThrowTangoExceptionIfNeeded (int p0)
		{
			if (id_throwTangoExceptionIfNeeded_I == IntPtr.Zero)
				id_throwTangoExceptionIfNeeded_I = JNIEnv.GetStaticMethodID (class_ref, "throwTangoExceptionIfNeeded", "(I)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_throwTangoExceptionIfNeeded_I, __args);
			} finally {
			}
		}

		static Delegate cb_unlockCameraBuffer_IJ;
#pragma warning disable 0169
		static Delegate GetUnlockCameraBuffer_IJHandler ()
		{
			if (cb_unlockCameraBuffer_IJ == null)
				cb_unlockCameraBuffer_IJ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, long>) n_UnlockCameraBuffer_IJ);
			return cb_unlockCameraBuffer_IJ;
		}

		static void n_UnlockCameraBuffer_IJ (IntPtr jnienv, IntPtr native__this, int p0, long p1)
		{
			global::Com.Google.Atap.Tangoservice.Tango __this = global::Java.Lang.Object.GetObject<global::Com.Google.Atap.Tangoservice.Tango> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.UnlockCameraBuffer (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_unlockCameraBuffer_IJ;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.atap.tangoservice']/class[@name='Tango']/method[@name='unlockCameraBuffer' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='long']]"
		[Register ("unlockCameraBuffer", "(IJ)V", "GetUnlockCameraBuffer_IJHandler")]
		public virtual unsafe void UnlockCameraBuffer (int p0, long p1)
		{
			if (id_unlockCameraBuffer_IJ == IntPtr.Zero)
				id_unlockCameraBuffer_IJ = JNIEnv.GetMethodID (class_ref, "unlockCameraBuffer", "(IJ)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_unlockCameraBuffer_IJ, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "unlockCameraBuffer", "(IJ)V"), __args);
			} finally {
			}
		}

		static Delegate cb_updateTexture_I;
#pragma warning disable 0169
		static Delegate GetUpdateTexture_IHandler ()
		{
			if (cb_updateTexture_I == null)
				cb_updateTexture_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, double>) n_UpdateTexture_I);
			return cb_updateTexture_I;
		}

		static double n_UpdateTexture_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Google.Atap.Tangoservice.Tango __this = global::Java.Lang.Object.GetObject<global::Com.Google.Atap.Tangoservice.Tango> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.UpdateTexture (p0);
		}
#pragma warning restore 0169

		static IntPtr id_updateTexture_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.atap.tangoservice']/class[@name='Tango']/method[@name='updateTexture' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("updateTexture", "(I)D", "GetUpdateTexture_IHandler")]
		public virtual unsafe double UpdateTexture (int p0)
		{
			if (id_updateTexture_I == IntPtr.Zero)
				id_updateTexture_I = JNIEnv.GetMethodID (class_ref, "updateTexture", "(I)D");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					return JNIEnv.CallDoubleMethod (((global::Java.Lang.Object) this).Handle, id_updateTexture_I, __args);
				else
					return JNIEnv.CallNonvirtualDoubleMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "updateTexture", "(I)D"), __args);
			} finally {
			}
		}

		static Delegate cb_updateTextureExternalOes_II;
#pragma warning disable 0169
		static Delegate GetUpdateTextureExternalOes_IIHandler ()
		{
			if (cb_updateTextureExternalOes_II == null)
				cb_updateTextureExternalOes_II = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, int, double>) n_UpdateTextureExternalOes_II);
			return cb_updateTextureExternalOes_II;
		}

		static double n_UpdateTextureExternalOes_II (IntPtr jnienv, IntPtr native__this, int p0, int p1)
		{
			global::Com.Google.Atap.Tangoservice.Tango __this = global::Java.Lang.Object.GetObject<global::Com.Google.Atap.Tangoservice.Tango> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.UpdateTextureExternalOes (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_updateTextureExternalOes_II;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.atap.tangoservice']/class[@name='Tango']/method[@name='updateTextureExternalOes' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
		[Register ("updateTextureExternalOes", "(II)D", "GetUpdateTextureExternalOes_IIHandler")]
		public virtual unsafe double UpdateTextureExternalOes (int p0, int p1)
		{
			if (id_updateTextureExternalOes_II == IntPtr.Zero)
				id_updateTextureExternalOes_II = JNIEnv.GetMethodID (class_ref, "updateTextureExternalOes", "(II)D");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				if (GetType () == ThresholdType)
					return JNIEnv.CallDoubleMethod (((global::Java.Lang.Object) this).Handle, id_updateTextureExternalOes_II, __args);
				else
					return JNIEnv.CallNonvirtualDoubleMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "updateTextureExternalOes", "(II)D"), __args);
			} finally {
			}
		}

		static Delegate cb_updateTextureExternalOesForBuffer_IIJ;
#pragma warning disable 0169
		static Delegate GetUpdateTextureExternalOesForBuffer_IIJHandler ()
		{
			if (cb_updateTextureExternalOesForBuffer_IIJ == null)
				cb_updateTextureExternalOesForBuffer_IIJ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, int, long>) n_UpdateTextureExternalOesForBuffer_IIJ);
			return cb_updateTextureExternalOesForBuffer_IIJ;
		}

		static void n_UpdateTextureExternalOesForBuffer_IIJ (IntPtr jnienv, IntPtr native__this, int p0, int p1, long p2)
		{
			global::Com.Google.Atap.Tangoservice.Tango __this = global::Java.Lang.Object.GetObject<global::Com.Google.Atap.Tangoservice.Tango> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.UpdateTextureExternalOesForBuffer (p0, p1, p2);
		}
#pragma warning restore 0169

		static IntPtr id_updateTextureExternalOesForBuffer_IIJ;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.atap.tangoservice']/class[@name='Tango']/method[@name='updateTextureExternalOesForBuffer' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='long']]"
		[Register ("updateTextureExternalOesForBuffer", "(IIJ)V", "GetUpdateTextureExternalOesForBuffer_IIJHandler")]
		public virtual unsafe void UpdateTextureExternalOesForBuffer (int p0, int p1, long p2)
		{
			if (id_updateTextureExternalOesForBuffer_IIJ == IntPtr.Zero)
				id_updateTextureExternalOesForBuffer_IIJ = JNIEnv.GetMethodID (class_ref, "updateTextureExternalOesForBuffer", "(IIJ)V");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_updateTextureExternalOesForBuffer_IIJ, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "updateTextureExternalOesForBuffer", "(IIJ)V"), __args);
			} finally {
			}
		}

	}
}
