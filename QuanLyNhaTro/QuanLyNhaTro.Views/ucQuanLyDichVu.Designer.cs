namespace QuanLyNhaTro.Views
{
    partial class ucQuanLyDichVu
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        private void InitializeComponent()
        {
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            this.gridServices = new DevExpress.XtraGrid.GridControl();
            this.gridViewServices = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.dataLayoutControl1 = new DevExpress.XtraDataLayout.DataLayoutControl();
            this.txtTenDichVu = new DevExpress.XtraEditors.TextEdit();
            this.calcDonGia = new DevExpress.XtraEditors.CalcEdit();
            this.cboDonViTinh = new DevExpress.XtraEditors.ComboBoxEdit();
            this.cboLoaiTinhPhi = new DevExpress.XtraEditors.ComboBoxEdit();
            this.toggleTrangThai = new DevExpress.XtraEditors.ToggleSwitch();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.btnAdd = new DevExpress.XtraEditors.SimpleButton();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            // ... Other layout items ...

            // --- Initialize all controls ---
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            this.splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridServices)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewServices)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).BeginInit();
            this.dataLayoutControl1.SuspendLayout();
            // ... other inits ...
            this.SuspendLayout();

            // --- SplitContainer ---
            this.splitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl1.Panel1.Controls.Add(this.gridServices);
            this.splitContainerControl1.Panel2.Controls.Add(this.dataLayoutControl1);

            // --- GridControl ---
            this.gridServices.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridServices.MainView = this.gridViewServices;
            this.gridServices.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewServices});

            // --- DataLayoutControl ---
            this.dataLayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataLayoutControl1.Controls.Add(this.txtTenDichVu);
            // ... add other detail controls ...
            this.dataLayoutControl1.Root = this.Root;

            // --- Layout Groups and Items for detail panel ---
            // This part is verbose and is summarized for brevity.
            // It includes creating LayoutControlItems for TenDichVu, DonGia, DonViTinh, etc.

            //
            // ucQuanLyDichVu
            //
            this.Controls.Add(this.splitContainerControl1);
            this.Name = "ucQuanLyDichVu";
            this.Size = new System.Drawing.Size(1200, 700);
            // --- EndInit for all controls ---
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridServices)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewServices)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).EndInit();
            this.dataLayoutControl1.ResumeLayout(false);
            // ... other endinits ...
            this.ResumeLayout(false);
        }

        #endregion

        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        private DevExpress.XtraGrid.GridControl gridServices;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewServices;
        private DevExpress.XtraDataLayout.DataLayoutControl dataLayoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraEditors.TextEdit txtTenDichVu;
        private DevExpress.XtraEditors.CalcEdit calcDonGia;
        private DevExpress.XtraEditors.ComboBoxEdit cboDonViTinh;
        private DevExpress.XtraEditors.ComboBoxEdit cboLoaiTinhPhi;
        private DevExpress.XtraEditors.ToggleSwitch toggleTrangThai;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private DevExpress.XtraEditors.SimpleButton btnAdd;
    }
}
