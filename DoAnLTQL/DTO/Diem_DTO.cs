using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Diem_DTO
    {
        private int id;
        private string maSinhVien;
        private string maMonHoc;
        private int phanTramTrenLop;
        private int phanTramThi;
        private float diemTrenLop;
        private float diemThi;
        private float diemTB;
        private string loai;

        public Diem_DTO()
        {

        }

        public Diem_DTO(int id, string maSinhVien, string maMonHoc, int phanTramTrenLop, int phanTramThi, float diemTrenLop, float diemThi, float diemTB, string loai)
        {
            this.Id = id;
            this.MaSinhVien = maSinhVien;
            this.MaMonHoc = maMonHoc;
            this.PhanTramTrenLop = phanTramTrenLop;
            this.PhanTramThi = phanTramThi;
            this.DiemTrenLop = diemTrenLop;
            this.DiemThi = diemThi;
            this.DiemTB = diemTB;
            this.Loai = loai;
        }

        public int Id { get => id; set => id = value; }
        public string MaSinhVien { get => maSinhVien; set => maSinhVien = value; }
        public string MaMonHoc { get => maMonHoc; set => maMonHoc = value; }
        public int PhanTramTrenLop { get => phanTramTrenLop; set => phanTramTrenLop = value; }
        public int PhanTramThi { get => phanTramThi; set => phanTramThi = value; }
        public float DiemTrenLop { get => diemTrenLop; set => diemTrenLop = value; }
        public float DiemThi { get => diemThi; set => diemThi = value; }
        public float DiemTB { get => diemTB; set => diemTB = value; }
        public string Loai { get => loai; set => loai = value; }
    }
}
