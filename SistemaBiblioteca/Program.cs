using SistemaBiblioteca.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
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

            Application.Run(new Form1());
            if(rg.DialogResult == DialogResult.OK)
            {
                rg.Dispose();
                Application.Run(new Form1());
            }
        }
        public static Form1 menu = null;
        public static Usuario usuario = null;
        public static RLogin login = null;
        public static string Hash(string input)
        {
            var hash = (new SHA1Managed()).ComputeHash(Encoding.UTF8.GetBytes(input));
            return string.Join("", hash.Select(b => b.ToString("x2")).ToArray());
        }
    }
}
