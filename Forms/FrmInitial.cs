using ERAProject.Class;
using ERAProject.Class.Controllers;
using System;
using System.Windows.Forms;

namespace ERAProject
{
    public partial class FrmInitial : Form
    {
        private CtrlPlayer ctrlPlayer;
        private CtrlMap ctrlMap;

        public FrmInitial()
        {
            InitializeGame();
            ctrlMap = GlobalVariables.CMap;
            ctrlPlayer = GlobalVariables.CPlayer;
            InitializeComponent();
            BindingControls();
        }

        private void InitializeGame()
        {
            GlobalVariables.CPlayer = new CtrlPlayer();
            GlobalVariables.CPlayer.ConstructPlayer(1);
            GlobalVariables.CMap = new CtrlMap();
            GlobalVariables.CMap.ContructMap(1);
        }

        //private void T_Tick(object sender, EventArgs e)
        //{
        //    ++i;
        //    rtbEventsLog.AppendText("Text"+i+" \n");
        //    rtbEventsLog.ScrollToCaret();
        //}

        private void button1_Click(object sender, EventArgs e)
        {
            //p.Hitpoints = 100;
            ////if (!t.Enabled)
            //    t.Start();
            //else
            //    t.Stop();
            ctrlPlayer.EventPlayer_DamageTaken(10);
        }

        private void FrmInitial_Load(object sender, EventArgs e)
        {
            //t = new Timer();
            //t.Tick += T_Tick;
            //t.Interval = 1500;
            ctrlPlayer.SendPlayer(8, 2);
            ctrlMap.ShowMap(Width + Left, Top);



        }

        private void BindingControls()
        {
            string controlPropName;

            #region BindingControlText
            controlPropName = "Text";

            grpbPlayerInfo.DataBindings.Add(ctrlPlayer.GetPlayerBinding(controlPropName, "Name"));
            //lbCurrentHitPoints.DataBindings.Add(ctrlPlayer.GetPlayerBinding(controlPropName, "Hitpoints"));

            lbCurrentLevel.DataBindings.Add(ctrlPlayer.GetPlayerBinding(controlPropName, "Level"));
            lbCurrentGold.DataBindings.Add(ctrlPlayer.GetPlayerBinding(controlPropName, "Gold"));
            lbCurrentXp.DataBindings.Add(ctrlPlayer.GetPlayerBinding(controlPropName, "ExperiencePoints"));

            ttbPlayerStr.DataBindings.Add(ctrlPlayer.GetPlayerStatusBinding(controlPropName, "Strength"));
            ttbPlayerDef.DataBindings.Add(ctrlPlayer.GetPlayerStatusBinding(controlPropName, "Defense"));
            ttbPlayerSpd.DataBindings.Add(ctrlPlayer.GetPlayerStatusBinding(controlPropName, "Speed"));
            ttbPlayerDex.DataBindings.Add(ctrlPlayer.GetPlayerStatusBinding(controlPropName, "Dextery"));
            ttbPlayerLuk.DataBindings.Add(ctrlPlayer.GetPlayerStatusBinding(controlPropName, "Luck"));

            controlPropName = "Maximum";

            prgbHitPoints.DataBindings.Add(ctrlPlayer.GetPlayerBinding(controlPropName, "Maxhitpoints"));

            controlPropName = "Value";

            prgbHitPoints.DataBindings.Add(ctrlPlayer.GetPlayerBinding(controlPropName, "Hitpoints"));

            #endregion

        }
    }
}
