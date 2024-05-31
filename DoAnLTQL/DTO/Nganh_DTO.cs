using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Nganh_DTO
    {

        private int id;
        private string maNganh;
        private string tenNganh;
        private string maKhoa;
        private int trangThai;

        public Nganh_DTO()
        {
        }

        public Nganh_DTO(int id, string maNganh, string tenNganh, string maKhoa, int trangThai)
        {
            this.Id = id;
            this.MaNganh = maNganh;
            this.TenNganh = tenNganh;
            this.MaKhoa = maKhoa;
            this.TrangThai = trangThai;
        }

        public int Id { get => id; set => id = value; }
        public string MaNganh { get => maNganh; set => maNganh = value; }
        public string TenNganh { get => tenNganh; set => tenNganh = value; }
        public string MaKhoa { get => maKhoa; set => maKhoa = value; }
        public int TrangThai { get => trangThai; set => trangThai = value; }
    }
}
