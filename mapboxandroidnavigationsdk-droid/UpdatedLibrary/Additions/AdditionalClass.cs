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
namespace Com.Mapbox.Services.Android.Navigation.V5.Milestone
{
    public partial class RouteMilestone
    {

        public new sealed partial class Builder
        {
            public override Milestone Build()
            {
                return RouteBuild();
            }
            public override Milestone.Builder SetTrigger(Trigger.Statement p0)
            {
                return RouteSetTrigger(p0);
            }
        }
    }

    public partial class StepMilestone
    {

        public new sealed partial class Builder
        {
            public override Milestone Build()
            {
                return StepMilestoneBuild();
            }

            public override Milestone.Builder SetTrigger(Trigger.Statement p0)
            {
                return StepMilestonSetTrigger(p0);
            }

        }
    }

    public partial class VoiceInstructionMilestone
    {

        public new sealed partial class Builder
        {
            public override Milestone Build()
            {
                return VoiceBuild();
            }

            public override Milestone.Builder SetTrigger(Trigger.Statement p0)
            {
                return VoiceSetTrigger(p0);
            }

        }
    }

}
