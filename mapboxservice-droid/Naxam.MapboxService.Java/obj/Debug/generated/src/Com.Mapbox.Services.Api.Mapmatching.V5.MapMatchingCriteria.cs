using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Mapbox.Services.Api.Mapmatching.V5 {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.mapbox.services.api.mapmatching.v5']/class[@name='MapMatchingCriteria']"
	[global::Android.Runtime.Register ("com/mapbox/services/api/mapmatching/v5/MapMatchingCriteria", DoNotGenerateAcw=true)]
	public partial class MapMatchingCriteria : global::Java.Lang.Object {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.mapbox.services.api.mapmatching.v5']/class[@name='MapMatchingCriteria']/field[@name='GEOMETRY_GEOJSON']"
		[Register ("GEOMETRY_GEOJSON")]
		public const string GeometryGeojson = (string) "geojson";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.mapbox.services.api.mapmatching.v5']/class[@name='MapMatchingCriteria']/field[@name='GEOMETRY_POLYLINE']"
		[Register ("GEOMETRY_POLYLINE")]
		public const string GeometryPolyline = (string) "polyline";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.mapbox.services.api.mapmatching.v5']/class[@name='MapMatchingCriteria']/field[@name='GEOMETRY_POLYLINE_6']"
		[Register ("GEOMETRY_POLYLINE_6")]
		public const string GeometryPolyline6 = (string) "polyline6";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.mapbox.services.api.mapmatching.v5']/class[@name='MapMatchingCriteria']/field[@name='OVERVIEW_FALSE']"
		[Register ("OVERVIEW_FALSE")]
		public const string OverviewFalse = (string) "false";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.mapbox.services.api.mapmatching.v5']/class[@name='MapMatchingCriteria']/field[@name='OVERVIEW_FULL']"
		[Register ("OVERVIEW_FULL")]
		public const string OverviewFull = (string) "full";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.mapbox.services.api.mapmatching.v5']/class[@name='MapMatchingCriteria']/field[@name='OVERVIEW_SIMPLIFIED']"
		[Register ("OVERVIEW_SIMPLIFIED")]
		public const string OverviewSimplified = (string) "simplified";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.mapbox.services.api.mapmatching.v5']/class[@name='MapMatchingCriteria']/field[@name='PROFILE_CYCLING']"
		[Register ("PROFILE_CYCLING")]
		public const string ProfileCycling = (string) "cycling";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.mapbox.services.api.mapmatching.v5']/class[@name='MapMatchingCriteria']/field[@name='PROFILE_DEFAULT_USER']"
		[Register ("PROFILE_DEFAULT_USER")]
		public const string ProfileDefaultUser = (string) "mapbox";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.mapbox.services.api.mapmatching.v5']/class[@name='MapMatchingCriteria']/field[@name='PROFILE_DRIVING']"
		[Register ("PROFILE_DRIVING")]
		public const string ProfileDriving = (string) "driving";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.mapbox.services.api.mapmatching.v5']/class[@name='MapMatchingCriteria']/field[@name='PROFILE_WALKING']"
		[Register ("PROFILE_WALKING")]
		public const string ProfileWalking = (string) "walking";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.mapbox.services.api.mapmatching.v5']/class[@name='MapMatchingCriteria']/field[@name='RESPONSE_INVALID_INPUT']"
		[Register ("RESPONSE_INVALID_INPUT")]
		public const string ResponseInvalidInput = (string) "InvalidInput";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.mapbox.services.api.mapmatching.v5']/class[@name='MapMatchingCriteria']/field[@name='RESPONSE_NO_MATCH']"
		[Register ("RESPONSE_NO_MATCH")]
		public const string ResponseNoMatch = (string) "NoMatch";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.mapbox.services.api.mapmatching.v5']/class[@name='MapMatchingCriteria']/field[@name='RESPONSE_OK']"
		[Register ("RESPONSE_OK")]
		public const string ResponseOk = (string) "Ok";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.mapbox.services.api.mapmatching.v5']/class[@name='MapMatchingCriteria']/field[@name='RESPONSE_PROFILE_NOT_FOUND']"
		[Register ("RESPONSE_PROFILE_NOT_FOUND")]
		public const string ResponseProfileNotFound = (string) "ProfileNotFound";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.mapbox.services.api.mapmatching.v5']/class[@name='MapMatchingCriteria']/field[@name='RESPONSE_TOO_MANY_COORDINATES']"
		[Register ("RESPONSE_TOO_MANY_COORDINATES")]
		public const string ResponseTooManyCoordinates = (string) "TooManyCoordinates";
		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/mapbox/services/api/mapmatching/v5/MapMatchingCriteria", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (MapMatchingCriteria); }
		}

		protected MapMatchingCriteria (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.mapbox.services.api.mapmatching.v5']/class[@name='MapMatchingCriteria']/constructor[@name='MapMatchingCriteria' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe MapMatchingCriteria ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (MapMatchingCriteria)) {
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
