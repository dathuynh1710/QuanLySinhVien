using DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class MonHoc_DAO
    {
        static SqlConnection conn;

        public static List<MonHoc_DTO> LayListMonHoc()
        {
            string sTruyVan = "select * from MonHoc where TrangThai = 1";
            conn = DataProvider.MoKetNoi();
            DataTable dt = DataProvider.TruyVanLayDuLieu(sTruyVan, conn);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            List<MonHoc_DTO> lstMonHoc = new List<MonHoc_DTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                MonHoc_DTO monhoc = new MonHoc_DTO();
                monhoc.Id = int.Parse(dt.Rows[i]["Id"].ToString());
                monhoc.MaMonHoc = dt.Rows[i]["MaMonHoc"].ToString();
                monhoc.TenMonHoc = dt.Rows[i]["TenMonHoc"].ToString();
                monhoc.SoTinChi = int.Parse(dt.Rows[i]["SoTinChi"].ToString());
                monhoc.TietLyThuyet = int.Parse(dt.Rows[i]["TietLyThuyet"].ToString());
                monhoc.TietThucHanh = int.Parse(dt.Rows[i]["TietThucHanh"].ToString());
                monhoc.TrangThai = int.Parse(dt.Rows[i]["TrangThai"].ToString());
                lstMonHoc.Add(monhoc);
            }
            DataProvider.DongKetNoi(conn);
            return lstMonHoc;
        }

        public static List<MonHoc_DTO> LayListMonHocKhongConDay()
        {
            string sTruyVan = "select * from MonHoc where TrangThai = 0";
            conn = DataProvider.MoKetNoi();
            DataTable dt = DataProvider.TruyVanLayDuLieu(sTruyVan, conn);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            List<MonHoc_DTO> lstMonHoc = new List<MonHoc_DTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                MonHoc_DTO monhoc = new MonHoc_DTO();
                monhoc.Id = int.Parse(dt.Rows[i]["Id"].ToString());
                monhoc.MaMonHoc = dt.Rows[i]["MaMonHoc"].ToString();
                monhoc.TenMonHoc = dt.Rows[i]["TenMonHoc"].ToString();
                monhoc.SoTinChi = int.Parse(dt.Rows[i]["SoTinChi"].ToString());
                monhoc.TietLyThuyet = int.Parse(dt.Rows[i]["TietLyThuyet"].ToString());
                monhoc.TietThucHanh = int.Parse(dt.Rows[i]["TietThucHanh"].ToString());
                monhoc.TrangThai = int.Parse(dt.Rows[i]["TrangThai"].ToString());
                lstMonHoc.Add(monhoc);
            }
            DataProvider.DongKetNoi(conn);
            return lstMonHoc;
        }

        public static List<MonHoc_DTO> LayListTatCaMonHoc()
        {
            string sTruyVan = "select * from MonHoc";
            conn = DataProvider.MoKetNoi();
            DataTable dt = DataProvider.TruyVanLayDuLieu(sTruyVan, conn);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            List<MonHoc_DTO> lstMonHoc = new List<MonHoc_DTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                MonHoc_DTO monhoc = new MonHoc_DTO();
                monhoc.Id = int.Parse(dt.Rows[i]["Id"].ToString());
                monhoc.MaMonHoc = dt.Rows[i]["MaMonHoc"].ToString();
                monhoc.TenMonHoc = dt.Rows[i]["TenMonHoc"].ToString();
                monhoc.SoTinChi = int.Parse(dt.Rows[i]["SoTinChi"].ToString());
                monhoc.TietLyThuyet = int.Parse(dt.Rows[i]["TietLyThuyet"].ToString());
                monhoc.TietThucHanh = int.Parse(dt.Rows[i]["TietThucHanh"].ToString());
                monhoc.TrangThai = int.Parse(dt.Rows[i]["TrangThai"].ToString());
                lstMonHoc.Add(monhoc);
            }
            DataProvider.DongKetNoi(conn);
            return lstMonHoc;
        }

        public static MonHoc_DTO TimMonHocTheoMaMonHoc(string maMonHoc)
        {
            string sTruyVan = string.Format(@"select * from MonHoc where MaMonHoc = '{0}'",maMonHoc);
            conn = DataProvider.MoKetNoi();
            DataTable dt = DataProvider.TruyVanLayDuLieu(sTruyVan, conn);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            MonHoc_DTO monhoc = new MonHoc_DTO();
            monhoc.Id = int.Parse(dt.Rows[0]["Id"].ToString());
            monhoc.MaMonHoc = dt.Rows[0]["MaMonHoc"].ToString();
            monhoc.TenMonHoc = dt.Rows[0]["TenMonHoc"].ToString();
            monhoc.SoTinChi = int.Parse(dt.Rows[0]["SoTinChi"].ToString());
            monhoc.TietLyThuyet = int.Parse(dt.Rows[0]["TietLyThuyet"].ToString());
            monhoc.TietThucHanh = int.Parse(dt.Rows[0]["TietThucHanh"].ToString());
            monhoc.TrangThai = int.Parse(dt.Rows[0]["TrangThai"].ToString());
            DataProvider.DongKetNoi(conn);
            return monhoc;
        }

        public static MonHoc_DTO TimMonHocTheoTenMonHoc(string tenmonhoc)
        {
            string sTruyVan = string.Format(@"select * from MonHoc where TenMonHoc like N'{0}'", tenmonhoc);
            conn = DataProvider.MoKetNoi();
            DataTable dt = DataProvider.TruyVanLayDuLieu(sTruyVan, conn);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            MonHoc_DTO monhoc = new MonHoc_DTO();
            monhoc.Id = int.Parse(dt.Rows[0]["Id"].ToString());
            monhoc.MaMonHoc = dt.Rows[0]["MaMonHoc"].ToString();
            monhoc.TenMonHoc = dt.Rows[0]["TenMonHoc"].ToString();
            monhoc.SoTinChi = int.Parse(dt.Rows[0]["SoTinChi"].ToString());
            monhoc.TietLyThuyet = int.Parse(dt.Rows[0]["TietLyThuyet"].ToString());
            monhoc.TietThucHanh = int.Parse(dt.Rows[0]["TietThucHanh"].ToString());
            monhoc.TrangThai = int.Parse(dt.Rows[0]["TrangThai"].ToString());
            DataProvider.DongKetNoi(conn);
            return monhoc;
        }

        public static bool ThemMonHoc(MonHoc_DTO monhoc)
        {
            string sTruyVan = string.Format(@"INSERT INTO MonHoc (MaMonHoc, TenMonHoc, SoTinChi, TietLyThuyet, TietThucHanh) 
VALUES ('{0}', N'{1}', {2}, {3}, {4})",monhoc.MaMonHoc,monhoc.TenMonHoc,monhoc.SoTinChi,monhoc.TietLyThuyet,monhoc.TietThucHanh);
            conn = DataProvider.MoKetNoi();
            bool kq = DataProvider.TruyVanKhongLayDuLieu(sTruyVan, conn);
            if (kq)
            {
                return true;
            }
            DataProvider.DongKetNoi(conn);
            return false;

        }
        public static bool SuaMonHoc(MonHoc_DTO monhoc)
        {
            string sTruyVan = string.Format(@"UPDATE MonHoc SET MaMonHoc='{0}', TenMonHoc= N'{1}', SoTinChi= {2}, TietLyThuyet = {3}, TietThucHanh = {4} WHERE Id = {5}",
                monhoc.MaMonHoc, monhoc.TenMonHoc, monhoc.SoTinChi, monhoc.TietLyThuyet, monhoc.TietThucHanh,monhoc.Id);
            conn = DataProvider.MoKetNoi();
            bool kq = DataProvider.TruyVanKhongLayDuLieu(sTruyVan, conn);
            if (kq)
            {
                return true;
            }
            DataProvider.DongKetNoi(conn);
            return false;

        }

        public static bool XoaMonHoc(MonHoc_DTO monhoc)
        {
            string sTruyVan = string.Format(@"UPDATE MonHoc SET TrangThai = 0 WHERE Id = {0}",monhoc.Id);
            conn = DataProvider.MoKetNoi();
            bool kq = DataProvider.TruyVanKhongLayDuLieu(sTruyVan, conn);
            if (kq)
            {
                return true;
            }
            DataProvider.DongKetNoi(conn);
            return false;

        }

        public static bool KhoiPhucMonHoc(MonHoc_DTO monhoc)
        {
            string sTruyVan = string.Format(@"UPDATE MonHoc SET TrangThai = 1 WHERE Id = {0}", monhoc.Id);
            conn = DataProvider.MoKetNoi();
            bool kq = DataProvider.TruyVanKhongLayDuLieu(sTruyVan, conn);
            if (kq)
            {
                return true;
            }
            DataProvider.DongKetNoi(conn);
            return false;

        }
        public static bool KiemTraMonHoc(string maMonHoc)
        {
            string sTruyVan = string.Format("SELECT COUNT(*) FROM MonHoc WHERE MaMonHoc = '{0}'", maMonHoc);
            conn = DataProvider.MoKetNoi();

            SqlCommand cmd = new SqlCommand(sTruyVan, conn);

            try
            {
                int count = (int)cmd.ExecuteScalar();
                return count > 0;
            }
            catch (Exception ex)
            {
                // Xử lý lỗi
                Console.WriteLine("Lỗi khi kiểm tra mã khoa: " + ex.Message);
                return false;
            }
            finally
            {
                DataProvider.DongKetNoi(conn);
            }
        }
    }
}
