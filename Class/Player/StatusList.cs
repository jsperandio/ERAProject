using System.ComponentModel;

namespace ERAProject.Class
{
    public class StatusList : INotifyPropertyChanged
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
