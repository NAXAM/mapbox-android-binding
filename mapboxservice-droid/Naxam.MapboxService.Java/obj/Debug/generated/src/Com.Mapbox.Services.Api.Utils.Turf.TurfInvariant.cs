using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Mapbox.Services.Api.Utils.Turf {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.mapbox.services.api.utils.turf']/class[@name='TurfInvariant']"
	[global::Android.Runtime.Register ("com/mapbox/services/api/utils/turf/TurfInvariant", DoNotGenerateAcw=true)]
	public partial class TurfInvariant : global::Java.Lang.Object {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/mapbox/services/api/utils/turf/TurfInvariant", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (TurfInvariant); }
		}

		protected TurfInvariant (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.mapbox.services.api.utils.turf']/class[@name='TurfInvariant']/constructor[@name='TurfInvariant' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe TurfInvariant ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (TurfInvariant)) {
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

		static IntPtr id_collectionOf_Lcom_mapbox_services_commons_geojson_FeatureCollection_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.services.api.utils.turf']/class[@name='TurfInvariant']/method[@name='collectionOf' and count(parameter)=3 and parameter[1][@type='com.mapbox.services.commons.geojson.FeatureCollection'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String']]"
		[Register ("collectionOf", "(Lcom/mapbox/services/commons/geojson/FeatureCollection;Ljava/lang/String;Ljava/lang/String;)V", "")]
		public static unsafe void CollectionOf (global::Com.Mapbox.Services.Commons.Geojson.FeatureCollection p0, string p1, string p2)
		{
			if (id_collectionOf_Lcom_mapbox_services_commons_geojson_FeatureCollection_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_collectionOf_Lcom_mapbox_services_commons_geojson_FeatureCollection_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "collectionOf", "(Lcom/mapbox/services/commons/geojson/FeatureCollection;Ljava/lang/String;Ljava/lang/String;)V");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (native_p2);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_collectionOf_Lcom_mapbox_services_commons_geojson_FeatureCollection_Ljava_lang_String_Ljava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
				JNIEnv.DeleteLocalRef (native_p2);
			}
		}

		static IntPtr id_featureOf_Lcom_mapbox_services_commons_geojson_Feature_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.services.api.utils.turf']/class[@name='TurfInvariant']/method[@name='featureOf' and count(parameter)=3 and parameter[1][@type='com.mapbox.services.commons.geojson.Feature'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String']]"
		[Register ("featureOf", "(Lcom/mapbox/services/commons/geojson/Feature;Ljava/lang/String;Ljava/lang/String;)V", "")]
		public static unsafe void FeatureOf (global::Com.Mapbox.Services.Commons.Geojson.Feature p0, string p1, string p2)
		{
			if (id_featureOf_Lcom_mapbox_services_commons_geojson_Feature_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_featureOf_Lcom_mapbox_services_commons_geojson_Feature_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "featureOf", "(Lcom/mapbox/services/commons/geojson/Feature;Ljava/lang/String;Ljava/lang/String;)V");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (native_p2);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_featureOf_Lcom_mapbox_services_commons_geojson_Feature_Ljava_lang_String_Ljava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
				JNIEnv.DeleteLocalRef (native_p2);
			}
		}

		static IntPtr id_geojsonType_Lcom_mapbox_services_commons_geojson_GeoJSON_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.services.api.utils.turf']/class[@name='TurfInvariant']/method[@name='geojsonType' and count(parameter)=3 and parameter[1][@type='com.mapbox.services.commons.geojson.GeoJSON'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String']]"
		[Register ("geojsonType", "(Lcom/mapbox/services/commons/geojson/GeoJSON;Ljava/lang/String;Ljava/lang/String;)V", "")]
		public static unsafe void GeojsonType (global::Com.Mapbox.Services.Commons.Geojson.IGeoJSON p0, string p1, string p2)
		{
			if (id_geojsonType_Lcom_mapbox_services_commons_geojson_GeoJSON_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_geojsonType_Lcom_mapbox_services_commons_geojson_GeoJSON_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "geojsonType", "(Lcom/mapbox/services/commons/geojson/GeoJSON;Ljava/lang/String;Ljava/lang/String;)V");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (native_p2);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_geojsonType_Lcom_mapbox_services_commons_geojson_GeoJSON_Ljava_lang_String_Ljava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
				JNIEnv.DeleteLocalRef (native_p2);
			}
		}

		static IntPtr id_getCoord_Lcom_mapbox_services_commons_geojson_Feature_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.services.api.utils.turf']/class[@name='TurfInvariant']/method[@name='getCoord' and count(parameter)=1 and parameter[1][@type='com.mapbox.services.commons.geojson.Feature']]"
		[Register ("getCoord", "(Lcom/mapbox/services/commons/geojson/Feature;)Lcom/mapbox/services/commons/models/Position;", "")]
		public static unsafe global::Com.Mapbox.Services.Commons.Models.Position GetCoord (global::Com.Mapbox.Services.Commons.Geojson.Feature p0)
		{
			if (id_getCoord_Lcom_mapbox_services_commons_geojson_Feature_ == IntPtr.Zero)
				id_getCoord_Lcom_mapbox_services_commons_geojson_Feature_ = JNIEnv.GetStaticMethodID (class_ref, "getCoord", "(Lcom/mapbox/services/commons/geojson/Feature;)Lcom/mapbox/services/commons/models/Position;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				global::Com.Mapbox.Services.Commons.Models.Position __ret = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Services.Commons.Models.Position> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getCoord_Lcom_mapbox_services_commons_geojson_Feature_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_getCoord_Lcom_mapbox_services_commons_geojson_Point_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.services.api.utils.turf']/class[@name='TurfInvariant']/method[@name='getCoord' and count(parameter)=1 and parameter[1][@type='com.mapbox.services.commons.geojson.Point']]"
		[Register ("getCoord", "(Lcom/mapbox/services/commons/geojson/Point;)Lcom/mapbox/services/commons/models/Position;", "")]
		public static unsafe global::Com.Mapbox.Services.Commons.Models.Position GetCoord (global::Com.Mapbox.Services.Commons.Geojson.Point p0)
		{
			if (id_getCoord_Lcom_mapbox_services_commons_geojson_Point_ == IntPtr.Zero)
				id_getCoord_Lcom_mapbox_services_commons_geojson_Point_ = JNIEnv.GetStaticMethodID (class_ref, "getCoord", "(Lcom/mapbox/services/commons/geojson/Point;)Lcom/mapbox/services/commons/models/Position;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				global::Com.Mapbox.Services.Commons.Models.Position __ret = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Services.Commons.Models.Position> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getCoord_Lcom_mapbox_services_commons_geojson_Point_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

	}
}
