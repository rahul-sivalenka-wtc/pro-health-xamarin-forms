using Android.App;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using ProHealth.Core.ViewModels;
using MvvmCross.Droid.Support.V7.Fragging.Attributes;
using Android.Support.V7.Widget;
using ProHealth.Droid.Adapters;
using ProHealth.Droid.Helpers;

namespace ProHealth.Droid.Fragments
{
    [MvxFragment(typeof(HomeViewModel), Resource.Id.ViewPager, true)]
    [Register("prohealth.droid.fragments.RecordsFragment")]
    public class RecordsFragment : BaseFragment<RecordsViewModel>
    {
        private RecyclerView recycler;
        private RecyclerView.LayoutManager layoutMgr;
        private Activity activity;
        private BlockAdapter blockAdapter;


        private CategoriesOfReports reportCategories;
        private View view;

        public CategoriesOfReports Reportcategories
        {
            get
            {
                if (reportCategories == null)
                    reportCategories = new CategoriesOfReports();
                return reportCategories;
            }
        }

        protected override int FragmentId => Resource.Layout.RecordsView;

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
            recycler = view.FindViewById<RecyclerView>(Resource.Id.BlockRecycler);
            layoutMgr = new GridLayoutManager(activity,2);
            reportCategories = new CategoriesOfReports();
            blockAdapter = new BlockAdapter(activity, reportCategories);
            blockAdapter.ItemClick += OnItemClick;
            recycler.SetLayoutManager(layoutMgr);
            recycler.SetAdapter(blockAdapter);
            return recycler;
        }
        public void OnItemClick(object sender, int e)
        {
            Toast.MakeText(activity, "item" + (e + 1), ToastLength.Short).Show();
        }
    }
}