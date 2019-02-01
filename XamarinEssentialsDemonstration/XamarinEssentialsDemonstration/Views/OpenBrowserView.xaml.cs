using XamarinEssentialsDemonstration.ViewModels;

namespace XamarinEssentialsDemonstration.Views
{
    public partial class OpenBrowserView : ViewBase
	{
		public OpenBrowserView ()
		{
			InitializeComponent ();
            BindingContext = new OpenBrowserViewModel();
            Title = "Open Browser Demo";
        }
	}
}