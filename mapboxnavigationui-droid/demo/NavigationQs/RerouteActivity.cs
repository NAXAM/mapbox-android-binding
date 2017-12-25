
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.Locations;
using Android.OS;
using Android.Runtime;
using Android.Support.Design.Widget;
using Android.Support.V7.App;
using Android.Views;
using Android.Widget;
using Com.Mapbox.Geojson;
using Com.Mapbox.Mapboxsdk;
using Com.Mapbox.Mapboxsdk.Annotations;
using Com.Mapbox.Mapboxsdk.Camera;
using Com.Mapbox.Mapboxsdk.Geometry;
using Com.Mapbox.Mapboxsdk.Maps;
using Com.Mapbox.Mapboxsdk.Plugins.Locationlayer;
using Com.Mapbox.Services.Android.Navigation.V5.Location;
using Com.Mapbox.Services.Android.Navigation.V5.Milestone;
using Com.Mapbox.Services.Android.Navigation.V5.Navigation;
using Com.Mapbox.Services.Android.Navigation.V5.Offroute;
using Com.Mapbox.Services.Android.Navigation.V5.Routeprogress;
using Com.Mapbox.Services.Android.Telemetry.Location;
using Square.Retrofit2;
using Com.Mapbox.Api.Directions.V5.Models;
using Com.Mapbox.Core.Constants;
using Android.Graphics;

namespace NavigationQs
{
    [Activity(Label = "RerouteActivity", Icon = "@mipmap/ic_launcher", RoundIcon = "@mipmap/ic_launcher_round", Theme = "@style/AppTheme")]
    public class RerouteActivity :
        AppCompatActivity, IOnMapReadyCallback,
        ILocationEngineListener, Square.Retrofit2.ICallback, MapboxMap.IOnMapClickListener,
        INavigationEventListener, IOffRouteListener,
        IProgressChangeListener, IMilestoneEventListener
    {

        MapView mapView;
        View contentLayout;

        private Com.Mapbox.Geojson.Point origin = Com.Mapbox.Geojson.Point.FromLngLat(-87.6900, 41.8529);
        private Com.Mapbox.Geojson.Point destination = Com.Mapbox.Geojson.Point.FromLngLat(-87.8921, 41.9794);
        private Polyline polyline;

        private LocationLayerPlugin locationLayerPlugin;
        private MockLocationEngine mockLocationEngine;
        private MapboxNavigation navigation;
        private MapboxMap mapboxMap;
        private bool running;
        private bool tracking;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.activity_reroute);

            mapView = FindViewById<MapView>(Resource.Id.mapView);
            contentLayout = FindViewById(Android.Resource.Id.Content);

            mapView.OnCreate(savedInstanceState);
            mapView.GetMapAsync(this);

            // Initialize MapboxNavigation and add listeners
            MapboxNavigationOptions options = MapboxNavigationOptions
                .InvokeBuilder()
                .IsDebugLoggingEnabled(true)
                .Build();

            navigation = new MapboxNavigation(ApplicationContext, Mapbox.AccessToken, options);
            navigation.AddNavigationEventListener(this);
            navigation.AddMilestoneEventListener(this);
        }

        protected override void OnResume()
        {
            base.OnResume(); ;
            mapView.OnResume();
        }

        protected override void OnStart()
        {
            base.OnStart();

            mapView.OnStart();
            if (locationLayerPlugin != null)
            {
                locationLayerPlugin.OnStart();
            }
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

            ShutdownLocationEngine();

            if (locationLayerPlugin != null)
            {
                locationLayerPlugin.OnStop();
            }

            if (navigation != null)
            {
                // End the navigation session
                navigation.EndNavigation();
            }
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
            ShutdownNavigation();
        }

        public void OnMapReady(MapboxMap mapboxMap)
        {
            this.mapboxMap = mapboxMap;
            mapboxMap.SetOnMapClickListener(this);

            locationLayerPlugin = new LocationLayerPlugin(mapView, mapboxMap, null);
            locationLayerPlugin.SetLocationLayerEnabled(LocationLayerMode.Navigation);

            // Setup the mockLocationEngine
            mockLocationEngine = new MockLocationEngine(1000, 30, false);
            mockLocationEngine.AddLocationEngineListener(this);
            navigation.LocationEngine = (mockLocationEngine);

            // Acquire the navigation route
            GetRoute(origin, destination, null);
        }

        public void OnConnected()
        {
            // No-op - mock automatically begins pushing updates
        }


        public void OnLocationChanged(Location location)
        {
            if (!tracking)
            {
                locationLayerPlugin.ForceLocationUpdate(location);
            }
        }

        public void OnMapClick(LatLng point)
        {
            if (!running || mapboxMap == null)
            {
                return;
            }

            mapboxMap.AddMarker(Android.Runtime.Extensions.JavaCast<MarkerOptions>(new MarkerOptions().Position(point)));
            mapboxMap.SetOnMapClickListener(null);

            Com.Mapbox.Geojson.Point newDestination = Com.Mapbox.Geojson.Point.FromLngLat(point.Longitude, point.Latitude);
            mockLocationEngine.MoveToLocation(newDestination);
            destination = Com.Mapbox.Geojson.Point.FromLngLat(point.Longitude, point.Latitude);
            tracking = false;
        }

        public void OnRunning(bool running)
        {
            this.running = running;
            if (running)
            {
                navigation.AddOffRouteListener(this);
                navigation.AddProgressChangeListener(this);
            }
        }

        public void UserOffRoute(Location location)
        {
            Com.Mapbox.Geojson.Point newOrigin = Com.Mapbox.Geojson.Point.FromLngLat(location.Longitude, location.Latitude);
            GetRoute(newOrigin, destination, location.Bearing);
            Snackbar.Make(contentLayout, "User Off Route", Snackbar.LengthShort).Show();
            var markerOptions = new MarkerOptions().Position(new LatLng(location.Latitude, location.Longitude));
            mapboxMap.AddMarker(Android.Runtime.Extensions.JavaCast<MarkerOptions>(markerOptions));
        }

        public void OnProgressChange(Location location, RouteProgress routeProgress)
        {
            if (tracking)
            {
                locationLayerPlugin.ForceLocationUpdate(location);
                CameraPosition cameraPosition = new CameraPosition
                    .Builder()
                    .Zoom(15)
                    .Target(new LatLng(location.Latitude, location.Longitude))
                    .Bearing(location.Bearing)
                    .Build();
                mapboxMap.AnimateCamera(CameraUpdateFactory.NewCameraPosition(cameraPosition), 2000);
            }
        }

        public void OnMilestoneEvent(RouteProgress routeProgress, String instruction, int identifier)
        {
            System.Diagnostics.Debug.WriteLine("onMilestoneEvent - Current Instruction: " + instruction);
        }


        public void OnResponse(ICall call, Response response)
        {
            System.Diagnostics.Debug.WriteLine(call.Request().Url());

            if (response.Body() != null)
            {
                var directions = Android.Runtime.Extensions.JavaCast<DirectionsResponse>(response.Body());

                if (directions.Routes().Count > 0)
                {
                    // Extract the route
                    DirectionsRoute route = directions.Routes()[0];
                    // Draw it on the map
                    DrawRoute(route);
                    // Start mocking the new route
                    ResetLocationEngine(route);
                    navigation.StartNavigation(route);
                    mapboxMap.SetOnMapClickListener(this);
                    tracking = true;
                }
            }
        }

        public void OnFailure(ICall call, Java.Lang.Throwable throwable)
        {
            System.Diagnostics.Debug.WriteLine("Getting directions failed: ", throwable);
        }

        void GetRoute(Com.Mapbox.Geojson.Point origin, Com.Mapbox.Geojson.Point destination, double? bearing)
        {
            NavigationRoute
                .GetBuilder()
                .Origin(origin, bearing.HasValue ? new Java.Lang.Double(bearing.Value) : null, new Java.Lang.Double(90))
                .Destination(destination)
                .AccessToken(Mapbox.AccessToken)
                .Build()
                .GetRoute(this);
        }

        void DrawRoute(DirectionsRoute route)
        {
            Java.Util.ArrayList points = new Java.Util.ArrayList();
            IList<Com.Mapbox.Geojson.Point> coords = LineString.FromPolyline(route.Geometry(), Constants.Precision6).Coordinates();

            foreach (Com.Mapbox.Geojson.Point point in coords)
            {
                points.Add(new LatLng(point.Latitude(), point.Longitude()));
            }

            if (points.IsEmpty == false)
            {
                if (polyline != null)
                {
                    mapboxMap.RemovePolyline(polyline);
                }

                // Draw polyline on map
                polyline = mapboxMap
                    .AddPolyline(new PolylineOptions()
                    .AddAll(points)
                    .InvokeColor(Color.ParseColor("#4264fb"))
                    .InvokeWidth(5));
            }
        }

        void ResetLocationEngine(DirectionsRoute directionsRoute)
        {
            mockLocationEngine.Deactivate();
            mockLocationEngine.SetRoute(directionsRoute);
        }

        void ShutdownLocationEngine()
        {
            if (mockLocationEngine != null)
            {
                mockLocationEngine.RemoveLocationEngineListener(this);
                mockLocationEngine.RemoveLocationUpdates();
                mockLocationEngine.Deactivate();
            }
        }

        void ShutdownNavigation()
        {
            navigation.RemoveNavigationEventListener(this);
            navigation.RemoveProgressChangeListener(this);
            navigation.OnDestroy();
        }
    }
}
