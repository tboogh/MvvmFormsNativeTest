using Foundation;
using MvvmCross.Platforms.Ios.Core;
using Mvvm.Core;

namespace Mvvm.iOS
{
    [Register(nameof(AppDelegate))]
    public class AppDelegate : MvxApplicationDelegate<Setup, App>
    {
    }
}
