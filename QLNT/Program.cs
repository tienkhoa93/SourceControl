using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLNT
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
            Form.Systems.RunApplication run = new Form.Systems.RunApplication();

            // chay cac form test o day
            // Application.Run(new Form.Systems.RunApplication());

        }
    }
}
