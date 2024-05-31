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
    public class SinhVien_DAO
    {

        static SqlConnection conn;
        public static List<SinhVien_DTO> LayListSinhVien()
        {
            string sTruyVan = "select * from SinhVien";
            conn = DataProvider.MoKetNoi();
            DataTable dt = DataProvider.TruyVanLayDuLieu(sTruyVan, conn);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            List<SinhVien_DTO> lstSinhVien = new List<SinhVien_DTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                SinhVien_DTO sv = new SinhVien_DTO();
                sv.Id = int.Parse(dt.Rows[i]["Id"].ToString());
                sv.MaSinhVien = dt.Rows[i]["MaSinhVien"].ToString();
                sv.HoVaTenSV = dt.Rows[i]["HoTenSV"].ToString();
                sv.GioiTinh = dt.Rows[i]["GioiTinh"].ToString();
                sv.NgaySinh = dt.Rows[i]["NgaySinh"].ToString();
                sv.DiaChi = dt.Rows[i]["DiaChi"].ToString();
                sv.SoDienThoai = dt.Rows[i]["SoDienThoai"].ToString();
                sv.NgayNhapHoc = dt.Rows[i]["NgayNhapHoc"].ToString();
                sv.MaLop = dt.Rows[i]["MaLop"].ToString();
                sv.TrangThai = int.Parse(dt.Rows[i]["TrangThai"].ToString());
                lstSinhVien.Add(sv);
            }
            DataProvider.DongKetNoi(conn);
            return lstSinhVien;
        }

        public static List<SinhVien_DTO> LaySinhVienTheoLop(string maLop)
        {
            string sTruyVan = string.Format("select * from SinhVien where MaLop = '{0}'", maLop);
            conn = DataProvider.MoKetNoi();
            DataTable dt = DataProvider.TruyVanLayDuLieu(sTruyVan, conn);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            List<SinhVien_DTO> lstSinhVien = new List<SinhVien_DTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                SinhVien_DTO sv = new SinhVien_DTO();
                sv.Id = int.Parse(dt.Rows[i]["Id"].ToString());
                sv.MaSinhVien = dt.Rows[i]["MaSinhVien"].ToString();
                sv.HoVaTenSV = dt.Rows[i]["HoTenSV"].ToString();
                sv.GioiTinh = dt.Rows[i]["GioiTinh"].ToString();
                sv.NgaySinh = dt.Rows[i]["NgaySinh"].ToString();
                sv.DiaChi = dt.Rows[i]["DiaChi"].ToString();
                sv.SoDienThoai = dt.Rows[i]["SoDienThoai"].ToString();
                sv.NgayNhapHoc = dt.Rows[i]["NgayNhapHoc"].ToString();
                sv.MaLop = dt.Rows[i]["MaLop"].ToString();
                sv.TrangThai = int.Parse(dt.Rows[i]["TrangThai"].ToString());
                lstSinhVien.Add(sv);
            }
            DataProvider.DongKetNoi(conn);
            return lstSinhVien;
        }

        public static List<SinhVien_DTO> DanhSachSinhVienConHoc()
        {
            string sTruyVan = "select * from SinhVien where TrangThai = 1";
            conn = DataProvider.MoKetNoi();
            DataTable dt = DataProvider.TruyVanLayDuLieu(sTruyVan, conn);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            List<SinhVien_DTO> lstSinhVien = new List<SinhVien_DTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                SinhVien_DTO sv = new SinhVien_DTO();
                sv.Id = int.Parse(dt.Rows[i]["Id"].ToString());
                sv.MaSinhVien = dt.Rows[i]["MaSinhVien"].ToString();
                sv.HoVaTenSV = dt.Rows[i]["HoTenSV"].ToString();
                sv.GioiTinh = dt.Rows[i]["GioiTinh"].ToString();
                sv.NgaySinh = dt.Rows[i]["NgaySinh"].ToString();
                sv.DiaChi = dt.Rows[i]["DiaChi"].ToString();
                sv.SoDienThoai = dt.Rows[i]["SoDienThoai"].ToString();
                sv.NgayNhapHoc = dt.Rows[i]["NgayNhapHoc"].ToString();
                sv.MaLop = dt.Rows[i]["MaLop"].ToString();
                sv.TrangThai = int.Parse(dt.Rows[i]["TrangThai"].ToString());
                lstSinhVien.Add(sv);
            }
            DataProvider.DongKetNoi(conn);
            return lstSinhVien;
        }

        public static List<SinhVien_DTO> DanhSachSinhVienDaNghiHoc()
        {
            string sTruyVan = "select * from SinhVien where TrangThai = 0";
            conn = DataProvider.MoKetNoi();
            DataTable dt = DataProvider.TruyVanLayDuLieu(sTruyVan, conn);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            List<SinhVien_DTO> lstSinhVien = new List<SinhVien_DTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                SinhVien_DTO sv = new SinhVien_DTO();
                sv.Id = int.Parse(dt.Rows[i]["Id"].ToString());
                sv.MaSinhVien = dt.Rows[i]["MaSinhVien"].ToString();
                sv.HoVaTenSV = dt.Rows[i]["HoTenSV"].ToString();
                sv.GioiTinh = dt.Rows[i]["GioiTinh"].ToString();
                sv.NgaySinh = dt.Rows[i]["NgaySinh"].ToString();
                sv.DiaChi = dt.Rows[i]["DiaChi"].ToString();
                sv.SoDienThoai = dt.Rows[i]["SoDienThoai"].ToString();
                sv.NgayNhapHoc = dt.Rows[i]["NgayNhapHoc"].ToString();
                sv.MaLop = dt.Rows[i]["MaLop"].ToString();
                sv.TrangThai = int.Parse(dt.Rows[i]["TrangThai"].ToString());
                lstSinhVien.Add(sv);
            }
            DataProvider.DongKetNoi(conn);
            return lstSinhVien;
        }

        public static List<SinhVien_DTO> TimSinhVienTheoMSSV(string mssv)
        {
            string sTruyVan = string.Format(@"select * from SinhVien where MaSinhVien like '%{0}%'", mssv);
            conn = DataProvider.MoKetNoi();
            DataTable dt = DataProvider.TruyVanLayDuLieu(sTruyVan, conn);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            List<SinhVien_DTO> lstSinhVien = new List<SinhVien_DTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                SinhVien_DTO sv = new SinhVien_DTO();
                sv.Id = int.Parse(dt.Rows[i]["Id"].ToString());
                sv.MaSinhVien = dt.Rows[i]["MaSinhVien"].ToString();
                sv.HoVaTenSV = dt.Rows[i]["HoTenSV"].ToString();
                sv.GioiTinh = dt.Rows[i]["GioiTinh"].ToString();
                sv.NgaySinh = dt.Rows[i]["NgaySinh"].ToString();
                sv.DiaChi = dt.Rows[i]["DiaChi"].ToString();
                sv.SoDienThoai = dt.Rows[i]["SoDienThoai"].ToString();
                sv.NgayNhapHoc = dt.Rows[i]["NgayNhapHoc"].ToString();
                sv.MaLop = dt.Rows[i]["MaLop"].ToString();
                sv.TrangThai = int.Parse(dt.Rows[i]["TrangThai"].ToString());
                lstSinhVien.Add(sv);
            }
            DataProvider.DongKetNoi(conn);
            return lstSinhVien;
        }

        public static SinhVien_DTO TimSinhVienMSSV(string mssv)
        {
            string sTruyVan = string.Format(@"select * from SinhVien where MaSinhVien like '{0}'", mssv);
            conn = DataProvider.MoKetNoi();
            DataTable dt = DataProvider.TruyVanLayDuLieu(sTruyVan, conn);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            SinhVien_DTO sv = new SinhVien_DTO();
            sv.Id = int.Parse(dt.Rows[0]["Id"].ToString());
            sv.MaSinhVien = dt.Rows[0]["MaSinhVien"].ToString();
            sv.HoVaTenSV = dt.Rows[0]["HoTenSV"].ToString();
            sv.GioiTinh = dt.Rows[0]["GioiTinh"].ToString();
            sv.NgaySinh = dt.Rows[0]["NgaySinh"].ToString();
            sv.DiaChi = dt.Rows[0]["DiaChi"].ToString();
            sv.SoDienThoai = dt.Rows[0]["SoDienThoai"].ToString();
            sv.NgayNhapHoc = dt.Rows[0]["NgayNhapHoc"].ToString();
            sv.MaLop = dt.Rows[0]["MaLop"].ToString();
            sv.TrangThai = int.Parse(dt.Rows[0]["TrangThai"].ToString());
            DataProvider.DongKetNoi(conn);
            return sv;
        }



        public static bool KiemTraMSSV(string mssv)
        {
            string sTruyVan = string.Format(@"select * from SinhVien where MaSinhVien like '{0}'", mssv);
            conn = DataProvider.MoKetNoi();
            bool kq = DataProvider.TruyVanKhongLayDuLieu(sTruyVan, conn);
            if (kq)
            {
                return true;
            }
            DataProvider.DongKetNoi(conn);
            return false;
        }

        public static SinhVien_DTO TimSinhVienTheoID(int id)
        {
            string sTruyVan = string.Format(@"select * from SinhVien where Id = {0}", id);
            conn = DataProvider.MoKetNoi();
            DataTable dt = DataProvider.TruyVanLayDuLieu(sTruyVan, conn);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            SinhVien_DTO sv = new SinhVien_DTO();
            sv.Id = int.Parse(dt.Rows[0]["Id"].ToString());
            sv.MaSinhVien = dt.Rows[0]["MaSinhVien"].ToString();
            sv.HoVaTenSV = dt.Rows[0]["HoTenSV"].ToString();
            sv.GioiTinh = dt.Rows[0]["GioiTinh"].ToString();
            sv.NgaySinh = dt.Rows[0]["NgaySinh"].ToString();
            sv.DiaChi = dt.Rows[0]["DiaChi"].ToString();
            sv.SoDienThoai = dt.Rows[0]["SoDienThoai"].ToString();
            sv.NgayNhapHoc = dt.Rows[0]["NgayNhapHoc"].ToString();
            sv.MaLop = dt.Rows[0]["MaLop"].ToString();
            sv.TrangThai = int.Parse(dt.Rows[0]["TrangThai"].ToString());
            DataProvider.DongKetNoi(conn);
            return sv;
        }

        public static SinhVien_DTO TimSinhVienTheoTenSV(string hoten)
        {
            string sTruyVan = string.Format(@"select * from SinhVien where HoTenSV like N'{0}'", hoten);
            conn = DataProvider.MoKetNoi();
            DataTable dt = DataProvider.TruyVanLayDuLieu(sTruyVan, conn);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            SinhVien_DTO sv = new SinhVien_DTO();
            sv.Id = int.Parse(dt.Rows[0]["Id"].ToString());
            sv.MaSinhVien = dt.Rows[0]["MaSinhVien"].ToString();
            sv.HoVaTenSV = dt.Rows[0]["HoTenSV"].ToString();
            sv.GioiTinh = dt.Rows[0]["GioiTinh"].ToString();
            sv.NgaySinh = dt.Rows[0]["NgaySinh"].ToString();
            sv.DiaChi = dt.Rows[0]["DiaChi"].ToString();
            sv.SoDienThoai = dt.Rows[0]["SoDienThoai"].ToString();
            sv.NgayNhapHoc = dt.Rows[0]["NgayNhapHoc"].ToString();
            sv.MaLop = dt.Rows[0]["MaLop"].ToString();
            sv.TrangThai = int.Parse(dt.Rows[0]["TrangThai"].ToString());
            DataProvider.DongKetNoi(conn);
            return sv;
        }

        public static bool ThemSinhVien(SinhVien_DTO sv)
        {
            string struyvan = string.Format(@"INSERT INTO SinhVien (MaSinhVien, HoTenSV, GioiTinh, NgaySinh, DiaChi, SoDienThoai, NgayNhapHoc, MaLop, TrangThai) 
                    VALUES ('{0}', N'{1}', N'{2}', '{3}', N'{4}', '{5}', '{6}', '{7}', {8})", sv.MaSinhVien, sv.HoVaTenSV, sv.GioiTinh, sv.NgaySinh, sv.DiaChi, sv.SoDienThoai, sv.NgayNhapHoc, sv.MaLop, sv.TrangThai);
            conn = DataProvider.MoKetNoi();
            bool kq = DataProvider.TruyVanKhongLayDuLieu(struyvan, conn);
            DataProvider.DongKetNoi(conn);
            return kq;
        }

        public static bool SuaSinhVien(SinhVien_DTO sv)
        {
            string struyvan = string.Format(@"UPDATE SinhVien SET MaSinhVien = '{0}', HoTenSV = N'{1}', GioiTinh = N'{2}', NgaySinh = '{3}', DiaChi = N'{4}', SoDienThoai = '{5}', NgayNhapHoc = '{6}', MaLop = '{7}', TrangThai = {8} WHERE Id = {9}",
                sv.MaSinhVien, sv.HoVaTenSV, sv.GioiTinh, sv.NgaySinh, sv.DiaChi, sv.SoDienThoai, sv.NgayNhapHoc, sv.MaLop, sv.TrangThai, sv.Id);
            conn = DataProvider.MoKetNoi();
            bool kq = DataProvider.TruyVanKhongLayDuLieu(struyvan, conn);
            DataProvider.DongKetNoi(conn);
            
            return kq;
        }

        public static bool XoaSinhVien(int id)
        {
            string struyvan = string.Format(@"UPDATE SinhVien SET TrangThai=0 WHERE Id={0}", id);
            conn = DataProvider.MoKetNoi();
            bool kq = DataProvider.TruyVanKhongLayDuLieu(struyvan, conn);
            DataProvider.DongKetNoi(conn);
            return kq;
        }



    }
}
