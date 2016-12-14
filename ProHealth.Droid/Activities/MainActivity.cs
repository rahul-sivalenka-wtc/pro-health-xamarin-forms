using Android.App;
using Android.Widget;
using Android.OS;
using MvvmCross.Droid.Support.V7.AppCompat;
using ProHealth.Core.ViewModels;
using Android.Content.PM;

namespace ProHealth.Droid
{
    [Activity(
         Label = "MainActivity",
         LaunchMode = LaunchMode.SingleTop,
         Name = "prohealth.droid.activities.MainActivity"
     )]
    public class MainActivity : MvxCachingFragmentCompatActivity<MainViewModel>
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            
            SetContentView(Resource.Layout.MainView);
        }

        protected override void OnPostCreate(Bundle savedInstanceState)
        {
            base.OnPostCreate(savedInstanceState);
            ViewModel.ShowLogin();
        }
    }
}

