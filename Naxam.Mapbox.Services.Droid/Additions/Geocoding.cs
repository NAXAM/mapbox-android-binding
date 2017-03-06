using System;
namespace Mapbox.Services.GeoCoding
{
	namespace V5.Gson
	{
		public partial class CarmenGeometryDeserializer
		{
			Java.Lang.Object global::GoogleGson.IJsonDeserializer.Deserialize(global::GoogleGson.JsonElement p0, global::Java.Lang.Reflect.IType p1, global::GoogleGson.IJsonDeserializationContext p2)
			{
				return this.Deserialize(p0, p1, p2) as Java.Lang.Object;
			}
		}
	}
}

namespace Mapbox.Services.MapMatching.V4.Gson
{
	public partial class MapMatchingGeometryDeserializer
	{
		Java.Lang.Object global::GoogleGson.IJsonDeserializer.Deserialize(global::GoogleGson.JsonElement p0, global::Java.Lang.Reflect.IType p1, global::GoogleGson.IJsonDeserializationContext p2)
		{
			return this.Deserialize(p0, p1, p2) as Java.Lang.Object;
		}
	}
}

namespace Mapbox.Services.Commons.GeoJson.Custom
{
	public partial class PositionDeserializer
	{
		Java.Lang.Object global::GoogleGson.IJsonDeserializer.Deserialize(global::GoogleGson.JsonElement p0, global::Java.Lang.Reflect.IType p1, global::GoogleGson.IJsonDeserializationContext p2)
		{
			return this.Deserialize(p0, p1, p2) as Java.Lang.Object;
		}
	}

	public partial class PositionSerializer
	{
		global::GoogleGson.JsonElement global::GoogleGson.IJsonSerializer.Serialize(global::Java.Lang.Object p0, global::Java.Lang.Reflect.IType p1, global::GoogleGson.IJsonSerializationContext p2)
		{
			return this.Serialize(p0 as global::Mapbox.Services.Commons.Models.Position, p1, p2);
		}
	}
}
