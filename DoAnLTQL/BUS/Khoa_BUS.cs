using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;

namespace BUS
{
    public class Khoa_BUS
    {
        public static List<Khoa_DTO> LayListKhoa()
        {
            return Khoa_DAO.LayListKhoa();
        }
        public static Khoa_DTO TimKhoaCuaSV(string maKhoa)
        {
            return Khoa_DAO.TimKhoaCuaSV(maKhoa);
        }

        public static Khoa_DTO TimKhoaCuaNganhTheoTenKhoa(string tenKhoa)
        {
            return Khoa_DAO.TimKhoaCuaNganhTheoTenKhoa(tenKhoa);
        }

        public static bool KiemTraKhoa(string maKhoa)
        {
            return Khoa_DAO.KiemTraKhoa(maKhoa);
        }

        public static bool ThemKhoa(Khoa_DTO khoa)
        {
            return Khoa_DAO.ThemKhoa(khoa);
        }

        public static bool CapNhatKhoa(Khoa_DTO khoa)
        {
            return Khoa_DAO.CapNhatKhoa(khoa);
        }

        public static bool XoaKhoa(Khoa_DTO khoa)
        {
           return Khoa_DAO.XoaKhoa(khoa);
        }

    }
}
