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

namespace QuanLyThuVien
{
    public partial class QuaHanForm : Form
    {
        public QuaHanForm()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void QuaHanForm_Load(object sender, EventArgs e)
        {
            ketnoicsdl();
        }
        SqlConnection connect = new SqlConnection(@"Data Source=DESKTOP-8RQTHGM;Initial Catalog=QuanLyThuVien;User ID=sa;Password=123456;Integrated Security=True");
        private void ketnoicsdl()
        {
            connect.Open();
            string sql = "select * from Quahantra";
            SqlCommand com = new SqlCommand(sql, connect);
            com.CommandType = CommandType.Text;
            SqlDataAdapter da = new SqlDataAdapter(com);
            DataTable dt = new DataTable();
            da.Fill(dt);
            connect.Close();
            dataGridView1.DataSource = dt;
        }
    }
}
