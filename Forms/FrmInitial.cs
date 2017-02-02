using ERAProject.Class;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace ERAProject
{
    public partial class FrmInitial : Form
    {
        private Player p;

        public FrmInitial()
        {
            InitializeComponent();
        }

        //private void T_Tick(object sender, EventArgs e)
        //{
        //    ++i;
        //    rtbEventsLog.AppendText("Text"+i+" \n");
        //    rtbEventsLog.ScrollToCaret();
        //}

        private void button1_Click(object sender, EventArgs e)
        {
            p.Name = "APERTOU BOTÃO";
            p.Hitpoints = 100;
            //if (!t.Enabled)
            //    t.Start();
            //else
            //    t.Stop();
        }

        private void FrmInitial_Load(object sender, EventArgs e)
        {
            //t = new Timer();
            //t.Tick += T_Tick;
            //t.Interval = 1500;
            p = new Player();
            FrmMap map = new FrmMap();
            
            map.Show(this);
            map.Location = new Point(Left + Width, Top);
            BindingControls();

        }

        private void BindingControls()
        {
            grpbPlayerInfo.DataBindings.Add(new Binding("Text", p, "Name"));
            lbCurrentHitPoints.DataBindings.Add("Text", p, "Hitpoints");
            lbCurrentLevel.DataBindings.Add("Text", p, "Level");
            lbCurrentGold.DataBindings.Add("Text", p, "Gold");
            lbCurrentXp.DataBindings.Add("Text", p, "ExperiencePoints");
        }
    }
}
