using ERAProject.Model.System;
using System;
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
            InitializeSystem();
            InitializeGame();
            Application.Run(new FrmInitial());
        }

        private static void InitializeSystem()
        {
            //
        }

        static void InitializeGame()
        {
            GlobalVariables.CMap = new Class.Controllers.CtrlMap();
            GlobalVariables.CLog = new Class.Controllers.CtrlLog();
            GlobalVariables.CPlayer = new Class.Controllers.CtrlPlayer();
            GlobalVariables.CMap.ContructMap(1);
            GlobalVariables.CLog.ConstructLog();
            GlobalVariables.CPlayer.ConstructPlayer(PlayerType.Load);
            
        }
    }
}
