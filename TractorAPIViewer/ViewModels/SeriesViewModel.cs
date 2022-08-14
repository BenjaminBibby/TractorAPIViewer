using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Ninject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TractorAPIViewer.Interfaces.Holders;
using TractorAPIViewer.Models.Tractor;
using TractorAPIViewer.Services.Interfaces;

namespace TractorAPIViewer.ViewModels
{
    public class SeriesViewModel : BaseViewModel, ISeriesHolder
    {
        private ISeriesService SeriesService { get; }

        public event Action<IEnumerable<Series>> SeriesUpdated;

        public IEnumerable<Series> Series { get; private set; }

        public int Count => Series?.Count() ?? 0;

        public Series GetSeries(int index) => Series?.ElementAt(index);

        public async void FetchSeries(int? brandId)
        {
            if (brandId is null)
                return;

            Series = await SeriesService?.GetSeriesAsync(brandId);
            SeriesUpdated?.Invoke(Series);
        }

        [Inject]
        public SeriesViewModel(ISeriesService seriesService)
        {
            SeriesService = seriesService;
        }
    }
}