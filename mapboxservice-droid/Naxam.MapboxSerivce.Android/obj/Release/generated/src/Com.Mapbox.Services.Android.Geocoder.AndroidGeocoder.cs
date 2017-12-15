using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Mapbox.Services.Android.Geocoder {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.mapbox.services.android.geocoder']/class[@name='AndroidGeocoder']"
	[global::Android.Runtime.Register ("com/mapbox/services/android/geocoder/AndroidGeocoder", DoNotGenerateAcw=true)]
	public partial class AndroidGeocoder : global::Java.Lang.Object {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/mapbox/services/android/geocoder/AndroidGeocoder", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (AndroidGeocoder); }
		}

		protected AndroidGeocoder (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Landroid_content_Context_Ljava_util_Locale_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.mapbox.services.android.geocoder']/class[@name='AndroidGeocoder']/constructor[@name='AndroidGeocoder' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.util.Locale']]"
		[Register (".ctor", "(Landroid/content/Context;Ljava/util/Locale;)V", "")]
		public unsafe AndroidGeocoder (global::Android.Content.Context p0, global::Java.Util.Locale p1)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				if (((object) this).GetType () != typeof (AndroidGeocoder)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Landroid/content/Context;Ljava/util/Locale;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Landroid/content/Context;Ljava/util/Locale;)V", __args);
					return;
				}

				if (id_ctor_Landroid_content_Context_Ljava_util_Locale_ == IntPtr.Zero)
					id_ctor_Landroid_content_Context_Ljava_util_Locale_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/content/Context;Ljava/util/Locale;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_content_Context_Ljava_util_Locale_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Landroid_content_Context_Ljava_util_Locale_, __args);
			} finally {
			}
		}

		static IntPtr id_ctor_Landroid_content_Context_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.mapbox.services.android.geocoder']/class[@name='AndroidGeocoder']/constructor[@name='AndroidGeocoder' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register (".ctor", "(Landroid/content/Context;)V", "")]
		public unsafe AndroidGeocoder (global::Android.Content.Context p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (((object) this).GetType () != typeof (AndroidGeocoder)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Landroid/content/Context;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Landroid/content/Context;)V", __args);
					return;
				}

				if (id_ctor_Landroid_content_Context_ == IntPtr.Zero)
					id_ctor_Landroid_content_Context_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/content/Context;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_content_Context_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Landroid_content_Context_, __args);
			} finally {
			}
		}

		static IntPtr id_isPresent;
		public static unsafe bool IsPresent {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.services.android.geocoder']/class[@name='AndroidGeocoder']/method[@name='isPresent' and count(parameter)=0]"
			[Register ("isPresent", "()Z", "GetIsPresentHandler")]
			get {
				if (id_isPresent == IntPtr.Zero)
					id_isPresent = JNIEnv.GetStaticMethodID (class_ref, "isPresent", "()Z");
				try {
					return JNIEnv.CallStaticBooleanMethod  (class_ref, id_isPresent);
				} finally {
				}
			}
		}

		static Delegate cb_getFromLocation_DDI;
#pragma warning disable 0169
		static Delegate GetGetFromLocation_DDIHandler ()
		{
			if (cb_getFromLocation_DDI == null)
				cb_getFromLocation_DDI = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, double, double, int, IntPtr>) n_GetFromLocation_DDI);
			return cb_getFromLocation_DDI;
		}

		static IntPtr n_GetFromLocation_DDI (IntPtr jnienv, IntPtr native__this, double p0, double p1, int p2)
		{
			global::Com.Mapbox.Services.Android.Geocoder.AndroidGeocoder __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Services.Android.Geocoder.AndroidGeocoder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList<global::Android.Locations.Address>.ToLocalJniHandle (__this.GetFromLocation (p0, p1, p2));
		}
#pragma warning restore 0169

		static IntPtr id_getFromLocation_DDI;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.services.android.geocoder']/class[@name='AndroidGeocoder']/method[@name='getFromLocation' and count(parameter)=3 and parameter[1][@type='double'] and parameter[2][@type='double'] and parameter[3][@type='int']]"
		[Register ("getFromLocation", "(DDI)Ljava/util/List;", "GetGetFromLocation_DDIHandler")]
		public virtual unsafe global::System.Collections.Generic.IList<global::Android.Locations.Address> GetFromLocation (double p0, double p1, int p2)
		{
			if (id_getFromLocation_DDI == IntPtr.Zero)
				id_getFromLocation_DDI = JNIEnv.GetMethodID (class_ref, "getFromLocation", "(DDI)Ljava/util/List;");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);

				if (((object) this).GetType () == ThresholdType)
					return global::Android.Runtime.JavaList<global::Android.Locations.Address>.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getFromLocation_DDI, __args), JniHandleOwnership.TransferLocalRef);
				else
					return global::Android.Runtime.JavaList<global::Android.Locations.Address>.FromJniHandle (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getFromLocation", "(DDI)Ljava/util/List;"), __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_getFromLocationName_Ljava_lang_String_I;
#pragma warning disable 0169
		static Delegate GetGetFromLocationName_Ljava_lang_String_IHandler ()
		{
			if (cb_getFromLocationName_Ljava_lang_String_I == null)
				cb_getFromLocationName_Ljava_lang_String_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, int, IntPtr>) n_GetFromLocationName_Ljava_lang_String_I);
			return cb_getFromLocationName_Ljava_lang_String_I;
		}

		static IntPtr n_GetFromLocationName_Ljava_lang_String_I (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1)
		{
			global::Com.Mapbox.Services.Android.Geocoder.AndroidGeocoder __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Services.Android.Geocoder.AndroidGeocoder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = global::Android.Runtime.JavaList<global::Android.Locations.Address>.ToLocalJniHandle (__this.GetFromLocationName (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getFromLocationName_Ljava_lang_String_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.services.android.geocoder']/class[@name='AndroidGeocoder']/method[@name='getFromLocationName' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='int']]"
		[Register ("getFromLocationName", "(Ljava/lang/String;I)Ljava/util/List;", "GetGetFromLocationName_Ljava_lang_String_IHandler")]
		public virtual unsafe global::System.Collections.Generic.IList<global::Android.Locations.Address> GetFromLocationName (string p0, int p1)
		{
			if (id_getFromLocationName_Ljava_lang_String_I == IntPtr.Zero)
				id_getFromLocationName_Ljava_lang_String_I = JNIEnv.GetMethodID (class_ref, "getFromLocationName", "(Ljava/lang/String;I)Ljava/util/List;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);

				global::System.Collections.Generic.IList<global::Android.Locations.Address> __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Android.Runtime.JavaList<global::Android.Locations.Address>.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getFromLocationName_Ljava_lang_String_I, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Android.Runtime.JavaList<global::Android.Locations.Address>.FromJniHandle (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getFromLocationName", "(Ljava/lang/String;I)Ljava/util/List;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_getFromLocationName_Ljava_lang_String_IDDDD;
#pragma warning disable 0169
		static Delegate GetGetFromLocationName_Ljava_lang_String_IDDDDHandler ()
		{
			if (cb_getFromLocationName_Ljava_lang_String_IDDDD == null)
				cb_getFromLocationName_Ljava_lang_String_IDDDD = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, int, double, double, double, double, IntPtr>) n_GetFromLocationName_Ljava_lang_String_IDDDD);
			return cb_getFromLocationName_Ljava_lang_String_IDDDD;
		}

		static IntPtr n_GetFromLocationName_Ljava_lang_String_IDDDD (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1, double p2, double p3, double p4, double p5)
		{
			global::Com.Mapbox.Services.Android.Geocoder.AndroidGeocoder __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Services.Android.Geocoder.AndroidGeocoder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = global::Android.Runtime.JavaList<global::Android.Locations.Address>.ToLocalJniHandle (__this.GetFromLocationName (p0, p1, p2, p3, p4, p5));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getFromLocationName_Ljava_lang_String_IDDDD;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.services.android.geocoder']/class[@name='AndroidGeocoder']/method[@name='getFromLocationName' and count(parameter)=6 and parameter[1][@type='java.lang.String'] and parameter[2][@type='int'] and parameter[3][@type='double'] and parameter[4][@type='double'] and parameter[5][@type='double'] and parameter[6][@type='double']]"
		[Register ("getFromLocationName", "(Ljava/lang/String;IDDDD)Ljava/util/List;", "GetGetFromLocationName_Ljava_lang_String_IDDDDHandler")]
		public virtual unsafe global::System.Collections.Generic.IList<global::Android.Locations.Address> GetFromLocationName (string p0, int p1, double p2, double p3, double p4, double p5)
		{
			if (id_getFromLocationName_Ljava_lang_String_IDDDD == IntPtr.Zero)
				id_getFromLocationName_Ljava_lang_String_IDDDD = JNIEnv.GetMethodID (class_ref, "getFromLocationName", "(Ljava/lang/String;IDDDD)Ljava/util/List;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [6];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				__args [4] = new JValue (p4);
				__args [5] = new JValue (p5);

				global::System.Collections.Generic.IList<global::Android.Locations.Address> __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Android.Runtime.JavaList<global::Android.Locations.Address>.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getFromLocationName_Ljava_lang_String_IDDDD, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Android.Runtime.JavaList<global::Android.Locations.Address>.FromJniHandle (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getFromLocationName", "(Ljava/lang/String;IDDDD)Ljava/util/List;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_setAccessToken_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetAccessToken_Ljava_lang_String_Handler ()
		{
			if (cb_setAccessToken_Ljava_lang_String_ == null)
				cb_setAccessToken_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetAccessToken_Ljava_lang_String_);
			return cb_setAccessToken_Ljava_lang_String_;
		}

		static void n_SetAccessToken_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Mapbox.Services.Android.Geocoder.AndroidGeocoder __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Services.Android.Geocoder.AndroidGeocoder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetAccessToken (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setAccessToken_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.services.android.geocoder']/class[@name='AndroidGeocoder']/method[@name='setAccessToken' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setAccessToken", "(Ljava/lang/String;)V", "GetSetAccessToken_Ljava_lang_String_Handler")]
		public virtual unsafe void SetAccessToken (string p0)
		{
			if (id_setAccessToken_Ljava_lang_String_ == IntPtr.Zero)
				id_setAccessToken_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setAccessToken", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setAccessToken_Ljava_lang_String_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setAccessToken", "(Ljava/lang/String;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

	}
}
