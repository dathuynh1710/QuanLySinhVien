namespace GUI.Form_Giao_Dien
{
    partial class frmTaiKhoan
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
            this.btnXoaTaiKhoan = new GUI.DesignButton();
            this.btnCapNhatTaiKhoan = new GUI.DesignButton();
            this.btnThemTaiKhoan = new GUI.DesignButton();
            this.panelGroup = new System.Windows.Forms.Panel();
            this.cboLoaiTaiKhoan = new GUI.Controls.DesignComboBox();
            this.dgvTaiKhoan = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMatKhau = new GUI.Controls.DesignTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTenDangNhap = new GUI.Controls.DesignTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panelGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTaiKhoan)).BeginInit();
            this.SuspendLayout();
            // 
            // btnXoaTaiKhoan
            // 
            this.btnXoaTaiKhoan.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnXoaTaiKhoan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(218)))), ((int)(((byte)(208)))));
            this.btnXoaTaiKhoan.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(218)))), ((int)(((byte)(208)))));
            this.btnXoaTaiKhoan.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnXoaTaiKhoan.BorderRadius = 40;
            this.btnXoaTaiKhoan.BorderSize = 0;
            this.btnXoaTaiKhoan.FlatAppearance.BorderSize = 0;
            this.btnXoaTaiKhoan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoaTaiKhoan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaTaiKhoan.ForeColor = System.Drawing.Color.Black;
            this.btnXoaTaiKhoan.Location = new System.Drawing.Point(495, 533);
            this.btnXoaTaiKhoan.Name = "btnXoaTaiKhoan";
            this.btnXoaTaiKhoan.Size = new System.Drawing.Size(160, 53);
            this.btnXoaTaiKhoan.TabIndex = 35;
            this.btnXoaTaiKhoan.Text = "Xóa Tài Khoản";
            this.btnXoaTaiKhoan.TextColor = System.Drawing.Color.Black;
            this.btnXoaTaiKhoan.UseVisualStyleBackColor = false;
            this.btnXoaTaiKhoan.Click += new System.EventHandler(this.btnXoaTaiKhoan_Click);
            // 
            // btnCapNhatTaiKhoan
            // 
            this.btnCapNhatTaiKhoan.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCapNhatTaiKhoan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(218)))), ((int)(((byte)(208)))));
            this.btnCapNhatTaiKhoan.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(218)))), ((int)(((byte)(208)))));
            this.btnCapNhatTaiKhoan.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnCapNhatTaiKhoan.BorderRadius = 40;
            this.btnCapNhatTaiKhoan.BorderSize = 0;
            this.btnCapNhatTaiKhoan.FlatAppearance.BorderSize = 0;
            this.btnCapNhatTaiKhoan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCapNhatTaiKhoan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCapNhatTaiKhoan.ForeColor = System.Drawing.Color.Black;
            this.btnCapNhatTaiKhoan.Location = new System.Drawing.Point(672, 533);
            this.btnCapNhatTaiKhoan.Name = "btnCapNhatTaiKhoan";
            this.btnCapNhatTaiKhoan.Size = new System.Drawing.Size(177, 53);
            this.btnCapNhatTaiKhoan.TabIndex = 34;
            this.btnCapNhatTaiKhoan.Text = "Cập Nhật Tài Khoản";
            this.btnCapNhatTaiKhoan.TextColor = System.Drawing.Color.Black;
            this.btnCapNhatTaiKhoan.UseVisualStyleBackColor = false;
            this.btnCapNhatTaiKhoan.Click += new System.EventHandler(this.btnCapNhatTaiKhoan_Click);
            // 
            // btnThemTaiKhoan
            // 
            this.btnThemTaiKhoan.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnThemTaiKhoan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(218)))), ((int)(((byte)(208)))));
            this.btnThemTaiKhoan.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(218)))), ((int)(((byte)(208)))));
            this.btnThemTaiKhoan.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnThemTaiKhoan.BorderRadius = 40;
            this.btnThemTaiKhoan.BorderSize = 0;
            this.btnThemTaiKhoan.FlatAppearance.BorderSize = 0;
            this.btnThemTaiKhoan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThemTaiKhoan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemTaiKhoan.ForeColor = System.Drawing.Color.Black;
            this.btnThemTaiKhoan.Location = new System.Drawing.Point(866, 533);
            this.btnThemTaiKhoan.Name = "btnThemTaiKhoan";
            this.btnThemTaiKhoan.Size = new System.Drawing.Size(160, 53);
            this.btnThemTaiKhoan.TabIndex = 33;
            this.btnThemTaiKhoan.Text = "Thêm Tài Khoản";
            this.btnThemTaiKhoan.TextColor = System.Drawing.Color.Black;
            this.btnThemTaiKhoan.UseVisualStyleBackColor = false;
            this.btnThemTaiKhoan.Click += new System.EventHandler(this.btnThemTaiKhoan_Click);
            // 
            // panelGroup
            // 
            this.panelGroup.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelGroup.Controls.Add(this.cboLoaiTaiKhoan);
            this.panelGroup.Controls.Add(this.dgvTaiKhoan);
            this.panelGroup.Controls.Add(this.label4);
            this.panelGroup.Controls.Add(this.txtMatKhau);
            this.panelGroup.Controls.Add(this.label3);
            this.panelGroup.Controls.Add(this.txtTenDangNhap);
            this.panelGroup.Controls.Add(this.label2);
            this.panelGroup.Location = new System.Drawing.Point(132, 68);
            this.panelGroup.Name = "panelGroup";
            this.panelGroup.Size = new System.Drawing.Size(811, 459);
            this.panelGroup.TabIndex = 32;
            // 
            // cboLoaiTaiKhoan
            // 
            this.cboLoaiTaiKhoan.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cboLoaiTaiKhoan.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.cboLoaiTaiKhoan.BorderSize = 1;
            this.cboLoaiTaiKhoan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.cboLoaiTaiKhoan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboLoaiTaiKhoan.ForeColor = System.Drawing.Color.DimGray;
            this.cboLoaiTaiKhoan.IconColor = System.Drawing.Color.MediumSlateBlue;
            this.cboLoaiTaiKhoan.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.cboLoaiTaiKhoan.ListTextColor = System.Drawing.Color.DimGray;
            this.cboLoaiTaiKhoan.Location = new System.Drawing.Point(359, 77);
            this.cboLoaiTaiKhoan.MinimumSize = new System.Drawing.Size(200, 30);
            this.cboLoaiTaiKhoan.Name = "cboLoaiTaiKhoan";
            this.cboLoaiTaiKhoan.Padding = new System.Windows.Forms.Padding(1);
            this.cboLoaiTaiKhoan.Size = new System.Drawing.Size(216, 30);
            this.cboLoaiTaiKhoan.TabIndex = 9;
            this.cboLoaiTaiKhoan.Texts = "";
            // 
            // dgvTaiKhoan
            // 
            this.dgvTaiKhoan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTaiKhoan.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvTaiKhoan.Location = new System.Drawing.Point(0, 125);
            this.dgvTaiKhoan.Name = "dgvTaiKhoan";
            this.dgvTaiKhoan.ReadOnly = true;
            this.dgvTaiKhoan.RowHeadersWidth = 51;
            this.dgvTaiKhoan.RowTemplate.Height = 24;
            this.dgvTaiKhoan.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTaiKhoan.Size = new System.Drawing.Size(811, 334);
            this.dgvTaiKhoan.TabIndex = 8;
            this.dgvTaiKhoan.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTaiKhoan_CellClick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(237, 82);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Loại tài khoản:";
            // 
            // txtMatKhau
            // 
            this.txtMatKhau.BackColor = System.Drawing.SystemColors.Window;
            this.txtMatKhau.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtMatKhau.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtMatKhau.BorderRadius = 0;
            this.txtMatKhau.BorderSize = 2;
            this.txtMatKhau.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMatKhau.ForeColor = System.Drawing.Color.DimGray;
            this.txtMatKhau.Location = new System.Drawing.Point(516, 19);
            this.txtMatKhau.Margin = new System.Windows.Forms.Padding(4);
            this.txtMatKhau.Multiline = false;
            this.txtMatKhau.Name = "txtMatKhau";
            this.txtMatKhau.Padding = new System.Windows.Forms.Padding(7);
            this.txtMatKhau.PasswordChar = false;
            this.txtMatKhau.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtMatKhau.PlaceholderText = "";
            this.txtMatKhau.ReadOnly = false;
            this.txtMatKhau.Size = new System.Drawing.Size(205, 35);
            this.txtMatKhau.TabIndex = 5;
            this.txtMatKhau.TextString = "";
            this.txtMatKhau.UnderlinedStyle = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(426, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Mật khẩu:";
            // 
            // txtTenDangNhap
            // 
            this.txtTenDangNhap.BackColor = System.Drawing.SystemColors.Window;
            this.txtTenDangNhap.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtTenDangNhap.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtTenDangNhap.BorderRadius = 0;
            this.txtTenDangNhap.BorderSize = 2;
            this.txtTenDangNhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenDangNhap.ForeColor = System.Drawing.Color.DimGray;
            this.txtTenDangNhap.Location = new System.Drawing.Point(192, 19);
            this.txtTenDangNhap.Margin = new System.Windows.Forms.Padding(4);
            this.txtTenDangNhap.Multiline = false;
            this.txtTenDangNhap.Name = "txtTenDangNhap";
            this.txtTenDangNhap.Padding = new System.Windows.Forms.Padding(7);
            this.txtTenDangNhap.PasswordChar = false;
            this.txtTenDangNhap.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtTenDangNhap.PlaceholderText = "";
            this.txtTenDangNhap.ReadOnly = false;
            this.txtTenDangNhap.Size = new System.Drawing.Size(200, 35);
            this.txtTenDangNhap.TabIndex = 3;
            this.txtTenDangNhap.TextString = "";
            this.txtTenDangNhap.UnderlinedStyle = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(68, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tên đăng nhập:";
            // 
            // frmTaiKhoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(153)))), ((int)(((byte)(174)))));
            this.ClientSize = new System.Drawing.Size(1043, 606);
            this.Controls.Add(this.btnXoaTaiKhoan);
            this.Controls.Add(this.btnCapNhatTaiKhoan);
            this.Controls.Add(this.btnThemTaiKhoan);
            this.Controls.Add(this.panelGroup);
            this.Name = "frmTaiKhoan";
            this.Text = "Tài Khoản";
            this.Load += new System.EventHandler(this.frmTaiKhoan_Load);
            this.panelGroup.ResumeLayout(false);
            this.panelGroup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTaiKhoan)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DesignButton btnXoaTaiKhoan;
        private DesignButton btnCapNhatTaiKhoan;
        private DesignButton btnThemTaiKhoan;
        private System.Windows.Forms.Panel panelGroup;
        private Controls.DesignComboBox cboLoaiTaiKhoan;
        private System.Windows.Forms.DataGridView dgvTaiKhoan;
        private System.Windows.Forms.Label label4;
        private Controls.DesignTextBox txtMatKhau;
        private System.Windows.Forms.Label label3;
        private Controls.DesignTextBox txtTenDangNhap;
        private System.Windows.Forms.Label label2;
    }
}