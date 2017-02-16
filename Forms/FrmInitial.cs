using ERAProject.Class;
using ERAProject.Class.Controllers;
using System;
using System.Windows.Forms;

namespace ERAProject
{
    public partial class FrmInitial : Form
    {
        private Player p;
        private CtrlMap cMap;

        public FrmInitial()
        {
            InitializeGame();
            cMap = GlobalVariables.CMap;
            p = GlobalVariables.User;
            InitializeComponent();

            BindingControls();
        }

        private void InitializeGame()
        {
            GlobalVariables.CMap = new CtrlMap();
            GlobalVariables.CMap.ContructMap(1);
            GlobalVariables.CPlayer = new CtrlPlayer();
            GlobalVariables.CPlayer.ConstructPlayer(1);
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
         
            cMap.ShowMap(Width+Left,Top);
            cMap.SendPlayerTo(1,1);
            

        }

        private void BindingControls()
        {
            grpbPlayerInfo.DataBindings.Add(new Binding("Text", p, "Name"));
            lbCurrentHitPoints.DataBindings.Add("Text", p, "Hitpoints");
            lbCurrentLevel.DataBindings.Add("Text", p, "Level");
            lbCurrentGold.DataBindings.Add("Text", p, "Gold");
            lbCurrentXp.DataBindings.Add("Text", p, "ExperiencePoints");

            ttbPlayerStr.DataBindings.Add("Text", p.StatusPlayer, "Strength");
            ttbPlayerDef.DataBindings.Add("Text", p.StatusPlayer, "Defense");
            ttbPlayerSpd.DataBindings.Add("Text", p.StatusPlayer, "Speed");
            ttbPlayerDex.DataBindings.Add("Text", p.StatusPlayer, "Dextery");
            ttbPlayerLuk.DataBindings.Add("Text", p.StatusPlayer, "Luck");


        }
    }
}
