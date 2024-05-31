using System;

namespace DTO
{
    public class CVHT_DTO
    {
        private int id;
        private string maCVHT;
        private string tenCVHT;
        private DateTime ngaySinh; // Thay đổi kiểu dữ liệu từ string sang DateTime
        private string gioiTinh;
        private int trangThai;

        public CVHT_DTO()
        {
        }

        public CVHT_DTO(int id, string maCVHT, string tenCVHT, DateTime ngaySinh, string gioiTinh, int trangThai)
        {
            this.Id = id;
            this.MaCVHT = maCVHT;
            this.TenCVHT = tenCVHT;
            this.NgaySinh = ngaySinh;
            this.GioiTinh = gioiTinh;
            this.TrangThai = trangThai;
        }

        public int Id { get => id; set => id = value; }
        public string MaCVHT { get => maCVHT; set => maCVHT = value; }
        public string TenCVHT { get => tenCVHT; set => tenCVHT = value; }
        public DateTime NgaySinh { get => ngaySinh; set => ngaySinh = value; } // Thay đổi kiểu dữ liệu từ string sang DateTime
        public string GioiTinh { get => gioiTinh; set => gioiTinh = value; }
        public int TrangThai { get => trangThai; set => trangThai = value; }
    }
}
