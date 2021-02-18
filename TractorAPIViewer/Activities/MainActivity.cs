using Android.App;
using Android.OS;
using Android.Support.V7.App;
using Android.Runtime;
using Android.Widget;
using TractorAPIViewer.Activities;
using TractorAPIViewer.Fragments;
using Android.Support.V4.App;
using Android.Support.V4.Content;
using Com.Airbnb.Lottie;

namespace TractorAPIViewer
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme")]
    public class MainActivity : BaseActivity
    {
        public FrameLayout SpinnerView;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            // Set our view from the "main" layout resource
            Window.RequestFeature(Android.Views.WindowFeatures.NoTitle);

            SetContentView(Resource.Layout.activity_main);

            SpinnerView = FindViewById<FrameLayout>(Resource.Id.spinner);

            CheckForPermission(Android.Manifest.Permission.AccessNetworkState);
            CheckForPermission(Android.Manifest.Permission.Internet);

            if (savedInstanceState == null)
                Navigate(new BrandsFragment());
        }

        private void CheckForPermission(string permission)
        {
            var hasAskedPermissionCall = ActivityCompat.ShouldShowRequestPermissionRationale(this, permission);
            if (ContextCompat.CheckSelfPermission(this, permission) != (int)Android.Content.PM.Permission.Granted)
                ActivityCompat.RequestPermissions(this, new string[] { permission }, 203);
        }
    }
}