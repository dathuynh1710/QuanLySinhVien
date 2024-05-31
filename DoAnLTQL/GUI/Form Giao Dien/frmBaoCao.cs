using BUS;
using DTO;
using Microsoft.Reporting.WinForms;
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
    public partial class frmBaoCao : Form
    {
        public frmBaoCao()
        {
            InitializeComponent();
        }

        private void frmBaoCao_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
        }

        private void btnSaoLuu_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog saoluuFolder = new FolderBrowserDialog();
            saoluuFolder.Description = "Chọn thư mục lưu trữ";
            if (saoluuFolder.ShowDialog() == DialogResult.OK)
            {
                string sDuongDan = saoluuFolder.SelectedPath;
                if (CSDL_BUS.SaoLuuDuLieu(sDuongDan) == true)
                    MessageBox.Show("Đã sao lưu dữ liệu vào " + sDuongDan);
                else
                    MessageBox.Show("Thao tác không thành công");
            }
        }

        private void btnKhoiPhuc_Click(object sender, EventArgs e)
        {
            OpenFileDialog phuchoiFile = new OpenFileDialog();
            phuchoiFile.Filter = "*.bak|*.bak";
            phuchoiFile.Title = "Chọn tập tin phục hồi (.bak)";
            if (phuchoiFile.ShowDialog() == DialogResult.OK && phuchoiFile.CheckFileExists == true)
            {
                string sDuongDan = phuchoiFile.FileName;
                if (CSDL_BUS.KhoiPhucDuLieu(sDuongDan))
                    MessageBox.Show("Khôi phục dữ liệu thành công");
                else
                    MessageBox.Show("Thất bại");
            }
        }

        private void btnReportSinhVien_Click(object sender, EventArgs e)
        {
            int stt = 1;
            List<SinhVien_DTO> lstsv = SinhVien_BUS.DanhSachSinhVienConHoc();
            List<ReportSinhVien> lstReport = new List<ReportSinhVien>();
            foreach (SinhVien_DTO sv in lstsv)
            {
                ReportSinhVien sinhvienrpt = new ReportSinhVien();
                sinhvienrpt.STT = stt;
                sinhvienrpt.MaSinhVien = sv.MaSinhVien;
                sinhvienrpt.HoVaTenSV = sv.HoVaTenSV;
                sinhvienrpt.GioiTinh = sv.GioiTinh;
                sinhvienrpt.DiaChi = sv.DiaChi;
                sinhvienrpt.SoDienThoai = sv.SoDienThoai;
                Lop_DTO lop = Lop_BUS.TimLopTheoMaLop(sv.MaLop);
                sinhvienrpt.TenLop = lop.TenLop;
                lstReport.Add(sinhvienrpt);
                stt++;
            }
            reportViewer1.LocalReport.ReportPath = "rptSinhVien.rdlc";
            var source = new ReportDataSource("DataSet1", lstReport);
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(source);
            this.reportViewer1.RefreshReport();
        }


        private void btnReportDiem_Click(object sender, EventArgs e)
        {
            List<Diem_DTO> lstdiem = Diem_BUS.LayListDiemSinhVienConHocVaConMonHoc();
            List<ReportDiem> lstReport = new List<ReportDiem>();
            foreach (Diem_DTO diem in lstdiem)
            {
                ReportDiem diemrpt = new ReportDiem();
                diemrpt.MaSinhVien = diem.MaSinhVien;
                SinhVien_DTO tensinhvien = SinhVien_BUS.TimSinhVienMSSV(diem.MaSinhVien);
                diemrpt.HoTenSV = tensinhvien.HoVaTenSV;
                MonHoc_DTO tenmonhoc = MonHoc_BUS.TimMonHocTheoMaMonHoc(diem.MaMonHoc);
                diemrpt.TenMonHoc = tenmonhoc.TenMonHoc;
                diemrpt.PhanTramTrenLop = diem.PhanTramTrenLop;
                diemrpt.PhanTramThi = diem.PhanTramThi;
                diemrpt.DiemTrenLop = diem.DiemTrenLop;
                diemrpt.DiemThi = diem.DiemThi;
                diemrpt.DiemTB = diem.DiemTB;
                diemrpt.Loai = diem.Loai;

                lstReport.Add(diemrpt);
            }
            reportViewer1.LocalReport.ReportPath = "rptDiem.rdlc";
            var source = new ReportDataSource("DataSet1", lstReport);
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(source);
            this.reportViewer1.RefreshReport();
        }
    }
}
