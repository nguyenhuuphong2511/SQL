using QuanLyThuVien.DAO;
using System.Data;
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
namespace QuanLyThuVien
{
    public partial class LoginFrom : Form
    {
        public LoginFrom()
        {
            InitializeComponent();
        }
    
        private void btnLogin_Click(object sender, EventArgs e)
        {
            string userName = txtTenUS.Text;
            string passWord = txtMatKhau.Text;

            
            if (Login(userName, passWord))
             {
                 //  Account loginAccount = AccountDAO.Instance.GetAccountByUserName(userName);
                 MessageBox.Show("Đăng nhập thành công", "Thông Báo!");
                 MenuForm menuForm = new MenuForm();
                 menuForm.Show();
                 this.Hide();
                 //this.ShowDialog();
                // this.Show();
             }
             else
             {
                 MessageBox.Show("Sai tên tài khoản hoặc mật khẩu!");
             }

        }
          

        
        bool Login(string userName, string passWord)
        {
            return AccountDAO.Instance.Login(userName, passWord);
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void LoginFrom_Load(object sender, EventArgs e)
        {
           
        }
    }
}
