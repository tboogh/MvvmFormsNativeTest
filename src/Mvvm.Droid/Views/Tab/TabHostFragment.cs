using System.Collections.Generic;
using Android.Graphics;
using Android.OS;
using Android.Support.Design.Widget;
using Android.Support.V4.App;
using Android.Support.V4.View;
using Android.Views;
using Mvvm.Core.ViewModels.Main;
using Mvvm.Core.ViewModels.Tab;
using MvvmCross.Droid.Support.V4;
using MvvmCross.Platforms.Android.Presenters.Attributes;
using MvvmCross.ViewModels;

namespace Mvvm.Droid.Views.Tab
{
    [MvxFragmentPresentation(typeof(MainContainerViewModel), Resource.Id.content_frame, true)]
    public class TabHostFragment : BaseFragment<TabHostViewModel>
    {
        protected override int FragmentLayoutId => Resource.Layout.fragment_tabhost;

        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            var view = base.OnCreateView(inflater, container, savedInstanceState);
            //var viewPager = view.FindViewById<ViewPager>(Resource.Id.viewpager);
            //if (viewPager == null)
            //    return view;

            //var fragments = new List<MvxViewPagerFragmentInfo>()
            //{
            //    new MvxViewPagerFragmentInfo("Tab A", typeof(TabAFragment), typeof(TabAViewModel)),
            //    new MvxViewPagerFragmentInfo("Tab B", typeof(TabAFragment), typeof(TabAViewModel)),
            //    new MvxViewPagerFragmentInfo("Tab C", typeof(TabAFragment), typeof(TabAViewModel)),
            //    //new MvxViewPagerFragmentInfo("Tab D", typeof(Fragment), typeof(FormsTabViewModel)),
            //};

            //viewPager.Adapter = new MvxCachingFragmentStatePagerAdapter(Activity, ChildFragmentManager, fragments);

            //var tabLayout = view.FindViewById<TabLayout>(Resource.Id.tabs);
            //tabLayout.SetupWithViewPager(viewPager);

            return view;
        }
    }

    public abstract class BaseTabFragment<TViewModel> : BaseFragment<TViewModel> where TViewModel : class, IMvxViewModel
    {
        public abstract Color Color { get; set; }
    }

    public class TabAFragment : BaseTabFragment<TabAViewModel>
    {
        protected override int FragmentLayoutId => Resource.Layout.tab_a;
        public override Color Color { get; set; }
    }

    public class TabBFragment : BaseTabFragment<TabBViewModel>
    {
        protected override int FragmentLayoutId => Resource.Layout.tab_b;
        public override Color Color { get; set; }
    }

    public class TabCFragment : BaseTabFragment<TabCViewModel>
    {
        protected override int FragmentLayoutId => Resource.Layout.tab_c;
        public override Color Color { get; set; }
    }
}
