using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Google.Atap.Tango.Dataset.Recorder {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.google.atap.tango.dataset.recorder']/class[@name='DatasetMuxer']"
	[global::Android.Runtime.Register ("com/google/atap/tango/dataset/recorder/DatasetMuxer", DoNotGenerateAcw=true)]
	public partial class DatasetMuxer : global::Java.Lang.Object {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.atap.tango.dataset.recorder']/class[@name='DatasetMuxer']/field[@name='DATASET_METADATA']"
		[Register ("DATASET_METADATA")]
		public const string DatasetMetadata = (string) "dataset.metadata";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.atap.tango.dataset.recorder']/class[@name='DatasetMuxer']/field[@name='DATASET_MP4']"
		[Register ("DATASET_MP4")]
		public const string DatasetMp4 = (string) "dataset.mp4";
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/google/atap/tango/dataset/recorder/DatasetMuxer", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (DatasetMuxer); }
		}

		protected DatasetMuxer (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Ljava_io_File_Lcom_google_atap_tangoservice_TangoCameraIntrinsics_Lcom_google_atap_tangoservice_TangoPoseData_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.google.atap.tango.dataset.recorder']/class[@name='DatasetMuxer']/constructor[@name='DatasetMuxer' and count(parameter)=3 and parameter[1][@type='java.io.File'] and parameter[2][@type='com.google.atap.tangoservice.TangoCameraIntrinsics'] and parameter[3][@type='com.google.atap.tangoservice.TangoPoseData']]"
		[Register (".ctor", "(Ljava/io/File;Lcom/google/atap/tangoservice/TangoCameraIntrinsics;Lcom/google/atap/tangoservice/TangoPoseData;)V", "")]
		public unsafe DatasetMuxer (global::Java.IO.File p0, global::Com.Google.Atap.Tangoservice.TangoCameraIntrinsics p1, global::Com.Google.Atap.Tangoservice.TangoPoseData p2)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				if (GetType () != typeof (DatasetMuxer)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Ljava/io/File;Lcom/google/atap/tangoservice/TangoCameraIntrinsics;Lcom/google/atap/tangoservice/TangoPoseData;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Ljava/io/File;Lcom/google/atap/tangoservice/TangoCameraIntrinsics;Lcom/google/atap/tangoservice/TangoPoseData;)V", __args);
					return;
				}

				if (id_ctor_Ljava_io_File_Lcom_google_atap_tangoservice_TangoCameraIntrinsics_Lcom_google_atap_tangoservice_TangoPoseData_ == IntPtr.Zero)
					id_ctor_Ljava_io_File_Lcom_google_atap_tangoservice_TangoCameraIntrinsics_Lcom_google_atap_tangoservice_TangoPoseData_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/io/File;Lcom/google/atap/tangoservice/TangoCameraIntrinsics;Lcom/google/atap/tangoservice/TangoPoseData;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_io_File_Lcom_google_atap_tangoservice_TangoCameraIntrinsics_Lcom_google_atap_tangoservice_TangoPoseData_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Ljava_io_File_Lcom_google_atap_tangoservice_TangoCameraIntrinsics_Lcom_google_atap_tangoservice_TangoPoseData_, __args);
			} finally {
			}
		}

		static Delegate cb_addTrack_Landroid_media_MediaFormat_;
#pragma warning disable 0169
		static Delegate GetAddTrack_Landroid_media_MediaFormat_Handler ()
		{
			if (cb_addTrack_Landroid_media_MediaFormat_ == null)
				cb_addTrack_Landroid_media_MediaFormat_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, int>) n_AddTrack_Landroid_media_MediaFormat_);
			return cb_addTrack_Landroid_media_MediaFormat_;
		}

		static int n_AddTrack_Landroid_media_MediaFormat_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Google.Atap.Tango.Dataset.Recorder.DatasetMuxer __this = global::Java.Lang.Object.GetObject<global::Com.Google.Atap.Tango.Dataset.Recorder.DatasetMuxer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Media.MediaFormat p0 = global::Java.Lang.Object.GetObject<global::Android.Media.MediaFormat> (native_p0, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.AddTrack (p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_addTrack_Landroid_media_MediaFormat_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.atap.tango.dataset.recorder']/class[@name='DatasetMuxer']/method[@name='addTrack' and count(parameter)=1 and parameter[1][@type='android.media.MediaFormat']]"
		[Register ("addTrack", "(Landroid/media/MediaFormat;)I", "GetAddTrack_Landroid_media_MediaFormat_Handler")]
		public virtual unsafe int AddTrack (global::Android.Media.MediaFormat p0)
		{
			if (id_addTrack_Landroid_media_MediaFormat_ == IntPtr.Zero)
				id_addTrack_Landroid_media_MediaFormat_ = JNIEnv.GetMethodID (class_ref, "addTrack", "(Landroid/media/MediaFormat;)I");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				int __ret;
				if (GetType () == ThresholdType)
					__ret = JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_addTrack_Landroid_media_MediaFormat_, __args);
				else
					__ret = JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "addTrack", "(Landroid/media/MediaFormat;)I"), __args);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_release;
#pragma warning disable 0169
		static Delegate GetReleaseHandler ()
		{
			if (cb_release == null)
				cb_release = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Release);
			return cb_release;
		}

		static void n_Release (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Google.Atap.Tango.Dataset.Recorder.DatasetMuxer __this = global::Java.Lang.Object.GetObject<global::Com.Google.Atap.Tango.Dataset.Recorder.DatasetMuxer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Release ();
		}
#pragma warning restore 0169

		static IntPtr id_release;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.atap.tango.dataset.recorder']/class[@name='DatasetMuxer']/method[@name='release' and count(parameter)=0]"
		[Register ("release", "()V", "GetReleaseHandler")]
		public virtual unsafe void Release ()
		{
			if (id_release == IntPtr.Zero)
				id_release = JNIEnv.GetMethodID (class_ref, "release", "()V");
			try {

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_release);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "release", "()V"));
			} finally {
			}
		}

		static Delegate cb_start;
#pragma warning disable 0169
		static Delegate GetStartHandler ()
		{
			if (cb_start == null)
				cb_start = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Start);
			return cb_start;
		}

		static void n_Start (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Google.Atap.Tango.Dataset.Recorder.DatasetMuxer __this = global::Java.Lang.Object.GetObject<global::Com.Google.Atap.Tango.Dataset.Recorder.DatasetMuxer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Start ();
		}
#pragma warning restore 0169

		static IntPtr id_start;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.atap.tango.dataset.recorder']/class[@name='DatasetMuxer']/method[@name='start' and count(parameter)=0]"
		[Register ("start", "()V", "GetStartHandler")]
		public virtual unsafe void Start ()
		{
			if (id_start == IntPtr.Zero)
				id_start = JNIEnv.GetMethodID (class_ref, "start", "()V");
			try {

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_start);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "start", "()V"));
			} finally {
			}
		}

		static Delegate cb_stop;
#pragma warning disable 0169
		static Delegate GetStopHandler ()
		{
			if (cb_stop == null)
				cb_stop = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Stop);
			return cb_stop;
		}

		static void n_Stop (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Google.Atap.Tango.Dataset.Recorder.DatasetMuxer __this = global::Java.Lang.Object.GetObject<global::Com.Google.Atap.Tango.Dataset.Recorder.DatasetMuxer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Stop ();
		}
#pragma warning restore 0169

		static IntPtr id_stop;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.atap.tango.dataset.recorder']/class[@name='DatasetMuxer']/method[@name='stop' and count(parameter)=0]"
		[Register ("stop", "()V", "GetStopHandler")]
		public virtual unsafe void Stop ()
		{
			if (id_stop == IntPtr.Zero)
				id_stop = JNIEnv.GetMethodID (class_ref, "stop", "()V");
			try {

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_stop);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "stop", "()V"));
			} finally {
			}
		}

		static Delegate cb_writeSampleData_ILjava_nio_ByteBuffer_Landroid_media_MediaCodec_BufferInfo_;
#pragma warning disable 0169
		static Delegate GetWriteSampleData_ILjava_nio_ByteBuffer_Landroid_media_MediaCodec_BufferInfo_Handler ()
		{
			if (cb_writeSampleData_ILjava_nio_ByteBuffer_Landroid_media_MediaCodec_BufferInfo_ == null)
				cb_writeSampleData_ILjava_nio_ByteBuffer_Landroid_media_MediaCodec_BufferInfo_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, IntPtr, IntPtr>) n_WriteSampleData_ILjava_nio_ByteBuffer_Landroid_media_MediaCodec_BufferInfo_);
			return cb_writeSampleData_ILjava_nio_ByteBuffer_Landroid_media_MediaCodec_BufferInfo_;
		}

		static void n_WriteSampleData_ILjava_nio_ByteBuffer_Landroid_media_MediaCodec_BufferInfo_ (IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1, IntPtr native_p2)
		{
			global::Com.Google.Atap.Tango.Dataset.Recorder.DatasetMuxer __this = global::Java.Lang.Object.GetObject<global::Com.Google.Atap.Tango.Dataset.Recorder.DatasetMuxer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Nio.ByteBuffer p1 = global::Java.Lang.Object.GetObject<global::Java.Nio.ByteBuffer> (native_p1, JniHandleOwnership.DoNotTransfer);
			global::Android.Media.MediaCodec.BufferInfo p2 = global::Java.Lang.Object.GetObject<global::Android.Media.MediaCodec.BufferInfo> (native_p2, JniHandleOwnership.DoNotTransfer);
			__this.WriteSampleData (p0, p1, p2);
		}
#pragma warning restore 0169

		static IntPtr id_writeSampleData_ILjava_nio_ByteBuffer_Landroid_media_MediaCodec_BufferInfo_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.atap.tango.dataset.recorder']/class[@name='DatasetMuxer']/method[@name='writeSampleData' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='java.nio.ByteBuffer'] and parameter[3][@type='android.media.MediaCodec.BufferInfo']]"
		[Register ("writeSampleData", "(ILjava/nio/ByteBuffer;Landroid/media/MediaCodec$BufferInfo;)V", "GetWriteSampleData_ILjava_nio_ByteBuffer_Landroid_media_MediaCodec_BufferInfo_Handler")]
		public virtual unsafe void WriteSampleData (int p0, global::Java.Nio.ByteBuffer p1, global::Android.Media.MediaCodec.BufferInfo p2)
		{
			if (id_writeSampleData_ILjava_nio_ByteBuffer_Landroid_media_MediaCodec_BufferInfo_ == IntPtr.Zero)
				id_writeSampleData_ILjava_nio_ByteBuffer_Landroid_media_MediaCodec_BufferInfo_ = JNIEnv.GetMethodID (class_ref, "writeSampleData", "(ILjava/nio/ByteBuffer;Landroid/media/MediaCodec$BufferInfo;)V");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_writeSampleData_ILjava_nio_ByteBuffer_Landroid_media_MediaCodec_BufferInfo_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "writeSampleData", "(ILjava/nio/ByteBuffer;Landroid/media/MediaCodec$BufferInfo;)V"), __args);
			} finally {
			}
		}

	}
}
