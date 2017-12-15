using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Mapbox.Services.Api.Staticimage.V1.Models {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.mapbox.services.api.staticimage.v1.models']/class[@name='StaticMarkerAnnotation']"
	[global::Android.Runtime.Register ("com/mapbox/services/api/staticimage/v1/models/StaticMarkerAnnotation", DoNotGenerateAcw=true)]
	public partial class StaticMarkerAnnotation : global::Java.Lang.Object {

		// Metadata.xml XPath class reference: path="/api/package[@name='com.mapbox.services.api.staticimage.v1.models']/class[@name='StaticMarkerAnnotation.Builder']"
		[global::Android.Runtime.Register ("com/mapbox/services/api/staticimage/v1/models/StaticMarkerAnnotation$Builder", DoNotGenerateAcw=true)]
		public partial class Builder : global::Java.Lang.Object {

			internal static new IntPtr java_class_handle;
			internal static new IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/mapbox/services/api/staticimage/v1/models/StaticMarkerAnnotation$Builder", ref java_class_handle);
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
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.mapbox.services.api.staticimage.v1.models']/class[@name='StaticMarkerAnnotation.Builder']/constructor[@name='StaticMarkerAnnotation.Builder' and count(parameter)=0]"
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

			static Delegate cb_getColor;
#pragma warning disable 0169
			static Delegate GetGetColorHandler ()
			{
				if (cb_getColor == null)
					cb_getColor = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetColor);
				return cb_getColor;
			}

			static IntPtr n_GetColor (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Mapbox.Services.Api.Staticimage.V1.Models.StaticMarkerAnnotation.Builder __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Services.Api.Staticimage.V1.Models.StaticMarkerAnnotation.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.NewString (__this.Color);
			}
#pragma warning restore 0169

			static IntPtr id_getColor;
			public virtual unsafe string Color {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.services.api.staticimage.v1.models']/class[@name='StaticMarkerAnnotation.Builder']/method[@name='getColor' and count(parameter)=0]"
				[Register ("getColor", "()Ljava/lang/String;", "GetGetColorHandler")]
				get {
					if (id_getColor == IntPtr.Zero)
						id_getColor = JNIEnv.GetMethodID (class_ref, "getColor", "()Ljava/lang/String;");
					try {

						if (((object) this).GetType () == ThresholdType)
							return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getColor), JniHandleOwnership.TransferLocalRef);
						else
							return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getColor", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
			}

			static Delegate cb_getLabel;
#pragma warning disable 0169
			static Delegate GetGetLabelHandler ()
			{
				if (cb_getLabel == null)
					cb_getLabel = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetLabel);
				return cb_getLabel;
			}

			static IntPtr n_GetLabel (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Mapbox.Services.Api.Staticimage.V1.Models.StaticMarkerAnnotation.Builder __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Services.Api.Staticimage.V1.Models.StaticMarkerAnnotation.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.NewString (__this.Label);
			}
#pragma warning restore 0169

			static IntPtr id_getLabel;
			public virtual unsafe string Label {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.services.api.staticimage.v1.models']/class[@name='StaticMarkerAnnotation.Builder']/method[@name='getLabel' and count(parameter)=0]"
				[Register ("getLabel", "()Ljava/lang/String;", "GetGetLabelHandler")]
				get {
					if (id_getLabel == IntPtr.Zero)
						id_getLabel = JNIEnv.GetMethodID (class_ref, "getLabel", "()Ljava/lang/String;");
					try {

						if (((object) this).GetType () == ThresholdType)
							return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getLabel), JniHandleOwnership.TransferLocalRef);
						else
							return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getLabel", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
			}

			static Delegate cb_getLat;
#pragma warning disable 0169
			static Delegate GetGetLatHandler ()
			{
				if (cb_getLat == null)
					cb_getLat = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetLat);
				return cb_getLat;
			}

			static IntPtr n_GetLat (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Mapbox.Services.Api.Staticimage.V1.Models.StaticMarkerAnnotation.Builder __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Services.Api.Staticimage.V1.Models.StaticMarkerAnnotation.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.Lat);
			}
#pragma warning restore 0169

			static IntPtr id_getLat;
			public virtual unsafe global::Java.Lang.Double Lat {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.services.api.staticimage.v1.models']/class[@name='StaticMarkerAnnotation.Builder']/method[@name='getLat' and count(parameter)=0]"
				[Register ("getLat", "()Ljava/lang/Double;", "GetGetLatHandler")]
				get {
					if (id_getLat == IntPtr.Zero)
						id_getLat = JNIEnv.GetMethodID (class_ref, "getLat", "()Ljava/lang/Double;");
					try {

						if (((object) this).GetType () == ThresholdType)
							return global::Java.Lang.Object.GetObject<global::Java.Lang.Double> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getLat), JniHandleOwnership.TransferLocalRef);
						else
							return global::Java.Lang.Object.GetObject<global::Java.Lang.Double> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getLat", "()Ljava/lang/Double;")), JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
			}

			static Delegate cb_getLon;
#pragma warning disable 0169
			static Delegate GetGetLonHandler ()
			{
				if (cb_getLon == null)
					cb_getLon = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetLon);
				return cb_getLon;
			}

			static IntPtr n_GetLon (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Mapbox.Services.Api.Staticimage.V1.Models.StaticMarkerAnnotation.Builder __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Services.Api.Staticimage.V1.Models.StaticMarkerAnnotation.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.Lon);
			}
#pragma warning restore 0169

			static IntPtr id_getLon;
			public virtual unsafe global::Java.Lang.Double Lon {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.services.api.staticimage.v1.models']/class[@name='StaticMarkerAnnotation.Builder']/method[@name='getLon' and count(parameter)=0]"
				[Register ("getLon", "()Ljava/lang/Double;", "GetGetLonHandler")]
				get {
					if (id_getLon == IntPtr.Zero)
						id_getLon = JNIEnv.GetMethodID (class_ref, "getLon", "()Ljava/lang/Double;");
					try {

						if (((object) this).GetType () == ThresholdType)
							return global::Java.Lang.Object.GetObject<global::Java.Lang.Double> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getLon), JniHandleOwnership.TransferLocalRef);
						else
							return global::Java.Lang.Object.GetObject<global::Java.Lang.Double> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getLon", "()Ljava/lang/Double;")), JniHandleOwnership.TransferLocalRef);
					} finally {
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
				global::Com.Mapbox.Services.Api.Staticimage.V1.Models.StaticMarkerAnnotation.Builder __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Services.Api.Staticimage.V1.Models.StaticMarkerAnnotation.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.NewString (__this.Name);
			}
#pragma warning restore 0169

			static IntPtr id_getName;
			public virtual unsafe string Name {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.services.api.staticimage.v1.models']/class[@name='StaticMarkerAnnotation.Builder']/method[@name='getName' and count(parameter)=0]"
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
			}

			static Delegate cb_getPosition;
#pragma warning disable 0169
			static Delegate GetGetPositionHandler ()
			{
				if (cb_getPosition == null)
					cb_getPosition = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetPosition);
				return cb_getPosition;
			}

			static IntPtr n_GetPosition (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Mapbox.Services.Api.Staticimage.V1.Models.StaticMarkerAnnotation.Builder __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Services.Api.Staticimage.V1.Models.StaticMarkerAnnotation.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.Position);
			}
#pragma warning restore 0169

			static IntPtr id_getPosition;
			public virtual unsafe global::Com.Mapbox.Services.Commons.Models.Position Position {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.services.api.staticimage.v1.models']/class[@name='StaticMarkerAnnotation.Builder']/method[@name='getPosition' and count(parameter)=0]"
				[Register ("getPosition", "()Lcom/mapbox/services/commons/models/Position;", "GetGetPositionHandler")]
				get {
					if (id_getPosition == IntPtr.Zero)
						id_getPosition = JNIEnv.GetMethodID (class_ref, "getPosition", "()Lcom/mapbox/services/commons/models/Position;");
					try {

						if (((object) this).GetType () == ThresholdType)
							return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Services.Commons.Models.Position> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getPosition), JniHandleOwnership.TransferLocalRef);
						else
							return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Services.Commons.Models.Position> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getPosition", "()Lcom/mapbox/services/commons/models/Position;")), JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
			}

			static Delegate cb_getPrecision;
#pragma warning disable 0169
			static Delegate GetGetPrecisionHandler ()
			{
				if (cb_getPrecision == null)
					cb_getPrecision = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetPrecision);
				return cb_getPrecision;
			}

			static int n_GetPrecision (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Mapbox.Services.Api.Staticimage.V1.Models.StaticMarkerAnnotation.Builder __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Services.Api.Staticimage.V1.Models.StaticMarkerAnnotation.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return __this.Precision;
			}
#pragma warning restore 0169

			static IntPtr id_getPrecision;
			public virtual unsafe int Precision {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.services.api.staticimage.v1.models']/class[@name='StaticMarkerAnnotation.Builder']/method[@name='getPrecision' and count(parameter)=0]"
				[Register ("getPrecision", "()I", "GetGetPrecisionHandler")]
				get {
					if (id_getPrecision == IntPtr.Zero)
						id_getPrecision = JNIEnv.GetMethodID (class_ref, "getPrecision", "()I");
					try {

						if (((object) this).GetType () == ThresholdType)
							return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getPrecision);
						else
							return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getPrecision", "()I"));
					} finally {
					}
				}
			}

			static Delegate cb_getUrl;
#pragma warning disable 0169
			static Delegate GetGetUrlHandler ()
			{
				if (cb_getUrl == null)
					cb_getUrl = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetUrl);
				return cb_getUrl;
			}

			static IntPtr n_GetUrl (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Mapbox.Services.Api.Staticimage.V1.Models.StaticMarkerAnnotation.Builder __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Services.Api.Staticimage.V1.Models.StaticMarkerAnnotation.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.NewString (__this.Url);
			}
#pragma warning restore 0169

			static IntPtr id_getUrl;
			public virtual unsafe string Url {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.services.api.staticimage.v1.models']/class[@name='StaticMarkerAnnotation.Builder']/method[@name='getUrl' and count(parameter)=0]"
				[Register ("getUrl", "()Ljava/lang/String;", "GetGetUrlHandler")]
				get {
					if (id_getUrl == IntPtr.Zero)
						id_getUrl = JNIEnv.GetMethodID (class_ref, "getUrl", "()Ljava/lang/String;");
					try {

						if (((object) this).GetType () == ThresholdType)
							return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getUrl), JniHandleOwnership.TransferLocalRef);
						else
							return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getUrl", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
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
				global::Com.Mapbox.Services.Api.Staticimage.V1.Models.StaticMarkerAnnotation.Builder __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Services.Api.Staticimage.V1.Models.StaticMarkerAnnotation.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.Build ());
			}
#pragma warning restore 0169

			static IntPtr id_build;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.services.api.staticimage.v1.models']/class[@name='StaticMarkerAnnotation.Builder']/method[@name='build' and count(parameter)=0]"
			[Register ("build", "()Lcom/mapbox/services/api/staticimage/v1/models/StaticMarkerAnnotation;", "GetBuildHandler")]
			public virtual unsafe global::Com.Mapbox.Services.Api.Staticimage.V1.Models.StaticMarkerAnnotation Build ()
			{
				if (id_build == IntPtr.Zero)
					id_build = JNIEnv.GetMethodID (class_ref, "build", "()Lcom/mapbox/services/api/staticimage/v1/models/StaticMarkerAnnotation;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Services.Api.Staticimage.V1.Models.StaticMarkerAnnotation> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_build), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Services.Api.Staticimage.V1.Models.StaticMarkerAnnotation> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "build", "()Lcom/mapbox/services/api/staticimage/v1/models/StaticMarkerAnnotation;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			static Delegate cb_setColor_Ljava_lang_String_;
#pragma warning disable 0169
			static Delegate GetSetColor_Ljava_lang_String_Handler ()
			{
				if (cb_setColor_Ljava_lang_String_ == null)
					cb_setColor_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetColor_Ljava_lang_String_);
				return cb_setColor_Ljava_lang_String_;
			}

			static IntPtr n_SetColor_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Mapbox.Services.Api.Staticimage.V1.Models.StaticMarkerAnnotation.Builder __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Services.Api.Staticimage.V1.Models.StaticMarkerAnnotation.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetColor (p0));
				return __ret;
			}
#pragma warning restore 0169

			static IntPtr id_setColor_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.services.api.staticimage.v1.models']/class[@name='StaticMarkerAnnotation.Builder']/method[@name='setColor' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setColor", "(Ljava/lang/String;)Lcom/mapbox/services/api/staticimage/v1/models/StaticMarkerAnnotation$Builder;", "GetSetColor_Ljava_lang_String_Handler")]
			public virtual unsafe global::Com.Mapbox.Services.Api.Staticimage.V1.Models.StaticMarkerAnnotation.Builder SetColor (string p0)
			{
				if (id_setColor_Ljava_lang_String_ == IntPtr.Zero)
					id_setColor_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setColor", "(Ljava/lang/String;)Lcom/mapbox/services/api/staticimage/v1/models/StaticMarkerAnnotation$Builder;");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_p0);

					global::Com.Mapbox.Services.Api.Staticimage.V1.Models.StaticMarkerAnnotation.Builder __ret;
					if (((object) this).GetType () == ThresholdType)
						__ret = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Services.Api.Staticimage.V1.Models.StaticMarkerAnnotation.Builder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_setColor_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
					else
						__ret = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Services.Api.Staticimage.V1.Models.StaticMarkerAnnotation.Builder> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setColor", "(Ljava/lang/String;)Lcom/mapbox/services/api/staticimage/v1/models/StaticMarkerAnnotation$Builder;"), __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

			static Delegate cb_setLabel_Ljava_lang_String_;
#pragma warning disable 0169
			static Delegate GetSetLabel_Ljava_lang_String_Handler ()
			{
				if (cb_setLabel_Ljava_lang_String_ == null)
					cb_setLabel_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetLabel_Ljava_lang_String_);
				return cb_setLabel_Ljava_lang_String_;
			}

			static IntPtr n_SetLabel_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Mapbox.Services.Api.Staticimage.V1.Models.StaticMarkerAnnotation.Builder __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Services.Api.Staticimage.V1.Models.StaticMarkerAnnotation.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetLabel (p0));
				return __ret;
			}
#pragma warning restore 0169

			static IntPtr id_setLabel_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.services.api.staticimage.v1.models']/class[@name='StaticMarkerAnnotation.Builder']/method[@name='setLabel' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setLabel", "(Ljava/lang/String;)Lcom/mapbox/services/api/staticimage/v1/models/StaticMarkerAnnotation$Builder;", "GetSetLabel_Ljava_lang_String_Handler")]
			public virtual unsafe global::Com.Mapbox.Services.Api.Staticimage.V1.Models.StaticMarkerAnnotation.Builder SetLabel (string p0)
			{
				if (id_setLabel_Ljava_lang_String_ == IntPtr.Zero)
					id_setLabel_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setLabel", "(Ljava/lang/String;)Lcom/mapbox/services/api/staticimage/v1/models/StaticMarkerAnnotation$Builder;");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_p0);

					global::Com.Mapbox.Services.Api.Staticimage.V1.Models.StaticMarkerAnnotation.Builder __ret;
					if (((object) this).GetType () == ThresholdType)
						__ret = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Services.Api.Staticimage.V1.Models.StaticMarkerAnnotation.Builder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_setLabel_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
					else
						__ret = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Services.Api.Staticimage.V1.Models.StaticMarkerAnnotation.Builder> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setLabel", "(Ljava/lang/String;)Lcom/mapbox/services/api/staticimage/v1/models/StaticMarkerAnnotation$Builder;"), __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

			static Delegate cb_setLat_Ljava_lang_Double_;
#pragma warning disable 0169
			static Delegate GetSetLat_Ljava_lang_Double_Handler ()
			{
				if (cb_setLat_Ljava_lang_Double_ == null)
					cb_setLat_Ljava_lang_Double_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetLat_Ljava_lang_Double_);
				return cb_setLat_Ljava_lang_Double_;
			}

			static IntPtr n_SetLat_Ljava_lang_Double_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Mapbox.Services.Api.Staticimage.V1.Models.StaticMarkerAnnotation.Builder __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Services.Api.Staticimage.V1.Models.StaticMarkerAnnotation.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Java.Lang.Double p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Double> (native_p0, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetLat (p0));
				return __ret;
			}
#pragma warning restore 0169

			static IntPtr id_setLat_Ljava_lang_Double_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.services.api.staticimage.v1.models']/class[@name='StaticMarkerAnnotation.Builder']/method[@name='setLat' and count(parameter)=1 and parameter[1][@type='java.lang.Double']]"
			[Register ("setLat", "(Ljava/lang/Double;)Lcom/mapbox/services/api/staticimage/v1/models/StaticMarkerAnnotation$Builder;", "GetSetLat_Ljava_lang_Double_Handler")]
			public virtual unsafe global::Com.Mapbox.Services.Api.Staticimage.V1.Models.StaticMarkerAnnotation.Builder SetLat (global::Java.Lang.Double p0)
			{
				if (id_setLat_Ljava_lang_Double_ == IntPtr.Zero)
					id_setLat_Ljava_lang_Double_ = JNIEnv.GetMethodID (class_ref, "setLat", "(Ljava/lang/Double;)Lcom/mapbox/services/api/staticimage/v1/models/StaticMarkerAnnotation$Builder;");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (p0);

					global::Com.Mapbox.Services.Api.Staticimage.V1.Models.StaticMarkerAnnotation.Builder __ret;
					if (((object) this).GetType () == ThresholdType)
						__ret = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Services.Api.Staticimage.V1.Models.StaticMarkerAnnotation.Builder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_setLat_Ljava_lang_Double_, __args), JniHandleOwnership.TransferLocalRef);
					else
						__ret = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Services.Api.Staticimage.V1.Models.StaticMarkerAnnotation.Builder> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setLat", "(Ljava/lang/Double;)Lcom/mapbox/services/api/staticimage/v1/models/StaticMarkerAnnotation$Builder;"), __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
				}
			}

			static Delegate cb_setLon_Ljava_lang_Double_;
#pragma warning disable 0169
			static Delegate GetSetLon_Ljava_lang_Double_Handler ()
			{
				if (cb_setLon_Ljava_lang_Double_ == null)
					cb_setLon_Ljava_lang_Double_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetLon_Ljava_lang_Double_);
				return cb_setLon_Ljava_lang_Double_;
			}

			static IntPtr n_SetLon_Ljava_lang_Double_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Mapbox.Services.Api.Staticimage.V1.Models.StaticMarkerAnnotation.Builder __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Services.Api.Staticimage.V1.Models.StaticMarkerAnnotation.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Java.Lang.Double p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Double> (native_p0, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetLon (p0));
				return __ret;
			}
#pragma warning restore 0169

			static IntPtr id_setLon_Ljava_lang_Double_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.services.api.staticimage.v1.models']/class[@name='StaticMarkerAnnotation.Builder']/method[@name='setLon' and count(parameter)=1 and parameter[1][@type='java.lang.Double']]"
			[Register ("setLon", "(Ljava/lang/Double;)Lcom/mapbox/services/api/staticimage/v1/models/StaticMarkerAnnotation$Builder;", "GetSetLon_Ljava_lang_Double_Handler")]
			public virtual unsafe global::Com.Mapbox.Services.Api.Staticimage.V1.Models.StaticMarkerAnnotation.Builder SetLon (global::Java.Lang.Double p0)
			{
				if (id_setLon_Ljava_lang_Double_ == IntPtr.Zero)
					id_setLon_Ljava_lang_Double_ = JNIEnv.GetMethodID (class_ref, "setLon", "(Ljava/lang/Double;)Lcom/mapbox/services/api/staticimage/v1/models/StaticMarkerAnnotation$Builder;");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (p0);

					global::Com.Mapbox.Services.Api.Staticimage.V1.Models.StaticMarkerAnnotation.Builder __ret;
					if (((object) this).GetType () == ThresholdType)
						__ret = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Services.Api.Staticimage.V1.Models.StaticMarkerAnnotation.Builder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_setLon_Ljava_lang_Double_, __args), JniHandleOwnership.TransferLocalRef);
					else
						__ret = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Services.Api.Staticimage.V1.Models.StaticMarkerAnnotation.Builder> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setLon", "(Ljava/lang/Double;)Lcom/mapbox/services/api/staticimage/v1/models/StaticMarkerAnnotation$Builder;"), __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
				}
			}

			static Delegate cb_setName_Ljava_lang_String_;
#pragma warning disable 0169
			static Delegate GetSetName_Ljava_lang_String_Handler ()
			{
				if (cb_setName_Ljava_lang_String_ == null)
					cb_setName_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetName_Ljava_lang_String_);
				return cb_setName_Ljava_lang_String_;
			}

			static IntPtr n_SetName_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Mapbox.Services.Api.Staticimage.V1.Models.StaticMarkerAnnotation.Builder __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Services.Api.Staticimage.V1.Models.StaticMarkerAnnotation.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetName (p0));
				return __ret;
			}
#pragma warning restore 0169

			static IntPtr id_setName_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.services.api.staticimage.v1.models']/class[@name='StaticMarkerAnnotation.Builder']/method[@name='setName' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setName", "(Ljava/lang/String;)Lcom/mapbox/services/api/staticimage/v1/models/StaticMarkerAnnotation$Builder;", "GetSetName_Ljava_lang_String_Handler")]
			public virtual unsafe global::Com.Mapbox.Services.Api.Staticimage.V1.Models.StaticMarkerAnnotation.Builder SetName (string p0)
			{
				if (id_setName_Ljava_lang_String_ == IntPtr.Zero)
					id_setName_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setName", "(Ljava/lang/String;)Lcom/mapbox/services/api/staticimage/v1/models/StaticMarkerAnnotation$Builder;");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_p0);

					global::Com.Mapbox.Services.Api.Staticimage.V1.Models.StaticMarkerAnnotation.Builder __ret;
					if (((object) this).GetType () == ThresholdType)
						__ret = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Services.Api.Staticimage.V1.Models.StaticMarkerAnnotation.Builder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_setName_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
					else
						__ret = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Services.Api.Staticimage.V1.Models.StaticMarkerAnnotation.Builder> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setName", "(Ljava/lang/String;)Lcom/mapbox/services/api/staticimage/v1/models/StaticMarkerAnnotation$Builder;"), __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

			static Delegate cb_setPosition_Lcom_mapbox_services_commons_models_Position_;
#pragma warning disable 0169
			static Delegate GetSetPosition_Lcom_mapbox_services_commons_models_Position_Handler ()
			{
				if (cb_setPosition_Lcom_mapbox_services_commons_models_Position_ == null)
					cb_setPosition_Lcom_mapbox_services_commons_models_Position_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetPosition_Lcom_mapbox_services_commons_models_Position_);
				return cb_setPosition_Lcom_mapbox_services_commons_models_Position_;
			}

			static IntPtr n_SetPosition_Lcom_mapbox_services_commons_models_Position_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Mapbox.Services.Api.Staticimage.V1.Models.StaticMarkerAnnotation.Builder __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Services.Api.Staticimage.V1.Models.StaticMarkerAnnotation.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Com.Mapbox.Services.Commons.Models.Position p0 = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Services.Commons.Models.Position> (native_p0, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetPosition (p0));
				return __ret;
			}
#pragma warning restore 0169

			static IntPtr id_setPosition_Lcom_mapbox_services_commons_models_Position_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.services.api.staticimage.v1.models']/class[@name='StaticMarkerAnnotation.Builder']/method[@name='setPosition' and count(parameter)=1 and parameter[1][@type='com.mapbox.services.commons.models.Position']]"
			[Register ("setPosition", "(Lcom/mapbox/services/commons/models/Position;)Lcom/mapbox/services/api/staticimage/v1/models/StaticMarkerAnnotation$Builder;", "GetSetPosition_Lcom_mapbox_services_commons_models_Position_Handler")]
			public virtual unsafe global::Com.Mapbox.Services.Api.Staticimage.V1.Models.StaticMarkerAnnotation.Builder SetPosition (global::Com.Mapbox.Services.Commons.Models.Position p0)
			{
				if (id_setPosition_Lcom_mapbox_services_commons_models_Position_ == IntPtr.Zero)
					id_setPosition_Lcom_mapbox_services_commons_models_Position_ = JNIEnv.GetMethodID (class_ref, "setPosition", "(Lcom/mapbox/services/commons/models/Position;)Lcom/mapbox/services/api/staticimage/v1/models/StaticMarkerAnnotation$Builder;");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (p0);

					global::Com.Mapbox.Services.Api.Staticimage.V1.Models.StaticMarkerAnnotation.Builder __ret;
					if (((object) this).GetType () == ThresholdType)
						__ret = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Services.Api.Staticimage.V1.Models.StaticMarkerAnnotation.Builder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_setPosition_Lcom_mapbox_services_commons_models_Position_, __args), JniHandleOwnership.TransferLocalRef);
					else
						__ret = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Services.Api.Staticimage.V1.Models.StaticMarkerAnnotation.Builder> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setPosition", "(Lcom/mapbox/services/commons/models/Position;)Lcom/mapbox/services/api/staticimage/v1/models/StaticMarkerAnnotation$Builder;"), __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
				}
			}

			static Delegate cb_setPrecision_I;
#pragma warning disable 0169
			static Delegate GetSetPrecision_IHandler ()
			{
				if (cb_setPrecision_I == null)
					cb_setPrecision_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_SetPrecision_I);
				return cb_setPrecision_I;
			}

			static IntPtr n_SetPrecision_I (IntPtr jnienv, IntPtr native__this, int p0)
			{
				global::Com.Mapbox.Services.Api.Staticimage.V1.Models.StaticMarkerAnnotation.Builder __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Services.Api.Staticimage.V1.Models.StaticMarkerAnnotation.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.SetPrecision (p0));
			}
#pragma warning restore 0169

			static IntPtr id_setPrecision_I;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.services.api.staticimage.v1.models']/class[@name='StaticMarkerAnnotation.Builder']/method[@name='setPrecision' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setPrecision", "(I)Lcom/mapbox/services/api/staticimage/v1/models/StaticMarkerAnnotation$Builder;", "GetSetPrecision_IHandler")]
			public virtual unsafe global::Com.Mapbox.Services.Api.Staticimage.V1.Models.StaticMarkerAnnotation.Builder SetPrecision (int p0)
			{
				if (id_setPrecision_I == IntPtr.Zero)
					id_setPrecision_I = JNIEnv.GetMethodID (class_ref, "setPrecision", "(I)Lcom/mapbox/services/api/staticimage/v1/models/StaticMarkerAnnotation$Builder;");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (p0);

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Services.Api.Staticimage.V1.Models.StaticMarkerAnnotation.Builder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_setPrecision_I, __args), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Services.Api.Staticimage.V1.Models.StaticMarkerAnnotation.Builder> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setPrecision", "(I)Lcom/mapbox/services/api/staticimage/v1/models/StaticMarkerAnnotation$Builder;"), __args), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			static Delegate cb_setUrl_Ljava_lang_String_;
#pragma warning disable 0169
			static Delegate GetSetUrl_Ljava_lang_String_Handler ()
			{
				if (cb_setUrl_Ljava_lang_String_ == null)
					cb_setUrl_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetUrl_Ljava_lang_String_);
				return cb_setUrl_Ljava_lang_String_;
			}

			static IntPtr n_SetUrl_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Mapbox.Services.Api.Staticimage.V1.Models.StaticMarkerAnnotation.Builder __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Services.Api.Staticimage.V1.Models.StaticMarkerAnnotation.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetUrl (p0));
				return __ret;
			}
#pragma warning restore 0169

			static IntPtr id_setUrl_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.services.api.staticimage.v1.models']/class[@name='StaticMarkerAnnotation.Builder']/method[@name='setUrl' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setUrl", "(Ljava/lang/String;)Lcom/mapbox/services/api/staticimage/v1/models/StaticMarkerAnnotation$Builder;", "GetSetUrl_Ljava_lang_String_Handler")]
			public virtual unsafe global::Com.Mapbox.Services.Api.Staticimage.V1.Models.StaticMarkerAnnotation.Builder SetUrl (string p0)
			{
				if (id_setUrl_Ljava_lang_String_ == IntPtr.Zero)
					id_setUrl_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setUrl", "(Ljava/lang/String;)Lcom/mapbox/services/api/staticimage/v1/models/StaticMarkerAnnotation$Builder;");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_p0);

					global::Com.Mapbox.Services.Api.Staticimage.V1.Models.StaticMarkerAnnotation.Builder __ret;
					if (((object) this).GetType () == ThresholdType)
						__ret = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Services.Api.Staticimage.V1.Models.StaticMarkerAnnotation.Builder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_setUrl_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
					else
						__ret = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Services.Api.Staticimage.V1.Models.StaticMarkerAnnotation.Builder> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setUrl", "(Ljava/lang/String;)Lcom/mapbox/services/api/staticimage/v1/models/StaticMarkerAnnotation$Builder;"), __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

		}

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/mapbox/services/api/staticimage/v1/models/StaticMarkerAnnotation", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (StaticMarkerAnnotation); }
		}

		protected StaticMarkerAnnotation (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Lcom_mapbox_services_api_staticimage_v1_models_StaticMarkerAnnotation_Builder_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.mapbox.services.api.staticimage.v1.models']/class[@name='StaticMarkerAnnotation']/constructor[@name='StaticMarkerAnnotation' and count(parameter)=1 and parameter[1][@type='com.mapbox.services.api.staticimage.v1.models.StaticMarkerAnnotation.Builder']]"
		[Register (".ctor", "(Lcom/mapbox/services/api/staticimage/v1/models/StaticMarkerAnnotation$Builder;)V", "")]
		public unsafe StaticMarkerAnnotation (global::Com.Mapbox.Services.Api.Staticimage.V1.Models.StaticMarkerAnnotation.Builder p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (((object) this).GetType () != typeof (StaticMarkerAnnotation)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Lcom/mapbox/services/api/staticimage/v1/models/StaticMarkerAnnotation$Builder;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Lcom/mapbox/services/api/staticimage/v1/models/StaticMarkerAnnotation$Builder;)V", __args);
					return;
				}

				if (id_ctor_Lcom_mapbox_services_api_staticimage_v1_models_StaticMarkerAnnotation_Builder_ == IntPtr.Zero)
					id_ctor_Lcom_mapbox_services_api_staticimage_v1_models_StaticMarkerAnnotation_Builder_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/mapbox/services/api/staticimage/v1/models/StaticMarkerAnnotation$Builder;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_mapbox_services_api_staticimage_v1_models_StaticMarkerAnnotation_Builder_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Lcom_mapbox_services_api_staticimage_v1_models_StaticMarkerAnnotation_Builder_, __args);
			} finally {
			}
		}

		static Delegate cb_getMarker;
#pragma warning disable 0169
		static Delegate GetGetMarkerHandler ()
		{
			if (cb_getMarker == null)
				cb_getMarker = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetMarker);
			return cb_getMarker;
		}

		static IntPtr n_GetMarker (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mapbox.Services.Api.Staticimage.V1.Models.StaticMarkerAnnotation __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Services.Api.Staticimage.V1.Models.StaticMarkerAnnotation> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Marker);
		}
#pragma warning restore 0169

		static IntPtr id_getMarker;
		public virtual unsafe string Marker {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.services.api.staticimage.v1.models']/class[@name='StaticMarkerAnnotation']/method[@name='getMarker' and count(parameter)=0]"
			[Register ("getMarker", "()Ljava/lang/String;", "GetGetMarkerHandler")]
			get {
				if (id_getMarker == IntPtr.Zero)
					id_getMarker = JNIEnv.GetMethodID (class_ref, "getMarker", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getMarker), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getMarker", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

	}
}
