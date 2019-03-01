using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace StayAwake
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        /// 
        //public static bool Start = false;
        public static bool MoveMouse = false;
        //public static bool StartMinimized = false;


        [STAThread]
        private static void Main(string[] args)
        {
        //    Mutex instance = new Mutex(false, "single instance: StayAwake");


        //    if (instance.WaitOne(0, false))
        //    {
        //        // Check for command-line switches.
        //        foreach (string arg in args)
        //        {
        //            if ((System.String.Compare(arg.ToUpperInvariant(), "--START", System.StringComparison.Ordinal) ==
        //                 0) ||
        //                (System.String.Compare(arg.ToUpperInvariant(), "-S", System.StringComparison.Ordinal) == 0))
        //                Start = true;

        //            if ((System.String.Compare(arg.ToUpperInvariant(), "--ENABLE", System.StringComparison.Ordinal) == 0) ||
        //                (System.String.Compare(arg.ToUpperInvariant(), "-E", System.StringComparison.Ordinal) == 0))
        //                MoveMouse = true;

        //            if (
        //                (System.String.Compare(arg.ToUpperInvariant(), "--MINIMIZED", System.StringComparison.Ordinal) ==
        //                 0) ||
        //                (System.String.Compare(arg.ToUpperInvariant(), "-M", System.StringComparison.Ordinal) == 0))
        //                StartMinimized = true;
        //        }


                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new Form1());
            }
          //  instance.Close();
      //  }

        }
}
