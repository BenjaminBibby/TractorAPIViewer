package crc64f73e13509ba16a35;


public class LoaderActivity
	extends crc64f73e13509ba16a35.BaseActivity
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onCreate:(Landroid/os/Bundle;)V:GetOnCreate_Landroid_os_Bundle_Handler\n" +
			"";
		mono.android.Runtime.register ("TractorAPIViewer.Activities.LoaderActivity, TractorAPIViewer", LoaderActivity.class, __md_methods);
	}


	public LoaderActivity ()
	{
		super ();
		if (getClass () == LoaderActivity.class)
			mono.android.TypeManager.Activate ("TractorAPIViewer.Activities.LoaderActivity, TractorAPIViewer", "", this, new java.lang.Object[] {  });
	}


	public void onCreate (android.os.Bundle p0)
	{
		n_onCreate (p0);
	}

	private native void n_onCreate (android.os.Bundle p0);

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
