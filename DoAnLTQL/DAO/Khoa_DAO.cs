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
    public class Khoa_DAO
    {
        static SqlConnection conn;
        public static List<Khoa_DTO> LayListKhoa()
        {
            string sTruyVan = "select * from Khoa where TrangThai = 1";
            conn = DataProvider.MoKetNoi();
            DataTable dt = DataProvider.TruyVanLayDuLieu(sTruyVan, conn);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            List<Khoa_DTO> lstKhoa = new List<Khoa_DTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                Khoa_DTO khoa = new Khoa_DTO();
                khoa.Id = int.Parse(dt.Rows[i]["Id"].ToString());
                khoa.MaKhoa = dt.Rows[i]["MaKhoa"].ToString();
                khoa.TenKhoa = dt.Rows[i]["TenKhoa"].ToString();
                khoa.TrangThai = int.Parse(dt.Rows[i]["TrangThai"].ToString());
                lstKhoa.Add(khoa);
            }
            DataProvider.DongKetNoi(conn);
            return lstKhoa;
        }

        public static Khoa_DTO TimKhoaCuaSV(string maKhoa)
        {
            string sTruyVan = string.Format("select * from Khoa where MaKhoa = '{0}'", maKhoa);
            conn = DataProvider.MoKetNoi();
            DataTable dt = DataProvider.TruyVanLayDuLieu(sTruyVan, conn);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            Khoa_DTO khoa = new Khoa_DTO();
            khoa.Id = int.Parse(dt.Rows[0]["Id"].ToString());
            khoa.MaKhoa = dt.Rows[0]["MaKhoa"].ToString();
            khoa.TenKhoa = dt.Rows[0]["TenKhoa"].ToString();
            khoa.TrangThai = int.Parse(dt.Rows[0]["TrangThai"].ToString());
            return khoa;
        }

        public static Khoa_DTO TimKhoaCuaNganhTheoTenKhoa(string tenKhoa)
        {
            string sTruyVan = string.Format("select * from Khoa where TenKhoa like N'{0}'", tenKhoa);
            conn = DataProvider.MoKetNoi();
            DataTable dt = DataProvider.TruyVanLayDuLieu(sTruyVan, conn);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            Khoa_DTO khoa = new Khoa_DTO();
            khoa.Id = int.Parse(dt.Rows[0]["Id"].ToString());
            khoa.MaKhoa = dt.Rows[0]["MaKhoa"].ToString();
            khoa.TenKhoa = dt.Rows[0]["TenKhoa"].ToString();
            khoa.TrangThai = int.Parse(dt.Rows[0]["TrangThai"].ToString());
            return khoa;
        }

        /*public static bool KiemTraKhoa(string maKhoa)
        {
            string sTruyVan = string.Format(@"select * from Khoa where MaKhoa like '{0}'", maKhoa);
            conn = DataProvider.MoKetNoi();
            bool kq = DataProvider.TruyVanKhongLayDuLieu(sTruyVan, conn);
            DataProvider.DongKetNoi(conn);
            return kq;
        }*/
        public static bool KiemTraKhoa(string maKhoa)
        {
            string sTruyVan = string.Format("SELECT COUNT(*) FROM Khoa WHERE MaKhoa = '{0}'", maKhoa);
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


        public static bool ThemKhoa(Khoa_DTO khoa)
        {
            string sTruyVan = string.Format("INSERT INTO Khoa (MaKhoa, TenKhoa) VALUES ('{0}', N'{1}')", khoa.MaKhoa, khoa.TenKhoa);
            conn = DataProvider.MoKetNoi();
            bool kq = DataProvider.TruyVanKhongLayDuLieu(sTruyVan, conn);
            if(kq)
            {
                return true;
            }
            DataProvider.DongKetNoi(conn);
            return false;
        }

        public static bool CapNhatKhoa(Khoa_DTO khoa)
        {
            string sTruyVan = string.Format("UPDATE Khoa SET MaKhoa = '{0}', TenKhoa = N'{1}' WHERE Id = {2}", khoa.MaKhoa, khoa.TenKhoa,khoa.Id);
            conn = DataProvider.MoKetNoi();
            bool kq = DataProvider.TruyVanKhongLayDuLieu(sTruyVan, conn);
            if (kq)
            {
                return true;
            }
            DataProvider.DongKetNoi(conn);
            return false;
        }

        public static bool XoaKhoa(Khoa_DTO khoa)
        {
            string sTruyVan = string.Format("UPDATE Khoa SET TrangThai=0 WHERE Id = {1}", khoa.TrangThai, khoa.Id);
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
