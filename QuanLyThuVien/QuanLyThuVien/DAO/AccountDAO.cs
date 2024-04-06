using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyThuVien.DAO
{
    public class AccountDAO
    {
        private static AccountDAO instance;
        public static AccountDAO Instance
        {
            get { if (instance == null) instance = new AccountDAO(); return instance; }
            private set { instance = value; }
        }

        public bool Login(string userName, string passWord)
        {

              string query = "CheckLogin @Username , @Password ;";
          //  string query = string.Format("select * from QuanTriVien where MaUS = '{0}' and MatKhau = '{1}'", userName, passWord);
            DataTable result = DataProvider.Instance.ExecuteQuery(query, new object[] { userName , passWord});

       

            return result.Rows.Count > 0;
        }
    }
}
