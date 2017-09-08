using ERAProject.Class;
using ERAProject.Class.Controllers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ERAProject.View
{
    public partial class FrmCamera : Form
    {
        public FrmCamera()
        {
            InitializeComponent();
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            CtrlMap map = new CtrlMap();
            CtrlPlayer player = new CtrlPlayer();
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
