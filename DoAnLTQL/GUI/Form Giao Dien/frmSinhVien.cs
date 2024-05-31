using BUS;
using DTO;
using GUI.Form_Giao_Dien;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class frmSinhVien : Form
    {
        public frmSinhVien()
        {
            InitializeComponent();
        }

        private void frmSinhVien_Load(object sender, EventArgs e)
        {
            List<SinhVien_DTO> lstSinhVien = SinhVien_BUS.DanhSachSinhVienConHoc();
            flowSinhVien.Controls.Clear();
            foreach(SinhVien_DTO sv in lstSinhVien)
            {
                viewSV viewSV = new viewSV(sv);
                viewSV.ClickEvent += ViewSV_ClickEvent; // Gán sự kiện click
                flowSinhVien.Controls.Add(viewSV);
            }
            loadComboBoxHienSinhVien();
            loadComboBoxHienLop();
        }

        private string chonLop= "---Chọn lớp---";

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

        private void ViewSV_ClickEvent(object sender, EventArgs e)
        {
            // Xử lý sự kiện click cho user control được click
            // Ví dụ: Hiển thị thông tin chi tiết của sinh viên
            viewSV clickedControl = sender as viewSV;
            if (clickedControl != null)
            {
                SinhVien_DTO sv = clickedControl.GetSinhVien();
                // Xử lý hiển thị thông tin sinh viên
                //MessageBox.Show(sinhVien.TenSinhVien);
                (this.ParentForm as frmMain)?.ThongTinSinhVienShow(sv);
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
            if (txtTimSinhVien.TextString.Equals(hintText)==true)
            {
                txtTimSinhVien.TextString = "";
                txtTimSinhVien.ForeColor = SystemColors.WindowText;
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
                    flowSinhVien.Controls.Clear();
                    foreach (SinhVien_DTO sv in lstSinhVien)
                    {
                        viewSV viewSV = new viewSV(sv);
                        flowSinhVien.Controls.Add(viewSV);
                    }
                }

            }
        }

        private void cboHienSinhVien_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            if(cboHienSinhVien.Texts.Equals("Tất cả"))
            {
                List<SinhVien_DTO> lstSinhVien = SinhVien_BUS.LayListSinhVien();
                flowSinhVien.Controls.Clear();
                if (lstSinhVien != null)
                {
                    foreach (SinhVien_DTO sv in lstSinhVien)
                    {
                        viewSV viewSV = new viewSV(sv);
                        viewSV.ClickEvent += ViewSV_ClickEvent;
                        flowSinhVien.Controls.Add(viewSV);
                    }
                }
            }
            else if(cboHienSinhVien.Texts.Equals("Còn học"))
            {
                List<SinhVien_DTO> lstSinhVien = SinhVien_BUS.DanhSachSinhVienConHoc();
                flowSinhVien.Controls.Clear();
                if (lstSinhVien != null)
                {
                    foreach (SinhVien_DTO sv in lstSinhVien)
                    {
                        viewSV viewSV = new viewSV(sv);
                        viewSV.ClickEvent += ViewSV_ClickEvent; 
                        flowSinhVien.Controls.Add(viewSV);
                    }
                }
            }
            else if (cboHienSinhVien.Texts.Equals("Đã nghỉ học"))
            {
                List<SinhVien_DTO> lstSinhVien = SinhVien_BUS.DanhSachSinhVienDaNghiHoc();
                flowSinhVien.Controls.Clear();
                if (lstSinhVien!=null)
                {
                    foreach (SinhVien_DTO sv in lstSinhVien)
                    {
                        viewSV viewSV = new viewSV(sv);
                        viewSV.ClickEvent += ViewSV_ClickEvent;
                        flowSinhVien.Controls.Add(viewSV);
                    }
                }
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

        private void cboLop_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboChonLop.Texts.Equals(chonLop))
            {
                List<SinhVien_DTO> lstSinhVien = SinhVien_BUS.LayListSinhVien();
                flowSinhVien.Controls.Clear();
                if (lstSinhVien != null)
                {
                    foreach (SinhVien_DTO sv in lstSinhVien)
                    {
                        viewSV viewSV = new viewSV(sv);
                        viewSV.ClickEvent += ViewSV_ClickEvent; 
                        flowSinhVien.Controls.Add(viewSV);
                    }
                }
            }
            else
            {
                List<SinhVien_DTO> lstSinhVien = SinhVien_BUS.LaySinhVienTheoLop(cboChonLop.Texts);
                flowSinhVien.Controls.Clear();
                if (lstSinhVien != null)
                {
                    foreach (SinhVien_DTO sv in lstSinhVien)
                    {
                        viewSV viewSV = new viewSV(sv);
                        viewSV.ClickEvent += ViewSV_ClickEvent; 
                        flowSinhVien.Controls.Add(viewSV);
                    }
                }
            }
        }

        private void btnDoiKieu_Click(object sender, EventArgs e)
        {
            frmDataSinhVien frmDataSinhVien = new frmDataSinhVien();
            foreach (Form form in Application.OpenForms)
            {
                if (form is frmMain)
                {
                    ((frmMain)form).OpenChildForm(frmDataSinhVien);
                    break;
                }
            }
        }
    }
}
