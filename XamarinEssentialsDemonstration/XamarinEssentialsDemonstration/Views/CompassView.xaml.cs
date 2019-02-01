using XamarinEssentialsDemonstration.ViewModels;

namespace XamarinEssentialsDemonstration.Views
{
    public partial class CompassView : ViewBase
	{
		public CompassView ()
		{
			InitializeComponent ();
            BindingContext = new CompassViewModel();
            Title = "Compass Demo";
		}
	}
}