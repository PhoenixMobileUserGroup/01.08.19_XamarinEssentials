using Android.App;
using Android.Content;
using XamarinEssentialsDemonstration.Droid.Services;
using XamarinEssentialsDemonstration.Interfaces;

[assembly: Xamarin.Forms.Dependency(typeof(BrowserService))]
namespace XamarinEssentialsDemonstration.Droid.Services
{
    public class BrowserService : IBrowserService
    {
        public void Open(string uri)
        {
            var tempUri = Android.Net.Uri.Parse(uri);
            var intent = new Intent(Intent.ActionView, tempUri);
            Application.Context.StartActivity(intent);
        }
    }
}