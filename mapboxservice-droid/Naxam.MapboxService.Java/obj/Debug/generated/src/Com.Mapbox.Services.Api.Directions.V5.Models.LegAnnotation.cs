using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Mapbox.Services.Api.Directions.V5.Models {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.mapbox.services.api.directions.v5.models']/class[@name='LegAnnotation']"
	[global::Android.Runtime.Register ("com/mapbox/services/api/directions/v5/models/LegAnnotation", DoNotGenerateAcw=true)]
	public partial class LegAnnotation : global::Java.Lang.Object {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/mapbox/services/api/directions/v5/models/LegAnnotation", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (LegAnnotation); }
		}

		protected LegAnnotation (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.mapbox.services.api.directions.v5.models']/class[@name='LegAnnotation']/constructor[@name='LegAnnotation' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe LegAnnotation ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (LegAnnotation)) {
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

		static Delegate cb_getCongestion;
#pragma warning disable 0169
		static Delegate GetGetCongestionHandler ()
		{
			if (cb_getCongestion == null)
				cb_getCongestion = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetCongestion);
			return cb_getCongestion;
		}

		static IntPtr n_GetCongestion (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mapbox.Services.Api.Directions.V5.Models.LegAnnotation __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Services.Api.Directions.V5.Models.LegAnnotation> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetCongestion ());
		}
#pragma warning restore 0169

		static IntPtr id_getCongestion;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.services.api.directions.v5.models']/class[@name='LegAnnotation']/method[@name='getCongestion' and count(parameter)=0]"
		[Register ("getCongestion", "()[Ljava/lang/String;", "GetGetCongestionHandler")]
		public virtual unsafe string[] GetCongestion ()
		{
			if (id_getCongestion == IntPtr.Zero)
				id_getCongestion = JNIEnv.GetMethodID (class_ref, "getCongestion", "()[Ljava/lang/String;");
			try {

				if (((object) this).GetType () == ThresholdType)
					return (string[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getCongestion), JniHandleOwnership.TransferLocalRef, typeof (string));
				else
					return (string[]) JNIEnv.GetArray (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getCongestion", "()[Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef, typeof (string));
			} finally {
			}
		}

		static Delegate cb_getDistance;
#pragma warning disable 0169
		static Delegate GetGetDistanceHandler ()
		{
			if (cb_getDistance == null)
				cb_getDistance = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetDistance);
			return cb_getDistance;
		}

		static IntPtr n_GetDistance (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mapbox.Services.Api.Directions.V5.Models.LegAnnotation __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Services.Api.Directions.V5.Models.LegAnnotation> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetDistance ());
		}
#pragma warning restore 0169

		static IntPtr id_getDistance;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.services.api.directions.v5.models']/class[@name='LegAnnotation']/method[@name='getDistance' and count(parameter)=0]"
		[Register ("getDistance", "()[D", "GetGetDistanceHandler")]
		public virtual unsafe double[] GetDistance ()
		{
			if (id_getDistance == IntPtr.Zero)
				id_getDistance = JNIEnv.GetMethodID (class_ref, "getDistance", "()[D");
			try {

				if (((object) this).GetType () == ThresholdType)
					return (double[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getDistance), JniHandleOwnership.TransferLocalRef, typeof (double));
				else
					return (double[]) JNIEnv.GetArray (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getDistance", "()[D")), JniHandleOwnership.TransferLocalRef, typeof (double));
			} finally {
			}
		}

		static Delegate cb_getDuration;
#pragma warning disable 0169
		static Delegate GetGetDurationHandler ()
		{
			if (cb_getDuration == null)
				cb_getDuration = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetDuration);
			return cb_getDuration;
		}

		static IntPtr n_GetDuration (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mapbox.Services.Api.Directions.V5.Models.LegAnnotation __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Services.Api.Directions.V5.Models.LegAnnotation> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetDuration ());
		}
#pragma warning restore 0169

		static IntPtr id_getDuration;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.services.api.directions.v5.models']/class[@name='LegAnnotation']/method[@name='getDuration' and count(parameter)=0]"
		[Register ("getDuration", "()[D", "GetGetDurationHandler")]
		public virtual unsafe double[] GetDuration ()
		{
			if (id_getDuration == IntPtr.Zero)
				id_getDuration = JNIEnv.GetMethodID (class_ref, "getDuration", "()[D");
			try {

				if (((object) this).GetType () == ThresholdType)
					return (double[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getDuration), JniHandleOwnership.TransferLocalRef, typeof (double));
				else
					return (double[]) JNIEnv.GetArray (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getDuration", "()[D")), JniHandleOwnership.TransferLocalRef, typeof (double));
			} finally {
			}
		}

		static Delegate cb_getSpeed;
#pragma warning disable 0169
		static Delegate GetGetSpeedHandler ()
		{
			if (cb_getSpeed == null)
				cb_getSpeed = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetSpeed);
			return cb_getSpeed;
		}

		static IntPtr n_GetSpeed (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mapbox.Services.Api.Directions.V5.Models.LegAnnotation __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Services.Api.Directions.V5.Models.LegAnnotation> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetSpeed ());
		}
#pragma warning restore 0169

		static IntPtr id_getSpeed;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.services.api.directions.v5.models']/class[@name='LegAnnotation']/method[@name='getSpeed' and count(parameter)=0]"
		[Register ("getSpeed", "()[D", "GetGetSpeedHandler")]
		public virtual unsafe double[] GetSpeed ()
		{
			if (id_getSpeed == IntPtr.Zero)
				id_getSpeed = JNIEnv.GetMethodID (class_ref, "getSpeed", "()[D");
			try {

				if (((object) this).GetType () == ThresholdType)
					return (double[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getSpeed), JniHandleOwnership.TransferLocalRef, typeof (double));
				else
					return (double[]) JNIEnv.GetArray (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getSpeed", "()[D")), JniHandleOwnership.TransferLocalRef, typeof (double));
			} finally {
			}
		}

		static Delegate cb_setCongestion_arrayLjava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetCongestion_arrayLjava_lang_String_Handler ()
		{
			if (cb_setCongestion_arrayLjava_lang_String_ == null)
				cb_setCongestion_arrayLjava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetCongestion_arrayLjava_lang_String_);
			return cb_setCongestion_arrayLjava_lang_String_;
		}

		static void n_SetCongestion_arrayLjava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Mapbox.Services.Api.Directions.V5.Models.LegAnnotation __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Services.Api.Directions.V5.Models.LegAnnotation> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string[] p0 = (string[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (string));
			__this.SetCongestion (p0);
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
		}
#pragma warning restore 0169

		static IntPtr id_setCongestion_arrayLjava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.services.api.directions.v5.models']/class[@name='LegAnnotation']/method[@name='setCongestion' and count(parameter)=1 and parameter[1][@type='java.lang.String[]']]"
		[Register ("setCongestion", "([Ljava/lang/String;)V", "GetSetCongestion_arrayLjava_lang_String_Handler")]
		public virtual unsafe void SetCongestion (string[] p0)
		{
			if (id_setCongestion_arrayLjava_lang_String_ == IntPtr.Zero)
				id_setCongestion_arrayLjava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setCongestion", "([Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setCongestion_arrayLjava_lang_String_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setCongestion", "([Ljava/lang/String;)V"), __args);
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}
		}

		static Delegate cb_setDistance_arrayD;
#pragma warning disable 0169
		static Delegate GetSetDistance_arrayDHandler ()
		{
			if (cb_setDistance_arrayD == null)
				cb_setDistance_arrayD = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetDistance_arrayD);
			return cb_setDistance_arrayD;
		}

		static void n_SetDistance_arrayD (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Mapbox.Services.Api.Directions.V5.Models.LegAnnotation __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Services.Api.Directions.V5.Models.LegAnnotation> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			double[] p0 = (double[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (double));
			__this.SetDistance (p0);
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
		}
#pragma warning restore 0169

		static IntPtr id_setDistance_arrayD;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.services.api.directions.v5.models']/class[@name='LegAnnotation']/method[@name='setDistance' and count(parameter)=1 and parameter[1][@type='double[]']]"
		[Register ("setDistance", "([D)V", "GetSetDistance_arrayDHandler")]
		public virtual unsafe void SetDistance (double[] p0)
		{
			if (id_setDistance_arrayD == IntPtr.Zero)
				id_setDistance_arrayD = JNIEnv.GetMethodID (class_ref, "setDistance", "([D)V");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setDistance_arrayD, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setDistance", "([D)V"), __args);
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}
		}

		static Delegate cb_setDuration_arrayD;
#pragma warning disable 0169
		static Delegate GetSetDuration_arrayDHandler ()
		{
			if (cb_setDuration_arrayD == null)
				cb_setDuration_arrayD = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetDuration_arrayD);
			return cb_setDuration_arrayD;
		}

		static void n_SetDuration_arrayD (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Mapbox.Services.Api.Directions.V5.Models.LegAnnotation __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Services.Api.Directions.V5.Models.LegAnnotation> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			double[] p0 = (double[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (double));
			__this.SetDuration (p0);
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
		}
#pragma warning restore 0169

		static IntPtr id_setDuration_arrayD;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.services.api.directions.v5.models']/class[@name='LegAnnotation']/method[@name='setDuration' and count(parameter)=1 and parameter[1][@type='double[]']]"
		[Register ("setDuration", "([D)V", "GetSetDuration_arrayDHandler")]
		public virtual unsafe void SetDuration (double[] p0)
		{
			if (id_setDuration_arrayD == IntPtr.Zero)
				id_setDuration_arrayD = JNIEnv.GetMethodID (class_ref, "setDuration", "([D)V");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setDuration_arrayD, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setDuration", "([D)V"), __args);
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}
		}

		static Delegate cb_setSpeed_arrayD;
#pragma warning disable 0169
		static Delegate GetSetSpeed_arrayDHandler ()
		{
			if (cb_setSpeed_arrayD == null)
				cb_setSpeed_arrayD = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetSpeed_arrayD);
			return cb_setSpeed_arrayD;
		}

		static void n_SetSpeed_arrayD (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Mapbox.Services.Api.Directions.V5.Models.LegAnnotation __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Services.Api.Directions.V5.Models.LegAnnotation> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			double[] p0 = (double[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (double));
			__this.SetSpeed (p0);
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
		}
#pragma warning restore 0169

		static IntPtr id_setSpeed_arrayD;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.services.api.directions.v5.models']/class[@name='LegAnnotation']/method[@name='setSpeed' and count(parameter)=1 and parameter[1][@type='double[]']]"
		[Register ("setSpeed", "([D)V", "GetSetSpeed_arrayDHandler")]
		public virtual unsafe void SetSpeed (double[] p0)
		{
			if (id_setSpeed_arrayD == IntPtr.Zero)
				id_setSpeed_arrayD = JNIEnv.GetMethodID (class_ref, "setSpeed", "([D)V");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setSpeed_arrayD, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setSpeed", "([D)V"), __args);
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}
		}

	}
}
