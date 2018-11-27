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

namespace QuanLyHocSinh
{
    public partial class XemPhanCong : Form
    {
        private String taiKhoan;
        public XemPhanCong(String taikhoan)
        {
            this.taiKhoan = taikhoan;
            InitializeComponent();
        }
        public XemPhanCong()
        {
            InitializeComponent();
        }
        QuanLyPhanCong phanCong = new QuanLyPhanCong();
        private void XemPhanCong_Load(object sender, EventArgs e)
        {
            cbGiaovien.DataSource = phanCong.GetGiaoVien();
            cbGiaovien.DisplayMember = "HoTen";
            cbGiaovien.ValueMember = "MaCanBoGiaoVien";
            cbLop.DataSource = phanCong.GetLopHoc();
            cbLop.DisplayMember = "TenLop";
            cbLop.ValueMember = "MaLop";
            cbMon.DataSource = phanCong.GetMonHoc();
            cbMon.DisplayMember = "TenMon";
            cbMon.ValueMember = "MaMon";
            
            rdAll.Checked = true;
            lblScope.Text = "";
            MakeView(-1,null);
        }
        private void MakeView(int index, String value)
        {
            DataTable dt = new DataTable();
            if (index == -1)
            {
                dt = phanCong.GetSchedule();  
            }
            else
            {
                dt = phanCong.GetScheduleInCondition(index, value);
            }
            dgvDanhsach.DataSource = dt;
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                dgvDanhsach.Rows[i].Cells[0].Value = i + 1;
            }     
        }
        private void cbMon_SelectionChangeCommitted(object sender, EventArgs e)
        {
            rdMon.Checked = true;
        }
        private void cbLop_SelectionChangeCommitted(object sender, EventArgs e)
        {
            rdLop.Checked = true;
        }
        private void cbGiaovien_SelectionChangeCommitted(object sender, EventArgs e)
        {
            rdGiaovien.Checked = true;
        }
        private void btnLoc_Click(object sender, EventArgs e)
        {
            int conditionIndex = -1;
            String conditionValue = "";
            if(rdMon.Checked == true)
            {
                conditionIndex = 1;
                conditionValue = cbMon.SelectedValue.ToString();
                lblScope.Text = "môn : "+cbMon.Text;
            }
            else if (rdLop.Checked == true)
            {
                conditionIndex = 0;
                conditionValue = cbLop.SelectedValue.ToString();
                lblScope.Text = "lớp : "+cbLop.Text;
            }
            else if (rdGiaovien.Checked == true)
            {
                conditionIndex = 2;
                conditionValue = cbGiaovien.SelectedValue.ToString();
                lblScope.Text = "giáo viên : "+cbGiaovien.Text;
            }
            MakeView(conditionIndex, conditionValue);
        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            String keyDieuKien = "";
            String valueDieuKien = "";
            int loai = 0;
            if(rdMon.Checked == true){
                keyDieuKien = cbMon.SelectedValue.ToString();
                valueDieuKien = cbMon.Text;
                loai = 1;
            }else if(rdLop.Checked == true){
                keyDieuKien = cbLop.SelectedValue.ToString();
                valueDieuKien = cbLop.Text;
                loai = 2;
            }else if(rdGiaovien.Checked == true){
                keyDieuKien = cbGiaovien.SelectedValue.ToString();
                valueDieuKien = cbGiaovien.Text;
                loai = 3;
            }
            BaoCaoPhanCong frm = new BaoCaoPhanCong(taiKhoan, keyDieuKien, valueDieuKien, loai);
            frm.Show();
        }
    }
}
