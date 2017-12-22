using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Com.Mapbox.Services.Android.Navigation.V5.Instruction;
using Com.Mapbox.Services.Android.Navigation.V5.Routeprogress;

namespace NavigationQs
{
    class IInstruction : Instruction
    {
        public override string BuildInstruction(RouteProgress routeProgress)
        {
            return routeProgress.CurrentLegProgress().UpComingStep().Maneuver().Instruction();
        }
    }
}