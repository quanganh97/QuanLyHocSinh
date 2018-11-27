namespace QuanLyHocSinh
{
    partial class PhanCongGiangDay
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PhanCongGiangDay));
            this.btnPhancong = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.dgvPhancong = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cbMon = new System.Windows.Forms.ComboBox();
            this.cbLop = new System.Windows.Forms.ComboBox();
            this.cbGiaovien = new System.Windows.Forms.ComboBox();
            this.dtNgay = new System.Windows.Forms.DateTimePicker();
            this.stt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenlop = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenmon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sotiet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tengv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhancong)).BeginInit();
            this.SuspendLayout();
            // 
            // btnPhancong
            // 
            this.btnPhancong.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnPhancong.Location = new System.Drawing.Point(465, 25);
            this.btnPhancong.Name = "btnPhancong";
            this.btnPhancong.Size = new System.Drawing.Size(75, 37);
            this.btnPhancong.TabIndex = 4;
            this.btnPhancong.Text = "Phân công";
            this.btnPhancong.UseVisualStyleBackColor = true;
            this.btnPhancong.Click += new System.EventHandler(this.btnPhancong_Click);
            // 
            // btnSua
            // 
            this.btnSua.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnSua.Location = new System.Drawing.Point(465, 79);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 37);
            this.btnSua.TabIndex = 5;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnXoa.Location = new System.Drawing.Point(465, 134);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 37);
            this.btnXoa.TabIndex = 6;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // dgvPhancong
            // 
            this.dgvPhancong.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvPhancong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPhancong.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.stt,
            this.tenlop,
            this.tenmon,
            this.sotiet,
            this.tengv,
            this.ngay});
            this.dgvPhancong.Location = new System.Drawing.Point(12, 207);
            this.dgvPhancong.Name = "dgvPhancong";
            this.dgvPhancong.Size = new System.Drawing.Size(615, 162);
            this.dgvPhancong.TabIndex = 4;
            this.dgvPhancong.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPhancong_CellContentClick);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 191);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Bảng phân công";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(109, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Môn học";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(111, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Lớp học";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(106, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Giáo viên";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(106, 157);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Ngày phân công";
            // 
            // cbMon
            // 
            this.cbMon.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cbMon.FormattingEnabled = true;
            this.cbMon.Location = new System.Drawing.Point(219, 71);
            this.cbMon.Name = "cbMon";
            this.cbMon.Size = new System.Drawing.Size(176, 21);
            this.cbMon.TabIndex = 0;
            // 
            // cbLop
            // 
            this.cbLop.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cbLop.FormattingEnabled = true;
            this.cbLop.Location = new System.Drawing.Point(219, 29);
            this.cbLop.Name = "cbLop";
            this.cbLop.Size = new System.Drawing.Size(176, 21);
            this.cbLop.TabIndex = 1;
            // 
            // cbGiaovien
            // 
            this.cbGiaovien.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cbGiaovien.FormattingEnabled = true;
            this.cbGiaovien.Location = new System.Drawing.Point(219, 112);
            this.cbGiaovien.Name = "cbGiaovien";
            this.cbGiaovien.Size = new System.Drawing.Size(176, 21);
            this.cbGiaovien.TabIndex = 2;
            // 
            // dtNgay
            // 
            this.dtNgay.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dtNgay.Location = new System.Drawing.Point(219, 151);
            this.dtNgay.Name = "dtNgay";
            this.dtNgay.Size = new System.Drawing.Size(176, 20);
            this.dtNgay.TabIndex = 3;
            // 
            // stt
            // 
            this.stt.HeaderText = "STT";
            this.stt.Name = "stt";
            this.stt.Width = 30;
            // 
            // tenlop
            // 
            this.tenlop.DataPropertyName = "TenLop";
            this.tenlop.HeaderText = "Tên lớp";
            this.tenlop.Name = "tenlop";
            this.tenlop.Width = 120;
            // 
            // tenmon
            // 
            this.tenmon.DataPropertyName = "TenMon";
            this.tenmon.HeaderText = "Tên môn";
            this.tenmon.Name = "tenmon";
            this.tenmon.Width = 120;
            // 
            // sotiet
            // 
            this.sotiet.DataPropertyName = "SoTiet";
            this.sotiet.HeaderText = "Số tiêt";
            this.sotiet.Name = "sotiet";
            this.sotiet.Width = 60;
            // 
            // tengv
            // 
            this.tengv.DataPropertyName = "HoTen";
            this.tengv.HeaderText = "Giáo viên";
            this.tengv.Name = "tengv";
            this.tengv.Width = 110;
            // 
            // ngay
            // 
            this.ngay.DataPropertyName = "NgayPhanCong";
            this.ngay.HeaderText = "Ngày phân công";
            this.ngay.Name = "ngay";
            this.ngay.Width = 120;
            // 
            // PhanCongGiangDay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(639, 381);
            this.Controls.Add(this.dtNgay);
            this.Controls.Add(this.cbGiaovien);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cbLop);
            this.Controls.Add(this.dgvPhancong);
            this.Controls.Add(this.cbMon);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnPhancong);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(655, 420);
            this.Name = "PhanCongGiangDay";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Phân công giảng dạy";
            this.Load += new System.EventHandler(this.PhanCongGiangDay_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhancong)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPhancong;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.DataGridView dgvPhancong;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbMon;
        private System.Windows.Forms.ComboBox cbLop;
        private System.Windows.Forms.ComboBox cbGiaovien;
        private System.Windows.Forms.DateTimePicker dtNgay;
        private System.Windows.Forms.DataGridViewTextBoxColumn stt;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenlop;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenmon;
        private System.Windows.Forms.DataGridViewTextBoxColumn sotiet;
        private System.Windows.Forms.DataGridViewTextBoxColumn tengv;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngay;
    }
}