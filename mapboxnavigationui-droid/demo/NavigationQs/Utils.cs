using System;
using Android.Content;
using Android.Graphics;
using Android.Support.V4.Content.Res;
using Com.Mapbox.Mapboxsdk;
using Com.Mapbox.Mapboxsdk.Annotations;
using Com.Mapbox.Mapboxsdk.Geometry;

namespace NavigationQs
{
    public class Utils
    {
        /**
   * <p>
   * Returns the Mapbox access token set in the app resources.
   * </p>
   * It will first search for a token in the Mapbox object. If not found it
   * will then attempt to load the access token from the
   * {@code res/values/dev.xml} development file.
   *
   * @param context The {@link Context} of the {@link android.app.Activity} or {@link android.app.Fragment}.
   * @return The Mapbox access token or null if not found.
   */
        public static String GetMapboxAccessToken(Context context)
        {
            try
            {
                // Read out AndroidManifest
                String token = Mapbox.AccessToken;
                if (string.IsNullOrWhiteSpace(token))
                {
                    throw new InvalidOperationException();
                }
                return token;
            }
            catch (Exception exception)
            {
                // Use fallback on string resource, used for development
                int tokenResId = context.Resources.GetIdentifier("mapbox_access_token", "string", context.PackageName);
                return tokenResId != 0 ? context.GetString(tokenResId) : null;
            }
        }

        /**
         * Demonstrates converting any Drawable to an Icon, for use as a marker icon.
         */
        public static Icon drawableToIcon(Context context, int id)
        {
            var vectorDrawable = ResourcesCompat.GetDrawable(context.Resources, id, context.Theme);
            var bitmap = Bitmap.CreateBitmap(vectorDrawable.IntrinsicWidth, vectorDrawable.IntrinsicHeight, Bitmap.Config.Argb8888);
            var canvas = new Canvas(bitmap);
            vectorDrawable.SetBounds(0, 0, canvas.Width, canvas.Height);
            vectorDrawable.Draw(canvas);
            return IconFactory.GetInstance(context).FromBitmap(bitmap);
        }

        public static LatLng GetRandomLatLng(double[] bbox)
        {
            Random random = new Random();

            double randomLat = bbox[1] + (bbox[3] - bbox[1]) * random.NextDouble();
            double randomLon = bbox[0] + (bbox[2] - bbox[0]) * random.NextDouble();

            LatLng latLng = new LatLng(randomLat, randomLon);
            System.Diagnostics.Debug.WriteLine("getRandomLatLng: {0}", latLng);
            return latLng;
        }
    }
}
