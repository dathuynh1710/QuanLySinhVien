namespace GUI.Form_Giao_Dien
{
    partial class frmKhoa
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
            this.dgvKhoa = new System.Windows.Forms.DataGridView();
            this.txtTenKhoa = new GUI.Controls.DesignTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMaKhoa = new GUI.Controls.DesignTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnThemKhoa = new GUI.DesignButton();
            this.btnCapNhatKhoa = new GUI.DesignButton();
            this.btnXoaKhoa = new GUI.DesignButton();
            this.panelGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKhoa)).BeginInit();
            this.SuspendLayout();
            // 
            // panelGroup
            // 
            this.panelGroup.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelGroup.Controls.Add(this.dgvKhoa);
            this.panelGroup.Controls.Add(this.txtTenKhoa);
            this.panelGroup.Controls.Add(this.label3);
            this.panelGroup.Controls.Add(this.txtMaKhoa);
            this.panelGroup.Controls.Add(this.label2);
            this.panelGroup.Location = new System.Drawing.Point(161, 47);
            this.panelGroup.Name = "panelGroup";
            this.panelGroup.Size = new System.Drawing.Size(716, 482);
            this.panelGroup.TabIndex = 0;
            // 
            // dgvKhoa
            // 
            this.dgvKhoa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKhoa.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvKhoa.Location = new System.Drawing.Point(0, 113);
            this.dgvKhoa.Name = "dgvKhoa";
            this.dgvKhoa.ReadOnly = true;
            this.dgvKhoa.RowHeadersWidth = 51;
            this.dgvKhoa.RowTemplate.Height = 24;
            this.dgvKhoa.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvKhoa.Size = new System.Drawing.Size(716, 369);
            this.dgvKhoa.TabIndex = 8;
            this.dgvKhoa.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvKhoa_CellClick);
            // 
            // txtTenKhoa
            // 
            this.txtTenKhoa.BackColor = System.Drawing.SystemColors.Window;
            this.txtTenKhoa.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtTenKhoa.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtTenKhoa.BorderRadius = 0;
            this.txtTenKhoa.BorderSize = 2;
            this.txtTenKhoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenKhoa.ForeColor = System.Drawing.Color.DimGray;
            this.txtTenKhoa.Location = new System.Drawing.Point(453, 45);
            this.txtTenKhoa.Margin = new System.Windows.Forms.Padding(4);
            this.txtTenKhoa.Multiline = false;
            this.txtTenKhoa.Name = "txtTenKhoa";
            this.txtTenKhoa.Padding = new System.Windows.Forms.Padding(7);
            this.txtTenKhoa.PasswordChar = false;
            this.txtTenKhoa.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtTenKhoa.PlaceholderText = "";
            this.txtTenKhoa.ReadOnly = false;
            this.txtTenKhoa.Size = new System.Drawing.Size(215, 35);
            this.txtTenKhoa.TabIndex = 5;
            this.txtTenKhoa.TextString = "";
            this.txtTenKhoa.UnderlinedStyle = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(359, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Tên Khoa:";
            // 
            // txtMaKhoa
            // 
            this.txtMaKhoa.BackColor = System.Drawing.SystemColors.Window;
            this.txtMaKhoa.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtMaKhoa.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtMaKhoa.BorderRadius = 0;
            this.txtMaKhoa.BorderSize = 2;
            this.txtMaKhoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaKhoa.ForeColor = System.Drawing.Color.DimGray;
            this.txtMaKhoa.Location = new System.Drawing.Point(137, 45);
            this.txtMaKhoa.Margin = new System.Windows.Forms.Padding(4);
            this.txtMaKhoa.Multiline = false;
            this.txtMaKhoa.Name = "txtMaKhoa";
            this.txtMaKhoa.Padding = new System.Windows.Forms.Padding(7);
            this.txtMaKhoa.PasswordChar = false;
            this.txtMaKhoa.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtMaKhoa.PlaceholderText = "";
            this.txtMaKhoa.ReadOnly = false;
            this.txtMaKhoa.Size = new System.Drawing.Size(200, 35);
            this.txtMaKhoa.TabIndex = 3;
            this.txtMaKhoa.TextString = "";
            this.txtMaKhoa.UnderlinedStyle = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(50, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Mã Khoa:";
            // 
            // btnThemKhoa
            // 
            this.btnThemKhoa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnThemKhoa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(218)))), ((int)(((byte)(208)))));
            this.btnThemKhoa.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(218)))), ((int)(((byte)(208)))));
            this.btnThemKhoa.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnThemKhoa.BorderRadius = 40;
            this.btnThemKhoa.BorderSize = 0;
            this.btnThemKhoa.FlatAppearance.BorderSize = 0;
            this.btnThemKhoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThemKhoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemKhoa.ForeColor = System.Drawing.Color.Black;
            this.btnThemKhoa.Location = new System.Drawing.Point(870, 547);
            this.btnThemKhoa.Name = "btnThemKhoa";
            this.btnThemKhoa.Size = new System.Drawing.Size(160, 53);
            this.btnThemKhoa.TabIndex = 29;
            this.btnThemKhoa.Text = "Thêm Khoa";
            this.btnThemKhoa.TextColor = System.Drawing.Color.Black;
            this.btnThemKhoa.UseVisualStyleBackColor = false;
            this.btnThemKhoa.Click += new System.EventHandler(this.btnThemKhoa_Click);
            // 
            // btnCapNhatKhoa
            // 
            this.btnCapNhatKhoa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCapNhatKhoa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(218)))), ((int)(((byte)(208)))));
            this.btnCapNhatKhoa.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(218)))), ((int)(((byte)(208)))));
            this.btnCapNhatKhoa.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnCapNhatKhoa.BorderRadius = 40;
            this.btnCapNhatKhoa.BorderSize = 0;
            this.btnCapNhatKhoa.FlatAppearance.BorderSize = 0;
            this.btnCapNhatKhoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCapNhatKhoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCapNhatKhoa.ForeColor = System.Drawing.Color.Black;
            this.btnCapNhatKhoa.Location = new System.Drawing.Point(697, 547);
            this.btnCapNhatKhoa.Name = "btnCapNhatKhoa";
            this.btnCapNhatKhoa.Size = new System.Drawing.Size(160, 53);
            this.btnCapNhatKhoa.TabIndex = 30;
            this.btnCapNhatKhoa.Text = "Cập Nhật Khoa";
            this.btnCapNhatKhoa.TextColor = System.Drawing.Color.Black;
            this.btnCapNhatKhoa.UseVisualStyleBackColor = false;
            this.btnCapNhatKhoa.Click += new System.EventHandler(this.btnCapNhatKhoa_Click);
            // 
            // btnXoaKhoa
            // 
            this.btnXoaKhoa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnXoaKhoa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(218)))), ((int)(((byte)(208)))));
            this.btnXoaKhoa.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(218)))), ((int)(((byte)(208)))));
            this.btnXoaKhoa.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnXoaKhoa.BorderRadius = 40;
            this.btnXoaKhoa.BorderSize = 0;
            this.btnXoaKhoa.FlatAppearance.BorderSize = 0;
            this.btnXoaKhoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoaKhoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaKhoa.ForeColor = System.Drawing.Color.Black;
            this.btnXoaKhoa.Location = new System.Drawing.Point(524, 547);
            this.btnXoaKhoa.Name = "btnXoaKhoa";
            this.btnXoaKhoa.Size = new System.Drawing.Size(160, 53);
            this.btnXoaKhoa.TabIndex = 31;
            this.btnXoaKhoa.Text = "Xóa Khoa";
            this.btnXoaKhoa.TextColor = System.Drawing.Color.Black;
            this.btnXoaKhoa.UseVisualStyleBackColor = false;
            this.btnXoaKhoa.Click += new System.EventHandler(this.btnXoaKhoa_Click);
            // 
            // frmKhoa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(153)))), ((int)(((byte)(174)))));
            this.ClientSize = new System.Drawing.Size(1043, 606);
            this.Controls.Add(this.btnXoaKhoa);
            this.Controls.Add(this.btnCapNhatKhoa);
            this.Controls.Add(this.btnThemKhoa);
            this.Controls.Add(this.panelGroup);
            this.Name = "frmKhoa";
            this.Text = "Khoa";
            this.Load += new System.EventHandler(this.frmKhoa_Load);
            this.panelGroup.ResumeLayout(false);
            this.panelGroup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKhoa)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelGroup;
        private Controls.DesignTextBox txtTenKhoa;
        private System.Windows.Forms.Label label3;
        private Controls.DesignTextBox txtMaKhoa;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvKhoa;
        private DesignButton btnThemKhoa;
        private DesignButton btnCapNhatKhoa;
        private DesignButton btnXoaKhoa;
    }
}