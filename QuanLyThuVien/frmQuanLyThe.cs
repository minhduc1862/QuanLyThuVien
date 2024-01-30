using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyThuVien
{
    public partial class frmQuanLyThe : DevExpress.XtraEditors.XtraForm
    {
        Con_CRUD con = new Con_CRUD();
        string sqlR = "select * from librarycard";
        public frmQuanLyThe()
        {
            InitializeComponent();
        }
        private void loadData()
        {
            DataTable dt = con.readData(sqlR);
            if (dt != null)
            {
                gcThe.DataSource = dt;
            }
        }

        private void frmQuanLyThe_Load(object sender, EventArgs e)
        {
            loadData();
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtMaDocGia.EditValue = null;
            txtTenDocGia.EditValue = null;
            txtNgayCap.EditValue = null;
            txtNgayHetHan.EditValue = null;
            txtTenDocGia.Focus();
        }

        private void gcThe_MouseCaptureChanged(object sender, EventArgs e)
        {
            int row_index = gvThe.FocusedRowHandle;
            string colID = "id_student";
            string colName = "fullname";
            string colNgaycap = "dateofissue";
            string colNgayhethan = "expirydate";
            if ((gvThe.GetRowCellValue(row_index, colID) != null) && (gvThe.GetRowCellValue(row_index, colName) != null) && (gvThe.GetRowCellValue(row_index, colNgaycap) != null) && (gvThe.GetRowCellValue(row_index, colNgayhethan) != null))
            {
                txtMaDocGia.EditValue = gvThe.GetRowCellValue(row_index, colID).ToString();
                txtTenDocGia.EditValue = gvThe.GetRowCellValue(row_index, colName).ToString();
                txtNgayCap.EditValue = Convert.ToDateTime(gvThe.GetRowCellValue(row_index, colNgaycap).ToString()).ToString("dd/MM/yyyy");
                txtNgayHetHan.EditValue = Convert.ToDateTime(gvThe.GetRowCellValue(row_index, colNgayhethan).ToString()).ToString("dd/MM/yyyy");
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (txtMaDocGia.EditValue == null)
            {
                XtraMessageBox.Show("Bạn chưa chọn độc giả để sửa\r\nVui lòng chọn!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if ((txtTenDocGia.EditValue == null) || (txtTenDocGia.EditValue.ToString().Equals("")))
            {
                XtraMessageBox.Show("Tên độc giả không được phép để trống\r\nVui lòng nhập!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtTenDocGia.Focus();
                return;
            }
            if ((txtNgayCap.EditValue == null) || (txtNgayCap.EditValue.ToString().Equals("")))
            {
                XtraMessageBox.Show("Ngày sinh không được phép để trống\r\nVui lòng nhập!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtNgayCap.Focus();
                return;
            }
            if ((txtNgayHetHan.EditValue == null) || (txtNgayHetHan.EditValue.ToString().Equals("")))
            {
                XtraMessageBox.Show("Địa chỉ không được phép để trống\r\nVui lòng nhập!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtNgayHetHan.Focus();
                return;
            }
            if (XtraMessageBox.Show("Bạn có chắc chắn muốn sửa độc giả đang chọn?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string sqlU = "update librarycard set fullname = N'" + txtTenDocGia.EditValue.ToString() + "', dateofissue = '" + Convert.ToDateTime(txtNgayCap.EditValue.ToString()).ToString("yyyy-MM-dd") + "', expirydate = '" + Convert.ToDateTime(txtNgayHetHan.EditValue.ToString()).ToString("yyyy-MM-dd") + "' where id_student = '" + txtMaDocGia.EditValue.ToString() + "'";
                if (con.exeData(sqlU))
                {
                    loadData();
                    XtraMessageBox.Show("Sửa thông tin thẻ thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btnLamMoi.PerformClick();
                }
                else
                {
                    XtraMessageBox.Show("Sửa thông tin thẻ thất bại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    }
}
