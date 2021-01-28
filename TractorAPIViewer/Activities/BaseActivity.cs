using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Support.V7.App;
using Android.Views;
using Android.Widget;
using Ninject;
using TractorAPIViewer.ViewModels;

namespace TractorAPIViewer.Activities
{
    [Activity(Label = "BaseActivity")]
    public class BaseActivity : AppCompatActivity
    {
        protected readonly BaseViewModel vm;
        protected Fragment CurrentFragment;

        public BaseActivity()
        {
            vm = App.Container.Get<BaseViewModel>();
        }

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
        }

        public void Navigate(Fragment fragment, bool addToStack = true)
        {
            CurrentFragment = fragment;

            var ft = FragmentManager.BeginTransaction();

            if (addToStack)
                ft.AddToBackStack(fragment.Class.SimpleName);

            ft.Replace(Resource.Id.content, fragment, "tag");
            ft.Commit();
        }
    }

    [Activity(Label = "BaseActivity")]
    public class BaseActivity<T> : BaseActivity where T : BaseViewModel
    {
        protected new T vm;

        public BaseActivity()
        {
            vm = App.Container.Get<T>();
        }
    }
}