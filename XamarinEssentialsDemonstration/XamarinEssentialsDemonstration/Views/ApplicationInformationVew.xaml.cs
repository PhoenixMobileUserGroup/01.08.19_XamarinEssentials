using XamarinEssentialsDemonstration.ViewModels;

namespace XamarinEssentialsDemonstration.Views
{
    public partial class ApplicationInformationVew : ViewBase
	{
		public ApplicationInformationVew ()
		{
			InitializeComponent ();
            BindingContext = new ApplicationInformationViewModel();
            Title = "Application Information Demo";
		}
	}
}