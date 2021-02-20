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
using TractorAPIViewer.Interfaces.Holders;
using TractorAPIViewer.Models.Tractor;

namespace TractorAPIViewer.Adapters
{
    public class SeriesAdapter : BaseAdapter<Series, SeriesViewHolder>
    {
        private ISeriesHolder _holder;

        public SeriesAdapter(ISeriesHolder holder) : base(Resource.Layout.item_tractor_card)
        {
            _holder = holder;
        }

        public override int Count => _holder?.Count ?? 0;

        public override Series GetEntry(int index) => _holder?.GetSeries(index);

        protected override SeriesViewHolder CreateViewHolder(
            View itemView,
            Action<Series> clickListener,
            Action<Series> clickLongListener
            )
        => CreateViewHolderFromFunc(
            (v, c, cl) => new SeriesViewHolder(v, c, cl),
            itemView,
            clickListener,
            clickLongListener
            );
    }
    public class SeriesViewHolder : BaseAdapterViewHolder<Series>
    {
        public TextView TvTitle { get; set; }

        public SeriesViewHolder(
            View itemView,
            Action<Series> clickListener,
            Action<Series> longClickListener = null)
            : base(itemView, clickListener, longClickListener)
        {
            TvTitle = ItemView.FindViewById<TextView>(Resource.Id.tv_title);
        }

        public override void Bind(Series item)
        {
            base.Bind(item);

            if (TvTitle != null)
                TvTitle.Text = item.Name;
        }
    }
}