using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Mapbox.Services.Api.Utils.Turf {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.mapbox.services.api.utils.turf']/class[@name='TurfJoins']"
	[global::Android.Runtime.Register ("com/mapbox/services/api/utils/turf/TurfJoins", DoNotGenerateAcw=true)]
	public partial class TurfJoins : global::Java.Lang.Object {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/mapbox/services/api/utils/turf/TurfJoins", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (TurfJoins); }
		}

		protected TurfJoins (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.mapbox.services.api.utils.turf']/class[@name='TurfJoins']/constructor[@name='TurfJoins' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe TurfJoins ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (TurfJoins)) {
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

		static IntPtr id_inside_Lcom_mapbox_services_commons_geojson_Point_Lcom_mapbox_services_commons_geojson_MultiPolygon_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.services.api.utils.turf']/class[@name='TurfJoins']/method[@name='inside' and count(parameter)=2 and parameter[1][@type='com.mapbox.services.commons.geojson.Point'] and parameter[2][@type='com.mapbox.services.commons.geojson.MultiPolygon']]"
		[Register ("inside", "(Lcom/mapbox/services/commons/geojson/Point;Lcom/mapbox/services/commons/geojson/MultiPolygon;)Z", "")]
		public static unsafe bool Inside (global::Com.Mapbox.Services.Commons.Geojson.Point p0, global::Com.Mapbox.Services.Commons.Geojson.MultiPolygon p1)
		{
			if (id_inside_Lcom_mapbox_services_commons_geojson_Point_Lcom_mapbox_services_commons_geojson_MultiPolygon_ == IntPtr.Zero)
				id_inside_Lcom_mapbox_services_commons_geojson_Point_Lcom_mapbox_services_commons_geojson_MultiPolygon_ = JNIEnv.GetStaticMethodID (class_ref, "inside", "(Lcom/mapbox/services/commons/geojson/Point;Lcom/mapbox/services/commons/geojson/MultiPolygon;)Z");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				bool __ret = JNIEnv.CallStaticBooleanMethod  (class_ref, id_inside_Lcom_mapbox_services_commons_geojson_Point_Lcom_mapbox_services_commons_geojson_MultiPolygon_, __args);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_inside_Lcom_mapbox_services_commons_geojson_Point_Lcom_mapbox_services_commons_geojson_Polygon_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.services.api.utils.turf']/class[@name='TurfJoins']/method[@name='inside' and count(parameter)=2 and parameter[1][@type='com.mapbox.services.commons.geojson.Point'] and parameter[2][@type='com.mapbox.services.commons.geojson.Polygon']]"
		[Register ("inside", "(Lcom/mapbox/services/commons/geojson/Point;Lcom/mapbox/services/commons/geojson/Polygon;)Z", "")]
		public static unsafe bool Inside (global::Com.Mapbox.Services.Commons.Geojson.Point p0, global::Com.Mapbox.Services.Commons.Geojson.Polygon p1)
		{
			if (id_inside_Lcom_mapbox_services_commons_geojson_Point_Lcom_mapbox_services_commons_geojson_Polygon_ == IntPtr.Zero)
				id_inside_Lcom_mapbox_services_commons_geojson_Point_Lcom_mapbox_services_commons_geojson_Polygon_ = JNIEnv.GetStaticMethodID (class_ref, "inside", "(Lcom/mapbox/services/commons/geojson/Point;Lcom/mapbox/services/commons/geojson/Polygon;)Z");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				bool __ret = JNIEnv.CallStaticBooleanMethod  (class_ref, id_inside_Lcom_mapbox_services_commons_geojson_Point_Lcom_mapbox_services_commons_geojson_Polygon_, __args);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_inside_Lcom_mapbox_services_commons_models_Position_Ljava_util_List_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.services.api.utils.turf']/class[@name='TurfJoins']/method[@name='inside' and count(parameter)=2 and parameter[1][@type='com.mapbox.services.commons.models.Position'] and parameter[2][@type='java.util.List&lt;com.mapbox.services.commons.models.Position&gt;']]"
		[Register ("inside", "(Lcom/mapbox/services/commons/models/Position;Ljava/util/List;)Z", "")]
		public static unsafe bool Inside (global::Com.Mapbox.Services.Commons.Models.Position p0, global::System.Collections.Generic.IList<global::Com.Mapbox.Services.Commons.Models.Position> p1)
		{
			if (id_inside_Lcom_mapbox_services_commons_models_Position_Ljava_util_List_ == IntPtr.Zero)
				id_inside_Lcom_mapbox_services_commons_models_Position_Ljava_util_List_ = JNIEnv.GetStaticMethodID (class_ref, "inside", "(Lcom/mapbox/services/commons/models/Position;Ljava/util/List;)Z");
			IntPtr native_p1 = global::Android.Runtime.JavaList<global::Com.Mapbox.Services.Commons.Models.Position>.ToLocalJniHandle (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				bool __ret = JNIEnv.CallStaticBooleanMethod  (class_ref, id_inside_Lcom_mapbox_services_commons_models_Position_Ljava_util_List_, __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

	}
}
