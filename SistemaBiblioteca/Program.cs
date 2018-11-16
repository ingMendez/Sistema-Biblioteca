using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace SistemaBiblioteca
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
            RLogin rg = new RLogin();

            Application.Run(rg);
            if(rg.DialogResult == DialogResult.OK)
            {
                rg.Dispose();
                Application.Run(new Form1());
            }
        }
    }
}
