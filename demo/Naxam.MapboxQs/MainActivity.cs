using Android.App;
using Android.Widget;
using Android.OS;
using Mapbox.Sdk;
using Mapbox.Sdk.Geometry;
using Mapbox.Sdk.Camera;
using Mapbox.Sdk.Maps;
using Mapbox.Sdk.Style;
using Android.Support.V7.App;

namespace Naxam.MapboxQs
{
	[Activity(Label = "MapboxQs", MainLauncher = true, Icon = "@mipmap/icon", Theme="@style/MyTheme")]
	public class MainActivity : AppCompatActivity, IOnMapReadyCallback
	{
		MapView mapView;

		protected override void OnCreate(Bundle bundle)
		{
			//TabLayoutResource = Resource.Layout.Tabbar;
			//ToolbarResource = Resource.Layout.Toolbar;

			base.OnCreate(bundle);
			MapboxAccountManager.Start(this, Resources.GetString(Resource.String.access_token));

			SetContentView(Resource.Layout.Main);

			mapView = FindViewById<MapView>(Resource.Id.mapView);
			//mapView.StyleUrl = Style.MapboxStreets;
			mapView.OnCreate(bundle);

			mapView.GetMapAsync(this);

			//global::Xamarin.Forms.Forms.Init(this, bundle);

			//LoadApplication(new App());
		}

		public void OnMapReady(MapboxMap map)
		{
			var position = new CameraPosition.Builder()
						   .Target(new LatLng(41.885, -87.679)) // Sets the new camera position
						   .Zoom(11) // Sets the zoom
						   .Build(); // Creates a CameraPosition from the builder

			map.AnimateCamera(CameraUpdateFactory.NewCameraPosition(position));
		}

		protected override void OnResume()
		{
			base.OnResume();
			mapView.OnResume();
		}

		protected override void OnPause()
		{
			mapView.OnPause();
			base.OnPause();
		}

		protected override void OnSaveInstanceState(Bundle outState)
		{
			base.OnSaveInstanceState(outState);
			mapView.OnSaveInstanceState(outState);
		}

		protected override void OnDestroy()
		{
			mapView.OnDestroy();
			base.OnStop();
		}

		public override void OnLowMemory()
		{
			base.OnLowMemory();
			mapView.OnLowMemory();
		}
	}
}

