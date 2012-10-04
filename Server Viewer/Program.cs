using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Server_Viewer.Forms;

namespace Server_Viewer
{
    static class Program
    {
        /// <summary>
        /// Der Haupteinstiegspunkt für die Anwendung.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new main());
        }
    }
}
