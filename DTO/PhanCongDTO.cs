using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class PhanCongDTO
    {
        private String _MaLop;

        public String MaLop
        {
            get { return _MaLop; }
            set { _MaLop = value; }
        }
        private String _MaMon;

        public String MaMon
        {
            get { return _MaMon; }
            set { _MaMon = value; }
        }
        private String _MaCanBoGiaoVien;

        public String MaCanBoGiaoVien
        {
            get { return _MaCanBoGiaoVien; }
            set { _MaCanBoGiaoVien = value; }
        }
        private DateTime _NgayPhanCong;

        public DateTime NgayPhanCong
        {
            get { return _NgayPhanCong; }
            set { _NgayPhanCong = value; }
        }
        public PhanCongDTO()
        {

        }
        public PhanCongDTO(String mal, String mamon, String magv, DateTime ngay)
        {
            this.MaLop = mal;
            this.MaMon = mamon;
            this.MaCanBoGiaoVien = magv;
            this.NgayPhanCong = ngay;
        }
    }
}
