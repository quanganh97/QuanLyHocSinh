namespace QuanLyHocSinh
{
    partial class XemPhanCong
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(XemPhanCong));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbMon = new System.Windows.Forms.ComboBox();
            this.cbGiaovien = new System.Windows.Forms.ComboBox();
            this.cbLop = new System.Windows.Forms.ComboBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.rdAll = new System.Windows.Forms.RadioButton();
            this.btnIn = new System.Windows.Forms.Button();
            this.btnLoc = new System.Windows.Forms.Button();
            this.rdGiaovien = new System.Windows.Forms.RadioButton();
            this.rdMon = new System.Windows.Forms.RadioButton();
            this.rdLop = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.lblScope = new System.Windows.Forms.Label();
            this.ngay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.giaovien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sotiet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.monhoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lop = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvDanhsach = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhsach)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên môn học";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tên lớp";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Tên Giáo viên";
            // 
            // cbMon
            // 
            this.cbMon.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cbMon.FormattingEnabled = true;
            this.cbMon.Location = new System.Drawing.Point(119, 20);
            this.cbMon.Name = "cbMon";
            this.cbMon.Size = new System.Drawing.Size(169, 21);
            this.cbMon.TabIndex = 1;
            this.cbMon.SelectionChangeCommitted += new System.EventHandler(this.cbMon_SelectionChangeCommitted);
            // 
            // cbGiaovien
            // 
            this.cbGiaovien.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cbGiaovien.FormattingEnabled = true;
            this.cbGiaovien.Location = new System.Drawing.Point(119, 106);
            this.cbGiaovien.Name = "cbGiaovien";
            this.cbGiaovien.Size = new System.Drawing.Size(169, 21);
            this.cbGiaovien.TabIndex = 2;
            this.cbGiaovien.SelectionChangeCommitted += new System.EventHandler(this.cbGiaovien_SelectionChangeCommitted);
            // 
            // cbLop
            // 
            this.cbLop.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cbLop.FormattingEnabled = true;
            this.cbLop.Location = new System.Drawing.Point(119, 62);
            this.cbLop.Name = "cbLop";
            this.cbLop.Size = new System.Drawing.Size(169, 21);
            this.cbLop.TabIndex = 1;
            this.cbLop.SelectionChangeCommitted += new System.EventHandler(this.cbLop_SelectionChangeCommitted);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.splitContainer1.Location = new System.Drawing.Point(26, 26);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.splitContainer1.Panel1.Controls.Add(this.cbGiaovien);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1.Controls.Add(this.cbLop);
            this.splitContainer1.Panel1.Controls.Add(this.label3);
            this.splitContainer1.Panel1.Controls.Add(this.cbMon);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.splitContainer1.Panel2.Controls.Add(this.rdAll);
            this.splitContainer1.Panel2.Controls.Add(this.btnIn);
            this.splitContainer1.Panel2.Controls.Add(this.btnLoc);
            this.splitContainer1.Panel2.Controls.Add(this.rdGiaovien);
            this.splitContainer1.Panel2.Controls.Add(this.rdMon);
            this.splitContainer1.Panel2.Controls.Add(this.rdLop);
            this.splitContainer1.Size = new System.Drawing.Size(634, 153);
            this.splitContainer1.SplitterDistance = 322;
            this.splitContainer1.TabIndex = 3;
            // 
            // rdAll
            // 
            this.rdAll.AutoSize = true;
            this.rdAll.Location = new System.Drawing.Point(34, 51);
            this.rdAll.Name = "rdAll";
            this.rdAll.Size = new System.Drawing.Size(112, 17);
            this.rdAll.TabIndex = 7;
            this.rdAll.TabStop = true;
            this.rdAll.Text = "Không giàng buộc";
            this.rdAll.UseVisualStyleBackColor = true;
            // 
            // btnIn
            // 
            this.btnIn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnIn.Location = new System.Drawing.Point(167, 79);
            this.btnIn.Name = "btnIn";
            this.btnIn.Size = new System.Drawing.Size(100, 43);
            this.btnIn.TabIndex = 5;
            this.btnIn.Text = "In danh sách";
            this.btnIn.UseVisualStyleBackColor = true;
            this.btnIn.Click += new System.EventHandler(this.btnIn_Click);
            // 
            // btnLoc
            // 
            this.btnLoc.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnLoc.Location = new System.Drawing.Point(34, 79);
            this.btnLoc.Name = "btnLoc";
            this.btnLoc.Size = new System.Drawing.Size(100, 43);
            this.btnLoc.TabIndex = 5;
            this.btnLoc.Text = "Lọc danh sách";
            this.btnLoc.UseVisualStyleBackColor = true;
            this.btnLoc.Click += new System.EventHandler(this.btnLoc_Click);
            // 
            // rdGiaovien
            // 
            this.rdGiaovien.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.rdGiaovien.AutoSize = true;
            this.rdGiaovien.Location = new System.Drawing.Point(197, 24);
            this.rdGiaovien.Name = "rdGiaovien";
            this.rdGiaovien.Size = new System.Drawing.Size(70, 17);
            this.rdGiaovien.TabIndex = 5;
            this.rdGiaovien.TabStop = true;
            this.rdGiaovien.Text = "Giáo viên";
            this.rdGiaovien.UseVisualStyleBackColor = true;
            // 
            // rdMon
            // 
            this.rdMon.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.rdMon.AutoSize = true;
            this.rdMon.Location = new System.Drawing.Point(113, 24);
            this.rdMon.Name = "rdMon";
            this.rdMon.Size = new System.Drawing.Size(67, 17);
            this.rdMon.TabIndex = 4;
            this.rdMon.TabStop = true;
            this.rdMon.Text = "Môn học";
            this.rdMon.UseVisualStyleBackColor = true;
            // 
            // rdLop
            // 
            this.rdLop.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.rdLop.AutoSize = true;
            this.rdLop.Location = new System.Drawing.Point(34, 24);
            this.rdLop.Name = "rdLop";
            this.rdLop.Size = new System.Drawing.Size(64, 17);
            this.rdLop.TabIndex = 3;
            this.rdLop.TabStop = true;
            this.rdLop.Text = "Lớp học";
            this.rdLop.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 193);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(130, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Lich phân công giảng dạy";
            // 
            // lblScope
            // 
            this.lblScope.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblScope.AutoSize = true;
            this.lblScope.Location = new System.Drawing.Point(151, 193);
            this.lblScope.Name = "lblScope";
            this.lblScope.Size = new System.Drawing.Size(35, 13);
            this.lblScope.TabIndex = 5;
            this.lblScope.Text = "label5";
            // 
            // ngay
            // 
            this.ngay.DataPropertyName = "NgayPhanCong";
            this.ngay.HeaderText = "Ngày phân công";
            this.ngay.Name = "ngay";
            this.ngay.Width = 120;
            // 
            // giaovien
            // 
            this.giaovien.DataPropertyName = "HoTen";
            this.giaovien.HeaderText = "Giáo Viên";
            this.giaovien.Name = "giaovien";
            this.giaovien.Width = 120;
            // 
            // sotiet
            // 
            this.sotiet.DataPropertyName = "SoTiet";
            this.sotiet.HeaderText = "Số tiết";
            this.sotiet.Name = "sotiet";
            this.sotiet.Width = 70;
            // 
            // monhoc
            // 
            this.monhoc.DataPropertyName = "TenMon";
            this.monhoc.HeaderText = "Môn học";
            this.monhoc.Name = "monhoc";
            this.monhoc.Width = 120;
            // 
            // lop
            // 
            this.lop.DataPropertyName = "TenLop";
            this.lop.HeaderText = "Lớp học";
            this.lop.Name = "lop";
            this.lop.Width = 120;
            // 
            // stt
            // 
            this.stt.HeaderText = "STT";
            this.stt.Name = "stt";
            this.stt.Width = 40;
            // 
            // dgvDanhsach
            // 
            this.dgvDanhsach.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDanhsach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDanhsach.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.stt,
            this.lop,
            this.monhoc,
            this.sotiet,
            this.giaovien,
            this.ngay});
            this.dgvDanhsach.Location = new System.Drawing.Point(27, 209);
            this.dgvDanhsach.Name = "dgvDanhsach";
            this.dgvDanhsach.Size = new System.Drawing.Size(632, 189);
            this.dgvDanhsach.TabIndex = 6;
            // 
            // XemPhanCong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(685, 410);
            this.Controls.Add(this.dgvDanhsach);
            this.Controls.Add(this.lblScope);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.splitContainer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(700, 449);
            this.Name = "XemPhanCong";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Xem phân công";
            this.Load += new System.EventHandler(this.XemPhanCong_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhsach)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbMon;
        private System.Windows.Forms.ComboBox cbGiaovien;
        private System.Windows.Forms.ComboBox cbLop;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button btnIn;
        private System.Windows.Forms.Button btnLoc;
        private System.Windows.Forms.RadioButton rdGiaovien;
        private System.Windows.Forms.RadioButton rdMon;
        private System.Windows.Forms.RadioButton rdLop;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblScope;
        private System.Windows.Forms.RadioButton rdAll;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngay;
        private System.Windows.Forms.DataGridViewTextBoxColumn giaovien;
        private System.Windows.Forms.DataGridViewTextBoxColumn sotiet;
        private System.Windows.Forms.DataGridViewTextBoxColumn monhoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn lop;
        private System.Windows.Forms.DataGridViewTextBoxColumn stt;
        private System.Windows.Forms.DataGridView dgvDanhsach;
    }
}