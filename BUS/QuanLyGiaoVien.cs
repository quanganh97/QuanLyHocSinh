using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DTO;
using DAL;

namespace BUS
{
    public class QuanLyGiaoVien
    {
        Data sqlData = new Data();
        //check loai tai khoan cua giao vien va trang thai dang nhap
        public bool CheckDangNhap(String taiKhoan, String matKhau)
        {
            String cmd = "select * from CanBoGiaoVien where TaiKhoan = '"+taiKhoan+"' COLLATE SQL_Latin1_General_CP1_CS_AS";
            DataTable dt = new DataTable();
            bool check = false;
            dt = sqlData.GetData(cmd);
            if (dt.Rows.Count != 0)
            {
                if (dt.Rows[0][5].ToString() == matKhau)
                {
                    check = true;
                }
            }
            return check;
        }
        //lay thong tin giao vien
        public GiaoVienDTO GetInfoTaiKhoan(String taiKhoan)
        {
            GiaoVienDTO gv = new GiaoVienDTO();
            String cmd = "select * from CanBoGiaoVien where TaiKhoan = '" + taiKhoan + "' COLLATE SQL_Latin1_General_CP1_CS_AS";
            DataTable dt = new DataTable();
            dt = sqlData.GetData(cmd);
            gv.MaCanBoGiaoVien = dt.Rows[0][0].ToString();
            gv.HoTen = dt.Rows[0][1].ToString();
            gv.TaiKhoan = dt.Rows[0][4].ToString();
            gv.MatKhau = dt.Rows[0][5].ToString();
            gv.LoaiTaiKhoan = dt.Rows[0][6].ToString();
            gv.MaTrinhDo = dt.Rows[0][7].ToString();
            return gv;
        }
        //cap nhap lai mat khau
        public void UpdateMatKhau(String taiKhoan, String MatKhauMoi)
        {
            String cmd = "update CanBoGiaoVien set MatKhau = '" + MatKhauMoi + "' where TaiKhoan = '" + taiKhoan + "' COLLATE SQL_Latin1_General_CP1_CS_AS";
            sqlData.NonQuery(cmd);
        }
    }
}
