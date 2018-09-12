using System;
using Mvvm.Core.ViewModels.Main;
using UIKit;

namespace Mvvm.iOS.Views.Main
{
    public partial class SecondViewController : BaseViewController<SecondViewModel>
    {
        public SecondViewController() : base("SecondViewController", null)
        {
        }
    }
}

