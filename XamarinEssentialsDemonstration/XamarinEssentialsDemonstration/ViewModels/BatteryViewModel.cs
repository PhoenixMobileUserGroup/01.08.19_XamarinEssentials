using System;
using System.Threading.Tasks;
using Xamarin.Essentials;

namespace XamarinEssentialsDemonstration.ViewModels
{
    public class BatteryViewModel: ViewModelBase
    {
        public double Level { get; set; }
        public string State { get; set; }
        public string Sounce { get; set; }

        public BatteryViewModel()
        {
        }

        public override async Task OnAppearing()
        {
            await base.OnAppearing();
            Level = Battery.ChargeLevel * 100;
            State = Enum.GetName(typeof(BatteryState), Battery.State);
            Sounce = Enum.GetName(typeof(BatteryPowerSource), Battery.PowerSource);
            Battery.BatteryInfoChanged += Battery_BatteryInfoChanged;
        }

        public override async Task OnDisappearing()
        {
            await base.OnDisappearing();
            Battery.BatteryInfoChanged -= Battery_BatteryInfoChanged;
        }

        private void Battery_BatteryInfoChanged(object sender, BatteryInfoChangedEventArgs e)
        {
            Level = e.ChargeLevel * 100;
            State = Enum.GetName(typeof(BatteryState), e.State);
            Sounce = Enum.GetName(typeof(BatteryPowerSource), e.PowerSource);
        }

    }
}
