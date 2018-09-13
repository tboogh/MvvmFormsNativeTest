using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Support.V7.App;
using Android.Views;
using Android.Widget;
using Mvvm.Core.ViewModels.Main;
using MvvmCross.Binding.BindingContext;
using MvvmCross.Platforms.Android.Presenters.Attributes;

namespace Mvvm.Droid.Views.Main
{
    [MvxFragmentPresentation(typeof(MainContainerViewModel), Resource.Id.content_frame, false)]
    public class MainFragment : BaseFragment<MainViewModel>
    {
        protected override int FragmentLayoutId => Resource.Layout.fragment_main;

        public override void OnViewCreated(View view, Bundle savedInstanceState)
        {
            base.OnViewCreated(view, savedInstanceState);
            
            var button = view.FindViewById<Button>(Resource.Id.navigationButton);

            var set = this.CreateBindingSet<MainFragment, MainViewModel>();
            set.Bind(button).To(vm => vm.NavigateCommand);
            set.Apply();
        }

        public override void OnActivityCreated(Bundle savedInstanceState)
        {
            base.OnActivityCreated(savedInstanceState);
            var supportActionBar = ((AppCompatActivity)Activity).SupportActionBar;
            
            supportActionBar.SetDisplayHomeAsUpEnabled(false);
            supportActionBar.SetDisplayShowHomeEnabled(false);
            
        }
    }
}
