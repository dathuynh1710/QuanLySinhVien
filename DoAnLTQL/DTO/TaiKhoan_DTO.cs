using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class TaiKhoan_DTO
    {
        private int id;
        private string tenDangNhap;
        private string matKhau;
        private string loaiTaiKhoan;
        private int trangThai;

        public TaiKhoan_DTO()
        {
        }

        public TaiKhoan_DTO(int id, string tenDangNhap, string matKhau, string loaiTaiKhoan, int trangThai)
        {
            this.Id = id;
            this.TenDangNhap = tenDangNhap;
            this.MatKhau = matKhau;
            this.LoaiTaiKhoan = loaiTaiKhoan;
            this.TrangThai = trangThai;
        }

        public int Id { get => id; set => id = value; }
        public string TenDangNhap { get => tenDangNhap; set => tenDangNhap = value; }
        public string MatKhau { get => matKhau; set => matKhau = value; }
        public string LoaiTaiKhoan { get => loaiTaiKhoan; set => loaiTaiKhoan = value; }
        public int TrangThai { get => trangThai; set => trangThai = value; }
    }
}
