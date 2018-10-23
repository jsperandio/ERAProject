using ERAProject.Class.Controllers;
using ERAProject.Model.System;
using ERAProject.View;
using System;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.Windows.Forms;

namespace ERAProject
{
    public partial class FrmInitial : Form
    {
        private CtrlPlayer _ctrlPlayer;
        private CtrlMap _ctrlMap;
        private CtrlLog _ctrlLog;

        public FrmInitial()
        {
            _ctrlMap = GlobalVariables.CMap;
            _ctrlPlayer = GlobalVariables.CPlayer;
            _ctrlLog = GlobalVariables.CLog;

            InitializeComponent();
            BindingControls();
        }

        private void FrmInitial_Load(object sender, EventArgs e)
        {
            _ctrlPlayer.SendPlayer(8, 2);
            _ctrlMap.ShowMap(Width + Left, Top);
        }

        
        /// <summary>
        /// Metodo responsavel por realizar o espelhamento 
        /// dos dados com a UI.
        /// </summary>
        private void BindingControls()
        {
            string controlPropName;

            #region BindingControlText

            controlPropName = "Text";

            grpbPlayerInfo.DataBindings.Add(_ctrlPlayer.GetPlayerBinding(controlPropName, "Name"));

            #region Labels

            //lbCurrentHitPoints.DataBindings.Add(ctrlPlayer.GetPlayerBinding(controlPropName, "Hitpoints"));
            lbCurrentLevel.DataBindings.Add(_ctrlPlayer.GetPlayerBinding(controlPropName, "Level"));
            lbCurrentGold.DataBindings.Add(_ctrlPlayer.GetPlayerBinding(controlPropName, "Gold"));
            lbCurrentXp.DataBindings.Add(_ctrlPlayer.GetPlayerBinding(controlPropName, "ExperiencePoints"));
            lbTitle.DataBindings.Add(_ctrlPlayer.GetPlayerBinding(controlPropName, "PlayerCurrentTile.Hint"));
           
            #endregion

            #region TextBox

            ttbPlayerStr.DataBindings.Add(_ctrlPlayer.GetPlayerStatusBinding(controlPropName, "Strength"));
            ttbPlayerDef.DataBindings.Add(_ctrlPlayer.GetPlayerStatusBinding(controlPropName, "Defense"));
            ttbPlayerSpd.DataBindings.Add(_ctrlPlayer.GetPlayerStatusBinding(controlPropName, "Speed"));
            ttbPlayerDex.DataBindings.Add(_ctrlPlayer.GetPlayerStatusBinding(controlPropName, "Dextery"));
            ttbPlayerLuk.DataBindings.Add(_ctrlPlayer.GetPlayerStatusBinding(controlPropName, "Luck"));

            #endregion

            #region ProgressBar
            controlPropName = "Maximum";

            prgbHitPoints.DataBindings.Add(_ctrlPlayer.GetPlayerBinding(controlPropName, "Maxhitpoints"));

            controlPropName = "Value";

            prgbHitPoints.DataBindings.Add(_ctrlPlayer.GetPlayerBinding(controlPropName, "Hitpoints"));

            #endregion

            controlPropName = "BackColor";
            pnTitle.DataBindings.Add(_ctrlPlayer.GetPlayerBinding(controlPropName, "PlayerCurrentTile.TileColor"));


            _ctrlLog.SetOnChangedEvent(OnLogTrackChange);

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

        private void TsBtnMap_Click(object sender, EventArgs e)
        {
            _ctrlMap.ShowMap(Width + Left, Top);
        }

        private void TsBtnBackpack_Click(object sender, EventArgs e)
        {
            _ctrlPlayer.ShowBackpack(Left,Top);
        }

        private void FrmInitial_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.Control && e.KeyCode == Keys.M)      
            {
                tsBtnMap.PerformClick();
                e.SuppressKeyPress = true;
            }
            if (e.Control && e.KeyCode == Keys.B)
            {
                tsBtnBackpack.PerformClick();
                e.SuppressKeyPress = true;
            }
        }

        private void ToolStripButton1_Click(object sender, EventArgs e)
        {
            FrmCamera c = new FrmCamera();
            c.Show();
        }
    }
}
