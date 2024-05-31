namespace GUI.Form_Giao_Dien
{
    partial class frmBaoCao
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
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.btnKhoiPhuc = new GUI.DesignButton();
            this.btnSaoLuu = new GUI.DesignButton();
            this.btnReportDiem = new GUI.DesignButton();
            this.btnReportSinhVien = new GUI.DesignButton();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.reportViewer1.Location = new System.Drawing.Point(2, 53);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1141, 594);
            this.reportViewer1.TabIndex = 0;
            // 
            // btnKhoiPhuc
            // 
            this.btnKhoiPhuc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnKhoiPhuc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(218)))), ((int)(((byte)(208)))));
            this.btnKhoiPhuc.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(218)))), ((int)(((byte)(208)))));
            this.btnKhoiPhuc.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnKhoiPhuc.BorderRadius = 30;
            this.btnKhoiPhuc.BorderSize = 0;
            this.btnKhoiPhuc.FlatAppearance.BorderSize = 0;
            this.btnKhoiPhuc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKhoiPhuc.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKhoiPhuc.ForeColor = System.Drawing.Color.Black;
            this.btnKhoiPhuc.Location = new System.Drawing.Point(1019, 5);
            this.btnKhoiPhuc.Name = "btnKhoiPhuc";
            this.btnKhoiPhuc.Size = new System.Drawing.Size(113, 39);
            this.btnKhoiPhuc.TabIndex = 6;
            this.btnKhoiPhuc.Text = "Khôi phục";
            this.btnKhoiPhuc.TextColor = System.Drawing.Color.Black;
            this.btnKhoiPhuc.UseVisualStyleBackColor = false;
            this.btnKhoiPhuc.Click += new System.EventHandler(this.btnKhoiPhuc_Click);
            // 
            // btnSaoLuu
            // 
            this.btnSaoLuu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSaoLuu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(218)))), ((int)(((byte)(208)))));
            this.btnSaoLuu.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(218)))), ((int)(((byte)(208)))));
            this.btnSaoLuu.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnSaoLuu.BorderRadius = 30;
            this.btnSaoLuu.BorderSize = 0;
            this.btnSaoLuu.FlatAppearance.BorderSize = 0;
            this.btnSaoLuu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaoLuu.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaoLuu.ForeColor = System.Drawing.Color.Black;
            this.btnSaoLuu.Location = new System.Drawing.Point(898, 5);
            this.btnSaoLuu.Name = "btnSaoLuu";
            this.btnSaoLuu.Size = new System.Drawing.Size(113, 39);
            this.btnSaoLuu.TabIndex = 5;
            this.btnSaoLuu.Text = "Sao lưu";
            this.btnSaoLuu.TextColor = System.Drawing.Color.Black;
            this.btnSaoLuu.UseVisualStyleBackColor = false;
            this.btnSaoLuu.Click += new System.EventHandler(this.btnSaoLuu_Click);
            // 
            // btnReportDiem
            // 
            this.btnReportDiem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnReportDiem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(218)))), ((int)(((byte)(208)))));
            this.btnReportDiem.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(218)))), ((int)(((byte)(208)))));
            this.btnReportDiem.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnReportDiem.BorderRadius = 30;
            this.btnReportDiem.BorderSize = 0;
            this.btnReportDiem.FlatAppearance.BorderSize = 0;
            this.btnReportDiem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReportDiem.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReportDiem.ForeColor = System.Drawing.Color.Black;
            this.btnReportDiem.Location = new System.Drawing.Point(776, 5);
            this.btnReportDiem.Name = "btnReportDiem";
            this.btnReportDiem.Size = new System.Drawing.Size(113, 39);
            this.btnReportDiem.TabIndex = 8;
            this.btnReportDiem.Text = "In Điểm";
            this.btnReportDiem.TextColor = System.Drawing.Color.Black;
            this.btnReportDiem.UseVisualStyleBackColor = false;
            this.btnReportDiem.Click += new System.EventHandler(this.btnReportDiem_Click);
            // 
            // btnReportSinhVien
            // 
            this.btnReportSinhVien.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnReportSinhVien.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(218)))), ((int)(((byte)(208)))));
            this.btnReportSinhVien.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(218)))), ((int)(((byte)(208)))));
            this.btnReportSinhVien.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnReportSinhVien.BorderRadius = 30;
            this.btnReportSinhVien.BorderSize = 0;
            this.btnReportSinhVien.FlatAppearance.BorderSize = 0;
            this.btnReportSinhVien.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReportSinhVien.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReportSinhVien.ForeColor = System.Drawing.Color.Black;
            this.btnReportSinhVien.Location = new System.Drawing.Point(629, 5);
            this.btnReportSinhVien.Name = "btnReportSinhVien";
            this.btnReportSinhVien.Size = new System.Drawing.Size(139, 39);
            this.btnReportSinhVien.TabIndex = 7;
            this.btnReportSinhVien.Text = "In Sinh Viên";
            this.btnReportSinhVien.TextColor = System.Drawing.Color.Black;
            this.btnReportSinhVien.UseVisualStyleBackColor = false;
            this.btnReportSinhVien.Click += new System.EventHandler(this.btnReportSinhVien_Click);
            // 
            // frmBaoCao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(153)))), ((int)(((byte)(174)))));
            this.ClientSize = new System.Drawing.Size(1144, 649);
            this.Controls.Add(this.btnReportDiem);
            this.Controls.Add(this.btnReportSinhVien);
            this.Controls.Add(this.btnKhoiPhuc);
            this.Controls.Add(this.btnSaoLuu);
            this.Controls.Add(this.reportViewer1);
            this.Name = "frmBaoCao";
            this.Text = "Thống kê";
            this.Load += new System.EventHandler(this.frmBaoCao_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private DesignButton btnKhoiPhuc;
        private DesignButton btnSaoLuu;
        private DesignButton btnReportDiem;
        private DesignButton btnReportSinhVien;
    }
}