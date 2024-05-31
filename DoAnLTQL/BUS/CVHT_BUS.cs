using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAO;

namespace BUS
{
    public class CVHT_BUS
    {
        public static List<CVHT_DTO> LayListCVHT()
        {
            return CVHT_DAO.LayListCVHT();
        }

        public static CVHT_DTO TimCVHTCuaSV(string maCVHT)
        {
            return CVHT_DAO.TimCVHTCuaSV(maCVHT);
        }

        public static CVHT_DTO TimCVHTTheoTenCVHT(string tenCVHT)
        {
            return CVHT_DAO.TimCVHTTheoTenCVHT(tenCVHT);
        }

        public static bool ThemCVHT(CVHT_DTO cvht)
        {
            return CVHT_DAO.ThemCVHT(cvht);
        }

        public static bool CapNhatCVHT(CVHT_DTO cvht)
        {
            return CVHT_DAO.CapNhatCVHT(cvht);
        }

        public static bool XoaCVHT(string maCVHT)
        {
            return CVHT_DAO.XoaCVHT(maCVHT);
        }

        public static CVHT_DTO TimCVHTTheoMaCVHT(string maCVHT)
        {
            return CVHT_DAO.TimCVHTTheoMaCVHT(maCVHT);
        }
    }
}
