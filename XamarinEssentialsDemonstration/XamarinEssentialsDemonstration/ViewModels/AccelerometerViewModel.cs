using System.Threading.Tasks;
using Xamarin.Essentials;

namespace XamarinEssentialsDemonstration.ViewModels
{
    public class AccelerometerViewModel : ViewModelBase
    {
        public float XReading { get; set; }
        public float YReading { get; set; }
        public float ZReading { get; set; }

        public AccelerometerViewModel()
        {
        }

        public override async Task OnAppearing()
        {
            await base.OnAppearing();
            Accelerometer.ReadingChanged += Accelerometer_ReadingChanged;
            Accelerometer.Start(SensorSpeed.UI);
        }
        public override async Task OnDisappearing()
        {
            await base.OnDisappearing();
            Accelerometer.ReadingChanged -= Accelerometer_ReadingChanged;
            Accelerometer.Stop();
        }

        private void Accelerometer_ReadingChanged(object sender, AccelerometerChangedEventArgs e)
        {
            var acceleration = e.Reading.Acceleration;

            XReading = acceleration.X;
            YReading = acceleration.Y;
            ZReading = acceleration.Z;
        }
    }
}
