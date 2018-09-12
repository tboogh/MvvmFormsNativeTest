using System.Windows.Input;
using Mvvm.Core.ViewModels.Tab;
using MvvmCross.Commands;
using MvvmCross.Navigation;

namespace Mvvm.Core.ViewModels.Main
{
    public class FormsViewModel : BaseViewModel{
        private string _title;
        IMvxNavigationService _navigationService;
        public string Title
        {
            get => _title;
            set => SetProperty(ref _title, value);
        }

        public ICommand NavigateToTabCommand => new MvxAsyncCommand(() => _navigationService.Navigate<TabHostViewModel>());

        public FormsViewModel(IMvxNavigationService navigationService)
        {
            _navigationService = navigationService;
            Title = "Tester";
        }
    }
}
