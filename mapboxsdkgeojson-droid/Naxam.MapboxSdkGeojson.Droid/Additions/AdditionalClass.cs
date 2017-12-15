using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using GoogleGson;
using Java.Lang.Reflect;


namespace Com.Mapbox.Geojson.Gson
{
    public partial class BoundingBoxDeserializer
    {
        public Java.Lang.Object Deserialize(JsonElement p0, IType p1, IJsonDeserializationContext p2)
        {
            return GeojsonDeserialize(p0, p1, p2);
        }

    }

    public partial class GeometryDeserializer
    {
        public Java.Lang.Object Deserialize(JsonElement p0, IType p1, IJsonDeserializationContext p2)
        {
            var result = GeometryDeserialize(p0, p1, p2);

            return Android.Runtime.Extensions.JavaCast<Java.Lang.Object>(result);
        }

    }

    public partial class PointDeserializer
    {
        public Java.Lang.Object Deserialize(JsonElement p0, IType p1, IJsonDeserializationContext p2)
        {
            return PointDeserialize(p0, p1, p2);
        }

    }

    public partial class BoundingBoxSerializer
    {
        public JsonElement Serialize(Java.Lang.Object p0, IType p1, IJsonSerializationContext p2)
        {

            return Serialize((Com.Mapbox.Geojson.BoundingBox)p0, p1, p2);
        }

    }

    public partial class PointSerializer
    {
        public JsonElement Serialize(Java.Lang.Object p0, IType p1, IJsonSerializationContext p2)
        {
            return Serialize((Com.Mapbox.Geojson.Point)p0, p1, p2);
        }
    }


}
namespace Com.Mapbox.Geojson
{
    public abstract partial class LineString : IGeometry
    {
        global::Java.Lang.Object global::Com.Mapbox.Geojson.IGeometry.Coordinates()
        {
            return Android.Runtime.JavaCollection<Point>.FromArray<Point>(Coordinates().ToArray()); 
        }
    }

    public abstract partial class MultiPoint : IGeometry
    {
        global::Java.Lang.Object global::Com.Mapbox.Geojson.IGeometry.Coordinates()
        {
            return Android.Runtime.JavaCollection<Point>.FromArray<Point>(Coordinates().ToArray());
        }
    }

    public abstract partial class MultiLineString : IGeometry
    {
        global::Java.Lang.Object global::Com.Mapbox.Geojson.IGeometry.Coordinates()
        {
            return Android.Runtime.JavaCollection<JavaCollection<Point>>.FromArray<IList<Point>>(Coordinates().ToArray());
        }
    }

    public abstract partial class MultiPolygon : IGeometry
    {
        global::Java.Lang.Object global::Com.Mapbox.Geojson.IGeometry.Coordinates()
        {
            return Android.Runtime.JavaCollection<JavaCollection<JavaCollection<Point>>>.FromArray<IList<IList<Point>>>(Coordinates().ToArray());
        }
    }
    public abstract partial class Point : IGeometry
    {
        global::Java.Lang.Object global::Com.Mapbox.Geojson.IGeometry.Coordinates()
        {
            return Android.Runtime.JavaCollection<Double>.FromArray<Java.Lang.Double>(Coordinates().ToArray());
        }
    }
    public abstract partial class Polygon : IGeometry
    {
        global::Java.Lang.Object global::Com.Mapbox.Geojson.IGeometry.Coordinates()
        {
            return Android.Runtime.JavaCollection<JavaCollection<Point>>.FromArray<IList<Point>>(Coordinates().ToArray());
        }
    }

}