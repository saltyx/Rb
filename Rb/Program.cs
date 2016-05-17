using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ChinaBlock
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            ModeSelect mainForm = new ModeSelect();
            Application.Run(mainForm);
        }
    }
}