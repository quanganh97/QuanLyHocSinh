using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class LopDTO
    {
        private String _MaLop;

        public String MaLop
        {
            get { return _MaLop; }
            set { _MaLop = value; }
        }
        private String _TenLop;

        public String TenLop
        {
            get { return _TenLop; }
            set { _TenLop = value; }
        }
        private String _NienKhoa;

        public String NienKhoa
        {
            get { return _NienKhoa; }
            set { _NienKhoa = value; }
        }
        private int _SiSo;

        public int SiSo
        {
            get { return _SiSo; }
            set { _SiSo = value; }
        }
        private String _GiaoVienChuNhiem;

        public String GiaoVienChuNhiem
        {
            get { return _GiaoVienChuNhiem; }
            set { _GiaoVienChuNhiem = value; }
        }
        public LopDTO()
        {

        }
        public LopDTO(String malop, String tenlop, String khoa, int siso, String gv)
        {
            this.MaLop = malop;
            this.TenLop = tenlop;
            this.NienKhoa = NienKhoa;
            this.SiSo = siso;
            this.GiaoVienChuNhiem = gv;
        }
    }
}
