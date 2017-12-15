using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Mapbox.Services.Api.Directions.V5.Models {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.mapbox.services.api.directions.v5.models']/class[@name='StepIntersection']"
	[global::Android.Runtime.Register ("com/mapbox/services/api/directions/v5/models/StepIntersection", DoNotGenerateAcw=true)]
	public partial class StepIntersection : global::Java.Lang.Object {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/mapbox/services/api/directions/v5/models/StepIntersection", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (StepIntersection); }
		}

		protected StepIntersection (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.mapbox.services.api.directions.v5.models']/class[@name='StepIntersection']/constructor[@name='StepIntersection' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe StepIntersection ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (StepIntersection)) {
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

		static IntPtr id_ctor_arrayLcom_mapbox_services_api_directions_v5_models_IntersectionLanes_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.mapbox.services.api.directions.v5.models']/class[@name='StepIntersection']/constructor[@name='StepIntersection' and count(parameter)=1 and parameter[1][@type='com.mapbox.services.api.directions.v5.models.IntersectionLanes[]']]"
		[Register (".ctor", "([Lcom/mapbox/services/api/directions/v5/models/IntersectionLanes;)V", "")]
		public unsafe StepIntersection (global::Com.Mapbox.Services.Api.Directions.V5.Models.IntersectionLanes[] p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				if (((object) this).GetType () != typeof (StepIntersection)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "([Lcom/mapbox/services/api/directions/v5/models/IntersectionLanes;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "([Lcom/mapbox/services/api/directions/v5/models/IntersectionLanes;)V", __args);
					return;
				}

				if (id_ctor_arrayLcom_mapbox_services_api_directions_v5_models_IntersectionLanes_ == IntPtr.Zero)
					id_ctor_arrayLcom_mapbox_services_api_directions_v5_models_IntersectionLanes_ = JNIEnv.GetMethodID (class_ref, "<init>", "([Lcom/mapbox/services/api/directions/v5/models/IntersectionLanes;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_arrayLcom_mapbox_services_api_directions_v5_models_IntersectionLanes_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_arrayLcom_mapbox_services_api_directions_v5_models_IntersectionLanes_, __args);
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}
		}

		static Delegate cb_getIn;
#pragma warning disable 0169
		static Delegate GetGetInHandler ()
		{
			if (cb_getIn == null)
				cb_getIn = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetIn);
			return cb_getIn;
		}

		static int n_GetIn (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mapbox.Services.Api.Directions.V5.Models.StepIntersection __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Services.Api.Directions.V5.Models.StepIntersection> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.In;
		}
#pragma warning restore 0169

		static Delegate cb_setIn_I;
#pragma warning disable 0169
		static Delegate GetSetIn_IHandler ()
		{
			if (cb_setIn_I == null)
				cb_setIn_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetIn_I);
			return cb_setIn_I;
		}

		static void n_SetIn_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Mapbox.Services.Api.Directions.V5.Models.StepIntersection __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Services.Api.Directions.V5.Models.StepIntersection> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.In = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getIn;
		static IntPtr id_setIn_I;
		public virtual unsafe int In {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.services.api.directions.v5.models']/class[@name='StepIntersection']/method[@name='getIn' and count(parameter)=0]"
			[Register ("getIn", "()I", "GetGetInHandler")]
			get {
				if (id_getIn == IntPtr.Zero)
					id_getIn = JNIEnv.GetMethodID (class_ref, "getIn", "()I");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getIn);
					else
						return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getIn", "()I"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.services.api.directions.v5.models']/class[@name='StepIntersection']/method[@name='setIn' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setIn", "(I)V", "GetSetIn_IHandler")]
			set {
				if (id_setIn_I == IntPtr.Zero)
					id_setIn_I = JNIEnv.GetMethodID (class_ref, "setIn", "(I)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setIn_I, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setIn", "(I)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getOut;
#pragma warning disable 0169
		static Delegate GetGetOutHandler ()
		{
			if (cb_getOut == null)
				cb_getOut = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetOut);
			return cb_getOut;
		}

		static int n_GetOut (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mapbox.Services.Api.Directions.V5.Models.StepIntersection __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Services.Api.Directions.V5.Models.StepIntersection> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Out;
		}
#pragma warning restore 0169

		static Delegate cb_setOut_I;
#pragma warning disable 0169
		static Delegate GetSetOut_IHandler ()
		{
			if (cb_setOut_I == null)
				cb_setOut_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetOut_I);
			return cb_setOut_I;
		}

		static void n_SetOut_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Mapbox.Services.Api.Directions.V5.Models.StepIntersection __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Services.Api.Directions.V5.Models.StepIntersection> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Out = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getOut;
		static IntPtr id_setOut_I;
		public virtual unsafe int Out {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.services.api.directions.v5.models']/class[@name='StepIntersection']/method[@name='getOut' and count(parameter)=0]"
			[Register ("getOut", "()I", "GetGetOutHandler")]
			get {
				if (id_getOut == IntPtr.Zero)
					id_getOut = JNIEnv.GetMethodID (class_ref, "getOut", "()I");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getOut);
					else
						return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getOut", "()I"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.services.api.directions.v5.models']/class[@name='StepIntersection']/method[@name='setOut' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setOut", "(I)V", "GetSetOut_IHandler")]
			set {
				if (id_setOut_I == IntPtr.Zero)
					id_setOut_I = JNIEnv.GetMethodID (class_ref, "setOut", "(I)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setOut_I, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setOut", "(I)V"), __args);
				} finally {
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
			global::Com.Mapbox.Services.Api.Directions.V5.Models.StepIntersection __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Services.Api.Directions.V5.Models.StepIntersection> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.AsPosition ());
		}
#pragma warning restore 0169

		static IntPtr id_asPosition;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.services.api.directions.v5.models']/class[@name='StepIntersection']/method[@name='asPosition' and count(parameter)=0]"
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

		static Delegate cb_getBearings;
#pragma warning disable 0169
		static Delegate GetGetBearingsHandler ()
		{
			if (cb_getBearings == null)
				cb_getBearings = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetBearings);
			return cb_getBearings;
		}

		static IntPtr n_GetBearings (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mapbox.Services.Api.Directions.V5.Models.StepIntersection __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Services.Api.Directions.V5.Models.StepIntersection> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetBearings ());
		}
#pragma warning restore 0169

		static IntPtr id_getBearings;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.services.api.directions.v5.models']/class[@name='StepIntersection']/method[@name='getBearings' and count(parameter)=0]"
		[Register ("getBearings", "()[I", "GetGetBearingsHandler")]
		public virtual unsafe int[] GetBearings ()
		{
			if (id_getBearings == IntPtr.Zero)
				id_getBearings = JNIEnv.GetMethodID (class_ref, "getBearings", "()[I");
			try {

				if (((object) this).GetType () == ThresholdType)
					return (int[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getBearings), JniHandleOwnership.TransferLocalRef, typeof (int));
				else
					return (int[]) JNIEnv.GetArray (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getBearings", "()[I")), JniHandleOwnership.TransferLocalRef, typeof (int));
			} finally {
			}
		}

		static Delegate cb_getEntry;
#pragma warning disable 0169
		static Delegate GetGetEntryHandler ()
		{
			if (cb_getEntry == null)
				cb_getEntry = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetEntry);
			return cb_getEntry;
		}

		static IntPtr n_GetEntry (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mapbox.Services.Api.Directions.V5.Models.StepIntersection __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Services.Api.Directions.V5.Models.StepIntersection> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetEntry ());
		}
#pragma warning restore 0169

		static IntPtr id_getEntry;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.services.api.directions.v5.models']/class[@name='StepIntersection']/method[@name='getEntry' and count(parameter)=0]"
		[Register ("getEntry", "()[Z", "GetGetEntryHandler")]
		public virtual unsafe bool[] GetEntry ()
		{
			if (id_getEntry == IntPtr.Zero)
				id_getEntry = JNIEnv.GetMethodID (class_ref, "getEntry", "()[Z");
			try {

				if (((object) this).GetType () == ThresholdType)
					return (bool[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getEntry), JniHandleOwnership.TransferLocalRef, typeof (bool));
				else
					return (bool[]) JNIEnv.GetArray (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getEntry", "()[Z")), JniHandleOwnership.TransferLocalRef, typeof (bool));
			} finally {
			}
		}

		static Delegate cb_getLanes;
#pragma warning disable 0169
		static Delegate GetGetLanesHandler ()
		{
			if (cb_getLanes == null)
				cb_getLanes = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetLanes);
			return cb_getLanes;
		}

		static IntPtr n_GetLanes (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mapbox.Services.Api.Directions.V5.Models.StepIntersection __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Services.Api.Directions.V5.Models.StepIntersection> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetLanes ());
		}
#pragma warning restore 0169

		static IntPtr id_getLanes;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.services.api.directions.v5.models']/class[@name='StepIntersection']/method[@name='getLanes' and count(parameter)=0]"
		[Register ("getLanes", "()[Lcom/mapbox/services/api/directions/v5/models/IntersectionLanes;", "GetGetLanesHandler")]
		public virtual unsafe global::Com.Mapbox.Services.Api.Directions.V5.Models.IntersectionLanes[] GetLanes ()
		{
			if (id_getLanes == IntPtr.Zero)
				id_getLanes = JNIEnv.GetMethodID (class_ref, "getLanes", "()[Lcom/mapbox/services/api/directions/v5/models/IntersectionLanes;");
			try {

				if (((object) this).GetType () == ThresholdType)
					return (global::Com.Mapbox.Services.Api.Directions.V5.Models.IntersectionLanes[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getLanes), JniHandleOwnership.TransferLocalRef, typeof (global::Com.Mapbox.Services.Api.Directions.V5.Models.IntersectionLanes));
				else
					return (global::Com.Mapbox.Services.Api.Directions.V5.Models.IntersectionLanes[]) JNIEnv.GetArray (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getLanes", "()[Lcom/mapbox/services/api/directions/v5/models/IntersectionLanes;")), JniHandleOwnership.TransferLocalRef, typeof (global::Com.Mapbox.Services.Api.Directions.V5.Models.IntersectionLanes));
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
			global::Com.Mapbox.Services.Api.Directions.V5.Models.StepIntersection __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Services.Api.Directions.V5.Models.StepIntersection> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetLocation ());
		}
#pragma warning restore 0169

		static IntPtr id_getLocation;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.services.api.directions.v5.models']/class[@name='StepIntersection']/method[@name='getLocation' and count(parameter)=0]"
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

		static Delegate cb_setBearings_arrayI;
#pragma warning disable 0169
		static Delegate GetSetBearings_arrayIHandler ()
		{
			if (cb_setBearings_arrayI == null)
				cb_setBearings_arrayI = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetBearings_arrayI);
			return cb_setBearings_arrayI;
		}

		static void n_SetBearings_arrayI (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Mapbox.Services.Api.Directions.V5.Models.StepIntersection __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Services.Api.Directions.V5.Models.StepIntersection> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			int[] p0 = (int[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (int));
			__this.SetBearings (p0);
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
		}
#pragma warning restore 0169

		static IntPtr id_setBearings_arrayI;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.services.api.directions.v5.models']/class[@name='StepIntersection']/method[@name='setBearings' and count(parameter)=1 and parameter[1][@type='int[]']]"
		[Register ("setBearings", "([I)V", "GetSetBearings_arrayIHandler")]
		public virtual unsafe void SetBearings (int[] p0)
		{
			if (id_setBearings_arrayI == IntPtr.Zero)
				id_setBearings_arrayI = JNIEnv.GetMethodID (class_ref, "setBearings", "([I)V");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setBearings_arrayI, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setBearings", "([I)V"), __args);
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}
		}

		static Delegate cb_setEntry_arrayZ;
#pragma warning disable 0169
		static Delegate GetSetEntry_arrayZHandler ()
		{
			if (cb_setEntry_arrayZ == null)
				cb_setEntry_arrayZ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetEntry_arrayZ);
			return cb_setEntry_arrayZ;
		}

		static void n_SetEntry_arrayZ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Mapbox.Services.Api.Directions.V5.Models.StepIntersection __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Services.Api.Directions.V5.Models.StepIntersection> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			bool[] p0 = (bool[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (bool));
			__this.SetEntry (p0);
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
		}
#pragma warning restore 0169

		static IntPtr id_setEntry_arrayZ;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.services.api.directions.v5.models']/class[@name='StepIntersection']/method[@name='setEntry' and count(parameter)=1 and parameter[1][@type='boolean[]']]"
		[Register ("setEntry", "([Z)V", "GetSetEntry_arrayZHandler")]
		public virtual unsafe void SetEntry (bool[] p0)
		{
			if (id_setEntry_arrayZ == IntPtr.Zero)
				id_setEntry_arrayZ = JNIEnv.GetMethodID (class_ref, "setEntry", "([Z)V");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setEntry_arrayZ, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setEntry", "([Z)V"), __args);
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}
		}

		static Delegate cb_setLanes_arrayLcom_mapbox_services_api_directions_v5_models_IntersectionLanes_;
#pragma warning disable 0169
		static Delegate GetSetLanes_arrayLcom_mapbox_services_api_directions_v5_models_IntersectionLanes_Handler ()
		{
			if (cb_setLanes_arrayLcom_mapbox_services_api_directions_v5_models_IntersectionLanes_ == null)
				cb_setLanes_arrayLcom_mapbox_services_api_directions_v5_models_IntersectionLanes_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetLanes_arrayLcom_mapbox_services_api_directions_v5_models_IntersectionLanes_);
			return cb_setLanes_arrayLcom_mapbox_services_api_directions_v5_models_IntersectionLanes_;
		}

		static void n_SetLanes_arrayLcom_mapbox_services_api_directions_v5_models_IntersectionLanes_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Mapbox.Services.Api.Directions.V5.Models.StepIntersection __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Services.Api.Directions.V5.Models.StepIntersection> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Mapbox.Services.Api.Directions.V5.Models.IntersectionLanes[] p0 = (global::Com.Mapbox.Services.Api.Directions.V5.Models.IntersectionLanes[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (global::Com.Mapbox.Services.Api.Directions.V5.Models.IntersectionLanes));
			__this.SetLanes (p0);
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
		}
#pragma warning restore 0169

		static IntPtr id_setLanes_arrayLcom_mapbox_services_api_directions_v5_models_IntersectionLanes_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.services.api.directions.v5.models']/class[@name='StepIntersection']/method[@name='setLanes' and count(parameter)=1 and parameter[1][@type='com.mapbox.services.api.directions.v5.models.IntersectionLanes[]']]"
		[Register ("setLanes", "([Lcom/mapbox/services/api/directions/v5/models/IntersectionLanes;)V", "GetSetLanes_arrayLcom_mapbox_services_api_directions_v5_models_IntersectionLanes_Handler")]
		public virtual unsafe void SetLanes (global::Com.Mapbox.Services.Api.Directions.V5.Models.IntersectionLanes[] p0)
		{
			if (id_setLanes_arrayLcom_mapbox_services_api_directions_v5_models_IntersectionLanes_ == IntPtr.Zero)
				id_setLanes_arrayLcom_mapbox_services_api_directions_v5_models_IntersectionLanes_ = JNIEnv.GetMethodID (class_ref, "setLanes", "([Lcom/mapbox/services/api/directions/v5/models/IntersectionLanes;)V");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setLanes_arrayLcom_mapbox_services_api_directions_v5_models_IntersectionLanes_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setLanes", "([Lcom/mapbox/services/api/directions/v5/models/IntersectionLanes;)V"), __args);
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
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
			global::Com.Mapbox.Services.Api.Directions.V5.Models.StepIntersection __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Services.Api.Directions.V5.Models.StepIntersection> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			double[] p0 = (double[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (double));
			__this.SetLocation (p0);
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
		}
#pragma warning restore 0169

		static IntPtr id_setLocation_arrayD;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.services.api.directions.v5.models']/class[@name='StepIntersection']/method[@name='setLocation' and count(parameter)=1 and parameter[1][@type='double[]']]"
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
