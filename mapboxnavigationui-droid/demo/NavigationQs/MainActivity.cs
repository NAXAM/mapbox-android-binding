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
using Android.Support.V7.App;
using Com.Mapbox.Services.Android.Telemetry.Permissions;
using Android.Support.V7.Widget;
using System.Linq;
using System.Collections.Generic;
using Android.Views;
using Android.Content;

namespace NavigationQs
{
    [Activity(Label = "NavigationQs", MainLauncher = true, Icon = "@mipmap/ic_launcher", RoundIcon = "@mipmap/ic_launcher_round", Theme = "@style/AppTheme")]
    public class MainActivity : AppCompatActivity, IPermissionsListener
    {

        RecyclerView recyclerView;
        PermissionsManager permissionsManager;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.activity_main);

            var samples = new[]{
                new SampleItem {
            Name = GetString(Resource.String.title_navigation_view_ui),
            Description = GetString(Resource.String.description_navigation_view_ui),
            ActivityType = typeof(NavigationViewActivity)
                },
                    new SampleItem
                    {
                        Name = GetString(Resource.String.title_mock_navigation),
                        Description = GetString(Resource.String.description_mock_navigation),
                        ActivityType = typeof(MockNavigationActivity)
                    },
                    new SampleItem{
                        Name = GetString(Resource.String.title_reroute),
                        Description = GetString(Resource.String.description_reroute),
                            ActivityType = typeof(RerouteActivity)
                    },
                    new SampleItem{
                        Name = GetString(Resource.String.title_navigation_route_ui),
                        Description = GetString(Resource.String.description_navigation_route_ui),
                                ActivityType = typeof(NavigationMapRouteActivity)
                    }};

            // RecyclerView
            recyclerView = FindViewById<RecyclerView>(Resource.Id.recycler_view);
            recyclerView.HasFixedSize = true;

            // Use a linear layout manager
            RecyclerView.LayoutManager layoutManager = new LinearLayoutManager(this);
            recyclerView.SetLayoutManager(layoutManager);

            // Specify an adapter
            RecyclerView.Adapter adapter = new MainAdapter(samples, recyclerView);
            recyclerView.SetAdapter(adapter);

            // Check for location permission
            permissionsManager = new PermissionsManager(this);
            if (!PermissionsManager.AreLocationPermissionsGranted(this))
            {
                recyclerView.Enabled = (false);
                permissionsManager.RequestLocationPermissions(this);
            }
        }

        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, Android.Content.PM.Permission[] grantResults)
        {
            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
            permissionsManager.OnRequestPermissionsResult(requestCode, permissions, grantResults.Cast<int>().ToArray());
        }

        public void OnExplanationNeeded(IList<string> p0)
        {
            Toast.MakeText(this,
                              "This app needs location permissions in order to show its functionality.",
                              ToastLength.Long).Show();
        }

        public void OnPermissionResult(bool granted)
        {
            if (granted)
            {
                recyclerView.Enabled = (true);
            }
            else
            {
                Toast.MakeText(this,
                               "You didn't grant location permissions.",
                               ToastLength.Long).Show();
            }
        }

        /*
         * Recycler view
         */
        class MainAdapter : RecyclerView.Adapter
        {
            IList<SampleItem> samples;
            private readonly RecyclerView recyclerView;

            class ViewHolder : RecyclerView.ViewHolder
            {
                TextView nameView;
                TextView descriptionView;

                public ViewHolder(View view) : base(view)
                {
                    nameView = (TextView)view.FindViewById(Resource.Id.nameView);
                    descriptionView = (TextView)view.FindViewById(Resource.Id.descriptionView);
                }

                public void SetData(SampleItem item)
                {
                    nameView.Text = item.Name;
                    descriptionView.Text = item.Description;
                }
            }

            public MainAdapter(IList<SampleItem> samples, RecyclerView recyclerView)
            {
                this.samples = samples;
                this.recyclerView = recyclerView;
            }

            public override RecyclerView.ViewHolder OnCreateViewHolder(ViewGroup parent, int viewType)
            {
                View view = LayoutInflater.FromContext(parent.Context).Inflate(Resource.Layout.item_main_feature, parent, false);

                view.Click += delegate
            {
                int position = recyclerView.GetChildLayoutPosition(view);
                Intent intent = new Intent(view.Context, samples[position].ActivityType);

                view.Context.StartActivity(intent);
            };

                return new ViewHolder(view);
            }

            public override void OnBindViewHolder(RecyclerView.ViewHolder holder, int position)
            {
                (holder as ViewHolder).SetData(samples[position]);
            }

            public override int ItemCount => samples.Count;
        }
    }
}

