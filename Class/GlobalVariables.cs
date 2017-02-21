using ERAProject.Class.Controllers;
using ERAProject.Class.Maps;

namespace ERAProject.Class
{
    static class GlobalVariables
    {
        private static Player _user=null;
        private static CtrlPlayer _cPlayer=null;
        private static Map _map=null;
        private static CtrlMap _cMap=null;

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
        #endregion

    }
}
