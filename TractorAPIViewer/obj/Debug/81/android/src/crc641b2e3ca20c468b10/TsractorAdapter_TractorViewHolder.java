package crc641b2e3ca20c468b10;


public class TsractorAdapter_TractorViewHolder
	extends android.support.v7.widget.RecyclerView.ViewHolder
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"";
		mono.android.Runtime.register ("TractorAPIViewer.Adapters.TsractorAdapter+TractorViewHolder, TractorAPIViewer", TsractorAdapter_TractorViewHolder.class, __md_methods);
	}


	public TsractorAdapter_TractorViewHolder (android.view.View p0)
	{
		super (p0);
		if (getClass () == TsractorAdapter_TractorViewHolder.class)
			mono.android.TypeManager.Activate ("TractorAPIViewer.Adapters.TsractorAdapter+TractorViewHolder, TractorAPIViewer", "Android.Views.View, Mono.Android", this, new java.lang.Object[] { p0 });
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
