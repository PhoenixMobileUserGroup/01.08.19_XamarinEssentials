using XamarinEssentialsDemonstration.ViewModels;

namespace XamarinEssentialsDemonstration.Views
{
    public partial class DeviceDisplayInformationView : ViewBase
	{
		public DeviceDisplayInformationView ()
		{
			InitializeComponent ();
            BindingContext = new DeviceDisplayInformationViewModel();
            Title = "Device Display Information";

        }
	}
}