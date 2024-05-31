using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class SinhVien_DTO
    {
        private int id;
        private string maSinhVien;
        private string hoVaTenSV;
        private string gioiTinh;
        private string ngaySinh;
        private string diaChi;
        private string soDienThoai;
        private string ngayNhapHoc;
        private string maLop;
        private int trangThai;

        public SinhVien_DTO()
        {
        }

        public SinhVien_DTO(int id, string maSinhVien, string hoVaTenSV, string gioiTinh, string ngaySinh, string diaChi, string soDienThoai, string ngayNhapHoc, string maLop, int trangThai)
        {
            this.Id = id;
            this.MaSinhVien = maSinhVien;
            this.HoVaTenSV = hoVaTenSV;
            this.GioiTinh = gioiTinh;
            this.NgaySinh = ngaySinh;
            this.DiaChi = diaChi;
            this.SoDienThoai = soDienThoai;
            this.NgayNhapHoc = ngayNhapHoc;
            this.MaLop = maLop;
            this.TrangThai = trangThai;
        }

        public int Id { get => id; set => id = value; }
        public string MaSinhVien { get => maSinhVien; set => maSinhVien = value; }
        public string HoVaTenSV { get => hoVaTenSV; set => hoVaTenSV = value; }
        public string GioiTinh { get => gioiTinh; set => gioiTinh = value; }
        public string NgaySinh { get => ngaySinh; set => ngaySinh = value; }
        public string DiaChi { get => diaChi; set => diaChi = value; }
        public string SoDienThoai { get => soDienThoai; set => soDienThoai = value; }
        public string NgayNhapHoc { get => ngayNhapHoc; set => ngayNhapHoc = value; }
        public string MaLop { get => maLop; set => maLop = value; }
        public int TrangThai { get => trangThai; set => trangThai = value; }
    }
}
