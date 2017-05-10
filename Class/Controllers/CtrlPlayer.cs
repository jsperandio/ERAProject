using ERAProject.Class.Maps;
using System.Windows.Forms;

namespace ERAProject.Class.Controllers
{
    public class CtrlPlayer
    {
        public void ConstructPlayer(int playertype)
        {
            GlobalVariables.User = new Player();
            if(playertype==1)
            SendPlayer(8,2);
            //To-Do
            //mudar isso para a Initical City 
        }

        public Binding GetPlayerBinding(string controlPropertyName , string objectProperty)
        {
            return new Binding(controlPropertyName, GlobalVariables.User, objectProperty);
        }

        public Binding GetPlayerStatusBinding(string controlPropertyName, string objectProperty)
        {
            return new Binding(controlPropertyName, GlobalVariables.User.StatusPlayer, objectProperty);
        }

        public Binding GetPlayerTileBinding(string controlPropertyName, string objectProperty)
        {
            return new Binding(controlPropertyName, GlobalVariables.User.PlayerCurrentTile, objectProperty);
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
        
        public bool IsAlive()
        {
            return GlobalVariables.User.Hitpoints > 0;
        }

        public void EventPlayer_DamageTaken(int damageTaken)
        {
            GlobalVariables.User.Hitpoints -= damageTaken;
            if (IsAlive())
                GlobalVariables.LogTrack.Add(new Log(System.DateTime.Now, "Damage Taken of " + damageTaken,"System",LogEventType.WarningEvent));
        }
    }
}
