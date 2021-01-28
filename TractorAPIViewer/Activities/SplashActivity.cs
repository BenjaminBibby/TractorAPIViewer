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
        Theme = "@style/SplashTheme", 
        MainLauncher = true,
        ScreenOrientation = Android.Content.PM.ScreenOrientation.Portrait
        )]
    class SplashActivity : BaseActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Add initial loading of libraries or etc here (e.g. Xamarin.Essentials)

            try
            {
                Intent intent = new Intent(this, typeof(LoaderActivity));

                if (intent != null)
                    intent.SetData(Intent.Data);

                base.StartActivity(intent, savedInstanceState);
                Finish();
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}