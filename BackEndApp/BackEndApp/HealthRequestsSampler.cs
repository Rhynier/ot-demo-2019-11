using OpenTelemetry.Trace;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace BackEndApp
{
    public class HealthRequestsSampler : Sampler
    {
        public HealthRequestsSampler()
        {
            Description = "HealthRequestSampler";
        }

        public override SamplingResult ShouldSample(in SamplingParameters samplingParameters)
        {
            if (samplingParameters.Name == "/health")
            {
                return new SamplingResult(false);
            }

            return new SamplingResult(true);
        }
    }
}
