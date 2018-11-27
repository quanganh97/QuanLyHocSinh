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
    public partial class PhanCongGiangDay : Form
    {
        public PhanCongGiangDay()
        {
            InitializeComponent();
        }
        QuanLyPhanCong phanCong = new QuanLyPhanCong();
        private void PhanCongGiangDay_Load(object sender, EventArgs e)
        {
            HienThiDuLieu();
            //load combobox
            cbLop.DataSource = phanCong.GetLopHoc();
            cbLop.DisplayMember = "TenLop";
            cbLop.ValueMember = "MaLop";
            cbMon.DataSource = phanCong.GetMonHoc();
            cbMon.DisplayMember = "TenMon";
            cbMon.ValueMember = "MaMon";
            cbGiaovien.DataSource = phanCong.GetGiaoVien();
            cbGiaovien.DisplayMember = "HoTen";
            cbGiaovien.ValueMember = "MaCanBoGiaoVien";
        }
        //hien du lieu
        public void HienThiDuLieu()
        {
            DataTable dt = new DataTable();
            dt = phanCong.GetSchedule();
            dgvPhancong.DataSource = dt;
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                dgvPhancong.Rows[i].Cells[0].Value = i + 1;
            }
        }
        //phan cong cong viec
        private void btnPhancong_Click(object sender, EventArgs e)
        {
            MessageBoxIcon warning = MessageBoxIcon.Warning;
            MessageBoxIcon info = MessageBoxIcon.Information;
            MessageBoxButtons ok = MessageBoxButtons.OK;
            MessageBoxButtons yesNo = MessageBoxButtons.YesNo;
            PhanCongDTO item = 
                new PhanCongDTO(cbLop.SelectedValue.ToString(), 
                    cbMon.SelectedValue.ToString(), 
                    cbGiaovien.SelectedValue.ToString(), 
                    dtNgay.Value);
            if (phanCong.CheckExitsts(item))
            {
                DialogResult result = MessageBox.Show("Lịch đã tồn tại! \nBạn vẫn muốn phân công!", "Cảnh báo", yesNo, warning);
                if (result == DialogResult.Yes)
                {
                    phanCong.UpdateNewDate(item);
                    MessageBox.Show("Sửa thành công!", "Thông báo", ok, info);
                }
            }
            else if (phanCong.CheckDoubleSchedule(item))
            {
                DialogResult result = MessageBox.Show("Đã có giáo viên khác cho lớp này.\n Tiếp tục ghi đè!", "Cảnh báo", yesNo, warning);
                if (result == DialogResult.Yes)
                {
                    phanCong.UpdateNewGiaoVien(item);
                    MessageBox.Show("Sửa thành công!", "Thông báo", ok, info);
                }
            }
            else
            { 
                phanCong.AddSchedule(item);
                MessageBox.Show("Thêm thành công!", "Thông báo", ok, info);
            }
            HienThiDuLieu();
        }
        //update 
        private void btnSua_Click(object sender, EventArgs e)
        {
            MessageBoxIcon warning = MessageBoxIcon.Warning;
            MessageBoxIcon info = MessageBoxIcon.Information;
            MessageBoxButtons ok = MessageBoxButtons.OK;
            MessageBoxButtons yesNo = MessageBoxButtons.YesNo;
            PhanCongDTO item =
            new PhanCongDTO(cbLop.SelectedValue.ToString(),
                cbMon.SelectedValue.ToString(),
                cbGiaovien.SelectedValue.ToString(),
                dtNgay.Value);
            try
            {
                if (!phanCong.CheckExitsts(item))
                {
                    MessageBox.Show("Không tìn thấy lịch trình cần sửa!", "Cảnh báo", ok, warning);
                }
                else if (phanCong.CheckDoubleSchedule(item))
                {
                    DialogResult result = MessageBox.Show("Đã có giáo viên khác cho lớp này. \nVẫn tiếp tục ghi đè", "Cảnh báo", yesNo, warning);
                    if (result == DialogResult.Yes)
                    {
                        phanCong.UpdateNewGiaoVien(item);
                        MessageBox.Show("Sửa thành công!", "Thông báo", ok, info);
                        HienThiDuLieu();
                    }
                }
                else
                {
                    phanCong.UpdateNewDate(item);
                    MessageBox.Show("Sửa thành công!", "Thông báo", ok, info);
                    HienThiDuLieu();
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Lịch đã tồn tại! \nkhông thể thêm hai lần!", "Cảnh báo", ok, warning);
            }
        }
        //xoa 1 lich trinh

        //chon 1 dong
        private void dgvPhancong_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            cbLop.Text = dgvPhancong.Rows[index].Cells[1].Value.ToString();
            cbMon.Text = dgvPhancong.Rows[index].Cells[2].Value.ToString();
            cbGiaovien.Text = dgvPhancong.Rows[index].Cells[4].Value.ToString();
            dtNgay.Value = DateTime.Parse(dgvPhancong.Rows[index].Cells[5].Value.ToString());
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            PhanCongDTO item =
            new PhanCongDTO(cbLop.SelectedValue.ToString(),
            cbMon.SelectedValue.ToString(),
            cbGiaovien.SelectedValue.ToString(),
            dtNgay.Value);
            if (!phanCong.CheckExitsts(item))
            {
                MessageBox.Show("Không tìn thấy lịch trình cần xóa!", "Cảnh báo", MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
            else
            {
                phanCong.DeleteSchedule(item);
                MessageBox.Show("Xóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                HienThiDuLieu();
            }
        }

    }
}
