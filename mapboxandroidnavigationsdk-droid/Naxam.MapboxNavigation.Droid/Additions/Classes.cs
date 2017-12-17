using ARExt = Android.Runtime.Extensions;
namespace Com.Mapbox.Services.Android.Navigation.V5.Navigation
{
    using System.Threading.Tasks;
    using Com.Mapbox.Api.Directions.V5.Models;
    using Square.Retrofit2;
    using Java.Lang;

    public static class NavigationRouteExtensions
    {
        public static Task<DirectionsResponse> GetRouteAsync(this NavigationRoute route)
        {
            var tcs = new TaskCompletionSource<DirectionsResponse>();

            route.GetRoute(new InternallCallback(tcs));

            return tcs.Task;
        }

        class InternallCallback : Java.Lang.Object, ICallback
        {
            readonly TaskCompletionSource<DirectionsResponse> tcs;

            public InternallCallback(TaskCompletionSource<DirectionsResponse> tcs)
            {
                this.tcs = tcs;
            }

            public void OnFailure(ICall p0, Throwable p1)
            {
                tcs.SetException(p1);
            }

            public void OnResponse(ICall p0, Response p1)
            {
                var result = ARExt.JavaCast<DirectionsResponse>(p1.Body());

                tcs.TrySetResult(result);
            }
        }
    }
}

namespace Com.Mapbox.Services.Android.Navigation.V5.Milestone
{
    partial class RouteMilestone
    {
        partial class Builder
        {
            public override Com.Mapbox.Services.Android.Navigation.V5.Milestone.Milestone Build()
            {
                return Build1();
            }

            public override Com.Mapbox.Services.Android.Navigation.V5.Milestone.Milestone.Builder SetTrigger(global::Com.Mapbox.Services.Android.Navigation.V5.Milestone.Trigger.Statement trigger)
            {
                return SetTrigger1(trigger);
            }
        }
    }
    partial class StepMilestone
    {
        partial class Builder
        {
            public override Com.Mapbox.Services.Android.Navigation.V5.Milestone.Milestone Build()
            {
                return Build1();
            }

            public override Com.Mapbox.Services.Android.Navigation.V5.Milestone.Milestone.Builder SetTrigger(global::Com.Mapbox.Services.Android.Navigation.V5.Milestone.Trigger.Statement trigger)
            {
                return SetTrigger1(trigger);
            }
        }
    }
    partial class VoiceInstructionMilestone
    {
        partial class Builder
        {
            public override Com.Mapbox.Services.Android.Navigation.V5.Milestone.Milestone Build()
            {
                return Build1();
            }

            public override Com.Mapbox.Services.Android.Navigation.V5.Milestone.Milestone.Builder SetTrigger(global::Com.Mapbox.Services.Android.Navigation.V5.Milestone.Trigger.Statement trigger)
            {
                return SetTrigger1(trigger);
            }
        }
    }
}