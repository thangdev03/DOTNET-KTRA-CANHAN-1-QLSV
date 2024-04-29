using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BAIKIEMTRA_CANHAN_1
{
    public partial class Frm_TimKiem : Form
    {
        ConnectDB cnn = new ConnectDB();

        public Frm_TimKiem()
        {
            InitializeComponent();
        }

        private void Frm_TimKiem_Load(object sender, EventArgs e)
        {
            LAY_DULIEU();
            LAY_DULIEU_LOP();
        }

        public void LAY_DULIEU()
        {
            DataTable dta = new DataTable();
            dta = cnn.LayBang("Select * From THONGTIN_SV_LOP");
            dtaGridKetQua.DataSource = dta;
        }

        public void LAY_DULIEU_LOP()
        {
            DataTable dta = new DataTable();
            dta = cnn.LayBang("Select MALOP, TENLOP From DMLOP");
            cboLop.DataSource = dta;
            cboLop.DisplayMember = "TENLOP";
            cboLop.ValueMember = "MALOP";
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            DataTable dta = new DataTable();
            String sql_timkiem = "SELECT * FROM THONGTIN_SV_LOP";

            if (optTimSinhVien.Checked)
            {
                String searchTxt = txtSinhVien.Text;
                sql_timkiem = $"SELECT * FROM THONGTIN_SV_LOP WHERE MASV like '%{searchTxt}%' or HOVATEN like '%{searchTxt}%'";
            } else if (optTimLop.Checked)
            {
                String searchTxt = cboLop.SelectedValue.ToString();
                Console.WriteLine(searchTxt);
                sql_timkiem = $"SELECT * FROM THONGTIN_SV_LOP WHERE MALOP = '{searchTxt}'";
            }

            dta = cnn.LayBang(sql_timkiem);
            dtaGridKetQua.DataSource = dta;
        }
    }
}
