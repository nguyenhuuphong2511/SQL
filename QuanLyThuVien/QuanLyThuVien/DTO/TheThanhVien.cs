using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyThuVien.DTO
{
    public class TheThanhVien
    {
        private string maTV;
        private string tenTV;
        private string diaChi;
        private string email;
        private bool gioiTinh;
        private int soDT;

        public TheThanhVien(DataRow row)
        {
            this.MaTV = row["MaTV"].ToString();
            this.TenTV = row["TenTV"].ToString();
            this.DiaChi = row["DiaChi"].ToString();
            this.Email = row["Email"].ToString();
            this.GioiTinh = (bool)row["GioiTinh"];
            this.SDT = (int)row["SDT"];
        }
        public string MaTV { get => maTV; set => maTV = value; }
        public string TenTV { get => tenTV; set => tenTV = value; }
        public string DiaChi { get => diaChi; set => diaChi = value; }
        public bool GioiTinh { get => gioiTinh; set => gioiTinh = value; }
        public int SDT { get => soDT; set => soDT = value; }
        public string Email { get => email; set => email = value; }
    }
}
