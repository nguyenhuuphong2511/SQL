using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyThuVien.DTO
{
    public class PhieuMuon
    {
        private string maPM;
        private string maTV;
        private DateTime ngayMuon;
        private DateTime ngayTra;
        public PhieuMuon(DataRow row)
        {

            this.MaPM = row["MaPM"].ToString();
            this.MaTV = row["MaTV"].ToString();
            this.NgayMuon = (DateTime)row["NgayMuon"];
            this.NgayTra = (DateTime)row["NgayTra"];

        }

        public string MaPM { get => maPM; set => maPM = value; }
        public string MaTV { get => maTV; set => maTV = value; }
        public DateTime NgayMuon { get => ngayMuon; set => ngayMuon = value; }
        public DateTime NgayTra { get => ngayTra; set => ngayTra = value; }
    }
}
