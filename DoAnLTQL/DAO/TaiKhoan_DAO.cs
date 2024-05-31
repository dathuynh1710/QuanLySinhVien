using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAO
{
    public class TaiKhoan_DAO
    {
        static SqlConnection conn;
        public static bool KiemTraDangNhap(string tenDangNhap, string matKhau)
        {
            string sTruyVan = string.Format(@"select * from TaiKhoan where TenDangNhap = '{0}' and MatKhau = '{1}' and TrangThai = 1", tenDangNhap, matKhau);
            conn = DataProvider.MoKetNoi();
            bool ketQua = DataProvider.TruyVanKhongLayDuLieu(sTruyVan, conn);
            if(ketQua )
            {
                return true;
            }
            DataProvider.DongKetNoi(conn);
            return false;
        }

        public static List<TaiKhoan_DTO> LayListTaiKhoan()
        {
            string sTruyVan = "select * from TaiKhoan";
            conn = DataProvider.MoKetNoi();
            DataTable dt = DataProvider.TruyVanLayDuLieu(sTruyVan, conn);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            List<TaiKhoan_DTO> lstTaiKhoan = new List<TaiKhoan_DTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                TaiKhoan_DTO taiKhoan = new TaiKhoan_DTO();
                taiKhoan.Id = int.Parse(dt.Rows[i]["Id"].ToString());
                taiKhoan.TenDangNhap = dt.Rows[i]["TenDangNhap"].ToString();
                taiKhoan.MatKhau = dt.Rows[i]["MatKhau"].ToString();
                taiKhoan.LoaiTaiKhoan = dt.Rows[i]["LoaiTaiKhoan"].ToString();
                taiKhoan.TrangThai = int.Parse(dt.Rows[i]["TrangThai"].ToString());
                lstTaiKhoan.Add(taiKhoan);
            }
            DataProvider.DongKetNoi(conn);
            return lstTaiKhoan;
        }

        public static TaiKhoan_DTO LayLoaiTaiKhoan(string tendangnhap)
        {
            string sTruyVan =string.Format(@"select * from TaiKhoan where TenDangNhap = '{0}'",tendangnhap);
            conn = DataProvider.MoKetNoi();
            DataTable dt = DataProvider.TruyVanLayDuLieu(sTruyVan, conn);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            TaiKhoan_DTO taiKhoan = new TaiKhoan_DTO();
            taiKhoan.Id = int.Parse(dt.Rows[0]["Id"].ToString());
            taiKhoan.TenDangNhap = dt.Rows[0]["TenDangNhap"].ToString();
            taiKhoan.MatKhau = dt.Rows[0]["MatKhau"].ToString();
            taiKhoan.LoaiTaiKhoan = dt.Rows[0]["LoaiTaiKhoan"].ToString();
            taiKhoan.TrangThai = int.Parse(dt.Rows[0]["TrangThai"].ToString());
            DataProvider.DongKetNoi(conn);
            return taiKhoan;
        }

        public static bool KiemTraTen(string tendangnhap)
        {
            string sTruyVan = string.Format("SELECT COUNT(*) FROM TaiKhoan WHERE TenDangNhap = '{0}'", tendangnhap);
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

        public static bool ThemTaiKhoan(TaiKhoan_DTO tk)
        {
            string sTruyVan = string.Format("INSERT INTO TaiKhoan (TenDangNhap,MatKhau,LoaiTaiKhoan) VALUES ('{0}','{1}',N'{2}')", tk.TenDangNhap, tk.MatKhau, tk.LoaiTaiKhoan);
            conn = DataProvider.MoKetNoi();
            bool kq = DataProvider.TruyVanKhongLayDuLieu(sTruyVan, conn);
            if (kq)
            {
                return true;
            }
            DataProvider.DongKetNoi(conn);
            return false;
        }

        public static bool CapNhatTaiKhoan(TaiKhoan_DTO tk)
        {
            string sTruyVan = string.Format("UPDATE TaiKhoan SET MatKhau ='{0}',LoaiTaiKhoan=N'{1}' WHERE Id = {2}", tk.MatKhau, tk.LoaiTaiKhoan, tk.Id);
            conn = DataProvider.MoKetNoi();
            bool kq = DataProvider.TruyVanKhongLayDuLieu(sTruyVan, conn);
            if (kq)
            {
                return true;
            }
            DataProvider.DongKetNoi(conn);
            return false;
        }

        public static bool XoaTaiKhoan(TaiKhoan_DTO tk)
        {
            string sTruyVan = string.Format("UPDATE TaiKhoan SET TrangThai = 0 WHERE Id = {1}", tk.TrangThai, tk.Id);
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
