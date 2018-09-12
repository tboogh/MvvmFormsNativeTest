using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Foundation;
using Mvvm.Core.Page;
using Mvvm.Core.ViewModels.Main;
using MvvmCross.Platforms.Ios.Presenters;
using MvvmCross.Presenters;
using MvvmCross.ViewModels;
using UIKit;
using Xamarin.Forms.Platform.iOS;

namespace Mvvm.iOS.Presenter
{
    public class FormsPagePresenter : MvxIosViewPresenter
    {
        public FormsPagePresenter(IUIApplicationDelegate applicationDelegate, UIWindow window) : base(applicationDelegate, window)
        {
        }

        public override void Show(MvxViewModelRequest request)
        {
            if (request.ViewModelType == typeof(FormsViewModel))
            {
                
                var page = new TestPage();
                var viewController = page.CreateViewController();
                MasterNavigationController.PushViewController(viewController, true);
                return;
            }
            base.Show(request);
        }
    }
}
