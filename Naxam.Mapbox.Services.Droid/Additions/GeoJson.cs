using System;
namespace Mapbox.Services.Commons.GeoJson
{
	namespace Custom {
		public partial class GeometryDeserializer {
			Java.Lang.Object GoogleGson.IJsonDeserializer.Deserialize(global::GoogleGson.JsonElement p0, global::Java.Lang.Reflect.IType p1, global::GoogleGson.IJsonDeserializationContext p2) {
				return this.Deserialize(p0, p1, p2) as Java.Lang.Object;
			}
		}
	}

	public partial class LineString
	{
		Java.Lang.Object IGeometry.Coordinates
		{

			get
			{
				return this.Coordinates.ToJavaList() as Java.Lang.Object;
			}
			set
			{
				this.Coordinates = ListExtensions.ToCsList<Mapbox.Services.Commons.Models.Position>(value as Java.Util.IList)
					as System.Collections.Generic.IList<Mapbox.Services.Commons.Models.Position>;
			}
		}
	}


	public partial class MultiLineString
	{
		Java.Lang.Object IGeometry.Coordinates
		{

			get
			{
				return this.Coordinates.ToJavaList() as Java.Lang.Object;
			}
			set
			{
				this.Coordinates = ListExtensions.ToCsList2<Mapbox.Services.Commons.Models.Position>(value as Java.Util.IList)
					as System.Collections.Generic.IList<System.Collections.Generic.IList<Mapbox.Services.Commons.Models.Position>>;
			}
		}
	}

	public partial class MultiPoint
	{
		Java.Lang.Object IGeometry.Coordinates
		{

			get
			{
				return this.Coordinates.ToJavaList() as Java.Lang.Object;
			}
			set
			{
				this.Coordinates = ListExtensions.ToCsList<Mapbox.Services.Commons.Models.Position>(value as Java.Util.IList)
					as System.Collections.Generic.IList<Mapbox.Services.Commons.Models.Position>;
			}
		}
	}

	public partial class MultiPolygon
	{
		Java.Lang.Object IGeometry.Coordinates
		{

			get
			{
				return this.Coordinates.ToJavaList() as Java.Lang.Object;
			}
			set
			{
				this.Coordinates = ListExtensions.ToCsList3<Mapbox.Services.Commons.Models.Position>(value as Java.Util.IList)
					as System.Collections.Generic.IList<System.Collections.Generic.IList<System.Collections.Generic.IList<Mapbox.Services.Commons.Models.Position>>>;
			}
		}
	}

	public partial class Point
	{
		Java.Lang.Object IGeometry.Coordinates
		{

			get
			{
				return this.Coordinates as Java.Lang.Object;
			}
			set
			{
				this.Coordinates = value as Mapbox.Services.Commons.Models.Position;
			}
		}
	}
	public partial class Polygon
	{
		Java.Lang.Object IGeometry.Coordinates
		{

			get
			{
				return this.Coordinates.ToJavaList() as Java.Lang.Object;
			}
			set
			{
				this.Coordinates = ListExtensions.ToCsList2<Mapbox.Services.Commons.Models.Position>(value as Java.Util.IList)
					as System.Collections.Generic.IList<System.Collections.Generic.IList<Mapbox.Services.Commons.Models.Position>>;
			}
		}
	}

	public static class ListExtensions
	{
		public static Java.Util.IList ToJavaList<T>(this System.Collections.Generic.IList<T> list)
		{
			if (list == null)
			{
				return null;
			}

			var result = new Java.Util.ArrayList(list.Count);

			for (int i = 0; i < list.Count; i++)
			{
				var item = list[i] as Java.Lang.Object;

				if (item == null) continue;

				result.Add(item);
			}

			return result;
		}

		public static Java.Util.IList ToJavaList<T>(this System.Collections.Generic.IList<System.Collections.Generic.IList<T>> list)
		{
			if (list == null)
			{
				return null;
			}

			var result = new Java.Util.ArrayList(list.Count);

			for (int i = 0; i < list.Count; i++)
			{
				result.Add((Java.Lang.Object)list[i].ToJavaList());
			}

			return result;
		}

		public static Java.Util.IList ToJavaList<T>(this System.Collections.Generic.IList<System.Collections.Generic.IList<System.Collections.Generic.IList<T>>> list)
		{
			if (list == null)
			{
				return null;
			}

			var result = new Java.Util.ArrayList(list.Count);

			for (int i = 0; i < list.Count; i++)
			{
				result.Add((Java.Lang.Object)list[i].ToJavaList());
			}

			return result;
		}

		public static System.Collections.IEnumerable ToCsList<T>(this Java.Util.IList list) where T : class
		{
			if (list == null)
			{
				return null;
			}
			var items = list.ToArray();

			System.Collections.Generic.IList<T> result = new System.Collections.Generic.List<T>(list.Size());
			for (int i = 0; i < items.Length; i++)
			{
				var item = items[i] as T;

				if (item == null) continue;

				result.Add(item);
			}

			return result;
		}

		public static System.Collections.IEnumerable ToCsList2<T>(this Java.Util.IList list) where T : class
		{
			if (list == null)
			{
				return null;
			}
			var items = list.ToArray();

			System.Collections.Generic.IList<System.Collections.Generic.IList<T>> result =
				new System.Collections.Generic.List<System.Collections.Generic.IList<T>>(list.Size());
			
			for (int i = 0; i < items.Length; i++)
			{
				var inner = (items[i] as Java.Util.IList).ToCsList<T>();

				if (inner == null) continue;

				result.Add(inner as System.Collections.Generic.IList<T>);
			}

			return result;
		}

		public static System.Collections.IEnumerable ToCsList3<T>(this Java.Util.IList list) where T : class
		{
			if (list == null)
			{
				return null;
			}
			var items = list.ToArray();

			System.Collections.Generic.IList<System.Collections.Generic.IList<System.Collections.Generic.IList<T>>> result =
				new System.Collections.Generic.List<System.Collections.Generic.IList<System.Collections.Generic.IList<T>>>(list.Size());

			for (int i = 0; i < items.Length; i++)
			{
				var inner = (items[i] as Java.Util.IList).ToCsList2<T>();

				if (inner == null) continue;

				result.Add(inner as System.Collections.Generic.IList<System.Collections.Generic.IList<T>>);
			}

			return result;
		}
	}
}
