using System;
using System.Threading.Tasks;
using Xamarin.Essentials;

namespace XamarinEssentialsDemonstration.ViewModels
{
    public class ConnectivityViewModel : ViewModelBase
    {
        public string BackgroundColor { get; set; }
        public string NetworkAccess { get; set; }

        public ConnectivityViewModel()
        {
            UpdateBackground(Connectivity.NetworkAccess);
        }

        public override async Task OnAppearing()
        {
            await base.OnAppearing();
            NetworkAccess = Enum.GetName(typeof(NetworkAccess), Connectivity.NetworkAccess);
            UpdateBackground(Connectivity.NetworkAccess);
            Connectivity.ConnectivityChanged += Connectivity_ConnectivityChanged;
        }

        public override async Task OnDisappearing()
        {
            await base.OnDisappearing();
            Connectivity.ConnectivityChanged -= Connectivity_ConnectivityChanged;
        }

        private void Connectivity_ConnectivityChanged(object sender, ConnectivityChangedEventArgs e)
        {
            NetworkAccess = Enum.GetName(typeof(NetworkAccess), e.NetworkAccess);
            UpdateBackground(e.NetworkAccess);
        }

        private void UpdateBackground(NetworkAccess networkAccess)
        {
            if (networkAccess == Xamarin.Essentials.NetworkAccess.Internet)
                BackgroundColor = "Green";
            else
                BackgroundColor = "Red";
        }
    }
}
