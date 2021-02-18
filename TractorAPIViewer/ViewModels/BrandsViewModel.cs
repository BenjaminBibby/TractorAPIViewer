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
    public class BrandsViewModel : BaseViewModel, IBrandHolder
    {
        public override string Title => "Tractor Brands";

        public IEnumerable<Brand> Brands { get; private set; }

        public int BrandCount => Brands?.Count() ?? 0;

        [Inject]
        public ITractorService tractorService;

        public event Action<IEnumerable<Brand>> OnBrandsUpdated;

        public BrandsViewModel()
        {
            if (tractorService == null)
                tractorService = App.Container.Get<ITractorService>();
        }

        public async void FetchBrands()
        {
            Brands = await tractorService?.GetTractorBrandsAsync();
            OnBrandsUpdated?.Invoke(Brands);
        }

        public Brand GetBrand(int index) => Brands?.ElementAt(index);
    }
}