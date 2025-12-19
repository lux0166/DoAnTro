namespace QuanLyNhaTro.Views
{
    partial class ucBaoCaoTaiChinh
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

            // Layout Controls
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();

            // KPI Panels
            this.panelControlTongDoanhThu = new DevExpress.XtraEditors.PanelControl();
            this.panelControlTongChiPhi = new DevExpress.XtraEditors.PanelControl();
            this.panelControlLoiNhuanRong = new DevExpress.XtraEditors.PanelControl();
            this.panelControlTyLeLapDay = new DevExpress.XtraEditors.PanelControl();

            // Charts
            this.chartControlDoanhThuChiPhi = new DevExpress.XtraCharts.ChartControl();
            this.chartControlCoCauChiPhi = new DevExpress.XtraCharts.ChartControl();

            // Grid
            this.gridControlGiaoDich = new DevExpress.XtraGrid.GridControl();
            this.gridViewGiaoDich = new DevExpress.XtraGrid.Views.Grid.GridView();

            // Filter Controls
            this.dateEditFrom = new DevExpress.XtraEditors.DateEdit();
            this.dateEditTo = new DevExpress.XtraEditors.DateEdit();
            this.btnExportExcel = new DevExpress.XtraEditors.SimpleButton();
            this.btnExportPdf = new DevExpress.XtraEditors.SimpleButton();

            // Layout Items
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            // ... other layout items

            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            // ... other initializations ...
            this.SuspendLayout();

            //
            // layoutControl1
            //
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(1000, 600);

            // ... (Full initialization code for all controls would go here, defining properties, docking, etc.) ...

            this.Controls.Add(this.layoutControl1);
            this.Name = "ucBaoCaoTaiChinh";
            this.Size = new System.Drawing.Size(1000, 600);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            // ... EndInit calls for all other controls ...
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraEditors.PanelControl panelControlTongDoanhThu;
        private DevExpress.XtraEditors.PanelControl panelControlTongChiPhi;
        private DevExpress.XtraEditors.PanelControl panelControlLoiNhuanRong;
        private DevExpress.XtraEditors.PanelControl panelControlTyLeLapDay;
        private DevExpress.XtraCharts.ChartControl chartControlDoanhThuChiPhi;
        private DevExpress.XtraCharts.ChartControl chartControlCoCauChiPhi;
        private DevExpress.XtraGrid.GridControl gridControlGiaoDich;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewGiaoDich;
        private DevExpress.XtraEditors.DateEdit dateEditFrom;
        private DevExpress.XtraEditors.DateEdit dateEditTo;
        private DevExpress.XtraEditors.SimpleButton btnExportExcel;
        private DevExpress.XtraEditors.SimpleButton btnExportPdf;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;

    }
}
