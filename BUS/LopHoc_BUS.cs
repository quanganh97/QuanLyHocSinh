using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DAL;


namespace BUS
{
    public class LopHoc_BUS
    {
        Data da = new Data();
        //Lay full hoc sinh
        public DataTable GetFullHocSinh()
        {
            String
                cmd = "select MaHocSinh, HoSoHocSinh.HoTen, GioiTinh, DiaChi, HoTenBoMe, SoDienThoai " +
                "from HoSoHocSinh inner join Lop on HoSoHocSinh.MaLop = Lop.MaLop ";
            DataTable dt = new DataTable();
            dt = da.GetData(cmd);
            return dt;
        }
        //lay danh sach hoc sinh 1 lop
        public DataTable GetHocSinhMotLop(String maLop)
        {
            String
                cmd = "select MaHocSinh, HoSoHocSinh.HoTen, GioiTinh, DiaChi, HoTenBoMe, SoDienThoai " +
                "from HoSoHocSinh inner join Lop on HoSoHocSinh.MaLop = Lop.MaLop " + 
                "where HoSoHocSinh.MaLop = '"+maLop+"'";
            DataTable dt = new DataTable();
            dt = da.GetData(cmd);
            return dt;
        }
        
        //lay full danh sach giao vien
        public DataTable GetFullGiaoVien()
        {
            String
                cmd = "select PhanCongGiangDay.MaCanBoGiaoVien, HoTen, TenMon, NgayPhanCong, SoDienThoai " +
                "from PhanCongGiangDay inner join CanBoGiaoVien " +
                "on PhanCongGiangDay.MaCanBoGiaoVien = CanBoGiaoVien.MaCanBoGiaoVien " +
                "inner join MonHoc on PhanCongGiangDay.MaMon = MonHoc.MaMon ";
            DataTable dt = new DataTable();
            dt = da.GetData(cmd);
            return dt;
        }
        //lay danh sach giao vien mot lop
        public DataTable GetGiaoVienMotLop(String maLop)
        {
            String
                cmd = "select PhanCongGiangDay.MaCanBoGiaoVien, HoTen, TenMon, NgayPhanCong, SoDienThoai " +
                "from PhanCongGiangDay inner join CanBoGiaoVien " +
                "on PhanCongGiangDay.MaCanBoGiaoVien = CanBoGiaoVien.MaCanBoGiaoVien " +
                "inner join MonHoc on PhanCongGiangDay.MaMon = MonHoc.MaMon " +
                "where PhanCongGiangDay.MaLop = '" + maLop + "'";
            DataTable dt = new DataTable();
            dt = da.GetData(cmd);
            return dt;
        }
        //fill combobox Lop
        public DataTable GetLop()
        {
            String cmd = "select TenLop, MaLop from Lop";
            DataTable dt = new DataTable();
            dt = da.GetData(cmd);
            return dt;
        }
    }
}
