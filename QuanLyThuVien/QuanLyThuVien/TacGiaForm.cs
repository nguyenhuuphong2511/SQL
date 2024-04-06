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

namespace QuanLyThuVien
{
    public partial class TacGiaForm : Form
    {
        public TacGiaForm()
        {
            InitializeComponent();
        }
        void load()
        {
            List<TacGia> GetListTG = TacGiaDAO.Instance.GetListTG();
            dataGridView1.DataSource = GetListTG;
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

        void resetText()
        {
            txtMaTG.Text = "TG00";
            txtTenTG.Text = null;
            txtMaTG.Enabled = true;
        }
        private void TacGiaForm_Load(object sender, EventArgs e)
        {
            load();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Kiểm tra xem có phải là một hàng hợp lệ không
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                string maLoai = row.Cells[0].Value.ToString();
                string tenLoai = row.Cells[1].Value.ToString();
                txtMaTG.Text = maLoai;
                txtTenTG.Text = tenLoai;
                tabControl1.SelectTab(tabPage2);
                txtMaTG.Enabled = false;
            }
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            string ma = txtMaTG.Text;
            string tenTG = txtTenTG.Text;
            if (ma == "TG00" || tenTG == null || tenTG == "" || ma == null)
            {
                MessageBox.Show("mã và tên tác giả không được để trống");
            }
            else
            {
                if (TacGiaDAO.Instance.InsertTG(ma, tenTG))
                {
                    MessageBox.Show("Thêm tác giả thành công");
                    load();
                    // resetText();
                }
                else
                {
                    MessageBox.Show("Có lỗi khi thêm tác giả");
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string ma = txtMaTG.Text;
            if (TacGiaDAO.Instance.DeleteTG(ma))
            {
                MessageBox.Show("Xóa thành công");
                load();
                resetText();
            }
            else
            {
                MessageBox.Show("Có lỗi khi xóa ");
            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            resetText();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string ma = txtMaTG.Text;
            string ten = txtTenTG.Text;
            if (TacGiaDAO.Instance.UpdateTG(ma, ten))
            {
                MessageBox.Show("Cập nhật thành công");
                load();
                //resetText();
            }
            else
            {
                MessageBox.Show("Có lỗi khi cập nhật ");
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string tenTG = txtSearch.Text;
            List<TacGia> GetListTG = TacGiaDAO.Instance.SearchTGByName(tenTG);
            dataGridView1.DataSource = GetListTG;
        }
    }
}
