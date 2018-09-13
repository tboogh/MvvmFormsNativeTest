using Mvvm.Core.ViewModels.Tab;
using MvvmCross.Platforms.Ios.Presenters.Attributes;
using UIKit;

namespace Mvvm.iOS.Views.Tab
{
    [MvxTabPresentation(TabName = "TabC", WrapInNavigationController = false)]
    public class TabCViewController : BaseTabViewController<TabCViewModel>
    {
        protected override UIColor BackGroundColor => UIColor.Blue;
    }
}