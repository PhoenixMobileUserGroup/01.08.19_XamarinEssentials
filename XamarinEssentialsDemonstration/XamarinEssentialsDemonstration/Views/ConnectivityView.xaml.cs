using XamarinEssentialsDemonstration.ViewModels;

namespace XamarinEssentialsDemonstration.Views
{
    public partial class ConnectivityView : ViewBase
	{
		public ConnectivityView()
		{
			InitializeComponent();
            BindingContext = new ConnectivityViewModel();
            Title = "Connectivity Demo";
		}
	}
}