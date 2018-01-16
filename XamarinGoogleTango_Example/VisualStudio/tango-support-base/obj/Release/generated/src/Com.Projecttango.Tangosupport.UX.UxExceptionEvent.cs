using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Projecttango.Tangosupport.UX {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.projecttango.tangosupport.ux']/class[@name='UxExceptionEvent']"
	[global::Android.Runtime.Register ("com/projecttango/tangosupport/ux/UxExceptionEvent", DoNotGenerateAcw=true)]
	public partial class UxExceptionEvent : global::Java.Lang.Object {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.projecttango.tangosupport.ux']/class[@name='UxExceptionEvent']/field[@name='STATUS_DETECTED']"
		[Register ("STATUS_DETECTED")]
		public const int StatusDetected = (int) 1;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.projecttango.tangosupport.ux']/class[@name='UxExceptionEvent']/field[@name='STATUS_RESOLVED']"
		[Register ("STATUS_RESOLVED")]
		public const int StatusResolved = (int) 0;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.projecttango.tangosupport.ux']/class[@name='UxExceptionEvent']/field[@name='TYPE_COLOR_CAMERA_OVER_EXPOSED']"
		[Register ("TYPE_COLOR_CAMERA_OVER_EXPOSED")]
		public const int TypeColorCameraOverExposed = (int) 13;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.projecttango.tangosupport.ux']/class[@name='UxExceptionEvent']/field[@name='TYPE_COLOR_CAMERA_UNDER_EXPOSED']"
		[Register ("TYPE_COLOR_CAMERA_UNDER_EXPOSED")]
		public const int TypeColorCameraUnderExposed = (int) 14;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.projecttango.tangosupport.ux']/class[@name='UxExceptionEvent']/field[@name='TYPE_FEW_DEPTH_POINTS']"
		[Register ("TYPE_FEW_DEPTH_POINTS")]
		public const int TypeFewDepthPoints = (int) 4;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.projecttango.tangosupport.ux']/class[@name='UxExceptionEvent']/field[@name='TYPE_FEW_FEATURES']"
		[Register ("TYPE_FEW_FEATURES")]
		public const int TypeFewFeatures = (int) 3;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.projecttango.tangosupport.ux']/class[@name='UxExceptionEvent']/field[@name='TYPE_FISHEYE_CAMERA_OVER_EXPOSED']"
		[Register ("TYPE_FISHEYE_CAMERA_OVER_EXPOSED")]
		public const int TypeFisheyeCameraOverExposed = (int) 11;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.projecttango.tangosupport.ux']/class[@name='UxExceptionEvent']/field[@name='TYPE_FISHEYE_CAMERA_UNDER_EXPOSED']"
		[Register ("TYPE_FISHEYE_CAMERA_UNDER_EXPOSED")]
		public const int TypeFisheyeCameraUnderExposed = (int) 12;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.projecttango.tangosupport.ux']/class[@name='UxExceptionEvent']/field[@name='TYPE_HOLD_POSTURE']"
		[Register ("TYPE_HOLD_POSTURE")]
		public const int TypeHoldPosture = (int) 10;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.projecttango.tangosupport.ux']/class[@name='UxExceptionEvent']/field[@name='TYPE_LYING_ON_SURFACE']"
		[Register ("TYPE_LYING_ON_SURFACE")]
		public const int TypeLyingOnSurface = (int) 5;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.projecttango.tangosupport.ux']/class[@name='UxExceptionEvent']/field[@name='TYPE_MOTION_TRACK_INVALID']"
		[Register ("TYPE_MOTION_TRACK_INVALID")]
		public const int TypeMotionTrackInvalid = (int) 6;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.projecttango.tangosupport.ux']/class[@name='UxExceptionEvent']/field[@name='TYPE_MOVING_TOO_FAST']"
		[Register ("TYPE_MOVING_TOO_FAST")]
		public const int TypeMovingTooFast = (int) 2;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.projecttango.tangosupport.ux']/class[@name='UxExceptionEvent']/field[@name='TYPE_OVER_EXPOSED']"
		[Register ("TYPE_OVER_EXPOSED")]
		[Obsolete ("deprecated")]
		public const int TypeOverExposed = (int) 0;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.projecttango.tangosupport.ux']/class[@name='UxExceptionEvent']/field[@name='TYPE_UNDER_EXPOSED']"
		[Register ("TYPE_UNDER_EXPOSED")]
		[Obsolete ("deprecated")]
		public const int TypeUnderExposed = (int) 1;
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/projecttango/tangosupport/ux/UxExceptionEvent", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (UxExceptionEvent); }
		}

		protected UxExceptionEvent (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static Delegate cb_getStatus;
#pragma warning disable 0169
		static Delegate GetGetStatusHandler ()
		{
			if (cb_getStatus == null)
				cb_getStatus = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetStatus);
			return cb_getStatus;
		}

		static int n_GetStatus (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Projecttango.Tangosupport.UX.UxExceptionEvent __this = global::Java.Lang.Object.GetObject<global::Com.Projecttango.Tangosupport.UX.UxExceptionEvent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Status;
		}
#pragma warning restore 0169

		static Delegate cb_setStatus_I;
#pragma warning disable 0169
		static Delegate GetSetStatus_IHandler ()
		{
			if (cb_setStatus_I == null)
				cb_setStatus_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetStatus_I);
			return cb_setStatus_I;
		}

		static void n_SetStatus_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Projecttango.Tangosupport.UX.UxExceptionEvent __this = global::Java.Lang.Object.GetObject<global::Com.Projecttango.Tangosupport.UX.UxExceptionEvent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Status = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getStatus;
		static IntPtr id_setStatus_I;
		public virtual unsafe int Status {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.projecttango.tangosupport.ux']/class[@name='UxExceptionEvent']/method[@name='getStatus' and count(parameter)=0]"
			[Register ("getStatus", "()I", "GetGetStatusHandler")]
			get {
				if (id_getStatus == IntPtr.Zero)
					id_getStatus = JNIEnv.GetMethodID (class_ref, "getStatus", "()I");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getStatus);
					else
						return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getStatus", "()I"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.projecttango.tangosupport.ux']/class[@name='UxExceptionEvent']/method[@name='setStatus' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setStatus", "(I)V", "GetSetStatus_IHandler")]
			set {
				if (id_setStatus_I == IntPtr.Zero)
					id_setStatus_I = JNIEnv.GetMethodID (class_ref, "setStatus", "(I)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setStatus_I, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setStatus", "(I)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getType;
#pragma warning disable 0169
		static Delegate GetGetTypeHandler ()
		{
			if (cb_getType == null)
				cb_getType = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetType);
			return cb_getType;
		}

		static int n_GetType (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Projecttango.Tangosupport.UX.UxExceptionEvent __this = global::Java.Lang.Object.GetObject<global::Com.Projecttango.Tangosupport.UX.UxExceptionEvent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Type;
		}
#pragma warning restore 0169

		static IntPtr id_getType;
		public virtual unsafe int Type {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.projecttango.tangosupport.ux']/class[@name='UxExceptionEvent']/method[@name='getType' and count(parameter)=0]"
			[Register ("getType", "()I", "GetGetTypeHandler")]
			get {
				if (id_getType == IntPtr.Zero)
					id_getType = JNIEnv.GetMethodID (class_ref, "getType", "()I");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getType);
					else
						return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getType", "()I"));
				} finally {
				}
			}
		}

		static Delegate cb_getValue;
#pragma warning disable 0169
		static Delegate GetGetValueHandler ()
		{
			if (cb_getValue == null)
				cb_getValue = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float>) n_GetValue);
			return cb_getValue;
		}

		static float n_GetValue (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Projecttango.Tangosupport.UX.UxExceptionEvent __this = global::Java.Lang.Object.GetObject<global::Com.Projecttango.Tangosupport.UX.UxExceptionEvent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Value;
		}
#pragma warning restore 0169

		static IntPtr id_getValue;
		public virtual unsafe float Value {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.projecttango.tangosupport.ux']/class[@name='UxExceptionEvent']/method[@name='getValue' and count(parameter)=0]"
			[Register ("getValue", "()F", "GetGetValueHandler")]
			get {
				if (id_getValue == IntPtr.Zero)
					id_getValue = JNIEnv.GetMethodID (class_ref, "getValue", "()F");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallFloatMethod (((global::Java.Lang.Object) this).Handle, id_getValue);
					else
						return JNIEnv.CallNonvirtualFloatMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getValue", "()F"));
				} finally {
				}
			}
		}

	}
}
