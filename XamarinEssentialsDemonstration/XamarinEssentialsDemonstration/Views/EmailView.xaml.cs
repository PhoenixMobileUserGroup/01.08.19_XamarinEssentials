using XamarinEssentialsDemonstration.ViewModels;

namespace XamarinEssentialsDemonstration.Views
{
    public partial class EmailView : ViewBase
	{
		public EmailView ()
		{
			InitializeComponent ();
            BindingContext = new EmailViewModel();
            Title = "Email Demo";
        }
	}
}