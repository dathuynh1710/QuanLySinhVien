using DTO;
using FontAwesome.Sharp;
using GUI.Form_Giao_Dien;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
namespace GUI
{
    public partial class frmMain : Form
    {
        public frmMain()
        {

            InitializeComponent();
            OpenChildForm(new frmLogin());
            this.Hide();
            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(7, 71);
            panelMenu.Controls.Add(leftBorderBtn);
            //Form
            this.Text = string.Empty;
            this.ControlBox = false;
            this.FormBorderStyle = FormBorderStyle.None;
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;



        }

        private void kiemtraDangNhap()
        {
            if (KetQuaDangNhap.ketQua)
            {
                if (KetQuaDangNhap.LoaiTaiKhoan.Equals("Quản trị"))
                {
                    btnTaiKhoan.Visible = true;
                    btnCVHT.Visible = true;
                    btnLop.Visible = true;
                    btnNganh.Visible = true;
                    btnKhoa.Visible = true;
                    btnThongKe.Visible = true;
                }
                else if (KetQuaDangNhap.LoaiTaiKhoan.Equals("Cố vấn học tập"))
                {
                    btnTaiKhoan.Visible = false;
                    btnCVHT.Visible = false;
                    btnLop.Visible = false;
                    btnNganh.Visible = false;
                    btnKhoa.Visible = false;

                    btnThongKe.Visible = false;
                }
            }
        }

        private IconButton currentBtn;
        private Panel leftBorderBtn;
        private Form currentChildForm;

        #region ColorMain
        private struct RGBColors
        {
            public static Color color1 = Color.FromArgb(172, 126, 241);
            public static Color color2 = Color.FromArgb(249, 118, 176);
            public static Color color3 = Color.FromArgb(253, 138, 114);
            public static Color color4 = Color.FromArgb(95, 77, 221);
            public static Color color5 = Color.FromArgb(249, 88, 155);
            public static Color color6 = Color.FromArgb(24, 161, 251);
        }

        //Methods
        private void ActivateButton(object senderBtn, Color color)
        {
            if (senderBtn != null)
            {
                DisableButton();
                //Button
                currentBtn = (IconButton)senderBtn;
                currentBtn.BackColor = Color.FromArgb(37, 36, 81);
                currentBtn.ForeColor = color;
                currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                currentBtn.IconColor = color;
                currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                currentBtn.ImageAlign = ContentAlignment.MiddleRight;
                //Left border button
                leftBorderBtn.BackColor = color;
                leftBorderBtn.Location = new Point(0, currentBtn.Location.Y);
                leftBorderBtn.Visible = true;
                leftBorderBtn.BringToFront();
                //Icon current child form
                iconHome.IconChar = currentBtn.IconChar;
                iconHome.IconColor = color;


            }
        }

        private void DisableButton()
        {
            if (currentBtn != null)
            {
                currentBtn.BackColor = Color.FromArgb(31, 30, 68);
                currentBtn.ForeColor = Color.Gainsboro;
                currentBtn.TextAlign = ContentAlignment.MiddleLeft;
                currentBtn.IconColor = Color.Gainsboro;
                currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentBtn.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }

        private void btnDanhSachSV_Click(object sender, EventArgs e)
        {
            if (KetQuaDangNhap.ketQua == true)
            {
                ActivateButton(sender, RGBColors.color1);
                OpenChildForm(new frmSinhVien());
            }
            else
            {
                MessageBox.Show("Chưa đăng nhập tài khoản", "Thông báo");
            }
        }





        #endregion

        #region DragForm
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void panelTitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        #endregion

        private void Reset()
        {
            DisableButton();
            leftBorderBtn.Visible = false;
            iconHome.IconChar = IconChar.Home;
            iconHome.IconColor = Color.MediumPurple;
        }



        public void OpenChildForm(Form childForm)
        {
            kiemtraDangNhap();
            if (currentChildForm != null)
            {
                //open only form
                currentChildForm.Close();
            }
            currentChildForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelDesktop.Controls.Add(childForm);
            panelDesktop.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            lbHome.Text = childForm.Text;

        }

        private void btnTat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private bool isMaximized = false;

        private void btnMaxMin_Click(object sender, EventArgs e)
        {
            if (isMaximized)
            {
                this.WindowState = FormWindowState.Normal;
                isMaximized = false;
            }
            else
            {
                this.WindowState = FormWindowState.Maximized;
                isMaximized = true;
            }
        }

        private void btnHide_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;

        }

        public void ThongTinSinhVienShow(SinhVien_DTO sv)
        {
            OpenChildForm(new frmThongTinSinhVien(sv));
        }

        private void btnKhoa_Click(object sender, EventArgs e)
        {

            if (KetQuaDangNhap.ketQua == true)
            {
                ActivateButton(sender, RGBColors.color1);
                OpenChildForm(new frmKhoa());
            }
            else
            {
                MessageBox.Show("Chưa đăng nhập tài khoản", "Thông báo");
            }
        }

        private void btnNganh_Click(object sender, EventArgs e)
        {
            if (KetQuaDangNhap.ketQua == true)
            {
                ActivateButton(sender, RGBColors.color1);
                OpenChildForm(new frmNganh());
            }
            else
            {
                MessageBox.Show("Chưa đăng nhập tài khoản", "Thông báo");
            }
        }


        private void btnLop_Click(object sender, EventArgs e)
        {

            if (KetQuaDangNhap.ketQua == true)
            {
                ActivateButton(sender, RGBColors.color1);
                OpenChildForm(new frmLop());
            }
            else
            {
                MessageBox.Show("Chưa đăng nhập tài khoản", "Thông báo");
            }

        }

        private void btnDiem_Click(object sender, EventArgs e)
        {
            if (KetQuaDangNhap.ketQua == true)
            {
                ActivateButton(sender, RGBColors.color1);
                OpenChildForm(new frmDiem());
            }
            else
            {
                MessageBox.Show("Chưa đăng nhập tài khoản", "Thông báo");
            }
        }

        private void btnMonHoc_Click(object sender, EventArgs e)
        {
            if (KetQuaDangNhap.ketQua == true)
            {
                ActivateButton(sender, RGBColors.color1);
                OpenChildForm(new frmMonHoc());
            }
            else
            {
                MessageBox.Show("Chưa đăng nhập tài khoản", "Thông báo");
            }
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            btnTaiKhoan.Visible = false;
            btnCVHT.Visible = false;
            btnLop.Visible = false;
            btnNganh.Visible = false;
            btnKhoa.Visible = false;
            btnThongKe.Visible = false;
            Reset();
            lbHome.Text = "Home";

        }



        private void btnTaiKhoan_Click_1(object sender, EventArgs e)
        {
            if (KetQuaDangNhap.ketQua == true)
            {
                ActivateButton(sender, RGBColors.color1);
                OpenChildForm(new frmTaiKhoan());
            }
            else
            {
                MessageBox.Show("Chưa đăng nhập tài khoản", "Thông báo");
            }

        }

        private void btnCVHT_Click(object sender, EventArgs e)
        {
            if (KetQuaDangNhap.ketQua == true)
            {
                ActivateButton(sender, RGBColors.color1);
                OpenChildForm(new frmCVHT());
            }
            else
            {
                MessageBox.Show("Chưa đăng nhập tài khoản", "Thông báo");
            }
        }



        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn đăng xuất", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result == DialogResult.OK)
            {
                OpenChildForm(new frmLogin());
                KetQuaDangNhap.ketQua = false;
                Reset();
                lbHome.Text = "Home";
            }
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            Reset();
            lbHome.Text = "Home";
        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            if (KetQuaDangNhap.ketQua == true)
            {
                ActivateButton(sender, RGBColors.color1);
                OpenChildForm(new frmBaoCao());
            }
            else
            {
                MessageBox.Show("Chưa đăng nhập tài khoản", "Thông báo");
            }
        }
    }
}
