using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace QuanLyThuVien
{
    public partial class frmHanTheDatePicker : DevExpress.XtraEditors.XtraForm
    {
        public static string date = "";
        public frmHanTheDatePicker()
        {
            InitializeComponent();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if ((txtHanThe.EditValue == null) || (txtHanThe.EditValue.ToString().Equals("")))
            {
                XtraMessageBox.Show("Bạn chưa chọn ngày hết hạn thẻ\r\nVui lòng chọn!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (Convert.ToDateTime(txtHanThe.EditValue.ToString()).CompareTo(DateTime.Now.Date) < 0)
            {
                XtraMessageBox.Show("Ngày hết hạn thẻ không được nhỏ hơn ngày hiện tại\r\nVui lòng chọn lại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            date = txtHanThe.EditValue.ToString();
            DialogResult = DialogResult.OK;
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}