using System;
using System.Windows.Input;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace XamarinEssentialsDemonstration.ViewModels
{
    public class OpenBrowserViewModel : ViewModelBase
    {
        public string Url { get; set; }

        public ICommand OpenSystemPreferredBrowserTappedCommand { get; set; }
        public ICommand OpenExternalBrowserTappedCommand { get; set; }

        public OpenBrowserViewModel()
        {
            InitializeCommands();
        }

        private void InitializeCommands()
        {
            OpenSystemPreferredBrowserTappedCommand = new Command(OpenSystemPreferredBrowserTapped);
            OpenExternalBrowserTappedCommand = new Command(OpenExternalBrowserTapped);
        }

        private async void OpenSystemPreferredBrowserTapped(object obj)
        {
            try
            {
                var uri = new Uri(Url);
                await Browser.OpenAsync(uri, BrowserLaunchMode.SystemPreferred);
            }
            catch
            {
                await Application.Current.MainPage.DisplayAlert("Error", "Invalid Url", "Ok");
            }
        }

        private async void OpenExternalBrowserTapped(object obj)
        {
            try
            {
                var uri = new Uri(Url);
                await Browser.OpenAsync(uri, BrowserLaunchMode.External);
            }
            catch
            {
                await Application.Current.MainPage.DisplayAlert("Error", "Invalid Url", "Ok");
            }
        }
    }
}
