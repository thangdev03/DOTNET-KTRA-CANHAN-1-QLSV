using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace BAIKIEMTRA_CANHAN_1
{
    public partial class Frm_DMLop : Form
    {
        public Frm_DMLop()
        {
            InitializeComponent();
        }

        private void Frm_DMLop_Load(object sender, EventArgs e)
        {
            LAY_DULIEU();
            LAY_DULIEU_BANGKHOA();

            dtaGridLop.SelectionChanged += dtaGridLop_SelectionChanged;
        }

        ConnectDB cnn = new ConnectDB();

        public void LAY_DULIEU()
        {
            DataTable dta = new DataTable();
            dta = cnn.LayBang("Select * From DMLOP");
            dtaGridLop.DataSource = dta;
            HIENTHIDULIEU();
        }

        public void LAY_DULIEU_BANGKHOA()
        {
            DataTable dta = cnn.LayBang("Select MAKHOA, TENKHOA From KHOAVIEN");
            cboMaKhoa.DataSource = dta;
            cboMaKhoa.DisplayMember = "MAKHOA";
            cboMaKhoa.ValueMember = "MAKHOA";
        }

        private void dtaGridLop_SelectionChanged(object sender, EventArgs e)
        {
            HIENTHIDULIEU();
        }

        public void HIENTHIDULIEU()
        {
            txtMaLop.DataBindings.Clear();
            txtMaLop.DataBindings.Add("Text", dtaGridLop.DataSource, "MALOP");

            txtTenLop.DataBindings.Clear();
            txtTenLop.DataBindings.Add("Text", dtaGridLop.DataSource, "TENLOP");

            cboMaKhoa.DataBindings.Clear();
            cboMaKhoa.DataBindings.Add("Text", dtaGridLop.DataSource, "MAKHOA");

            txtCVHT.DataBindings.Clear();
            txtCVHT.DataBindings.Add("Text", dtaGridLop.DataSource, "CVHT");

            txtGhiChu.DataBindings.Clear();
            txtGhiChu.DataBindings.Add("Text", dtaGridLop.DataSource, "GHICHU");
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnTao_Click(object sender, EventArgs e)
        {
            txtMaLop.Text = "";
            txtMaLop.Focus();
            txtTenLop.Text = "";
            txtCVHT.Text = "";
            txtGhiChu.Text = "";
            cboMaKhoa.SelectedIndex = 0;
        }

        private void btnChen_Click(object sender, EventArgs e)
        {
            String malop = txtMaLop.Text;
            String tenlop = txtTenLop.Text;
            String cvht = txtCVHT.Text;
            String ghichu = txtGhiChu.Text;
            String makhoa = cboMaKhoa.Text;

            String sql_chen = $"INSERT INTO DMLOP VALUES ('{malop}','{tenlop}','{makhoa}','{cvht}','{ghichu}')";
            cnn.THUCTHI_DULIEU(sql_chen);
            LAY_DULIEU();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            String malop = txtMaLop.Text;
            String tenlop = txtTenLop.Text;
            String cvht = txtCVHT.Text;
            String ghichu = txtGhiChu.Text;
            String makhoa = cboMaKhoa.Text;

            String sql_sua = $"UPDATE DMLOP SET TENLOP = '{tenlop}', MAKHOA='{makhoa}', CVHT='{cvht}', GHICHU='{ghichu}' " +
                $"WHERE MALOP = '{malop}'";

            cnn.THUCTHI_DULIEU(sql_sua);
            LAY_DULIEU();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            String sql_xoa = $"DELETE FROM DMLOP WHERE MALOP = '{txtMaLop.Text}'";
            cnn.THUCTHI_DULIEU(sql_xoa);
            LAY_DULIEU();
        }
    }
}
