using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Mapbox.Services.Api.Utils.Turf {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.mapbox.services.api.utils.turf']/class[@name='TurfMeta']"
	[global::Android.Runtime.Register ("com/mapbox/services/api/utils/turf/TurfMeta", DoNotGenerateAcw=true)]
	public partial class TurfMeta : global::Java.Lang.Object {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/mapbox/services/api/utils/turf/TurfMeta", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (TurfMeta); }
		}

		protected TurfMeta (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.mapbox.services.api.utils.turf']/class[@name='TurfMeta']/constructor[@name='TurfMeta' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe TurfMeta ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (TurfMeta)) {
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

		static IntPtr id_coordAll_Lcom_mapbox_services_commons_geojson_LineString_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.services.api.utils.turf']/class[@name='TurfMeta']/method[@name='coordAll' and count(parameter)=1 and parameter[1][@type='com.mapbox.services.commons.geojson.LineString']]"
		[Register ("coordAll", "(Lcom/mapbox/services/commons/geojson/LineString;)Ljava/util/List;", "")]
		public static unsafe global::System.Collections.Generic.IList<global::Com.Mapbox.Services.Commons.Models.Position> CoordAll (global::Com.Mapbox.Services.Commons.Geojson.LineString p0)
		{
			if (id_coordAll_Lcom_mapbox_services_commons_geojson_LineString_ == IntPtr.Zero)
				id_coordAll_Lcom_mapbox_services_commons_geojson_LineString_ = JNIEnv.GetStaticMethodID (class_ref, "coordAll", "(Lcom/mapbox/services/commons/geojson/LineString;)Ljava/util/List;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				global::System.Collections.Generic.IList<global::Com.Mapbox.Services.Commons.Models.Position> __ret = global::Android.Runtime.JavaList<global::Com.Mapbox.Services.Commons.Models.Position>.FromJniHandle (JNIEnv.CallStaticObjectMethod  (class_ref, id_coordAll_Lcom_mapbox_services_commons_geojson_LineString_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_coordAll_Lcom_mapbox_services_commons_geojson_MultiLineString_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.services.api.utils.turf']/class[@name='TurfMeta']/method[@name='coordAll' and count(parameter)=1 and parameter[1][@type='com.mapbox.services.commons.geojson.MultiLineString']]"
		[Register ("coordAll", "(Lcom/mapbox/services/commons/geojson/MultiLineString;)Ljava/util/List;", "")]
		public static unsafe global::System.Collections.Generic.IList<global::Com.Mapbox.Services.Commons.Models.Position> CoordAll (global::Com.Mapbox.Services.Commons.Geojson.MultiLineString p0)
		{
			if (id_coordAll_Lcom_mapbox_services_commons_geojson_MultiLineString_ == IntPtr.Zero)
				id_coordAll_Lcom_mapbox_services_commons_geojson_MultiLineString_ = JNIEnv.GetStaticMethodID (class_ref, "coordAll", "(Lcom/mapbox/services/commons/geojson/MultiLineString;)Ljava/util/List;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				global::System.Collections.Generic.IList<global::Com.Mapbox.Services.Commons.Models.Position> __ret = global::Android.Runtime.JavaList<global::Com.Mapbox.Services.Commons.Models.Position>.FromJniHandle (JNIEnv.CallStaticObjectMethod  (class_ref, id_coordAll_Lcom_mapbox_services_commons_geojson_MultiLineString_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_coordAll_Lcom_mapbox_services_commons_geojson_MultiPoint_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.services.api.utils.turf']/class[@name='TurfMeta']/method[@name='coordAll' and count(parameter)=1 and parameter[1][@type='com.mapbox.services.commons.geojson.MultiPoint']]"
		[Register ("coordAll", "(Lcom/mapbox/services/commons/geojson/MultiPoint;)Ljava/util/List;", "")]
		public static unsafe global::System.Collections.Generic.IList<global::Com.Mapbox.Services.Commons.Models.Position> CoordAll (global::Com.Mapbox.Services.Commons.Geojson.MultiPoint p0)
		{
			if (id_coordAll_Lcom_mapbox_services_commons_geojson_MultiPoint_ == IntPtr.Zero)
				id_coordAll_Lcom_mapbox_services_commons_geojson_MultiPoint_ = JNIEnv.GetStaticMethodID (class_ref, "coordAll", "(Lcom/mapbox/services/commons/geojson/MultiPoint;)Ljava/util/List;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				global::System.Collections.Generic.IList<global::Com.Mapbox.Services.Commons.Models.Position> __ret = global::Android.Runtime.JavaList<global::Com.Mapbox.Services.Commons.Models.Position>.FromJniHandle (JNIEnv.CallStaticObjectMethod  (class_ref, id_coordAll_Lcom_mapbox_services_commons_geojson_MultiPoint_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_coordAll_Lcom_mapbox_services_commons_geojson_MultiPolygon_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.services.api.utils.turf']/class[@name='TurfMeta']/method[@name='coordAll' and count(parameter)=2 and parameter[1][@type='com.mapbox.services.commons.geojson.MultiPolygon'] and parameter[2][@type='boolean']]"
		[Register ("coordAll", "(Lcom/mapbox/services/commons/geojson/MultiPolygon;Z)Ljava/util/List;", "")]
		public static unsafe global::System.Collections.Generic.IList<global::Com.Mapbox.Services.Commons.Models.Position> CoordAll (global::Com.Mapbox.Services.Commons.Geojson.MultiPolygon p0, bool p1)
		{
			if (id_coordAll_Lcom_mapbox_services_commons_geojson_MultiPolygon_Z == IntPtr.Zero)
				id_coordAll_Lcom_mapbox_services_commons_geojson_MultiPolygon_Z = JNIEnv.GetStaticMethodID (class_ref, "coordAll", "(Lcom/mapbox/services/commons/geojson/MultiPolygon;Z)Ljava/util/List;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				global::System.Collections.Generic.IList<global::Com.Mapbox.Services.Commons.Models.Position> __ret = global::Android.Runtime.JavaList<global::Com.Mapbox.Services.Commons.Models.Position>.FromJniHandle (JNIEnv.CallStaticObjectMethod  (class_ref, id_coordAll_Lcom_mapbox_services_commons_geojson_MultiPolygon_Z, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_coordAll_Lcom_mapbox_services_commons_geojson_Point_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.services.api.utils.turf']/class[@name='TurfMeta']/method[@name='coordAll' and count(parameter)=1 and parameter[1][@type='com.mapbox.services.commons.geojson.Point']]"
		[Register ("coordAll", "(Lcom/mapbox/services/commons/geojson/Point;)Ljava/util/List;", "")]
		public static unsafe global::System.Collections.Generic.IList<global::Com.Mapbox.Services.Commons.Models.Position> CoordAll (global::Com.Mapbox.Services.Commons.Geojson.Point p0)
		{
			if (id_coordAll_Lcom_mapbox_services_commons_geojson_Point_ == IntPtr.Zero)
				id_coordAll_Lcom_mapbox_services_commons_geojson_Point_ = JNIEnv.GetStaticMethodID (class_ref, "coordAll", "(Lcom/mapbox/services/commons/geojson/Point;)Ljava/util/List;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				global::System.Collections.Generic.IList<global::Com.Mapbox.Services.Commons.Models.Position> __ret = global::Android.Runtime.JavaList<global::Com.Mapbox.Services.Commons.Models.Position>.FromJniHandle (JNIEnv.CallStaticObjectMethod  (class_ref, id_coordAll_Lcom_mapbox_services_commons_geojson_Point_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_coordAll_Lcom_mapbox_services_commons_geojson_Polygon_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.services.api.utils.turf']/class[@name='TurfMeta']/method[@name='coordAll' and count(parameter)=2 and parameter[1][@type='com.mapbox.services.commons.geojson.Polygon'] and parameter[2][@type='boolean']]"
		[Register ("coordAll", "(Lcom/mapbox/services/commons/geojson/Polygon;Z)Ljava/util/List;", "")]
		public static unsafe global::System.Collections.Generic.IList<global::Com.Mapbox.Services.Commons.Models.Position> CoordAll (global::Com.Mapbox.Services.Commons.Geojson.Polygon p0, bool p1)
		{
			if (id_coordAll_Lcom_mapbox_services_commons_geojson_Polygon_Z == IntPtr.Zero)
				id_coordAll_Lcom_mapbox_services_commons_geojson_Polygon_Z = JNIEnv.GetStaticMethodID (class_ref, "coordAll", "(Lcom/mapbox/services/commons/geojson/Polygon;Z)Ljava/util/List;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				global::System.Collections.Generic.IList<global::Com.Mapbox.Services.Commons.Models.Position> __ret = global::Android.Runtime.JavaList<global::Com.Mapbox.Services.Commons.Models.Position>.FromJniHandle (JNIEnv.CallStaticObjectMethod  (class_ref, id_coordAll_Lcom_mapbox_services_commons_geojson_Polygon_Z, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

	}
}
