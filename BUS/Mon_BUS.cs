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
    public class Mon_BUS
    {
        Data da = new Data();
        HocSinh_DTO L = new HocSinh_DTO();
        public DataTable ShowMonHoc()
        {
            string sql = "select * from MonHoc";
            DataTable dt = new DataTable();
            dt = da.GetData(sql);
            return dt;
        }
        public void InsertMonHoc(string mm,string tm, int st)
        {
            string sql = "insert MonHoc values(N'" + mm + "',N'" + tm + "',N'" + st + "')";
            da.NonQuery(sql);
        }
        public void UploadMonHoc(string mm,string tm,int st)
        {
            string sql = "update MonHoc set TenMon=N'" + tm + "',SoTiet=N'" + st + "' where MaMon=N'" + mm + "'";
            da.NonQuery(sql);
        }
        public void DeleteMonHoc(string mm)
        {
            string sql = "delete MonHoc where MaMon=N'" + mm + "'";
            da.NonQuery(sql);
        }
        public DataTable LookMonHoc(string dk)
        {
            string sql = "select *from MonHoc where MaMon like N'%" + dk + "%' OR TenMon like N'%" + dk + "%'";
            DataTable dt = new DataTable();
            dt = da.GetData(sql);
            return dt;
        }
    }
}
