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
using MvvmCross.Droid.Support.V7.Fragging.Attributes;
using ProHealth.Core.ViewModels;

namespace ProHealth.Droid.Fragments
{
    [MvxFragment(typeof(MainViewModel), Resource.Id.root, true)]
    [Register("prohealth.droid.fragments.LoginViewFragment")]
    public class LoginViewFragment : BaseFragment<LoginViewModel>
    {
        protected override int FragmentId => Resource.Layout.LoginView;

        public override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            ParentActivity.SupportActionBar?.Hide();
        }

        public override void OnDestroy()
        {
            base.OnDestroy();
            ParentActivity.SupportActionBar?.Show();
        }
    }
}