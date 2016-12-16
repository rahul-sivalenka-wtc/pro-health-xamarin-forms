using Android.Runtime;
using MvvmCross.Droid.Support.V7.Fragging.Fragments;
using ProHealth.Core.ViewModels;
using MvvmCross.Droid.Support.V7.Fragging.Attributes;
using Android.Support.V7.Widget;
using Android.App;
using ProHealth.Droid.Helpers;
using Android.Views;
using Android.OS;
using Android.Widget;
using ProHealth.Droid.Adapters;

namespace ProHealth.Droid.Fragments
{
    [MvxFragment(typeof(HomeViewModel), Resource.Id.ViewPager, true)]
    [Register("prohealth.droid.fragments.DoctorsInfoFragment")]
    public class DoctorsInfoFragment : BaseFragment<DoctorsInfoViewModel>
    {
        private RecyclerView recycler;
        private RecyclerView.LayoutManager layoutMgr;
        private Activity activity;
        private DoctorsInfoAdapter blockAdapter;

        private DoctorsInformation doctorsInformation;
        private View view;

        public DoctorsInformation Doctorsinformation
        {
            get
            {
                if (doctorsInformation == null)
                    doctorsInformation = new DoctorsInformation();
                return doctorsInformation;
            }
        }

        protected override int FragmentId => Resource.Layout.DoctorsInfoView;

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
            recycler = view.FindViewById<RecyclerView>(Resource.Id.doctorsRecycler);
            layoutMgr = new LinearLayoutManager(activity);
            doctorsInformation = new DoctorsInformation();
            blockAdapter = new DoctorsInfoAdapter(doctorsInformation, activity);
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