using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Mapbox.Services.Api.Staticimage.V1 {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.mapbox.services.api.staticimage.v1']/class[@name='MapboxStaticImage']"
	[global::Android.Runtime.Register ("com/mapbox/services/api/staticimage/v1/MapboxStaticImage", DoNotGenerateAcw=true)]
	public partial class MapboxStaticImage : global::Java.Lang.Object {

		// Metadata.xml XPath class reference: path="/api/package[@name='com.mapbox.services.api.staticimage.v1']/class[@name='MapboxStaticImage.Builder']"
		[global::Android.Runtime.Register ("com/mapbox/services/api/staticimage/v1/MapboxStaticImage$Builder", DoNotGenerateAcw=true)]
		public partial class Builder : global::Com.Mapbox.Services.Api.MapboxBuilder {

			internal static new IntPtr java_class_handle;
			internal static new IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/mapbox/services/api/staticimage/v1/MapboxStaticImage$Builder", ref java_class_handle);
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
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.mapbox.services.api.staticimage.v1']/class[@name='MapboxStaticImage.Builder']/constructor[@name='MapboxStaticImage.Builder' and count(parameter)=0]"
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

			static Delegate cb_getAccessToken;
#pragma warning disable 0169
			static Delegate GetGetAccessTokenHandler ()
			{
				if (cb_getAccessToken == null)
					cb_getAccessToken = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetAccessToken);
				return cb_getAccessToken;
			}

			static IntPtr n_GetAccessToken (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Mapbox.Services.Api.Staticimage.V1.MapboxStaticImage.Builder __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Services.Api.Staticimage.V1.MapboxStaticImage.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.NewString (__this.AccessToken);
			}
#pragma warning restore 0169

			static IntPtr id_getAccessToken;
			public override unsafe string AccessToken {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.services.api.staticimage.v1']/class[@name='MapboxStaticImage.Builder']/method[@name='getAccessToken' and count(parameter)=0]"
				[Register ("getAccessToken", "()Ljava/lang/String;", "GetGetAccessTokenHandler")]
				get {
					if (id_getAccessToken == IntPtr.Zero)
						id_getAccessToken = JNIEnv.GetMethodID (class_ref, "getAccessToken", "()Ljava/lang/String;");
					try {

						if (((object) this).GetType () == ThresholdType)
							return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getAccessToken), JniHandleOwnership.TransferLocalRef);
						else
							return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getAccessToken", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
			}

			static Delegate cb_getBeforeLayer;
#pragma warning disable 0169
			static Delegate GetGetBeforeLayerHandler ()
			{
				if (cb_getBeforeLayer == null)
					cb_getBeforeLayer = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetBeforeLayer);
				return cb_getBeforeLayer;
			}

			static IntPtr n_GetBeforeLayer (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Mapbox.Services.Api.Staticimage.V1.MapboxStaticImage.Builder __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Services.Api.Staticimage.V1.MapboxStaticImage.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.NewString (__this.BeforeLayer);
			}
#pragma warning restore 0169

			static IntPtr id_getBeforeLayer;
			public virtual unsafe string BeforeLayer {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.services.api.staticimage.v1']/class[@name='MapboxStaticImage.Builder']/method[@name='getBeforeLayer' and count(parameter)=0]"
				[Register ("getBeforeLayer", "()Ljava/lang/String;", "GetGetBeforeLayerHandler")]
				get {
					if (id_getBeforeLayer == IntPtr.Zero)
						id_getBeforeLayer = JNIEnv.GetMethodID (class_ref, "getBeforeLayer", "()Ljava/lang/String;");
					try {

						if (((object) this).GetType () == ThresholdType)
							return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getBeforeLayer), JniHandleOwnership.TransferLocalRef);
						else
							return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getBeforeLayer", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
			}

			static Delegate cb_getGeoJson;
#pragma warning disable 0169
			static Delegate GetGetGeoJsonHandler ()
			{
				if (cb_getGeoJson == null)
					cb_getGeoJson = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetGeoJson);
				return cb_getGeoJson;
			}

			static IntPtr n_GetGeoJson (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Mapbox.Services.Api.Staticimage.V1.MapboxStaticImage.Builder __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Services.Api.Staticimage.V1.MapboxStaticImage.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.NewString (__this.GeoJson);
			}
#pragma warning restore 0169

			static IntPtr id_getGeoJson;
			public virtual unsafe string GeoJson {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.services.api.staticimage.v1']/class[@name='MapboxStaticImage.Builder']/method[@name='getGeoJson' and count(parameter)=0]"
				[Register ("getGeoJson", "()Ljava/lang/String;", "GetGetGeoJsonHandler")]
				get {
					if (id_getGeoJson == IntPtr.Zero)
						id_getGeoJson = JNIEnv.GetMethodID (class_ref, "getGeoJson", "()Ljava/lang/String;");
					try {

						if (((object) this).GetType () == ThresholdType)
							return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getGeoJson), JniHandleOwnership.TransferLocalRef);
						else
							return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getGeoJson", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
			}

			static Delegate cb_isAttribution;
#pragma warning disable 0169
			static Delegate GetIsAttributionHandler ()
			{
				if (cb_isAttribution == null)
					cb_isAttribution = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsAttribution);
				return cb_isAttribution;
			}

			static bool n_IsAttribution (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Mapbox.Services.Api.Staticimage.V1.MapboxStaticImage.Builder __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Services.Api.Staticimage.V1.MapboxStaticImage.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return __this.IsAttribution;
			}
#pragma warning restore 0169

			static IntPtr id_isAttribution;
			public virtual unsafe bool IsAttribution {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.services.api.staticimage.v1']/class[@name='MapboxStaticImage.Builder']/method[@name='isAttribution' and count(parameter)=0]"
				[Register ("isAttribution", "()Z", "GetIsAttributionHandler")]
				get {
					if (id_isAttribution == IntPtr.Zero)
						id_isAttribution = JNIEnv.GetMethodID (class_ref, "isAttribution", "()Z");
					try {

						if (((object) this).GetType () == ThresholdType)
							return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isAttribution);
						else
							return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isAttribution", "()Z"));
					} finally {
					}
				}
			}

			static Delegate cb_isAuto;
#pragma warning disable 0169
			static Delegate GetIsAutoHandler ()
			{
				if (cb_isAuto == null)
					cb_isAuto = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsAuto);
				return cb_isAuto;
			}

			static bool n_IsAuto (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Mapbox.Services.Api.Staticimage.V1.MapboxStaticImage.Builder __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Services.Api.Staticimage.V1.MapboxStaticImage.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return __this.IsAuto;
			}
#pragma warning restore 0169

			static IntPtr id_isAuto;
			public virtual unsafe bool IsAuto {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.services.api.staticimage.v1']/class[@name='MapboxStaticImage.Builder']/method[@name='isAuto' and count(parameter)=0]"
				[Register ("isAuto", "()Z", "GetIsAutoHandler")]
				get {
					if (id_isAuto == IntPtr.Zero)
						id_isAuto = JNIEnv.GetMethodID (class_ref, "isAuto", "()Z");
					try {

						if (((object) this).GetType () == ThresholdType)
							return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isAuto);
						else
							return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isAuto", "()Z"));
					} finally {
					}
				}
			}

			static Delegate cb_isLogo;
#pragma warning disable 0169
			static Delegate GetIsLogoHandler ()
			{
				if (cb_isLogo == null)
					cb_isLogo = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsLogo);
				return cb_isLogo;
			}

			static bool n_IsLogo (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Mapbox.Services.Api.Staticimage.V1.MapboxStaticImage.Builder __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Services.Api.Staticimage.V1.MapboxStaticImage.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return __this.IsLogo;
			}
#pragma warning restore 0169

			static IntPtr id_isLogo;
			public virtual unsafe bool IsLogo {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.services.api.staticimage.v1']/class[@name='MapboxStaticImage.Builder']/method[@name='isLogo' and count(parameter)=0]"
				[Register ("isLogo", "()Z", "GetIsLogoHandler")]
				get {
					if (id_isLogo == IntPtr.Zero)
						id_isLogo = JNIEnv.GetMethodID (class_ref, "isLogo", "()Z");
					try {

						if (((object) this).GetType () == ThresholdType)
							return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isLogo);
						else
							return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isLogo", "()Z"));
					} finally {
					}
				}
			}

			static Delegate cb_getLocationPathSegment;
#pragma warning disable 0169
			static Delegate GetGetLocationPathSegmentHandler ()
			{
				if (cb_getLocationPathSegment == null)
					cb_getLocationPathSegment = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetLocationPathSegment);
				return cb_getLocationPathSegment;
			}

			static IntPtr n_GetLocationPathSegment (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Mapbox.Services.Api.Staticimage.V1.MapboxStaticImage.Builder __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Services.Api.Staticimage.V1.MapboxStaticImage.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.NewString (__this.LocationPathSegment);
			}
#pragma warning restore 0169

			static IntPtr id_getLocationPathSegment;
			public virtual unsafe string LocationPathSegment {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.services.api.staticimage.v1']/class[@name='MapboxStaticImage.Builder']/method[@name='getLocationPathSegment' and count(parameter)=0]"
				[Register ("getLocationPathSegment", "()Ljava/lang/String;", "GetGetLocationPathSegmentHandler")]
				get {
					if (id_getLocationPathSegment == IntPtr.Zero)
						id_getLocationPathSegment = JNIEnv.GetMethodID (class_ref, "getLocationPathSegment", "()Ljava/lang/String;");
					try {

						if (((object) this).GetType () == ThresholdType)
							return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getLocationPathSegment), JniHandleOwnership.TransferLocalRef);
						else
							return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getLocationPathSegment", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
			}

			static Delegate cb_getOverlays;
#pragma warning disable 0169
			static Delegate GetGetOverlaysHandler ()
			{
				if (cb_getOverlays == null)
					cb_getOverlays = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetOverlays);
				return cb_getOverlays;
			}

			static IntPtr n_GetOverlays (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Mapbox.Services.Api.Staticimage.V1.MapboxStaticImage.Builder __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Services.Api.Staticimage.V1.MapboxStaticImage.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.NewString (__this.Overlays);
			}
#pragma warning restore 0169

			static IntPtr id_getOverlays;
			public virtual unsafe string Overlays {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.services.api.staticimage.v1']/class[@name='MapboxStaticImage.Builder']/method[@name='getOverlays' and count(parameter)=0]"
				[Register ("getOverlays", "()Ljava/lang/String;", "GetGetOverlaysHandler")]
				get {
					if (id_getOverlays == IntPtr.Zero)
						id_getOverlays = JNIEnv.GetMethodID (class_ref, "getOverlays", "()Ljava/lang/String;");
					try {

						if (((object) this).GetType () == ThresholdType)
							return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getOverlays), JniHandleOwnership.TransferLocalRef);
						else
							return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getOverlays", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
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
				global::Com.Mapbox.Services.Api.Staticimage.V1.MapboxStaticImage.Builder __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Services.Api.Staticimage.V1.MapboxStaticImage.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return __this.Precision;
			}
#pragma warning restore 0169

			static IntPtr id_getPrecision;
			public virtual unsafe int Precision {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.services.api.staticimage.v1']/class[@name='MapboxStaticImage.Builder']/method[@name='getPrecision' and count(parameter)=0]"
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

			static Delegate cb_getSizePathSegment;
#pragma warning disable 0169
			static Delegate GetGetSizePathSegmentHandler ()
			{
				if (cb_getSizePathSegment == null)
					cb_getSizePathSegment = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetSizePathSegment);
				return cb_getSizePathSegment;
			}

			static IntPtr n_GetSizePathSegment (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Mapbox.Services.Api.Staticimage.V1.MapboxStaticImage.Builder __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Services.Api.Staticimage.V1.MapboxStaticImage.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.NewString (__this.SizePathSegment);
			}
#pragma warning restore 0169

			static IntPtr id_getSizePathSegment;
			public virtual unsafe string SizePathSegment {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.services.api.staticimage.v1']/class[@name='MapboxStaticImage.Builder']/method[@name='getSizePathSegment' and count(parameter)=0]"
				[Register ("getSizePathSegment", "()Ljava/lang/String;", "GetGetSizePathSegmentHandler")]
				get {
					if (id_getSizePathSegment == IntPtr.Zero)
						id_getSizePathSegment = JNIEnv.GetMethodID (class_ref, "getSizePathSegment", "()Ljava/lang/String;");
					try {

						if (((object) this).GetType () == ThresholdType)
							return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getSizePathSegment), JniHandleOwnership.TransferLocalRef);
						else
							return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getSizePathSegment", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
			}

			static Delegate cb_getStyleId;
#pragma warning disable 0169
			static Delegate GetGetStyleIdHandler ()
			{
				if (cb_getStyleId == null)
					cb_getStyleId = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetStyleId);
				return cb_getStyleId;
			}

			static IntPtr n_GetStyleId (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Mapbox.Services.Api.Staticimage.V1.MapboxStaticImage.Builder __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Services.Api.Staticimage.V1.MapboxStaticImage.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.NewString (__this.StyleId);
			}
#pragma warning restore 0169

			static IntPtr id_getStyleId;
			public virtual unsafe string StyleId {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.services.api.staticimage.v1']/class[@name='MapboxStaticImage.Builder']/method[@name='getStyleId' and count(parameter)=0]"
				[Register ("getStyleId", "()Ljava/lang/String;", "GetGetStyleIdHandler")]
				get {
					if (id_getStyleId == IntPtr.Zero)
						id_getStyleId = JNIEnv.GetMethodID (class_ref, "getStyleId", "()Ljava/lang/String;");
					try {

						if (((object) this).GetType () == ThresholdType)
							return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getStyleId), JniHandleOwnership.TransferLocalRef);
						else
							return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getStyleId", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
			}

			static Delegate cb_getUsername;
#pragma warning disable 0169
			static Delegate GetGetUsernameHandler ()
			{
				if (cb_getUsername == null)
					cb_getUsername = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetUsername);
				return cb_getUsername;
			}

			static IntPtr n_GetUsername (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Mapbox.Services.Api.Staticimage.V1.MapboxStaticImage.Builder __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Services.Api.Staticimage.V1.MapboxStaticImage.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.NewString (__this.Username);
			}
#pragma warning restore 0169

			static IntPtr id_getUsername;
			public virtual unsafe string Username {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.services.api.staticimage.v1']/class[@name='MapboxStaticImage.Builder']/method[@name='getUsername' and count(parameter)=0]"
				[Register ("getUsername", "()Ljava/lang/String;", "GetGetUsernameHandler")]
				get {
					if (id_getUsername == IntPtr.Zero)
						id_getUsername = JNIEnv.GetMethodID (class_ref, "getUsername", "()Ljava/lang/String;");
					try {

						if (((object) this).GetType () == ThresholdType)
							return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getUsername), JniHandleOwnership.TransferLocalRef);
						else
							return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getUsername", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
			}

			static Delegate cb_build;
#pragma warning disable 0169
			static Delegate GetStaticImageBuidHandler ()
			{
				if (cb_build == null)
					cb_build = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_StaticImageBuid);
				return cb_build;
			}

			static IntPtr n_StaticImageBuid (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Mapbox.Services.Api.Staticimage.V1.MapboxStaticImage.Builder __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Services.Api.Staticimage.V1.MapboxStaticImage.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.StaticImageBuid ());
			}
#pragma warning restore 0169

			static IntPtr id_build;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.services.api.staticimage.v1']/class[@name='MapboxStaticImage.Builder']/method[@name='build' and count(parameter)=0]"
			[Register ("build", "()Lcom/mapbox/services/api/staticimage/v1/MapboxStaticImage;", "GetStaticImageBuidHandler")]
			public virtual unsafe global::Com.Mapbox.Services.Api.Staticimage.V1.MapboxStaticImage StaticImageBuid ()
			{
				if (id_build == IntPtr.Zero)
					id_build = JNIEnv.GetMethodID (class_ref, "build", "()Lcom/mapbox/services/api/staticimage/v1/MapboxStaticImage;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Services.Api.Staticimage.V1.MapboxStaticImage> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_build), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Services.Api.Staticimage.V1.MapboxStaticImage> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "build", "()Lcom/mapbox/services/api/staticimage/v1/MapboxStaticImage;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			static Delegate cb_setAccessToken_Ljava_lang_String_;
#pragma warning disable 0169
			static Delegate GetStaticImageAccessToken_Ljava_lang_String_Handler ()
			{
				if (cb_setAccessToken_Ljava_lang_String_ == null)
					cb_setAccessToken_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_StaticImageAccessToken_Ljava_lang_String_);
				return cb_setAccessToken_Ljava_lang_String_;
			}

			static IntPtr n_StaticImageAccessToken_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Mapbox.Services.Api.Staticimage.V1.MapboxStaticImage.Builder __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Services.Api.Staticimage.V1.MapboxStaticImage.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.StaticImageAccessToken (p0));
				return __ret;
			}
#pragma warning restore 0169

			static IntPtr id_setAccessToken_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.services.api.staticimage.v1']/class[@name='MapboxStaticImage.Builder']/method[@name='setAccessToken' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setAccessToken", "(Ljava/lang/String;)Lcom/mapbox/services/api/staticimage/v1/MapboxStaticImage$Builder;", "GetStaticImageAccessToken_Ljava_lang_String_Handler")]
			public virtual unsafe global::Com.Mapbox.Services.Api.Staticimage.V1.MapboxStaticImage.Builder StaticImageAccessToken (string p0)
			{
				if (id_setAccessToken_Ljava_lang_String_ == IntPtr.Zero)
					id_setAccessToken_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setAccessToken", "(Ljava/lang/String;)Lcom/mapbox/services/api/staticimage/v1/MapboxStaticImage$Builder;");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_p0);

					global::Com.Mapbox.Services.Api.Staticimage.V1.MapboxStaticImage.Builder __ret;
					if (((object) this).GetType () == ThresholdType)
						__ret = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Services.Api.Staticimage.V1.MapboxStaticImage.Builder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_setAccessToken_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
					else
						__ret = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Services.Api.Staticimage.V1.MapboxStaticImage.Builder> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setAccessToken", "(Ljava/lang/String;)Lcom/mapbox/services/api/staticimage/v1/MapboxStaticImage$Builder;"), __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

			static Delegate cb_setAttribution_Z;
#pragma warning disable 0169
			static Delegate GetSetAttribution_ZHandler ()
			{
				if (cb_setAttribution_Z == null)
					cb_setAttribution_Z = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool, IntPtr>) n_SetAttribution_Z);
				return cb_setAttribution_Z;
			}

			static IntPtr n_SetAttribution_Z (IntPtr jnienv, IntPtr native__this, bool p0)
			{
				global::Com.Mapbox.Services.Api.Staticimage.V1.MapboxStaticImage.Builder __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Services.Api.Staticimage.V1.MapboxStaticImage.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.SetAttribution (p0));
			}
#pragma warning restore 0169

			static IntPtr id_setAttribution_Z;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.services.api.staticimage.v1']/class[@name='MapboxStaticImage.Builder']/method[@name='setAttribution' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setAttribution", "(Z)Lcom/mapbox/services/api/staticimage/v1/MapboxStaticImage$Builder;", "GetSetAttribution_ZHandler")]
			public virtual unsafe global::Com.Mapbox.Services.Api.Staticimage.V1.MapboxStaticImage.Builder SetAttribution (bool p0)
			{
				if (id_setAttribution_Z == IntPtr.Zero)
					id_setAttribution_Z = JNIEnv.GetMethodID (class_ref, "setAttribution", "(Z)Lcom/mapbox/services/api/staticimage/v1/MapboxStaticImage$Builder;");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (p0);

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Services.Api.Staticimage.V1.MapboxStaticImage.Builder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_setAttribution_Z, __args), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Services.Api.Staticimage.V1.MapboxStaticImage.Builder> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setAttribution", "(Z)Lcom/mapbox/services/api/staticimage/v1/MapboxStaticImage$Builder;"), __args), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			static Delegate cb_setAuto_Z;
#pragma warning disable 0169
			static Delegate GetSetAuto_ZHandler ()
			{
				if (cb_setAuto_Z == null)
					cb_setAuto_Z = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool, IntPtr>) n_SetAuto_Z);
				return cb_setAuto_Z;
			}

			static IntPtr n_SetAuto_Z (IntPtr jnienv, IntPtr native__this, bool p0)
			{
				global::Com.Mapbox.Services.Api.Staticimage.V1.MapboxStaticImage.Builder __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Services.Api.Staticimage.V1.MapboxStaticImage.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.SetAuto (p0));
			}
#pragma warning restore 0169

			static IntPtr id_setAuto_Z;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.services.api.staticimage.v1']/class[@name='MapboxStaticImage.Builder']/method[@name='setAuto' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setAuto", "(Z)Lcom/mapbox/services/api/staticimage/v1/MapboxStaticImage$Builder;", "GetSetAuto_ZHandler")]
			public virtual unsafe global::Com.Mapbox.Services.Api.Staticimage.V1.MapboxStaticImage.Builder SetAuto (bool p0)
			{
				if (id_setAuto_Z == IntPtr.Zero)
					id_setAuto_Z = JNIEnv.GetMethodID (class_ref, "setAuto", "(Z)Lcom/mapbox/services/api/staticimage/v1/MapboxStaticImage$Builder;");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (p0);

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Services.Api.Staticimage.V1.MapboxStaticImage.Builder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_setAuto_Z, __args), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Services.Api.Staticimage.V1.MapboxStaticImage.Builder> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setAuto", "(Z)Lcom/mapbox/services/api/staticimage/v1/MapboxStaticImage$Builder;"), __args), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			static Delegate cb_setBaseUrl_Ljava_lang_String_;
#pragma warning disable 0169
			static Delegate GetSetBaseUrl_Ljava_lang_String_Handler ()
			{
				if (cb_setBaseUrl_Ljava_lang_String_ == null)
					cb_setBaseUrl_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetBaseUrl_Ljava_lang_String_);
				return cb_setBaseUrl_Ljava_lang_String_;
			}

			static IntPtr n_SetBaseUrl_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Mapbox.Services.Api.Staticimage.V1.MapboxStaticImage.Builder __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Services.Api.Staticimage.V1.MapboxStaticImage.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetBaseUrl (p0));
				return __ret;
			}
#pragma warning restore 0169

			static IntPtr id_setBaseUrl_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.services.api.staticimage.v1']/class[@name='MapboxStaticImage.Builder']/method[@name='setBaseUrl' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setBaseUrl", "(Ljava/lang/String;)Lcom/mapbox/services/api/MapboxBuilder;", "GetSetBaseUrl_Ljava_lang_String_Handler")]
			public override unsafe global::Java.Lang.Object SetBaseUrl (string p0)
			{
				if (id_setBaseUrl_Ljava_lang_String_ == IntPtr.Zero)
					id_setBaseUrl_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setBaseUrl", "(Ljava/lang/String;)Lcom/mapbox/services/api/MapboxBuilder;");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_p0);

					global::Java.Lang.Object __ret;
					if (((object) this).GetType () == ThresholdType)
						__ret = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_setBaseUrl_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
					else
						__ret = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setBaseUrl", "(Ljava/lang/String;)Lcom/mapbox/services/api/MapboxBuilder;"), __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

			static Delegate cb_setBearing_D;
#pragma warning disable 0169
			static Delegate GetSetBearing_DHandler ()
			{
				if (cb_setBearing_D == null)
					cb_setBearing_D = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, double, IntPtr>) n_SetBearing_D);
				return cb_setBearing_D;
			}

			static IntPtr n_SetBearing_D (IntPtr jnienv, IntPtr native__this, double p0)
			{
				global::Com.Mapbox.Services.Api.Staticimage.V1.MapboxStaticImage.Builder __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Services.Api.Staticimage.V1.MapboxStaticImage.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.SetBearing (p0));
			}
#pragma warning restore 0169

			static IntPtr id_setBearing_D;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.services.api.staticimage.v1']/class[@name='MapboxStaticImage.Builder']/method[@name='setBearing' and count(parameter)=1 and parameter[1][@type='double']]"
			[Register ("setBearing", "(D)Lcom/mapbox/services/api/staticimage/v1/MapboxStaticImage$Builder;", "GetSetBearing_DHandler")]
			public virtual unsafe global::Com.Mapbox.Services.Api.Staticimage.V1.MapboxStaticImage.Builder SetBearing (double p0)
			{
				if (id_setBearing_D == IntPtr.Zero)
					id_setBearing_D = JNIEnv.GetMethodID (class_ref, "setBearing", "(D)Lcom/mapbox/services/api/staticimage/v1/MapboxStaticImage$Builder;");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (p0);

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Services.Api.Staticimage.V1.MapboxStaticImage.Builder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_setBearing_D, __args), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Services.Api.Staticimage.V1.MapboxStaticImage.Builder> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setBearing", "(D)Lcom/mapbox/services/api/staticimage/v1/MapboxStaticImage$Builder;"), __args), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			static Delegate cb_setBeforeLayer_Ljava_lang_String_;
#pragma warning disable 0169
			static Delegate GetSetBeforeLayer_Ljava_lang_String_Handler ()
			{
				if (cb_setBeforeLayer_Ljava_lang_String_ == null)
					cb_setBeforeLayer_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetBeforeLayer_Ljava_lang_String_);
				return cb_setBeforeLayer_Ljava_lang_String_;
			}

			static IntPtr n_SetBeforeLayer_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Mapbox.Services.Api.Staticimage.V1.MapboxStaticImage.Builder __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Services.Api.Staticimage.V1.MapboxStaticImage.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetBeforeLayer (p0));
				return __ret;
			}
#pragma warning restore 0169

			static IntPtr id_setBeforeLayer_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.services.api.staticimage.v1']/class[@name='MapboxStaticImage.Builder']/method[@name='setBeforeLayer' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setBeforeLayer", "(Ljava/lang/String;)Lcom/mapbox/services/api/staticimage/v1/MapboxStaticImage$Builder;", "GetSetBeforeLayer_Ljava_lang_String_Handler")]
			public virtual unsafe global::Com.Mapbox.Services.Api.Staticimage.V1.MapboxStaticImage.Builder SetBeforeLayer (string p0)
			{
				if (id_setBeforeLayer_Ljava_lang_String_ == IntPtr.Zero)
					id_setBeforeLayer_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setBeforeLayer", "(Ljava/lang/String;)Lcom/mapbox/services/api/staticimage/v1/MapboxStaticImage$Builder;");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_p0);

					global::Com.Mapbox.Services.Api.Staticimage.V1.MapboxStaticImage.Builder __ret;
					if (((object) this).GetType () == ThresholdType)
						__ret = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Services.Api.Staticimage.V1.MapboxStaticImage.Builder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_setBeforeLayer_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
					else
						__ret = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Services.Api.Staticimage.V1.MapboxStaticImage.Builder> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setBeforeLayer", "(Ljava/lang/String;)Lcom/mapbox/services/api/staticimage/v1/MapboxStaticImage$Builder;"), __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

			static Delegate cb_setClientAppName_Ljava_lang_String_;
#pragma warning disable 0169
			static Delegate GetStaticImageSetClientAppName_Ljava_lang_String_Handler ()
			{
				if (cb_setClientAppName_Ljava_lang_String_ == null)
					cb_setClientAppName_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_StaticImageSetClientAppName_Ljava_lang_String_);
				return cb_setClientAppName_Ljava_lang_String_;
			}

			static IntPtr n_StaticImageSetClientAppName_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Mapbox.Services.Api.Staticimage.V1.MapboxStaticImage.Builder __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Services.Api.Staticimage.V1.MapboxStaticImage.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.StaticImageSetClientAppName (p0));
				return __ret;
			}
#pragma warning restore 0169

			static IntPtr id_setClientAppName_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.services.api.staticimage.v1']/class[@name='MapboxStaticImage.Builder']/method[@name='setClientAppName' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setClientAppName", "(Ljava/lang/String;)Lcom/mapbox/services/api/staticimage/v1/MapboxStaticImage$Builder;", "GetStaticImageSetClientAppName_Ljava_lang_String_Handler")]
			public virtual unsafe global::Com.Mapbox.Services.Api.Staticimage.V1.MapboxStaticImage.Builder StaticImageSetClientAppName (string p0)
			{
				if (id_setClientAppName_Ljava_lang_String_ == IntPtr.Zero)
					id_setClientAppName_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setClientAppName", "(Ljava/lang/String;)Lcom/mapbox/services/api/staticimage/v1/MapboxStaticImage$Builder;");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_p0);

					global::Com.Mapbox.Services.Api.Staticimage.V1.MapboxStaticImage.Builder __ret;
					if (((object) this).GetType () == ThresholdType)
						__ret = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Services.Api.Staticimage.V1.MapboxStaticImage.Builder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_setClientAppName_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
					else
						__ret = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Services.Api.Staticimage.V1.MapboxStaticImage.Builder> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setClientAppName", "(Ljava/lang/String;)Lcom/mapbox/services/api/staticimage/v1/MapboxStaticImage$Builder;"), __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

			static Delegate cb_setGeoJson_Lcom_mapbox_services_commons_geojson_GeoJSON_;
#pragma warning disable 0169
			static Delegate GetSetGeoJson_Lcom_mapbox_services_commons_geojson_GeoJSON_Handler ()
			{
				if (cb_setGeoJson_Lcom_mapbox_services_commons_geojson_GeoJSON_ == null)
					cb_setGeoJson_Lcom_mapbox_services_commons_geojson_GeoJSON_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetGeoJson_Lcom_mapbox_services_commons_geojson_GeoJSON_);
				return cb_setGeoJson_Lcom_mapbox_services_commons_geojson_GeoJSON_;
			}

			static IntPtr n_SetGeoJson_Lcom_mapbox_services_commons_geojson_GeoJSON_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Mapbox.Services.Api.Staticimage.V1.MapboxStaticImage.Builder __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Services.Api.Staticimage.V1.MapboxStaticImage.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Com.Mapbox.Services.Commons.Geojson.IGeoJSON p0 = (global::Com.Mapbox.Services.Commons.Geojson.IGeoJSON)global::Java.Lang.Object.GetObject<global::Com.Mapbox.Services.Commons.Geojson.IGeoJSON> (native_p0, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetGeoJson (p0));
				return __ret;
			}
#pragma warning restore 0169

			static IntPtr id_setGeoJson_Lcom_mapbox_services_commons_geojson_GeoJSON_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.services.api.staticimage.v1']/class[@name='MapboxStaticImage.Builder']/method[@name='setGeoJson' and count(parameter)=1 and parameter[1][@type='com.mapbox.services.commons.geojson.GeoJSON']]"
			[Register ("setGeoJson", "(Lcom/mapbox/services/commons/geojson/GeoJSON;)Lcom/mapbox/services/api/staticimage/v1/MapboxStaticImage$Builder;", "GetSetGeoJson_Lcom_mapbox_services_commons_geojson_GeoJSON_Handler")]
			public virtual unsafe global::Com.Mapbox.Services.Api.Staticimage.V1.MapboxStaticImage.Builder SetGeoJson (global::Com.Mapbox.Services.Commons.Geojson.IGeoJSON p0)
			{
				if (id_setGeoJson_Lcom_mapbox_services_commons_geojson_GeoJSON_ == IntPtr.Zero)
					id_setGeoJson_Lcom_mapbox_services_commons_geojson_GeoJSON_ = JNIEnv.GetMethodID (class_ref, "setGeoJson", "(Lcom/mapbox/services/commons/geojson/GeoJSON;)Lcom/mapbox/services/api/staticimage/v1/MapboxStaticImage$Builder;");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (p0);

					global::Com.Mapbox.Services.Api.Staticimage.V1.MapboxStaticImage.Builder __ret;
					if (((object) this).GetType () == ThresholdType)
						__ret = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Services.Api.Staticimage.V1.MapboxStaticImage.Builder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_setGeoJson_Lcom_mapbox_services_commons_geojson_GeoJSON_, __args), JniHandleOwnership.TransferLocalRef);
					else
						__ret = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Services.Api.Staticimage.V1.MapboxStaticImage.Builder> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setGeoJson", "(Lcom/mapbox/services/commons/geojson/GeoJSON;)Lcom/mapbox/services/api/staticimage/v1/MapboxStaticImage$Builder;"), __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
				}
			}

			static Delegate cb_setHeight_I;
#pragma warning disable 0169
			static Delegate GetSetHeight_IHandler ()
			{
				if (cb_setHeight_I == null)
					cb_setHeight_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_SetHeight_I);
				return cb_setHeight_I;
			}

			static IntPtr n_SetHeight_I (IntPtr jnienv, IntPtr native__this, int p0)
			{
				global::Com.Mapbox.Services.Api.Staticimage.V1.MapboxStaticImage.Builder __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Services.Api.Staticimage.V1.MapboxStaticImage.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.SetHeight (p0));
			}
#pragma warning restore 0169

			static IntPtr id_setHeight_I;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.services.api.staticimage.v1']/class[@name='MapboxStaticImage.Builder']/method[@name='setHeight' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setHeight", "(I)Lcom/mapbox/services/api/staticimage/v1/MapboxStaticImage$Builder;", "GetSetHeight_IHandler")]
			public virtual unsafe global::Com.Mapbox.Services.Api.Staticimage.V1.MapboxStaticImage.Builder SetHeight (int p0)
			{
				if (id_setHeight_I == IntPtr.Zero)
					id_setHeight_I = JNIEnv.GetMethodID (class_ref, "setHeight", "(I)Lcom/mapbox/services/api/staticimage/v1/MapboxStaticImage$Builder;");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (p0);

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Services.Api.Staticimage.V1.MapboxStaticImage.Builder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_setHeight_I, __args), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Services.Api.Staticimage.V1.MapboxStaticImage.Builder> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setHeight", "(I)Lcom/mapbox/services/api/staticimage/v1/MapboxStaticImage$Builder;"), __args), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			static Delegate cb_setLat_D;
#pragma warning disable 0169
			static Delegate GetSetLat_DHandler ()
			{
				if (cb_setLat_D == null)
					cb_setLat_D = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, double, IntPtr>) n_SetLat_D);
				return cb_setLat_D;
			}

			static IntPtr n_SetLat_D (IntPtr jnienv, IntPtr native__this, double p0)
			{
				global::Com.Mapbox.Services.Api.Staticimage.V1.MapboxStaticImage.Builder __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Services.Api.Staticimage.V1.MapboxStaticImage.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.SetLat (p0));
			}
#pragma warning restore 0169

			static IntPtr id_setLat_D;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.services.api.staticimage.v1']/class[@name='MapboxStaticImage.Builder']/method[@name='setLat' and count(parameter)=1 and parameter[1][@type='double']]"
			[Register ("setLat", "(D)Lcom/mapbox/services/api/staticimage/v1/MapboxStaticImage$Builder;", "GetSetLat_DHandler")]
			public virtual unsafe global::Com.Mapbox.Services.Api.Staticimage.V1.MapboxStaticImage.Builder SetLat (double p0)
			{
				if (id_setLat_D == IntPtr.Zero)
					id_setLat_D = JNIEnv.GetMethodID (class_ref, "setLat", "(D)Lcom/mapbox/services/api/staticimage/v1/MapboxStaticImage$Builder;");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (p0);

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Services.Api.Staticimage.V1.MapboxStaticImage.Builder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_setLat_D, __args), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Services.Api.Staticimage.V1.MapboxStaticImage.Builder> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setLat", "(D)Lcom/mapbox/services/api/staticimage/v1/MapboxStaticImage$Builder;"), __args), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			static Delegate cb_setLocation_Lcom_mapbox_services_commons_models_Position_;
#pragma warning disable 0169
			static Delegate GetSetLocation_Lcom_mapbox_services_commons_models_Position_Handler ()
			{
				if (cb_setLocation_Lcom_mapbox_services_commons_models_Position_ == null)
					cb_setLocation_Lcom_mapbox_services_commons_models_Position_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetLocation_Lcom_mapbox_services_commons_models_Position_);
				return cb_setLocation_Lcom_mapbox_services_commons_models_Position_;
			}

			static IntPtr n_SetLocation_Lcom_mapbox_services_commons_models_Position_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Mapbox.Services.Api.Staticimage.V1.MapboxStaticImage.Builder __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Services.Api.Staticimage.V1.MapboxStaticImage.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Com.Mapbox.Services.Commons.Models.Position p0 = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Services.Commons.Models.Position> (native_p0, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetLocation (p0));
				return __ret;
			}
#pragma warning restore 0169

			static IntPtr id_setLocation_Lcom_mapbox_services_commons_models_Position_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.services.api.staticimage.v1']/class[@name='MapboxStaticImage.Builder']/method[@name='setLocation' and count(parameter)=1 and parameter[1][@type='com.mapbox.services.commons.models.Position']]"
			[Obsolete (@"deprecated")]
			[Register ("setLocation", "(Lcom/mapbox/services/commons/models/Position;)Lcom/mapbox/services/api/staticimage/v1/MapboxStaticImage$Builder;", "GetSetLocation_Lcom_mapbox_services_commons_models_Position_Handler")]
			public virtual unsafe global::Com.Mapbox.Services.Api.Staticimage.V1.MapboxStaticImage.Builder SetLocation (global::Com.Mapbox.Services.Commons.Models.Position p0)
			{
				if (id_setLocation_Lcom_mapbox_services_commons_models_Position_ == IntPtr.Zero)
					id_setLocation_Lcom_mapbox_services_commons_models_Position_ = JNIEnv.GetMethodID (class_ref, "setLocation", "(Lcom/mapbox/services/commons/models/Position;)Lcom/mapbox/services/api/staticimage/v1/MapboxStaticImage$Builder;");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (p0);

					global::Com.Mapbox.Services.Api.Staticimage.V1.MapboxStaticImage.Builder __ret;
					if (((object) this).GetType () == ThresholdType)
						__ret = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Services.Api.Staticimage.V1.MapboxStaticImage.Builder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_setLocation_Lcom_mapbox_services_commons_models_Position_, __args), JniHandleOwnership.TransferLocalRef);
					else
						__ret = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Services.Api.Staticimage.V1.MapboxStaticImage.Builder> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setLocation", "(Lcom/mapbox/services/commons/models/Position;)Lcom/mapbox/services/api/staticimage/v1/MapboxStaticImage$Builder;"), __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
				}
			}

			static Delegate cb_setLogo_Z;
#pragma warning disable 0169
			static Delegate GetSetLogo_ZHandler ()
			{
				if (cb_setLogo_Z == null)
					cb_setLogo_Z = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool, IntPtr>) n_SetLogo_Z);
				return cb_setLogo_Z;
			}

			static IntPtr n_SetLogo_Z (IntPtr jnienv, IntPtr native__this, bool p0)
			{
				global::Com.Mapbox.Services.Api.Staticimage.V1.MapboxStaticImage.Builder __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Services.Api.Staticimage.V1.MapboxStaticImage.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.SetLogo (p0));
			}
#pragma warning restore 0169

			static IntPtr id_setLogo_Z;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.services.api.staticimage.v1']/class[@name='MapboxStaticImage.Builder']/method[@name='setLogo' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setLogo", "(Z)Lcom/mapbox/services/api/staticimage/v1/MapboxStaticImage$Builder;", "GetSetLogo_ZHandler")]
			public virtual unsafe global::Com.Mapbox.Services.Api.Staticimage.V1.MapboxStaticImage.Builder SetLogo (bool p0)
			{
				if (id_setLogo_Z == IntPtr.Zero)
					id_setLogo_Z = JNIEnv.GetMethodID (class_ref, "setLogo", "(Z)Lcom/mapbox/services/api/staticimage/v1/MapboxStaticImage$Builder;");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (p0);

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Services.Api.Staticimage.V1.MapboxStaticImage.Builder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_setLogo_Z, __args), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Services.Api.Staticimage.V1.MapboxStaticImage.Builder> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setLogo", "(Z)Lcom/mapbox/services/api/staticimage/v1/MapboxStaticImage$Builder;"), __args), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			static Delegate cb_setLon_D;
#pragma warning disable 0169
			static Delegate GetSetLon_DHandler ()
			{
				if (cb_setLon_D == null)
					cb_setLon_D = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, double, IntPtr>) n_SetLon_D);
				return cb_setLon_D;
			}

			static IntPtr n_SetLon_D (IntPtr jnienv, IntPtr native__this, double p0)
			{
				global::Com.Mapbox.Services.Api.Staticimage.V1.MapboxStaticImage.Builder __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Services.Api.Staticimage.V1.MapboxStaticImage.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.SetLon (p0));
			}
#pragma warning restore 0169

			static IntPtr id_setLon_D;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.services.api.staticimage.v1']/class[@name='MapboxStaticImage.Builder']/method[@name='setLon' and count(parameter)=1 and parameter[1][@type='double']]"
			[Register ("setLon", "(D)Lcom/mapbox/services/api/staticimage/v1/MapboxStaticImage$Builder;", "GetSetLon_DHandler")]
			public virtual unsafe global::Com.Mapbox.Services.Api.Staticimage.V1.MapboxStaticImage.Builder SetLon (double p0)
			{
				if (id_setLon_D == IntPtr.Zero)
					id_setLon_D = JNIEnv.GetMethodID (class_ref, "setLon", "(D)Lcom/mapbox/services/api/staticimage/v1/MapboxStaticImage$Builder;");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (p0);

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Services.Api.Staticimage.V1.MapboxStaticImage.Builder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_setLon_D, __args), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Services.Api.Staticimage.V1.MapboxStaticImage.Builder> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setLon", "(D)Lcom/mapbox/services/api/staticimage/v1/MapboxStaticImage$Builder;"), __args), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			static Delegate cb_setPitch_D;
#pragma warning disable 0169
			static Delegate GetSetPitch_DHandler ()
			{
				if (cb_setPitch_D == null)
					cb_setPitch_D = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, double, IntPtr>) n_SetPitch_D);
				return cb_setPitch_D;
			}

			static IntPtr n_SetPitch_D (IntPtr jnienv, IntPtr native__this, double p0)
			{
				global::Com.Mapbox.Services.Api.Staticimage.V1.MapboxStaticImage.Builder __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Services.Api.Staticimage.V1.MapboxStaticImage.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.SetPitch (p0));
			}
#pragma warning restore 0169

			static IntPtr id_setPitch_D;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.services.api.staticimage.v1']/class[@name='MapboxStaticImage.Builder']/method[@name='setPitch' and count(parameter)=1 and parameter[1][@type='double']]"
			[Register ("setPitch", "(D)Lcom/mapbox/services/api/staticimage/v1/MapboxStaticImage$Builder;", "GetSetPitch_DHandler")]
			public virtual unsafe global::Com.Mapbox.Services.Api.Staticimage.V1.MapboxStaticImage.Builder SetPitch (double p0)
			{
				if (id_setPitch_D == IntPtr.Zero)
					id_setPitch_D = JNIEnv.GetMethodID (class_ref, "setPitch", "(D)Lcom/mapbox/services/api/staticimage/v1/MapboxStaticImage$Builder;");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (p0);

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Services.Api.Staticimage.V1.MapboxStaticImage.Builder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_setPitch_D, __args), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Services.Api.Staticimage.V1.MapboxStaticImage.Builder> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setPitch", "(D)Lcom/mapbox/services/api/staticimage/v1/MapboxStaticImage$Builder;"), __args), JniHandleOwnership.TransferLocalRef);
				} finally {
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
				global::Com.Mapbox.Services.Api.Staticimage.V1.MapboxStaticImage.Builder __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Services.Api.Staticimage.V1.MapboxStaticImage.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Com.Mapbox.Services.Commons.Models.Position p0 = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Services.Commons.Models.Position> (native_p0, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetPosition (p0));
				return __ret;
			}
#pragma warning restore 0169

			static IntPtr id_setPosition_Lcom_mapbox_services_commons_models_Position_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.services.api.staticimage.v1']/class[@name='MapboxStaticImage.Builder']/method[@name='setPosition' and count(parameter)=1 and parameter[1][@type='com.mapbox.services.commons.models.Position']]"
			[Register ("setPosition", "(Lcom/mapbox/services/commons/models/Position;)Lcom/mapbox/services/api/staticimage/v1/MapboxStaticImage$Builder;", "GetSetPosition_Lcom_mapbox_services_commons_models_Position_Handler")]
			public virtual unsafe global::Com.Mapbox.Services.Api.Staticimage.V1.MapboxStaticImage.Builder SetPosition (global::Com.Mapbox.Services.Commons.Models.Position p0)
			{
				if (id_setPosition_Lcom_mapbox_services_commons_models_Position_ == IntPtr.Zero)
					id_setPosition_Lcom_mapbox_services_commons_models_Position_ = JNIEnv.GetMethodID (class_ref, "setPosition", "(Lcom/mapbox/services/commons/models/Position;)Lcom/mapbox/services/api/staticimage/v1/MapboxStaticImage$Builder;");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (p0);

					global::Com.Mapbox.Services.Api.Staticimage.V1.MapboxStaticImage.Builder __ret;
					if (((object) this).GetType () == ThresholdType)
						__ret = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Services.Api.Staticimage.V1.MapboxStaticImage.Builder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_setPosition_Lcom_mapbox_services_commons_models_Position_, __args), JniHandleOwnership.TransferLocalRef);
					else
						__ret = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Services.Api.Staticimage.V1.MapboxStaticImage.Builder> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setPosition", "(Lcom/mapbox/services/commons/models/Position;)Lcom/mapbox/services/api/staticimage/v1/MapboxStaticImage$Builder;"), __args), JniHandleOwnership.TransferLocalRef);
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
				global::Com.Mapbox.Services.Api.Staticimage.V1.MapboxStaticImage.Builder __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Services.Api.Staticimage.V1.MapboxStaticImage.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.SetPrecision (p0));
			}
#pragma warning restore 0169

			static IntPtr id_setPrecision_I;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.services.api.staticimage.v1']/class[@name='MapboxStaticImage.Builder']/method[@name='setPrecision' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setPrecision", "(I)Lcom/mapbox/services/api/staticimage/v1/MapboxStaticImage$Builder;", "GetSetPrecision_IHandler")]
			public virtual unsafe global::Com.Mapbox.Services.Api.Staticimage.V1.MapboxStaticImage.Builder SetPrecision (int p0)
			{
				if (id_setPrecision_I == IntPtr.Zero)
					id_setPrecision_I = JNIEnv.GetMethodID (class_ref, "setPrecision", "(I)Lcom/mapbox/services/api/staticimage/v1/MapboxStaticImage$Builder;");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (p0);

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Services.Api.Staticimage.V1.MapboxStaticImage.Builder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_setPrecision_I, __args), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Services.Api.Staticimage.V1.MapboxStaticImage.Builder> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setPrecision", "(I)Lcom/mapbox/services/api/staticimage/v1/MapboxStaticImage$Builder;"), __args), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			static Delegate cb_setRetina_Z;
#pragma warning disable 0169
			static Delegate GetSetRetina_ZHandler ()
			{
				if (cb_setRetina_Z == null)
					cb_setRetina_Z = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool, IntPtr>) n_SetRetina_Z);
				return cb_setRetina_Z;
			}

			static IntPtr n_SetRetina_Z (IntPtr jnienv, IntPtr native__this, bool p0)
			{
				global::Com.Mapbox.Services.Api.Staticimage.V1.MapboxStaticImage.Builder __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Services.Api.Staticimage.V1.MapboxStaticImage.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.SetRetina (p0));
			}
#pragma warning restore 0169

			static IntPtr id_setRetina_Z;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.services.api.staticimage.v1']/class[@name='MapboxStaticImage.Builder']/method[@name='setRetina' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setRetina", "(Z)Lcom/mapbox/services/api/staticimage/v1/MapboxStaticImage$Builder;", "GetSetRetina_ZHandler")]
			public virtual unsafe global::Com.Mapbox.Services.Api.Staticimage.V1.MapboxStaticImage.Builder SetRetina (bool p0)
			{
				if (id_setRetina_Z == IntPtr.Zero)
					id_setRetina_Z = JNIEnv.GetMethodID (class_ref, "setRetina", "(Z)Lcom/mapbox/services/api/staticimage/v1/MapboxStaticImage$Builder;");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (p0);

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Services.Api.Staticimage.V1.MapboxStaticImage.Builder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_setRetina_Z, __args), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Services.Api.Staticimage.V1.MapboxStaticImage.Builder> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setRetina", "(Z)Lcom/mapbox/services/api/staticimage/v1/MapboxStaticImage$Builder;"), __args), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			static Delegate cb_setStaticMarkerAnnotations_arrayLcom_mapbox_services_api_staticimage_v1_models_StaticMarkerAnnotation_;
#pragma warning disable 0169
			static Delegate GetSetStaticMarkerAnnotations_arrayLcom_mapbox_services_api_staticimage_v1_models_StaticMarkerAnnotation_Handler ()
			{
				if (cb_setStaticMarkerAnnotations_arrayLcom_mapbox_services_api_staticimage_v1_models_StaticMarkerAnnotation_ == null)
					cb_setStaticMarkerAnnotations_arrayLcom_mapbox_services_api_staticimage_v1_models_StaticMarkerAnnotation_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetStaticMarkerAnnotations_arrayLcom_mapbox_services_api_staticimage_v1_models_StaticMarkerAnnotation_);
				return cb_setStaticMarkerAnnotations_arrayLcom_mapbox_services_api_staticimage_v1_models_StaticMarkerAnnotation_;
			}

			static IntPtr n_SetStaticMarkerAnnotations_arrayLcom_mapbox_services_api_staticimage_v1_models_StaticMarkerAnnotation_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Mapbox.Services.Api.Staticimage.V1.MapboxStaticImage.Builder __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Services.Api.Staticimage.V1.MapboxStaticImage.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Com.Mapbox.Services.Api.Staticimage.V1.Models.StaticMarkerAnnotation[] p0 = (global::Com.Mapbox.Services.Api.Staticimage.V1.Models.StaticMarkerAnnotation[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (global::Com.Mapbox.Services.Api.Staticimage.V1.Models.StaticMarkerAnnotation));
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetStaticMarkerAnnotations (p0));
				if (p0 != null)
					JNIEnv.CopyArray (p0, native_p0);
				return __ret;
			}
#pragma warning restore 0169

			static IntPtr id_setStaticMarkerAnnotations_arrayLcom_mapbox_services_api_staticimage_v1_models_StaticMarkerAnnotation_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.services.api.staticimage.v1']/class[@name='MapboxStaticImage.Builder']/method[@name='setStaticMarkerAnnotations' and count(parameter)=1 and parameter[1][@type='com.mapbox.services.api.staticimage.v1.models.StaticMarkerAnnotation...']]"
			[Register ("setStaticMarkerAnnotations", "([Lcom/mapbox/services/api/staticimage/v1/models/StaticMarkerAnnotation;)Lcom/mapbox/services/api/staticimage/v1/MapboxStaticImage$Builder;", "GetSetStaticMarkerAnnotations_arrayLcom_mapbox_services_api_staticimage_v1_models_StaticMarkerAnnotation_Handler")]
			public virtual unsafe global::Com.Mapbox.Services.Api.Staticimage.V1.MapboxStaticImage.Builder SetStaticMarkerAnnotations (params global:: Com.Mapbox.Services.Api.Staticimage.V1.Models.StaticMarkerAnnotation[] p0)
			{
				if (id_setStaticMarkerAnnotations_arrayLcom_mapbox_services_api_staticimage_v1_models_StaticMarkerAnnotation_ == IntPtr.Zero)
					id_setStaticMarkerAnnotations_arrayLcom_mapbox_services_api_staticimage_v1_models_StaticMarkerAnnotation_ = JNIEnv.GetMethodID (class_ref, "setStaticMarkerAnnotations", "([Lcom/mapbox/services/api/staticimage/v1/models/StaticMarkerAnnotation;)Lcom/mapbox/services/api/staticimage/v1/MapboxStaticImage$Builder;");
				IntPtr native_p0 = JNIEnv.NewArray (p0);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_p0);

					global::Com.Mapbox.Services.Api.Staticimage.V1.MapboxStaticImage.Builder __ret;
					if (((object) this).GetType () == ThresholdType)
						__ret = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Services.Api.Staticimage.V1.MapboxStaticImage.Builder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_setStaticMarkerAnnotations_arrayLcom_mapbox_services_api_staticimage_v1_models_StaticMarkerAnnotation_, __args), JniHandleOwnership.TransferLocalRef);
					else
						__ret = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Services.Api.Staticimage.V1.MapboxStaticImage.Builder> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setStaticMarkerAnnotations", "([Lcom/mapbox/services/api/staticimage/v1/models/StaticMarkerAnnotation;)Lcom/mapbox/services/api/staticimage/v1/MapboxStaticImage$Builder;"), __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
					if (p0 != null) {
						JNIEnv.CopyArray (native_p0, p0);
						JNIEnv.DeleteLocalRef (native_p0);
					}
				}
			}

			static Delegate cb_setStaticPolylineAnnotations_arrayLcom_mapbox_services_api_staticimage_v1_models_StaticPolylineAnnotation_;
#pragma warning disable 0169
			static Delegate GetSetStaticPolylineAnnotations_arrayLcom_mapbox_services_api_staticimage_v1_models_StaticPolylineAnnotation_Handler ()
			{
				if (cb_setStaticPolylineAnnotations_arrayLcom_mapbox_services_api_staticimage_v1_models_StaticPolylineAnnotation_ == null)
					cb_setStaticPolylineAnnotations_arrayLcom_mapbox_services_api_staticimage_v1_models_StaticPolylineAnnotation_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetStaticPolylineAnnotations_arrayLcom_mapbox_services_api_staticimage_v1_models_StaticPolylineAnnotation_);
				return cb_setStaticPolylineAnnotations_arrayLcom_mapbox_services_api_staticimage_v1_models_StaticPolylineAnnotation_;
			}

			static IntPtr n_SetStaticPolylineAnnotations_arrayLcom_mapbox_services_api_staticimage_v1_models_StaticPolylineAnnotation_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Mapbox.Services.Api.Staticimage.V1.MapboxStaticImage.Builder __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Services.Api.Staticimage.V1.MapboxStaticImage.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Com.Mapbox.Services.Api.Staticimage.V1.Models.StaticPolylineAnnotation[] p0 = (global::Com.Mapbox.Services.Api.Staticimage.V1.Models.StaticPolylineAnnotation[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (global::Com.Mapbox.Services.Api.Staticimage.V1.Models.StaticPolylineAnnotation));
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetStaticPolylineAnnotations (p0));
				if (p0 != null)
					JNIEnv.CopyArray (p0, native_p0);
				return __ret;
			}
#pragma warning restore 0169

			static IntPtr id_setStaticPolylineAnnotations_arrayLcom_mapbox_services_api_staticimage_v1_models_StaticPolylineAnnotation_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.services.api.staticimage.v1']/class[@name='MapboxStaticImage.Builder']/method[@name='setStaticPolylineAnnotations' and count(parameter)=1 and parameter[1][@type='com.mapbox.services.api.staticimage.v1.models.StaticPolylineAnnotation...']]"
			[Register ("setStaticPolylineAnnotations", "([Lcom/mapbox/services/api/staticimage/v1/models/StaticPolylineAnnotation;)Lcom/mapbox/services/api/staticimage/v1/MapboxStaticImage$Builder;", "GetSetStaticPolylineAnnotations_arrayLcom_mapbox_services_api_staticimage_v1_models_StaticPolylineAnnotation_Handler")]
			public virtual unsafe global::Com.Mapbox.Services.Api.Staticimage.V1.MapboxStaticImage.Builder SetStaticPolylineAnnotations (params global:: Com.Mapbox.Services.Api.Staticimage.V1.Models.StaticPolylineAnnotation[] p0)
			{
				if (id_setStaticPolylineAnnotations_arrayLcom_mapbox_services_api_staticimage_v1_models_StaticPolylineAnnotation_ == IntPtr.Zero)
					id_setStaticPolylineAnnotations_arrayLcom_mapbox_services_api_staticimage_v1_models_StaticPolylineAnnotation_ = JNIEnv.GetMethodID (class_ref, "setStaticPolylineAnnotations", "([Lcom/mapbox/services/api/staticimage/v1/models/StaticPolylineAnnotation;)Lcom/mapbox/services/api/staticimage/v1/MapboxStaticImage$Builder;");
				IntPtr native_p0 = JNIEnv.NewArray (p0);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_p0);

					global::Com.Mapbox.Services.Api.Staticimage.V1.MapboxStaticImage.Builder __ret;
					if (((object) this).GetType () == ThresholdType)
						__ret = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Services.Api.Staticimage.V1.MapboxStaticImage.Builder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_setStaticPolylineAnnotations_arrayLcom_mapbox_services_api_staticimage_v1_models_StaticPolylineAnnotation_, __args), JniHandleOwnership.TransferLocalRef);
					else
						__ret = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Services.Api.Staticimage.V1.MapboxStaticImage.Builder> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setStaticPolylineAnnotations", "([Lcom/mapbox/services/api/staticimage/v1/models/StaticPolylineAnnotation;)Lcom/mapbox/services/api/staticimage/v1/MapboxStaticImage$Builder;"), __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
					if (p0 != null) {
						JNIEnv.CopyArray (native_p0, p0);
						JNIEnv.DeleteLocalRef (native_p0);
					}
				}
			}

			static Delegate cb_setStyleId_Ljava_lang_String_;
#pragma warning disable 0169
			static Delegate GetSetStyleId_Ljava_lang_String_Handler ()
			{
				if (cb_setStyleId_Ljava_lang_String_ == null)
					cb_setStyleId_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetStyleId_Ljava_lang_String_);
				return cb_setStyleId_Ljava_lang_String_;
			}

			static IntPtr n_SetStyleId_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Mapbox.Services.Api.Staticimage.V1.MapboxStaticImage.Builder __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Services.Api.Staticimage.V1.MapboxStaticImage.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetStyleId (p0));
				return __ret;
			}
#pragma warning restore 0169

			static IntPtr id_setStyleId_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.services.api.staticimage.v1']/class[@name='MapboxStaticImage.Builder']/method[@name='setStyleId' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setStyleId", "(Ljava/lang/String;)Lcom/mapbox/services/api/staticimage/v1/MapboxStaticImage$Builder;", "GetSetStyleId_Ljava_lang_String_Handler")]
			public virtual unsafe global::Com.Mapbox.Services.Api.Staticimage.V1.MapboxStaticImage.Builder SetStyleId (string p0)
			{
				if (id_setStyleId_Ljava_lang_String_ == IntPtr.Zero)
					id_setStyleId_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setStyleId", "(Ljava/lang/String;)Lcom/mapbox/services/api/staticimage/v1/MapboxStaticImage$Builder;");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_p0);

					global::Com.Mapbox.Services.Api.Staticimage.V1.MapboxStaticImage.Builder __ret;
					if (((object) this).GetType () == ThresholdType)
						__ret = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Services.Api.Staticimage.V1.MapboxStaticImage.Builder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_setStyleId_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
					else
						__ret = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Services.Api.Staticimage.V1.MapboxStaticImage.Builder> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setStyleId", "(Ljava/lang/String;)Lcom/mapbox/services/api/staticimage/v1/MapboxStaticImage$Builder;"), __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

			static Delegate cb_setUsername_Ljava_lang_String_;
#pragma warning disable 0169
			static Delegate GetSetUsername_Ljava_lang_String_Handler ()
			{
				if (cb_setUsername_Ljava_lang_String_ == null)
					cb_setUsername_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetUsername_Ljava_lang_String_);
				return cb_setUsername_Ljava_lang_String_;
			}

			static IntPtr n_SetUsername_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Mapbox.Services.Api.Staticimage.V1.MapboxStaticImage.Builder __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Services.Api.Staticimage.V1.MapboxStaticImage.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetUsername (p0));
				return __ret;
			}
#pragma warning restore 0169

			static IntPtr id_setUsername_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.services.api.staticimage.v1']/class[@name='MapboxStaticImage.Builder']/method[@name='setUsername' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setUsername", "(Ljava/lang/String;)Lcom/mapbox/services/api/staticimage/v1/MapboxStaticImage$Builder;", "GetSetUsername_Ljava_lang_String_Handler")]
			public virtual unsafe global::Com.Mapbox.Services.Api.Staticimage.V1.MapboxStaticImage.Builder SetUsername (string p0)
			{
				if (id_setUsername_Ljava_lang_String_ == IntPtr.Zero)
					id_setUsername_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setUsername", "(Ljava/lang/String;)Lcom/mapbox/services/api/staticimage/v1/MapboxStaticImage$Builder;");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_p0);

					global::Com.Mapbox.Services.Api.Staticimage.V1.MapboxStaticImage.Builder __ret;
					if (((object) this).GetType () == ThresholdType)
						__ret = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Services.Api.Staticimage.V1.MapboxStaticImage.Builder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_setUsername_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
					else
						__ret = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Services.Api.Staticimage.V1.MapboxStaticImage.Builder> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setUsername", "(Ljava/lang/String;)Lcom/mapbox/services/api/staticimage/v1/MapboxStaticImage$Builder;"), __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

			static Delegate cb_setWidth_I;
#pragma warning disable 0169
			static Delegate GetSetWidth_IHandler ()
			{
				if (cb_setWidth_I == null)
					cb_setWidth_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_SetWidth_I);
				return cb_setWidth_I;
			}

			static IntPtr n_SetWidth_I (IntPtr jnienv, IntPtr native__this, int p0)
			{
				global::Com.Mapbox.Services.Api.Staticimage.V1.MapboxStaticImage.Builder __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Services.Api.Staticimage.V1.MapboxStaticImage.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.SetWidth (p0));
			}
#pragma warning restore 0169

			static IntPtr id_setWidth_I;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.services.api.staticimage.v1']/class[@name='MapboxStaticImage.Builder']/method[@name='setWidth' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setWidth", "(I)Lcom/mapbox/services/api/staticimage/v1/MapboxStaticImage$Builder;", "GetSetWidth_IHandler")]
			public virtual unsafe global::Com.Mapbox.Services.Api.Staticimage.V1.MapboxStaticImage.Builder SetWidth (int p0)
			{
				if (id_setWidth_I == IntPtr.Zero)
					id_setWidth_I = JNIEnv.GetMethodID (class_ref, "setWidth", "(I)Lcom/mapbox/services/api/staticimage/v1/MapboxStaticImage$Builder;");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (p0);

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Services.Api.Staticimage.V1.MapboxStaticImage.Builder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_setWidth_I, __args), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Services.Api.Staticimage.V1.MapboxStaticImage.Builder> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setWidth", "(I)Lcom/mapbox/services/api/staticimage/v1/MapboxStaticImage$Builder;"), __args), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			static Delegate cb_setZoom_D;
#pragma warning disable 0169
			static Delegate GetSetZoom_DHandler ()
			{
				if (cb_setZoom_D == null)
					cb_setZoom_D = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, double, IntPtr>) n_SetZoom_D);
				return cb_setZoom_D;
			}

			static IntPtr n_SetZoom_D (IntPtr jnienv, IntPtr native__this, double p0)
			{
				global::Com.Mapbox.Services.Api.Staticimage.V1.MapboxStaticImage.Builder __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Services.Api.Staticimage.V1.MapboxStaticImage.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.SetZoom (p0));
			}
#pragma warning restore 0169

			static IntPtr id_setZoom_D;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.services.api.staticimage.v1']/class[@name='MapboxStaticImage.Builder']/method[@name='setZoom' and count(parameter)=1 and parameter[1][@type='double']]"
			[Register ("setZoom", "(D)Lcom/mapbox/services/api/staticimage/v1/MapboxStaticImage$Builder;", "GetSetZoom_DHandler")]
			public virtual unsafe global::Com.Mapbox.Services.Api.Staticimage.V1.MapboxStaticImage.Builder SetZoom (double p0)
			{
				if (id_setZoom_D == IntPtr.Zero)
					id_setZoom_D = JNIEnv.GetMethodID (class_ref, "setZoom", "(D)Lcom/mapbox/services/api/staticimage/v1/MapboxStaticImage$Builder;");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (p0);

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Services.Api.Staticimage.V1.MapboxStaticImage.Builder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_setZoom_D, __args), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Services.Api.Staticimage.V1.MapboxStaticImage.Builder> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setZoom", "(D)Lcom/mapbox/services/api/staticimage/v1/MapboxStaticImage$Builder;"), __args), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

		}

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/mapbox/services/api/staticimage/v1/MapboxStaticImage", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (MapboxStaticImage); }
		}

		protected MapboxStaticImage (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Lcom_mapbox_services_api_staticimage_v1_MapboxStaticImage_Builder_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.mapbox.services.api.staticimage.v1']/class[@name='MapboxStaticImage']/constructor[@name='MapboxStaticImage' and count(parameter)=1 and parameter[1][@type='com.mapbox.services.api.staticimage.v1.MapboxStaticImage.Builder']]"
		[Register (".ctor", "(Lcom/mapbox/services/api/staticimage/v1/MapboxStaticImage$Builder;)V", "")]
		public unsafe MapboxStaticImage (global::Com.Mapbox.Services.Api.Staticimage.V1.MapboxStaticImage.Builder p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (((object) this).GetType () != typeof (MapboxStaticImage)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Lcom/mapbox/services/api/staticimage/v1/MapboxStaticImage$Builder;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Lcom/mapbox/services/api/staticimage/v1/MapboxStaticImage$Builder;)V", __args);
					return;
				}

				if (id_ctor_Lcom_mapbox_services_api_staticimage_v1_MapboxStaticImage_Builder_ == IntPtr.Zero)
					id_ctor_Lcom_mapbox_services_api_staticimage_v1_MapboxStaticImage_Builder_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/mapbox/services/api/staticimage/v1/MapboxStaticImage$Builder;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_mapbox_services_api_staticimage_v1_MapboxStaticImage_Builder_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Lcom_mapbox_services_api_staticimage_v1_MapboxStaticImage_Builder_, __args);
			} finally {
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
			global::Com.Mapbox.Services.Api.Staticimage.V1.MapboxStaticImage __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Services.Api.Staticimage.V1.MapboxStaticImage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Url);
		}
#pragma warning restore 0169

		static IntPtr id_getUrl;
		public virtual unsafe global::Square.OkHttp3.HttpUrl Url {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.services.api.staticimage.v1']/class[@name='MapboxStaticImage']/method[@name='getUrl' and count(parameter)=0]"
			[Register ("getUrl", "()Lokhttp3/HttpUrl;", "GetGetUrlHandler")]
			get {
				if (id_getUrl == IntPtr.Zero)
					id_getUrl = JNIEnv.GetMethodID (class_ref, "getUrl", "()Lokhttp3/HttpUrl;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Square.OkHttp3.HttpUrl> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getUrl), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Square.OkHttp3.HttpUrl> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getUrl", "()Lokhttp3/HttpUrl;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

	}
}
