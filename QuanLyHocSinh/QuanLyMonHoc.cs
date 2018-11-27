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
    public partial class QuanLyMonHoc : Form
    {
        public QuanLyMonHoc()
        {
            InitializeComponent();
        }
        Mon_DTO L = new Mon_DTO();
        Mon_BUS mhoc = new Mon_BUS();

        private void Form1_Load(object sender, EventArgs e)
        {
            dgvMonHoc.DataSource = mhoc.ShowMonHoc();
        }

        private void dgvmonhoc_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            for (int i = 0; i < dgvMonHoc.RowCount; i++)
                dgvMonHoc.Rows[i].Cells[0].Value = i + 1;
        }

        private void dgvmonhoc_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            int dong = e.RowIndex;
            txtmm.Text = dgvMonHoc.Rows[dong].Cells[1].Value.ToString();
            txttm.Text = dgvMonHoc.Rows[dong].Cells[2].Value.ToString();
            txtst.Text = dgvMonHoc.Rows[dong].Cells[3].Value.ToString();
        }

        private void btn_nhaplai_Click(object sender, EventArgs e)
        {
            txtmm.Clear();
            txttm.Clear();
            txtst.Clear();
            txtmm.Focus();
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            if (txtmm.TextLength == 0)
                MessageBox.Show("mã môn không được để trống");
            else if (txttm.TextLength == 0)
                MessageBox.Show("tên môn không được để trống");
            else if (txtst.TextLength == 0)
                MessageBox.Show("số tiết không được để trống");
            else
            {
                try
                {
                    L.MaMon = txtmm.Text; L.TenMon = txttm.Text; L.SoTiet = Int32.Parse(txtst.Text);
                    mhoc.InsertMonHoc(L.MaMon, L.TenMon, L.SoTiet);
                    MessageBox.Show("đã thêm thành công");
                    Form1_Load(sender, e);

                }
                catch { MessageBox.Show("có lỗi!!!"); }   }
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            if (txtmm.TextLength == 0)
                MessageBox.Show("mã môn không được bỏ trống");
            else if (txttm.TextLength == 0)
                MessageBox.Show("tên môn không được bỏ trống");
            else if (txtst.TextLength == 0)
                MessageBox.Show("số tiết không được bỏ trống");
            else
            {
                try
                {
                    L.MaMon = txtmm.Text;
                    L.TenMon = txttm.Text;
                    L.SoTiet = Int32.Parse(txtst.Text);
                    mhoc.UploadMonHoc(L.MaMon, L.TenMon, L.SoTiet);
                    MessageBox.Show("đã chỉnh sửa thành công");
                    Form1_Load(sender, e);

                }
                catch { MessageBox.Show("Có Lỗi!!!!!"); }
            }
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            if (txtmm.TextLength == 0)
                MessageBox.Show("Bạn cần chọn mã môn để xóa");
            else
                L.MaMon = txtmm.Text;
            mhoc.DeleteMonHoc(L.MaMon);
            MessageBox.Show("Đã xóa thành công");
            Form1_Load(sender, e);
        }

        private void btn_tim_Click(object sender, EventArgs e)
        {
           if(txttk.TextLength==0)
               MessageBox.Show("bạn chưa nhập từ khóa tìm kiếm");
            else
            {
                dgvMonHoc.DataSource=mhoc.LookMonHoc(txttk.Text);
            }
        }

        private void btn_xem_Click(object sender, EventArgs e)
        {
            Form1_Load(sender, e);
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
