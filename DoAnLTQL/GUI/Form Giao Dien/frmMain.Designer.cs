namespace GUI
{
    partial class frmMain
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
            this.panelMenu = new System.Windows.Forms.Panel();
            this.btnThongKe = new FontAwesome.Sharp.IconButton();
            this.btnDangXuat = new System.Windows.Forms.Label();
            this.btnTaiKhoan = new FontAwesome.Sharp.IconButton();
            this.btnCVHT = new FontAwesome.Sharp.IconButton();
            this.btnKhoa = new FontAwesome.Sharp.IconButton();
            this.btnNganh = new FontAwesome.Sharp.IconButton();
            this.btnLop = new FontAwesome.Sharp.IconButton();
            this.btnDiem = new FontAwesome.Sharp.IconButton();
            this.btnMonHoc = new FontAwesome.Sharp.IconButton();
            this.btnDanhSachSV = new FontAwesome.Sharp.IconButton();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.btnHome = new System.Windows.Forms.PictureBox();
            this.panelTitleBar = new System.Windows.Forms.Panel();
            this.btnTat = new FontAwesome.Sharp.IconPictureBox();
            this.btnMaxMin = new FontAwesome.Sharp.IconPictureBox();
            this.btnHide = new FontAwesome.Sharp.IconPictureBox();
            this.lbHome = new System.Windows.Forms.Label();
            this.iconHome = new FontAwesome.Sharp.IconPictureBox();
            this.panelDesktop = new System.Windows.Forms.Panel();
            this.panelMenu.SuspendLayout();
            this.panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnHome)).BeginInit();
            this.panelTitleBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnTat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMaxMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnHide)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconHome)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.AllowDrop = true;
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(27)))), ((int)(((byte)(71)))));
            this.panelMenu.Controls.Add(this.btnThongKe);
            this.panelMenu.Controls.Add(this.btnDangXuat);
            this.panelMenu.Controls.Add(this.btnTaiKhoan);
            this.panelMenu.Controls.Add(this.btnCVHT);
            this.panelMenu.Controls.Add(this.btnKhoa);
            this.panelMenu.Controls.Add(this.btnNganh);
            this.panelMenu.Controls.Add(this.btnLop);
            this.panelMenu.Controls.Add(this.btnDiem);
            this.panelMenu.Controls.Add(this.btnMonHoc);
            this.panelMenu.Controls.Add(this.btnDanhSachSV);
            this.panelMenu.Controls.Add(this.panelLogo);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(234, 819);
            this.panelMenu.TabIndex = 0;
            // 
            // btnThongKe
            // 
            this.btnThongKe.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnThongKe.FlatAppearance.BorderSize = 0;
            this.btnThongKe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThongKe.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThongKe.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnThongKe.IconChar = FontAwesome.Sharp.IconChar.ChartColumn;
            this.btnThongKe.IconColor = System.Drawing.Color.Gainsboro;
            this.btnThongKe.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnThongKe.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThongKe.Location = new System.Drawing.Point(0, 693);
            this.btnThongKe.Name = "btnThongKe";
            this.btnThongKe.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnThongKe.Size = new System.Drawing.Size(234, 71);
            this.btnThongKe.TabIndex = 11;
            this.btnThongKe.Text = "Thống kê";
            this.btnThongKe.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThongKe.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnThongKe.UseVisualStyleBackColor = true;
            this.btnThongKe.Click += new System.EventHandler(this.btnThongKe_Click);
            // 
            // btnDangXuat
            // 
            this.btnDangXuat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnDangXuat.AutoSize = true;
            this.btnDangXuat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDangXuat.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnDangXuat.Location = new System.Drawing.Point(65, 785);
            this.btnDangXuat.Name = "btnDangXuat";
            this.btnDangXuat.Size = new System.Drawing.Size(101, 25);
            this.btnDangXuat.TabIndex = 0;
            this.btnDangXuat.Text = "Đăng xuất";
            this.btnDangXuat.Click += new System.EventHandler(this.btnDangXuat_Click);
            // 
            // btnTaiKhoan
            // 
            this.btnTaiKhoan.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnTaiKhoan.FlatAppearance.BorderSize = 0;
            this.btnTaiKhoan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTaiKhoan.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTaiKhoan.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnTaiKhoan.IconChar = FontAwesome.Sharp.IconChar.User;
            this.btnTaiKhoan.IconColor = System.Drawing.Color.Gainsboro;
            this.btnTaiKhoan.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnTaiKhoan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTaiKhoan.Location = new System.Drawing.Point(0, 622);
            this.btnTaiKhoan.Name = "btnTaiKhoan";
            this.btnTaiKhoan.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnTaiKhoan.Size = new System.Drawing.Size(234, 71);
            this.btnTaiKhoan.TabIndex = 10;
            this.btnTaiKhoan.Text = "Tài khoản";
            this.btnTaiKhoan.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTaiKhoan.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTaiKhoan.UseVisualStyleBackColor = true;
            this.btnTaiKhoan.Click += new System.EventHandler(this.btnTaiKhoan_Click_1);
            // 
            // btnCVHT
            // 
            this.btnCVHT.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCVHT.FlatAppearance.BorderSize = 0;
            this.btnCVHT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCVHT.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCVHT.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnCVHT.IconChar = FontAwesome.Sharp.IconChar.UserTie;
            this.btnCVHT.IconColor = System.Drawing.Color.Gainsboro;
            this.btnCVHT.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCVHT.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCVHT.Location = new System.Drawing.Point(0, 551);
            this.btnCVHT.Name = "btnCVHT";
            this.btnCVHT.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnCVHT.Size = new System.Drawing.Size(234, 71);
            this.btnCVHT.TabIndex = 9;
            this.btnCVHT.Text = "CVHT";
            this.btnCVHT.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCVHT.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCVHT.UseVisualStyleBackColor = true;
            this.btnCVHT.Click += new System.EventHandler(this.btnCVHT_Click);
            // 
            // btnKhoa
            // 
            this.btnKhoa.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnKhoa.FlatAppearance.BorderSize = 0;
            this.btnKhoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKhoa.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKhoa.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnKhoa.IconChar = FontAwesome.Sharp.IconChar.University;
            this.btnKhoa.IconColor = System.Drawing.Color.Gainsboro;
            this.btnKhoa.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnKhoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnKhoa.Location = new System.Drawing.Point(0, 480);
            this.btnKhoa.Name = "btnKhoa";
            this.btnKhoa.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnKhoa.Size = new System.Drawing.Size(234, 71);
            this.btnKhoa.TabIndex = 8;
            this.btnKhoa.Text = "Khoa";
            this.btnKhoa.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnKhoa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnKhoa.UseVisualStyleBackColor = true;
            this.btnKhoa.Click += new System.EventHandler(this.btnKhoa_Click);
            // 
            // btnNganh
            // 
            this.btnNganh.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnNganh.FlatAppearance.BorderSize = 0;
            this.btnNganh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNganh.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNganh.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnNganh.IconChar = FontAwesome.Sharp.IconChar.BuildingUser;
            this.btnNganh.IconColor = System.Drawing.Color.Gainsboro;
            this.btnNganh.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnNganh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNganh.Location = new System.Drawing.Point(0, 409);
            this.btnNganh.Name = "btnNganh";
            this.btnNganh.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnNganh.Size = new System.Drawing.Size(234, 71);
            this.btnNganh.TabIndex = 7;
            this.btnNganh.Text = "Ngành";
            this.btnNganh.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNganh.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnNganh.UseVisualStyleBackColor = true;
            this.btnNganh.Click += new System.EventHandler(this.btnNganh_Click);
            // 
            // btnLop
            // 
            this.btnLop.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnLop.FlatAppearance.BorderSize = 0;
            this.btnLop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLop.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLop.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnLop.IconChar = FontAwesome.Sharp.IconChar.ChalkboardTeacher;
            this.btnLop.IconColor = System.Drawing.Color.Gainsboro;
            this.btnLop.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnLop.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLop.Location = new System.Drawing.Point(0, 338);
            this.btnLop.Name = "btnLop";
            this.btnLop.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnLop.Size = new System.Drawing.Size(234, 71);
            this.btnLop.TabIndex = 4;
            this.btnLop.Text = "Lớp";
            this.btnLop.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLop.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLop.UseVisualStyleBackColor = true;
            this.btnLop.Click += new System.EventHandler(this.btnLop_Click);
            // 
            // btnDiem
            // 
            this.btnDiem.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDiem.FlatAppearance.BorderSize = 0;
            this.btnDiem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDiem.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDiem.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnDiem.IconChar = FontAwesome.Sharp.IconChar.Clipboard;
            this.btnDiem.IconColor = System.Drawing.Color.Gainsboro;
            this.btnDiem.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnDiem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDiem.Location = new System.Drawing.Point(0, 267);
            this.btnDiem.Name = "btnDiem";
            this.btnDiem.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnDiem.Size = new System.Drawing.Size(234, 71);
            this.btnDiem.TabIndex = 3;
            this.btnDiem.Text = "Điểm";
            this.btnDiem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDiem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDiem.UseVisualStyleBackColor = true;
            this.btnDiem.Click += new System.EventHandler(this.btnDiem_Click);
            // 
            // btnMonHoc
            // 
            this.btnMonHoc.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMonHoc.FlatAppearance.BorderSize = 0;
            this.btnMonHoc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMonHoc.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMonHoc.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnMonHoc.IconChar = FontAwesome.Sharp.IconChar.Book;
            this.btnMonHoc.IconColor = System.Drawing.Color.Gainsboro;
            this.btnMonHoc.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnMonHoc.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMonHoc.Location = new System.Drawing.Point(0, 196);
            this.btnMonHoc.Name = "btnMonHoc";
            this.btnMonHoc.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnMonHoc.Size = new System.Drawing.Size(234, 71);
            this.btnMonHoc.TabIndex = 2;
            this.btnMonHoc.Text = "Môn Học";
            this.btnMonHoc.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMonHoc.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnMonHoc.UseVisualStyleBackColor = true;
            this.btnMonHoc.Click += new System.EventHandler(this.btnMonHoc_Click);
            // 
            // btnDanhSachSV
            // 
            this.btnDanhSachSV.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDanhSachSV.FlatAppearance.BorderSize = 0;
            this.btnDanhSachSV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDanhSachSV.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDanhSachSV.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnDanhSachSV.IconChar = FontAwesome.Sharp.IconChar.AddressBook;
            this.btnDanhSachSV.IconColor = System.Drawing.Color.Gainsboro;
            this.btnDanhSachSV.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnDanhSachSV.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDanhSachSV.Location = new System.Drawing.Point(0, 125);
            this.btnDanhSachSV.Name = "btnDanhSachSV";
            this.btnDanhSachSV.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnDanhSachSV.Size = new System.Drawing.Size(234, 71);
            this.btnDanhSachSV.TabIndex = 1;
            this.btnDanhSachSV.Text = "Danh Sách SV";
            this.btnDanhSachSV.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDanhSachSV.UseVisualStyleBackColor = true;
            this.btnDanhSachSV.Click += new System.EventHandler(this.btnDanhSachSV_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.Controls.Add(this.btnHome);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(234, 125);
            this.panelLogo.TabIndex = 0;
            // 
            // btnHome
            // 
            this.btnHome.Image = global::GUI.Properties.Resources.logobk;
            this.btnHome.Location = new System.Drawing.Point(53, 7);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(118, 115);
            this.btnHome.TabIndex = 0;
            this.btnHome.TabStop = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // panelTitleBar
            // 
            this.panelTitleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(87)))), ((int)(((byte)(119)))));
            this.panelTitleBar.Controls.Add(this.btnTat);
            this.panelTitleBar.Controls.Add(this.btnMaxMin);
            this.panelTitleBar.Controls.Add(this.btnHide);
            this.panelTitleBar.Controls.Add(this.lbHome);
            this.panelTitleBar.Controls.Add(this.iconHome);
            this.panelTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitleBar.Location = new System.Drawing.Point(234, 0);
            this.panelTitleBar.Name = "panelTitleBar";
            this.panelTitleBar.Size = new System.Drawing.Size(1063, 80);
            this.panelTitleBar.TabIndex = 1;
            this.panelTitleBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTitleBar_MouseDown);
            // 
            // btnTat
            // 
            this.btnTat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(87)))), ((int)(((byte)(119)))));
            this.btnTat.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnTat.IconChar = FontAwesome.Sharp.IconChar.Xmark;
            this.btnTat.IconColor = System.Drawing.Color.Gainsboro;
            this.btnTat.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnTat.IconSize = 37;
            this.btnTat.Location = new System.Drawing.Point(1020, 12);
            this.btnTat.Name = "btnTat";
            this.btnTat.Size = new System.Drawing.Size(37, 40);
            this.btnTat.TabIndex = 4;
            this.btnTat.TabStop = false;
            this.btnTat.Click += new System.EventHandler(this.btnTat_Click);
            // 
            // btnMaxMin
            // 
            this.btnMaxMin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMaxMin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(87)))), ((int)(((byte)(119)))));
            this.btnMaxMin.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnMaxMin.IconChar = FontAwesome.Sharp.IconChar.WindowMaximize;
            this.btnMaxMin.IconColor = System.Drawing.Color.Gainsboro;
            this.btnMaxMin.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnMaxMin.IconSize = 40;
            this.btnMaxMin.Location = new System.Drawing.Point(967, 12);
            this.btnMaxMin.Name = "btnMaxMin";
            this.btnMaxMin.Size = new System.Drawing.Size(40, 40);
            this.btnMaxMin.TabIndex = 3;
            this.btnMaxMin.TabStop = false;
            this.btnMaxMin.Click += new System.EventHandler(this.btnMaxMin_Click);
            // 
            // btnHide
            // 
            this.btnHide.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnHide.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(87)))), ((int)(((byte)(119)))));
            this.btnHide.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnHide.IconChar = FontAwesome.Sharp.IconChar.Minus;
            this.btnHide.IconColor = System.Drawing.Color.Gainsboro;
            this.btnHide.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnHide.IconSize = 37;
            this.btnHide.Location = new System.Drawing.Point(920, 12);
            this.btnHide.Name = "btnHide";
            this.btnHide.Size = new System.Drawing.Size(37, 37);
            this.btnHide.TabIndex = 2;
            this.btnHide.TabStop = false;
            this.btnHide.Click += new System.EventHandler(this.btnHide_Click);
            // 
            // lbHome
            // 
            this.lbHome.AutoSize = true;
            this.lbHome.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbHome.ForeColor = System.Drawing.Color.Gainsboro;
            this.lbHome.Location = new System.Drawing.Point(69, 31);
            this.lbHome.Name = "lbHome";
            this.lbHome.Size = new System.Drawing.Size(61, 25);
            this.lbHome.TabIndex = 1;
            this.lbHome.Text = "Home";
            // 
            // iconHome
            // 
            this.iconHome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(87)))), ((int)(((byte)(119)))));
            this.iconHome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(27)))), ((int)(((byte)(71)))));
            this.iconHome.IconChar = FontAwesome.Sharp.IconChar.House;
            this.iconHome.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(27)))), ((int)(((byte)(71)))));
            this.iconHome.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconHome.IconSize = 45;
            this.iconHome.Location = new System.Drawing.Point(18, 21);
            this.iconHome.Name = "iconHome";
            this.iconHome.Size = new System.Drawing.Size(45, 45);
            this.iconHome.TabIndex = 0;
            this.iconHome.TabStop = false;
            // 
            // panelDesktop
            // 
            this.panelDesktop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(153)))), ((int)(((byte)(174)))));
            this.panelDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktop.Location = new System.Drawing.Point(234, 80);
            this.panelDesktop.MinimumSize = new System.Drawing.Size(1061, 653);
            this.panelDesktop.Name = "panelDesktop";
            this.panelDesktop.Size = new System.Drawing.Size(1063, 739);
            this.panelDesktop.TabIndex = 2;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.ClientSize = new System.Drawing.Size(1297, 819);
            this.ControlBox = false;
            this.Controls.Add(this.panelDesktop);
            this.Controls.Add(this.panelTitleBar);
            this.Controls.Add(this.panelMenu);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.panelMenu.ResumeLayout(false);
            this.panelMenu.PerformLayout();
            this.panelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnHome)).EndInit();
            this.panelTitleBar.ResumeLayout(false);
            this.panelTitleBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnTat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMaxMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnHide)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconHome)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private FontAwesome.Sharp.IconButton btnDanhSachSV;
        private System.Windows.Forms.Panel panelLogo;
        private FontAwesome.Sharp.IconButton btnLop;
        private FontAwesome.Sharp.IconButton btnDiem;
        private FontAwesome.Sharp.IconButton btnMonHoc;
        private System.Windows.Forms.Panel panelTitleBar;
        private FontAwesome.Sharp.IconPictureBox iconHome;
        private System.Windows.Forms.Label lbHome;
        private System.Windows.Forms.Panel panelDesktop;
        private FontAwesome.Sharp.IconPictureBox btnMaxMin;
        private FontAwesome.Sharp.IconPictureBox btnHide;
        private FontAwesome.Sharp.IconPictureBox btnTat;
        private FontAwesome.Sharp.IconButton btnKhoa;
        private FontAwesome.Sharp.IconButton btnNganh;
        private FontAwesome.Sharp.IconButton btnCVHT;
        private FontAwesome.Sharp.IconButton btnTaiKhoan;
        private System.Windows.Forms.PictureBox btnHome;
        private System.Windows.Forms.Label btnDangXuat;
        private FontAwesome.Sharp.IconButton btnThongKe;
    }
}

