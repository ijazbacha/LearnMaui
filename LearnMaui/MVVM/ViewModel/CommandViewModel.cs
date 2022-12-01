using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace LearnMaui.MVVM.ViewModel
{
    public class CommandViewModel
    {
        public ICommand CommandClick =>
            new Command(ExecuteAlert);

        private void ExecuteAlert(object obj)
        {
            App.Current.MainPage.DisplayAlert("Hi", "Command Example Alert!", "OK");
        }
    }
}
