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
    public partial class FormGV : Form
    {

        GiaoVienBUS bus = new GiaoVienBUS();
        GiaoVienDTO dto = new GiaoVienDTO();
        public FormGV()
        {
            InitializeComponent();
        }

        private void btnNhapLai_Click(object sender, EventArgs e)
        {
            txtDiaChi.Clear();
            txtMaGV.Clear();
            txtSDT.Clear();
            txtTenGV.Clear();
            txtMaGV.Focus();
        }

        private void btnXem_Click(object sender, EventArgs e)
        {
            gvCanBo.DataSource = bus.LoadDuLieu();
            comboBox1.Items.Add("Admin");
            comboBox1.Items.Add("Giảng viên");
            comboBox2.DataSource = bus.LoadDuLieuTrinhDo();
            comboBox2.DisplayMember = "TenTrinhDo";
            comboBox2.ValueMember = "MaTrinhDo";
        }

        private void FormGV_Load(object sender, EventArgs e)
        {
            btnXem_Click(sender, e);
        }

        private void gvCanBo_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            int dong = e.RowIndex;
            txtMaGV.Text = gvCanBo.Rows[dong].Cells["MaCanBoGiaoVien"].Value.ToString();
            txtTenGV.Text = gvCanBo.Rows[dong].Cells["HoTen"].Value.ToString();
            txtDiaChi.Text = gvCanBo.Rows[dong].Cells["DiaCHi"].Value.ToString();
            txtSDT.Text = gvCanBo.Rows[dong].Cells["SoDienThoai"].Value.ToString();
            txtTaiKhoan.Text = gvCanBo.Rows[dong].Cells["TaiKhoan"].Value.ToString();
            txtMatKhau.Text = gvCanBo.Rows[dong].Cells["MatKhau"].Value.ToString();
            comboBox1.Text = gvCanBo.Rows[dong].Cells["LoaiTaiKhoan"].Value.ToString();
            comboBox2.Text = gvCanBo.Rows[dong].Cells["TenTrinhDo"].Value.ToString();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            dto.MaCanBoGiaoVien = txtMaGV.Text;
            try
            {
                gvCanBo.DataSource = bus.TimKiem(dto.MaCanBoGiaoVien);
            }
            catch { }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            dto.MaCanBoGiaoVien = txtMaGV.Text;
            DialogResult kt = MessageBox.Show("Bạn có thực sự muốn xóa ??", "Kiểm tra", MessageBoxButtons.YesNo);
            if (kt == DialogResult.Yes)
            {
                try
                {
                    bus.Xoa(dto.MaCanBoGiaoVien);
                    MessageBox.Show("Xóa thành công");
                }
                catch
                {
                    MessageBox.Show("Lỗi khi xóa");
                }
            }
            btnXem_Click(sender, e);
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            dto.MaCanBoGiaoVien = txtMaGV.Text;
            dto.HoTen = txtTenGV.Text;
            dto.DiaChi = txtDiaChi.Text;
            dto.SoDienThoai = txtSDT.Text;
            dto.TaiKhoan = txtTaiKhoan.Text;
            dto.MatKhau = txtMatKhau.Text;
            dto.LoaiTaiKhoan = comboBox1.Text;
            dto.MaTrinhDo = comboBox2.SelectedValue + "";
            try
            {
                bus.Sua(dto.MaCanBoGiaoVien, dto.HoTen, dto.DiaChi, dto.SoDienThoai, dto.TaiKhoan, dto.MatKhau, dto.LoaiTaiKhoan, dto.MaTrinhDo);
                MessageBox.Show("Sửa thành công");
            }
            catch
            {
                MessageBox.Show("Lỗi khi sửa");
            }
            btnXem_Click(sender, e);
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            dto.MaCanBoGiaoVien = txtMaGV.Text;
            dto.HoTen = txtTenGV.Text;
            dto.DiaChi = txtDiaChi.Text;
            dto.SoDienThoai = txtSDT.Text;
            dto.TaiKhoan = txtTaiKhoan.Text;
            dto.MatKhau = txtMatKhau.Text;
            dto.LoaiTaiKhoan = comboBox1.Text;
            dto.MaTrinhDo = comboBox2.SelectedValue + "";
            try
            {
                bus.Them(dto.MaCanBoGiaoVien, dto.HoTen, dto.DiaChi, dto.SoDienThoai, dto.TaiKhoan, dto.MatKhau, dto.LoaiTaiKhoan, dto.MaTrinhDo);
                MessageBox.Show("Thêm thành công");
            }
            catch
            {
                MessageBox.Show("Lỗi khi thêm");
            }
            btnXem_Click(sender, e);
        
        }
    }
}
