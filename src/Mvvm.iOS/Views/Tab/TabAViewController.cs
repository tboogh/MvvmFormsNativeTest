using Mvvm.Core.ViewModels.Tab;
using MvvmCross.Platforms.Ios.Presenters.Attributes;
using UIKit;

namespace Mvvm.iOS.Views.Tab
{
    [MvxTabPresentation(TabName = "TabA", WrapInNavigationController = false)]
    public class TabAViewController : BaseTabViewController<TabAViewModel>
    {
        protected override UIColor BackGroundColor => UIColor.Red;
    }
}