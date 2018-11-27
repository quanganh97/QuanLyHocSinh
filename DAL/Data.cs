using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class Data
    {
        static String connString = @"Data Source=.\sqlexpress;Initial Catalog=QuanLyHocSinh;Integrated Security=True";
        static SqlConnection con = new SqlConnection(connString);
        //tra ve bang
        public DataTable GetData(String cmd)
        {
            con.Open();
            DataTable dt = new DataTable();
            SqlDataAdapter ad = new SqlDataAdapter(cmd, con);
            ad.Fill(dt);
            con.Close();
            return dt;
        }
        //thuc hien cau lenh sql khung tra ve bang
        public void NonQuery(String sql) {
            con.Open();
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            cmd.Clone();
            con.Close();
        }
        public DataSet GetDataSet(String cmd)
        {
            con.Open();
            DataSet ds = new DataSet();
            SqlDataAdapter ad = new SqlDataAdapter(cmd, con);
            ad.Fill(ds);
            con.Close();
            return ds;
        }
    }
}
