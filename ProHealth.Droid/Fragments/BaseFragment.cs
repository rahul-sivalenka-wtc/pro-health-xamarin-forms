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
using MvvmCross.Droid.Support.V7.Fragging.Fragments;
using MvvmCross.Droid.Support.V7.AppCompat;
using MvvmCross.Core.ViewModels;
using FragmentTransaction = Android.Support.V4.App.FragmentTransaction;
using Fragment = Android.Support.V4.App.Fragment;
using MvvmCross.Binding.Droid.BindingContext;

namespace ProHealth.Droid.Fragments
{
    public abstract class BaseFragment : MvxFragment
    {
        protected BaseFragment()
        {
            RetainInstance = true;
        }

        protected abstract int FragmentId { get; }
        private const string DialogFragmentTag = "dialog";

        public MvxCachingFragmentCompatActivity ParentActivity => (MvxCachingFragmentCompatActivity)Activity;

        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            base.OnCreateView(inflater, container, savedInstanceState);
            return this.BindingInflate(FragmentId, null);
        }

        protected CustomDialogInfo CreateDialog(int layoutId, string dialogTag, string title = null)
        {
            FragmentTransaction ft = FragmentManager.BeginTransaction();
            //Remove fragment else it will crash as it is already added to backstack
            Fragment prev = FragmentManager.FindFragmentByTag(dialogTag);
            if (prev != null)
            {
                ft.Remove(prev);
            }

            ft.AddToBackStack(null);

            // Create and show the dialog.
            CustomDialogFragment dialog = CustomDialogFragment.NewInstance(layoutId, null);

            //Add fragment
            //newFragment.Show(ft, "dialog");
            
            return new CustomDialogInfo
            {
                Dialog = dialog,
                DialogTag = dialogTag,
                FragmentTransaction = ft
            };
        }
    }

    public abstract class BaseFragment<TViewModel> : BaseFragment where TViewModel : class, IMvxViewModel
    {
        public new TViewModel ViewModel
        {
            get { return (TViewModel)base.ViewModel; }
            set { base.ViewModel = value; }
        }
    }
}