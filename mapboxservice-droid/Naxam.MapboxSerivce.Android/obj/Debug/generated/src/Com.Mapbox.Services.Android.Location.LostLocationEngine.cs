using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Mapbox.Services.Android.Location {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.mapbox.services.android.location']/class[@name='LostLocationEngine']"
	[global::Android.Runtime.Register ("com/mapbox/services/android/location/LostLocationEngine", DoNotGenerateAcw=true)]
	public partial class LostLocationEngine : global::Com.Mapbox.Services.Android.Telemetry.Location.LocationEngine, global::Com.Mapzen.Android.Lost.Api.ILocationListener, global::Com.Mapzen.Android.Lost.Api.ILostApiClientConnectionCallbacks {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/mapbox/services/android/location/LostLocationEngine", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (LostLocationEngine); }
		}

		protected LostLocationEngine (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Landroid_content_Context_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.mapbox.services.android.location']/class[@name='LostLocationEngine']/constructor[@name='LostLocationEngine' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register (".ctor", "(Landroid/content/Context;)V", "")]
		public unsafe LostLocationEngine (global::Android.Content.Context p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (((object) this).GetType () != typeof (LostLocationEngine)) {
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
			global::Com.Mapbox.Services.Android.Location.LostLocationEngine __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Services.Android.Location.LostLocationEngine> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsConnected;
		}
#pragma warning restore 0169

		static IntPtr id_isConnected;
		public override unsafe bool IsConnected {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.services.android.location']/class[@name='LostLocationEngine']/method[@name='isConnected' and count(parameter)=0]"
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
			global::Com.Mapbox.Services.Android.Location.LostLocationEngine __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Services.Android.Location.LostLocationEngine> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.LastLocation);
		}
#pragma warning restore 0169

		static IntPtr id_getLastLocation;
		public override unsafe global::Android.Locations.Location LastLocation {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.services.android.location']/class[@name='LostLocationEngine']/method[@name='getLastLocation' and count(parameter)=0]"
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
			global::Com.Mapbox.Services.Android.Location.LostLocationEngine __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Services.Android.Location.LostLocationEngine> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Activate ();
		}
#pragma warning restore 0169

		static IntPtr id_activate;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.services.android.location']/class[@name='LostLocationEngine']/method[@name='activate' and count(parameter)=0]"
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
			global::Com.Mapbox.Services.Android.Location.LostLocationEngine __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Services.Android.Location.LostLocationEngine> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Deactivate ();
		}
#pragma warning restore 0169

		static IntPtr id_deactivate;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.services.android.location']/class[@name='LostLocationEngine']/method[@name='deactivate' and count(parameter)=0]"
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

		static IntPtr id_getLocationEngine_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.services.android.location']/class[@name='LostLocationEngine']/method[@name='getLocationEngine' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("getLocationEngine", "(Landroid/content/Context;)Lcom/mapbox/services/android/telemetry/location/LocationEngine;", "")]
		public static unsafe global::Com.Mapbox.Services.Android.Telemetry.Location.LocationEngine GetLocationEngine (global::Android.Content.Context p0)
		{
			if (id_getLocationEngine_Landroid_content_Context_ == IntPtr.Zero)
				id_getLocationEngine_Landroid_content_Context_ = JNIEnv.GetStaticMethodID (class_ref, "getLocationEngine", "(Landroid/content/Context;)Lcom/mapbox/services/android/telemetry/location/LocationEngine;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				global::Com.Mapbox.Services.Android.Telemetry.Location.LocationEngine __ret = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Services.Android.Telemetry.Location.LocationEngine> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getLocationEngine_Landroid_content_Context_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
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
			global::Com.Mapbox.Services.Android.Location.LostLocationEngine __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Services.Android.Location.LostLocationEngine> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ObtainType ());
		}
#pragma warning restore 0169

		static IntPtr id_obtainType;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.services.android.location']/class[@name='LostLocationEngine']/method[@name='obtainType' and count(parameter)=0]"
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

		static Delegate cb_onConnected;
#pragma warning disable 0169
		static Delegate GetOnConnectedHandler ()
		{
			if (cb_onConnected == null)
				cb_onConnected = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnConnected);
			return cb_onConnected;
		}

		static void n_OnConnected (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mapbox.Services.Android.Location.LostLocationEngine __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Services.Android.Location.LostLocationEngine> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnConnected ();
		}
#pragma warning restore 0169

		static IntPtr id_onConnected;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.services.android.location']/class[@name='LostLocationEngine']/method[@name='onConnected' and count(parameter)=0]"
		[Register ("onConnected", "()V", "GetOnConnectedHandler")]
		public virtual unsafe void OnConnected ()
		{
			if (id_onConnected == IntPtr.Zero)
				id_onConnected = JNIEnv.GetMethodID (class_ref, "onConnected", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onConnected);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onConnected", "()V"));
			} finally {
			}
		}

		static Delegate cb_onConnectionSuspended;
#pragma warning disable 0169
		static Delegate GetOnConnectionSuspendedHandler ()
		{
			if (cb_onConnectionSuspended == null)
				cb_onConnectionSuspended = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnConnectionSuspended);
			return cb_onConnectionSuspended;
		}

		static void n_OnConnectionSuspended (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mapbox.Services.Android.Location.LostLocationEngine __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Services.Android.Location.LostLocationEngine> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnConnectionSuspended ();
		}
#pragma warning restore 0169

		static IntPtr id_onConnectionSuspended;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.services.android.location']/class[@name='LostLocationEngine']/method[@name='onConnectionSuspended' and count(parameter)=0]"
		[Register ("onConnectionSuspended", "()V", "GetOnConnectionSuspendedHandler")]
		public virtual unsafe void OnConnectionSuspended ()
		{
			if (id_onConnectionSuspended == IntPtr.Zero)
				id_onConnectionSuspended = JNIEnv.GetMethodID (class_ref, "onConnectionSuspended", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onConnectionSuspended);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onConnectionSuspended", "()V"));
			} finally {
			}
		}

		static Delegate cb_onLocationChanged_Landroid_location_Location_;
#pragma warning disable 0169
		static Delegate GetOnLocationChanged_Landroid_location_Location_Handler ()
		{
			if (cb_onLocationChanged_Landroid_location_Location_ == null)
				cb_onLocationChanged_Landroid_location_Location_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnLocationChanged_Landroid_location_Location_);
			return cb_onLocationChanged_Landroid_location_Location_;
		}

		static void n_OnLocationChanged_Landroid_location_Location_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Mapbox.Services.Android.Location.LostLocationEngine __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Services.Android.Location.LostLocationEngine> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Locations.Location p0 = global::Java.Lang.Object.GetObject<global::Android.Locations.Location> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnLocationChanged (p0);
		}
#pragma warning restore 0169

		static IntPtr id_onLocationChanged_Landroid_location_Location_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.services.android.location']/class[@name='LostLocationEngine']/method[@name='onLocationChanged' and count(parameter)=1 and parameter[1][@type='android.location.Location']]"
		[Register ("onLocationChanged", "(Landroid/location/Location;)V", "GetOnLocationChanged_Landroid_location_Location_Handler")]
		public virtual unsafe void OnLocationChanged (global::Android.Locations.Location p0)
		{
			if (id_onLocationChanged_Landroid_location_Location_ == IntPtr.Zero)
				id_onLocationChanged_Landroid_location_Location_ = JNIEnv.GetMethodID (class_ref, "onLocationChanged", "(Landroid/location/Location;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onLocationChanged_Landroid_location_Location_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onLocationChanged", "(Landroid/location/Location;)V"), __args);
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
			global::Com.Mapbox.Services.Android.Location.LostLocationEngine __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Services.Android.Location.LostLocationEngine> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.RemoveLocationUpdates ();
		}
#pragma warning restore 0169

		static IntPtr id_removeLocationUpdates;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.services.android.location']/class[@name='LostLocationEngine']/method[@name='removeLocationUpdates' and count(parameter)=0]"
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
			global::Com.Mapbox.Services.Android.Location.LostLocationEngine __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Services.Android.Location.LostLocationEngine> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.RequestLocationUpdates ();
		}
#pragma warning restore 0169

		static IntPtr id_requestLocationUpdates;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.services.android.location']/class[@name='LostLocationEngine']/method[@name='requestLocationUpdates' and count(parameter)=0]"
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

	}
}
