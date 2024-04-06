using QuanLyThuVien.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyThuVien.DAO
{
    public class PhieuMuonDAO
    {
        private static PhieuMuonDAO instance;
        private PhieuMuonDAO() { }
        public static PhieuMuonDAO Instance
        {
            get { if (instance == null) instance = new PhieuMuonDAO(); return PhieuMuonDAO.instance; }
            private set { PhieuMuonDAO.instance = value; }
        }

        public List<PhieuMuon> GetListPM()
        {
            List<PhieuMuon> list = new List<PhieuMuon>();

            string query = "select * from PhieuMuon";

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                PhieuMuon phieuMuon = new PhieuMuon(item);
                list.Add(phieuMuon);
            }

            return list;
        }

        public List<PhieuMuon> SearchPhieuById(string id)
        {

            List<PhieuMuon> list = new List<PhieuMuon>();

            string query = string.Format("SELECT * FROM PhieuMuon where MaPM = '{0}' ", id);

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                PhieuMuon pm = new PhieuMuon(item);
                list.Add(pm);
            }

            return list;
        }

        public bool InsertPhieu(string maPhieu, string maTV, DateTime ngayMuon, DateTime ngayTra)
        {
            string query = string.Format("INSERT dbo.PhieuMuon (MaLoai , TenLoai) values('{0}',N'{1}');", maPhieu, maTV,  ngayMuon,  ngayTra);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }

        public bool UpdatePhieu(string maLoai, string tenLoai)
        {
            string query = string.Format("UPDATE dbo.PhieuMuon SET TenLoai = N'{0}' WHERE MaLoai = '{1}'", tenLoai, maLoai);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }

        public bool DeletePhieu(string maLoai)
        {
            string query = string.Format("Delete PhieuMuon where MaLoai = '{0}'", maLoai);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }


    }
}
