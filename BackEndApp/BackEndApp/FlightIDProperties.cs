using OpenTelemetry.Trace;
using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;

namespace BackEndApp
{
    public class FlightIDProperties : ActivityProcessor
    {
        public override void OnStart(Activity activity)
        {
            foreach (var b in Activity.Current.Baggage)
            {
                activity.AddTag(b.Key, b.Value);
            }
        }

        public override void OnEnd(Activity activity)
        {
        }

        public override Task ShutdownAsync(CancellationToken cancellationToken)
        {
            return Task.CompletedTask;
        }

        public override Task ForceFlushAsync(CancellationToken cancellationToken)
        {
            return Task.CompletedTask;
        }
    }
}
