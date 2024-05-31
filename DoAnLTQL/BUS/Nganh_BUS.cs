using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class Nganh_BUS
    {
        public static List<Nganh_DTO> LayListNganh()
        {
            return Nganh_DAO.LayListNganh();
        }

        public static Nganh_DTO TimNganhCuaSV(string maNganh)
        {
            return Nganh_DAO.TimNganhCuaSV(maNganh);
        }

        public static bool KiemTraNganh(string maNganh)
        {
            return Nganh_DAO.KiemTraNganh(maNganh);
        }


        public static bool ThemNganh(Nganh_DTO nganh)
        {
            return Nganh_DAO.ThemNganh(nganh);
        }
        public static bool CapNhatNganh(Nganh_DTO nganh)
        {
            return Nganh_DAO.CapNhatNganh(nganh);
        }
        public static bool XoaNganh(Nganh_DTO nganh)
        {
            return Nganh_DAO.XoaNganh(nganh);
        }

        public static Nganh_DTO TimNganhTheoTenNganh(string tenNganh)
        {
            return Nganh_DAO.TimNganhTheoTenNganh(tenNganh);
        }
    }
}
