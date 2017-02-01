using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERAProject.Class
{
    class StatusList : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public int Strength { get; set; }
        public int Defense { get; set; }
        public int Speed { get; set; }
        public int Dextery { get; set; }
        public int Luck { get; set; }

        public StatusList()
        {
            Strength = 1;
            Defense = 1;
            Speed = 1;
            Dextery = 1;
            Luck = 1;
        }

        protected virtual void OnPropertyChanged(string property)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(property));
        }
    }
}
