using System;
using System.Windows.Forms;

namespace Ferreteria_Los_Norteños_S.A
{
    internal static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Proveedor_Nuevo());
        }
    }
}
