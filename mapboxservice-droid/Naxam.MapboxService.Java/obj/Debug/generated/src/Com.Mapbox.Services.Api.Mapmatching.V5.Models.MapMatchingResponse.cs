using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Mapbox.Services.Api.Mapmatching.V5.Models {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.mapbox.services.api.mapmatching.v5.models']/class[@name='MapMatchingResponse']"
	[global::Android.Runtime.Register ("com/mapbox/services/api/mapmatching/v5/models/MapMatchingResponse", DoNotGenerateAcw=true)]
	public partial class MapMatchingResponse : global::Java.Lang.Object {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/mapbox/services/api/mapmatching/v5/models/MapMatchingResponse", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (MapMatchingResponse); }
		}

		protected MapMatchingResponse (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.mapbox.services.api.mapmatching.v5.models']/class[@name='MapMatchingResponse']/constructor[@name='MapMatchingResponse' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe MapMatchingResponse ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (MapMatchingResponse)) {
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
			global::Com.Mapbox.Services.Api.Mapmatching.V5.Models.MapMatchingResponse __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Services.Api.Mapmatching.V5.Models.MapMatchingResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Com.Mapbox.Services.Api.Mapmatching.V5.Models.MapMatchingResponse __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Services.Api.Mapmatching.V5.Models.MapMatchingResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Code = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getCode;
		static IntPtr id_setCode_Ljava_lang_String_;
		public virtual unsafe string Code {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.services.api.mapmatching.v5.models']/class[@name='MapMatchingResponse']/method[@name='getCode' and count(parameter)=0]"
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
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.services.api.mapmatching.v5.models']/class[@name='MapMatchingResponse']/method[@name='setCode' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
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

		static Delegate cb_getMatchings;
#pragma warning disable 0169
		static Delegate GetGetMatchingsHandler ()
		{
			if (cb_getMatchings == null)
				cb_getMatchings = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetMatchings);
			return cb_getMatchings;
		}

		static IntPtr n_GetMatchings (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mapbox.Services.Api.Mapmatching.V5.Models.MapMatchingResponse __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Services.Api.Mapmatching.V5.Models.MapMatchingResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList<global::Com.Mapbox.Services.Api.Mapmatching.V5.Models.MapMatchingMatching>.ToLocalJniHandle (__this.Matchings);
		}
#pragma warning restore 0169

		static Delegate cb_setMatchings_Ljava_util_List_;
#pragma warning disable 0169
		static Delegate GetSetMatchings_Ljava_util_List_Handler ()
		{
			if (cb_setMatchings_Ljava_util_List_ == null)
				cb_setMatchings_Ljava_util_List_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetMatchings_Ljava_util_List_);
			return cb_setMatchings_Ljava_util_List_;
		}

		static void n_SetMatchings_Ljava_util_List_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Mapbox.Services.Api.Mapmatching.V5.Models.MapMatchingResponse __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Services.Api.Mapmatching.V5.Models.MapMatchingResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Android.Runtime.JavaList<global::Com.Mapbox.Services.Api.Mapmatching.V5.Models.MapMatchingMatching>.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Matchings = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getMatchings;
		static IntPtr id_setMatchings_Ljava_util_List_;
		public virtual unsafe global::System.Collections.Generic.IList<global::Com.Mapbox.Services.Api.Mapmatching.V5.Models.MapMatchingMatching> Matchings {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.services.api.mapmatching.v5.models']/class[@name='MapMatchingResponse']/method[@name='getMatchings' and count(parameter)=0]"
			[Register ("getMatchings", "()Ljava/util/List;", "GetGetMatchingsHandler")]
			get {
				if (id_getMatchings == IntPtr.Zero)
					id_getMatchings = JNIEnv.GetMethodID (class_ref, "getMatchings", "()Ljava/util/List;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Android.Runtime.JavaList<global::Com.Mapbox.Services.Api.Mapmatching.V5.Models.MapMatchingMatching>.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getMatchings), JniHandleOwnership.TransferLocalRef);
					else
						return global::Android.Runtime.JavaList<global::Com.Mapbox.Services.Api.Mapmatching.V5.Models.MapMatchingMatching>.FromJniHandle (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getMatchings", "()Ljava/util/List;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.services.api.mapmatching.v5.models']/class[@name='MapMatchingResponse']/method[@name='setMatchings' and count(parameter)=1 and parameter[1][@type='java.util.List&lt;com.mapbox.services.api.mapmatching.v5.models.MapMatchingMatching&gt;']]"
			[Register ("setMatchings", "(Ljava/util/List;)V", "GetSetMatchings_Ljava_util_List_Handler")]
			set {
				if (id_setMatchings_Ljava_util_List_ == IntPtr.Zero)
					id_setMatchings_Ljava_util_List_ = JNIEnv.GetMethodID (class_ref, "setMatchings", "(Ljava/util/List;)V");
				IntPtr native_value = global::Android.Runtime.JavaList<global::Com.Mapbox.Services.Api.Mapmatching.V5.Models.MapMatchingMatching>.ToLocalJniHandle (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setMatchings_Ljava_util_List_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setMatchings", "(Ljava/util/List;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getTracepoints;
#pragma warning disable 0169
		static Delegate GetGetTracepointsHandler ()
		{
			if (cb_getTracepoints == null)
				cb_getTracepoints = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetTracepoints);
			return cb_getTracepoints;
		}

		static IntPtr n_GetTracepoints (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mapbox.Services.Api.Mapmatching.V5.Models.MapMatchingResponse __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Services.Api.Mapmatching.V5.Models.MapMatchingResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList<global::Com.Mapbox.Services.Api.Mapmatching.V5.Models.MapMatchingTracepoint>.ToLocalJniHandle (__this.Tracepoints);
		}
#pragma warning restore 0169

		static Delegate cb_setTracepoints_Ljava_util_List_;
#pragma warning disable 0169
		static Delegate GetSetTracepoints_Ljava_util_List_Handler ()
		{
			if (cb_setTracepoints_Ljava_util_List_ == null)
				cb_setTracepoints_Ljava_util_List_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetTracepoints_Ljava_util_List_);
			return cb_setTracepoints_Ljava_util_List_;
		}

		static void n_SetTracepoints_Ljava_util_List_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Mapbox.Services.Api.Mapmatching.V5.Models.MapMatchingResponse __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Services.Api.Mapmatching.V5.Models.MapMatchingResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Android.Runtime.JavaList<global::Com.Mapbox.Services.Api.Mapmatching.V5.Models.MapMatchingTracepoint>.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Tracepoints = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getTracepoints;
		static IntPtr id_setTracepoints_Ljava_util_List_;
		public virtual unsafe global::System.Collections.Generic.IList<global::Com.Mapbox.Services.Api.Mapmatching.V5.Models.MapMatchingTracepoint> Tracepoints {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.services.api.mapmatching.v5.models']/class[@name='MapMatchingResponse']/method[@name='getTracepoints' and count(parameter)=0]"
			[Register ("getTracepoints", "()Ljava/util/List;", "GetGetTracepointsHandler")]
			get {
				if (id_getTracepoints == IntPtr.Zero)
					id_getTracepoints = JNIEnv.GetMethodID (class_ref, "getTracepoints", "()Ljava/util/List;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Android.Runtime.JavaList<global::Com.Mapbox.Services.Api.Mapmatching.V5.Models.MapMatchingTracepoint>.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getTracepoints), JniHandleOwnership.TransferLocalRef);
					else
						return global::Android.Runtime.JavaList<global::Com.Mapbox.Services.Api.Mapmatching.V5.Models.MapMatchingTracepoint>.FromJniHandle (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getTracepoints", "()Ljava/util/List;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.services.api.mapmatching.v5.models']/class[@name='MapMatchingResponse']/method[@name='setTracepoints' and count(parameter)=1 and parameter[1][@type='java.util.List&lt;com.mapbox.services.api.mapmatching.v5.models.MapMatchingTracepoint&gt;']]"
			[Register ("setTracepoints", "(Ljava/util/List;)V", "GetSetTracepoints_Ljava_util_List_Handler")]
			set {
				if (id_setTracepoints_Ljava_util_List_ == IntPtr.Zero)
					id_setTracepoints_Ljava_util_List_ = JNIEnv.GetMethodID (class_ref, "setTracepoints", "(Ljava/util/List;)V");
				IntPtr native_value = global::Android.Runtime.JavaList<global::Com.Mapbox.Services.Api.Mapmatching.V5.Models.MapMatchingTracepoint>.ToLocalJniHandle (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setTracepoints_Ljava_util_List_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setTracepoints", "(Ljava/util/List;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

	}
}
