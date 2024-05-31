namespace GUI.Form_Giao_Dien
{
    partial class frmThongTinSinhVien
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
            this.panelThongTin = new System.Windows.Forms.Panel();
            this.panelGroup = new System.Windows.Forms.Panel();
            this.cboNganh = new GUI.Controls.DesignComboBox();
            this.cboCVHT = new GUI.Controls.DesignComboBox();
            this.cboLop = new GUI.Controls.DesignComboBox();
            this.dtpNgayNhapHoc = new GUI.DesignDateTimePicker();
            this.cboTrangThai = new GUI.Controls.DesignComboBox();
            this.cboKhoa = new GUI.Controls.DesignComboBox();
            this.dtpNgaySinh = new GUI.DesignDateTimePicker();
            this.rdoNu = new System.Windows.Forms.RadioButton();
            this.rdoNam = new System.Windows.Forms.RadioButton();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
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
            this.btnTroVe = new FontAwesome.Sharp.IconPictureBox();
            this.btnXoa = new GUI.DesignButton();
            this.btnCapNhat = new GUI.DesignButton();
            this.panelThongTin.SuspendLayout();
            this.panelGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnTroVe)).BeginInit();
            this.SuspendLayout();
            // 
            // panelThongTin
            // 
            this.panelThongTin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(153)))), ((int)(((byte)(174)))));
            this.panelThongTin.Controls.Add(this.panelGroup);
            this.panelThongTin.Controls.Add(this.btnTroVe);
            this.panelThongTin.Controls.Add(this.btnXoa);
            this.panelThongTin.Controls.Add(this.btnCapNhat);
            this.panelThongTin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelThongTin.Location = new System.Drawing.Point(0, 0);
            this.panelThongTin.Name = "panelThongTin";
            this.panelThongTin.Size = new System.Drawing.Size(1043, 606);
            this.panelThongTin.TabIndex = 0;
            // 
            // panelGroup
            // 
            this.panelGroup.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panelGroup.Controls.Add(this.cboNganh);
            this.panelGroup.Controls.Add(this.cboCVHT);
            this.panelGroup.Controls.Add(this.cboLop);
            this.panelGroup.Controls.Add(this.dtpNgayNhapHoc);
            this.panelGroup.Controls.Add(this.cboTrangThai);
            this.panelGroup.Controls.Add(this.cboKhoa);
            this.panelGroup.Controls.Add(this.dtpNgaySinh);
            this.panelGroup.Controls.Add(this.rdoNu);
            this.panelGroup.Controls.Add(this.rdoNam);
            this.panelGroup.Controls.Add(this.label12);
            this.panelGroup.Controls.Add(this.label11);
            this.panelGroup.Controls.Add(this.label10);
            this.panelGroup.Controls.Add(this.label9);
            this.panelGroup.Controls.Add(this.label8);
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
            // cboNganh
            // 
            this.cboNganh.BackColor = System.Drawing.Color.White;
            this.cboNganh.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.cboNganh.BorderSize = 1;
            this.cboNganh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.cboNganh.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboNganh.ForeColor = System.Drawing.Color.Black;
            this.cboNganh.IconColor = System.Drawing.Color.MediumSlateBlue;
            this.cboNganh.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.cboNganh.ListTextColor = System.Drawing.Color.DimGray;
            this.cboNganh.Location = new System.Drawing.Point(649, 176);
            this.cboNganh.MinimumSize = new System.Drawing.Size(200, 30);
            this.cboNganh.Name = "cboNganh";
            this.cboNganh.Padding = new System.Windows.Forms.Padding(1);
            this.cboNganh.Size = new System.Drawing.Size(250, 35);
            this.cboNganh.TabIndex = 61;
            this.cboNganh.Texts = "";
            // 
            // cboCVHT
            // 
            this.cboCVHT.BackColor = System.Drawing.Color.White;
            this.cboCVHT.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.cboCVHT.BorderSize = 1;
            this.cboCVHT.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.cboCVHT.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboCVHT.ForeColor = System.Drawing.Color.Black;
            this.cboCVHT.IconColor = System.Drawing.Color.MediumSlateBlue;
            this.cboCVHT.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.cboCVHT.ListTextColor = System.Drawing.Color.DimGray;
            this.cboCVHT.Location = new System.Drawing.Point(649, 315);
            this.cboCVHT.MinimumSize = new System.Drawing.Size(200, 30);
            this.cboCVHT.Name = "cboCVHT";
            this.cboCVHT.Padding = new System.Windows.Forms.Padding(1);
            this.cboCVHT.Size = new System.Drawing.Size(250, 35);
            this.cboCVHT.TabIndex = 60;
            this.cboCVHT.Texts = "";
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
            this.dtpNgayNhapHoc.Location = new System.Drawing.Point(649, 246);
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
            this.cboTrangThai.Location = new System.Drawing.Point(649, 381);
            this.cboTrangThai.MinimumSize = new System.Drawing.Size(200, 30);
            this.cboTrangThai.Name = "cboTrangThai";
            this.cboTrangThai.Padding = new System.Windows.Forms.Padding(1);
            this.cboTrangThai.Size = new System.Drawing.Size(250, 35);
            this.cboTrangThai.TabIndex = 57;
            this.cboTrangThai.Texts = "Còn học";
            // 
            // cboKhoa
            // 
            this.cboKhoa.BackColor = System.Drawing.Color.White;
            this.cboKhoa.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.cboKhoa.BorderSize = 1;
            this.cboKhoa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.cboKhoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboKhoa.ForeColor = System.Drawing.Color.Black;
            this.cboKhoa.IconColor = System.Drawing.Color.MediumSlateBlue;
            this.cboKhoa.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.cboKhoa.ListTextColor = System.Drawing.Color.DimGray;
            this.cboKhoa.Location = new System.Drawing.Point(649, 105);
            this.cboKhoa.MinimumSize = new System.Drawing.Size(200, 30);
            this.cboKhoa.Name = "cboKhoa";
            this.cboKhoa.Padding = new System.Windows.Forms.Padding(1);
            this.cboKhoa.Size = new System.Drawing.Size(250, 35);
            this.cboKhoa.TabIndex = 56;
            this.cboKhoa.Texts = "";
            // 
            // dtpNgaySinh
            // 
            this.dtpNgaySinh.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.dtpNgaySinh.BorderSize = 0;
            this.dtpNgaySinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpNgaySinh.Location = new System.Drawing.Point(176, 246);
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
            this.rdoNu.Location = new System.Drawing.Point(307, 181);
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
            this.rdoNam.Location = new System.Drawing.Point(207, 181);
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
            this.label12.Location = new System.Drawing.Point(520, 388);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(89, 20);
            this.label12.TabIndex = 52;
            this.label12.Text = "Trạng thái:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(517, 183);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(94, 20);
            this.label11.TabIndex = 51;
            this.label11.Text = "Ngành học:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(501, 253);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(125, 20);
            this.label10.TabIndex = 49;
            this.label10.Text = "Ngày nhập học:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(501, 322);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(126, 20);
            this.label9.TabIndex = 48;
            this.label9.Text = "Cố vấn học tập:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(538, 112);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 20);
            this.label8.TabIndex = 46;
            this.label8.Text = "Khoa:";
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
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(35, 388);
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
            this.txtSDT.Location = new System.Drawing.Point(176, 378);
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
            this.label5.Location = new System.Drawing.Point(57, 322);
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
            this.txtDiaChi.Location = new System.Drawing.Point(176, 312);
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
            this.label4.Location = new System.Drawing.Point(46, 253);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 20);
            this.label4.TabIndex = 39;
            this.label4.Text = "Ngày sinh:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(52, 183);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 20);
            this.label3.TabIndex = 38;
            this.label3.Text = "Giới tính:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(18, 113);
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
            this.txtHoTen.Location = new System.Drawing.Point(176, 103);
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
            // btnXoa
            // 
            this.btnXoa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnXoa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(218)))), ((int)(((byte)(208)))));
            this.btnXoa.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(218)))), ((int)(((byte)(208)))));
            this.btnXoa.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnXoa.BorderRadius = 40;
            this.btnXoa.BorderSize = 0;
            this.btnXoa.FlatAppearance.BorderSize = 0;
            this.btnXoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.ForeColor = System.Drawing.Color.Black;
            this.btnXoa.Location = new System.Drawing.Point(667, 526);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(160, 53);
            this.btnXoa.TabIndex = 26;
            this.btnXoa.Text = "Xóa sinh viên";
            this.btnXoa.TextColor = System.Drawing.Color.Black;
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCapNhat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(218)))), ((int)(((byte)(208)))));
            this.btnCapNhat.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(218)))), ((int)(((byte)(208)))));
            this.btnCapNhat.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnCapNhat.BorderRadius = 40;
            this.btnCapNhat.BorderSize = 0;
            this.btnCapNhat.FlatAppearance.BorderSize = 0;
            this.btnCapNhat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCapNhat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCapNhat.ForeColor = System.Drawing.Color.Black;
            this.btnCapNhat.Location = new System.Drawing.Point(844, 526);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(160, 53);
            this.btnCapNhat.TabIndex = 25;
            this.btnCapNhat.Text = "Cập nhật lý lịch";
            this.btnCapNhat.TextColor = System.Drawing.Color.Black;
            this.btnCapNhat.UseVisualStyleBackColor = false;
            this.btnCapNhat.Click += new System.EventHandler(this.btnCapNhat_Click);
            // 
            // frmThongTinSinhVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(153)))), ((int)(((byte)(174)))));
            this.ClientSize = new System.Drawing.Size(1043, 606);
            this.Controls.Add(this.panelThongTin);
            this.Name = "frmThongTinSinhVien";
            this.Text = "Thông Tin Sinh Viên";
            this.Load += new System.EventHandler(this.frmThongTinSinhVien_Load);
            this.panelThongTin.ResumeLayout(false);
            this.panelGroup.ResumeLayout(false);
            this.panelGroup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnTroVe)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelThongTin;
        private FontAwesome.Sharp.IconPictureBox btnTroVe;
        private DesignButton btnCapNhat;
        private DesignButton btnXoa;
        private System.Windows.Forms.Panel panelGroup;
        private DesignDateTimePicker dtpNgayNhapHoc;
        private Controls.DesignComboBox cboTrangThai;
        private Controls.DesignComboBox cboKhoa;
        private DesignDateTimePicker dtpNgaySinh;
        private System.Windows.Forms.RadioButton rdoNu;
        private System.Windows.Forms.RadioButton rdoNam;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
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
        private Controls.DesignComboBox cboNganh;
        private Controls.DesignComboBox cboCVHT;
        private Controls.DesignComboBox cboLop;
        private System.Windows.Forms.Label label7;
    }
}