using System.Windows.Input;
using Xamarin.Forms;
using XamarinEssentialsDemonstration.Interfaces;

namespace XamarinEssentialsDemonstration.ViewModels
{
    public class DependencyServiceOpenBrowserViewModel : ViewModelBase
    {
        public string Url { get; set; }

        private IBrowserService _browserService;

        public ICommand OpenBrowserTappedCommand { get; set; }

        public DependencyServiceOpenBrowserViewModel()
        {
            InitializeCommands();
        }

        private void InitializeCommands()
        {
            _browserService = DependencyService.Get<IBrowserService>();
            OpenBrowserTappedCommand = new Command(OpenBrowserTapped);
        }

        private async void OpenBrowserTapped(object obj)
        {
            try
            {
                _browserService.Open(Url);
            }
            catch
            {
                await Application.Current.MainPage.DisplayAlert("Error", "Invalid Url", "Ok");
            }
        }
    }
}
