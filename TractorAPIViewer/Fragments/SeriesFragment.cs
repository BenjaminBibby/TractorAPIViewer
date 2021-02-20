using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Support.V7.Widget;
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
    public class SeriesFragment : BaseFragment<SeriesViewModel>
    {
        private int? _seriesId;

        private RecyclerView _recyclerView;
        private SeriesAdapter _adapter;
        private LinearLayoutManager _layoutManager;

        public SeriesFragment() : base(Resource.Layout.fragment_tractor_gallery)
        {
        }

        public SeriesFragment(int? seriesId) : this()
        {
            _seriesId = seriesId;
        }

        protected override void CreateView(View view)
        {
            base.CreateView(view);

            _recyclerView = view.FindViewById<RecyclerView>(Resource.Id.rv_tractors);
            _adapter = new SeriesAdapter(vm);
            _recyclerView.SetAdapter(_adapter);
            _layoutManager = new LinearLayoutManager(Activity);
            _recyclerView.SetLayoutManager(_layoutManager);
        }
        public override void OnResume()
        {
            base.OnResume();

            vm.SeriesUpdated += OnSeriesUpdated;

            _adapter.ItemClick += AdapterItemClick;

            vm.FetchSeries(_seriesId.Value);
        }

        public override void OnPause()
        {
            base.OnPause();

            vm.SeriesUpdated -= OnSeriesUpdated;

            _adapter.ItemClick -= AdapterItemClick;
        }

        private void OnSeriesUpdated(IEnumerable<Models.Tractor.Series> series)
        {
            Activity?.RunOnUiThread(() => {
                _adapter.NotifyDataSetChanged();
            });
        }

        private void AdapterItemClick(Models.Tractor.Series series)
        {
            if (series is null)
                return;

            if (series.Id != null)
                Navigate(new TractorGalleryFragment(series.Id.Value));
        }
    }
}