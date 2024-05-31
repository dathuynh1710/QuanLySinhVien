using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Lop_DTO
    {
        private int id;
        private string maLop;
        private string tenLop;
        private int soLuong;
        private string maCVHT;
        private string maNganh;
        private int trangThai;

        public Lop_DTO()
        {
        }

        public Lop_DTO(int id, string maLop, string tenLop, int soLuong, string maCVHT, string maNganh, int trangThai)
        {
            this.Id = id;
            this.MaLop = maLop;
            this.TenLop = tenLop;
            this.SoLuong = soLuong;
            this.MaCVHT = maCVHT;
            this.MaNganh = maNganh;
            this.TrangThai = trangThai;
        }

        public int Id { get => id; set => id = value; }
        public string MaLop { get => maLop; set => maLop = value; }
        public string TenLop { get => tenLop; set => tenLop = value; }
        public int SoLuong { get => soLuong; set => soLuong = value; }
        public string MaCVHT { get => maCVHT; set => maCVHT = value; }
        public string MaNganh { get => maNganh; set => maNganh = value; }
        public int TrangThai { get => trangThai; set => trangThai = value; }
    }
}
