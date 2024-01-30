namespace QuanLyThuVien
{
    partial class frmSachHienCo
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
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.gcSach = new DevExpress.XtraGrid.GridControl();
            this.gvSach = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.id_book = new DevExpress.XtraGrid.Columns.GridColumn();
            this.bookname = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.txtDeposit = new DevExpress.XtraEditors.TextEdit();
            this.label1 = new System.Windows.Forms.Label();
            this.btnLamMoi = new DevExpress.XtraEditors.SimpleButton();
            this.btnXoa = new DevExpress.XtraEditors.SimpleButton();
            this.btnSua = new DevExpress.XtraEditors.SimpleButton();
            this.btnThem = new DevExpress.XtraEditors.SimpleButton();
            this.txtSoLuong = new DevExpress.XtraEditors.TextEdit();
            this.txtTenSach = new DevExpress.XtraEditors.TextEdit();
            this.txtMaSach = new DevExpress.XtraEditors.TextEdit();
            this.lueNhaCungCap = new DevExpress.XtraEditors.LookUpEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControl2 = new DevExpress.XtraLayout.LayoutControl();
            this.groupControl3 = new DevExpress.XtraEditors.GroupControl();
            this.gcSachHienCo = new DevExpress.XtraGrid.GridControl();
            this.gvSachHienCo = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.id_provided = new DevExpress.XtraGrid.Columns.GridColumn();
            this.id_book2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.id_bookprovider = new DevExpress.XtraGrid.Columns.GridColumn();
            this.bookname2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.date = new DevExpress.XtraGrid.Columns.GridColumn();
            this.amount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.deposit = new DevExpress.XtraGrid.Columns.GridColumn();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcSach)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvSach)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtDeposit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSoLuong.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenSach.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaSach.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueNhaCungCap.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl2)).BeginInit();
            this.layoutControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).BeginInit();
            this.groupControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcSachHienCo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvSachHienCo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.groupControl2);
            this.layoutControl1.Controls.Add(this.groupControl1);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(1916, 360);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.gcSach);
            this.groupControl2.Location = new System.Drawing.Point(887, 14);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(1016, 344);
            this.groupControl2.TabIndex = 5;
            this.groupControl2.Text = "Sách";
            // 
            // gcSach
            // 
            this.gcSach.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcSach.Location = new System.Drawing.Point(2, 34);
            this.gcSach.MainView = this.gvSach;
            this.gcSach.Name = "gcSach";
            this.gcSach.Size = new System.Drawing.Size(1012, 308);
            this.gcSach.TabIndex = 0;
            this.gcSach.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvSach});
            this.gcSach.MouseCaptureChanged += new System.EventHandler(this.gcSach_MouseCaptureChanged);
            // 
            // gvSach
            // 
            this.gvSach.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.id_book,
            this.bookname});
            this.gvSach.DetailHeight = 438;
            this.gvSach.GridControl = this.gcSach;
            this.gvSach.Name = "gvSach";
            this.gvSach.OptionsBehavior.Editable = false;
            this.gvSach.OptionsFind.AlwaysVisible = true;
            this.gvSach.OptionsFind.FindDelay = 100;
            this.gvSach.OptionsFind.FindNullPrompt = "Tìm kiếm...";
            this.gvSach.OptionsFind.ShowClearButton = false;
            this.gvSach.OptionsFind.ShowCloseButton = false;
            this.gvSach.OptionsFind.ShowFindButton = false;
            this.gvSach.OptionsFind.ShowSearchNavButtons = false;
            this.gvSach.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gvSach.OptionsView.ShowGroupPanel = false;
            // 
            // id_book
            // 
            this.id_book.Caption = "Mã sách";
            this.id_book.FieldName = "id_book";
            this.id_book.MaxWidth = 192;
            this.id_book.MinWidth = 258;
            this.id_book.Name = "id_book";
            this.id_book.Visible = true;
            this.id_book.VisibleIndex = 0;
            this.id_book.Width = 258;
            // 
            // bookname
            // 
            this.bookname.Caption = "Tên sách";
            this.bookname.FieldName = "bookname";
            this.bookname.MinWidth = 33;
            this.bookname.Name = "bookname";
            this.bookname.Visible = true;
            this.bookname.VisibleIndex = 1;
            this.bookname.Width = 790;
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.txtDeposit);
            this.groupControl1.Controls.Add(this.label1);
            this.groupControl1.Controls.Add(this.btnLamMoi);
            this.groupControl1.Controls.Add(this.btnXoa);
            this.groupControl1.Controls.Add(this.btnSua);
            this.groupControl1.Controls.Add(this.btnThem);
            this.groupControl1.Controls.Add(this.txtSoLuong);
            this.groupControl1.Controls.Add(this.txtTenSach);
            this.groupControl1.Controls.Add(this.txtMaSach);
            this.groupControl1.Controls.Add(this.lueNhaCungCap);
            this.groupControl1.Controls.Add(this.labelControl4);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Location = new System.Drawing.Point(13, 14);
            this.groupControl1.MaximumSize = new System.Drawing.Size(870, 0);
            this.groupControl1.MinimumSize = new System.Drawing.Size(870, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(870, 344);
            this.groupControl1.TabIndex = 4;
            this.groupControl1.Text = "Thông tin";
            // 
            // txtDeposit
            // 
            this.txtDeposit.Location = new System.Drawing.Point(137, 281);
            this.txtDeposit.Name = "txtDeposit";
            this.txtDeposit.Properties.DisplayFormat.FormatString = "{0:N0}";
            this.txtDeposit.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtDeposit.Size = new System.Drawing.Size(541, 26);
            this.txtDeposit.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 281);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "Tiền đặt cọc:";
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.Location = new System.Drawing.Point(712, 218);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(120, 37);
            this.btnLamMoi.TabIndex = 7;
            this.btnLamMoi.Text = "Làm mới";
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(712, 160);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(120, 37);
            this.btnXoa.TabIndex = 6;
            this.btnXoa.Text = "Xoá";
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(712, 102);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(120, 37);
            this.btnSua.TabIndex = 5;
            this.btnSua.Text = "Sửa";
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(712, 44);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(120, 37);
            this.btnThem.TabIndex = 4;
            this.btnThem.Text = "Thêm";
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.Location = new System.Drawing.Point(137, 222);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(541, 26);
            this.txtSoLuong.TabIndex = 3;
            // 
            // txtTenSach
            // 
            this.txtTenSach.Enabled = false;
            this.txtTenSach.Location = new System.Drawing.Point(137, 164);
            this.txtTenSach.Name = "txtTenSach";
            this.txtTenSach.Properties.Appearance.BackColor = System.Drawing.SystemColors.Info;
            this.txtTenSach.Properties.Appearance.Options.UseBackColor = true;
            this.txtTenSach.Size = new System.Drawing.Size(541, 26);
            this.txtTenSach.TabIndex = 2;
            // 
            // txtMaSach
            // 
            this.txtMaSach.Enabled = false;
            this.txtMaSach.Location = new System.Drawing.Point(137, 108);
            this.txtMaSach.Name = "txtMaSach";
            this.txtMaSach.Properties.Appearance.BackColor = System.Drawing.SystemColors.Info;
            this.txtMaSach.Properties.Appearance.Options.UseBackColor = true;
            this.txtMaSach.Size = new System.Drawing.Size(541, 26);
            this.txtMaSach.TabIndex = 1;
            // 
            // lueNhaCungCap
            // 
            this.lueNhaCungCap.EditValue = "";
            this.lueNhaCungCap.Location = new System.Drawing.Point(137, 50);
            this.lueNhaCungCap.Name = "lueNhaCungCap";
            this.lueNhaCungCap.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lueNhaCungCap.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("id_bookprovider", "Mã nhà cung cấp", 22, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("providername", "Tên nhà cung cấp", 22, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.lueNhaCungCap.Size = new System.Drawing.Size(541, 26);
            this.lueNhaCungCap.TabIndex = 0;
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(15, 227);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(67, 20);
            this.labelControl4.TabIndex = 3;
            this.labelControl4.Text = "Số lượng:";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(15, 169);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(69, 20);
            this.labelControl3.TabIndex = 2;
            this.labelControl3.Text = "Tên sách:";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(15, 111);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(64, 20);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "Mã sách:";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(15, 52);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(102, 20);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Nhà cung cấp:";
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem2});
            this.Root.Name = "Root";
            this.Root.Padding = new DevExpress.XtraLayout.Utils.Padding(11, 11, 12, 0);
            this.Root.Size = new System.Drawing.Size(1916, 360);
            this.Root.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.groupControl1;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(874, 348);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.groupControl2;
            this.layoutControlItem2.Location = new System.Drawing.Point(874, 0);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(1020, 348);
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextVisible = false;
            // 
            // layoutControl2
            // 
            this.layoutControl2.Controls.Add(this.groupControl3);
            this.layoutControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl2.Location = new System.Drawing.Point(0, 360);
            this.layoutControl2.Name = "layoutControl2";
            this.layoutControl2.Root = this.layoutControlGroup1;
            this.layoutControl2.Size = new System.Drawing.Size(1916, 457);
            this.layoutControl2.TabIndex = 1;
            this.layoutControl2.Text = "layoutControl2";
            // 
            // groupControl3
            // 
            this.groupControl3.Controls.Add(this.gcSachHienCo);
            this.groupControl3.Location = new System.Drawing.Point(13, 13);
            this.groupControl3.Name = "groupControl3";
            this.groupControl3.Size = new System.Drawing.Size(1890, 431);
            this.groupControl3.TabIndex = 5;
            this.groupControl3.Text = "Sách có trong thư viện";
            // 
            // gcSachHienCo
            // 
            this.gcSachHienCo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcSachHienCo.Location = new System.Drawing.Point(2, 34);
            this.gcSachHienCo.MainView = this.gvSachHienCo;
            this.gcSachHienCo.Margin = new System.Windows.Forms.Padding(0);
            this.gcSachHienCo.Name = "gcSachHienCo";
            this.gcSachHienCo.Size = new System.Drawing.Size(1886, 395);
            this.gcSachHienCo.TabIndex = 0;
            this.gcSachHienCo.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvSachHienCo});
            this.gcSachHienCo.Click += new System.EventHandler(this.gcSachHienCo_Click);
            this.gcSachHienCo.MouseCaptureChanged += new System.EventHandler(this.gcSachHienCo_MouseCaptureChanged);
            // 
            // gvSachHienCo
            // 
            this.gvSachHienCo.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.id_provided,
            this.id_book2,
            this.id_bookprovider,
            this.bookname2,
            this.date,
            this.amount,
            this.deposit});
            this.gvSachHienCo.DetailHeight = 438;
            this.gvSachHienCo.GridControl = this.gcSachHienCo;
            this.gvSachHienCo.Name = "gvSachHienCo";
            this.gvSachHienCo.OptionsBehavior.Editable = false;
            this.gvSachHienCo.OptionsFind.AlwaysVisible = true;
            this.gvSachHienCo.OptionsFind.FindDelay = 100;
            this.gvSachHienCo.OptionsFind.FindNullPrompt = "Tìm kiếm...";
            this.gvSachHienCo.OptionsFind.ShowClearButton = false;
            this.gvSachHienCo.OptionsFind.ShowCloseButton = false;
            this.gvSachHienCo.OptionsFind.ShowFindButton = false;
            this.gvSachHienCo.OptionsFind.ShowSearchNavButtons = false;
            this.gvSachHienCo.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gvSachHienCo.OptionsView.ShowGroupPanel = false;
            // 
            // id_provided
            // 
            this.id_provided.Caption = "Mã cung cấp";
            this.id_provided.FieldName = "id_provided";
            this.id_provided.MaxWidth = 192;
            this.id_provided.MinWidth = 33;
            this.id_provided.Name = "id_provided";
            this.id_provided.Visible = true;
            this.id_provided.VisibleIndex = 0;
            this.id_provided.Width = 120;
            // 
            // id_book2
            // 
            this.id_book2.Caption = "Mã sách";
            this.id_book2.FieldName = "id_book";
            this.id_book2.MaxWidth = 192;
            this.id_book2.MinWidth = 33;
            this.id_book2.Name = "id_book2";
            this.id_book2.Visible = true;
            this.id_book2.VisibleIndex = 2;
            this.id_book2.Width = 120;
            // 
            // id_bookprovider
            // 
            this.id_bookprovider.Caption = "Mã nhà cung cấp";
            this.id_bookprovider.FieldName = "id_bookprovider";
            this.id_bookprovider.MaxWidth = 192;
            this.id_bookprovider.MinWidth = 33;
            this.id_bookprovider.Name = "id_bookprovider";
            this.id_bookprovider.Visible = true;
            this.id_bookprovider.VisibleIndex = 1;
            this.id_bookprovider.Width = 120;
            // 
            // bookname2
            // 
            this.bookname2.Caption = "Tên sách";
            this.bookname2.FieldName = "bookname";
            this.bookname2.MinWidth = 578;
            this.bookname2.Name = "bookname2";
            this.bookname2.Visible = true;
            this.bookname2.VisibleIndex = 3;
            this.bookname2.Width = 578;
            // 
            // date
            // 
            this.date.Caption = "Ngày nhập";
            this.date.DisplayFormat.FormatString = "dd/MM/yyyy";
            this.date.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.date.FieldName = "date";
            this.date.MaxWidth = 192;
            this.date.MinWidth = 33;
            this.date.Name = "date";
            this.date.Visible = true;
            this.date.VisibleIndex = 4;
            this.date.Width = 120;
            // 
            // amount
            // 
            this.amount.Caption = "Số lượng";
            this.amount.FieldName = "amount";
            this.amount.MaxWidth = 192;
            this.amount.MinWidth = 33;
            this.amount.Name = "amount";
            this.amount.Visible = true;
            this.amount.VisibleIndex = 5;
            this.amount.Width = 120;
            // 
            // deposit
            // 
            this.deposit.Caption = "Tiền đặt cọc";
            this.deposit.DisplayFormat.FormatString = "{0:N0}";
            this.deposit.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.deposit.FieldName = "deposit";
            this.deposit.MaxWidth = 225;
            this.deposit.MinWidth = 28;
            this.deposit.Name = "deposit";
            this.deposit.Visible = true;
            this.deposit.VisibleIndex = 6;
            this.deposit.Width = 106;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem4});
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(1916, 457);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.groupControl3;
            this.layoutControlItem4.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(1894, 435);
            this.layoutControlItem4.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem4.TextVisible = false;
            // 
            // frmSachHienCo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1916, 817);
            this.Controls.Add(this.layoutControl2);
            this.Controls.Add(this.layoutControl1);
            this.MinimumSize = new System.Drawing.Size(1500, 35);
            this.Name = "frmSachHienCo";
            this.Text = "Sách hiện có trong thư viện";
            this.Load += new System.EventHandler(this.frmSachHienCo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcSach)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvSach)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtDeposit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSoLuong.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenSach.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaSach.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueNhaCungCap.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl2)).EndInit();
            this.layoutControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).EndInit();
            this.groupControl3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcSachHienCo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvSachHienCo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraGrid.GridControl gcSach;
        private DevExpress.XtraGrid.Views.Grid.GridView gvSach;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControl layoutControl2;
        private DevExpress.XtraGrid.GridControl gcSachHienCo;
        private DevExpress.XtraGrid.Views.Grid.GridView gvSachHienCo;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txtTenSach;
        private DevExpress.XtraEditors.TextEdit txtMaSach;
        private DevExpress.XtraEditors.LookUpEdit lueNhaCungCap;
        private DevExpress.XtraEditors.TextEdit txtSoLuong;
        private DevExpress.XtraGrid.Columns.GridColumn id_book;
        private DevExpress.XtraGrid.Columns.GridColumn bookname;
        private DevExpress.XtraEditors.SimpleButton btnLamMoi;
        private DevExpress.XtraEditors.SimpleButton btnXoa;
        private DevExpress.XtraEditors.SimpleButton btnSua;
        private DevExpress.XtraEditors.SimpleButton btnThem;
        private DevExpress.XtraGrid.Columns.GridColumn id_bookprovider;
        private DevExpress.XtraGrid.Columns.GridColumn id_book2;
        private DevExpress.XtraGrid.Columns.GridColumn date;
        private DevExpress.XtraGrid.Columns.GridColumn amount;
        private DevExpress.XtraEditors.GroupControl groupControl3;
        private DevExpress.XtraGrid.Columns.GridColumn bookname2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraGrid.Columns.GridColumn id_provided;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraGrid.Columns.GridColumn deposit;
        private DevExpress.XtraEditors.TextEdit txtDeposit;
    }
}