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

namespace TractorAPIViewer
{
    public class Constants
    {
        public static string BaseUrl => @"http://api.shelfdex.com/";
        public static string ApiKey => @"TestKey";
        public static int BrandId => 4;

        public static string TractorUrl => $@"{BaseUrl}products/read.php?cat=tractor&key={ApiKey}";
        public static string BrandsUrl => $@"{BaseUrl}products/read.php?cat=brand&key={ApiKey}";
        public static string SeriesUrl => $@"{BaseUrl}products/read.php?cat=series&key={ApiKey}";
    }
}