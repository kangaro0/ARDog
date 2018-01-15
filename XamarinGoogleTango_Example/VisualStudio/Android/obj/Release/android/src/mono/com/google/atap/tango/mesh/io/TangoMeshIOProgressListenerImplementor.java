package mono.com.google.atap.tango.mesh.io;


public class TangoMeshIOProgressListenerImplementor
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer,
		com.google.atap.tango.mesh.io.TangoMeshIOProgressListener
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onProgress:(JJ)V:GetOnProgress_JJHandler:Com.Google.Atap.Tango.Mesh.IO.ITangoMeshIOProgressListenerInvoker, GoogleProjectTangoBinding\n" +
			"";
		mono.android.Runtime.register ("Com.Google.Atap.Tango.Mesh.IO.ITangoMeshIOProgressListenerImplementor, GoogleProjectTangoBinding, Version=1.48.0.0, Culture=neutral, PublicKeyToken=null", TangoMeshIOProgressListenerImplementor.class, __md_methods);
	}


	public TangoMeshIOProgressListenerImplementor () throws java.lang.Throwable
	{
		super ();
		if (getClass () == TangoMeshIOProgressListenerImplementor.class)
			mono.android.TypeManager.Activate ("Com.Google.Atap.Tango.Mesh.IO.ITangoMeshIOProgressListenerImplementor, GoogleProjectTangoBinding, Version=1.48.0.0, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
	}


	public void onProgress (long p0, long p1)
	{
		n_onProgress (p0, p1);
	}

	private native void n_onProgress (long p0, long p1);

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
