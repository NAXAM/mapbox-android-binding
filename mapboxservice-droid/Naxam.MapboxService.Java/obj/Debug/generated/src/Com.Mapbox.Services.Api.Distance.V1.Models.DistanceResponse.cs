using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Mapbox.Services.Api.Distance.V1.Models {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.mapbox.services.api.distance.v1.models']/class[@name='DistanceResponse']"
	[ObsoleteAttribute (@"This class is obsoleted in this android platform")]
	[global::Android.Runtime.Register ("com/mapbox/services/api/distance/v1/models/DistanceResponse", DoNotGenerateAcw=true)]
	public partial class DistanceResponse : global::Com.Mapbox.Services.Commons.Geojson.FeatureCollection {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/mapbox/services/api/distance/v1/models/DistanceResponse", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (DistanceResponse); }
		}

		protected DistanceResponse (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Ljava_util_List_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.mapbox.services.api.distance.v1.models']/class[@name='DistanceResponse']/constructor[@name='DistanceResponse' and count(parameter)=1 and parameter[1][@type='java.util.List&lt;com.mapbox.services.commons.geojson.Feature&gt;']]"
		[Register (".ctor", "(Ljava/util/List;)V", "")]
		protected unsafe DistanceResponse (global::System.Collections.Generic.IList<global::Com.Mapbox.Services.Commons.Geojson.Feature> p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_p0 = global::Android.Runtime.JavaList<global::Com.Mapbox.Services.Commons.Geojson.Feature>.ToLocalJniHandle (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				if (((object) this).GetType () != typeof (DistanceResponse)) {
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
			global::Com.Mapbox.Services.Api.Distance.V1.Models.DistanceResponse __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Services.Api.Distance.V1.Models.DistanceResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Com.Mapbox.Services.Api.Distance.V1.Models.DistanceResponse __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Services.Api.Distance.V1.Models.DistanceResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Code = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getCode;
		static IntPtr id_setCode_Ljava_lang_String_;
		[Obsolete (@"deprecated")]
		public virtual unsafe string Code {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.services.api.distance.v1.models']/class[@name='DistanceResponse']/method[@name='getCode' and count(parameter)=0]"
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
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.services.api.distance.v1.models']/class[@name='DistanceResponse']/method[@name='setCode' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
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
			global::Com.Mapbox.Services.Api.Distance.V1.Models.DistanceResponse __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Services.Api.Distance.V1.Models.DistanceResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetDurations ());
		}
#pragma warning restore 0169

		static IntPtr id_getDurations;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.services.api.distance.v1.models']/class[@name='DistanceResponse']/method[@name='getDurations' and count(parameter)=0]"
		[Obsolete (@"deprecated")]
		[Register ("getDurations", "()[[I", "GetGetDurationsHandler")]
		public virtual unsafe int[][] GetDurations ()
		{
			if (id_getDurations == IntPtr.Zero)
				id_getDurations = JNIEnv.GetMethodID (class_ref, "getDurations", "()[[I");
			try {

				if (((object) this).GetType () == ThresholdType)
					return (int[][]) JNIEnv.GetArray (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getDurations), JniHandleOwnership.TransferLocalRef, typeof (int[]));
				else
					return (int[][]) JNIEnv.GetArray (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getDurations", "()[[I")), JniHandleOwnership.TransferLocalRef, typeof (int[]));
			} finally {
			}
		}

	}
}
