using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using DTO;
using BUS;

namespace QuanLyHocSinh
{
    public partial class QuanLyHoSoHocSinh : Form
    {
        public QuanLyHoSoHocSinh()
        {
            InitializeComponent();
        }
        HocSinh_DTO L = new HocSinh_DTO();
        HocSinh_BUS hshocsinh = new HocSinh_BUS();

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dgvhshs.DataSource = hshocsinh.ShowHoSoHocSinh();
        }

        private void dgvhshs_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            for (int i = 0; i < dgvhshs.RowCount; i++)
                dgvhshs.Rows[i].Cells[0].Value = i + 1;
        }

        private void dgvhshs_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            int dong = e.RowIndex;
            txtmhs.Text = dgvhshs.Rows[dong].Cells["MaHocSinh"].Value.ToString();
            txtht.Text = dgvhshs.Rows[dong].Cells["HoTen"].Value.ToString();
            txtns.Text = dgvhshs.Rows[dong].Cells["NgaySinh"].Value.ToString();
            txtdc.Text = dgvhshs.Rows[dong].Cells["DiaChi"].Value.ToString();
            txtd.Text = dgvhshs.Rows[dong].Cells["DiemVaoTruong"].Value.ToString();
            txthtbm.Text = dgvhshs.Rows[dong].Cells["HoTenBoMe"].Value.ToString();
            txtsdt.Text = dgvhshs.Rows[dong].Cells["SoDienThoai"].Value.ToString();
            txtml.Text = dgvhshs.Rows[dong].Cells["MaLop"].Value.ToString();
        }

        private void btn_nhaplai_Click(object sender, EventArgs e)
        {
            txtmhs.Clear();
            txtht.Clear();
            txtns.Clear();
            txtdc.Clear();
            txtd.Clear();
            txthtbm.Clear();
            txtsdt.Clear();
            txtml.Clear();
            txtmhs.Focus();
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            if (txtmhs.TextLength == 0)
                MessageBox.Show("Mã học sinh không được để trống");
            else if (txtht.TextLength == 0)
                MessageBox.Show("họ tên không được để trống");
            else if (txtns.TextLength == 0)
                MessageBox.Show("ngày sinh không được để trống");
            else if (txtdc.TextLength == 0)
                MessageBox.Show("địa chỉ không được để trống");
            else if (txtd.TextLength == 0)
                MessageBox.Show("điểm k được bổ trống");
            else if (txthtbm.TextLength == 0)
                MessageBox.Show("họ tên bố mẹ không được để trống");
            else if (txtsdt.TextLength == 0)
                MessageBox.Show("số điện thoại không được để trống");
            else if (txtml.TextLength == 0)
                MessageBox.Show("mã lớp không được để trống");
            else
            {
                try
                {
                    L.Mahs = txtmhs.Text;
                    L.HoTen = txtht.Text;
                    L.NgaySinh = txtns.Text;
                    L.DiaChi = txtdc.Text;
                    L.Diem = Int32.Parse(txtd.Text);
                    L.HoTenBM = txthtbm.Text;
                    L.SoDT = Int32.Parse(txtsdt.Text);
                    L.MaLop = txtml.Text;
                    if (radioButton1.Checked == true)
                    {
                        L.GioiTinh = "Nam";
                    }
                    if (radioButton2.Checked == true)
                    {
                        L.GioiTinh = "Nu";
                    }
                    hshocsinh.InsertHoSoHocSinh(L.Mahs, L.HoTen, L.NgaySinh,L.GioiTinh, L.DiaChi, L.Diem, L.HoTenBM, L.SoDT, L.MaLop);
                    MessageBox.Show("Đã thêm thành công");
                    Form1_Load(sender, e);

                }
                catch { MessageBox.Show("Có lỗi!!!"); }
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                radioButton2.Checked = false;
            }
            if (radioButton2.Checked == true)
            {
                radioButton1.Checked = false;
            }
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            if (txtmhs.TextLength == 0)
                MessageBox.Show("Mã học sinh không được để trống");
            else if (txtht.TextLength == 0)
                MessageBox.Show("họ tên không được để trống");
            else if (txtns.TextLength == 0)
                MessageBox.Show("ngày sinh không được để trống");
            else if (txtdc.TextLength == 0)
                MessageBox.Show("địa chỉ không được để trống");
            else if (txtd.TextLength == 0)
                MessageBox.Show("điểm k được bổ trống");
            else if (txthtbm.TextLength == 0)
                MessageBox.Show("họ tên bố mẹ không được để trống");
            else if (txtsdt.TextLength == 0)
                MessageBox.Show("số điện thoại không được để trống");
            else if (txtml.TextLength == 0)
                MessageBox.Show("mã lớp không được để trống");
            else
            {
                try
                {
                    L.Mahs = txtmhs.Text;
                    L.HoTen = txtht.Text;
                    L.NgaySinh = txtns.Text;
                    L.DiaChi = txtdc.Text;
                    L.Diem = Int32.Parse(txtd.Text);
                    L.HoTenBM = txthtbm.Text;
                    L.SoDT = Int32.Parse(txtsdt.Text);
                    L.MaLop = txtml.Text;
                    if (radioButton1.Checked == true)
                    {
                        L.GioiTinh = "Nam";
                    }
                    if (radioButton2.Checked == true)
                    {
                        L.GioiTinh = "Nu";
                    }
                    hshocsinh.UpdateHoSoHocSinh(L.Mahs, L.HoTen, L.NgaySinh,L.GioiTinh, L.DiaChi, L.Diem, L.HoTenBM, L.SoDT, L.MaLop);
                    MessageBox.Show("Đã sửa thành công");
                    Form1_Load(sender, e);

                }
                catch { MessageBox.Show("Có lỗi!!!"); }
            }
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            if (txtmhs.TextLength == 0)
                MessageBox.Show("Bạn cần chọn mã học sinh để xóa");
            else
                L.Mahs = txtmhs.Text;
            hshocsinh.DeleteHoSoHocSinh(L.Mahs);
            MessageBox.Show("Đã xóa thành công");
            Form1_Load(sender, e);

        }

        private void btn_xem_Click(object sender, EventArgs e)
        {
            Form1_Load(sender, e);
        }

        private void btn_tim_Click(object sender, EventArgs e)
        {
            if (txttim.TextLength == 0)
                MessageBox.Show("Bạn chưa nhập từ khóa tìm kiếm");
            else if (txttim.TextLength != 0)
                MessageBox.Show("Không có học sinh bạn tìm");
            else
            {
                dgvhshs.DataSource = hshocsinh.LookHoSoHocSinh(txttim.Text);
            }
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

