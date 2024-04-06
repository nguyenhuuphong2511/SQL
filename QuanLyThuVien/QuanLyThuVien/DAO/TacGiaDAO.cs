using QuanLyThuVien.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyThuVien.DAO
{
    public class TacGiaDAO
    {
        private static TacGiaDAO instance;
        private TacGiaDAO() { }
        public static TacGiaDAO Instance
        {
            get { if (instance == null) instance = new TacGiaDAO(); return TacGiaDAO.instance; }
            private set { TacGiaDAO.instance = value; }
        }

        public List<TacGia> GetListTG()
        {
            List<TacGia> list = new List<TacGia>();

            string query = "select * from TacGia";

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                TacGia tacgia = new TacGia(item);
                list.Add(tacgia);
            }

            return list;
        }

        public List<TacGia> SearchTGByName(string name)
        {

            List<TacGia> list = new List<TacGia>();

            string query = string.Format("SELECT * FROM TacGia where TenTG like N'%{0}%' ", name);

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                TacGia sach = new TacGia(item);
                list.Add(sach);
            }

            return list;
        }

        public bool InsertTG(string maTG, string name)
        {
            string query = string.Format("INSERT dbo.TacGia (MaTG , TenTG) values('{0}',N'{1}');", maTG, name);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }

        public bool UpdateTG(string maTG, string name)
        {
            string query = string.Format("UPDATE dbo.TacGia SET TenTG = N'{0}' WHERE MaTG = '{1}'", name, maTG);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }

        public bool DeleteTG(string maTG)
        {
            string query = string.Format("Delete TacGia where MaTG = '{0}'", maTG);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
    }
}
