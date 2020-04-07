using Android.App;
using Android.OS;
using MapboxAccountManager = Com.Mapbox.Mapboxsdk.Mapbox;
using Com.Mapbox.Mapboxsdk.Maps;
using AndroidX.AppCompat.App;
using Com.Mapbox.Mapboxsdk.Camera;
using Com.Mapbox.Mapboxsdk.Geometry;
using Com.Mapbox.Mapboxsdk.Plugins.Annotation;
using Java.Lang;
using Java.Interop;

namespace Naxam.MapboxQs
{
    [Activity(Label = "@string/app_name", MainLauncher = true, Icon = "@mipmap/ic_launcher", Theme="@style/MyTheme")]
	public class MainActivity : AppCompatActivity, IOnMapReadyCallback, Style.IOnStyleLoaded, IOnSymbolClickListener
	{
		MapView mapView;

		protected override void OnCreate(Bundle bundle)
		{
			//TabLayoutResource = Resource.Layout.Tabbar;
			//ToolbarResource = Resource.Layout.Toolbar;

			base.OnCreate(bundle);
			MapboxAccountManager.GetInstance(this, Resources.GetString(Resource.String.access_token));

			SetContentView(Resource.Layout.Main);
            System.Diagnostics.Debug.WriteLine("===========" + Com.Mapbox.Mapboxsdk.BuildConfig.MAPBOX_SDK_VERSION + "   " + Com.Mapbox.Mapboxsdk.BuildConfig.MAPBOX_VERSION_STRING + "   " + Com.Mapbox.Mapboxsdk.BuildConfig.MAPBOX_SDK_IDENTIFIER);
			mapView = FindViewById<MapView>(Resource.Id.mapView);
			mapView.OnCreate(bundle);
			mapView.GetMapAsync(this);
		}

		protected override void OnStart()
		{
			base.OnStart();
			mapView.OnStart();
		}

        MapboxMap mapboxMap;

        public void OnMapReady(MapboxMap map)
		{
            mapboxMap = map;

            //var position = new CameraPosition.Builder()
			//			   .Target(new LatLng(41.885, -87.679)) // Sets the new camera position
			//			   .Zoom(11) // Sets the zoom
			//			   .Build(); // Creates a CameraPosition from the builder
   //         map.AnimateCamera(CameraUpdateFactory.NewCameraPosition(position));

            map.SetStyle(Style.MAPBOX_STREETS, this);

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

        SymbolManager symbolManager;
        public void OnStyleLoaded(Style p0)
        {
            symbolManager = new SymbolManager(mapView, mapboxMap, p0);

            var point = Com.Mapbox.Geojson.Point.FromLngLat(105.505, 21.033);
            mapboxMap.MoveCamera(CameraUpdateFactory.NewLatLngZoom(new LatLng(point.Latitude(), point.Longitude()), 15));

            var options = new SymbolOptions();
            options.WithIconImage("fire-station-11");
            options.WithGeometry(point);
            options.WithIconSize(new Float(4f))
                .WithDraggable(true);

            var symbol = symbolManager.Create(options);

            var options2 = new SymbolOptions()
                .WithIconImage("fire-station-11")
                .WithGeometry(point)
                .WithIconSize(new Float(2f));

            var symbol2 = symbolManager.Create(options2);

            symbolManager.AddClickListener(this);
        }

        public void OnAnnotationClick(Symbol p0)
        {
        }
    } 
}

