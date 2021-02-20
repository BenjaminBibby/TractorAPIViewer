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
    public interface ISeriesHolder
    {
        IEnumerable<Series> Series { get; }
        int Count { get; }
        Series GetSeries(int index);

        event Action<IEnumerable<Series>> SeriesUpdated;

        void FetchSeries(int? brandId);
    }
}