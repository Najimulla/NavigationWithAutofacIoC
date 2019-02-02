using NevigationIoC.Interfaces;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace NevigationIoC.ViewModels
{
    public class BaseViewModel : IViewModelBase
    {
        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyname = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyname));
        }
    }
}
