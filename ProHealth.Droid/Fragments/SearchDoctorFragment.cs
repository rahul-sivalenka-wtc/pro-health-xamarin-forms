using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Util;
using Android.Views;
using Android.Widget;
using ProHealth.Core.ViewModels;
using MvvmCross.Droid.Support.V7.Fragging.Attributes;

namespace ProHealth.Droid.Fragments
{

    [MvxFragment(typeof(HomeViewModel), Resource.Id.ViewPager, true)]
    [Register("prohealth.droid.fragments.SearchDoctorFragment")]
    public class SearchDoctorFragment : BaseFragment<SearchDoctorViewModel>
    {
        protected override int FragmentId => Resource.Layout.SearchDoctorView;
    }
}