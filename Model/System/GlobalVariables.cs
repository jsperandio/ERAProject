using ERAProject.Class;
using ERAProject.Class.Controllers;
using ERAProject.Class.Maps;
using System;
using System.Collections.ObjectModel;
using System.IO;

namespace ERAProject.Model.System
{
    public static class GlobalVariables
    {
        private static string _path = Directory.GetParent((Directory.GetParent(Environment.CurrentDirectory).FullName)).FullName;


        #region Encapsulate Fields
        internal static Map Map { get; set; } = null;

        internal static CtrlMap CMap { get; set; } = null;

        internal static Player User { get; set; } = null;

        internal static CtrlPlayer CPlayer { get; set; } = null;

        public static string ProjectPath { get; set; } = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName;

        internal static CtrlLog CLog { get; set; } = null;

        internal static ObservableCollection<Log> LogTrack { get; set; } = null;

        public static string StrCon { get; set; } = "data source=" + _path + "\\Eradb.db";

        #endregion

    }
}
