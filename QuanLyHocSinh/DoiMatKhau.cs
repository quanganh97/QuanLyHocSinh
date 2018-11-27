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
    public partial class DoiMatKhau : Form
    {
        private String taiKhoan;
        public DoiMatKhau(String tk)
        {
            this.taiKhoan = tk;
            InitializeComponent();
        }
        GiaoVienDTO giaoVien = new GiaoVienDTO();
        QuanLyGiaoVien qlTaiKhoan;
        private void DoiMatKhau_Load(object sender, EventArgs e)
        {
             qlTaiKhoan = new QuanLyGiaoVien();  
             giaoVien = qlTaiKhoan.GetInfoTaiKhoan(taiKhoan);
        }
        private void btnDoi_Click(object sender, EventArgs e)
        {
            MessageBoxIcon failed = MessageBoxIcon.Warning;
            MessageBoxIcon success = MessageBoxIcon.Information;
            MessageBoxButtons button = MessageBoxButtons.OK;
            if (txtMatkhaucu.Text == "")
            {
                MessageBox.Show("Mật khẩu không được bỏ trống!", "Cảnh báo", button, failed);
            }
            else if (txtMatkhaumoi.Text == "")
            {
                MessageBox.Show("Mật khẩu mới không được bỏ trông!", "Cảnh báo", button, failed);
            }
            else if (txtXacnhan.Text == "")
            {
                MessageBox.Show("Xác nhận mật khẩu không được bỏ trống không được bỏ trông!", "Cảnh báo", button, failed);
            }
            else if (txtMatkhaucu.Text != giaoVien.MatKhau)
            {
                MessageBox.Show("Mật khẩu cũ không chính xác!", "Cảnh báo", button, failed);
            }
            else if(txtMatkhaumoi.Text == giaoVien.MatKhau)
            {
                MessageBox.Show("Mật khẩu mới phải khác mật khẩu cũ!", "Cảnh báo", button, failed);
            }
            else if (txtXacnhan.Text != txtMatkhaumoi.Text)
            {
                MessageBox.Show("Xác nhận mật khẩu không chính xác!", "Cảnh báo", button, failed);
            }
            else if (!checkHopLe(txtMatkhaumoi.Text))
            {
                MessageBox.Show("Mật khẩu không được chứa kí tự trắng!", "Cảnh báo", button, failed);
            }
            else
            {
                MessageBox.Show("Đổi thành công!", "Thông báo", button, success);
                qlTaiKhoan.UpdateMatKhau(taiKhoan, txtMatkhaumoi.Text);
            }
        }
        private bool checkHopLe(String chuoi)
        {
            chuoi = chuoi.Trim();
            if (chuoi.Contains(" "))
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private void btnLammoi_Click(object sender, EventArgs e)
        {
            txtMatkhaucu.Text = "";
            txtMatkhaumoi.Text = "";
            txtXacnhan.Text = "";
        }
    }
}
