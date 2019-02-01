using XamarinEssentialsDemonstration.ViewModels;

namespace XamarinEssentialsDemonstration.Views
{
    public partial class ClipboardView : ViewBase
	{
		public ClipboardView ()
		{
			InitializeComponent ();
            BindingContext = new ClipboardViewModel();
            Title = "Clipboard Demo";
		}
	}
}