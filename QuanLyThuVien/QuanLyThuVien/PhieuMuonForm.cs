using QuanLyThuVien.DAO;
using QuanLyThuVien.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Xps;

namespace QuanLyThuVien
{
    public partial class PhieuMuonForm : Form
    {
        public string ValueToSend { get; internal set; }

        public PhieuMuonForm()
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

        private void PhieuMuonForm_Load(object sender, EventArgs e)
        {
            load();
        }

        void load()
        {
            List<PhieuMuon> phieuMuon = PhieuMuonDAO.Instance.GetListPM();
            dataGridView1.DataSource = phieuMuon;
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            string ValueToSend = txtMaPM.Text;
            ChiTietPMForm chiTietPMForm = new(tabControl1.SelectTab(1));
            chiTietPMForm.Show();
        }
    }
}
