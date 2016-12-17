using Android.OS;
using Android.Runtime;
using Android.Views;
using MvvmCross.Droid.Support.V7.Fragging.Attributes;
using ProHealth.Core.ViewModels;
using ProHealth.Core.ViewModels.Schedule;

namespace ProHealth.Droid.Fragments.Schedule
{
    [MvxFragment(typeof(ScheduleViewModel), Resource.Id.ScheduleViewPager, true)]
    [Register("prohealth.droid.fragments.schedule.RemindersFragment")]
    public class RemindersFragment : BaseFragment<RemindersViewModel>
    {
        protected override int FragmentId => Resource.Layout.ScheduleRemindersView;

        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            var view = base.OnCreateView(inflater, container, savedInstanceState);

            var dialogInfo = CreateDialog(Resource.Layout.AddReminderDialog, "ReminderDialog");
            dialogInfo.Dialog.Show(dialogInfo.FragmentTransaction, dialogInfo.DialogTag);

            return view;
        }
    }
}