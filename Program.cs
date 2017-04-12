﻿using System;
using System.Windows.Forms;

namespace ERAProject
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            InitializeGame();
            Application.Run(new FrmInitial());
        }

        static void InitializeGame()
        {
            Class.GlobalVariables.CMap = new Class.Controllers.CtrlMap();
            Class.GlobalVariables.CLog = new Class.Controllers.CtrlLog();
            Class.GlobalVariables.CPlayer = new Class.Controllers.CtrlPlayer();
            Class.GlobalVariables.CMap.ContructMap(1);
            Class.GlobalVariables.CLog.ConstructLog();
            Class.GlobalVariables.CPlayer.ConstructPlayer(1);
            
        }
    }
}
