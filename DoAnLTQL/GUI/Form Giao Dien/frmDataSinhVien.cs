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
    public partial class frmDataSinhVien : Form
    {
        public frmDataSinhVien()
        {
            InitializeComponent();
        }

        private void frmDataSinhVien_Load(object sender, EventArgs e)
        {
            loadDataGridViewSinhVien();
            loadComboBoxHienSinhVien();
            loadComboBoxHienLop();
        }

        private string chonLop = "---Chọn lớp---";
        private void loadComboBoxHienLop()
        {
            cboChonLop.Items.Add(chonLop);
            List<Lop_DTO> lstlop = Lop_BUS.LayListLop();
            foreach (Lop_DTO lop in lstlop)
            {
                cboChonLop.Items.Add(lop.TenLop);
            }
        }

        private void loadComboBoxHienSinhVien()
        {
            cboHienSinhVien.Items.Add("Còn học");
            cboHienSinhVien.Items.Add("Đã nghỉ học");
            cboHienSinhVien.Items.Add("Tất cả");
        }

        private void loadDataGridViewSinhVien()
        {
            List<SinhVien_DTO> lstSinhVien = SinhVien_BUS.LayListSinhVien();
            if (lstSinhVien != null && lstSinhVien.Count > 0)
            {
                dgvSinhVien.DataSource = lstSinhVien;
                hienthi();
            }
            else
            {
                MessageBox.Show("Chưa có dữ liệu trong bảng!", "Thông báo");
            }
        }
        private void hienthi()
        {
            dgvSinhVien.Columns["Id"].HeaderText = "ID";
            dgvSinhVien.Columns["Id"].Width = 100;
            dgvSinhVien.Columns["MaSinhVien"].HeaderText = "Mã sinh viên";
            dgvSinhVien.Columns["MaSinhVien"].Width = 200;
            dgvSinhVien.Columns["HoVaTenSV"].HeaderText = "Họ tên sinh viên";
            dgvSinhVien.Columns["HoVaTenSV"].Width = 200;
            dgvSinhVien.Columns["GioiTinh"].HeaderText = "Giới tính";
            dgvSinhVien.Columns["GioiTinh"].Width = 180;
            dgvSinhVien.Columns["NgaySinh"].HeaderText = "Ngày sinh";
            dgvSinhVien.Columns["NgaySinh"].Width = 220;
            dgvSinhVien.Columns["DiaChi"].HeaderText = "Địa chỉ";
            dgvSinhVien.Columns["DiaChi"].Width = 250;
            dgvSinhVien.Columns["SoDienThoai"].HeaderText = "Số điện thoại";
            dgvSinhVien.Columns["SoDienThoai"].Width = 200;
            dgvSinhVien.Columns["NgayNhapHoc"].HeaderText = "Ngày nhập học";
            dgvSinhVien.Columns["NgayNhapHoc"].Width = 220;
            dgvSinhVien.Columns["MaLop"].HeaderText = "Mã lớp";
            dgvSinhVien.Columns["MaLop"].Width = 200;
            dgvSinhVien.Columns["NgaySinh"].DefaultCellStyle.Format = "dd/MM/yyyy";
            dgvSinhVien.Columns["NgayNhapHoc"].DefaultCellStyle.Format = "dd/MM/yyyy";
            dgvSinhVien.Columns["Id"].Visible = false;
            dgvSinhVien.Columns["TrangThai"].Visible = false;
        }
        private void btnDoiKieu_Click(object sender, EventArgs e)
        {
            frmSinhVien frmSinhVien = new frmSinhVien();
            foreach (Form form in Application.OpenForms)
            {
                if (form is frmMain)
                {
                    ((frmMain)form).OpenChildForm(frmSinhVien);
                    break;
                }
            }
        }

        private void cboHienSinhVien_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboHienSinhVien.Texts.Equals("Tất cả"))
            {
                List<SinhVien_DTO> lstSinhVien = SinhVien_BUS.LayListSinhVien();
                if(lstSinhVien!=null && lstSinhVien.Count > 0)
                {
                    dgvSinhVien.DataSource = lstSinhVien;
                    hienthi();
                }
                else
                {
                    dgvSinhVien.DataSource = null;
                }
            }
            else if (cboHienSinhVien.Texts.Equals("Còn học"))
            {
                List<SinhVien_DTO> lstSinhVien = SinhVien_BUS.DanhSachSinhVienConHoc();
                if (lstSinhVien != null && lstSinhVien.Count > 0)
                {
                    dgvSinhVien.DataSource = lstSinhVien;
                    hienthi();
                }
                else
                {
                    dgvSinhVien.DataSource = null;
                }
            }
            else if (cboHienSinhVien.Texts.Equals("Đã nghỉ học"))
            {
                List<SinhVien_DTO> lstSinhVien = SinhVien_BUS.DanhSachSinhVienDaNghiHoc();
                if (lstSinhVien != null && lstSinhVien.Count > 0)
                {
                    dgvSinhVien.DataSource = lstSinhVien;
                    hienthi();
                }
                else
                {
                    dgvSinhVien.DataSource=null;
                }
            }
        }

        private void cboChonLop_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboChonLop.Texts.Equals(chonLop))
            {
                List<SinhVien_DTO> lstSinhVien = SinhVien_BUS.LayListSinhVien();
                if (lstSinhVien != null && lstSinhVien.Count > 0)
                {
                    dgvSinhVien.DataSource = lstSinhVien;
                    hienthi();
                }
                else
                {
                    dgvSinhVien.DataSource = null;
                }
            }
            else
            {
                List<SinhVien_DTO> lstSinhVien = SinhVien_BUS.LaySinhVienTheoLop(cboChonLop.Texts);
                if (lstSinhVien != null && lstSinhVien.Count > 0)
                {
                    dgvSinhVien.DataSource = lstSinhVien;
                    hienthi();
                }
                else
                {
                    dgvSinhVien.DataSource = null;
                }
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            if (txtTimSinhVien.TextString.Equals(hintText) == true)
            {
                MessageBox.Show("Vui lòng nhập mã số sinh viên cần tìm!", "Thông báo");
            }
            else
            {
                string chuoi = txtTimSinhVien.TextString;
                string mssv = chuoi.ToUpper();
                List<SinhVien_DTO> lstSinhVien = SinhVien_BUS.TimSinhVienTheoMSSV(mssv);

                if (lstSinhVien == null)
                {
                    MessageBox.Show("Đã xảy ra lỗi khi tìm kiếm sinh viên!", "Thông báo");
                }
                else if (lstSinhVien.Count == 0)
                {
                    MessageBox.Show("Không có sinh viên nào phù hợp với MSSV đã nhập!", "Thông báo");
                }
                else
                {
                    dgvSinhVien.DataSource = lstSinhVien;
                    hienthi();
                }

            }
        }

        private string hintText = "Nhập mã số sinh viên...";

        private void txtTimSinhVien_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTimSinhVien.TextString))
            {
                txtTimSinhVien.TextString = hintText;
                txtTimSinhVien.ForeColor = SystemColors.GrayText;
            }
        }

        private void txtTimSinhVien_Enter(object sender, EventArgs e)
        {
            if (txtTimSinhVien.TextString.Equals(hintText) == true)
            {
                txtTimSinhVien.TextString = "";
                txtTimSinhVien.ForeColor = SystemColors.WindowText;
            }
        }

        private void btnThemSinhVien_Click(object sender, EventArgs e)
        {
            frmThemSinhVien frmThemSinhVien = new frmThemSinhVien();
            foreach (Form form in Application.OpenForms)
            {
                if (form is frmMain)
                {
                    ((frmMain)form).OpenChildForm(frmThemSinhVien);
                    break;
                }
            }
        }

        private void dgvSinhVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= -1)
            {
                DataGridViewRow row = dgvSinhVien.SelectedRows[0];
                SinhVien_DTO sv = SinhVien_BUS.TimSinhVienMSSV(row.Cells[1].Value.ToString());
                if (sv != null)
                {
                    (this.ParentForm as frmMain)?.ThongTinSinhVienShow(sv);
                }
            }
        }
    }
}
