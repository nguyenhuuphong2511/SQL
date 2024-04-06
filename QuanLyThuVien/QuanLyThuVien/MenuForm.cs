namespace QuanLyThuVien
{
    public partial class MenuForm : Form
    {
        public MenuForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button12_Click(object sender, EventArgs e)
        {
            SachForm sachForm = new SachForm();
            sachForm.Show();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            LoaiSachFrom loaiSach = new LoaiSachFrom();
            loaiSach.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            TacGiaForm tacGia = new TacGiaForm();
            tacGia.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            PhieuMuonForm phieuMuon = new PhieuMuonForm();
            phieuMuon.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ChiTietPMForm chiTietPM = new ChiTietPMForm();
            chiTietPM.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            QTVForm qtvForm = new QTVForm();
            qtvForm.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            TheTVForm theTVForm = new TheTVForm();
            theTVForm.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            QuaHanForm quaHan = new QuaHanForm();
            quaHan.Show();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn đăng xuất?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                // Thực hiện các công việc cần thiết để đăng xuất, chẳng hạn như đặt lại trạng thái đăng nhập
                // Để minh họa, chúng ta chỉ đóng cửa sổ chính
                this.Hide();

                // Hiển thị lại form đăng nhập hoặc form khác tùy thuộc vào yêu cầu của ứng dụng
                LoginFrom LoginFrom = new LoginFrom();
                LoginFrom.Show();
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            TacGiaForm tacGiaForm = new TacGiaForm();
            tacGiaForm.Show();
        }
    }
}
