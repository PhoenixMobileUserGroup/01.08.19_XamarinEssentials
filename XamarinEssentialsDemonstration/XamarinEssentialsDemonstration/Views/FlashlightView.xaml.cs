using XamarinEssentialsDemonstration.ViewModels;

namespace XamarinEssentialsDemonstration.Views
{
    public partial class FlashlightView : ViewBase
	{
		public FlashlightView()
		{
			InitializeComponent();
            BindingContext = new FlashlightViewModel();
            Title = "Flashlight Demo";
        }
	}
}