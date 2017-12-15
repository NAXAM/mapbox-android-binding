using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Mapbox.Services.Api.Utils.Turf {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.mapbox.services.api.utils.turf']/class[@name='TurfMisc']"
	[global::Android.Runtime.Register ("com/mapbox/services/api/utils/turf/TurfMisc", DoNotGenerateAcw=true)]
	public partial class TurfMisc : global::Java.Lang.Object {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/mapbox/services/api/utils/turf/TurfMisc", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (TurfMisc); }
		}

		protected TurfMisc (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.mapbox.services.api.utils.turf']/class[@name='TurfMisc']/constructor[@name='TurfMisc' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe TurfMisc ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (TurfMisc)) {
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

		static IntPtr id_lineSlice_Lcom_mapbox_services_commons_geojson_Point_Lcom_mapbox_services_commons_geojson_Point_Lcom_mapbox_services_commons_geojson_Feature_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.services.api.utils.turf']/class[@name='TurfMisc']/method[@name='lineSlice' and count(parameter)=3 and parameter[1][@type='com.mapbox.services.commons.geojson.Point'] and parameter[2][@type='com.mapbox.services.commons.geojson.Point'] and parameter[3][@type='com.mapbox.services.commons.geojson.Feature']]"
		[Register ("lineSlice", "(Lcom/mapbox/services/commons/geojson/Point;Lcom/mapbox/services/commons/geojson/Point;Lcom/mapbox/services/commons/geojson/Feature;)Lcom/mapbox/services/commons/geojson/LineString;", "")]
		public static unsafe global::Com.Mapbox.Services.Commons.Geojson.LineString LineSlice (global::Com.Mapbox.Services.Commons.Geojson.Point p0, global::Com.Mapbox.Services.Commons.Geojson.Point p1, global::Com.Mapbox.Services.Commons.Geojson.Feature p2)
		{
			if (id_lineSlice_Lcom_mapbox_services_commons_geojson_Point_Lcom_mapbox_services_commons_geojson_Point_Lcom_mapbox_services_commons_geojson_Feature_ == IntPtr.Zero)
				id_lineSlice_Lcom_mapbox_services_commons_geojson_Point_Lcom_mapbox_services_commons_geojson_Point_Lcom_mapbox_services_commons_geojson_Feature_ = JNIEnv.GetStaticMethodID (class_ref, "lineSlice", "(Lcom/mapbox/services/commons/geojson/Point;Lcom/mapbox/services/commons/geojson/Point;Lcom/mapbox/services/commons/geojson/Feature;)Lcom/mapbox/services/commons/geojson/LineString;");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				global::Com.Mapbox.Services.Commons.Geojson.LineString __ret = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Services.Commons.Geojson.LineString> (JNIEnv.CallStaticObjectMethod  (class_ref, id_lineSlice_Lcom_mapbox_services_commons_geojson_Point_Lcom_mapbox_services_commons_geojson_Point_Lcom_mapbox_services_commons_geojson_Feature_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_lineSlice_Lcom_mapbox_services_commons_geojson_Point_Lcom_mapbox_services_commons_geojson_Point_Lcom_mapbox_services_commons_geojson_LineString_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.services.api.utils.turf']/class[@name='TurfMisc']/method[@name='lineSlice' and count(parameter)=3 and parameter[1][@type='com.mapbox.services.commons.geojson.Point'] and parameter[2][@type='com.mapbox.services.commons.geojson.Point'] and parameter[3][@type='com.mapbox.services.commons.geojson.LineString']]"
		[Register ("lineSlice", "(Lcom/mapbox/services/commons/geojson/Point;Lcom/mapbox/services/commons/geojson/Point;Lcom/mapbox/services/commons/geojson/LineString;)Lcom/mapbox/services/commons/geojson/LineString;", "")]
		public static unsafe global::Com.Mapbox.Services.Commons.Geojson.LineString LineSlice (global::Com.Mapbox.Services.Commons.Geojson.Point p0, global::Com.Mapbox.Services.Commons.Geojson.Point p1, global::Com.Mapbox.Services.Commons.Geojson.LineString p2)
		{
			if (id_lineSlice_Lcom_mapbox_services_commons_geojson_Point_Lcom_mapbox_services_commons_geojson_Point_Lcom_mapbox_services_commons_geojson_LineString_ == IntPtr.Zero)
				id_lineSlice_Lcom_mapbox_services_commons_geojson_Point_Lcom_mapbox_services_commons_geojson_Point_Lcom_mapbox_services_commons_geojson_LineString_ = JNIEnv.GetStaticMethodID (class_ref, "lineSlice", "(Lcom/mapbox/services/commons/geojson/Point;Lcom/mapbox/services/commons/geojson/Point;Lcom/mapbox/services/commons/geojson/LineString;)Lcom/mapbox/services/commons/geojson/LineString;");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				global::Com.Mapbox.Services.Commons.Geojson.LineString __ret = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Services.Commons.Geojson.LineString> (JNIEnv.CallStaticObjectMethod  (class_ref, id_lineSlice_Lcom_mapbox_services_commons_geojson_Point_Lcom_mapbox_services_commons_geojson_Point_Lcom_mapbox_services_commons_geojson_LineString_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_pointOnLine_Lcom_mapbox_services_commons_geojson_Point_Ljava_util_List_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.services.api.utils.turf']/class[@name='TurfMisc']/method[@name='pointOnLine' and count(parameter)=2 and parameter[1][@type='com.mapbox.services.commons.geojson.Point'] and parameter[2][@type='java.util.List&lt;com.mapbox.services.commons.models.Position&gt;']]"
		[Register ("pointOnLine", "(Lcom/mapbox/services/commons/geojson/Point;Ljava/util/List;)Lcom/mapbox/services/commons/geojson/Feature;", "")]
		public static unsafe global::Com.Mapbox.Services.Commons.Geojson.Feature PointOnLine (global::Com.Mapbox.Services.Commons.Geojson.Point p0, global::System.Collections.Generic.IList<global::Com.Mapbox.Services.Commons.Models.Position> p1)
		{
			if (id_pointOnLine_Lcom_mapbox_services_commons_geojson_Point_Ljava_util_List_ == IntPtr.Zero)
				id_pointOnLine_Lcom_mapbox_services_commons_geojson_Point_Ljava_util_List_ = JNIEnv.GetStaticMethodID (class_ref, "pointOnLine", "(Lcom/mapbox/services/commons/geojson/Point;Ljava/util/List;)Lcom/mapbox/services/commons/geojson/Feature;");
			IntPtr native_p1 = global::Android.Runtime.JavaList<global::Com.Mapbox.Services.Commons.Models.Position>.ToLocalJniHandle (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				global::Com.Mapbox.Services.Commons.Geojson.Feature __ret = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Services.Commons.Geojson.Feature> (JNIEnv.CallStaticObjectMethod  (class_ref, id_pointOnLine_Lcom_mapbox_services_commons_geojson_Point_Ljava_util_List_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

	}
}
