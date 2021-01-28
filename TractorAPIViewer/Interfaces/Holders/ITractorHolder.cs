using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TractorAPIViewer.Models.Tractor;

namespace TractorAPIViewer.Interfaces.Holders
{
    public interface ITractorHolder
    {
        IEnumerable<Tractor> Tractors { get; set; }
        IEnumerable<Tractor> VisibleTractors { get; set; }

        // Click event
        event Action<Tractor> OnTractorClicked;

        // Fetch events
        event Action<Tractor> OnTractorFetched;                 // Single tractor
        event Action<IEnumerable<Tractor>> OnTractorsFetched;   // Collection of tractors

        void TractorClicked(Tractor tractor);
    }
}