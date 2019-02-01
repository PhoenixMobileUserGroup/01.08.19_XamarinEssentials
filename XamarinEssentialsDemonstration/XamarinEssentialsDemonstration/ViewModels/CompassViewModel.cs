using System.Threading.Tasks;
using Xamarin.Essentials;

namespace XamarinEssentialsDemonstration.ViewModels
{
    public class CompassViewModel : ViewModelBase
    {
        public double MagneticNorth { get; set; }
        public string Direction { get; set; }

        public CompassViewModel()
        {
        }

        public override async Task OnAppearing()
        {
            await base.OnAppearing();
            Compass.Start(SensorSpeed.UI, applyLowPassFilter: true);
            Compass.ReadingChanged += Compass_ReadingChanged;
        }

        public override async Task OnDisappearing()
        {
            await base.OnDisappearing();
            Compass.Stop();
            Compass.ReadingChanged -= Compass_ReadingChanged;
        }

        private void Compass_ReadingChanged(object sender, CompassChangedEventArgs e)
        {
            MagneticNorth = e.Reading.HeadingMagneticNorth;
            UpdateDirection(MagneticNorth);
        }

        private void UpdateDirection(double magneticNorthReading)
        {
            if(magneticNorthReading >= 315 || magneticNorthReading < 45)
            {
                Direction = "NORTH";
            }
            else if(magneticNorthReading >= 45 && magneticNorthReading < 135)
            {
                Direction = "EAST";
            }
            else if (magneticNorthReading >= 135 && magneticNorthReading < 225)
            {
                Direction = "SOUTH";
            }
            else if(magneticNorthReading >= 225 && magneticNorthReading < 315)
            {
                Direction = "WEST";
            }
        }
    }
}
