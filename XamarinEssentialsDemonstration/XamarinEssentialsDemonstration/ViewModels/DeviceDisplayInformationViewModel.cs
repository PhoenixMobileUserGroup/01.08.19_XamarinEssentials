using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace XamarinEssentialsDemonstration.ViewModels
{
    public class DeviceDisplayInformationViewModel : ViewModelBase
    {
        public string Orientation { get; set; }
        public string Rotation { get; set; }
        public double Width { get; set; }
        public double Height { get; set; }
        public double Density { get; set; }
        public bool ScreenLockSet { get; set; }

        public ICommand ToggleScreenLockTappedCommand { get; set; }

        public DeviceDisplayInformationViewModel()
        {
            InitializeCommands();
        }

        private void InitializeCommands()
        {
            ToggleScreenLockTappedCommand = new Command(ToggleScreenLockTapped);
        }

        public override async Task OnAppearing()
        {
            await base.OnAppearing();
            DeviceDisplay.MainDisplayInfoChanged += DeviceDisplay_MainDisplayInfoChanged;

            var mainDisplayInfo = DeviceDisplay.MainDisplayInfo;

            Orientation = Enum.GetName(typeof(DisplayOrientation), mainDisplayInfo.Orientation);
            Rotation = Enum.GetName(typeof(DisplayRotation), mainDisplayInfo.Rotation);
            Width = mainDisplayInfo.Width;
            Height = mainDisplayInfo.Height;
            Density = mainDisplayInfo.Density;
            ScreenLockSet = DeviceDisplay.KeepScreenOn;
        }

        public override async Task OnDisappearing()
        {
            await base.OnDisappearing();
            DeviceDisplay.MainDisplayInfoChanged -= DeviceDisplay_MainDisplayInfoChanged;
            DeviceDisplay.KeepScreenOn = false;
        }

        private void ToggleScreenLockTapped()
        {
            DeviceDisplay.KeepScreenOn = !DeviceDisplay.KeepScreenOn;
            ScreenLockSet = DeviceDisplay.KeepScreenOn;
        }

        private void DeviceDisplay_MainDisplayInfoChanged(object sender, DisplayInfoChangedEventArgs e)
        {
            var mainDisplayInfo = e.DisplayInfo;

            Orientation = Enum.GetName(typeof(DisplayOrientation), mainDisplayInfo.Orientation);
            Rotation = Enum.GetName(typeof(DisplayRotation), mainDisplayInfo.Rotation);
            Width = mainDisplayInfo.Width;
            Height = mainDisplayInfo.Height;
            Density = mainDisplayInfo.Density;
            ScreenLockSet = DeviceDisplay.KeepScreenOn;
        }
    }
}
