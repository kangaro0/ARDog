using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Google.Atap.Tango.Reconstruction {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.google.atap.tango.reconstruction']/class[@name='TangoZipInputStream']"
	[global::Android.Runtime.Register ("com/google/atap/tango/reconstruction/TangoZipInputStream", DoNotGenerateAcw=true)]
	public partial class TangoZipInputStream : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/google/atap/tango/reconstruction/TangoZipInputStream", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (TangoZipInputStream); }
		}

		protected TangoZipInputStream (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.google.atap.tango.reconstruction']/class[@name='TangoZipInputStream']/constructor[@name='TangoZipInputStream' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe TangoZipInputStream ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (TangoZipInputStream)) {
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

		static IntPtr id_ctor_Ljava_io_File_Ljava_lang_String_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.google.atap.tango.reconstruction']/class[@name='TangoZipInputStream']/constructor[@name='TangoZipInputStream' and count(parameter)=2 and parameter[1][@type='java.io.File'] and parameter[2][@type='java.lang.String']]"
		[Register (".ctor", "(Ljava/io/File;Ljava/lang/String;)V", "")]
		public unsafe TangoZipInputStream (global::Java.IO.File p0, string p1)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				if (GetType () != typeof (TangoZipInputStream)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Ljava/io/File;Ljava/lang/String;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Ljava/io/File;Ljava/lang/String;)V", __args);
					return;
				}

				if (id_ctor_Ljava_io_File_Ljava_lang_String_ == IntPtr.Zero)
					id_ctor_Ljava_io_File_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/io/File;Ljava/lang/String;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_io_File_Ljava_lang_String_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Ljava_io_File_Ljava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static Delegate cb_isReleased;
#pragma warning disable 0169
		static Delegate GetIsReleasedHandler ()
		{
			if (cb_isReleased == null)
				cb_isReleased = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsReleased);
			return cb_isReleased;
		}

		static bool n_IsReleased (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Google.Atap.Tango.Reconstruction.TangoZipInputStream __this = global::Java.Lang.Object.GetObject<global::Com.Google.Atap.Tango.Reconstruction.TangoZipInputStream> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsReleased;
		}
#pragma warning restore 0169

		static IntPtr id_isReleased;
		public virtual unsafe bool IsReleased {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.atap.tango.reconstruction']/class[@name='TangoZipInputStream']/method[@name='isReleased' and count(parameter)=0]"
			[Register ("isReleased", "()Z", "GetIsReleasedHandler")]
			get {
				if (id_isReleased == IntPtr.Zero)
					id_isReleased = JNIEnv.GetMethodID (class_ref, "isReleased", "()Z");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isReleased);
					else
						return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isReleased", "()Z"));
				} finally {
				}
			}
		}

		static Delegate cb_getNextEntry;
#pragma warning disable 0169
		static Delegate GetGetNextEntryHandler ()
		{
			if (cb_getNextEntry == null)
				cb_getNextEntry = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetNextEntry);
			return cb_getNextEntry;
		}

		static IntPtr n_GetNextEntry (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Google.Atap.Tango.Reconstruction.TangoZipInputStream __this = global::Java.Lang.Object.GetObject<global::Com.Google.Atap.Tango.Reconstruction.TangoZipInputStream> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.NextEntry);
		}
#pragma warning restore 0169

		static IntPtr id_getNextEntry;
		public virtual unsafe global::Java.Util.Zip.ZipEntry NextEntry {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.atap.tango.reconstruction']/class[@name='TangoZipInputStream']/method[@name='getNextEntry' and count(parameter)=0]"
			[Register ("getNextEntry", "()Ljava/util/zip/ZipEntry;", "GetGetNextEntryHandler")]
			get {
				if (id_getNextEntry == IntPtr.Zero)
					id_getNextEntry = JNIEnv.GetMethodID (class_ref, "getNextEntry", "()Ljava/util/zip/ZipEntry;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Java.Util.Zip.ZipEntry> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getNextEntry), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Java.Util.Zip.ZipEntry> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getNextEntry", "()Ljava/util/zip/ZipEntry;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getNumEntriesWithFileReset;
#pragma warning disable 0169
		static Delegate GetGetNumEntriesWithFileResetHandler ()
		{
			if (cb_getNumEntriesWithFileReset == null)
				cb_getNumEntriesWithFileReset = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetNumEntriesWithFileReset);
			return cb_getNumEntriesWithFileReset;
		}

		static int n_GetNumEntriesWithFileReset (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Google.Atap.Tango.Reconstruction.TangoZipInputStream __this = global::Java.Lang.Object.GetObject<global::Com.Google.Atap.Tango.Reconstruction.TangoZipInputStream> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.NumEntriesWithFileReset;
		}
#pragma warning restore 0169

		static IntPtr id_getNumEntriesWithFileReset;
		public virtual unsafe int NumEntriesWithFileReset {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.atap.tango.reconstruction']/class[@name='TangoZipInputStream']/method[@name='getNumEntriesWithFileReset' and count(parameter)=0]"
			[Register ("getNumEntriesWithFileReset", "()I", "GetGetNumEntriesWithFileResetHandler")]
			get {
				if (id_getNumEntriesWithFileReset == IntPtr.Zero)
					id_getNumEntriesWithFileReset = JNIEnv.GetMethodID (class_ref, "getNumEntriesWithFileReset", "()I");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getNumEntriesWithFileReset);
					else
						return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getNumEntriesWithFileReset", "()I"));
				} finally {
				}
			}
		}

		static Delegate cb_getBytes;
#pragma warning disable 0169
		static Delegate GetGetBytesHandler ()
		{
			if (cb_getBytes == null)
				cb_getBytes = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetBytes);
			return cb_getBytes;
		}

		static IntPtr n_GetBytes (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Google.Atap.Tango.Reconstruction.TangoZipInputStream __this = global::Java.Lang.Object.GetObject<global::Com.Google.Atap.Tango.Reconstruction.TangoZipInputStream> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetBytes ());
		}
#pragma warning restore 0169

		static IntPtr id_getBytes;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.atap.tango.reconstruction']/class[@name='TangoZipInputStream']/method[@name='getBytes' and count(parameter)=0]"
		[Register ("getBytes", "()[B", "GetGetBytesHandler")]
		public virtual unsafe byte[] GetBytes ()
		{
			if (id_getBytes == IntPtr.Zero)
				id_getBytes = JNIEnv.GetMethodID (class_ref, "getBytes", "()[B");
			try {

				if (GetType () == ThresholdType)
					return (byte[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getBytes), JniHandleOwnership.TransferLocalRef, typeof (byte));
				else
					return (byte[]) JNIEnv.GetArray (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getBytes", "()[B")), JniHandleOwnership.TransferLocalRef, typeof (byte));
			} finally {
			}
		}

		static Delegate cb_readBytes;
#pragma warning disable 0169
		static Delegate GetReadBytesHandler ()
		{
			if (cb_readBytes == null)
				cb_readBytes = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_ReadBytes);
			return cb_readBytes;
		}

		static int n_ReadBytes (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Google.Atap.Tango.Reconstruction.TangoZipInputStream __this = global::Java.Lang.Object.GetObject<global::Com.Google.Atap.Tango.Reconstruction.TangoZipInputStream> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ReadBytes ();
		}
#pragma warning restore 0169

		static IntPtr id_readBytes;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.atap.tango.reconstruction']/class[@name='TangoZipInputStream']/method[@name='readBytes' and count(parameter)=0]"
		[Register ("readBytes", "()I", "GetReadBytesHandler")]
		public virtual unsafe int ReadBytes ()
		{
			if (id_readBytes == IntPtr.Zero)
				id_readBytes = JNIEnv.GetMethodID (class_ref, "readBytes", "()I");
			try {

				if (GetType () == ThresholdType)
					return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_readBytes);
				else
					return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "readBytes", "()I"));
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
			global::Com.Google.Atap.Tango.Reconstruction.TangoZipInputStream __this = global::Java.Lang.Object.GetObject<global::Com.Google.Atap.Tango.Reconstruction.TangoZipInputStream> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Release ();
		}
#pragma warning restore 0169

		static IntPtr id_release;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.atap.tango.reconstruction']/class[@name='TangoZipInputStream']/method[@name='release' and count(parameter)=0]"
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

		static Delegate cb_setJavaArrayExpectedSize_I;
#pragma warning disable 0169
		static Delegate GetSetJavaArrayExpectedSize_IHandler ()
		{
			if (cb_setJavaArrayExpectedSize_I == null)
				cb_setJavaArrayExpectedSize_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetJavaArrayExpectedSize_I);
			return cb_setJavaArrayExpectedSize_I;
		}

		static void n_SetJavaArrayExpectedSize_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Google.Atap.Tango.Reconstruction.TangoZipInputStream __this = global::Java.Lang.Object.GetObject<global::Com.Google.Atap.Tango.Reconstruction.TangoZipInputStream> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetJavaArrayExpectedSize (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setJavaArrayExpectedSize_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.atap.tango.reconstruction']/class[@name='TangoZipInputStream']/method[@name='setJavaArrayExpectedSize' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setJavaArrayExpectedSize", "(I)V", "GetSetJavaArrayExpectedSize_IHandler")]
		public virtual unsafe void SetJavaArrayExpectedSize (int p0)
		{
			if (id_setJavaArrayExpectedSize_I == IntPtr.Zero)
				id_setJavaArrayExpectedSize_I = JNIEnv.GetMethodID (class_ref, "setJavaArrayExpectedSize", "(I)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setJavaArrayExpectedSize_I, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setJavaArrayExpectedSize", "(I)V"), __args);
			} finally {
			}
		}

	}
}
