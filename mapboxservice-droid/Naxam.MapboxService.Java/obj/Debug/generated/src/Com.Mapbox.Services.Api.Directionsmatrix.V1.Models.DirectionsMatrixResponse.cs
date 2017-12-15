using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Mapbox.Services.Api.Directionsmatrix.V1.Models {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.mapbox.services.api.directionsmatrix.v1.models']/class[@name='DirectionsMatrixResponse']"
	[global::Android.Runtime.Register ("com/mapbox/services/api/directionsmatrix/v1/models/DirectionsMatrixResponse", DoNotGenerateAcw=true)]
	public partial class DirectionsMatrixResponse : global::Java.Lang.Object {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/mapbox/services/api/directionsmatrix/v1/models/DirectionsMatrixResponse", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (DirectionsMatrixResponse); }
		}

		protected DirectionsMatrixResponse (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.mapbox.services.api.directionsmatrix.v1.models']/class[@name='DirectionsMatrixResponse']/constructor[@name='DirectionsMatrixResponse' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe DirectionsMatrixResponse ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (DirectionsMatrixResponse)) {
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
			global::Com.Mapbox.Services.Api.Directionsmatrix.V1.Models.DirectionsMatrixResponse __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Services.Api.Directionsmatrix.V1.Models.DirectionsMatrixResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Com.Mapbox.Services.Api.Directionsmatrix.V1.Models.DirectionsMatrixResponse __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Services.Api.Directionsmatrix.V1.Models.DirectionsMatrixResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Code = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getCode;
		static IntPtr id_setCode_Ljava_lang_String_;
		public virtual unsafe string Code {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.services.api.directionsmatrix.v1.models']/class[@name='DirectionsMatrixResponse']/method[@name='getCode' and count(parameter)=0]"
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
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.services.api.directionsmatrix.v1.models']/class[@name='DirectionsMatrixResponse']/method[@name='setCode' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
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
			global::Com.Mapbox.Services.Api.Directionsmatrix.V1.Models.DirectionsMatrixResponse __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Services.Api.Directionsmatrix.V1.Models.DirectionsMatrixResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList<global::Com.Mapbox.Services.Api.Directions.V5.Models.DirectionsWaypoint>.ToLocalJniHandle (__this.Destinations);
		}
#pragma warning restore 0169

		static Delegate cb_setDestinations_Ljava_util_List_;
#pragma warning disable 0169
		static Delegate GetSetDestinations_Ljava_util_List_Handler ()
		{
			if (cb_setDestinations_Ljava_util_List_ == null)
				cb_setDestinations_Ljava_util_List_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetDestinations_Ljava_util_List_);
			return cb_setDestinations_Ljava_util_List_;
		}

		static void n_SetDestinations_Ljava_util_List_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Mapbox.Services.Api.Directionsmatrix.V1.Models.DirectionsMatrixResponse __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Services.Api.Directionsmatrix.V1.Models.DirectionsMatrixResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Android.Runtime.JavaList<global::Com.Mapbox.Services.Api.Directions.V5.Models.DirectionsWaypoint>.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Destinations = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getDestinations;
		static IntPtr id_setDestinations_Ljava_util_List_;
		public virtual unsafe global::System.Collections.Generic.IList<global::Com.Mapbox.Services.Api.Directions.V5.Models.DirectionsWaypoint> Destinations {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.services.api.directionsmatrix.v1.models']/class[@name='DirectionsMatrixResponse']/method[@name='getDestinations' and count(parameter)=0]"
			[Register ("getDestinations", "()Ljava/util/List;", "GetGetDestinationsHandler")]
			get {
				if (id_getDestinations == IntPtr.Zero)
					id_getDestinations = JNIEnv.GetMethodID (class_ref, "getDestinations", "()Ljava/util/List;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Android.Runtime.JavaList<global::Com.Mapbox.Services.Api.Directions.V5.Models.DirectionsWaypoint>.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getDestinations), JniHandleOwnership.TransferLocalRef);
					else
						return global::Android.Runtime.JavaList<global::Com.Mapbox.Services.Api.Directions.V5.Models.DirectionsWaypoint>.FromJniHandle (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getDestinations", "()Ljava/util/List;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.services.api.directionsmatrix.v1.models']/class[@name='DirectionsMatrixResponse']/method[@name='setDestinations' and count(parameter)=1 and parameter[1][@type='java.util.List&lt;com.mapbox.services.api.directions.v5.models.DirectionsWaypoint&gt;']]"
			[Register ("setDestinations", "(Ljava/util/List;)V", "GetSetDestinations_Ljava_util_List_Handler")]
			set {
				if (id_setDestinations_Ljava_util_List_ == IntPtr.Zero)
					id_setDestinations_Ljava_util_List_ = JNIEnv.GetMethodID (class_ref, "setDestinations", "(Ljava/util/List;)V");
				IntPtr native_value = global::Android.Runtime.JavaList<global::Com.Mapbox.Services.Api.Directions.V5.Models.DirectionsWaypoint>.ToLocalJniHandle (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setDestinations_Ljava_util_List_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setDestinations", "(Ljava/util/List;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getSources;
#pragma warning disable 0169
		static Delegate GetGetSourcesHandler ()
		{
			if (cb_getSources == null)
				cb_getSources = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetSources);
			return cb_getSources;
		}

		static IntPtr n_GetSources (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mapbox.Services.Api.Directionsmatrix.V1.Models.DirectionsMatrixResponse __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Services.Api.Directionsmatrix.V1.Models.DirectionsMatrixResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList<global::Com.Mapbox.Services.Api.Directions.V5.Models.DirectionsWaypoint>.ToLocalJniHandle (__this.Sources);
		}
#pragma warning restore 0169

		static Delegate cb_setSources_Ljava_util_List_;
#pragma warning disable 0169
		static Delegate GetSetSources_Ljava_util_List_Handler ()
		{
			if (cb_setSources_Ljava_util_List_ == null)
				cb_setSources_Ljava_util_List_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetSources_Ljava_util_List_);
			return cb_setSources_Ljava_util_List_;
		}

		static void n_SetSources_Ljava_util_List_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Mapbox.Services.Api.Directionsmatrix.V1.Models.DirectionsMatrixResponse __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Services.Api.Directionsmatrix.V1.Models.DirectionsMatrixResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Android.Runtime.JavaList<global::Com.Mapbox.Services.Api.Directions.V5.Models.DirectionsWaypoint>.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Sources = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getSources;
		static IntPtr id_setSources_Ljava_util_List_;
		public virtual unsafe global::System.Collections.Generic.IList<global::Com.Mapbox.Services.Api.Directions.V5.Models.DirectionsWaypoint> Sources {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.services.api.directionsmatrix.v1.models']/class[@name='DirectionsMatrixResponse']/method[@name='getSources' and count(parameter)=0]"
			[Register ("getSources", "()Ljava/util/List;", "GetGetSourcesHandler")]
			get {
				if (id_getSources == IntPtr.Zero)
					id_getSources = JNIEnv.GetMethodID (class_ref, "getSources", "()Ljava/util/List;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Android.Runtime.JavaList<global::Com.Mapbox.Services.Api.Directions.V5.Models.DirectionsWaypoint>.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getSources), JniHandleOwnership.TransferLocalRef);
					else
						return global::Android.Runtime.JavaList<global::Com.Mapbox.Services.Api.Directions.V5.Models.DirectionsWaypoint>.FromJniHandle (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getSources", "()Ljava/util/List;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.services.api.directionsmatrix.v1.models']/class[@name='DirectionsMatrixResponse']/method[@name='setSources' and count(parameter)=1 and parameter[1][@type='java.util.List&lt;com.mapbox.services.api.directions.v5.models.DirectionsWaypoint&gt;']]"
			[Register ("setSources", "(Ljava/util/List;)V", "GetSetSources_Ljava_util_List_Handler")]
			set {
				if (id_setSources_Ljava_util_List_ == IntPtr.Zero)
					id_setSources_Ljava_util_List_ = JNIEnv.GetMethodID (class_ref, "setSources", "(Ljava/util/List;)V");
				IntPtr native_value = global::Android.Runtime.JavaList<global::Com.Mapbox.Services.Api.Directions.V5.Models.DirectionsWaypoint>.ToLocalJniHandle (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setSources_Ljava_util_List_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setSources", "(Ljava/util/List;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getDurations;
#pragma warning disable 0169
		static Delegate GetGetDurationsHandler ()
		{
			if (cb_getDurations == null)
				cb_getDurations = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetDurations);
			return cb_getDurations;
		}

		static IntPtr n_GetDurations (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mapbox.Services.Api.Directionsmatrix.V1.Models.DirectionsMatrixResponse __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Services.Api.Directionsmatrix.V1.Models.DirectionsMatrixResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetDurations ());
		}
#pragma warning restore 0169

		static IntPtr id_getDurations;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.services.api.directionsmatrix.v1.models']/class[@name='DirectionsMatrixResponse']/method[@name='getDurations' and count(parameter)=0]"
		[Register ("getDurations", "()[[D", "GetGetDurationsHandler")]
		public virtual unsafe double[][] GetDurations ()
		{
			if (id_getDurations == IntPtr.Zero)
				id_getDurations = JNIEnv.GetMethodID (class_ref, "getDurations", "()[[D");
			try {

				if (((object) this).GetType () == ThresholdType)
					return (double[][]) JNIEnv.GetArray (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getDurations), JniHandleOwnership.TransferLocalRef, typeof (double[]));
				else
					return (double[][]) JNIEnv.GetArray (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getDurations", "()[[D")), JniHandleOwnership.TransferLocalRef, typeof (double[]));
			} finally {
			}
		}

		static Delegate cb_setDurations_arrayarrayD;
#pragma warning disable 0169
		static Delegate GetSetDurations_arrayarrayDHandler ()
		{
			if (cb_setDurations_arrayarrayD == null)
				cb_setDurations_arrayarrayD = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetDurations_arrayarrayD);
			return cb_setDurations_arrayarrayD;
		}

		static void n_SetDurations_arrayarrayD (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Mapbox.Services.Api.Directionsmatrix.V1.Models.DirectionsMatrixResponse __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Services.Api.Directionsmatrix.V1.Models.DirectionsMatrixResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			double[][] p0 = (double[][]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (double[]));
			__this.SetDurations (p0);
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
		}
#pragma warning restore 0169

		static IntPtr id_setDurations_arrayarrayD;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.services.api.directionsmatrix.v1.models']/class[@name='DirectionsMatrixResponse']/method[@name='setDurations' and count(parameter)=1 and parameter[1][@type='double[][]']]"
		[Register ("setDurations", "([[D)V", "GetSetDurations_arrayarrayDHandler")]
		public virtual unsafe void SetDurations (double[][] p0)
		{
			if (id_setDurations_arrayarrayD == IntPtr.Zero)
				id_setDurations_arrayarrayD = JNIEnv.GetMethodID (class_ref, "setDurations", "([[D)V");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setDurations_arrayarrayD, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setDurations", "([[D)V"), __args);
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}
		}

	}
}
