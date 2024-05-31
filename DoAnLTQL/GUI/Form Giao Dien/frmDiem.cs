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

namespace GUI.Form_Giao_Dien
{
    public partial class frmDiem : Form
    {
        public frmDiem()
        {
            InitializeComponent();
            CenterControl(panelGroup);
        }
        private void CenterControl(Control control)
        {
            control.Anchor = AnchorStyles.None; 
            int x = (this.ClientSize.Width - control.Width) / 2;
            int y = (this.ClientSize.Height - control.Height) / 2;
            control.Location = new Point(x, y);
        }

        private void frmDiem_Load(object sender, EventArgs e)
        {
            loadComboBoxSinhVien();
            loadComboBoxMonHoc();
            loadDataGridView();
        }

        private void loadDataGridView()
        {
            List<Diem_DTO> lstdiem = Diem_BUS.LayListDiemSinhVienConHocVaConMonHoc();
            if (lstdiem != null && lstdiem.Count > 0)
            {
                dgvDiem.DataSource = lstdiem;
                dgvDiem.Columns["Id"].HeaderText = "ID";
                dgvDiem.Columns["Id"].Width = 100;
                dgvDiem.Columns["MaMonHoc"].HeaderText = "Mã môn học";
                dgvDiem.Columns["MaMonHoc"].Width = 180;
                dgvDiem.Columns["MaSinhVien"].HeaderText = "Mã sinh viên";
                dgvDiem.Columns["MaSinhVien"].Width = 180;
                dgvDiem.Columns["PhanTramTrenLop"].HeaderText = "Phần trăm trên lớp";
                dgvDiem.Columns["PhanTramTrenLop"].Width = 150;
                dgvDiem.Columns["PhanTramThi"].HeaderText = "Phần trăm thi";
                dgvDiem.Columns["PhanTramThi"].Width = 180;
                dgvDiem.Columns["DiemTrenLop"].HeaderText = "Điểm trên lớp";
                dgvDiem.Columns["DiemTrenLop"].Width = 150;
                dgvDiem.Columns["DiemThi"].HeaderText = "Điểm thi";
                dgvDiem.Columns["DiemThi"].Width = 180;
                dgvDiem.Columns["DiemTB"].HeaderText = "Điểm trung bình";
                dgvDiem.Columns["DiemTB"].Width = 180;
                dgvDiem.Columns["Loai"].HeaderText = "loại";
                dgvDiem.Columns["Loai"].Width = 150;
            }
            else
            {
                MessageBox.Show("Chưa có dữ liệu trong bảng!", "Thông báo");
            }
        }

        private void loadComboBoxSinhVien()
        {
            List<SinhVien_DTO> lstSinhVien = SinhVien_BUS.LayListSinhVien();
            foreach (SinhVien_DTO sv in lstSinhVien)
            {
                cboTenSinhVien.Items.Add(sv.HoVaTenSV);
            }
        }

        private void loadComboBoxMonHoc()
        {
            List<MonHoc_DTO> lstMonHoc = MonHoc_BUS.LayListMonHoc();
            foreach (MonHoc_DTO mh in lstMonHoc)
            {
                cboTenMonHoc.Items.Add(mh.TenMonHoc);
            }
        }

        private void btnThemDiem_Click(object sender, EventArgs e)
        {
            if (cboTenMonHoc.Texts.Equals("") || cboTenSinhVien.Texts.Equals("")
               || txtDiemThi.TextString.Equals("") || txtDiemTrenLop.TextString.Equals("") ||
               txtPhanTramThi.TextString.Equals("") || txtPhanTramTrenLop.TextString.Equals(""))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin sinh viên!", "Thông báo");
            }
            else if (!IsNumeric(txtDiemTrenLop.TextString) || !IsNumeric(txtPhanTramThi.TextString)
                || !IsNumeric(txtDiemThi.TextString) || !IsNumeric(txtPhanTramTrenLop.TextString))
            {
                MessageBox.Show("Nhập số!", "Thông báo");
            }
            else
            {
                SinhVien_DTO sinhvien = SinhVien_BUS.TimSinhVienTheoTenSV(cboTenSinhVien.Texts);
                if (sinhvien!=null)
                {
                    MonHoc_DTO monhoc = MonHoc_BUS.TimMonHocTheoTenMonHoc(cboTenMonHoc.Texts);
                    if (monhoc != null)
                    {
                        bool kq = Diem_BUS.KiemTraDiem(sinhvien.MaSinhVien, monhoc.MaMonHoc);
                        if (kq == false)
                        {
                            Diem_DTO diem = new Diem_DTO();
                            diem.MaMonHoc = monhoc.MaMonHoc;
                            diem.MaSinhVien = sinhvien.MaSinhVien;
                            diem.PhanTramTrenLop = int.Parse(txtPhanTramTrenLop.TextString);
                            diem.PhanTramThi = int.Parse(txtPhanTramThi.TextString);
                            diem.DiemTrenLop = float.Parse(txtDiemTrenLop.TextString);
                            diem.DiemThi = float.Parse(txtDiemThi.TextString);
                            diem.DiemTB = TinhDiem(int.Parse(txtPhanTramTrenLop.TextString), int.Parse(txtPhanTramThi.TextString),
                                 float.Parse(txtDiemTrenLop.TextString), float.Parse(txtDiemThi.TextString));
                            diem.Loai = XepLoai(TinhDiem(int.Parse(txtPhanTramTrenLop.TextString), int.Parse(txtPhanTramThi.TextString),
                                 float.Parse(txtDiemTrenLop.TextString), float.Parse(txtDiemThi.TextString)));
                            bool ketQua = Diem_BUS.ThemDiem(diem);

                            if (ketQua)
                            {
                                MessageBox.Show("Thêm Điểm thành công", "Thông báo");
                                loadDataGridView();
                            }
                            else
                            {
                                MessageBox.Show("Thêm Điểm không thành công", "Thông báo");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Sinh Viên đã có điểm môn này", "Thông báo");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Không có môn học tồn tại","Thông báo!");
                    }
                }
                else
                {
                    MessageBox.Show("Sinh viên không tồn tại", "Thông báo");
                }
            }
        }
        private static float TinhDiem(int phanTramTrenLop, int phanTramThi, float diemtrenlop, float diemthi)
        {
            // Tính điểm từ phần trăm trên lớp và trong kỳ
            float diem = (phanTramTrenLop * 0.1f*diemtrenlop + phanTramThi * 0.1f*diemthi)/10.0f;
            return diem;
            
        }

        private static string XepLoai(float diemtb)
        {
            // Xác định loại điểm
            string loai = "";
            if (diemtb >= 9)
            {
                loai = "A+";
            }
            else if (diemtb >= 8)
            {
                loai = "A";
            }
            else if (diemtb >= 7)
            {
                loai = "B+";
            }
            else if (diemtb >= 6)
            {
                loai = "B";
            }
            else if (diemtb >= 5)
            {
                loai = "C";
            }
            else if (diemtb >= 4)
            {
                loai = "D+";
            }
            else if (diemtb >= 3)
            {
                loai = "D";
            }
            else
            {
                loai = "F";
            }

            // Trả về loại điểm
            return loai;
        }


       

        public bool IsNumeric(string input)
        {
            // Biểu thức chính quy kiểm tra chuỗi chỉ chứa các ký tự số từ 0 đến 9
            Regex regex = new Regex(@"^\d+$");

            // So sánh chuỗi với biểu thức chính quy
            return regex.IsMatch(input);
        }

        private void btnCapNhatDiem_Click(object sender, EventArgs e)
        {
            if (cboTenMonHoc.Texts.Equals("") || cboTenSinhVien.Texts.Equals("")
              || txtDiemThi.TextString.Equals("") || txtDiemTrenLop.TextString.Equals("") ||
              txtPhanTramThi.TextString.Equals("") || txtPhanTramTrenLop.TextString.Equals(""))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin sinh viên!", "Thông báo");
            }
            else if (!IsNumeric(txtDiemTrenLop.TextString) || !IsNumeric(txtDiemTrenLop.TextString)
                || !IsNumeric(txtDiemTrenLop.TextString) || !IsNumeric(txtDiemTrenLop.TextString) || !IsNumeric(txtDiemTrenLop.TextString))
            {
                MessageBox.Show("Nhập số!", "Thông báo");
            }
            else
            {
                SinhVien_DTO sinhvien = SinhVien_BUS.TimSinhVienTheoTenSV(cboTenSinhVien.Texts);
                if (sinhvien != null)
                {
                    MonHoc_DTO monhoc = MonHoc_BUS.TimMonHocTheoTenMonHoc(cboTenMonHoc.Texts);
                    if (monhoc != null)
                    {
                        bool kq = Diem_BUS.KiemTraDiem(sinhvien.MaSinhVien, monhoc.MaMonHoc);
                        if (kq == true)
                        {
                            Diem_DTO diem = Diem_BUS.TimDiemTheoMaMonHocVaMaSinhVien(monhoc.MaMonHoc,sinhvien.MaSinhVien);
                            diem.MaMonHoc = monhoc.MaMonHoc;
                            diem.MaSinhVien = sinhvien.MaSinhVien;
                            diem.PhanTramTrenLop = int.Parse(txtPhanTramTrenLop.TextString);
                            diem.PhanTramThi = int.Parse(txtPhanTramThi.TextString);
                            diem.DiemTrenLop = float.Parse(txtDiemTrenLop.TextString);
                            diem.DiemThi = float.Parse(txtDiemThi.TextString);
                            diem.DiemTB = TinhDiem(int.Parse(txtPhanTramTrenLop.TextString), int.Parse(txtPhanTramThi.TextString),
                                 float.Parse(txtDiemTrenLop.TextString), float.Parse(txtDiemThi.TextString));
                            diem.Loai = XepLoai(TinhDiem(int.Parse(txtPhanTramTrenLop.TextString), int.Parse(txtPhanTramThi.TextString),
                                 float.Parse(txtDiemTrenLop.TextString), float.Parse(txtDiemThi.TextString)));
                            bool ketQua = Diem_BUS.SuaDiem(diem);

                            if (ketQua)
                            {
                                MessageBox.Show("Cập nhật Điểm thành công", "Thông báo");
                                loadDataGridView();
                            }
                            else
                            {
                                MessageBox.Show("Cập nhật Điểm không thành công", "Thông báo");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Sinh Viên chưa có điểm môn này", "Thông báo");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Không có môn học tồn tại", "Thông báo!");
                    }
                }
                else
                {
                    MessageBox.Show("Sinh viên không tồn tại", "Thông báo");
                }
            }
        }

        private void dgvNganh_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= -1)
            {
                DataGridViewRow row = dgvDiem.Rows[e.RowIndex];
               
                SinhVien_DTO sinhvien = SinhVien_BUS.TimSinhVienMSSV(row.Cells[1].Value.ToString());
                cboTenSinhVien.Texts = sinhvien.HoVaTenSV;
                MonHoc_DTO monhoc = MonHoc_BUS.TimMonHocTheoMaMonHoc(row.Cells[2].Value.ToString().Trim());
                cboTenMonHoc.Texts = monhoc.TenMonHoc;
                txtPhanTramTrenLop.TextString = row.Cells[3].Value.ToString();
                txtPhanTramThi.TextString = row.Cells[4].Value.ToString();
                txtDiemTrenLop.TextString = row.Cells[5].Value.ToString();
                txtDiemThi.TextString = row.Cells[6].Value.ToString();
                txtDiemTrungBinh.TextString = row.Cells[7].Value.ToString();
                txtLoai.TextString = row.Cells[8].Value.ToString();
            }
        }

        private void btnXoaDiem_Click(object sender, EventArgs e)
        {
            if (cboTenMonHoc.Texts.Equals("") || cboTenSinhVien.Texts.Equals(""))
            {
                MessageBox.Show("Vui lòng chọn sinh viên và môn học cần xóa điểm!", "Thông báo");
            }
            else
            {
                SinhVien_DTO sinhvien = SinhVien_BUS.TimSinhVienTheoTenSV(cboTenSinhVien.Texts);
                if (sinhvien != null)
                {
                    MonHoc_DTO monhoc = MonHoc_BUS.TimMonHocTheoTenMonHoc(cboTenMonHoc.Texts);
                    if (monhoc != null)
                    {
                        bool kq = Diem_BUS.KiemTraDiem(sinhvien.MaSinhVien, monhoc.MaMonHoc);
                        if (kq == true)
                        {
                            Diem_DTO diem = Diem_BUS.TimDiemTheoMaMonHocVaMaSinhVien(monhoc.MaMonHoc, sinhvien.MaSinhVien);
                            
                            bool ketQua = Diem_BUS.XoaDiem(diem.MaSinhVien,diem.MaMonHoc);

                            if (ketQua)
                            {
                                MessageBox.Show("Xóa Điểm thành công", "Thông báo");
                                List<Diem_DTO> lstdiem = new List<Diem_DTO> ();
                                if(lstdiem.Count > 0 && lstdiem!=null)
                                {
                                    loadDataGridView();
                                }
                                
                            }
                            else
                            {
                                MessageBox.Show("Xóa Điểm không thành công", "Thông báo");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Sinh Viên chưa có điểm môn này", "Thông báo");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Không có môn học tồn tại", "Thông báo!");
                    }
                }
                else
                {
                    MessageBox.Show("Sinh viên không tồn tại", "Thông báo");
                }
            }
        }

    }
}
