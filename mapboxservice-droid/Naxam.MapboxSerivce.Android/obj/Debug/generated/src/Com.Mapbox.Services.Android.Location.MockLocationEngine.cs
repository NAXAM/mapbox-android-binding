using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Mapbox.Services.Android.Location {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.mapbox.services.android.location']/class[@name='MockLocationEngine']"
	[global::Android.Runtime.Register ("com/mapbox/services/android/location/MockLocationEngine", DoNotGenerateAcw=true)]
	public partial class MockLocationEngine : global::Com.Mapbox.Services.Android.Telemetry.Location.LocationEngine {

		// Metadata.xml XPath class reference: path="/api/package[@name='com.mapbox.services.android.location']/class[@name='MockLocationEngine.LocationUpdateRunnable']"
		[global::Android.Runtime.Register ("com/mapbox/services/android/location/MockLocationEngine$LocationUpdateRunnable", DoNotGenerateAcw=true)]
		public partial class LocationUpdateRunnable : global::Java.Lang.Object, global::Java.Lang.IRunnable {

			internal static new IntPtr java_class_handle;
			internal static new IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/mapbox/services/android/location/MockLocationEngine$LocationUpdateRunnable", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (LocationUpdateRunnable); }
			}

			protected LocationUpdateRunnable (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static Delegate cb_run;
#pragma warning disable 0169
			static Delegate GetRunHandler ()
			{
				if (cb_run == null)
					cb_run = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Run);
				return cb_run;
			}

			static void n_Run (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Mapbox.Services.Android.Location.MockLocationEngine.LocationUpdateRunnable __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Services.Android.Location.MockLocationEngine.LocationUpdateRunnable> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.Run ();
			}
#pragma warning restore 0169

			static IntPtr id_run;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.services.android.location']/class[@name='MockLocationEngine.LocationUpdateRunnable']/method[@name='run' and count(parameter)=0]"
			[Register ("run", "()V", "GetRunHandler")]
			public virtual unsafe void Run ()
			{
				if (id_run == IntPtr.Zero)
					id_run = JNIEnv.GetMethodID (class_ref, "run", "()V");
				try {

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_run);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "run", "()V"));
				} finally {
				}
			}

		}

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/mapbox/services/android/location/MockLocationEngine", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (MockLocationEngine); }
		}

		protected MockLocationEngine (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.mapbox.services.android.location']/class[@name='MockLocationEngine']/constructor[@name='MockLocationEngine' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe MockLocationEngine ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (MockLocationEngine)) {
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

		static IntPtr id_ctor_IIZ;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.mapbox.services.android.location']/class[@name='MockLocationEngine']/constructor[@name='MockLocationEngine' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='boolean']]"
		[Register (".ctor", "(IIZ)V", "")]
		public unsafe MockLocationEngine (int p0, int p1, bool p2)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				if (((object) this).GetType () != typeof (MockLocationEngine)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(IIZ)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(IIZ)V", __args);
					return;
				}

				if (id_ctor_IIZ == IntPtr.Zero)
					id_ctor_IIZ = JNIEnv.GetMethodID (class_ref, "<init>", "(IIZ)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_IIZ, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_IIZ, __args);
			} finally {
			}
		}

		static Delegate cb_getDelay;
#pragma warning disable 0169
		static Delegate GetGetDelayHandler ()
		{
			if (cb_getDelay == null)
				cb_getDelay = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetDelay);
			return cb_getDelay;
		}

		static int n_GetDelay (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mapbox.Services.Android.Location.MockLocationEngine __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Services.Android.Location.MockLocationEngine> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Delay;
		}
#pragma warning restore 0169

		static IntPtr id_getDelay;
		public virtual unsafe int Delay {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.services.android.location']/class[@name='MockLocationEngine']/method[@name='getDelay' and count(parameter)=0]"
			[Register ("getDelay", "()I", "GetGetDelayHandler")]
			get {
				if (id_getDelay == IntPtr.Zero)
					id_getDelay = JNIEnv.GetMethodID (class_ref, "getDelay", "()I");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getDelay);
					else
						return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getDelay", "()I"));
				} finally {
				}
			}
		}

		static Delegate cb_isConnected;
#pragma warning disable 0169
		static Delegate GetIsConnectedHandler ()
		{
			if (cb_isConnected == null)
				cb_isConnected = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsConnected);
			return cb_isConnected;
		}

		static bool n_IsConnected (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mapbox.Services.Android.Location.MockLocationEngine __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Services.Android.Location.MockLocationEngine> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsConnected;
		}
#pragma warning restore 0169

		static IntPtr id_isConnected;
		public override unsafe bool IsConnected {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.services.android.location']/class[@name='MockLocationEngine']/method[@name='isConnected' and count(parameter)=0]"
			[Register ("isConnected", "()Z", "GetIsConnectedHandler")]
			get {
				if (id_isConnected == IntPtr.Zero)
					id_isConnected = JNIEnv.GetMethodID (class_ref, "isConnected", "()Z");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isConnected);
					else
						return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isConnected", "()Z"));
				} finally {
				}
			}
		}

		static Delegate cb_isNoisyGps;
#pragma warning disable 0169
		static Delegate GetIsNoisyGpsHandler ()
		{
			if (cb_isNoisyGps == null)
				cb_isNoisyGps = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsNoisyGps);
			return cb_isNoisyGps;
		}

		static bool n_IsNoisyGps (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mapbox.Services.Android.Location.MockLocationEngine __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Services.Android.Location.MockLocationEngine> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsNoisyGps;
		}
#pragma warning restore 0169

		static IntPtr id_isNoisyGps;
		public virtual unsafe bool IsNoisyGps {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.services.android.location']/class[@name='MockLocationEngine']/method[@name='isNoisyGps' and count(parameter)=0]"
			[Register ("isNoisyGps", "()Z", "GetIsNoisyGpsHandler")]
			get {
				if (id_isNoisyGps == IntPtr.Zero)
					id_isNoisyGps = JNIEnv.GetMethodID (class_ref, "isNoisyGps", "()Z");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isNoisyGps);
					else
						return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isNoisyGps", "()Z"));
				} finally {
				}
			}
		}

		static Delegate cb_getLastLocation;
#pragma warning disable 0169
		static Delegate GetGetLastLocationHandler ()
		{
			if (cb_getLastLocation == null)
				cb_getLastLocation = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetLastLocation);
			return cb_getLastLocation;
		}

		static IntPtr n_GetLastLocation (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mapbox.Services.Android.Location.MockLocationEngine __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Services.Android.Location.MockLocationEngine> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.LastLocation);
		}
#pragma warning restore 0169

		static IntPtr id_getLastLocation;
		public override unsafe global::Android.Locations.Location LastLocation {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.services.android.location']/class[@name='MockLocationEngine']/method[@name='getLastLocation' and count(parameter)=0]"
			[Register ("getLastLocation", "()Landroid/location/Location;", "GetGetLastLocationHandler")]
			get {
				if (id_getLastLocation == IntPtr.Zero)
					id_getLastLocation = JNIEnv.GetMethodID (class_ref, "getLastLocation", "()Landroid/location/Location;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Android.Locations.Location> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getLastLocation), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Android.Locations.Location> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getLastLocation", "()Landroid/location/Location;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getSpeed;
#pragma warning disable 0169
		static Delegate GetGetSpeedHandler ()
		{
			if (cb_getSpeed == null)
				cb_getSpeed = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetSpeed);
			return cb_getSpeed;
		}

		static int n_GetSpeed (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mapbox.Services.Android.Location.MockLocationEngine __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Services.Android.Location.MockLocationEngine> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Speed;
		}
#pragma warning restore 0169

		static IntPtr id_getSpeed;
		public virtual unsafe int Speed {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.services.android.location']/class[@name='MockLocationEngine']/method[@name='getSpeed' and count(parameter)=0]"
			[Register ("getSpeed", "()I", "GetGetSpeedHandler")]
			get {
				if (id_getSpeed == IntPtr.Zero)
					id_getSpeed = JNIEnv.GetMethodID (class_ref, "getSpeed", "()I");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getSpeed);
					else
						return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getSpeed", "()I"));
				} finally {
				}
			}
		}

		static Delegate cb_activate;
#pragma warning disable 0169
		static Delegate GetActivateHandler ()
		{
			if (cb_activate == null)
				cb_activate = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Activate);
			return cb_activate;
		}

		static void n_Activate (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mapbox.Services.Android.Location.MockLocationEngine __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Services.Android.Location.MockLocationEngine> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Activate ();
		}
#pragma warning restore 0169

		static IntPtr id_activate;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.services.android.location']/class[@name='MockLocationEngine']/method[@name='activate' and count(parameter)=0]"
		[Register ("activate", "()V", "GetActivateHandler")]
		public override unsafe void Activate ()
		{
			if (id_activate == IntPtr.Zero)
				id_activate = JNIEnv.GetMethodID (class_ref, "activate", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_activate);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "activate", "()V"));
			} finally {
			}
		}

		static Delegate cb_deactivate;
#pragma warning disable 0169
		static Delegate GetDeactivateHandler ()
		{
			if (cb_deactivate == null)
				cb_deactivate = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Deactivate);
			return cb_deactivate;
		}

		static void n_Deactivate (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mapbox.Services.Android.Location.MockLocationEngine __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Services.Android.Location.MockLocationEngine> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Deactivate ();
		}
#pragma warning restore 0169

		static IntPtr id_deactivate;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.services.android.location']/class[@name='MockLocationEngine']/method[@name='deactivate' and count(parameter)=0]"
		[Register ("deactivate", "()V", "GetDeactivateHandler")]
		public override unsafe void Deactivate ()
		{
			if (id_deactivate == IntPtr.Zero)
				id_deactivate = JNIEnv.GetMethodID (class_ref, "deactivate", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_deactivate);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "deactivate", "()V"));
			} finally {
			}
		}

		static Delegate cb_moveToLocation_Lcom_mapbox_services_commons_models_Position_;
#pragma warning disable 0169
		static Delegate GetMoveToLocation_Lcom_mapbox_services_commons_models_Position_Handler ()
		{
			if (cb_moveToLocation_Lcom_mapbox_services_commons_models_Position_ == null)
				cb_moveToLocation_Lcom_mapbox_services_commons_models_Position_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_MoveToLocation_Lcom_mapbox_services_commons_models_Position_);
			return cb_moveToLocation_Lcom_mapbox_services_commons_models_Position_;
		}

		static void n_MoveToLocation_Lcom_mapbox_services_commons_models_Position_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Mapbox.Services.Android.Location.MockLocationEngine __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Services.Android.Location.MockLocationEngine> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Mapbox.Services.Commons.Models.Position p0 = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Services.Commons.Models.Position> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.MoveToLocation (p0);
		}
#pragma warning restore 0169

		static IntPtr id_moveToLocation_Lcom_mapbox_services_commons_models_Position_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.services.android.location']/class[@name='MockLocationEngine']/method[@name='moveToLocation' and count(parameter)=1 and parameter[1][@type='com.mapbox.services.commons.models.Position']]"
		[Register ("moveToLocation", "(Lcom/mapbox/services/commons/models/Position;)V", "GetMoveToLocation_Lcom_mapbox_services_commons_models_Position_Handler")]
		public virtual unsafe void MoveToLocation (global::Com.Mapbox.Services.Commons.Models.Position p0)
		{
			if (id_moveToLocation_Lcom_mapbox_services_commons_models_Position_ == IntPtr.Zero)
				id_moveToLocation_Lcom_mapbox_services_commons_models_Position_ = JNIEnv.GetMethodID (class_ref, "moveToLocation", "(Lcom/mapbox/services/commons/models/Position;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_moveToLocation_Lcom_mapbox_services_commons_models_Position_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "moveToLocation", "(Lcom/mapbox/services/commons/models/Position;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_obtainType;
#pragma warning disable 0169
		static Delegate GetObtainTypeHandler ()
		{
			if (cb_obtainType == null)
				cb_obtainType = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_ObtainType);
			return cb_obtainType;
		}

		static IntPtr n_ObtainType (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mapbox.Services.Android.Location.MockLocationEngine __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Services.Android.Location.MockLocationEngine> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ObtainType ());
		}
#pragma warning restore 0169

		static IntPtr id_obtainType;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.services.android.location']/class[@name='MockLocationEngine']/method[@name='obtainType' and count(parameter)=0]"
		[Register ("obtainType", "()Lcom/mapbox/services/android/telemetry/location/LocationEngine$Type;", "GetObtainTypeHandler")]
		public override unsafe global::Com.Mapbox.Services.Android.Telemetry.Location.LocationEngine.Type ObtainType ()
		{
			if (id_obtainType == IntPtr.Zero)
				id_obtainType = JNIEnv.GetMethodID (class_ref, "obtainType", "()Lcom/mapbox/services/android/telemetry/location/LocationEngine$Type;");
			try {

				if (((object) this).GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Services.Android.Telemetry.Location.LocationEngine.Type> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_obtainType), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Services.Android.Telemetry.Location.LocationEngine.Type> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "obtainType", "()Lcom/mapbox/services/android/telemetry/location/LocationEngine$Type;")), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_removeLocationUpdates;
#pragma warning disable 0169
		static Delegate GetRemoveLocationUpdatesHandler ()
		{
			if (cb_removeLocationUpdates == null)
				cb_removeLocationUpdates = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_RemoveLocationUpdates);
			return cb_removeLocationUpdates;
		}

		static void n_RemoveLocationUpdates (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mapbox.Services.Android.Location.MockLocationEngine __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Services.Android.Location.MockLocationEngine> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.RemoveLocationUpdates ();
		}
#pragma warning restore 0169

		static IntPtr id_removeLocationUpdates;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.services.android.location']/class[@name='MockLocationEngine']/method[@name='removeLocationUpdates' and count(parameter)=0]"
		[Register ("removeLocationUpdates", "()V", "GetRemoveLocationUpdatesHandler")]
		public override unsafe void RemoveLocationUpdates ()
		{
			if (id_removeLocationUpdates == IntPtr.Zero)
				id_removeLocationUpdates = JNIEnv.GetMethodID (class_ref, "removeLocationUpdates", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_removeLocationUpdates);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "removeLocationUpdates", "()V"));
			} finally {
			}
		}

		static Delegate cb_requestLocationUpdates;
#pragma warning disable 0169
		static Delegate GetRequestLocationUpdatesHandler ()
		{
			if (cb_requestLocationUpdates == null)
				cb_requestLocationUpdates = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_RequestLocationUpdates);
			return cb_requestLocationUpdates;
		}

		static void n_RequestLocationUpdates (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mapbox.Services.Android.Location.MockLocationEngine __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Services.Android.Location.MockLocationEngine> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.RequestLocationUpdates ();
		}
#pragma warning restore 0169

		static IntPtr id_requestLocationUpdates;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.services.android.location']/class[@name='MockLocationEngine']/method[@name='requestLocationUpdates' and count(parameter)=0]"
		[Register ("requestLocationUpdates", "()V", "GetRequestLocationUpdatesHandler")]
		public override unsafe void RequestLocationUpdates ()
		{
			if (id_requestLocationUpdates == IntPtr.Zero)
				id_requestLocationUpdates = JNIEnv.GetMethodID (class_ref, "requestLocationUpdates", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_requestLocationUpdates);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "requestLocationUpdates", "()V"));
			} finally {
			}
		}

		static Delegate cb_setLastLocation_Lcom_mapbox_services_commons_models_Position_;
#pragma warning disable 0169
		static Delegate GetSetLastLocation_Lcom_mapbox_services_commons_models_Position_Handler ()
		{
			if (cb_setLastLocation_Lcom_mapbox_services_commons_models_Position_ == null)
				cb_setLastLocation_Lcom_mapbox_services_commons_models_Position_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetLastLocation_Lcom_mapbox_services_commons_models_Position_);
			return cb_setLastLocation_Lcom_mapbox_services_commons_models_Position_;
		}

		static void n_SetLastLocation_Lcom_mapbox_services_commons_models_Position_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Mapbox.Services.Android.Location.MockLocationEngine __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Services.Android.Location.MockLocationEngine> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Mapbox.Services.Commons.Models.Position p0 = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Services.Commons.Models.Position> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetLastLocation (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setLastLocation_Lcom_mapbox_services_commons_models_Position_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.services.android.location']/class[@name='MockLocationEngine']/method[@name='setLastLocation' and count(parameter)=1 and parameter[1][@type='com.mapbox.services.commons.models.Position']]"
		[Register ("setLastLocation", "(Lcom/mapbox/services/commons/models/Position;)V", "GetSetLastLocation_Lcom_mapbox_services_commons_models_Position_Handler")]
		public virtual unsafe void SetLastLocation (global::Com.Mapbox.Services.Commons.Models.Position p0)
		{
			if (id_setLastLocation_Lcom_mapbox_services_commons_models_Position_ == IntPtr.Zero)
				id_setLastLocation_Lcom_mapbox_services_commons_models_Position_ = JNIEnv.GetMethodID (class_ref, "setLastLocation", "(Lcom/mapbox/services/commons/models/Position;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setLastLocation_Lcom_mapbox_services_commons_models_Position_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setLastLocation", "(Lcom/mapbox/services/commons/models/Position;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setRoute_Lcom_mapbox_services_api_directions_v5_models_DirectionsRoute_;
#pragma warning disable 0169
		static Delegate GetSetRoute_Lcom_mapbox_services_api_directions_v5_models_DirectionsRoute_Handler ()
		{
			if (cb_setRoute_Lcom_mapbox_services_api_directions_v5_models_DirectionsRoute_ == null)
				cb_setRoute_Lcom_mapbox_services_api_directions_v5_models_DirectionsRoute_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetRoute_Lcom_mapbox_services_api_directions_v5_models_DirectionsRoute_);
			return cb_setRoute_Lcom_mapbox_services_api_directions_v5_models_DirectionsRoute_;
		}

		static void n_SetRoute_Lcom_mapbox_services_api_directions_v5_models_DirectionsRoute_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Mapbox.Services.Android.Location.MockLocationEngine __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Services.Android.Location.MockLocationEngine> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Mapbox.Services.Api.Directions.V5.Models.DirectionsRoute p0 = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Services.Api.Directions.V5.Models.DirectionsRoute> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetRoute (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setRoute_Lcom_mapbox_services_api_directions_v5_models_DirectionsRoute_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.services.android.location']/class[@name='MockLocationEngine']/method[@name='setRoute' and count(parameter)=1 and parameter[1][@type='com.mapbox.services.api.directions.v5.models.DirectionsRoute']]"
		[Register ("setRoute", "(Lcom/mapbox/services/api/directions/v5/models/DirectionsRoute;)V", "GetSetRoute_Lcom_mapbox_services_api_directions_v5_models_DirectionsRoute_Handler")]
		public virtual unsafe void SetRoute (global::Com.Mapbox.Services.Api.Directions.V5.Models.DirectionsRoute p0)
		{
			if (id_setRoute_Lcom_mapbox_services_api_directions_v5_models_DirectionsRoute_ == IntPtr.Zero)
				id_setRoute_Lcom_mapbox_services_api_directions_v5_models_DirectionsRoute_ = JNIEnv.GetMethodID (class_ref, "setRoute", "(Lcom/mapbox/services/api/directions/v5/models/DirectionsRoute;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setRoute_Lcom_mapbox_services_api_directions_v5_models_DirectionsRoute_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setRoute", "(Lcom/mapbox/services/api/directions/v5/models/DirectionsRoute;)V"), __args);
			} finally {
			}
		}

	}
}
