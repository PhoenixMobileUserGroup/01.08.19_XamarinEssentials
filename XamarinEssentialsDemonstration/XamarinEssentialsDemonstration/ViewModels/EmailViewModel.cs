using System.Collections.Generic;
using System.Linq;
using System.Windows.Input;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace XamarinEssentialsDemonstration.ViewModels
{
    public class EmailViewModel : ViewModelBase
    {
        public string Recipients { get; set; }
        public string Subject { get; set; }
        public string Body { get; set; }

        public ICommand ComposeEmailTappedCommand { get; set; }

        public EmailViewModel()
        {
            InitializeCommands();
        }

        private void InitializeCommands()
        {
            ComposeEmailTappedCommand = new Command(ComposeEmailTapped);
        }

        private async void ComposeEmailTapped()
        {
            var recipientsList = new List<string>();

            if (string.IsNullOrEmpty(Subject))
            {
                await Application.Current.MainPage.DisplayAlert("Error", "Subject Required", "Ok");
                return;
            }


            if (string.IsNullOrEmpty(Body))
            {
                await Application.Current.MainPage.DisplayAlert("Error", "Body Required", "Ok");
                return;
            }


            if (string.IsNullOrEmpty(Recipients))
            {
                await Application.Current.MainPage.DisplayAlert("Error", "Recipients Required", "Ok");
                return;
            }

            recipientsList = Recipients.Split(',').ToList();

            foreach (var recipient in recipientsList)
            {
                if(!IsValidEmail(recipient))
                {
                    await Application.Current.MainPage.DisplayAlert("Error", "A recipients email format is invalid", "Ok");
                    return;
                }
            }

            var message = new EmailMessage
            {
                Subject = Subject,
                Body = Body,
                To = recipientsList
            };

            await Email.ComposeAsync(message);
        }

        private bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
