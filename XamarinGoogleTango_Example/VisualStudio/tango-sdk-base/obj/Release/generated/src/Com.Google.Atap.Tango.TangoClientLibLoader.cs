using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Google.Atap.Tango {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.google.atap.tango']/class[@name='TangoClientLibLoader']"
	[global::Android.Runtime.Register ("com/google/atap/tango/TangoClientLibLoader", DoNotGenerateAcw=true)]
	public partial class TangoClientLibLoader : global::Java.Lang.Object {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.atap.tango']/class[@name='TangoClientLibLoader']/field[@name='ARCH_ARM32']"
		[Register ("ARCH_ARM32")]
		public const int ArchArm32 = (int) 2;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.atap.tango']/class[@name='TangoClientLibLoader']/field[@name='ARCH_ARM64']"
		[Register ("ARCH_ARM64")]
		public const int ArchArm64 = (int) 1;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.atap.tango']/class[@name='TangoClientLibLoader']/field[@name='ARCH_DEFAULT']"
		[Register ("ARCH_DEFAULT")]
		public const int ArchDefault = (int) 0;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.atap.tango']/class[@name='TangoClientLibLoader']/field[@name='ARCH_ERROR']"
		[Register ("ARCH_ERROR")]
		public const int ArchError = (int) -2;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.atap.tango']/class[@name='TangoClientLibLoader']/field[@name='ARCH_FALLBACK']"
		[Register ("ARCH_FALLBACK")]
		public const int ArchFallback = (int) -1;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.atap.tango']/class[@name='TangoClientLibLoader']/field[@name='ARCH_X86']"
		[Register ("ARCH_X86")]
		public const int ArchX86 = (int) 4;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.atap.tango']/class[@name='TangoClientLibLoader']/field[@name='ARCH_X86_64']"
		[Register ("ARCH_X86_64")]
		public const int ArchX8664 = (int) 3;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.atap.tango']/class[@name='TangoClientLibLoader']/field[@name='PURE_JAVA_PATH']"
		[Register ("PURE_JAVA_PATH")]
		public const bool PureJavaPath = (bool) false;
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/google/atap/tango/TangoClientLibLoader", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (TangoClientLibLoader); }
		}

		protected TangoClientLibLoader (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.google.atap.tango']/class[@name='TangoClientLibLoader']/constructor[@name='TangoClientLibLoader' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe TangoClientLibLoader ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (TangoClientLibLoader)) {
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

		static IntPtr id_getTangoClientApiArch;
		public static unsafe int TangoClientApiArch {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.atap.tango']/class[@name='TangoClientLibLoader']/method[@name='getTangoClientApiArch' and count(parameter)=0]"
			[Register ("getTangoClientApiArch", "()I", "GetGetTangoClientApiArchHandler")]
			get {
				if (id_getTangoClientApiArch == IntPtr.Zero)
					id_getTangoClientApiArch = JNIEnv.GetStaticMethodID (class_ref, "getTangoClientApiArch", "()I");
				try {
					return JNIEnv.CallStaticIntMethod  (class_ref, id_getTangoClientApiArch);
				} finally {
				}
			}
		}

		static IntPtr id_loadedSuccessfully;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.atap.tango']/class[@name='TangoClientLibLoader']/method[@name='loadedSuccessfully' and count(parameter)=0]"
		[Register ("loadedSuccessfully", "()Z", "")]
		public static unsafe bool LoadedSuccessfully ()
		{
			if (id_loadedSuccessfully == IntPtr.Zero)
				id_loadedSuccessfully = JNIEnv.GetStaticMethodID (class_ref, "loadedSuccessfully", "()Z");
			try {
				return JNIEnv.CallStaticBooleanMethod  (class_ref, id_loadedSuccessfully);
			} finally {
			}
		}

	}
}
