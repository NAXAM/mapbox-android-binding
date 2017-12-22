using Android.App;
using Android.Widget;
using Android.OS;
using Com.Mapbox.Services.Android.Navigation.V5.Navigation;
using Android;
using Com.Mapbox.Mapboxsdk;
using Com.Mapbox.Geojson;
using Com.Mapbox.Services.Android.Telemetry.Location;
using Com.Mapbox.Services.Android.Navigation.V5.Milestone;
using Com.Mapbox.Services.Android.Navigation.V5.Instruction;
using Com.Mapbox.Services.Android.Navigation.V5.Routeprogress;
using Android.Locations;
using Com.Mapbox.Services.Android.Navigation.V5.Offroute;
using Com.Mapbox.Api.Directions.V5.Models;
using Com.Mapbox.Mapboxsdk.Maps;
using Com.Mapbox.Mapboxsdk.Maps.Widgets;
using Com.Mapbox.Services.Android.Navigation.UI.V5;
using Com.Mapbox.Services.Android.Navigation.UI.V5.Instruction;
using Com.Mapbox.Services.Android.Navigation.UI.V5.Route;

namespace NavigationQs
{
    [Activity(Label = "NavigationQs", MainLauncher = true, Icon = "@mipmap/icon")]
    public class MainActivity : Activity, INavigationEventListener, IMilestoneEventListener, IProgressChangeListener, IOffRouteListener, INavigationViewListener
    {
        string key = "pk.eyJ1IjoicXV5bmhuZ2ExMjMiLCJhIjoiY2piZzVkanJ3MzJ1ODJ3bnVyYjk1NnQ0eCJ9.FzaAQLO8NJiE7XygUPRCjQ";
        NavigationViewOptions navigationViewOptions;
        InstructionView instructionView;
        NavigationView navigationView;
        int count = 1;
        string awsPoolId = null;
        bool simulateRoute = true;
        Point origin, destination;
        MapboxNavigation mapboxNavigation;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);
            navigationView = FindViewById<NavigationView>(Resource.Id.navigationView);
            instructionView = FindViewById<InstructionView>(Resource.Id.instructionView);
            MapboxNavigationOptions options = MapboxNavigationOptions.InvokeBuilder().ManeuverZoneRadius(70).Build();
            mapboxNavigation = new MapboxNavigation(this,key , options);
            origin = Point.FromLngLat(-77.03613, 38.90992);
            destination = Point.FromLngLat(-77.0365, 38.8977);
            NavigationRoute.Builder builder = NavigationRoute.GetBuilder();
            builder.AccessToken(key).Origin(origin).Destination(destination).Build();
            LocationEngine locationEngine = LostLocationEngine.GetLocationEngine(this);
            mapboxNavigation.LocationEngine = locationEngine;
            mapboxNavigation.AddMilestone(new RouteMilestone.Builder().SetIdentifier(12).SetTrigger(Trigger.All(Trigger.Lt(TriggerProperty.StepIndex, 3), Trigger.Gt(TriggerProperty.StepIndex, 3))).Build());
            MapboxNavigationOptions mapboxNavigationOptions = MapboxNavigationOptions.InvokeBuilder().UnitType(NavigationUnitType.TypeMetric).Build();
            //NavigationViewOptions x =NavigationViewOptions.InvokeBuilder().Origin(origin).Destination(destination).AwsPoolId(null).ShouldSimulateRoute(true).Build();
            //NavigationLauncher.StartNavigation(this, x); 
            navigationViewOptions = NavigationViewOptions.InvokeBuilder().Origin(origin).Destination(destination).AwsPoolId(null).ShouldSimulateRoute(true).Build();
            navigationView.OnCreate(savedInstanceState);
            navigationView.GetNavigationAsync(this);
        }
        protected override void OnRestoreInstanceState(Bundle savedInstanceState)
        {
            base.OnRestoreInstanceState(savedInstanceState);
            navigationView.OnRestoreInstanceState(savedInstanceState);
        }
        protected override void OnSaveInstanceState(Bundle outState)
        {
            navigationView.OnSaveInstanceState(outState);
            base.OnSaveInstanceState(outState);

        }
        public override void OnBackPressed()
        {
            if (!navigationView.OnBackPressed())
                base.OnBackPressed();
        }
        public override void OnLowMemory()
        {
            base.OnLowMemory();
            navigationView.OnLowMemory();
        }
        protected override void OnDestroy()
        {
            base.OnDestroy();
            mapboxNavigation.EndNavigation();
            mapboxNavigation.OnDestroy();

        }
        public void OnMilestoneEvent(RouteProgress routeProgress, string instruction, int milestone)
        {
        }

        public void OnProgressChange(Location location, RouteProgress routeProgress)
        {
            instructionView.Update(routeProgress, NavigationUnitType.TypeImperial);
        }

        public void OnRunning(bool p0)
        {
        }

        public void UserOffRoute(Location p0)
        {
        }

        public void OnNavigationFinished()
        {
            Finish();
        }

        public void OnNavigationReady()
        {
            navigationView.StartNavigation(navigationViewOptions);
        }
    }

}

