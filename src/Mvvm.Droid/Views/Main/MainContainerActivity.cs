using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Mvvm.Core.ViewModels.Main;
using MvvmCross;
using MvvmCross.Core;
using MvvmCross.Platforms.Android;
using MvvmCross.Platforms.Android.Core;
using MvvmCross.Platforms.Android.Views;
using Xamarin.Forms;
using Toolbar = Android.Support.V7.Widget.Toolbar;

namespace Mvvm.Droid.Views.Main
{
    [Activity(
        Theme = "@style/AppTheme",
        WindowSoftInputMode = SoftInput.AdjustResize | SoftInput.StateHidden)]
    public class MainContainerActivity : BaseActivity<MainContainerViewModel>
    {
        private IMvxAndroidActivityLifetimeListener  _lifetimeMonitor;
        protected override int ActivityLayoutId => Resource.Layout.activity_main_container;


        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            Forms.Init(this, bundle);

            var toolbar = FindViewById<Toolbar>(Resource.Id.toolbar);
            SetSupportActionBar(toolbar);
            toolbar.NavigationClick += ToolbarOnNavigationClick;

            _lifetimeMonitor = Mvx.Resolve<IMvxAndroidActivityLifetimeListener>();
            _lifetimeMonitor.OnCreate(this, bundle);
        }

        protected override void OnStart()
        {
            base.OnStart();
            _lifetimeMonitor.OnStart(this);
        }

        protected override void OnRestart()
        {
            base.OnRestart();
            _lifetimeMonitor.OnRestart(this);
        }

        protected override void OnResume()
        {
            base.OnResume();
            _lifetimeMonitor.OnResume(this);
        }

        protected override void OnDestroy()
        {
            base.OnDestroy();
            _lifetimeMonitor.OnDestroy(this);
        }

        private void ToolbarOnNavigationClick(object sender, Toolbar.NavigationClickEventArgs navigationClickEventArgs)
        {
            OnBackPressed();
        }
    }
}
