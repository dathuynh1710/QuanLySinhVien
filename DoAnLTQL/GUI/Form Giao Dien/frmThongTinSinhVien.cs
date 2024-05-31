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
    public partial class frmThongTinSinhVien : Form
    {
        private SinhVien_DTO sv;
        public frmThongTinSinhVien(SinhVien_DTO sv)
        {
            InitializeComponent();
            if (sv != null)
            {
                this.sv = sv;
                ChinhGiaoDien();
            }
        }

        public frmThongTinSinhVien()
        {
            InitializeComponent();
        }

        private void frmThongTinSinhVien_Load(object sender, EventArgs e)
        {
            dtpNgaySinh.Format = DateTimePickerFormat.Custom;
            dtpNgaySinh.CustomFormat = "dd/MM/yyyy";
            dtpNgayNhapHoc.Format = DateTimePickerFormat.Custom;
            dtpNgayNhapHoc.CustomFormat = "dd/MM/yyyy";
            if (sv != null)
            {
                HienThiThongTinSV();
            }
            LoadComboBoxTrangThai();
            LoadComboBoxKhoa();
            loadComboBoxLop();
            loadComboBoxNganh();
            loadComboBoxCVHT();
        }

        private void loadComboBoxLop()
        {
            List<Lop_DTO> lstLop = Lop_BUS.LayListLop();
            foreach(Lop_DTO lop in lstLop)
            {
                cboLop.Items.Add(lop.TenLop);
            }
        }

        private void loadComboBoxNganh()
        {
            List<Nganh_DTO> lstnganh = Nganh_BUS.LayListNganh();
            foreach (Nganh_DTO nganh in lstnganh)
            {
                cboNganh.Items.Add(nganh.TenNganh);
            }
        }

        private void loadComboBoxCVHT()
        {
            List<CVHT_DTO> lstCVHT = CVHT_BUS.LayListCVHT();
            foreach (CVHT_DTO cvht in lstCVHT)
            {
                cboCVHT.Items.Add(cvht.TenCVHT);
            }
            
        }

        private void HienThiThongTinSV()
        {
            txtMSSV.TextString = sv.MaSinhVien;
            txtHoTen.TextString = sv.HoVaTenSV;
            if (sv.GioiTinh.Equals("Nam"))
            {
                rdoNam.Checked = true;
            }
            else if (sv.GioiTinh.Equals("Nữ"))
            {
                rdoNu.Checked = true;
            }
            dtpNgaySinh.Value = DateTime.Parse(sv.NgaySinh);
            txtDiaChi.TextString = sv.DiaChi;
            txtSDT.TextString = sv.SoDienThoai;
            if (sv.TrangThai == 1)
            {
                cboTrangThai.Texts = "Còn học";
            }
            else if (sv.TrangThai == 0)
            {
                cboTrangThai.Texts = "Không còn học";
            }
            Lop_DTO lop = Lop_BUS.TimLopTheoMaLop(sv.MaLop);
            cboLop.Texts = lop.TenLop;
            Nganh_DTO nganh = Nganh_BUS.TimNganhCuaSV(lop.MaNganh);
            cboNganh.Texts = nganh.TenNganh;
            Khoa_DTO khoa = Khoa_BUS.TimKhoaCuaSV(nganh.MaKhoa);
            cboKhoa.Texts = khoa.TenKhoa;
            CVHT_DTO cvht = CVHT_BUS.TimCVHTCuaSV(lop.MaCVHT);
            cboCVHT.Texts = cvht.TenCVHT;



        }
        private void LoadComboBoxKhoa()
        {
            List<Khoa_DTO> listKhoa = Khoa_BUS.LayListKhoa();
            foreach(Khoa_DTO khoa in  listKhoa)
            {
                cboKhoa.Items.Add(khoa.TenKhoa);
            }
        }

        private void LoadComboBoxTrangThai()
        {
            cboTrangThai.Items.Add("Còn học");
            cboTrangThai.Items.Add("Đã nghỉ học");
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn cập nhật sinh viên này!", "Thông báo", MessageBoxButtons.OK);
            if (result == DialogResult.OK)
            {
                sv.MaSinhVien = txtMSSV.TextString.Trim();
                sv.HoVaTenSV=txtHoTen.TextString.Trim();
                if (rdoNam.Checked==true)
                {
                    sv.GioiTinh = "Nam";
                }
                else if (rdoNu.Checked==true)
                {
                    sv.GioiTinh = "Nữ";
                }
                sv.NgaySinh = dtpNgaySinh.Value.ToString("yyyy-MM-dd");
                sv.DiaChi = txtDiaChi.TextString.Trim();
                sv.SoDienThoai = txtSDT.TextString.Trim();
                sv.NgayNhapHoc = dtpNgayNhapHoc.Value.ToString("yyyy-MM-dd");
                if(cboTrangThai.Texts.Equals("Còn học"))
                {
                    sv.TrangThai = 1;
                }else if (cboTrangThai.Texts.Equals("Không còn học"))
                {
                    sv.TrangThai = 0;
                }
                Lop_DTO lop = Lop_BUS.TimLopTheoMaLop(sv.MaLop);
                sv.MaLop = lop.MaLop;

                bool kq = SinhVien_BUS.SuaSinhVien(sv);

                if (kq)
                {
                    MessageBox.Show("Cập nhật sinh viên thành công!", "Thông báo");
                }
                else
                {
                    MessageBox.Show("Cập nhật sinh viên không thành công!", "Thông báo");
                }
            }
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

        public void ChinhGiaoDien()
        {
            CenterControl(panelGroup);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn xóa sinh viên này!", "Thông báo", MessageBoxButtons.OK);
            if (result==DialogResult.OK)
            {
                bool kq = SinhVien_BUS.XoaSinhVien(sv.Id);
                if(kq)
                {
                    MessageBox.Show("Đã xóa sinh viên!", "Thông báo");
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
                else
                {
                    MessageBox.Show("Xóa sinh viên không thành công!", "Thông báo");
                }

            }    
            
        }
        private void CenterControl(Control control)
        {
            control.Anchor = AnchorStyles.None; // Bỏ anchor để không bị lệch khi form thay đổi kích thước
            int x = (this.ClientSize.Width - control.Width) / 2;
            int y = (this.ClientSize.Height - control.Height) / 2;
            control.Location = new Point(x, y);
        }      
    }
}
