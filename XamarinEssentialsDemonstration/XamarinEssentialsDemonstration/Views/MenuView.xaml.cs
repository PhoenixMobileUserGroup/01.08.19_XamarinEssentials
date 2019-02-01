using XamarinEssentialsDemonstration.ViewModels;

namespace XamarinEssentialsDemonstration.Views
{
    public partial class MenuView : ViewBase
    {
        public MenuView()
        {
            InitializeComponent();
            BindingContext = new MenuViewModel();
            Title = "Xamarin.Essentials Demo App";
        }
    }
}
