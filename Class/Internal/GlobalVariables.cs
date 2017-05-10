using ERAProject.Class.Controllers;
using ERAProject.Class.Maps;
using System.Collections.ObjectModel;
using System.IO;

namespace ERAProject.Class
{
    public static class GlobalVariables
    {
        private static Player _user=null;
        private static CtrlPlayer _cPlayer=null;
        private static Map _map=null;
        private static CtrlMap _cMap=null;
        private static ObservableCollection<Log>  _logTrack = null;
        private static CtrlLog _cLog = null;
        private static string _projectPath = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName;

        #region Encapsulate Fields
        internal static Map Map
        {
            get
            {
                return _map;
            }

            set
            {
                _map = value;
            }
        }

        internal static CtrlMap CMap
        {
            get
            {
                return _cMap;
            }

            set
            {
                _cMap = value;
            }
        }

        internal static Player User
        {
            get
            {
                return _user;
            }

            set
            {
                _user = value;
            }
        }

        internal static CtrlPlayer CPlayer
        {
            get
            {
                return _cPlayer;
            }

            set
            {
                _cPlayer = value;
            }
        }

        public static string ProjectPath
        {
            get
            {
                return _projectPath;
            }

            set
            {
                _projectPath = value;
            }
        }
        internal static CtrlLog CLog { get => _cLog; set => _cLog = value; }
        internal static ObservableCollection<Log> LogTrack { get => _logTrack; set => _logTrack = value; }
        #endregion

    }
}
