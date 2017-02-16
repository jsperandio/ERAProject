using ERAProject.Class.Controllers;
using ERAProject.Class.Maps;

namespace ERAProject.Class
{
    static class GlobalVariables
    {
        private static Player _user;
        private static CtrlPlayer _cPlayer;
        private static Map _map=null;
        private static CtrlMap cMap=null;

        #region Encapsulate Fields
        internal static Maps.Map Map
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
                return cMap;
            }

            set
            {
                cMap = value;
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
