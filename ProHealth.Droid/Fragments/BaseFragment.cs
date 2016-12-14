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

        public MvxCachingFragmentCompatActivity ParentActivity => (MvxCachingFragmentCompatActivity)Activity;

        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            base.OnCreateView(inflater, container, savedInstanceState);
            return this.BindingInflate(FragmentId, null);
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