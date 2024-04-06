using QuanLyThuVien.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace QuanLyThuVien.DAO
{
    public class SachDAO
    {
        private static SachDAO instance;
        private SachDAO() { }   
        public static SachDAO Instance
        {
            get { if (instance == null) instance = new SachDAO(); return SachDAO.instance; }
            private set { SachDAO.instance = value; }
        }

        public List<Sach> GetListSach()
        {
            List<Sach> list = new List<Sach>();

            string query = "select * from SachList ORDER BY MaSach DESC";

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                Sach sach = new Sach(item);
                list.Add(sach);
            }

            return list;
        }

        public List<SachChiTiet> SearchSachByID(string maSach)
        {

            List<SachChiTiet> list = new List<SachChiTiet>();

        //    string query = string.Format("SELECT * FROM SachList where maSach = '{0}' ", maSach);

            DataTable data = DataProvider.Instance.ExecuteQuery("EXEC SearchByIdSach @MaSach  ", new object[] { maSach });

            foreach (DataRow item in data.Rows)
            {
                SachChiTiet sach = new SachChiTiet(item);
                list.Add(sach);
            }

            return list;
        }
        public List<Sach> SearchSachByName(string name)
        {

            List<Sach> list = new List<Sach>();

           // string query = string.Format("EXEC SearchByNameSach @TenSach  ", new object[] { name });

            DataTable data = DataProvider.Instance.ExecuteQuery("EXEC SearchByNameSach @TenSach  ", new object[] { name });

            foreach (DataRow item in data.Rows)
            {
                Sach sach = new Sach(item);
                list.Add(sach);
            }

            return list;
        }

        public bool InsertSach(string maSach, string tenSach, string maLoai, string maTG, string nhaXB, string soLuong)
        {
            /* string query = string.Format("INSERT dbo.Sach (MaSach , TenSach , MaLoai , MaTG , NhaXB , SoLuong) values('{0}',N'{1}','{2}','{3}','{4}',{5})", maSach, tenSach, maLoai, maTG, nhaXB, soLuong);
             int result = DataProvider.Instance.ExecuteNonQuery(query);*/
            int result = DataProvider.Instance.ExecuteNonQuery("EXEC InsertSach @MaSach , @TenSach , @MaLoai , @MaTG , @NhaXB , @SoLuong ", new object[] { maSach, tenSach, maLoai, maTG, nhaXB, soLuong });
            return result > 0;
        }

        public bool UpdateSach(string maSach, string tenSach, string maLoai, string maTG, string nhaXB, string soLuong)
        {
            int result = DataProvider.Instance.ExecuteNonQuery("EXEC UpdateSach @MaSach , @TenSach , @MaLoai , @MaTG , @NhaXB , @SoLuong ", new object[] { maSach, tenSach, maLoai, maTG, nhaXB, soLuong });
            return result > 0;
        }

        public bool DeleteSach(string maSach)
        {
            int result = DataProvider.Instance.ExecuteNonQuery("EXEC DeleteSach @MaSach ", new object[] { maSach });
            return result > 0;
        }

    }
}
