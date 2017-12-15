using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Mapbox.Services.Api.Mapmatching.V5.Models {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.mapbox.services.api.mapmatching.v5.models']/class[@name='MapMatchingMatching']"
	[global::Android.Runtime.Register ("com/mapbox/services/api/mapmatching/v5/models/MapMatchingMatching", DoNotGenerateAcw=true)]
	public partial class MapMatchingMatching : global::Com.Mapbox.Services.Api.Directions.V5.Models.DirectionsRoute {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/mapbox/services/api/mapmatching/v5/models/MapMatchingMatching", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (MapMatchingMatching); }
		}

		protected MapMatchingMatching (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.mapbox.services.api.mapmatching.v5.models']/class[@name='MapMatchingMatching']/constructor[@name='MapMatchingMatching' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe MapMatchingMatching ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (MapMatchingMatching)) {
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

		static Delegate cb_getConfidence;
#pragma warning disable 0169
		static Delegate GetGetConfidenceHandler ()
		{
			if (cb_getConfidence == null)
				cb_getConfidence = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, double>) n_GetConfidence);
			return cb_getConfidence;
		}

		static double n_GetConfidence (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mapbox.Services.Api.Mapmatching.V5.Models.MapMatchingMatching __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Services.Api.Mapmatching.V5.Models.MapMatchingMatching> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Confidence;
		}
#pragma warning restore 0169

		static Delegate cb_setConfidence_D;
#pragma warning disable 0169
		static Delegate GetSetConfidence_DHandler ()
		{
			if (cb_setConfidence_D == null)
				cb_setConfidence_D = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, double>) n_SetConfidence_D);
			return cb_setConfidence_D;
		}

		static void n_SetConfidence_D (IntPtr jnienv, IntPtr native__this, double p0)
		{
			global::Com.Mapbox.Services.Api.Mapmatching.V5.Models.MapMatchingMatching __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Services.Api.Mapmatching.V5.Models.MapMatchingMatching> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Confidence = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getConfidence;
		static IntPtr id_setConfidence_D;
		public virtual unsafe double Confidence {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.services.api.mapmatching.v5.models']/class[@name='MapMatchingMatching']/method[@name='getConfidence' and count(parameter)=0]"
			[Register ("getConfidence", "()D", "GetGetConfidenceHandler")]
			get {
				if (id_getConfidence == IntPtr.Zero)
					id_getConfidence = JNIEnv.GetMethodID (class_ref, "getConfidence", "()D");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallDoubleMethod (((global::Java.Lang.Object) this).Handle, id_getConfidence);
					else
						return JNIEnv.CallNonvirtualDoubleMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getConfidence", "()D"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.services.api.mapmatching.v5.models']/class[@name='MapMatchingMatching']/method[@name='setConfidence' and count(parameter)=1 and parameter[1][@type='double']]"
			[Register ("setConfidence", "(D)V", "GetSetConfidence_DHandler")]
			set {
				if (id_setConfidence_D == IntPtr.Zero)
					id_setConfidence_D = JNIEnv.GetMethodID (class_ref, "setConfidence", "(D)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setConfidence_D, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setConfidence", "(D)V"), __args);
				} finally {
				}
			}
		}

	}
}
