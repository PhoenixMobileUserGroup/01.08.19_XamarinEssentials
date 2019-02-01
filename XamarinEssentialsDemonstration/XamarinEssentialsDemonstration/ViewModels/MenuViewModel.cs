using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;
using XamarinEssentialsDemonstration.Views;

namespace XamarinEssentialsDemonstration.ViewModels
{
    public class MenuViewModel : ViewModelBase
    {
        // Commands
        public ICommand FlashlightTappedCommand { get; set; }
        public ICommand AccelerometerTappedCommand { get; set; }
        public ICommand BatteryTappedCommand { get; set; }
        public ICommand ApplicationInformationTappedCommand { get; set; }
        public ICommand ClipboardTappedCommand { get; set; }
        public ICommand CompassTappedCommand { get; set; }
        public ICommand ConnectivityTappedCommand { get; set; }
        public ICommand DeviceDisplayInformationTappedCommand { get; set; }
        public ICommand DeviceInformationTappedCommand { get; set; }
        public ICommand EmailTappedCommand { get; set; }
        public ICommand GyroscopeTappedCommand { get; set; }
        public ICommand VibrationTappedCommand { get; set; }
        public ICommand OpenBrowserTappedCommand { get; set; }
        public ICommand DependencyServiceOpenBrowserCommand { get; set; }

        public MenuViewModel()
        {
            InitializeCommands();
        }

        private void InitializeCommands()
        {
            FlashlightTappedCommand = new Command(OnFlashlightTapped);
            AccelerometerTappedCommand = new Command(OnAccelerometerTapped);
            BatteryTappedCommand = new Command(OnBatteryTapped);
            ApplicationInformationTappedCommand = new Command(AplicationInformationTapped);
            ClipboardTappedCommand = new Command(ClipboardTapped);
            CompassTappedCommand = new Command(CompassTapped);
            ConnectivityTappedCommand = new Command(ConnectivityTapped);
            DeviceDisplayInformationTappedCommand = new Command(DeviceDisplayInformationTapped);
            DeviceInformationTappedCommand = new Command(DeviceInformationTapped);
            EmailTappedCommand = new Command(EmailTapped);
            GyroscopeTappedCommand = new Command(GyroscopeTapped);
            VibrationTappedCommand = new Command(VibrationTapped);
            OpenBrowserTappedCommand = new Command(OpenBrowserTapped);
            DependencyServiceOpenBrowserCommand = new Command(DependencyServiceOpenBrowserTapped);
        }

        private async Task Navigate(Page page)
        {
            await Application.Current.MainPage.Navigation.PushAsync(page);
        }

        private async void OnFlashlightTapped()
        {
            await Navigate(new FlashlightView());
        }

        private async void OnAccelerometerTapped()
        {
            await Navigate(new AccelerometerView());
        }

        private async void OnBatteryTapped()
        {
            await Navigate(new BatteryView());
        }

        private async void AplicationInformationTapped()
        {
            await Navigate(new ApplicationInformationVew());
        }

        private async void ClipboardTapped()
        {
            await Navigate(new ClipboardView());
        }

        private async void CompassTapped()
        {
            await Navigate(new CompassView());
        }

        private async void ConnectivityTapped()
        {
            await Navigate(new ConnectivityView());
        }

        private async void DeviceDisplayInformationTapped()
        {
            await Navigate(new DeviceDisplayInformationView());
        }

        private async void DeviceInformationTapped()
        {
            await Navigate(new DeviceInformationView());
        }

        private async void EmailTapped()
        {
            await Navigate(new EmailView());
        }

        private async void GyroscopeTapped()
        {
            await Navigate(new GyroscopeView());
        }

        private async void VibrationTapped()
        {
            await Navigate(new VibrationView());
        }

        private async void OpenBrowserTapped()
        {
            await Navigate(new OpenBrowserView());
        }

        private async void DependencyServiceOpenBrowserTapped()
        {
            await Navigate(new DependencyServiceOpenBrowserView());
        }
    }
}
