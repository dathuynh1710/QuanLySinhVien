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
    public partial class frmTaiKhoan : Form
    {
        public frmTaiKhoan()
        {
            InitializeComponent();
            CenterControl(panelGroup);
        }

        private void CenterControl(Control control)
        {
            control.Anchor = AnchorStyles.None; // Bỏ anchor để không bị lệch khi form thay đổi kích thước
            int x = (this.ClientSize.Width - control.Width) / 2;
            int y = (this.ClientSize.Height - control.Height) / 2;
            control.Location = new Point(x, y);
        }
        private void frmTaiKhoan_Load(object sender, EventArgs e)
        {
            loadDataGridViewTaiKhoan();
            loadComboBoxLoaiTaiKhoan();
        }

        private void loadDataGridViewTaiKhoan()
        {
            List<TaiKhoan_DTO> lstTaiKhoan = TaiKhoan_BUS.LayListTaiKhoan();
            if (lstTaiKhoan != null && lstTaiKhoan.Count > 0)
            {
                dgvTaiKhoan.DataSource = lstTaiKhoan;
                dgvTaiKhoan.Columns["Id"].HeaderText = "ID";
                dgvTaiKhoan.Columns["Id"].Width = 80;
                dgvTaiKhoan.Columns["TenDangNhap"].HeaderText = "Tên đăng nhập";
                dgvTaiKhoan.Columns["TenDangNhap"].Width = 180;
                dgvTaiKhoan.Columns["MatKhau"].HeaderText = "Mật khẩu";
                dgvTaiKhoan.Columns["MatKhau"].Width = 180;
                dgvTaiKhoan.Columns["LoaiTaiKhoan"].HeaderText = "Loại tài khoản";
                dgvTaiKhoan.Columns["LoaiTaiKhoan"].Width = 180;
                dgvTaiKhoan.Columns["TrangThai"].HeaderText = "Hoạt Động";
                dgvTaiKhoan.Columns["TrangThai"].Width = 155;
                /*dgvTaiKhoan.Columns["TrangThai"].Visible = false;
                dgvTaiKhoan.Columns["Id"].Visible = false;*/
            }
        }

        private void loadComboBoxLoaiTaiKhoan()
        {
            List<TaiKhoan_DTO> lstTaiKhoan = TaiKhoan_BUS.LayListTaiKhoan();
            if (lstTaiKhoan != null && lstTaiKhoan.Count > 0)
            {
                foreach(TaiKhoan_DTO tk  in lstTaiKhoan)
                {
                    cboLoaiTaiKhoan.Items.Add(tk.LoaiTaiKhoan);
                }
            }
        }

        private void dgvTaiKhoan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= -1)
            {
                DataGridViewRow row = dgvTaiKhoan.Rows[e.RowIndex];

                txtTenDangNhap.TextString = row.Cells[1].Value.ToString().Trim();
                txtMatKhau.TextString = row.Cells[2].Value.ToString();
                TaiKhoan_DTO tk = TaiKhoan_BUS.LayLoaiTaiKhoan(txtTenDangNhap.TextString);
                if (tk != null)
                {
                    cboLoaiTaiKhoan.Texts = tk.LoaiTaiKhoan;
                    taikhoan.LoaiTaiKhoan = tk.LoaiTaiKhoan;
                }
                taikhoan.TenDangNhap = row.Cells[1].Value.ToString().Trim();
                taikhoan.MatKhau = row.Cells[2].Value.ToString();
            }
        }

        private void btnThemTaiKhoan_Click(object sender, EventArgs e)
        {
            if (txtTenDangNhap.TextString.Trim().Equals("") || txtMatKhau.TextString.Trim().Equals("") || cboLoaiTaiKhoan.Texts.Trim().Equals(""))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Thông báo");

            }
            else
            {
                string tenDangNhap = txtTenDangNhap.TextString.Trim();

                if (TaiKhoan_BUS.KiemTraTen(tenDangNhap) == false)
                {
                    TaiKhoan_DTO tk = new TaiKhoan_DTO();

                    tk.TenDangNhap = txtTenDangNhap.TextString.Trim();
                    tk.MatKhau = txtMatKhau.TextString;
                    tk.LoaiTaiKhoan = cboLoaiTaiKhoan.Texts;

                    bool ketQua = TaiKhoan_BUS.ThemTaiKhoan(tk);

                    if (ketQua)
                    {
                        MessageBox.Show("Thêm Tài Khoản thành công", "Thông báo");
                        loadDataGridViewTaiKhoan();
                    }
                    else
                    {
                        MessageBox.Show("Thêm Tài Khoản không thành công", "Thông báo");
                    }
                }
                else
                {
                    MessageBox.Show("Tên đăng nhập đã tồn tại", "Thông báo");
                }
            }
        }

        private TaiKhoan_DTO taikhoan = new TaiKhoan_DTO();
        private void btnCapNhatTaiKhoan_Click(object sender, EventArgs e)
        {
            if (txtTenDangNhap.TextString.Trim().Equals("") || txtMatKhau.TextString.Trim().Equals("") || cboLoaiTaiKhoan.Texts.Trim().Equals(""))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Thông báo");

            }
            else
            {
                string tenDangNhap = txtTenDangNhap.TextString.Trim();

                if (TaiKhoan_BUS.KiemTraTen(tenDangNhap) == true)
                {
                    TaiKhoan_DTO tk = TaiKhoan_BUS.LayLoaiTaiKhoan(txtTenDangNhap.TextString.Trim());

                    if (txtTenDangNhap.TextString.Trim().Equals(taikhoan.TenDangNhap))
                    {
                        tk.MatKhau = txtMatKhau.TextString.Trim();
                        tk.LoaiTaiKhoan = cboLoaiTaiKhoan.Texts;

                        bool ketQua = TaiKhoan_BUS.CapNhatTaiKhoan(tk);

                        if (ketQua)
                        {
                            MessageBox.Show("Cập nhật Tài Khoản thành công", "Thông báo");
                            loadDataGridViewTaiKhoan();
                        }
                        else
                        {
                            MessageBox.Show("Cập nhật Tài Khoản không thành công", "Thông báo");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Chỉ có thể cập nhật mật khẩu và loại tài khoản");
                    }
                    
                }
                else
                {
                    MessageBox.Show("Không thể cập nhật tên tài khoản chưa tồn tại", "Thông báo");
                }
            }
        }

        private void btnXoaTaiKhoan_Click(object sender, EventArgs e)
        {
            if (txtTenDangNhap.TextString.Trim().Equals("") || txtMatKhau.TextString.Trim().Equals("") || cboLoaiTaiKhoan.Texts.Trim().Equals(""))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Thông báo");

            }
            else
            {
                string tenDangNhap = txtTenDangNhap.TextString.Trim();

                if (TaiKhoan_BUS.KiemTraTen(tenDangNhap) == true)
                {
                    TaiKhoan_DTO tk = TaiKhoan_BUS.LayLoaiTaiKhoan(tenDangNhap);

                    bool ketQua = TaiKhoan_BUS.XoaTaiKhoan(tk);

                    if (ketQua)
                    {
                        MessageBox.Show("Xóa Tài Khoản thành công", "Thông báo");
                        loadDataGridViewTaiKhoan();
                    }
                    else
                    {
                        MessageBox.Show("Xóa Tài Khoản không thành công", "Thông báo");
                    }
                }
                else
                {
                    MessageBox.Show("Tài khoản không tồn tại", "Thông báo");
                }
            }
        }
    }
}
