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
    public class Engine
    {
        [JsonProperty("brand")]
        public string Brand { get; set; }

        [JsonProperty("model")]
        public string Model { get; set; }

        [JsonProperty("displacement")]
        public int? Displacement { get; set; }

        [JsonProperty("cyllinders")]
        public int? Cyllinders { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("fuel")]
        public string Fuel { get; set; }

        [JsonProperty("cooling")]
        public string Cooling { get; set; }

        [JsonProperty("hp")]
        public float? Horsepower { get; set; }

        [JsonProperty("tq")]
        public float? Torque { get; set; }

        [JsonProperty("intercooler")]
        public string HasIntercooler { get; set; }

        [JsonProperty("turbo")]
        public string HasTurbo { get; set; }

        [JsonProperty("compressor")]
        public string HasCompressor { get; set; }
    }
}