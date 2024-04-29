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
    public partial class MDI : Form
    {
        public MDI()
        {
            InitializeComponent();
        }

        private void btnDMLop_Click(object sender, EventArgs e)
        {
            Frm_DMLop frmDMLop = new Frm_DMLop();
            frmDMLop.Show();
        }

        private void btnKhoaVien_Click(object sender, EventArgs e)
        {
            Frm_KhoaVien frmKhoaVien = new Frm_KhoaVien();
            frmKhoaVien.Show();
        }

        private void btnSinhVien_Click(object sender, EventArgs e)
        {
            Frm_SinhVien frmSinhVien= new Frm_SinhVien();
            frmSinhVien.Show();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            Frm_TimKiem frmTimKiem = new Frm_TimKiem();
            frmTimKiem.Show();
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
