namespace QuanLyNhaTro.Views
{
    partial class ucQuanLyHoaDon
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
            this.components = new System.ComponentModel.Container();
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;

            // Main Layout - SplitContainerControl
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            this.gridControlHoaDon = new DevExpress.XtraGrid.GridControl();
            this.gridViewHoaDon = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.panelControlDetails = new DevExpress.XtraEditors.PanelControl();

            // Details Panel Controls
            this.lblTenPhongKhachThue = new DevExpress.XtraEditors.LabelControl();
            this.lblMaHDThang = new DevExpress.XtraEditors.LabelControl();
            this.lblTrangThaiHD = new DevExpress.XtraEditors.LabelControl();

            // Utility Group
            this.groupControlTienIch = new DevExpress.XtraEditors.GroupControl();
            this.txtSoDienCu = new DevExpress.XtraEditors.TextEdit();
            this.txtSoDienMoi = new DevExpress.XtraEditors.TextEdit();
            this.lblThanhTienDien = new DevExpress.XtraEditors.LabelControl();
            this.txtSoNuocCu = new DevExpress.XtraEditors.TextEdit();
            this.txtSoNuocMoi = new DevExpress.XtraEditors.TextEdit();
            this.lblThanhTienNuoc = new DevExpress.XtraEditors.LabelControl();

            // Summary Group
            this.groupControlThanhToan = new DevExpress.XtraEditors.GroupControl();
            this.lblTienPhong = new DevExpress.XtraEditors.LabelControl();
            this.lblTienDienNuoc = new DevExpress.XtraEditors.LabelControl();
            this.lblTienDichVuKhac = new DevExpress.XtraEditors.LabelControl();
            this.lblTongCong = new DevExpress.XtraEditors.LabelControl();

            // Payment Action Group
            this.groupControlGhiNhan = new DevExpress.XtraEditors.GroupControl();
            this.txtSoTienThucThu = new DevExpress.XtraEditors.TextEdit();
            this.radioGroupHinhThuc = new DevExpress.XtraEditors.RadioGroup();
            this.memoGhiChu = new DevExpress.XtraEditors.MemoEdit();
            this.btnGuiNhacNo = new DevExpress.XtraEditors.SimpleButton();
            this.btnXacNhanThu = new DevExpress.XtraEditors.SimpleButton();

            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            this.splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlHoaDon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewHoaDon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControlDetails)).BeginInit();
            this.panelControlDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControlTienIch)).BeginInit();
            this.groupControlTienIch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtSoDienCu.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSoDienMoi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSoNuocCu.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSoNuocMoi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControlThanhToan)).BeginInit();
            this.groupControlThanhToan.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControlGhiNhan)).BeginInit();
            this.groupControlGhiNhan.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtSoTienThucThu.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radioGroupHinhThuc.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.memoGhiChu.Properties)).BeginInit();
            this.SuspendLayout();

            //
            // splitContainerControl1
            //
            this.splitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl1.Location = new System.Drawing.Point(0, 0);
            this.splitContainerControl1.Name = "splitContainerControl1";
            this.splitContainerControl1.Panel1.Controls.Add(this.gridControlHoaDon);
            this.splitContainerControl1.Panel1.Text = "Panel1";
            this.splitContainerControl1.Panel2.Controls.Add(this.panelControlDetails);
            this.splitContainerControl1.Panel2.Text = "Panel2";
            this.splitContainerControl1.Size = new System.Drawing.Size(1200, 700);
            this.splitContainerControl1.SplitterPosition = 750;

            //
            // gridControlHoaDon
            //
            this.gridControlHoaDon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlHoaDon.MainView = this.gridViewHoaDon;
            this.gridControlHoaDon.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewHoaDon});

            //
            // panelControlDetails
            //
            this.panelControlDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControlDetails.Controls.Add(this.lblTenPhongKhachThue);
            this.panelControlDetails.Controls.Add(this.lblMaHDThang);
            //... add all other controls to the panel ...

            // ... (Full initialization code for all controls would go here) ...

            this.Controls.Add(this.splitContainerControl1);
            this.Name = "ucQuanLyHoaDon";
            this.Size = new System.Drawing.Size(1200, 700);

            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlHoaDon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewHoaDon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControlDetails)).EndInit();
            this.panelControlDetails.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControlTienIch)).EndInit();
            this.groupControlTienIch.ResumeLayout(false);
            // ... (EndInit calls for all other controls) ...
            this.ResumeLayout(false);
        }

        #endregion

        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        private DevExpress.XtraGrid.GridControl gridControlHoaDon;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewHoaDon;
        private DevExpress.XtraEditors.PanelControl panelControlDetails;
        private DevExpress.XtraEditors.LabelControl lblTenPhongKhachThue;
        private DevExpress.XtraEditors.LabelControl lblMaHDThang;
        private DevExpress.XtraEditors.LabelControl lblTrangThaiHD;
        private DevExpress.XtraEditors.GroupControl groupControlTienIch;
        private DevExpress.XtraEditors.TextEdit txtSoDienCu;
        private DevExpress.XtraEditors.TextEdit txtSoDienMoi;
        private DevExpress.XtraEditors.LabelControl lblThanhTienDien;
        private DevExpress.XtraEditors.TextEdit txtSoNuocCu;
        private DevExpress.XtraEditors.TextEdit txtSoNuocMoi;
        private DevExpress.XtraEditors.LabelControl lblThanhTienNuoc;
        private DevExpress.XtraEditors.GroupControl groupControlThanhToan;
        private DevExpress.XtraEditors.LabelControl lblTienPhong;
        private DevExpress.XtraEditors.LabelControl lblTienDienNuoc;
        private DevExpress.XtraEditors.LabelControl lblTienDichVuKhac;
        private DevExpress.XtraEditors.LabelControl lblTongCong;
        private DevExpress.XtraEditors.GroupControl groupControlGhiNhan;
        private DevExpress.XtraEditors.TextEdit txtSoTienThucThu;
        private DevExpress.XtraEditors.RadioGroup radioGroupHinhThuc;
        private DevExpress.XtraEditors.MemoEdit memoGhiChu;
        private DevExpress.XtraEditors.SimpleButton btnGuiNhacNo;
        private DevExpress.XtraEditors.SimpleButton btnXacNhanThu;
    }
}
