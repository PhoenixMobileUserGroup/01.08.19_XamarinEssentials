using System.Windows.Input;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace XamarinEssentialsDemonstration.ViewModels
{
    public class ApplicationInformationViewModel: ViewModelBase
    {
        public string AppName { get; set; }
        public string PackageName { get; set; }
        public string Version { get; set; }
        public string Build { get; set; }

        public ICommand ShowSettingsTappedCommand { get; set; }

        public ApplicationInformationViewModel()
        {
            AppName = AppInfo.Name;
            PackageName = AppInfo.PackageName;
            Version = AppInfo.VersionString;
            Build = AppInfo.BuildString;
            InitializeCommands();
        }

        private void InitializeCommands()
        {
            ShowSettingsTappedCommand = new Command(ShowSettingsTapped);
        }

        private void ShowSettingsTapped()
        {
            AppInfo.ShowSettingsUI();
        }
    }
}
