using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Util;
using Android.Views;
using Android.Widget;
using Ninject;
using TractorAPIViewer.Activities;
using TractorAPIViewer.ViewModels;

namespace TractorAPIViewer.Fragments
{
    public class BaseFragment : Fragment
    {
        public BaseActivity ActivityAsBase => (BaseActivity)Activity;
        public string BaseTag => Guid.NewGuid().ToString();

        public BaseFragment()
        {
        }

        public override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your fragment here
        }

        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            // Use this to return your custom view for this Fragment
            // return inflater.Inflate(Resource.Layout.YourFragment, container, false);

            return base.OnCreateView(inflater, container, savedInstanceState);
        }

        public void Navigate(Fragment fragment, bool addToStack = true)
        {
            // Cancel navigation if Activity is null
            if (Activity == null)
                return;

            FragmentTransaction ft = Activity.FragmentManager.BeginTransaction();

            if (addToStack)
                ft.AddToBackStack(fragment.Class.SimpleName);

            ft.Replace(Resource.Id.content, fragment, BaseTag);
            ft.Commit();
        }
    }

    public class BaseFragment<T> : BaseFragment where T : BaseViewModel
    {
        protected readonly T vm;
        protected int _resourceId;

        public BaseFragment(int resourceId)
        {
            vm = App.Container.Get<T>();
            _resourceId = resourceId;
        }

        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            var view = inflater.Inflate(_resourceId, container, false);

            CreateView(view);

            return view;
        }

        protected virtual void CreateView(View view)
        { 
            // Override this
        }

        public override void OnResume()
        {
            base.OnResume();

            vm.OnStartSpinner += StartSpinner;
            vm.OnStopSpinner += StopSpinner;
        }

        public override void OnPause()
        {
            base.OnPause();

            vm.OnStartSpinner -= StartSpinner;
            vm.OnStopSpinner -= StopSpinner;
        }

        private void StartSpinner()
        {
            //
            if (ActivityAsBase is MainActivity act)
                act.SpinnerView.Visibility = ViewStates.Visible;
        }

        private void StopSpinner()
        {
            //
            if (ActivityAsBase is MainActivity act)
                act.SpinnerView.Visibility = ViewStates.Invisible;
        }
    }
}