package okhttp3;


public class OkHttpClient$Builder_AuthenticatorImpl
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer,
		okhttp3.Authenticator
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_authenticate:(Lokhttp3/Route;Lokhttp3/Response;)Lokhttp3/Request;:GetAuthenticate_Lokhttp3_Route_Lokhttp3_Response_Handler:Square.OkHttp3.IAuthenticatorInvoker, Square.OkHttp3\n" +
			"";
		mono.android.Runtime.register ("Square.OkHttp3.OkHttpClient+Builder+AuthenticatorImpl, Square.OkHttp3, Version=3.8.0.0, Culture=neutral, PublicKeyToken=null", OkHttpClient$Builder_AuthenticatorImpl.class, __md_methods);
	}


	public OkHttpClient$Builder_AuthenticatorImpl ()
	{
		super ();
		if (getClass () == OkHttpClient$Builder_AuthenticatorImpl.class)
			mono.android.TypeManager.Activate ("Square.OkHttp3.OkHttpClient+Builder+AuthenticatorImpl, Square.OkHttp3, Version=3.8.0.0, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
	}


	public okhttp3.Request authenticate (okhttp3.Route p0, okhttp3.Response p1)
	{
		return n_authenticate (p0, p1);
	}

	private native okhttp3.Request n_authenticate (okhttp3.Route p0, okhttp3.Response p1);

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
