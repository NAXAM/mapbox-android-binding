using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Mapbox.Services.Api.Utils.Tidy {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.mapbox.services.api.utils.tidy']/class[@name='Tidy']"
	[global::Android.Runtime.Register ("com/mapbox/services/api/utils/tidy/Tidy", DoNotGenerateAcw=true)]
	public partial class Tidy : global::Java.Lang.Object {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.mapbox.services.api.utils.tidy']/class[@name='Tidy']/field[@name='KEY_COORD_TIMES']"
		[Register ("KEY_COORD_TIMES")]
		public const string KeyCoordTimes = (string) "coordTimes";
		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/mapbox/services/api/utils/tidy/Tidy", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (Tidy); }
		}

		protected Tidy (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.mapbox.services.api.utils.tidy']/class[@name='Tidy']/constructor[@name='Tidy' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe Tidy ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (Tidy)) {
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
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.mapbox.services.api.utils.tidy']/class[@name='Tidy']/constructor[@name='Tidy' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
		[Register (".ctor", "(III)V", "")]
		public unsafe Tidy (int p0, int p1, int p2)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				if (((object) this).GetType () != typeof (Tidy)) {
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

		static Delegate cb_getDateFormat;
#pragma warning disable 0169
		static Delegate GetGetDateFormatHandler ()
		{
			if (cb_getDateFormat == null)
				cb_getDateFormat = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetDateFormat);
			return cb_getDateFormat;
		}

		static IntPtr n_GetDateFormat (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mapbox.Services.Api.Utils.Tidy.Tidy __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Services.Api.Utils.Tidy.Tidy> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.DateFormat);
		}
#pragma warning restore 0169

		static Delegate cb_setDateFormat_Ljava_text_SimpleDateFormat_;
#pragma warning disable 0169
		static Delegate GetSetDateFormat_Ljava_text_SimpleDateFormat_Handler ()
		{
			if (cb_setDateFormat_Ljava_text_SimpleDateFormat_ == null)
				cb_setDateFormat_Ljava_text_SimpleDateFormat_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetDateFormat_Ljava_text_SimpleDateFormat_);
			return cb_setDateFormat_Ljava_text_SimpleDateFormat_;
		}

		static void n_SetDateFormat_Ljava_text_SimpleDateFormat_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Mapbox.Services.Api.Utils.Tidy.Tidy __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Services.Api.Utils.Tidy.Tidy> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Text.SimpleDateFormat p0 = global::Java.Lang.Object.GetObject<global::Java.Text.SimpleDateFormat> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.DateFormat = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getDateFormat;
		static IntPtr id_setDateFormat_Ljava_text_SimpleDateFormat_;
		public virtual unsafe global::Java.Text.SimpleDateFormat DateFormat {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.services.api.utils.tidy']/class[@name='Tidy']/method[@name='getDateFormat' and count(parameter)=0]"
			[Register ("getDateFormat", "()Ljava/text/SimpleDateFormat;", "GetGetDateFormatHandler")]
			get {
				if (id_getDateFormat == IntPtr.Zero)
					id_getDateFormat = JNIEnv.GetMethodID (class_ref, "getDateFormat", "()Ljava/text/SimpleDateFormat;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Java.Text.SimpleDateFormat> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getDateFormat), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Java.Text.SimpleDateFormat> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getDateFormat", "()Ljava/text/SimpleDateFormat;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.services.api.utils.tidy']/class[@name='Tidy']/method[@name='setDateFormat' and count(parameter)=1 and parameter[1][@type='java.text.SimpleDateFormat']]"
			[Register ("setDateFormat", "(Ljava/text/SimpleDateFormat;)V", "GetSetDateFormat_Ljava_text_SimpleDateFormat_Handler")]
			set {
				if (id_setDateFormat_Ljava_text_SimpleDateFormat_ == IntPtr.Zero)
					id_setDateFormat_Ljava_text_SimpleDateFormat_ = JNIEnv.GetMethodID (class_ref, "setDateFormat", "(Ljava/text/SimpleDateFormat;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setDateFormat_Ljava_text_SimpleDateFormat_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setDateFormat", "(Ljava/text/SimpleDateFormat;)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getMaximumPoints;
#pragma warning disable 0169
		static Delegate GetGetMaximumPointsHandler ()
		{
			if (cb_getMaximumPoints == null)
				cb_getMaximumPoints = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetMaximumPoints);
			return cb_getMaximumPoints;
		}

		static int n_GetMaximumPoints (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mapbox.Services.Api.Utils.Tidy.Tidy __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Services.Api.Utils.Tidy.Tidy> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.MaximumPoints;
		}
#pragma warning restore 0169

		static Delegate cb_setMaximumPoints_I;
#pragma warning disable 0169
		static Delegate GetSetMaximumPoints_IHandler ()
		{
			if (cb_setMaximumPoints_I == null)
				cb_setMaximumPoints_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetMaximumPoints_I);
			return cb_setMaximumPoints_I;
		}

		static void n_SetMaximumPoints_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Mapbox.Services.Api.Utils.Tidy.Tidy __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Services.Api.Utils.Tidy.Tidy> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.MaximumPoints = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getMaximumPoints;
		static IntPtr id_setMaximumPoints_I;
		public virtual unsafe int MaximumPoints {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.services.api.utils.tidy']/class[@name='Tidy']/method[@name='getMaximumPoints' and count(parameter)=0]"
			[Register ("getMaximumPoints", "()I", "GetGetMaximumPointsHandler")]
			get {
				if (id_getMaximumPoints == IntPtr.Zero)
					id_getMaximumPoints = JNIEnv.GetMethodID (class_ref, "getMaximumPoints", "()I");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getMaximumPoints);
					else
						return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getMaximumPoints", "()I"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.services.api.utils.tidy']/class[@name='Tidy']/method[@name='setMaximumPoints' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setMaximumPoints", "(I)V", "GetSetMaximumPoints_IHandler")]
			set {
				if (id_setMaximumPoints_I == IntPtr.Zero)
					id_setMaximumPoints_I = JNIEnv.GetMethodID (class_ref, "setMaximumPoints", "(I)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setMaximumPoints_I, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setMaximumPoints", "(I)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getMinimumDistance;
#pragma warning disable 0169
		static Delegate GetGetMinimumDistanceHandler ()
		{
			if (cb_getMinimumDistance == null)
				cb_getMinimumDistance = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetMinimumDistance);
			return cb_getMinimumDistance;
		}

		static int n_GetMinimumDistance (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mapbox.Services.Api.Utils.Tidy.Tidy __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Services.Api.Utils.Tidy.Tidy> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.MinimumDistance;
		}
#pragma warning restore 0169

		static Delegate cb_setMinimumDistance_I;
#pragma warning disable 0169
		static Delegate GetSetMinimumDistance_IHandler ()
		{
			if (cb_setMinimumDistance_I == null)
				cb_setMinimumDistance_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetMinimumDistance_I);
			return cb_setMinimumDistance_I;
		}

		static void n_SetMinimumDistance_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Mapbox.Services.Api.Utils.Tidy.Tidy __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Services.Api.Utils.Tidy.Tidy> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.MinimumDistance = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getMinimumDistance;
		static IntPtr id_setMinimumDistance_I;
		public virtual unsafe int MinimumDistance {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.services.api.utils.tidy']/class[@name='Tidy']/method[@name='getMinimumDistance' and count(parameter)=0]"
			[Register ("getMinimumDistance", "()I", "GetGetMinimumDistanceHandler")]
			get {
				if (id_getMinimumDistance == IntPtr.Zero)
					id_getMinimumDistance = JNIEnv.GetMethodID (class_ref, "getMinimumDistance", "()I");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getMinimumDistance);
					else
						return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getMinimumDistance", "()I"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.services.api.utils.tidy']/class[@name='Tidy']/method[@name='setMinimumDistance' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setMinimumDistance", "(I)V", "GetSetMinimumDistance_IHandler")]
			set {
				if (id_setMinimumDistance_I == IntPtr.Zero)
					id_setMinimumDistance_I = JNIEnv.GetMethodID (class_ref, "setMinimumDistance", "(I)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setMinimumDistance_I, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setMinimumDistance", "(I)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getMinimumTime;
#pragma warning disable 0169
		static Delegate GetGetMinimumTimeHandler ()
		{
			if (cb_getMinimumTime == null)
				cb_getMinimumTime = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetMinimumTime);
			return cb_getMinimumTime;
		}

		static int n_GetMinimumTime (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mapbox.Services.Api.Utils.Tidy.Tidy __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Services.Api.Utils.Tidy.Tidy> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.MinimumTime;
		}
#pragma warning restore 0169

		static Delegate cb_setMinimumTime_I;
#pragma warning disable 0169
		static Delegate GetSetMinimumTime_IHandler ()
		{
			if (cb_setMinimumTime_I == null)
				cb_setMinimumTime_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetMinimumTime_I);
			return cb_setMinimumTime_I;
		}

		static void n_SetMinimumTime_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Mapbox.Services.Api.Utils.Tidy.Tidy __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Services.Api.Utils.Tidy.Tidy> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.MinimumTime = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getMinimumTime;
		static IntPtr id_setMinimumTime_I;
		public virtual unsafe int MinimumTime {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.services.api.utils.tidy']/class[@name='Tidy']/method[@name='getMinimumTime' and count(parameter)=0]"
			[Register ("getMinimumTime", "()I", "GetGetMinimumTimeHandler")]
			get {
				if (id_getMinimumTime == IntPtr.Zero)
					id_getMinimumTime = JNIEnv.GetMethodID (class_ref, "getMinimumTime", "()I");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getMinimumTime);
					else
						return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getMinimumTime", "()I"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.services.api.utils.tidy']/class[@name='Tidy']/method[@name='setMinimumTime' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setMinimumTime", "(I)V", "GetSetMinimumTime_IHandler")]
			set {
				if (id_setMinimumTime_I == IntPtr.Zero)
					id_setMinimumTime_I = JNIEnv.GetMethodID (class_ref, "setMinimumTime", "(I)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setMinimumTime_I, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setMinimumTime", "(I)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_execute_Lcom_mapbox_services_commons_geojson_FeatureCollection_;
#pragma warning disable 0169
		static Delegate GetExecute_Lcom_mapbox_services_commons_geojson_FeatureCollection_Handler ()
		{
			if (cb_execute_Lcom_mapbox_services_commons_geojson_FeatureCollection_ == null)
				cb_execute_Lcom_mapbox_services_commons_geojson_FeatureCollection_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_Execute_Lcom_mapbox_services_commons_geojson_FeatureCollection_);
			return cb_execute_Lcom_mapbox_services_commons_geojson_FeatureCollection_;
		}

		static IntPtr n_Execute_Lcom_mapbox_services_commons_geojson_FeatureCollection_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Mapbox.Services.Api.Utils.Tidy.Tidy __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Services.Api.Utils.Tidy.Tidy> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Mapbox.Services.Commons.Geojson.FeatureCollection p0 = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Services.Commons.Geojson.FeatureCollection> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Execute (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_execute_Lcom_mapbox_services_commons_geojson_FeatureCollection_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.services.api.utils.tidy']/class[@name='Tidy']/method[@name='execute' and count(parameter)=1 and parameter[1][@type='com.mapbox.services.commons.geojson.FeatureCollection']]"
		[Register ("execute", "(Lcom/mapbox/services/commons/geojson/FeatureCollection;)Lcom/mapbox/services/commons/geojson/FeatureCollection;", "GetExecute_Lcom_mapbox_services_commons_geojson_FeatureCollection_Handler")]
		public virtual unsafe global::Com.Mapbox.Services.Commons.Geojson.FeatureCollection Execute (global::Com.Mapbox.Services.Commons.Geojson.FeatureCollection p0)
		{
			if (id_execute_Lcom_mapbox_services_commons_geojson_FeatureCollection_ == IntPtr.Zero)
				id_execute_Lcom_mapbox_services_commons_geojson_FeatureCollection_ = JNIEnv.GetMethodID (class_ref, "execute", "(Lcom/mapbox/services/commons/geojson/FeatureCollection;)Lcom/mapbox/services/commons/geojson/FeatureCollection;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				global::Com.Mapbox.Services.Commons.Geojson.FeatureCollection __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Services.Commons.Geojson.FeatureCollection> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_execute_Lcom_mapbox_services_commons_geojson_FeatureCollection_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Services.Commons.Geojson.FeatureCollection> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "execute", "(Lcom/mapbox/services/commons/geojson/FeatureCollection;)Lcom/mapbox/services/commons/geojson/FeatureCollection;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

	}
}
