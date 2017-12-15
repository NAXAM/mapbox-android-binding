using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Mapbox.Services.Api.Directions.V5.Models {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.mapbox.services.api.directions.v5.models']/class[@name='RouteLeg']"
	[global::Android.Runtime.Register ("com/mapbox/services/api/directions/v5/models/RouteLeg", DoNotGenerateAcw=true)]
	public partial class RouteLeg : global::Java.Lang.Object {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/mapbox/services/api/directions/v5/models/RouteLeg", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (RouteLeg); }
		}

		protected RouteLeg (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.mapbox.services.api.directions.v5.models']/class[@name='RouteLeg']/constructor[@name='RouteLeg' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe RouteLeg ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (RouteLeg)) {
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

		static Delegate cb_getAnnotation;
#pragma warning disable 0169
		static Delegate GetGetAnnotationHandler ()
		{
			if (cb_getAnnotation == null)
				cb_getAnnotation = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetAnnotation);
			return cb_getAnnotation;
		}

		static IntPtr n_GetAnnotation (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mapbox.Services.Api.Directions.V5.Models.RouteLeg __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Services.Api.Directions.V5.Models.RouteLeg> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Annotation);
		}
#pragma warning restore 0169

		static Delegate cb_setAnnotation_Lcom_mapbox_services_api_directions_v5_models_LegAnnotation_;
#pragma warning disable 0169
		static Delegate GetSetAnnotation_Lcom_mapbox_services_api_directions_v5_models_LegAnnotation_Handler ()
		{
			if (cb_setAnnotation_Lcom_mapbox_services_api_directions_v5_models_LegAnnotation_ == null)
				cb_setAnnotation_Lcom_mapbox_services_api_directions_v5_models_LegAnnotation_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetAnnotation_Lcom_mapbox_services_api_directions_v5_models_LegAnnotation_);
			return cb_setAnnotation_Lcom_mapbox_services_api_directions_v5_models_LegAnnotation_;
		}

		static void n_SetAnnotation_Lcom_mapbox_services_api_directions_v5_models_LegAnnotation_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Mapbox.Services.Api.Directions.V5.Models.RouteLeg __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Services.Api.Directions.V5.Models.RouteLeg> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Mapbox.Services.Api.Directions.V5.Models.LegAnnotation p0 = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Services.Api.Directions.V5.Models.LegAnnotation> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Annotation = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getAnnotation;
		static IntPtr id_setAnnotation_Lcom_mapbox_services_api_directions_v5_models_LegAnnotation_;
		public virtual unsafe global::Com.Mapbox.Services.Api.Directions.V5.Models.LegAnnotation Annotation {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.services.api.directions.v5.models']/class[@name='RouteLeg']/method[@name='getAnnotation' and count(parameter)=0]"
			[Register ("getAnnotation", "()Lcom/mapbox/services/api/directions/v5/models/LegAnnotation;", "GetGetAnnotationHandler")]
			get {
				if (id_getAnnotation == IntPtr.Zero)
					id_getAnnotation = JNIEnv.GetMethodID (class_ref, "getAnnotation", "()Lcom/mapbox/services/api/directions/v5/models/LegAnnotation;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Services.Api.Directions.V5.Models.LegAnnotation> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getAnnotation), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Services.Api.Directions.V5.Models.LegAnnotation> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getAnnotation", "()Lcom/mapbox/services/api/directions/v5/models/LegAnnotation;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.services.api.directions.v5.models']/class[@name='RouteLeg']/method[@name='setAnnotation' and count(parameter)=1 and parameter[1][@type='com.mapbox.services.api.directions.v5.models.LegAnnotation']]"
			[Register ("setAnnotation", "(Lcom/mapbox/services/api/directions/v5/models/LegAnnotation;)V", "GetSetAnnotation_Lcom_mapbox_services_api_directions_v5_models_LegAnnotation_Handler")]
			set {
				if (id_setAnnotation_Lcom_mapbox_services_api_directions_v5_models_LegAnnotation_ == IntPtr.Zero)
					id_setAnnotation_Lcom_mapbox_services_api_directions_v5_models_LegAnnotation_ = JNIEnv.GetMethodID (class_ref, "setAnnotation", "(Lcom/mapbox/services/api/directions/v5/models/LegAnnotation;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setAnnotation_Lcom_mapbox_services_api_directions_v5_models_LegAnnotation_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setAnnotation", "(Lcom/mapbox/services/api/directions/v5/models/LegAnnotation;)V"), __args);
				} finally {
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
			global::Com.Mapbox.Services.Api.Directions.V5.Models.RouteLeg __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Services.Api.Directions.V5.Models.RouteLeg> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Com.Mapbox.Services.Api.Directions.V5.Models.RouteLeg __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Services.Api.Directions.V5.Models.RouteLeg> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Distance = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getDistance;
		static IntPtr id_setDistance_D;
		public virtual unsafe double Distance {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.services.api.directions.v5.models']/class[@name='RouteLeg']/method[@name='getDistance' and count(parameter)=0]"
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
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.services.api.directions.v5.models']/class[@name='RouteLeg']/method[@name='setDistance' and count(parameter)=1 and parameter[1][@type='double']]"
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
			global::Com.Mapbox.Services.Api.Directions.V5.Models.RouteLeg __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Services.Api.Directions.V5.Models.RouteLeg> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Com.Mapbox.Services.Api.Directions.V5.Models.RouteLeg __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Services.Api.Directions.V5.Models.RouteLeg> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Duration = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getDuration;
		static IntPtr id_setDuration_D;
		public virtual unsafe double Duration {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.services.api.directions.v5.models']/class[@name='RouteLeg']/method[@name='getDuration' and count(parameter)=0]"
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
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.services.api.directions.v5.models']/class[@name='RouteLeg']/method[@name='setDuration' and count(parameter)=1 and parameter[1][@type='double']]"
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

		static Delegate cb_getSteps;
#pragma warning disable 0169
		static Delegate GetGetStepsHandler ()
		{
			if (cb_getSteps == null)
				cb_getSteps = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetSteps);
			return cb_getSteps;
		}

		static IntPtr n_GetSteps (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mapbox.Services.Api.Directions.V5.Models.RouteLeg __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Services.Api.Directions.V5.Models.RouteLeg> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList<global::Com.Mapbox.Services.Api.Directions.V5.Models.LegStep>.ToLocalJniHandle (__this.Steps);
		}
#pragma warning restore 0169

		static Delegate cb_setSteps_Ljava_util_List_;
#pragma warning disable 0169
		static Delegate GetSetSteps_Ljava_util_List_Handler ()
		{
			if (cb_setSteps_Ljava_util_List_ == null)
				cb_setSteps_Ljava_util_List_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetSteps_Ljava_util_List_);
			return cb_setSteps_Ljava_util_List_;
		}

		static void n_SetSteps_Ljava_util_List_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Mapbox.Services.Api.Directions.V5.Models.RouteLeg __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Services.Api.Directions.V5.Models.RouteLeg> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Android.Runtime.JavaList<global::Com.Mapbox.Services.Api.Directions.V5.Models.LegStep>.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Steps = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getSteps;
		static IntPtr id_setSteps_Ljava_util_List_;
		public virtual unsafe global::System.Collections.Generic.IList<global::Com.Mapbox.Services.Api.Directions.V5.Models.LegStep> Steps {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.services.api.directions.v5.models']/class[@name='RouteLeg']/method[@name='getSteps' and count(parameter)=0]"
			[Register ("getSteps", "()Ljava/util/List;", "GetGetStepsHandler")]
			get {
				if (id_getSteps == IntPtr.Zero)
					id_getSteps = JNIEnv.GetMethodID (class_ref, "getSteps", "()Ljava/util/List;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Android.Runtime.JavaList<global::Com.Mapbox.Services.Api.Directions.V5.Models.LegStep>.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getSteps), JniHandleOwnership.TransferLocalRef);
					else
						return global::Android.Runtime.JavaList<global::Com.Mapbox.Services.Api.Directions.V5.Models.LegStep>.FromJniHandle (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getSteps", "()Ljava/util/List;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.services.api.directions.v5.models']/class[@name='RouteLeg']/method[@name='setSteps' and count(parameter)=1 and parameter[1][@type='java.util.List&lt;com.mapbox.services.api.directions.v5.models.LegStep&gt;']]"
			[Register ("setSteps", "(Ljava/util/List;)V", "GetSetSteps_Ljava_util_List_Handler")]
			set {
				if (id_setSteps_Ljava_util_List_ == IntPtr.Zero)
					id_setSteps_Ljava_util_List_ = JNIEnv.GetMethodID (class_ref, "setSteps", "(Ljava/util/List;)V");
				IntPtr native_value = global::Android.Runtime.JavaList<global::Com.Mapbox.Services.Api.Directions.V5.Models.LegStep>.ToLocalJniHandle (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setSteps_Ljava_util_List_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setSteps", "(Ljava/util/List;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getSummary;
#pragma warning disable 0169
		static Delegate GetGetSummaryHandler ()
		{
			if (cb_getSummary == null)
				cb_getSummary = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetSummary);
			return cb_getSummary;
		}

		static IntPtr n_GetSummary (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mapbox.Services.Api.Directions.V5.Models.RouteLeg __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Services.Api.Directions.V5.Models.RouteLeg> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Summary);
		}
#pragma warning restore 0169

		static Delegate cb_setSummary_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetSummary_Ljava_lang_String_Handler ()
		{
			if (cb_setSummary_Ljava_lang_String_ == null)
				cb_setSummary_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetSummary_Ljava_lang_String_);
			return cb_setSummary_Ljava_lang_String_;
		}

		static void n_SetSummary_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Mapbox.Services.Api.Directions.V5.Models.RouteLeg __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Services.Api.Directions.V5.Models.RouteLeg> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Summary = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getSummary;
		static IntPtr id_setSummary_Ljava_lang_String_;
		public virtual unsafe string Summary {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.services.api.directions.v5.models']/class[@name='RouteLeg']/method[@name='getSummary' and count(parameter)=0]"
			[Register ("getSummary", "()Ljava/lang/String;", "GetGetSummaryHandler")]
			get {
				if (id_getSummary == IntPtr.Zero)
					id_getSummary = JNIEnv.GetMethodID (class_ref, "getSummary", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getSummary), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getSummary", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.services.api.directions.v5.models']/class[@name='RouteLeg']/method[@name='setSummary' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setSummary", "(Ljava/lang/String;)V", "GetSetSummary_Ljava_lang_String_Handler")]
			set {
				if (id_setSummary_Ljava_lang_String_ == IntPtr.Zero)
					id_setSummary_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setSummary", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setSummary_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setSummary", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

	}
}
