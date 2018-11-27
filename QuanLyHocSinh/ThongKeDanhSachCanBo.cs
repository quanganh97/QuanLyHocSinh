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
    public partial class ThongKeDanhSachCanBo : Form
    {
        private String taiKhoan;
        public ThongKeDanhSachCanBo (String taikhoan)
	    {
             this.taiKhoan = taikhoan;
             InitializeComponent();
	    }
        public ThongKeDanhSachCanBo()
        {
            InitializeComponent();
        }
        LopHoc_BUS qlLopHoc = new LopHoc_BUS();
        private void ThongKeDanhSachGiaoVien_Load(object sender, EventArgs e)
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
        private void HienFullDuLieu()
        {
            DataTable dt = new DataTable();
            dt = qlLopHoc.GetFullGiaoVien();
            dgvGiaovien.DataSource = dt;
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                dgvGiaovien.Rows[i].Cells[0].Value = i + 1;
            }
        }
        private void HienDuLieuTheoLop(String maLop)
        {
            DataTable dt = new DataTable();
            dt = qlLopHoc.GetGiaoVienMotLop(maLop);
            dgvGiaovien.DataSource = dt;
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                dgvGiaovien.Rows[i].Cells[0].Value = i + 1;
            }
        }

        private void cbLop_SelectionChangeCommitted(object sender, EventArgs e)
        {
            HienDuLieuTheoLop(cbLop.SelectedValue.ToString());
        }

        private void btnXem_Click(object sender, EventArgs e)
        {
            HienFullDuLieu();
        }
    }
}
