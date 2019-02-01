using Foundation;
using UIKit;
using XamarinEssentialsDemonstration.Interfaces;
using XamarinEssentialsDemonstration.iOS.Services;

[assembly: Xamarin.Forms.Dependency(typeof(BrowserService))]
namespace XamarinEssentialsDemonstration.iOS.Services
{
    public class BrowserService : IBrowserService
    {
        public void Open(string uri)
        {
            UIApplication.SharedApplication.OpenUrl(new NSUrl(uri));
        }
    }
}