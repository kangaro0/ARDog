using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Google.Tango.Markers {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.google.tango.markers']/class[@name='TangoMarkers']"
	[global::Android.Runtime.Register ("com/google/tango/markers/TangoMarkers", DoNotGenerateAcw=true)]
	public partial class TangoMarkers : global::Java.Lang.Object {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.tango.markers']/class[@name='TangoMarkers']/field[@name='MARKER_ARTAG']"
		[Register ("MARKER_ARTAG")]
		public const int MarkerArtag = (int) 1;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.tango.markers']/class[@name='TangoMarkers']/field[@name='MARKER_QRCODE']"
		[Register ("MARKER_QRCODE")]
		public const int MarkerQrcode = (int) 2;
		// Metadata.xml XPath class reference: path="/api/package[@name='com.google.tango.markers']/class[@name='TangoMarkers.DetectParam']"
		[global::Android.Runtime.Register ("com/google/tango/markers/TangoMarkers$DetectParam", DoNotGenerateAcw=true)]
		public partial class DetectParam : global::Java.Lang.Object {


			static IntPtr markerSize_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.google.tango.markers']/class[@name='TangoMarkers.DetectParam']/field[@name='markerSize']"
			[Register ("markerSize")]
			public double MarkerSize {
				get {
					if (markerSize_jfieldId == IntPtr.Zero)
						markerSize_jfieldId = JNIEnv.GetFieldID (class_ref, "markerSize", "D");
					return JNIEnv.GetDoubleField (((global::Java.Lang.Object) this).Handle, markerSize_jfieldId);
				}
				set {
					if (markerSize_jfieldId == IntPtr.Zero)
						markerSize_jfieldId = JNIEnv.GetFieldID (class_ref, "markerSize", "D");
					try {
						JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, markerSize_jfieldId, value);
					} finally {
					}
				}
			}

			static IntPtr type_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.google.tango.markers']/class[@name='TangoMarkers.DetectParam']/field[@name='type']"
			[Register ("type")]
			public int Type {
				get {
					if (type_jfieldId == IntPtr.Zero)
						type_jfieldId = JNIEnv.GetFieldID (class_ref, "type", "I");
					return JNIEnv.GetIntField (((global::Java.Lang.Object) this).Handle, type_jfieldId);
				}
				set {
					if (type_jfieldId == IntPtr.Zero)
						type_jfieldId = JNIEnv.GetFieldID (class_ref, "type", "I");
					try {
						JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, type_jfieldId, value);
					} finally {
					}
				}
			}
			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/google/tango/markers/TangoMarkers$DetectParam", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (DetectParam); }
			}

			protected DetectParam (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.google.tango.markers']/class[@name='TangoMarkers.DetectParam']/constructor[@name='TangoMarkers.DetectParam' and count(parameter)=0]"
			[Register (".ctor", "()V", "")]
			public unsafe DetectParam ()
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				try {
					if (GetType () != typeof (DetectParam)) {
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

		// Metadata.xml XPath class reference: path="/api/package[@name='com.google.tango.markers']/class[@name='TangoMarkers.Marker']"
		[global::Android.Runtime.Register ("com/google/tango/markers/TangoMarkers$Marker", DoNotGenerateAcw=true)]
		public partial class Marker : global::Java.Lang.Object {


			static IntPtr content_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.google.tango.markers']/class[@name='TangoMarkers.Marker']/field[@name='content']"
			[Register ("content")]
			public string Content {
				get {
					if (content_jfieldId == IntPtr.Zero)
						content_jfieldId = JNIEnv.GetFieldID (class_ref, "content", "Ljava/lang/String;");
					IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, content_jfieldId);
					return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (content_jfieldId == IntPtr.Zero)
						content_jfieldId = JNIEnv.GetFieldID (class_ref, "content", "Ljava/lang/String;");
					IntPtr native_value = JNIEnv.NewString (value);
					try {
						JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, content_jfieldId, native_value);
					} finally {
						JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}

			static IntPtr corners2d_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.google.tango.markers']/class[@name='TangoMarkers.Marker']/field[@name='corners2d']"
			[Register ("corners2d")]
			public IList<float[]> Corners2d {
				get {
					if (corners2d_jfieldId == IntPtr.Zero)
						corners2d_jfieldId = JNIEnv.GetFieldID (class_ref, "corners2d", "[[F");
					return global::Android.Runtime.JavaArray<float[]>.FromJniHandle (JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, corners2d_jfieldId), JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (corners2d_jfieldId == IntPtr.Zero)
						corners2d_jfieldId = JNIEnv.GetFieldID (class_ref, "corners2d", "[[F");
					IntPtr native_value = global::Android.Runtime.JavaArray<float[]>.ToLocalJniHandle (value);
					try {
						JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, corners2d_jfieldId, native_value);
					} finally {
						JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}

			static IntPtr corners3d_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.google.tango.markers']/class[@name='TangoMarkers.Marker']/field[@name='corners3d']"
			[Register ("corners3d")]
			public IList<float[]> Corners3d {
				get {
					if (corners3d_jfieldId == IntPtr.Zero)
						corners3d_jfieldId = JNIEnv.GetFieldID (class_ref, "corners3d", "[[F");
					return global::Android.Runtime.JavaArray<float[]>.FromJniHandle (JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, corners3d_jfieldId), JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (corners3d_jfieldId == IntPtr.Zero)
						corners3d_jfieldId = JNIEnv.GetFieldID (class_ref, "corners3d", "[[F");
					IntPtr native_value = global::Android.Runtime.JavaArray<float[]>.ToLocalJniHandle (value);
					try {
						JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, corners3d_jfieldId, native_value);
					} finally {
						JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}

			static IntPtr orientation_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.google.tango.markers']/class[@name='TangoMarkers.Marker']/field[@name='orientation']"
			[Register ("orientation")]
			public IList<double> Orientation {
				get {
					if (orientation_jfieldId == IntPtr.Zero)
						orientation_jfieldId = JNIEnv.GetFieldID (class_ref, "orientation", "[D");
					return global::Android.Runtime.JavaArray<double>.FromJniHandle (JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, orientation_jfieldId), JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (orientation_jfieldId == IntPtr.Zero)
						orientation_jfieldId = JNIEnv.GetFieldID (class_ref, "orientation", "[D");
					IntPtr native_value = global::Android.Runtime.JavaArray<double>.ToLocalJniHandle (value);
					try {
						JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, orientation_jfieldId, native_value);
					} finally {
						JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}

			static IntPtr timestamp_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.google.tango.markers']/class[@name='TangoMarkers.Marker']/field[@name='timestamp']"
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

			static IntPtr translation_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.google.tango.markers']/class[@name='TangoMarkers.Marker']/field[@name='translation']"
			[Register ("translation")]
			public IList<double> Translation {
				get {
					if (translation_jfieldId == IntPtr.Zero)
						translation_jfieldId = JNIEnv.GetFieldID (class_ref, "translation", "[D");
					return global::Android.Runtime.JavaArray<double>.FromJniHandle (JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, translation_jfieldId), JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (translation_jfieldId == IntPtr.Zero)
						translation_jfieldId = JNIEnv.GetFieldID (class_ref, "translation", "[D");
					IntPtr native_value = global::Android.Runtime.JavaArray<double>.ToLocalJniHandle (value);
					try {
						JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, translation_jfieldId, native_value);
					} finally {
						JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}

			static IntPtr type_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.google.tango.markers']/class[@name='TangoMarkers.Marker']/field[@name='type']"
			[Register ("type")]
			public int Type {
				get {
					if (type_jfieldId == IntPtr.Zero)
						type_jfieldId = JNIEnv.GetFieldID (class_ref, "type", "I");
					return JNIEnv.GetIntField (((global::Java.Lang.Object) this).Handle, type_jfieldId);
				}
				set {
					if (type_jfieldId == IntPtr.Zero)
						type_jfieldId = JNIEnv.GetFieldID (class_ref, "type", "I");
					try {
						JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, type_jfieldId, value);
					} finally {
					}
				}
			}
			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/google/tango/markers/TangoMarkers$Marker", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (Marker); }
			}

			protected Marker (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.google.tango.markers']/class[@name='TangoMarkers.Marker']/constructor[@name='TangoMarkers.Marker' and count(parameter)=0]"
			[Register (".ctor", "()V", "")]
			public unsafe Marker ()
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				try {
					if (GetType () != typeof (Marker)) {
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
				return JNIEnv.FindClass ("com/google/tango/markers/TangoMarkers", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (TangoMarkers); }
		}

		protected TangoMarkers (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.google.tango.markers']/class[@name='TangoMarkers']/constructor[@name='TangoMarkers' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe TangoMarkers ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (TangoMarkers)) {
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

		static IntPtr id_detectMarkers_Lcom_google_atap_tangoservice_experimental_TangoImageBuffer_IarrayDarrayDLcom_google_tango_markers_TangoMarkers_DetectParam_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.tango.markers']/class[@name='TangoMarkers']/method[@name='detectMarkers' and count(parameter)=5 and parameter[1][@type='com.google.atap.tangoservice.experimental.TangoImageBuffer'] and parameter[2][@type='int'] and parameter[3][@type='double[]'] and parameter[4][@type='double[]'] and parameter[5][@type='com.google.tango.markers.TangoMarkers.DetectParam']]"
		[Register ("detectMarkers", "(Lcom/google/atap/tangoservice/experimental/TangoImageBuffer;I[D[DLcom/google/tango/markers/TangoMarkers$DetectParam;)Ljava/util/List;", "")]
		public static unsafe global::System.Collections.Generic.IList<global::Com.Google.Tango.Markers.TangoMarkers.Marker> DetectMarkers (global::Com.Google.Atap.Tangoservice.Experimental.TangoImageBuffer p0, int p1, double[] p2, double[] p3, global::Com.Google.Tango.Markers.TangoMarkers.DetectParam p4)
		{
			if (id_detectMarkers_Lcom_google_atap_tangoservice_experimental_TangoImageBuffer_IarrayDarrayDLcom_google_tango_markers_TangoMarkers_DetectParam_ == IntPtr.Zero)
				id_detectMarkers_Lcom_google_atap_tangoservice_experimental_TangoImageBuffer_IarrayDarrayDLcom_google_tango_markers_TangoMarkers_DetectParam_ = JNIEnv.GetStaticMethodID (class_ref, "detectMarkers", "(Lcom/google/atap/tangoservice/experimental/TangoImageBuffer;I[D[DLcom/google/tango/markers/TangoMarkers$DetectParam;)Ljava/util/List;");
			IntPtr native_p2 = JNIEnv.NewArray (p2);
			IntPtr native_p3 = JNIEnv.NewArray (p3);
			try {
				JValue* __args = stackalloc JValue [5];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (native_p2);
				__args [3] = new JValue (native_p3);
				__args [4] = new JValue (p4);
				global::System.Collections.Generic.IList<global::Com.Google.Tango.Markers.TangoMarkers.Marker> __ret = global::Android.Runtime.JavaList<global::Com.Google.Tango.Markers.TangoMarkers.Marker>.FromJniHandle (JNIEnv.CallStaticObjectMethod  (class_ref, id_detectMarkers_Lcom_google_atap_tangoservice_experimental_TangoImageBuffer_IarrayDarrayDLcom_google_tango_markers_TangoMarkers_DetectParam_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				if (p2 != null) {
					JNIEnv.CopyArray (native_p2, p2);
					JNIEnv.DeleteLocalRef (native_p2);
				}
				if (p3 != null) {
					JNIEnv.CopyArray (native_p3, p3);
					JNIEnv.DeleteLocalRef (native_p3);
				}
			}
		}

	}
}
