using ERAProject.Class;
using ERAProject.Class.Controllers;
using ERAProject.Data;
using ERAProject.Forms;
using System;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.Windows.Forms;

namespace ERAProject
{
    public partial class FrmInitial : Form
    {
        private CtrlPlayer ctrlPlayer;
        private CtrlMap ctrlMap;
        private CtrlLog ctrlLog;

        public FrmInitial()
        {
            ctrlMap = GlobalVariables.CMap;
            ctrlPlayer = GlobalVariables.CPlayer;
            ctrlLog = GlobalVariables.CLog;
            InitializeComponent();
            BindingControls();
        }

        private void FrmInitial_Load(object sender, EventArgs e)
        {
            DataAcess.Instance.CreateIfNotExists();
            ctrlPlayer.SendPlayer(8, 2);
            ctrlMap.ShowMap(Width + Left, Top);
        }

        private void BindingControls()
        {
            string controlPropName;

            #region BindingControlText

            controlPropName = "Text";

            grpbPlayerInfo.DataBindings.Add(ctrlPlayer.GetPlayerBinding(controlPropName, "Name"));

            #region Labels

            //lbCurrentHitPoints.DataBindings.Add(ctrlPlayer.GetPlayerBinding(controlPropName, "Hitpoints"));
            lbCurrentLevel.DataBindings.Add(ctrlPlayer.GetPlayerBinding(controlPropName, "Level"));
            lbCurrentGold.DataBindings.Add(ctrlPlayer.GetPlayerBinding(controlPropName, "Gold"));
            lbCurrentXp.DataBindings.Add(ctrlPlayer.GetPlayerBinding(controlPropName, "ExperiencePoints"));
            lbTitle.DataBindings.Add(ctrlPlayer.GetPlayerBinding(controlPropName, "PlayerCurrentTile.Hint"));
            #endregion

            #region TextBox

            ttbPlayerStr.DataBindings.Add(ctrlPlayer.GetPlayerStatusBinding(controlPropName, "Strength"));
            ttbPlayerDef.DataBindings.Add(ctrlPlayer.GetPlayerStatusBinding(controlPropName, "Defense"));
            ttbPlayerSpd.DataBindings.Add(ctrlPlayer.GetPlayerStatusBinding(controlPropName, "Speed"));
            ttbPlayerDex.DataBindings.Add(ctrlPlayer.GetPlayerStatusBinding(controlPropName, "Dextery"));
            ttbPlayerLuk.DataBindings.Add(ctrlPlayer.GetPlayerStatusBinding(controlPropName, "Luck"));

            #endregion

            #region ProgressBar
            controlPropName = "Maximum";

            prgbHitPoints.DataBindings.Add(ctrlPlayer.GetPlayerBinding(controlPropName, "Maxhitpoints"));

            controlPropName = "Value";

            prgbHitPoints.DataBindings.Add(ctrlPlayer.GetPlayerBinding(controlPropName, "Hitpoints"));

            #endregion

            controlPropName = "BackColor";
            pnTitle.DataBindings.Add(ctrlPlayer.GetPlayerBinding(controlPropName, "PlayerCurrentTile.TileColor"));


            ctrlLog.SetOnChangedEvent(OnLogTrackChange);

            #endregion

        }

        private void OnLogTrackChange(object sender, NotifyCollectionChangedEventArgs e)
        {
            switch (e.Action)
            {
                case NotifyCollectionChangedAction.Add:
                    {
                        for (int i = 0; i < e.NewItems.Count; i++)
                        {
                            rtbEventsLog.AppendText((Log)e.NewItems[i]);
                            rtbEventsLog.ScrollToCaret();
                            ((ObservableCollection<Log>)sender).RemoveAt(i);
                        }
                        break;
                    }
                    //case NotifyCollectionChangedAction.Remove:
                    //    {
                    //        //OnRemove(sender, e);
                    //        break;
                    //    }

            }
        }

        private void tsBtnMap_Click(object sender, EventArgs e)
        {
            ctrlMap.ShowMap(Width + Left, Top);
        }

        private void tsBtnBackpack_Click(object sender, EventArgs e)
        {
            FrmBackpack bp = new FrmBackpack();
            bp.Show();

        }
    }
}
