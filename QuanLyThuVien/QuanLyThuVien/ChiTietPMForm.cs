using QuanLyThuVien.DAO;
using QuanLyThuVien.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyThuVien
{
    public partial class ChiTietPMForm : Form
    {
        public ChiTietPMForm()
        {
            InitializeComponent();
            reset();
            txtMaPM.Text = ((PhieuMuonForm)Application.OpenForms["PhieuMuonForm"]).ValueToSend;
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

        void load()
        {
            List<PhieuMuonCT> phieuMuonCT = ChiTietPMDAO.Instance.GetListPM();
            dataGridView1.DataSource = phieuMuonCT;
        }
        void reset()
        {
            txtMaPM.Text = null;
            txtMaSach.Text = null;
            cmbTrangThai.Hide();
            lblTrangThai.Hide();
            txtMaSach.Enabled = true;
            txtMaPM.Enabled = true;
            btnInsert.Enabled = true;
            btnDelete.Enabled = false;
            btnUpdate.Enabled = false;

        }
        private void ChiTietPMForm_Load(object sender, EventArgs e)
        {
            load();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Kiểm tra xem có phải là một hàng hợp lệ không
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                string maPM = row.Cells[0].Value.ToString();
                string maSach = row.Cells[1].Value.ToString();
                bool trangThai = (bool)row.Cells[2].Value;
                txtMaPM.Text = maPM;
                txtMaSach.Text = maSach;
                if (trangThai == false)
                {
                    cmbTrangThai.Text = "Đang mượn";
                }
                else
                {
                    cmbTrangThai.Text = "Đã trả";
                }
                tabControl1.SelectTab(tabPage2);
                btnInsert.Enabled = false;
                txtMaPM.Enabled = false;
                txtMaSach.Enabled = false;
                cmbTrangThai.Show();
                lblTrangThai.Show();
                btnDelete.Enabled = true;
                btnUpdate.Enabled = true;
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string maPM = txtMaPM.Text;
            string maSach = txtMaSach.Text;
            int trangThai = 0;

            if (cmbTrangThai.Text == "Đã trả")
            {
                trangThai = 1;
            }
            else
            {
                trangThai = 0;
            }

            ChiTietPMDAO.Instance.UpdatePhieu(maPM, maSach, trangThai);
            load();
            reset();

        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            string maPM = txtMaPM.Text;
            string maSach = txtMaSach.Text;
            int trangThai = 0;

            if (cmbTrangThai.Text == "Đã trả")
            {
                trangThai = 1;
            }
            else
            {
                trangThai = 0;
            }
            ChiTietPMDAO.Instance.InsertPhieu(maPM, maSach, trangThai);
            load();
            reset();
        }

        private void btn_Click(object sender, EventArgs e)
        {

        }

        private void btn_Click_1(object sender, EventArgs e)
        {
            load();
            reset();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string maPM = txtMaPM.Text;
            string maSach = txtMaSach.Text;
            ChiTietPMDAO.Instance.DeletePhieu(maPM, maSach);
            load();
            reset();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string ma = txtSearch.Text;
            if (ma == "")
            {
                List<PhieuMuonCT> phieuMuonCT = ChiTietPMDAO.Instance.GetListPM();
                dataGridView1.DataSource = phieuMuonCT;
            }
            else 
            {
                List<PhieuMuonCT> phieuMuonCT = ChiTietPMDAO.Instance.SearchPhieuById(ma);
                dataGridView1.DataSource = phieuMuonCT;
            }
           
        }
    }
}
