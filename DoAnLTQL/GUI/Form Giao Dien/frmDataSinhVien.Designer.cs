namespace GUI.Form_Giao_Dien
{
    partial class frmDataSinhVien
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvSinhVien = new System.Windows.Forms.DataGridView();
            this.btnDoiKieu = new GUI.DesignButton();
            this.cboChonLop = new GUI.Controls.DesignComboBox();
            this.btnThemSinhVien = new GUI.DesignButton();
            this.cboHienSinhVien = new GUI.Controls.DesignComboBox();
            this.txtTimSinhVien = new GUI.Controls.DesignTextBox();
            this.btnTimKiem = new GUI.DesignButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSinhVien)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.dgvSinhVien);
            this.panel1.Location = new System.Drawing.Point(0, 40);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1043, 654);
            this.panel1.TabIndex = 12;
            // 
            // dgvSinhVien
            // 
            this.dgvSinhVien.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvSinhVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSinhVien.Location = new System.Drawing.Point(0, 0);
            this.dgvSinhVien.Name = "dgvSinhVien";
            this.dgvSinhVien.ReadOnly = true;
            this.dgvSinhVien.RowHeadersWidth = 51;
            this.dgvSinhVien.RowTemplate.Height = 24;
            this.dgvSinhVien.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSinhVien.Size = new System.Drawing.Size(1043, 651);
            this.dgvSinhVien.TabIndex = 0;
            this.dgvSinhVien.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSinhVien_CellClick);
            // 
            // btnDoiKieu
            // 
            this.btnDoiKieu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(218)))), ((int)(((byte)(208)))));
            this.btnDoiKieu.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(218)))), ((int)(((byte)(208)))));
            this.btnDoiKieu.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnDoiKieu.BorderRadius = 30;
            this.btnDoiKieu.BorderSize = 0;
            this.btnDoiKieu.FlatAppearance.BorderSize = 0;
            this.btnDoiKieu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDoiKieu.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDoiKieu.ForeColor = System.Drawing.Color.Black;
            this.btnDoiKieu.Location = new System.Drawing.Point(12, 2);
            this.btnDoiKieu.Name = "btnDoiKieu";
            this.btnDoiKieu.Size = new System.Drawing.Size(102, 32);
            this.btnDoiKieu.TabIndex = 13;
            this.btnDoiKieu.Text = "Đổi kiểu";
            this.btnDoiKieu.TextColor = System.Drawing.Color.Black;
            this.btnDoiKieu.UseVisualStyleBackColor = false;
            this.btnDoiKieu.Click += new System.EventHandler(this.btnDoiKieu_Click);
            // 
            // cboChonLop
            // 
            this.cboChonLop.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cboChonLop.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.cboChonLop.BorderSize = 1;
            this.cboChonLop.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.cboChonLop.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboChonLop.ForeColor = System.Drawing.Color.DimGray;
            this.cboChonLop.IconColor = System.Drawing.Color.MediumSlateBlue;
            this.cboChonLop.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.cboChonLop.ListTextColor = System.Drawing.Color.DimGray;
            this.cboChonLop.Location = new System.Drawing.Point(325, 4);
            this.cboChonLop.MinimumSize = new System.Drawing.Size(200, 30);
            this.cboChonLop.Name = "cboChonLop";
            this.cboChonLop.Padding = new System.Windows.Forms.Padding(1);
            this.cboChonLop.Size = new System.Drawing.Size(200, 30);
            this.cboChonLop.TabIndex = 11;
            this.cboChonLop.Texts = "---Chọn lớp---";
            this.cboChonLop.OnSelectedIndexChanged += new System.EventHandler(this.cboChonLop_OnSelectedIndexChanged);
            // 
            // btnThemSinhVien
            // 
            this.btnThemSinhVien.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnThemSinhVien.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(218)))), ((int)(((byte)(208)))));
            this.btnThemSinhVien.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(218)))), ((int)(((byte)(208)))));
            this.btnThemSinhVien.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnThemSinhVien.BorderRadius = 30;
            this.btnThemSinhVien.BorderSize = 0;
            this.btnThemSinhVien.FlatAppearance.BorderSize = 0;
            this.btnThemSinhVien.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThemSinhVien.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemSinhVien.ForeColor = System.Drawing.Color.Black;
            this.btnThemSinhVien.Location = new System.Drawing.Point(900, 2);
            this.btnThemSinhVien.Name = "btnThemSinhVien";
            this.btnThemSinhVien.Size = new System.Drawing.Size(145, 32);
            this.btnThemSinhVien.TabIndex = 10;
            this.btnThemSinhVien.Text = "Thêm Sinh Viên";
            this.btnThemSinhVien.TextColor = System.Drawing.Color.Black;
            this.btnThemSinhVien.UseVisualStyleBackColor = false;
            this.btnThemSinhVien.Click += new System.EventHandler(this.btnThemSinhVien_Click);
            // 
            // cboHienSinhVien
            // 
            this.cboHienSinhVien.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cboHienSinhVien.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.cboHienSinhVien.BorderSize = 1;
            this.cboHienSinhVien.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.cboHienSinhVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboHienSinhVien.ForeColor = System.Drawing.Color.DimGray;
            this.cboHienSinhVien.IconColor = System.Drawing.Color.MediumSlateBlue;
            this.cboHienSinhVien.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.cboHienSinhVien.ListTextColor = System.Drawing.Color.DimGray;
            this.cboHienSinhVien.Location = new System.Drawing.Point(121, 4);
            this.cboHienSinhVien.MinimumSize = new System.Drawing.Size(200, 30);
            this.cboHienSinhVien.Name = "cboHienSinhVien";
            this.cboHienSinhVien.Padding = new System.Windows.Forms.Padding(1);
            this.cboHienSinhVien.Size = new System.Drawing.Size(200, 30);
            this.cboHienSinhVien.TabIndex = 9;
            this.cboHienSinhVien.Texts = "Tất cả";
            this.cboHienSinhVien.OnSelectedIndexChanged += new System.EventHandler(this.cboHienSinhVien_OnSelectedIndexChanged);
            // 
            // txtTimSinhVien
            // 
            this.txtTimSinhVien.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTimSinhVien.BackColor = System.Drawing.SystemColors.Window;
            this.txtTimSinhVien.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtTimSinhVien.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtTimSinhVien.BorderRadius = 0;
            this.txtTimSinhVien.BorderSize = 2;
            this.txtTimSinhVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimSinhVien.ForeColor = System.Drawing.Color.DimGray;
            this.txtTimSinhVien.Location = new System.Drawing.Point(535, 1);
            this.txtTimSinhVien.Margin = new System.Windows.Forms.Padding(4);
            this.txtTimSinhVien.Multiline = false;
            this.txtTimSinhVien.Name = "txtTimSinhVien";
            this.txtTimSinhVien.Padding = new System.Windows.Forms.Padding(7);
            this.txtTimSinhVien.PasswordChar = false;
            this.txtTimSinhVien.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtTimSinhVien.PlaceholderText = "";
            this.txtTimSinhVien.ReadOnly = false;
            this.txtTimSinhVien.Size = new System.Drawing.Size(250, 35);
            this.txtTimSinhVien.TabIndex = 8;
            this.txtTimSinhVien.TextString = "Nhập mã số sinh viên...";
            this.txtTimSinhVien.UnderlinedStyle = false;
            this.txtTimSinhVien.Enter += new System.EventHandler(this.txtTimSinhVien_Enter);
            this.txtTimSinhVien.Leave += new System.EventHandler(this.txtTimSinhVien_Leave);
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTimKiem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(218)))), ((int)(((byte)(208)))));
            this.btnTimKiem.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(218)))), ((int)(((byte)(208)))));
            this.btnTimKiem.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnTimKiem.BorderRadius = 30;
            this.btnTimKiem.BorderSize = 0;
            this.btnTimKiem.FlatAppearance.BorderSize = 0;
            this.btnTimKiem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTimKiem.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimKiem.ForeColor = System.Drawing.Color.Black;
            this.btnTimKiem.Location = new System.Drawing.Point(792, 2);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(102, 32);
            this.btnTimKiem.TabIndex = 7;
            this.btnTimKiem.Text = "Tìm Kiếm";
            this.btnTimKiem.TextColor = System.Drawing.Color.Black;
            this.btnTimKiem.UseVisualStyleBackColor = false;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // frmDataSinhVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(153)))), ((int)(((byte)(174)))));
            this.ClientSize = new System.Drawing.Size(1045, 692);
            this.Controls.Add(this.btnDoiKieu);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.cboChonLop);
            this.Controls.Add(this.btnThemSinhVien);
            this.Controls.Add(this.cboHienSinhVien);
            this.Controls.Add(this.txtTimSinhVien);
            this.Controls.Add(this.btnTimKiem);
            this.Name = "frmDataSinhVien";
            this.Text = "Sinh Viên";
            this.Load += new System.EventHandler(this.frmDataSinhVien_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSinhVien)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Controls.DesignComboBox cboChonLop;
        private DesignButton btnThemSinhVien;
        private Controls.DesignComboBox cboHienSinhVien;
        private Controls.DesignTextBox txtTimSinhVien;
        private DesignButton btnTimKiem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvSinhVien;
        private DesignButton btnDoiKieu;
    }
}