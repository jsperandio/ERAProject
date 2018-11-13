using ERAProject.Class.Controllers;
using ERAProject.Class.Maps;
using ERAProject.Model.System;
using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace ERAProject.View
{
    public partial class FrmCamera : Form
    {
        private CtrlMap ctrlMap;
        private CtrlPlayer ctrlPlayer;

        public FrmCamera()
        {
            ctrlMap = GlobalVariables.CMap;
            ctrlPlayer = GlobalVariables.CPlayer;
            InitializeComponent();
        }

        private void PbMap_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            ctrlMap.DrawMapPlayerRect(ctrlPlayer.GetPlayerTile(), e.Graphics, Pens.Black, PbMap.ClientSize);
            //map.DrawPlayerOnMap(player.GetPlayerTile(), e.Graphics);
        }

        private void PbMap_Resize(object sender, EventArgs e)
        {
            PbMap.Refresh();
        }

        private void PbMap_MouseMove(object sender, MouseEventArgs e)
        {
            Point mouse_location = e.Location;
            mouse_location = ctrlMap.ScreenToXy(mouse_location);
            Text = "Positon (" + mouse_location.X + ", " + mouse_location.Y + ")";
        }

        private void PbMap_MouseClick(object sender, MouseEventArgs e)
        {
            if (ModifierKeys == Keys.Control)
            {
                Tile t = ctrlMap.ScreenToTile(e.Location);
                if (t != null)
                {
                    ctrlPlayer.SendPlayer(t);
                    ((PictureBox)sender).Refresh();
                }
            }
        }
    }
}
