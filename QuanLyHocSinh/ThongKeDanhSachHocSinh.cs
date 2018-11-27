using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
using DTO;

namespace QuanLyHocSinh
{
    public partial class ThongKeDanhSachHocSinh : Form
    {
        private String taiKhoan;
        public ThongKeDanhSachHocSinh(String taikhoan)
        {
                this.taiKhoan = taikhoan;
                InitializeComponent();
        }
        public ThongKeDanhSachHocSinh()
        {
            InitializeComponent();
        }
        LopHoc_BUS qlLopHoc = new LopHoc_BUS();
        private void HienFullDuLieu()
        {
            DataTable dt = new DataTable();
            LopHoc_BUS qlLopHoc = new LopHoc_BUS();
            dt = qlLopHoc.GetFullHocSinh();
            dgvHocsinh.DataSource = dt;
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                dgvHocsinh.Rows[i].Cells[0].Value = i + 1;
            }
        }
        private void HienDuLieuTheoLop(String maLop)
        {
            DataTable dt = new DataTable();  
            dt = qlLopHoc.GetHocSinhMotLop(maLop);
            dgvHocsinh.DataSource = dt;
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                dgvHocsinh.Rows[i].Cells[0].Value = i + 1;
            }
        }
        private void ThongKeDanhSachHocSinh_Load(object sender, EventArgs e)
        {
            QuanLyGiaoVien qlGiaoVien = new QuanLyGiaoVien();
            GiaoVienDTO giaoVien = new GiaoVienDTO();
            giaoVien = qlGiaoVien.GetInfoTaiKhoan(taiKhoan);
            txtNguoilap.Text = giaoVien.HoTen;
            String date = DateTime.Now.ToShortDateString();
            txtNgaylap.Text = date;
            txtNguoilap.Enabled = false;
            txtNgaylap.Enabled = false;
            cbLop.DataSource = qlLopHoc.GetLop();
            cbLop.DisplayMember = "TenLop";
            cbLop.ValueMember = "MaLop";
            HienFullDuLieu();
        }

        private void btnXem_Click(object sender, EventArgs e)
        {
            HienFullDuLieu();
        }

        private void cbLop_SelectionChangeCommitted(object sender, EventArgs e)
        {
            HienDuLieuTheoLop(cbLop.SelectedValue.ToString()); ;
        }
    }
}
