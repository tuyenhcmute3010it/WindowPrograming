using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp1
{

    public class HocSinhDAO
    {
        SqlConnection conn = new SqlConnection(Properties.Settings.Default.connStr);
        public HocSinhDAO() { }
        public void btnThem(string hoTen, string diaChi, string cmnd)
        {
            try
            {
                // Ket noi
                conn.Open();
                HocSinh hs = new HocSinh(hoTen, diaChi, cmnd);
                string sqlStr = string.Format("INSERT INTO HocSinh(Ten , Diachi ,Cmnd) VALUES ('{0}', '{1}','{2}')", hoTen, diaChi, cmnd);
                SqlCommand cmd = new SqlCommand(sqlStr, conn);
                if (cmd.ExecuteNonQuery() > 0)
                    MessageBox.Show("them thanh cong");
            }
            catch (Exception ex)
            {
                MessageBox.Show("them that bai" + ex);
            }
            finally
            {
                conn.Close();
            }
        }
        public void btnXoa(string cmnd)
        {
            try
            {
                // Ket noi
                conn.Open();
                string SQL = string.Format("DELETE FROM HocSinh WHERE Cmnd = '{0}'", cmnd);
                SqlCommand cmd = new SqlCommand(SQL, conn);
                if (cmd.ExecuteNonQuery() > 0)
                    MessageBox.Show("xoa thanh cong");
            }
            catch (Exception ex)
            {
                MessageBox.Show("xoa that bai" + ex);
            }
            finally
            {
                conn.Close();
            }
        }
        public void btnSua(string hoTen, string diaChi, string cmnd)
        {
            try
            {
                // Ket noi
                conn.Open();
                string SQL = string.Format("UPDATE HocSinh SET Ten = '{0}', DiaChi = '{1}' WHERE Cmnd = '{2}'", hoTen, diaChi, cmnd);
                SqlCommand cmd = new SqlCommand(SQL, conn);
                if (cmd.ExecuteNonQuery() > 0)
                    MessageBox.Show("sua thanh cong");
            }
            catch (Exception ex)
            {
                MessageBox.Show("sua that bai" + ex);
            }
            finally
            {
                conn.Close();
            }

        }


    }
}
