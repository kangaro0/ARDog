using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Google.Atap.Tangoservice.Experimental {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.google.atap.tangoservice.experimental']/class[@name='TangoImageBuffer']"
	[global::Android.Runtime.Register ("com/google/atap/tangoservice/experimental/TangoImageBuffer", DoNotGenerateAcw=true)]
	public partial class TangoImageBuffer : global::Java.Lang.Object {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.atap.tangoservice.experimental']/class[@name='TangoImageBuffer']/field[@name='RGBA_8888']"
		[Register ("RGBA_8888")]
		public const int Rgba8888 = (int) 1;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.atap.tangoservice.experimental']/class[@name='TangoImageBuffer']/field[@name='RGB_888']"
		[Register ("RGB_888")]
		public const int Rgb888 = (int) 3;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.atap.tangoservice.experimental']/class[@name='TangoImageBuffer']/field[@name='YCRCB_420_SP']"
		[Register ("YCRCB_420_SP")]
		public const int Ycrcb420Sp = (int) 17;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.atap.tangoservice.experimental']/class[@name='TangoImageBuffer']/field[@name='YV12']"
		[Register ("YV12")]
		public const int Yv12 = (int) 842094169;

		static IntPtr data_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.atap.tangoservice.experimental']/class[@name='TangoImageBuffer']/field[@name='data']"
		[Register ("data")]
		public global::Java.Nio.ByteBuffer Data {
			get {
				if (data_jfieldId == IntPtr.Zero)
					data_jfieldId = JNIEnv.GetFieldID (class_ref, "data", "Ljava/nio/ByteBuffer;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, data_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Java.Nio.ByteBuffer> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (data_jfieldId == IntPtr.Zero)
					data_jfieldId = JNIEnv.GetFieldID (class_ref, "data", "Ljava/nio/ByteBuffer;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, data_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr format_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.atap.tangoservice.experimental']/class[@name='TangoImageBuffer']/field[@name='format']"
		[Register ("format")]
		public int Format {
			get {
				if (format_jfieldId == IntPtr.Zero)
					format_jfieldId = JNIEnv.GetFieldID (class_ref, "format", "I");
				return JNIEnv.GetIntField (((global::Java.Lang.Object) this).Handle, format_jfieldId);
			}
			set {
				if (format_jfieldId == IntPtr.Zero)
					format_jfieldId = JNIEnv.GetFieldID (class_ref, "format", "I");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, format_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr frameNumber_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.atap.tangoservice.experimental']/class[@name='TangoImageBuffer']/field[@name='frameNumber']"
		[Register ("frameNumber")]
		public long FrameNumber {
			get {
				if (frameNumber_jfieldId == IntPtr.Zero)
					frameNumber_jfieldId = JNIEnv.GetFieldID (class_ref, "frameNumber", "J");
				return JNIEnv.GetLongField (((global::Java.Lang.Object) this).Handle, frameNumber_jfieldId);
			}
			set {
				if (frameNumber_jfieldId == IntPtr.Zero)
					frameNumber_jfieldId = JNIEnv.GetFieldID (class_ref, "frameNumber", "J");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, frameNumber_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr height_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.atap.tangoservice.experimental']/class[@name='TangoImageBuffer']/field[@name='height']"
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

		static IntPtr stride_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.atap.tangoservice.experimental']/class[@name='TangoImageBuffer']/field[@name='stride']"
		[Register ("stride")]
		public int Stride {
			get {
				if (stride_jfieldId == IntPtr.Zero)
					stride_jfieldId = JNIEnv.GetFieldID (class_ref, "stride", "I");
				return JNIEnv.GetIntField (((global::Java.Lang.Object) this).Handle, stride_jfieldId);
			}
			set {
				if (stride_jfieldId == IntPtr.Zero)
					stride_jfieldId = JNIEnv.GetFieldID (class_ref, "stride", "I");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, stride_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr timestamp_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.atap.tangoservice.experimental']/class[@name='TangoImageBuffer']/field[@name='timestamp']"
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

		static IntPtr width_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.atap.tangoservice.experimental']/class[@name='TangoImageBuffer']/field[@name='width']"
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
				return JNIEnv.FindClass ("com/google/atap/tangoservice/experimental/TangoImageBuffer", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (TangoImageBuffer); }
		}

		protected TangoImageBuffer (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.google.atap.tangoservice.experimental']/class[@name='TangoImageBuffer']/constructor[@name='TangoImageBuffer' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe TangoImageBuffer ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (TangoImageBuffer)) {
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

		static IntPtr id_ctor_IIIJDILjava_nio_ByteBuffer_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.google.atap.tangoservice.experimental']/class[@name='TangoImageBuffer']/constructor[@name='TangoImageBuffer' and count(parameter)=7 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='long'] and parameter[5][@type='double'] and parameter[6][@type='int'] and parameter[7][@type='java.nio.ByteBuffer']]"
		[Register (".ctor", "(IIIJDILjava/nio/ByteBuffer;)V", "")]
		public unsafe TangoImageBuffer (int p0, int p1, int p2, long p3, double p4, int p5, global::Java.Nio.ByteBuffer p6)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [7];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				__args [4] = new JValue (p4);
				__args [5] = new JValue (p5);
				__args [6] = new JValue (p6);
				if (GetType () != typeof (TangoImageBuffer)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(IIIJDILjava/nio/ByteBuffer;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(IIIJDILjava/nio/ByteBuffer;)V", __args);
					return;
				}

				if (id_ctor_IIIJDILjava_nio_ByteBuffer_ == IntPtr.Zero)
					id_ctor_IIIJDILjava_nio_ByteBuffer_ = JNIEnv.GetMethodID (class_ref, "<init>", "(IIIJDILjava/nio/ByteBuffer;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_IIIJDILjava_nio_ByteBuffer_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_IIIJDILjava_nio_ByteBuffer_, __args);
			} finally {
			}
		}

	}
}
