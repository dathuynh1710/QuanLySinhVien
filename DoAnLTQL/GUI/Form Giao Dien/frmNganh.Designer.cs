namespace GUI.Form_Giao_Dien
{
    partial class frmNganh
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
            this.cboTenKhoa = new GUI.Controls.DesignComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTenNganh = new GUI.Controls.DesignTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMaNganh = new GUI.Controls.DesignTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvNganh = new System.Windows.Forms.DataGridView();
            this.btnXoaNganh = new GUI.DesignButton();
            this.btnCapNhatNganh = new GUI.DesignButton();
            this.btnThemNganh = new GUI.DesignButton();
            this.panelGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNganh)).BeginInit();
            this.SuspendLayout();
            // 
            // panelGroup
            // 
            this.panelGroup.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelGroup.Controls.Add(this.cboTenKhoa);
            this.panelGroup.Controls.Add(this.label4);
            this.panelGroup.Controls.Add(this.txtTenNganh);
            this.panelGroup.Controls.Add(this.label3);
            this.panelGroup.Controls.Add(this.txtMaNganh);
            this.panelGroup.Controls.Add(this.label2);
            this.panelGroup.Controls.Add(this.dgvNganh);
            this.panelGroup.Location = new System.Drawing.Point(233, 24);
            this.panelGroup.Name = "panelGroup";
            this.panelGroup.Size = new System.Drawing.Size(682, 493);
            this.panelGroup.TabIndex = 32;
            // 
            // cboTenKhoa
            // 
            this.cboTenKhoa.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cboTenKhoa.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.cboTenKhoa.BorderSize = 1;
            this.cboTenKhoa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.cboTenKhoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboTenKhoa.ForeColor = System.Drawing.Color.Black;
            this.cboTenKhoa.IconColor = System.Drawing.Color.MediumSlateBlue;
            this.cboTenKhoa.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.cboTenKhoa.ListTextColor = System.Drawing.Color.DimGray;
            this.cboTenKhoa.Location = new System.Drawing.Point(325, 81);
            this.cboTenKhoa.MinimumSize = new System.Drawing.Size(200, 30);
            this.cboTenKhoa.Name = "cboTenKhoa";
            this.cboTenKhoa.Padding = new System.Windows.Forms.Padding(1);
            this.cboTenKhoa.Size = new System.Drawing.Size(200, 30);
            this.cboTenKhoa.TabIndex = 17;
            this.cboTenKhoa.Texts = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(203, 86);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 20);
            this.label4.TabIndex = 16;
            this.label4.Text = "Thuộc Khoa:";
            // 
            // txtTenNganh
            // 
            this.txtTenNganh.BackColor = System.Drawing.SystemColors.Window;
            this.txtTenNganh.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtTenNganh.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtTenNganh.BorderRadius = 0;
            this.txtTenNganh.BorderSize = 2;
            this.txtTenNganh.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenNganh.ForeColor = System.Drawing.Color.Black;
            this.txtTenNganh.Location = new System.Drawing.Point(418, 22);
            this.txtTenNganh.Margin = new System.Windows.Forms.Padding(4);
            this.txtTenNganh.Multiline = false;
            this.txtTenNganh.Name = "txtTenNganh";
            this.txtTenNganh.Padding = new System.Windows.Forms.Padding(7);
            this.txtTenNganh.PasswordChar = false;
            this.txtTenNganh.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtTenNganh.PlaceholderText = "";
            this.txtTenNganh.ReadOnly = false;
            this.txtTenNganh.Size = new System.Drawing.Size(232, 35);
            this.txtTenNganh.TabIndex = 15;
            this.txtTenNganh.TextString = "";
            this.txtTenNganh.UnderlinedStyle = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(320, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 20);
            this.label3.TabIndex = 14;
            this.label3.Text = "Tên Ngành:";
            // 
            // txtMaNganh
            // 
            this.txtMaNganh.BackColor = System.Drawing.SystemColors.Window;
            this.txtMaNganh.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtMaNganh.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtMaNganh.BorderRadius = 0;
            this.txtMaNganh.BorderSize = 2;
            this.txtMaNganh.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaNganh.ForeColor = System.Drawing.Color.Black;
            this.txtMaNganh.Location = new System.Drawing.Point(111, 22);
            this.txtMaNganh.Margin = new System.Windows.Forms.Padding(4);
            this.txtMaNganh.Multiline = false;
            this.txtMaNganh.Name = "txtMaNganh";
            this.txtMaNganh.Padding = new System.Windows.Forms.Padding(7);
            this.txtMaNganh.PasswordChar = false;
            this.txtMaNganh.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtMaNganh.PlaceholderText = "";
            this.txtMaNganh.ReadOnly = false;
            this.txtMaNganh.Size = new System.Drawing.Size(190, 35);
            this.txtMaNganh.TabIndex = 13;
            this.txtMaNganh.TextString = "";
            this.txtMaNganh.UnderlinedStyle = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(18, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 20);
            this.label2.TabIndex = 12;
            this.label2.Text = "Mã Ngành:";
            // 
            // dgvNganh
            // 
            this.dgvNganh.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNganh.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvNganh.Location = new System.Drawing.Point(0, 124);
            this.dgvNganh.Name = "dgvNganh";
            this.dgvNganh.ReadOnly = true;
            this.dgvNganh.RowHeadersWidth = 51;
            this.dgvNganh.RowTemplate.Height = 24;
            this.dgvNganh.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvNganh.Size = new System.Drawing.Size(682, 369);
            this.dgvNganh.TabIndex = 8;
            this.dgvNganh.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvNganh_CellClick);
            // 
            // btnXoaNganh
            // 
            this.btnXoaNganh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnXoaNganh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(218)))), ((int)(((byte)(208)))));
            this.btnXoaNganh.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(218)))), ((int)(((byte)(208)))));
            this.btnXoaNganh.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnXoaNganh.BorderRadius = 40;
            this.btnXoaNganh.BorderSize = 0;
            this.btnXoaNganh.FlatAppearance.BorderSize = 0;
            this.btnXoaNganh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoaNganh.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaNganh.ForeColor = System.Drawing.Color.Black;
            this.btnXoaNganh.Location = new System.Drawing.Point(513, 535);
            this.btnXoaNganh.Name = "btnXoaNganh";
            this.btnXoaNganh.Size = new System.Drawing.Size(160, 53);
            this.btnXoaNganh.TabIndex = 35;
            this.btnXoaNganh.Text = "Xóa Ngành";
            this.btnXoaNganh.TextColor = System.Drawing.Color.Black;
            this.btnXoaNganh.UseVisualStyleBackColor = false;
            this.btnXoaNganh.Click += new System.EventHandler(this.btnXoaNganh_Click);
            // 
            // btnCapNhatNganh
            // 
            this.btnCapNhatNganh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCapNhatNganh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(218)))), ((int)(((byte)(208)))));
            this.btnCapNhatNganh.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(218)))), ((int)(((byte)(208)))));
            this.btnCapNhatNganh.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnCapNhatNganh.BorderRadius = 40;
            this.btnCapNhatNganh.BorderSize = 0;
            this.btnCapNhatNganh.FlatAppearance.BorderSize = 0;
            this.btnCapNhatNganh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCapNhatNganh.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCapNhatNganh.ForeColor = System.Drawing.Color.Black;
            this.btnCapNhatNganh.Location = new System.Drawing.Point(686, 535);
            this.btnCapNhatNganh.Name = "btnCapNhatNganh";
            this.btnCapNhatNganh.Size = new System.Drawing.Size(160, 53);
            this.btnCapNhatNganh.TabIndex = 34;
            this.btnCapNhatNganh.Text = "Cập Nhật Ngành";
            this.btnCapNhatNganh.TextColor = System.Drawing.Color.Black;
            this.btnCapNhatNganh.UseVisualStyleBackColor = false;
            this.btnCapNhatNganh.Click += new System.EventHandler(this.btnCapNhatNganh_Click);
            // 
            // btnThemNganh
            // 
            this.btnThemNganh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnThemNganh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(218)))), ((int)(((byte)(208)))));
            this.btnThemNganh.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(218)))), ((int)(((byte)(208)))));
            this.btnThemNganh.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnThemNganh.BorderRadius = 40;
            this.btnThemNganh.BorderSize = 0;
            this.btnThemNganh.FlatAppearance.BorderSize = 0;
            this.btnThemNganh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThemNganh.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemNganh.ForeColor = System.Drawing.Color.Black;
            this.btnThemNganh.Location = new System.Drawing.Point(859, 535);
            this.btnThemNganh.Name = "btnThemNganh";
            this.btnThemNganh.Size = new System.Drawing.Size(160, 53);
            this.btnThemNganh.TabIndex = 33;
            this.btnThemNganh.Text = "Thêm Ngành";
            this.btnThemNganh.TextColor = System.Drawing.Color.Black;
            this.btnThemNganh.UseVisualStyleBackColor = false;
            this.btnThemNganh.Click += new System.EventHandler(this.btnThemNganh_Click);
            // 
            // frmNganh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(153)))), ((int)(((byte)(174)))));
            this.ClientSize = new System.Drawing.Size(1043, 606);
            this.Controls.Add(this.panelGroup);
            this.Controls.Add(this.btnXoaNganh);
            this.Controls.Add(this.btnCapNhatNganh);
            this.Controls.Add(this.btnThemNganh);
            this.Name = "frmNganh";
            this.Text = "Ngành";
            this.Load += new System.EventHandler(this.frmNganh_Load);
            this.panelGroup.ResumeLayout(false);
            this.panelGroup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNganh)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelGroup;
        private System.Windows.Forms.DataGridView dgvNganh;
        private DesignButton btnXoaNganh;
        private DesignButton btnCapNhatNganh;
        private DesignButton btnThemNganh;
        private Controls.DesignComboBox cboTenKhoa;
        private System.Windows.Forms.Label label4;
        private Controls.DesignTextBox txtTenNganh;
        private System.Windows.Forms.Label label3;
        private Controls.DesignTextBox txtMaNganh;
        private System.Windows.Forms.Label label2;
    }
}