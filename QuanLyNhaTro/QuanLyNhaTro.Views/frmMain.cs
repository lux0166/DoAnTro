using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraEditors;
using System;

namespace QuanLyNhaTro.Views
{
    public partial class frmMain : RibbonForm
    {
        public frmMain()
        {
            InitializeComponent();
            // Assign click events to ribbon buttons
            btnDashboard.ItemClick += (s, e) => ShowUserControl(new ucDashboard());
            btnQuanLyPhong.ItemClick += (s, e) => ShowUserControl(new ucQuanLyPhong());

            // Show Dashboard on startup
            this.Load += (s, e) => ShowUserControl(new ucDashboard());
        }

        private void ShowUserControl(XtraUserControl control)
        {
            mainContainer.Controls.Clear();
            control.Dock = System.Windows.Forms.DockStyle.Fill;
            mainContainer.Controls.Add(control);
        }
    }
}
