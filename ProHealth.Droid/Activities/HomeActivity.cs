using Fragment = Android.Support.V4.App.Fragment;
using Android.App;
using Android.OS;
using Android.Runtime;
using Java.Lang;
using Android.Support.V4.View;
using Android.Support.Design.Widget;
using ProHealth.Droid.Fragments;
using ProHealth.Droid.Adapters;
using MvvmCross.Droid.Support.V7.AppCompat;
using ProHealth.Core.ViewModels;

namespace ProHealth.Droid.Activities
{
    [Activity(
        Label = "HomeActivity",
        Name = "prohealth.droid.activities.HomeActivity"
    )]
    public class HomeActivity : MvxCachingFragmentCompatActivity<HomeViewModel>
    {
        private TabLayout tabLayout;
        private ViewPager viewPager;

        Fragment[] fragments = new Fragment[] {
                new SearchDoctorFragment(),
                new RecordsFragment(),
                new ScheduleFragment(),
                new ProfileFragment()
             };

        ICharSequence[] titles = CharSequence.ArrayFromStringArray(new[] {
                    "Search doctor",
                    "Records",
                    "Schedule",
                    "Profile"
                });

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            SetContentView(Resource.Layout.HomeView);

            viewPager = FindViewById<ViewPager>(Resource.Id.ViewPager);
            viewPager.Adapter = new TabsFragmentPagerAdapter(SupportFragmentManager, fragments, titles);

            tabLayout = FindViewById<TabLayout>(Resource.Id.SlidingTabs);
            tabLayout.SetupWithViewPager(viewPager);

            SetTabIcons();
        }

        private void SetTabIcons()
        {
            tabLayout.GetTabAt(0).SetIcon(Resource.Drawable.PersonIcon);
            tabLayout.GetTabAt(1).SetIcon(Resource.Drawable.PersonIcon);
            tabLayout.GetTabAt(2).SetIcon(Resource.Drawable.PersonIcon);
            tabLayout.GetTabAt(3).SetIcon(Resource.Drawable.PersonIcon);
        }
    }
}
