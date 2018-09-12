using System;
using Foundation;
using Mvvm.Core.ViewModels.Tab;
using MvvmCross.Platforms.Ios.Presenters.Attributes;
using MvvmCross.Platforms.Ios.Views;
using MvvmCross.ViewModels;
using UIKit;

namespace Mvvm.iOS.Views.Tab
{
    public abstract class BaseTabViewController<TViewModel> : BaseViewController<TViewModel> where TViewModel : class, IMvxViewModel
    {
        protected abstract UIColor BackGroundColor { get; }



        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            View.BackgroundColor = BackGroundColor;
        }
    }

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


    [MvxTabPresentation(TabName = "TabA", WrapInNavigationController = false)]
    public class TabAViewController : BaseTabViewController<TabAViewModel>
    {
        protected override UIColor BackGroundColor => UIColor.Red;
    }

    [MvxTabPresentation(TabName = "TabB", WrapInNavigationController = false)]
    public class TabBViewController : BaseTabViewController<TabBViewModel>
    {
        protected override UIColor BackGroundColor => UIColor.Green;
    }

    [MvxTabPresentation(TabName = "TabC", WrapInNavigationController = false)]
    public class TabCViewController : BaseTabViewController<TabCViewModel>
    {
        protected override UIColor BackGroundColor => UIColor.Blue;
    }
}

