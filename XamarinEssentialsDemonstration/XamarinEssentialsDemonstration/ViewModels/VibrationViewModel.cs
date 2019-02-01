using System.Windows.Input;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace XamarinEssentialsDemonstration.ViewModels
{
    public class VibrationViewModel : ViewModelBase
    {
        public ICommand VibrateTappedCommand { get; set; }

        public VibrationViewModel()
        {
            InitializeCommands();
        }

        private void InitializeCommands()
        {
            VibrateTappedCommand = new Command(VibrateTapped);
        }

        private void VibrateTapped(object obj)
        {
            Vibration.Vibrate();
        }
    }
}
