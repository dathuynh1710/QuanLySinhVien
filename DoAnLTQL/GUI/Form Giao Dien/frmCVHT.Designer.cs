namespace GUI.Form_Giao_Dien
{
    partial class frmCVHT
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
            this.btnThemCVHT = new GUI.DesignButton();
            this.panelGroup = new System.Windows.Forms.Panel();
            this.rdoNu = new System.Windows.Forms.RadioButton();
            this.rdoNam = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpNgaySinh = new GUI.DesignDateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvCVHT = new System.Windows.Forms.DataGridView();
            this.txtTenCVHT = new GUI.Controls.DesignTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMaCVHT = new GUI.Controls.DesignTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnXoaCVHT = new GUI.DesignButton();
            this.btnCapNhatCVHT = new GUI.DesignButton();
            this.panelGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCVHT)).BeginInit();
            this.SuspendLayout();
            // 
            // btnThemCVHT
            // 
            this.btnThemCVHT.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnThemCVHT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(218)))), ((int)(((byte)(208)))));
            this.btnThemCVHT.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(218)))), ((int)(((byte)(208)))));
            this.btnThemCVHT.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnThemCVHT.BorderRadius = 40;
            this.btnThemCVHT.BorderSize = 0;
            this.btnThemCVHT.FlatAppearance.BorderSize = 0;
            this.btnThemCVHT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThemCVHT.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemCVHT.ForeColor = System.Drawing.Color.Black;
            this.btnThemCVHT.Location = new System.Drawing.Point(868, 527);
            this.btnThemCVHT.Name = "btnThemCVHT";
            this.btnThemCVHT.Size = new System.Drawing.Size(160, 53);
            this.btnThemCVHT.TabIndex = 33;
            this.btnThemCVHT.Text = "Thêm CVHT";
            this.btnThemCVHT.TextColor = System.Drawing.Color.Black;
            this.btnThemCVHT.UseVisualStyleBackColor = false;
            this.btnThemCVHT.Click += new System.EventHandler(this.btnThemCVHT_Click);
            // 
            // panelGroup
            // 
            this.panelGroup.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelGroup.Controls.Add(this.rdoNu);
            this.panelGroup.Controls.Add(this.rdoNam);
            this.panelGroup.Controls.Add(this.label4);
            this.panelGroup.Controls.Add(this.dtpNgaySinh);
            this.panelGroup.Controls.Add(this.label1);
            this.panelGroup.Controls.Add(this.dgvCVHT);
            this.panelGroup.Controls.Add(this.txtTenCVHT);
            this.panelGroup.Controls.Add(this.label3);
            this.panelGroup.Controls.Add(this.txtMaCVHT);
            this.panelGroup.Controls.Add(this.label2);
            this.panelGroup.Location = new System.Drawing.Point(79, 27);
            this.panelGroup.Name = "panelGroup";
            this.panelGroup.Size = new System.Drawing.Size(894, 482);
            this.panelGroup.TabIndex = 32;
            // 
            // rdoNu
            // 
            this.rdoNu.AutoSize = true;
            this.rdoNu.Location = new System.Drawing.Point(679, 81);
            this.rdoNu.Name = "rdoNu";
            this.rdoNu.Size = new System.Drawing.Size(45, 20);
            this.rdoNu.TabIndex = 13;
            this.rdoNu.TabStop = true;
            this.rdoNu.Text = "Nữ";
            this.rdoNu.UseVisualStyleBackColor = true;
            // 
            // rdoNam
            // 
            this.rdoNam.AutoSize = true;
            this.rdoNam.Location = new System.Drawing.Point(583, 80);
            this.rdoNam.Name = "rdoNam";
            this.rdoNam.Size = new System.Drawing.Size(57, 20);
            this.rdoNam.TabIndex = 12;
            this.rdoNam.TabStop = true;
            this.rdoNam.Text = "Nam";
            this.rdoNam.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(461, 80);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 20);
            this.label4.TabIndex = 11;
            this.label4.Text = "Giới tính:";
            // 
            // dtpNgaySinh
            // 
            this.dtpNgaySinh.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.dtpNgaySinh.BorderSize = 0;
            this.dtpNgaySinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.dtpNgaySinh.Location = new System.Drawing.Point(227, 72);
            this.dtpNgaySinh.MinimumSize = new System.Drawing.Size(4, 35);
            this.dtpNgaySinh.Name = "dtpNgaySinh";
            this.dtpNgaySinh.Size = new System.Drawing.Size(200, 35);
            this.dtpNgaySinh.SkinColor = System.Drawing.Color.MidnightBlue;
            this.dtpNgaySinh.TabIndex = 10;
            this.dtpNgaySinh.TextColor = System.Drawing.Color.White;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(133, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "Ngày sinh:";
            // 
            // dgvCVHT
            // 
            this.dgvCVHT.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCVHT.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvCVHT.Location = new System.Drawing.Point(0, 132);
            this.dgvCVHT.Name = "dgvCVHT";
            this.dgvCVHT.ReadOnly = true;
            this.dgvCVHT.RowHeadersWidth = 51;
            this.dgvCVHT.RowTemplate.Height = 24;
            this.dgvCVHT.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCVHT.Size = new System.Drawing.Size(894, 350);
            this.dgvCVHT.TabIndex = 8;
            this.dgvCVHT.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCVHT_CellClick);
            // 
            // txtTenCVHT
            // 
            this.txtTenCVHT.BackColor = System.Drawing.SystemColors.Window;
            this.txtTenCVHT.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtTenCVHT.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtTenCVHT.BorderRadius = 0;
            this.txtTenCVHT.BorderSize = 2;
            this.txtTenCVHT.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenCVHT.ForeColor = System.Drawing.Color.DimGray;
            this.txtTenCVHT.Location = new System.Drawing.Point(555, 20);
            this.txtTenCVHT.Margin = new System.Windows.Forms.Padding(4);
            this.txtTenCVHT.Multiline = false;
            this.txtTenCVHT.Name = "txtTenCVHT";
            this.txtTenCVHT.Padding = new System.Windows.Forms.Padding(7);
            this.txtTenCVHT.PasswordChar = false;
            this.txtTenCVHT.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtTenCVHT.PlaceholderText = "";
            this.txtTenCVHT.ReadOnly = false;
            this.txtTenCVHT.Size = new System.Drawing.Size(215, 35);
            this.txtTenCVHT.TabIndex = 5;
            this.txtTenCVHT.TextString = "";
            this.txtTenCVHT.UnderlinedStyle = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(470, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "CVHT:";
            // 
            // txtMaCVHT
            // 
            this.txtMaCVHT.BackColor = System.Drawing.SystemColors.Window;
            this.txtMaCVHT.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtMaCVHT.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtMaCVHT.BorderRadius = 0;
            this.txtMaCVHT.BorderSize = 2;
            this.txtMaCVHT.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaCVHT.ForeColor = System.Drawing.Color.DimGray;
            this.txtMaCVHT.Location = new System.Drawing.Point(227, 20);
            this.txtMaCVHT.Margin = new System.Windows.Forms.Padding(4);
            this.txtMaCVHT.Multiline = false;
            this.txtMaCVHT.Name = "txtMaCVHT";
            this.txtMaCVHT.Padding = new System.Windows.Forms.Padding(7);
            this.txtMaCVHT.PasswordChar = false;
            this.txtMaCVHT.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtMaCVHT.PlaceholderText = "";
            this.txtMaCVHT.ReadOnly = false;
            this.txtMaCVHT.Size = new System.Drawing.Size(200, 35);
            this.txtMaCVHT.TabIndex = 3;
            this.txtMaCVHT.TextString = "";
            this.txtMaCVHT.UnderlinedStyle = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(140, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Mã CVHT:";
            // 
            // btnXoaCVHT
            // 
            this.btnXoaCVHT.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnXoaCVHT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(218)))), ((int)(((byte)(208)))));
            this.btnXoaCVHT.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(218)))), ((int)(((byte)(208)))));
            this.btnXoaCVHT.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnXoaCVHT.BorderRadius = 40;
            this.btnXoaCVHT.BorderSize = 0;
            this.btnXoaCVHT.FlatAppearance.BorderSize = 0;
            this.btnXoaCVHT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoaCVHT.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaCVHT.ForeColor = System.Drawing.Color.Black;
            this.btnXoaCVHT.Location = new System.Drawing.Point(522, 527);
            this.btnXoaCVHT.Name = "btnXoaCVHT";
            this.btnXoaCVHT.Size = new System.Drawing.Size(160, 53);
            this.btnXoaCVHT.TabIndex = 35;
            this.btnXoaCVHT.Text = "Xóa CVHT";
            this.btnXoaCVHT.TextColor = System.Drawing.Color.Black;
            this.btnXoaCVHT.UseVisualStyleBackColor = false;
            this.btnXoaCVHT.Click += new System.EventHandler(this.btnXoaCVHT_Click);
            // 
            // btnCapNhatCVHT
            // 
            this.btnCapNhatCVHT.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCapNhatCVHT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(218)))), ((int)(((byte)(208)))));
            this.btnCapNhatCVHT.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(218)))), ((int)(((byte)(208)))));
            this.btnCapNhatCVHT.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnCapNhatCVHT.BorderRadius = 40;
            this.btnCapNhatCVHT.BorderSize = 0;
            this.btnCapNhatCVHT.FlatAppearance.BorderSize = 0;
            this.btnCapNhatCVHT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCapNhatCVHT.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCapNhatCVHT.ForeColor = System.Drawing.Color.Black;
            this.btnCapNhatCVHT.Location = new System.Drawing.Point(695, 527);
            this.btnCapNhatCVHT.Name = "btnCapNhatCVHT";
            this.btnCapNhatCVHT.Size = new System.Drawing.Size(160, 53);
            this.btnCapNhatCVHT.TabIndex = 34;
            this.btnCapNhatCVHT.Text = "Cập Nhật CVHT";
            this.btnCapNhatCVHT.TextColor = System.Drawing.Color.Black;
            this.btnCapNhatCVHT.UseVisualStyleBackColor = false;
            this.btnCapNhatCVHT.Click += new System.EventHandler(this.btnCapNhatCVHT_Click);
            // 
            // frmCVHT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(153)))), ((int)(((byte)(174)))));
            this.ClientSize = new System.Drawing.Size(1043, 606);
            this.Controls.Add(this.btnThemCVHT);
            this.Controls.Add(this.panelGroup);
            this.Controls.Add(this.btnXoaCVHT);
            this.Controls.Add(this.btnCapNhatCVHT);
            this.Name = "frmCVHT";
            this.Text = "Cố vấn học tập";
            this.Load += new System.EventHandler(this.frmCVHT_Load);
            this.panelGroup.ResumeLayout(false);
            this.panelGroup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCVHT)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DesignButton btnThemCVHT;
        private System.Windows.Forms.Panel panelGroup;
        private System.Windows.Forms.DataGridView dgvCVHT;
        private Controls.DesignTextBox txtTenCVHT;
        private System.Windows.Forms.Label label3;
        private Controls.DesignTextBox txtMaCVHT;
        private System.Windows.Forms.Label label2;
        private DesignButton btnXoaCVHT;
        private DesignButton btnCapNhatCVHT;
        private DesignDateTimePicker dtpNgaySinh;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rdoNu;
        private System.Windows.Forms.RadioButton rdoNam;
        private System.Windows.Forms.Label label4;
    }
}