using MvvmCross.Droid.Support.V7.Fragging.Fragments;
using ProHealth.Core.ViewModels;
using MvvmCross.Droid.Support.V7.Fragging.Attributes;
using Android.Runtime;

namespace ProHealth.Droid.Fragments
{
    [MvxFragment(typeof(HomeViewModel), Resource.Id.ViewPager, true)]
    [Register("prohealth.droid.fragments.ProfileFragment")]
    public class ProfileFragment : BaseFragment<ProfileViewModel>
    {
        protected override int FragmentId => Resource.Layout.ProfileView;
    }
}