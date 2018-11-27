using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;
using System.Data;

namespace BUS
{
    public class LopHocBUS
    {
        Data d = new Data();
        public DataTable LoadDuLieu()
        {
            string rowquery = "Select * From Lop";
            DataTable dt = new DataTable();
            dt = d.GetData(rowquery);
            return dt;
        }

        public DataTable LoadDuLieuGV()
        {
            string rowquery = "Select MaCanBoGiaoVien,HoTen From CanBoGiaoVien";
            DataTable dt = new DataTable();
            dt = d.GetData(rowquery);
            return dt;
        }

        public void Them(string MaLop, string TenLop, string NiemKhoa, string SiSo, string GiaoVienChuNhiem)
        {
            string rowquery = "Insert into Lop values('" + MaLop + "',N'" + TenLop + "',' " + NiemKhoa + "'," + Int32.Parse(SiSo) + ",N' " + GiaoVienChuNhiem + "')";
            d.NonQuery(rowquery);
        }

        public void Sua(string MaLop, string TenLop, string NienKhoa, string SiSo, string GiaoVienChuNhiem)
        {
            string rowquery = "Update Lop set TenLop = N'" + TenLop + "' , NienKhoa = '" + NienKhoa +
                "' , SiSo = '" + Int32.Parse(SiSo) + "' , GiaoVienChuNhiem = '" + GiaoVienChuNhiem +
                "' Where MaLop = '" + MaLop + "'";
            d.NonQuery(rowquery);
        }

        public void Xoa(string MaLop)
        {
            string rowquery = "Delete from Lop Where MaLop = '" + MaLop + "'";
            d.NonQuery(rowquery);
        }

        public DataTable TimKiem(string MaLop)
        {
            string rowquery = "Select * From Lop Where MaLop = '" + MaLop + "'";
            DataTable dt = new DataTable();
            dt = d.GetData(rowquery);
            return dt;
        }
    }
}
