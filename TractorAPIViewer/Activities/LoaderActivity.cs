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

namespace TractorAPIViewer.Activities
{
    [Activity(
        Label = "LoaderActivity",
        Theme = "@style/LoaderTheme",
        ScreenOrientation = Android.Content.PM.ScreenOrientation.Portrait
        )]
    class LoaderActivity : BaseActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.activity_loading);

            Intent intent = new Intent(this, typeof(MainActivity));

            StartActivity(intent);
            Finish();
        }
    }
}