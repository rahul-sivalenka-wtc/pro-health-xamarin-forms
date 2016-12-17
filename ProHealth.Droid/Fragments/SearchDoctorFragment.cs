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
using Android.Support.V7.App;
using ProHealth.Droid.Fragments.SearchDoctor;

namespace ProHealth.Droid.Fragments
{

    [MvxFragment(typeof(HomeViewModel), Resource.Id.ViewPager, true)]
    [Register("prohealth.droid.fragments.SearchDoctorFragment")]
    public class SearchDoctorFragment : BaseFragment<SearchDoctorViewModel>
    {
        protected override int FragmentId => Resource.Layout.SearchDoctorView;

        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            var view =  base.OnCreateView(inflater, container, savedInstanceState);

            return view;
        }

        public override void OnViewCreated(View view, Bundle savedInstanceState)
        {
            base.OnViewCreated(view, savedInstanceState);
            //ViewModel.ShowList();
            (this.Activity as AppCompatActivity).SupportFragmentManager.BeginTransaction().AddToBackStack("Message").Add(Resource.Id.SearchDoctorFrame, new SearchDoctorListFragment(), "Message").Commit();
        }
    }
}
