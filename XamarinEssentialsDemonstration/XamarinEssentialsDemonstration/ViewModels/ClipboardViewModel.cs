using System;
using System.Windows.Input;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace XamarinEssentialsDemonstration.ViewModels
{
    public class ClipboardViewModel: ViewModelBase
    {
        public string Id { get; set; }

        public ICommand RefreshIdTappedCommand { get; set; }
        public ICommand CopyIdTappedCommand { get; set; }

        public ClipboardViewModel()
        {
            InitializeCommands();
            GenerateId();
        }

        private void InitializeCommands()
        {
            RefreshIdTappedCommand = new Command(RefreshIdTapped);
            CopyIdTappedCommand = new Command(CopyIdTapped);
        }

        private void GenerateId()
        {
            Id = Guid.NewGuid().ToString();
        }

        private void RefreshIdTapped()
        {
            GenerateId();
        }
        private void CopyIdTapped()
        {
            Clipboard.SetTextAsync(Id);
        }
    }
}
