package md5ac6c7c6fc421f3eeb831509337bfd95c;


public class CallExtensions_ActionCallback
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer,
		okhttp3.Callback
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onFailure:(Lokhttp3/Call;Ljava/io/IOException;)V:GetOnFailure_Lokhttp3_Call_Ljava_io_IOException_Handler:Square.OkHttp3.ICallbackInvoker, Square.OkHttp3\n" +
			"n_onResponse:(Lokhttp3/Call;Lokhttp3/Response;)V:GetOnResponse_Lokhttp3_Call_Lokhttp3_Response_Handler:Square.OkHttp3.ICallbackInvoker, Square.OkHttp3\n" +
			"";
		mono.android.Runtime.register ("Square.OkHttp3.CallExtensions+ActionCallback, Square.OkHttp3, Version=3.8.0.0, Culture=neutral, PublicKeyToken=null", CallExtensions_ActionCallback.class, __md_methods);
	}


	public CallExtensions_ActionCallback ()
	{
		super ();
		if (getClass () == CallExtensions_ActionCallback.class)
			mono.android.TypeManager.Activate ("Square.OkHttp3.CallExtensions+ActionCallback, Square.OkHttp3, Version=3.8.0.0, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
	}


	public void onFailure (okhttp3.Call p0, java.io.IOException p1)
	{
		n_onFailure (p0, p1);
	}

	private native void n_onFailure (okhttp3.Call p0, java.io.IOException p1);


	public void onResponse (okhttp3.Call p0, okhttp3.Response p1)
	{
		n_onResponse (p0, p1);
	}

	private native void n_onResponse (okhttp3.Call p0, okhttp3.Response p1);

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
