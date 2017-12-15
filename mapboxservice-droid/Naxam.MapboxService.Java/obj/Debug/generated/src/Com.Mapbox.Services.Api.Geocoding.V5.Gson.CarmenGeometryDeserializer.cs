using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Mapbox.Services.Api.Geocoding.V5.Gson {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.mapbox.services.api.geocoding.v5.gson']/class[@name='CarmenGeometryDeserializer']"
	[global::Android.Runtime.Register ("com/mapbox/services/api/geocoding/v5/gson/CarmenGeometryDeserializer", DoNotGenerateAcw=true)]
	public partial class CarmenGeometryDeserializer : global::Java.Lang.Object, global::GoogleGson.IJsonDeserializer {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/mapbox/services/api/geocoding/v5/gson/CarmenGeometryDeserializer", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (CarmenGeometryDeserializer); }
		}

		protected CarmenGeometryDeserializer (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.mapbox.services.api.geocoding.v5.gson']/class[@name='CarmenGeometryDeserializer']/constructor[@name='CarmenGeometryDeserializer' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe CarmenGeometryDeserializer ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (CarmenGeometryDeserializer)) {
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

		static Delegate cb_deserialize_Lcom_google_gson_JsonElement_Ljava_lang_reflect_Type_Lcom_google_gson_JsonDeserializationContext_;
#pragma warning disable 0169
		static Delegate GetCarmenGeometryDserialize_Lcom_google_gson_JsonElement_Ljava_lang_reflect_Type_Lcom_google_gson_JsonDeserializationContext_Handler ()
		{
			if (cb_deserialize_Lcom_google_gson_JsonElement_Ljava_lang_reflect_Type_Lcom_google_gson_JsonDeserializationContext_ == null)
				cb_deserialize_Lcom_google_gson_JsonElement_Ljava_lang_reflect_Type_Lcom_google_gson_JsonDeserializationContext_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_CarmenGeometryDserialize_Lcom_google_gson_JsonElement_Ljava_lang_reflect_Type_Lcom_google_gson_JsonDeserializationContext_);
			return cb_deserialize_Lcom_google_gson_JsonElement_Ljava_lang_reflect_Type_Lcom_google_gson_JsonDeserializationContext_;
		}

		static IntPtr n_CarmenGeometryDserialize_Lcom_google_gson_JsonElement_Ljava_lang_reflect_Type_Lcom_google_gson_JsonDeserializationContext_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			global::Com.Mapbox.Services.Api.Geocoding.V5.Gson.CarmenGeometryDeserializer __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Services.Api.Geocoding.V5.Gson.CarmenGeometryDeserializer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::GoogleGson.JsonElement p0 = global::Java.Lang.Object.GetObject<global::GoogleGson.JsonElement> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Reflect.IType p1 = (global::Java.Lang.Reflect.IType)global::Java.Lang.Object.GetObject<global::Java.Lang.Reflect.IType> (native_p1, JniHandleOwnership.DoNotTransfer);
			global::GoogleGson.IJsonDeserializationContext p2 = (global::GoogleGson.IJsonDeserializationContext)global::Java.Lang.Object.GetObject<global::GoogleGson.IJsonDeserializationContext> (native_p2, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.CarmenGeometryDserialize (p0, p1, p2));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_deserialize_Lcom_google_gson_JsonElement_Ljava_lang_reflect_Type_Lcom_google_gson_JsonDeserializationContext_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.services.api.geocoding.v5.gson']/class[@name='CarmenGeometryDeserializer']/method[@name='deserialize' and count(parameter)=3 and parameter[1][@type='com.google.gson.JsonElement'] and parameter[2][@type='java.lang.reflect.Type'] and parameter[3][@type='com.google.gson.JsonDeserializationContext']]"
		[Register ("deserialize", "(Lcom/google/gson/JsonElement;Ljava/lang/reflect/Type;Lcom/google/gson/JsonDeserializationContext;)Lcom/mapbox/services/commons/geojson/Geometry;", "GetCarmenGeometryDserialize_Lcom_google_gson_JsonElement_Ljava_lang_reflect_Type_Lcom_google_gson_JsonDeserializationContext_Handler")]
		public virtual unsafe global::Com.Mapbox.Services.Commons.Geojson.IGeometry CarmenGeometryDserialize (global::GoogleGson.JsonElement p0, global::Java.Lang.Reflect.IType p1, global::GoogleGson.IJsonDeserializationContext p2)
		{
			if (id_deserialize_Lcom_google_gson_JsonElement_Ljava_lang_reflect_Type_Lcom_google_gson_JsonDeserializationContext_ == IntPtr.Zero)
				id_deserialize_Lcom_google_gson_JsonElement_Ljava_lang_reflect_Type_Lcom_google_gson_JsonDeserializationContext_ = JNIEnv.GetMethodID (class_ref, "deserialize", "(Lcom/google/gson/JsonElement;Ljava/lang/reflect/Type;Lcom/google/gson/JsonDeserializationContext;)Lcom/mapbox/services/commons/geojson/Geometry;");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);

				global::Com.Mapbox.Services.Commons.Geojson.IGeometry __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Services.Commons.Geojson.IGeometry> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_deserialize_Lcom_google_gson_JsonElement_Ljava_lang_reflect_Type_Lcom_google_gson_JsonDeserializationContext_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Services.Commons.Geojson.IGeometry> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "deserialize", "(Lcom/google/gson/JsonElement;Ljava/lang/reflect/Type;Lcom/google/gson/JsonDeserializationContext;)Lcom/mapbox/services/commons/geojson/Geometry;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

	}
}
