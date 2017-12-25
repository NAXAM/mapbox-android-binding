using System;
using Android.App;
using Android.Runtime;
using Com.Mapbox.Mapboxsdk;

namespace NavigationQs
{
    [Application(Icon = "@mipmap/ic_launcher", RoundIcon = "@mipmap/ic_launcher_round", Theme = "@style/AppTheme")]
    public class NavQsApplication  : Application
    {
        public NavQsApplication(IntPtr handle, JniHandleOwnership transfer)
            : base(handle, transfer)
        {
        }

        public override void OnCreate()
        {
            base.OnCreate();

            String mapboxAccessToken = Utils.GetMapboxAccessToken(ApplicationContext);
            if (string.IsNullOrWhiteSpace(mapboxAccessToken) || string.Equals(mapboxAccessToken, "YOUR_MAPBOX_ACCESS_TOKEN"))
            {
                throw new InvalidOperationException("Please configure your Mapbox access token");
            }

            Mapbox.GetInstance(ApplicationContext, mapboxAccessToken);
        }
    }
}
