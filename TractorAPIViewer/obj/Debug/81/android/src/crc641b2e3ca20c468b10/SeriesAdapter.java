package crc641b2e3ca20c468b10;


public class SeriesAdapter
	extends crc641b2e3ca20c468b10.BaseAdapter_2
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"";
		mono.android.Runtime.register ("TractorAPIViewer.Adapters.SeriesAdapter, TractorAPIViewer", SeriesAdapter.class, __md_methods);
	}


	public SeriesAdapter ()
	{
		super ();
		if (getClass () == SeriesAdapter.class)
			mono.android.TypeManager.Activate ("TractorAPIViewer.Adapters.SeriesAdapter, TractorAPIViewer", "", this, new java.lang.Object[] {  });
	}

	public SeriesAdapter (int p0)
	{
		super ();
		if (getClass () == SeriesAdapter.class)
			mono.android.TypeManager.Activate ("TractorAPIViewer.Adapters.SeriesAdapter, TractorAPIViewer", "System.Int32, mscorlib", this, new java.lang.Object[] { p0 });
	}

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
