using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Mapbox.Services.Api.Utils.Turf {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.mapbox.services.api.utils.turf']/class[@name='TurfHelpers']"
	[global::Android.Runtime.Register ("com/mapbox/services/api/utils/turf/TurfHelpers", DoNotGenerateAcw=true)]
	public partial class TurfHelpers : global::Java.Lang.Object {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/mapbox/services/api/utils/turf/TurfHelpers", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (TurfHelpers); }
		}

		protected TurfHelpers (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.mapbox.services.api.utils.turf']/class[@name='TurfHelpers']/constructor[@name='TurfHelpers' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe TurfHelpers ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (TurfHelpers)) {
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

		static IntPtr id_convertDistance_DLjava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.services.api.utils.turf']/class[@name='TurfHelpers']/method[@name='convertDistance' and count(parameter)=2 and parameter[1][@type='double'] and parameter[2][@type='java.lang.String']]"
		[Register ("convertDistance", "(DLjava/lang/String;)D", "")]
		public static unsafe double ConvertDistance (double p0, string p1)
		{
			if (id_convertDistance_DLjava_lang_String_ == IntPtr.Zero)
				id_convertDistance_DLjava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "convertDistance", "(DLjava/lang/String;)D");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				double __ret = JNIEnv.CallStaticDoubleMethod  (class_ref, id_convertDistance_DLjava_lang_String_, __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static IntPtr id_convertDistance_DLjava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.services.api.utils.turf']/class[@name='TurfHelpers']/method[@name='convertDistance' and count(parameter)=3 and parameter[1][@type='double'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String']]"
		[Register ("convertDistance", "(DLjava/lang/String;Ljava/lang/String;)D", "")]
		public static unsafe double ConvertDistance (double p0, string p1, string p2)
		{
			if (id_convertDistance_DLjava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_convertDistance_DLjava_lang_String_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "convertDistance", "(DLjava/lang/String;Ljava/lang/String;)D");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (native_p2);
				double __ret = JNIEnv.CallStaticDoubleMethod  (class_ref, id_convertDistance_DLjava_lang_String_Ljava_lang_String_, __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
				JNIEnv.DeleteLocalRef (native_p2);
			}
		}

		static IntPtr id_distanceToRadians_D;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.services.api.utils.turf']/class[@name='TurfHelpers']/method[@name='distanceToRadians' and count(parameter)=1 and parameter[1][@type='double']]"
		[Register ("distanceToRadians", "(D)D", "")]
		public static unsafe double DistanceToRadians (double p0)
		{
			if (id_distanceToRadians_D == IntPtr.Zero)
				id_distanceToRadians_D = JNIEnv.GetStaticMethodID (class_ref, "distanceToRadians", "(D)D");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				return JNIEnv.CallStaticDoubleMethod  (class_ref, id_distanceToRadians_D, __args);
			} finally {
			}
		}

		static IntPtr id_distanceToRadians_DLjava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.services.api.utils.turf']/class[@name='TurfHelpers']/method[@name='distanceToRadians' and count(parameter)=2 and parameter[1][@type='double'] and parameter[2][@type='java.lang.String']]"
		[Register ("distanceToRadians", "(DLjava/lang/String;)D", "")]
		public static unsafe double DistanceToRadians (double p0, string p1)
		{
			if (id_distanceToRadians_DLjava_lang_String_ == IntPtr.Zero)
				id_distanceToRadians_DLjava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "distanceToRadians", "(DLjava/lang/String;)D");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				double __ret = JNIEnv.CallStaticDoubleMethod  (class_ref, id_distanceToRadians_DLjava_lang_String_, __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static IntPtr id_radiansToDistance_D;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.services.api.utils.turf']/class[@name='TurfHelpers']/method[@name='radiansToDistance' and count(parameter)=1 and parameter[1][@type='double']]"
		[Register ("radiansToDistance", "(D)D", "")]
		public static unsafe double RadiansToDistance (double p0)
		{
			if (id_radiansToDistance_D == IntPtr.Zero)
				id_radiansToDistance_D = JNIEnv.GetStaticMethodID (class_ref, "radiansToDistance", "(D)D");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				return JNIEnv.CallStaticDoubleMethod  (class_ref, id_radiansToDistance_D, __args);
			} finally {
			}
		}

		static IntPtr id_radiansToDistance_DLjava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.services.api.utils.turf']/class[@name='TurfHelpers']/method[@name='radiansToDistance' and count(parameter)=2 and parameter[1][@type='double'] and parameter[2][@type='java.lang.String']]"
		[Register ("radiansToDistance", "(DLjava/lang/String;)D", "")]
		public static unsafe double RadiansToDistance (double p0, string p1)
		{
			if (id_radiansToDistance_DLjava_lang_String_ == IntPtr.Zero)
				id_radiansToDistance_DLjava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "radiansToDistance", "(DLjava/lang/String;)D");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				double __ret = JNIEnv.CallStaticDoubleMethod  (class_ref, id_radiansToDistance_DLjava_lang_String_, __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

	}
}
