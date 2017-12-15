using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Mapbox.Services.Api.Staticimage.V1.Models {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.mapbox.services.api.staticimage.v1.models']/class[@name='StaticPolylineAnnotation']"
	[global::Android.Runtime.Register ("com/mapbox/services/api/staticimage/v1/models/StaticPolylineAnnotation", DoNotGenerateAcw=true)]
	public partial class StaticPolylineAnnotation : global::Java.Lang.Object {

		// Metadata.xml XPath class reference: path="/api/package[@name='com.mapbox.services.api.staticimage.v1.models']/class[@name='StaticPolylineAnnotation.Builder']"
		[global::Android.Runtime.Register ("com/mapbox/services/api/staticimage/v1/models/StaticPolylineAnnotation$Builder", DoNotGenerateAcw=true)]
		public partial class Builder : global::Java.Lang.Object {

			internal static new IntPtr java_class_handle;
			internal static new IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/mapbox/services/api/staticimage/v1/models/StaticPolylineAnnotation$Builder", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (Builder); }
			}

			protected Builder (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.mapbox.services.api.staticimage.v1.models']/class[@name='StaticPolylineAnnotation.Builder']/constructor[@name='StaticPolylineAnnotation.Builder' and count(parameter)=0]"
			[Register (".ctor", "()V", "")]
			public unsafe Builder ()
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				try {
					if (((object) this).GetType () != typeof (Builder)) {
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

			static Delegate cb_getFillColor;
#pragma warning disable 0169
			static Delegate GetGetFillColorHandler ()
			{
				if (cb_getFillColor == null)
					cb_getFillColor = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetFillColor);
				return cb_getFillColor;
			}

			static IntPtr n_GetFillColor (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Mapbox.Services.Api.Staticimage.V1.Models.StaticPolylineAnnotation.Builder __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Services.Api.Staticimage.V1.Models.StaticPolylineAnnotation.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.NewString (__this.FillColor);
			}
#pragma warning restore 0169

			static IntPtr id_getFillColor;
			public virtual unsafe string FillColor {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.services.api.staticimage.v1.models']/class[@name='StaticPolylineAnnotation.Builder']/method[@name='getFillColor' and count(parameter)=0]"
				[Register ("getFillColor", "()Ljava/lang/String;", "GetGetFillColorHandler")]
				get {
					if (id_getFillColor == IntPtr.Zero)
						id_getFillColor = JNIEnv.GetMethodID (class_ref, "getFillColor", "()Ljava/lang/String;");
					try {

						if (((object) this).GetType () == ThresholdType)
							return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getFillColor), JniHandleOwnership.TransferLocalRef);
						else
							return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getFillColor", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
			}

			static Delegate cb_getFillOpacity;
#pragma warning disable 0169
			static Delegate GetGetFillOpacityHandler ()
			{
				if (cb_getFillOpacity == null)
					cb_getFillOpacity = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetFillOpacity);
				return cb_getFillOpacity;
			}

			static IntPtr n_GetFillOpacity (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Mapbox.Services.Api.Staticimage.V1.Models.StaticPolylineAnnotation.Builder __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Services.Api.Staticimage.V1.Models.StaticPolylineAnnotation.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.FillOpacity);
			}
#pragma warning restore 0169

			static IntPtr id_getFillOpacity;
			public virtual unsafe global::Java.Lang.Float FillOpacity {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.services.api.staticimage.v1.models']/class[@name='StaticPolylineAnnotation.Builder']/method[@name='getFillOpacity' and count(parameter)=0]"
				[Register ("getFillOpacity", "()Ljava/lang/Float;", "GetGetFillOpacityHandler")]
				get {
					if (id_getFillOpacity == IntPtr.Zero)
						id_getFillOpacity = JNIEnv.GetMethodID (class_ref, "getFillOpacity", "()Ljava/lang/Float;");
					try {

						if (((object) this).GetType () == ThresholdType)
							return global::Java.Lang.Object.GetObject<global::Java.Lang.Float> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getFillOpacity), JniHandleOwnership.TransferLocalRef);
						else
							return global::Java.Lang.Object.GetObject<global::Java.Lang.Float> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getFillOpacity", "()Ljava/lang/Float;")), JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
			}

			static Delegate cb_getPolyline;
#pragma warning disable 0169
			static Delegate GetGetPolylineHandler ()
			{
				if (cb_getPolyline == null)
					cb_getPolyline = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetPolyline);
				return cb_getPolyline;
			}

			static IntPtr n_GetPolyline (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Mapbox.Services.Api.Staticimage.V1.Models.StaticPolylineAnnotation.Builder __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Services.Api.Staticimage.V1.Models.StaticPolylineAnnotation.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.NewString (__this.Polyline);
			}
#pragma warning restore 0169

			static IntPtr id_getPolyline;
			public virtual unsafe string Polyline {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.services.api.staticimage.v1.models']/class[@name='StaticPolylineAnnotation.Builder']/method[@name='getPolyline' and count(parameter)=0]"
				[Register ("getPolyline", "()Ljava/lang/String;", "GetGetPolylineHandler")]
				get {
					if (id_getPolyline == IntPtr.Zero)
						id_getPolyline = JNIEnv.GetMethodID (class_ref, "getPolyline", "()Ljava/lang/String;");
					try {

						if (((object) this).GetType () == ThresholdType)
							return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getPolyline), JniHandleOwnership.TransferLocalRef);
						else
							return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getPolyline", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
			}

			static Delegate cb_getStrokeColor;
#pragma warning disable 0169
			static Delegate GetGetStrokeColorHandler ()
			{
				if (cb_getStrokeColor == null)
					cb_getStrokeColor = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetStrokeColor);
				return cb_getStrokeColor;
			}

			static IntPtr n_GetStrokeColor (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Mapbox.Services.Api.Staticimage.V1.Models.StaticPolylineAnnotation.Builder __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Services.Api.Staticimage.V1.Models.StaticPolylineAnnotation.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.NewString (__this.StrokeColor);
			}
#pragma warning restore 0169

			static IntPtr id_getStrokeColor;
			public virtual unsafe string StrokeColor {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.services.api.staticimage.v1.models']/class[@name='StaticPolylineAnnotation.Builder']/method[@name='getStrokeColor' and count(parameter)=0]"
				[Register ("getStrokeColor", "()Ljava/lang/String;", "GetGetStrokeColorHandler")]
				get {
					if (id_getStrokeColor == IntPtr.Zero)
						id_getStrokeColor = JNIEnv.GetMethodID (class_ref, "getStrokeColor", "()Ljava/lang/String;");
					try {

						if (((object) this).GetType () == ThresholdType)
							return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getStrokeColor), JniHandleOwnership.TransferLocalRef);
						else
							return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getStrokeColor", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
			}

			static Delegate cb_getStrokeOpacity;
#pragma warning disable 0169
			static Delegate GetGetStrokeOpacityHandler ()
			{
				if (cb_getStrokeOpacity == null)
					cb_getStrokeOpacity = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetStrokeOpacity);
				return cb_getStrokeOpacity;
			}

			static IntPtr n_GetStrokeOpacity (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Mapbox.Services.Api.Staticimage.V1.Models.StaticPolylineAnnotation.Builder __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Services.Api.Staticimage.V1.Models.StaticPolylineAnnotation.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.StrokeOpacity);
			}
#pragma warning restore 0169

			static IntPtr id_getStrokeOpacity;
			public virtual unsafe global::Java.Lang.Float StrokeOpacity {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.services.api.staticimage.v1.models']/class[@name='StaticPolylineAnnotation.Builder']/method[@name='getStrokeOpacity' and count(parameter)=0]"
				[Register ("getStrokeOpacity", "()Ljava/lang/Float;", "GetGetStrokeOpacityHandler")]
				get {
					if (id_getStrokeOpacity == IntPtr.Zero)
						id_getStrokeOpacity = JNIEnv.GetMethodID (class_ref, "getStrokeOpacity", "()Ljava/lang/Float;");
					try {

						if (((object) this).GetType () == ThresholdType)
							return global::Java.Lang.Object.GetObject<global::Java.Lang.Float> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getStrokeOpacity), JniHandleOwnership.TransferLocalRef);
						else
							return global::Java.Lang.Object.GetObject<global::Java.Lang.Float> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getStrokeOpacity", "()Ljava/lang/Float;")), JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
			}

			static Delegate cb_getStrokeWidth;
#pragma warning disable 0169
			static Delegate GetGetStrokeWidthHandler ()
			{
				if (cb_getStrokeWidth == null)
					cb_getStrokeWidth = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetStrokeWidth);
				return cb_getStrokeWidth;
			}

			static IntPtr n_GetStrokeWidth (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Mapbox.Services.Api.Staticimage.V1.Models.StaticPolylineAnnotation.Builder __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Services.Api.Staticimage.V1.Models.StaticPolylineAnnotation.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.StrokeWidth);
			}
#pragma warning restore 0169

			static IntPtr id_getStrokeWidth;
			public virtual unsafe global::Java.Lang.Double StrokeWidth {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.services.api.staticimage.v1.models']/class[@name='StaticPolylineAnnotation.Builder']/method[@name='getStrokeWidth' and count(parameter)=0]"
				[Register ("getStrokeWidth", "()Ljava/lang/Double;", "GetGetStrokeWidthHandler")]
				get {
					if (id_getStrokeWidth == IntPtr.Zero)
						id_getStrokeWidth = JNIEnv.GetMethodID (class_ref, "getStrokeWidth", "()Ljava/lang/Double;");
					try {

						if (((object) this).GetType () == ThresholdType)
							return global::Java.Lang.Object.GetObject<global::Java.Lang.Double> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getStrokeWidth), JniHandleOwnership.TransferLocalRef);
						else
							return global::Java.Lang.Object.GetObject<global::Java.Lang.Double> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getStrokeWidth", "()Ljava/lang/Double;")), JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
			}

			static Delegate cb_build;
#pragma warning disable 0169
			static Delegate GetBuildHandler ()
			{
				if (cb_build == null)
					cb_build = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_Build);
				return cb_build;
			}

			static IntPtr n_Build (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Mapbox.Services.Api.Staticimage.V1.Models.StaticPolylineAnnotation.Builder __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Services.Api.Staticimage.V1.Models.StaticPolylineAnnotation.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.Build ());
			}
#pragma warning restore 0169

			static IntPtr id_build;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.services.api.staticimage.v1.models']/class[@name='StaticPolylineAnnotation.Builder']/method[@name='build' and count(parameter)=0]"
			[Register ("build", "()Lcom/mapbox/services/api/staticimage/v1/models/StaticPolylineAnnotation;", "GetBuildHandler")]
			public virtual unsafe global::Com.Mapbox.Services.Api.Staticimage.V1.Models.StaticPolylineAnnotation Build ()
			{
				if (id_build == IntPtr.Zero)
					id_build = JNIEnv.GetMethodID (class_ref, "build", "()Lcom/mapbox/services/api/staticimage/v1/models/StaticPolylineAnnotation;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Services.Api.Staticimage.V1.Models.StaticPolylineAnnotation> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_build), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Services.Api.Staticimage.V1.Models.StaticPolylineAnnotation> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "build", "()Lcom/mapbox/services/api/staticimage/v1/models/StaticPolylineAnnotation;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			static Delegate cb_setFillColor_Ljava_lang_String_;
#pragma warning disable 0169
			static Delegate GetSetFillColor_Ljava_lang_String_Handler ()
			{
				if (cb_setFillColor_Ljava_lang_String_ == null)
					cb_setFillColor_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetFillColor_Ljava_lang_String_);
				return cb_setFillColor_Ljava_lang_String_;
			}

			static IntPtr n_SetFillColor_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Mapbox.Services.Api.Staticimage.V1.Models.StaticPolylineAnnotation.Builder __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Services.Api.Staticimage.V1.Models.StaticPolylineAnnotation.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetFillColor (p0));
				return __ret;
			}
#pragma warning restore 0169

			static IntPtr id_setFillColor_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.services.api.staticimage.v1.models']/class[@name='StaticPolylineAnnotation.Builder']/method[@name='setFillColor' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setFillColor", "(Ljava/lang/String;)Lcom/mapbox/services/api/staticimage/v1/models/StaticPolylineAnnotation$Builder;", "GetSetFillColor_Ljava_lang_String_Handler")]
			public virtual unsafe global::Com.Mapbox.Services.Api.Staticimage.V1.Models.StaticPolylineAnnotation.Builder SetFillColor (string p0)
			{
				if (id_setFillColor_Ljava_lang_String_ == IntPtr.Zero)
					id_setFillColor_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setFillColor", "(Ljava/lang/String;)Lcom/mapbox/services/api/staticimage/v1/models/StaticPolylineAnnotation$Builder;");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_p0);

					global::Com.Mapbox.Services.Api.Staticimage.V1.Models.StaticPolylineAnnotation.Builder __ret;
					if (((object) this).GetType () == ThresholdType)
						__ret = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Services.Api.Staticimage.V1.Models.StaticPolylineAnnotation.Builder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_setFillColor_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
					else
						__ret = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Services.Api.Staticimage.V1.Models.StaticPolylineAnnotation.Builder> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setFillColor", "(Ljava/lang/String;)Lcom/mapbox/services/api/staticimage/v1/models/StaticPolylineAnnotation$Builder;"), __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

			static Delegate cb_setFillOpacity_F;
#pragma warning disable 0169
			static Delegate GetSetFillOpacity_FHandler ()
			{
				if (cb_setFillOpacity_F == null)
					cb_setFillOpacity_F = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float, IntPtr>) n_SetFillOpacity_F);
				return cb_setFillOpacity_F;
			}

			static IntPtr n_SetFillOpacity_F (IntPtr jnienv, IntPtr native__this, float p0)
			{
				global::Com.Mapbox.Services.Api.Staticimage.V1.Models.StaticPolylineAnnotation.Builder __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Services.Api.Staticimage.V1.Models.StaticPolylineAnnotation.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.SetFillOpacity (p0));
			}
#pragma warning restore 0169

			static IntPtr id_setFillOpacity_F;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.services.api.staticimage.v1.models']/class[@name='StaticPolylineAnnotation.Builder']/method[@name='setFillOpacity' and count(parameter)=1 and parameter[1][@type='float']]"
			[Register ("setFillOpacity", "(F)Lcom/mapbox/services/api/staticimage/v1/models/StaticPolylineAnnotation$Builder;", "GetSetFillOpacity_FHandler")]
			public virtual unsafe global::Com.Mapbox.Services.Api.Staticimage.V1.Models.StaticPolylineAnnotation.Builder SetFillOpacity (float p0)
			{
				if (id_setFillOpacity_F == IntPtr.Zero)
					id_setFillOpacity_F = JNIEnv.GetMethodID (class_ref, "setFillOpacity", "(F)Lcom/mapbox/services/api/staticimage/v1/models/StaticPolylineAnnotation$Builder;");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (p0);

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Services.Api.Staticimage.V1.Models.StaticPolylineAnnotation.Builder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_setFillOpacity_F, __args), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Services.Api.Staticimage.V1.Models.StaticPolylineAnnotation.Builder> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setFillOpacity", "(F)Lcom/mapbox/services/api/staticimage/v1/models/StaticPolylineAnnotation$Builder;"), __args), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			static Delegate cb_setPolyline_Ljava_lang_String_;
#pragma warning disable 0169
			static Delegate GetSetPolyline_Ljava_lang_String_Handler ()
			{
				if (cb_setPolyline_Ljava_lang_String_ == null)
					cb_setPolyline_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetPolyline_Ljava_lang_String_);
				return cb_setPolyline_Ljava_lang_String_;
			}

			static IntPtr n_SetPolyline_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Mapbox.Services.Api.Staticimage.V1.Models.StaticPolylineAnnotation.Builder __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Services.Api.Staticimage.V1.Models.StaticPolylineAnnotation.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetPolyline (p0));
				return __ret;
			}
#pragma warning restore 0169

			static IntPtr id_setPolyline_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.services.api.staticimage.v1.models']/class[@name='StaticPolylineAnnotation.Builder']/method[@name='setPolyline' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setPolyline", "(Ljava/lang/String;)Lcom/mapbox/services/api/staticimage/v1/models/StaticPolylineAnnotation$Builder;", "GetSetPolyline_Ljava_lang_String_Handler")]
			public virtual unsafe global::Com.Mapbox.Services.Api.Staticimage.V1.Models.StaticPolylineAnnotation.Builder SetPolyline (string p0)
			{
				if (id_setPolyline_Ljava_lang_String_ == IntPtr.Zero)
					id_setPolyline_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setPolyline", "(Ljava/lang/String;)Lcom/mapbox/services/api/staticimage/v1/models/StaticPolylineAnnotation$Builder;");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_p0);

					global::Com.Mapbox.Services.Api.Staticimage.V1.Models.StaticPolylineAnnotation.Builder __ret;
					if (((object) this).GetType () == ThresholdType)
						__ret = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Services.Api.Staticimage.V1.Models.StaticPolylineAnnotation.Builder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_setPolyline_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
					else
						__ret = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Services.Api.Staticimage.V1.Models.StaticPolylineAnnotation.Builder> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setPolyline", "(Ljava/lang/String;)Lcom/mapbox/services/api/staticimage/v1/models/StaticPolylineAnnotation$Builder;"), __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

			static Delegate cb_setStrokeColor_Ljava_lang_String_;
#pragma warning disable 0169
			static Delegate GetSetStrokeColor_Ljava_lang_String_Handler ()
			{
				if (cb_setStrokeColor_Ljava_lang_String_ == null)
					cb_setStrokeColor_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetStrokeColor_Ljava_lang_String_);
				return cb_setStrokeColor_Ljava_lang_String_;
			}

			static IntPtr n_SetStrokeColor_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Mapbox.Services.Api.Staticimage.V1.Models.StaticPolylineAnnotation.Builder __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Services.Api.Staticimage.V1.Models.StaticPolylineAnnotation.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetStrokeColor (p0));
				return __ret;
			}
#pragma warning restore 0169

			static IntPtr id_setStrokeColor_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.services.api.staticimage.v1.models']/class[@name='StaticPolylineAnnotation.Builder']/method[@name='setStrokeColor' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setStrokeColor", "(Ljava/lang/String;)Lcom/mapbox/services/api/staticimage/v1/models/StaticPolylineAnnotation$Builder;", "GetSetStrokeColor_Ljava_lang_String_Handler")]
			public virtual unsafe global::Com.Mapbox.Services.Api.Staticimage.V1.Models.StaticPolylineAnnotation.Builder SetStrokeColor (string p0)
			{
				if (id_setStrokeColor_Ljava_lang_String_ == IntPtr.Zero)
					id_setStrokeColor_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setStrokeColor", "(Ljava/lang/String;)Lcom/mapbox/services/api/staticimage/v1/models/StaticPolylineAnnotation$Builder;");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_p0);

					global::Com.Mapbox.Services.Api.Staticimage.V1.Models.StaticPolylineAnnotation.Builder __ret;
					if (((object) this).GetType () == ThresholdType)
						__ret = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Services.Api.Staticimage.V1.Models.StaticPolylineAnnotation.Builder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_setStrokeColor_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
					else
						__ret = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Services.Api.Staticimage.V1.Models.StaticPolylineAnnotation.Builder> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setStrokeColor", "(Ljava/lang/String;)Lcom/mapbox/services/api/staticimage/v1/models/StaticPolylineAnnotation$Builder;"), __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

			static Delegate cb_setStrokeOpacity_F;
#pragma warning disable 0169
			static Delegate GetSetStrokeOpacity_FHandler ()
			{
				if (cb_setStrokeOpacity_F == null)
					cb_setStrokeOpacity_F = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float, IntPtr>) n_SetStrokeOpacity_F);
				return cb_setStrokeOpacity_F;
			}

			static IntPtr n_SetStrokeOpacity_F (IntPtr jnienv, IntPtr native__this, float p0)
			{
				global::Com.Mapbox.Services.Api.Staticimage.V1.Models.StaticPolylineAnnotation.Builder __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Services.Api.Staticimage.V1.Models.StaticPolylineAnnotation.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.SetStrokeOpacity (p0));
			}
#pragma warning restore 0169

			static IntPtr id_setStrokeOpacity_F;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.services.api.staticimage.v1.models']/class[@name='StaticPolylineAnnotation.Builder']/method[@name='setStrokeOpacity' and count(parameter)=1 and parameter[1][@type='float']]"
			[Register ("setStrokeOpacity", "(F)Lcom/mapbox/services/api/staticimage/v1/models/StaticPolylineAnnotation$Builder;", "GetSetStrokeOpacity_FHandler")]
			public virtual unsafe global::Com.Mapbox.Services.Api.Staticimage.V1.Models.StaticPolylineAnnotation.Builder SetStrokeOpacity (float p0)
			{
				if (id_setStrokeOpacity_F == IntPtr.Zero)
					id_setStrokeOpacity_F = JNIEnv.GetMethodID (class_ref, "setStrokeOpacity", "(F)Lcom/mapbox/services/api/staticimage/v1/models/StaticPolylineAnnotation$Builder;");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (p0);

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Services.Api.Staticimage.V1.Models.StaticPolylineAnnotation.Builder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_setStrokeOpacity_F, __args), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Services.Api.Staticimage.V1.Models.StaticPolylineAnnotation.Builder> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setStrokeOpacity", "(F)Lcom/mapbox/services/api/staticimage/v1/models/StaticPolylineAnnotation$Builder;"), __args), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			static Delegate cb_setStrokeWidth_D;
#pragma warning disable 0169
			static Delegate GetSetStrokeWidth_DHandler ()
			{
				if (cb_setStrokeWidth_D == null)
					cb_setStrokeWidth_D = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, double, IntPtr>) n_SetStrokeWidth_D);
				return cb_setStrokeWidth_D;
			}

			static IntPtr n_SetStrokeWidth_D (IntPtr jnienv, IntPtr native__this, double p0)
			{
				global::Com.Mapbox.Services.Api.Staticimage.V1.Models.StaticPolylineAnnotation.Builder __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Services.Api.Staticimage.V1.Models.StaticPolylineAnnotation.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.SetStrokeWidth (p0));
			}
#pragma warning restore 0169

			static IntPtr id_setStrokeWidth_D;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.services.api.staticimage.v1.models']/class[@name='StaticPolylineAnnotation.Builder']/method[@name='setStrokeWidth' and count(parameter)=1 and parameter[1][@type='double']]"
			[Register ("setStrokeWidth", "(D)Lcom/mapbox/services/api/staticimage/v1/models/StaticPolylineAnnotation$Builder;", "GetSetStrokeWidth_DHandler")]
			public virtual unsafe global::Com.Mapbox.Services.Api.Staticimage.V1.Models.StaticPolylineAnnotation.Builder SetStrokeWidth (double p0)
			{
				if (id_setStrokeWidth_D == IntPtr.Zero)
					id_setStrokeWidth_D = JNIEnv.GetMethodID (class_ref, "setStrokeWidth", "(D)Lcom/mapbox/services/api/staticimage/v1/models/StaticPolylineAnnotation$Builder;");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (p0);

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Services.Api.Staticimage.V1.Models.StaticPolylineAnnotation.Builder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_setStrokeWidth_D, __args), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Services.Api.Staticimage.V1.Models.StaticPolylineAnnotation.Builder> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setStrokeWidth", "(D)Lcom/mapbox/services/api/staticimage/v1/models/StaticPolylineAnnotation$Builder;"), __args), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

		}

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/mapbox/services/api/staticimage/v1/models/StaticPolylineAnnotation", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (StaticPolylineAnnotation); }
		}

		protected StaticPolylineAnnotation (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Lcom_mapbox_services_api_staticimage_v1_models_StaticPolylineAnnotation_Builder_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.mapbox.services.api.staticimage.v1.models']/class[@name='StaticPolylineAnnotation']/constructor[@name='StaticPolylineAnnotation' and count(parameter)=1 and parameter[1][@type='com.mapbox.services.api.staticimage.v1.models.StaticPolylineAnnotation.Builder']]"
		[Register (".ctor", "(Lcom/mapbox/services/api/staticimage/v1/models/StaticPolylineAnnotation$Builder;)V", "")]
		public unsafe StaticPolylineAnnotation (global::Com.Mapbox.Services.Api.Staticimage.V1.Models.StaticPolylineAnnotation.Builder p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (((object) this).GetType () != typeof (StaticPolylineAnnotation)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Lcom/mapbox/services/api/staticimage/v1/models/StaticPolylineAnnotation$Builder;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Lcom/mapbox/services/api/staticimage/v1/models/StaticPolylineAnnotation$Builder;)V", __args);
					return;
				}

				if (id_ctor_Lcom_mapbox_services_api_staticimage_v1_models_StaticPolylineAnnotation_Builder_ == IntPtr.Zero)
					id_ctor_Lcom_mapbox_services_api_staticimage_v1_models_StaticPolylineAnnotation_Builder_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/mapbox/services/api/staticimage/v1/models/StaticPolylineAnnotation$Builder;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_mapbox_services_api_staticimage_v1_models_StaticPolylineAnnotation_Builder_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Lcom_mapbox_services_api_staticimage_v1_models_StaticPolylineAnnotation_Builder_, __args);
			} finally {
			}
		}

		static Delegate cb_getPath;
#pragma warning disable 0169
		static Delegate GetGetPathHandler ()
		{
			if (cb_getPath == null)
				cb_getPath = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetPath);
			return cb_getPath;
		}

		static IntPtr n_GetPath (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mapbox.Services.Api.Staticimage.V1.Models.StaticPolylineAnnotation __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Services.Api.Staticimage.V1.Models.StaticPolylineAnnotation> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Path);
		}
#pragma warning restore 0169

		static IntPtr id_getPath;
		public virtual unsafe string Path {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.services.api.staticimage.v1.models']/class[@name='StaticPolylineAnnotation']/method[@name='getPath' and count(parameter)=0]"
			[Register ("getPath", "()Ljava/lang/String;", "GetGetPathHandler")]
			get {
				if (id_getPath == IntPtr.Zero)
					id_getPath = JNIEnv.GetMethodID (class_ref, "getPath", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getPath), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getPath", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

	}
}
