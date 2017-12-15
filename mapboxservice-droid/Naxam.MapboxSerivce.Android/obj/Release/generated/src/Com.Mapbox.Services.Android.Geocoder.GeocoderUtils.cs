using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Mapbox.Services.Android.Geocoder {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.mapbox.services.android.geocoder']/class[@name='GeocoderUtils']"
	[global::Android.Runtime.Register ("com/mapbox/services/android/geocoder/GeocoderUtils", DoNotGenerateAcw=true)]
	public partial class GeocoderUtils : global::Java.Lang.Object {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/mapbox/services/android/geocoder/GeocoderUtils", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (GeocoderUtils); }
		}

		protected GeocoderUtils (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.mapbox.services.android.geocoder']/class[@name='GeocoderUtils']/constructor[@name='GeocoderUtils' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe GeocoderUtils ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (GeocoderUtils)) {
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

		static IntPtr id_featureToAddress_Lcom_mapbox_services_api_geocoding_v5_models_CarmenFeature_Ljava_util_Locale_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.services.android.geocoder']/class[@name='GeocoderUtils']/method[@name='featureToAddress' and count(parameter)=2 and parameter[1][@type='com.mapbox.services.api.geocoding.v5.models.CarmenFeature'] and parameter[2][@type='java.util.Locale']]"
		[Register ("featureToAddress", "(Lcom/mapbox/services/api/geocoding/v5/models/CarmenFeature;Ljava/util/Locale;)Landroid/location/Address;", "")]
		public static unsafe global::Android.Locations.Address FeatureToAddress (global::Com.Mapbox.Services.Api.Geocoding.V5.Models.CarmenFeature p0, global::Java.Util.Locale p1)
		{
			if (id_featureToAddress_Lcom_mapbox_services_api_geocoding_v5_models_CarmenFeature_Ljava_util_Locale_ == IntPtr.Zero)
				id_featureToAddress_Lcom_mapbox_services_api_geocoding_v5_models_CarmenFeature_Ljava_util_Locale_ = JNIEnv.GetStaticMethodID (class_ref, "featureToAddress", "(Lcom/mapbox/services/api/geocoding/v5/models/CarmenFeature;Ljava/util/Locale;)Landroid/location/Address;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				global::Android.Locations.Address __ret = global::Java.Lang.Object.GetObject<global::Android.Locations.Address> (JNIEnv.CallStaticObjectMethod  (class_ref, id_featureToAddress_Lcom_mapbox_services_api_geocoding_v5_models_CarmenFeature_Ljava_util_Locale_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

	}
}
