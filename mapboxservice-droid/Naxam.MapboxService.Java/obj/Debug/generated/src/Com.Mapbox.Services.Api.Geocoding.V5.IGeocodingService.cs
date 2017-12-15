using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Mapbox.Services.Api.Geocoding.V5 {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.mapbox.services.api.geocoding.v5']/interface[@name='GeocodingService']"
	[Register ("com/mapbox/services/api/geocoding/v5/GeocodingService", "", "Com.Mapbox.Services.Api.Geocoding.V5.IGeocodingServiceInvoker")]
	public partial interface IGeocodingService : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.services.api.geocoding.v5']/interface[@name='GeocodingService']/method[@name='getBatchCall' and count(parameter)=11 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='java.lang.String'] and parameter[5][@type='java.lang.String'] and parameter[6][@type='java.lang.String'] and parameter[7][@type='java.lang.String'] and parameter[8][@type='java.lang.Boolean'] and parameter[9][@type='java.lang.String'] and parameter[10][@type='java.lang.String'] and parameter[11][@type='java.lang.String']]"
		[Register ("getBatchCall", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/Boolean;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Lretrofit2/Call;", "GetGetBatchCall_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_Boolean_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Handler:Com.Mapbox.Services.Api.Geocoding.V5.IGeocodingServiceInvoker, Naxam-MapboxService-Java")]
		global::Square.Retrofit2.ICall GetBatchCall (string p0, string p1, string p2, string p3, string p4, string p5, string p6, global::Java.Lang.Boolean p7, string p8, string p9, string p10);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.services.api.geocoding.v5']/interface[@name='GeocodingService']/method[@name='getCall' and count(parameter)=11 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='java.lang.String'] and parameter[5][@type='java.lang.String'] and parameter[6][@type='java.lang.String'] and parameter[7][@type='java.lang.String'] and parameter[8][@type='java.lang.Boolean'] and parameter[9][@type='java.lang.String'] and parameter[10][@type='java.lang.String'] and parameter[11][@type='java.lang.String']]"
		[Register ("getCall", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/Boolean;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Lretrofit2/Call;", "GetGetCall_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_Boolean_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Handler:Com.Mapbox.Services.Api.Geocoding.V5.IGeocodingServiceInvoker, Naxam-MapboxService-Java")]
		global::Square.Retrofit2.ICall GetCall (string p0, string p1, string p2, string p3, string p4, string p5, string p6, global::Java.Lang.Boolean p7, string p8, string p9, string p10);

	}

	[global::Android.Runtime.Register ("com/mapbox/services/api/geocoding/v5/GeocodingService", DoNotGenerateAcw=true)]
	internal class IGeocodingServiceInvoker : global::Java.Lang.Object, IGeocodingService {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/mapbox/services/api/geocoding/v5/GeocodingService");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IGeocodingServiceInvoker); }
		}

		IntPtr class_ref;

		public static IGeocodingService GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IGeocodingService> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.mapbox.services.api.geocoding.v5.GeocodingService"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IGeocodingServiceInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_getBatchCall_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_Boolean_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGetBatchCall_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_Boolean_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_getBatchCall_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_Boolean_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_getBatchCall_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_Boolean_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_GetBatchCall_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_Boolean_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_);
			return cb_getBatchCall_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_Boolean_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_;
		}

		static IntPtr n_GetBatchCall_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_Boolean_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2, IntPtr native_p3, IntPtr native_p4, IntPtr native_p5, IntPtr native_p6, IntPtr native_p7, IntPtr native_p8, IntPtr native_p9, IntPtr native_p10)
		{
			global::Com.Mapbox.Services.Api.Geocoding.V5.IGeocodingService __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Services.Api.Geocoding.V5.IGeocodingService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			string p2 = JNIEnv.GetString (native_p2, JniHandleOwnership.DoNotTransfer);
			string p3 = JNIEnv.GetString (native_p3, JniHandleOwnership.DoNotTransfer);
			string p4 = JNIEnv.GetString (native_p4, JniHandleOwnership.DoNotTransfer);
			string p5 = JNIEnv.GetString (native_p5, JniHandleOwnership.DoNotTransfer);
			string p6 = JNIEnv.GetString (native_p6, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Boolean p7 = global::Java.Lang.Object.GetObject<global::Java.Lang.Boolean> (native_p7, JniHandleOwnership.DoNotTransfer);
			string p8 = JNIEnv.GetString (native_p8, JniHandleOwnership.DoNotTransfer);
			string p9 = JNIEnv.GetString (native_p9, JniHandleOwnership.DoNotTransfer);
			string p10 = JNIEnv.GetString (native_p10, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetBatchCall (p0, p1, p2, p3, p4, p5, p6, p7, p8, p9, p10));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_getBatchCall_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_Boolean_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_;
		public unsafe global::Square.Retrofit2.ICall GetBatchCall (string p0, string p1, string p2, string p3, string p4, string p5, string p6, global::Java.Lang.Boolean p7, string p8, string p9, string p10)
		{
			if (id_getBatchCall_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_Boolean_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_getBatchCall_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_Boolean_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "getBatchCall", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/Boolean;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Lretrofit2/Call;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			IntPtr native_p3 = JNIEnv.NewString (p3);
			IntPtr native_p4 = JNIEnv.NewString (p4);
			IntPtr native_p5 = JNIEnv.NewString (p5);
			IntPtr native_p6 = JNIEnv.NewString (p6);
			IntPtr native_p8 = JNIEnv.NewString (p8);
			IntPtr native_p9 = JNIEnv.NewString (p9);
			IntPtr native_p10 = JNIEnv.NewString (p10);
			JValue* __args = stackalloc JValue [11];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue (native_p1);
			__args [2] = new JValue (native_p2);
			__args [3] = new JValue (native_p3);
			__args [4] = new JValue (native_p4);
			__args [5] = new JValue (native_p5);
			__args [6] = new JValue (native_p6);
			__args [7] = new JValue (p7);
			__args [8] = new JValue (native_p8);
			__args [9] = new JValue (native_p9);
			__args [10] = new JValue (native_p10);
			global::Square.Retrofit2.ICall __ret = global::Java.Lang.Object.GetObject<global::Square.Retrofit2.ICall> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getBatchCall_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_Boolean_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			JNIEnv.DeleteLocalRef (native_p1);
			JNIEnv.DeleteLocalRef (native_p2);
			JNIEnv.DeleteLocalRef (native_p3);
			JNIEnv.DeleteLocalRef (native_p4);
			JNIEnv.DeleteLocalRef (native_p5);
			JNIEnv.DeleteLocalRef (native_p6);
			JNIEnv.DeleteLocalRef (native_p8);
			JNIEnv.DeleteLocalRef (native_p9);
			JNIEnv.DeleteLocalRef (native_p10);
			return __ret;
		}

		static Delegate cb_getCall_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_Boolean_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGetCall_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_Boolean_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_getCall_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_Boolean_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_getCall_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_Boolean_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_GetCall_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_Boolean_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_);
			return cb_getCall_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_Boolean_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_;
		}

		static IntPtr n_GetCall_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_Boolean_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2, IntPtr native_p3, IntPtr native_p4, IntPtr native_p5, IntPtr native_p6, IntPtr native_p7, IntPtr native_p8, IntPtr native_p9, IntPtr native_p10)
		{
			global::Com.Mapbox.Services.Api.Geocoding.V5.IGeocodingService __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Services.Api.Geocoding.V5.IGeocodingService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			string p2 = JNIEnv.GetString (native_p2, JniHandleOwnership.DoNotTransfer);
			string p3 = JNIEnv.GetString (native_p3, JniHandleOwnership.DoNotTransfer);
			string p4 = JNIEnv.GetString (native_p4, JniHandleOwnership.DoNotTransfer);
			string p5 = JNIEnv.GetString (native_p5, JniHandleOwnership.DoNotTransfer);
			string p6 = JNIEnv.GetString (native_p6, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Boolean p7 = global::Java.Lang.Object.GetObject<global::Java.Lang.Boolean> (native_p7, JniHandleOwnership.DoNotTransfer);
			string p8 = JNIEnv.GetString (native_p8, JniHandleOwnership.DoNotTransfer);
			string p9 = JNIEnv.GetString (native_p9, JniHandleOwnership.DoNotTransfer);
			string p10 = JNIEnv.GetString (native_p10, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetCall (p0, p1, p2, p3, p4, p5, p6, p7, p8, p9, p10));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_getCall_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_Boolean_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_;
		public unsafe global::Square.Retrofit2.ICall GetCall (string p0, string p1, string p2, string p3, string p4, string p5, string p6, global::Java.Lang.Boolean p7, string p8, string p9, string p10)
		{
			if (id_getCall_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_Boolean_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_getCall_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_Boolean_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "getCall", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/Boolean;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Lretrofit2/Call;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			IntPtr native_p3 = JNIEnv.NewString (p3);
			IntPtr native_p4 = JNIEnv.NewString (p4);
			IntPtr native_p5 = JNIEnv.NewString (p5);
			IntPtr native_p6 = JNIEnv.NewString (p6);
			IntPtr native_p8 = JNIEnv.NewString (p8);
			IntPtr native_p9 = JNIEnv.NewString (p9);
			IntPtr native_p10 = JNIEnv.NewString (p10);
			JValue* __args = stackalloc JValue [11];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue (native_p1);
			__args [2] = new JValue (native_p2);
			__args [3] = new JValue (native_p3);
			__args [4] = new JValue (native_p4);
			__args [5] = new JValue (native_p5);
			__args [6] = new JValue (native_p6);
			__args [7] = new JValue (p7);
			__args [8] = new JValue (native_p8);
			__args [9] = new JValue (native_p9);
			__args [10] = new JValue (native_p10);
			global::Square.Retrofit2.ICall __ret = global::Java.Lang.Object.GetObject<global::Square.Retrofit2.ICall> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getCall_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_Boolean_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			JNIEnv.DeleteLocalRef (native_p1);
			JNIEnv.DeleteLocalRef (native_p2);
			JNIEnv.DeleteLocalRef (native_p3);
			JNIEnv.DeleteLocalRef (native_p4);
			JNIEnv.DeleteLocalRef (native_p5);
			JNIEnv.DeleteLocalRef (native_p6);
			JNIEnv.DeleteLocalRef (native_p8);
			JNIEnv.DeleteLocalRef (native_p9);
			JNIEnv.DeleteLocalRef (native_p10);
			return __ret;
		}

	}

}
