using BUS;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI.Form_Giao_Dien
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        string hintUsername = "Tên đăng nhập";
        string hintPassword = "Mật khẩu";
        private void txtUsername_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTenDangNhap.TextString))
            {
                txtTenDangNhap.TextString = hintUsername;
                txtTenDangNhap.ForeColor = SystemColors.GrayText;
            }
        }

        private void txtUsername_Enter(object sender, EventArgs e)
        {
            if (txtTenDangNhap.TextString.Equals(hintUsername) == true)
            {
                txtTenDangNhap.TextString = "";
                txtTenDangNhap.ForeColor = SystemColors.WindowText;
            }
        }

        private void txtPassword_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMatKhau.TextString))
            {
                txtMatKhau.TextString = hintPassword;
                txtMatKhau.ForeColor = SystemColors.GrayText;
                txtMatKhau.PasswordChar = false;
            }
        }

        private void txtPassword_Enter(object sender, EventArgs e)
        {
            if (txtMatKhau.TextString.Equals(hintPassword) == true)
            {
                txtMatKhau.TextString = "";
                txtMatKhau.ForeColor = SystemColors.WindowText;
                txtMatKhau.PasswordChar = true;
            }
        }

        private void checkXemMatKhau_CheckedChanged(object sender, EventArgs e)
        {
            if (txtMatKhau.TextString.Equals(hintPassword)==false)
            {
                txtMatKhau.PasswordChar = !checkXemMatKhau.Checked;
            }
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtTenDangNhap.TextString != "" && txtTenDangNhap.TextString.Equals(hintUsername)==false)
                {
                    if (txtMatKhau.TextString != "" && txtMatKhau.TextString.Equals(hintUsername) == false)
                    {
                        bool ketQua = TaiKhoan_BUS.KiemTraDangNhap(txtTenDangNhap.ToString(), txtMatKhau.ToString());
                        if (ketQua)
                        {
                            TaiKhoan_DTO tk = TaiKhoan_BUS.LayLoaiTaiKhoan(txtTenDangNhap.TextString);
                            if(tk!= null)
                            {
                                foreach (Form form in Application.OpenForms)
                                {

                                    // Kiểm tra xem form có phải là frmMain không
                                    if (form is frmMain)
                                    {
                                        // Nếu là frmMain, thực hiện phương thức OpenChildForm
                                        ((frmMain)form).OpenChildForm(new frmFlashScreen());

                                        break; // Thoát khỏi vòng lặp sau khi thực hiện xong
                                    }
                                }
                                KetQuaDangNhap.LoaiTaiKhoan = tk.LoaiTaiKhoan;
                                KetQuaDangNhap.ketQua = true;
                            }
                            else
                            {
                                MessageBox.Show("Tài khoản không đúng!", "Thông báo");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Tên đăng nhập và Mật khẩu không trùng khớp!", "Thông báo");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Nhập mật khẩu!", "Thông báo");
                        txtMatKhau.Focus();
                    }
                }
                else
                {
                    MessageBox.Show("Nhập tài khoản!", "Thông báo");
                    txtTenDangNhap.Focus();
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnDangKy_Click(object sender, EventArgs e)
        {
            foreach (Form form in Application.OpenForms)
            {
                // Kiểm tra xem form có phải là frmMain không
                if (form is frmMain)
                {
                    // Nếu là frmMain, thực hiện phương thức OpenChildForm
                    ((frmMain)form).OpenChildForm(new frmDangKy());
                    break; // Thoát khỏi vòng lặp sau khi thực hiện xong
                }
            }
            Hide();
        }

            private void btnDangNhap_DoubleClick(object sender, EventArgs e)
            {
                try
                {
                    if (txtTenDangNhap.TextString != "" && txtTenDangNhap.TextString.Equals(hintUsername) == false)
                    {
                        if (txtMatKhau.TextString != "" && txtMatKhau.TextString.Equals(hintUsername) == false)
                        {
                            bool ketQua = TaiKhoan_BUS.KiemTraDangNhap(txtTenDangNhap.ToString(), txtMatKhau.ToString());
                            if (ketQua)
                            {
                                TaiKhoan_DTO tk = TaiKhoan_BUS.LayLoaiTaiKhoan(txtTenDangNhap.TextString);
                                if (tk != null)
                                {
                                    foreach (Form form in Application.OpenForms)
                                    {

                                        // Kiểm tra xem form có phải là frmMain không
                                        if (form is frmMain)
                                        {
                                            // Nếu là frmMain, thực hiện phương thức OpenChildForm
                                            ((frmMain)form).OpenChildForm(new frmFlashScreen());

                                            break; // Thoát khỏi vòng lặp sau khi thực hiện xong
                                        }
                                    }
                                    KetQuaDangNhap.LoaiTaiKhoan = tk.LoaiTaiKhoan;
                                    KetQuaDangNhap.ketQua = true;
                                }
                                else
                                {
                                    MessageBox.Show("Tài khoản không đúng!", "Thông báo");
                                }

                            }
                            else
                            {
                                MessageBox.Show("Tên đăng nhập và Mật khẩu không trùng khớp!", "Thông báo");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Nhập mật khẩu!", "Thông báo");
                            txtMatKhau.Focus();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Nhập tài khoản!", "Thông báo");
                        txtTenDangNhap.Focus();
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

        private void txtMatKhau_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == (char)Keys.Enter)
            {
                btnDangNhap_Click(sender, e);  
            }
        }
    }
}
