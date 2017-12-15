using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Mapbox.Services.Api.Directions.V5.Models {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.mapbox.services.api.directions.v5.models']/class[@name='StepManeuver']"
	[global::Android.Runtime.Register ("com/mapbox/services/api/directions/v5/models/StepManeuver", DoNotGenerateAcw=true)]
	public partial class StepManeuver : global::Java.Lang.Object {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/mapbox/services/api/directions/v5/models/StepManeuver", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (StepManeuver); }
		}

		protected StepManeuver (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.mapbox.services.api.directions.v5.models']/class[@name='StepManeuver']/constructor[@name='StepManeuver' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe StepManeuver ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (StepManeuver)) {
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

		static IntPtr id_ctor_Ljava_lang_String_Ljava_lang_String_Ljava_lang_Integer_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.mapbox.services.api.directions.v5.models']/class[@name='StepManeuver']/constructor[@name='StepManeuver' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.Integer']]"
		[Register (".ctor", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/Integer;)V", "")]
		public unsafe StepManeuver (string p0, string p1, global::Java.Lang.Integer p2)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (p2);
				if (((object) this).GetType () != typeof (StepManeuver)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/Integer;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/Integer;)V", __args);
					return;
				}

				if (id_ctor_Ljava_lang_String_Ljava_lang_String_Ljava_lang_Integer_ == IntPtr.Zero)
					id_ctor_Ljava_lang_String_Ljava_lang_String_Ljava_lang_Integer_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/Integer;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_lang_String_Ljava_lang_String_Ljava_lang_Integer_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Ljava_lang_String_Ljava_lang_String_Ljava_lang_Integer_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static Delegate cb_getBearingAfter;
#pragma warning disable 0169
		static Delegate GetGetBearingAfterHandler ()
		{
			if (cb_getBearingAfter == null)
				cb_getBearingAfter = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, double>) n_GetBearingAfter);
			return cb_getBearingAfter;
		}

		static double n_GetBearingAfter (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mapbox.Services.Api.Directions.V5.Models.StepManeuver __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Services.Api.Directions.V5.Models.StepManeuver> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.BearingAfter;
		}
#pragma warning restore 0169

		static Delegate cb_setBearingAfter_D;
#pragma warning disable 0169
		static Delegate GetSetBearingAfter_DHandler ()
		{
			if (cb_setBearingAfter_D == null)
				cb_setBearingAfter_D = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, double>) n_SetBearingAfter_D);
			return cb_setBearingAfter_D;
		}

		static void n_SetBearingAfter_D (IntPtr jnienv, IntPtr native__this, double p0)
		{
			global::Com.Mapbox.Services.Api.Directions.V5.Models.StepManeuver __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Services.Api.Directions.V5.Models.StepManeuver> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.BearingAfter = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getBearingAfter;
		static IntPtr id_setBearingAfter_D;
		public virtual unsafe double BearingAfter {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.services.api.directions.v5.models']/class[@name='StepManeuver']/method[@name='getBearingAfter' and count(parameter)=0]"
			[Register ("getBearingAfter", "()D", "GetGetBearingAfterHandler")]
			get {
				if (id_getBearingAfter == IntPtr.Zero)
					id_getBearingAfter = JNIEnv.GetMethodID (class_ref, "getBearingAfter", "()D");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallDoubleMethod (((global::Java.Lang.Object) this).Handle, id_getBearingAfter);
					else
						return JNIEnv.CallNonvirtualDoubleMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getBearingAfter", "()D"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.services.api.directions.v5.models']/class[@name='StepManeuver']/method[@name='setBearingAfter' and count(parameter)=1 and parameter[1][@type='double']]"
			[Register ("setBearingAfter", "(D)V", "GetSetBearingAfter_DHandler")]
			set {
				if (id_setBearingAfter_D == IntPtr.Zero)
					id_setBearingAfter_D = JNIEnv.GetMethodID (class_ref, "setBearingAfter", "(D)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setBearingAfter_D, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setBearingAfter", "(D)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getBearingBefore;
#pragma warning disable 0169
		static Delegate GetGetBearingBeforeHandler ()
		{
			if (cb_getBearingBefore == null)
				cb_getBearingBefore = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, double>) n_GetBearingBefore);
			return cb_getBearingBefore;
		}

		static double n_GetBearingBefore (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mapbox.Services.Api.Directions.V5.Models.StepManeuver __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Services.Api.Directions.V5.Models.StepManeuver> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.BearingBefore;
		}
#pragma warning restore 0169

		static Delegate cb_setBearingBefore_D;
#pragma warning disable 0169
		static Delegate GetSetBearingBefore_DHandler ()
		{
			if (cb_setBearingBefore_D == null)
				cb_setBearingBefore_D = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, double>) n_SetBearingBefore_D);
			return cb_setBearingBefore_D;
		}

		static void n_SetBearingBefore_D (IntPtr jnienv, IntPtr native__this, double p0)
		{
			global::Com.Mapbox.Services.Api.Directions.V5.Models.StepManeuver __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Services.Api.Directions.V5.Models.StepManeuver> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.BearingBefore = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getBearingBefore;
		static IntPtr id_setBearingBefore_D;
		public virtual unsafe double BearingBefore {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.services.api.directions.v5.models']/class[@name='StepManeuver']/method[@name='getBearingBefore' and count(parameter)=0]"
			[Register ("getBearingBefore", "()D", "GetGetBearingBeforeHandler")]
			get {
				if (id_getBearingBefore == IntPtr.Zero)
					id_getBearingBefore = JNIEnv.GetMethodID (class_ref, "getBearingBefore", "()D");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallDoubleMethod (((global::Java.Lang.Object) this).Handle, id_getBearingBefore);
					else
						return JNIEnv.CallNonvirtualDoubleMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getBearingBefore", "()D"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.services.api.directions.v5.models']/class[@name='StepManeuver']/method[@name='setBearingBefore' and count(parameter)=1 and parameter[1][@type='double']]"
			[Register ("setBearingBefore", "(D)V", "GetSetBearingBefore_DHandler")]
			set {
				if (id_setBearingBefore_D == IntPtr.Zero)
					id_setBearingBefore_D = JNIEnv.GetMethodID (class_ref, "setBearingBefore", "(D)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setBearingBefore_D, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setBearingBefore", "(D)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getExit;
#pragma warning disable 0169
		static Delegate GetGetExitHandler ()
		{
			if (cb_getExit == null)
				cb_getExit = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetExit);
			return cb_getExit;
		}

		static IntPtr n_GetExit (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mapbox.Services.Api.Directions.V5.Models.StepManeuver __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Services.Api.Directions.V5.Models.StepManeuver> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Exit);
		}
#pragma warning restore 0169

		static Delegate cb_setExit_Ljava_lang_Integer_;
#pragma warning disable 0169
		static Delegate GetSetExit_Ljava_lang_Integer_Handler ()
		{
			if (cb_setExit_Ljava_lang_Integer_ == null)
				cb_setExit_Ljava_lang_Integer_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetExit_Ljava_lang_Integer_);
			return cb_setExit_Ljava_lang_Integer_;
		}

		static void n_SetExit_Ljava_lang_Integer_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Mapbox.Services.Api.Directions.V5.Models.StepManeuver __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Services.Api.Directions.V5.Models.StepManeuver> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Integer p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Integer> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Exit = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getExit;
		static IntPtr id_setExit_Ljava_lang_Integer_;
		public virtual unsafe global::Java.Lang.Integer Exit {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.services.api.directions.v5.models']/class[@name='StepManeuver']/method[@name='getExit' and count(parameter)=0]"
			[Register ("getExit", "()Ljava/lang/Integer;", "GetGetExitHandler")]
			get {
				if (id_getExit == IntPtr.Zero)
					id_getExit = JNIEnv.GetMethodID (class_ref, "getExit", "()Ljava/lang/Integer;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Java.Lang.Integer> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getExit), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Java.Lang.Integer> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getExit", "()Ljava/lang/Integer;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.services.api.directions.v5.models']/class[@name='StepManeuver']/method[@name='setExit' and count(parameter)=1 and parameter[1][@type='java.lang.Integer']]"
			[Register ("setExit", "(Ljava/lang/Integer;)V", "GetSetExit_Ljava_lang_Integer_Handler")]
			set {
				if (id_setExit_Ljava_lang_Integer_ == IntPtr.Zero)
					id_setExit_Ljava_lang_Integer_ = JNIEnv.GetMethodID (class_ref, "setExit", "(Ljava/lang/Integer;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setExit_Ljava_lang_Integer_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setExit", "(Ljava/lang/Integer;)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getInstruction;
#pragma warning disable 0169
		static Delegate GetGetInstructionHandler ()
		{
			if (cb_getInstruction == null)
				cb_getInstruction = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetInstruction);
			return cb_getInstruction;
		}

		static IntPtr n_GetInstruction (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mapbox.Services.Api.Directions.V5.Models.StepManeuver __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Services.Api.Directions.V5.Models.StepManeuver> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Instruction);
		}
#pragma warning restore 0169

		static Delegate cb_setInstruction_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetInstruction_Ljava_lang_String_Handler ()
		{
			if (cb_setInstruction_Ljava_lang_String_ == null)
				cb_setInstruction_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetInstruction_Ljava_lang_String_);
			return cb_setInstruction_Ljava_lang_String_;
		}

		static void n_SetInstruction_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Mapbox.Services.Api.Directions.V5.Models.StepManeuver __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Services.Api.Directions.V5.Models.StepManeuver> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Instruction = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getInstruction;
		static IntPtr id_setInstruction_Ljava_lang_String_;
		public virtual unsafe string Instruction {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.services.api.directions.v5.models']/class[@name='StepManeuver']/method[@name='getInstruction' and count(parameter)=0]"
			[Register ("getInstruction", "()Ljava/lang/String;", "GetGetInstructionHandler")]
			get {
				if (id_getInstruction == IntPtr.Zero)
					id_getInstruction = JNIEnv.GetMethodID (class_ref, "getInstruction", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getInstruction), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getInstruction", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.services.api.directions.v5.models']/class[@name='StepManeuver']/method[@name='setInstruction' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setInstruction", "(Ljava/lang/String;)V", "GetSetInstruction_Ljava_lang_String_Handler")]
			set {
				if (id_setInstruction_Ljava_lang_String_ == IntPtr.Zero)
					id_setInstruction_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setInstruction", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setInstruction_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setInstruction", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getModifier;
#pragma warning disable 0169
		static Delegate GetGetModifierHandler ()
		{
			if (cb_getModifier == null)
				cb_getModifier = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetModifier);
			return cb_getModifier;
		}

		static IntPtr n_GetModifier (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mapbox.Services.Api.Directions.V5.Models.StepManeuver __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Services.Api.Directions.V5.Models.StepManeuver> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Modifier);
		}
#pragma warning restore 0169

		static Delegate cb_setModifier_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetModifier_Ljava_lang_String_Handler ()
		{
			if (cb_setModifier_Ljava_lang_String_ == null)
				cb_setModifier_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetModifier_Ljava_lang_String_);
			return cb_setModifier_Ljava_lang_String_;
		}

		static void n_SetModifier_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Mapbox.Services.Api.Directions.V5.Models.StepManeuver __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Services.Api.Directions.V5.Models.StepManeuver> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Modifier = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getModifier;
		static IntPtr id_setModifier_Ljava_lang_String_;
		public virtual unsafe string Modifier {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.services.api.directions.v5.models']/class[@name='StepManeuver']/method[@name='getModifier' and count(parameter)=0]"
			[Register ("getModifier", "()Ljava/lang/String;", "GetGetModifierHandler")]
			get {
				if (id_getModifier == IntPtr.Zero)
					id_getModifier = JNIEnv.GetMethodID (class_ref, "getModifier", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getModifier), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getModifier", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.services.api.directions.v5.models']/class[@name='StepManeuver']/method[@name='setModifier' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setModifier", "(Ljava/lang/String;)V", "GetSetModifier_Ljava_lang_String_Handler")]
			set {
				if (id_setModifier_Ljava_lang_String_ == IntPtr.Zero)
					id_setModifier_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setModifier", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setModifier_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setModifier", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getType;
#pragma warning disable 0169
		static Delegate GetGetTypeHandler ()
		{
			if (cb_getType == null)
				cb_getType = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetType);
			return cb_getType;
		}

		static IntPtr n_GetType (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mapbox.Services.Api.Directions.V5.Models.StepManeuver __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Services.Api.Directions.V5.Models.StepManeuver> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Type);
		}
#pragma warning restore 0169

		static Delegate cb_setType_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetType_Ljava_lang_String_Handler ()
		{
			if (cb_setType_Ljava_lang_String_ == null)
				cb_setType_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetType_Ljava_lang_String_);
			return cb_setType_Ljava_lang_String_;
		}

		static void n_SetType_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Mapbox.Services.Api.Directions.V5.Models.StepManeuver __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Services.Api.Directions.V5.Models.StepManeuver> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Type = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getType;
		static IntPtr id_setType_Ljava_lang_String_;
		public virtual unsafe string Type {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.services.api.directions.v5.models']/class[@name='StepManeuver']/method[@name='getType' and count(parameter)=0]"
			[Register ("getType", "()Ljava/lang/String;", "GetGetTypeHandler")]
			get {
				if (id_getType == IntPtr.Zero)
					id_getType = JNIEnv.GetMethodID (class_ref, "getType", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getType), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getType", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.services.api.directions.v5.models']/class[@name='StepManeuver']/method[@name='setType' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setType", "(Ljava/lang/String;)V", "GetSetType_Ljava_lang_String_Handler")]
			set {
				if (id_setType_Ljava_lang_String_ == IntPtr.Zero)
					id_setType_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setType", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setType_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setType", "(Ljava/lang/String;)V"), __args);
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
			global::Com.Mapbox.Services.Api.Directions.V5.Models.StepManeuver __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Services.Api.Directions.V5.Models.StepManeuver> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.AsPosition ());
		}
#pragma warning restore 0169

		static IntPtr id_asPosition;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.services.api.directions.v5.models']/class[@name='StepManeuver']/method[@name='asPosition' and count(parameter)=0]"
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
			global::Com.Mapbox.Services.Api.Directions.V5.Models.StepManeuver __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Services.Api.Directions.V5.Models.StepManeuver> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetLocation ());
		}
#pragma warning restore 0169

		static IntPtr id_getLocation;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.services.api.directions.v5.models']/class[@name='StepManeuver']/method[@name='getLocation' and count(parameter)=0]"
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
			global::Com.Mapbox.Services.Api.Directions.V5.Models.StepManeuver __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Services.Api.Directions.V5.Models.StepManeuver> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			double[] p0 = (double[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (double));
			__this.SetLocation (p0);
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
		}
#pragma warning restore 0169

		static IntPtr id_setLocation_arrayD;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.services.api.directions.v5.models']/class[@name='StepManeuver']/method[@name='setLocation' and count(parameter)=1 and parameter[1][@type='double[]']]"
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
