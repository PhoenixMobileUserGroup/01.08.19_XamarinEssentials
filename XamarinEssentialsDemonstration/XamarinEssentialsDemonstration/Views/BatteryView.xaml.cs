using XamarinEssentialsDemonstration.ViewModels;

namespace XamarinEssentialsDemonstration.Views
{
    public partial class BatteryView : ViewBase
	{
		public BatteryView ()
		{
			InitializeComponent ();
            BindingContext = new BatteryViewModel();
            Title = "Battery Demp";
		}
	}
}