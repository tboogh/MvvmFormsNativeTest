using MvvmCross.IoC;
using MvvmCross.ViewModels;
using Mvvm.Core.ViewModels.Main;

namespace Mvvm.Core
{
    public class App : MvxApplication
    {
        public override void Initialize()
        {
            CreatableTypes()
                .EndingWith("Service")
                .AsInterfaces()
                .RegisterAsLazySingleton();

            RegisterAppStart<MainViewModel>();
        }
    }
}
