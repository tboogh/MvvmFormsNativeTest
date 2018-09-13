using System;
using Foundation;
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
}

