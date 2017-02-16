using ERAProject.Class.Maps;
using System.ComponentModel;

namespace ERAProject.Class
{
    class Player : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        private string _name;
        private int _hitpoints;
        private int _gold;
        private int _level;
        private int _experiencePoints;
        private Tile _playerCurrentTile;
        public StatusList StatusPlayer { get; set; }

        #region Encapsulate Fields
        public string Name
        {
            get { return _name; }
            set
            {
                _name = value;
                OnPropertyChanged("Name");
            }
        }

        public int Gold
        {
            get
            {
                return _gold;
            }

            set
            {
                _gold = value;
                OnPropertyChanged("Gold");
            }
        }

        public int ExperiencePoints
        {
            get
            {
                return _experiencePoints;
            }

            set
            {
                _experiencePoints = value;
                OnPropertyChanged("Experiencepoints");
            }
        }

        public int Hitpoints
        {
            get
            {
                return _hitpoints;
            }

            set
            {
                _hitpoints = value;
                OnPropertyChanged("Hitpoints");
            }
        }

        public int Level
        {
            get
            {
                return _level;
            }

            set
            {
                _level = value;
                OnPropertyChanged("Level");
            }
        }

        internal Tile PlayerCurrentTile
        {
            get
            {
                return _playerCurrentTile;
            }

            set
            {
                _playerCurrentTile = value;
            }
        }
        #endregion

        #region Constructors
        public Player()
        {
            Name = "Test";
            Hitpoints = 100;
            Gold = 50;
            Level = 1;
            ExperiencePoints = 0;
            _playerCurrentTile = null;
            StatusPlayer = new StatusList();
        }
        #endregion

        protected virtual void OnPropertyChanged(string property)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(property));
        }
    }
}
