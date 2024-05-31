using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class Diem_BUS
    {
        public static List<Diem_DTO> LayListDiemSinhVienConHocVaConMonHoc()
        {
            return Diem_DAO.LayListDiemSinhVienConHocVaConMonHoc();
        }

        public static Diem_DTO TimDiemTheoMaMonHoc(string maMonHoc)
        {
            return Diem_DAO.TimDiemTheoMaMonHoc(maMonHoc);
        }

        public static bool ThemDiem(Diem_DTO diem)
        {
            return Diem_DAO.ThemDiem(diem);
        }
        public static bool SuaDiem(Diem_DTO diem)
        {
            return Diem_DAO.SuaDiem(diem);
        }

        public static bool KiemTraDiem(string maSinhVien, string maMonHoc)
        {
            return Diem_DAO.KiemTraDiem(maSinhVien,maMonHoc);
        }

        public static Diem_DTO TimDiemTheoMaMonHocVaMaSinhVien(string maMonHoc, string maSinhVien)
        {
            return Diem_DAO.TimDiemTheoMaMonHocVaMaSinhVien(maMonHoc, maSinhVien);
        }

        public static bool XoaDiem(string maSinhVien, string maMonHoc)
        {
            return Diem_DAO.XoaDiem(maSinhVien, maMonHoc);
        }
    }
}
