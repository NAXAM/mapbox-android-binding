using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Mapbox.Services.Api.Directions.V5.Models {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.mapbox.services.api.directions.v5.models']/class[@name='IntersectionLanes']"
	[global::Android.Runtime.Register ("com/mapbox/services/api/directions/v5/models/IntersectionLanes", DoNotGenerateAcw=true)]
	public partial class IntersectionLanes : global::Java.Lang.Object {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/mapbox/services/api/directions/v5/models/IntersectionLanes", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IntersectionLanes); }
		}

		protected IntersectionLanes (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.mapbox.services.api.directions.v5.models']/class[@name='IntersectionLanes']/constructor[@name='IntersectionLanes' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe IntersectionLanes ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (IntersectionLanes)) {
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

		static IntPtr id_ctor_Z;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.mapbox.services.api.directions.v5.models']/class[@name='IntersectionLanes']/constructor[@name='IntersectionLanes' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register (".ctor", "(Z)V", "")]
		public unsafe IntersectionLanes (bool p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (((object) this).GetType () != typeof (IntersectionLanes)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Z)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Z)V", __args);
					return;
				}

				if (id_ctor_Z == IntPtr.Zero)
					id_ctor_Z = JNIEnv.GetMethodID (class_ref, "<init>", "(Z)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Z, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Z, __args);
			} finally {
			}
		}

		static Delegate cb_getValid;
#pragma warning disable 0169
		static Delegate GetGetValidHandler ()
		{
			if (cb_getValid == null)
				cb_getValid = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_GetValid);
			return cb_getValid;
		}

		static bool n_GetValid (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mapbox.Services.Api.Directions.V5.Models.IntersectionLanes __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Services.Api.Directions.V5.Models.IntersectionLanes> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Valid;
		}
#pragma warning restore 0169

		static Delegate cb_setValid_Z;
#pragma warning disable 0169
		static Delegate GetSetValid_ZHandler ()
		{
			if (cb_setValid_Z == null)
				cb_setValid_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetValid_Z);
			return cb_setValid_Z;
		}

		static void n_SetValid_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Com.Mapbox.Services.Api.Directions.V5.Models.IntersectionLanes __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Services.Api.Directions.V5.Models.IntersectionLanes> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Valid = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getValid;
		static IntPtr id_setValid_Z;
		public virtual unsafe bool Valid {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.services.api.directions.v5.models']/class[@name='IntersectionLanes']/method[@name='getValid' and count(parameter)=0]"
			[Register ("getValid", "()Z", "GetGetValidHandler")]
			get {
				if (id_getValid == IntPtr.Zero)
					id_getValid = JNIEnv.GetMethodID (class_ref, "getValid", "()Z");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_getValid);
					else
						return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getValid", "()Z"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.services.api.directions.v5.models']/class[@name='IntersectionLanes']/method[@name='setValid' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setValid", "(Z)V", "GetSetValid_ZHandler")]
			set {
				if (id_setValid_Z == IntPtr.Zero)
					id_setValid_Z = JNIEnv.GetMethodID (class_ref, "setValid", "(Z)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setValid_Z, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setValid", "(Z)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getIndications;
#pragma warning disable 0169
		static Delegate GetGetIndicationsHandler ()
		{
			if (cb_getIndications == null)
				cb_getIndications = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetIndications);
			return cb_getIndications;
		}

		static IntPtr n_GetIndications (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mapbox.Services.Api.Directions.V5.Models.IntersectionLanes __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Services.Api.Directions.V5.Models.IntersectionLanes> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetIndications ());
		}
#pragma warning restore 0169

		static IntPtr id_getIndications;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.services.api.directions.v5.models']/class[@name='IntersectionLanes']/method[@name='getIndications' and count(parameter)=0]"
		[Register ("getIndications", "()[Ljava/lang/String;", "GetGetIndicationsHandler")]
		public virtual unsafe string[] GetIndications ()
		{
			if (id_getIndications == IntPtr.Zero)
				id_getIndications = JNIEnv.GetMethodID (class_ref, "getIndications", "()[Ljava/lang/String;");
			try {

				if (((object) this).GetType () == ThresholdType)
					return (string[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getIndications), JniHandleOwnership.TransferLocalRef, typeof (string));
				else
					return (string[]) JNIEnv.GetArray (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getIndications", "()[Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef, typeof (string));
			} finally {
			}
		}

		static Delegate cb_setIndications_arrayLjava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetIndications_arrayLjava_lang_String_Handler ()
		{
			if (cb_setIndications_arrayLjava_lang_String_ == null)
				cb_setIndications_arrayLjava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetIndications_arrayLjava_lang_String_);
			return cb_setIndications_arrayLjava_lang_String_;
		}

		static void n_SetIndications_arrayLjava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Mapbox.Services.Api.Directions.V5.Models.IntersectionLanes __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Services.Api.Directions.V5.Models.IntersectionLanes> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string[] p0 = (string[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (string));
			__this.SetIndications (p0);
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
		}
#pragma warning restore 0169

		static IntPtr id_setIndications_arrayLjava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.services.api.directions.v5.models']/class[@name='IntersectionLanes']/method[@name='setIndications' and count(parameter)=1 and parameter[1][@type='java.lang.String[]']]"
		[Register ("setIndications", "([Ljava/lang/String;)V", "GetSetIndications_arrayLjava_lang_String_Handler")]
		public virtual unsafe void SetIndications (string[] p0)
		{
			if (id_setIndications_arrayLjava_lang_String_ == IntPtr.Zero)
				id_setIndications_arrayLjava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setIndications", "([Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setIndications_arrayLjava_lang_String_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setIndications", "([Ljava/lang/String;)V"), __args);
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}
		}

	}
}
