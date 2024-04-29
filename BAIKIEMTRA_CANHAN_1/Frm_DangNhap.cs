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
    public partial class Frm_DangNhap : Form
    {
        ConnectDB cnn = new ConnectDB();

        public Frm_DangNhap()
        {
            InitializeComponent();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            cnn.KetNoi_Dulieu();
            String username = txtTenDN.Text;
            String password = txtMatKhau.Text;
            String sql_login = $"SELECT * FROM HETHONG WHERE TENDN = '{username}' and MATKHAU = '{password}'";

            SqlCommand cmd = new SqlCommand(sql_login, cnn.cnn);
            SqlDataReader datRed = cmd.ExecuteReader();

            if (datRed.Read() == true)
            {
                MessageBox.Show("Đăng nhập thành công!");
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("Thông tin mật khẩu hoặc tên đăng nhập bị sai");
            }

            cnn.HuyKetNoi();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
