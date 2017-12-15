using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Mapbox.Services.Api.Directions.V5.Models {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.mapbox.services.api.directions.v5.models']/class[@name='DirectionsRoute']"
	[global::Android.Runtime.Register ("com/mapbox/services/api/directions/v5/models/DirectionsRoute", DoNotGenerateAcw=true)]
	public partial class DirectionsRoute : global::Java.Lang.Object {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/mapbox/services/api/directions/v5/models/DirectionsRoute", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (DirectionsRoute); }
		}

		protected DirectionsRoute (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.mapbox.services.api.directions.v5.models']/class[@name='DirectionsRoute']/constructor[@name='DirectionsRoute' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe DirectionsRoute ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (DirectionsRoute)) {
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
			global::Com.Mapbox.Services.Api.Directions.V5.Models.DirectionsRoute __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Services.Api.Directions.V5.Models.DirectionsRoute> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Com.Mapbox.Services.Api.Directions.V5.Models.DirectionsRoute __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Services.Api.Directions.V5.Models.DirectionsRoute> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Distance = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getDistance;
		static IntPtr id_setDistance_D;
		public virtual unsafe double Distance {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.services.api.directions.v5.models']/class[@name='DirectionsRoute']/method[@name='getDistance' and count(parameter)=0]"
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
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.services.api.directions.v5.models']/class[@name='DirectionsRoute']/method[@name='setDistance' and count(parameter)=1 and parameter[1][@type='double']]"
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
			global::Com.Mapbox.Services.Api.Directions.V5.Models.DirectionsRoute __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Services.Api.Directions.V5.Models.DirectionsRoute> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Com.Mapbox.Services.Api.Directions.V5.Models.DirectionsRoute __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Services.Api.Directions.V5.Models.DirectionsRoute> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Duration = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getDuration;
		static IntPtr id_setDuration_D;
		public virtual unsafe double Duration {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.services.api.directions.v5.models']/class[@name='DirectionsRoute']/method[@name='getDuration' and count(parameter)=0]"
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
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.services.api.directions.v5.models']/class[@name='DirectionsRoute']/method[@name='setDuration' and count(parameter)=1 and parameter[1][@type='double']]"
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
			global::Com.Mapbox.Services.Api.Directions.V5.Models.DirectionsRoute __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Services.Api.Directions.V5.Models.DirectionsRoute> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Com.Mapbox.Services.Api.Directions.V5.Models.DirectionsRoute __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Services.Api.Directions.V5.Models.DirectionsRoute> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Geometry = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getGeometry;
		static IntPtr id_setGeometry_Ljava_lang_String_;
		public virtual unsafe string Geometry {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.services.api.directions.v5.models']/class[@name='DirectionsRoute']/method[@name='getGeometry' and count(parameter)=0]"
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
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.services.api.directions.v5.models']/class[@name='DirectionsRoute']/method[@name='setGeometry' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
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

		static Delegate cb_getLegs;
#pragma warning disable 0169
		static Delegate GetGetLegsHandler ()
		{
			if (cb_getLegs == null)
				cb_getLegs = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetLegs);
			return cb_getLegs;
		}

		static IntPtr n_GetLegs (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mapbox.Services.Api.Directions.V5.Models.DirectionsRoute __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Services.Api.Directions.V5.Models.DirectionsRoute> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList<global::Com.Mapbox.Services.Api.Directions.V5.Models.RouteLeg>.ToLocalJniHandle (__this.Legs);
		}
#pragma warning restore 0169

		static Delegate cb_setLegs_Ljava_util_List_;
#pragma warning disable 0169
		static Delegate GetSetLegs_Ljava_util_List_Handler ()
		{
			if (cb_setLegs_Ljava_util_List_ == null)
				cb_setLegs_Ljava_util_List_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetLegs_Ljava_util_List_);
			return cb_setLegs_Ljava_util_List_;
		}

		static void n_SetLegs_Ljava_util_List_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Mapbox.Services.Api.Directions.V5.Models.DirectionsRoute __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Services.Api.Directions.V5.Models.DirectionsRoute> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Android.Runtime.JavaList<global::Com.Mapbox.Services.Api.Directions.V5.Models.RouteLeg>.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Legs = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getLegs;
		static IntPtr id_setLegs_Ljava_util_List_;
		public virtual unsafe global::System.Collections.Generic.IList<global::Com.Mapbox.Services.Api.Directions.V5.Models.RouteLeg> Legs {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.services.api.directions.v5.models']/class[@name='DirectionsRoute']/method[@name='getLegs' and count(parameter)=0]"
			[Register ("getLegs", "()Ljava/util/List;", "GetGetLegsHandler")]
			get {
				if (id_getLegs == IntPtr.Zero)
					id_getLegs = JNIEnv.GetMethodID (class_ref, "getLegs", "()Ljava/util/List;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Android.Runtime.JavaList<global::Com.Mapbox.Services.Api.Directions.V5.Models.RouteLeg>.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getLegs), JniHandleOwnership.TransferLocalRef);
					else
						return global::Android.Runtime.JavaList<global::Com.Mapbox.Services.Api.Directions.V5.Models.RouteLeg>.FromJniHandle (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getLegs", "()Ljava/util/List;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.services.api.directions.v5.models']/class[@name='DirectionsRoute']/method[@name='setLegs' and count(parameter)=1 and parameter[1][@type='java.util.List&lt;com.mapbox.services.api.directions.v5.models.RouteLeg&gt;']]"
			[Register ("setLegs", "(Ljava/util/List;)V", "GetSetLegs_Ljava_util_List_Handler")]
			set {
				if (id_setLegs_Ljava_util_List_ == IntPtr.Zero)
					id_setLegs_Ljava_util_List_ = JNIEnv.GetMethodID (class_ref, "setLegs", "(Ljava/util/List;)V");
				IntPtr native_value = global::Android.Runtime.JavaList<global::Com.Mapbox.Services.Api.Directions.V5.Models.RouteLeg>.ToLocalJniHandle (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setLegs_Ljava_util_List_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setLegs", "(Ljava/util/List;)V"), __args);
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
			global::Com.Mapbox.Services.Api.Directions.V5.Models.DirectionsRoute __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Services.Api.Directions.V5.Models.DirectionsRoute> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Com.Mapbox.Services.Api.Directions.V5.Models.DirectionsRoute __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Services.Api.Directions.V5.Models.DirectionsRoute> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Weight = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getWeight;
		static IntPtr id_setWeight_D;
		public virtual unsafe double Weight {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.services.api.directions.v5.models']/class[@name='DirectionsRoute']/method[@name='getWeight' and count(parameter)=0]"
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
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.services.api.directions.v5.models']/class[@name='DirectionsRoute']/method[@name='setWeight' and count(parameter)=1 and parameter[1][@type='double']]"
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

		static Delegate cb_getWeightName;
#pragma warning disable 0169
		static Delegate GetGetWeightNameHandler ()
		{
			if (cb_getWeightName == null)
				cb_getWeightName = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetWeightName);
			return cb_getWeightName;
		}

		static IntPtr n_GetWeightName (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mapbox.Services.Api.Directions.V5.Models.DirectionsRoute __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Services.Api.Directions.V5.Models.DirectionsRoute> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.WeightName);
		}
#pragma warning restore 0169

		static Delegate cb_setWeightName_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetWeightName_Ljava_lang_String_Handler ()
		{
			if (cb_setWeightName_Ljava_lang_String_ == null)
				cb_setWeightName_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetWeightName_Ljava_lang_String_);
			return cb_setWeightName_Ljava_lang_String_;
		}

		static void n_SetWeightName_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Mapbox.Services.Api.Directions.V5.Models.DirectionsRoute __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Services.Api.Directions.V5.Models.DirectionsRoute> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.WeightName = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getWeightName;
		static IntPtr id_setWeightName_Ljava_lang_String_;
		public virtual unsafe string WeightName {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.services.api.directions.v5.models']/class[@name='DirectionsRoute']/method[@name='getWeightName' and count(parameter)=0]"
			[Register ("getWeightName", "()Ljava/lang/String;", "GetGetWeightNameHandler")]
			get {
				if (id_getWeightName == IntPtr.Zero)
					id_getWeightName = JNIEnv.GetMethodID (class_ref, "getWeightName", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getWeightName), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getWeightName", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.services.api.directions.v5.models']/class[@name='DirectionsRoute']/method[@name='setWeightName' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setWeightName", "(Ljava/lang/String;)V", "GetSetWeightName_Ljava_lang_String_Handler")]
			set {
				if (id_setWeightName_Ljava_lang_String_ == IntPtr.Zero)
					id_setWeightName_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setWeightName", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setWeightName_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setWeightName", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

	}
}
