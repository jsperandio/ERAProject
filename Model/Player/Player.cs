using ERAProject.Class.Maps;
using ERAProject.Model.System;
using System.ComponentModel;
using System.Drawing;

namespace ERAProject.Class
{
    public class Player : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        private string _name;
        private int _maxhitpoints;
        private int _hitpoints;
        private int _gold;
        private int _level;
        private int _experiencePoints;
        private Tile _playerCurrentTile;
        private Image _playerImage;
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
        public int Maxhitpoints
        {
            get
            {
                return _maxhitpoints;
            }

            set
            {
                _maxhitpoints = value;
                OnPropertyChanged("Level");
            }
        }

        /* Validate max damage and max Heal on player */
        public int Hitpoints
        {
            get
            {
                return _hitpoints;
            }

            set
            {
                _hitpoints = (value >= 0 ? (value <= _maxhitpoints ? value : _maxhitpoints) : 0);
                OnPropertyChanged("Hitpoints");
                if (_hitpoints == 0)
                    Death();
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

        public Tile PlayerCurrentTile
        {
            get
            {
                return _playerCurrentTile;
            }

            set
            {
                _playerCurrentTile = value;
                OnPropertyChanged("PlayerCurrentTile");
                Moviment(value);
            }
        }

        public Image PlayerImage
        {
            get
            {
                return _playerImage;
            }

            set
            {
                _playerImage = value;
            }
        }
        #endregion

        #region Constructors
        public Player()
        {
            //Name = "John Doe";
            //Maxhitpoints = 100;
            //Hitpoints = Maxhitpoints;
            //Gold = 50;
            //Level = 1;
            //ExperiencePoints = 0;
            //_playerCurrentTile = null;
            PlayerImage = Image.FromFile(GlobalVariables.ProjectPath + "\\Model\\LoadFiles\\battle-gear.png");
            //StatusPlayer = new StatusList();
        }

        public Player(PlayerType pt)
        {

        }
        #endregion

        protected virtual void OnPropertyChanged(string property)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(property));
        }

        public void Death()
        {
            GlobalVariables.LogTrack.Add(new Log(System.DateTime.Now, "You are dead!", Name, LogEventType.CriticalEvent));
        }

        private void Moviment(Tile t)
        {
            GlobalVariables.LogTrack.Add(new Log(System.DateTime.Now, "Moving to tile {"+t.Row+","+t.Column+"} !", Name, LogEventType.InformationEvent));
        }

    }
}
