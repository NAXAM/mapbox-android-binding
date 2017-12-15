using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Mapbox.Services.Api.Directions.V5.Models {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.mapbox.services.api.directions.v5.models']/class[@name='DirectionsWaypoint']"
	[global::Android.Runtime.Register ("com/mapbox/services/api/directions/v5/models/DirectionsWaypoint", DoNotGenerateAcw=true)]
	public partial class DirectionsWaypoint : global::Java.Lang.Object {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/mapbox/services/api/directions/v5/models/DirectionsWaypoint", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (DirectionsWaypoint); }
		}

		protected DirectionsWaypoint (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.mapbox.services.api.directions.v5.models']/class[@name='DirectionsWaypoint']/constructor[@name='DirectionsWaypoint' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe DirectionsWaypoint ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (DirectionsWaypoint)) {
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
			global::Com.Mapbox.Services.Api.Directions.V5.Models.DirectionsWaypoint __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Services.Api.Directions.V5.Models.DirectionsWaypoint> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Name);
		}
#pragma warning restore 0169

		static Delegate cb_setName_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetName_Ljava_lang_String_Handler ()
		{
			if (cb_setName_Ljava_lang_String_ == null)
				cb_setName_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetName_Ljava_lang_String_);
			return cb_setName_Ljava_lang_String_;
		}

		static void n_SetName_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Mapbox.Services.Api.Directions.V5.Models.DirectionsWaypoint __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Services.Api.Directions.V5.Models.DirectionsWaypoint> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Name = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getName;
		static IntPtr id_setName_Ljava_lang_String_;
		public virtual unsafe string Name {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.services.api.directions.v5.models']/class[@name='DirectionsWaypoint']/method[@name='getName' and count(parameter)=0]"
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
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.services.api.directions.v5.models']/class[@name='DirectionsWaypoint']/method[@name='setName' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setName", "(Ljava/lang/String;)V", "GetSetName_Ljava_lang_String_Handler")]
			set {
				if (id_setName_Ljava_lang_String_ == IntPtr.Zero)
					id_setName_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setName", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setName_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setName", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_asPosition;
#pragma warning disable 0169
		static Delegate GetAsPositionHandler ()
		{
			if (cb_asPosition == null)
				cb_asPosition = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_AsPosition);
			return cb_asPosition;
		}

		static IntPtr n_AsPosition (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mapbox.Services.Api.Directions.V5.Models.DirectionsWaypoint __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Services.Api.Directions.V5.Models.DirectionsWaypoint> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.AsPosition ());
		}
#pragma warning restore 0169

		static IntPtr id_asPosition;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.services.api.directions.v5.models']/class[@name='DirectionsWaypoint']/method[@name='asPosition' and count(parameter)=0]"
		[Register ("asPosition", "()Lcom/mapbox/services/commons/models/Position;", "GetAsPositionHandler")]
		public virtual unsafe global::Com.Mapbox.Services.Commons.Models.Position AsPosition ()
		{
			if (id_asPosition == IntPtr.Zero)
				id_asPosition = JNIEnv.GetMethodID (class_ref, "asPosition", "()Lcom/mapbox/services/commons/models/Position;");
			try {

				if (((object) this).GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Services.Commons.Models.Position> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_asPosition), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Services.Commons.Models.Position> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "asPosition", "()Lcom/mapbox/services/commons/models/Position;")), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_getLocation;
#pragma warning disable 0169
		static Delegate GetGetLocationHandler ()
		{
			if (cb_getLocation == null)
				cb_getLocation = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetLocation);
			return cb_getLocation;
		}

		static IntPtr n_GetLocation (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mapbox.Services.Api.Directions.V5.Models.DirectionsWaypoint __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Services.Api.Directions.V5.Models.DirectionsWaypoint> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetLocation ());
		}
#pragma warning restore 0169

		static IntPtr id_getLocation;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.services.api.directions.v5.models']/class[@name='DirectionsWaypoint']/method[@name='getLocation' and count(parameter)=0]"
		[Register ("getLocation", "()[D", "GetGetLocationHandler")]
		public virtual unsafe double[] GetLocation ()
		{
			if (id_getLocation == IntPtr.Zero)
				id_getLocation = JNIEnv.GetMethodID (class_ref, "getLocation", "()[D");
			try {

				if (((object) this).GetType () == ThresholdType)
					return (double[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getLocation), JniHandleOwnership.TransferLocalRef, typeof (double));
				else
					return (double[]) JNIEnv.GetArray (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getLocation", "()[D")), JniHandleOwnership.TransferLocalRef, typeof (double));
			} finally {
			}
		}

		static Delegate cb_setLocation_arrayD;
#pragma warning disable 0169
		static Delegate GetSetLocation_arrayDHandler ()
		{
			if (cb_setLocation_arrayD == null)
				cb_setLocation_arrayD = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetLocation_arrayD);
			return cb_setLocation_arrayD;
		}

		static void n_SetLocation_arrayD (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Mapbox.Services.Api.Directions.V5.Models.DirectionsWaypoint __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Services.Api.Directions.V5.Models.DirectionsWaypoint> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			double[] p0 = (double[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (double));
			__this.SetLocation (p0);
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
		}
#pragma warning restore 0169

		static IntPtr id_setLocation_arrayD;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.services.api.directions.v5.models']/class[@name='DirectionsWaypoint']/method[@name='setLocation' and count(parameter)=1 and parameter[1][@type='double[]']]"
		[Register ("setLocation", "([D)V", "GetSetLocation_arrayDHandler")]
		public virtual unsafe void SetLocation (double[] p0)
		{
			if (id_setLocation_arrayD == IntPtr.Zero)
				id_setLocation_arrayD = JNIEnv.GetMethodID (class_ref, "setLocation", "([D)V");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setLocation_arrayD, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setLocation", "([D)V"), __args);
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}
		}

	}
}
