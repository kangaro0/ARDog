using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Google.Tango.Depthinterpolation {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.google.tango.depthinterpolation']/class[@name='TangoDepthInterpolation']"
	[global::Android.Runtime.Register ("com/google/tango/depthinterpolation/TangoDepthInterpolation", DoNotGenerateAcw=true)]
	public partial class TangoDepthInterpolation : global::Java.Lang.Object {

		// Metadata.xml XPath class reference: path="/api/package[@name='com.google.tango.depthinterpolation']/class[@name='TangoDepthInterpolation.DepthBuffer']"
		[global::Android.Runtime.Register ("com/google/tango/depthinterpolation/TangoDepthInterpolation$DepthBuffer", DoNotGenerateAcw=true)]
		public partial class DepthBuffer : global::Java.Lang.Object {


			static IntPtr depths_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.google.tango.depthinterpolation']/class[@name='TangoDepthInterpolation.DepthBuffer']/field[@name='depths']"
			[Register ("depths")]
			public global::Java.Nio.FloatBuffer Depths {
				get {
					if (depths_jfieldId == IntPtr.Zero)
						depths_jfieldId = JNIEnv.GetFieldID (class_ref, "depths", "Ljava/nio/FloatBuffer;");
					IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, depths_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Java.Nio.FloatBuffer> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (depths_jfieldId == IntPtr.Zero)
						depths_jfieldId = JNIEnv.GetFieldID (class_ref, "depths", "Ljava/nio/FloatBuffer;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					try {
						JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, depths_jfieldId, native_value);
					} finally {
						JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}

			static IntPtr height_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.google.tango.depthinterpolation']/class[@name='TangoDepthInterpolation.DepthBuffer']/field[@name='height']"
			[Register ("height")]
			public int Height {
				get {
					if (height_jfieldId == IntPtr.Zero)
						height_jfieldId = JNIEnv.GetFieldID (class_ref, "height", "I");
					return JNIEnv.GetIntField (((global::Java.Lang.Object) this).Handle, height_jfieldId);
				}
				set {
					if (height_jfieldId == IntPtr.Zero)
						height_jfieldId = JNIEnv.GetFieldID (class_ref, "height", "I");
					try {
						JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, height_jfieldId, value);
					} finally {
					}
				}
			}

			static IntPtr width_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.google.tango.depthinterpolation']/class[@name='TangoDepthInterpolation.DepthBuffer']/field[@name='width']"
			[Register ("width")]
			public int Width {
				get {
					if (width_jfieldId == IntPtr.Zero)
						width_jfieldId = JNIEnv.GetFieldID (class_ref, "width", "I");
					return JNIEnv.GetIntField (((global::Java.Lang.Object) this).Handle, width_jfieldId);
				}
				set {
					if (width_jfieldId == IntPtr.Zero)
						width_jfieldId = JNIEnv.GetFieldID (class_ref, "width", "I");
					try {
						JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, width_jfieldId, value);
					} finally {
					}
				}
			}
			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/google/tango/depthinterpolation/TangoDepthInterpolation$DepthBuffer", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (DepthBuffer); }
			}

			protected DepthBuffer (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.google.tango.depthinterpolation']/class[@name='TangoDepthInterpolation.DepthBuffer']/constructor[@name='TangoDepthInterpolation.DepthBuffer' and count(parameter)=0]"
			[Register (".ctor", "()V", "")]
			public unsafe DepthBuffer ()
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				try {
					if (GetType () != typeof (DepthBuffer)) {
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

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/google/tango/depthinterpolation/TangoDepthInterpolation", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (TangoDepthInterpolation); }
		}

		protected TangoDepthInterpolation (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.google.tango.depthinterpolation']/class[@name='TangoDepthInterpolation']/constructor[@name='TangoDepthInterpolation' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe TangoDepthInterpolation ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (TangoDepthInterpolation)) {
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

		static IntPtr id_getDepthAtPointBilateral_Lcom_google_atap_tangoservice_TangoPointCloudData_arrayDarrayDLcom_google_atap_tangoservice_experimental_TangoImageBuffer_FFIarrayDarrayD;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.tango.depthinterpolation']/class[@name='TangoDepthInterpolation']/method[@name='getDepthAtPointBilateral' and count(parameter)=9 and parameter[1][@type='com.google.atap.tangoservice.TangoPointCloudData'] and parameter[2][@type='double[]'] and parameter[3][@type='double[]'] and parameter[4][@type='com.google.atap.tangoservice.experimental.TangoImageBuffer'] and parameter[5][@type='float'] and parameter[6][@type='float'] and parameter[7][@type='int'] and parameter[8][@type='double[]'] and parameter[9][@type='double[]']]"
		[Register ("getDepthAtPointBilateral", "(Lcom/google/atap/tangoservice/TangoPointCloudData;[D[DLcom/google/atap/tangoservice/experimental/TangoImageBuffer;FFI[D[D)[F", "")]
		public static unsafe float[] GetDepthAtPointBilateral (global::Com.Google.Atap.Tangoservice.TangoPointCloudData p0, double[] p1, double[] p2, global::Com.Google.Atap.Tangoservice.Experimental.TangoImageBuffer p3, float p4, float p5, int p6, double[] p7, double[] p8)
		{
			if (id_getDepthAtPointBilateral_Lcom_google_atap_tangoservice_TangoPointCloudData_arrayDarrayDLcom_google_atap_tangoservice_experimental_TangoImageBuffer_FFIarrayDarrayD == IntPtr.Zero)
				id_getDepthAtPointBilateral_Lcom_google_atap_tangoservice_TangoPointCloudData_arrayDarrayDLcom_google_atap_tangoservice_experimental_TangoImageBuffer_FFIarrayDarrayD = JNIEnv.GetStaticMethodID (class_ref, "getDepthAtPointBilateral", "(Lcom/google/atap/tangoservice/TangoPointCloudData;[D[DLcom/google/atap/tangoservice/experimental/TangoImageBuffer;FFI[D[D)[F");
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			IntPtr native_p2 = JNIEnv.NewArray (p2);
			IntPtr native_p7 = JNIEnv.NewArray (p7);
			IntPtr native_p8 = JNIEnv.NewArray (p8);
			try {
				JValue* __args = stackalloc JValue [9];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (native_p2);
				__args [3] = new JValue (p3);
				__args [4] = new JValue (p4);
				__args [5] = new JValue (p5);
				__args [6] = new JValue (p6);
				__args [7] = new JValue (native_p7);
				__args [8] = new JValue (native_p8);
				float[] __ret = (float[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_getDepthAtPointBilateral_Lcom_google_atap_tangoservice_TangoPointCloudData_arrayDarrayDLcom_google_atap_tangoservice_experimental_TangoImageBuffer_FFIarrayDarrayD, __args), JniHandleOwnership.TransferLocalRef, typeof (float));
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
				if (p7 != null) {
					JNIEnv.CopyArray (native_p7, p7);
					JNIEnv.DeleteLocalRef (native_p7);
				}
				if (p8 != null) {
					JNIEnv.CopyArray (native_p8, p8);
					JNIEnv.DeleteLocalRef (native_p8);
				}
			}
		}

		static IntPtr id_getDepthAtPointNearestNeighbor_Lcom_google_atap_tangoservice_TangoPointCloudData_arrayDarrayDFFIarrayDarrayD;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.tango.depthinterpolation']/class[@name='TangoDepthInterpolation']/method[@name='getDepthAtPointNearestNeighbor' and count(parameter)=8 and parameter[1][@type='com.google.atap.tangoservice.TangoPointCloudData'] and parameter[2][@type='double[]'] and parameter[3][@type='double[]'] and parameter[4][@type='float'] and parameter[5][@type='float'] and parameter[6][@type='int'] and parameter[7][@type='double[]'] and parameter[8][@type='double[]']]"
		[Register ("getDepthAtPointNearestNeighbor", "(Lcom/google/atap/tangoservice/TangoPointCloudData;[D[DFFI[D[D)[F", "")]
		public static unsafe float[] GetDepthAtPointNearestNeighbor (global::Com.Google.Atap.Tangoservice.TangoPointCloudData p0, double[] p1, double[] p2, float p3, float p4, int p5, double[] p6, double[] p7)
		{
			if (id_getDepthAtPointNearestNeighbor_Lcom_google_atap_tangoservice_TangoPointCloudData_arrayDarrayDFFIarrayDarrayD == IntPtr.Zero)
				id_getDepthAtPointNearestNeighbor_Lcom_google_atap_tangoservice_TangoPointCloudData_arrayDarrayDFFIarrayDarrayD = JNIEnv.GetStaticMethodID (class_ref, "getDepthAtPointNearestNeighbor", "(Lcom/google/atap/tangoservice/TangoPointCloudData;[D[DFFI[D[D)[F");
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
				float[] __ret = (float[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_getDepthAtPointNearestNeighbor_Lcom_google_atap_tangoservice_TangoPointCloudData_arrayDarrayDFFIarrayDarrayD, __args), JniHandleOwnership.TransferLocalRef, typeof (float));
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

		static IntPtr id_upsampleImageBilateral_ZLcom_google_atap_tangoservice_TangoPointCloudData_Lcom_google_atap_tangoservice_experimental_TangoImageBuffer_Lcom_google_atap_tangoservice_TangoPoseData_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.tango.depthinterpolation']/class[@name='TangoDepthInterpolation']/method[@name='upsampleImageBilateral' and count(parameter)=4 and parameter[1][@type='boolean'] and parameter[2][@type='com.google.atap.tangoservice.TangoPointCloudData'] and parameter[3][@type='com.google.atap.tangoservice.experimental.TangoImageBuffer'] and parameter[4][@type='com.google.atap.tangoservice.TangoPoseData']]"
		[Register ("upsampleImageBilateral", "(ZLcom/google/atap/tangoservice/TangoPointCloudData;Lcom/google/atap/tangoservice/experimental/TangoImageBuffer;Lcom/google/atap/tangoservice/TangoPoseData;)Lcom/google/tango/depthinterpolation/TangoDepthInterpolation$DepthBuffer;", "")]
		public static unsafe global::Com.Google.Tango.Depthinterpolation.TangoDepthInterpolation.DepthBuffer UpsampleImageBilateral (bool p0, global::Com.Google.Atap.Tangoservice.TangoPointCloudData p1, global::Com.Google.Atap.Tangoservice.Experimental.TangoImageBuffer p2, global::Com.Google.Atap.Tangoservice.TangoPoseData p3)
		{
			if (id_upsampleImageBilateral_ZLcom_google_atap_tangoservice_TangoPointCloudData_Lcom_google_atap_tangoservice_experimental_TangoImageBuffer_Lcom_google_atap_tangoservice_TangoPoseData_ == IntPtr.Zero)
				id_upsampleImageBilateral_ZLcom_google_atap_tangoservice_TangoPointCloudData_Lcom_google_atap_tangoservice_experimental_TangoImageBuffer_Lcom_google_atap_tangoservice_TangoPoseData_ = JNIEnv.GetStaticMethodID (class_ref, "upsampleImageBilateral", "(ZLcom/google/atap/tangoservice/TangoPointCloudData;Lcom/google/atap/tangoservice/experimental/TangoImageBuffer;Lcom/google/atap/tangoservice/TangoPoseData;)Lcom/google/tango/depthinterpolation/TangoDepthInterpolation$DepthBuffer;");
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				global::Com.Google.Tango.Depthinterpolation.TangoDepthInterpolation.DepthBuffer __ret = global::Java.Lang.Object.GetObject<global::Com.Google.Tango.Depthinterpolation.TangoDepthInterpolation.DepthBuffer> (JNIEnv.CallStaticObjectMethod  (class_ref, id_upsampleImageBilateral_ZLcom_google_atap_tangoservice_TangoPointCloudData_Lcom_google_atap_tangoservice_experimental_TangoImageBuffer_Lcom_google_atap_tangoservice_TangoPoseData_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_upsampleImageNearestNeighbor_Lcom_google_atap_tangoservice_TangoPointCloudData_IILcom_google_atap_tangoservice_TangoPoseData_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.tango.depthinterpolation']/class[@name='TangoDepthInterpolation']/method[@name='upsampleImageNearestNeighbor' and count(parameter)=4 and parameter[1][@type='com.google.atap.tangoservice.TangoPointCloudData'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='com.google.atap.tangoservice.TangoPoseData']]"
		[Register ("upsampleImageNearestNeighbor", "(Lcom/google/atap/tangoservice/TangoPointCloudData;IILcom/google/atap/tangoservice/TangoPoseData;)Lcom/google/tango/depthinterpolation/TangoDepthInterpolation$DepthBuffer;", "")]
		public static unsafe global::Com.Google.Tango.Depthinterpolation.TangoDepthInterpolation.DepthBuffer UpsampleImageNearestNeighbor (global::Com.Google.Atap.Tangoservice.TangoPointCloudData p0, int p1, int p2, global::Com.Google.Atap.Tangoservice.TangoPoseData p3)
		{
			if (id_upsampleImageNearestNeighbor_Lcom_google_atap_tangoservice_TangoPointCloudData_IILcom_google_atap_tangoservice_TangoPoseData_ == IntPtr.Zero)
				id_upsampleImageNearestNeighbor_Lcom_google_atap_tangoservice_TangoPointCloudData_IILcom_google_atap_tangoservice_TangoPoseData_ = JNIEnv.GetStaticMethodID (class_ref, "upsampleImageNearestNeighbor", "(Lcom/google/atap/tangoservice/TangoPointCloudData;IILcom/google/atap/tangoservice/TangoPoseData;)Lcom/google/tango/depthinterpolation/TangoDepthInterpolation$DepthBuffer;");
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				global::Com.Google.Tango.Depthinterpolation.TangoDepthInterpolation.DepthBuffer __ret = global::Java.Lang.Object.GetObject<global::Com.Google.Tango.Depthinterpolation.TangoDepthInterpolation.DepthBuffer> (JNIEnv.CallStaticObjectMethod  (class_ref, id_upsampleImageNearestNeighbor_Lcom_google_atap_tangoservice_TangoPointCloudData_IILcom_google_atap_tangoservice_TangoPoseData_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

	}
}
