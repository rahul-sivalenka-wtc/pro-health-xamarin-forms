using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using ProHealth.Core.ViewModels.SearchDoctor;
using MvvmCross.Droid.Support.V7.Fragging.Attributes;
using ProHealth.Core.ViewModels;
using Android.Support.V7.Widget;
using ProHealth.Droid.Adapters;
using ProHealth.Droid.Helpers;
using Android.Support.V7.App;

namespace ProHealth.Droid.Fragments.SearchDoctor
{
    [MvxFragment(typeof(SearchDoctorViewModel), Resource.Id.SearchDoctorFrame, true)]
    [Register("prohealth.droid.fragments.searchdoctor.SearchDoctorListFragment")]
    public class SearchDoctorListFragment : BaseFragment<SearchDoctorListViewModel>
    {
        protected override int FragmentId => Resource.Layout.SearchDoctorListView;

        private RecyclerView recycler;
        private RecyclerView.LayoutManager layoutMgr;
        private Activity activity;
        private SearchDoctorAdapter blockAdapter;

        private SearchDoctorInfo reportCategories;
        private View view;

        public SearchDoctorInfo Reportcategories
        {
            get
            {
                if (reportCategories == null)
                    reportCategories = new SearchDoctorInfo();
                return reportCategories;
            }
        }

        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            view = base.OnCreateView(inflater, container, savedInstanceState);
            recycler = initRecycler();
            activity = this.Activity;
            return view;
        }
        private RecyclerView initRecycler()
        {
            //Initialize the RecyclerView
            recycler = view.FindViewById<RecyclerView>(Resource.Id.searchDocterRecycler);
            layoutMgr = new GridLayoutManager(activity, 2);
            reportCategories = new SearchDoctorInfo();
            blockAdapter = new SearchDoctorAdapter(activity, reportCategories);
            blockAdapter.ItemClick += OnItemClick;
            recycler.SetLayoutManager(layoutMgr);
            recycler.SetAdapter(blockAdapter);
            return recycler;
        }
        public void OnItemClick(object sender, int e)
        {
            Toast.MakeText(activity, "item" + (e + 1), ToastLength.Short).Show();
            //(this.Activity as AppCompatActivity).SupportFragmentManager.BeginTransaction().AddToBackStack("Message").Add(Resource.Id., new FromUnknownFragment(), "").Commit();

        }
    }
}