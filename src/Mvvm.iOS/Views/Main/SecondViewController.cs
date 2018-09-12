using System;
using Cirrious.FluentLayouts.Touch;
using Mvvm.Core.ViewModels.Main;
using MvvmCross.Binding.BindingContext;
using UIKit;

namespace Mvvm.iOS.Views.Main
{
    public class SecondViewController : BaseViewController<SecondViewModel>
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

            var set = this.CreateBindingSet<SecondViewController, SecondViewModel>();
            set.Bind(_navigateButton).To(vm => vm.NavigateCommand);
            set.Apply();

            View.BackgroundColor = UIColor.Red;
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

