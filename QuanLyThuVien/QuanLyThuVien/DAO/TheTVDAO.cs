using QuanLyThuVien.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyThuVien.DAO
{
    public class TheTVDAO
    {
        private static TheTVDAO instance;
        private TheTVDAO() { }
        public static TheTVDAO Instance
        {
            get { if (instance == null) instance = new TheTVDAO(); return TheTVDAO.instance; }
            private set { TheTVDAO.instance = value; }
        }

        public List<TheThanhVien> GetListTheTV()
        {
            List<TheThanhVien> list = new List<TheThanhVien>();

            string query = "select * from TheThanhVien";

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                TheThanhVien theTV = new TheThanhVien(item);
                list.Add(theTV);
            }

            return list;
        }

        public List<TheThanhVien> SearchTheByID(string id)
        {

            List<TheThanhVien> list = new List<TheThanhVien>();

            string query = string.Format("SELECT * FROM TheThanhVien where MaTV like N'%{0}%' ", id);

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                TheThanhVien theTV = new TheThanhVien(item);
                list.Add(theTV);
            }

            return list;
        }

        public bool InsertThe(string maTV, string tenTV, string diaChi, string email, int gioiTinh, string sdt) 
        {
            string query = string.Format("INSERT dbo.TheThanhVien (MaTV , TenTV , DiaChi , Email , GioiTinh , SDT) values('{0}',N'{1}' , N'{2}' , '{3}' , {4} , {5} );", maTV,  tenTV,  diaChi,  email,  gioiTinh, sdt);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }

        public bool UpdateThe(string maTV, string tenTV, string diaChi, string email, int gioiTinh, string sdt)
        {
            string query = string.Format("UPDATE dbo.TheThanhVien SET TenTV = N'{0}' , DiaChi = N'{1}' , Email = '{2}' , GioiTinh = {3} , SDT = {4} WHERE MaTV = '{5}'",  tenTV,  diaChi,  email,  gioiTinh,  sdt , maTV);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }

        public bool DeleteThe(string ma)
        {
            string query = string.Format("Delete TheThanhVien where MaTV = '{0}'", ma);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
        
    }
}
