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
    public partial class FormLop : Form
    {
        LopDTO dto = new LopDTO();
        LopHocBUS bus = new LopHocBUS();
        public FormLop()
        {
            InitializeComponent();
        }

        private void btnNhapLai_Click(object sender, EventArgs e)
        {
            txtMaLop.Clear();
            txtNiemKhoa.Clear();
            txtSiSo.Clear();
            txtTenLop.Clear();
            txtMaLop.Focus();
        }

        private void btnXem_Click(object sender, EventArgs e)
        {
            gvLop.DataSource = bus.LoadDuLieu();
            for (int i = 0; i < gvLop.RowCount ; i++)
            {
                gvLop.Rows[i].Cells[0].Value = i + 1;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btnXem_Click(sender, e);
            comboBox1.DataSource = bus.LoadDuLieuGV();
            comboBox1.DisplayMember = "HoTen";
            comboBox1.ValueMember = "MaCanBoGiaoVien";
        }

        private void gvLop_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            int dong = e.RowIndex;
            txtMaLop.Text = gvLop.Rows[dong].Cells[1].Value.ToString();
            txtTenLop.Text = gvLop.Rows[dong].Cells[2].Value.ToString();
            txtNiemKhoa.Text = gvLop.Rows[dong].Cells[3].Value.ToString();
            txtSiSo.Text = gvLop.Rows[dong].Cells[4].Value.ToString();
            comboBox1.Text = gvLop.Rows[dong].Cells[5].Value.ToString();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            dto.MaLop = txtMaLop.Text;
            dto.TenLop = txtTenLop.Text;
            dto.NienKhoa = txtNiemKhoa.Text;
            dto.SiSo = Int32.Parse(txtSiSo.Text);
            dto.GiaoVienChuNhiem = comboBox1.Text;
            try
            {
                bus.Them(dto.MaLop, dto.TenLop, dto.NienKhoa, dto.SiSo.ToString(), dto.GiaoVienChuNhiem);
                MessageBox.Show("Thêm thành công");
            }
            catch
            {
                MessageBox.Show("lỗi khi thêm dữ liệu");
            }
            btnXem_Click(sender, e);
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            dto.MaLop = txtMaLop.Text;
            dto.TenLop = txtTenLop.Text;
            dto.NienKhoa = txtNiemKhoa.Text;
            dto.SiSo = Int32.Parse(txtSiSo.Text);
            dto.GiaoVienChuNhiem = comboBox1.Text;
            try
            {
                bus.Sua(dto.MaLop, dto.TenLop, dto.NienKhoa, dto.SiSo.ToString(), dto.GiaoVienChuNhiem);
                MessageBox.Show("Sửa thành công");
            }
            catch
            {
                MessageBox.Show("Lỗi khi sửa dữ liệu");
            }
            btnXem_Click(sender, e);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            dto.MaLop = txtMaLop.Text;
            DialogResult kt = MessageBox.Show("Bạn có thực sự muốn xóa thông tin này không ??", "Bạn có chắc chắn", MessageBoxButtons.YesNo);
            if (kt == DialogResult.Yes)
            {
                try
                {
                    bus.Xoa(dto.MaLop);
                    MessageBox.Show("Xóa thành công");
                }
                catch
                {
                    MessageBox.Show("Lỗi khi xóa dữ liệu");
                }
            }
            btnXem_Click(sender, e);
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            dto.MaLop = txtMaLop.Text;
            try
            {
                gvLop.DataSource = bus.TimKiem(dto.MaLop);
                for (int i = 0; i < gvLop.RowCount; i++)
                {
                    gvLop.Rows[i].Cells[0].Value = i + 1;
                }
            }
            catch
            {
                MessageBox.Show("Tìm kiếm thất bại");
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
