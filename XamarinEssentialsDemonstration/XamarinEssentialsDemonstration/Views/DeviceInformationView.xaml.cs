using XamarinEssentialsDemonstration.ViewModels;

namespace XamarinEssentialsDemonstration.Views
{
    public partial class DeviceInformationView : ViewBase
	{
		public DeviceInformationView ()
		{
			InitializeComponent ();
            BindingContext = new DeviceInformationViewModel();
            Title = "Device Information Demo";
        }
	}
}