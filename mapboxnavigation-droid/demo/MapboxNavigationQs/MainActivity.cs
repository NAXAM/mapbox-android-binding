using Android.App;
using Android.OS;
using Com.Mapbox.Services.Android.Navigation.V5.Navigation;
using Com.Mapbox.Mapboxsdk;
using Com.Mapbox.Geojson;
using Android.Widget;

namespace MapboxNavigationQs
{
    [Activity(Label = "MapboxNavigationQs", MainLauncher = true, Icon = "@mipmap/icon")]
    public class MainActivity : Activity
    {
        const string MAPBOX_KEY = "pk.eyJ1IjoibmF4YW10ZXN0IiwiYSI6ImNqNWtpaG1oYTJqZmQyd28yM2tsdDhucmEifQ.Zr35ENq9tziBBDAbdeU2dw";

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            Mapbox.GetInstance(this, MAPBOX_KEY);

            var btn = FindViewById<Button>(Resource.Id.myButton);
            btn.Click += delegate {
                BuildRoute();
            };
        }

        async void BuildRoute()
        {
            MapboxNavigation navigation = new MapboxNavigation(this, MAPBOX_KEY);

            Point origin = Point.FromLngLat(-77.03613, 38.90992);
            Point destination = Point.FromLngLat(-77.0365, 38.8977);

            var response = await NavigationRoute
                .GetBuilder()
                .AccessToken(Mapbox.AccessToken)
                .Origin(origin)
                .Destination(destination)
                .Build()
                .GetRouteAsync();

            System.Diagnostics.Debug.WriteLine(response);
        }
    }


}

