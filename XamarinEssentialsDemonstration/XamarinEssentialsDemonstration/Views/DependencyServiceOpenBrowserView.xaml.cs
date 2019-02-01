using XamarinEssentialsDemonstration.ViewModels;

namespace XamarinEssentialsDemonstration.Views
{
    public partial class DependencyServiceOpenBrowserView : ViewBase
	{
		public DependencyServiceOpenBrowserView ()
		{
			InitializeComponent ();
            BindingContext = new DependencyServiceOpenBrowserViewModel();
            Title = "Dependency Service Open Browser Demo";
        }
	}
}