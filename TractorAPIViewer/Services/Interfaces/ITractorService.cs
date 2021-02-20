using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using TractorAPIViewer.Models.Tractor;

namespace TractorAPIViewer.Services.Interfaces
{
    public interface ITractorService
    {
        Task<IEnumerable<Tractor>> GetTractorsAsync(int seriesId);

        Task<IEnumerable<Tractor>> GetTractorsFromSeriesAsync(int seriesId);
        
        Task<IEnumerable<Tractor>> GetTractorsFromBrandAsync(int brandId);

        Task<Tractor> GetTractorAsync(int id);

        Task<IEnumerable<Brand>> GetTractorBrandsAsync();
    }
}