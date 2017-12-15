using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Mapbox.Services.Api.Utils.Turf {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.mapbox.services.api.utils.turf']/class[@name='TurfMeasurement']"
	[global::Android.Runtime.Register ("com/mapbox/services/api/utils/turf/TurfMeasurement", DoNotGenerateAcw=true)]
	public partial class TurfMeasurement : global::Java.Lang.Object {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/mapbox/services/api/utils/turf/TurfMeasurement", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (TurfMeasurement); }
		}

		protected TurfMeasurement (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.mapbox.services.api.utils.turf']/class[@name='TurfMeasurement']/constructor[@name='TurfMeasurement' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe TurfMeasurement ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (TurfMeasurement)) {
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

		static IntPtr id_along_Lcom_mapbox_services_commons_geojson_LineString_DLjava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.services.api.utils.turf']/class[@name='TurfMeasurement']/method[@name='along' and count(parameter)=3 and parameter[1][@type='com.mapbox.services.commons.geojson.LineString'] and parameter[2][@type='double'] and parameter[3][@type='java.lang.String']]"
		[Register ("along", "(Lcom/mapbox/services/commons/geojson/LineString;DLjava/lang/String;)Lcom/mapbox/services/commons/geojson/Point;", "")]
		public static unsafe global::Com.Mapbox.Services.Commons.Geojson.Point Along (global::Com.Mapbox.Services.Commons.Geojson.LineString p0, double p1, string p2)
		{
			if (id_along_Lcom_mapbox_services_commons_geojson_LineString_DLjava_lang_String_ == IntPtr.Zero)
				id_along_Lcom_mapbox_services_commons_geojson_LineString_DLjava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "along", "(Lcom/mapbox/services/commons/geojson/LineString;DLjava/lang/String;)Lcom/mapbox/services/commons/geojson/Point;");
			IntPtr native_p2 = JNIEnv.NewString (p2);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (native_p2);
				global::Com.Mapbox.Services.Commons.Geojson.Point __ret = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Services.Commons.Geojson.Point> (JNIEnv.CallStaticObjectMethod  (class_ref, id_along_Lcom_mapbox_services_commons_geojson_LineString_DLjava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p2);
			}
		}

		static IntPtr id_bbox_Lcom_mapbox_services_commons_geojson_LineString_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.services.api.utils.turf']/class[@name='TurfMeasurement']/method[@name='bbox' and count(parameter)=1 and parameter[1][@type='com.mapbox.services.commons.geojson.LineString']]"
		[Register ("bbox", "(Lcom/mapbox/services/commons/geojson/LineString;)[D", "")]
		public static unsafe double[] Bbox (global::Com.Mapbox.Services.Commons.Geojson.LineString p0)
		{
			if (id_bbox_Lcom_mapbox_services_commons_geojson_LineString_ == IntPtr.Zero)
				id_bbox_Lcom_mapbox_services_commons_geojson_LineString_ = JNIEnv.GetStaticMethodID (class_ref, "bbox", "(Lcom/mapbox/services/commons/geojson/LineString;)[D");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				double[] __ret = (double[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_bbox_Lcom_mapbox_services_commons_geojson_LineString_, __args), JniHandleOwnership.TransferLocalRef, typeof (double));
				return __ret;
			} finally {
			}
		}

		static IntPtr id_bbox_Lcom_mapbox_services_commons_geojson_MultiLineString_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.services.api.utils.turf']/class[@name='TurfMeasurement']/method[@name='bbox' and count(parameter)=1 and parameter[1][@type='com.mapbox.services.commons.geojson.MultiLineString']]"
		[Register ("bbox", "(Lcom/mapbox/services/commons/geojson/MultiLineString;)[D", "")]
		public static unsafe double[] Bbox (global::Com.Mapbox.Services.Commons.Geojson.MultiLineString p0)
		{
			if (id_bbox_Lcom_mapbox_services_commons_geojson_MultiLineString_ == IntPtr.Zero)
				id_bbox_Lcom_mapbox_services_commons_geojson_MultiLineString_ = JNIEnv.GetStaticMethodID (class_ref, "bbox", "(Lcom/mapbox/services/commons/geojson/MultiLineString;)[D");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				double[] __ret = (double[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_bbox_Lcom_mapbox_services_commons_geojson_MultiLineString_, __args), JniHandleOwnership.TransferLocalRef, typeof (double));
				return __ret;
			} finally {
			}
		}

		static IntPtr id_bbox_Lcom_mapbox_services_commons_geojson_MultiPoint_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.services.api.utils.turf']/class[@name='TurfMeasurement']/method[@name='bbox' and count(parameter)=1 and parameter[1][@type='com.mapbox.services.commons.geojson.MultiPoint']]"
		[Register ("bbox", "(Lcom/mapbox/services/commons/geojson/MultiPoint;)[D", "")]
		public static unsafe double[] Bbox (global::Com.Mapbox.Services.Commons.Geojson.MultiPoint p0)
		{
			if (id_bbox_Lcom_mapbox_services_commons_geojson_MultiPoint_ == IntPtr.Zero)
				id_bbox_Lcom_mapbox_services_commons_geojson_MultiPoint_ = JNIEnv.GetStaticMethodID (class_ref, "bbox", "(Lcom/mapbox/services/commons/geojson/MultiPoint;)[D");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				double[] __ret = (double[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_bbox_Lcom_mapbox_services_commons_geojson_MultiPoint_, __args), JniHandleOwnership.TransferLocalRef, typeof (double));
				return __ret;
			} finally {
			}
		}

		static IntPtr id_bbox_Lcom_mapbox_services_commons_geojson_MultiPolygon_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.services.api.utils.turf']/class[@name='TurfMeasurement']/method[@name='bbox' and count(parameter)=1 and parameter[1][@type='com.mapbox.services.commons.geojson.MultiPolygon']]"
		[Register ("bbox", "(Lcom/mapbox/services/commons/geojson/MultiPolygon;)[D", "")]
		public static unsafe double[] Bbox (global::Com.Mapbox.Services.Commons.Geojson.MultiPolygon p0)
		{
			if (id_bbox_Lcom_mapbox_services_commons_geojson_MultiPolygon_ == IntPtr.Zero)
				id_bbox_Lcom_mapbox_services_commons_geojson_MultiPolygon_ = JNIEnv.GetStaticMethodID (class_ref, "bbox", "(Lcom/mapbox/services/commons/geojson/MultiPolygon;)[D");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				double[] __ret = (double[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_bbox_Lcom_mapbox_services_commons_geojson_MultiPolygon_, __args), JniHandleOwnership.TransferLocalRef, typeof (double));
				return __ret;
			} finally {
			}
		}

		static IntPtr id_bbox_Lcom_mapbox_services_commons_geojson_Point_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.services.api.utils.turf']/class[@name='TurfMeasurement']/method[@name='bbox' and count(parameter)=1 and parameter[1][@type='com.mapbox.services.commons.geojson.Point']]"
		[Register ("bbox", "(Lcom/mapbox/services/commons/geojson/Point;)[D", "")]
		public static unsafe double[] Bbox (global::Com.Mapbox.Services.Commons.Geojson.Point p0)
		{
			if (id_bbox_Lcom_mapbox_services_commons_geojson_Point_ == IntPtr.Zero)
				id_bbox_Lcom_mapbox_services_commons_geojson_Point_ = JNIEnv.GetStaticMethodID (class_ref, "bbox", "(Lcom/mapbox/services/commons/geojson/Point;)[D");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				double[] __ret = (double[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_bbox_Lcom_mapbox_services_commons_geojson_Point_, __args), JniHandleOwnership.TransferLocalRef, typeof (double));
				return __ret;
			} finally {
			}
		}

		static IntPtr id_bbox_Lcom_mapbox_services_commons_geojson_Polygon_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.services.api.utils.turf']/class[@name='TurfMeasurement']/method[@name='bbox' and count(parameter)=1 and parameter[1][@type='com.mapbox.services.commons.geojson.Polygon']]"
		[Register ("bbox", "(Lcom/mapbox/services/commons/geojson/Polygon;)[D", "")]
		public static unsafe double[] Bbox (global::Com.Mapbox.Services.Commons.Geojson.Polygon p0)
		{
			if (id_bbox_Lcom_mapbox_services_commons_geojson_Polygon_ == IntPtr.Zero)
				id_bbox_Lcom_mapbox_services_commons_geojson_Polygon_ = JNIEnv.GetStaticMethodID (class_ref, "bbox", "(Lcom/mapbox/services/commons/geojson/Polygon;)[D");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				double[] __ret = (double[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_bbox_Lcom_mapbox_services_commons_geojson_Polygon_, __args), JniHandleOwnership.TransferLocalRef, typeof (double));
				return __ret;
			} finally {
			}
		}

		static IntPtr id_bearing_Lcom_mapbox_services_commons_geojson_Point_Lcom_mapbox_services_commons_geojson_Point_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.services.api.utils.turf']/class[@name='TurfMeasurement']/method[@name='bearing' and count(parameter)=2 and parameter[1][@type='com.mapbox.services.commons.geojson.Point'] and parameter[2][@type='com.mapbox.services.commons.geojson.Point']]"
		[Register ("bearing", "(Lcom/mapbox/services/commons/geojson/Point;Lcom/mapbox/services/commons/geojson/Point;)D", "")]
		public static unsafe double Bearing (global::Com.Mapbox.Services.Commons.Geojson.Point p0, global::Com.Mapbox.Services.Commons.Geojson.Point p1)
		{
			if (id_bearing_Lcom_mapbox_services_commons_geojson_Point_Lcom_mapbox_services_commons_geojson_Point_ == IntPtr.Zero)
				id_bearing_Lcom_mapbox_services_commons_geojson_Point_Lcom_mapbox_services_commons_geojson_Point_ = JNIEnv.GetStaticMethodID (class_ref, "bearing", "(Lcom/mapbox/services/commons/geojson/Point;Lcom/mapbox/services/commons/geojson/Point;)D");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				double __ret = JNIEnv.CallStaticDoubleMethod  (class_ref, id_bearing_Lcom_mapbox_services_commons_geojson_Point_Lcom_mapbox_services_commons_geojson_Point_, __args);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_bearing_Lcom_mapbox_services_commons_models_Position_Lcom_mapbox_services_commons_models_Position_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.services.api.utils.turf']/class[@name='TurfMeasurement']/method[@name='bearing' and count(parameter)=2 and parameter[1][@type='com.mapbox.services.commons.models.Position'] and parameter[2][@type='com.mapbox.services.commons.models.Position']]"
		[Register ("bearing", "(Lcom/mapbox/services/commons/models/Position;Lcom/mapbox/services/commons/models/Position;)D", "")]
		public static unsafe double Bearing (global::Com.Mapbox.Services.Commons.Models.Position p0, global::Com.Mapbox.Services.Commons.Models.Position p1)
		{
			if (id_bearing_Lcom_mapbox_services_commons_models_Position_Lcom_mapbox_services_commons_models_Position_ == IntPtr.Zero)
				id_bearing_Lcom_mapbox_services_commons_models_Position_Lcom_mapbox_services_commons_models_Position_ = JNIEnv.GetStaticMethodID (class_ref, "bearing", "(Lcom/mapbox/services/commons/models/Position;Lcom/mapbox/services/commons/models/Position;)D");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				double __ret = JNIEnv.CallStaticDoubleMethod  (class_ref, id_bearing_Lcom_mapbox_services_commons_models_Position_Lcom_mapbox_services_commons_models_Position_, __args);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_destination_Lcom_mapbox_services_commons_geojson_Point_DDLjava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.services.api.utils.turf']/class[@name='TurfMeasurement']/method[@name='destination' and count(parameter)=4 and parameter[1][@type='com.mapbox.services.commons.geojson.Point'] and parameter[2][@type='double'] and parameter[3][@type='double'] and parameter[4][@type='java.lang.String']]"
		[Register ("destination", "(Lcom/mapbox/services/commons/geojson/Point;DDLjava/lang/String;)Lcom/mapbox/services/commons/geojson/Point;", "")]
		public static unsafe global::Com.Mapbox.Services.Commons.Geojson.Point Destination (global::Com.Mapbox.Services.Commons.Geojson.Point p0, double p1, double p2, string p3)
		{
			if (id_destination_Lcom_mapbox_services_commons_geojson_Point_DDLjava_lang_String_ == IntPtr.Zero)
				id_destination_Lcom_mapbox_services_commons_geojson_Point_DDLjava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "destination", "(Lcom/mapbox/services/commons/geojson/Point;DDLjava/lang/String;)Lcom/mapbox/services/commons/geojson/Point;");
			IntPtr native_p3 = JNIEnv.NewString (p3);
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (native_p3);
				global::Com.Mapbox.Services.Commons.Geojson.Point __ret = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Services.Commons.Geojson.Point> (JNIEnv.CallStaticObjectMethod  (class_ref, id_destination_Lcom_mapbox_services_commons_geojson_Point_DDLjava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p3);
			}
		}

		static IntPtr id_destination_Lcom_mapbox_services_commons_models_Position_DDLjava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.services.api.utils.turf']/class[@name='TurfMeasurement']/method[@name='destination' and count(parameter)=4 and parameter[1][@type='com.mapbox.services.commons.models.Position'] and parameter[2][@type='double'] and parameter[3][@type='double'] and parameter[4][@type='java.lang.String']]"
		[Register ("destination", "(Lcom/mapbox/services/commons/models/Position;DDLjava/lang/String;)Lcom/mapbox/services/commons/models/Position;", "")]
		public static unsafe global::Com.Mapbox.Services.Commons.Models.Position Destination (global::Com.Mapbox.Services.Commons.Models.Position p0, double p1, double p2, string p3)
		{
			if (id_destination_Lcom_mapbox_services_commons_models_Position_DDLjava_lang_String_ == IntPtr.Zero)
				id_destination_Lcom_mapbox_services_commons_models_Position_DDLjava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "destination", "(Lcom/mapbox/services/commons/models/Position;DDLjava/lang/String;)Lcom/mapbox/services/commons/models/Position;");
			IntPtr native_p3 = JNIEnv.NewString (p3);
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (native_p3);
				global::Com.Mapbox.Services.Commons.Models.Position __ret = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Services.Commons.Models.Position> (JNIEnv.CallStaticObjectMethod  (class_ref, id_destination_Lcom_mapbox_services_commons_models_Position_DDLjava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p3);
			}
		}

		static IntPtr id_distance_Lcom_mapbox_services_commons_geojson_Point_Lcom_mapbox_services_commons_geojson_Point_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.services.api.utils.turf']/class[@name='TurfMeasurement']/method[@name='distance' and count(parameter)=2 and parameter[1][@type='com.mapbox.services.commons.geojson.Point'] and parameter[2][@type='com.mapbox.services.commons.geojson.Point']]"
		[Register ("distance", "(Lcom/mapbox/services/commons/geojson/Point;Lcom/mapbox/services/commons/geojson/Point;)D", "")]
		public static unsafe double Distance (global::Com.Mapbox.Services.Commons.Geojson.Point p0, global::Com.Mapbox.Services.Commons.Geojson.Point p1)
		{
			if (id_distance_Lcom_mapbox_services_commons_geojson_Point_Lcom_mapbox_services_commons_geojson_Point_ == IntPtr.Zero)
				id_distance_Lcom_mapbox_services_commons_geojson_Point_Lcom_mapbox_services_commons_geojson_Point_ = JNIEnv.GetStaticMethodID (class_ref, "distance", "(Lcom/mapbox/services/commons/geojson/Point;Lcom/mapbox/services/commons/geojson/Point;)D");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				double __ret = JNIEnv.CallStaticDoubleMethod  (class_ref, id_distance_Lcom_mapbox_services_commons_geojson_Point_Lcom_mapbox_services_commons_geojson_Point_, __args);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_distance_Lcom_mapbox_services_commons_geojson_Point_Lcom_mapbox_services_commons_geojson_Point_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.services.api.utils.turf']/class[@name='TurfMeasurement']/method[@name='distance' and count(parameter)=3 and parameter[1][@type='com.mapbox.services.commons.geojson.Point'] and parameter[2][@type='com.mapbox.services.commons.geojson.Point'] and parameter[3][@type='java.lang.String']]"
		[Register ("distance", "(Lcom/mapbox/services/commons/geojson/Point;Lcom/mapbox/services/commons/geojson/Point;Ljava/lang/String;)D", "")]
		public static unsafe double Distance (global::Com.Mapbox.Services.Commons.Geojson.Point p0, global::Com.Mapbox.Services.Commons.Geojson.Point p1, string p2)
		{
			if (id_distance_Lcom_mapbox_services_commons_geojson_Point_Lcom_mapbox_services_commons_geojson_Point_Ljava_lang_String_ == IntPtr.Zero)
				id_distance_Lcom_mapbox_services_commons_geojson_Point_Lcom_mapbox_services_commons_geojson_Point_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "distance", "(Lcom/mapbox/services/commons/geojson/Point;Lcom/mapbox/services/commons/geojson/Point;Ljava/lang/String;)D");
			IntPtr native_p2 = JNIEnv.NewString (p2);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (native_p2);
				double __ret = JNIEnv.CallStaticDoubleMethod  (class_ref, id_distance_Lcom_mapbox_services_commons_geojson_Point_Lcom_mapbox_services_commons_geojson_Point_Ljava_lang_String_, __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p2);
			}
		}

		static IntPtr id_distance_Lcom_mapbox_services_commons_models_Position_Lcom_mapbox_services_commons_models_Position_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.services.api.utils.turf']/class[@name='TurfMeasurement']/method[@name='distance' and count(parameter)=3 and parameter[1][@type='com.mapbox.services.commons.models.Position'] and parameter[2][@type='com.mapbox.services.commons.models.Position'] and parameter[3][@type='java.lang.String']]"
		[Register ("distance", "(Lcom/mapbox/services/commons/models/Position;Lcom/mapbox/services/commons/models/Position;Ljava/lang/String;)D", "")]
		public static unsafe double Distance (global::Com.Mapbox.Services.Commons.Models.Position p0, global::Com.Mapbox.Services.Commons.Models.Position p1, string p2)
		{
			if (id_distance_Lcom_mapbox_services_commons_models_Position_Lcom_mapbox_services_commons_models_Position_Ljava_lang_String_ == IntPtr.Zero)
				id_distance_Lcom_mapbox_services_commons_models_Position_Lcom_mapbox_services_commons_models_Position_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "distance", "(Lcom/mapbox/services/commons/models/Position;Lcom/mapbox/services/commons/models/Position;Ljava/lang/String;)D");
			IntPtr native_p2 = JNIEnv.NewString (p2);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (native_p2);
				double __ret = JNIEnv.CallStaticDoubleMethod  (class_ref, id_distance_Lcom_mapbox_services_commons_models_Position_Lcom_mapbox_services_commons_models_Position_Ljava_lang_String_, __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p2);
			}
		}

		static IntPtr id_lineDistance_Lcom_mapbox_services_commons_geojson_LineString_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.services.api.utils.turf']/class[@name='TurfMeasurement']/method[@name='lineDistance' and count(parameter)=2 and parameter[1][@type='com.mapbox.services.commons.geojson.LineString'] and parameter[2][@type='java.lang.String']]"
		[Register ("lineDistance", "(Lcom/mapbox/services/commons/geojson/LineString;Ljava/lang/String;)D", "")]
		public static unsafe double LineDistance (global::Com.Mapbox.Services.Commons.Geojson.LineString p0, string p1)
		{
			if (id_lineDistance_Lcom_mapbox_services_commons_geojson_LineString_Ljava_lang_String_ == IntPtr.Zero)
				id_lineDistance_Lcom_mapbox_services_commons_geojson_LineString_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "lineDistance", "(Lcom/mapbox/services/commons/geojson/LineString;Ljava/lang/String;)D");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				double __ret = JNIEnv.CallStaticDoubleMethod  (class_ref, id_lineDistance_Lcom_mapbox_services_commons_geojson_LineString_Ljava_lang_String_, __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static IntPtr id_lineDistance_Lcom_mapbox_services_commons_geojson_MultiLineString_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.services.api.utils.turf']/class[@name='TurfMeasurement']/method[@name='lineDistance' and count(parameter)=2 and parameter[1][@type='com.mapbox.services.commons.geojson.MultiLineString'] and parameter[2][@type='java.lang.String']]"
		[Register ("lineDistance", "(Lcom/mapbox/services/commons/geojson/MultiLineString;Ljava/lang/String;)D", "")]
		public static unsafe double LineDistance (global::Com.Mapbox.Services.Commons.Geojson.MultiLineString p0, string p1)
		{
			if (id_lineDistance_Lcom_mapbox_services_commons_geojson_MultiLineString_Ljava_lang_String_ == IntPtr.Zero)
				id_lineDistance_Lcom_mapbox_services_commons_geojson_MultiLineString_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "lineDistance", "(Lcom/mapbox/services/commons/geojson/MultiLineString;Ljava/lang/String;)D");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				double __ret = JNIEnv.CallStaticDoubleMethod  (class_ref, id_lineDistance_Lcom_mapbox_services_commons_geojson_MultiLineString_Ljava_lang_String_, __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static IntPtr id_lineDistance_Lcom_mapbox_services_commons_geojson_MultiPolygon_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.services.api.utils.turf']/class[@name='TurfMeasurement']/method[@name='lineDistance' and count(parameter)=2 and parameter[1][@type='com.mapbox.services.commons.geojson.MultiPolygon'] and parameter[2][@type='java.lang.String']]"
		[Register ("lineDistance", "(Lcom/mapbox/services/commons/geojson/MultiPolygon;Ljava/lang/String;)D", "")]
		public static unsafe double LineDistance (global::Com.Mapbox.Services.Commons.Geojson.MultiPolygon p0, string p1)
		{
			if (id_lineDistance_Lcom_mapbox_services_commons_geojson_MultiPolygon_Ljava_lang_String_ == IntPtr.Zero)
				id_lineDistance_Lcom_mapbox_services_commons_geojson_MultiPolygon_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "lineDistance", "(Lcom/mapbox/services/commons/geojson/MultiPolygon;Ljava/lang/String;)D");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				double __ret = JNIEnv.CallStaticDoubleMethod  (class_ref, id_lineDistance_Lcom_mapbox_services_commons_geojson_MultiPolygon_Ljava_lang_String_, __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static IntPtr id_lineDistance_Lcom_mapbox_services_commons_geojson_Polygon_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.services.api.utils.turf']/class[@name='TurfMeasurement']/method[@name='lineDistance' and count(parameter)=2 and parameter[1][@type='com.mapbox.services.commons.geojson.Polygon'] and parameter[2][@type='java.lang.String']]"
		[Register ("lineDistance", "(Lcom/mapbox/services/commons/geojson/Polygon;Ljava/lang/String;)D", "")]
		public static unsafe double LineDistance (global::Com.Mapbox.Services.Commons.Geojson.Polygon p0, string p1)
		{
			if (id_lineDistance_Lcom_mapbox_services_commons_geojson_Polygon_Ljava_lang_String_ == IntPtr.Zero)
				id_lineDistance_Lcom_mapbox_services_commons_geojson_Polygon_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "lineDistance", "(Lcom/mapbox/services/commons/geojson/Polygon;Ljava/lang/String;)D");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				double __ret = JNIEnv.CallStaticDoubleMethod  (class_ref, id_lineDistance_Lcom_mapbox_services_commons_geojson_Polygon_Ljava_lang_String_, __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static IntPtr id_midpoint_Lcom_mapbox_services_commons_geojson_Point_Lcom_mapbox_services_commons_geojson_Point_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.services.api.utils.turf']/class[@name='TurfMeasurement']/method[@name='midpoint' and count(parameter)=2 and parameter[1][@type='com.mapbox.services.commons.geojson.Point'] and parameter[2][@type='com.mapbox.services.commons.geojson.Point']]"
		[Register ("midpoint", "(Lcom/mapbox/services/commons/geojson/Point;Lcom/mapbox/services/commons/geojson/Point;)Lcom/mapbox/services/commons/geojson/Point;", "")]
		public static unsafe global::Com.Mapbox.Services.Commons.Geojson.Point Midpoint (global::Com.Mapbox.Services.Commons.Geojson.Point p0, global::Com.Mapbox.Services.Commons.Geojson.Point p1)
		{
			if (id_midpoint_Lcom_mapbox_services_commons_geojson_Point_Lcom_mapbox_services_commons_geojson_Point_ == IntPtr.Zero)
				id_midpoint_Lcom_mapbox_services_commons_geojson_Point_Lcom_mapbox_services_commons_geojson_Point_ = JNIEnv.GetStaticMethodID (class_ref, "midpoint", "(Lcom/mapbox/services/commons/geojson/Point;Lcom/mapbox/services/commons/geojson/Point;)Lcom/mapbox/services/commons/geojson/Point;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				global::Com.Mapbox.Services.Commons.Geojson.Point __ret = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Services.Commons.Geojson.Point> (JNIEnv.CallStaticObjectMethod  (class_ref, id_midpoint_Lcom_mapbox_services_commons_geojson_Point_Lcom_mapbox_services_commons_geojson_Point_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_midpoint_Lcom_mapbox_services_commons_models_Position_Lcom_mapbox_services_commons_models_Position_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.services.api.utils.turf']/class[@name='TurfMeasurement']/method[@name='midpoint' and count(parameter)=2 and parameter[1][@type='com.mapbox.services.commons.models.Position'] and parameter[2][@type='com.mapbox.services.commons.models.Position']]"
		[Register ("midpoint", "(Lcom/mapbox/services/commons/models/Position;Lcom/mapbox/services/commons/models/Position;)Lcom/mapbox/services/commons/models/Position;", "")]
		public static unsafe global::Com.Mapbox.Services.Commons.Models.Position Midpoint (global::Com.Mapbox.Services.Commons.Models.Position p0, global::Com.Mapbox.Services.Commons.Models.Position p1)
		{
			if (id_midpoint_Lcom_mapbox_services_commons_models_Position_Lcom_mapbox_services_commons_models_Position_ == IntPtr.Zero)
				id_midpoint_Lcom_mapbox_services_commons_models_Position_Lcom_mapbox_services_commons_models_Position_ = JNIEnv.GetStaticMethodID (class_ref, "midpoint", "(Lcom/mapbox/services/commons/models/Position;Lcom/mapbox/services/commons/models/Position;)Lcom/mapbox/services/commons/models/Position;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				global::Com.Mapbox.Services.Commons.Models.Position __ret = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Services.Commons.Models.Position> (JNIEnv.CallStaticObjectMethod  (class_ref, id_midpoint_Lcom_mapbox_services_commons_models_Position_Lcom_mapbox_services_commons_models_Position_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

	}
}
