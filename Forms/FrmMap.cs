using ERAProject.Class.Map;
using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace ERAProject
{
    public partial class FrmMap : Form
    {
        private ToolTip Current_tip;

        private Map mapComplete;

        public FrmMap()
        {
            mapComplete = new Map(1);
            InitializeComponent();
        }

        private void pbMapViewer_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

            //// Draw the selected hexagons.
            //foreach (PointF point in Hexagons)
            //{
            //    //e.Graphics.FillPolygon(Brushes.LightBlue,HexToPoints(HexHeight, point.X, point.Y));
            //    e.Graphics.FillPolygon(Brushes.Purple, HexToPoints(HexHeight, point.X, point.Y));
            //}

            // Color map
            mapComplete.FillMapHexagons(e.Graphics);
            // Draw the grid.
            mapComplete.DrawHexGrid(e.Graphics, Pens.Black,
                0, pbMapViewer.ClientSize.Width,
                0, pbMapViewer.ClientSize.Height,
                mapComplete.TileHeight);


        }


        private void pbMapViewer_Resize(object sender, EventArgs e)
        {
            pbMapViewer.Refresh();
        }

        /*
         * Update map X,Y on mouse over tile
        */
        private void pbMapViewer_MouseMove(object sender, MouseEventArgs e)
        {
            int row, col;
            mapComplete.PointToHex(e.X, e.Y, mapComplete.TileHeight, out row, out col);
            Text = "(" + row + ", " + col + ")";
        }

        /*
         * if not in selection add else remove from seleteds hexagons
         * case shift press , show information
        */
        private void pbMapViewer_MouseClick(object sender, MouseEventArgs e)
        {

            if (ModifierKeys == Keys.Shift)
            {
                Tile t = mapComplete.PointToTile(e.X, e.Y);
                if (t != null)
                {
                    MessageBox.Show(t.Hint + "\n Line:" + t.Row + " Collum:"+t.Collum);
                }
            }

            //mapComplete.PointToHex(e.X, e.Y, mapComplete.TileHeight, out row, out col);

            //    int row, col;
            //    PointF polygon;

            //    mapComplete.PointToHex(e.X, e.Y, mapComplete.TileHeight, out row, out col);
            //    polygon = new PointF(row, col);

            //    if (ModifierKeys == Keys.Shift)
            //    {
            //        Tile t = Tiles.Find(x => x.Point.Equals(polygon));
            //        if (t != null)
            //        {
            //            if (!t.Point.IsEmpty)
            //            {
            //                Current_tip = new ToolTip();
            //                Current_tip.ToolTipTitle = "Description of Tyle";
            //                Current_tip.Show(t.Hint, this, Cursor.Position.X, Cursor.Position.Y+25, 1000);
            //            }
            //        } 
            //    }
            //    else
            //    {
            //        if ((Hexagons.Find(x => x.Equals(polygon))).IsEmpty)
            //            Hexagons.Add(new PointF(row, col));
            //        else
            //            Hexagons.Remove(polygon);

            //        pbMapViewer.Refresh();
            //    }


        }

    }
}
