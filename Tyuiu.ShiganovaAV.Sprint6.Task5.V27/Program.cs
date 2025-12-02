using System;
using System.Windows.Forms;

namespace Tyutu.ShiganovaAV.Sprint6.Task5.V27
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormMain());
        }
    }
}