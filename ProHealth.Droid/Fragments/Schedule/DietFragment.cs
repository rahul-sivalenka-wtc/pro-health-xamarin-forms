using Android.OS;
using Android.Runtime;
using Android.Views;
using MvvmCross.Droid.Support.V7.Fragging.Attributes;
using ProHealth.Core.ViewModels;
using ProHealth.Core.ViewModels.Schedule;

namespace ProHealth.Droid.Fragments.Schedule
{
    [MvxFragment(typeof(ScheduleViewModel), Resource.Id.ScheduleViewPager, true)]
    [Register("prohealth.droid.fragments.schedule.DietFragment")]
    public class DietFragment : BaseFragment<DietViewModel>
    {
        protected override int FragmentId => Resource.Layout.ScheduleDietView;
    }
}