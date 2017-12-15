package okhttp3;


public class OkHttpClient$Builder_DnsImpl
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer,
		okhttp3.Dns
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_lookup:(Ljava/lang/String;)Ljava/util/List;:GetLookup_Ljava_lang_String_Handler:Square.OkHttp3.IDnsInvoker, Square.OkHttp3\n" +
			"";
		mono.android.Runtime.register ("Square.OkHttp3.OkHttpClient+Builder+DnsImpl, Square.OkHttp3, Version=3.8.0.0, Culture=neutral, PublicKeyToken=null", OkHttpClient$Builder_DnsImpl.class, __md_methods);
	}


	public OkHttpClient$Builder_DnsImpl ()
	{
		super ();
		if (getClass () == OkHttpClient$Builder_DnsImpl.class)
			mono.android.TypeManager.Activate ("Square.OkHttp3.OkHttpClient+Builder+DnsImpl, Square.OkHttp3, Version=3.8.0.0, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
	}


	public java.util.List lookup (java.lang.String p0)
	{
		return n_lookup (p0);
	}

	private native java.util.List n_lookup (java.lang.String p0);

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
