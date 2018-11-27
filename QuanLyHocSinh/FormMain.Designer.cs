namespace QuanLyHocSinh
{
    partial class FormMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.mstrTaiKhoan = new System.Windows.Forms.ToolStripMenuItem();
            this.mstrDoimk = new System.Windows.Forms.ToolStripMenuItem();
            this.mstrDangxuat = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.mstrThoat = new System.Windows.Forms.ToolStripMenuItem();
            this.mtrDanhMuc = new System.Windows.Forms.ToolStripMenuItem();
            this.mstrLop = new System.Windows.Forms.ToolStripMenuItem();
            this.mstrMon = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.mstrHocsinh = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            this.mstrGiaovien = new System.Windows.Forms.ToolStripMenuItem();
            this.mstrTrinhdo = new System.Windows.Forms.ToolStripMenuItem();
            this.mstrQuanlydiem = new System.Windows.Forms.ToolStripMenuItem();
            this.mstrNhapdiem = new System.Windows.Forms.ToolStripMenuItem();
            this.mstrSuadiem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripSeparator();
            this.mstrBaocaodiem = new System.Windows.Forms.ToolStripMenuItem();
            this.mstrPhancong = new System.Windows.Forms.ToolStripMenuItem();
            this.mstrLaplich = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripSeparator();
            this.mstrXemlich = new System.Windows.Forms.ToolStripMenuItem();
            this.mstrThongke = new System.Windows.Forms.ToolStripMenuItem();
            this.mstrDanhsachhs = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem6 = new System.Windows.Forms.ToolStripSeparator();
            this.mstrDanhsachgv = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mstrTaiKhoan,
            this.mtrDanhMuc,
            this.mstrQuanlydiem,
            this.mstrPhancong,
            this.mstrThongke});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(906, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip";
            // 
            // mstrTaiKhoan
            // 
            this.mstrTaiKhoan.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mstrDoimk,
            this.mstrDangxuat,
            this.toolStripMenuItem1,
            this.mstrThoat});
            this.mstrTaiKhoan.Name = "mstrTaiKhoan";
            this.mstrTaiKhoan.Size = new System.Drawing.Size(70, 20);
            this.mstrTaiKhoan.Text = "Tài khoản";
            // 
            // mstrDoimk
            // 
            this.mstrDoimk.Name = "mstrDoimk";
            this.mstrDoimk.Size = new System.Drawing.Size(145, 22);
            this.mstrDoimk.Text = "Đổi mật khẩu";
            this.mstrDoimk.Click += new System.EventHandler(this.mstrDoimk_Click);
            // 
            // mstrDangxuat
            // 
            this.mstrDangxuat.Name = "mstrDangxuat";
            this.mstrDangxuat.Size = new System.Drawing.Size(145, 22);
            this.mstrDangxuat.Text = "Đăng xuất";
            this.mstrDangxuat.Click += new System.EventHandler(this.mstrLogout_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(142, 6);
            // 
            // mstrThoat
            // 
            this.mstrThoat.Name = "mstrThoat";
            this.mstrThoat.Size = new System.Drawing.Size(145, 22);
            this.mstrThoat.Text = "Thoát";
            this.mstrThoat.Click += new System.EventHandler(this.mstrThoat_Click);
            // 
            // mtrDanhMuc
            // 
            this.mtrDanhMuc.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mstrLop,
            this.mstrMon,
            this.toolStripMenuItem2,
            this.mstrHocsinh,
            this.toolStripMenuItem3,
            this.mstrGiaovien,
            this.mstrTrinhdo});
            this.mtrDanhMuc.Name = "mtrDanhMuc";
            this.mtrDanhMuc.Size = new System.Drawing.Size(74, 20);
            this.mtrDanhMuc.Text = "Danh mục";
            // 
            // mstrLop
            // 
            this.mstrLop.Name = "mstrLop";
            this.mstrLop.Size = new System.Drawing.Size(188, 22);
            this.mstrLop.Text = "Quản lý lớp học";
            this.mstrLop.Click += new System.EventHandler(this.mstrLop_Click);
            // 
            // mstrMon
            // 
            this.mstrMon.Name = "mstrMon";
            this.mstrMon.Size = new System.Drawing.Size(188, 22);
            this.mstrMon.Text = "Quản lý môn học";
            this.mstrMon.Click += new System.EventHandler(this.mstrMon_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(185, 6);
            // 
            // mstrHocsinh
            // 
            this.mstrHocsinh.Name = "mstrHocsinh";
            this.mstrHocsinh.Size = new System.Drawing.Size(188, 22);
            this.mstrHocsinh.Text = "Quản lý học sinh";
            this.mstrHocsinh.Click += new System.EventHandler(this.mstrHocsinh_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(185, 6);
            // 
            // mstrGiaovien
            // 
            this.mstrGiaovien.Name = "mstrGiaovien";
            this.mstrGiaovien.Size = new System.Drawing.Size(188, 22);
            this.mstrGiaovien.Text = "Quản lý giáo viên";
            this.mstrGiaovien.Click += new System.EventHandler(this.mstrGiaovien_Click);
            // 
            // mstrTrinhdo
            // 
            this.mstrTrinhdo.Name = "mstrTrinhdo";
            this.mstrTrinhdo.Size = new System.Drawing.Size(188, 22);
            this.mstrTrinhdo.Text = "Trình độ chuyên môn";
            // 
            // mstrQuanlydiem
            // 
            this.mstrQuanlydiem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mstrNhapdiem,
            this.mstrSuadiem,
            this.toolStripMenuItem4,
            this.mstrBaocaodiem});
            this.mstrQuanlydiem.Name = "mstrQuanlydiem";
            this.mstrQuanlydiem.Size = new System.Drawing.Size(90, 20);
            this.mstrQuanlydiem.Text = "Quản lý điểm";
            // 
            // mstrNhapdiem
            // 
            this.mstrNhapdiem.Name = "mstrNhapdiem";
            this.mstrNhapdiem.Size = new System.Drawing.Size(146, 22);
            this.mstrNhapdiem.Text = "Nhập điểm";
            // 
            // mstrSuadiem
            // 
            this.mstrSuadiem.Name = "mstrSuadiem";
            this.mstrSuadiem.Size = new System.Drawing.Size(146, 22);
            this.mstrSuadiem.Text = "Sửa điểm";
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(143, 6);
            // 
            // mstrBaocaodiem
            // 
            this.mstrBaocaodiem.Name = "mstrBaocaodiem";
            this.mstrBaocaodiem.Size = new System.Drawing.Size(146, 22);
            this.mstrBaocaodiem.Text = "Báo cáo điểm";
            // 
            // mstrPhancong
            // 
            this.mstrPhancong.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mstrLaplich,
            this.toolStripMenuItem5,
            this.mstrXemlich});
            this.mstrPhancong.Name = "mstrPhancong";
            this.mstrPhancong.Size = new System.Drawing.Size(131, 20);
            this.mstrPhancong.Text = "Phân công giảng dạy";
            // 
            // mstrLaplich
            // 
            this.mstrLaplich.Name = "mstrLaplich";
            this.mstrLaplich.Size = new System.Drawing.Size(170, 22);
            this.mstrLaplich.Text = "Lập lịch giảng dạy";
            this.mstrLaplich.Click += new System.EventHandler(this.mstrLaplich_Click);
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(167, 6);
            // 
            // mstrXemlich
            // 
            this.mstrXemlich.Name = "mstrXemlich";
            this.mstrXemlich.Size = new System.Drawing.Size(170, 22);
            this.mstrXemlich.Text = "Xem phân công";
            this.mstrXemlich.Click += new System.EventHandler(this.mstrXemlich_Click);
            // 
            // mstrThongke
            // 
            this.mstrThongke.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mstrDanhsachhs,
            this.toolStripMenuItem6,
            this.mstrDanhsachgv});
            this.mstrThongke.Name = "mstrThongke";
            this.mstrThongke.Size = new System.Drawing.Size(69, 20);
            this.mstrThongke.Text = "Thống kê";
            // 
            // mstrDanhsachhs
            // 
            this.mstrDanhsachhs.Name = "mstrDanhsachhs";
            this.mstrDanhsachhs.Size = new System.Drawing.Size(180, 22);
            this.mstrDanhsachhs.Text = "Danh sách học sinh";
            this.mstrDanhsachhs.Click += new System.EventHandler(this.mstrDanhsachhs_Click);
            // 
            // toolStripMenuItem6
            // 
            this.toolStripMenuItem6.Name = "toolStripMenuItem6";
            this.toolStripMenuItem6.Size = new System.Drawing.Size(177, 6);
            // 
            // mstrDanhsachgv
            // 
            this.mstrDanhsachgv.Name = "mstrDanhsachgv";
            this.mstrDanhsachgv.Size = new System.Drawing.Size(180, 22);
            this.mstrDanhsachgv.Text = "Danh sách giáo viên";
            this.mstrDanhsachgv.Click += new System.EventHandler(this.mstrDanhsachgv_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(906, 518);
            this.Controls.Add(this.menuStrip);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip;
            this.MinimumSize = new System.Drawing.Size(666, 557);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý học sinh";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem mstrTaiKhoan;
        private System.Windows.Forms.ToolStripMenuItem mstrDoimk;
        private System.Windows.Forms.ToolStripMenuItem mstrDangxuat;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem mstrThoat;
        private System.Windows.Forms.ToolStripMenuItem mtrDanhMuc;
        private System.Windows.Forms.ToolStripMenuItem mstrLop;
        private System.Windows.Forms.ToolStripMenuItem mstrMon;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem mstrHocsinh;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem mstrGiaovien;
        private System.Windows.Forms.ToolStripMenuItem mstrTrinhdo;
        private System.Windows.Forms.ToolStripMenuItem mstrQuanlydiem;
        private System.Windows.Forms.ToolStripMenuItem mstrNhapdiem;
        private System.Windows.Forms.ToolStripMenuItem mstrSuadiem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem mstrBaocaodiem;
        private System.Windows.Forms.ToolStripMenuItem mstrPhancong;
        private System.Windows.Forms.ToolStripMenuItem mstrLaplich;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem5;
        private System.Windows.Forms.ToolStripMenuItem mstrXemlich;
        private System.Windows.Forms.ToolStripMenuItem mstrThongke;
        private System.Windows.Forms.ToolStripMenuItem mstrDanhsachhs;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem6;
        private System.Windows.Forms.ToolStripMenuItem mstrDanhsachgv;

    }
}