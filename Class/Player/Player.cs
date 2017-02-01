using System.ComponentModel;

namespace ERAProject.Class
{
    class Player : INotifyPropertyChanged
    {
        private string _name;
        public string Name
        {
            get { return _name; }
            set
            {
                _name = value;
                OnPropertyChanged("Name");
            }
        }
        public int Hitpoints { get; set; }
        public int Level { get; set; }
        public int Gold { get; set; }
        public int ExperiencePoints { get; set; }
        public int RemainingStamina { get; set; }
        public StatusList StatusPlayer { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;


        public Player()
        {
            Name = "Test";
            Hitpoints = 10;
            Level = 1;
            Gold = 0;
            ExperiencePoints = 0;
            RemainingStamina = 8;
            StatusPlayer = new StatusList();
        }

        protected virtual void OnPropertyChanged(string property)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(property));
        }
    }
}
