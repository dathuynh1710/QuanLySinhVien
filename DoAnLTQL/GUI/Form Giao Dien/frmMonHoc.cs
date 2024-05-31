using BUS;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Media;

namespace GUI.Form_Giao_Dien
{
    public partial class frmMonHoc : Form
    {
        public frmMonHoc()
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

        private void frmMonHoc_Load(object sender, EventArgs e)
        {
            loadDataGridViewMonHoc();
            loadComboBoxMonHoc();

        }

        private void loadComboBoxMonHoc()
        {
            cboLocMonHoc.Items.Add("Tất cả");
            cboLocMonHoc.Items.Add("Còn dạy");
            cboLocMonHoc.Items.Add("Đã nghỉ dạy");
        }

        private void loadDataGridViewMonHoc()
        {
            List<MonHoc_DTO> lstmh = MonHoc_BUS.LayListMonHoc();
            if (lstmh != null && lstmh.Count > 0)
            {
                dgvMonHoc.DataSource = lstmh;
                SetCot(dgvMonHoc);
            }
        }

        private void SetCot(DataGridView dgvMonHoc)
        {
            dgvMonHoc.Columns["Id"].HeaderText = "ID";
            dgvMonHoc.Columns["Id"].Width = 140;
            dgvMonHoc.Columns["MaMonHoc"].HeaderText = "Mã Môn học";
            dgvMonHoc.Columns["MaMonHoc"].Width = 180;
            dgvMonHoc.Columns["TenMonHoc"].HeaderText = "Tên Môn học";
            dgvMonHoc.Columns["TenMonHoc"].Width = 200;
            dgvMonHoc.Columns["SoTinChi"].HeaderText = "Số tín chỉ";
            dgvMonHoc.Columns["SoTinChi"].Width = 180;
            dgvMonHoc.Columns["TietLyThuyet"].HeaderText = "Tiết lý thuyết";
            dgvMonHoc.Columns["TietLyThuyet"].Width = 180;
            dgvMonHoc.Columns["TietThucHanh"].HeaderText = "Tiết thực hành";
            dgvMonHoc.Columns["TietThucHanh"].Width = 180;
            dgvMonHoc.Columns["TrangThai"].HeaderText = "Hoạt Động";
            dgvMonHoc.Columns["TrangThai"].Width = 180;
            /*dgvMonHoc.Columns["TrangThai"].Visible = false;*/
            dgvMonHoc.Columns["Id"].Visible = false;
        }

        private void btnThemMonHoc_Click(object sender, EventArgs e)
        {
            if (txtMaMonHoc.TextString.Equals("") || txtTenMonHoc.TextString.Equals("")
               || txtSoTinChi.TextString.Equals("") || txtTietLyThuyet.TextString.Equals("") ||
               txtTietThucHanh.TextString.Equals(""))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin Môn học!", "Thông báo");
            }
            else if(!IsNumeric(txtSoTinChi.TextString) || !IsNumeric(txtTietLyThuyet.TextString)
                || !IsNumeric(txtTietThucHanh.TextString))
            {
                MessageBox.Show("Số tín chỉ, tiết lý thuyết và tiết thực hành phải là số!", "Thông báo");
            }
            else
            {
                bool kq = MonHoc_BUS.KiemTraMonHoc(txtMaMonHoc.TextString.Trim());
                if (kq == false)
                {
                    MonHoc_DTO monhoc = new MonHoc_DTO();
                    monhoc.MaMonHoc = txtMaMonHoc.TextString.Trim();
                    monhoc.TenMonHoc = txtTenMonHoc.TextString.Trim();
                    monhoc.SoTinChi = int.Parse(txtSoTinChi.TextString);
                    monhoc.TietLyThuyet = int.Parse(txtTietLyThuyet.TextString);
                    monhoc.TietThucHanh = int.Parse(txtTietThucHanh.TextString);
                    bool ketQua = MonHoc_BUS.ThemMonHoc(monhoc);

                    if (ketQua)
                    {
                        MessageBox.Show("Thêm Môn học thành công", "Thông báo");
                        loadDataGridViewMonHoc();
                    }
                    else
                    {
                        MessageBox.Show("Thêm Môn học không thành công", "Thông báo");
                    }
                }
                else
                {
                    MessageBox.Show("Môn học đã tồn tại", "Thông báo");
                }
            }
        }

        private void btnCapNhatMonHoc_Click(object sender, EventArgs e)
        {
            if (txtMaMonHoc.TextString.Equals("") || txtTenMonHoc.TextString.Equals("")
               || txtSoTinChi.TextString.Equals("") || txtTietLyThuyet.TextString.Equals("") ||
               txtTietThucHanh.TextString.Equals(""))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin Môn học!", "Thông báo");
            }
            else
            {
                bool kq = MonHoc_BUS.KiemTraMonHoc(txtMaMonHoc.TextString.Trim());
                if (kq == true)
                {
                    MonHoc_DTO monhoc = MonHoc_BUS.TimMonHocTheoMaMonHoc(txtMaMonHoc.TextString.Trim());
                    monhoc.MaMonHoc = txtMaMonHoc.TextString.Trim();
                    monhoc.TenMonHoc = txtTenMonHoc.TextString.Trim();
                    monhoc.SoTinChi = int.Parse(txtSoTinChi.TextString);
                    monhoc.TietLyThuyet = int.Parse(txtTietLyThuyet.TextString);
                    monhoc.TietThucHanh = int.Parse(txtTietThucHanh.TextString);
                    bool ketQua = MonHoc_BUS.SuaMonHoc(monhoc);

                    if (ketQua)
                    {
                        MessageBox.Show("Cập nhật Môn học thành công", "Thông báo");
                        loadDataGridViewMonHoc();
                    }
                    else
                    {
                        MessageBox.Show("Cập nhật Môn học không thành công", "Thông báo");
                    }
                }
                else
                {
                    MessageBox.Show("Môn học chưa tồn tại", "Thông báo");
                }
            }
        }

        private void dgvMonHoc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= -1)
            {
                DataGridViewRow row = dgvMonHoc.Rows[e.RowIndex];
                txtMaMonHoc.TextString = row.Cells[1].Value.ToString().Trim();
                txtTenMonHoc.TextString = row.Cells[2].Value.ToString().Trim();
                txtSoTinChi.TextString = row.Cells[3].Value.ToString().Trim();
                txtTietLyThuyet.TextString = row.Cells[4].Value.ToString().Trim();
                txtTietThucHanh.TextString = row.Cells[5].Value.ToString().Trim();
            }
        }

        private void btnXoaMonHoc_Click(object sender, EventArgs e)
        {
            if (txtMaMonHoc.TextString.Equals("") || txtTenMonHoc.TextString.Equals("")
               || txtSoTinChi.TextString.Equals("") || txtTietLyThuyet.TextString.Equals("") ||
               txtTietThucHanh.TextString.Equals(""))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin Môn học!", "Thông báo");
            }
            else
            {
                bool kq = MonHoc_BUS.KiemTraMonHoc(txtMaMonHoc.TextString.Trim());
                if (kq == true)
                {
                    MonHoc_DTO monhoc = MonHoc_BUS.TimMonHocTheoMaMonHoc(txtMaMonHoc.TextString.Trim());
                    bool ketQua = MonHoc_BUS.XoaMonHoc(monhoc);

                    if (ketQua)
                    {
                        MessageBox.Show("Xóa Môn học thành công", "Thông báo");
                        loadDataGridViewMonHoc();
                    }
                    else
                    {
                        MessageBox.Show("Xóa Môn học không thành công", "Thông báo");
                    }
                }
                else
                {
                    MessageBox.Show("Môn học chưa tồn tại", "Thông báo");
                }
            }
        }

        public bool IsNumeric(string input)
        {
            // Biểu thức chính quy kiểm tra chuỗi chỉ chứa các ký tự số từ 0 đến 9
            Regex regex = new Regex(@"^\d+$");

            // So sánh chuỗi với biểu thức chính quy
            return regex.IsMatch(input);
        }

        private void cboLocMonHoc_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            dgvMonHoc.DataSource = null;
            if(cboLocMonHoc.Texts.Equals("Tất cả"))
            {
                List<MonHoc_DTO> listMonHoc = MonHoc_BUS.LayListTatCaMonHoc();
                if(listMonHoc!=null && listMonHoc.Count > 0)
                {
                    dgvMonHoc.DataSource = listMonHoc;
                    SetCot(dgvMonHoc);
                }
            }
            else if(cboLocMonHoc.Texts.Equals("Còn dạy"))
            {
                List<MonHoc_DTO> listMonHoc = MonHoc_BUS.LayListMonHoc();
                if (listMonHoc != null && listMonHoc.Count > 0)
                {
                    dgvMonHoc.DataSource = listMonHoc;
                    SetCot(dgvMonHoc);
                }
            }
            else if (cboLocMonHoc.Texts.Equals("Đã nghỉ dạy"))
            {
                List<MonHoc_DTO> listMonHoc = MonHoc_BUS.LayListMonHocKhongConDay();
                if (listMonHoc != null && listMonHoc.Count > 0)
                {
                    dgvMonHoc.DataSource = listMonHoc;
                    SetCot(dgvMonHoc);
                }
            }

        }

        private void btnKhoiPhuc_Click(object sender, EventArgs e)
        {
            if (txtMaMonHoc.TextString.Equals("") || txtTenMonHoc.TextString.Equals("")
               || txtSoTinChi.TextString.Equals("") || txtTietLyThuyet.TextString.Equals("") ||
               txtTietThucHanh.TextString.Equals(""))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin Môn học!", "Thông báo");
            }
            else
            {
                bool kq = MonHoc_BUS.KiemTraMonHoc(txtMaMonHoc.TextString.Trim());
                if (kq == true)
                {
                    MonHoc_DTO monhoc = MonHoc_BUS.TimMonHocTheoMaMonHoc(txtMaMonHoc.TextString.Trim());
                    monhoc.MaMonHoc = txtMaMonHoc.TextString.Trim();
                    monhoc.TenMonHoc = txtTenMonHoc.TextString.Trim();
                    monhoc.SoTinChi = int.Parse(txtSoTinChi.TextString);
                    monhoc.TietLyThuyet = int.Parse(txtTietLyThuyet.TextString);
                    monhoc.TietThucHanh = int.Parse(txtTietThucHanh.TextString);
                    bool ketQua = MonHoc_BUS.KhoiPhucMonHoc(monhoc);

                    if (ketQua)
                    {
                        MessageBox.Show("Khôi phục Môn học thành công", "Thông báo");
                        loadDataGridViewMonHoc();
                    }
                    else
                    {
                        MessageBox.Show("Khôi phục Môn học không thành công", "Thông báo");
                    }
                }
                else
                {
                    MessageBox.Show("Môn học chưa tồn tại", "Thông báo");
                }
            }

        }
    }
}
