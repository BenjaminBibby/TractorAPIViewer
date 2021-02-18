package crc641b2e3ca20c468b10;


public class BrandsViewHolder
	extends crc641b2e3ca20c468b10.BaseAdapterViewHolder_1
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"";
		mono.android.Runtime.register ("TractorAPIViewer.Adapters.BrandsViewHolder, TractorAPIViewer", BrandsViewHolder.class, __md_methods);
	}


	public BrandsViewHolder (android.view.View p0)
	{
		super (p0);
		if (getClass () == BrandsViewHolder.class)
			mono.android.TypeManager.Activate ("TractorAPIViewer.Adapters.BrandsViewHolder, TractorAPIViewer", "Android.Views.View, Mono.Android", this, new java.lang.Object[] { p0 });
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
