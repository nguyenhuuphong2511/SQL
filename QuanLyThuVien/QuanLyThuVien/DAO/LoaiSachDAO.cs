using QuanLyThuVien.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyThuVien.DAO
{
    public class LoaiSachDAO
    { 
        private static LoaiSachDAO instance;
        private LoaiSachDAO() { }
        public static LoaiSachDAO Instance
        {
            get { if (instance == null) instance = new LoaiSachDAO(); return LoaiSachDAO.instance; }
            private set { LoaiSachDAO.instance = value; }
        }

        public List<LoaiSach> GetListLoai()
        {
            List<LoaiSach> list = new List<LoaiSach>();

            string query = "select * from loaiSach";

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                LoaiSach loaiSach = new LoaiSach(item);
                list.Add(loaiSach);
            }

            return list;
        }

        public List<LoaiSach> SearchLoaiByName(string name)
        {

            List<LoaiSach> list = new List<LoaiSach>();

            string query = string.Format("SELECT * FROM LoaiSach where TenLoai like N'%{0}%' ", name);

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                LoaiSach sach = new LoaiSach(item);
                list.Add(sach);
            }

            return list;
        }

        public bool InsertLoai(string maLoai, string tenLoai)
        {
            string query = string.Format("INSERT dbo.LoaiSach (MaLoai , TenLoai) values('{0}',N'{1}');", maLoai,tenLoai);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }

        public bool UpdateLoai(string maLoai, string tenLoai)
        {
            string query = string.Format("UPDATE dbo.LoaiSach SET TenLoai = N'{0}' WHERE MaLoai = '{1}'", tenLoai, maLoai);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }

         public bool DeleteLoai(string maLoai)
          {
              string query = string.Format("Delete LoaiSach where MaLoai = '{0}'", maLoai);
              int result = DataProvider.Instance.ExecuteNonQuery(query);
              return result > 0;
          }

    }
}

