using Mvvm.Core.ViewModels.Tab;
using MvvmCross.Platforms.Ios.Views;

namespace Mvvm.iOS.Views.Tab
{
    public class TabHostViewController : MvxTabBarViewController<TabHostViewModel>
    {
        private bool _firstTimePresented = true;

        public override void ViewWillAppear(bool animated)
        {
            base.ViewWillAppear(animated);

            if (_firstTimePresented)
            {
                _firstTimePresented = false;
                ViewModel.ShowTabACommand.Execute(null);
                ViewModel.ShowTabBCommand.Execute(null);
                ViewModel.ShowTabCCommand.Execute(null);
                ViewModel.ShowFormsTab.Execute(null);
            }
        }
    }
}
