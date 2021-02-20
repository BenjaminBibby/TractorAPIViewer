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
using System.Threading.Tasks;
using TractorAPIViewer.Models.Tractor;

namespace TractorAPIViewer.Services.Interfaces
{
    public interface ISeriesService
    {
        Task<IEnumerable<Series>> GetSeriesAsync(int? brandId);
    }
}