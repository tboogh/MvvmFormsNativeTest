using Cirrious.FluentLayouts.Touch;
using Foundation;
using MvvmCross.Platforms.Ios.Views;
using MvvmCross.ViewModels;
using Mvvm.iOS.Styles;
using UIKit;

namespace Mvvm.iOS.Views
{
    public abstract class BaseViewController<TViewModel> : MvxViewController<TViewModel>
        where TViewModel : class, IMvxViewModel
    {
        protected BaseViewController() : base()
        {

        }

        protected BaseViewController(string nibName, NSBundle bundle) : base(nibName, bundle)
        {

        }


        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            View.BackgroundColor = UIColor.White;

            NavigationController.NavigationBar.BarStyle = UIBarStyle.Black;
            NavigationController.NavigationBar.Translucent = false;
            NavigationController.NavigationBar.Hidden = false;
            NavigationController.NavigationBar.BarTintColor = ColorPalette.Primary;
            NavigationController.NavigationBar.TintColor = UIColor.White;

            NavigationController.SetNeedsStatusBarAppearanceUpdate();

            CreateView();

            LayoutView();

            BindView();
        }

        public override void ViewWillAppear(bool animated)
        {
            base.ViewWillAppear(animated);

            View.SubviewsDoNotTranslateAutoresizingMaskIntoConstraints();
        }

        protected virtual void CreateView()
        {
        }

        protected virtual void LayoutView()
        {
        }

        protected virtual void BindView()
        {
        }
    }
}
