﻿using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TractorAPIViewer.Models.Tractor
{
    public class Series
    {
        [JsonProperty("id")]
        public int? Id { get; set; }

        [JsonProperty("series")]
        public string Name { get; set; }
    }
}