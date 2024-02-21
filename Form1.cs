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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        SqlConnection conn = new SqlConnection(Properties.Settings.Default.connStr);
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                string sqlStr = string.Format("SELECT *FROM GiaoVien");


                SqlDataAdapter adapter = new SqlDataAdapter(sqlStr, conn);
                DataTable dtSinhVien = new DataTable();
                adapter.Fill(dtSinhVien);
                dataGridView1.DataSource = dtSinhVien; /// gvHsinh = name cua data gridview
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void btnthem1_Click(object sender, EventArgs e)
        {
            HocSinhDAO hsDao = new HocSinhDAO();
            hsDao.btnThem(txthoten.Text, txtdiachi.Text, txtcmnd.Text);
        }

        private void btnxoa1_Click(object sender, EventArgs e)
        {
            HocSinhDAO hsDao = new HocSinhDAO();
            hsDao.btnXoa(txtcmnd.Text);
        }

        private void btnsua1_Click(object sender, EventArgs e)
        {
            HocSinhDAO hsDao = new HocSinhDAO();
            hsDao.btnSua(txthoten.Text, txtdiachi.Text, txtcmnd.Text);
        }

    }
}
