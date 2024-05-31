using DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace BUS
{
    public class TaiKhoan_BUS
    {
        public static bool KiemTraDangNhap(string tenDangNhap, string matKhau)
        {
            return TaiKhoan_DAO.KiemTraDangNhap(tenDangNhap, matKhau);
        }

        public static List<TaiKhoan_DTO> LayListTaiKhoan()
        {
            return TaiKhoan_DAO.LayListTaiKhoan();
        }

        public static TaiKhoan_DTO LayLoaiTaiKhoan(string tendangnhap)
        {
            return TaiKhoan_DAO.LayLoaiTaiKhoan(tendangnhap);
        }

        public static bool ThemTaiKhoan(TaiKhoan_DTO tk)
        {
            return TaiKhoan_DAO.ThemTaiKhoan(tk);
        }

        public static bool CapNhatTaiKhoan(TaiKhoan_DTO tk)
        {
            return TaiKhoan_DAO.CapNhatTaiKhoan(tk);
        }

        public static bool XoaTaiKhoan(TaiKhoan_DTO tk)
        {
            return TaiKhoan_DAO.XoaTaiKhoan(tk);
        }

        public static bool KiemTraTen(string tendangnhap)
        {
            return TaiKhoan_DAO.KiemTraTen(tendangnhap);
        }
    }
}
