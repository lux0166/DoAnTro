namespace QuanLyNhaTro.Views
{
    partial class frmMain
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

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.mainContainer = new DevExpress.XtraEditors.PanelControl();
            this.kpiLayout = new System.Windows.Forms.TableLayoutPanel();
            this.kpiTotalRooms = new DevExpress.XtraEditors.GroupControl();
            this.lblKpiTotalRoomsValue = new DevExpress.XtraEditors.LabelControl();
            this.lblKpiTotalRoomsTitle = new DevExpress.XtraEditors.LabelControl();
            this.kpiOccupiedRooms = new DevExpress.XtraEditors.GroupControl();
            this.lblKpiOccupiedRoomsValue = new DevExpress.XtraEditors.LabelControl();
            this.lblKpiOccupiedRoomsTitle = new DevExpress.XtraEditors.LabelControl();
            this.kpiEmptyRooms = new DevExpress.XtraEditors.GroupControl();
            this.lblKpiEmptyRoomsValue = new DevExpress.XtraEditors.LabelControl();
            this.lblKpiEmptyRoomsTitle = new DevExpress.XtraEditors.LabelControl();
            this.kpiMonthlyRevenue = new DevExpress.XtraEditors.GroupControl();
            this.lblKpiMonthlyRevenueValue = new DevExpress.XtraEditors.LabelControl();
            this.lblKpiMonthlyRevenueTitle = new DevExpress.XtraEditors.LabelControl();

            // New Controls
            this.chartRevenue = new DevExpress.XtraCharts.ChartControl();
            this.gridRecentActivity = new DevExpress.XtraGrid.GridControl();
            this.gridViewRecentActivity = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.bottomLayout = new System.Windows.Forms.TableLayoutPanel();


            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainContainer)).BeginInit();
            this.mainContainer.SuspendLayout();
            this.kpiLayout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kpiTotalRooms)).BeginInit();
            this.kpiTotalRooms.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kpiOccupiedRooms)).BeginInit();
            this.kpiOccupiedRooms.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kpiEmptyRooms)).BeginInit();
            this.kpiEmptyRooms.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kpiMonthlyRevenue)).BeginInit();
            this.kpiMonthlyRevenue.SuspendLayout();

            ((System.ComponentModel.ISupportInitialize)(this.chartRevenue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridRecentActivity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewRecentActivity)).BeginInit();
            this.bottomLayout.SuspendLayout();

            this.SuspendLayout();
            //
            // ribbon
            //
            this.ribbon.ExpandCollapseItem.Id = 0;
            this.ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] { this.ribbon.ExpandCollapseItem });
            this.ribbon.Location = new System.Drawing.Point(0, 0);
            this.ribbon.MaxItemId = 1;
            this.ribbon.Name = "ribbon";
            this.ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] { this.ribbonPage1 });
            this.ribbon.Size = new System.Drawing.Size(1200, 193);
            this.ribbon.StatusBar = this.ribbonStatusBar;
            //
            // ribbonPage1
            //
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] { this.ribbonPageGroup1 });
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "Hệ thống";
            //
            // ribbonPageGroup1
            //
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "Chức năng";
            //
            // ribbonStatusBar
            //
            this.ribbonStatusBar.Location = new System.Drawing.Point(0, 770);
            this.ribbonStatusBar.Name = "ribbonStatusBar";
            this.ribbonStatusBar.Ribbon = this.ribbon;
            this.ribbonStatusBar.Size = new System.Drawing.Size(1200, 30);
            //
            // mainContainer
            //
            this.mainContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainContainer.Location = new System.Drawing.Point(0, 193);
            this.mainContainer.Name = "mainContainer";
            this.mainContainer.Size = new System.Drawing.Size(1200, 577);
            this.mainContainer.Controls.Add(this.bottomLayout);
            this.mainContainer.Controls.Add(this.kpiLayout);
            //
            // kpiLayout
            //
            this.kpiLayout.Dock = System.Windows.Forms.DockStyle.Top;
            this.kpiLayout.Padding = new System.Windows.Forms.Padding(10);
            this.kpiLayout.ColumnCount = 4;
            this.kpiLayout.RowCount = 1;
            this.kpiLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.kpiLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.kpiLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.kpiLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.kpiLayout.Controls.Add(this.kpiTotalRooms, 0, 0);
            this.kpiLayout.Controls.Add(this.kpiOccupiedRooms, 1, 0);
            this.kpiLayout.Controls.Add(this.kpiEmptyRooms, 2, 0);
            this.kpiLayout.Controls.Add(this.kpiMonthlyRevenue, 3, 0);
            this.kpiLayout.Height = 120;
            //
            // kpiTotalRooms, Occupied, Empty, Revenue setup... (omitted for brevity, same as before)
            // ...
            //
            // bottomLayout
            //
            this.bottomLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bottomLayout.Padding = new System.Windows.Forms.Padding(10);
            this.bottomLayout.ColumnCount = 2;
            this.bottomLayout.RowCount = 1;
            this.bottomLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.bottomLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.bottomLayout.Controls.Add(this.chartRevenue, 0, 0);
            this.bottomLayout.Controls.Add(this.gridRecentActivity, 1, 0);
            //
            // chartRevenue
            //
            this.chartRevenue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chartRevenue.Name = "chartRevenue";
            //
            // gridRecentActivity
            //
            this.gridRecentActivity.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridRecentActivity.Name = "gridRecentActivity";
            this.gridRecentActivity.MainView = this.gridViewRecentActivity;
            this.gridRecentActivity.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] { this.gridViewRecentActivity });
            //
            // gridViewRecentActivity
            //
            this.gridViewRecentActivity.GridControl = this.gridRecentActivity;
            this.gridViewRecentActivity.Name = "gridViewRecentActivity";
            this.gridViewRecentActivity.OptionsView.ShowGroupPanel = false;
            //
            // frmMain
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 800);
            this.Controls.Add(this.mainContainer);
            this.Controls.Add(this.ribbonStatusBar);
            this.Controls.Add(this.ribbon);
            this.Name = "frmMain";
            this.Ribbon = this.ribbon;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.StatusBar = this.ribbonStatusBar;
            this.Text = "Quản lý Nhà trọ - Dashboard";
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainContainer)).EndInit();
            this.mainContainer.ResumeLayout(false);
            this.kpiLayout.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kpiTotalRooms)).EndInit();
            this.kpiTotalRooms.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kpiOccupiedRooms)).EndInit();
            this.kpiOccupiedRooms.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kpiEmptyRooms)).EndInit();
            this.kpiEmptyRooms.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kpiMonthlyRevenue)).EndInit();
            this.kpiMonthlyRevenue.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartRevenue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridRecentActivity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewRecentActivity)).EndInit();
            this.bottomLayout.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar;
        private DevExpress.XtraEditors.PanelControl mainContainer;
        private System.Windows.Forms.TableLayoutPanel kpiLayout;
        private DevExpress.XtraEditors.GroupControl kpiTotalRooms;
        private DevExpress.XtraEditors.LabelControl lblKpiTotalRoomsValue;
        private DevExpress.XtraEditors.LabelControl lblKpiTotalRoomsTitle;
        private DevExpress.XtraEditors.GroupControl kpiOccupiedRooms;
        private DevExpress.XtraEditors.LabelControl lblKpiOccupiedRoomsValue;
        private DevExpress.XtraEditors.LabelControl lblKpiOccupiedRoomsTitle;
        private DevExpress.XtraEditors.GroupControl kpiEmptyRooms;
        private DevExpress.XtraEditors.LabelControl lblKpiEmptyRoomsValue;
        private DevExpress.XtraEditors.LabelControl lblKpiEmptyRoomsTitle;
        private DevExpress.XtraEditors.GroupControl kpiMonthlyRevenue;
        private DevExpress.XtraEditors.LabelControl lblKpiMonthlyRevenueValue;
        private DevExpress.XtraEditors.LabelControl lblKpiMonthlyRevenueTitle;
        private System.Windows.Forms.TableLayoutPanel bottomLayout;
        private DevExpress.XtraCharts.ChartControl chartRevenue;
        private DevExpress.XtraGrid.GridControl gridRecentActivity;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewRecentActivity;
    }
}
