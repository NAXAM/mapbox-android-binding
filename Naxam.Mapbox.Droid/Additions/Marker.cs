using System;
namespace Mapbox.Sdk.Annotations
{
	public partial class Marker
	{
		public override int CompareTo(Java.Lang.Object obj)
		{
			return 0;
		}
	}

	public partial class Polygon
	{
		public override int CompareTo(Java.Lang.Object obj)
		{
			return 0;
		}
	}

	public partial class Polyline
	{
		public override int CompareTo(Java.Lang.Object obj)
		{
			return 0;
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
