using System;
using System.Windows.Forms;
using QuanLyNhaTro.Views;

namespace QuanLyNhaTro.Views
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // These lines require the project to have a reference to System.Windows.Forms.dll
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            frmLogin loginForm = new frmLogin();

            // Show login form as a dialog.
            // The login form will return DialogResult.OK if login is successful.
            if (loginForm.ShowDialog() == DialogResult.OK)
            {
                // If login is successful, open the main application window.
                Application.Run(new frmMain());
            }
            // If login fails or is cancelled, the application will exit automatically.
        }
    }
}
