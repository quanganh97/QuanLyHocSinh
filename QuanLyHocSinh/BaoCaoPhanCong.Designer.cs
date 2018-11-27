namespace QuanLyHocSinh
{
    partial class BaoCaoPhanCong
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BaoCaoPhanCong));
            this.rpPhanCong = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // rpPhanCong
            // 
            this.rpPhanCong.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rpPhanCong.LocalReport.ReportEmbeddedResource = "QuanLyHocSinh.reports.GiangDayTheoLop.rdlc";
            this.rpPhanCong.Location = new System.Drawing.Point(0, 0);
            this.rpPhanCong.MinimumSize = new System.Drawing.Size(824, 461);
            this.rpPhanCong.Name = "rpPhanCong";
            this.rpPhanCong.Size = new System.Drawing.Size(824, 461);
            this.rpPhanCong.TabIndex = 0;
            // 
            // BaoCaoPhanCong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(824, 461);
            this.Controls.Add(this.rpPhanCong);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(840, 500);
            this.Name = "BaoCaoPhanCong";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Báo cáo phân công";
            this.Load += new System.EventHandler(this.BaoCaoPhanCong_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rpPhanCong;




    }
}