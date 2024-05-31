using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Khoa_DTO
    {
        private int id;
        private string maKhoa;
        private string tenKhoa;
        private int trangThai;


        public Khoa_DTO()
        {
        }

        public Khoa_DTO(int id, string maKhoa, string tenKhoa, int trangThai)
        {
            this.Id = id;
            this.MaKhoa = maKhoa;
            this.TenKhoa = tenKhoa;
            this.TrangThai = trangThai;
        }

        public int Id { get => id; set => id = value; }
        public string MaKhoa { get => maKhoa; set => maKhoa = value; }
        public string TenKhoa { get => tenKhoa; set => tenKhoa = value; }
        public int TrangThai { get => trangThai; set => trangThai = value; }
    }
}
