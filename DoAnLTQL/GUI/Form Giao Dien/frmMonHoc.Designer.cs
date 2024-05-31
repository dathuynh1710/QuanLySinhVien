namespace GUI.Form_Giao_Dien
{
    partial class frmMonHoc
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
            this.txtTietThucHanh = new GUI.Controls.DesignTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTietLyThuyet = new GUI.Controls.DesignTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSoTinChi = new GUI.Controls.DesignTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTenMonHoc = new GUI.Controls.DesignTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMaMonHoc = new GUI.Controls.DesignTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvMonHoc = new System.Windows.Forms.DataGridView();
            this.btnXoaMonHoc = new GUI.DesignButton();
            this.btnCapNhatMonHoc = new GUI.DesignButton();
            this.btnThemMonHoc = new GUI.DesignButton();
            this.label6 = new System.Windows.Forms.Label();
            this.cboLocMonHoc = new GUI.Controls.DesignComboBox();
            this.btnKhoiPhuc = new GUI.DesignButton();
            this.panelGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMonHoc)).BeginInit();
            this.SuspendLayout();
            // 
            // panelGroup
            // 
            this.panelGroup.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelGroup.Controls.Add(this.txtTietThucHanh);
            this.panelGroup.Controls.Add(this.label5);
            this.panelGroup.Controls.Add(this.txtTietLyThuyet);
            this.panelGroup.Controls.Add(this.label1);
            this.panelGroup.Controls.Add(this.txtSoTinChi);
            this.panelGroup.Controls.Add(this.label4);
            this.panelGroup.Controls.Add(this.txtTenMonHoc);
            this.panelGroup.Controls.Add(this.label3);
            this.panelGroup.Controls.Add(this.txtMaMonHoc);
            this.panelGroup.Controls.Add(this.label2);
            this.panelGroup.Controls.Add(this.dgvMonHoc);
            this.panelGroup.Location = new System.Drawing.Point(73, 42);
            this.panelGroup.Name = "panelGroup";
            this.panelGroup.Size = new System.Drawing.Size(908, 472);
            this.panelGroup.TabIndex = 36;
            // 
            // txtTietThucHanh
            // 
            this.txtTietThucHanh.BackColor = System.Drawing.SystemColors.Window;
            this.txtTietThucHanh.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtTietThucHanh.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtTietThucHanh.BorderRadius = 0;
            this.txtTietThucHanh.BorderSize = 2;
            this.txtTietThucHanh.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTietThucHanh.ForeColor = System.Drawing.Color.DimGray;
            this.txtTietThucHanh.Location = new System.Drawing.Point(582, 73);
            this.txtTietThucHanh.Margin = new System.Windows.Forms.Padding(4);
            this.txtTietThucHanh.Multiline = false;
            this.txtTietThucHanh.Name = "txtTietThucHanh";
            this.txtTietThucHanh.Padding = new System.Windows.Forms.Padding(7);
            this.txtTietThucHanh.PasswordChar = false;
            this.txtTietThucHanh.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtTietThucHanh.PlaceholderText = "";
            this.txtTietThucHanh.ReadOnly = false;
            this.txtTietThucHanh.Size = new System.Drawing.Size(181, 35);
            this.txtTietThucHanh.TabIndex = 21;
            this.txtTietThucHanh.TextString = "";
            this.txtTietThucHanh.UnderlinedStyle = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(448, 80);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(114, 20);
            this.label5.TabIndex = 20;
            this.label5.Text = "Tiết thực hành:";
            // 
            // txtTietLyThuyet
            // 
            this.txtTietLyThuyet.BackColor = System.Drawing.SystemColors.Window;
            this.txtTietLyThuyet.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtTietLyThuyet.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtTietLyThuyet.BorderRadius = 0;
            this.txtTietLyThuyet.BorderSize = 2;
            this.txtTietLyThuyet.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTietLyThuyet.ForeColor = System.Drawing.Color.DimGray;
            this.txtTietLyThuyet.Location = new System.Drawing.Point(247, 73);
            this.txtTietLyThuyet.Margin = new System.Windows.Forms.Padding(4);
            this.txtTietLyThuyet.Multiline = false;
            this.txtTietLyThuyet.Name = "txtTietLyThuyet";
            this.txtTietLyThuyet.Padding = new System.Windows.Forms.Padding(7);
            this.txtTietLyThuyet.PasswordChar = false;
            this.txtTietLyThuyet.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtTietLyThuyet.PlaceholderText = "";
            this.txtTietLyThuyet.ReadOnly = false;
            this.txtTietLyThuyet.Size = new System.Drawing.Size(181, 35);
            this.txtTietLyThuyet.TabIndex = 19;
            this.txtTietLyThuyet.TextString = "";
            this.txtTietLyThuyet.UnderlinedStyle = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(126, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 20);
            this.label1.TabIndex = 18;
            this.label1.Text = "Tiết lý thuyết:";
            // 
            // txtSoTinChi
            // 
            this.txtSoTinChi.BackColor = System.Drawing.SystemColors.Window;
            this.txtSoTinChi.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtSoTinChi.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtSoTinChi.BorderRadius = 0;
            this.txtSoTinChi.BorderSize = 2;
            this.txtSoTinChi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSoTinChi.ForeColor = System.Drawing.Color.DimGray;
            this.txtSoTinChi.Location = new System.Drawing.Point(728, 19);
            this.txtSoTinChi.Margin = new System.Windows.Forms.Padding(4);
            this.txtSoTinChi.Multiline = false;
            this.txtSoTinChi.Name = "txtSoTinChi";
            this.txtSoTinChi.Padding = new System.Windows.Forms.Padding(7);
            this.txtSoTinChi.PasswordChar = false;
            this.txtSoTinChi.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtSoTinChi.PlaceholderText = "";
            this.txtSoTinChi.ReadOnly = false;
            this.txtSoTinChi.Size = new System.Drawing.Size(145, 35);
            this.txtSoTinChi.TabIndex = 17;
            this.txtSoTinChi.TextString = "";
            this.txtSoTinChi.UnderlinedStyle = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(635, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 20);
            this.label4.TabIndex = 16;
            this.label4.Text = "Số tín chỉ:";
            // 
            // txtTenMonHoc
            // 
            this.txtTenMonHoc.BackColor = System.Drawing.SystemColors.Window;
            this.txtTenMonHoc.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtTenMonHoc.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtTenMonHoc.BorderRadius = 0;
            this.txtTenMonHoc.BorderSize = 2;
            this.txtTenMonHoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenMonHoc.ForeColor = System.Drawing.Color.DimGray;
            this.txtTenMonHoc.Location = new System.Drawing.Point(425, 19);
            this.txtTenMonHoc.Margin = new System.Windows.Forms.Padding(4);
            this.txtTenMonHoc.Multiline = false;
            this.txtTenMonHoc.Name = "txtTenMonHoc";
            this.txtTenMonHoc.Padding = new System.Windows.Forms.Padding(7);
            this.txtTenMonHoc.PasswordChar = false;
            this.txtTenMonHoc.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtTenMonHoc.PlaceholderText = "";
            this.txtTenMonHoc.ReadOnly = false;
            this.txtTenMonHoc.Size = new System.Drawing.Size(195, 35);
            this.txtTenMonHoc.TabIndex = 15;
            this.txtTenMonHoc.TextString = "";
            this.txtTenMonHoc.UnderlinedStyle = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(305, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 20);
            this.label3.TabIndex = 14;
            this.label3.Text = "Tên Môn học:";
            // 
            // txtMaMonHoc
            // 
            this.txtMaMonHoc.BackColor = System.Drawing.SystemColors.Window;
            this.txtMaMonHoc.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtMaMonHoc.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtMaMonHoc.BorderRadius = 0;
            this.txtMaMonHoc.BorderSize = 2;
            this.txtMaMonHoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaMonHoc.ForeColor = System.Drawing.Color.DimGray;
            this.txtMaMonHoc.Location = new System.Drawing.Point(126, 19);
            this.txtMaMonHoc.Margin = new System.Windows.Forms.Padding(4);
            this.txtMaMonHoc.Multiline = false;
            this.txtMaMonHoc.Name = "txtMaMonHoc";
            this.txtMaMonHoc.Padding = new System.Windows.Forms.Padding(7);
            this.txtMaMonHoc.PasswordChar = false;
            this.txtMaMonHoc.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtMaMonHoc.PlaceholderText = "";
            this.txtMaMonHoc.ReadOnly = false;
            this.txtMaMonHoc.Size = new System.Drawing.Size(164, 35);
            this.txtMaMonHoc.TabIndex = 13;
            this.txtMaMonHoc.TextString = "";
            this.txtMaMonHoc.UnderlinedStyle = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(11, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 20);
            this.label2.TabIndex = 12;
            this.label2.Text = "Mã Môn học:";
            // 
            // dgvMonHoc
            // 
            this.dgvMonHoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMonHoc.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvMonHoc.Location = new System.Drawing.Point(0, 134);
            this.dgvMonHoc.Name = "dgvMonHoc";
            this.dgvMonHoc.ReadOnly = true;
            this.dgvMonHoc.RowHeadersWidth = 51;
            this.dgvMonHoc.RowTemplate.Height = 24;
            this.dgvMonHoc.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMonHoc.Size = new System.Drawing.Size(908, 338);
            this.dgvMonHoc.TabIndex = 8;
            this.dgvMonHoc.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMonHoc_CellClick);
            // 
            // btnXoaMonHoc
            // 
            this.btnXoaMonHoc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnXoaMonHoc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(218)))), ((int)(((byte)(208)))));
            this.btnXoaMonHoc.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(218)))), ((int)(((byte)(208)))));
            this.btnXoaMonHoc.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnXoaMonHoc.BorderRadius = 40;
            this.btnXoaMonHoc.BorderSize = 0;
            this.btnXoaMonHoc.FlatAppearance.BorderSize = 0;
            this.btnXoaMonHoc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoaMonHoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaMonHoc.ForeColor = System.Drawing.Color.Black;
            this.btnXoaMonHoc.Location = new System.Drawing.Point(522, 532);
            this.btnXoaMonHoc.Name = "btnXoaMonHoc";
            this.btnXoaMonHoc.Size = new System.Drawing.Size(160, 53);
            this.btnXoaMonHoc.TabIndex = 39;
            this.btnXoaMonHoc.Text = "Xóa Môn Học";
            this.btnXoaMonHoc.TextColor = System.Drawing.Color.Black;
            this.btnXoaMonHoc.UseVisualStyleBackColor = false;
            this.btnXoaMonHoc.Click += new System.EventHandler(this.btnXoaMonHoc_Click);
            // 
            // btnCapNhatMonHoc
            // 
            this.btnCapNhatMonHoc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCapNhatMonHoc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(218)))), ((int)(((byte)(208)))));
            this.btnCapNhatMonHoc.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(218)))), ((int)(((byte)(208)))));
            this.btnCapNhatMonHoc.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnCapNhatMonHoc.BorderRadius = 40;
            this.btnCapNhatMonHoc.BorderSize = 0;
            this.btnCapNhatMonHoc.FlatAppearance.BorderSize = 0;
            this.btnCapNhatMonHoc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCapNhatMonHoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCapNhatMonHoc.ForeColor = System.Drawing.Color.Black;
            this.btnCapNhatMonHoc.Location = new System.Drawing.Point(695, 532);
            this.btnCapNhatMonHoc.Name = "btnCapNhatMonHoc";
            this.btnCapNhatMonHoc.Size = new System.Drawing.Size(160, 53);
            this.btnCapNhatMonHoc.TabIndex = 38;
            this.btnCapNhatMonHoc.Text = "Cập Nhật Môn Học";
            this.btnCapNhatMonHoc.TextColor = System.Drawing.Color.Black;
            this.btnCapNhatMonHoc.UseVisualStyleBackColor = false;
            this.btnCapNhatMonHoc.Click += new System.EventHandler(this.btnCapNhatMonHoc_Click);
            // 
            // btnThemMonHoc
            // 
            this.btnThemMonHoc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnThemMonHoc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(218)))), ((int)(((byte)(208)))));
            this.btnThemMonHoc.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(218)))), ((int)(((byte)(208)))));
            this.btnThemMonHoc.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnThemMonHoc.BorderRadius = 40;
            this.btnThemMonHoc.BorderSize = 0;
            this.btnThemMonHoc.FlatAppearance.BorderSize = 0;
            this.btnThemMonHoc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThemMonHoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemMonHoc.ForeColor = System.Drawing.Color.Black;
            this.btnThemMonHoc.Location = new System.Drawing.Point(868, 532);
            this.btnThemMonHoc.Name = "btnThemMonHoc";
            this.btnThemMonHoc.Size = new System.Drawing.Size(160, 53);
            this.btnThemMonHoc.TabIndex = 37;
            this.btnThemMonHoc.Text = "Thêm Môn Học";
            this.btnThemMonHoc.TextColor = System.Drawing.Color.Black;
            this.btnThemMonHoc.UseVisualStyleBackColor = false;
            this.btnThemMonHoc.Click += new System.EventHandler(this.btnThemMonHoc_Click);
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(693, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(104, 20);
            this.label6.TabIndex = 22;
            this.label6.Text = "Lọc môn học:";
            // 
            // cboLocMonHoc
            // 
            this.cboLocMonHoc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cboLocMonHoc.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cboLocMonHoc.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.cboLocMonHoc.BorderSize = 1;
            this.cboLocMonHoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.cboLocMonHoc.ForeColor = System.Drawing.Color.DimGray;
            this.cboLocMonHoc.IconColor = System.Drawing.Color.MediumSlateBlue;
            this.cboLocMonHoc.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.cboLocMonHoc.ListTextColor = System.Drawing.Color.DimGray;
            this.cboLocMonHoc.Location = new System.Drawing.Point(810, 4);
            this.cboLocMonHoc.MinimumSize = new System.Drawing.Size(200, 30);
            this.cboLocMonHoc.Name = "cboLocMonHoc";
            this.cboLocMonHoc.Padding = new System.Windows.Forms.Padding(1);
            this.cboLocMonHoc.Size = new System.Drawing.Size(202, 30);
            this.cboLocMonHoc.TabIndex = 40;
            this.cboLocMonHoc.Texts = "";
            this.cboLocMonHoc.OnSelectedIndexChanged += new System.EventHandler(this.cboLocMonHoc_OnSelectedIndexChanged);
            // 
            // btnKhoiPhuc
            // 
            this.btnKhoiPhuc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnKhoiPhuc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(218)))), ((int)(((byte)(208)))));
            this.btnKhoiPhuc.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(218)))), ((int)(((byte)(208)))));
            this.btnKhoiPhuc.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnKhoiPhuc.BorderRadius = 40;
            this.btnKhoiPhuc.BorderSize = 0;
            this.btnKhoiPhuc.FlatAppearance.BorderSize = 0;
            this.btnKhoiPhuc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKhoiPhuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKhoiPhuc.ForeColor = System.Drawing.Color.Black;
            this.btnKhoiPhuc.Location = new System.Drawing.Point(345, 532);
            this.btnKhoiPhuc.Name = "btnKhoiPhuc";
            this.btnKhoiPhuc.Size = new System.Drawing.Size(160, 53);
            this.btnKhoiPhuc.TabIndex = 41;
            this.btnKhoiPhuc.Text = "Khôi phục";
            this.btnKhoiPhuc.TextColor = System.Drawing.Color.Black;
            this.btnKhoiPhuc.UseVisualStyleBackColor = false;
            this.btnKhoiPhuc.Click += new System.EventHandler(this.btnKhoiPhuc_Click);
            // 
            // frmMonHoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(153)))), ((int)(((byte)(174)))));
            this.ClientSize = new System.Drawing.Size(1043, 606);
            this.Controls.Add(this.btnKhoiPhuc);
            this.Controls.Add(this.cboLocMonHoc);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.panelGroup);
            this.Controls.Add(this.btnXoaMonHoc);
            this.Controls.Add(this.btnCapNhatMonHoc);
            this.Controls.Add(this.btnThemMonHoc);
            this.Name = "frmMonHoc";
            this.Text = "Môn Học";
            this.Load += new System.EventHandler(this.frmMonHoc_Load);
            this.panelGroup.ResumeLayout(false);
            this.panelGroup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMonHoc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelGroup;
        private Controls.DesignTextBox txtSoTinChi;
        private System.Windows.Forms.Label label4;
        private Controls.DesignTextBox txtTenMonHoc;
        private System.Windows.Forms.Label label3;
        private Controls.DesignTextBox txtMaMonHoc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvMonHoc;
        private DesignButton btnXoaMonHoc;
        private DesignButton btnCapNhatMonHoc;
        private DesignButton btnThemMonHoc;
        private Controls.DesignTextBox txtTietThucHanh;
        private System.Windows.Forms.Label label5;
        private Controls.DesignTextBox txtTietLyThuyet;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private Controls.DesignComboBox cboLocMonHoc;
        private DesignButton btnKhoiPhuc;
    }
}