using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Thêm 2 thư viện để kết nối db
using System.Data;
using System.Data.SqlClient;

namespace BAIKIEMTRA_CANHAN_1
{
    internal class ConnectDB
    {
        public SqlConnection cnn;
        public SqlCommand cmd;
        public DataTable dta;
        public SqlDataAdapter ada;

        public void KetNoi_Dulieu()
        {
            string strKetNoi = @"Data Source = ThangScarPC-DT\SQLEXPRESS; Initial Catalog = QLSV; Integrated Security = True";
            cnn = new SqlConnection(strKetNoi);
            cnn.Open();
        }

        public void HuyKetNoi()
        {
            if (cnn.State == ConnectionState.Open)
                cnn.Close();
        }

        public DataTable LayBang(string Sql)
        {
            KetNoi_Dulieu();
            ada = new SqlDataAdapter(Sql, cnn);
            dta = new DataTable();
            ada.Fill(dta);
            return dta;
        }

        public void THUCTHI_DULIEU(string Sql)
        {
            KetNoi_Dulieu();
            cmd = new SqlCommand(Sql, cnn);
            cmd.ExecuteNonQuery();
            HuyKetNoi();
        }
    }
}
