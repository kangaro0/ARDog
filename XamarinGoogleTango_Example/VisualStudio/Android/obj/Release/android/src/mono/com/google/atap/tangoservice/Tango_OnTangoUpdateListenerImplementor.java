package mono.com.google.atap.tangoservice;


public class Tango_OnTangoUpdateListenerImplementor
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer,
		com.google.atap.tangoservice.Tango.OnTangoUpdateListener
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onFrameAvailable:(I)V:GetOnFrameAvailable_IHandler:Com.Google.Atap.Tangoservice.Tango/IOnTangoUpdateListenerInvoker, GoogleProjectTangoBinding\n" +
			"n_onPointCloudAvailable:(Lcom/google/atap/tangoservice/TangoPointCloudData;)V:GetOnPointCloudAvailable_Lcom_google_atap_tangoservice_TangoPointCloudData_Handler:Com.Google.Atap.Tangoservice.Tango/IOnTangoUpdateListenerInvoker, GoogleProjectTangoBinding\n" +
			"n_onPoseAvailable:(Lcom/google/atap/tangoservice/TangoPoseData;)V:GetOnPoseAvailable_Lcom_google_atap_tangoservice_TangoPoseData_Handler:Com.Google.Atap.Tangoservice.Tango/IOnTangoUpdateListenerInvoker, GoogleProjectTangoBinding\n" +
			"n_onTangoEvent:(Lcom/google/atap/tangoservice/TangoEvent;)V:GetOnTangoEvent_Lcom_google_atap_tangoservice_TangoEvent_Handler:Com.Google.Atap.Tangoservice.Tango/IOnTangoUpdateListenerInvoker, GoogleProjectTangoBinding\n" +
			"n_onXyzIjAvailable:(Lcom/google/atap/tangoservice/TangoXyzIjData;)V:GetOnXyzIjAvailable_Lcom_google_atap_tangoservice_TangoXyzIjData_Handler:Com.Google.Atap.Tangoservice.Tango/IOnTangoUpdateListenerInvoker, GoogleProjectTangoBinding\n" +
			"";
		mono.android.Runtime.register ("Com.Google.Atap.Tangoservice.Tango+IOnTangoUpdateListenerImplementor, GoogleProjectTangoBinding, Version=1.48.0.0, Culture=neutral, PublicKeyToken=null", Tango_OnTangoUpdateListenerImplementor.class, __md_methods);
	}


	public Tango_OnTangoUpdateListenerImplementor () throws java.lang.Throwable
	{
		super ();
		if (getClass () == Tango_OnTangoUpdateListenerImplementor.class)
			mono.android.TypeManager.Activate ("Com.Google.Atap.Tangoservice.Tango+IOnTangoUpdateListenerImplementor, GoogleProjectTangoBinding, Version=1.48.0.0, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
	}


	public void onFrameAvailable (int p0)
	{
		n_onFrameAvailable (p0);
	}

	private native void n_onFrameAvailable (int p0);


	public void onPointCloudAvailable (com.google.atap.tangoservice.TangoPointCloudData p0)
	{
		n_onPointCloudAvailable (p0);
	}

	private native void n_onPointCloudAvailable (com.google.atap.tangoservice.TangoPointCloudData p0);


	public void onPoseAvailable (com.google.atap.tangoservice.TangoPoseData p0)
	{
		n_onPoseAvailable (p0);
	}

	private native void n_onPoseAvailable (com.google.atap.tangoservice.TangoPoseData p0);


	public void onTangoEvent (com.google.atap.tangoservice.TangoEvent p0)
	{
		n_onTangoEvent (p0);
	}

	private native void n_onTangoEvent (com.google.atap.tangoservice.TangoEvent p0);


	public void onXyzIjAvailable (com.google.atap.tangoservice.TangoXyzIjData p0)
	{
		n_onXyzIjAvailable (p0);
	}

	private native void n_onXyzIjAvailable (com.google.atap.tangoservice.TangoXyzIjData p0);

	private java.util.ArrayList refList;
	public void monodroidAddReference (java.lang.Object obj)
	{
		if (refList == null)
			refList = new java.util.ArrayList ();
		refList.add (obj);
	}

	public void monodroidClearReferences ()
	{
		if (refList != null)
			refList.clear ();
	}
}
