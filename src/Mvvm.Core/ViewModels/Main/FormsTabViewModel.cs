using Xamarin.Forms;

namespace Mvvm.Core.ViewModels.Main
{
    public class FormsTabViewModel : BaseViewModel{
        Color _backgroundColor;

        public Color BackgroundColor
        {
            get => _backgroundColor;
            set => SetProperty(ref _backgroundColor, value);
        }

        public FormsTabViewModel()
        {
            BackgroundColor = Color.BlueViolet;
        }
    }
}