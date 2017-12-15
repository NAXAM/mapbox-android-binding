using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Mapbox.Services.Api.Optimizedtrips.V1.Models {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.mapbox.services.api.optimizedtrips.v1.models']/class[@name='OptimizationWaypoint']"
	[global::Android.Runtime.Register ("com/mapbox/services/api/optimizedtrips/v1/models/OptimizationWaypoint", DoNotGenerateAcw=true)]
	public partial class OptimizationWaypoint : global::Com.Mapbox.Services.Api.Directions.V5.Models.DirectionsWaypoint {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/mapbox/services/api/optimizedtrips/v1/models/OptimizationWaypoint", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (OptimizationWaypoint); }
		}

		protected OptimizationWaypoint (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.mapbox.services.api.optimizedtrips.v1.models']/class[@name='OptimizationWaypoint']/constructor[@name='OptimizationWaypoint' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe OptimizationWaypoint ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (OptimizationWaypoint)) {
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

		static IntPtr id_ctor_II;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.mapbox.services.api.optimizedtrips.v1.models']/class[@name='OptimizationWaypoint']/constructor[@name='OptimizationWaypoint' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
		[Register (".ctor", "(II)V", "")]
		public unsafe OptimizationWaypoint (int p0, int p1)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				if (((object) this).GetType () != typeof (OptimizationWaypoint)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(II)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(II)V", __args);
					return;
				}

				if (id_ctor_II == IntPtr.Zero)
					id_ctor_II = JNIEnv.GetMethodID (class_ref, "<init>", "(II)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_II, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_II, __args);
			} finally {
			}
		}

		static Delegate cb_getTripsIndex;
#pragma warning disable 0169
		static Delegate GetGetTripsIndexHandler ()
		{
			if (cb_getTripsIndex == null)
				cb_getTripsIndex = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetTripsIndex);
			return cb_getTripsIndex;
		}

		static int n_GetTripsIndex (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mapbox.Services.Api.Optimizedtrips.V1.Models.OptimizationWaypoint __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Services.Api.Optimizedtrips.V1.Models.OptimizationWaypoint> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.TripsIndex;
		}
#pragma warning restore 0169

		static Delegate cb_setTripsIndex_I;
#pragma warning disable 0169
		static Delegate GetSetTripsIndex_IHandler ()
		{
			if (cb_setTripsIndex_I == null)
				cb_setTripsIndex_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetTripsIndex_I);
			return cb_setTripsIndex_I;
		}

		static void n_SetTripsIndex_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Mapbox.Services.Api.Optimizedtrips.V1.Models.OptimizationWaypoint __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Services.Api.Optimizedtrips.V1.Models.OptimizationWaypoint> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.TripsIndex = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getTripsIndex;
		static IntPtr id_setTripsIndex_I;
		public virtual unsafe int TripsIndex {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.services.api.optimizedtrips.v1.models']/class[@name='OptimizationWaypoint']/method[@name='getTripsIndex' and count(parameter)=0]"
			[Register ("getTripsIndex", "()I", "GetGetTripsIndexHandler")]
			get {
				if (id_getTripsIndex == IntPtr.Zero)
					id_getTripsIndex = JNIEnv.GetMethodID (class_ref, "getTripsIndex", "()I");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getTripsIndex);
					else
						return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getTripsIndex", "()I"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.services.api.optimizedtrips.v1.models']/class[@name='OptimizationWaypoint']/method[@name='setTripsIndex' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setTripsIndex", "(I)V", "GetSetTripsIndex_IHandler")]
			set {
				if (id_setTripsIndex_I == IntPtr.Zero)
					id_setTripsIndex_I = JNIEnv.GetMethodID (class_ref, "setTripsIndex", "(I)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setTripsIndex_I, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setTripsIndex", "(I)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getWaypointIndex;
#pragma warning disable 0169
		static Delegate GetGetWaypointIndexHandler ()
		{
			if (cb_getWaypointIndex == null)
				cb_getWaypointIndex = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetWaypointIndex);
			return cb_getWaypointIndex;
		}

		static int n_GetWaypointIndex (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mapbox.Services.Api.Optimizedtrips.V1.Models.OptimizationWaypoint __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Services.Api.Optimizedtrips.V1.Models.OptimizationWaypoint> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.WaypointIndex;
		}
#pragma warning restore 0169

		static Delegate cb_setWaypointIndex_I;
#pragma warning disable 0169
		static Delegate GetSetWaypointIndex_IHandler ()
		{
			if (cb_setWaypointIndex_I == null)
				cb_setWaypointIndex_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetWaypointIndex_I);
			return cb_setWaypointIndex_I;
		}

		static void n_SetWaypointIndex_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Mapbox.Services.Api.Optimizedtrips.V1.Models.OptimizationWaypoint __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Services.Api.Optimizedtrips.V1.Models.OptimizationWaypoint> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.WaypointIndex = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getWaypointIndex;
		static IntPtr id_setWaypointIndex_I;
		public virtual unsafe int WaypointIndex {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.services.api.optimizedtrips.v1.models']/class[@name='OptimizationWaypoint']/method[@name='getWaypointIndex' and count(parameter)=0]"
			[Register ("getWaypointIndex", "()I", "GetGetWaypointIndexHandler")]
			get {
				if (id_getWaypointIndex == IntPtr.Zero)
					id_getWaypointIndex = JNIEnv.GetMethodID (class_ref, "getWaypointIndex", "()I");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getWaypointIndex);
					else
						return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getWaypointIndex", "()I"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.services.api.optimizedtrips.v1.models']/class[@name='OptimizationWaypoint']/method[@name='setWaypointIndex' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setWaypointIndex", "(I)V", "GetSetWaypointIndex_IHandler")]
			set {
				if (id_setWaypointIndex_I == IntPtr.Zero)
					id_setWaypointIndex_I = JNIEnv.GetMethodID (class_ref, "setWaypointIndex", "(I)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setWaypointIndex_I, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setWaypointIndex", "(I)V"), __args);
				} finally {
				}
			}
		}

	}
}
