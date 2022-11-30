using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace LearnMaui.Model 
{
    public class Employee : INotifyPropertyChanged
    {
        private int id;
        public int Id { get => id; set
            {
                id = value;
                onPropertyChanged();
            } }

        private string name;
        public string Name { get => name; set
            {
                name = value;
                onPropertyChanged();
            }
                }

        public event PropertyChangedEventHandler PropertyChanged;
        protected void onPropertyChanged(string propName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propName));
        }
    }
}
