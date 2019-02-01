using XamarinEssentialsDemonstration.ViewModels;

namespace XamarinEssentialsDemonstration.Views
{
    public partial class VibrationView : ViewBase
	{
		public VibrationView ()
		{
			InitializeComponent ();
            BindingContext = new VibrationViewModel();
            Title = "Vibration Demo";

        }
	}
}