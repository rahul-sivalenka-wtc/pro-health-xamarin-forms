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

        private Button loginButton;

        public override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            ParentActivity.SupportActionBar?.Hide();
        }

        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            var view = base.OnCreateView(inflater, container, savedInstanceState);

            loginButton = view.FindViewById<Button>(Resource.Id.LoginButton);

            WireEvents();
            return view;
        }

        private void WireEvents()
        {
            loginButton.Click += LoginButton_Click;
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            ViewModel.LoginCommand.Execute();
        }

        public override void OnDestroyView()
        {
            base.OnDestroyView();
            UnWireEvents();
        }

        private void UnWireEvents()
        {
            loginButton.Click -= LoginButton_Click;
        }

        public override void OnDestroy()
        {
            base.OnDestroy();
            ParentActivity.SupportActionBar?.Show();
        }
    }
}