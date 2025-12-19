namespace QuanLyNhaTro.Views
{
    partial class ucQuanLyKhachThue
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
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.gridTenants = new DevExpress.XtraGrid.GridControl();
            this.gridViewTenants = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.txtSearch = new DevExpress.XtraEditors.TextEdit();
            this.btnAdd = new DevExpress.XtraEditors.SimpleButton();
            this.btnEdit = new DevExpress.XtraEditors.SimpleButton();
            this.btnDelete = new DevExpress.XtraEditors.SimpleButton();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItemGrid = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlGroupActions = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItemAdd = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItemEdit = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItemDelete = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItemSearch = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridTenants)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewTenants)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSearch.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItemGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroupActions)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItemAdd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItemEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItemDelete)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItemSearch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            this.SuspendLayout();
            //
            // layoutControl1
            //
            this.layoutControl1.Controls.Add(this.btnDelete);
            this.layoutControl1.Controls.Add(this.btnEdit);
            this.layoutControl1.Controls.Add(this.btnAdd);
            this.layoutControl1.Controls.Add(this.txtSearch);
            this.layoutControl1.Controls.Add(this.gridTenants);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(1000, 600);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            //
            // gridTenants
            //
            this.gridTenants.Location = new System.Drawing.Point(12, 91);
            this.gridTenants.MainView = this.gridViewTenants;
            this.gridTenants.Name = "gridTenants";
            this.gridTenants.Size = new System.Drawing.Size(976, 497);
            this.gridTenants.TabIndex = 4;
            this.gridTenants.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewTenants});
            //
            // gridViewTenants
            //
            this.gridViewTenants.GridControl = this.gridTenants;
            this.gridViewTenants.Name = "gridViewTenants";
            this.gridViewTenants.OptionsBehavior.Editable = false;
            //
            // txtSearch
            //
            this.txtSearch.Location = new System.Drawing.Point(401, 45);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Properties.NullValuePrompt = "Nhập tên, CMND hoặc SĐT...";
            this.txtSearch.Size = new System.Drawing.Size(575, 22);
            this.txtSearch.StyleController = this.layoutControl1;
            this.txtSearch.TabIndex = 5;
            //
            // btnAdd
            //
            this.btnAdd.Location = new System.Drawing.Point(24, 45);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(111, 27);
            this.btnAdd.StyleController = this.layoutControl1;
            this.btnAdd.TabIndex = 6;
            this.btnAdd.Text = "Thêm khách mới";
            //
            // btnEdit
            //
            this.btnEdit.Location = new System.Drawing.Point(139, 45);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(78, 27);
            this.btnEdit.StyleController = this.layoutControl1;
            this.btnEdit.TabIndex = 7;
            this.btnEdit.Text = "Sửa";
            //
            // btnDelete
            //
            this.btnDelete.Location = new System.Drawing.Point(221, 45);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(78, 27);
            this.btnDelete.StyleController = this.layoutControl1;
            this.btnDelete.TabIndex = 8;
            this.btnDelete.Text = "Xóa";
            //
            // Root
            //
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItemGrid,
            this.layoutControlGroupActions});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(1000, 600);
            this.Root.TextVisible = false;
            //
            // layoutControlItemGrid
            //
            this.layoutControlItemGrid.Control = this.gridTenants;
            this.layoutControlItemGrid.Location = new System.Drawing.Point(0, 79);
            this.layoutControlItemGrid.Name = "layoutControlItemGrid";
            this.layoutControlItemGrid.Size = new System.Drawing.Size(980, 501);
            this.layoutControlItemGrid.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItemGrid.TextVisible = false;
            //
            // layoutControlGroupActions
            //
            this.layoutControlGroupActions.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItemAdd,
            this.layoutControlItemEdit,
            this.layoutControlItemDelete,
            this.layoutControlItemSearch,
            this.emptySpaceItem1});
            this.layoutControlGroupActions.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroupActions.Name = "layoutControlGroupActions";
            this.layoutControlGroupActions.Size = new System.Drawing.Size(980, 79);
            this.layoutControlGroupActions.Text = "Chức năng";
            //
            // layoutControlItemAdd
            //
            this.layoutControlItemAdd.Control = this.btnAdd;
            this.layoutControlItemAdd.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItemAdd.MaxSize = new System.Drawing.Size(115, 31);
            this.layoutControlItemAdd.MinSize = new System.Drawing.Size(115, 31);
            this.layoutControlItemAdd.Name = "layoutControlItemAdd";
            this.layoutControlItemAdd.Size = new System.Drawing.Size(115, 34);
            this.layoutControlItemAdd.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItemAdd.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItemAdd.TextVisible = false;
            //
            // layoutControlItemEdit
            //
            this.layoutControlItemEdit.Control = this.btnEdit;
            this.layoutControlItemEdit.Location = new System.Drawing.Point(115, 0);
            this.layoutControlItemEdit.MaxSize = new System.Drawing.Size(82, 31);
            this.layoutControlItemEdit.MinSize = new System.Drawing.Size(82, 31);
            this.layoutControlItemEdit.Name = "layoutControlItemEdit";
            this.layoutControlItemEdit.Size = new System.Drawing.Size(82, 34);
            this.layoutControlItemEdit.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItemEdit.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItemEdit.TextVisible = false;
            //
            // layoutControlItemDelete
            //
            this.layoutControlItemDelete.Control = this.btnDelete;
            this.layoutControlItemDelete.Location = new System.Drawing.Point(197, 0);
            this.layoutControlItemDelete.MaxSize = new System.Drawing.Size(82, 31);
            this.layoutControlItemDelete.MinSize = new System.Drawing.Size(82, 31);
            this.layoutControlItemDelete.Name = "layoutControlItemDelete";
            this.layoutControlItemDelete.Size = new System.Drawing.Size(82, 34);
            this.layoutControlItemDelete.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItemDelete.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItemDelete.TextVisible = false;
            //
            // layoutControlItemSearch
            //
            this.layoutControlItemSearch.Control = this.txtSearch;
            this.layoutControlItemSearch.Location = new System.Drawing.Point(279, 0);
            this.layoutControlItemSearch.Name = "layoutControlItemSearch";
            this.layoutControlItemSearch.Size = new System.Drawing.Size(677, 34);
            this.layoutControlItemSearch.Text = "Tìm kiếm";
            this.layoutControlItemSearch.TextSize = new System.Drawing.Size(95, 16);
            //
            // emptySpaceItem1
            //
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(279, 0);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(10, 34);
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            //
            // ucQuanLyKhachThue
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.layoutControl1);
            this.Name = "ucQuanLyKhachThue";
            this.Size = new System.Drawing.Size(1000, 600);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridTenants)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewTenants)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSearch.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItemGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroupActions)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItemAdd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItemEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItemDelete)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItemSearch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            this.ResumeLayout(false);
        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraGrid.GridControl gridTenants;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewTenants;
        private DevExpress.XtraEditors.TextEdit txtSearch;
        private DevExpress.XtraEditors.SimpleButton btnAdd;
        private DevExpress.XtraEditors.SimpleButton btnEdit;
        private DevExpress.XtraEditors.SimpleButton btnDelete;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItemGrid;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroupActions;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItemAdd;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItemEdit;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItemDelete;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItemSearch;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
    }
}
