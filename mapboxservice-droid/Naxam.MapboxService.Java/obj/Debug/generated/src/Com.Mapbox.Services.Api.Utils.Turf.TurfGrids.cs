using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Mapbox.Services.Api.Utils.Turf {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.mapbox.services.api.utils.turf']/class[@name='TurfGrids']"
	[global::Android.Runtime.Register ("com/mapbox/services/api/utils/turf/TurfGrids", DoNotGenerateAcw=true)]
	public partial class TurfGrids : global::Java.Lang.Object {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/mapbox/services/api/utils/turf/TurfGrids", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (TurfGrids); }
		}

		protected TurfGrids (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.mapbox.services.api.utils.turf']/class[@name='TurfGrids']/constructor[@name='TurfGrids' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe TurfGrids ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (TurfGrids)) {
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

		static IntPtr id_within_Lcom_mapbox_services_commons_geojson_FeatureCollection_Lcom_mapbox_services_commons_geojson_FeatureCollection_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.services.api.utils.turf']/class[@name='TurfGrids']/method[@name='within' and count(parameter)=2 and parameter[1][@type='com.mapbox.services.commons.geojson.FeatureCollection'] and parameter[2][@type='com.mapbox.services.commons.geojson.FeatureCollection']]"
		[Register ("within", "(Lcom/mapbox/services/commons/geojson/FeatureCollection;Lcom/mapbox/services/commons/geojson/FeatureCollection;)Lcom/mapbox/services/commons/geojson/FeatureCollection;", "")]
		public static unsafe global::Com.Mapbox.Services.Commons.Geojson.FeatureCollection Within (global::Com.Mapbox.Services.Commons.Geojson.FeatureCollection p0, global::Com.Mapbox.Services.Commons.Geojson.FeatureCollection p1)
		{
			if (id_within_Lcom_mapbox_services_commons_geojson_FeatureCollection_Lcom_mapbox_services_commons_geojson_FeatureCollection_ == IntPtr.Zero)
				id_within_Lcom_mapbox_services_commons_geojson_FeatureCollection_Lcom_mapbox_services_commons_geojson_FeatureCollection_ = JNIEnv.GetStaticMethodID (class_ref, "within", "(Lcom/mapbox/services/commons/geojson/FeatureCollection;Lcom/mapbox/services/commons/geojson/FeatureCollection;)Lcom/mapbox/services/commons/geojson/FeatureCollection;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				global::Com.Mapbox.Services.Commons.Geojson.FeatureCollection __ret = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Services.Commons.Geojson.FeatureCollection> (JNIEnv.CallStaticObjectMethod  (class_ref, id_within_Lcom_mapbox_services_commons_geojson_FeatureCollection_Lcom_mapbox_services_commons_geojson_FeatureCollection_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

	}
}
