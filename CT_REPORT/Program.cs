using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace CT_REPORT
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
            Application.Run(new frmCtReport("Data Source=5COSMEDA.HOMEUNIX.COM,1433;Initial Catalog=dbBeautyCommSupport;User ID=sa;Password=0211", "Data Source=5COSMEDA.HOMEUNIX.COM,1433;Initial Catalog=CMD-BX;User ID=sa;Password=0211", "263"));
        }
    }
}
