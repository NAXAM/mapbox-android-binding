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
using Java.Lang;
using Java.Lang.Reflect;

namespace Com.Mapbox.Services.Api.Geocoding.V5.Gson
{
    public partial class CarmenGeometryDeserializer
    {
        public unsafe Java.Lang.Object Deserialize(JsonElement p0, IType p1, IJsonDeserializationContext p2)
        {
            return Deserialize(p0, p1, p2);
        }
    }

}

namespace Com.Mapbox.Services.Api.Distance.V1.Gson
{
    public partial class DistanceGeometryDeserializer
    {
        public unsafe Java.Lang.Object Deserialize(JsonElement p0, IType p1, IJsonDeserializationContext p2)
        {
            return Deserialize(p0, p1, p2);
        }

    }

}

namespace Com.Mapbox.Services.Api.Optimizedtrips.V1
{
    public partial class MapboxOptimizedTrips
    {
        partial class Builder
        {
            //public override Java.Lang.Object Build()
            //{
            //    return TripBuild();
            //}

            //public override MapboxBuilder SetAccessToken(string p0)
            //{
            //    return (MapboxBuilder)TripSetAccessToken(p0);
            //}
        }
    }
}

namespace Com.Mapbox.Services.Api.Directionsmatrix.V1
{
    public partial class MapboxDirectionsMatrix
    {
        partial class Builder
        {
            //public override Java.Lang.Object Build()
            //{
            //    return MatrixBuild();
            //}

            //public override MapboxBuilder SetAccessToken(string p0)
            //{
            //    return (MapboxBuilder)MatrixSetAccessToken(p0);
            //}
        }

    }
}

namespace Com.Mapbox.Services.Api.Distance.V1
{
    partial class MapboxDistance
    {
        partial class Builder
        {
            //public override Java.Lang.Object Build()
            //{
            //    return DistanceBuild();
            //}

            //public override MapboxBuilder SetAccessToken(string p0)
            //{
            //    return (MapboxBuilder)DistanceSetAccessToken(p0);
            //}
        }
    }

}

namespace Com.Mapbox.Services.Api.Staticimage.V1
{
    public partial class MapboxStaticImage
    {
        partial class Builder
        {
            public override MapboxBuilder SetAccessToken(string p0)
            {
                return StaticImageAccessToken(p0);
            }

            public override Java.Lang.Object Build()
            {
                return StaticImageBuid();
            }
        }
    }
}

namespace Com.Mapbox.Services.Api.Mapmatching.V5
{
    public partial class MapboxMapMatching
    {
        partial class Builder
        {
            //public override MapboxBuilder SetAccessToken(string p0)
            //{
            //    return (MapboxBuilder)MapMatchingSetAccessToken(p0);
            //}
            //public override Java.Lang.Object Build()
            //{
            //    return MapMatchingBuid();
            //}
        }

    }
}

namespace Com.Mapbox.Services.Api.Geocoding.V5
{
    public partial class MapboxGeocoding
    {
        partial class Builder
        {
            //public override Java.Lang.Object Build()
            //{
            //    return GeocodingBuid();
            //}

            //public override MapboxBuilder SetAccessToken(string p0)
            //{
            //    return (MapboxBuilder)GeocodingSetAccessToken(p0);
            //}
        }
    }
}

namespace Com.Mapbox.Services.Api.Directions.V5
{
    public partial class MapboxDirections
    {
        partial class Builder
        {
            //public override Java.Lang.Object Build()
            //{
            //    return DirectionsBuid();
            //}

            //public override MapboxBuilder SetAccessToken(string p0)
            //{
            //    return (MapboxBuilder)DirectionsSetAccessToken(p0);
            //}
        }
    }

}

namespace Com.Mapbox.Services.Api.Distance.V1.Gson
{
    public partial class DistanceGeometryDeserializer
    {
        //public Java.Lang.Object Deserialize(JsonElement p0, IType p1, IJsonDeserializationContext p2)
        //{

        //    return (Java.Lang.Object)DistanceDserialize(p0,p1,p2);
        //}
    }

}

namespace Com.Mapbox.Services.Api.Geocoding.V5.Gson
{
    public partial class CarmenGeometryDeserializer
    {
        //public Java.Lang.Object Deserialize(JsonElement p0, IType p1, IJsonDeserializationContext p2)
        //{
        //    return (Java.Lang.Object)CarmenGeometryDserialize(p0,p1,p2);
        //}
    }

}

namespace Com.Mapbox.Services.Api.Staticimage.V1
{
    public partial class MapboxStaticImage
    {
        public partial class Builder
        {
            public override Java.Lang.Object SetClientAppName(string p0)
            {
                return StaticImageSetClientAppName(p0);
            }
        }
    }

}