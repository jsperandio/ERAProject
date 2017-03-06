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

        public Tile GetTileByXy(int x, int y)
        {
            return GlobalVariables.Map.XyToTile(x, y);
        }

        public float GetTileHeight()
        {
            return GlobalVariables.Map.TileHeight;
        }

        public Point ScreenToXy(Point screenLocation)
        {
            int row, col;
            GlobalVariables.Map.PointToHex(screenLocation.X, screenLocation.Y,
                                            GetTileHeight(), out row, out col);
            return new Point(row,col);
        }

        public Tile ScreenToTile(Point location)
        {
            return GlobalVariables.Map.PointToTile(location.X, location.Y);
        }

        public void DrawBaseMap(Graphics graphics, Pen borderColor, Size clientSize)
        {
            // Color map
            GlobalVariables.Map.FillMapHexagons(graphics);
            // Draw the grid.
            GlobalVariables.Map.DrawHexagonsGrid(graphics, borderColor,
                                            0, clientSize.Width,
                                            0, clientSize.Height,
                                            GetTileHeight());
        }

        public void DrawPlayerOnMap(Tile tile, Graphics graphics)
        {
            if (tile != null)
            { 
                PointF[] points = GlobalVariables.Map.HexToPoints(GetTileHeight(), tile.Point.X, tile.Point.Y);

                float x = ((points[0].X + points[3].X) / 3) + 8;
                float y = ((points[1].Y + points[4].Y) / 2) - 15;

                graphics.DrawImage(GlobalVariables.User.PlayerImage, x, y);

                //gr.DrawPolygon(Pens.Cyan, HexToPoints(_tileHeight, tile.Point.X, tile.Point.Y));
            }
        }
    }
}
