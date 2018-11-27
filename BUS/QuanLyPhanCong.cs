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
    
    public class QuanLyPhanCong
    {
        //Du lieu phan cong
        public DataTable GetSchedule()
        {
            DataTable dt = new DataTable();
            Data sqldata = new Data();
            String cmd = 
                "select TenLop, TenMon, SoTiet, HoTen, NgayPhanCong"+ 
                " from PhanCongGiangDay inner join Lop"+
                " on PhanCongGiangDay.MaLop = Lop.MaLop inner join MonHoc"+
                " on PhanCongGiangDay.MaMon = MonHoc.MaMon inner join CanBoGiaoVien"+
                " on PhanCongGiangDay.MaCanBoGiaoVien = CanBoGiaoVien.MaCanBoGiaoVien";
            dt = sqldata.GetData(cmd);
            return dt;
        }
        //Get schedule in condittion
        public DataTable GetScheduleInCondition(int indexOfcondition, String value)
        {
            DataTable dt = new DataTable();
            Data sqldata = new Data();
            String condittion = "where ";
            if (indexOfcondition == 0)
            {
                condittion += "PhanCongGiangDay.MaLop = '" + value + "'";
            }
            else if (indexOfcondition == 1)
            {
                condittion += "PhanCongGiangDay.MaMon = '" + value + "'";
            }
            else
            {
                condittion += "PhanCongGiangDay.MaCanBoGiaoVien = '" + value + "'";
            }
            String cmd =
                "select TenLop, TenMon, SoTiet, HoTen, NgayPhanCong" +
                " from PhanCongGiangDay inner join Lop" +
                " on PhanCongGiangDay.MaLop = Lop.MaLop inner join MonHoc" +
                " on PhanCongGiangDay.MaMon = MonHoc.MaMon inner join CanBoGiaoVien" +
                " on PhanCongGiangDay.MaCanBoGiaoVien = CanBoGiaoVien.MaCanBoGiaoVien " + condittion;
            dt = sqldata.GetData(cmd);
            return dt;
        }
        //display mon hoc in combobox
        public DataTable GetMonHoc()
        {
            DataTable dt = new DataTable();
            Data sqldata = new Data();
            String cmd = "select * from MonHoc";
            dt = sqldata.GetData(cmd);
            return dt;
        }
        //display lop hoc in combobox
        public DataTable GetLopHoc()
        {
            DataTable dt = new DataTable();
            Data sqldata = new Data();
            String cmd = "select MaLop, TenLop from Lop";
            dt = sqldata.GetData(cmd);
            return dt;
        }
        //display giao vien in combobox
        public DataTable GetGiaoVien()
        {
            DataTable dt = new DataTable();
            Data sqldata = new Data();
            String cmd = "select MaCanBoGiaoVien, HoTen from CanBoGiaoVien";
            dt = sqldata.GetData(cmd);
            return dt;
        }
        //check phan cong
        //in case double key value
        public Boolean CheckExitsts(PhanCongDTO lich)
        {
            Data sqldata = new Data();
            DataTable dt = new DataTable();
            String cmd = "select * from PhanCongGiangDay"+
            " where MaLop = '"+lich.MaLop+"' and MaMon = '"+lich.MaMon+"' and MaCanBoGiaoVien = '"+lich.MaCanBoGiaoVien+"'";
            dt = sqldata.GetData(cmd);
            if(dt.Rows.Count == 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        //in case double teacher in a mission
        public Boolean CheckDoubleSchedule(PhanCongDTO lich)
        {
            Data sqldata = new Data();
            DataTable dt = new DataTable();
            String date = String.Format("{0:MM/dd/yyyy}", lich.NgayPhanCong);
            String cmd = "select * from PhanCongGiangDay" +
            " where MaLop = '" + lich.MaLop + "' and MaMon = '" + lich.MaMon + "' and NgayPhanCong = '" + date + "'";
            dt = sqldata.GetData(cmd);
            int n = dt.Rows.Count;
            if (dt.Rows.Count == 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        //them phan cong
        public void AddSchedule(PhanCongDTO lich)
        {
            Data sqldata = new Data();
            String date = String.Format("{0:MM/dd/yyyy}", lich.NgayPhanCong);
            String cmd = 
                "insert into PhanCongGiangDay "+
                "values('"+lich.MaLop+"','"+lich.MaMon+"','"+lich.MaCanBoGiaoVien+"','"+date+"')";
            sqldata.NonQuery(cmd);
        }
        //update phan cong
        //update make a new date
        public void UpdateNewDate(PhanCongDTO lich)
        {
            Data sqldata = new Data();
            String date = String.Format("{0:MM/dd/yyyy}", lich.NgayPhanCong);
            String cmd = 
                "update PhanCongGiangDay set NgayPhanCong = '"+date+"'"+
                " where MaLop = '"+lich.MaLop+"' and MaMon = '"+lich.MaMon+"' and MaCanBoGiaoVien = '"+lich.MaCanBoGiaoVien+"'";
            sqldata.NonQuery(cmd);
        }
        //update another teacher instead
        public void UpdateNewGiaoVien(PhanCongDTO lich)
        {
            Data sqldata = new Data();
            String date = String.Format("{0:MM/dd/yyyy}", lich.NgayPhanCong);
            String cmdDelete = 
                "Delete from PhanCongGiangDay "+
                "where MaLop = '" + lich.MaLop + "' and MaMon = '" + lich.MaMon + "' and NgayPhanCong = '" + date + "' and MaCanBoGiaoVien !='"+lich.MaCanBoGiaoVien+"'";
            String cmdUpdate = 
                "update PhanCongGiangDay set MaCanBoGiaoVien = '"+lich.MaCanBoGiaoVien+"' "+
                "where MaLop = '" + lich.MaLop + "' and MaMon = '" + lich.MaMon + "' and NgayPhanCong = '" + date + "'";
            if (!CheckExitsts(lich))
            {
                AddSchedule(lich);
            }
            sqldata.NonQuery(cmdDelete);
            sqldata.NonQuery(cmdUpdate);
        }
        //Xoa phan cong
        public void DeleteSchedule(PhanCongDTO lich)
        {
            Data sqldata = new Data();
            String cmd = 
                "delete from PhanCongGiangDay "+
                "where MaLop = '"+lich.MaLop+"' and "+
                "MaMon = '"+lich.MaMon+"' and "+
                "MaCanBoGiaoVien = '"+lich.MaCanBoGiaoVien+"'";
            sqldata.NonQuery(cmd);
        }
    }
}
