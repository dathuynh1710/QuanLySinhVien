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
    public partial class frmThemSinhVien : Form
    {
        public frmThemSinhVien()
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

        private void frmThemSinhVien_Load(object sender, EventArgs e)
        {
            loadComboBoxLop();
            dtpNgaySinh.Format = DateTimePickerFormat.Custom;
            dtpNgaySinh.CustomFormat = "dd/MM/yyyy";
            dtpNgayNhapHoc.Format = DateTimePickerFormat.Custom;
            dtpNgayNhapHoc.CustomFormat = "dd/MM/yyyy";
            LoadComboBoxTrangThai();
        }

        private void btnTroVe_Click(object sender, EventArgs e)
        {
            foreach (Form form in Application.OpenForms)
            {
                // Kiểm tra xem form có phải là frmMain không
                if (form is frmMain)
                {
                    // Nếu là frmMain, thực hiện phương thức OpenChildForm
                    ((frmMain)form).OpenChildForm(new frmSinhVien());
                    break; // Thoát khỏi vòng lặp sau khi thực hiện xong
                }
            }
        }

        private void LoadComboBoxTrangThai()
        {
            cboTrangThai.Items.Add("Còn học");
            cboTrangThai.Items.Add("Đã nghỉ học");
        }

        private void loadComboBoxLop()
        {
            List<Lop_DTO> lstLop = Lop_BUS.LayListLop();
            foreach (Lop_DTO lop in lstLop)
            {
                cboLop.Items.Add(lop.TenLop);
            }
        }

        private void btnThemSinhVien_Click(object sender, EventArgs e)
        {
            if (txtMSSV.TextString.Equals("") || txtHoTen.TextString.Equals("") 
                || txtDiaChi.TextString.Equals("") || txtSDT.TextString.Equals("") ||
                cboLop.Texts.Equals("") || (rdoNam.Checked==false && rdoNu.Checked==false) )
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin sinh viên!", "Thông báo");
            }
            else
            {
                bool sinhvientontai = SinhVien_BUS.KiemTraMSSV(txtMSSV.TextString);
                if (sinhvientontai!=true)
                {
                    SinhVien_DTO sv = new SinhVien_DTO();
                    sv.MaSinhVien = txtMSSV.TextString.Trim();
                    sv.HoVaTenSV = txtHoTen.TextString.Trim();
                    if (rdoNam.Checked == true)
                    {
                        sv.GioiTinh = "Nam";
                    }
                    else if (rdoNu.Checked == true)
                    {
                        sv.GioiTinh = "Nữ";
                    }
                    sv.NgaySinh = dtpNgaySinh.Value.ToString("yyyy-MM-dd");
                    sv.DiaChi = txtDiaChi.TextString.Trim();
                    sv.SoDienThoai = txtSDT.TextString.Trim();
                    sv.NgayNhapHoc = dtpNgayNhapHoc.Value.ToString("yyyy-MM-dd");
                    if (cboTrangThai.Texts.Equals("Còn học"))
                    {
                        sv.TrangThai = 1;
                    }
                    else if (cboTrangThai.Texts.Equals("Đã nghỉ học"))
                    {
                        sv.TrangThai = 0;
                    }
                    Lop_DTO lop = Lop_BUS.TimLopTheoTenLop(cboLop.Texts);
                    sv.MaLop = lop.MaLop;
                    bool kq = SinhVien_BUS.ThemSinhVien(sv);
                    if (kq)
                    {
                        MessageBox.Show("Thêm sinh viên thành công", "Thông báo");
                        bool ketQua = Lop_BUS.CapNhatSoLuongSinhVien(lop);
                        if (ketQua)
                        {
                            MessageBox.Show("Cập nhật số lượng sinh viên của lớp thành công", "Thông báo");
                        }
                        else
                        {
                            MessageBox.Show("Cập nhật số lượng sinh viên của lớp không thành công", "Thông báo");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Thêm sinh viên không thành công", "Thông báo");
                    }
                }
                else
                {
                    MessageBox.Show("Sinh viên đã tồn tại", "Thông báo");
                }
            }


        }

        
    }
}
