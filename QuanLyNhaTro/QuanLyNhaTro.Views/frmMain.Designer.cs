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
            this.components = new System.ComponentModel.Container();
            this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.btnQuanLyPhong = new DevExpress.XtraBars.BarButtonItem();
            this.btnDashboard = new DevExpress.XtraBars.BarButtonItem();
            this.btnQuanLyKhachThue = new DevExpress.XtraBars.BarButtonItem();
            this.btnQuanLyHopDong = new DevExpress.XtraBars.BarButtonItem(); // New Button
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.mainContainer = new DevExpress.XtraEditors.PanelControl();
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainContainer)).BeginInit();
            this.SuspendLayout();
            //
            // ribbon
            //
            this.ribbon.ExpandCollapseItem.Id = 0;
            this.ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
                this.ribbon.ExpandCollapseItem,
                this.btnQuanLyPhong,
                this.btnDashboard,
                this.btnQuanLyKhachThue,
                this.btnQuanLyHopDong // Added here
            });
            this.ribbon.Location = new System.Drawing.Point(0, 0);
            this.ribbon.MaxItemId = 5; // Updated MaxItemId
            this.ribbon.Name = "ribbon";
            this.ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbon.Size = new System.Drawing.Size(1200, 193);
            this.ribbon.StatusBar = this.ribbonStatusBar;
            //
            // btnQuanLyPhong
            //
            this.btnQuanLyPhong.Caption = "Quản lý Phòng";
            this.btnQuanLyPhong.Id = 1;
            this.btnQuanLyPhong.Name = "btnQuanLyPhong";
            //
            // btnDashboard
            //
            this.btnDashboard.Caption = "Dashboard";
            this.btnDashboard.Id = 2;
            this.btnDashboard.Name = "btnDashboard";
            //
            // btnQuanLyKhachThue
            //
            this.btnQuanLyKhachThue.Caption = "Quản lý Khách thuê";
            this.btnQuanLyKhachThue.Id = 3;
            this.btnQuanLyKhachThue.Name = "btnQuanLyKhachThue";
            //
            // btnQuanLyHopDong
            //
            this.btnQuanLyHopDong.Caption = "Quản lý Hợp đồng";
            this.btnQuanLyHopDong.Id = 4;
            this.btnQuanLyHopDong.Name = "btnQuanLyHopDong";
            //
            // ribbonPage1
            //
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "Chức năng";
            //
            // ribbonPageGroup1
            //
            this.ribbonPageGroup1.ItemLinks.Add(this.btnDashboard);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnQuanLyPhong);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnQuanLyKhachThue);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnQuanLyHopDong); // Added here
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "Quản lý";
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
            this.mainContainer.TabIndex = 2;
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
            this.Text = "Quản lý Nhà trọ";
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainContainer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar;
        private DevExpress.XtraEditors.PanelControl mainContainer;
        private DevExpress.XtraBars.BarButtonItem btnQuanLyPhong;
        private DevExpress.XtraBars.BarButtonItem btnDashboard;
        private DevExpress.XtraBars.BarButtonItem btnQuanLyKhachThue;
        private DevExpress.XtraBars.BarButtonItem btnQuanLyHopDong; // Added here
    }
}
