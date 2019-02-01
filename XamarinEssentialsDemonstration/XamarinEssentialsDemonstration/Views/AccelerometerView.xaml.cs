using XamarinEssentialsDemonstration.ViewModels;

namespace XamarinEssentialsDemonstration.Views
{
    public partial class AccelerometerView : ViewBase
	{
		public AccelerometerView ()
		{
			InitializeComponent();
            BindingContext = new AccelerometerViewModel();
            Title = "Accelerometer Demo";
		}
	}
}