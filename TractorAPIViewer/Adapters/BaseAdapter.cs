using Android.Support.V7.Widget;
using Android.Views;
using Android.Widget;
using System;

namespace TractorAPIViewer.Adapters
{
    public abstract class BaseAdapter<T, VH> : RecyclerView.Adapter where VH : BaseAdapterViewHolder<T>
    {
        protected int _resourceId;
        public event Action<T> ItemClick;
        public event Action<T> ItemLongClick;

        public BaseAdapter(int resourceId)
        {
            _resourceId = resourceId;
        }

        public abstract int Count { get; }
        public abstract T GetEntry(int index);

        // Create new views (invoked by the layout manager)
        public override RecyclerView.ViewHolder OnCreateViewHolder(ViewGroup parent, int viewType)
        {
            View itemView = LayoutInflater.From(parent.Context).Inflate(_resourceId, parent, false);

            var vh = CreateViewHolder(itemView, OnClick, OnLongClick); 
            return vh;
        }

        protected abstract VH CreateViewHolder(View itemView, Action<T> clickListener, Action<T> clickLongListener);

        protected VH CreateViewHolderFromFunc(
            Func<View, Action<T>, Action<T>, VH> func, 
            View itemView, 
            Action<T> clickListener,
            Action<T> clickLongListener
            ) => func?.Invoke(itemView, clickListener, clickLongListener);

        // Replace the contents of a view (invoked by the layout manager)
        public override void OnBindViewHolder(RecyclerView.ViewHolder viewHolder, int position)
        {
            var item = GetEntry(position);

            // Replace the contents of the view with that element
            var holder = viewHolder as VH;
            holder?.Bind(item);
        }

        public override int ItemCount => Count;

        void OnClick(T args) => ItemClick?.Invoke(args);
        void OnLongClick(T args) => ItemLongClick?.Invoke(args);

    }

    public class BaseAdapterViewHolder<T> : RecyclerView.ViewHolder
    {
        protected T _value;
        public BaseAdapterViewHolder(
            View itemView, 
            Action<T> clickListener,
            Action<T> longClickListener = null) : base(itemView)
        {
            ItemView = itemView;
            itemView.Click += (sender, e) => clickListener(_value);
            itemView.LongClick += (sender, e) => longClickListener(_value);
        }

        public virtual void Bind(T item)
        {
            _value = item;
        }
    }
}