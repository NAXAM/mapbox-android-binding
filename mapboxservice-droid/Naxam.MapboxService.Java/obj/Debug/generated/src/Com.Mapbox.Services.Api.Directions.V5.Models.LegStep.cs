using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Mapbox.Services.Api.Directions.V5.Models {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.mapbox.services.api.directions.v5.models']/class[@name='LegStep']"
	[global::Android.Runtime.Register ("com/mapbox/services/api/directions/v5/models/LegStep", DoNotGenerateAcw=true)]
	public partial class LegStep : global::Java.Lang.Object {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/mapbox/services/api/directions/v5/models/LegStep", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (LegStep); }
		}

		protected LegStep (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Ljava_lang_String_Ljava_lang_String_Lcom_mapbox_services_api_directions_v5_models_StepManeuver_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.mapbox.services.api.directions.v5.models']/class[@name='LegStep']/constructor[@name='LegStep' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='com.mapbox.services.api.directions.v5.models.StepManeuver']]"
		[Register (".ctor", "(Ljava/lang/String;Ljava/lang/String;Lcom/mapbox/services/api/directions/v5/models/StepManeuver;)V", "")]
		public unsafe LegStep (string p0, string p1, global::Com.Mapbox.Services.Api.Directions.V5.Models.StepManeuver p2)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (p2);
				if (((object) this).GetType () != typeof (LegStep)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Ljava/lang/String;Ljava/lang/String;Lcom/mapbox/services/api/directions/v5/models/StepManeuver;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Ljava/lang/String;Ljava/lang/String;Lcom/mapbox/services/api/directions/v5/models/StepManeuver;)V", __args);
					return;
				}

				if (id_ctor_Ljava_lang_String_Ljava_lang_String_Lcom_mapbox_services_api_directions_v5_models_StepManeuver_ == IntPtr.Zero)
					id_ctor_Ljava_lang_String_Ljava_lang_String_Lcom_mapbox_services_api_directions_v5_models_StepManeuver_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/lang/String;Ljava/lang/String;Lcom/mapbox/services/api/directions/v5/models/StepManeuver;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_lang_String_Ljava_lang_String_Lcom_mapbox_services_api_directions_v5_models_StepManeuver_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Ljava_lang_String_Ljava_lang_String_Lcom_mapbox_services_api_directions_v5_models_StepManeuver_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static IntPtr id_ctor_Ljava_util_List_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.mapbox.services.api.directions.v5.models']/class[@name='LegStep']/constructor[@name='LegStep' and count(parameter)=1 and parameter[1][@type='java.util.List&lt;com.mapbox.services.api.directions.v5.models.StepIntersection&gt;']]"
		[Register (".ctor", "(Ljava/util/List;)V", "")]
		public unsafe LegStep (global::System.Collections.Generic.IList<global::Com.Mapbox.Services.Api.Directions.V5.Models.StepIntersection> p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_p0 = global::Android.Runtime.JavaList<global::Com.Mapbox.Services.Api.Directions.V5.Models.StepIntersection>.ToLocalJniHandle (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				if (((object) this).GetType () != typeof (LegStep)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Ljava/util/List;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Ljava/util/List;)V", __args);
					return;
				}

				if (id_ctor_Ljava_util_List_ == IntPtr.Zero)
					id_ctor_Ljava_util_List_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/util/List;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_util_List_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Ljava_util_List_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.mapbox.services.api.directions.v5.models']/class[@name='LegStep']/constructor[@name='LegStep' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe LegStep ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (LegStep)) {
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

		static Delegate cb_getDestinations;
#pragma warning disable 0169
		static Delegate GetGetDestinationsHandler ()
		{
			if (cb_getDestinations == null)
				cb_getDestinations = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetDestinations);
			return cb_getDestinations;
		}

		static IntPtr n_GetDestinations (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mapbox.Services.Api.Directions.V5.Models.LegStep __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Services.Api.Directions.V5.Models.LegStep> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Destinations);
		}
#pragma warning restore 0169

		static Delegate cb_setDestinations_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetDestinations_Ljava_lang_String_Handler ()
		{
			if (cb_setDestinations_Ljava_lang_String_ == null)
				cb_setDestinations_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetDestinations_Ljava_lang_String_);
			return cb_setDestinations_Ljava_lang_String_;
		}

		static void n_SetDestinations_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Mapbox.Services.Api.Directions.V5.Models.LegStep __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Services.Api.Directions.V5.Models.LegStep> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Destinations = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getDestinations;
		static IntPtr id_setDestinations_Ljava_lang_String_;
		public virtual unsafe string Destinations {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.services.api.directions.v5.models']/class[@name='LegStep']/method[@name='getDestinations' and count(parameter)=0]"
			[Register ("getDestinations", "()Ljava/lang/String;", "GetGetDestinationsHandler")]
			get {
				if (id_getDestinations == IntPtr.Zero)
					id_getDestinations = JNIEnv.GetMethodID (class_ref, "getDestinations", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getDestinations), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getDestinations", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.services.api.directions.v5.models']/class[@name='LegStep']/method[@name='setDestinations' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setDestinations", "(Ljava/lang/String;)V", "GetSetDestinations_Ljava_lang_String_Handler")]
			set {
				if (id_setDestinations_Ljava_lang_String_ == IntPtr.Zero)
					id_setDestinations_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setDestinations", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setDestinations_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setDestinations", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getDistance;
#pragma warning disable 0169
		static Delegate GetGetDistanceHandler ()
		{
			if (cb_getDistance == null)
				cb_getDistance = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, double>) n_GetDistance);
			return cb_getDistance;
		}

		static double n_GetDistance (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mapbox.Services.Api.Directions.V5.Models.LegStep __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Services.Api.Directions.V5.Models.LegStep> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Distance;
		}
#pragma warning restore 0169

		static Delegate cb_setDistance_D;
#pragma warning disable 0169
		static Delegate GetSetDistance_DHandler ()
		{
			if (cb_setDistance_D == null)
				cb_setDistance_D = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, double>) n_SetDistance_D);
			return cb_setDistance_D;
		}

		static void n_SetDistance_D (IntPtr jnienv, IntPtr native__this, double p0)
		{
			global::Com.Mapbox.Services.Api.Directions.V5.Models.LegStep __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Services.Api.Directions.V5.Models.LegStep> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Distance = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getDistance;
		static IntPtr id_setDistance_D;
		public virtual unsafe double Distance {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.services.api.directions.v5.models']/class[@name='LegStep']/method[@name='getDistance' and count(parameter)=0]"
			[Register ("getDistance", "()D", "GetGetDistanceHandler")]
			get {
				if (id_getDistance == IntPtr.Zero)
					id_getDistance = JNIEnv.GetMethodID (class_ref, "getDistance", "()D");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallDoubleMethod (((global::Java.Lang.Object) this).Handle, id_getDistance);
					else
						return JNIEnv.CallNonvirtualDoubleMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getDistance", "()D"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.services.api.directions.v5.models']/class[@name='LegStep']/method[@name='setDistance' and count(parameter)=1 and parameter[1][@type='double']]"
			[Register ("setDistance", "(D)V", "GetSetDistance_DHandler")]
			set {
				if (id_setDistance_D == IntPtr.Zero)
					id_setDistance_D = JNIEnv.GetMethodID (class_ref, "setDistance", "(D)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setDistance_D, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setDistance", "(D)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getDuration;
#pragma warning disable 0169
		static Delegate GetGetDurationHandler ()
		{
			if (cb_getDuration == null)
				cb_getDuration = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, double>) n_GetDuration);
			return cb_getDuration;
		}

		static double n_GetDuration (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mapbox.Services.Api.Directions.V5.Models.LegStep __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Services.Api.Directions.V5.Models.LegStep> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Duration;
		}
#pragma warning restore 0169

		static Delegate cb_setDuration_D;
#pragma warning disable 0169
		static Delegate GetSetDuration_DHandler ()
		{
			if (cb_setDuration_D == null)
				cb_setDuration_D = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, double>) n_SetDuration_D);
			return cb_setDuration_D;
		}

		static void n_SetDuration_D (IntPtr jnienv, IntPtr native__this, double p0)
		{
			global::Com.Mapbox.Services.Api.Directions.V5.Models.LegStep __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Services.Api.Directions.V5.Models.LegStep> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Duration = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getDuration;
		static IntPtr id_setDuration_D;
		public virtual unsafe double Duration {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.services.api.directions.v5.models']/class[@name='LegStep']/method[@name='getDuration' and count(parameter)=0]"
			[Register ("getDuration", "()D", "GetGetDurationHandler")]
			get {
				if (id_getDuration == IntPtr.Zero)
					id_getDuration = JNIEnv.GetMethodID (class_ref, "getDuration", "()D");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallDoubleMethod (((global::Java.Lang.Object) this).Handle, id_getDuration);
					else
						return JNIEnv.CallNonvirtualDoubleMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getDuration", "()D"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.services.api.directions.v5.models']/class[@name='LegStep']/method[@name='setDuration' and count(parameter)=1 and parameter[1][@type='double']]"
			[Register ("setDuration", "(D)V", "GetSetDuration_DHandler")]
			set {
				if (id_setDuration_D == IntPtr.Zero)
					id_setDuration_D = JNIEnv.GetMethodID (class_ref, "setDuration", "(D)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setDuration_D, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setDuration", "(D)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getGeometry;
#pragma warning disable 0169
		static Delegate GetGetGeometryHandler ()
		{
			if (cb_getGeometry == null)
				cb_getGeometry = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetGeometry);
			return cb_getGeometry;
		}

		static IntPtr n_GetGeometry (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mapbox.Services.Api.Directions.V5.Models.LegStep __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Services.Api.Directions.V5.Models.LegStep> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Geometry);
		}
#pragma warning restore 0169

		static Delegate cb_setGeometry_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetGeometry_Ljava_lang_String_Handler ()
		{
			if (cb_setGeometry_Ljava_lang_String_ == null)
				cb_setGeometry_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetGeometry_Ljava_lang_String_);
			return cb_setGeometry_Ljava_lang_String_;
		}

		static void n_SetGeometry_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Mapbox.Services.Api.Directions.V5.Models.LegStep __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Services.Api.Directions.V5.Models.LegStep> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Geometry = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getGeometry;
		static IntPtr id_setGeometry_Ljava_lang_String_;
		public virtual unsafe string Geometry {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.services.api.directions.v5.models']/class[@name='LegStep']/method[@name='getGeometry' and count(parameter)=0]"
			[Register ("getGeometry", "()Ljava/lang/String;", "GetGetGeometryHandler")]
			get {
				if (id_getGeometry == IntPtr.Zero)
					id_getGeometry = JNIEnv.GetMethodID (class_ref, "getGeometry", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getGeometry), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getGeometry", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.services.api.directions.v5.models']/class[@name='LegStep']/method[@name='setGeometry' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setGeometry", "(Ljava/lang/String;)V", "GetSetGeometry_Ljava_lang_String_Handler")]
			set {
				if (id_setGeometry_Ljava_lang_String_ == IntPtr.Zero)
					id_setGeometry_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setGeometry", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setGeometry_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setGeometry", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getIntersections;
#pragma warning disable 0169
		static Delegate GetGetIntersectionsHandler ()
		{
			if (cb_getIntersections == null)
				cb_getIntersections = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetIntersections);
			return cb_getIntersections;
		}

		static IntPtr n_GetIntersections (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mapbox.Services.Api.Directions.V5.Models.LegStep __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Services.Api.Directions.V5.Models.LegStep> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList<global::Com.Mapbox.Services.Api.Directions.V5.Models.StepIntersection>.ToLocalJniHandle (__this.Intersections);
		}
#pragma warning restore 0169

		static Delegate cb_setIntersections_Ljava_util_List_;
#pragma warning disable 0169
		static Delegate GetSetIntersections_Ljava_util_List_Handler ()
		{
			if (cb_setIntersections_Ljava_util_List_ == null)
				cb_setIntersections_Ljava_util_List_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetIntersections_Ljava_util_List_);
			return cb_setIntersections_Ljava_util_List_;
		}

		static void n_SetIntersections_Ljava_util_List_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Mapbox.Services.Api.Directions.V5.Models.LegStep __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Services.Api.Directions.V5.Models.LegStep> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Android.Runtime.JavaList<global::Com.Mapbox.Services.Api.Directions.V5.Models.StepIntersection>.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Intersections = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getIntersections;
		static IntPtr id_setIntersections_Ljava_util_List_;
		public virtual unsafe global::System.Collections.Generic.IList<global::Com.Mapbox.Services.Api.Directions.V5.Models.StepIntersection> Intersections {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.services.api.directions.v5.models']/class[@name='LegStep']/method[@name='getIntersections' and count(parameter)=0]"
			[Register ("getIntersections", "()Ljava/util/List;", "GetGetIntersectionsHandler")]
			get {
				if (id_getIntersections == IntPtr.Zero)
					id_getIntersections = JNIEnv.GetMethodID (class_ref, "getIntersections", "()Ljava/util/List;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Android.Runtime.JavaList<global::Com.Mapbox.Services.Api.Directions.V5.Models.StepIntersection>.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getIntersections), JniHandleOwnership.TransferLocalRef);
					else
						return global::Android.Runtime.JavaList<global::Com.Mapbox.Services.Api.Directions.V5.Models.StepIntersection>.FromJniHandle (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getIntersections", "()Ljava/util/List;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.services.api.directions.v5.models']/class[@name='LegStep']/method[@name='setIntersections' and count(parameter)=1 and parameter[1][@type='java.util.List&lt;com.mapbox.services.api.directions.v5.models.StepIntersection&gt;']]"
			[Register ("setIntersections", "(Ljava/util/List;)V", "GetSetIntersections_Ljava_util_List_Handler")]
			set {
				if (id_setIntersections_Ljava_util_List_ == IntPtr.Zero)
					id_setIntersections_Ljava_util_List_ = JNIEnv.GetMethodID (class_ref, "setIntersections", "(Ljava/util/List;)V");
				IntPtr native_value = global::Android.Runtime.JavaList<global::Com.Mapbox.Services.Api.Directions.V5.Models.StepIntersection>.ToLocalJniHandle (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setIntersections_Ljava_util_List_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setIntersections", "(Ljava/util/List;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getManeuver;
#pragma warning disable 0169
		static Delegate GetGetManeuverHandler ()
		{
			if (cb_getManeuver == null)
				cb_getManeuver = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetManeuver);
			return cb_getManeuver;
		}

		static IntPtr n_GetManeuver (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mapbox.Services.Api.Directions.V5.Models.LegStep __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Services.Api.Directions.V5.Models.LegStep> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Maneuver);
		}
#pragma warning restore 0169

		static Delegate cb_setManeuver_Lcom_mapbox_services_api_directions_v5_models_StepManeuver_;
#pragma warning disable 0169
		static Delegate GetSetManeuver_Lcom_mapbox_services_api_directions_v5_models_StepManeuver_Handler ()
		{
			if (cb_setManeuver_Lcom_mapbox_services_api_directions_v5_models_StepManeuver_ == null)
				cb_setManeuver_Lcom_mapbox_services_api_directions_v5_models_StepManeuver_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetManeuver_Lcom_mapbox_services_api_directions_v5_models_StepManeuver_);
			return cb_setManeuver_Lcom_mapbox_services_api_directions_v5_models_StepManeuver_;
		}

		static void n_SetManeuver_Lcom_mapbox_services_api_directions_v5_models_StepManeuver_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Mapbox.Services.Api.Directions.V5.Models.LegStep __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Services.Api.Directions.V5.Models.LegStep> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Mapbox.Services.Api.Directions.V5.Models.StepManeuver p0 = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Services.Api.Directions.V5.Models.StepManeuver> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Maneuver = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getManeuver;
		static IntPtr id_setManeuver_Lcom_mapbox_services_api_directions_v5_models_StepManeuver_;
		public virtual unsafe global::Com.Mapbox.Services.Api.Directions.V5.Models.StepManeuver Maneuver {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.services.api.directions.v5.models']/class[@name='LegStep']/method[@name='getManeuver' and count(parameter)=0]"
			[Register ("getManeuver", "()Lcom/mapbox/services/api/directions/v5/models/StepManeuver;", "GetGetManeuverHandler")]
			get {
				if (id_getManeuver == IntPtr.Zero)
					id_getManeuver = JNIEnv.GetMethodID (class_ref, "getManeuver", "()Lcom/mapbox/services/api/directions/v5/models/StepManeuver;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Services.Api.Directions.V5.Models.StepManeuver> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getManeuver), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Services.Api.Directions.V5.Models.StepManeuver> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getManeuver", "()Lcom/mapbox/services/api/directions/v5/models/StepManeuver;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.services.api.directions.v5.models']/class[@name='LegStep']/method[@name='setManeuver' and count(parameter)=1 and parameter[1][@type='com.mapbox.services.api.directions.v5.models.StepManeuver']]"
			[Register ("setManeuver", "(Lcom/mapbox/services/api/directions/v5/models/StepManeuver;)V", "GetSetManeuver_Lcom_mapbox_services_api_directions_v5_models_StepManeuver_Handler")]
			set {
				if (id_setManeuver_Lcom_mapbox_services_api_directions_v5_models_StepManeuver_ == IntPtr.Zero)
					id_setManeuver_Lcom_mapbox_services_api_directions_v5_models_StepManeuver_ = JNIEnv.GetMethodID (class_ref, "setManeuver", "(Lcom/mapbox/services/api/directions/v5/models/StepManeuver;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setManeuver_Lcom_mapbox_services_api_directions_v5_models_StepManeuver_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setManeuver", "(Lcom/mapbox/services/api/directions/v5/models/StepManeuver;)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getMode;
#pragma warning disable 0169
		static Delegate GetGetModeHandler ()
		{
			if (cb_getMode == null)
				cb_getMode = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetMode);
			return cb_getMode;
		}

		static IntPtr n_GetMode (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mapbox.Services.Api.Directions.V5.Models.LegStep __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Services.Api.Directions.V5.Models.LegStep> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Mode);
		}
#pragma warning restore 0169

		static Delegate cb_setMode_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetMode_Ljava_lang_String_Handler ()
		{
			if (cb_setMode_Ljava_lang_String_ == null)
				cb_setMode_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetMode_Ljava_lang_String_);
			return cb_setMode_Ljava_lang_String_;
		}

		static void n_SetMode_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Mapbox.Services.Api.Directions.V5.Models.LegStep __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Services.Api.Directions.V5.Models.LegStep> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Mode = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getMode;
		static IntPtr id_setMode_Ljava_lang_String_;
		public virtual unsafe string Mode {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.services.api.directions.v5.models']/class[@name='LegStep']/method[@name='getMode' and count(parameter)=0]"
			[Register ("getMode", "()Ljava/lang/String;", "GetGetModeHandler")]
			get {
				if (id_getMode == IntPtr.Zero)
					id_getMode = JNIEnv.GetMethodID (class_ref, "getMode", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getMode), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getMode", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.services.api.directions.v5.models']/class[@name='LegStep']/method[@name='setMode' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setMode", "(Ljava/lang/String;)V", "GetSetMode_Ljava_lang_String_Handler")]
			set {
				if (id_setMode_Ljava_lang_String_ == IntPtr.Zero)
					id_setMode_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setMode", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setMode_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setMode", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getName;
#pragma warning disable 0169
		static Delegate GetGetNameHandler ()
		{
			if (cb_getName == null)
				cb_getName = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetName);
			return cb_getName;
		}

		static IntPtr n_GetName (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mapbox.Services.Api.Directions.V5.Models.LegStep __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Services.Api.Directions.V5.Models.LegStep> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Name);
		}
#pragma warning restore 0169

		static Delegate cb_setName_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetName_Ljava_lang_String_Handler ()
		{
			if (cb_setName_Ljava_lang_String_ == null)
				cb_setName_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetName_Ljava_lang_String_);
			return cb_setName_Ljava_lang_String_;
		}

		static void n_SetName_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Mapbox.Services.Api.Directions.V5.Models.LegStep __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Services.Api.Directions.V5.Models.LegStep> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Name = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getName;
		static IntPtr id_setName_Ljava_lang_String_;
		public virtual unsafe string Name {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.services.api.directions.v5.models']/class[@name='LegStep']/method[@name='getName' and count(parameter)=0]"
			[Register ("getName", "()Ljava/lang/String;", "GetGetNameHandler")]
			get {
				if (id_getName == IntPtr.Zero)
					id_getName = JNIEnv.GetMethodID (class_ref, "getName", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getName), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getName", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.services.api.directions.v5.models']/class[@name='LegStep']/method[@name='setName' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setName", "(Ljava/lang/String;)V", "GetSetName_Ljava_lang_String_Handler")]
			set {
				if (id_setName_Ljava_lang_String_ == IntPtr.Zero)
					id_setName_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setName", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setName_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setName", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getPronunciation;
#pragma warning disable 0169
		static Delegate GetGetPronunciationHandler ()
		{
			if (cb_getPronunciation == null)
				cb_getPronunciation = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetPronunciation);
			return cb_getPronunciation;
		}

		static IntPtr n_GetPronunciation (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mapbox.Services.Api.Directions.V5.Models.LegStep __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Services.Api.Directions.V5.Models.LegStep> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Pronunciation);
		}
#pragma warning restore 0169

		static Delegate cb_setPronunciation_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetPronunciation_Ljava_lang_String_Handler ()
		{
			if (cb_setPronunciation_Ljava_lang_String_ == null)
				cb_setPronunciation_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetPronunciation_Ljava_lang_String_);
			return cb_setPronunciation_Ljava_lang_String_;
		}

		static void n_SetPronunciation_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Mapbox.Services.Api.Directions.V5.Models.LegStep __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Services.Api.Directions.V5.Models.LegStep> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Pronunciation = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getPronunciation;
		static IntPtr id_setPronunciation_Ljava_lang_String_;
		public virtual unsafe string Pronunciation {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.services.api.directions.v5.models']/class[@name='LegStep']/method[@name='getPronunciation' and count(parameter)=0]"
			[Register ("getPronunciation", "()Ljava/lang/String;", "GetGetPronunciationHandler")]
			get {
				if (id_getPronunciation == IntPtr.Zero)
					id_getPronunciation = JNIEnv.GetMethodID (class_ref, "getPronunciation", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getPronunciation), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getPronunciation", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.services.api.directions.v5.models']/class[@name='LegStep']/method[@name='setPronunciation' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setPronunciation", "(Ljava/lang/String;)V", "GetSetPronunciation_Ljava_lang_String_Handler")]
			set {
				if (id_setPronunciation_Ljava_lang_String_ == IntPtr.Zero)
					id_setPronunciation_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setPronunciation", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setPronunciation_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setPronunciation", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getRef;
#pragma warning disable 0169
		static Delegate GetGetRefHandler ()
		{
			if (cb_getRef == null)
				cb_getRef = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetRef);
			return cb_getRef;
		}

		static IntPtr n_GetRef (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mapbox.Services.Api.Directions.V5.Models.LegStep __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Services.Api.Directions.V5.Models.LegStep> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Ref);
		}
#pragma warning restore 0169

		static Delegate cb_setRef_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetRef_Ljava_lang_String_Handler ()
		{
			if (cb_setRef_Ljava_lang_String_ == null)
				cb_setRef_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetRef_Ljava_lang_String_);
			return cb_setRef_Ljava_lang_String_;
		}

		static void n_SetRef_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Mapbox.Services.Api.Directions.V5.Models.LegStep __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Services.Api.Directions.V5.Models.LegStep> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Ref = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getRef;
		static IntPtr id_setRef_Ljava_lang_String_;
		public virtual unsafe string Ref {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.services.api.directions.v5.models']/class[@name='LegStep']/method[@name='getRef' and count(parameter)=0]"
			[Register ("getRef", "()Ljava/lang/String;", "GetGetRefHandler")]
			get {
				if (id_getRef == IntPtr.Zero)
					id_getRef = JNIEnv.GetMethodID (class_ref, "getRef", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getRef), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getRef", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.services.api.directions.v5.models']/class[@name='LegStep']/method[@name='setRef' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setRef", "(Ljava/lang/String;)V", "GetSetRef_Ljava_lang_String_Handler")]
			set {
				if (id_setRef_Ljava_lang_String_ == IntPtr.Zero)
					id_setRef_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setRef", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setRef_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setRef", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getRotaryName;
#pragma warning disable 0169
		static Delegate GetGetRotaryNameHandler ()
		{
			if (cb_getRotaryName == null)
				cb_getRotaryName = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetRotaryName);
			return cb_getRotaryName;
		}

		static IntPtr n_GetRotaryName (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mapbox.Services.Api.Directions.V5.Models.LegStep __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Services.Api.Directions.V5.Models.LegStep> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.RotaryName);
		}
#pragma warning restore 0169

		static Delegate cb_setRotaryName_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetRotaryName_Ljava_lang_String_Handler ()
		{
			if (cb_setRotaryName_Ljava_lang_String_ == null)
				cb_setRotaryName_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetRotaryName_Ljava_lang_String_);
			return cb_setRotaryName_Ljava_lang_String_;
		}

		static void n_SetRotaryName_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Mapbox.Services.Api.Directions.V5.Models.LegStep __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Services.Api.Directions.V5.Models.LegStep> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.RotaryName = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getRotaryName;
		static IntPtr id_setRotaryName_Ljava_lang_String_;
		public virtual unsafe string RotaryName {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.services.api.directions.v5.models']/class[@name='LegStep']/method[@name='getRotaryName' and count(parameter)=0]"
			[Register ("getRotaryName", "()Ljava/lang/String;", "GetGetRotaryNameHandler")]
			get {
				if (id_getRotaryName == IntPtr.Zero)
					id_getRotaryName = JNIEnv.GetMethodID (class_ref, "getRotaryName", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getRotaryName), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getRotaryName", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.services.api.directions.v5.models']/class[@name='LegStep']/method[@name='setRotaryName' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setRotaryName", "(Ljava/lang/String;)V", "GetSetRotaryName_Ljava_lang_String_Handler")]
			set {
				if (id_setRotaryName_Ljava_lang_String_ == IntPtr.Zero)
					id_setRotaryName_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setRotaryName", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setRotaryName_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setRotaryName", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getRotaryPronunciation;
#pragma warning disable 0169
		static Delegate GetGetRotaryPronunciationHandler ()
		{
			if (cb_getRotaryPronunciation == null)
				cb_getRotaryPronunciation = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetRotaryPronunciation);
			return cb_getRotaryPronunciation;
		}

		static IntPtr n_GetRotaryPronunciation (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mapbox.Services.Api.Directions.V5.Models.LegStep __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Services.Api.Directions.V5.Models.LegStep> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.RotaryPronunciation);
		}
#pragma warning restore 0169

		static Delegate cb_setRotaryPronunciation_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetRotaryPronunciation_Ljava_lang_String_Handler ()
		{
			if (cb_setRotaryPronunciation_Ljava_lang_String_ == null)
				cb_setRotaryPronunciation_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetRotaryPronunciation_Ljava_lang_String_);
			return cb_setRotaryPronunciation_Ljava_lang_String_;
		}

		static void n_SetRotaryPronunciation_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Mapbox.Services.Api.Directions.V5.Models.LegStep __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Services.Api.Directions.V5.Models.LegStep> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.RotaryPronunciation = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getRotaryPronunciation;
		static IntPtr id_setRotaryPronunciation_Ljava_lang_String_;
		public virtual unsafe string RotaryPronunciation {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.services.api.directions.v5.models']/class[@name='LegStep']/method[@name='getRotaryPronunciation' and count(parameter)=0]"
			[Register ("getRotaryPronunciation", "()Ljava/lang/String;", "GetGetRotaryPronunciationHandler")]
			get {
				if (id_getRotaryPronunciation == IntPtr.Zero)
					id_getRotaryPronunciation = JNIEnv.GetMethodID (class_ref, "getRotaryPronunciation", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getRotaryPronunciation), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getRotaryPronunciation", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.services.api.directions.v5.models']/class[@name='LegStep']/method[@name='setRotaryPronunciation' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setRotaryPronunciation", "(Ljava/lang/String;)V", "GetSetRotaryPronunciation_Ljava_lang_String_Handler")]
			set {
				if (id_setRotaryPronunciation_Ljava_lang_String_ == IntPtr.Zero)
					id_setRotaryPronunciation_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setRotaryPronunciation", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setRotaryPronunciation_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setRotaryPronunciation", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getWeight;
#pragma warning disable 0169
		static Delegate GetGetWeightHandler ()
		{
			if (cb_getWeight == null)
				cb_getWeight = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, double>) n_GetWeight);
			return cb_getWeight;
		}

		static double n_GetWeight (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mapbox.Services.Api.Directions.V5.Models.LegStep __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Services.Api.Directions.V5.Models.LegStep> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Weight;
		}
#pragma warning restore 0169

		static Delegate cb_setWeight_D;
#pragma warning disable 0169
		static Delegate GetSetWeight_DHandler ()
		{
			if (cb_setWeight_D == null)
				cb_setWeight_D = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, double>) n_SetWeight_D);
			return cb_setWeight_D;
		}

		static void n_SetWeight_D (IntPtr jnienv, IntPtr native__this, double p0)
		{
			global::Com.Mapbox.Services.Api.Directions.V5.Models.LegStep __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Services.Api.Directions.V5.Models.LegStep> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Weight = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getWeight;
		static IntPtr id_setWeight_D;
		public virtual unsafe double Weight {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.services.api.directions.v5.models']/class[@name='LegStep']/method[@name='getWeight' and count(parameter)=0]"
			[Register ("getWeight", "()D", "GetGetWeightHandler")]
			get {
				if (id_getWeight == IntPtr.Zero)
					id_getWeight = JNIEnv.GetMethodID (class_ref, "getWeight", "()D");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallDoubleMethod (((global::Java.Lang.Object) this).Handle, id_getWeight);
					else
						return JNIEnv.CallNonvirtualDoubleMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getWeight", "()D"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.services.api.directions.v5.models']/class[@name='LegStep']/method[@name='setWeight' and count(parameter)=1 and parameter[1][@type='double']]"
			[Register ("setWeight", "(D)V", "GetSetWeight_DHandler")]
			set {
				if (id_setWeight_D == IntPtr.Zero)
					id_setWeight_D = JNIEnv.GetMethodID (class_ref, "setWeight", "(D)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setWeight_D, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setWeight", "(D)V"), __args);
				} finally {
				}
			}
		}

	}
}
