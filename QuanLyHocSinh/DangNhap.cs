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
    public partial class DangNhap : Form
    {
        QuanLyGiaoVien quanLyGv = new QuanLyGiaoVien();
        public DangNhap()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            MessageBoxIcon failed = MessageBoxIcon.Warning;
            MessageBoxIcon success = MessageBoxIcon.Information;
            MessageBoxButtons button = MessageBoxButtons.OK;
            bool check = quanLyGv.CheckDangNhap(txtTaikhoan.Text,txtMatkhau.Text);
            if (txtTaikhoan.Text == "")
            {
                MessageBox.Show("Tài khoản không được bỏ trông!","Cảnh báo",button,failed);
            }
            else if (txtMatkhau.Text == "")
            {
                MessageBox.Show("Mật khẩu không được bỏ trông!", "Cảnh báo", button, failed);
            }
            else if (check == false)
            {
                MessageBox.Show("tài khoản hoặc mật khẩu không chính xác!", "Cảnh báo", button, failed);
            }
            else
            {
                if (check == true)
                {
                    MessageBox.Show("Đăng nhập thành công!", "Thông báo", button, success);
                    FormMain frm = new FormMain(txtTaikhoan.Text);
                    frm.Show();
                    this.Hide();
                }
            }
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
