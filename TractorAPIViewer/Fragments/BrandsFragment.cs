using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Support.V7.Widget;
using Android.Util;
using Android.Views;
using Android.Widget;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TractorAPIViewer.Adapters;
using TractorAPIViewer.ViewModels;

namespace TractorAPIViewer.Fragments
{
    public class BrandsFragment : BaseFragment<BrandsViewModel>
    {
        private RecyclerView _recyclerView;
        private BrandsAdapter _adapter;
        private LinearLayoutManager _layoutManager;

        public BrandsFragment() : base(Resource.Layout.fragment_tractor_gallery)
        {
        }

        protected override void CreateView(View view)
        {
            base.CreateView(view);

            _recyclerView = view.FindViewById<RecyclerView>(Resource.Id.rv_tractors);
            _adapter = new BrandsAdapter(vm);
            _recyclerView.SetAdapter(_adapter);
            _layoutManager = new LinearLayoutManager(Activity);
            _recyclerView.SetLayoutManager(_layoutManager);
        }

        public override void OnResume()
        {
            base.OnResume();

            vm.OnBrandsUpdated += BrandsUpdated;

            _adapter.ItemClick += AdapterItemClick;

            vm.FetchBrands();
        }

        public override void OnPause()
        {
            base.OnPause();

            vm.OnBrandsUpdated -= BrandsUpdated;

            _adapter.ItemClick -= AdapterItemClick;
        }

        private void BrandsUpdated(IEnumerable<Models.Tractor.Brand> brands)
        {
            Activity?.RunOnUiThread(() => { 
                _adapter.NotifyDataSetChanged();
            });
        }

        private void AdapterItemClick(Models.Tractor.Brand brand)
        {
            if (brand is null)
                return;

            if(brand.Id != null)
                Navigate(new SeriesFragment(brand.Id.Value));
        }
    }
}