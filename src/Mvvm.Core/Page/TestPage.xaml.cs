using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MvvmCross.Presenters;
using MvvmCross.Presenters.Attributes;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Mvvm.Core.Page
{
    public class FormsPagePresentation : MvxBasePresentationAttribute
    {

    }

    [XamlCompilation(XamlCompilationOptions.Compile)]
    [FormsPagePresentation]
    public partial class TestPage : ContentPage
    {
        public TestPage()
        {
            InitializeComponent();
        }
    }
}
