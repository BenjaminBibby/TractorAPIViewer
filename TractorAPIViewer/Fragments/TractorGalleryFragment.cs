using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Support.V7.Widget;
using Android.Util;
using Android.Views;
using Android.Widget;
using TractorAPIViewer.Adapters;
using TractorAPIViewer.Models.Tractor;
using TractorAPIViewer.ViewModels;

namespace TractorAPIViewer.Fragments
{
    public class TractorGalleryFragment : BaseFragment<TracorGalleryViewModel>
    {
        private RecyclerView _recyclerView;
        private TractorRecyclerAdapter _adapter;
        private LinearLayoutManager _layoutManager;

        public TractorGalleryFragment() : base(Resource.Layout.fragment_tractor_gallery)
        {
        }

        public override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your fragment here
        }

        protected override void CreateView(View view)
        {
            base.CreateView(view);

            _recyclerView = view.FindViewById<RecyclerView>(Resource.Id.rv_tractors);
            _adapter = new TractorRecyclerAdapter(vm);
            _recyclerView.SetAdapter(_adapter);
            _layoutManager = new LinearLayoutManager(Activity);
            _recyclerView.SetLayoutManager(_layoutManager);
        }

        public override void OnResume()
        {
            base.OnResume();

            //vm.OnTractorFetched += TractorFetched;
            vm.OnTractorsFetched += TractorsFetched;

            vm.OnTractorClicked += TractorClicked;

            // Get all tractors from API of the brand "Volvo BM"
            FetchTractors(Constants.BrandId);
        }

        private void TractorClicked(Tractor obj)
        {
            Toast.MakeText(Activity, obj.InfoFormatted, ToastLength.Short).Show();
        }

        public override void OnPause()
        {
            base.OnPause();

            //vm.OnTractorFetched -= TractorFetched;
            vm.OnTractorsFetched -= TractorsFetched;

            vm.OnTractorClicked -= TractorClicked;
        }

        private void TractorFetched(Tractor tractor)
        {
            Console.WriteLine(tractor?.Model ?? "No Model");
        }

        private void TractorsFetched(IEnumerable<Tractor> tractors)
        {
            Activity.RunOnUiThread(() =>
            {
                vm.VisibleTractors = tractors;
                _adapter.NotifyDataSetChanged();
            });
        }

        private async void FetchTractor(int id)
        {
            await vm.GetTractorAsync(id);
        }

        private async void FetchTractors(int brandId)
        {
            await vm.GetTractorsAsync(brandId);
        }
    }
}