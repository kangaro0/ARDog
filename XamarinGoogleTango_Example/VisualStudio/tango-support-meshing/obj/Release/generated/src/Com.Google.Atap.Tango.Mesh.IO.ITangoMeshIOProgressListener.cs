using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Google.Atap.Tango.Mesh.IO {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.google.atap.tango.mesh.io']/interface[@name='TangoMeshIOProgressListener']"
	[Register ("com/google/atap/tango/mesh/io/TangoMeshIOProgressListener", "", "Com.Google.Atap.Tango.Mesh.IO.ITangoMeshIOProgressListenerInvoker")]
	public partial interface ITangoMeshIOProgressListener : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.atap.tango.mesh.io']/interface[@name='TangoMeshIOProgressListener']/method[@name='onProgress' and count(parameter)=2 and parameter[1][@type='long'] and parameter[2][@type='long']]"
		[Register ("onProgress", "(JJ)V", "GetOnProgress_JJHandler:Com.Google.Atap.Tango.Mesh.IO.ITangoMeshIOProgressListenerInvoker, tango-support-meshing")]
		void OnProgress (long p0, long p1);

	}

	[global::Android.Runtime.Register ("com/google/atap/tango/mesh/io/TangoMeshIOProgressListener", DoNotGenerateAcw=true)]
	internal class ITangoMeshIOProgressListenerInvoker : global::Java.Lang.Object, ITangoMeshIOProgressListener {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/google/atap/tango/mesh/io/TangoMeshIOProgressListener");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ITangoMeshIOProgressListenerInvoker); }
		}

		IntPtr class_ref;

		public static ITangoMeshIOProgressListener GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<ITangoMeshIOProgressListener> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.google.atap.tango.mesh.io.TangoMeshIOProgressListener"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public ITangoMeshIOProgressListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_onProgress_JJ;
#pragma warning disable 0169
		static Delegate GetOnProgress_JJHandler ()
		{
			if (cb_onProgress_JJ == null)
				cb_onProgress_JJ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, long, long>) n_OnProgress_JJ);
			return cb_onProgress_JJ;
		}

		static void n_OnProgress_JJ (IntPtr jnienv, IntPtr native__this, long p0, long p1)
		{
			global::Com.Google.Atap.Tango.Mesh.IO.ITangoMeshIOProgressListener __this = global::Java.Lang.Object.GetObject<global::Com.Google.Atap.Tango.Mesh.IO.ITangoMeshIOProgressListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnProgress (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_onProgress_JJ;
		public unsafe void OnProgress (long p0, long p1)
		{
			if (id_onProgress_JJ == IntPtr.Zero)
				id_onProgress_JJ = JNIEnv.GetMethodID (class_ref, "onProgress", "(JJ)V");
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (p1);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onProgress_JJ, __args);
		}

	}

	public partial class TangoMeshIOProgressEventArgs : global::System.EventArgs {

		public TangoMeshIOProgressEventArgs (long p0, long p1)
		{
			this.p0 = p0;
			this.p1 = p1;
		}

		long p0;
		public long P0 {
			get { return p0; }
		}

		long p1;
		public long P1 {
			get { return p1; }
		}
	}

	[global::Android.Runtime.Register ("mono/com/google/atap/tango/mesh/io/TangoMeshIOProgressListenerImplementor")]
	internal sealed partial class ITangoMeshIOProgressListenerImplementor : global::Java.Lang.Object, ITangoMeshIOProgressListener {

		object sender;

		public ITangoMeshIOProgressListenerImplementor (object sender)
			: base (
				global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/google/atap/tango/mesh/io/TangoMeshIOProgressListenerImplementor", "()V"),
				JniHandleOwnership.TransferLocalRef)
		{
			global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
			this.sender = sender;
		}

#pragma warning disable 0649
		public EventHandler<TangoMeshIOProgressEventArgs> Handler;
#pragma warning restore 0649

		public void OnProgress (long p0, long p1)
		{
			var __h = Handler;
			if (__h != null)
				__h (sender, new TangoMeshIOProgressEventArgs (p0, p1));
		}

		internal static bool __IsEmpty (ITangoMeshIOProgressListenerImplementor value)
		{
			return value.Handler == null;
		}
	}

}
