using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;

namespace BUS
{
    public class MonHoc_BUS
    {
        public static List<MonHoc_DTO> LayListMonHoc()
        {
            return MonHoc_DAO.LayListMonHoc();
        }

        public static MonHoc_DTO TimMonHocTheoMaMonHoc(string maMonHoc)
        {
            return MonHoc_DAO.TimMonHocTheoMaMonHoc(maMonHoc);
        }

        public static bool ThemMonHoc(MonHoc_DTO monhoc)
        {
            return MonHoc_DAO.ThemMonHoc(monhoc);
        }

        public static bool SuaMonHoc(MonHoc_DTO monhoc)
        {
            return MonHoc_DAO.SuaMonHoc(monhoc);
        }

        public static bool XoaMonHoc(MonHoc_DTO monhoc)
        {
            return MonHoc_DAO.XoaMonHoc(monhoc);
        }

        public static bool KiemTraMonHoc(string maMonHoc)
        {
            return MonHoc_DAO.KiemTraMonHoc(maMonHoc);
        }

        public static MonHoc_DTO TimMonHocTheoTenMonHoc(string tenmonhoc)
        {
            return MonHoc_DAO.TimMonHocTheoTenMonHoc(tenmonhoc);
        }

        public static List<MonHoc_DTO> LayListMonHocKhongConDay()
        {
            return MonHoc_DAO.LayListMonHocKhongConDay();
        }
        public static List<MonHoc_DTO> LayListTatCaMonHoc()
        {
            return MonHoc_DAO.LayListTatCaMonHoc();
        }

        public static bool KhoiPhucMonHoc(MonHoc_DTO monhoc)
        {
            return MonHoc_DAO.KhoiPhucMonHoc(monhoc);
        }

    }
}
