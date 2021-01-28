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
using TractorAPIViewer.Interfaces.Holders;

namespace TractorAPIViewer.Adapters
{
    class TsractorAdapter : RecyclerView.Adapter
    {
        ITractorHolder _holder;

        public TsractorAdapter(ITractorHolder holder)
        {
            _holder = holder;
        }

        public override int ItemCount => _holder.VisibleTractors?.Count() ?? 0;

        public override void OnBindViewHolder(RecyclerView.ViewHolder holder, int position)
        {
            throw new NotImplementedException();
        }

        public override RecyclerView.ViewHolder OnCreateViewHolder(ViewGroup parent, int viewType)
        {
            throw new NotImplementedException();
        }

        public class TractorViewHolder : RecyclerView.ViewHolder
        {
            public TractorViewHolder(View itemView) : base(itemView)
            {
            }
        }
    }
}