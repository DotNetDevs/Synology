using System;
using Newtonsoft.Json;

namespace Synology.SurveillanceStation.Info.Results
{
    public class InfoVersion
    {
        public int Major { get; set; }
        public int Minor { get; set; }
        public int Build { get; set; }
    }
}