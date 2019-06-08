using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Mapbox.Android.Gestures
{
    partial class AndroidGesturesManager
    {
        // Metadata.xml XPath constructor reference: path="/api/package[@name='com.mapbox.android.gestures']/class[@name='AndroidGesturesManager']/constructor[@name='AndroidGesturesManager' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.util.Set&lt;java.lang.Integer&gt;...']]"
        [Register(".ctor", "(Landroid/content/Context;[Ljava/util/Set;)V", "")]
        public unsafe AndroidGesturesManager(global::Android.Content.Context context, params global::System.Collections.Generic.ICollection<global::Java.Lang.Integer>[] exclusiveGestures)
            : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
        {
            const string __id = "(Landroid/content/Context;[Ljava/util/Set;)V";

            if (((global::Java.Lang.Object)this).Handle != IntPtr.Zero)
                return;

            IntPtr native_exclusiveGestures = JNIEnv.NewArray(exclusiveGestures);
            try
            {
                JniArgumentValue* __args = stackalloc JniArgumentValue[2];
                __args[0] = new JniArgumentValue((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object)context).Handle);
                __args[1] = new JniArgumentValue(native_exclusiveGestures);
                var __r = _members.InstanceMethods.StartCreateInstance(__id, ((object)this).GetType(), __args);
                SetHandle(__r.Handle, JniHandleOwnership.TransferLocalRef);
                _members.InstanceMethods.FinishCreateInstance(__id, this, __args);
            }
            finally
            {
                if (exclusiveGestures != null)
                {
                    JNIEnv.CopyArray(native_exclusiveGestures, exclusiveGestures);
                    JNIEnv.DeleteLocalRef(native_exclusiveGestures);
                }
            }
        }

        // Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.android.gestures']/class[@name='AndroidGesturesManager']/method[@name='setMutuallyExclusiveGestures' and count(parameter)=1 and parameter[1][@type='java.util.Set&lt;java.lang.Integer&gt;...']]"
        [Register("setMutuallyExclusiveGestures", "([Ljava/util/Set;)V", "")]
        public unsafe void SetMutuallyExclusiveGestures(params global::System.Collections.Generic.ICollection<global::Java.Lang.Integer>[] exclusiveGestures)
        {
            const string __id = "setMutuallyExclusiveGestures.([Ljava/util/Set;)V";
            IntPtr native_exclusiveGestures = JNIEnv.NewArray(exclusiveGestures);
            try
            {
                JniArgumentValue* __args = stackalloc JniArgumentValue[1];
                __args[0] = new JniArgumentValue(native_exclusiveGestures);
                _members.InstanceMethods.InvokeNonvirtualVoidMethod(__id, this, __args);
            }
            finally
            {
                if (exclusiveGestures != null)
                {
                    JNIEnv.CopyArray(native_exclusiveGestures, exclusiveGestures);
                    JNIEnv.DeleteLocalRef(native_exclusiveGestures);
                }
            }
        }

    }
}