using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using BUS;

namespace QuanLyHocSinh
{
    public partial class FormMain : Form
    {
        private String taiKhoan;
        QuanLyGiaoVien qlTaiKhoan = new QuanLyGiaoVien();
        public FormMain(String taiKhoan)
        {
            this.taiKhoan = taiKhoan;
            InitializeComponent();
        }
        private void FormMain_Load(object sender, EventArgs e)
        {
            GiaoVienDTO giaoVien = qlTaiKhoan.GetInfoTaiKhoan(taiKhoan);
            if (giaoVien.LoaiTaiKhoan == "Giáo viên")
            {
                mtrDanhMuc.Visible = false;
                mstrPhancong.Visible = false;
                mstrThongke.Visible = false;
            }
        }

        private void mstrDoimk_Click(object sender, EventArgs e)
        {
            DoiMatKhau frm = new DoiMatKhau(taiKhoan);
            frm.ShowDialog();
        }

        private void mstrThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void mstrLogout_Click(object sender, EventArgs e)
        {
            this.Close();
            DangNhap frm = new DangNhap();
            frm.Show();
        }

        private void mstrXemlich_Click(object sender, EventArgs e)
        {
            XemPhanCong frm = new XemPhanCong(taiKhoan);
            frm.Show();
            
        }

        private void mstrLaplich_Click(object sender, EventArgs e)
        {
            PhanCongGiangDay frm = new PhanCongGiangDay();
            frm.Show();
        }

        private void mstrLop_Click(object sender, EventArgs e)
        {
            FormLop frm = new FormLop();
            frm.Show();
        }

        private void mstrMon_Click(object sender, EventArgs e)
        {
            QuanLyMonHoc frm = new QuanLyMonHoc();
            frm.Show();
        }

        private void mstrHocsinh_Click(object sender, EventArgs e)
        {
            QuanLyHoSoHocSinh frm = new QuanLyHoSoHocSinh();
            frm.Show();
        }

        private void mstrGiaovien_Click(object sender, EventArgs e)
        {
            FormGV frm = new FormGV();
            frm.Show();
        }

        private void mstrDanhsachhs_Click(object sender, EventArgs e)
        {
            ThongKeDanhSachHocSinh frm = new ThongKeDanhSachHocSinh(taiKhoan);
            frm.Show();
        }

        private void mstrDanhsachgv_Click(object sender, EventArgs e)
        {
            ThongKeDanhSachCanBo frm = new ThongKeDanhSachCanBo(taiKhoan);
            frm.Show();
        }
    }
}
