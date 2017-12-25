
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Support.V7.App;
using Android.Views;
using Android.Widget;
using Com.Mapbox.Api.Directions.V5;
using Com.Mapbox.Api.Directions.V5.Models;
using Com.Mapbox.Mapboxsdk.Annotations;
using Com.Mapbox.Mapboxsdk.Maps;
using Com.Mapbox.Services.Android.Navigation.UI.V5.Route;
using GoogleGson;
using Square.Retrofit2;
using Java.Lang;
using Com.Mapbox.Mapboxsdk.Geometry;
using Com.Mapbox.Geojson;
using Com.Mapbox.Mapboxsdk;
using System.IO;
using Android.Bluetooth.LE;
using Android.Support.Design.Widget;

namespace NavigationQs
{
    [Activity(Label = "NavigationMapRouteActivity",Icon = "@mipmap/ic_launcher", RoundIcon = "@mipmap/ic_launcher_round", Theme = "@style/AppTheme")]
    public class NavigationMapRouteActivity
        : AppCompatActivity, IOnMapReadyCallback, MapboxMap.IOnMapLongClickListener,
        ICallback, IOnRouteSelectionChangeListener
    {

        private static readonly string DIRECTIONS_RESPONSE = "directions-route.json";

        MapView mapView;
        TextView primaryRouteIndexTextView;

        private MapboxMap mapboxMap;
        private NavigationMapRoute navigationMapRoute;
        private StyleCycle styleCycle = new StyleCycle();

        private Marker originMarker;
        private Marker destinationMarker;
        private bool alternativesVisible = true;
        private IList<DirectionsRoute> routes = new List<DirectionsRoute>();

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.activity_navigation_map_route);

            mapView = FindViewById<MapView>(Resource.Id.mapView);
            primaryRouteIndexTextView = FindViewById<TextView>(Resource.Id.primaryRouteIndexTextView);

            var btnFabStyles = FindViewById<FloatingActionButton>(Resource.Id.fabStyles);
            var btnFabToggleAlternatives = FindViewById<FloatingActionButton>(Resource.Id.fabToggleAlternatives);

            btnFabStyles.Click += OnStyleFabClick;
            btnFabToggleAlternatives.Click += OnToggleAlternativesClick;

            mapView.SetStyleUrl(styleCycle.GetStyle());
            mapView.OnCreate(savedInstanceState);
            mapView.GetMapAsync(this);
        }

        public void OnStyleFabClick(object sender, EventArgs e)
        {
            if (mapboxMap != null)
            {
                mapboxMap.StyleUrl = (styleCycle.GetNextStyle());
            }
        }

        public void OnToggleAlternativesClick(object sender, EventArgs e)
        {
            alternativesVisible = !alternativesVisible;
            if (navigationMapRoute != null)
            {
                navigationMapRoute.ShowAlternativeRoutes(alternativesVisible);
            }
        }

        public void OnNewPrimaryRouteSelected(DirectionsRoute directionsRoute)
        {
            primaryRouteIndexTextView.Text = (routes.IndexOf(directionsRoute).ToString());
        }

        public void OnMapReady(MapboxMap mapboxMap)
        {
            this.mapboxMap = mapboxMap;
            navigationMapRoute = new NavigationMapRoute(null, mapView, mapboxMap, "admin-3-4-boundaries-bg");
            Gson gson = new GsonBuilder().RegisterTypeAdapterFactory(DirectionsAdapterFactory.Create()).Create();
            var json = loadJsonFromAsset(DIRECTIONS_RESPONSE);
            DirectionsResponse response = (DirectionsResponse)gson.FromJson(json, Class.FromType(typeof(DirectionsResponse)));

            navigationMapRoute.AddRoute(response.Routes()[0]);
            mapboxMap.SetOnMapLongClickListener(this);
            navigationMapRoute.SetOnRouteSelectionChangeListener(this);
        }

        public void OnMapLongClick(LatLng point)
        {
            if (originMarker == null)
            {
                originMarker = mapboxMap.AddMarker(Android.Runtime.Extensions.JavaCast<MarkerOptions>(new MarkerOptions().Position(point)));
            }
            else if (destinationMarker == null)
            {
                destinationMarker = mapboxMap.AddMarker(Android.Runtime.Extensions.JavaCast<MarkerOptions>(new MarkerOptions().Position(point)));
                Point originPoint = Point.FromLngLat(originMarker.Position.Longitude, originMarker.Position.Latitude);
                Point destinationPoint = Point.FromLngLat(destinationMarker.Position.Longitude, destinationMarker.Position.Latitude);
                RequestDirectionsRoute(originPoint, destinationPoint);
                mapboxMap.RemoveMarker(originMarker);
                mapboxMap.RemoveMarker(destinationMarker);
            }
            else
            {
                originMarker = null;
                destinationMarker = null;
                navigationMapRoute.RemoveRoute();
            }
        }

        public void RequestDirectionsRoute(Point origin, Point destination)
        {
            MapboxDirections directions = MapboxDirections
                        .InvokeBuilder()
                        .Origin(origin)
                        .Destination(destination)
                        .AccessToken(Mapbox.AccessToken)
                        .Profile(DirectionsCriteria.ProfileDrivingTraffic)
                        .Overview(DirectionsCriteria.OverviewFull)
                        .Annotations(DirectionsCriteria.AnnotationCongestion)
                        .Alternatives(new Java.Lang.Boolean(true))
                        .Steps(new Java.Lang.Boolean(true))
                        .Build();

            directions.EnqueueCall(this);
        }


        public void OnResponse(ICall call, Response response)
        {
            var directions = Android.Runtime.Extensions.JavaCast<DirectionsResponse>(response.Body());

            if (directions != null && directions.Routes().Count > 0)
            {
                this.routes = directions.Routes();
                navigationMapRoute.AddRoutes(routes);
            }
        }

        public void OnFailure(ICall call, Throwable throwable)
        {
            //Timber.e(throwable);
        }

        protected override void OnResume()
        {
            base.OnResume();
            mapView.OnResume();
        }

        protected override void OnStart()
        {
            base.OnStart();
            mapView.OnStart();
        }

        protected override void OnStop()
        {
            base.OnStop();
            mapView.OnStop();
        }
        protected override void OnPause()
        {
            base.OnPause();
            mapView.OnPause();
        }

        public override void OnLowMemory()
        {
            base.OnLowMemory();
            mapView.OnLowMemory();
        }

        protected override void OnDestroy()
        {
            base.OnDestroy();
            mapView.OnDestroy();
        }

        protected override void OnSaveInstanceState(Bundle outState)
        {
            base.OnSaveInstanceState(outState);
            mapView.OnSaveInstanceState(outState);
        }

        public NavigationMapRoute GetNavigationMapRoute()
        {
            return navigationMapRoute;
        }

        private string loadJsonFromAsset(string filename)
        {
            // Using this method to load in GeoJSON files from the assets folder.

            var stream = Assets.Open(filename);
            var textReader = new StreamReader(stream);
            return textReader.ReadToEnd();
        }

        private class StyleCycle
        {
            private static readonly string[] STYLES = {
                        Com.Mapbox.Mapboxsdk.Constants.Style.MapboxStreets,
                        Com.Mapbox.Mapboxsdk.Constants.Style.Outdoors,
                        Com.Mapbox.Mapboxsdk.Constants.Style.Light,
                        Com.Mapbox.Mapboxsdk.Constants.Style.Dark,
                        Com.Mapbox.Mapboxsdk.Constants.Style.SatelliteStreets
                    };
            private int index;

            public string GetNextStyle()
            {
                index++;
                if (index == STYLES.Length)
                {
                    index = 0;
                }
                return GetStyle();
            }

            public string GetStyle()
            {
                return STYLES[index];
            }
        }
    }
}
