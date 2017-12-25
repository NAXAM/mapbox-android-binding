
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
using Com.Mapbox.Api.Directions.V5.Models;
using Com.Mapbox.Core.Constants;
using Com.Mapbox.Geojson;
using Com.Mapbox.Mapboxsdk;
using Com.Mapbox.Mapboxsdk.Annotations;
using Com.Mapbox.Mapboxsdk.Camera;
using Com.Mapbox.Mapboxsdk.Exceptions;
using Com.Mapbox.Mapboxsdk.Geometry;
using Com.Mapbox.Mapboxsdk.Maps;
using Com.Mapbox.Mapboxsdk.Plugins.Locationlayer;
using Com.Mapbox.Services.Android.Navigation.UI.V5;
using Com.Mapbox.Services.Android.Navigation.UI.V5.Route;
using Com.Mapbox.Services.Android.Navigation.V5.Navigation;
using Com.Mapbox.Services.Android.Telemetry.Location;
using Square.Retrofit2;

namespace NavigationQs
{
    [Activity(Label = "NavigationViewActivity", Icon = "@mipmap/ic_launcher", RoundIcon = "@mipmap/ic_launcher_round", Theme = "@style/AppTheme")]
    public class NavigationViewActivity
        : AppCompatActivity, IOnMapReadyCallback, MapboxMap.IOnMapLongClickListener,
        ILocationEngineListener, ICallback, IOnRouteSelectionChangeListener
    {

        private static readonly int CAMERA_ANIMATION_DURATION = 1000;

        private LocationLayerPlugin locationLayer;
        private LocationEngine locationEngine;
        private NavigationMapRoute mapRoute;
        private MapboxMap mapboxMap;

        MapView mapView;
        Button launchRouteBtn;
        ProgressBar loading;
        Switch demoSwitch;

        private Marker currentMarker;
        private Point currentLocation;
        private Point destination;
        private DirectionsRoute route;

        private bool locationFound;
        private bool shouldSimulateRoute;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.activity_navigation_view);
            mapView = (MapView)FindViewById(Resource.Id.mapView);
            launchRouteBtn = (Button)FindViewById(Resource.Id.launchRouteBtn);
            loading = (ProgressBar)FindViewById(Resource.Id.loading);
            demoSwitch = (Switch)FindViewById(Resource.Id.demoSwitch);


            mapView.OnCreate(savedInstanceState);
            mapView.GetMapAsync(this);

            demoSwitch.CheckedChange += (sender, e) =>
            {
                shouldSimulateRoute = e.IsChecked;
            };
            launchRouteBtn.Click += delegate
            {
                LaunchNavigationWithRoute();
            };
        }

        protected override void OnStart()
        {
            base.OnStart();

            mapView.OnStart();
            if (locationLayer != null)
            {
                locationLayer.OnStart();
            }
        }

        protected override void OnResume()
        {
            base.OnResume();
            mapView.OnResume();
            try
            {
                if (locationEngine != null)
                {
                    locationEngine.AddLocationEngineListener(this);
                    if (!locationEngine.IsConnected)
                    {
                        locationEngine.Activate();
                    }
                }
            }
            catch (Exception e)
            {

            }
        }

        protected override void OnPause()
        {
            base.OnPause();

            mapView.OnPause();
            if (locationEngine != null)
            {
                locationEngine.RemoveLocationEngineListener(this);
            }
        }

        public override void OnLowMemory()
        {
            base.OnLowMemory();

            mapView.OnLowMemory();
        }

        protected override void OnStop()
        {
            base.OnStop();

            mapView.OnStop();
            if (locationLayer != null)
            {
                locationLayer.OnStop();
            }
        }

        protected override void OnDestroy()
        {
            base.OnDestroy();

            mapView.OnDestroy();
            if (locationEngine != null)
            {
                locationEngine.RemoveLocationUpdates();
                locationEngine.Deactivate();
            }
        }

        protected override void OnSaveInstanceState(Bundle outState)
        {
            base.OnSaveInstanceState(outState);
            mapView.OnSaveInstanceState(outState);
        }

        public void OnMapReady(MapboxMap mapboxMap)
        {
            this.mapboxMap = mapboxMap;
            this.mapboxMap.SetOnMapLongClickListener(this);
            InitLocationEngine();
            InitLocationLayer();
            InitMapRoute();
        }

        public void OnMapLongClick(LatLng point)
        {
            destination = Point.FromLngLat(point.Longitude, point.Latitude);
            launchRouteBtn.Enabled = (false);
            loading.Visibility = ViewStates.Visible;
            SetCurrentMarkerPosition(point);
            if (currentLocation != null)
            {
                FetchRoute();
            }
        }


        public void OnConnected()
        {
            locationEngine.RequestLocationUpdates();
        }


        public void OnLocationChanged(Location location)
        {
            currentLocation = Point.FromLngLat(location.Longitude, location.Latitude);
            OnLocationFound(location);
        }

        public void OnResponse(ICall call, Response response)
        {
            if (ValidRouteResponse(response))
            {
                HideLoading();
                var directions = Android.Runtime.Extensions.JavaCast<DirectionsResponse>(response.Body());

                route = directions.Routes()[0];
                var distance = route.Distance();

                if (distance.CompareTo(new Java.Lang.Double(25)) > 0)
                {
                    launchRouteBtn.Enabled = (true);
                    mapRoute.AddRoutes(directions.Routes());
                    BoundCameraToRoute();
                }
                else
                {
                    Snackbar.Make(mapView, "Please select a longer route", BaseTransientBottomBar.LengthShort).Show();
                }
            }
        }

        public void OnFailure(ICall call, Java.Lang.Throwable throwable)
        {
            //Timber.e(throwable.getMessage());
        }

        public void OnNewPrimaryRouteSelected(DirectionsRoute directionsRoute)
        {
            route = directionsRoute;
        }

        private void InitLocationEngine()
        {
            locationEngine = new LostLocationEngine(this);
            locationEngine.Priority = LocationEnginePriority.HighAccuracy;
            locationEngine.Interval = (0);
            locationEngine.FastestInterval = (1000);
            locationEngine.AddLocationEngineListener(this);
            locationEngine.Activate();

            if (locationEngine.LastLocation != null)
            {
                Location lastLocation = locationEngine.LastLocation;
                OnLocationChanged(lastLocation);
                currentLocation = Point.FromLngLat(lastLocation.Longitude, lastLocation.Latitude);
            }
        }

        private void InitLocationLayer()
        {
            locationLayer = new LocationLayerPlugin(mapView, mapboxMap, locationEngine);
            locationLayer.SetLocationLayerEnabled(LocationLayerMode.Compass);
        }

        private void InitMapRoute()
        {
            mapRoute = new NavigationMapRoute(mapView, mapboxMap, "admin-3-4-boundaries-bg");
            mapRoute.SetOnRouteSelectionChangeListener(this);
        }

        private void FetchRoute()
        {
            NavigationRoute
                .GetBuilder()
                .AccessToken(Mapbox.AccessToken)
                .Origin(currentLocation)
                .Destination(destination)
                .Alternatives(new Java.Lang.Boolean(true))
                .Build()
                .GetRoute(this);
            loading.Visibility = (ViewStates.Visible);
        }

        private void LaunchNavigationWithRoute()
        {
            NavigationViewOptions.Builder optionsBuilder = NavigationViewOptions
                .InvokeBuilder()
                .UnitType(NavigationUnitType.TypeImperial)
                .ShouldSimulateRoute(shouldSimulateRoute);

            if (route != null)
            {
                optionsBuilder.DirectionsRoute(route);
                NavigationLauncher.StartNavigation(this, optionsBuilder.Build());
            }
        }

        private bool ValidRouteResponse(Response response)
        {
            var directions = Android.Runtime.Extensions.JavaCast<DirectionsResponse>(response.Body());

            return directions != null
                    && directions.Routes() != null
                    && directions.Routes().Count > 0;
        }

        private void HideLoading()
        {
            if (loading.Visibility == ViewStates.Visible)
            {
                loading.Visibility = ViewStates.Invisible;
            }
        }

        private void OnLocationFound(Location location)
        {
            if (!locationFound)
            {
                AnimateCamera(new LatLng(location.Latitude, location.Longitude));
                Snackbar.Make(mapView, "Long press map to place waypoint", BaseTransientBottomBar.LengthLong).Show();
                locationFound = true;
                HideLoading();
            }
        }

        public void BoundCameraToRoute()
        {
            if (route != null)
            {
                IList<Point> routeCoords = LineString.FromPolyline(route.Geometry(), Constants.Precision6).Coordinates();
                var bboxPoints = new List<LatLng>();
                foreach (Point point in routeCoords)
                {
                    bboxPoints.Add(new LatLng(point.Latitude(), point.Longitude()));
                }
                if (bboxPoints.Count > 1)
                {
                    try
                    {
                        LatLngBounds bounds = new LatLngBounds.Builder().Includes(bboxPoints).Build();
                        AnimateCameraBbox(bounds, CAMERA_ANIMATION_DURATION, new int[] { 50, 500, 50, 335 });
                    }
                    catch (InvalidLatLngBoundsException exception)
                    {
                        Toast.MakeText(this, "Valid route not found.", ToastLength.Short).Show();
                    }
                }
            }
        }

        private void AnimateCameraBbox(LatLngBounds bounds, int animationTime, int[] padding)
        {
            mapboxMap.AnimateCamera(CameraUpdateFactory.NewLatLngBounds(bounds,
              padding[0], padding[1], padding[2], padding[3]), animationTime);
        }

        private void AnimateCamera(LatLng point)
        {
            mapboxMap.AnimateCamera(CameraUpdateFactory.NewLatLngZoom(point, 16), CAMERA_ANIMATION_DURATION);
        }

        private void SetCurrentMarkerPosition(LatLng position)
        {
            if (position != null)
            {
                if (currentMarker == null)
                {
                    var markerViewOptions = new MarkerViewOptions().InvokePosition(position);
                    currentMarker = mapboxMap.AddMarker(Android.Runtime.Extensions.JavaCast<MarkerViewOptions>(markerViewOptions));
                }
                else
                {
                    currentMarker.Position = (position);
                }
            }
        }
    }
}
