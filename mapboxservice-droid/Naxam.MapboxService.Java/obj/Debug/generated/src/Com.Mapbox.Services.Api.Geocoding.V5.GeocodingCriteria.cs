using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Mapbox.Services.Api.Geocoding.V5 {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.mapbox.services.api.geocoding.v5']/class[@name='GeocodingCriteria']"
	[global::Android.Runtime.Register ("com/mapbox/services/api/geocoding/v5/GeocodingCriteria", DoNotGenerateAcw=true)]
	public sealed partial class GeocodingCriteria : global::Java.Lang.Object {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.mapbox.services.api.geocoding.v5']/class[@name='GeocodingCriteria']/field[@name='MODE_PLACES']"
		[Register ("MODE_PLACES")]
		public const string ModePlaces = (string) "mapbox.places";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.mapbox.services.api.geocoding.v5']/class[@name='GeocodingCriteria']/field[@name='MODE_PLACES_PERMANENT']"
		[Register ("MODE_PLACES_PERMANENT")]
		public const string ModePlacesPermanent = (string) "mapbox.places-permanent";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.mapbox.services.api.geocoding.v5']/class[@name='GeocodingCriteria']/field[@name='TYPE_ADDRESS']"
		[Register ("TYPE_ADDRESS")]
		public const string TypeAddress = (string) "address";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.mapbox.services.api.geocoding.v5']/class[@name='GeocodingCriteria']/field[@name='TYPE_COUNTRY']"
		[Register ("TYPE_COUNTRY")]
		public const string TypeCountry = (string) "country";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.mapbox.services.api.geocoding.v5']/class[@name='GeocodingCriteria']/field[@name='TYPE_DISTRICT']"
		[Register ("TYPE_DISTRICT")]
		public const string TypeDistrict = (string) "district";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.mapbox.services.api.geocoding.v5']/class[@name='GeocodingCriteria']/field[@name='TYPE_LOCALITY']"
		[Register ("TYPE_LOCALITY")]
		public const string TypeLocality = (string) "locality";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.mapbox.services.api.geocoding.v5']/class[@name='GeocodingCriteria']/field[@name='TYPE_NEIGHBORHOOD']"
		[Register ("TYPE_NEIGHBORHOOD")]
		public const string TypeNeighborhood = (string) "neighborhood";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.mapbox.services.api.geocoding.v5']/class[@name='GeocodingCriteria']/field[@name='TYPE_PLACE']"
		[Register ("TYPE_PLACE")]
		public const string TypePlace = (string) "place";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.mapbox.services.api.geocoding.v5']/class[@name='GeocodingCriteria']/field[@name='TYPE_POI']"
		[Register ("TYPE_POI")]
		public const string TypePoi = (string) "poi";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.mapbox.services.api.geocoding.v5']/class[@name='GeocodingCriteria']/field[@name='TYPE_POI_LANDMARK']"
		[Register ("TYPE_POI_LANDMARK")]
		public const string TypePoiLandmark = (string) "poi.landmark";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.mapbox.services.api.geocoding.v5']/class[@name='GeocodingCriteria']/field[@name='TYPE_POSTCODE']"
		[Register ("TYPE_POSTCODE")]
		public const string TypePostcode = (string) "postcode";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.mapbox.services.api.geocoding.v5']/class[@name='GeocodingCriteria']/field[@name='TYPE_REGION']"
		[Register ("TYPE_REGION")]
		public const string TypeRegion = (string) "region";
		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/mapbox/services/api/geocoding/v5/GeocodingCriteria", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (GeocodingCriteria); }
		}

		internal GeocodingCriteria (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.mapbox.services.api.geocoding.v5']/class[@name='GeocodingCriteria']/constructor[@name='GeocodingCriteria' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe GeocodingCriteria ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (GeocodingCriteria)) {
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

	}
}
