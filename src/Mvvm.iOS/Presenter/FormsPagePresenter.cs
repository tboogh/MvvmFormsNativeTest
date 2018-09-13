using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Foundation;
using Mvvm.Core.Page;
using Mvvm.Core.ViewModels.Main;
using MvvmCross;
using MvvmCross.Platforms.Ios.Presenters;
using MvvmCross.Platforms.Ios.Presenters.Attributes;
using MvvmCross.Presenters;
using MvvmCross.ViewModels;
using UIKit;
using Xamarin.Forms;
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
            var viewModelLoader = Mvx.Resolve<IMvxViewModelLoader>();
            var viewModel = viewModelLoader.LoadViewModel(request, null);
            if (request.ViewModelType == typeof(FormsViewModel))
            {

                var page = new TestPage
                {
                    BindingContext = viewModel
                };
                var viewController = page.CreateViewController();
                MasterNavigationController.PushViewController(viewController, true);
                return;
            }

            if (request.ViewModelType == typeof(FormsTabViewModel))
            {
                var page = new TabPage()
                {
                    BindingContext = viewModel
                };
                var viewController = page.CreateViewController();
                var attribute = new MvxTabPresentationAttribute()
                {
                    TabName = page.Title
                };
                TabBarViewController.ShowTabView(viewController, attribute);
                return;
            }
            base.Show(request);
        }
    }
}
