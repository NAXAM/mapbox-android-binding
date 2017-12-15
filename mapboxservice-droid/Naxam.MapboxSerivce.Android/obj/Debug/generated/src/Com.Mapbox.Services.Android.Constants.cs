using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Mapbox.Services.Android {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.mapbox.services.android']/class[@name='Constants']"
	[global::Android.Runtime.Register ("com/mapbox/services/android/Constants", DoNotGenerateAcw=true)]
	public partial class Constants : global::Java.Lang.Object {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.mapbox.services.android']/class[@name='Constants']/field[@name='STEP_MANEUVER_TYPE_ARRIVE']"
		[Register ("STEP_MANEUVER_TYPE_ARRIVE")]
		public const string StepManeuverTypeArrive = (string) "arrive";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.mapbox.services.android']/class[@name='Constants']/field[@name='STEP_MANEUVER_TYPE_CONTINUE']"
		[Register ("STEP_MANEUVER_TYPE_CONTINUE")]
		public const string StepManeuverTypeContinue = (string) "continue";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.mapbox.services.android']/class[@name='Constants']/field[@name='STEP_MANEUVER_TYPE_DEPART']"
		[Register ("STEP_MANEUVER_TYPE_DEPART")]
		public const string StepManeuverTypeDepart = (string) "depart";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.mapbox.services.android']/class[@name='Constants']/field[@name='STEP_MANEUVER_TYPE_END_OF_ROAD']"
		[Register ("STEP_MANEUVER_TYPE_END_OF_ROAD")]
		public const string StepManeuverTypeEndOfRoad = (string) "end of road";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.mapbox.services.android']/class[@name='Constants']/field[@name='STEP_MANEUVER_TYPE_EXIT_ROTARY']"
		[Register ("STEP_MANEUVER_TYPE_EXIT_ROTARY")]
		public const string StepManeuverTypeExitRotary = (string) "exit rotary";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.mapbox.services.android']/class[@name='Constants']/field[@name='STEP_MANEUVER_TYPE_EXIT_ROUNDABOUT']"
		[Register ("STEP_MANEUVER_TYPE_EXIT_ROUNDABOUT")]
		public const string StepManeuverTypeExitRoundabout = (string) "exit roundabout";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.mapbox.services.android']/class[@name='Constants']/field[@name='STEP_MANEUVER_TYPE_FORK']"
		[Register ("STEP_MANEUVER_TYPE_FORK")]
		public const string StepManeuverTypeFork = (string) "fork";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.mapbox.services.android']/class[@name='Constants']/field[@name='STEP_MANEUVER_TYPE_MERGE']"
		[Register ("STEP_MANEUVER_TYPE_MERGE")]
		public const string StepManeuverTypeMerge = (string) "merge";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.mapbox.services.android']/class[@name='Constants']/field[@name='STEP_MANEUVER_TYPE_NEW_NAME']"
		[Register ("STEP_MANEUVER_TYPE_NEW_NAME")]
		public const string StepManeuverTypeNewName = (string) "new name";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.mapbox.services.android']/class[@name='Constants']/field[@name='STEP_MANEUVER_TYPE_NOTIFICATION']"
		[Register ("STEP_MANEUVER_TYPE_NOTIFICATION")]
		public const string StepManeuverTypeNotification = (string) "notification";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.mapbox.services.android']/class[@name='Constants']/field[@name='STEP_MANEUVER_TYPE_OFF_RAMP']"
		[Register ("STEP_MANEUVER_TYPE_OFF_RAMP")]
		public const string StepManeuverTypeOffRamp = (string) "off ramp";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.mapbox.services.android']/class[@name='Constants']/field[@name='STEP_MANEUVER_TYPE_ON_RAMP']"
		[Register ("STEP_MANEUVER_TYPE_ON_RAMP")]
		public const string StepManeuverTypeOnRamp = (string) "on ramp";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.mapbox.services.android']/class[@name='Constants']/field[@name='STEP_MANEUVER_TYPE_ROTARY']"
		[Register ("STEP_MANEUVER_TYPE_ROTARY")]
		public const string StepManeuverTypeRotary = (string) "rotary";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.mapbox.services.android']/class[@name='Constants']/field[@name='STEP_MANEUVER_TYPE_ROUNDABOUT']"
		[Register ("STEP_MANEUVER_TYPE_ROUNDABOUT")]
		public const string StepManeuverTypeRoundabout = (string) "roundabout";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.mapbox.services.android']/class[@name='Constants']/field[@name='STEP_MANEUVER_TYPE_ROUNDABOUT_TURN']"
		[Register ("STEP_MANEUVER_TYPE_ROUNDABOUT_TURN")]
		public const string StepManeuverTypeRoundaboutTurn = (string) "roundabout turn";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.mapbox.services.android']/class[@name='Constants']/field[@name='STEP_MANEUVER_TYPE_TURN']"
		[Register ("STEP_MANEUVER_TYPE_TURN")]
		public const string StepManeuverTypeTurn = (string) "turn";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.mapbox.services.android']/class[@name='Constants']/field[@name='STEP_MANEUVER_TYPE_USE_LANE']"
		[Register ("STEP_MANEUVER_TYPE_USE_LANE")]
		public const string StepManeuverTypeUseLane = (string) "use lane";
		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/mapbox/services/android/Constants", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (Constants); }
		}

		protected Constants (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.mapbox.services.android']/class[@name='Constants']/constructor[@name='Constants' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe Constants ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (Constants)) {
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
