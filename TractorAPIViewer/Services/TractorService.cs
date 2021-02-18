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
using TractorAPIViewer.Services.Interfaces;

namespace TractorAPIViewer.Services
{
    public class TractorService : ITractorService
    {
        public TractorService()
        {

        }

        public async Task<IEnumerable<Brand>> GetTractorBrandsAsync()
        {
            var brands = await BaseService.Instance.Get<ItemCollection<Brand>>(Constants.BrandsUrl + $"&id=8");
            return brands.Items;
        }

        /// <summary>
        /// Get a single tractor from API
        /// </summary>
        /// <returns></returns>
        public async Task<Tractor> GetTractorAsync(int id)
        {
            var tractor = await BaseService.Instance.Get<ItemCollection<Tractor>>(Constants.TractorUrl + $"&id={id}");
            return tractor.Items.FirstOrDefault();
        }

        /// <summary>
        /// Get all tractors from API
        /// </summary>
        /// <returns></returns>
        public async Task<IEnumerable<Tractor>> GetTractorsAsync(int brandId)
        {
            var tractors = await BaseService.Instance.Get<ItemCollection<Tractor>>(Constants.TractorUrl + $"&sr={brandId}");
            return tractors.Items;
        }
    }
}