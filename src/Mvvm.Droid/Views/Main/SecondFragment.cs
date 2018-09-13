using Android.OS;
using Android.Support.V7.App;
using Android.Views;
using Android.Widget;
using Mvvm.Core.ViewModels.Main;
using MvvmCross.Binding.BindingContext;
using MvvmCross.Platforms.Android.Presenters.Attributes;

namespace Mvvm.Droid.Views.Main
{
    [MvxFragmentPresentation(typeof(MainContainerViewModel), Resource.Id.content_frame, true)]
    public class SecondFragment : BaseFragment<SecondViewModel>
    {
        protected override int FragmentLayoutId => Resource.Layout.fragment_second;

        public override void OnViewCreated(View view, Bundle savedInstanceState)
        {
            base.OnViewCreated(view, savedInstanceState);

            var button = view.FindViewById<Button>(Resource.Id.navigationButton);

            var set = this.CreateBindingSet<SecondFragment, SecondViewModel>();
            set.Bind(button).To(vm => vm.NavigateCommand);
            set.Apply();
        }

        public override void OnActivityCreated(Bundle savedInstanceState)
        {
            base.OnActivityCreated(savedInstanceState);
            var supportActionBar = ((AppCompatActivity)Activity).SupportActionBar;
            
            supportActionBar.SetDisplayHomeAsUpEnabled(true);
            supportActionBar.SetDisplayShowHomeEnabled(true);
            
        }
    }
}