using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Mapbox.Services.Api.Geocoding.V5.Models {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.mapbox.services.api.geocoding.v5.models']/class[@name='GeocodingResponse']"
	[global::Android.Runtime.Register ("com/mapbox/services/api/geocoding/v5/models/GeocodingResponse", DoNotGenerateAcw=true)]
	public partial class GeocodingResponse : global::Com.Mapbox.Services.Api.Geocoding.V5.Models.CarmenFeatureCollection {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/mapbox/services/api/geocoding/v5/models/GeocodingResponse", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (GeocodingResponse); }
		}

		protected GeocodingResponse (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.mapbox.services.api.geocoding.v5.models']/class[@name='GeocodingResponse']/constructor[@name='GeocodingResponse' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe GeocodingResponse ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (GeocodingResponse)) {
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

		static IntPtr id_ctor_Ljava_util_List_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.mapbox.services.api.geocoding.v5.models']/class[@name='GeocodingResponse']/constructor[@name='GeocodingResponse' and count(parameter)=1 and parameter[1][@type='java.util.List&lt;com.mapbox.services.api.geocoding.v5.models.CarmenFeature&gt;']]"
		[Register (".ctor", "(Ljava/util/List;)V", "")]
		public unsafe GeocodingResponse (global::System.Collections.Generic.IList<global::Com.Mapbox.Services.Api.Geocoding.V5.Models.CarmenFeature> p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_p0 = global::Android.Runtime.JavaList<global::Com.Mapbox.Services.Api.Geocoding.V5.Models.CarmenFeature>.ToLocalJniHandle (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				if (((object) this).GetType () != typeof (GeocodingResponse)) {
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

	}
}
