using PropertyChanged;
using System.Threading.Tasks;

namespace XamarinEssentialsDemonstration.ViewModels
{
    [AddINotifyPropertyChangedInterface]
    public abstract class ViewModelBase
    {
        public virtual Task OnAppearing() { return Task.CompletedTask; }
        public virtual Task OnDisappearing() { return Task.CompletedTask; }
    }
}
