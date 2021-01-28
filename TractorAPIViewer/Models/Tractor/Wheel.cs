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
    public class Wheel
    {
        [JsonProperty("inner")]
        public float Inner{ get; set; }

        [JsonProperty("outer")]
        public float Outer { get; set; }
    }
}