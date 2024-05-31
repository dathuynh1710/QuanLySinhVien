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
    public class Nganh_DAO
    {
        static SqlConnection conn;

        public static List<Nganh_DTO> LayListNganh()
        {
            string sTruyVan = "select * from Nganh where TrangThai = 1";
            conn = DataProvider.MoKetNoi();
            DataTable dt = DataProvider.TruyVanLayDuLieu(sTruyVan, conn);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            List<Nganh_DTO> lstNganh = new List<Nganh_DTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                Nganh_DTO nganh = new Nganh_DTO();
                nganh.Id = int.Parse(dt.Rows[i]["Id"].ToString());
                nganh.MaNganh = dt.Rows[i]["MaNganh"].ToString();
                nganh.TenNganh = dt.Rows[i]["TenNganh"].ToString();
                nganh.MaKhoa = dt.Rows[i]["MaKhoa"].ToString();
                nganh.TrangThai = int.Parse(dt.Rows[i]["TrangThai"].ToString());
                lstNganh.Add(nganh);
            }
            DataProvider.DongKetNoi(conn);
            return lstNganh;
        }

        public static Nganh_DTO TimNganhCuaSV(string maNganh)
        {
            string sTruyVan = string.Format("select * from Nganh where MaNganh = '{0}'", maNganh);
            conn = DataProvider.MoKetNoi();
            DataTable dt = DataProvider.TruyVanLayDuLieu(sTruyVan, conn);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            Nganh_DTO nganh = new Nganh_DTO();
            nganh.Id = int.Parse(dt.Rows[0]["Id"].ToString());
            nganh.MaNganh = dt.Rows[0]["MaNganh"].ToString();
            nganh.TenNganh = dt.Rows[0]["TenNganh"].ToString();
            nganh.MaKhoa = dt.Rows[0]["MaKhoa"].ToString();
            nganh.TrangThai = int.Parse(dt.Rows[0]["TrangThai"].ToString());
            DataProvider.DongKetNoi(conn);
            return nganh;
        }

        public static Nganh_DTO TimNganhTheoTenNganh(string tenNganh)
        {
            string sTruyVan = string.Format("select * from Nganh where TenNganh = N'{0}'", tenNganh);
            conn = DataProvider.MoKetNoi();
            DataTable dt = DataProvider.TruyVanLayDuLieu(sTruyVan, conn);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            Nganh_DTO nganh = new Nganh_DTO();
            nganh.Id = int.Parse(dt.Rows[0]["Id"].ToString());
            nganh.MaNganh = dt.Rows[0]["MaNganh"].ToString();
            nganh.TenNganh = dt.Rows[0]["TenNganh"].ToString();
            nganh.MaKhoa = dt.Rows[0]["MaKhoa"].ToString();
            nganh.TrangThai = int.Parse(dt.Rows[0]["TrangThai"].ToString());
            DataProvider.DongKetNoi(conn);
            return nganh;
        }

        public static bool KiemTraNganh(string maNganh)
        {
            string sTruyVan = string.Format("SELECT COUNT(*) FROM Nganh WHERE MaNganh = '{0}'", maNganh);
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
                Console.WriteLine("Lỗi khi kiểm tra mã ngành: " + ex.Message);
                return false;
            }
            finally
            {
                DataProvider.DongKetNoi(conn);
            }
        }

        public static bool ThemNganh(Nganh_DTO nganh)
        {
            string sTruyVan = string.Format("INSERT INTO Nganh (MaNganh, TenNganh, MaKhoa) VALUES ('{0}', N'{1}', '{2}')", nganh.MaNganh, nganh.TenNganh,nganh.MaKhoa);
            conn = DataProvider.MoKetNoi();
            bool kq = DataProvider.TruyVanKhongLayDuLieu(sTruyVan, conn);
            if (kq)
            {
                return true;
            }
            DataProvider.DongKetNoi(conn);
            return false;
        }

        public static bool CapNhatNganh(Nganh_DTO nganh)
        {
            string sTruyVan = string.Format("UPDATE Nganh SET MaNganh = '{0}', TenNganh = N'{1}', MaKhoa = '{2}' WHERE Id = {3}", nganh.MaNganh, nganh.TenNganh, nganh.MaKhoa,nganh.Id);
            conn = DataProvider.MoKetNoi();
            bool kq = DataProvider.TruyVanKhongLayDuLieu(sTruyVan, conn);
            if (kq)
            {
                return true;
            }
            DataProvider.DongKetNoi(conn);
            return false;
        }

        public static bool XoaNganh(Nganh_DTO nganh)
        {
            string sTruyVan = string.Format("UPDATE Nganh SET TrangThai = 0 WHERE Id = {1}", nganh.TrangThai, nganh.Id);
            conn = DataProvider.MoKetNoi();
            bool kq = DataProvider.TruyVanKhongLayDuLieu(sTruyVan, conn);
            if (kq)
            {
                return true;
            }
            DataProvider.DongKetNoi(conn);
            return false;
        }
    }
}
