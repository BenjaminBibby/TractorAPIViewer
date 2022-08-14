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
using System.Threading.Tasks;
using TractorAPIViewer.Models.Tractor;
using TractorAPIViewer.Services.Interfaces;

namespace TractorAPIViewer.Services
{
    public class SeriesService : ISeriesService
    {
        [Inject]
        public SeriesService() { 
        }

        public async Task<IEnumerable<Series>> GetSeriesAsync(int? brandId)
        {
            if (brandId is null)
                return null;

            var series = await BaseService.Instance.Get<ItemCollection<Series>>(Constants.SeriesUrl + @$"&id={brandId.Value}");
            return series.Items;
        }
    }
}