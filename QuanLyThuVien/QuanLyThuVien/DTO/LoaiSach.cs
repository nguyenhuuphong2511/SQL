using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyThuVien.DTO
{
    public class LoaiSach
    {
        private string maLoai;
        private string tenLoai;

        public LoaiSach(DataRow row)
        {
         
            this.MaLoai = row["MaLoai"].ToString();
            this.TenLoai = row["TenLoai"].ToString();

        }

        public string MaLoai { get => maLoai; set => maLoai = value; }
        public string TenLoai { get => tenLoai; set => tenLoai = value; }
    }
}
