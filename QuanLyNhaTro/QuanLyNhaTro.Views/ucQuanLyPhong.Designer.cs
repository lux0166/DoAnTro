namespace QuanLyNhaTro.Views
{
    partial class ucQuanLyPhong
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
            this.gridRooms = new DevExpress.XtraGrid.GridControl();
            this.gridViewRooms = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.txtSearch = new DevExpress.XtraEditors.TextEdit();
            this.lueBuilding = new DevExpress.XtraEditors.LookUpEdit();
            this.lueRoomType = new DevExpress.XtraEditors.LookUpEdit();
            this.cboStatus = new DevExpress.XtraEditors.ComboBoxEdit();
            this.btnSearch = new DevExpress.XtraEditors.SimpleButton();
            this.btnAdd = new DevExpress.XtraEditors.SimpleButton();
            this.btnEdit = new DevExpress.XtraEditors.SimpleButton();
            this.btnDelete = new DevExpress.XtraEditors.SimpleButton();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItemGrid = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlGroupFilters = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItemSearch = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItemBuilding = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItemRoomType = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItemStatus = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItemSearchBtn = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlGroupActions = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItemAdd = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItemEdit = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItemDelete = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem2 = new DevExpress.XtraLayout.EmptySpaceItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridRooms)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewRooms)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSearch.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueBuilding.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueRoomType.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboStatus.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItemGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroupFilters)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItemSearch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItemBuilding)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItemRoomType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItemStatus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItemSearchBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroupActions)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItemAdd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItemEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItemDelete)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).BeginInit();
            this.SuspendLayout();
            //
            // layoutControl1
            //
            this.layoutControl1.Controls.Add(this.btnDelete);
            this.layoutControl1.Controls.Add(this.btnEdit);
            this.layoutControl1.Controls.Add(this.btnAdd);
            this.layoutControl1.Controls.Add(this.btnSearch);
            this.layoutControl1.Controls.Add(this.cboStatus);
            this.layoutControl1.Controls.Add(this.lueRoomType);
            this.layoutControl1.Controls.Add(this.lueBuilding);
            this.layoutControl1.Controls.Add(this.txtSearch);
            this.layoutControl1.Controls.Add(this.gridRooms);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(1000, 600);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            //
            // gridRooms
            //
            this.gridRooms.Location = new System.Drawing.Point(12, 160);
            this.gridRooms.MainView = this.gridViewRooms;
            this.gridRooms.Name = "gridRooms";
            this.gridRooms.Size = new System.Drawing.Size(976, 428);
            this.gridRooms.TabIndex = 9;
            this.gridRooms.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewRooms});
            //
            // gridViewRooms
            //
            this.gridViewRooms.GridControl = this.gridRooms;
            this.gridViewRooms.Name = "gridViewRooms";
            //
            // txtSearch
            //
            this.txtSearch.Location = new System.Drawing.Point(99, 107);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(207, 22);
            this.txtSearch.StyleController = this.layoutControl1;
            this.txtSearch.TabIndex = 5;
            //
            // lueBuilding
            //
            this.lueBuilding.Location = new System.Drawing.Point(385, 107);
            this.lueBuilding.Name = "lueBuilding";
            this.lueBuilding.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lueBuilding.Properties.NullText = "";
            this.lueBuilding.Size = new System.Drawing.Size(146, 22);
            this.lueBuilding.StyleController = this.layoutControl1;
            this.lueBuilding.TabIndex = 6;
            //
            // lueRoomType
            //
            this.lueRoomType.Location = new System.Drawing.Point(610, 107);
            this.lueRoomType.Name = "lueRoomType";
            this.lueRoomType.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lueRoomType.Properties.NullText = "";
            this.lueRoomType.Size = new System.Drawing.Size(146, 22);
            this.lueRoomType.StyleController = this.layoutControl1;
            this.lueRoomType.TabIndex = 7;
            //
            // cboStatus
            //
            this.cboStatus.Location = new System.Drawing.Point(835, 107);
            this.cboStatus.Name = "cboStatus";
            this.cboStatus.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboStatus.Properties.Items.AddRange(new object[] {
            "Tất cả",
            "Trống",
            "Đang thuê",
            "Bảo trì"});
            this.cboStatus.Size = new System.Drawing.Size(141, 22);
            this.cboStatus.StyleController = this.layoutControl1;
            this.cboStatus.TabIndex = 8;
            //
            // btnSearch
            //
            this.btnSearch.Location = new System.Drawing.Point(310, 107);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(71, 22);
            this.btnSearch.StyleController = this.layoutControl1;
            this.btnSearch.TabIndex = 10;
            this.btnSearch.Text = "Tìm";
            //
            // btnAdd
            //
            this.btnAdd.Location = new System.Drawing.Point(24, 45);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(96, 27);
            this.btnAdd.StyleController = this.layoutControl1;
            this.btnAdd.TabIndex = 11;
            this.btnAdd.Text = "Thêm mới";
            //
            // btnEdit
            //
            this.btnEdit.Location = new System.Drawing.Point(124, 45);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(96, 27);
            this.btnEdit.StyleController = this.layoutControl1;
            this.btnEdit.TabIndex = 12;
            this.btnEdit.Text = "Sửa";
            //
            // btnDelete
            //
            this.btnDelete.Location = new System.Drawing.Point(224, 45);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(96, 27);
            this.btnDelete.StyleController = this.layoutControl1;
            this.btnDelete.TabIndex = 13;
            this.btnDelete.Text = "Xóa";
            //
            // Root
            //
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItemGrid,
            this.layoutControlGroupFilters,
            this.layoutControlGroupActions});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(1000, 600);
            this.Root.TextVisible = false;
            //
            // layoutControlItemGrid
            //
            this.layoutControlItemGrid.Control = this.gridRooms;
            this.layoutControlItemGrid.Location = new System.Drawing.Point(0, 148);
            this.layoutControlItemGrid.Name = "layoutControlItemGrid";
            this.layoutControlItemGrid.Size = new System.Drawing.Size(980, 432);
            this.layoutControlItemGrid.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItemGrid.TextVisible = false;
            //
            // layoutControlGroupFilters
            //
            this.layoutControlGroupFilters.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItemSearch,
            this.layoutControlItemBuilding,
            this.layoutControlItemRoomType,
            this.layoutControlItemStatus,
            this.layoutControlItemSearchBtn,
            this.emptySpaceItem1});
            this.layoutControlGroupFilters.Location = new System.Drawing.Point(0, 77);
            this.layoutControlGroupFilters.Name = "layoutControlGroupFilters";
            this.layoutControlGroupFilters.Size = new System.Drawing.Size(980, 71);
            this.layoutControlGroupFilters.Text = "Tìm kiếm & Lọc";
            //
            // layoutControlItemSearch
            //
            this.layoutControlItemSearch.Control = this.txtSearch;
            this.layoutControlItemSearch.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItemSearch.Name = "layoutControlItemSearch";
            this.layoutControlItemSearch.Size = new System.Drawing.Size(286, 26);
            this.layoutControlItemSearch.Text = "Tìm kiếm";
            this.layoutControlItemSearch.TextSize = new System.Drawing.Size(72, 16);
            //
            // layoutControlItemBuilding
            //
            this.layoutControlItemBuilding.Control = this.lueBuilding;
            this.layoutControlItemBuilding.Location = new System.Drawing.Point(286, 0);
            this.layoutControlItemBuilding.Name = "layoutControlItemBuilding";
            this.layoutControlItemBuilding.Size = new System.Drawing.Size(225, 26);
            this.layoutControlItemBuilding.Text = "Khu nhà";
            this.layoutControlItemBuilding.TextSize = new System.Drawing.Size(72, 16);
            //
            // layoutControlItemRoomType
            //
            this.layoutControlItemRoomType.Control = this.lueRoomType;
            this.layoutControlItemRoomType.Location = new System.Drawing.Point(511, 0);
            this.layoutControlItemRoomType.Name = "layoutControlItemRoomType";
            this.layoutControlItemRoomType.Size = new System.Drawing.Size(225, 26);
            this.layoutControlItemRoomType.Text = "Loại phòng";
            this.layoutControlItemRoomType.TextSize = new System.Drawing.Size(72, 16);
            //
            // layoutControlItemStatus
            //
            this.layoutControlItemStatus.Control = this.cboStatus;
            this.layoutControlItemStatus.Location = new System.Drawing.Point(736, 0);
            this.layoutControlItemStatus.Name = "layoutControlItemStatus";
            this.layoutControlItemStatus.Size = new System.Drawing.Size(220, 26);
            this.layoutControlItemStatus.Text = "Trạng thái";
            this.layoutControlItemStatus.TextSize = new System.Drawing.Size(72, 16);
            //
            // layoutControlItemSearchBtn
            //
            this.layoutControlItemSearchBtn.Control = this.btnSearch;
            this.layoutControlItemSearchBtn.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItemSearchBtn.Name = "layoutControlItemSearchBtn";
            this.layoutControlItemSearchBtn.Size = new System.Drawing.Size(75, 26);
            this.layoutControlItemSearchBtn.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItemSearchBtn.TextVisible = false;
            //
            // emptySpaceItem1
            //
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(75, 0);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(10, 26);
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            //
            // layoutControlGroupActions
            //
            this.layoutControlGroupActions.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItemAdd,
            this.layoutControlItemEdit,
            this.layoutControlItemDelete,
            this.emptySpaceItem2});
            this.layoutControlGroupActions.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroupActions.Name = "layoutControlGroupActions";
            this.layoutControlGroupActions.Size = new System.Drawing.Size(980, 77);
            this.layoutControlGroupActions.Text = "Chức năng";
            //
            // layoutControlItemAdd
            //
            this.layoutControlItemAdd.Control = this.btnAdd;
            this.layoutControlItemAdd.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItemAdd.MaxSize = new System.Drawing.Size(100, 31);
            this.layoutControlItemAdd.MinSize = new System.Drawing.Size(100, 31);
            this.layoutControlItemAdd.Name = "layoutControlItemAdd";
            this.layoutControlItemAdd.Size = new System.Drawing.Size(100, 32);
            this.layoutControlItemAdd.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItemAdd.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItemAdd.TextVisible = false;
            //
            // layoutControlItemEdit
            //
            this.layoutControlItemEdit.Control = this.btnEdit;
            this.layoutControlItemEdit.Location = new System.Drawing.Point(100, 0);
            this.layoutControlItemEdit.MaxSize = new System.Drawing.Size(100, 31);
            this.layoutControlItemEdit.MinSize = new System.Drawing.Size(100, 31);
            this.layoutControlItemEdit.Name = "layoutControlItemEdit";
            this.layoutControlItemEdit.Size = new System.Drawing.Size(100, 32);
            this.layoutControlItemEdit.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItemEdit.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItemEdit.TextVisible = false;
            //
            // layoutControlItemDelete
            //
            this.layoutControlItemDelete.Control = this.btnDelete;
            this.layoutControlItemDelete.Location = new System.Drawing.Point(200, 0);
            this.layoutControlItemDelete.MaxSize = new System.Drawing.Size(100, 31);
            this.layoutControlItemDelete.MinSize = new System.Drawing.Size(100, 31);
            this.layoutControlItemDelete.Name = "layoutControlItemDelete";
            this.layoutControlItemDelete.Size = new System.Drawing.Size(100, 32);
            this.layoutControlItemDelete.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItemDelete.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItemDelete.TextVisible = false;
            //
            // emptySpaceItem2
            //
            this.emptySpaceItem2.AllowHotTrack = false;
            this.emptySpaceItem2.Location = new System.Drawing.Point(300, 0);
            this.emptySpaceItem2.Name = "emptySpaceItem2";
            this.emptySpaceItem2.Size = new System.Drawing.Size(656, 32);
            this.emptySpaceItem2.TextSize = new System.Drawing.Size(0, 0);
            //
            // ucQuanLyPhong
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.layoutControl1);
            this.Name = "ucQuanLyPhong";
            this.Size = new System.Drawing.Size(1000, 600);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridRooms)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewRooms)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSearch.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueBuilding.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueRoomType.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboStatus.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItemGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroupFilters)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItemSearch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItemBuilding)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItemRoomType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItemStatus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItemSearchBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroupActions)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItemAdd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItemEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItemDelete)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).EndInit();
            this.ResumeLayout(false);
        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraGrid.GridControl gridRooms;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewRooms;
        private DevExpress.XtraEditors.TextEdit txtSearch;
        private DevExpress.XtraEditors.LookUpEdit lueBuilding;
        private DevExpress.XtraEditors.LookUpEdit lueRoomType;
        private DevExpress.XtraEditors.ComboBoxEdit cboStatus;
        private DevExpress.XtraEditors.SimpleButton btnSearch;
        private DevExpress.XtraEditors.SimpleButton btnAdd;
        private DevExpress.XtraEditors.SimpleButton btnEdit;
        private DevExpress.XtraEditors.SimpleButton btnDelete;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItemGrid;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroupFilters;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItemSearch;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItemBuilding;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItemRoomType;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItemStatus;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItemSearchBtn;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroupActions;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItemAdd;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItemEdit;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItemDelete;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem2;
    }
}
