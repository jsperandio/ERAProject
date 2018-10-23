using ERAProject.Class.Maps;
using ERAProject.DAO;
using ERAProject.Forms;
using ERAProject.Model.System;
using System.Drawing;
using System.Windows.Forms;

namespace ERAProject.Class.Controllers
{
    public class CtrlPlayer
    {
        public FrmBackpack FormBackpack=null;
        public void ConstructPlayer(PlayerType playertype)
        {
            switch(playertype)
            {
                case PlayerType.New:
                    {
                        GlobalVariables.User = new Player();
                        //To-Do
                        //mudar isso para a Initical City 
                        SendPlayer(7, 3);
                        break;
                    }
                case PlayerType.Load:
                    {
                        PlayerDAO pDao = new PlayerDAO();

                        GlobalVariables.User = pDao.Carregar("Teste");
                        SendPlayer(7, 3);
                        break;
                    }
            }
           
          
        }

        public void ShowBackpack(int x,int y)
        {
            FormBackpack = FormBackpack ?? new FrmBackpack();
            if (!FormBackpack.Visible)
                FormBackpack.Show();
            else
                FormBackpack.Hide();

            FormBackpack.Location = new Point(x - FormBackpack.Width, y);
        }


        public Binding GetPlayerBinding(string controlPropertyName, string objectProperty)
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
                GlobalVariables.LogTrack.Add(new Log(System.DateTime.Now, "Damage Taken of " + damageTaken, "System", LogEventType.WarningEvent));
        }
    }
}
