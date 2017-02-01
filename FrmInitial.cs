using ERAProject.Class;
using System;
using System.Windows.Forms;

namespace ERAProject
{
    public partial class FrmInitial : Form
    {
        private int i = 0;
        private Timer t;
        private Player p;
        public FrmInitial()
        {
            InitializeComponent();

        }

        private void T_Tick(object sender, EventArgs e)
        {
            ++i;
            rtbEventsLog.AppendText("Text"+i+" \n");
            rtbEventsLog.ScrollToCaret();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            p.Name = "APERTOU BOTÃO";
            if (!t.Enabled)
                t.Start();
            else
                t.Stop();
        }

        private void FrmInitial_Load(object sender, EventArgs e)
        {
            t = new Timer();
            t.Tick += T_Tick;
            t.Interval = 1500;
            p = new Player();

            grpbPlayerInfo.DataBindings.Add(new Binding("Text", p, "Name"));

        }
    }
}
