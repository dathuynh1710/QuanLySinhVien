namespace GUI.Form_Giao_Dien
{
    partial class frmLop
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
            this.cboNganh = new GUI.Controls.DesignComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSoLuong = new GUI.Controls.DesignTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cboCVHT = new GUI.Controls.DesignComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvLop = new System.Windows.Forms.DataGridView();
            this.txtTenLop = new GUI.Controls.DesignTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMaLop = new GUI.Controls.DesignTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnXoaLop = new GUI.DesignButton();
            this.btnCapNhatLop = new GUI.DesignButton();
            this.btnThemLop = new GUI.DesignButton();
            this.panelGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLop)).BeginInit();
            this.SuspendLayout();
            // 
            // panelGroup
            // 
            this.panelGroup.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelGroup.Controls.Add(this.cboNganh);
            this.panelGroup.Controls.Add(this.label5);
            this.panelGroup.Controls.Add(this.txtSoLuong);
            this.panelGroup.Controls.Add(this.label4);
            this.panelGroup.Controls.Add(this.cboCVHT);
            this.panelGroup.Controls.Add(this.label1);
            this.panelGroup.Controls.Add(this.dgvLop);
            this.panelGroup.Controls.Add(this.txtTenLop);
            this.panelGroup.Controls.Add(this.label3);
            this.panelGroup.Controls.Add(this.txtMaLop);
            this.panelGroup.Controls.Add(this.label2);
            this.panelGroup.Location = new System.Drawing.Point(51, 27);
            this.panelGroup.Name = "panelGroup";
            this.panelGroup.Size = new System.Drawing.Size(951, 482);
            this.panelGroup.TabIndex = 32;
            // 
            // cboNganh
            // 
            this.cboNganh.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cboNganh.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.cboNganh.BorderSize = 1;
            this.cboNganh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.cboNganh.ForeColor = System.Drawing.Color.DimGray;
            this.cboNganh.IconColor = System.Drawing.Color.MediumSlateBlue;
            this.cboNganh.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.cboNganh.ListTextColor = System.Drawing.Color.DimGray;
            this.cboNganh.Location = new System.Drawing.Point(410, 65);
            this.cboNganh.MinimumSize = new System.Drawing.Size(200, 30);
            this.cboNganh.Name = "cboNganh";
            this.cboNganh.Padding = new System.Windows.Forms.Padding(1);
            this.cboNganh.Size = new System.Drawing.Size(200, 30);
            this.cboNganh.TabIndex = 14;
            this.cboNganh.Texts = "";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(331, 70);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 20);
            this.label5.TabIndex = 13;
            this.label5.Text = "Ngành:";
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.BackColor = System.Drawing.SystemColors.Window;
            this.txtSoLuong.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtSoLuong.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtSoLuong.BorderRadius = 0;
            this.txtSoLuong.BorderSize = 2;
            this.txtSoLuong.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSoLuong.ForeColor = System.Drawing.Color.DimGray;
            this.txtSoLuong.Location = new System.Drawing.Point(104, 63);
            this.txtSoLuong.Margin = new System.Windows.Forms.Padding(4);
            this.txtSoLuong.Multiline = false;
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Padding = new System.Windows.Forms.Padding(7);
            this.txtSoLuong.PasswordChar = false;
            this.txtSoLuong.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtSoLuong.PlaceholderText = "";
            this.txtSoLuong.ReadOnly = false;
            this.txtSoLuong.Size = new System.Drawing.Size(200, 35);
            this.txtSoLuong.TabIndex = 12;
            this.txtSoLuong.TextString = "";
            this.txtSoLuong.UnderlinedStyle = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(23, 70);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 20);
            this.label4.TabIndex = 11;
            this.label4.Text = "Số lượng:";
            // 
            // cboCVHT
            // 
            this.cboCVHT.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cboCVHT.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.cboCVHT.BorderSize = 1;
            this.cboCVHT.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.cboCVHT.ForeColor = System.Drawing.Color.DimGray;
            this.cboCVHT.IconColor = System.Drawing.Color.MediumSlateBlue;
            this.cboCVHT.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.cboCVHT.ListTextColor = System.Drawing.Color.DimGray;
            this.cboCVHT.Location = new System.Drawing.Point(715, 18);
            this.cboCVHT.MinimumSize = new System.Drawing.Size(200, 30);
            this.cboCVHT.Name = "cboCVHT";
            this.cboCVHT.Padding = new System.Windows.Forms.Padding(1);
            this.cboCVHT.Size = new System.Drawing.Size(200, 30);
            this.cboCVHT.TabIndex = 10;
            this.cboCVHT.Texts = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(642, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "CVHT:";
            // 
            // dgvLop
            // 
            this.dgvLop.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLop.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvLop.Location = new System.Drawing.Point(0, 113);
            this.dgvLop.Name = "dgvLop";
            this.dgvLop.ReadOnly = true;
            this.dgvLop.RowHeadersWidth = 51;
            this.dgvLop.RowTemplate.Height = 24;
            this.dgvLop.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLop.Size = new System.Drawing.Size(951, 369);
            this.dgvLop.TabIndex = 8;
            this.dgvLop.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLop_CellClick);
            // 
            // txtTenLop
            // 
            this.txtTenLop.BackColor = System.Drawing.SystemColors.Window;
            this.txtTenLop.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtTenLop.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtTenLop.BorderRadius = 0;
            this.txtTenLop.BorderSize = 2;
            this.txtTenLop.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenLop.ForeColor = System.Drawing.Color.DimGray;
            this.txtTenLop.Location = new System.Drawing.Point(410, 16);
            this.txtTenLop.Margin = new System.Windows.Forms.Padding(4);
            this.txtTenLop.Multiline = false;
            this.txtTenLop.Name = "txtTenLop";
            this.txtTenLop.Padding = new System.Windows.Forms.Padding(7);
            this.txtTenLop.PasswordChar = false;
            this.txtTenLop.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtTenLop.PlaceholderText = "";
            this.txtTenLop.ReadOnly = false;
            this.txtTenLop.Size = new System.Drawing.Size(215, 35);
            this.txtTenLop.TabIndex = 5;
            this.txtTenLop.TextString = "";
            this.txtTenLop.UnderlinedStyle = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(326, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Tên Lớp:";
            // 
            // txtMaLop
            // 
            this.txtMaLop.BackColor = System.Drawing.SystemColors.Window;
            this.txtMaLop.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtMaLop.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtMaLop.BorderRadius = 0;
            this.txtMaLop.BorderSize = 2;
            this.txtMaLop.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaLop.ForeColor = System.Drawing.Color.DimGray;
            this.txtMaLop.Location = new System.Drawing.Point(104, 16);
            this.txtMaLop.Margin = new System.Windows.Forms.Padding(4);
            this.txtMaLop.Multiline = false;
            this.txtMaLop.Name = "txtMaLop";
            this.txtMaLop.Padding = new System.Windows.Forms.Padding(7);
            this.txtMaLop.PasswordChar = false;
            this.txtMaLop.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtMaLop.PlaceholderText = "";
            this.txtMaLop.ReadOnly = false;
            this.txtMaLop.Size = new System.Drawing.Size(200, 35);
            this.txtMaLop.TabIndex = 3;
            this.txtMaLop.TextString = "";
            this.txtMaLop.UnderlinedStyle = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(23, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Mã Lớp:";
            // 
            // btnXoaLop
            // 
            this.btnXoaLop.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnXoaLop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(218)))), ((int)(((byte)(208)))));
            this.btnXoaLop.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(218)))), ((int)(((byte)(208)))));
            this.btnXoaLop.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnXoaLop.BorderRadius = 40;
            this.btnXoaLop.BorderSize = 0;
            this.btnXoaLop.FlatAppearance.BorderSize = 0;
            this.btnXoaLop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoaLop.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaLop.ForeColor = System.Drawing.Color.Black;
            this.btnXoaLop.Location = new System.Drawing.Point(514, 527);
            this.btnXoaLop.Name = "btnXoaLop";
            this.btnXoaLop.Size = new System.Drawing.Size(160, 53);
            this.btnXoaLop.TabIndex = 35;
            this.btnXoaLop.Text = "Xóa Lớp";
            this.btnXoaLop.TextColor = System.Drawing.Color.Black;
            this.btnXoaLop.UseVisualStyleBackColor = false;
            // 
            // btnCapNhatLop
            // 
            this.btnCapNhatLop.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCapNhatLop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(218)))), ((int)(((byte)(208)))));
            this.btnCapNhatLop.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(218)))), ((int)(((byte)(208)))));
            this.btnCapNhatLop.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnCapNhatLop.BorderRadius = 40;
            this.btnCapNhatLop.BorderSize = 0;
            this.btnCapNhatLop.FlatAppearance.BorderSize = 0;
            this.btnCapNhatLop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCapNhatLop.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCapNhatLop.ForeColor = System.Drawing.Color.Black;
            this.btnCapNhatLop.Location = new System.Drawing.Point(687, 527);
            this.btnCapNhatLop.Name = "btnCapNhatLop";
            this.btnCapNhatLop.Size = new System.Drawing.Size(160, 53);
            this.btnCapNhatLop.TabIndex = 34;
            this.btnCapNhatLop.Text = "Cập Nhật Lớp";
            this.btnCapNhatLop.TextColor = System.Drawing.Color.Black;
            this.btnCapNhatLop.UseVisualStyleBackColor = false;
            this.btnCapNhatLop.Click += new System.EventHandler(this.btnCapNhatLop_Click);
            // 
            // btnThemLop
            // 
            this.btnThemLop.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnThemLop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(218)))), ((int)(((byte)(208)))));
            this.btnThemLop.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(218)))), ((int)(((byte)(208)))));
            this.btnThemLop.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnThemLop.BorderRadius = 40;
            this.btnThemLop.BorderSize = 0;
            this.btnThemLop.FlatAppearance.BorderSize = 0;
            this.btnThemLop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThemLop.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemLop.ForeColor = System.Drawing.Color.Black;
            this.btnThemLop.Location = new System.Drawing.Point(860, 527);
            this.btnThemLop.Name = "btnThemLop";
            this.btnThemLop.Size = new System.Drawing.Size(160, 53);
            this.btnThemLop.TabIndex = 33;
            this.btnThemLop.Text = "Thêm Lớp";
            this.btnThemLop.TextColor = System.Drawing.Color.Black;
            this.btnThemLop.UseVisualStyleBackColor = false;
            this.btnThemLop.Click += new System.EventHandler(this.btnThemLop_Click);
            // 
            // frmLop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(153)))), ((int)(((byte)(174)))));
            this.ClientSize = new System.Drawing.Size(1043, 606);
            this.Controls.Add(this.panelGroup);
            this.Controls.Add(this.btnXoaLop);
            this.Controls.Add(this.btnCapNhatLop);
            this.Controls.Add(this.btnThemLop);
            this.Name = "frmLop";
            this.Text = "frmLop";
            this.Load += new System.EventHandler(this.frmLop_Load);
            this.panelGroup.ResumeLayout(false);
            this.panelGroup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLop)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelGroup;
        private System.Windows.Forms.DataGridView dgvLop;
        private Controls.DesignTextBox txtTenLop;
        private System.Windows.Forms.Label label3;
        private Controls.DesignTextBox txtMaLop;
        private System.Windows.Forms.Label label2;
        private DesignButton btnXoaLop;
        private DesignButton btnCapNhatLop;
        private DesignButton btnThemLop;
        private Controls.DesignComboBox cboNganh;
        private System.Windows.Forms.Label label5;
        private Controls.DesignTextBox txtSoLuong;
        private System.Windows.Forms.Label label4;
        private Controls.DesignComboBox cboCVHT;
        private System.Windows.Forms.Label label1;
    }
}