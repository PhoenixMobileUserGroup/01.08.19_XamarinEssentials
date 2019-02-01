using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace XamarinEssentialsDemonstration.ViewModels
{
    public class FlashlightViewModel: ViewModelBase
    {
        // Properties
        public bool FlashlightOn { get; set; }
        public string ToggleFlashlightButtonBackgroundColor { get; set; } = "Black";
        public string ToggleFlashlightButtonText { get; set; } = "Off";

        // Commands
        public ICommand ToggleFlashlightTappedCommand { get; private set; }

        public FlashlightViewModel()
        {
            InitializeCommands();
        }

        private void InitializeCommands()
        {
            ToggleFlashlightTappedCommand = new Command(ToggleFlashlightTapped);
        }

        public override async Task OnAppearing()
        {
            await base.OnAppearing();
            await Flashlight.TurnOffAsync();
            ToggleFlashlightButtonText = "Off";
            ToggleFlashlightButtonBackgroundColor = "Black";
        }

        public override async Task OnDisappearing()
        {
            await base.OnDisappearing();
            await Flashlight.TurnOffAsync();
        }

        private async void ToggleFlashlightTapped()
        {
            if(FlashlightOn == false)
            {
                await Flashlight.TurnOnAsync();
                ToggleFlashlightButtonText = "ON";
                ToggleFlashlightButtonBackgroundColor = "White";
            }
            else
            {
                await Flashlight.TurnOffAsync();
                ToggleFlashlightButtonText = "OFF";
                ToggleFlashlightButtonBackgroundColor = "Black";
            }

            FlashlightOn = !FlashlightOn;
        }
    }
}
