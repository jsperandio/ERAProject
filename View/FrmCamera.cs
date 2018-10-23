using ERAProject.Class.Controllers;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace ERAProject.View
{
    public partial class FrmCamera : Form
    {
        private CtrlMap map;
        private CtrlPlayer player;

        public FrmCamera()
        {
            InitializeComponent();
            map = new CtrlMap();
            player = new CtrlPlayer();
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {

            map.DrawMapPlayerOnCenter(e.Graphics, Pens.Black, pictureBox1.ClientSize);
            map.DrawPlayerOnMap(player.GetPlayerTile(), e.Graphics);

            //map.DrawBaseMap(e.Graphics, Pens.Black, pictureBox1.ClientSize);

        }

        private void pictureBox1_Resize(object sender, EventArgs e)
        {
            pictureBox1.Refresh();
        }
    }
}
