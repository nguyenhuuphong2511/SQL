using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyThuVien.DTO
{
    public class TacGia
    {
        private string maTG;
        private string tenTG;
        public TacGia(DataRow row)
        {

            this.MaTG = row["MaTG"].ToString();
            this.TenTG = row["TenTG"].ToString();

        }
        public string MaTG { get => maTG; set => maTG = value; }
        public string TenTG { get => tenTG; set => tenTG = value; }
    }
}
