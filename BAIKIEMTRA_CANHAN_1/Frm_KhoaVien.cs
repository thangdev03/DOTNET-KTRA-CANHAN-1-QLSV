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
    public partial class Frm_KhoaVien : Form
    {
        public Frm_KhoaVien()
        {
            InitializeComponent();
        }

        private void Frm_KhoaVien_Load(object sender, EventArgs e)
        {
            LAY_DULIEU();
            dtaGridKhoa.SelectionChanged += dtaGridKhoa_SelectionChanged;
        }

        ConnectDB cnn = new ConnectDB();

        public void LAY_DULIEU()
        {
            DataTable dta = new DataTable();
            dta = cnn.LayBang("Select * From KHOAVIEN");
            dtaGridKhoa.DataSource = dta;
            HIENTHIDULIEU();
        }

        private void dtaGridKhoa_SelectionChanged(object sender, EventArgs e)
        {
            HIENTHIDULIEU();
        }
        public void HIENTHIDULIEU()
        {
            txtMaKhoa.DataBindings.Clear();
            txtMaKhoa.DataBindings.Add("Text", dtaGridKhoa.DataSource, "MAKHOA");

            txtTenKhoa.DataBindings.Clear();
            txtTenKhoa.DataBindings.Add("Text", dtaGridKhoa.DataSource, "TENKHOA");

            txtDiaChi.DataBindings.Clear();
            txtDiaChi.DataBindings.Add("Text", dtaGridKhoa.DataSource, "DIACHI");

            txtSDT.DataBindings.Clear();
            txtSDT.DataBindings.Add("Text", dtaGridKhoa.DataSource, "SODT");
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnTao_Click(object sender, EventArgs e)
        {
            txtMaKhoa.Text = "";
            txtMaKhoa.Focus();
            txtTenKhoa.Text = "";
            txtDiaChi.Text = "";
            txtSDT.Text = "";
        }

        private void btnChen_Click(object sender, EventArgs e)
        {
            String makhoa = txtMaKhoa.Text;
            String tenkhoa = txtTenKhoa.Text;
            String diachi = txtDiaChi.Text;
            String sdt = txtSDT.Text;

            String sql_chen = $"INSERT INTO KHOAVIEN VALUES ('{makhoa}','{tenkhoa}','{diachi}','{sdt}')";

            cnn.THUCTHI_DULIEU(sql_chen);
            LAY_DULIEU();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            String makhoa = txtMaKhoa.Text;
            String tenkhoa = txtTenKhoa.Text;
            String diachi = txtDiaChi.Text;
            String sdt = txtSDT.Text;

            String sql_sua = $"UPDATE KHOAVIEN SET TENKHOA='{tenkhoa}',DIACHI='{diachi}',SODT='{sdt}' " +
                $"WHERE MAKHOA='{makhoa}'";

            cnn.THUCTHI_DULIEU(sql_sua);
            LAY_DULIEU();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            String sql_xoa = $"DELETE FROM KHOAVIEN WHERE MAKHOA = '{txtMaKhoa.Text}'";

            cnn.THUCTHI_DULIEU(sql_xoa);
            LAY_DULIEU();
        }
    }
}
