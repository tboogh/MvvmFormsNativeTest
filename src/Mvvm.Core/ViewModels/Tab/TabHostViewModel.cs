using System;
using System.Windows.Input;
using Mvvm.Core.ViewModels.Main;
using MvvmCross.Commands;
using MvvmCross.Navigation;

namespace Mvvm.Core.ViewModels.Tab
{
    public class TabHostViewModel : BaseViewModel
    {
        IMvxNavigationService _navigationService;

        public TabHostViewModel(IMvxNavigationService navigationService)
        {
            _navigationService = navigationService;
        }

        public ICommand ShowTabACommand => new MvxAsyncCommand(() => _navigationService.Navigate<TabAViewModel>());
        public ICommand ShowTabBCommand => new MvxAsyncCommand(() => _navigationService.Navigate<TabBViewModel>());
        public ICommand ShowTabCCommand => new MvxAsyncCommand(() => _navigationService.Navigate<TabCViewModel>());
        public ICommand ShowFormsTab => new MvxAsyncCommand(() => _navigationService.Navigate<FormsTabViewModel>());

    }
}
