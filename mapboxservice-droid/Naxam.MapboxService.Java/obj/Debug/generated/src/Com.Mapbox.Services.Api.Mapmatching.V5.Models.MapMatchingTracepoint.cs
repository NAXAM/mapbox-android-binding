using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Mapbox.Services.Api.Mapmatching.V5.Models {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.mapbox.services.api.mapmatching.v5.models']/class[@name='MapMatchingTracepoint']"
	[global::Android.Runtime.Register ("com/mapbox/services/api/mapmatching/v5/models/MapMatchingTracepoint", DoNotGenerateAcw=true)]
	public partial class MapMatchingTracepoint : global::Com.Mapbox.Services.Api.Directions.V5.Models.DirectionsWaypoint {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/mapbox/services/api/mapmatching/v5/models/MapMatchingTracepoint", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (MapMatchingTracepoint); }
		}

		protected MapMatchingTracepoint (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.mapbox.services.api.mapmatching.v5.models']/class[@name='MapMatchingTracepoint']/constructor[@name='MapMatchingTracepoint' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe MapMatchingTracepoint ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (MapMatchingTracepoint)) {
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

		static IntPtr id_ctor_III;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.mapbox.services.api.mapmatching.v5.models']/class[@name='MapMatchingTracepoint']/constructor[@name='MapMatchingTracepoint' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
		[Register (".ctor", "(III)V", "")]
		public unsafe MapMatchingTracepoint (int p0, int p1, int p2)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				if (((object) this).GetType () != typeof (MapMatchingTracepoint)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(III)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(III)V", __args);
					return;
				}

				if (id_ctor_III == IntPtr.Zero)
					id_ctor_III = JNIEnv.GetMethodID (class_ref, "<init>", "(III)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_III, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_III, __args);
			} finally {
			}
		}

		static Delegate cb_getAlternativesCount;
#pragma warning disable 0169
		static Delegate GetGetAlternativesCountHandler ()
		{
			if (cb_getAlternativesCount == null)
				cb_getAlternativesCount = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetAlternativesCount);
			return cb_getAlternativesCount;
		}

		static int n_GetAlternativesCount (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mapbox.Services.Api.Mapmatching.V5.Models.MapMatchingTracepoint __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Services.Api.Mapmatching.V5.Models.MapMatchingTracepoint> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.AlternativesCount;
		}
#pragma warning restore 0169

		static Delegate cb_setAlternativesCount_I;
#pragma warning disable 0169
		static Delegate GetSetAlternativesCount_IHandler ()
		{
			if (cb_setAlternativesCount_I == null)
				cb_setAlternativesCount_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetAlternativesCount_I);
			return cb_setAlternativesCount_I;
		}

		static void n_SetAlternativesCount_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Mapbox.Services.Api.Mapmatching.V5.Models.MapMatchingTracepoint __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Services.Api.Mapmatching.V5.Models.MapMatchingTracepoint> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.AlternativesCount = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getAlternativesCount;
		static IntPtr id_setAlternativesCount_I;
		public virtual unsafe int AlternativesCount {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.services.api.mapmatching.v5.models']/class[@name='MapMatchingTracepoint']/method[@name='getAlternativesCount' and count(parameter)=0]"
			[Register ("getAlternativesCount", "()I", "GetGetAlternativesCountHandler")]
			get {
				if (id_getAlternativesCount == IntPtr.Zero)
					id_getAlternativesCount = JNIEnv.GetMethodID (class_ref, "getAlternativesCount", "()I");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getAlternativesCount);
					else
						return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getAlternativesCount", "()I"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.services.api.mapmatching.v5.models']/class[@name='MapMatchingTracepoint']/method[@name='setAlternativesCount' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setAlternativesCount", "(I)V", "GetSetAlternativesCount_IHandler")]
			set {
				if (id_setAlternativesCount_I == IntPtr.Zero)
					id_setAlternativesCount_I = JNIEnv.GetMethodID (class_ref, "setAlternativesCount", "(I)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setAlternativesCount_I, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setAlternativesCount", "(I)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getMatchingsIndex;
#pragma warning disable 0169
		static Delegate GetGetMatchingsIndexHandler ()
		{
			if (cb_getMatchingsIndex == null)
				cb_getMatchingsIndex = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetMatchingsIndex);
			return cb_getMatchingsIndex;
		}

		static int n_GetMatchingsIndex (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mapbox.Services.Api.Mapmatching.V5.Models.MapMatchingTracepoint __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Services.Api.Mapmatching.V5.Models.MapMatchingTracepoint> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.MatchingsIndex;
		}
#pragma warning restore 0169

		static Delegate cb_setMatchingsIndex_I;
#pragma warning disable 0169
		static Delegate GetSetMatchingsIndex_IHandler ()
		{
			if (cb_setMatchingsIndex_I == null)
				cb_setMatchingsIndex_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetMatchingsIndex_I);
			return cb_setMatchingsIndex_I;
		}

		static void n_SetMatchingsIndex_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Mapbox.Services.Api.Mapmatching.V5.Models.MapMatchingTracepoint __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Services.Api.Mapmatching.V5.Models.MapMatchingTracepoint> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.MatchingsIndex = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getMatchingsIndex;
		static IntPtr id_setMatchingsIndex_I;
		public virtual unsafe int MatchingsIndex {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.services.api.mapmatching.v5.models']/class[@name='MapMatchingTracepoint']/method[@name='getMatchingsIndex' and count(parameter)=0]"
			[Register ("getMatchingsIndex", "()I", "GetGetMatchingsIndexHandler")]
			get {
				if (id_getMatchingsIndex == IntPtr.Zero)
					id_getMatchingsIndex = JNIEnv.GetMethodID (class_ref, "getMatchingsIndex", "()I");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getMatchingsIndex);
					else
						return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getMatchingsIndex", "()I"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.services.api.mapmatching.v5.models']/class[@name='MapMatchingTracepoint']/method[@name='setMatchingsIndex' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setMatchingsIndex", "(I)V", "GetSetMatchingsIndex_IHandler")]
			set {
				if (id_setMatchingsIndex_I == IntPtr.Zero)
					id_setMatchingsIndex_I = JNIEnv.GetMethodID (class_ref, "setMatchingsIndex", "(I)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setMatchingsIndex_I, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setMatchingsIndex", "(I)V"), __args);
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
			global::Com.Mapbox.Services.Api.Mapmatching.V5.Models.MapMatchingTracepoint __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Services.Api.Mapmatching.V5.Models.MapMatchingTracepoint> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Com.Mapbox.Services.Api.Mapmatching.V5.Models.MapMatchingTracepoint __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Services.Api.Mapmatching.V5.Models.MapMatchingTracepoint> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.WaypointIndex = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getWaypointIndex;
		static IntPtr id_setWaypointIndex_I;
		public virtual unsafe int WaypointIndex {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.services.api.mapmatching.v5.models']/class[@name='MapMatchingTracepoint']/method[@name='getWaypointIndex' and count(parameter)=0]"
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
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.services.api.mapmatching.v5.models']/class[@name='MapMatchingTracepoint']/method[@name='setWaypointIndex' and count(parameter)=1 and parameter[1][@type='int']]"
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
