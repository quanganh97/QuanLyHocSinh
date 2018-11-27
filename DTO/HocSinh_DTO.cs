using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class HocSinh_DTO
    {
        string Mahs_;
        string HoTen_;
        string NgaySinh_;
        string GioiTinh_;
        string DiaChi_;
        string HoTenBM_;
        string MaLop_;
        int Diem_;
        int SoDT_;
        public string Mahs
        { get { return Mahs_; } set { Mahs_ = value; } }
        public string HoTen
        { get { return HoTen_; } set { HoTen_ = value; } }
        public string NgaySinh
        { get { return NgaySinh_; } set { NgaySinh_ = value; } }
        public string GioiTinh
        { get { return GioiTinh_; } set { GioiTinh_ = value; } }
        public string DiaChi
        { get { return DiaChi_; } set { DiaChi_ = value; } }
        public string HoTenBM
        { get { return HoTenBM_; } set { HoTenBM_ = value; } }
        public string MaLop
        { get { return MaLop_; } set { MaLop_ = value; } }
        public int Diem
        { get { return Diem_; } set { Diem_ = value; } }
        public int SoDT
        { get { return SoDT_; } set { SoDT_ = value; } }

    }
}
