using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class GiaoVienDTO
    {
        private String _MaCanBoGiaoVien;

        public String MaCanBoGiaoVien
        {
            get { return _MaCanBoGiaoVien; }
            set { _MaCanBoGiaoVien = value; }
        }
        private String _HoTen;

        public String HoTen
        {
            get { return _HoTen; }
            set { _HoTen = value; }
        }
        private String _DiaChi;

        public String DiaChi
        {
            get { return _DiaChi; }
            set { _DiaChi = value; }
        }
        private String _SoDienThoai;

        public String SoDienThoai
        {
            get { return _SoDienThoai; }
            set { _SoDienThoai = value; }
        }
        private String _TaiKhoan;

        public String TaiKhoan
        {
            get { return _TaiKhoan; }
            set { _TaiKhoan = value; }
        }
        private String _MatKhau;

        public String MatKhau
        {
            get { return _MatKhau; }
            set { _MatKhau = value; }
        }
        private String _LoaiTaiKhoan;

        public String LoaiTaiKhoan
        {
            get { return _LoaiTaiKhoan; }
            set { _LoaiTaiKhoan = value; }
        }
        private String _MaTrinhDo;

        public String MaTrinhDo
        {
            get { return _MaTrinhDo; }
            set { _MaTrinhDo = value; }
        }
        public GiaoVienDTO()
        {

        }
        public GiaoVienDTO(String magv, String ten, String diachi, String sdt, String tk, String mk, String loaitk, String matd)
        {
            this.MaCanBoGiaoVien = magv;
            this.HoTen = ten;
            this.DiaChi = diachi;
            this.SoDienThoai = sdt;
            this.MatKhau = mk;
            this.TaiKhoan = tk;
            this.LoaiTaiKhoan = loaitk;
            this.MaTrinhDo = matd;
        }
    }
}
