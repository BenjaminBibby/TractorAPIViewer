using Android.Support.V7.Widget;
using Android.Views;
using Android.Widget;
using System;
using System.Linq;
using TractorAPIViewer.Interfaces.Holders;
using TractorAPIViewer.Models.Tractor;

namespace TractorAPIViewer.Adapters
{
    class TractorRecyclerAdapter : RecyclerView.Adapter
    {
        ITractorHolder _holder;
        public TractorRecyclerAdapter(ITractorHolder holder)
        {
            _holder = holder;
        }

        // Create new views (invoked by the layout manager)
        public override RecyclerView.ViewHolder OnCreateViewHolder(ViewGroup parent, int viewType)
        {
            //Setup your layout here
            View itemView = null;
            var id = Resource.Layout.item_tractor_card;
            itemView = LayoutInflater.From(parent.Context).
                   Inflate(id, parent, false);

            var vh = new TractorRecyclerAdapterViewHolder(itemView, OnClick);
            return vh;
        }

        // Replace the contents of a view (invoked by the layout manager)
        public override void OnBindViewHolder(RecyclerView.ViewHolder viewHolder, int position)
        {
            var item = GetEntry(position);   //items[position];

            // Replace the contents of the view with that element
            var holder = viewHolder as TractorRecyclerAdapterViewHolder;
            holder.Tractor = item;
            holder.TvTitle.Text = item.InfoFormatted;
        }

        public override int ItemCount => _holder?.VisibleTractors?.Count() ?? 0;

        public Tractor GetEntry(int position) => _holder?.VisibleTractors?.ElementAt(position);

        void OnClick(Tractor tractor) => _holder?.TractorClicked(tractor);
    }

    public class TractorRecyclerAdapterViewHolder : RecyclerView.ViewHolder
    {
        public Tractor Tractor { get; set; }
        public TextView TvTitle { get; set; }


        public TractorRecyclerAdapterViewHolder(
            View itemView,
            Action<Tractor> clickListener
            ) : base(itemView)
        {
            TvTitle = ItemView.FindViewById<TextView>(Resource.Id.tv_title);
            itemView.Click += (sender, e) => clickListener(Tractor);
        }
    }

    public class TractorRecyclerAdapterClickEventArgs : EventArgs
    {
        public View View { get; set; }
        public int Position { get; set; }
    }
}