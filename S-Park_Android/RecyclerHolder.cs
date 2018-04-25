using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Support.V7.Widget;
using Android.Views;
using Android.Widget;

namespace S_Park_Android
{
    public class RecyclerHolder : RecyclerView.ViewHolder, View.IOnClickListener, View.IOnLongClickListener
    {

        public TextView Caption { get; private set; }
        private IItemClickListener itemClickListener;
        public RecyclerHolder(View itemView) : base(itemView)
        {
            Caption = itemView.FindViewById<TextView>(Resource.Id.textView);
            itemView.SetOnClickListener(this);
            ItemView.SetOnLongClickListener(this);
        }

        public void SetItemClickListener(IItemClickListener itemClickListener)
        {
            this.itemClickListener = itemClickListener;

        }
        public void OnClick(View v)
        {
            itemClickListener.Onclick(v, AdapterPosition, false);
        }

        public bool OnLongClick(View v)
        {
            itemClickListener.Onclick(v, AdapterPosition, true);
            return true;
        }
    }
}