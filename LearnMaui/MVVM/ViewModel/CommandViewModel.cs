using PropertyChanged;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace LearnMaui.MVVM.ViewModel
{
    [AddINotifyPropertyChangedInterface]
    public class CommandViewModel
    {
        public int First { get; set; }
        public int Second { get; set; }
        public int Result { get; set; }

        public ICommand ResultCommand =>
            new Command(Calculate);

        private void Calculate(object obj)
        {
            Result = First + Second;
        }



        public string searchCommand { get; set; }
        public ICommand commandSearch =>
            new Command(Commandpara);

        private void Commandpara(object obj)
        {
            App.Current.MainPage.DisplayAlert("Hi", $"{obj}", "OK");
        }

        

        public ICommand CommandClick =>
            new Command(ExecuteAlert);

        private void ExecuteAlert(object obj)
        {
            App.Current.MainPage.DisplayAlert("Hi", "Command Example Alert!", "OK");
        }
    }
}
