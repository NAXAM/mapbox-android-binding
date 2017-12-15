using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Mapbox.Services.Api.Distance.V1 {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.mapbox.services.api.distance.v1']/interface[@name='DistanceService']"
	[ObsoleteAttribute (@"This class is obsoleted in this android platform")]
	[Register ("com/mapbox/services/api/distance/v1/DistanceService", "", "Com.Mapbox.Services.Api.Distance.V1.IDistanceServiceInvoker")]
	public partial interface IDistanceService : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.services.api.distance.v1']/interface[@name='DistanceService']/method[@name='getCall' and count(parameter)=5 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='java.lang.String'] and parameter[5][@type='okhttp3.RequestBody']]"
[Obsolete (@"deprecated")]
		[Register ("getCall", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Lokhttp3/RequestBody;)Lretrofit2/Call;", "GetGetCall_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Lokhttp3_RequestBody_Handler:Com.Mapbox.Services.Api.Distance.V1.IDistanceServiceInvoker, Naxam-MapboxService-Java")]
		global::Square.Retrofit2.ICall GetCall (string p0, string p1, string p2, string p3, global::Square.OkHttp3.RequestBody p4);

	}

	[global::Android.Runtime.Register ("com/mapbox/services/api/distance/v1/DistanceService", DoNotGenerateAcw=true)]
	internal class IDistanceServiceInvoker : global::Java.Lang.Object, IDistanceService {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/mapbox/services/api/distance/v1/DistanceService");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IDistanceServiceInvoker); }
		}

		IntPtr class_ref;

		public static IDistanceService GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IDistanceService> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.mapbox.services.api.distance.v1.DistanceService"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IDistanceServiceInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_getCall_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Lokhttp3_RequestBody_;
#pragma warning disable 0169
		static Delegate GetGetCall_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Lokhttp3_RequestBody_Handler ()
		{
			if (cb_getCall_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Lokhttp3_RequestBody_ == null)
				cb_getCall_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Lokhttp3_RequestBody_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_GetCall_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Lokhttp3_RequestBody_);
			return cb_getCall_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Lokhttp3_RequestBody_;
		}

		static IntPtr n_GetCall_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Lokhttp3_RequestBody_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2, IntPtr native_p3, IntPtr native_p4)
		{
			global::Com.Mapbox.Services.Api.Distance.V1.IDistanceService __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Services.Api.Distance.V1.IDistanceService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			string p2 = JNIEnv.GetString (native_p2, JniHandleOwnership.DoNotTransfer);
			string p3 = JNIEnv.GetString (native_p3, JniHandleOwnership.DoNotTransfer);
			global::Square.OkHttp3.RequestBody p4 = global::Java.Lang.Object.GetObject<global::Square.OkHttp3.RequestBody> (native_p4, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetCall (p0, p1, p2, p3, p4));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_getCall_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Lokhttp3_RequestBody_;
		public unsafe global::Square.Retrofit2.ICall GetCall (string p0, string p1, string p2, string p3, global::Square.OkHttp3.RequestBody p4)
		{
			if (id_getCall_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Lokhttp3_RequestBody_ == IntPtr.Zero)
				id_getCall_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Lokhttp3_RequestBody_ = JNIEnv.GetMethodID (class_ref, "getCall", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Lokhttp3/RequestBody;)Lretrofit2/Call;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			IntPtr native_p3 = JNIEnv.NewString (p3);
			JValue* __args = stackalloc JValue [5];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue (native_p1);
			__args [2] = new JValue (native_p2);
			__args [3] = new JValue (native_p3);
			__args [4] = new JValue (p4);
			global::Square.Retrofit2.ICall __ret = global::Java.Lang.Object.GetObject<global::Square.Retrofit2.ICall> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getCall_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Lokhttp3_RequestBody_, __args), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			JNIEnv.DeleteLocalRef (native_p1);
			JNIEnv.DeleteLocalRef (native_p2);
			JNIEnv.DeleteLocalRef (native_p3);
			return __ret;
		}

	}

}
