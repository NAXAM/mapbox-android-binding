using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Mapbox.Services.Api.Geocoding.V5.Models {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.mapbox.services.api.geocoding.v5.models']/class[@name='CarmenFeatureCollection']"
	[global::Android.Runtime.Register ("com/mapbox/services/api/geocoding/v5/models/CarmenFeatureCollection", DoNotGenerateAcw=true)]
	public partial class CarmenFeatureCollection : global::Com.Mapbox.Services.Commons.Geojson.BaseFeatureCollection {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/mapbox/services/api/geocoding/v5/models/CarmenFeatureCollection", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (CarmenFeatureCollection); }
		}

		protected CarmenFeatureCollection (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.mapbox.services.api.geocoding.v5.models']/class[@name='CarmenFeatureCollection']/constructor[@name='CarmenFeatureCollection' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe CarmenFeatureCollection ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (CarmenFeatureCollection)) {
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

		static IntPtr id_ctor_Ljava_util_List_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.mapbox.services.api.geocoding.v5.models']/class[@name='CarmenFeatureCollection']/constructor[@name='CarmenFeatureCollection' and count(parameter)=1 and parameter[1][@type='java.util.List&lt;com.mapbox.services.api.geocoding.v5.models.CarmenFeature&gt;']]"
		[Register (".ctor", "(Ljava/util/List;)V", "")]
		protected unsafe CarmenFeatureCollection (global::System.Collections.Generic.IList<global::Com.Mapbox.Services.Api.Geocoding.V5.Models.CarmenFeature> p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_p0 = global::Android.Runtime.JavaList<global::Com.Mapbox.Services.Api.Geocoding.V5.Models.CarmenFeature>.ToLocalJniHandle (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				if (((object) this).GetType () != typeof (CarmenFeatureCollection)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Ljava/util/List;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Ljava/util/List;)V", __args);
					return;
				}

				if (id_ctor_Ljava_util_List_ == IntPtr.Zero)
					id_ctor_Ljava_util_List_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/util/List;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_util_List_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Ljava_util_List_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_getAttribution;
#pragma warning disable 0169
		static Delegate GetGetAttributionHandler ()
		{
			if (cb_getAttribution == null)
				cb_getAttribution = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetAttribution);
			return cb_getAttribution;
		}

		static IntPtr n_GetAttribution (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mapbox.Services.Api.Geocoding.V5.Models.CarmenFeatureCollection __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Services.Api.Geocoding.V5.Models.CarmenFeatureCollection> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Attribution);
		}
#pragma warning restore 0169

		static Delegate cb_setAttribution_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetAttribution_Ljava_lang_String_Handler ()
		{
			if (cb_setAttribution_Ljava_lang_String_ == null)
				cb_setAttribution_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetAttribution_Ljava_lang_String_);
			return cb_setAttribution_Ljava_lang_String_;
		}

		static void n_SetAttribution_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Mapbox.Services.Api.Geocoding.V5.Models.CarmenFeatureCollection __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Services.Api.Geocoding.V5.Models.CarmenFeatureCollection> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Attribution = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getAttribution;
		static IntPtr id_setAttribution_Ljava_lang_String_;
		public virtual unsafe string Attribution {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.services.api.geocoding.v5.models']/class[@name='CarmenFeatureCollection']/method[@name='getAttribution' and count(parameter)=0]"
			[Register ("getAttribution", "()Ljava/lang/String;", "GetGetAttributionHandler")]
			get {
				if (id_getAttribution == IntPtr.Zero)
					id_getAttribution = JNIEnv.GetMethodID (class_ref, "getAttribution", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getAttribution), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getAttribution", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.services.api.geocoding.v5.models']/class[@name='CarmenFeatureCollection']/method[@name='setAttribution' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setAttribution", "(Ljava/lang/String;)V", "GetSetAttribution_Ljava_lang_String_Handler")]
			set {
				if (id_setAttribution_Ljava_lang_String_ == IntPtr.Zero)
					id_setAttribution_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setAttribution", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setAttribution_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setAttribution", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getFeatures;
#pragma warning disable 0169
		static Delegate GetGetFeaturesHandler ()
		{
			if (cb_getFeatures == null)
				cb_getFeatures = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetFeatures);
			return cb_getFeatures;
		}

		static IntPtr n_GetFeatures (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mapbox.Services.Api.Geocoding.V5.Models.CarmenFeatureCollection __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Services.Api.Geocoding.V5.Models.CarmenFeatureCollection> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList<global::Com.Mapbox.Services.Api.Geocoding.V5.Models.CarmenFeature>.ToLocalJniHandle (__this.Features);
		}
#pragma warning restore 0169

		static IntPtr id_getFeatures;
		public virtual unsafe global::System.Collections.Generic.IList<global::Com.Mapbox.Services.Api.Geocoding.V5.Models.CarmenFeature> Features {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.services.api.geocoding.v5.models']/class[@name='CarmenFeatureCollection']/method[@name='getFeatures' and count(parameter)=0]"
			[Register ("getFeatures", "()Ljava/util/List;", "GetGetFeaturesHandler")]
			get {
				if (id_getFeatures == IntPtr.Zero)
					id_getFeatures = JNIEnv.GetMethodID (class_ref, "getFeatures", "()Ljava/util/List;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Android.Runtime.JavaList<global::Com.Mapbox.Services.Api.Geocoding.V5.Models.CarmenFeature>.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getFeatures), JniHandleOwnership.TransferLocalRef);
					else
						return global::Android.Runtime.JavaList<global::Com.Mapbox.Services.Api.Geocoding.V5.Models.CarmenFeature>.FromJniHandle (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getFeatures", "()Ljava/util/List;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getQuery;
#pragma warning disable 0169
		static Delegate GetGetQueryHandler ()
		{
			if (cb_getQuery == null)
				cb_getQuery = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetQuery);
			return cb_getQuery;
		}

		static IntPtr n_GetQuery (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mapbox.Services.Api.Geocoding.V5.Models.CarmenFeatureCollection __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Services.Api.Geocoding.V5.Models.CarmenFeatureCollection> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList<string>.ToLocalJniHandle (__this.Query);
		}
#pragma warning restore 0169

		static Delegate cb_setQuery_Ljava_util_List_;
#pragma warning disable 0169
		static Delegate GetSetQuery_Ljava_util_List_Handler ()
		{
			if (cb_setQuery_Ljava_util_List_ == null)
				cb_setQuery_Ljava_util_List_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetQuery_Ljava_util_List_);
			return cb_setQuery_Ljava_util_List_;
		}

		static void n_SetQuery_Ljava_util_List_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Mapbox.Services.Api.Geocoding.V5.Models.CarmenFeatureCollection __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Services.Api.Geocoding.V5.Models.CarmenFeatureCollection> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Android.Runtime.JavaList<string>.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Query = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getQuery;
		static IntPtr id_setQuery_Ljava_util_List_;
		public virtual unsafe global::System.Collections.Generic.IList<string> Query {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.services.api.geocoding.v5.models']/class[@name='CarmenFeatureCollection']/method[@name='getQuery' and count(parameter)=0]"
			[Register ("getQuery", "()Ljava/util/List;", "GetGetQueryHandler")]
			get {
				if (id_getQuery == IntPtr.Zero)
					id_getQuery = JNIEnv.GetMethodID (class_ref, "getQuery", "()Ljava/util/List;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Android.Runtime.JavaList<string>.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getQuery), JniHandleOwnership.TransferLocalRef);
					else
						return global::Android.Runtime.JavaList<string>.FromJniHandle (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getQuery", "()Ljava/util/List;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.services.api.geocoding.v5.models']/class[@name='CarmenFeatureCollection']/method[@name='setQuery' and count(parameter)=1 and parameter[1][@type='java.util.List&lt;java.lang.String&gt;']]"
			[Register ("setQuery", "(Ljava/util/List;)V", "GetSetQuery_Ljava_util_List_Handler")]
			set {
				if (id_setQuery_Ljava_util_List_ == IntPtr.Zero)
					id_setQuery_Ljava_util_List_ = JNIEnv.GetMethodID (class_ref, "setQuery", "(Ljava/util/List;)V");
				IntPtr native_value = global::Android.Runtime.JavaList<string>.ToLocalJniHandle (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setQuery_Ljava_util_List_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setQuery", "(Ljava/util/List;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr id_fromFeatures_Ljava_util_List_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.services.api.geocoding.v5.models']/class[@name='CarmenFeatureCollection']/method[@name='fromFeatures' and count(parameter)=1 and parameter[1][@type='java.util.List&lt;com.mapbox.services.api.geocoding.v5.models.CarmenFeature&gt;']]"
		[Register ("fromFeatures", "(Ljava/util/List;)Lcom/mapbox/services/api/geocoding/v5/models/CarmenFeatureCollection;", "")]
		public static unsafe global::Com.Mapbox.Services.Api.Geocoding.V5.Models.CarmenFeatureCollection FromFeatures (global::System.Collections.Generic.IList<global::Com.Mapbox.Services.Api.Geocoding.V5.Models.CarmenFeature> p0)
		{
			if (id_fromFeatures_Ljava_util_List_ == IntPtr.Zero)
				id_fromFeatures_Ljava_util_List_ = JNIEnv.GetStaticMethodID (class_ref, "fromFeatures", "(Ljava/util/List;)Lcom/mapbox/services/api/geocoding/v5/models/CarmenFeatureCollection;");
			IntPtr native_p0 = global::Android.Runtime.JavaList<global::Com.Mapbox.Services.Api.Geocoding.V5.Models.CarmenFeature>.ToLocalJniHandle (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				global::Com.Mapbox.Services.Api.Geocoding.V5.Models.CarmenFeatureCollection __ret = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Services.Api.Geocoding.V5.Models.CarmenFeatureCollection> (JNIEnv.CallStaticObjectMethod  (class_ref, id_fromFeatures_Ljava_util_List_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

	}
}
