package okhttp3;


public class OkHttpClient$Builder_InterceptorImpl
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer,
		okhttp3.Interceptor
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_intercept:(Lokhttp3/Interceptor$Chain;)Lokhttp3/Response;:GetIntercept_Lokhttp3_Interceptor_Chain_Handler:Square.OkHttp3.IInterceptorInvoker, Square.OkHttp3\n" +
			"";
		mono.android.Runtime.register ("Square.OkHttp3.OkHttpClient+Builder+InterceptorImpl, Square.OkHttp3, Version=3.8.0.0, Culture=neutral, PublicKeyToken=null", OkHttpClient$Builder_InterceptorImpl.class, __md_methods);
	}


	public OkHttpClient$Builder_InterceptorImpl ()
	{
		super ();
		if (getClass () == OkHttpClient$Builder_InterceptorImpl.class)
			mono.android.TypeManager.Activate ("Square.OkHttp3.OkHttpClient+Builder+InterceptorImpl, Square.OkHttp3, Version=3.8.0.0, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
	}


	public okhttp3.Response intercept (okhttp3.Interceptor.Chain p0)
	{
		return n_intercept (p0);
	}

	private native okhttp3.Response n_intercept (okhttp3.Interceptor.Chain p0);

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
