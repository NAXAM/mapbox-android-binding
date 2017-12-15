using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Mapbox.Services.Api.Geocoding.V5.Models {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.mapbox.services.api.geocoding.v5.models']/class[@name='CarmenContext']"
	[global::Android.Runtime.Register ("com/mapbox/services/api/geocoding/v5/models/CarmenContext", DoNotGenerateAcw=true)]
	public partial class CarmenContext : global::Java.Lang.Object {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/mapbox/services/api/geocoding/v5/models/CarmenContext", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (CarmenContext); }
		}

		protected CarmenContext (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.mapbox.services.api.geocoding.v5.models']/class[@name='CarmenContext']/constructor[@name='CarmenContext' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe CarmenContext ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (CarmenContext)) {
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

		static Delegate cb_getCategory;
#pragma warning disable 0169
		static Delegate GetGetCategoryHandler ()
		{
			if (cb_getCategory == null)
				cb_getCategory = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetCategory);
			return cb_getCategory;
		}

		static IntPtr n_GetCategory (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mapbox.Services.Api.Geocoding.V5.Models.CarmenContext __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Services.Api.Geocoding.V5.Models.CarmenContext> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Category);
		}
#pragma warning restore 0169

		static IntPtr id_getCategory;
		public virtual unsafe string Category {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.services.api.geocoding.v5.models']/class[@name='CarmenContext']/method[@name='getCategory' and count(parameter)=0]"
			[Register ("getCategory", "()Ljava/lang/String;", "GetGetCategoryHandler")]
			get {
				if (id_getCategory == IntPtr.Zero)
					id_getCategory = JNIEnv.GetMethodID (class_ref, "getCategory", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getCategory), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getCategory", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getId;
#pragma warning disable 0169
		static Delegate GetGetIdHandler ()
		{
			if (cb_getId == null)
				cb_getId = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetId);
			return cb_getId;
		}

		static IntPtr n_GetId (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mapbox.Services.Api.Geocoding.V5.Models.CarmenContext __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Services.Api.Geocoding.V5.Models.CarmenContext> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Id);
		}
#pragma warning restore 0169

		static IntPtr id_getId;
		public virtual unsafe string Id {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.services.api.geocoding.v5.models']/class[@name='CarmenContext']/method[@name='getId' and count(parameter)=0]"
			[Register ("getId", "()Ljava/lang/String;", "GetGetIdHandler")]
			get {
				if (id_getId == IntPtr.Zero)
					id_getId = JNIEnv.GetMethodID (class_ref, "getId", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getId), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getId", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getMaki;
#pragma warning disable 0169
		static Delegate GetGetMakiHandler ()
		{
			if (cb_getMaki == null)
				cb_getMaki = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetMaki);
			return cb_getMaki;
		}

		static IntPtr n_GetMaki (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mapbox.Services.Api.Geocoding.V5.Models.CarmenContext __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Services.Api.Geocoding.V5.Models.CarmenContext> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Maki);
		}
#pragma warning restore 0169

		static IntPtr id_getMaki;
		public virtual unsafe string Maki {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.services.api.geocoding.v5.models']/class[@name='CarmenContext']/method[@name='getMaki' and count(parameter)=0]"
			[Register ("getMaki", "()Ljava/lang/String;", "GetGetMakiHandler")]
			get {
				if (id_getMaki == IntPtr.Zero)
					id_getMaki = JNIEnv.GetMethodID (class_ref, "getMaki", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getMaki), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getMaki", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getShortCode;
#pragma warning disable 0169
		static Delegate GetGetShortCodeHandler ()
		{
			if (cb_getShortCode == null)
				cb_getShortCode = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetShortCode);
			return cb_getShortCode;
		}

		static IntPtr n_GetShortCode (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mapbox.Services.Api.Geocoding.V5.Models.CarmenContext __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Services.Api.Geocoding.V5.Models.CarmenContext> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.ShortCode);
		}
#pragma warning restore 0169

		static IntPtr id_getShortCode;
		public virtual unsafe string ShortCode {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.services.api.geocoding.v5.models']/class[@name='CarmenContext']/method[@name='getShortCode' and count(parameter)=0]"
			[Register ("getShortCode", "()Ljava/lang/String;", "GetGetShortCodeHandler")]
			get {
				if (id_getShortCode == IntPtr.Zero)
					id_getShortCode = JNIEnv.GetMethodID (class_ref, "getShortCode", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getShortCode), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getShortCode", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getText;
#pragma warning disable 0169
		static Delegate GetGetTextHandler ()
		{
			if (cb_getText == null)
				cb_getText = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetText);
			return cb_getText;
		}

		static IntPtr n_GetText (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mapbox.Services.Api.Geocoding.V5.Models.CarmenContext __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Services.Api.Geocoding.V5.Models.CarmenContext> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Text);
		}
#pragma warning restore 0169

		static IntPtr id_getText;
		public virtual unsafe string Text {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.services.api.geocoding.v5.models']/class[@name='CarmenContext']/method[@name='getText' and count(parameter)=0]"
			[Register ("getText", "()Ljava/lang/String;", "GetGetTextHandler")]
			get {
				if (id_getText == IntPtr.Zero)
					id_getText = JNIEnv.GetMethodID (class_ref, "getText", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getText), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getText", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getWikidata;
#pragma warning disable 0169
		static Delegate GetGetWikidataHandler ()
		{
			if (cb_getWikidata == null)
				cb_getWikidata = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetWikidata);
			return cb_getWikidata;
		}

		static IntPtr n_GetWikidata (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mapbox.Services.Api.Geocoding.V5.Models.CarmenContext __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Services.Api.Geocoding.V5.Models.CarmenContext> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Wikidata);
		}
#pragma warning restore 0169

		static IntPtr id_getWikidata;
		public virtual unsafe string Wikidata {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.services.api.geocoding.v5.models']/class[@name='CarmenContext']/method[@name='getWikidata' and count(parameter)=0]"
			[Register ("getWikidata", "()Ljava/lang/String;", "GetGetWikidataHandler")]
			get {
				if (id_getWikidata == IntPtr.Zero)
					id_getWikidata = JNIEnv.GetMethodID (class_ref, "getWikidata", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getWikidata), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getWikidata", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

	}
}
