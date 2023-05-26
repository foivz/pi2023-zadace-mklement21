using DBLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HelpDesk__Matea_Klement
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            DB.SetConfiguration("IPS23_mklement21", "mklement21", "3EZTWDk0");
            Application.Run(new FrmPrijava());
        }
    }
}
