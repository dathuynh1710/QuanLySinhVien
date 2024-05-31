using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class MonHoc_DTO
    {
		private int id;
		private string maMonHoc;
		private string tenMonHoc;
		private int soTinChi;
		private int tietLyThuyet;
		private int tietThucHanh;
        private int trangThai;

        public MonHoc_DTO()
        {
        }

        public MonHoc_DTO(int id, string maMonHoc, string tenMonHoc, int soTinChi, int tietLyThuyet, int tietThucHanh, int trangThai)
        {
            this.Id = id;
            this.MaMonHoc = maMonHoc;
            this.TenMonHoc = tenMonHoc;
            this.SoTinChi = soTinChi;
            this.TietLyThuyet = tietLyThuyet;
            this.TietThucHanh = tietThucHanh;
            this.TrangThai = trangThai;
        }

        public int Id { get => id; set => id = value; }
        public string MaMonHoc { get => maMonHoc; set => maMonHoc = value; }
        public string TenMonHoc { get => tenMonHoc; set => tenMonHoc = value; }
        public int SoTinChi { get => soTinChi; set => soTinChi = value; }
        public int TietLyThuyet { get => tietLyThuyet; set => tietLyThuyet = value; }
        public int TietThucHanh { get => tietThucHanh; set => tietThucHanh = value; }
        public int TrangThai { get => trangThai; set => trangThai = value; }
    }
}
