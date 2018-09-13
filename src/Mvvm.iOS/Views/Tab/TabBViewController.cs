using Mvvm.Core.ViewModels.Tab;
using MvvmCross.Platforms.Ios.Presenters.Attributes;
using UIKit;

namespace Mvvm.iOS.Views.Tab
{
    [MvxTabPresentation(TabName = "TabB", WrapInNavigationController = false)]
    public class TabBViewController : BaseTabViewController<TabBViewModel>
    {
        protected override UIColor BackGroundColor => UIColor.Green;
    }
}