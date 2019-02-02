using System.Windows.Input;
using Xamarin.Forms;

namespace NevigationIoC.ViewModels
{
    public class SecondViewModel : BaseViewModel
    {
        public string PageTitle => "Second Page";
        public string IncrementButtonText => "Increment";

        private int _ValueToChange;

        public int ValueToChange
        {
            get { return _ValueToChange; }
            set
            {
                _ValueToChange = value;
                OnPropertyChanged("ValueToChange");
            }
        }


        // public int ValueToChange { get; set; }

        //[DependsOn(nameof(ValueToChange))]
        public string ValueToChangeIndirectly => $"I depend on the value #{ValueToChange} above";

        public ICommand IncrementValueCommand => new Command(() => ++ValueToChange);
    }
}
