using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;
using DAL;
using DTO;
using BUS;

namespace QuanLyHocSinh
{
    public partial class BaoCaoPhanCong : Form
    {
        private String taiKhoan;
        private String keyDieuKien;
        private String valueDieuKien;
        private int loai;
        public BaoCaoPhanCong(String taikhoan, String keydieukien, String valuedieukien, int loai)
        {
            this.taiKhoan = taikhoan;
            this.keyDieuKien = keydieukien;
            this.valueDieuKien = valuedieukien;
            this.loai = loai;
            InitializeComponent();
        }
        public BaoCaoPhanCong()
        {
            InitializeComponent();
        }

        private void BaoCaoPhanCong_Load(object sender, EventArgs e)
        {
            //get can bo giao vien lap bao ca
            QuanLyGiaoVien qlGiaoVien = new QuanLyGiaoVien();
            GiaoVienDTO giaoVien = new GiaoVienDTO();
            giaoVien = qlGiaoVien.GetInfoTaiKhoan(taiKhoan);
            //tao string truy van co so du lieu
            String cmd = "select * from ViewPhanCong ";
            String loaiBaoCao = "";
            switch (loai)
            {
                case 1: 
                    cmd += "where MaMon = '" + keyDieuKien +"'"; 
                    loaiBaoCao = "Lịch giảng dạy môn : " + valueDieuKien; 
                    break;
                case 2:
                    cmd += "where MaLop = '" + keyDieuKien + "'";
                    loaiBaoCao = "Lịch giảng dạy lớp : " + valueDieuKien + "'";
                    break;
                case 3:
                    cmd += "where MaCanBoGiaoVien = '" + keyDieuKien + "'";
                    loaiBaoCao = "Lịch giảng dạy giáo viên : " + valueDieuKien;
                    break;
            }
            //tao dataset
            DataSet DataSet = new DataSet();
            Data sqldata = new Data();
            DataSet = sqldata.GetDataSet(cmd);
            rpPhanCong.ProcessingMode = Microsoft.Reporting.WinForms.ProcessingMode.Local;
            //add datasource
            if (DataSet.Tables[0].Rows.Count > 0)
            {
                //add datasource
                ReportDataSource rpds = new ReportDataSource();
                rpds.Name = "DataSet";
                rpds.Value = DataSet.Tables[0];
                rpPhanCong.LocalReport.DataSources.Clear();
                rpPhanCong.LocalReport.DataSources.Add(rpds);
                rpPhanCong.RefreshReport();

                //Them parameter
                ReportParameter rpTennv = new ReportParameter("DoiTuong", giaoVien.HoTen);
                rpPhanCong.LocalReport.SetParameters(rpTennv);
                rpPhanCong.RefreshReport();
                ReportParameter rpLoaiBaoCao = new ReportParameter("LoaiBaoCao", loaiBaoCao);
                rpPhanCong.LocalReport.SetParameters(rpLoaiBaoCao);
            }
            else
            {
                //khi khong co ban ghi nao de xu ly
                MessageBox.Show("Không có bản ghi nào!", "Thông báo");
            }
        }
    }
}
