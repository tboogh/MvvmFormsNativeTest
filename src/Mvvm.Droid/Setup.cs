using MvvmCross.Droid.Support.V7.AppCompat;
using Mvvm.Core;
using Mvvm.Droid.Presenter;
using MvvmCross;
using MvvmCross.Platforms.Android.Presenters;

namespace Mvvm.Droid
{
    public class Setup : MvxAppCompatSetup<App>
    {
        protected override IMvxAndroidViewPresenter CreateViewPresenter()
        {
            return new FormsPagePresenter(AndroidViewAssemblies);
        }
    }
}
