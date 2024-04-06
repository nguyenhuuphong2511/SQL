using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyThuVien.DTO
{
    public class Sach
    {
        private string maSach;
        private string tenSach;
        private string tenLoai;
        //private string maLoai;
        //private string maTG;
        private string tenTG;
        private string nhaXB;
        private int soLuong;

        public Sach(DataRow row) {
            this.MaSach = row["MaSach"].ToString();
            this.TenSach = row["TenSach"].ToString();
            //this.MaLoai = row["MaLoai"].ToString();
            //this.MaTG = row["MaTG"].ToString();
            this.NhaXB = row["NhaXB"].ToString();
            this.SoLuong = (int)row["SoLuong"];
            this.TenTG = row["TenTG"].ToString();
            this.TenLoai = row["TenLoai"].ToString();
        }

       

        public Sach(string maSach, string tenSach, string maLoai, string maTG, string nhaXB, int soLuong)
        {
            this.maSach = maSach;
            this.tenSach = tenSach;
            //this.maLoai = maLoai;
            //this.maTG = maTG;
            this.nhaXB = nhaXB;
            this.soLuong = soLuong;
        }
        public string MaSach
        {
            get { return maSach; }
            set { maSach = value; }
        }
        
        public string TenSach {
            get { return tenSach; }
            set { tenSach = value; }
        }
        //public string MaLoai {
        //    get { return maLoai; }
        //    set { maLoai = value; }
        //}
        //public string MaTG {
        //    get { return maTG; }
        //    set { maTG = value; }
        //}
        public string NhaXB {
            get { return nhaXB; }
            set { nhaXB = value; }
        }

        public string TenLoai
        {
            get { return tenLoai; }
            set { tenLoai = value; }
        }
        public string TenTG
        {
            get { return tenTG; }
            set { tenTG = value; }
        }
        public int SoLuong
        {
            get { return soLuong; }
            set { soLuong = value; }
        }
    }
}
