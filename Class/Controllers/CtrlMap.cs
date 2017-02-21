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
            FrmMap form_map = new FrmMap();
            form_map.Show();
            form_map.Location = new Point(x, y);
        }

        public Tile GetTileByXY(int x, int y)
        {
            return GlobalVariables.Map.PointToTile(x, y);
        }
    }
}
