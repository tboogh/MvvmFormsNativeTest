using MvvmCross.Platforms.Ios.Core;
using Mvvm.Core;
using Mvvm.iOS.Presenter;
using MvvmCross.Platforms.Ios.Presenters;
using Xamarin.Forms;

namespace Mvvm.iOS
{
    public class Setup : MvxIosSetup<App>
    {
        protected override IMvxIosViewPresenter CreateViewPresenter()
        {
            Forms.Init();
            return new FormsPagePresenter(ApplicationDelegate, Window);
        }
    }
}
