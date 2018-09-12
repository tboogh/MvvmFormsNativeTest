using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Cirrious.FluentLayouts.Touch;
using Foundation;
using MvvmCross.Platforms.Ios.Presenters.Attributes;
using Mvvm.Core.ViewModels.Main;
using MvvmCross.Binding.BindingContext;
using UIKit;

namespace Mvvm.iOS.Views.Main
{
    [MvxRootPresentation(WrapInNavigationController = true)]
    public class MainViewController : BaseViewController<MainViewModel>
    {
        private UILabel _labelWelcome, _labelMessage;
        UIButton _navigateButton;

        protected override void CreateView()
        {
            _labelWelcome = new UILabel
            {
                Text = "Welcome!!",
                TextAlignment = UITextAlignment.Center
            };
            Add(_labelWelcome);

            _labelMessage = new UILabel
            {
                Text = "App scaffolded with MvxScaffolding",
                TextAlignment = UITextAlignment.Center
            };
            Add(_labelMessage);

            _navigateButton = new UIButton(UIButtonType.RoundedRect);
            _navigateButton.SetTitle("Navigate", UIControlState.Normal);
            Add(_navigateButton);

            var set = this.CreateBindingSet<MainViewController, MainViewModel>();
            set.Bind(_navigateButton).To(vm => vm.NavigateCommand);
            set.Apply();

        }

        protected override void LayoutView()
        {
            View.AddConstraints(new FluentLayout[]
           {
                _labelWelcome.WithSameCenterX(View),
                _labelWelcome.WithSameCenterY(View),

                _labelMessage.Below(_labelWelcome, 10f),
                _labelMessage.WithSameWidth(View)
           });
        }
    }
}
