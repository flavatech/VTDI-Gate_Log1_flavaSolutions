using System;
using System.Windows.Forms;

namespace VTDI_Gate_Log1_flavaSolutions
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
           Application.Run(new Login());
            //Application.Run(new vtdi_gateLog_flavaSolutions1());
        }
    }
}
