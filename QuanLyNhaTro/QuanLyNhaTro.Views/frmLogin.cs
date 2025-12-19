using DevExpress.XtraEditors;
using QuanLyNhaTro.Core.Interfaces;
using QuanLyNhaTro.Presenters;
using System;
using System.Windows.Forms; // Required for DialogResult, etc.

namespace QuanLyNhaTro.Views
{
    public partial class frmLogin : XtraForm, ILoginView
    {
        private readonly LoginPresenter _presenter;

        public frmLogin()
        {
            InitializeComponent();
            _presenter = new LoginPresenter(this);
            // Assign event handler for the login button
            this.btnLogin.Click += (sender, e) => _presenter.Login();
        }

        // ILoginView Implementation
        public string TenDangNhap => txtUsername.Text;
        public string MatKhau => txtPassword.Text;

        public void ShowMessage(string message, string caption, bool isError = false)
        {
            MessageBoxIcon icon = isError ? MessageBoxIcon.Error : MessageBoxIcon.Information;
            XtraMessageBox.Show(message, caption, MessageBoxButtons.OK, icon);
        }

        public void LoginSuccess()
        {
            // This signals the Program.cs to open the main form
            this.DialogResult = DialogResult.OK;
        }

        public void CloseView()
        {
            this.Close();
        }
    }
}
