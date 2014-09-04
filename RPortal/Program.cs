using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace WindowsFormsApplication1
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
            //Application.Run(new auth_system.LoginScreen());
            Application.Run(new interviews.ramon());
           // Application.Run(new sql_log.sqlwriterlog());
            //Application.Run(new main());
            //Application.Run(new ast());
            //Application.Run(new mst());
        }
    }
}
