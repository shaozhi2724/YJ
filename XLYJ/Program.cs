using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace XLYJ
{
    static class Program
    {
        public static bool IsLoginIn
        {
            get;
            set;
        }
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FrmLogin());
            if (IsLoginIn)
            {
                Application.Run(new FrmMainOrder());
            }
        }
    }
}
