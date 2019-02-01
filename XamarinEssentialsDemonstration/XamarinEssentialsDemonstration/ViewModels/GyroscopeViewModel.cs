using System.Threading.Tasks;
using Xamarin.Essentials;

namespace XamarinEssentialsDemonstration.ViewModels
{
    public class GyroscopeViewModel : ViewModelBase
    {
        public float AngularVelocityX { get; set; }
        public float AngularVelocityY { get; set; }
        public float AngularVelocityZ { get; set; }

        public GyroscopeViewModel()
        {
        }

        public override async Task OnAppearing()
        {
            await base.OnAppearing();
            Gyroscope.Start(SensorSpeed.UI);
            Gyroscope.ReadingChanged += Gyroscope_ReadingChanged;
        }

        public override async Task OnDisappearing()
        {
            await base.OnDisappearing();
            Gyroscope.Stop();
            Gyroscope.ReadingChanged -= Gyroscope_ReadingChanged;
        }

        private void Gyroscope_ReadingChanged(object sender, GyroscopeChangedEventArgs e)
        {
            var angularVelocity = e.Reading.AngularVelocity;
            AngularVelocityX = angularVelocity.X;
            AngularVelocityY = angularVelocity.Y;
            AngularVelocityZ = angularVelocity.Z;
        }

    }
}
