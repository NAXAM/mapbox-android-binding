using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Mapbox.Services.Api.Utils.Turf.Models {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.mapbox.services.api.utils.turf.models']/class[@name='LineIntersectsResult']"
	[global::Android.Runtime.Register ("com/mapbox/services/api/utils/turf/models/LineIntersectsResult", DoNotGenerateAcw=true)]
	public partial class LineIntersectsResult : global::Java.Lang.Object {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/mapbox/services/api/utils/turf/models/LineIntersectsResult", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (LineIntersectsResult); }
		}

		protected LineIntersectsResult (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.mapbox.services.api.utils.turf.models']/class[@name='LineIntersectsResult']/constructor[@name='LineIntersectsResult' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe LineIntersectsResult ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (LineIntersectsResult)) {
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

		static Delegate cb_isOnLine1;
#pragma warning disable 0169
		static Delegate GetIsOnLine1Handler ()
		{
			if (cb_isOnLine1 == null)
				cb_isOnLine1 = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsOnLine1);
			return cb_isOnLine1;
		}

		static bool n_IsOnLine1 (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mapbox.Services.Api.Utils.Turf.Models.LineIntersectsResult __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Services.Api.Utils.Turf.Models.LineIntersectsResult> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.OnLine1;
		}
#pragma warning restore 0169

		static Delegate cb_setOnLine1_Z;
#pragma warning disable 0169
		static Delegate GetSetOnLine1_ZHandler ()
		{
			if (cb_setOnLine1_Z == null)
				cb_setOnLine1_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetOnLine1_Z);
			return cb_setOnLine1_Z;
		}

		static void n_SetOnLine1_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Com.Mapbox.Services.Api.Utils.Turf.Models.LineIntersectsResult __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Services.Api.Utils.Turf.Models.LineIntersectsResult> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnLine1 = p0;
		}
#pragma warning restore 0169

		static IntPtr id_isOnLine1;
		static IntPtr id_setOnLine1_Z;
		public virtual unsafe bool OnLine1 {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.services.api.utils.turf.models']/class[@name='LineIntersectsResult']/method[@name='isOnLine1' and count(parameter)=0]"
			[Register ("isOnLine1", "()Z", "GetIsOnLine1Handler")]
			get {
				if (id_isOnLine1 == IntPtr.Zero)
					id_isOnLine1 = JNIEnv.GetMethodID (class_ref, "isOnLine1", "()Z");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isOnLine1);
					else
						return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isOnLine1", "()Z"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.services.api.utils.turf.models']/class[@name='LineIntersectsResult']/method[@name='setOnLine1' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setOnLine1", "(Z)V", "GetSetOnLine1_ZHandler")]
			set {
				if (id_setOnLine1_Z == IntPtr.Zero)
					id_setOnLine1_Z = JNIEnv.GetMethodID (class_ref, "setOnLine1", "(Z)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setOnLine1_Z, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setOnLine1", "(Z)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_isOnLine2;
#pragma warning disable 0169
		static Delegate GetIsOnLine2Handler ()
		{
			if (cb_isOnLine2 == null)
				cb_isOnLine2 = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsOnLine2);
			return cb_isOnLine2;
		}

		static bool n_IsOnLine2 (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mapbox.Services.Api.Utils.Turf.Models.LineIntersectsResult __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Services.Api.Utils.Turf.Models.LineIntersectsResult> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.OnLine2;
		}
#pragma warning restore 0169

		static Delegate cb_setOnLine2_Z;
#pragma warning disable 0169
		static Delegate GetSetOnLine2_ZHandler ()
		{
			if (cb_setOnLine2_Z == null)
				cb_setOnLine2_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetOnLine2_Z);
			return cb_setOnLine2_Z;
		}

		static void n_SetOnLine2_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Com.Mapbox.Services.Api.Utils.Turf.Models.LineIntersectsResult __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Services.Api.Utils.Turf.Models.LineIntersectsResult> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnLine2 = p0;
		}
#pragma warning restore 0169

		static IntPtr id_isOnLine2;
		static IntPtr id_setOnLine2_Z;
		public virtual unsafe bool OnLine2 {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.services.api.utils.turf.models']/class[@name='LineIntersectsResult']/method[@name='isOnLine2' and count(parameter)=0]"
			[Register ("isOnLine2", "()Z", "GetIsOnLine2Handler")]
			get {
				if (id_isOnLine2 == IntPtr.Zero)
					id_isOnLine2 = JNIEnv.GetMethodID (class_ref, "isOnLine2", "()Z");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isOnLine2);
					else
						return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isOnLine2", "()Z"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.services.api.utils.turf.models']/class[@name='LineIntersectsResult']/method[@name='setOnLine2' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setOnLine2", "(Z)V", "GetSetOnLine2_ZHandler")]
			set {
				if (id_setOnLine2_Z == IntPtr.Zero)
					id_setOnLine2_Z = JNIEnv.GetMethodID (class_ref, "setOnLine2", "(Z)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setOnLine2_Z, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setOnLine2", "(Z)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getX;
#pragma warning disable 0169
		static Delegate GetGetXHandler ()
		{
			if (cb_getX == null)
				cb_getX = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetX);
			return cb_getX;
		}

		static IntPtr n_GetX (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mapbox.Services.Api.Utils.Turf.Models.LineIntersectsResult __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Services.Api.Utils.Turf.Models.LineIntersectsResult> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.GetX ());
		}
#pragma warning restore 0169

		static IntPtr id_getX;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.services.api.utils.turf.models']/class[@name='LineIntersectsResult']/method[@name='getX' and count(parameter)=0]"
		[Register ("getX", "()Ljava/lang/Double;", "GetGetXHandler")]
		public virtual unsafe global::Java.Lang.Double GetX ()
		{
			if (id_getX == IntPtr.Zero)
				id_getX = JNIEnv.GetMethodID (class_ref, "getX", "()Ljava/lang/Double;");
			try {

				if (((object) this).GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Java.Lang.Double> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getX), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Java.Lang.Double> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getX", "()Ljava/lang/Double;")), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_getY;
#pragma warning disable 0169
		static Delegate GetGetYHandler ()
		{
			if (cb_getY == null)
				cb_getY = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetY);
			return cb_getY;
		}

		static IntPtr n_GetY (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mapbox.Services.Api.Utils.Turf.Models.LineIntersectsResult __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Services.Api.Utils.Turf.Models.LineIntersectsResult> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.GetY ());
		}
#pragma warning restore 0169

		static IntPtr id_getY;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.services.api.utils.turf.models']/class[@name='LineIntersectsResult']/method[@name='getY' and count(parameter)=0]"
		[Register ("getY", "()Ljava/lang/Double;", "GetGetYHandler")]
		public virtual unsafe global::Java.Lang.Double GetY ()
		{
			if (id_getY == IntPtr.Zero)
				id_getY = JNIEnv.GetMethodID (class_ref, "getY", "()Ljava/lang/Double;");
			try {

				if (((object) this).GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Java.Lang.Double> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getY), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Java.Lang.Double> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getY", "()Ljava/lang/Double;")), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_setX_Ljava_lang_Double_;
#pragma warning disable 0169
		static Delegate GetSetX_Ljava_lang_Double_Handler ()
		{
			if (cb_setX_Ljava_lang_Double_ == null)
				cb_setX_Ljava_lang_Double_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetX_Ljava_lang_Double_);
			return cb_setX_Ljava_lang_Double_;
		}

		static void n_SetX_Ljava_lang_Double_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Mapbox.Services.Api.Utils.Turf.Models.LineIntersectsResult __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Services.Api.Utils.Turf.Models.LineIntersectsResult> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Double p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Double> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetX (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setX_Ljava_lang_Double_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.services.api.utils.turf.models']/class[@name='LineIntersectsResult']/method[@name='setX' and count(parameter)=1 and parameter[1][@type='java.lang.Double']]"
		[Register ("setX", "(Ljava/lang/Double;)V", "GetSetX_Ljava_lang_Double_Handler")]
		public virtual unsafe void SetX (global::Java.Lang.Double p0)
		{
			if (id_setX_Ljava_lang_Double_ == IntPtr.Zero)
				id_setX_Ljava_lang_Double_ = JNIEnv.GetMethodID (class_ref, "setX", "(Ljava/lang/Double;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setX_Ljava_lang_Double_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setX", "(Ljava/lang/Double;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setY_Ljava_lang_Double_;
#pragma warning disable 0169
		static Delegate GetSetY_Ljava_lang_Double_Handler ()
		{
			if (cb_setY_Ljava_lang_Double_ == null)
				cb_setY_Ljava_lang_Double_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetY_Ljava_lang_Double_);
			return cb_setY_Ljava_lang_Double_;
		}

		static void n_SetY_Ljava_lang_Double_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Mapbox.Services.Api.Utils.Turf.Models.LineIntersectsResult __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Services.Api.Utils.Turf.Models.LineIntersectsResult> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Double p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Double> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetY (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setY_Ljava_lang_Double_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.services.api.utils.turf.models']/class[@name='LineIntersectsResult']/method[@name='setY' and count(parameter)=1 and parameter[1][@type='java.lang.Double']]"
		[Register ("setY", "(Ljava/lang/Double;)V", "GetSetY_Ljava_lang_Double_Handler")]
		public virtual unsafe void SetY (global::Java.Lang.Double p0)
		{
			if (id_setY_Ljava_lang_Double_ == IntPtr.Zero)
				id_setY_Ljava_lang_Double_ = JNIEnv.GetMethodID (class_ref, "setY", "(Ljava/lang/Double;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setY_Ljava_lang_Double_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setY", "(Ljava/lang/Double;)V"), __args);
			} finally {
			}
		}

	}
}
