using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Mapbox.Services.Api.Utils.Turf {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.mapbox.services.api.utils.turf']/class[@name='TurfConstants']"
	[global::Android.Runtime.Register ("com/mapbox/services/api/utils/turf/TurfConstants", DoNotGenerateAcw=true)]
	public partial class TurfConstants : global::Java.Lang.Object {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.mapbox.services.api.utils.turf']/class[@name='TurfConstants']/field[@name='UNIT_CENTIMETERS']"
		[Register ("UNIT_CENTIMETERS")]
		public const string UnitCentimeters = (string) "centimeters";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.mapbox.services.api.utils.turf']/class[@name='TurfConstants']/field[@name='UNIT_DEFAULT']"
		[Register ("UNIT_DEFAULT")]
		public const string UnitDefault = (string) "kilometers";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.mapbox.services.api.utils.turf']/class[@name='TurfConstants']/field[@name='UNIT_DEGREES']"
		[Register ("UNIT_DEGREES")]
		public const string UnitDegrees = (string) "degrees";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.mapbox.services.api.utils.turf']/class[@name='TurfConstants']/field[@name='UNIT_FEET']"
		[Register ("UNIT_FEET")]
		public const string UnitFeet = (string) "feet";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.mapbox.services.api.utils.turf']/class[@name='TurfConstants']/field[@name='UNIT_INCHES']"
		[Register ("UNIT_INCHES")]
		public const string UnitInches = (string) "inches";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.mapbox.services.api.utils.turf']/class[@name='TurfConstants']/field[@name='UNIT_KILOMETERS']"
		[Register ("UNIT_KILOMETERS")]
		public const string UnitKilometers = (string) "kilometers";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.mapbox.services.api.utils.turf']/class[@name='TurfConstants']/field[@name='UNIT_METERS']"
		[Register ("UNIT_METERS")]
		public const string UnitMeters = (string) "meters";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.mapbox.services.api.utils.turf']/class[@name='TurfConstants']/field[@name='UNIT_MILES']"
		[Register ("UNIT_MILES")]
		public const string UnitMiles = (string) "miles";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.mapbox.services.api.utils.turf']/class[@name='TurfConstants']/field[@name='UNIT_NAUTICAL_MILES']"
		[Register ("UNIT_NAUTICAL_MILES")]
		public const string UnitNauticalMiles = (string) "nauticalmiles";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.mapbox.services.api.utils.turf']/class[@name='TurfConstants']/field[@name='UNIT_RADIANS']"
		[Register ("UNIT_RADIANS")]
		public const string UnitRadians = (string) "radians";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.mapbox.services.api.utils.turf']/class[@name='TurfConstants']/field[@name='UNIT_YARDS']"
		[Register ("UNIT_YARDS")]
		public const string UnitYards = (string) "yards";
		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/mapbox/services/api/utils/turf/TurfConstants", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (TurfConstants); }
		}

		protected TurfConstants (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.mapbox.services.api.utils.turf']/class[@name='TurfConstants']/constructor[@name='TurfConstants' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe TurfConstants ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (TurfConstants)) {
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
