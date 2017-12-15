using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Mapbox.Services.Api {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.mapbox.services.api']/class[@name='MapboxBuilder']"
	[global::Android.Runtime.Register ("com/mapbox/services/api/MapboxBuilder", DoNotGenerateAcw=true)]
	public abstract partial class MapboxBuilder : global::Java.Lang.Object {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/mapbox/services/api/MapboxBuilder", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (MapboxBuilder); }
		}

		protected MapboxBuilder (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.mapbox.services.api']/class[@name='MapboxBuilder']/constructor[@name='MapboxBuilder' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe MapboxBuilder ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (MapboxBuilder)) {
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

		static Delegate cb_getAccessToken;
#pragma warning disable 0169
		static Delegate GetGetAccessTokenHandler ()
		{
			if (cb_getAccessToken == null)
				cb_getAccessToken = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetAccessToken);
			return cb_getAccessToken;
		}

		static IntPtr n_GetAccessToken (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mapbox.Services.Api.MapboxBuilder __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Services.Api.MapboxBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.AccessToken);
		}
#pragma warning restore 0169

		public abstract string AccessToken {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.services.api']/class[@name='MapboxBuilder']/method[@name='getAccessToken' and count(parameter)=0]"
			[Register ("getAccessToken", "()Ljava/lang/String;", "GetGetAccessTokenHandler")] get;
		}

		static Delegate cb_getBaseUrl;
#pragma warning disable 0169
		static Delegate GetGetBaseUrlHandler ()
		{
			if (cb_getBaseUrl == null)
				cb_getBaseUrl = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetBaseUrl);
			return cb_getBaseUrl;
		}

		static IntPtr n_GetBaseUrl (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mapbox.Services.Api.MapboxBuilder __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Services.Api.MapboxBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.BaseUrl);
		}
#pragma warning restore 0169

		static IntPtr id_getBaseUrl;
		public virtual unsafe string BaseUrl {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.services.api']/class[@name='MapboxBuilder']/method[@name='getBaseUrl' and count(parameter)=0]"
			[Register ("getBaseUrl", "()Ljava/lang/String;", "GetGetBaseUrlHandler")]
			get {
				if (id_getBaseUrl == IntPtr.Zero)
					id_getBaseUrl = JNIEnv.GetMethodID (class_ref, "getBaseUrl", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getBaseUrl), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getBaseUrl", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getClientAppName;
#pragma warning disable 0169
		static Delegate GetGetClientAppNameHandler ()
		{
			if (cb_getClientAppName == null)
				cb_getClientAppName = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetClientAppName);
			return cb_getClientAppName;
		}

		static IntPtr n_GetClientAppName (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mapbox.Services.Api.MapboxBuilder __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Services.Api.MapboxBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.ClientAppName);
		}
#pragma warning restore 0169

		static IntPtr id_getClientAppName;
		public virtual unsafe string ClientAppName {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.services.api']/class[@name='MapboxBuilder']/method[@name='getClientAppName' and count(parameter)=0]"
			[Register ("getClientAppName", "()Ljava/lang/String;", "GetGetClientAppNameHandler")]
			get {
				if (id_getClientAppName == IntPtr.Zero)
					id_getClientAppName = JNIEnv.GetMethodID (class_ref, "getClientAppName", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getClientAppName), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getClientAppName", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_build;
#pragma warning disable 0169
		static Delegate GetBuildHandler ()
		{
			if (cb_build == null)
				cb_build = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_Build);
			return cb_build;
		}

		static IntPtr n_Build (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mapbox.Services.Api.MapboxBuilder __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Services.Api.MapboxBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Build ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.services.api']/class[@name='MapboxBuilder']/method[@name='build' and count(parameter)=0]"
		[Register ("build", "()Ljava/lang/Object;", "GetBuildHandler")]
		public abstract global::Java.Lang.Object Build ();

		static Delegate cb_setAccessToken_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetAccessToken_Ljava_lang_String_Handler ()
		{
			if (cb_setAccessToken_Ljava_lang_String_ == null)
				cb_setAccessToken_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetAccessToken_Ljava_lang_String_);
			return cb_setAccessToken_Ljava_lang_String_;
		}

		static IntPtr n_SetAccessToken_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Mapbox.Services.Api.MapboxBuilder __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Services.Api.MapboxBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetAccessToken (p0));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.services.api']/class[@name='MapboxBuilder']/method[@name='setAccessToken' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setAccessToken", "(Ljava/lang/String;)Lcom/mapbox/services/api/MapboxBuilder;", "GetSetAccessToken_Ljava_lang_String_Handler")]
		public abstract global::Com.Mapbox.Services.Api.MapboxBuilder SetAccessToken (string p0);

		static Delegate cb_setBaseUrl_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetBaseUrl_Ljava_lang_String_Handler ()
		{
			if (cb_setBaseUrl_Ljava_lang_String_ == null)
				cb_setBaseUrl_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetBaseUrl_Ljava_lang_String_);
			return cb_setBaseUrl_Ljava_lang_String_;
		}

		static IntPtr n_SetBaseUrl_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Mapbox.Services.Api.MapboxBuilder __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Services.Api.MapboxBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetBaseUrl (p0));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.services.api']/class[@name='MapboxBuilder']/method[@name='setBaseUrl' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setBaseUrl", "(Ljava/lang/String;)Lcom/mapbox/services/api/MapboxBuilder;", "GetSetBaseUrl_Ljava_lang_String_Handler")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T extends com.mapbox.services.api.MapboxBuilder"})]
		public abstract global::Java.Lang.Object SetBaseUrl (string p0);

		static Delegate cb_setClientAppName_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetClientAppName_Ljava_lang_String_Handler ()
		{
			if (cb_setClientAppName_Ljava_lang_String_ == null)
				cb_setClientAppName_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetClientAppName_Ljava_lang_String_);
			return cb_setClientAppName_Ljava_lang_String_;
		}

		static IntPtr n_SetClientAppName_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Mapbox.Services.Api.MapboxBuilder __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Services.Api.MapboxBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetClientAppName (p0));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.services.api']/class[@name='MapboxBuilder']/method[@name='setClientAppName' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setClientAppName", "(Ljava/lang/String;)Lcom/mapbox/services/api/MapboxBuilder;", "GetSetClientAppName_Ljava_lang_String_Handler")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T extends com.mapbox.services.api.MapboxBuilder"})]
		public abstract global::Java.Lang.Object SetClientAppName (string p0);

		static Delegate cb_validateAccessToken_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetValidateAccessToken_Ljava_lang_String_Handler ()
		{
			if (cb_validateAccessToken_Ljava_lang_String_ == null)
				cb_validateAccessToken_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_ValidateAccessToken_Ljava_lang_String_);
			return cb_validateAccessToken_Ljava_lang_String_;
		}

		static void n_ValidateAccessToken_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Mapbox.Services.Api.MapboxBuilder __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Services.Api.MapboxBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.ValidateAccessToken (p0);
		}
#pragma warning restore 0169

		static IntPtr id_validateAccessToken_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.services.api']/class[@name='MapboxBuilder']/method[@name='validateAccessToken' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("validateAccessToken", "(Ljava/lang/String;)V", "GetValidateAccessToken_Ljava_lang_String_Handler")]
		protected virtual unsafe void ValidateAccessToken (string p0)
		{
			if (id_validateAccessToken_Ljava_lang_String_ == IntPtr.Zero)
				id_validateAccessToken_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "validateAccessToken", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_validateAccessToken_Ljava_lang_String_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "validateAccessToken", "(Ljava/lang/String;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

	}

	[global::Android.Runtime.Register ("com/mapbox/services/api/MapboxBuilder", DoNotGenerateAcw=true)]
	internal partial class MapboxBuilderInvoker : MapboxBuilder {

		public MapboxBuilderInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		protected override global::System.Type ThresholdType {
			get { return typeof (MapboxBuilderInvoker); }
		}

		static IntPtr id_getAccessToken;
		public override unsafe string AccessToken {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.services.api']/class[@name='MapboxBuilder']/method[@name='getAccessToken' and count(parameter)=0]"
			[Register ("getAccessToken", "()Ljava/lang/String;", "GetGetAccessTokenHandler")]
			get {
				if (id_getAccessToken == IntPtr.Zero)
					id_getAccessToken = JNIEnv.GetMethodID (class_ref, "getAccessToken", "()Ljava/lang/String;");
				try {
					return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getAccessToken), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_build;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.services.api']/class[@name='MapboxBuilder']/method[@name='build' and count(parameter)=0]"
		[Register ("build", "()Ljava/lang/Object;", "GetBuildHandler")]
		public override unsafe global::Java.Lang.Object Build ()
		{
			if (id_build == IntPtr.Zero)
				id_build = JNIEnv.GetMethodID (class_ref, "build", "()Ljava/lang/Object;");
			try {
				return global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_build), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_setAccessToken_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.services.api']/class[@name='MapboxBuilder']/method[@name='setAccessToken' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setAccessToken", "(Ljava/lang/String;)Lcom/mapbox/services/api/MapboxBuilder;", "GetSetAccessToken_Ljava_lang_String_Handler")]
		public override unsafe global::Com.Mapbox.Services.Api.MapboxBuilder SetAccessToken (string p0)
		{
			if (id_setAccessToken_Ljava_lang_String_ == IntPtr.Zero)
				id_setAccessToken_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setAccessToken", "(Ljava/lang/String;)Lcom/mapbox/services/api/MapboxBuilder;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				global::Com.Mapbox.Services.Api.MapboxBuilder __ret = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Services.Api.MapboxBuilder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_setAccessToken_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_setBaseUrl_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.services.api']/class[@name='MapboxBuilder']/method[@name='setBaseUrl' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setBaseUrl", "(Ljava/lang/String;)Lcom/mapbox/services/api/MapboxBuilder;", "GetSetBaseUrl_Ljava_lang_String_Handler")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T extends com.mapbox.services.api.MapboxBuilder"})]
		public override unsafe global::Java.Lang.Object SetBaseUrl (string p0)
		{
			if (id_setBaseUrl_Ljava_lang_String_ == IntPtr.Zero)
				id_setBaseUrl_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setBaseUrl", "(Ljava/lang/String;)Lcom/mapbox/services/api/MapboxBuilder;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				global::Java.Lang.Object __ret = (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_setBaseUrl_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_setClientAppName_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.services.api']/class[@name='MapboxBuilder']/method[@name='setClientAppName' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setClientAppName", "(Ljava/lang/String;)Lcom/mapbox/services/api/MapboxBuilder;", "GetSetClientAppName_Ljava_lang_String_Handler")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T extends com.mapbox.services.api.MapboxBuilder"})]
		public override unsafe global::Java.Lang.Object SetClientAppName (string p0)
		{
			if (id_setClientAppName_Ljava_lang_String_ == IntPtr.Zero)
				id_setClientAppName_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setClientAppName", "(Ljava/lang/String;)Lcom/mapbox/services/api/MapboxBuilder;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				global::Java.Lang.Object __ret = (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_setClientAppName_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

	}

}
