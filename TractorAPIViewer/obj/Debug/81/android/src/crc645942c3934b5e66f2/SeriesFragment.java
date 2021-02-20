package crc645942c3934b5e66f2;


public class SeriesFragment
	extends crc645942c3934b5e66f2.BaseFragment_1
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onResume:()V:GetOnResumeHandler\n" +
			"n_onPause:()V:GetOnPauseHandler\n" +
			"";
		mono.android.Runtime.register ("TractorAPIViewer.Fragments.SeriesFragment, TractorAPIViewer", SeriesFragment.class, __md_methods);
	}


	public SeriesFragment ()
	{
		super ();
		if (getClass () == SeriesFragment.class)
			mono.android.TypeManager.Activate ("TractorAPIViewer.Fragments.SeriesFragment, TractorAPIViewer", "", this, new java.lang.Object[] {  });
	}


	public void onResume ()
	{
		n_onResume ();
	}

	private native void n_onResume ();


	public void onPause ()
	{
		n_onPause ();
	}

	private native void n_onPause ();

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
