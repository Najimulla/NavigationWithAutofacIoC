using NevigationIoC.Interfaces;
using System.Windows.Input;
using Xamarin.Forms;

namespace NevigationIoC.ViewModels
{
    public class HomeBaseViewModel : BaseViewModel
    {
        public string PageTitle => "Start Page";
        public string GoToNextPageButtonText => "Push to next page";

        private readonly INavigator _navigator;

        public HomeBaseViewModel(INavigator navigator)
        {
            _navigator = navigator;
        }

        public ICommand NextPageCommand => new Command(() =>
        {
            _navigator.PushAsync<SecondViewModel>();
        });
    }
}
