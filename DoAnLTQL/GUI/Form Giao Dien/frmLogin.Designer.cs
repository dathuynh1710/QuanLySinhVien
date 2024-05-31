namespace GUI.Form_Giao_Dien
{
    partial class frmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            this.label1 = new System.Windows.Forms.Label();
            this.checkXemMatKhau = new System.Windows.Forms.CheckBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.btnDangNhap = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnDangKy = new GUI.DesignButton();
            this.txtMatKhau = new GUI.Controls.DesignTextBox();
            this.txtTenDangNhap = new GUI.Controls.DesignTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDangNhap)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label1.Location = new System.Drawing.Point(514, 206);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(280, 23);
            this.label1.TabIndex = 2;
            this.label1.Text = "Login below to get started !";
            // 
            // checkXemMatKhau
            // 
            this.checkXemMatKhau.AutoSize = true;
            this.checkXemMatKhau.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.checkXemMatKhau.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.checkXemMatKhau.Location = new System.Drawing.Point(471, 415);
            this.checkXemMatKhau.Name = "checkXemMatKhau";
            this.checkXemMatKhau.Size = new System.Drawing.Size(145, 24);
            this.checkXemMatKhau.TabIndex = 5;
            this.checkXemMatKhau.Text = "Show Password";
            this.checkXemMatKhau.UseVisualStyleBackColor = true;
            this.checkXemMatKhau.CheckedChanged += new System.EventHandler(this.checkXemMatKhau_CheckedChanged);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(461, 326);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(402, 70);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 8;
            this.pictureBox4.TabStop = false;
            // 
            // btnDangNhap
            // 
            this.btnDangNhap.Image = ((System.Drawing.Image)(resources.GetObject("btnDangNhap.Image")));
            this.btnDangNhap.Location = new System.Drawing.Point(376, 451);
            this.btnDangNhap.Name = "btnDangNhap";
            this.btnDangNhap.Size = new System.Drawing.Size(526, 86);
            this.btnDangNhap.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnDangNhap.TabIndex = 6;
            this.btnDangNhap.TabStop = false;
            this.btnDangNhap.Click += new System.EventHandler(this.btnDangNhap_Click);
            this.btnDangNhap.DoubleClick += new System.EventHandler(this.btnDangNhap_DoubleClick);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(455, 242);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(402, 70);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 3;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(566, 50);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(165, 142);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-142, -182);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(705, 1071);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btnDangKy
            // 
            this.btnDangKy.BackColor = System.Drawing.Color.Plum;
            this.btnDangKy.BackgroundColor = System.Drawing.Color.Plum;
            this.btnDangKy.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnDangKy.BorderRadius = 40;
            this.btnDangKy.BorderSize = 0;
            this.btnDangKy.FlatAppearance.BorderSize = 0;
            this.btnDangKy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDangKy.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDangKy.ForeColor = System.Drawing.Color.White;
            this.btnDangKy.Location = new System.Drawing.Point(564, 543);
            this.btnDangKy.Name = "btnDangKy";
            this.btnDangKy.Size = new System.Drawing.Size(150, 40);
            this.btnDangKy.TabIndex = 13;
            this.btnDangKy.Text = "Đăng ký";
            this.btnDangKy.TextColor = System.Drawing.Color.White;
            this.btnDangKy.UseVisualStyleBackColor = false;
            this.btnDangKy.Click += new System.EventHandler(this.btnDangKy_Click);
            // 
            // txtMatKhau
            // 
            this.txtMatKhau.BackColor = System.Drawing.SystemColors.Window;
            this.txtMatKhau.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtMatKhau.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtMatKhau.BorderRadius = 30;
            this.txtMatKhau.BorderSize = 1;
            this.txtMatKhau.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMatKhau.ForeColor = System.Drawing.Color.DimGray;
            this.txtMatKhau.Location = new System.Drawing.Point(480, 344);
            this.txtMatKhau.Margin = new System.Windows.Forms.Padding(4);
            this.txtMatKhau.Multiline = false;
            this.txtMatKhau.Name = "txtMatKhau";
            this.txtMatKhau.Padding = new System.Windows.Forms.Padding(20, 7, 7, 7);
            this.txtMatKhau.PasswordChar = false;
            this.txtMatKhau.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtMatKhau.PlaceholderText = "";
            this.txtMatKhau.ReadOnly = false;
            this.txtMatKhau.Size = new System.Drawing.Size(359, 35);
            this.txtMatKhau.TabIndex = 12;
            this.txtMatKhau.TextString = "Mật khẩu";
            this.txtMatKhau.UnderlinedStyle = false;
            this.txtMatKhau.Enter += new System.EventHandler(this.txtPassword_Enter);
            this.txtMatKhau.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMatKhau_KeyPress);
            this.txtMatKhau.Leave += new System.EventHandler(this.txtPassword_Leave);
            // 
            // txtTenDangNhap
            // 
            this.txtTenDangNhap.BackColor = System.Drawing.SystemColors.Window;
            this.txtTenDangNhap.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtTenDangNhap.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtTenDangNhap.BorderRadius = 30;
            this.txtTenDangNhap.BorderSize = 1;
            this.txtTenDangNhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenDangNhap.ForeColor = System.Drawing.Color.DimGray;
            this.txtTenDangNhap.Location = new System.Drawing.Point(475, 260);
            this.txtTenDangNhap.Margin = new System.Windows.Forms.Padding(4);
            this.txtTenDangNhap.Multiline = false;
            this.txtTenDangNhap.Name = "txtTenDangNhap";
            this.txtTenDangNhap.Padding = new System.Windows.Forms.Padding(20, 7, 7, 7);
            this.txtTenDangNhap.PasswordChar = false;
            this.txtTenDangNhap.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtTenDangNhap.PlaceholderText = "";
            this.txtTenDangNhap.ReadOnly = false;
            this.txtTenDangNhap.Size = new System.Drawing.Size(359, 35);
            this.txtTenDangNhap.TabIndex = 11;
            this.txtTenDangNhap.TextString = "Tên đăng nhập";
            this.txtTenDangNhap.UnderlinedStyle = false;
            this.txtTenDangNhap.Enter += new System.EventHandler(this.txtUsername_Enter);
            this.txtTenDangNhap.Leave += new System.EventHandler(this.txtUsername_Leave);
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1063, 739);
            this.ControlBox = false;
            this.Controls.Add(this.btnDangKy);
            this.Controls.Add(this.txtMatKhau);
            this.Controls.Add(this.txtTenDangNhap);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.btnDangNhap);
            this.Controls.Add(this.checkXemMatKhau);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng nhập";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDangNhap)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.CheckBox checkXemMatKhau;
        private System.Windows.Forms.PictureBox btnDangNhap;
        private System.Windows.Forms.PictureBox pictureBox4;
        private Controls.DesignTextBox txtTenDangNhap;
        private Controls.DesignTextBox txtMatKhau;
        private DesignButton btnDangKy;
    }
}