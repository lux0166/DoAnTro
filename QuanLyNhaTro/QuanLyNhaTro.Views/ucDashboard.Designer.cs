namespace QuanLyNhaTro.Views
{
    partial class ucDashboard
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
            this.chartRevenue = new DevExpress.XtraCharts.ChartControl();
            this.gridRecentActivity = new DevExpress.XtraGrid.GridControl();
            this.gridViewRecentActivity = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.bottomLayout = new System.Windows.Forms.TableLayoutPanel();
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
            // kpiLayout
            //
            this.kpiLayout.ColumnCount = 4;
            this.kpiLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.kpiLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.kpiLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.kpiLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.kpiLayout.Controls.Add(this.kpiTotalRooms, 0, 0);
            this.kpiLayout.Controls.Add(this.kpiOccupiedRooms, 1, 0);
            this.kpiLayout.Controls.Add(this.kpiEmptyRooms, 2, 0);
            this.kpiLayout.Controls.Add(this.kpiMonthlyRevenue, 3, 0);
            this.kpiLayout.Dock = System.Windows.Forms.DockStyle.Top;
            this.kpiLayout.Location = new System.Drawing.Point(0, 0);
            this.kpiLayout.Name = "kpiLayout";
            this.kpiLayout.Padding = new System.Windows.Forms.Padding(10);
            this.kpiLayout.RowCount = 1;
            this.kpiLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.kpiLayout.Size = new System.Drawing.Size(1180, 120);
            this.kpiLayout.TabIndex = 0;
            //
            // kpiTotalRooms
            //
            this.kpiTotalRooms.Controls.Add(this.lblKpiTotalRoomsValue);
            this.kpiTotalRooms.Controls.Add(this.lblKpiTotalRoomsTitle);
            this.kpiTotalRooms.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kpiTotalRooms.Location = new System.Drawing.Point(13, 13);
            this.kpiTotalRooms.Name = "kpiTotalRooms";
            this.kpiTotalRooms.ShowCaption = false;
            this.kpiTotalRooms.Size = new System.Drawing.Size(284, 94);
            this.kpiTotalRooms.TabIndex = 0;
            //
            // lblKpiTotalRoomsValue
            //
            this.lblKpiTotalRoomsValue.Appearance.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.lblKpiTotalRoomsValue.Appearance.Options.UseFont = true;
            this.lblKpiTotalRoomsValue.Location = new System.Drawing.Point(20, 45);
            this.lblKpiTotalRoomsValue.Name = "lblKpiTotalRoomsValue";
            this.lblKpiTotalRoomsValue.Size = new System.Drawing.Size(28, 45);
            this.lblKpiTotalRoomsValue.TabIndex = 1;
            this.lblKpiTotalRoomsValue.Text = "0";
            //
            // lblKpiTotalRoomsTitle
            //
            this.lblKpiTotalRoomsTitle.Appearance.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblKpiTotalRoomsTitle.Appearance.ForeColor = System.Drawing.Color.Gray;
            this.lblKpiTotalRoomsTitle.Appearance.Options.UseFont = true;
            this.lblKpiTotalRoomsTitle.Appearance.Options.UseForeColor = true;
            this.lblKpiTotalRoomsTitle.Location = new System.Drawing.Point(20, 20);
            this.lblKpiTotalRoomsTitle.Name = "lblKpiTotalRoomsTitle";
            this.lblKpiTotalRoomsTitle.Size = new System.Drawing.Size(125, 23);
            this.lblKpiTotalRoomsTitle.TabIndex = 0;
            this.lblKpiTotalRoomsTitle.Text = "TỔNG SỐ PHÒNG";
            //
            // kpiOccupiedRooms
            //
            this.kpiOccupiedRooms.Controls.Add(this.lblKpiOccupiedRoomsValue);
            this.kpiOccupiedRooms.Controls.Add(this.lblKpiOccupiedRoomsTitle);
            this.kpiOccupiedRooms.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kpiOccupiedRooms.Location = new System.Drawing.Point(303, 13);
            this.kpiOccupiedRooms.Name = "kpiOccupiedRooms";
            this.kpiOccupiedRooms.ShowCaption = false;
            this.kpiOccupiedRooms.Size = new System.Drawing.Size(284, 94);
            this.kpiOccupiedRooms.TabIndex = 1;
            //
            // lblKpiOccupiedRoomsValue
            //
            this.lblKpiOccupiedRoomsValue.Appearance.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.lblKpiOccupiedRoomsValue.Appearance.Options.UseFont = true;
            this.lblKpiOccupiedRoomsValue.Location = new System.Drawing.Point(20, 45);
            this.lblKpiOccupiedRoomsValue.Name = "lblKpiOccupiedRoomsValue";
            this.lblKpiOccupiedRoomsValue.Size = new System.Drawing.Size(28, 45);
            this.lblKpiOccupiedRoomsValue.TabIndex = 1;
            this.lblKpiOccupiedRoomsValue.Text = "0";
            //
            // lblKpiOccupiedRoomsTitle
            //
            this.lblKpiOccupiedRoomsTitle.Appearance.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblKpiOccupiedRoomsTitle.Appearance.ForeColor = System.Drawing.Color.Gray;
            this.lblKpiOccupiedRoomsTitle.Appearance.Options.UseFont = true;
            this.lblKpiOccupiedRoomsTitle.Appearance.Options.UseForeColor = true;
            this.lblKpiOccupiedRoomsTitle.Location = new System.Drawing.Point(20, 20);
            this.lblKpiOccupiedRoomsTitle.Name = "lblKpiOccupiedRoomsTitle";
            this.lblKpiOccupiedRoomsTitle.Size = new System.Drawing.Size(89, 23);
            this.lblKpiOccupiedRoomsTitle.TabIndex = 0;
            this.lblKpiOccupiedRoomsTitle.Text = "ĐANG THUÊ";
            //
            // kpiEmptyRooms
            //
            this.kpiEmptyRooms.Controls.Add(this.lblKpiEmptyRoomsValue);
            this.kpiEmptyRooms.Controls.Add(this.lblKpiEmptyRoomsTitle);
            this.kpiEmptyRooms.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kpiEmptyRooms.Location = new System.Drawing.Point(593, 13);
            this.kpiEmptyRooms.Name = "kpiEmptyRooms";
            this.kpiEmptyRooms.ShowCaption = false;
            this.kpiEmptyRooms.Size = new System.Drawing.Size(284, 94);
            this.kpiEmptyRooms.TabIndex = 2;
            //
            // lblKpiEmptyRoomsValue
            //
            this.lblKpiEmptyRoomsValue.Appearance.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.lblKpiEmptyRoomsValue.Appearance.Options.UseFont = true;
            this.lblKpiEmptyRoomsValue.Location = new System.Drawing.Point(20, 45);
            this.lblKpiEmptyRoomsValue.Name = "lblKpiEmptyRoomsValue";
            this.lblKpiEmptyRoomsValue.Size = new System.Drawing.Size(28, 45);
            this.lblKpiEmptyRoomsValue.TabIndex = 1;
            this.lblKpiEmptyRoomsValue.Text = "0";
            //
            // lblKpiEmptyRoomsTitle
            //
            this.lblKpiEmptyRoomsTitle.Appearance.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblKpiEmptyRoomsTitle.Appearance.ForeColor = System.Drawing.Color.Gray;
            this.lblKpiEmptyRoomsTitle.Appearance.Options.UseFont = true;
            this.lblKpiEmptyRoomsTitle.Appearance.Options.UseForeColor = true;
            this.lblKpiEmptyRoomsTitle.Location = new System.Drawing.Point(20, 20);
            this.lblKpiEmptyRoomsTitle.Name = "lblKpiEmptyRoomsTitle";
            this.lblKpiEmptyRoomsTitle.Size = new System.Drawing.Size(111, 23);
            this.lblKpiEmptyRoomsTitle.TabIndex = 0;
            this.lblKpiEmptyRoomsTitle.Text = "PHÒNG TRỐNG";
            //
            // kpiMonthlyRevenue
            //
            this.kpiMonthlyRevenue.Controls.Add(this.lblKpiMonthlyRevenueValue);
            this.kpiMonthlyRevenue.Controls.Add(this.lblKpiMonthlyRevenueTitle);
            this.kpiMonthlyRevenue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kpiMonthlyRevenue.Location = new System.Drawing.Point(883, 13);
            this.kpiMonthlyRevenue.Name = "kpiMonthlyRevenue";
            this.kpiMonthlyRevenue.ShowCaption = false;
            this.kpiMonthlyRevenue.Size = new System.Drawing.Size(284, 94);
            this.kpiMonthlyRevenue.TabIndex = 3;
            //
            // lblKpiMonthlyRevenueValue
            //
            this.lblKpiMonthlyRevenueValue.Appearance.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.lblKpiMonthlyRevenueValue.Appearance.Options.UseFont = true;
            this.lblKpiMonthlyRevenueValue.Location = new System.Drawing.Point(20, 45);
            this.lblKpiMonthlyRevenueValue.Name = "lblKpiMonthlyRevenueValue";
            this.lblKpiMonthlyRevenueValue.Size = new System.Drawing.Size(43, 45);
            this.lblKpiMonthlyRevenueValue.TabIndex = 1;
            this.lblKpiMonthlyRevenueValue.Text = "0đ";
            //
            // lblKpiMonthlyRevenueTitle
            //
            this.lblKpiMonthlyRevenueTitle.Appearance.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblKpiMonthlyRevenueTitle.Appearance.ForeColor = System.Drawing.Color.Gray;
            this.lblKpiMonthlyRevenueTitle.Appearance.Options.UseFont = true;
            this.lblKpiMonthlyRevenueTitle.Appearance.Options.UseForeColor = true;
            this.lblKpiMonthlyRevenueTitle.Location = new System.Drawing.Point(20, 20);
            this.lblKpiMonthlyRevenueTitle.Name = "lblKpiMonthlyRevenueTitle";
            this.lblKpiMonthlyRevenueTitle.Size = new System.Drawing.Size(145, 23);
            this.lblKpiMonthlyRevenueTitle.TabIndex = 0;
            this.lblKpiMonthlyRevenueTitle.Text = "DOANH THU THÁNG";
            //
            // bottomLayout
            //
            this.bottomLayout.ColumnCount = 2;
            this.bottomLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.bottomLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.bottomLayout.Controls.Add(this.chartRevenue, 0, 0);
            this.bottomLayout.Controls.Add(this.gridRecentActivity, 1, 0);
            this.bottomLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bottomLayout.Location = new System.Drawing.Point(0, 120);
            this.bottomLayout.Name = "bottomLayout";
            this.bottomLayout.Padding = new System.Windows.Forms.Padding(10);
            this.bottomLayout.RowCount = 1;
            this.bottomLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.bottomLayout.Size = new System.Drawing.Size(1180, 437);
            this.bottomLayout.TabIndex = 1;
            //
            // chartRevenue
            //
            this.chartRevenue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chartRevenue.Location = new System.Drawing.Point(13, 13);
            this.chartRevenue.Name = "chartRevenue";
            this.chartRevenue.SeriesSerializable = new DevExpress.XtraCharts.Series[0];
            this.chartRevenue.Size = new System.Drawing.Size(690, 411);
            this.chartRevenue.TabIndex = 0;
            //
            // gridRecentActivity
            //
            this.gridRecentActivity.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridRecentActivity.Location = new System.Drawing.Point(709, 13);
            this.gridRecentActivity.MainView = this.gridViewRecentActivity;
            this.gridRecentActivity.Name = "gridRecentActivity";
            this.gridRecentActivity.Size = new System.Drawing.Size(458, 411);
            this.gridRecentActivity.TabIndex = 1;
            this.gridRecentActivity.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] { this.gridViewRecentActivity });
            //
            // gridViewRecentActivity
            //
            this.gridViewRecentActivity.GridControl = this.gridRecentActivity;
            this.gridViewRecentActivity.Name = "gridViewRecentActivity";
            this.gridViewRecentActivity.OptionsView.ShowGroupPanel = false;
            //
            // ucDashboard
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.bottomLayout);
            this.Controls.Add(this.kpiLayout);
            this.Name = "ucDashboard";
            this.Size = new System.Drawing.Size(1180, 557);
            this.kpiLayout.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kpiTotalRooms)).EndInit();
            this.kpiTotalRooms.ResumeLayout(false);
            this.kpiTotalRooms.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kpiOccupiedRooms)).EndInit();
            this.kpiOccupiedRooms.ResumeLayout(false);
            this.kpiOccupiedRooms.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kpiEmptyRooms)).EndInit();
            this.kpiEmptyRooms.ResumeLayout(false);
            this.kpiEmptyRooms.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kpiMonthlyRevenue)).EndInit();
            this.kpiMonthlyRevenue.ResumeLayout(false);
            this.kpiMonthlyRevenue.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartRevenue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridRecentActivity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewRecentActivity)).EndInit();
            this.bottomLayout.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        #endregion

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
