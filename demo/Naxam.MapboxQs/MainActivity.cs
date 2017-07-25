using Android.App;
using Android.Widget;
using Android.OS;
using MapboxAccountManager = Com.Mapbox.Mapboxsdk.Mapbox;
using Com.Mapbox.Mapboxsdk.Maps;
using Android.Support.V7.App;
using Com.Mapbox.Mapboxsdk.Camera;
using Com.Mapbox.Mapboxsdk.Geometry;
using Com.Mapbox.Mapboxsdk.Annotations;

namespace Naxam.MapboxQs
{
	[Activity(Label = "@string/app_name", MainLauncher = true, Icon = "@mipmap/ic_launcher", Theme="@style/MyTheme")]
	public class MainActivity : AppCompatActivity, IOnMapReadyCallback
	{
		MapView mapView;

		protected override void OnCreate(Bundle bundle)
		{
			//TabLayoutResource = Resource.Layout.Tabbar;
			//ToolbarResource = Resource.Layout.Toolbar;

			base.OnCreate(bundle);
			MapboxAccountManager.GetInstance(this, Resources.GetString(Resource.String.access_token));

			SetContentView(Resource.Layout.Main);

			mapView = FindViewById<MapView>(Resource.Id.mapView);
			//mapView.StyleUrl = Style.MapboxStreets;
			mapView.OnCreate(bundle);

			mapView.GetMapAsync(this);

            //global::Xamarin.Forms.Forms.Init(this, bundle);

            //LoadApplication(new App());

            MarkerOptions options = new MarkerOptions()
                .SetTitle("Hello")
				.This<MarkerOptions>();
            
			MarkerViewOptions viewOptions = new MarkerViewOptions()
                .InvokeTitle("Hello")
				.This<MarkerViewOptions>();
		}

		protected override void OnStart()
		{
			base.OnStart();
			mapView.OnStart();
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

		protected override void OnStop()
		{
			base.OnStop();
			mapView.OnStop();
		}

		protected override void OnDestroy()
		{
			mapView.OnDestroy();
			base.OnDestroy();
		}

		public override void OnLowMemory()
		{
			base.OnLowMemory();
			mapView.OnLowMemory();
		}
	} 
}

