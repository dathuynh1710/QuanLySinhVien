using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace DAO
{
    public class Lop_DAO
    {
        static SqlConnection conn;

        public static List<Lop_DTO> LayListLop()
        {
            string sTruyVan = "select * from Lop where TrangThai = 1";
            conn = DataProvider.MoKetNoi();
            DataTable dt = DataProvider.TruyVanLayDuLieu(sTruyVan, conn);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            List<Lop_DTO> lstLop = new List<Lop_DTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                Lop_DTO lop = new Lop_DTO();
                lop.Id = int.Parse(dt.Rows[i]["Id"].ToString());
                lop.MaLop = dt.Rows[i]["MaLop"].ToString();
                lop.TenLop = dt.Rows[i]["TenLop"].ToString();
                lop.SoLuong = int.Parse(dt.Rows[i]["SoLuong"].ToString());
                lop.MaCVHT = dt.Rows[i]["MaCVHT"].ToString();
                lop.MaNganh = dt.Rows[i]["MaNganh"].ToString();
                lop.TrangThai = int.Parse(dt.Rows[i]["TrangThai"].ToString());
                lstLop.Add(lop);
            }
            DataProvider.DongKetNoi(conn);
            return lstLop;
        }

        public static Lop_DTO TimLopTheoMaLop(string maLop)
        {
            string sTruyVan = string.Format("select * from Lop where MaLop = '{0}'", maLop);
            conn = DataProvider.MoKetNoi();
            DataTable dt = DataProvider.TruyVanLayDuLieu(sTruyVan, conn);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            Lop_DTO lop = new Lop_DTO();
            lop.Id = int.Parse(dt.Rows[0]["Id"].ToString());
            lop.MaLop = dt.Rows[0]["MaLop"].ToString();
            lop.TenLop = dt.Rows[0]["TenLop"].ToString();
            lop.SoLuong = int.Parse(dt.Rows[0]["SoLuong"].ToString());
            lop.MaCVHT = dt.Rows[0]["MaCVHT"].ToString();
            lop.MaNganh = dt.Rows[0]["MaNganh"].ToString();
            lop.TrangThai = int.Parse(dt.Rows[0]["TrangThai"].ToString());
            DataProvider.DongKetNoi(conn);
            return lop;
        }

        public static Lop_DTO TimLopTheoTenLop(string tenLop)
        {
            string sTruyVan = string.Format("select * from Lop where TenLop like '{0}'", tenLop);
            conn = DataProvider.MoKetNoi();
            DataTable dt = DataProvider.TruyVanLayDuLieu(sTruyVan, conn);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            Lop_DTO lop = new Lop_DTO();
            lop.Id = int.Parse(dt.Rows[0]["Id"].ToString());
            lop.MaLop = dt.Rows[0]["MaLop"].ToString();
            lop.TenLop = dt.Rows[0]["TenLop"].ToString();
            lop.SoLuong = int.Parse(dt.Rows[0]["SoLuong"].ToString());
            lop.MaCVHT = dt.Rows[0]["MaCVHT"].ToString();
            lop.MaNganh = dt.Rows[0]["MaNganh"].ToString();
            lop.TrangThai = int.Parse(dt.Rows[0]["TrangThai"].ToString());
            DataProvider.DongKetNoi(conn);
            return lop;
        }

        public static bool CapNhatSoLuongSinhVien(Lop_DTO lop)
        {
            int soLuong = lop.SoLuong;
            string struyvan = string.Format(@"UPDATE Lop SET SoLuong = {0} WHERE Id = {1}", soLuong, lop.Id);
            conn = DataProvider.MoKetNoi();
            bool kq = DataProvider.TruyVanKhongLayDuLieu(struyvan, conn);
            if (kq)
            {
                return true;
            }
            DataProvider.DongKetNoi(conn);
            return false;
        }

        public static bool ThemLop(Lop_DTO lop)
        {
            string sTruyVan = string.Format(@"INSERT INTO Lop (MaLop, TenLop, SoLuong, MaCVHT, MaNganh) 
VALUES ('{0}', N'{1}', {2}, '{3}', '{4}')", lop.MaLop, lop.TenLop, lop.SoLuong, lop.MaCVHT, lop.MaNganh);

            conn = DataProvider.MoKetNoi();
            bool kq = DataProvider.TruyVanKhongLayDuLieu(sTruyVan, conn);
            if (kq)
            {
                return true;
            }
            DataProvider.DongKetNoi(conn);
            return false;

        }
        public static bool SuaLop(Lop_DTO lop)
        {
            string sTruyVan = string.Format(@"UPDATE Lop SET MaLop='{0}', TenLop= N'{1}', SoLuong= {2}, MaCVHT = '{3}', MaNganh = '{4}' WHERE Id = {6}",
                lop.MaLop, lop.TenLop, lop.SoLuong, lop.MaCVHT, lop.MaNganh, lop.TrangThai, lop.Id);
            conn = DataProvider.MoKetNoi();
            bool kq = DataProvider.TruyVanKhongLayDuLieu(sTruyVan, conn);
            if (kq)
            {
                return true;
            }
            DataProvider.DongKetNoi(conn);
            return false;

        }

        public static bool XoaLop(Lop_DTO lop)
        {
            string sTruyVan = string.Format(@"UPDATE Lop SET TrangThai = 0 WHERE Id = {0}", lop.Id);
            conn = DataProvider.MoKetNoi();
            bool kq = DataProvider.TruyVanKhongLayDuLieu(sTruyVan, conn);
            if (kq)
            {
                return true;
            }
            DataProvider.DongKetNoi(conn);
            return false;

        }
        public static bool KiemTraLop(string malop)
        {
            string sTruyVan = string.Format("SELECT COUNT(*) FROM Lop WHERE MaLop = '{0}'", malop);
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
