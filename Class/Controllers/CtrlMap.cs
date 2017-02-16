using System;
using System.Drawing;
using ERAProject.Class.Maps;

namespace ERAProject.Class.Controllers
{
    class CtrlMap
    {
        public void ContructMap(int mapType)
        {
            GlobalVariables.Map= new Map(mapType);
        }


        public void ShowMap(int x, int y)
        {
            FrmMap map = new FrmMap();
            map.Show();
            map.Location = new Point(x, y);
        }

        public void SendPlayerTo(int x, int y)
        {
            
        }
    }
}
