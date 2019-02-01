using XamarinEssentialsDemonstration.ViewModels;

namespace XamarinEssentialsDemonstration.Views
{
    public partial class GyroscopeView : ViewBase
	{
		public GyroscopeView ()
		{
			InitializeComponent ();
            BindingContext = new GyroscopeViewModel();
            Title = "Gyroscope Demo";
        }
	}
}