namespace QuanLyThuVien
{
    partial class frmQuanLyNhaCungCap
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.txtLamMoi = new DevExpress.XtraEditors.SimpleButton();
            this.btnXoa = new DevExpress.XtraEditors.SimpleButton();
            this.btnSua = new DevExpress.XtraEditors.SimpleButton();
            this.btnThem = new DevExpress.XtraEditors.SimpleButton();
            this.txtMaNhaCungcap = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtTenNhaCungCap = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControl2 = new DevExpress.XtraLayout.LayoutControl();
            this.gcQuanLyNhaCungCap = new DevExpress.XtraGrid.GridControl();
            this.gvQuanLyNhaCungCap = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.id_bookprovider = new DevExpress.XtraGrid.Columns.GridColumn();
            this.providername = new DevExpress.XtraGrid.Columns.GridColumn();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaNhaCungcap.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenNhaCungCap.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl2)).BeginInit();
            this.layoutControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcQuanLyNhaCungCap)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvQuanLyNhaCungCap)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.txtLamMoi);
            this.groupControl1.Controls.Add(this.btnXoa);
            this.groupControl1.Controls.Add(this.btnSua);
            this.groupControl1.Controls.Add(this.btnThem);
            this.groupControl1.Controls.Add(this.txtMaNhaCungcap);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.txtTenNhaCungCap);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Location = new System.Drawing.Point(12, 12);
            this.groupControl1.Margin = new System.Windows.Forms.Padding(4);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(1402, 176);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "Thông tin nhà cung cấp";
            this.groupControl1.Paint += new System.Windows.Forms.PaintEventHandler(this.groupControl1_Paint);
            // 
            // txtLamMoi
            // 
            this.txtLamMoi.Location = new System.Drawing.Point(658, 128);
            this.txtLamMoi.Margin = new System.Windows.Forms.Padding(4);
            this.txtLamMoi.Name = "txtLamMoi";
            this.txtLamMoi.Size = new System.Drawing.Size(121, 36);
            this.txtLamMoi.TabIndex = 4;
            this.txtLamMoi.Text = "Làm mới";
            this.txtLamMoi.Click += new System.EventHandler(this.txtLamMoi_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(494, 128);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(4);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(121, 36);
            this.btnXoa.TabIndex = 3;
            this.btnXoa.Text = "Xoá";
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(329, 128);
            this.btnSua.Margin = new System.Windows.Forms.Padding(4);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(121, 36);
            this.btnSua.TabIndex = 2;
            this.btnSua.Text = "Sửa";
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(165, 128);
            this.btnThem.Margin = new System.Windows.Forms.Padding(4);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(121, 36);
            this.btnThem.TabIndex = 1;
            this.btnThem.Text = "Thêm";
            this.btnThem.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // txtMaNhaCungcap
            // 
            this.txtMaNhaCungcap.Enabled = false;
            this.txtMaNhaCungcap.Location = new System.Drawing.Point(163, 44);
            this.txtMaNhaCungcap.Margin = new System.Windows.Forms.Padding(4);
            this.txtMaNhaCungcap.Name = "txtMaNhaCungcap";
            this.txtMaNhaCungcap.Properties.Appearance.BackColor = System.Drawing.SystemColors.Info;
            this.txtMaNhaCungcap.Properties.Appearance.Options.UseBackColor = true;
            this.txtMaNhaCungcap.Size = new System.Drawing.Size(617, 26);
            this.txtMaNhaCungcap.TabIndex = 0;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(6, 48);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(126, 20);
            this.labelControl2.TabIndex = 0;
            this.labelControl2.Text = "Mã nhà cung cấp:";
            this.labelControl2.Click += new System.EventHandler(this.labelControl1_Click);
            // 
            // txtTenNhaCungCap
            // 
            this.txtTenNhaCungCap.Location = new System.Drawing.Point(165, 89);
            this.txtTenNhaCungCap.Margin = new System.Windows.Forms.Padding(4);
            this.txtTenNhaCungCap.Name = "txtTenNhaCungCap";
            this.txtTenNhaCungCap.Size = new System.Drawing.Size(617, 26);
            this.txtTenNhaCungCap.TabIndex = 0;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(8, 92);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(131, 20);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Tên nhà cung cấp:";
            this.labelControl1.Click += new System.EventHandler(this.labelControl1_Click);
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.groupControl1);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(1426, 200);
            this.layoutControl1.TabIndex = 1;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(1426, 200);
            this.Root.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.groupControl1;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(1406, 180);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // layoutControl2
            // 
            this.layoutControl2.Controls.Add(this.gcQuanLyNhaCungCap);
            this.layoutControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl2.Location = new System.Drawing.Point(0, 200);
            this.layoutControl2.Margin = new System.Windows.Forms.Padding(4);
            this.layoutControl2.Name = "layoutControl2";
            this.layoutControl2.Root = this.layoutControlGroup1;
            this.layoutControl2.Size = new System.Drawing.Size(1426, 505);
            this.layoutControl2.TabIndex = 2;
            this.layoutControl2.Text = "layoutControl2";
            // 
            // gcQuanLyNhaCungCap
            // 
            this.gcQuanLyNhaCungCap.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(5);
            this.gcQuanLyNhaCungCap.Location = new System.Drawing.Point(12, 12);
            this.gcQuanLyNhaCungCap.MainView = this.gvQuanLyNhaCungCap;
            this.gcQuanLyNhaCungCap.Margin = new System.Windows.Forms.Padding(4);
            this.gcQuanLyNhaCungCap.Name = "gcQuanLyNhaCungCap";
            this.gcQuanLyNhaCungCap.Size = new System.Drawing.Size(1402, 481);
            this.gcQuanLyNhaCungCap.TabIndex = 0;
            this.gcQuanLyNhaCungCap.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvQuanLyNhaCungCap});
            this.gcQuanLyNhaCungCap.Click += new System.EventHandler(this.gcQuanLyNhaCungCap_Click);
            this.gcQuanLyNhaCungCap.MouseClick += new System.Windows.Forms.MouseEventHandler(this.gcQuanLyNhaCungCap_MouseClick);
            this.gcQuanLyNhaCungCap.MouseCaptureChanged += new System.EventHandler(this.gcQuanLyNhaCungCap_MouseCaptureChanged);
            // 
            // gvQuanLyNhaCungCap
            // 
            this.gvQuanLyNhaCungCap.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.id_bookprovider,
            this.providername});
            this.gvQuanLyNhaCungCap.DetailHeight = 437;
            this.gvQuanLyNhaCungCap.GridControl = this.gcQuanLyNhaCungCap;
            this.gvQuanLyNhaCungCap.Name = "gvQuanLyNhaCungCap";
            this.gvQuanLyNhaCungCap.OptionsBehavior.Editable = false;
            this.gvQuanLyNhaCungCap.OptionsFind.AlwaysVisible = true;
            this.gvQuanLyNhaCungCap.OptionsFind.FindDelay = 100;
            this.gvQuanLyNhaCungCap.OptionsFind.FindMode = DevExpress.XtraEditors.FindMode.Always;
            this.gvQuanLyNhaCungCap.OptionsFind.FindNullPrompt = "Tìm kiếm...";
            this.gvQuanLyNhaCungCap.OptionsFind.ShowClearButton = false;
            this.gvQuanLyNhaCungCap.OptionsFind.ShowCloseButton = false;
            this.gvQuanLyNhaCungCap.OptionsFind.ShowFindButton = false;
            this.gvQuanLyNhaCungCap.OptionsFind.ShowSearchNavButtons = false;
            this.gvQuanLyNhaCungCap.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gvQuanLyNhaCungCap.OptionsView.ShowGroupPanel = false;
            // 
            // id_bookprovider
            // 
            this.id_bookprovider.Caption = "Mã nhà cung cấp";
            this.id_bookprovider.FieldName = "id_bookprovider";
            this.id_bookprovider.MaxWidth = 257;
            this.id_bookprovider.MinWidth = 32;
            this.id_bookprovider.Name = "id_bookprovider";
            this.id_bookprovider.Visible = true;
            this.id_bookprovider.VisibleIndex = 0;
            this.id_bookprovider.Width = 121;
            // 
            // providername
            // 
            this.providername.Caption = "Tên nhà cung cấp";
            this.providername.FieldName = "providername";
            this.providername.MinWidth = 32;
            this.providername.Name = "providername";
            this.providername.Visible = true;
            this.providername.VisibleIndex = 1;
            this.providername.Width = 121;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem2});
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(1426, 505);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.gcQuanLyNhaCungCap;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(1406, 485);
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextVisible = false;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Mã nhà cung cấp";
            this.gridColumn1.FieldName = "id_NhaCungCap";
            this.gridColumn1.MaxWidth = 257;
            this.gridColumn1.MinWidth = 32;
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            this.gridColumn1.Width = 121;
            // 
            // frmQuanLyNhaCungCap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1426, 705);
            this.Controls.Add(this.layoutControl2);
            this.Controls.Add(this.layoutControl1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmQuanLyNhaCungCap";
            this.Text = "Quản lý nhà cung cấp";
            this.Load += new System.EventHandler(this.frmQuanLyNhaCungCap_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaNhaCungcap.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenNhaCungCap.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl2)).EndInit();
            this.layoutControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcQuanLyNhaCungCap)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvQuanLyNhaCungCap)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.SimpleButton btnXoa;
        private DevExpress.XtraEditors.SimpleButton btnSua;
        private DevExpress.XtraEditors.SimpleButton btnThem;
        private DevExpress.XtraEditors.TextEdit txtTenNhaCungCap;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControl layoutControl2;
        private DevExpress.XtraGrid.GridControl gcQuanLyNhaCungCap;
        private DevExpress.XtraGrid.Views.Grid.GridView gvQuanLyNhaCungCap;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraGrid.Columns.GridColumn id_bookprovider;
        private DevExpress.XtraGrid.Columns.GridColumn providername;
        private DevExpress.XtraEditors.TextEdit txtMaNhaCungcap;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.SimpleButton txtLamMoi;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
    }
}