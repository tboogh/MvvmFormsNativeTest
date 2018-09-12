using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using MvvmCross.Commands;
using MvvmCross.Navigation;

namespace Mvvm.Core.ViewModels.Main
{
    public class MainViewModel : BaseViewModel
    {
        readonly IMvxNavigationService _navigationService;

        public MainViewModel(IMvxNavigationService navigationService)
        {
            _navigationService = navigationService;
        }

        private ICommand _navigateCommand;
        public ICommand NavigateCommand
        {
            get
            {
                _navigateCommand = _navigateCommand ?? new MvxCommand(Navigate);
                return _navigateCommand;
            }
        }

        void Navigate()
        {
            _navigationService.Navigate<SecondViewModel>();
        }
    }
}
