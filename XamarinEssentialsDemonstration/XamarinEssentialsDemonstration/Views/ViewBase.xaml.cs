using System;
using Xamarin.Forms;
using XamarinEssentialsDemonstration.ViewModels;

namespace XamarinEssentialsDemonstration.Views
{
    public partial class ViewBase : ContentPage
    {
        public ViewBase()
        {
            InitializeComponent();
        }

        private async void OnAppearing(object sender, EventArgs e) 
            => await (BindingContext as ViewModelBase)?.OnAppearing();

        private async void OnDisappearing(object sender, EventArgs e) 
            => await (BindingContext as ViewModelBase)?.OnDisappearing();
    }
}