namespace QuanLyNhaTro.Views
{
    partial class ucQuanLyBaiGiuXe
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

            // Main Layout - SplitContainer
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();

            // Center Panel
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.gridControlPhuongTien = new DevExpress.XtraGrid.GridControl();
            this.gridViewPhuongTien = new DevExpress.XtraGrid.Views.Grid.GridView();

            // Right Details Panel
            this.panelControlDetails = new DevExpress.XtraEditors.PanelControl();
            this.picHinhAnhXe = new DevExpress.XtraEditors.PictureEdit();
            this.lblBienSoDetail = new DevExpress.XtraEditors.LabelControl();
            this.lblHieuXeDetail = new DevExpress.XtraEditors.LabelControl();
            this.lblChuXeDetail = new DevExpress.XtraEditors.LabelControl();
            this.lblPhongDetail = new DevExpress.XtraEditors.LabelControl();
            this.lblDonGiaPhi = new DevExpress.XtraEditors.LabelControl();
            this.lblTrangThaiPhiDetail = new DevExpress.XtraEditors.LabelControl();
            this.btnTraCho = new DevExpress.XtraEditors.SimpleButton();
            this.btnInTheXe = new DevExpress.XtraEditors.SimpleButton();


            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            this.splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlPhuongTien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewPhuongTien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControlDetails)).BeginInit();
            this.panelControlDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picHinhAnhXe.Properties)).BeginInit();
            this.SuspendLayout();

            //
            // splitContainerControl1
            //
            this.splitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl1.Panel1.Controls.Add(this.layoutControl1);
            this.splitContainerControl1.Panel2.Controls.Add(this.panelControlDetails);
            this.splitContainerControl1.SplitterPosition = 800;

            // ... (Full initialization of all controls: layout, grid, detail panel labels, etc.) ...

            this.Controls.Add(this.splitContainerControl1);
            this.Name = "ucQuanLyBaiGiuXe";
            this.Size = new System.Drawing.Size(1280, 720);

            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlPhuongTien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewPhuongTien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControlDetails)).EndInit();
            this.panelControlDetails.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picHinhAnhXe.Properties)).EndInit();
            this.ResumeLayout(false);
        }

        #endregion

        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraGrid.GridControl gridControlPhuongTien;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewPhuongTien;
        private DevExpress.XtraEditors.PanelControl panelControlDetails;
        private DevExpress.XtraEditors.PictureEdit picHinhAnhXe;
        private DevExpress.XtraEditors.LabelControl lblBienSoDetail;
        private DevExpress.XtraEditors.LabelControl lblHieuXeDetail;
        private DevExpress.XtraEditors.LabelControl lblChuXeDetail;
        private DevExpress.XtraEditors.LabelControl lblPhongDetail;
        private DevExpress.XtraEditors.LabelControl lblDonGiaPhi;
        private DevExpress.XtraEditors.LabelControl lblTrangThaiPhiDetail;
        private DevExpress.XtraEditors.SimpleButton btnTraCho;
        private DevExpress.XtraEditors.SimpleButton btnInTheXe;
    }
}
