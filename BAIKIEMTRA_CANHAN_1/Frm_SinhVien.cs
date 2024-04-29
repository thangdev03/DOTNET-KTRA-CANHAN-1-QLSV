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
    public partial class Frm_SinhVien : Form
    {
        public Frm_SinhVien()
        {
            InitializeComponent();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Frm_SinhVien_Load(object sender, EventArgs e)
        {
            LAY_DULIEU();
            LAY_DULIEU_BANGLOP();
            LAY_DULIEU_BANGKHOA();
            LAY_DULIEU_BANGHE();

            dtaGridSinhVien.SelectionChanged += dtaGridSinhVien_SelectionChanged;
        }

        ConnectDB cnn = new ConnectDB();

        public void LAY_DULIEU()
        {
            DataTable dta = new DataTable();
            dta = cnn.LayBang("Select * From SINHVIEN");
            dtaGridSinhVien.DataSource = dta;
            HIENTHIDULIEU();
        }

        public void LAY_DULIEU_BANGLOP()
        {
            DataTable dta = cnn.LayBang("Select MALOP, TENLOP From DMLOP");
            cboMaLop.DataSource = dta;
            cboMaLop.DisplayMember = "MALOP";
            cboMaLop.ValueMember = "MALOP";
        }

        public void LAY_DULIEU_BANGKHOA()
        {
            DataTable dta = cnn.LayBang("Select MAKHOA, TENKHOA From KHOAVIEN");
            cboMaKhoa.DataSource = dta;
            cboMaKhoa.DisplayMember = "MAKHOA";
            cboMaKhoa.ValueMember = "MAKHOA";
        }

        public void LAY_DULIEU_BANGHE()
        {
            DataTable dta = cnn.LayBang("Select MAHE, TENHE From HEDT");
            cboMaHe.DataSource = dta;
            cboMaHe.DisplayMember = "MAHE";
            cboMaHe.ValueMember = "MAHE";
        }

        public void LAY_DULIEU_GIOITINH(String maSV)
        {
            DataTable dta = cnn.LayBang($"Select GIOITINH From SINHVIEN WHERE MASV = {maSV}");
        }

        public void HIENTHIDULIEU()
        {
            txtMaSV.DataBindings.Clear();
            txtMaSV.DataBindings.Add("Text", dtaGridSinhVien.DataSource, "MASV");

            txtHoTen.DataBindings.Clear();
            txtHoTen.DataBindings.Add("Text", dtaGridSinhVien.DataSource, "HOVATEN");

            txtNoiSinh.DataBindings.Clear();
            txtNoiSinh.DataBindings.Add("Text", dtaGridSinhVien.DataSource, "NOISINH");

            datePickNgaySinh.DataBindings.Clear();
            datePickNgaySinh.DataBindings.Add("Value", dtaGridSinhVien.DataSource, "NGAYSINH");

            cboMaLop.DataBindings.Clear();
            cboMaLop.DataBindings.Add("Text", dtaGridSinhVien.DataSource, "MALOP");

            cboMaKhoa.DataBindings.Clear();
            cboMaKhoa.DataBindings.Add("Text", dtaGridSinhVien.DataSource, "MAKHOA");

            cboMaHe.DataBindings.Clear();
            cboMaHe.DataBindings.Add("Text", dtaGridSinhVien.DataSource, "MAHE");

            string gioiTinhValue = dtaGridSinhVien.CurrentRow.Cells["GIOITINH"].Value.ToString();

            if (gioiTinhValue == "Nam")
            {
                optNam.Checked = true;
                optNu.Checked = false;
            } else
            {
                optNam.Checked = false;
                optNu.Checked = true;
            }
        }

        private void dtaGridSinhVien_SelectionChanged(object sender, EventArgs e)
        {
            HIENTHIDULIEU();
        }

        private void btnTao_Click(object sender, EventArgs e)
        {
            txtMaSV.Text = "";
            txtMaSV.Focus();
            txtHoTen.Text = "";
            datePickNgaySinh.Text = "";
            txtNoiSinh.Text = "";
            cboMaLop.SelectedIndex = 0;
            cboMaHe.SelectedIndex = 0;
            cboMaKhoa.SelectedIndex = 0;
            optNam.Checked = false;
            optNu.Checked = false;
        }

        private void btnChen_Click(object sender, EventArgs e)
        {
            String masv = txtMaSV.Text;
            String hoten = txtHoTen.Text;
            DateTime ngaysinhValue = datePickNgaySinh.Value;
            String ngaysinh = ngaysinhValue.ToString("MM-dd-yyyy");
            String noisinh = txtNoiSinh.Text;
            String malop = cboMaLop.Text;
            String makhoa = cboMaKhoa.Text;
            String mahe = cboMaHe.Text;
            String optGioiTinh = optNam.Checked ? "Nam" : "Nu";

            String sql_chen = $"INSERT INTO SINHVIEN VALUES ('{masv}','{hoten}','{optGioiTinh}','{ngaysinh}','{noisinh}','{makhoa}','{malop}','{mahe}')";
            cnn.THUCTHI_DULIEU(sql_chen);
            LAY_DULIEU();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            String masv = txtMaSV.Text;
            String hoten = txtHoTen.Text;
            DateTime ngaysinhValue = datePickNgaySinh.Value;
            String ngaysinh = ngaysinhValue.ToString("MM-dd-yyyy");
            String noisinh = txtNoiSinh.Text;
            String malop = cboMaLop.Text;
            String makhoa = cboMaKhoa.Text;
            String mahe = cboMaHe.Text;
            String optGioiTinh = optNam.Checked ? "Nam" : "Nu";

            String sql_sua = $"UPDATE SINHVIEN SET HOVATEN = '{hoten}',GIOITINH = '{optGioiTinh}',NGAYSINH = '{ngaysinh}' ,NOISINH = '{noisinh}',MAKHOA = '{makhoa}',MALOP = '{malop}', MAHE = '{mahe}'" +
                $"WHERE MASV = '{masv}'";

            cnn.THUCTHI_DULIEU(sql_sua);
            LAY_DULIEU();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            String sql_xoa = $"DELETE FROM SINHVIEN WHERE MASV = '{txtMaSV.Text}'";
            cnn.THUCTHI_DULIEU(sql_xoa);
            LAY_DULIEU();
        }
    }
}
