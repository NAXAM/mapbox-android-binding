using System;
using Android.Runtime;

namespace Com.Mapbox.Mapboxsdk.Annotations
{
	public partial class Marker
	{
		public override int CompareTo(Java.Lang.Object obj)
		{
			return CompareTo((Marker)obj);
		}
	}

	public partial class Polygon
	{
		public override int CompareTo(Java.Lang.Object obj)
		{
			return CompareTo((Polygon)obj);
		}
	}

	public partial class Polyline
	{
		public override int CompareTo(Java.Lang.Object obj)
		{
			return CompareTo((Polyline)obj);
		}
	}

	public partial class MarkerOptions
	{
		protected override Java.Lang.Object RawMarker
		{
			get { return Marker; }
		}

		protected override Java.Lang.Object RawThis
		{
			get { return This; }
		}
	}


	public partial class MarkerViewOptions
	{
		protected override Java.Lang.Object RawMarker
		{
			get { return Marker; }
		}

		protected override Java.Lang.Object RawThis
		{
			get { return This; }
		}
	}

    partial class PolygonOptions {

		static IntPtr id_addHole_arrayLjava_util_List_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.annotations']/class[@name='PolygonOptions']/method[@name='addHole' and count(parameter)=1 and parameter[1][@type='java.util.List&lt;com.mapbox.mapboxsdk.geometry.LatLng&gt;...']]"
		[Register("addHole", "([Ljava/util/List;)Lcom/mapbox/mapboxsdk/annotations/PolygonOptions;", "")]
		public unsafe global::Com.Mapbox.Mapboxsdk.Annotations.PolygonOptions AddHole(params global::System.Collections.Generic.IList<global::Com.Mapbox.Mapboxsdk.Geometry.LatLng>[] p0)
		{
			if (id_addHole_arrayLjava_util_List_ == IntPtr.Zero)
				id_addHole_arrayLjava_util_List_ = JNIEnv.GetMethodID(class_ref, "addHole", "([Ljava/util/List;)Lcom/mapbox/mapboxsdk/annotations/PolygonOptions;");
			IntPtr native_p0 = JNIEnv.NewArray(p0);
			try
			{
				JValue* __args = stackalloc JValue[1];
				__args[0] = new JValue(native_p0);
				global::Com.Mapbox.Mapboxsdk.Annotations.PolygonOptions __ret = Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Annotations.PolygonOptions>(JNIEnv.CallObjectMethod(((global::Java.Lang.Object)this).Handle, id_addHole_arrayLjava_util_List_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			}
			finally
			{
				if (p0 != null)
				{
					JNIEnv.CopyArray(native_p0, p0);
					JNIEnv.DeleteLocalRef(native_p0);
				}
			}
		}

	}
}
