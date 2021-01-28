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

namespace TractorAPIViewer.ViewModels
{
    public class BaseViewModel
    {
        public virtual string Title => "Tractor API";
        public string Yes => "Yes";
        public string No => "No";
        public string Cancel => "Cancel";

        // Spinner events
        public event Action OnStartSpinner, OnStopSpinner;

        public void StartSpinner()
        {
            // Start spinner
            OnStartSpinner?.Invoke();
        }

        public void StopSpinner()
        {
            // Stop spinner
            OnStopSpinner?.Invoke();
        }
    }
}