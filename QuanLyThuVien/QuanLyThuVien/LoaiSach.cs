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
using System.Windows.Media;

namespace QuanLyThuVien
{
    public partial class LoaiSachFrom : Form
    {
        public LoaiSachFrom()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Kiểm tra xem có phải là một hàng hợp lệ không
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                string maLoai = row.Cells[0].Value.ToString();
                string tenLoai = row.Cells[1].Value.ToString();
                txtMaLoai.Text = maLoai;
                txtTenLoai.Text = tenLoai;

                tabControl1.SelectTab(tabPage2);
                txtMaLoai.Enabled = false;
            }
        }

        private void LoaiSachFrom_Load(object sender, EventArgs e)
        {
            loadListLoaiSach();
        }

        void loadListLoaiSach()
        {
            List<LoaiSach> lsachList = LoaiSachDAO.Instance.GetListLoai();
            dataGridView1.DataSource = lsachList;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string ma = txtMaLoai.Text;
            string tenLoai = txtTenLoai.Text;
            if (ma == "LS00" || tenLoai == null || tenLoai == "" || ma ==null)
            {
                MessageBox.Show("mã và tên loại không được để trống");

            }
            else
            {
                if (LoaiSachDAO.Instance.InsertLoai(ma, tenLoai))
                {
                    MessageBox.Show("Thêm loại sách thành công nhá");
                    loadListLoaiSach();
                    resetText();
                }
                else
                {
                    MessageBox.Show("Có lỗi khi thêm loại sách");
                }
            }
        }
        void resetText()
        {
            txtMaLoai.Text = "LS00";
            txtTenLoai.Text = null;
        }
        private void btnNew_Click(object sender, EventArgs e)
        {
            resetText();
            txtMaLoai.Enabled = true;
        }

        private void btnDeleted_Click(object sender, EventArgs e)
        {
            string ma = txtMaLoai.Text;
            if (LoaiSachDAO.Instance.DeleteLoai(ma))
            {
                MessageBox.Show("Xóa thành công");
                loadListLoaiSach();
                resetText();
            }
            else
            {
                MessageBox.Show("Có lỗi khi xóa ");
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string ma = txtMaLoai.Text;
            string ten = txtTenLoai.Text;
            if (LoaiSachDAO.Instance.UpdateLoai(ma, ten))
            {
                MessageBox.Show("Cập nhật thành công");
                loadListLoaiSach();
                resetText();
            }
            else
            {
                MessageBox.Show("Có lỗi khi cập nhật ");
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string name = txtTim.Text;
            List<LoaiSach> lsachList = LoaiSachDAO.Instance.SearchLoaiByName(name);
            dataGridView1.DataSource = lsachList;
        }
    }
}
