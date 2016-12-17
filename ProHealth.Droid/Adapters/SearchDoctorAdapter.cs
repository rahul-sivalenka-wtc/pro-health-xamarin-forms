using System;
using System.Linq;
using Android.App;
using Android.Views;
using Android.Support.V7.Widget;
using ProHealth.Droid.Helpers;
using ProHealth.Droid.ViewHolders;

namespace ProHealth.Droid.Adapters
{
    public class SearchDoctorAdapter : RecyclerView.Adapter
    {
        // TODO Events region
        public event EventHandler<int> ItemClick;

        // TODO Field region
        public SearchDoctorInfo reportCategories;

        public Activity activity;

        // TODO Properties region
        public override int ItemCount
        {
            get
            {
                return SearchDoctorInfo.MyReportsCategories.Count();
            }
        }

        // TODO Align Ctor, public , override and then private methods.

        // TODO Remove the activity from the adapter.
        public SearchDoctorAdapter(Activity activity, SearchDoctorInfo reportCategories)
        {
            this.activity = activity;
            this.reportCategories = reportCategories;
        }

        public override void OnBindViewHolder(RecyclerView.ViewHolder holder, int position)
        {
            SearchDoctorViewHolder vh = holder as SearchDoctorViewHolder;
            vh.specialityLogo.SetImageResource(reportCategories[position].IconId);
            vh.specialityCount.Text = reportCategories[position].Count.ToString();
            vh.category.Text = reportCategories[position].Name;
        }

        public override RecyclerView.ViewHolder OnCreateViewHolder(ViewGroup parent, int viewType)
        {

            var itemView = LayoutInflater.From(parent.Context).Inflate(Resource.Layout.searchDoctorTemplate, parent, false);
            SearchDoctorViewHolder vh = new SearchDoctorViewHolder(itemView, OnClick);
            return vh;
        }

        void OnClick(int position)
        {
            ItemClick?.Invoke(this, position);
        }
    }
}