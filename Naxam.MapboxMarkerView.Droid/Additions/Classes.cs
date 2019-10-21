using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Mapbox.Mapboxsdk.Plugins.Markerview
{
    partial class MarkerView : global::Java.Lang.Object
    {

        // Metadata.xml XPath interface reference: path="/api/package[@name='com.mapbox.mapboxsdk.plugins.markerview']/interface[@name='MarkerView.OnPositionUpdateListener']"
        [Register("com/mapbox/mapboxsdk/plugins/markerview/MarkerView$OnPositionUpdateListener", "", "Com.Mapbox.Mapboxsdk.Plugins.Markerview.MarkerView/IOnPositionUpdateListenerInvoker")]
        public partial interface IOnPositionUpdateListener : IJavaObject
        {

            // Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.plugins.markerview']/interface[@name='MarkerView.OnPositionUpdateListener']/method[@name='onUpdate' and count(parameter)=1 and parameter[1][@type='android.graphics.PointF']]"
            [Register("onUpdate", "(Landroid/graphics/PointF;)Landroid/graphics/PointF;", "GetOnUpdate_Landroid_graphics_PointF_Handler:Com.Mapbox.Mapboxsdk.Plugins.Markerview.MarkerView/IOnPositionUpdateListenerInvoker, Naxam.MapboxMarkerView.Droid")]
            global::Android.Graphics.PointF OnUpdate(global::Android.Graphics.PointF p0);

        }

        [global::Android.Runtime.Register("com/mapbox/mapboxsdk/plugins/markerview/MarkerView$OnPositionUpdateListener", DoNotGenerateAcw = true)]
        internal class IOnPositionUpdateListenerInvoker : global::Java.Lang.Object, IOnPositionUpdateListener
        {

            internal new static readonly JniPeerMembers _members = new JniPeerMembers("com/mapbox/mapboxsdk/plugins/markerview/MarkerView$OnPositionUpdateListener", typeof(IOnPositionUpdateListenerInvoker));

            static IntPtr java_class_ref
            {
                get { return _members.JniPeerType.PeerReference.Handle; }
            }

            public override global::Java.Interop.JniPeerMembers JniPeerMembers
            {
                get { return _members; }
            }

            protected override IntPtr ThresholdClass
            {
                get { return class_ref; }
            }

            protected override global::System.Type ThresholdType
            {
                get { return _members.ManagedPeerType; }
            }

            IntPtr class_ref;

            public static IOnPositionUpdateListener GetObject(IntPtr handle, JniHandleOwnership transfer)
            {
                return global::Java.Lang.Object.GetObject<IOnPositionUpdateListener>(handle, transfer);
            }

            static IntPtr Validate(IntPtr handle)
            {
                if (!JNIEnv.IsInstanceOf(handle, java_class_ref))
                    throw new InvalidCastException(string.Format("Unable to convert instance of type '{0}' to type '{1}'.",
                                JNIEnv.GetClassNameFromInstance(handle), "com.mapbox.mapboxsdk.plugins.markerview.MarkerView.OnPositionUpdateListener"));
                return handle;
            }

            protected override void Dispose(bool disposing)
            {
                if (this.class_ref != IntPtr.Zero)
                    JNIEnv.DeleteGlobalRef(this.class_ref);
                this.class_ref = IntPtr.Zero;
                base.Dispose(disposing);
            }

            public IOnPositionUpdateListenerInvoker(IntPtr handle, JniHandleOwnership transfer) : base(Validate(handle), transfer)
            {
                IntPtr local_ref = JNIEnv.GetObjectClass(((global::Java.Lang.Object)this).Handle);
                this.class_ref = JNIEnv.NewGlobalRef(local_ref);
                JNIEnv.DeleteLocalRef(local_ref);
            }

            static Delegate cb_onUpdate_Landroid_graphics_PointF_;
#pragma warning disable 0169
            static Delegate GetOnUpdate_Landroid_graphics_PointF_Handler()
            {
                if (cb_onUpdate_Landroid_graphics_PointF_ == null)
                    cb_onUpdate_Landroid_graphics_PointF_ = JNINativeWrapper.CreateDelegate((Func<IntPtr, IntPtr, IntPtr, IntPtr>)n_OnUpdate_Landroid_graphics_PointF_);
                return cb_onUpdate_Landroid_graphics_PointF_;
            }

            static IntPtr n_OnUpdate_Landroid_graphics_PointF_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
            {
                global::Com.Mapbox.Mapboxsdk.Plugins.Markerview.MarkerView.IOnPositionUpdateListener __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Plugins.Markerview.MarkerView.IOnPositionUpdateListener>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
                global::Android.Graphics.PointF p0 = global::Java.Lang.Object.GetObject<global::Android.Graphics.PointF>(native_p0, JniHandleOwnership.DoNotTransfer);
                IntPtr __ret = JNIEnv.ToLocalJniHandle(__this.OnUpdate(p0));
                return __ret;
            }
#pragma warning restore 0169

            IntPtr id_onUpdate_Landroid_graphics_PointF_;
            public unsafe global::Android.Graphics.PointF OnUpdate(global::Android.Graphics.PointF p0)
            {
                if (id_onUpdate_Landroid_graphics_PointF_ == IntPtr.Zero)
                    id_onUpdate_Landroid_graphics_PointF_ = JNIEnv.GetMethodID(class_ref, "onUpdate", "(Landroid/graphics/PointF;)Landroid/graphics/PointF;");
                JValue* __args = stackalloc JValue[1];
                __args[0] = new JValue((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object)p0).Handle);
                global::Android.Graphics.PointF __ret = global::Java.Lang.Object.GetObject<global::Android.Graphics.PointF>(JNIEnv.CallObjectMethod(((global::Java.Lang.Object)this).Handle, id_onUpdate_Landroid_graphics_PointF_, __args), JniHandleOwnership.TransferLocalRef);
                return __ret;
            }

        }

        public delegate global::Android.Graphics.PointF PositionUpdateHandler(global::Android.Graphics.PointF p0);

        [global::Android.Runtime.Register("mono/com/mapbox/mapboxsdk/plugins/markerview/MarkerView_OnPositionUpdateListenerImplementor")]
        internal sealed partial class IOnPositionUpdateListenerImplementor : global::Java.Lang.Object, IOnPositionUpdateListener
        {

            public IOnPositionUpdateListenerImplementor()
                : base(
                    global::Android.Runtime.JNIEnv.StartCreateInstance("mono/com/mapbox/mapboxsdk/plugins/markerview/MarkerView_OnPositionUpdateListenerImplementor", "()V"),
                    JniHandleOwnership.TransferLocalRef)
            {
                global::Android.Runtime.JNIEnv.FinishCreateInstance(((global::Java.Lang.Object)this).Handle, "()V");
            }

#pragma warning disable 0649
            public PositionUpdateHandler Handler;
#pragma warning restore 0649

            public global::Android.Graphics.PointF OnUpdate(global::Android.Graphics.PointF p0)
            {
                var __h = Handler;
                return __h != null ? __h(p0) : default(global::Android.Graphics.PointF);
            }

            internal static bool __IsEmpty(IOnPositionUpdateListenerImplementor value)
            {
                return value.Handler == null;
            }
        }

        static Delegate cb_setOnPositionUpdateListener_Lcom_mapbox_mapboxsdk_plugins_markerview_MarkerView_OnPositionUpdateListener_;
#pragma warning disable 0169
        static Delegate GetSetOnPositionUpdateListener_Lcom_mapbox_mapboxsdk_plugins_markerview_MarkerView_OnPositionUpdateListener_Handler()
        {
            if (cb_setOnPositionUpdateListener_Lcom_mapbox_mapboxsdk_plugins_markerview_MarkerView_OnPositionUpdateListener_ == null)
                cb_setOnPositionUpdateListener_Lcom_mapbox_mapboxsdk_plugins_markerview_MarkerView_OnPositionUpdateListener_ = JNINativeWrapper.CreateDelegate((Action<IntPtr, IntPtr, IntPtr>)n_SetOnPositionUpdateListener_Lcom_mapbox_mapboxsdk_plugins_markerview_MarkerView_OnPositionUpdateListener_);
            return cb_setOnPositionUpdateListener_Lcom_mapbox_mapboxsdk_plugins_markerview_MarkerView_OnPositionUpdateListener_;
        }

        static void n_SetOnPositionUpdateListener_Lcom_mapbox_mapboxsdk_plugins_markerview_MarkerView_OnPositionUpdateListener_(IntPtr jnienv, IntPtr native__this, IntPtr native_onPositionUpdateListener)
        {
            global::Com.Mapbox.Mapboxsdk.Plugins.Markerview.MarkerView __this = global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Plugins.Markerview.MarkerView>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
            global::Com.Mapbox.Mapboxsdk.Plugins.Markerview.MarkerView.IOnPositionUpdateListener onPositionUpdateListener = (global::Com.Mapbox.Mapboxsdk.Plugins.Markerview.MarkerView.IOnPositionUpdateListener)global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Plugins.Markerview.MarkerView.IOnPositionUpdateListener>(native_onPositionUpdateListener, JniHandleOwnership.DoNotTransfer);
            __this.SetOnPositionUpdateListener(onPositionUpdateListener);
        }
#pragma warning restore 0169

        // Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.plugins.markerview']/class[@name='MarkerView']/method[@name='setOnPositionUpdateListener' and count(parameter)=1 and parameter[1][@type='com.mapbox.mapboxsdk.plugins.markerview.MarkerView.OnPositionUpdateListener']]"
        [Register("setOnPositionUpdateListener", "(Lcom/mapbox/mapboxsdk/plugins/markerview/MarkerView$OnPositionUpdateListener;)V", "GetSetOnPositionUpdateListener_Lcom_mapbox_mapboxsdk_plugins_markerview_MarkerView_OnPositionUpdateListener_Handler")]
        public virtual unsafe void SetOnPositionUpdateListener(global::Com.Mapbox.Mapboxsdk.Plugins.Markerview.MarkerView.IOnPositionUpdateListener onPositionUpdateListener)
        {
            const string __id = "setOnPositionUpdateListener.(Lcom/mapbox/mapboxsdk/plugins/markerview/MarkerView$OnPositionUpdateListener;)V";
            try {
                JniArgumentValue* __args = stackalloc JniArgumentValue[1];
                __args[0] = new JniArgumentValue((onPositionUpdateListener == null) ? IntPtr.Zero : ((global::Java.Lang.Object)onPositionUpdateListener).Handle);
                _members.InstanceMethods.InvokeVirtualVoidMethod(__id, this, __args);
            }
            finally {
            }
        }

        #region "Event implementation for Com.Mapbox.Mapboxsdk.Plugins.Markerview.MarkerView.IOnPositionUpdateListener"
        WeakReference weak_implementor_PositionUpdate;
        global::Com.Mapbox.Mapboxsdk.Plugins.Markerview.MarkerView.IOnPositionUpdateListenerImplementor ImplPositionUpdate
        {
            get
            {
                if (weak_implementor_PositionUpdate == null || !weak_implementor_PositionUpdate.IsAlive)
                    return null;
                return weak_implementor_PositionUpdate.Target as global::Com.Mapbox.Mapboxsdk.Plugins.Markerview.MarkerView.IOnPositionUpdateListenerImplementor;
            }
            set { weak_implementor_PositionUpdate = new WeakReference(value, true); }
        }

        public global::Com.Mapbox.Mapboxsdk.Plugins.Markerview.MarkerView.PositionUpdateHandler PositionUpdate
        {
            get
            {
                global::Com.Mapbox.Mapboxsdk.Plugins.Markerview.MarkerView.IOnPositionUpdateListenerImplementor impl = ImplPositionUpdate;
                return impl == null ? null : impl.Handler;
            }
            set
            {
                global::Com.Mapbox.Mapboxsdk.Plugins.Markerview.MarkerView.IOnPositionUpdateListenerImplementor impl = ImplPositionUpdate;
                if (impl == null) {
                    impl = new global::Com.Mapbox.Mapboxsdk.Plugins.Markerview.MarkerView.IOnPositionUpdateListenerImplementor();
                    ImplPositionUpdate = impl;
                }
                else
                    impl.Handler = value;
            }
        }

        WeakReference weak_implementor_SetOnPositionUpdateListener;

        global::Com.Mapbox.Mapboxsdk.Plugins.Markerview.MarkerView.IOnPositionUpdateListenerImplementor __CreateIOnPositionUpdateListenerImplementor()
        {
            return new global::Com.Mapbox.Mapboxsdk.Plugins.Markerview.MarkerView.IOnPositionUpdateListenerImplementor();
        }
        #endregion
    }
}
