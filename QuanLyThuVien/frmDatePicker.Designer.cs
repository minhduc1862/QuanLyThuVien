﻿namespace QuanLyThuVien
{
    partial class frmDatePicker
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDatePicker));
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtDate = new DevExpress.XtraEditors.DateEdit();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.txtDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDate.Properties.CalendarTimeProperties)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 8F);
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(15, 9);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(228, 19);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Vui lòng chọn ngày hẹn trả sách";
            // 
            // txtDate
            // 
            this.txtDate.EditValue = null;
            this.txtDate.Location = new System.Drawing.Point(15, 44);
            this.txtDate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtDate.Name = "txtDate";
            this.txtDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtDate.Properties.DisplayFormat.FormatString = "dd/MM/yyyy";
            this.txtDate.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.txtDate.Properties.EditFormat.FormatString = "dd/MM/yyyy";
            this.txtDate.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.txtDate.Properties.Mask.EditMask = "dd/MM/yyyy";
            this.txtDate.Size = new System.Drawing.Size(255, 26);
            this.txtDate.TabIndex = 1;
            // 
            // simpleButton1
            // 
            this.simpleButton1.Location = new System.Drawing.Point(41, 89);
            this.simpleButton1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(84, 36);
            this.simpleButton1.TabIndex = 2;
            this.simpleButton1.Text = "Ok";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // simpleButton2
            // 
            this.simpleButton2.Location = new System.Drawing.Point(161, 89);
            this.simpleButton2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(84, 36);
            this.simpleButton2.TabIndex = 3;
            this.simpleButton2.Text = "Huỷ";
            this.simpleButton2.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // frmDatePicker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(288, 138);
            this.Controls.Add(this.simpleButton2);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.txtDate);
            this.Controls.Add(this.labelControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.IconOptions.Icon = ((System.Drawing.Icon)(resources.GetObject("frmDatePicker.IconOptions.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(234, 159);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(226, 159);
            this.Name = "frmDatePicker";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chọn ngày hẹn trả";
            this.Load += new System.EventHandler(this.frmDatePicker_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDate.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.DateEdit txtDate;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
    }
}