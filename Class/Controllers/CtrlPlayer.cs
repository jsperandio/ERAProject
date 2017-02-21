using ERAProject.Class.Maps;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ERAProject.Class.Controllers
{
    class CtrlPlayer
    {
        public void ConstructPlayer(int playertype)
        {
            GlobalVariables.User = new Player();
        }

        public Binding GetPlayerBinding(string controlPropertyName , string objectProperty)
        {
            return new Binding(controlPropertyName, GlobalVariables.User, objectProperty);
        }

        public Binding GetPlayerStatusBinding(string controlPropertyName, string objectProperty)
        {
            return new Binding(controlPropertyName, GlobalVariables.User.StatusPlayer, objectProperty);
        }

        public void SendPlayer(int x,int y)
        {
            GlobalVariables.User.PlayerCurrentTile = GlobalVariables.CMap.GetTileByXY(x,y);
        }

        public Tile GetPlayerTile()
        {
            return GlobalVariables.User.PlayerCurrentTile;
        }
    }
}
