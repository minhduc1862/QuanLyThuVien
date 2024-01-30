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
    public partial class frmDauSachDuocPhucVu : DevExpress.XtraEditors.XtraForm
    {
        public frmDauSachDuocPhucVu()
        {
            InitializeComponent();
        }

        private void frmDauSachDuocPhucVu_Load(object sender, EventArgs e)
        {
            rptDauSachDuocPhucVu rpt = new rptDauSachDuocPhucVu();
            rpt.initData(DateTime.Now.Day.ToString(), DateTime.Now.Month.ToString(), DateTime.Now.Year.ToString(), frmLogin.name_user);
            documentViewer1.PrintingSystem = rpt.PrintingSystem;
            rpt.CreateDocumentAsync();
        }
    }
}