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
using Newtonsoft.Json;

namespace TractorAPIViewer.Models.Tractor
{
    public class Transmission
    {
        [JsonProperty("speed_max")]
        public float? MaxSpeed { get; set; }

        [JsonProperty("speed_min")]
        public float? MinSpeed { get; set; }

        [JsonProperty("gears_forward")]
        public int? GearsForward { get; set; }

        [JsonProperty("gears_reverse")]
        public int? GearsReverse { get; set; }
    }
}