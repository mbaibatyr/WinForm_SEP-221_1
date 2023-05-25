using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyWinForm
{
    internal static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new fmCrud());
        }
    }
}

/*
 https://github.com/mbaibatyr/WinForm_SEP-221_1.git

https://github.com/mbaibatyr/SEP_221.2_Winforms.git

\\share\Shared_Folder\Временные файлы\221-1
 
 */