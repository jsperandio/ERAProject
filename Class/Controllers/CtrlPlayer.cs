using ERAProject.Class.Maps;
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

        public Tile GetPlayerTile()
        {
            return GlobalVariables.User.PlayerCurrentTile;
        }


        public void SendPlayer(int x, int y)
        {
            GlobalVariables.User.PlayerCurrentTile = GlobalVariables.CMap.GetTileByXy(x, y);
        }

        public void SendPlayer(Tile t)
        {
            GlobalVariables.User.PlayerCurrentTile = t;
        }

        public void EventPlayer_DamageTaken(int damageTaken)
        {
            GlobalVariables.User.Hitpoints -= damageTaken;
        }
    }
}
