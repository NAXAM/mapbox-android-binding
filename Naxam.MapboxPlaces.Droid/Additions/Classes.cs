using System;
using Android.Runtime;
using Android.Support.V7.Widget;
using Android.Views;
using Java.Interop;

namespace Com.Mapbox.Mapboxsdk.Plugins.Places.Autocomplete.UI
{
    public partial class SearchResultAdapter : RecyclerView.Adapter
    {
        static Delegate cb_onBindViewHolder_Landroid_view_ViewGroup_I;
#pragma warning disable 0169
        static Delegate GetonBindViewHolder_Landroid_view_ViewGroup_IHandler()
        {
            if (cb_onBindViewHolder_Landroid_view_ViewGroup_I == null)
                cb_onBindViewHolder_Landroid_view_ViewGroup_I = JNINativeWrapper.CreateDelegate((Action<IntPtr, IntPtr, IntPtr, int>)n_onBindViewHolder_Landroid_view_ViewGroup_I);
            return cb_onBindViewHolder_Landroid_view_ViewGroup_I;
        }

        static void n_onBindViewHolder_Landroid_view_ViewGroup_I(IntPtr jnienv, IntPtr native__this, IntPtr native_parent, int viewType)
        {
            SearchResultAdapter __this = GetObject<SearchResultAdapter>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
            var viewHolder = GetObject<RecyclerView.ViewHolder>(native_parent, JniHandleOwnership.DoNotTransfer);
            __this.OnBindViewHolder(viewHolder, viewType);
        }
#pragma warning restore 0169

        // Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.plugins.places.autocomplete.ui']/class[@name='SearchResultAdapter']/method[@name='onBindViewHolder' and count(parameter)=2 and parameter[1][@type='android.view.ViewGroup'] and parameter[2][@type='int']]"
        [Register("onBindViewHolder", "(Lcom/mapbox/mapboxsdk/plugins/places/autocomplete/ui/SearchResultAdapter$SearchViewHolder;I)V", "GetonBindViewHolder_Landroid_view_ViewGroup_IHandler")]
        public unsafe void OnBindViewHolder(SearchViewHolder viewHolder, int position)
        {
            const string __id = "onBindViewHolder.(Landroid/support/v7/widget/RecyclerView$ViewHolder;I)V";
            try {
                JniArgumentValue* __args = stackalloc JniArgumentValue[2];
                __args[0] = new JniArgumentValue((viewHolder == null) ? IntPtr.Zero : viewHolder.Handle);
                __args[1] = new JniArgumentValue(position);
                _members.InstanceMethods.InvokeVirtualVoidMethod(__id, this, __args);
            }
            finally {
            }
        }

        public override unsafe void OnBindViewHolder(RecyclerView.ViewHolder holder, int position)
        {
            OnBindViewHolder(holder as SearchViewHolder, position);
        }
    }
}
