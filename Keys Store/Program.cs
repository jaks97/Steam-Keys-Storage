using System;
using System.IO;
using System.Windows.Forms;

namespace Keys_Store
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
            if (!File.Exists("Keys.db"))
                KeysDAO.create();
            Application.Run(new Form1());
        }
    }
}
