using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAO;

namespace BUS
{
    public class Lop_BUS
    {
        public static List<Lop_DTO> LayListLop()
        {
            return Lop_DAO.LayListLop();
        }

        public static Lop_DTO TimLopTheoMaLop(string maLop)
        {
            return Lop_DAO.TimLopTheoMaLop(maLop);
        }

        public static Lop_DTO TimLopTheoTenLop(string tenLop)
        {
            return Lop_DAO.TimLopTheoTenLop(tenLop);
        }

        public static bool CapNhatSoLuongSinhVien(Lop_DTO lop)
        {
            return Lop_DAO.CapNhatSoLuongSinhVien(lop);
        }

        public static bool ThemLop(Lop_DTO lop)
        {
            return Lop_DAO.ThemLop(lop);
        }

        public static bool SuaLop(Lop_DTO lop)
        {
            return Lop_DAO.SuaLop(lop);
        }

        public static bool Xoa(Lop_DTO lop)
        {
            return Lop_DAO.XoaLop(lop);
        }


    }
}
