using MvvmCross.Core.ViewModels;

namespace ProHealth.Core.ViewModels
{
    public class LoginViewModel : MvxViewModel
    {
        public IMvxCommand LoginCommand { get; }

        public LoginViewModel()
        {
            LoginCommand = new MvxCommand(DoLogin);
        }

        private void DoLogin()
        {
            ShowViewModel<HomeViewModel>();
        }
    }
}
