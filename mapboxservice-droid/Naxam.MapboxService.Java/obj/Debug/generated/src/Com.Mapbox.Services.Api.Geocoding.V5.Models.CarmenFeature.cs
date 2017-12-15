using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Mapbox.Services.Api.Geocoding.V5.Models {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.mapbox.services.api.geocoding.v5.models']/class[@name='CarmenFeature']"
	[global::Android.Runtime.Register ("com/mapbox/services/api/geocoding/v5/models/CarmenFeature", DoNotGenerateAcw=true)]
	public partial class CarmenFeature : global::Com.Mapbox.Services.Commons.Geojson.Feature {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/mapbox/services/api/geocoding/v5/models/CarmenFeature", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (CarmenFeature); }
		}

		protected CarmenFeature (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.mapbox.services.api.geocoding.v5.models']/class[@name='CarmenFeature']/constructor[@name='CarmenFeature' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe CarmenFeature ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (CarmenFeature)) {
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

		static Delegate cb_getAddress;
#pragma warning disable 0169
		static Delegate GetGetAddressHandler ()
		{
			if (cb_getAddress == null)
				cb_getAddress = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetAddress);
			return cb_getAddress;
		}

		static IntPtr n_GetAddress (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mapbox.Services.Api.Geocoding.V5.Models.CarmenFeature __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Services.Api.Geocoding.V5.Models.CarmenFeature> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Address);
		}
#pragma warning restore 0169

		static Delegate cb_setAddress_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetAddress_Ljava_lang_String_Handler ()
		{
			if (cb_setAddress_Ljava_lang_String_ == null)
				cb_setAddress_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetAddress_Ljava_lang_String_);
			return cb_setAddress_Ljava_lang_String_;
		}

		static void n_SetAddress_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Mapbox.Services.Api.Geocoding.V5.Models.CarmenFeature __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Services.Api.Geocoding.V5.Models.CarmenFeature> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Address = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getAddress;
		static IntPtr id_setAddress_Ljava_lang_String_;
		public virtual unsafe string Address {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.services.api.geocoding.v5.models']/class[@name='CarmenFeature']/method[@name='getAddress' and count(parameter)=0]"
			[Register ("getAddress", "()Ljava/lang/String;", "GetGetAddressHandler")]
			get {
				if (id_getAddress == IntPtr.Zero)
					id_getAddress = JNIEnv.GetMethodID (class_ref, "getAddress", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getAddress), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getAddress", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.services.api.geocoding.v5.models']/class[@name='CarmenFeature']/method[@name='setAddress' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setAddress", "(Ljava/lang/String;)V", "GetSetAddress_Ljava_lang_String_Handler")]
			set {
				if (id_setAddress_Ljava_lang_String_ == IntPtr.Zero)
					id_setAddress_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setAddress", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setAddress_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setAddress", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getContext;
#pragma warning disable 0169
		static Delegate GetGetContextHandler ()
		{
			if (cb_getContext == null)
				cb_getContext = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetContext);
			return cb_getContext;
		}

		static IntPtr n_GetContext (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mapbox.Services.Api.Geocoding.V5.Models.CarmenFeature __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Services.Api.Geocoding.V5.Models.CarmenFeature> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList<global::Com.Mapbox.Services.Api.Geocoding.V5.Models.CarmenContext>.ToLocalJniHandle (__this.Context);
		}
#pragma warning restore 0169

		static Delegate cb_setContext_Ljava_util_List_;
#pragma warning disable 0169
		static Delegate GetSetContext_Ljava_util_List_Handler ()
		{
			if (cb_setContext_Ljava_util_List_ == null)
				cb_setContext_Ljava_util_List_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetContext_Ljava_util_List_);
			return cb_setContext_Ljava_util_List_;
		}

		static void n_SetContext_Ljava_util_List_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Mapbox.Services.Api.Geocoding.V5.Models.CarmenFeature __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Services.Api.Geocoding.V5.Models.CarmenFeature> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Android.Runtime.JavaList<global::Com.Mapbox.Services.Api.Geocoding.V5.Models.CarmenContext>.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Context = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getContext;
		static IntPtr id_setContext_Ljava_util_List_;
		public virtual unsafe global::System.Collections.Generic.IList<global::Com.Mapbox.Services.Api.Geocoding.V5.Models.CarmenContext> Context {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.services.api.geocoding.v5.models']/class[@name='CarmenFeature']/method[@name='getContext' and count(parameter)=0]"
			[Register ("getContext", "()Ljava/util/List;", "GetGetContextHandler")]
			get {
				if (id_getContext == IntPtr.Zero)
					id_getContext = JNIEnv.GetMethodID (class_ref, "getContext", "()Ljava/util/List;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Android.Runtime.JavaList<global::Com.Mapbox.Services.Api.Geocoding.V5.Models.CarmenContext>.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getContext), JniHandleOwnership.TransferLocalRef);
					else
						return global::Android.Runtime.JavaList<global::Com.Mapbox.Services.Api.Geocoding.V5.Models.CarmenContext>.FromJniHandle (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getContext", "()Ljava/util/List;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.services.api.geocoding.v5.models']/class[@name='CarmenFeature']/method[@name='setContext' and count(parameter)=1 and parameter[1][@type='java.util.List&lt;com.mapbox.services.api.geocoding.v5.models.CarmenContext&gt;']]"
			[Register ("setContext", "(Ljava/util/List;)V", "GetSetContext_Ljava_util_List_Handler")]
			set {
				if (id_setContext_Ljava_util_List_ == IntPtr.Zero)
					id_setContext_Ljava_util_List_ = JNIEnv.GetMethodID (class_ref, "setContext", "(Ljava/util/List;)V");
				IntPtr native_value = global::Android.Runtime.JavaList<global::Com.Mapbox.Services.Api.Geocoding.V5.Models.CarmenContext>.ToLocalJniHandle (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setContext_Ljava_util_List_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setContext", "(Ljava/util/List;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getLanguage;
#pragma warning disable 0169
		static Delegate GetGetLanguageHandler ()
		{
			if (cb_getLanguage == null)
				cb_getLanguage = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetLanguage);
			return cb_getLanguage;
		}

		static IntPtr n_GetLanguage (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mapbox.Services.Api.Geocoding.V5.Models.CarmenFeature __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Services.Api.Geocoding.V5.Models.CarmenFeature> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Language);
		}
#pragma warning restore 0169

		static Delegate cb_setLanguage_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetLanguage_Ljava_lang_String_Handler ()
		{
			if (cb_setLanguage_Ljava_lang_String_ == null)
				cb_setLanguage_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetLanguage_Ljava_lang_String_);
			return cb_setLanguage_Ljava_lang_String_;
		}

		static void n_SetLanguage_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Mapbox.Services.Api.Geocoding.V5.Models.CarmenFeature __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Services.Api.Geocoding.V5.Models.CarmenFeature> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Language = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getLanguage;
		static IntPtr id_setLanguage_Ljava_lang_String_;
		public virtual unsafe string Language {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.services.api.geocoding.v5.models']/class[@name='CarmenFeature']/method[@name='getLanguage' and count(parameter)=0]"
			[Register ("getLanguage", "()Ljava/lang/String;", "GetGetLanguageHandler")]
			get {
				if (id_getLanguage == IntPtr.Zero)
					id_getLanguage = JNIEnv.GetMethodID (class_ref, "getLanguage", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getLanguage), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getLanguage", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.services.api.geocoding.v5.models']/class[@name='CarmenFeature']/method[@name='setLanguage' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setLanguage", "(Ljava/lang/String;)V", "GetSetLanguage_Ljava_lang_String_Handler")]
			set {
				if (id_setLanguage_Ljava_lang_String_ == IntPtr.Zero)
					id_setLanguage_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setLanguage", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setLanguage_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setLanguage", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getMatchingPlaceName;
#pragma warning disable 0169
		static Delegate GetGetMatchingPlaceNameHandler ()
		{
			if (cb_getMatchingPlaceName == null)
				cb_getMatchingPlaceName = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetMatchingPlaceName);
			return cb_getMatchingPlaceName;
		}

		static IntPtr n_GetMatchingPlaceName (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mapbox.Services.Api.Geocoding.V5.Models.CarmenFeature __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Services.Api.Geocoding.V5.Models.CarmenFeature> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.MatchingPlaceName);
		}
#pragma warning restore 0169

		static Delegate cb_setMatchingPlaceName_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetMatchingPlaceName_Ljava_lang_String_Handler ()
		{
			if (cb_setMatchingPlaceName_Ljava_lang_String_ == null)
				cb_setMatchingPlaceName_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetMatchingPlaceName_Ljava_lang_String_);
			return cb_setMatchingPlaceName_Ljava_lang_String_;
		}

		static void n_SetMatchingPlaceName_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Mapbox.Services.Api.Geocoding.V5.Models.CarmenFeature __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Services.Api.Geocoding.V5.Models.CarmenFeature> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.MatchingPlaceName = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getMatchingPlaceName;
		static IntPtr id_setMatchingPlaceName_Ljava_lang_String_;
		public virtual unsafe string MatchingPlaceName {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.services.api.geocoding.v5.models']/class[@name='CarmenFeature']/method[@name='getMatchingPlaceName' and count(parameter)=0]"
			[Register ("getMatchingPlaceName", "()Ljava/lang/String;", "GetGetMatchingPlaceNameHandler")]
			get {
				if (id_getMatchingPlaceName == IntPtr.Zero)
					id_getMatchingPlaceName = JNIEnv.GetMethodID (class_ref, "getMatchingPlaceName", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getMatchingPlaceName), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getMatchingPlaceName", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.services.api.geocoding.v5.models']/class[@name='CarmenFeature']/method[@name='setMatchingPlaceName' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setMatchingPlaceName", "(Ljava/lang/String;)V", "GetSetMatchingPlaceName_Ljava_lang_String_Handler")]
			set {
				if (id_setMatchingPlaceName_Ljava_lang_String_ == IntPtr.Zero)
					id_setMatchingPlaceName_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setMatchingPlaceName", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setMatchingPlaceName_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setMatchingPlaceName", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getMatchingText;
#pragma warning disable 0169
		static Delegate GetGetMatchingTextHandler ()
		{
			if (cb_getMatchingText == null)
				cb_getMatchingText = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetMatchingText);
			return cb_getMatchingText;
		}

		static IntPtr n_GetMatchingText (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mapbox.Services.Api.Geocoding.V5.Models.CarmenFeature __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Services.Api.Geocoding.V5.Models.CarmenFeature> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.MatchingText);
		}
#pragma warning restore 0169

		static Delegate cb_setMatchingText_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetMatchingText_Ljava_lang_String_Handler ()
		{
			if (cb_setMatchingText_Ljava_lang_String_ == null)
				cb_setMatchingText_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetMatchingText_Ljava_lang_String_);
			return cb_setMatchingText_Ljava_lang_String_;
		}

		static void n_SetMatchingText_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Mapbox.Services.Api.Geocoding.V5.Models.CarmenFeature __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Services.Api.Geocoding.V5.Models.CarmenFeature> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.MatchingText = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getMatchingText;
		static IntPtr id_setMatchingText_Ljava_lang_String_;
		public virtual unsafe string MatchingText {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.services.api.geocoding.v5.models']/class[@name='CarmenFeature']/method[@name='getMatchingText' and count(parameter)=0]"
			[Register ("getMatchingText", "()Ljava/lang/String;", "GetGetMatchingTextHandler")]
			get {
				if (id_getMatchingText == IntPtr.Zero)
					id_getMatchingText = JNIEnv.GetMethodID (class_ref, "getMatchingText", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getMatchingText), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getMatchingText", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.services.api.geocoding.v5.models']/class[@name='CarmenFeature']/method[@name='setMatchingText' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setMatchingText", "(Ljava/lang/String;)V", "GetSetMatchingText_Ljava_lang_String_Handler")]
			set {
				if (id_setMatchingText_Ljava_lang_String_ == IntPtr.Zero)
					id_setMatchingText_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setMatchingText", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setMatchingText_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setMatchingText", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getPlaceName;
#pragma warning disable 0169
		static Delegate GetGetPlaceNameHandler ()
		{
			if (cb_getPlaceName == null)
				cb_getPlaceName = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetPlaceName);
			return cb_getPlaceName;
		}

		static IntPtr n_GetPlaceName (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mapbox.Services.Api.Geocoding.V5.Models.CarmenFeature __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Services.Api.Geocoding.V5.Models.CarmenFeature> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.PlaceName);
		}
#pragma warning restore 0169

		static Delegate cb_setPlaceName_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetPlaceName_Ljava_lang_String_Handler ()
		{
			if (cb_setPlaceName_Ljava_lang_String_ == null)
				cb_setPlaceName_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetPlaceName_Ljava_lang_String_);
			return cb_setPlaceName_Ljava_lang_String_;
		}

		static void n_SetPlaceName_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Mapbox.Services.Api.Geocoding.V5.Models.CarmenFeature __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Services.Api.Geocoding.V5.Models.CarmenFeature> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.PlaceName = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getPlaceName;
		static IntPtr id_setPlaceName_Ljava_lang_String_;
		public virtual unsafe string PlaceName {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.services.api.geocoding.v5.models']/class[@name='CarmenFeature']/method[@name='getPlaceName' and count(parameter)=0]"
			[Register ("getPlaceName", "()Ljava/lang/String;", "GetGetPlaceNameHandler")]
			get {
				if (id_getPlaceName == IntPtr.Zero)
					id_getPlaceName = JNIEnv.GetMethodID (class_ref, "getPlaceName", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getPlaceName), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getPlaceName", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.services.api.geocoding.v5.models']/class[@name='CarmenFeature']/method[@name='setPlaceName' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setPlaceName", "(Ljava/lang/String;)V", "GetSetPlaceName_Ljava_lang_String_Handler")]
			set {
				if (id_setPlaceName_Ljava_lang_String_ == IntPtr.Zero)
					id_setPlaceName_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setPlaceName", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setPlaceName_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setPlaceName", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getRelevance;
#pragma warning disable 0169
		static Delegate GetGetRelevanceHandler ()
		{
			if (cb_getRelevance == null)
				cb_getRelevance = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, double>) n_GetRelevance);
			return cb_getRelevance;
		}

		static double n_GetRelevance (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mapbox.Services.Api.Geocoding.V5.Models.CarmenFeature __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Services.Api.Geocoding.V5.Models.CarmenFeature> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Relevance;
		}
#pragma warning restore 0169

		static Delegate cb_setRelevance_D;
#pragma warning disable 0169
		static Delegate GetSetRelevance_DHandler ()
		{
			if (cb_setRelevance_D == null)
				cb_setRelevance_D = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, double>) n_SetRelevance_D);
			return cb_setRelevance_D;
		}

		static void n_SetRelevance_D (IntPtr jnienv, IntPtr native__this, double p0)
		{
			global::Com.Mapbox.Services.Api.Geocoding.V5.Models.CarmenFeature __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Services.Api.Geocoding.V5.Models.CarmenFeature> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Relevance = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getRelevance;
		static IntPtr id_setRelevance_D;
		public virtual unsafe double Relevance {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.services.api.geocoding.v5.models']/class[@name='CarmenFeature']/method[@name='getRelevance' and count(parameter)=0]"
			[Register ("getRelevance", "()D", "GetGetRelevanceHandler")]
			get {
				if (id_getRelevance == IntPtr.Zero)
					id_getRelevance = JNIEnv.GetMethodID (class_ref, "getRelevance", "()D");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallDoubleMethod (((global::Java.Lang.Object) this).Handle, id_getRelevance);
					else
						return JNIEnv.CallNonvirtualDoubleMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getRelevance", "()D"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.services.api.geocoding.v5.models']/class[@name='CarmenFeature']/method[@name='setRelevance' and count(parameter)=1 and parameter[1][@type='double']]"
			[Register ("setRelevance", "(D)V", "GetSetRelevance_DHandler")]
			set {
				if (id_setRelevance_D == IntPtr.Zero)
					id_setRelevance_D = JNIEnv.GetMethodID (class_ref, "setRelevance", "(D)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setRelevance_D, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setRelevance", "(D)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getText;
#pragma warning disable 0169
		static Delegate GetGetTextHandler ()
		{
			if (cb_getText == null)
				cb_getText = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetText);
			return cb_getText;
		}

		static IntPtr n_GetText (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mapbox.Services.Api.Geocoding.V5.Models.CarmenFeature __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Services.Api.Geocoding.V5.Models.CarmenFeature> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Text);
		}
#pragma warning restore 0169

		static Delegate cb_setText_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetText_Ljava_lang_String_Handler ()
		{
			if (cb_setText_Ljava_lang_String_ == null)
				cb_setText_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetText_Ljava_lang_String_);
			return cb_setText_Ljava_lang_String_;
		}

		static void n_SetText_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Mapbox.Services.Api.Geocoding.V5.Models.CarmenFeature __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Services.Api.Geocoding.V5.Models.CarmenFeature> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Text = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getText;
		static IntPtr id_setText_Ljava_lang_String_;
		public virtual unsafe string Text {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.services.api.geocoding.v5.models']/class[@name='CarmenFeature']/method[@name='getText' and count(parameter)=0]"
			[Register ("getText", "()Ljava/lang/String;", "GetGetTextHandler")]
			get {
				if (id_getText == IntPtr.Zero)
					id_getText = JNIEnv.GetMethodID (class_ref, "getText", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getText), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getText", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.services.api.geocoding.v5.models']/class[@name='CarmenFeature']/method[@name='setText' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setText", "(Ljava/lang/String;)V", "GetSetText_Ljava_lang_String_Handler")]
			set {
				if (id_setText_Ljava_lang_String_ == IntPtr.Zero)
					id_setText_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setText", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setText_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setText", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_asPosition;
#pragma warning disable 0169
		static Delegate GetAsPositionHandler ()
		{
			if (cb_asPosition == null)
				cb_asPosition = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_AsPosition);
			return cb_asPosition;
		}

		static IntPtr n_AsPosition (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mapbox.Services.Api.Geocoding.V5.Models.CarmenFeature __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Services.Api.Geocoding.V5.Models.CarmenFeature> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.AsPosition ());
		}
#pragma warning restore 0169

		static IntPtr id_asPosition;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.services.api.geocoding.v5.models']/class[@name='CarmenFeature']/method[@name='asPosition' and count(parameter)=0]"
		[Register ("asPosition", "()Lcom/mapbox/services/commons/models/Position;", "GetAsPositionHandler")]
		public virtual unsafe global::Com.Mapbox.Services.Commons.Models.Position AsPosition ()
		{
			if (id_asPosition == IntPtr.Zero)
				id_asPosition = JNIEnv.GetMethodID (class_ref, "asPosition", "()Lcom/mapbox/services/commons/models/Position;");
			try {

				if (((object) this).GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Services.Commons.Models.Position> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_asPosition), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Services.Commons.Models.Position> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "asPosition", "()Lcom/mapbox/services/commons/models/Position;")), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_fromJson_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.services.api.geocoding.v5.models']/class[@name='CarmenFeature']/method[@name='fromJson' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("fromJson", "(Ljava/lang/String;)Lcom/mapbox/services/api/geocoding/v5/models/CarmenFeature;", "")]
		public static unsafe global::Com.Mapbox.Services.Api.Geocoding.V5.Models.CarmenFeature FromJson (string p0)
		{
			if (id_fromJson_Ljava_lang_String_ == IntPtr.Zero)
				id_fromJson_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "fromJson", "(Ljava/lang/String;)Lcom/mapbox/services/api/geocoding/v5/models/CarmenFeature;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				global::Com.Mapbox.Services.Api.Geocoding.V5.Models.CarmenFeature __ret = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Services.Api.Geocoding.V5.Models.CarmenFeature> (JNIEnv.CallStaticObjectMethod  (class_ref, id_fromJson_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_getBbox;
#pragma warning disable 0169
		static Delegate GetGetBboxHandler ()
		{
			if (cb_getBbox == null)
				cb_getBbox = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetBbox);
			return cb_getBbox;
		}

		static IntPtr n_GetBbox (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mapbox.Services.Api.Geocoding.V5.Models.CarmenFeature __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Services.Api.Geocoding.V5.Models.CarmenFeature> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetBbox ());
		}
#pragma warning restore 0169

		static IntPtr id_getBbox;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.services.api.geocoding.v5.models']/class[@name='CarmenFeature']/method[@name='getBbox' and count(parameter)=0]"
		[Register ("getBbox", "()[D", "GetGetBboxHandler")]
		public virtual unsafe double[] GetBbox ()
		{
			if (id_getBbox == IntPtr.Zero)
				id_getBbox = JNIEnv.GetMethodID (class_ref, "getBbox", "()[D");
			try {

				if (((object) this).GetType () == ThresholdType)
					return (double[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getBbox), JniHandleOwnership.TransferLocalRef, typeof (double));
				else
					return (double[]) JNIEnv.GetArray (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getBbox", "()[D")), JniHandleOwnership.TransferLocalRef, typeof (double));
			} finally {
			}
		}

		static Delegate cb_getCenter;
#pragma warning disable 0169
		static Delegate GetGetCenterHandler ()
		{
			if (cb_getCenter == null)
				cb_getCenter = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetCenter);
			return cb_getCenter;
		}

		static IntPtr n_GetCenter (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mapbox.Services.Api.Geocoding.V5.Models.CarmenFeature __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Services.Api.Geocoding.V5.Models.CarmenFeature> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetCenter ());
		}
#pragma warning restore 0169

		static IntPtr id_getCenter;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.services.api.geocoding.v5.models']/class[@name='CarmenFeature']/method[@name='getCenter' and count(parameter)=0]"
		[Register ("getCenter", "()[D", "GetGetCenterHandler")]
		public virtual unsafe double[] GetCenter ()
		{
			if (id_getCenter == IntPtr.Zero)
				id_getCenter = JNIEnv.GetMethodID (class_ref, "getCenter", "()[D");
			try {

				if (((object) this).GetType () == ThresholdType)
					return (double[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getCenter), JniHandleOwnership.TransferLocalRef, typeof (double));
				else
					return (double[]) JNIEnv.GetArray (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getCenter", "()[D")), JniHandleOwnership.TransferLocalRef, typeof (double));
			} finally {
			}
		}

		static Delegate cb_getPlaceType;
#pragma warning disable 0169
		static Delegate GetGetPlaceTypeHandler ()
		{
			if (cb_getPlaceType == null)
				cb_getPlaceType = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetPlaceType);
			return cb_getPlaceType;
		}

		static IntPtr n_GetPlaceType (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mapbox.Services.Api.Geocoding.V5.Models.CarmenFeature __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Services.Api.Geocoding.V5.Models.CarmenFeature> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetPlaceType ());
		}
#pragma warning restore 0169

		static IntPtr id_getPlaceType;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.services.api.geocoding.v5.models']/class[@name='CarmenFeature']/method[@name='getPlaceType' and count(parameter)=0]"
		[Register ("getPlaceType", "()[Ljava/lang/String;", "GetGetPlaceTypeHandler")]
		public virtual unsafe string[] GetPlaceType ()
		{
			if (id_getPlaceType == IntPtr.Zero)
				id_getPlaceType = JNIEnv.GetMethodID (class_ref, "getPlaceType", "()[Ljava/lang/String;");
			try {

				if (((object) this).GetType () == ThresholdType)
					return (string[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getPlaceType), JniHandleOwnership.TransferLocalRef, typeof (string));
				else
					return (string[]) JNIEnv.GetArray (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getPlaceType", "()[Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef, typeof (string));
			} finally {
			}
		}

		static Delegate cb_setBbox_arrayD;
#pragma warning disable 0169
		static Delegate GetSetBbox_arrayDHandler ()
		{
			if (cb_setBbox_arrayD == null)
				cb_setBbox_arrayD = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetBbox_arrayD);
			return cb_setBbox_arrayD;
		}

		static void n_SetBbox_arrayD (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Mapbox.Services.Api.Geocoding.V5.Models.CarmenFeature __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Services.Api.Geocoding.V5.Models.CarmenFeature> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			double[] p0 = (double[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (double));
			__this.SetBbox (p0);
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
		}
#pragma warning restore 0169

		static IntPtr id_setBbox_arrayD;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.services.api.geocoding.v5.models']/class[@name='CarmenFeature']/method[@name='setBbox' and count(parameter)=1 and parameter[1][@type='double[]']]"
		[Register ("setBbox", "([D)V", "GetSetBbox_arrayDHandler")]
		public virtual unsafe void SetBbox (double[] p0)
		{
			if (id_setBbox_arrayD == IntPtr.Zero)
				id_setBbox_arrayD = JNIEnv.GetMethodID (class_ref, "setBbox", "([D)V");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setBbox_arrayD, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setBbox", "([D)V"), __args);
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}
		}

		static Delegate cb_setCenter_arrayD;
#pragma warning disable 0169
		static Delegate GetSetCenter_arrayDHandler ()
		{
			if (cb_setCenter_arrayD == null)
				cb_setCenter_arrayD = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetCenter_arrayD);
			return cb_setCenter_arrayD;
		}

		static void n_SetCenter_arrayD (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Mapbox.Services.Api.Geocoding.V5.Models.CarmenFeature __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Services.Api.Geocoding.V5.Models.CarmenFeature> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			double[] p0 = (double[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (double));
			__this.SetCenter (p0);
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
		}
#pragma warning restore 0169

		static IntPtr id_setCenter_arrayD;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.services.api.geocoding.v5.models']/class[@name='CarmenFeature']/method[@name='setCenter' and count(parameter)=1 and parameter[1][@type='double[]']]"
		[Register ("setCenter", "([D)V", "GetSetCenter_arrayDHandler")]
		public virtual unsafe void SetCenter (double[] p0)
		{
			if (id_setCenter_arrayD == IntPtr.Zero)
				id_setCenter_arrayD = JNIEnv.GetMethodID (class_ref, "setCenter", "([D)V");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setCenter_arrayD, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setCenter", "([D)V"), __args);
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}
		}

		static Delegate cb_setPlaceType_arrayLjava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetPlaceType_arrayLjava_lang_String_Handler ()
		{
			if (cb_setPlaceType_arrayLjava_lang_String_ == null)
				cb_setPlaceType_arrayLjava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetPlaceType_arrayLjava_lang_String_);
			return cb_setPlaceType_arrayLjava_lang_String_;
		}

		static void n_SetPlaceType_arrayLjava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Mapbox.Services.Api.Geocoding.V5.Models.CarmenFeature __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Services.Api.Geocoding.V5.Models.CarmenFeature> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string[] p0 = (string[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (string));
			__this.SetPlaceType (p0);
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
		}
#pragma warning restore 0169

		static IntPtr id_setPlaceType_arrayLjava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.services.api.geocoding.v5.models']/class[@name='CarmenFeature']/method[@name='setPlaceType' and count(parameter)=1 and parameter[1][@type='java.lang.String[]']]"
		[Register ("setPlaceType", "([Ljava/lang/String;)V", "GetSetPlaceType_arrayLjava_lang_String_Handler")]
		public virtual unsafe void SetPlaceType (string[] p0)
		{
			if (id_setPlaceType_arrayLjava_lang_String_ == IntPtr.Zero)
				id_setPlaceType_arrayLjava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setPlaceType", "([Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setPlaceType_arrayLjava_lang_String_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setPlaceType", "([Ljava/lang/String;)V"), __args);
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}
		}

	}
}
