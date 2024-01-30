
namespace QuanLyThuVien
{
    partial class frmQuanLyThe
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
            this.layoutControl2 = new DevExpress.XtraLayout.LayoutControl();
            this.gcThe = new DevExpress.XtraGrid.GridControl();
            this.gvThe = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.id_student = new DevExpress.XtraGrid.Columns.GridColumn();
            this.fullname = new DevExpress.XtraGrid.Columns.GridColumn();
            this.dateofissue = new DevExpress.XtraGrid.Columns.GridColumn();
            this.expirydate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.txtNgayHetHan = new DevExpress.XtraEditors.DateEdit();
            this.btnLamMoi = new DevExpress.XtraEditors.SimpleButton();
            this.btnSua = new DevExpress.XtraEditors.SimpleButton();
            this.txtTenDocGia = new DevExpress.XtraEditors.TextEdit();
            this.txtMaDocGia = new DevExpress.XtraEditors.TextEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtNgayCap = new DevExpress.XtraEditors.DateEdit();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.number = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl2)).BeginInit();
            this.layoutControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcThe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvThe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtNgayHetHan.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNgayHetHan.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenDocGia.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaDocGia.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNgayCap.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNgayCap.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl2
            // 
            this.layoutControl2.Controls.Add(this.gcThe);
            this.layoutControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl2.Location = new System.Drawing.Point(0, 248);
            this.layoutControl2.Name = "layoutControl2";
            this.layoutControl2.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(945, 327, 975, 600);
            this.layoutControl2.Root = this.layoutControlGroup1;
            this.layoutControl2.Size = new System.Drawing.Size(1352, 466);
            this.layoutControl2.TabIndex = 3;
            this.layoutControl2.Text = "layoutControl2";
            // 
            // gcThe
            // 
            this.gcThe.Location = new System.Drawing.Point(12, 12);
            this.gcThe.MainView = this.gvThe;
            this.gcThe.Name = "gcThe";
            this.gcThe.Size = new System.Drawing.Size(1328, 442);
            this.gcThe.TabIndex = 0;
            this.gcThe.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvThe});
            this.gcThe.MouseCaptureChanged += new System.EventHandler(this.gcThe_MouseCaptureChanged);
            // 
            // gvThe
            // 
            this.gvThe.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.id_student,
            this.fullname,
            this.dateofissue,
            this.expirydate});
            this.gvThe.DetailHeight = 438;
            this.gvThe.GridControl = this.gcThe;
            this.gvThe.Name = "gvThe";
            this.gvThe.OptionsBehavior.Editable = false;
            this.gvThe.OptionsFind.AlwaysVisible = true;
            this.gvThe.OptionsFind.FindDelay = 100;
            this.gvThe.OptionsFind.FindNullPrompt = "Tìm kiếm...";
            this.gvThe.OptionsFind.ShowClearButton = false;
            this.gvThe.OptionsFind.ShowCloseButton = false;
            this.gvThe.OptionsFind.ShowFindButton = false;
            this.gvThe.OptionsFind.ShowSearchNavButtons = false;
            this.gvThe.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gvThe.OptionsView.ShowGroupPanel = false;
            // 
            // id_student
            // 
            this.id_student.Caption = "Mã độc giả";
            this.id_student.FieldName = "id_student";
            this.id_student.MaxWidth = 258;
            this.id_student.MinWidth = 33;
            this.id_student.Name = "id_student";
            this.id_student.Visible = true;
            this.id_student.VisibleIndex = 0;
            this.id_student.Width = 220;
            // 
            // fullname
            // 
            this.fullname.Caption = "Họ tên";
            this.fullname.FieldName = "fullname";
            this.fullname.MinWidth = 258;
            this.fullname.Name = "fullname";
            this.fullname.Visible = true;
            this.fullname.VisibleIndex = 1;
            this.fullname.Width = 475;
            // 
            // dateofissue
            // 
            this.dateofissue.Caption = "Ngày cấp";
            this.dateofissue.DisplayFormat.FormatString = "dd/MM/yyyy";
            this.dateofissue.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dateofissue.FieldName = "dateofissue";
            this.dateofissue.MaxWidth = 258;
            this.dateofissue.MinWidth = 33;
            this.dateofissue.Name = "dateofissue";
            this.dateofissue.Visible = true;
            this.dateofissue.VisibleIndex = 2;
            this.dateofissue.Width = 258;
            // 
            // expirydate
            // 
            this.expirydate.Caption = "Ngày hết hạn";
            this.expirydate.DisplayFormat.FormatString = "dd/MM/yyyy";
            this.expirydate.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.expirydate.FieldName = "expirydate";
            this.expirydate.MinWidth = 258;
            this.expirydate.Name = "expirydate";
            this.expirydate.Visible = true;
            this.expirydate.VisibleIndex = 3;
            this.expirydate.Width = 339;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem2});
            this.layoutControlGroup1.Name = "Root";
            this.layoutControlGroup1.Size = new System.Drawing.Size(1352, 466);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.gcThe;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(1332, 446);
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextVisible = false;
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.groupControl1);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(945, 0, 975, 600);
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(1352, 248);
            this.layoutControl1.TabIndex = 2;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.txtNgayHetHan);
            this.groupControl1.Controls.Add(this.btnLamMoi);
            this.groupControl1.Controls.Add(this.btnSua);
            this.groupControl1.Controls.Add(this.txtTenDocGia);
            this.groupControl1.Controls.Add(this.txtMaDocGia);
            this.groupControl1.Controls.Add(this.labelControl5);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Controls.Add(this.txtNgayCap);
            this.groupControl1.Location = new System.Drawing.Point(14, 14);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(1324, 232);
            this.groupControl1.TabIndex = 4;
            this.groupControl1.Text = "Thông tin thẻ";
            // 
            // txtNgayHetHan
            // 
            this.txtNgayHetHan.EditValue = null;
            this.txtNgayHetHan.Location = new System.Drawing.Point(141, 178);
            this.txtNgayHetHan.Name = "txtNgayHetHan";
            this.txtNgayHetHan.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtNgayHetHan.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtNgayHetHan.Properties.DisplayFormat.FormatString = "dd/MM/yyyy";
            this.txtNgayHetHan.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.txtNgayHetHan.Properties.EditFormat.FormatString = "dd/MM/yyyy";
            this.txtNgayHetHan.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.txtNgayHetHan.Properties.MaskSettings.Set("mask", "dd/MM/yyyy");
            this.txtNgayHetHan.Size = new System.Drawing.Size(390, 26);
            this.txtNgayHetHan.TabIndex = 8;
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.Location = new System.Drawing.Point(558, 135);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(120, 37);
            this.btnLamMoi.TabIndex = 7;
            this.btnLamMoi.Text = "Làm mới";
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(558, 78);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(120, 37);
            this.btnSua.TabIndex = 5;
            this.btnSua.Text = "Sửa";
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // txtTenDocGia
            // 
            this.txtTenDocGia.Location = new System.Drawing.Point(141, 82);
            this.txtTenDocGia.Name = "txtTenDocGia";
            this.txtTenDocGia.Size = new System.Drawing.Size(390, 26);
            this.txtTenDocGia.TabIndex = 0;
            // 
            // txtMaDocGia
            // 
            this.txtMaDocGia.Enabled = false;
            this.txtMaDocGia.Location = new System.Drawing.Point(141, 38);
            this.txtMaDocGia.Name = "txtMaDocGia";
            this.txtMaDocGia.Properties.Appearance.BackColor = System.Drawing.SystemColors.Info;
            this.txtMaDocGia.Properties.Appearance.Options.UseBackColor = true;
            this.txtMaDocGia.Size = new System.Drawing.Size(390, 26);
            this.txtMaDocGia.TabIndex = 0;
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(10, 181);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(125, 20);
            this.labelControl5.TabIndex = 4;
            this.labelControl5.Text = "Ngày hết hạn thẻ:";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(11, 133);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(70, 20);
            this.labelControl3.TabIndex = 2;
            this.labelControl3.Text = "Ngày cấp:";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(11, 87);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(86, 20);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "Tên độc giả:";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(11, 41);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(81, 20);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Mã độc giả:";
            // 
            // txtNgayCap
            // 
            this.txtNgayCap.EditValue = null;
            this.txtNgayCap.Location = new System.Drawing.Point(141, 130);
            this.txtNgayCap.Name = "txtNgayCap";
            this.txtNgayCap.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtNgayCap.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtNgayCap.Properties.DisplayFormat.FormatString = "dd/MM/yyyy";
            this.txtNgayCap.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.txtNgayCap.Properties.EditFormat.FormatString = "dd/MM/yyyy";
            this.txtNgayCap.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.txtNgayCap.Properties.MaskSettings.Set("mask", "dd/MM/yyyy");
            this.txtNgayCap.Size = new System.Drawing.Size(390, 26);
            this.txtNgayCap.TabIndex = 1;
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1});
            this.Root.Name = "Root";
            this.Root.Padding = new DevExpress.XtraLayout.Utils.Padding(12, 12, 12, 0);
            this.Root.Size = new System.Drawing.Size(1352, 248);
            this.Root.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.groupControl1;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(1328, 236);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // number
            // 
            this.number.Caption = "Số điện thoại";
            this.number.FieldName = "number";
            this.number.MaxWidth = 258;
            this.number.MinWidth = 33;
            this.number.Name = "number";
            this.number.Visible = true;
            this.number.VisibleIndex = 4;
            this.number.Width = 258;
            // 
            // frmQuanLyThe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1352, 714);
            this.Controls.Add(this.layoutControl2);
            this.Controls.Add(this.layoutControl1);
            this.Name = "frmQuanLyThe";
            this.Text = "Quản lý thẻ";
            this.Load += new System.EventHandler(this.frmQuanLyThe_Load);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl2)).EndInit();
            this.layoutControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcThe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvThe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtNgayHetHan.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNgayHetHan.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenDocGia.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaDocGia.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNgayCap.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNgayCap.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl2;
        private DevExpress.XtraGrid.GridControl gcThe;
        private DevExpress.XtraGrid.Views.Grid.GridView gvThe;
        private DevExpress.XtraGrid.Columns.GridColumn id_student;
        private DevExpress.XtraGrid.Columns.GridColumn fullname;
        private DevExpress.XtraGrid.Columns.GridColumn dateofissue;
        private DevExpress.XtraGrid.Columns.GridColumn expirydate;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.SimpleButton btnLamMoi;
        private DevExpress.XtraEditors.SimpleButton btnSua;
        private DevExpress.XtraEditors.TextEdit txtTenDocGia;
        private DevExpress.XtraEditors.TextEdit txtMaDocGia;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.DateEdit txtNgayCap;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraGrid.Columns.GridColumn number;
        private DevExpress.XtraEditors.DateEdit txtNgayHetHan;
    }
}