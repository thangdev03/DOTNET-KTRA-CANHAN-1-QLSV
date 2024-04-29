using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BAIKIEMTRA_CANHAN_1
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Frm_DangNhap fLogin = new Frm_DangNhap();
            if (fLogin.ShowDialog() == DialogResult.OK)
            {
                Application.Run(new MDI());
            }
            else
            {
                Application.Exit();
            }
        }
    }
}
