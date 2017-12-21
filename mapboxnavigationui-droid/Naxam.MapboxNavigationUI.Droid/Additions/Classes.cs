using Android.Support.V7.Widget;
using Android.Views;
using RecyclerViewAdapter = Android.Support.V7.Widget.RecyclerView.Adapter;
using AndroidRuntime = Android.Runtime;
using ARE = Android.Runtime.Extensions;
using Android.OS;
using Java.Lang;

namespace Com.Mapbox.Services.Android.Navigation.UI.V5.Feedback
{

}

namespace Com.Mapbox.Services.Android.Navigation.UI.V5.Voice.Polly
{
    partial class InstructionTask : AsyncTask
    {
        protected override unsafe Java.Lang.Object DoInBackground(params Object[] parameters)
        {
            var jarray = AndroidRuntime.JavaArray<Object>.FromArray<Object>(parameters);

            var result = DoInBackground(AndroidRuntime.JNIEnv.GetArray<string>(jarray.Handle));

            return new Java.Lang.String(result);
        }
    }
}