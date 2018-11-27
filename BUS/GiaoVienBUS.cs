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
    public class GiaoVienBUS
    {
        Data d = new Data();
        public DataTable LoadDuLieu()
        {
            string rowquery = "Select MaCanBoGiaoVien,HoTen,DiaCHi,SoDienThoai,TaiKhoan,MatKhau,LoaiTaiKhoan,TenTrinhDo from CanBoGiaoVien inner join TrinhDo on " +
            "CanBoGiaoVien.MaTrinhDo = TrinhDo.MaTrinhDo";
            DataTable dt = new DataTable();
            dt = d.GetData(rowquery);
            return dt;
        }

        public DataTable LoadDuLieuTrinhDo()
        {
            string rowquery = "Select MaTrinhDo, TenTrinhDo from TrinhDo";
            DataTable dt = new DataTable();
            dt = d.GetData(rowquery);
            return dt;
        }

        public void Them(string MaCanBoGiaoVien, string HoTen, string DiaCHi, string SoDienThoai,
            string TaiKhoan, string MatKhau, string LoaiTaiKhoan, string MaTrinhDo)
        {
            string rowquery = "Insert into CanBoGiaoVien values('" + MaCanBoGiaoVien + "',N'" + HoTen +
                "',N' " + DiaCHi + "','" + SoDienThoai + "',' " + TaiKhoan + "','" + MatKhau + "', " +
                   "N'" + LoaiTaiKhoan + "','" + MaTrinhDo + "')";
            d.NonQuery(rowquery);
        }

        public void Sua(string MaCanBoGiaoVien, string HoTen, string DiaCHi, string SoDienThoai,string TaiKhoan, string MatKhau, string LoaiTaiKhoan, string MaTrinhDo)
        {
            string rowquery = "Update CanBoGiaoVien set HoTen = N'" + HoTen + "' , DiaCHi = N'" + DiaCHi +
                "' , SoDienThoai = '" + SoDienThoai + "' , TaiKhoan = '" + TaiKhoan + "' , MatKhau = '"
                + MatKhau + "' , LoaiTaiKhoan = N'" + LoaiTaiKhoan + "' , MaTrinhDo = '" + MaTrinhDo +
                "'Where MaCanBoGiaoVien = '" + MaCanBoGiaoVien + "'";
            d.NonQuery(rowquery);
        }

        public void Xoa(string MaCanBoGiaoVien)
        {
            string rowquery = "Delete From CanBoGiaoVien Where MaCanBoGiaoVien = '" + MaCanBoGiaoVien + "'";
            d.NonQuery(rowquery);
        }

        public DataTable TimKiem(string MaCanBoGiaoVien)
        {
            string rowquery = "Select MaCanBoGiaoVien,HoTen,DiaCHi,SoDienThoai,TaiKhoan," +
            "MatKhau,LoaiTaiKhoan,TenTrinhDo from CanBoGiaoVien inner join TrinhDo on " +
            "CanBoGiaoVien.MaTrinhDo = TrinhDo.MaTrinhDo Where MaCanBoGiaoVien = '" + MaCanBoGiaoVien + "'";
            DataTable dt = new DataTable();
            dt = d.GetData(rowquery);
            return dt;
        }
    }
}
