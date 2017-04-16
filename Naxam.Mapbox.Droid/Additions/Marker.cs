using System;
namespace Mapbox.MapboxSdk.Annotations
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
}
