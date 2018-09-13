using System.Collections.Generic;
using System.Reflection;
using Android.App;
using Mvvm.Core.Page;
using Mvvm.Core.ViewModels.Main;
using MvvmCross;
using MvvmCross.Droid.Support.V7.AppCompat;
using MvvmCross.Platforms.Android.Presenters;
using MvvmCross.Platforms.Android.Views;
using MvvmCross.Presenters.Attributes;
using MvvmCross.ViewModels;
using Xamarin.Forms.Platform.Android;

namespace Mvvm.Droid.Presenter
{
    public class FormsPagePresenter : MvxAppCompatViewPresenter 
    {
        protected override IMvxFragmentView CreateFragment(MvxBasePresentationAttribute attribute, string fragmentName)
        {
            
            return base.CreateFragment(attribute, fragmentName);
        }

        public override void Show(MvxViewModelRequest request)
        {
            var viewModelLoader = Mvx.Resolve<IMvxViewModelLoader>();
            var viewModel = viewModelLoader.LoadViewModel(request, null);
            if (request.ViewModelType == typeof(FormsViewModel))
            {
                var fragmentManageer = CurrentFragmentManager;
                var page = new TestPage()
                {
                    BindingContext = viewModel
                };
                var fragment = page.CreateSupportFragment(CurrentActivity);
                fragmentManageer.BeginTransaction().Replace(Resource.Id.content_frame, fragment).AddToBackStack(null).Commit();
                return;
            }

            if (request.ViewModelType == typeof(FormsTabViewModel))
            {
                var fragmentManageer = CurrentFragmentManager;
                var page = new TestPage()
                {
                    BindingContext = viewModel
                };
                var fragment = page.CreateSupportFragment(CurrentActivity);
                fragmentManageer.BeginTransaction().Replace(Resource.Id.content_frame, fragment).AddToBackStack(null).Commit();
                return;
            }

            base.Show(request);
        }

        public FormsPagePresenter(IEnumerable<Assembly> androidViewAssemblies) : base(androidViewAssemblies)
        {
        }
    }
}
