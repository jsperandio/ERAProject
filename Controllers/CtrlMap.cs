using System.Drawing;
using ERAProject.Class.Maps;
using ERAProject.Model.System;

namespace ERAProject.Class.Controllers
{
    public class CtrlMap
    {
        public FrmMap FormMapViewer = null;
        private Map _map = null;
        public void ContructMap(int mapType)
        {
            GlobalVariables.Map = new Map(mapType, 6);
            _map = GlobalVariables.Map;
        }


        public void ShowMap(int x, int y)
        {
            FormMapViewer = FormMapViewer ?? new FrmMap();
            if (!FormMapViewer.Visible)
                FormMapViewer.Show();
            else
                FormMapViewer.Hide();

            FormMapViewer.Location = new Point(x, y);
        }

        public Tile GetTileByXy(int x, int y)
        {
            return _map.XyToTile(x, y);
        }

        public float GetTileHeight()
        {
            return _map.TileHeight;
        }

        public int GetMiniMapOffset()
        {
            return _map.OffsetMiniMap;
        }

        public Point ScreenToXy(Point screenLocation)
        {
            _map.PointToHexagon(screenLocation.X, screenLocation.Y,
                                            GetTileHeight(), out int row, out int col);
            return new Point(row, col);
        }

        public Tile ScreenToTile(Point location)
        {
            return _map.PointToTile(location.X, location.Y);
        }

        public void DrawBaseMap(Graphics graphics, Pen borderColor, Size clientSize)
        {
            // Color map
            _map.FillMapHexagons(graphics);
            // Draw the grid.
            _map.DrawHexagonsGrid(graphics, borderColor,
                                  0, clientSize.Width,
                                  0, clientSize.Height,
                                  GetTileHeight());

        }

        public void DrawMapPlayerOnCenter(Graphics graphics, Pen borderColor, Size clientSize)
        {
            _map.DrawMapRect(GlobalVariables.CPlayer.GetPlayerTile(), 6, 6, graphics);

            //GlobalVariables.Map.DrawHexagonsGridWithPositons(graphics, borderColor,
            //                                                   0, clientSize.Width,
            //                                                   0, clientSize.Height,
            //                                                   GetTileHeight());
        }

        public void DrawMapPlayerRect(Tile tile, Graphics graphics, Pen borderColor, Size clientSize)
        {
            float offset_x, offset_y;
            CtrlPlayer _ctrlPlayer = GlobalVariables.CPlayer;

            _map.DrawMapRectOnTopLeft(graphics, _ctrlPlayer.GetPlayerTile(),out offset_x,out offset_y);

            DrawPlayerOnMap(tile, graphics,offset_x,offset_y);
        }

        public void DrawPlayerOnMap(Tile tile, Graphics graphics, float offset_x,float offset_y)
        {
            if (tile != null)
            {
                PointF[] points = _map.HexagonToPoints(GetTileHeight(), tile.Point.X, tile.Point.Y);
                float x = points[0].X + 3;
                float y = points[1].Y;

                graphics.DrawImage(GlobalVariables.User.PlayerImage, x - offset_x, y-offset_y);
            }
        }

        public void DrawPlayerOnMap(Tile tile, Graphics graphics)
        {
            if (tile != null)
            {
                PointF[] points = _map.HexagonToPoints(GetTileHeight(), tile.Point.X, tile.Point.Y);
                float x = points[0].X + 3;
                float y = points[1].Y;

                graphics.DrawImage(GlobalVariables.User.PlayerImage, x, y);

            }
        }

        public void DrawStringOnTile(Tile tile, Graphics graphics, Font originalFont)
        {
            using (StringFormat sf = new StringFormat())
            {
                PointF[] points = _map.HexagonToPoints(GetTileHeight(), tile.Point.X, tile.Point.Y);
                sf.Alignment = StringAlignment.Center;
                sf.LineAlignment = StringAlignment.Center;

                float x = (points[0].X + points[3].X) / 2;
                float y = (points[1].Y + points[4].Y) / 2;
                //string label = "(" + tile.Row.ToString() + ", " +
                //     tile.Column.ToString() + ")";
                Font localFont = new Font(originalFont, FontStyle.Bold);

                graphics.DrawString(GlobalVariables.User.Name, localFont, Brushes.Black, x, y, sf);
            }
        }

        public Color GetTileColor(Tile t)
        {
            return t.TileColor;
        }

        public Brush GetTileBrushColor(Tile t)
        {
            return t.TileBrushColor;
        }

        public void Refresh()
        {
            _map.ImportMap();
        }
    }
}
