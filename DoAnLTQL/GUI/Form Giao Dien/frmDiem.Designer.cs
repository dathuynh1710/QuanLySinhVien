namespace GUI.Form_Giao_Dien
{
    partial class frmDiem
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
            this.panelGroup = new System.Windows.Forms.Panel();
            this.txtLoai = new GUI.Controls.DesignTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtDiemTrungBinh = new GUI.Controls.DesignTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtDiemThi = new GUI.Controls.DesignTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cboTenMonHoc = new GUI.Controls.DesignComboBox();
            this.cboTenSinhVien = new GUI.Controls.DesignComboBox();
            this.txtDiemTrenLop = new GUI.Controls.DesignTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPhanTramThi = new GUI.Controls.DesignTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPhanTramTrenLop = new GUI.Controls.DesignTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvDiem = new System.Windows.Forms.DataGridView();
            this.btnXoaDiem = new GUI.DesignButton();
            this.btnCapNhatDiem = new GUI.DesignButton();
            this.btnThemDiem = new GUI.DesignButton();
            this.panelGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDiem)).BeginInit();
            this.SuspendLayout();
            // 
            // panelGroup
            // 
            this.panelGroup.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelGroup.Controls.Add(this.txtLoai);
            this.panelGroup.Controls.Add(this.label8);
            this.panelGroup.Controls.Add(this.txtDiemTrungBinh);
            this.panelGroup.Controls.Add(this.label7);
            this.panelGroup.Controls.Add(this.txtDiemThi);
            this.panelGroup.Controls.Add(this.label6);
            this.panelGroup.Controls.Add(this.cboTenMonHoc);
            this.panelGroup.Controls.Add(this.cboTenSinhVien);
            this.panelGroup.Controls.Add(this.txtDiemTrenLop);
            this.panelGroup.Controls.Add(this.label5);
            this.panelGroup.Controls.Add(this.txtPhanTramThi);
            this.panelGroup.Controls.Add(this.label4);
            this.panelGroup.Controls.Add(this.txtPhanTramTrenLop);
            this.panelGroup.Controls.Add(this.label1);
            this.panelGroup.Controls.Add(this.label3);
            this.panelGroup.Controls.Add(this.label2);
            this.panelGroup.Controls.Add(this.dgvDiem);
            this.panelGroup.Location = new System.Drawing.Point(24, 12);
            this.panelGroup.Name = "panelGroup";
            this.panelGroup.Size = new System.Drawing.Size(1002, 502);
            this.panelGroup.TabIndex = 36;
            // 
            // txtLoai
            // 
            this.txtLoai.BackColor = System.Drawing.SystemColors.Window;
            this.txtLoai.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtLoai.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtLoai.BorderRadius = 0;
            this.txtLoai.BorderSize = 2;
            this.txtLoai.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLoai.ForeColor = System.Drawing.Color.DimGray;
            this.txtLoai.Location = new System.Drawing.Point(867, 114);
            this.txtLoai.Margin = new System.Windows.Forms.Padding(4);
            this.txtLoai.Multiline = false;
            this.txtLoai.Name = "txtLoai";
            this.txtLoai.Padding = new System.Windows.Forms.Padding(7);
            this.txtLoai.PasswordChar = false;
            this.txtLoai.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtLoai.PlaceholderText = "";
            this.txtLoai.ReadOnly = true;
            this.txtLoai.Size = new System.Drawing.Size(73, 35);
            this.txtLoai.TabIndex = 31;
            this.txtLoai.TextString = "";
            this.txtLoai.UnderlinedStyle = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(789, 121);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(70, 20);
            this.label8.TabIndex = 28;
            this.label8.Text = "Xếp loại:";
            // 
            // txtDiemTrungBinh
            // 
            this.txtDiemTrungBinh.BackColor = System.Drawing.SystemColors.Window;
            this.txtDiemTrungBinh.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtDiemTrungBinh.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtDiemTrungBinh.BorderRadius = 0;
            this.txtDiemTrungBinh.BorderSize = 2;
            this.txtDiemTrungBinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiemTrungBinh.ForeColor = System.Drawing.Color.DimGray;
            this.txtDiemTrungBinh.Location = new System.Drawing.Point(867, 69);
            this.txtDiemTrungBinh.Margin = new System.Windows.Forms.Padding(4);
            this.txtDiemTrungBinh.Multiline = false;
            this.txtDiemTrungBinh.Name = "txtDiemTrungBinh";
            this.txtDiemTrungBinh.Padding = new System.Windows.Forms.Padding(7);
            this.txtDiemTrungBinh.PasswordChar = false;
            this.txtDiemTrungBinh.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtDiemTrungBinh.PlaceholderText = "";
            this.txtDiemTrungBinh.ReadOnly = true;
            this.txtDiemTrungBinh.Size = new System.Drawing.Size(110, 35);
            this.txtDiemTrungBinh.TabIndex = 27;
            this.txtDiemTrungBinh.TextString = "";
            this.txtDiemTrungBinh.UnderlinedStyle = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(731, 76);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(131, 20);
            this.label7.TabIndex = 26;
            this.label7.Text = "Điểm Trung Bình:";
            // 
            // txtDiemThi
            // 
            this.txtDiemThi.BackColor = System.Drawing.SystemColors.Window;
            this.txtDiemThi.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtDiemThi.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtDiemThi.BorderRadius = 0;
            this.txtDiemThi.BorderSize = 2;
            this.txtDiemThi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiemThi.ForeColor = System.Drawing.Color.DimGray;
            this.txtDiemThi.Location = new System.Drawing.Point(609, 69);
            this.txtDiemThi.Margin = new System.Windows.Forms.Padding(4);
            this.txtDiemThi.Multiline = false;
            this.txtDiemThi.Name = "txtDiemThi";
            this.txtDiemThi.Padding = new System.Windows.Forms.Padding(7);
            this.txtDiemThi.PasswordChar = false;
            this.txtDiemThi.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtDiemThi.PlaceholderText = "";
            this.txtDiemThi.ReadOnly = false;
            this.txtDiemThi.Size = new System.Drawing.Size(110, 35);
            this.txtDiemThi.TabIndex = 25;
            this.txtDiemThi.TextString = "";
            this.txtDiemThi.UnderlinedStyle = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(523, 76);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 20);
            this.label6.TabIndex = 24;
            this.label6.Text = "Điểm Thi:";
            // 
            // cboTenMonHoc
            // 
            this.cboTenMonHoc.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cboTenMonHoc.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.cboTenMonHoc.BorderSize = 1;
            this.cboTenMonHoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.cboTenMonHoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboTenMonHoc.ForeColor = System.Drawing.Color.DimGray;
            this.cboTenMonHoc.IconColor = System.Drawing.Color.MediumSlateBlue;
            this.cboTenMonHoc.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.cboTenMonHoc.ListTextColor = System.Drawing.Color.DimGray;
            this.cboTenMonHoc.Location = new System.Drawing.Point(476, 21);
            this.cboTenMonHoc.MinimumSize = new System.Drawing.Size(200, 30);
            this.cboTenMonHoc.Name = "cboTenMonHoc";
            this.cboTenMonHoc.Padding = new System.Windows.Forms.Padding(1);
            this.cboTenMonHoc.Size = new System.Drawing.Size(200, 30);
            this.cboTenMonHoc.TabIndex = 23;
            this.cboTenMonHoc.Texts = "";
            // 
            // cboTenSinhVien
            // 
            this.cboTenSinhVien.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cboTenSinhVien.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.cboTenSinhVien.BorderSize = 1;
            this.cboTenSinhVien.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.cboTenSinhVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboTenSinhVien.ForeColor = System.Drawing.Color.DimGray;
            this.cboTenSinhVien.IconColor = System.Drawing.Color.MediumSlateBlue;
            this.cboTenSinhVien.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.cboTenSinhVien.ListTextColor = System.Drawing.Color.DimGray;
            this.cboTenSinhVien.Location = new System.Drawing.Point(140, 21);
            this.cboTenSinhVien.MinimumSize = new System.Drawing.Size(200, 30);
            this.cboTenSinhVien.Name = "cboTenSinhVien";
            this.cboTenSinhVien.Padding = new System.Windows.Forms.Padding(1);
            this.cboTenSinhVien.Size = new System.Drawing.Size(200, 30);
            this.cboTenSinhVien.TabIndex = 22;
            this.cboTenSinhVien.Texts = "";
            // 
            // txtDiemTrenLop
            // 
            this.txtDiemTrenLop.BackColor = System.Drawing.SystemColors.Window;
            this.txtDiemTrenLop.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtDiemTrenLop.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtDiemTrenLop.BorderRadius = 0;
            this.txtDiemTrenLop.BorderSize = 2;
            this.txtDiemTrenLop.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiemTrenLop.ForeColor = System.Drawing.Color.DimGray;
            this.txtDiemTrenLop.Location = new System.Drawing.Point(399, 69);
            this.txtDiemTrenLop.Margin = new System.Windows.Forms.Padding(4);
            this.txtDiemTrenLop.Multiline = false;
            this.txtDiemTrenLop.Name = "txtDiemTrenLop";
            this.txtDiemTrenLop.Padding = new System.Windows.Forms.Padding(7);
            this.txtDiemTrenLop.PasswordChar = false;
            this.txtDiemTrenLop.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtDiemTrenLop.PlaceholderText = "";
            this.txtDiemTrenLop.ReadOnly = false;
            this.txtDiemTrenLop.Size = new System.Drawing.Size(110, 35);
            this.txtDiemTrenLop.TabIndex = 21;
            this.txtDiemTrenLop.TextString = "";
            this.txtDiemTrenLop.UnderlinedStyle = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(274, 76);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(117, 20);
            this.label5.TabIndex = 20;
            this.label5.Text = "Điểm Trên Lớp:";
            // 
            // txtPhanTramThi
            // 
            this.txtPhanTramThi.BackColor = System.Drawing.SystemColors.Window;
            this.txtPhanTramThi.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtPhanTramThi.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtPhanTramThi.BorderRadius = 0;
            this.txtPhanTramThi.BorderSize = 2;
            this.txtPhanTramThi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhanTramThi.ForeColor = System.Drawing.Color.DimGray;
            this.txtPhanTramThi.Location = new System.Drawing.Point(142, 69);
            this.txtPhanTramThi.Margin = new System.Windows.Forms.Padding(4);
            this.txtPhanTramThi.Multiline = false;
            this.txtPhanTramThi.Name = "txtPhanTramThi";
            this.txtPhanTramThi.Padding = new System.Windows.Forms.Padding(7);
            this.txtPhanTramThi.PasswordChar = false;
            this.txtPhanTramThi.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtPhanTramThi.PlaceholderText = "";
            this.txtPhanTramThi.ReadOnly = false;
            this.txtPhanTramThi.Size = new System.Drawing.Size(110, 35);
            this.txtPhanTramThi.TabIndex = 19;
            this.txtPhanTramThi.TextString = "";
            this.txtPhanTramThi.UnderlinedStyle = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(17, 76);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 20);
            this.label4.TabIndex = 18;
            this.label4.Text = "Phần Trăm Thi:";
            // 
            // txtPhanTramTrenLop
            // 
            this.txtPhanTramTrenLop.BackColor = System.Drawing.SystemColors.Window;
            this.txtPhanTramTrenLop.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtPhanTramTrenLop.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtPhanTramTrenLop.BorderRadius = 0;
            this.txtPhanTramTrenLop.BorderSize = 2;
            this.txtPhanTramTrenLop.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhanTramTrenLop.ForeColor = System.Drawing.Color.DimGray;
            this.txtPhanTramTrenLop.Location = new System.Drawing.Point(867, 19);
            this.txtPhanTramTrenLop.Margin = new System.Windows.Forms.Padding(4);
            this.txtPhanTramTrenLop.Multiline = false;
            this.txtPhanTramTrenLop.Name = "txtPhanTramTrenLop";
            this.txtPhanTramTrenLop.Padding = new System.Windows.Forms.Padding(7);
            this.txtPhanTramTrenLop.PasswordChar = false;
            this.txtPhanTramTrenLop.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtPhanTramTrenLop.PlaceholderText = "";
            this.txtPhanTramTrenLop.ReadOnly = false;
            this.txtPhanTramTrenLop.Size = new System.Drawing.Size(110, 35);
            this.txtPhanTramTrenLop.TabIndex = 17;
            this.txtPhanTramTrenLop.TextString = "";
            this.txtPhanTramTrenLop.UnderlinedStyle = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(702, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 20);
            this.label1.TabIndex = 16;
            this.label1.Text = "Phần Trăm Trên Lớp:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(361, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 20);
            this.label3.TabIndex = 14;
            this.label3.Text = "Tên Môn Học:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(21, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 20);
            this.label2.TabIndex = 12;
            this.label2.Text = "Tên Sinh Viên:";
            // 
            // dgvDiem
            // 
            this.dgvDiem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDiem.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvDiem.Location = new System.Drawing.Point(0, 167);
            this.dgvDiem.Name = "dgvDiem";
            this.dgvDiem.ReadOnly = true;
            this.dgvDiem.RowHeadersWidth = 51;
            this.dgvDiem.RowTemplate.Height = 24;
            this.dgvDiem.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDiem.Size = new System.Drawing.Size(1002, 335);
            this.dgvDiem.TabIndex = 8;
            this.dgvDiem.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvNganh_CellClick);
            // 
            // btnXoaDiem
            // 
            this.btnXoaDiem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnXoaDiem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(218)))), ((int)(((byte)(208)))));
            this.btnXoaDiem.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(218)))), ((int)(((byte)(208)))));
            this.btnXoaDiem.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnXoaDiem.BorderRadius = 40;
            this.btnXoaDiem.BorderSize = 0;
            this.btnXoaDiem.FlatAppearance.BorderSize = 0;
            this.btnXoaDiem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoaDiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaDiem.ForeColor = System.Drawing.Color.Black;
            this.btnXoaDiem.Location = new System.Drawing.Point(527, 532);
            this.btnXoaDiem.Name = "btnXoaDiem";
            this.btnXoaDiem.Size = new System.Drawing.Size(160, 53);
            this.btnXoaDiem.TabIndex = 39;
            this.btnXoaDiem.Text = "Xóa Điểm";
            this.btnXoaDiem.TextColor = System.Drawing.Color.Black;
            this.btnXoaDiem.UseVisualStyleBackColor = false;
            this.btnXoaDiem.Click += new System.EventHandler(this.btnXoaDiem_Click);
            // 
            // btnCapNhatDiem
            // 
            this.btnCapNhatDiem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCapNhatDiem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(218)))), ((int)(((byte)(208)))));
            this.btnCapNhatDiem.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(218)))), ((int)(((byte)(208)))));
            this.btnCapNhatDiem.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnCapNhatDiem.BorderRadius = 40;
            this.btnCapNhatDiem.BorderSize = 0;
            this.btnCapNhatDiem.FlatAppearance.BorderSize = 0;
            this.btnCapNhatDiem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCapNhatDiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCapNhatDiem.ForeColor = System.Drawing.Color.Black;
            this.btnCapNhatDiem.Location = new System.Drawing.Point(696, 532);
            this.btnCapNhatDiem.Name = "btnCapNhatDiem";
            this.btnCapNhatDiem.Size = new System.Drawing.Size(160, 53);
            this.btnCapNhatDiem.TabIndex = 38;
            this.btnCapNhatDiem.Text = "Cập Nhật Điểm";
            this.btnCapNhatDiem.TextColor = System.Drawing.Color.Black;
            this.btnCapNhatDiem.UseVisualStyleBackColor = false;
            this.btnCapNhatDiem.Click += new System.EventHandler(this.btnCapNhatDiem_Click);
            // 
            // btnThemDiem
            // 
            this.btnThemDiem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnThemDiem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(218)))), ((int)(((byte)(208)))));
            this.btnThemDiem.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(218)))), ((int)(((byte)(208)))));
            this.btnThemDiem.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnThemDiem.BorderRadius = 40;
            this.btnThemDiem.BorderSize = 0;
            this.btnThemDiem.FlatAppearance.BorderSize = 0;
            this.btnThemDiem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThemDiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemDiem.ForeColor = System.Drawing.Color.Black;
            this.btnThemDiem.Location = new System.Drawing.Point(865, 532);
            this.btnThemDiem.Name = "btnThemDiem";
            this.btnThemDiem.Size = new System.Drawing.Size(160, 53);
            this.btnThemDiem.TabIndex = 37;
            this.btnThemDiem.Text = "Thêm Điểm";
            this.btnThemDiem.TextColor = System.Drawing.Color.Black;
            this.btnThemDiem.UseVisualStyleBackColor = false;
            this.btnThemDiem.Click += new System.EventHandler(this.btnThemDiem_Click);
            // 
            // frmDiem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(153)))), ((int)(((byte)(174)))));
            this.ClientSize = new System.Drawing.Size(1043, 606);
            this.Controls.Add(this.btnXoaDiem);
            this.Controls.Add(this.panelGroup);
            this.Controls.Add(this.btnCapNhatDiem);
            this.Controls.Add(this.btnThemDiem);
            this.Name = "frmDiem";
            this.Text = "Điểm";
            this.Load += new System.EventHandler(this.frmDiem_Load);
            this.panelGroup.ResumeLayout(false);
            this.panelGroup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDiem)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelGroup;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvDiem;
        private DesignButton btnCapNhatDiem;
        private DesignButton btnThemDiem;
        private Controls.DesignTextBox txtDiemTrungBinh;
        private System.Windows.Forms.Label label7;
        private Controls.DesignTextBox txtDiemThi;
        private System.Windows.Forms.Label label6;
        private Controls.DesignComboBox cboTenMonHoc;
        private Controls.DesignComboBox cboTenSinhVien;
        private Controls.DesignTextBox txtDiemTrenLop;
        private System.Windows.Forms.Label label5;
        private Controls.DesignTextBox txtPhanTramThi;
        private System.Windows.Forms.Label label4;
        private Controls.DesignTextBox txtPhanTramTrenLop;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label8;
        private Controls.DesignTextBox txtLoai;
        private DesignButton btnXoaDiem;
    }
}