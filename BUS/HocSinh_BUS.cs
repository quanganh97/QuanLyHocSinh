using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using DTO;
using DAL;

namespace BUS
{
    public class HocSinh_BUS
    {
        Data da = new Data();
        HocSinh_DTO L = new HocSinh_DTO();
        public DataTable ShowHoSoHocSinh()
        {
            string sql = "select *from HoSoHocSinh";
            DataTable dt = new DataTable();
            dt = da.GetData(sql);
            return dt;
        }
        public void InsertHoSoHocSinh(string mhs,string ht,string ns, string gt,string dc,int diem , string htbm,int sdt, string ml)
        {
            string sql = "insert HoSoHocSinh values(N'" + mhs + "',N'" + ht + "',N'" + ns + "',N'" + gt + "',N'" + dc + "',N'" + diem + "',N'" + htbm + "',N'" + sdt + "',N'" + ml + "')";
            da.NonQuery(sql);
        }
        public void UpdateHoSoHocSinh(string mhs,string ht,string ns,string gt,string dc, int diem,string htbm,int sdt, string ml )
        {
            string sql = "update HoSoHocSinh set HoTen=N'" + ht + "',NgaySinh=N'" + ns + "',GioiTinh=N'" + gt + "',DiaChi=N'" + dc + "',DiemVaoTruong=N'" + diem + "',HoTenBoMe=N'" + htbm + "',SoDienThoai=N'" + sdt + "', MaLop=N'" + ml + "' Where MaHocSinh=N'" + mhs + "'";
            da.NonQuery(sql);
        }
        public void DeleteHoSoHocSinh(string mhs)
        {
            string sql = "delete HoSoHocSinh where MaHocSinh=N'" + mhs + "'";
            da.NonQuery(sql);
        }
        public DataTable LookHoSoHocSinh(string dk)
        {
            string sql = "select *from HoSoHocSinh where MaHocSinh like N'%" + dk + "%' OR MaLop like N'%" + dk + "%'";
            DataTable dt = new DataTable();
            dt = da.GetData(sql);
            return dt;
        }
    }
}
