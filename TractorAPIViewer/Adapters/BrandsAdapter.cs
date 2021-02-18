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
    public class BrandsAdapter : BaseAdapter<Brand, BrandsViewHolder>
    {
        IBrandHolder _holder;
        public BrandsAdapter(IBrandHolder holder) : base(Resource.Layout.item_tractor_card)
        {
            _holder = holder;
        }

        public override int Count => _holder?.BrandCount ?? 0;

        public override Brand GetEntry(int index) => _holder?.GetBrand(index);

        protected override BrandsViewHolder CreateViewHolder(
            View itemView,
            Action<Brand> clickListener,
            Action<Brand> clickLongListener
            )
        => CreateViewHolderFromFunc(
            (v, c, cl) => new BrandsViewHolder(v, c, cl),
            itemView,
            clickListener,
            clickLongListener
            );
    }

    public class BrandsViewHolder : BaseAdapterViewHolder<Brand>
    {
        public TextView TvTitle { get; set; }

        public BrandsViewHolder(
            View itemView, 
            Action<Brand> clickListener, 
            Action<Brand> longClickListener = null) 
            : base(itemView, clickListener, longClickListener)
        {
            TvTitle = ItemView.FindViewById<TextView>(Resource.Id.tv_title);
        }

        public override void Bind(Brand item)
        {
            base.Bind(item);

            if(TvTitle != null)
                TvTitle.Text = item.Name;
        }
    }
}