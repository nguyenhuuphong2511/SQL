using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyThuVien.DTO
{
    public class PhieuMuonCT
    {
        private string maPM;
        private string maSach;
        private bool trangThai;
        private bool quaHan;

        public PhieuMuonCT(DataRow row)
        {
            this.MaPM = row["MaPM"].ToString();
            this.MaSach = row["MaSach"].ToString();
            this.trangThai = (bool)row["TrangThai"];
            this.quaHan = (bool)row["QuaHan"];

        }
        public string MaPM { get => maPM; set => maPM = value; }
        public string MaSach { get => maSach; set => maSach = value; }
        public bool TrangThai { get => trangThai; set => trangThai = value; }
        public bool QuaHan { get => quaHan; set => quaHan = value; }
    }
}
