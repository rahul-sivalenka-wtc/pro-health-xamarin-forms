using System;
using Android;
using Android.App;
using Android.OS;
using Android.Views;
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
        //public override void OnCreate(Bundle savedInstanceState)
        //{
        //    base.OnCreate(savedInstanceState);

        //    // Create your fragment here
        //}

        //public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        //{
        //    // Use this to return your custom view for this Fragment
        //    // return inflater.Inflate(Resource.Layout.YourFragment, container, false);
        //    return inflater.Inflate(Resource.Layout.ProfileView, container, false);
        //}
        protected override int FragmentId => Resource.Layout.ProfileView;
    }
}