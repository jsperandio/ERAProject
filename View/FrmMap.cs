using ERAProject.Class;
using ERAProject.Class.Controllers;
using ERAProject.Class.Maps;
using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace ERAProject
{
    public partial class FrmMap : Form
    {
        private CtrlPlayer ctrlPlayer;
        private CtrlMap ctrlMap;

        public FrmMap()
        {
            ctrlPlayer = GlobalVariables.CPlayer;
            ctrlMap = GlobalVariables.CMap;
            InitializeComponent();
            pbMapViewer.Left += 100; 
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

            ctrlMap.DrawBaseMap(e.Graphics, Pens.Black, pbMapViewer.ClientSize);
            ctrlMap.DrawPlayerOnMap(ctrlPlayer.GetPlayerTile(), e.Graphics);
            //ctrlMap.DrawStringOnTile(ctrlPlayer.GetPlayerTile(), e.Graphics, Font);
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
            Point mouse_location = e.Location;
            mouse_location= ctrlMap.ScreenToXy(mouse_location);
            Text = "Map Viewer (" + mouse_location.X + ", " + mouse_location.Y + ")";
        }

        /*
         * if not in selection add else remove from seleteds hexagons
         * case shift press , show information
        */
        private void pbMapViewer_MouseClick(object sender, MouseEventArgs e)
        {

            if (ModifierKeys == Keys.Shift)
            {
                Tile t = ctrlMap.ScreenToTile(e.Location);
                if (t != null)
                {
                    MessageBox.Show(t.Hint + "\n Line:" + t.Row + " Collum:"+t.Column);
                }
            }
            if (ModifierKeys == Keys.Control)
            {
                Tile t = ctrlMap.ScreenToTile(e.Location);
                if (t != null)
                {
                    ctrlPlayer.SendPlayer(t);
                    pbMapViewer.Refresh();
                }
            }


            //mapComplete.PointToHex(e.X, e.Y, mapComplete.TileHeight, out row, out col);

            //    int row, col;
            //    PointF polygon;

            //    mapComplete.PointToHex(e.X, e.Y, mapComplete.TileHeight, out row, out col);
            //    polygon = new PointF(row, col);

            //    if (ModifierKeys == Keys.Shift)
            //    {
            //        if ((Hexagons.Find(x => x.Equals(polygon))).IsEmpty)
            //            Hexagons.Add(new PointF(row, col));
            //        else
            //            Hexagons.Remove(polygon);

            //        pbMapViewer.Refresh();
            //    }


        }

        private void FrmMap_FormClosing(object sender, FormClosingEventArgs e)
        {
            Hide();
            e.Cancel = true;
        }

        private void FrmMap_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.F5)
            {
                ctrlMap.Refresh();
                pbMapViewer.Refresh();
            }
        }
    }
}
