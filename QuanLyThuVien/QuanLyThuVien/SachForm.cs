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
using System.Windows.Controls;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace QuanLyThuVien
{
    public partial class SachForm : Form
    {
        public SachForm()
        {
            InitializeComponent();
            LoadMaLoai();
        }
        void LoadMaLoai()
        {
            List<LoaiSach> lsachList = LoaiSachDAO.Instance.GetListLoai();
           
            //this.comboBox1.DataSource = lsachList;
            var bindingSource1 = new BindingSource();
            bindingSource1.DataSource = lsachList;
            this.cmbLoaiSach.DataSource = bindingSource1.DataSource;
            cmbLoaiSach.DisplayMember = "TenLoai";
            cmbLoaiSach.ValueMember = "MaLoai";

            
            List<TacGia> tgiaList = TacGiaDAO.Instance.GetListTG();
            bindingSource1.DataSource = tgiaList;
            this.cmbTacGia.DataSource = bindingSource1.DataSource;
            cmbTacGia.DisplayMember = "TenTG";
            cmbTacGia.ValueMember = "MaTG";
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Kiểm tra xem có phải là một hàng hợp lệ không
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                string MaSach = row.Cells[0].Value.ToString();
                List<SachChiTiet> sachList = SachDAO.Instance.SearchSachByID(MaSach);
                txtMaSach.Text = MaSach;
                txtTenSach.Text = sachList[0].TenSach.ToString();
                cmbLoaiSach.SelectedValue = sachList[0].MaLoai.ToString();
                cmbTacGia.SelectedValue = sachList[0].MaTG.ToString();
                txtNhaXB.Text = sachList[0].NhaXB.ToString(); ;
                txtSoLuong.Text = sachList[0].SoLuong.ToString();
                tabControl1.SelectTab(tabPage2);
                txtMaSach.Enabled = false;
            }
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

        private void SachForm_Load(object sender, EventArgs e)
        {
            List<Sach> sachList = SachDAO.Instance.GetListSach();
            dataGridView1.DataSource = sachList;
        }


        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbLoaiSach_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }



        private void btnNew_Click(object sender, EventArgs e)
        {
            reset();


        }

        void reset()
        {
            txtMaSach.Text = "MS00";
            txtTenSach.Text = null;
            cmbTacGia.SelectedIndex = 0;
            cmbLoaiSach.SelectedIndex = 0;
            txtSoLuong.Text = null;
            txtNhaXB.Text = null;
            txtMaSach.Enabled = true;
            List<Sach> sachList = SachDAO.Instance.GetListSach();
            dataGridView1.DataSource = sachList;
        }
        private void btnInsert_Click(object sender, EventArgs e)
        {
            string maSach = txtMaSach.Text;
            string tenSach = txtTenSach.Text;
            string maLoai = cmbLoaiSach.SelectedValue.ToString();
            string maTG = cmbTacGia.SelectedValue.ToString();
            string nhaXb = txtNhaXB.Text;
            string soLuong = txtSoLuong.Text;
            //    int soLuong = int.Parse(txtSoLuong.Text.ToString());
            SachDAO.Instance.InsertSach(maSach, tenSach, maLoai, maTG, nhaXb, soLuong);
            reset();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string maSach = txtMaSach.Text;
            SachDAO.Instance.DeleteSach(maSach);
            reset();
            
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string maSach = txtMaSach.Text;
            string tenSach = txtTenSach.Text;
            string maLoai = cmbLoaiSach.SelectedValue.ToString();
            string maTG = cmbTacGia.SelectedValue.ToString();
            string nhaXb = txtNhaXB.Text;
            string soLuong = txtSoLuong.Text;
            // int soLuong = int.Parse(txtSoLuong.Text.ToString());
            SachDAO.Instance.UpdateSach(maSach, tenSach, maLoai, maTG, nhaXb, soLuong);
            reset();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string name = txtTimKiem.Text;
            List<Sach> sachList = SachDAO.Instance.SearchSachByName(name);
            dataGridView1.DataSource = sachList;
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
