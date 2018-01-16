using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Google.Tango.Support {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.google.tango.support']/class[@name='TangoSupport']"
	[global::Android.Runtime.Register ("com/google/tango/support/TangoSupport", DoNotGenerateAcw=true)]
	public partial class TangoSupport : global::Java.Lang.Object {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.tango.support']/class[@name='TangoSupport']/field[@name='ENGINE_OPENGL']"
		[Register ("ENGINE_OPENGL")]
		public const int EngineOpengl = (int) 1;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.tango.support']/class[@name='TangoSupport']/field[@name='ENGINE_TANGO']"
		[Register ("ENGINE_TANGO")]
		public const int EngineTango = (int) 0;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.tango.support']/class[@name='TangoSupport']/field[@name='ENGINE_UNITY']"
		[Register ("ENGINE_UNITY")]
		public const int EngineUnity = (int) 2;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.tango.support']/class[@name='TangoSupport']/field[@name='ENGINE_UNREAL']"
		[Register ("ENGINE_UNREAL")]
		public const int EngineUnreal = (int) 3;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.tango.support']/class[@name='TangoSupport']/field[@name='ROTATION_0']"
		[Register ("ROTATION_0")]
		public const int Rotation0 = (int) 0;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.tango.support']/class[@name='TangoSupport']/field[@name='ROTATION_180']"
		[Register ("ROTATION_180")]
		public const int Rotation180 = (int) 2;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.tango.support']/class[@name='TangoSupport']/field[@name='ROTATION_270']"
		[Register ("ROTATION_270")]
		public const int Rotation270 = (int) 3;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.tango.support']/class[@name='TangoSupport']/field[@name='ROTATION_90']"
		[Register ("ROTATION_90")]
		public const int Rotation90 = (int) 1;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.tango.support']/class[@name='TangoSupport']/field[@name='ROTATION_IGNORED']"
		[Register ("ROTATION_IGNORED")]
		public const int RotationIgnored = (int) -1;
		// Metadata.xml XPath class reference: path="/api/package[@name='com.google.tango.support']/class[@name='TangoSupport.DoubleMatrixTransformData']"
		[global::Android.Runtime.Register ("com/google/tango/support/TangoSupport$DoubleMatrixTransformData", DoNotGenerateAcw=true)]
		public partial class DoubleMatrixTransformData : global::Java.Lang.Object {


			static IntPtr matrix_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.google.tango.support']/class[@name='TangoSupport.DoubleMatrixTransformData']/field[@name='matrix']"
			[Register ("matrix")]
			public IList<double> Matrix {
				get {
					if (matrix_jfieldId == IntPtr.Zero)
						matrix_jfieldId = JNIEnv.GetFieldID (class_ref, "matrix", "[D");
					return global::Android.Runtime.JavaArray<double>.FromJniHandle (JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, matrix_jfieldId), JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (matrix_jfieldId == IntPtr.Zero)
						matrix_jfieldId = JNIEnv.GetFieldID (class_ref, "matrix", "[D");
					IntPtr native_value = global::Android.Runtime.JavaArray<double>.ToLocalJniHandle (value);
					try {
						JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, matrix_jfieldId, native_value);
					} finally {
						JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}

			static IntPtr statusCode_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.google.tango.support']/class[@name='TangoSupport.DoubleMatrixTransformData']/field[@name='statusCode']"
			[Register ("statusCode")]
			public int StatusCode {
				get {
					if (statusCode_jfieldId == IntPtr.Zero)
						statusCode_jfieldId = JNIEnv.GetFieldID (class_ref, "statusCode", "I");
					return JNIEnv.GetIntField (((global::Java.Lang.Object) this).Handle, statusCode_jfieldId);
				}
				set {
					if (statusCode_jfieldId == IntPtr.Zero)
						statusCode_jfieldId = JNIEnv.GetFieldID (class_ref, "statusCode", "I");
					try {
						JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, statusCode_jfieldId, value);
					} finally {
					}
				}
			}

			static IntPtr timestamp_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.google.tango.support']/class[@name='TangoSupport.DoubleMatrixTransformData']/field[@name='timestamp']"
			[Register ("timestamp")]
			public double Timestamp {
				get {
					if (timestamp_jfieldId == IntPtr.Zero)
						timestamp_jfieldId = JNIEnv.GetFieldID (class_ref, "timestamp", "D");
					return JNIEnv.GetDoubleField (((global::Java.Lang.Object) this).Handle, timestamp_jfieldId);
				}
				set {
					if (timestamp_jfieldId == IntPtr.Zero)
						timestamp_jfieldId = JNIEnv.GetFieldID (class_ref, "timestamp", "D");
					try {
						JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, timestamp_jfieldId, value);
					} finally {
					}
				}
			}
			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/google/tango/support/TangoSupport$DoubleMatrixTransformData", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (DoubleMatrixTransformData); }
			}

			protected DoubleMatrixTransformData (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.google.tango.support']/class[@name='TangoSupport.DoubleMatrixTransformData']/constructor[@name='TangoSupport.DoubleMatrixTransformData' and count(parameter)=0]"
			[Register (".ctor", "()V", "")]
			public unsafe DoubleMatrixTransformData ()
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				try {
					if (GetType () != typeof (DoubleMatrixTransformData)) {
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

		// Metadata.xml XPath class reference: path="/api/package[@name='com.google.tango.support']/class[@name='TangoSupport.IntersectionPointPlaneModelPair']"
		[global::Android.Runtime.Register ("com/google/tango/support/TangoSupport$IntersectionPointPlaneModelPair", DoNotGenerateAcw=true)]
		public partial class IntersectionPointPlaneModelPair : global::Java.Lang.Object {


			static IntPtr intersectionPoint_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.google.tango.support']/class[@name='TangoSupport.IntersectionPointPlaneModelPair']/field[@name='intersectionPoint']"
			[Register ("intersectionPoint")]
			public IList<double> IntersectionPoint {
				get {
					if (intersectionPoint_jfieldId == IntPtr.Zero)
						intersectionPoint_jfieldId = JNIEnv.GetFieldID (class_ref, "intersectionPoint", "[D");
					return global::Android.Runtime.JavaArray<double>.FromJniHandle (JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, intersectionPoint_jfieldId), JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (intersectionPoint_jfieldId == IntPtr.Zero)
						intersectionPoint_jfieldId = JNIEnv.GetFieldID (class_ref, "intersectionPoint", "[D");
					IntPtr native_value = global::Android.Runtime.JavaArray<double>.ToLocalJniHandle (value);
					try {
						JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, intersectionPoint_jfieldId, native_value);
					} finally {
						JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}

			static IntPtr planeModel_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.google.tango.support']/class[@name='TangoSupport.IntersectionPointPlaneModelPair']/field[@name='planeModel']"
			[Register ("planeModel")]
			public IList<double> PlaneModel {
				get {
					if (planeModel_jfieldId == IntPtr.Zero)
						planeModel_jfieldId = JNIEnv.GetFieldID (class_ref, "planeModel", "[D");
					return global::Android.Runtime.JavaArray<double>.FromJniHandle (JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, planeModel_jfieldId), JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (planeModel_jfieldId == IntPtr.Zero)
						planeModel_jfieldId = JNIEnv.GetFieldID (class_ref, "planeModel", "[D");
					IntPtr native_value = global::Android.Runtime.JavaArray<double>.ToLocalJniHandle (value);
					try {
						JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, planeModel_jfieldId, native_value);
					} finally {
						JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}
			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/google/tango/support/TangoSupport$IntersectionPointPlaneModelPair", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (IntersectionPointPlaneModelPair); }
			}

			protected IntersectionPointPlaneModelPair (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.google.tango.support']/class[@name='TangoSupport.IntersectionPointPlaneModelPair']/constructor[@name='TangoSupport.IntersectionPointPlaneModelPair' and count(parameter)=0]"
			[Register (".ctor", "()V", "")]
			public unsafe IntersectionPointPlaneModelPair ()
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				try {
					if (GetType () != typeof (IntersectionPointPlaneModelPair)) {
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

			static IntPtr id_ctor_arrayDarrayD;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.google.tango.support']/class[@name='TangoSupport.IntersectionPointPlaneModelPair']/constructor[@name='TangoSupport.IntersectionPointPlaneModelPair' and count(parameter)=2 and parameter[1][@type='double[]'] and parameter[2][@type='double[]']]"
			[Register (".ctor", "([D[D)V", "")]
			public unsafe IntersectionPointPlaneModelPair (double[] p0, double[] p1)
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				IntPtr native_p0 = JNIEnv.NewArray (p0);
				IntPtr native_p1 = JNIEnv.NewArray (p1);
				try {
					JValue* __args = stackalloc JValue [2];
					__args [0] = new JValue (native_p0);
					__args [1] = new JValue (native_p1);
					if (GetType () != typeof (IntersectionPointPlaneModelPair)) {
						SetHandle (
								global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "([D[D)V", __args),
								JniHandleOwnership.TransferLocalRef);
						global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "([D[D)V", __args);
						return;
					}

					if (id_ctor_arrayDarrayD == IntPtr.Zero)
						id_ctor_arrayDarrayD = JNIEnv.GetMethodID (class_ref, "<init>", "([D[D)V");
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_arrayDarrayD, __args),
							JniHandleOwnership.TransferLocalRef);
					JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_arrayDarrayD, __args);
				} finally {
					if (p0 != null) {
						JNIEnv.CopyArray (native_p0, p0);
						JNIEnv.DeleteLocalRef (native_p0);
					}
					if (p1 != null) {
						JNIEnv.CopyArray (native_p1, p1);
						JNIEnv.DeleteLocalRef (native_p1);
					}
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.google.tango.support']/class[@name='TangoSupport.MatrixTransformData']"
		[global::Android.Runtime.Register ("com/google/tango/support/TangoSupport$MatrixTransformData", DoNotGenerateAcw=true)]
		public partial class MatrixTransformData : global::Java.Lang.Object {


			static IntPtr matrix_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.google.tango.support']/class[@name='TangoSupport.MatrixTransformData']/field[@name='matrix']"
			[Register ("matrix")]
			public IList<float> Matrix {
				get {
					if (matrix_jfieldId == IntPtr.Zero)
						matrix_jfieldId = JNIEnv.GetFieldID (class_ref, "matrix", "[F");
					return global::Android.Runtime.JavaArray<float>.FromJniHandle (JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, matrix_jfieldId), JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (matrix_jfieldId == IntPtr.Zero)
						matrix_jfieldId = JNIEnv.GetFieldID (class_ref, "matrix", "[F");
					IntPtr native_value = global::Android.Runtime.JavaArray<float>.ToLocalJniHandle (value);
					try {
						JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, matrix_jfieldId, native_value);
					} finally {
						JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}

			static IntPtr statusCode_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.google.tango.support']/class[@name='TangoSupport.MatrixTransformData']/field[@name='statusCode']"
			[Register ("statusCode")]
			public int StatusCode {
				get {
					if (statusCode_jfieldId == IntPtr.Zero)
						statusCode_jfieldId = JNIEnv.GetFieldID (class_ref, "statusCode", "I");
					return JNIEnv.GetIntField (((global::Java.Lang.Object) this).Handle, statusCode_jfieldId);
				}
				set {
					if (statusCode_jfieldId == IntPtr.Zero)
						statusCode_jfieldId = JNIEnv.GetFieldID (class_ref, "statusCode", "I");
					try {
						JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, statusCode_jfieldId, value);
					} finally {
					}
				}
			}

			static IntPtr timestamp_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.google.tango.support']/class[@name='TangoSupport.MatrixTransformData']/field[@name='timestamp']"
			[Register ("timestamp")]
			public double Timestamp {
				get {
					if (timestamp_jfieldId == IntPtr.Zero)
						timestamp_jfieldId = JNIEnv.GetFieldID (class_ref, "timestamp", "D");
					return JNIEnv.GetDoubleField (((global::Java.Lang.Object) this).Handle, timestamp_jfieldId);
				}
				set {
					if (timestamp_jfieldId == IntPtr.Zero)
						timestamp_jfieldId = JNIEnv.GetFieldID (class_ref, "timestamp", "D");
					try {
						JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, timestamp_jfieldId, value);
					} finally {
					}
				}
			}
			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/google/tango/support/TangoSupport$MatrixTransformData", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (MatrixTransformData); }
			}

			protected MatrixTransformData (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.google.tango.support']/class[@name='TangoSupport.MatrixTransformData']/constructor[@name='TangoSupport.MatrixTransformData' and count(parameter)=0]"
			[Register (".ctor", "()V", "")]
			public unsafe MatrixTransformData ()
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				try {
					if (GetType () != typeof (MatrixTransformData)) {
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

		// Metadata.xml XPath interface reference: path="/api/package[@name='com.google.tango.support']/interface[@name='TangoSupport.TangoSupportCallbacks']"
		[Register ("com/google/tango/support/TangoSupport$TangoSupportCallbacks", "", "Com.Google.Tango.Support.TangoSupport/ITangoSupportCallbacksInvoker")]
		public partial interface ITangoSupportCallbacks : IJavaObject {

			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.tango.support']/interface[@name='TangoSupport.TangoSupportCallbacks']/method[@name='getCameraIntrinsics' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("getCameraIntrinsics", "(I)Lcom/google/atap/tangoservice/TangoCameraIntrinsics;", "GetGetCameraIntrinsics_IHandler:Com.Google.Tango.Support.TangoSupport/ITangoSupportCallbacksInvoker, tango-sdk-support")]
			global::Com.Google.Atap.Tangoservice.TangoCameraIntrinsics GetCameraIntrinsics (int p0);

			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.tango.support']/interface[@name='TangoSupport.TangoSupportCallbacks']/method[@name='getPoseAtTime' and count(parameter)=2 and parameter[1][@type='double'] and parameter[2][@type='com.google.atap.tangoservice.TangoCoordinateFramePair']]"
			[Register ("getPoseAtTime", "(DLcom/google/atap/tangoservice/TangoCoordinateFramePair;)Lcom/google/atap/tangoservice/TangoPoseData;", "GetGetPoseAtTime_DLcom_google_atap_tangoservice_TangoCoordinateFramePair_Handler:Com.Google.Tango.Support.TangoSupport/ITangoSupportCallbacksInvoker, tango-sdk-support")]
			global::Com.Google.Atap.Tangoservice.TangoPoseData GetPoseAtTime (double p0, global::Com.Google.Atap.Tangoservice.TangoCoordinateFramePair p1);

		}

		[global::Android.Runtime.Register ("com/google/tango/support/TangoSupport$TangoSupportCallbacks", DoNotGenerateAcw=true)]
		internal class ITangoSupportCallbacksInvoker : global::Java.Lang.Object, ITangoSupportCallbacks {

			static IntPtr java_class_ref = JNIEnv.FindClass ("com/google/tango/support/TangoSupport$TangoSupportCallbacks");

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (ITangoSupportCallbacksInvoker); }
			}

			IntPtr class_ref;

			public static ITangoSupportCallbacks GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<ITangoSupportCallbacks> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.google.tango.support.TangoSupport.TangoSupportCallbacks"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public ITangoSupportCallbacksInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
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
				global::Com.Google.Tango.Support.TangoSupport.ITangoSupportCallbacks __this = global::Java.Lang.Object.GetObject<global::Com.Google.Tango.Support.TangoSupport.ITangoSupportCallbacks> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.GetCameraIntrinsics (p0));
			}
#pragma warning restore 0169

			IntPtr id_getCameraIntrinsics_I;
			public unsafe global::Com.Google.Atap.Tangoservice.TangoCameraIntrinsics GetCameraIntrinsics (int p0)
			{
				if (id_getCameraIntrinsics_I == IntPtr.Zero)
					id_getCameraIntrinsics_I = JNIEnv.GetMethodID (class_ref, "getCameraIntrinsics", "(I)Lcom/google/atap/tangoservice/TangoCameraIntrinsics;");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				return global::Java.Lang.Object.GetObject<global::Com.Google.Atap.Tangoservice.TangoCameraIntrinsics> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getCameraIntrinsics_I, __args), JniHandleOwnership.TransferLocalRef);
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
				global::Com.Google.Tango.Support.TangoSupport.ITangoSupportCallbacks __this = global::Java.Lang.Object.GetObject<global::Com.Google.Tango.Support.TangoSupport.ITangoSupportCallbacks> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Com.Google.Atap.Tangoservice.TangoCoordinateFramePair p1 = global::Java.Lang.Object.GetObject<global::Com.Google.Atap.Tangoservice.TangoCoordinateFramePair> (native_p1, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetPoseAtTime (p0, p1));
				return __ret;
			}
#pragma warning restore 0169

			IntPtr id_getPoseAtTime_DLcom_google_atap_tangoservice_TangoCoordinateFramePair_;
			public unsafe global::Com.Google.Atap.Tangoservice.TangoPoseData GetPoseAtTime (double p0, global::Com.Google.Atap.Tangoservice.TangoCoordinateFramePair p1)
			{
				if (id_getPoseAtTime_DLcom_google_atap_tangoservice_TangoCoordinateFramePair_ == IntPtr.Zero)
					id_getPoseAtTime_DLcom_google_atap_tangoservice_TangoCoordinateFramePair_ = JNIEnv.GetMethodID (class_ref, "getPoseAtTime", "(DLcom/google/atap/tangoservice/TangoCoordinateFramePair;)Lcom/google/atap/tangoservice/TangoPoseData;");
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				global::Com.Google.Atap.Tangoservice.TangoPoseData __ret = global::Java.Lang.Object.GetObject<global::Com.Google.Atap.Tangoservice.TangoPoseData> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getPoseAtTime_DLcom_google_atap_tangoservice_TangoCoordinateFramePair_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			}

		}


		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/google/tango/support/TangoSupport", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (TangoSupport); }
		}

		protected TangoSupport (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.google.tango.support']/class[@name='TangoSupport']/constructor[@name='TangoSupport' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe TangoSupport ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (TangoSupport)) {
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

		static IntPtr id_calculateRelativePose_DIDI;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.tango.support']/class[@name='TangoSupport']/method[@name='calculateRelativePose' and count(parameter)=4 and parameter[1][@type='double'] and parameter[2][@type='int'] and parameter[3][@type='double'] and parameter[4][@type='int']]"
		[Register ("calculateRelativePose", "(DIDI)Lcom/google/atap/tangoservice/TangoPoseData;", "")]
		public static unsafe global::Com.Google.Atap.Tangoservice.TangoPoseData CalculateRelativePose (double p0, int p1, double p2, int p3)
		{
			if (id_calculateRelativePose_DIDI == IntPtr.Zero)
				id_calculateRelativePose_DIDI = JNIEnv.GetStaticMethodID (class_ref, "calculateRelativePose", "(DIDI)Lcom/google/atap/tangoservice/TangoPoseData;");
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				return global::Java.Lang.Object.GetObject<global::Com.Google.Atap.Tangoservice.TangoPoseData> (JNIEnv.CallStaticObjectMethod  (class_ref, id_calculateRelativePose_DIDI, __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_fitPlaneModelNearPoint_Lcom_google_atap_tangoservice_TangoPointCloudData_arrayDarrayDFFIarrayDarrayD;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.tango.support']/class[@name='TangoSupport']/method[@name='fitPlaneModelNearPoint' and count(parameter)=8 and parameter[1][@type='com.google.atap.tangoservice.TangoPointCloudData'] and parameter[2][@type='double[]'] and parameter[3][@type='double[]'] and parameter[4][@type='float'] and parameter[5][@type='float'] and parameter[6][@type='int'] and parameter[7][@type='double[]'] and parameter[8][@type='double[]']]"
		[Register ("fitPlaneModelNearPoint", "(Lcom/google/atap/tangoservice/TangoPointCloudData;[D[DFFI[D[D)Lcom/google/tango/support/TangoSupport$IntersectionPointPlaneModelPair;", "")]
		public static unsafe global::Com.Google.Tango.Support.TangoSupport.IntersectionPointPlaneModelPair FitPlaneModelNearPoint (global::Com.Google.Atap.Tangoservice.TangoPointCloudData p0, double[] p1, double[] p2, float p3, float p4, int p5, double[] p6, double[] p7)
		{
			if (id_fitPlaneModelNearPoint_Lcom_google_atap_tangoservice_TangoPointCloudData_arrayDarrayDFFIarrayDarrayD == IntPtr.Zero)
				id_fitPlaneModelNearPoint_Lcom_google_atap_tangoservice_TangoPointCloudData_arrayDarrayDFFIarrayDarrayD = JNIEnv.GetStaticMethodID (class_ref, "fitPlaneModelNearPoint", "(Lcom/google/atap/tangoservice/TangoPointCloudData;[D[DFFI[D[D)Lcom/google/tango/support/TangoSupport$IntersectionPointPlaneModelPair;");
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			IntPtr native_p2 = JNIEnv.NewArray (p2);
			IntPtr native_p6 = JNIEnv.NewArray (p6);
			IntPtr native_p7 = JNIEnv.NewArray (p7);
			try {
				JValue* __args = stackalloc JValue [8];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (native_p2);
				__args [3] = new JValue (p3);
				__args [4] = new JValue (p4);
				__args [5] = new JValue (p5);
				__args [6] = new JValue (native_p6);
				__args [7] = new JValue (native_p7);
				global::Com.Google.Tango.Support.TangoSupport.IntersectionPointPlaneModelPair __ret = global::Java.Lang.Object.GetObject<global::Com.Google.Tango.Support.TangoSupport.IntersectionPointPlaneModelPair> (JNIEnv.CallStaticObjectMethod  (class_ref, id_fitPlaneModelNearPoint_Lcom_google_atap_tangoservice_TangoPointCloudData_arrayDarrayDFFIarrayDarrayD, __args), JniHandleOwnership.TransferLocalRef);
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
				if (p6 != null) {
					JNIEnv.CopyArray (native_p6, p6);
					JNIEnv.DeleteLocalRef (native_p6);
				}
				if (p7 != null) {
					JNIEnv.CopyArray (native_p7, p7);
					JNIEnv.DeleteLocalRef (native_p7);
				}
			}
		}

		static IntPtr id_getCameraIntrinsicsBasedOnDisplayRotation_II;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.tango.support']/class[@name='TangoSupport']/method[@name='getCameraIntrinsicsBasedOnDisplayRotation' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
		[Register ("getCameraIntrinsicsBasedOnDisplayRotation", "(II)Lcom/google/atap/tangoservice/TangoCameraIntrinsics;", "")]
		public static unsafe global::Com.Google.Atap.Tangoservice.TangoCameraIntrinsics GetCameraIntrinsicsBasedOnDisplayRotation (int p0, int p1)
		{
			if (id_getCameraIntrinsicsBasedOnDisplayRotation_II == IntPtr.Zero)
				id_getCameraIntrinsicsBasedOnDisplayRotation_II = JNIEnv.GetStaticMethodID (class_ref, "getCameraIntrinsicsBasedOnDisplayRotation", "(II)Lcom/google/atap/tangoservice/TangoCameraIntrinsics;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				return global::Java.Lang.Object.GetObject<global::Com.Google.Atap.Tangoservice.TangoCameraIntrinsics> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getCameraIntrinsicsBasedOnDisplayRotation_II, __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_getDoubleMatrixTransformAtTime_DIIIII;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.tango.support']/class[@name='TangoSupport']/method[@name='getDoubleMatrixTransformAtTime' and count(parameter)=6 and parameter[1][@type='double'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='int'] and parameter[5][@type='int'] and parameter[6][@type='int']]"
		[Register ("getDoubleMatrixTransformAtTime", "(DIIIII)Lcom/google/tango/support/TangoSupport$DoubleMatrixTransformData;", "")]
		public static unsafe global::Com.Google.Tango.Support.TangoSupport.DoubleMatrixTransformData GetDoubleMatrixTransformAtTime (double p0, int p1, int p2, int p3, int p4, int p5)
		{
			if (id_getDoubleMatrixTransformAtTime_DIIIII == IntPtr.Zero)
				id_getDoubleMatrixTransformAtTime_DIIIII = JNIEnv.GetStaticMethodID (class_ref, "getDoubleMatrixTransformAtTime", "(DIIIII)Lcom/google/tango/support/TangoSupport$DoubleMatrixTransformData;");
			try {
				JValue* __args = stackalloc JValue [6];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				__args [4] = new JValue (p4);
				__args [5] = new JValue (p5);
				return global::Java.Lang.Object.GetObject<global::Com.Google.Tango.Support.TangoSupport.DoubleMatrixTransformData> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getDoubleMatrixTransformAtTime_DIIIII, __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_getMatrixTransformAtTime_DIIIII;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.tango.support']/class[@name='TangoSupport']/method[@name='getMatrixTransformAtTime' and count(parameter)=6 and parameter[1][@type='double'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='int'] and parameter[5][@type='int'] and parameter[6][@type='int']]"
		[Register ("getMatrixTransformAtTime", "(DIIIII)Lcom/google/tango/support/TangoSupport$MatrixTransformData;", "")]
		public static unsafe global::Com.Google.Tango.Support.TangoSupport.MatrixTransformData GetMatrixTransformAtTime (double p0, int p1, int p2, int p3, int p4, int p5)
		{
			if (id_getMatrixTransformAtTime_DIIIII == IntPtr.Zero)
				id_getMatrixTransformAtTime_DIIIII = JNIEnv.GetStaticMethodID (class_ref, "getMatrixTransformAtTime", "(DIIIII)Lcom/google/tango/support/TangoSupport$MatrixTransformData;");
			try {
				JValue* __args = stackalloc JValue [6];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				__args [4] = new JValue (p4);
				__args [5] = new JValue (p5);
				return global::Java.Lang.Object.GetObject<global::Com.Google.Tango.Support.TangoSupport.MatrixTransformData> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getMatrixTransformAtTime_DIIIII, __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_getPoseAtTime_DIIIII;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.tango.support']/class[@name='TangoSupport']/method[@name='getPoseAtTime' and count(parameter)=6 and parameter[1][@type='double'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='int'] and parameter[5][@type='int'] and parameter[6][@type='int']]"
		[Register ("getPoseAtTime", "(DIIIII)Lcom/google/atap/tangoservice/TangoPoseData;", "")]
		public static unsafe global::Com.Google.Atap.Tangoservice.TangoPoseData GetPoseAtTime (double p0, int p1, int p2, int p3, int p4, int p5)
		{
			if (id_getPoseAtTime_DIIIII == IntPtr.Zero)
				id_getPoseAtTime_DIIIII = JNIEnv.GetStaticMethodID (class_ref, "getPoseAtTime", "(DIIIII)Lcom/google/atap/tangoservice/TangoPoseData;");
			try {
				JValue* __args = stackalloc JValue [6];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				__args [4] = new JValue (p4);
				__args [5] = new JValue (p5);
				return global::Java.Lang.Object.GetObject<global::Com.Google.Atap.Tangoservice.TangoPoseData> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getPoseAtTime_DIIIII, __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_getVideoOverlayUVBasedOnDisplayRotation_arrayFI;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.tango.support']/class[@name='TangoSupport']/method[@name='getVideoOverlayUVBasedOnDisplayRotation' and count(parameter)=2 and parameter[1][@type='float[]'] and parameter[2][@type='int']]"
		[Register ("getVideoOverlayUVBasedOnDisplayRotation", "([FI)[F", "")]
		public static unsafe float[] GetVideoOverlayUVBasedOnDisplayRotation (float[] p0, int p1)
		{
			if (id_getVideoOverlayUVBasedOnDisplayRotation_arrayFI == IntPtr.Zero)
				id_getVideoOverlayUVBasedOnDisplayRotation_arrayFI = JNIEnv.GetStaticMethodID (class_ref, "getVideoOverlayUVBasedOnDisplayRotation", "([FI)[F");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				float[] __ret = (float[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_getVideoOverlayUVBasedOnDisplayRotation_arrayFI, __args), JniHandleOwnership.TransferLocalRef, typeof (float));
				return __ret;
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}
		}

		static IntPtr id_initialize_Lcom_google_atap_tangoservice_Tango_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.tango.support']/class[@name='TangoSupport']/method[@name='initialize' and count(parameter)=1 and parameter[1][@type='com.google.atap.tangoservice.Tango']]"
		[Register ("initialize", "(Lcom/google/atap/tangoservice/Tango;)V", "")]
		public static unsafe void Initialize (global::Com.Google.Atap.Tangoservice.Tango p0)
		{
			if (id_initialize_Lcom_google_atap_tangoservice_Tango_ == IntPtr.Zero)
				id_initialize_Lcom_google_atap_tangoservice_Tango_ = JNIEnv.GetStaticMethodID (class_ref, "initialize", "(Lcom/google/atap/tangoservice/Tango;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_initialize_Lcom_google_atap_tangoservice_Tango_, __args);
			} finally {
			}
		}

		static IntPtr id_initialize_Lcom_google_tango_support_TangoSupport_TangoSupportCallbacks_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.tango.support']/class[@name='TangoSupport']/method[@name='initialize' and count(parameter)=1 and parameter[1][@type='com.google.tango.support.TangoSupport.TangoSupportCallbacks']]"
		[Register ("initialize", "(Lcom/google/tango/support/TangoSupport$TangoSupportCallbacks;)V", "")]
		public static unsafe void Initialize (global::Com.Google.Tango.Support.TangoSupport.ITangoSupportCallbacks p0)
		{
			if (id_initialize_Lcom_google_tango_support_TangoSupport_TangoSupportCallbacks_ == IntPtr.Zero)
				id_initialize_Lcom_google_tango_support_TangoSupport_TangoSupportCallbacks_ = JNIEnv.GetStaticMethodID (class_ref, "initialize", "(Lcom/google/tango/support/TangoSupport$TangoSupportCallbacks;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_initialize_Lcom_google_tango_support_TangoSupport_TangoSupportCallbacks_, __args);
			} finally {
			}
		}

	}
}
