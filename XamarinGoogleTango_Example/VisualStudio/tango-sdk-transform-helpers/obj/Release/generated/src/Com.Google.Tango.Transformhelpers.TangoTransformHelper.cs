using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Google.Tango.Transformhelpers {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.google.tango.transformhelpers']/class[@name='TangoTransformHelper']"
	[global::Android.Runtime.Register ("com/google/tango/transformhelpers/TangoTransformHelper", DoNotGenerateAcw=true)]
	public partial class TangoTransformHelper : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/google/tango/transformhelpers/TangoTransformHelper", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (TangoTransformHelper); }
		}

		protected TangoTransformHelper (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.google.tango.transformhelpers']/class[@name='TangoTransformHelper']/constructor[@name='TangoTransformHelper' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe TangoTransformHelper ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (TangoTransformHelper)) {
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

		static IntPtr id_doubleTransformPoint_arrayDarrayD;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.tango.transformhelpers']/class[@name='TangoTransformHelper']/method[@name='doubleTransformPoint' and count(parameter)=2 and parameter[1][@type='double[]'] and parameter[2][@type='double[]']]"
		[Register ("doubleTransformPoint", "([D[D)[D", "")]
		public static unsafe double[] DoubleTransformPoint (double[] p0, double[] p1)
		{
			if (id_doubleTransformPoint_arrayDarrayD == IntPtr.Zero)
				id_doubleTransformPoint_arrayDarrayD = JNIEnv.GetStaticMethodID (class_ref, "doubleTransformPoint", "([D[D)[D");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				double[] __ret = (double[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_doubleTransformPoint_arrayDarrayD, __args), JniHandleOwnership.TransferLocalRef, typeof (double));
				return __ret;
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

		static IntPtr id_doubleTransformPointCloud_arrayDLcom_google_atap_tangoservice_TangoPointCloudData_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.tango.transformhelpers']/class[@name='TangoTransformHelper']/method[@name='doubleTransformPointCloud' and count(parameter)=2 and parameter[1][@type='double[]'] and parameter[2][@type='com.google.atap.tangoservice.TangoPointCloudData']]"
		[Register ("doubleTransformPointCloud", "([DLcom/google/atap/tangoservice/TangoPointCloudData;)Lcom/google/atap/tangoservice/TangoPointCloudData;", "")]
		public static unsafe global::Com.Google.Atap.Tangoservice.TangoPointCloudData DoubleTransformPointCloud (double[] p0, global::Com.Google.Atap.Tangoservice.TangoPointCloudData p1)
		{
			if (id_doubleTransformPointCloud_arrayDLcom_google_atap_tangoservice_TangoPointCloudData_ == IntPtr.Zero)
				id_doubleTransformPointCloud_arrayDLcom_google_atap_tangoservice_TangoPointCloudData_ = JNIEnv.GetStaticMethodID (class_ref, "doubleTransformPointCloud", "([DLcom/google/atap/tangoservice/TangoPointCloudData;)Lcom/google/atap/tangoservice/TangoPointCloudData;");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				global::Com.Google.Atap.Tangoservice.TangoPointCloudData __ret = global::Java.Lang.Object.GetObject<global::Com.Google.Atap.Tangoservice.TangoPointCloudData> (JNIEnv.CallStaticObjectMethod  (class_ref, id_doubleTransformPointCloud_arrayDLcom_google_atap_tangoservice_TangoPointCloudData_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}
		}

		static IntPtr id_doubleTransformPose_arrayDarrayDarrayDarrayDarrayD;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.tango.transformhelpers']/class[@name='TangoTransformHelper']/method[@name='doubleTransformPose' and count(parameter)=5 and parameter[1][@type='double[]'] and parameter[2][@type='double[]'] and parameter[3][@type='double[]'] and parameter[4][@type='double[]'] and parameter[5][@type='double[]']]"
		[Register ("doubleTransformPose", "([D[D[D[D[D)V", "")]
		public static unsafe void DoubleTransformPose (double[] p0, double[] p1, double[] p2, double[] p3, double[] p4)
		{
			if (id_doubleTransformPose_arrayDarrayDarrayDarrayDarrayD == IntPtr.Zero)
				id_doubleTransformPose_arrayDarrayDarrayDarrayDarrayD = JNIEnv.GetStaticMethodID (class_ref, "doubleTransformPose", "([D[D[D[D[D)V");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			IntPtr native_p2 = JNIEnv.NewArray (p2);
			IntPtr native_p3 = JNIEnv.NewArray (p3);
			IntPtr native_p4 = JNIEnv.NewArray (p4);
			try {
				JValue* __args = stackalloc JValue [5];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (native_p2);
				__args [3] = new JValue (native_p3);
				__args [4] = new JValue (native_p4);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_doubleTransformPose_arrayDarrayDarrayDarrayDarrayD, __args);
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
				if (p1 != null) {
					JNIEnv.CopyArray (native_p1, p1);
					JNIEnv.DeleteLocalRef (native_p1);
				}
				if (p2 != null) {
					JNIEnv.CopyArray (native_p2, p2);
					JNIEnv.DeleteLocalRef (native_p2);
				}
				if (p3 != null) {
					JNIEnv.CopyArray (native_p3, p3);
					JNIEnv.DeleteLocalRef (native_p3);
				}
				if (p4 != null) {
					JNIEnv.CopyArray (native_p4, p4);
					JNIEnv.DeleteLocalRef (native_p4);
				}
			}
		}

		static IntPtr id_findCorrespondenceSimilarityTransform_arrayarrayDarrayarrayD;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.tango.transformhelpers']/class[@name='TangoTransformHelper']/method[@name='findCorrespondenceSimilarityTransform' and count(parameter)=2 and parameter[1][@type='double[][]'] and parameter[2][@type='double[][]']]"
		[Register ("findCorrespondenceSimilarityTransform", "([[D[[D)[D", "")]
		public static unsafe double[] FindCorrespondenceSimilarityTransform (double[][] p0, double[][] p1)
		{
			if (id_findCorrespondenceSimilarityTransform_arrayarrayDarrayarrayD == IntPtr.Zero)
				id_findCorrespondenceSimilarityTransform_arrayarrayDarrayarrayD = JNIEnv.GetStaticMethodID (class_ref, "findCorrespondenceSimilarityTransform", "([[D[[D)[D");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				double[] __ret = (double[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_findCorrespondenceSimilarityTransform_arrayarrayDarrayarrayD, __args), JniHandleOwnership.TransferLocalRef, typeof (double));
				return __ret;
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

		static IntPtr id_transformPoint_arrayFarrayF;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.tango.transformhelpers']/class[@name='TangoTransformHelper']/method[@name='transformPoint' and count(parameter)=2 and parameter[1][@type='float[]'] and parameter[2][@type='float[]']]"
		[Register ("transformPoint", "([F[F)[F", "")]
		public static unsafe float[] TransformPoint (float[] p0, float[] p1)
		{
			if (id_transformPoint_arrayFarrayF == IntPtr.Zero)
				id_transformPoint_arrayFarrayF = JNIEnv.GetStaticMethodID (class_ref, "transformPoint", "([F[F)[F");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				float[] __ret = (float[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_transformPoint_arrayFarrayF, __args), JniHandleOwnership.TransferLocalRef, typeof (float));
				return __ret;
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

		static IntPtr id_transformPointCloud_arrayFLcom_google_atap_tangoservice_TangoPointCloudData_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.tango.transformhelpers']/class[@name='TangoTransformHelper']/method[@name='transformPointCloud' and count(parameter)=2 and parameter[1][@type='float[]'] and parameter[2][@type='com.google.atap.tangoservice.TangoPointCloudData']]"
		[Register ("transformPointCloud", "([FLcom/google/atap/tangoservice/TangoPointCloudData;)Lcom/google/atap/tangoservice/TangoPointCloudData;", "")]
		public static unsafe global::Com.Google.Atap.Tangoservice.TangoPointCloudData TransformPointCloud (float[] p0, global::Com.Google.Atap.Tangoservice.TangoPointCloudData p1)
		{
			if (id_transformPointCloud_arrayFLcom_google_atap_tangoservice_TangoPointCloudData_ == IntPtr.Zero)
				id_transformPointCloud_arrayFLcom_google_atap_tangoservice_TangoPointCloudData_ = JNIEnv.GetStaticMethodID (class_ref, "transformPointCloud", "([FLcom/google/atap/tangoservice/TangoPointCloudData;)Lcom/google/atap/tangoservice/TangoPointCloudData;");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				global::Com.Google.Atap.Tangoservice.TangoPointCloudData __ret = global::Java.Lang.Object.GetObject<global::Com.Google.Atap.Tangoservice.TangoPointCloudData> (JNIEnv.CallStaticObjectMethod  (class_ref, id_transformPointCloud_arrayFLcom_google_atap_tangoservice_TangoPointCloudData_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}
		}

		static IntPtr id_transformPose_arrayFarrayFarrayFarrayFarrayF;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.tango.transformhelpers']/class[@name='TangoTransformHelper']/method[@name='transformPose' and count(parameter)=5 and parameter[1][@type='float[]'] and parameter[2][@type='float[]'] and parameter[3][@type='float[]'] and parameter[4][@type='float[]'] and parameter[5][@type='float[]']]"
		[Register ("transformPose", "([F[F[F[F[F)V", "")]
		public static unsafe void TransformPose (float[] p0, float[] p1, float[] p2, float[] p3, float[] p4)
		{
			if (id_transformPose_arrayFarrayFarrayFarrayFarrayF == IntPtr.Zero)
				id_transformPose_arrayFarrayFarrayFarrayFarrayF = JNIEnv.GetStaticMethodID (class_ref, "transformPose", "([F[F[F[F[F)V");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			IntPtr native_p2 = JNIEnv.NewArray (p2);
			IntPtr native_p3 = JNIEnv.NewArray (p3);
			IntPtr native_p4 = JNIEnv.NewArray (p4);
			try {
				JValue* __args = stackalloc JValue [5];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (native_p2);
				__args [3] = new JValue (native_p3);
				__args [4] = new JValue (native_p4);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_transformPose_arrayFarrayFarrayFarrayFarrayF, __args);
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
				if (p1 != null) {
					JNIEnv.CopyArray (native_p1, p1);
					JNIEnv.DeleteLocalRef (native_p1);
				}
				if (p2 != null) {
					JNIEnv.CopyArray (native_p2, p2);
					JNIEnv.DeleteLocalRef (native_p2);
				}
				if (p3 != null) {
					JNIEnv.CopyArray (native_p3, p3);
					JNIEnv.DeleteLocalRef (native_p3);
				}
				if (p4 != null) {
					JNIEnv.CopyArray (native_p4, p4);
					JNIEnv.DeleteLocalRef (native_p4);
				}
			}
		}

	}
}
