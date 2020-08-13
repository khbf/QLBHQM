using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
namespace GUI_QuanLy
{
    static class Main
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void MainChinh()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MHQuanLyMatHang());
        }
    }
}
