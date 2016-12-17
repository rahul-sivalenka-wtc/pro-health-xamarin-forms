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

namespace ProHealth.Droid.Fragments
{
    public class CustomDialogInfo
    {
        public Android.Support.V4.App.FragmentTransaction FragmentTransaction { set; get; }
        public string DialogTag { set; get; }
        public Android.Support.V4.App.DialogFragment Dialog { set; get; }
    }

    public class CustomDialogFragment : Android.Support.V4.App.DialogFragment
    {
        private int FragmentId { get; }

        public static CustomDialogFragment NewInstance(int fragmentId, Bundle bundle)
        {
            CustomDialogFragment dialog = new CustomDialogFragment(fragmentId);
            dialog.Arguments = bundle;
            return dialog;
        }

        public CustomDialogFragment(int fragmentId) : base()
        {
            FragmentId = fragmentId;
        }

        public override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your fragment here
        }

        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            // Use this to return your custom view for this Fragment
            return inflater.Inflate(FragmentId, container, false);

            //return base.OnCreateView(inflater, container, savedInstanceState);
        }
    }
}