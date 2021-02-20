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
        [Inject]
        private ISeriesService _seriesService;

        public event Action<IEnumerable<Series>> SeriesUpdated;

        public IEnumerable<Series> Series { get; private set; }

        public int Count => Series?.Count() ?? 0;

        public Series GetSeries(int index) => Series?.ElementAt(index);

        public async void FetchSeries(int? brandId)
        {
            if (brandId is null)
                return;

            Series = await _seriesService?.GetSeriesAsync(brandId);
            SeriesUpdated?.Invoke(Series);
        }

        public SeriesViewModel()
        {
            if (_seriesService is null)
                _seriesService = App.Container.Get<ISeriesService>();
        }
    }
}