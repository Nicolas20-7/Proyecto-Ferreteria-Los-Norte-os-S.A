using System;
using System.Windows.Forms;

namespace Ferreteria_Los_Norteños_S.A
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Gestion_Proveedor());
        }
    }
}
