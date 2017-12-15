using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Mapbox.Services.Api.Optimizedtrips.V1.Models {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.mapbox.services.api.optimizedtrips.v1.models']/class[@name='OptimizedTripsResponse']"
	[global::Android.Runtime.Register ("com/mapbox/services/api/optimizedtrips/v1/models/OptimizedTripsResponse", DoNotGenerateAcw=true)]
	public partial class OptimizedTripsResponse : global::Java.Lang.Object {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/mapbox/services/api/optimizedtrips/v1/models/OptimizedTripsResponse", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (OptimizedTripsResponse); }
		}

		protected OptimizedTripsResponse (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.mapbox.services.api.optimizedtrips.v1.models']/class[@name='OptimizedTripsResponse']/constructor[@name='OptimizedTripsResponse' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe OptimizedTripsResponse ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (OptimizedTripsResponse)) {
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

		static IntPtr id_ctor_Ljava_util_List_Ljava_util_List_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.mapbox.services.api.optimizedtrips.v1.models']/class[@name='OptimizedTripsResponse']/constructor[@name='OptimizedTripsResponse' and count(parameter)=2 and parameter[1][@type='java.util.List&lt;com.mapbox.services.api.directions.v5.models.DirectionsRoute&gt;'] and parameter[2][@type='java.util.List&lt;com.mapbox.services.api.optimizedtrips.v1.models.OptimizationWaypoint&gt;']]"
		[Register (".ctor", "(Ljava/util/List;Ljava/util/List;)V", "")]
		public unsafe OptimizedTripsResponse (global::System.Collections.Generic.IList<global::Com.Mapbox.Services.Api.Directions.V5.Models.DirectionsRoute> p0, global::System.Collections.Generic.IList<global::Com.Mapbox.Services.Api.Optimizedtrips.V1.Models.OptimizationWaypoint> p1)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_p0 = global::Android.Runtime.JavaList<global::Com.Mapbox.Services.Api.Directions.V5.Models.DirectionsRoute>.ToLocalJniHandle (p0);
			IntPtr native_p1 = global::Android.Runtime.JavaList<global::Com.Mapbox.Services.Api.Optimizedtrips.V1.Models.OptimizationWaypoint>.ToLocalJniHandle (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				if (((object) this).GetType () != typeof (OptimizedTripsResponse)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Ljava/util/List;Ljava/util/List;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Ljava/util/List;Ljava/util/List;)V", __args);
					return;
				}

				if (id_ctor_Ljava_util_List_Ljava_util_List_ == IntPtr.Zero)
					id_ctor_Ljava_util_List_Ljava_util_List_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/util/List;Ljava/util/List;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_util_List_Ljava_util_List_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Ljava_util_List_Ljava_util_List_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static Delegate cb_getCode;
#pragma warning disable 0169
		static Delegate GetGetCodeHandler ()
		{
			if (cb_getCode == null)
				cb_getCode = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetCode);
			return cb_getCode;
		}

		static IntPtr n_GetCode (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mapbox.Services.Api.Optimizedtrips.V1.Models.OptimizedTripsResponse __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Services.Api.Optimizedtrips.V1.Models.OptimizedTripsResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Code);
		}
#pragma warning restore 0169

		static Delegate cb_setCode_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetCode_Ljava_lang_String_Handler ()
		{
			if (cb_setCode_Ljava_lang_String_ == null)
				cb_setCode_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetCode_Ljava_lang_String_);
			return cb_setCode_Ljava_lang_String_;
		}

		static void n_SetCode_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Mapbox.Services.Api.Optimizedtrips.V1.Models.OptimizedTripsResponse __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Services.Api.Optimizedtrips.V1.Models.OptimizedTripsResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Code = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getCode;
		static IntPtr id_setCode_Ljava_lang_String_;
		public virtual unsafe string Code {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.services.api.optimizedtrips.v1.models']/class[@name='OptimizedTripsResponse']/method[@name='getCode' and count(parameter)=0]"
			[Register ("getCode", "()Ljava/lang/String;", "GetGetCodeHandler")]
			get {
				if (id_getCode == IntPtr.Zero)
					id_getCode = JNIEnv.GetMethodID (class_ref, "getCode", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getCode), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getCode", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.services.api.optimizedtrips.v1.models']/class[@name='OptimizedTripsResponse']/method[@name='setCode' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setCode", "(Ljava/lang/String;)V", "GetSetCode_Ljava_lang_String_Handler")]
			set {
				if (id_setCode_Ljava_lang_String_ == IntPtr.Zero)
					id_setCode_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setCode", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setCode_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setCode", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getTrips;
#pragma warning disable 0169
		static Delegate GetGetTripsHandler ()
		{
			if (cb_getTrips == null)
				cb_getTrips = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetTrips);
			return cb_getTrips;
		}

		static IntPtr n_GetTrips (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mapbox.Services.Api.Optimizedtrips.V1.Models.OptimizedTripsResponse __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Services.Api.Optimizedtrips.V1.Models.OptimizedTripsResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList<global::Com.Mapbox.Services.Api.Directions.V5.Models.DirectionsRoute>.ToLocalJniHandle (__this.Trips);
		}
#pragma warning restore 0169

		static Delegate cb_setTrips_Ljava_util_List_;
#pragma warning disable 0169
		static Delegate GetSetTrips_Ljava_util_List_Handler ()
		{
			if (cb_setTrips_Ljava_util_List_ == null)
				cb_setTrips_Ljava_util_List_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetTrips_Ljava_util_List_);
			return cb_setTrips_Ljava_util_List_;
		}

		static void n_SetTrips_Ljava_util_List_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Mapbox.Services.Api.Optimizedtrips.V1.Models.OptimizedTripsResponse __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Services.Api.Optimizedtrips.V1.Models.OptimizedTripsResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Android.Runtime.JavaList<global::Com.Mapbox.Services.Api.Directions.V5.Models.DirectionsRoute>.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Trips = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getTrips;
		static IntPtr id_setTrips_Ljava_util_List_;
		public virtual unsafe global::System.Collections.Generic.IList<global::Com.Mapbox.Services.Api.Directions.V5.Models.DirectionsRoute> Trips {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.services.api.optimizedtrips.v1.models']/class[@name='OptimizedTripsResponse']/method[@name='getTrips' and count(parameter)=0]"
			[Register ("getTrips", "()Ljava/util/List;", "GetGetTripsHandler")]
			get {
				if (id_getTrips == IntPtr.Zero)
					id_getTrips = JNIEnv.GetMethodID (class_ref, "getTrips", "()Ljava/util/List;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Android.Runtime.JavaList<global::Com.Mapbox.Services.Api.Directions.V5.Models.DirectionsRoute>.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getTrips), JniHandleOwnership.TransferLocalRef);
					else
						return global::Android.Runtime.JavaList<global::Com.Mapbox.Services.Api.Directions.V5.Models.DirectionsRoute>.FromJniHandle (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getTrips", "()Ljava/util/List;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.services.api.optimizedtrips.v1.models']/class[@name='OptimizedTripsResponse']/method[@name='setTrips' and count(parameter)=1 and parameter[1][@type='java.util.List&lt;com.mapbox.services.api.directions.v5.models.DirectionsRoute&gt;']]"
			[Register ("setTrips", "(Ljava/util/List;)V", "GetSetTrips_Ljava_util_List_Handler")]
			set {
				if (id_setTrips_Ljava_util_List_ == IntPtr.Zero)
					id_setTrips_Ljava_util_List_ = JNIEnv.GetMethodID (class_ref, "setTrips", "(Ljava/util/List;)V");
				IntPtr native_value = global::Android.Runtime.JavaList<global::Com.Mapbox.Services.Api.Directions.V5.Models.DirectionsRoute>.ToLocalJniHandle (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setTrips_Ljava_util_List_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setTrips", "(Ljava/util/List;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getWaypoints;
#pragma warning disable 0169
		static Delegate GetGetWaypointsHandler ()
		{
			if (cb_getWaypoints == null)
				cb_getWaypoints = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetWaypoints);
			return cb_getWaypoints;
		}

		static IntPtr n_GetWaypoints (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mapbox.Services.Api.Optimizedtrips.V1.Models.OptimizedTripsResponse __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Services.Api.Optimizedtrips.V1.Models.OptimizedTripsResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList<global::Com.Mapbox.Services.Api.Optimizedtrips.V1.Models.OptimizationWaypoint>.ToLocalJniHandle (__this.Waypoints);
		}
#pragma warning restore 0169

		static Delegate cb_setWaypoints_Ljava_util_List_;
#pragma warning disable 0169
		static Delegate GetSetWaypoints_Ljava_util_List_Handler ()
		{
			if (cb_setWaypoints_Ljava_util_List_ == null)
				cb_setWaypoints_Ljava_util_List_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetWaypoints_Ljava_util_List_);
			return cb_setWaypoints_Ljava_util_List_;
		}

		static void n_SetWaypoints_Ljava_util_List_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Mapbox.Services.Api.Optimizedtrips.V1.Models.OptimizedTripsResponse __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Services.Api.Optimizedtrips.V1.Models.OptimizedTripsResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Android.Runtime.JavaList<global::Com.Mapbox.Services.Api.Optimizedtrips.V1.Models.OptimizationWaypoint>.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Waypoints = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getWaypoints;
		static IntPtr id_setWaypoints_Ljava_util_List_;
		public virtual unsafe global::System.Collections.Generic.IList<global::Com.Mapbox.Services.Api.Optimizedtrips.V1.Models.OptimizationWaypoint> Waypoints {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.services.api.optimizedtrips.v1.models']/class[@name='OptimizedTripsResponse']/method[@name='getWaypoints' and count(parameter)=0]"
			[Register ("getWaypoints", "()Ljava/util/List;", "GetGetWaypointsHandler")]
			get {
				if (id_getWaypoints == IntPtr.Zero)
					id_getWaypoints = JNIEnv.GetMethodID (class_ref, "getWaypoints", "()Ljava/util/List;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Android.Runtime.JavaList<global::Com.Mapbox.Services.Api.Optimizedtrips.V1.Models.OptimizationWaypoint>.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getWaypoints), JniHandleOwnership.TransferLocalRef);
					else
						return global::Android.Runtime.JavaList<global::Com.Mapbox.Services.Api.Optimizedtrips.V1.Models.OptimizationWaypoint>.FromJniHandle (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getWaypoints", "()Ljava/util/List;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.services.api.optimizedtrips.v1.models']/class[@name='OptimizedTripsResponse']/method[@name='setWaypoints' and count(parameter)=1 and parameter[1][@type='java.util.List&lt;com.mapbox.services.api.optimizedtrips.v1.models.OptimizationWaypoint&gt;']]"
			[Register ("setWaypoints", "(Ljava/util/List;)V", "GetSetWaypoints_Ljava_util_List_Handler")]
			set {
				if (id_setWaypoints_Ljava_util_List_ == IntPtr.Zero)
					id_setWaypoints_Ljava_util_List_ = JNIEnv.GetMethodID (class_ref, "setWaypoints", "(Ljava/util/List;)V");
				IntPtr native_value = global::Android.Runtime.JavaList<global::Com.Mapbox.Services.Api.Optimizedtrips.V1.Models.OptimizationWaypoint>.ToLocalJniHandle (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setWaypoints_Ljava_util_List_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setWaypoints", "(Ljava/util/List;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

	}
}
