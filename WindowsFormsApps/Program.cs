using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApps.SecondTaskGUI;

namespace WindowsFormsApps
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new FirstTask());
            //Application.Run(new SecondTaskCoordinate());
            Application.Run(new OtherTasks());
        }
    }
}
