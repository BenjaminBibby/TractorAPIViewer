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
    public class Tractor : DBItem
    {
        [JsonProperty("year_pro")]
        public int? YearProduced { get; set; }

        [JsonProperty("year_end")]
        public int? YearEnded { get; set; }

        [JsonProperty("model")]
        public string Model { get; set; }

        [JsonProperty("brand")]
        public string Brand { get; set; }

        [JsonProperty("series")]
        public string Series { get; set; }

        [JsonProperty("category")]
        public string Category { get; set; }

        [JsonProperty("pto_rpm")]
        public int PTO { get; set; }

        [JsonProperty("awd")]
        public string AllWheelDrive { get; set; }

        [JsonProperty("engine")]
        public Engine Engine { get; set; }

        [JsonProperty("transmission")]
        public Transmission Transmission { get; set; }

        [JsonProperty("wheels")]
        public WheelSet Wheels { get; set; }

        [JsonIgnore]
        public string InfoFormatted => $"{Brand} {Model} ({Engine.Horsepower}hp, {YearProduced}-{YearEnded})";
    }
}