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
    public partial class frmDangKy : Form
    {
        public frmDangKy()
        {
            InitializeComponent();
        }

        private void btnQuayLai_Click(object sender, EventArgs e)
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form is frmMain)
                {
                    ((frmMain)form).OpenChildForm(new frmLogin());
                    break;
                }
            }
        }

        private void btnDangKy_Click(object sender, EventArgs e)
        {
            if(txtTenDangNhap.TextString.Equals(hintdangnhap) || txtMatKhau.TextString.Equals(hintmatkhau)|| txtNhapLaiMK.TextString.Equals(hintnhaplai))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin đăng ký", "Thông báo");
            }
            else if (txtMatKhau.TextString.Length<6)
            {
                MessageBox.Show("Mật khẩu phải lớn hơn 6 kí tự", "Thông báo");
            }
            else if (txtMatKhau.TextString.Equals(txtNhapLaiMK.TextString)==false)
            {
                MessageBox.Show("Mật  khẩu không trùng khớp", "Thông báo");
            }else if (TaiKhoan_BUS.KiemTraTen(txtTenDangNhap.TextString)==true)
            {
                MessageBox.Show("Tên tài khoản đã tồn tại", "Thông báo");
            }
            else
            {
                TaiKhoan_DTO tk = new TaiKhoan_DTO();
                tk.TenDangNhap = txtTenDangNhap.TextString;
                tk.MatKhau = txtMatKhau.TextString;
                tk.LoaiTaiKhoan = "Cố vấn học tập";
                bool kq = TaiKhoan_BUS.ThemTaiKhoan(tk);
                if (kq)
                {
                    MessageBox.Show("Tài khoản đăng ký thành công!", "Thông báo");
                }
                else
                {
                    MessageBox.Show("Đăng ký tài khoản không thành công!", "Thông báo");
                }
            }
        }

        string hintdangnhap = "Tên đăng nhập";
        string hintmatkhau = "Mật khẩu";
        string hintnhaplai = "Nhập lại mật khẩu";
        private void txtTenDangNhap_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTenDangNhap.TextString))
            {
                txtTenDangNhap.TextString = hintdangnhap;
                txtTenDangNhap.ForeColor = SystemColors.GrayText;
            }
        }

        private void txtTenDangNhap_Enter(object sender, EventArgs e)
        {
            if (txtTenDangNhap.TextString.Equals(hintdangnhap) == true)
            {
                txtTenDangNhap.TextString = "";
                txtTenDangNhap.ForeColor = SystemColors.WindowText;
            }
        }

        private void txtMatKhau_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMatKhau.TextString))
            {
                txtMatKhau.TextString = hintmatkhau;
                txtMatKhau.ForeColor = SystemColors.GrayText;
                txtMatKhau.PasswordChar = false;
            }
        }

        private void txtNhapLaiMK_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNhapLaiMK.TextString))
            {
                txtNhapLaiMK.TextString = hintnhaplai;
                txtNhapLaiMK.ForeColor = SystemColors.GrayText;
                txtNhapLaiMK.PasswordChar = false;
            }
        }

        private void txtMatKhau_Enter(object sender, EventArgs e)
        {
            if (txtMatKhau.TextString.Equals(hintmatkhau) == true)
            {
                txtMatKhau.TextString = "";
                txtMatKhau.ForeColor = SystemColors.WindowText;
                txtMatKhau.PasswordChar = true;
            }
        }

        private void txtNhapLaiMK_Enter(object sender, EventArgs e)
        {
            if (txtNhapLaiMK.TextString.Equals(hintnhaplai) == true)
            {
                txtNhapLaiMK.TextString = "";
                txtNhapLaiMK.ForeColor = SystemColors.WindowText;
                txtNhapLaiMK.PasswordChar = true;
            }
        }

        private void checkXemMatKhau_CheckedChanged(object sender, EventArgs e)
        {
            if(txtMatKhau.TextString.Equals (hintmatkhau) == false && txtNhapLaiMK.TextString.Equals(hintnhaplai) == false)
            {
                txtMatKhau.PasswordChar = !checkXemMatKhau.Checked;
                txtNhapLaiMK.PasswordChar = !checkXemMatKhau.Checked;
            }
        }

        private void txtNhapLaiMK_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == (char)Keys.Enter)
            {
                btnDangKy_Click(sender, e);
            }
        }
    }
}
