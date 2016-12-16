using MvvmCross.Core.ViewModels;
using ProHealth.Core.ViewModels.SearchDoctor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProHealth.Core.ViewModels
{
    public class SearchDoctorViewModel : MvxViewModel
    {
        public IMvxCommand ShowDoctorDetailCommand { get; }

        public SearchDoctorViewModel()
        {
            ShowDoctorDetailCommand = new MvxCommand(ShowDoctorDetail);
        }

        private void ShowDoctorDetail()
        {
            ShowViewModel<DoctorsInfoViewModel>();
        }

        public void ShowList()
        {
            ShowViewModel<SearchDoctorListViewModel>();
        }
    }
}
