using ISS.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISS.ViewModel.MainPageViewModel
{
    public partial class MainPageViewModel : BaseViewModel
    {
        [ObservableProperty]
        string _button;

        public MainPageViewModel()
        {
            Title = "MainPage";
            Button = "Button!";
        }


    }
}
