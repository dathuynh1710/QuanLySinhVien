using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAO;

namespace BUS
{
    public class SinhVien_BUS
    {
        public static List<SinhVien_DTO> LayListSinhVien()
        {
            return SinhVien_DAO.LayListSinhVien();
        }

        public static List<SinhVien_DTO> DanhSachSinhVienConHoc()
        {
            return SinhVien_DAO.DanhSachSinhVienConHoc();
        }

        public static List<SinhVien_DTO> DanhSachSinhVienDaNghiHoc()
        {
            return SinhVien_DAO.DanhSachSinhVienDaNghiHoc();
        }

        public static List<SinhVien_DTO> TimSinhVienTheoMSSV(string mssv)
        {
            return SinhVien_DAO.TimSinhVienTheoMSSV(mssv);
        }

        public static SinhVien_DTO TimSinhVienMSSV(string mssv)
        {
            return SinhVien_DAO.TimSinhVienMSSV(mssv);
        }

        public static SinhVien_DTO TimSinhVienTheoID(int id)
        {
            return SinhVien_DAO.TimSinhVienTheoID(id);
        }

        public static bool ThemSinhVien(SinhVien_DTO sv)
        {
            return SinhVien_DAO.ThemSinhVien(sv);
        }

        public static bool SuaSinhVien(SinhVien_DTO sv)
        {
            return SinhVien_DAO.SuaSinhVien(sv);
        }

        public static bool XoaSinhVien(int id)
        {
            return SinhVien_DAO.XoaSinhVien(id);
        }

        public static List<SinhVien_DTO> LaySinhVienTheoLop(string maLop)
        {
            return SinhVien_DAO.LaySinhVienTheoLop(maLop);
        }

        public static bool KiemTraMSSV(string mssv)
        {
            return SinhVien_DAO.KiemTraMSSV(mssv);
        }

        public static SinhVien_DTO TimSinhVienTheoTenSV(string hoten)
        {
            return SinhVien_DAO.TimSinhVienTheoTenSV(hoten);
        }
    }
}
