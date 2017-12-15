using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Mapbox.Services.Api {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.mapbox.services.api']/class[@name='MapboxService']"
	[global::Android.Runtime.Register ("com/mapbox/services/api/MapboxService", DoNotGenerateAcw=true)]
	[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
	public abstract partial class MapboxService : global::Java.Lang.Object {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/mapbox/services/api/MapboxService", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (MapboxService); }
		}

		protected MapboxService (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.mapbox.services.api']/class[@name='MapboxService']/constructor[@name='MapboxService' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe MapboxService ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (MapboxService)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "()V"),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
					return;
				}

				if (id_ctor == IntPtr.Zero)
					id_ctor = JNIEnv.GetMethodID (class_ref, "<init>", "()V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor);
			} finally {
			}
		}

		static Delegate cb_getCallFactory;
#pragma warning disable 0169
		static Delegate GetGetCallFactoryHandler ()
		{
			if (cb_getCallFactory == null)
				cb_getCallFactory = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetCallFactory);
			return cb_getCallFactory;
		}

		static IntPtr n_GetCallFactory (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mapbox.Services.Api.MapboxService __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Services.Api.MapboxService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.CallFactory);
		}
#pragma warning restore 0169

		static Delegate cb_setCallFactory_Lokhttp3_Call_Factory_;
#pragma warning disable 0169
		static Delegate GetSetCallFactory_Lokhttp3_Call_Factory_Handler ()
		{
			if (cb_setCallFactory_Lokhttp3_Call_Factory_ == null)
				cb_setCallFactory_Lokhttp3_Call_Factory_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetCallFactory_Lokhttp3_Call_Factory_);
			return cb_setCallFactory_Lokhttp3_Call_Factory_;
		}

		static void n_SetCallFactory_Lokhttp3_Call_Factory_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Mapbox.Services.Api.MapboxService __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Services.Api.MapboxService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Square.OkHttp3.ICallFactory p0 = (global::Square.OkHttp3.ICallFactory)global::Java.Lang.Object.GetObject<global::Square.OkHttp3.ICallFactory> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.CallFactory = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getCallFactory;
		static IntPtr id_setCallFactory_Lokhttp3_Call_Factory_;
		public virtual unsafe global::Square.OkHttp3.ICallFactory CallFactory {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.services.api']/class[@name='MapboxService']/method[@name='getCallFactory' and count(parameter)=0]"
			[Register ("getCallFactory", "()Lokhttp3/Call$Factory;", "GetGetCallFactoryHandler")]
			get {
				if (id_getCallFactory == IntPtr.Zero)
					id_getCallFactory = JNIEnv.GetMethodID (class_ref, "getCallFactory", "()Lokhttp3/Call$Factory;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Square.OkHttp3.ICallFactory> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getCallFactory), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Square.OkHttp3.ICallFactory> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getCallFactory", "()Lokhttp3/Call$Factory;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.services.api']/class[@name='MapboxService']/method[@name='setCallFactory' and count(parameter)=1 and parameter[1][@type='okhttp3.Call.Factory']]"
			[Register ("setCallFactory", "(Lokhttp3/Call$Factory;)V", "GetSetCallFactory_Lokhttp3_Call_Factory_Handler")]
			set {
				if (id_setCallFactory_Lokhttp3_Call_Factory_ == IntPtr.Zero)
					id_setCallFactory_Lokhttp3_Call_Factory_ = JNIEnv.GetMethodID (class_ref, "setCallFactory", "(Lokhttp3/Call$Factory;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setCallFactory_Lokhttp3_Call_Factory_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setCallFactory", "(Lokhttp3/Call$Factory;)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_isEnableDebug;
#pragma warning disable 0169
		static Delegate GetIsEnableDebugHandler ()
		{
			if (cb_isEnableDebug == null)
				cb_isEnableDebug = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsEnableDebug);
			return cb_isEnableDebug;
		}

		static bool n_IsEnableDebug (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mapbox.Services.Api.MapboxService __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Services.Api.MapboxService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.EnableDebug;
		}
#pragma warning restore 0169

		static Delegate cb_setEnableDebug_Z;
#pragma warning disable 0169
		static Delegate GetSetEnableDebug_ZHandler ()
		{
			if (cb_setEnableDebug_Z == null)
				cb_setEnableDebug_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetEnableDebug_Z);
			return cb_setEnableDebug_Z;
		}

		static void n_SetEnableDebug_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Com.Mapbox.Services.Api.MapboxService __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Services.Api.MapboxService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.EnableDebug = p0;
		}
#pragma warning restore 0169

		static IntPtr id_isEnableDebug;
		static IntPtr id_setEnableDebug_Z;
		public virtual unsafe bool EnableDebug {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.services.api']/class[@name='MapboxService']/method[@name='isEnableDebug' and count(parameter)=0]"
			[Register ("isEnableDebug", "()Z", "GetIsEnableDebugHandler")]
			get {
				if (id_isEnableDebug == IntPtr.Zero)
					id_isEnableDebug = JNIEnv.GetMethodID (class_ref, "isEnableDebug", "()Z");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isEnableDebug);
					else
						return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isEnableDebug", "()Z"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.services.api']/class[@name='MapboxService']/method[@name='setEnableDebug' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setEnableDebug", "(Z)V", "GetSetEnableDebug_ZHandler")]
			set {
				if (id_setEnableDebug_Z == IntPtr.Zero)
					id_setEnableDebug_Z = JNIEnv.GetMethodID (class_ref, "setEnableDebug", "(Z)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setEnableDebug_Z, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setEnableDebug", "(Z)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getOkHttpClient;
#pragma warning disable 0169
		static Delegate GetGetOkHttpClientHandler ()
		{
			if (cb_getOkHttpClient == null)
				cb_getOkHttpClient = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetOkHttpClient);
			return cb_getOkHttpClient;
		}

		static IntPtr n_GetOkHttpClient (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mapbox.Services.Api.MapboxService __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Services.Api.MapboxService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.OkHttpClient);
		}
#pragma warning restore 0169

		static IntPtr id_getOkHttpClient;
		public virtual unsafe global::Square.OkHttp3.OkHttpClient OkHttpClient {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.services.api']/class[@name='MapboxService']/method[@name='getOkHttpClient' and count(parameter)=0]"
			[Register ("getOkHttpClient", "()Lokhttp3/OkHttpClient;", "GetGetOkHttpClientHandler")]
			get {
				if (id_getOkHttpClient == IntPtr.Zero)
					id_getOkHttpClient = JNIEnv.GetMethodID (class_ref, "getOkHttpClient", "()Lokhttp3/OkHttpClient;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Square.OkHttp3.OkHttpClient> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getOkHttpClient), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Square.OkHttp3.OkHttpClient> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getOkHttpClient", "()Lokhttp3/OkHttpClient;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_cancelCall;
#pragma warning disable 0169
		static Delegate GetCancelCallHandler ()
		{
			if (cb_cancelCall == null)
				cb_cancelCall = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_CancelCall);
			return cb_cancelCall;
		}

		static void n_CancelCall (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mapbox.Services.Api.MapboxService __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Services.Api.MapboxService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.CancelCall ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.services.api']/class[@name='MapboxService']/method[@name='cancelCall' and count(parameter)=0]"
		[Register ("cancelCall", "()V", "GetCancelCallHandler")]
		public abstract void CancelCall ();

		static Delegate cb_cloneCall;
#pragma warning disable 0169
		static Delegate GetCloneCallHandler ()
		{
			if (cb_cloneCall == null)
				cb_cloneCall = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_CloneCall);
			return cb_cloneCall;
		}

		static IntPtr n_CloneCall (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mapbox.Services.Api.MapboxService __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Services.Api.MapboxService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.CloneCall ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.services.api']/class[@name='MapboxService']/method[@name='cloneCall' and count(parameter)=0]"
		[Register ("cloneCall", "()Lretrofit2/Call;", "GetCloneCallHandler")]
		public abstract global::Square.Retrofit2.ICall CloneCall ();

		static Delegate cb_enqueueCall_Lretrofit2_Callback_;
#pragma warning disable 0169
		static Delegate GetEnqueueCall_Lretrofit2_Callback_Handler ()
		{
			if (cb_enqueueCall_Lretrofit2_Callback_ == null)
				cb_enqueueCall_Lretrofit2_Callback_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_EnqueueCall_Lretrofit2_Callback_);
			return cb_enqueueCall_Lretrofit2_Callback_;
		}

		static void n_EnqueueCall_Lretrofit2_Callback_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Mapbox.Services.Api.MapboxService __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Services.Api.MapboxService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Square.Retrofit2.ICallback p0 = (global::Square.Retrofit2.ICallback)global::Java.Lang.Object.GetObject<global::Square.Retrofit2.ICallback> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.EnqueueCall (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.services.api']/class[@name='MapboxService']/method[@name='enqueueCall' and count(parameter)=1 and parameter[1][@type='retrofit2.Callback&lt;T&gt;']]"
		[Register ("enqueueCall", "(Lretrofit2/Callback;)V", "GetEnqueueCall_Lretrofit2_Callback_Handler")]
		public abstract void EnqueueCall (global::Square.Retrofit2.ICallback p0);

		static Delegate cb_executeCall;
#pragma warning disable 0169
		static Delegate GetExecuteCallHandler ()
		{
			if (cb_executeCall == null)
				cb_executeCall = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_ExecuteCall);
			return cb_executeCall;
		}

		static IntPtr n_ExecuteCall (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mapbox.Services.Api.MapboxService __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Services.Api.MapboxService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ExecuteCall ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.services.api']/class[@name='MapboxService']/method[@name='executeCall' and count(parameter)=0]"
		[Register ("executeCall", "()Lretrofit2/Response;", "GetExecuteCallHandler")]
		public abstract global::Square.Retrofit2.Response ExecuteCall ();

		static IntPtr id_getHeaderUserAgent_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.services.api']/class[@name='MapboxService']/method[@name='getHeaderUserAgent' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getHeaderUserAgent", "(Ljava/lang/String;)Ljava/lang/String;", "")]
		public static unsafe string GetHeaderUserAgent (string p0)
		{
			if (id_getHeaderUserAgent_Ljava_lang_String_ == IntPtr.Zero)
				id_getHeaderUserAgent_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "getHeaderUserAgent", "(Ljava/lang/String;)Ljava/lang/String;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_getHeaderUserAgent_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

	}

	[global::Android.Runtime.Register ("com/mapbox/services/api/MapboxService", DoNotGenerateAcw=true)]
	internal partial class MapboxServiceInvoker : MapboxService {

		public MapboxServiceInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		protected override global::System.Type ThresholdType {
			get { return typeof (MapboxServiceInvoker); }
		}

		static IntPtr id_cancelCall;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.services.api']/class[@name='MapboxService']/method[@name='cancelCall' and count(parameter)=0]"
		[Register ("cancelCall", "()V", "GetCancelCallHandler")]
		public override unsafe void CancelCall ()
		{
			if (id_cancelCall == IntPtr.Zero)
				id_cancelCall = JNIEnv.GetMethodID (class_ref, "cancelCall", "()V");
			try {
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_cancelCall);
			} finally {
			}
		}

		static IntPtr id_cloneCall;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.services.api']/class[@name='MapboxService']/method[@name='cloneCall' and count(parameter)=0]"
		[Register ("cloneCall", "()Lretrofit2/Call;", "GetCloneCallHandler")]
		public override unsafe global::Square.Retrofit2.ICall CloneCall ()
		{
			if (id_cloneCall == IntPtr.Zero)
				id_cloneCall = JNIEnv.GetMethodID (class_ref, "cloneCall", "()Lretrofit2/Call;");
			try {
				return global::Java.Lang.Object.GetObject<global::Square.Retrofit2.ICall> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_cloneCall), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_enqueueCall_Lretrofit2_Callback_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.services.api']/class[@name='MapboxService']/method[@name='enqueueCall' and count(parameter)=1 and parameter[1][@type='retrofit2.Callback&lt;T&gt;']]"
		[Register ("enqueueCall", "(Lretrofit2/Callback;)V", "GetEnqueueCall_Lretrofit2_Callback_Handler")]
		public override unsafe void EnqueueCall (global::Square.Retrofit2.ICallback p0)
		{
			if (id_enqueueCall_Lretrofit2_Callback_ == IntPtr.Zero)
				id_enqueueCall_Lretrofit2_Callback_ = JNIEnv.GetMethodID (class_ref, "enqueueCall", "(Lretrofit2/Callback;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_enqueueCall_Lretrofit2_Callback_, __args);
			} finally {
			}
		}

		static IntPtr id_executeCall;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.services.api']/class[@name='MapboxService']/method[@name='executeCall' and count(parameter)=0]"
		[Register ("executeCall", "()Lretrofit2/Response;", "GetExecuteCallHandler")]
		public override unsafe global::Square.Retrofit2.Response ExecuteCall ()
		{
			if (id_executeCall == IntPtr.Zero)
				id_executeCall = JNIEnv.GetMethodID (class_ref, "executeCall", "()Lretrofit2/Response;");
			try {
				return global::Java.Lang.Object.GetObject<global::Square.Retrofit2.Response> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_executeCall), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}

}
