namespace GUI.Form_Giao_Dien
{
    partial class frmThemSinhVien
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
            this.btnThemSinhVien = new GUI.DesignButton();
            this.cboLop = new GUI.Controls.DesignComboBox();
            this.dtpNgayNhapHoc = new GUI.DesignDateTimePicker();
            this.cboTrangThai = new GUI.Controls.DesignComboBox();
            this.dtpNgaySinh = new GUI.DesignDateTimePicker();
            this.rdoNu = new System.Windows.Forms.RadioButton();
            this.rdoNam = new System.Windows.Forms.RadioButton();
            this.label12 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.btnTroVe = new FontAwesome.Sharp.IconPictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtSDT = new GUI.Controls.DesignTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDiaChi = new GUI.Controls.DesignTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtHoTen = new GUI.Controls.DesignTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMSSV = new GUI.Controls.DesignTextBox();
            this.panelGroup = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.panelThongTin = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.btnTroVe)).BeginInit();
            this.panelGroup.SuspendLayout();
            this.panelThongTin.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnThemSinhVien
            // 
            this.btnThemSinhVien.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnThemSinhVien.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(218)))), ((int)(((byte)(208)))));
            this.btnThemSinhVien.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(218)))), ((int)(((byte)(208)))));
            this.btnThemSinhVien.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnThemSinhVien.BorderRadius = 40;
            this.btnThemSinhVien.BorderSize = 0;
            this.btnThemSinhVien.FlatAppearance.BorderSize = 0;
            this.btnThemSinhVien.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThemSinhVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemSinhVien.ForeColor = System.Drawing.Color.Black;
            this.btnThemSinhVien.Location = new System.Drawing.Point(871, 526);
            this.btnThemSinhVien.Name = "btnThemSinhVien";
            this.btnThemSinhVien.Size = new System.Drawing.Size(160, 53);
            this.btnThemSinhVien.TabIndex = 28;
            this.btnThemSinhVien.Text = "Thêm Sinh Viên";
            this.btnThemSinhVien.TextColor = System.Drawing.Color.Black;
            this.btnThemSinhVien.UseVisualStyleBackColor = false;
            this.btnThemSinhVien.Click += new System.EventHandler(this.btnThemSinhVien_Click);
            // 
            // cboLop
            // 
            this.cboLop.BackColor = System.Drawing.Color.White;
            this.cboLop.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.cboLop.BorderSize = 1;
            this.cboLop.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.cboLop.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboLop.ForeColor = System.Drawing.Color.Black;
            this.cboLop.IconColor = System.Drawing.Color.MediumSlateBlue;
            this.cboLop.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.cboLop.ListTextColor = System.Drawing.Color.DimGray;
            this.cboLop.Location = new System.Drawing.Point(649, 36);
            this.cboLop.MinimumSize = new System.Drawing.Size(200, 30);
            this.cboLop.Name = "cboLop";
            this.cboLop.Padding = new System.Windows.Forms.Padding(1);
            this.cboLop.Size = new System.Drawing.Size(250, 35);
            this.cboLop.TabIndex = 59;
            this.cboLop.Texts = "";
            // 
            // dtpNgayNhapHoc
            // 
            this.dtpNgayNhapHoc.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.dtpNgayNhapHoc.BorderSize = 0;
            this.dtpNgayNhapHoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpNgayNhapHoc.Location = new System.Drawing.Point(649, 288);
            this.dtpNgayNhapHoc.MinimumSize = new System.Drawing.Size(4, 35);
            this.dtpNgayNhapHoc.Name = "dtpNgayNhapHoc";
            this.dtpNgayNhapHoc.Size = new System.Drawing.Size(250, 35);
            this.dtpNgayNhapHoc.SkinColor = System.Drawing.Color.MidnightBlue;
            this.dtpNgayNhapHoc.TabIndex = 58;
            this.dtpNgayNhapHoc.TextColor = System.Drawing.Color.White;
            // 
            // cboTrangThai
            // 
            this.cboTrangThai.BackColor = System.Drawing.Color.White;
            this.cboTrangThai.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.cboTrangThai.BorderSize = 1;
            this.cboTrangThai.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.cboTrangThai.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboTrangThai.ForeColor = System.Drawing.Color.Black;
            this.cboTrangThai.IconColor = System.Drawing.Color.MediumSlateBlue;
            this.cboTrangThai.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.cboTrangThai.ListTextColor = System.Drawing.Color.DimGray;
            this.cboTrangThai.Location = new System.Drawing.Point(176, 373);
            this.cboTrangThai.MinimumSize = new System.Drawing.Size(200, 30);
            this.cboTrangThai.Name = "cboTrangThai";
            this.cboTrangThai.Padding = new System.Windows.Forms.Padding(1);
            this.cboTrangThai.Size = new System.Drawing.Size(250, 35);
            this.cboTrangThai.TabIndex = 57;
            this.cboTrangThai.Texts = "Còn học";
            // 
            // dtpNgaySinh
            // 
            this.dtpNgaySinh.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.dtpNgaySinh.BorderSize = 0;
            this.dtpNgaySinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpNgaySinh.Location = new System.Drawing.Point(176, 288);
            this.dtpNgaySinh.MinimumSize = new System.Drawing.Size(4, 35);
            this.dtpNgaySinh.Name = "dtpNgaySinh";
            this.dtpNgaySinh.Size = new System.Drawing.Size(250, 35);
            this.dtpNgaySinh.SkinColor = System.Drawing.Color.MidnightBlue;
            this.dtpNgaySinh.TabIndex = 55;
            this.dtpNgaySinh.TextColor = System.Drawing.Color.White;
            // 
            // rdoNu
            // 
            this.rdoNu.AutoSize = true;
            this.rdoNu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoNu.Location = new System.Drawing.Point(307, 209);
            this.rdoNu.Name = "rdoNu";
            this.rdoNu.Size = new System.Drawing.Size(51, 24);
            this.rdoNu.TabIndex = 54;
            this.rdoNu.TabStop = true;
            this.rdoNu.Text = "Nữ";
            this.rdoNu.UseVisualStyleBackColor = true;
            // 
            // rdoNam
            // 
            this.rdoNam.AutoSize = true;
            this.rdoNam.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoNam.Location = new System.Drawing.Point(207, 209);
            this.rdoNam.Name = "rdoNam";
            this.rdoNam.Size = new System.Drawing.Size(65, 24);
            this.rdoNam.TabIndex = 53;
            this.rdoNam.TabStop = true;
            this.rdoNam.Text = "Nam";
            this.rdoNam.UseVisualStyleBackColor = true;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(47, 379);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(89, 20);
            this.label12.TabIndex = 52;
            this.label12.Text = "Trạng thái:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(501, 295);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(125, 20);
            this.label10.TabIndex = 49;
            this.label10.Text = "Ngày nhập học:";
            // 
            // btnTroVe
            // 
            this.btnTroVe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(153)))), ((int)(((byte)(174)))));
            this.btnTroVe.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnTroVe.IconChar = FontAwesome.Sharp.IconChar.MailReply;
            this.btnTroVe.IconColor = System.Drawing.Color.WhiteSmoke;
            this.btnTroVe.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnTroVe.IconSize = 45;
            this.btnTroVe.Location = new System.Drawing.Point(12, 12);
            this.btnTroVe.Name = "btnTroVe";
            this.btnTroVe.Size = new System.Drawing.Size(50, 45);
            this.btnTroVe.TabIndex = 1;
            this.btnTroVe.TabStop = false;
            this.btnTroVe.Click += new System.EventHandler(this.btnTroVe_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(508, 211);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(111, 20);
            this.label6.TabIndex = 43;
            this.label6.Text = "Số điện thoại:";
            // 
            // txtSDT
            // 
            this.txtSDT.BackColor = System.Drawing.SystemColors.Window;
            this.txtSDT.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtSDT.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtSDT.BorderRadius = 0;
            this.txtSDT.BorderSize = 2;
            this.txtSDT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSDT.ForeColor = System.Drawing.Color.Black;
            this.txtSDT.Location = new System.Drawing.Point(649, 201);
            this.txtSDT.Margin = new System.Windows.Forms.Padding(4);
            this.txtSDT.Multiline = false;
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Padding = new System.Windows.Forms.Padding(7);
            this.txtSDT.PasswordChar = false;
            this.txtSDT.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtSDT.PlaceholderText = "";
            this.txtSDT.ReadOnly = false;
            this.txtSDT.Size = new System.Drawing.Size(250, 40);
            this.txtSDT.TabIndex = 42;
            this.txtSDT.TextString = "";
            this.txtSDT.UnderlinedStyle = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(530, 127);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 20);
            this.label5.TabIndex = 41;
            this.label5.Text = "Địa chỉ:";
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.BackColor = System.Drawing.SystemColors.Window;
            this.txtDiaChi.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtDiaChi.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtDiaChi.BorderRadius = 0;
            this.txtDiaChi.BorderSize = 2;
            this.txtDiaChi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiaChi.ForeColor = System.Drawing.Color.Black;
            this.txtDiaChi.Location = new System.Drawing.Point(649, 117);
            this.txtDiaChi.Margin = new System.Windows.Forms.Padding(4);
            this.txtDiaChi.Multiline = false;
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Padding = new System.Windows.Forms.Padding(7);
            this.txtDiaChi.PasswordChar = false;
            this.txtDiaChi.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtDiaChi.PlaceholderText = "";
            this.txtDiaChi.ReadOnly = false;
            this.txtDiaChi.Size = new System.Drawing.Size(250, 40);
            this.txtDiaChi.TabIndex = 40;
            this.txtDiaChi.TextString = "";
            this.txtDiaChi.UnderlinedStyle = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(46, 295);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 20);
            this.label4.TabIndex = 39;
            this.label4.Text = "Ngày sinh:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(52, 211);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 20);
            this.label3.TabIndex = 38;
            this.label3.Text = "Giới tính:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(18, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 20);
            this.label2.TabIndex = 37;
            this.label2.Text = "Họ Tên Sinh Viên:";
            // 
            // txtHoTen
            // 
            this.txtHoTen.BackColor = System.Drawing.SystemColors.Window;
            this.txtHoTen.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtHoTen.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtHoTen.BorderRadius = 0;
            this.txtHoTen.BorderSize = 2;
            this.txtHoTen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHoTen.ForeColor = System.Drawing.Color.Black;
            this.txtHoTen.Location = new System.Drawing.Point(176, 117);
            this.txtHoTen.Margin = new System.Windows.Forms.Padding(4);
            this.txtHoTen.Multiline = false;
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Padding = new System.Windows.Forms.Padding(7);
            this.txtHoTen.PasswordChar = false;
            this.txtHoTen.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtHoTen.PlaceholderText = "";
            this.txtHoTen.ReadOnly = false;
            this.txtHoTen.Size = new System.Drawing.Size(250, 40);
            this.txtHoTen.TabIndex = 36;
            this.txtHoTen.TextString = "";
            this.txtHoTen.UnderlinedStyle = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(36, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 20);
            this.label1.TabIndex = 35;
            this.label1.Text = "Mã sinh viên:";
            // 
            // txtMSSV
            // 
            this.txtMSSV.BackColor = System.Drawing.SystemColors.Window;
            this.txtMSSV.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtMSSV.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtMSSV.BorderRadius = 0;
            this.txtMSSV.BorderSize = 2;
            this.txtMSSV.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMSSV.ForeColor = System.Drawing.Color.Black;
            this.txtMSSV.Location = new System.Drawing.Point(176, 33);
            this.txtMSSV.Margin = new System.Windows.Forms.Padding(4);
            this.txtMSSV.Multiline = false;
            this.txtMSSV.Name = "txtMSSV";
            this.txtMSSV.Padding = new System.Windows.Forms.Padding(7);
            this.txtMSSV.PasswordChar = false;
            this.txtMSSV.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtMSSV.PlaceholderText = "";
            this.txtMSSV.ReadOnly = false;
            this.txtMSSV.Size = new System.Drawing.Size(250, 40);
            this.txtMSSV.TabIndex = 34;
            this.txtMSSV.TextString = "";
            this.txtMSSV.UnderlinedStyle = false;
            // 
            // panelGroup
            // 
            this.panelGroup.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panelGroup.Controls.Add(this.cboLop);
            this.panelGroup.Controls.Add(this.dtpNgayNhapHoc);
            this.panelGroup.Controls.Add(this.cboTrangThai);
            this.panelGroup.Controls.Add(this.dtpNgaySinh);
            this.panelGroup.Controls.Add(this.rdoNu);
            this.panelGroup.Controls.Add(this.rdoNam);
            this.panelGroup.Controls.Add(this.label12);
            this.panelGroup.Controls.Add(this.label10);
            this.panelGroup.Controls.Add(this.label7);
            this.panelGroup.Controls.Add(this.label6);
            this.panelGroup.Controls.Add(this.txtSDT);
            this.panelGroup.Controls.Add(this.label5);
            this.panelGroup.Controls.Add(this.txtDiaChi);
            this.panelGroup.Controls.Add(this.label4);
            this.panelGroup.Controls.Add(this.label3);
            this.panelGroup.Controls.Add(this.label2);
            this.panelGroup.Controls.Add(this.txtHoTen);
            this.panelGroup.Controls.Add(this.label1);
            this.panelGroup.Controls.Add(this.txtMSSV);
            this.panelGroup.Location = new System.Drawing.Point(79, 53);
            this.panelGroup.Name = "panelGroup";
            this.panelGroup.Size = new System.Drawing.Size(925, 454);
            this.panelGroup.TabIndex = 27;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(543, 43);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 20);
            this.label7.TabIndex = 45;
            this.label7.Text = "Lớp:";
            // 
            // panelThongTin
            // 
            this.panelThongTin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(153)))), ((int)(((byte)(174)))));
            this.panelThongTin.Controls.Add(this.btnThemSinhVien);
            this.panelThongTin.Controls.Add(this.panelGroup);
            this.panelThongTin.Controls.Add(this.btnTroVe);
            this.panelThongTin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelThongTin.Location = new System.Drawing.Point(0, 0);
            this.panelThongTin.Name = "panelThongTin";
            this.panelThongTin.Size = new System.Drawing.Size(1043, 606);
            this.panelThongTin.TabIndex = 1;
            // 
            // frmThemSinhVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1043, 606);
            this.Controls.Add(this.panelThongTin);
            this.Name = "frmThemSinhVien";
            this.Text = "frmThemSinhVien";
            this.Load += new System.EventHandler(this.frmThemSinhVien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.btnTroVe)).EndInit();
            this.panelGroup.ResumeLayout(false);
            this.panelGroup.PerformLayout();
            this.panelThongTin.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DesignButton btnThemSinhVien;
        private Controls.DesignComboBox cboLop;
        private DesignDateTimePicker dtpNgayNhapHoc;
        private Controls.DesignComboBox cboTrangThai;
        private DesignDateTimePicker dtpNgaySinh;
        private System.Windows.Forms.RadioButton rdoNu;
        private System.Windows.Forms.RadioButton rdoNam;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label10;
        private FontAwesome.Sharp.IconPictureBox btnTroVe;
        private System.Windows.Forms.Label label6;
        private Controls.DesignTextBox txtSDT;
        private System.Windows.Forms.Label label5;
        private Controls.DesignTextBox txtDiaChi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private Controls.DesignTextBox txtHoTen;
        private System.Windows.Forms.Label label1;
        private Controls.DesignTextBox txtMSSV;
        private System.Windows.Forms.Panel panelGroup;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panelThongTin;
    }
}