using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using DTO;

namespace DAO
{
    public class CVHT_DAO
    {
        static SqlConnection conn;

        public static List<CVHT_DTO> LayListCVHT()
        {
            string sTruyVan = "select * from CVHT where TrangThai = 1";
            conn = DataProvider.MoKetNoi();
            DataTable dt = DataProvider.TruyVanLayDuLieu(sTruyVan, conn);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            List<CVHT_DTO> lstCVHT = new List<CVHT_DTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                CVHT_DTO cvht = new CVHT_DTO();
                cvht.Id = int.Parse(dt.Rows[i]["Id"].ToString());
                cvht.MaCVHT = dt.Rows[i]["MaCVHT"].ToString();
                cvht.TenCVHT = dt.Rows[i]["TenCVHT"].ToString();
                cvht.NgaySinh = Convert.ToDateTime(dt.Rows[i]["NgaySinh"].ToString());
                cvht.GioiTinh = dt.Rows[i]["GioiTinh"].ToString();
                cvht.TrangThai = int.Parse(dt.Rows[i]["TrangThai"].ToString());
                lstCVHT.Add(cvht);
            }
            DataProvider.DongKetNoi(conn);
            return lstCVHT;
        }

        public static CVHT_DTO TimCVHTCuaSV(string maCVHT)
        {
            string sTruyVan = string.Format("select * from CVHT where MaCVHT = '{0}'", maCVHT);
            conn = DataProvider.MoKetNoi();
            DataTable dt = DataProvider.TruyVanLayDuLieu(sTruyVan, conn);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            CVHT_DTO cvht = new CVHT_DTO();
            cvht.Id = int.Parse(dt.Rows[0]["Id"].ToString());
            cvht.MaCVHT = dt.Rows[0]["MaCVHT"].ToString();
            cvht.TenCVHT = dt.Rows[0]["TenCVHT"].ToString();
            cvht.NgaySinh = Convert.ToDateTime(dt.Rows[0]["NgaySinh"].ToString());
            cvht.GioiTinh = dt.Rows[0]["GioiTinh"].ToString();
            cvht.TrangThai = int.Parse(dt.Rows[0]["TrangThai"].ToString());
            DataProvider.DongKetNoi(conn);
            return cvht;
        }

        public static CVHT_DTO TimCVHTTheoTenCVHT(string tenCVHT)
        {
            string sTruyVan = string.Format("select * from CVHT where TenCVHT = N'{0}'", tenCVHT);
            conn = DataProvider.MoKetNoi();
            DataTable dt = DataProvider.TruyVanLayDuLieu(sTruyVan, conn);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            CVHT_DTO cvht = new CVHT_DTO();
            cvht.Id = int.Parse(dt.Rows[0]["Id"].ToString());
            cvht.MaCVHT = dt.Rows[0]["MaCVHT"].ToString();
            cvht.TenCVHT = dt.Rows[0]["TenCVHT"].ToString();
            cvht.NgaySinh = Convert.ToDateTime(dt.Rows[0]["NgaySinh"].ToString());
            cvht.GioiTinh = dt.Rows[0]["GioiTinh"].ToString();
            cvht.TrangThai = int.Parse(dt.Rows[0]["TrangThai"].ToString());
            DataProvider.DongKetNoi(conn);
            return cvht;
        }

        public static CVHT_DTO TimCVHTTheoMaCVHT(string maCVHT)
        {
            string sTruyVan = string.Format("select * from CVHT where MaCVHT = '{0}'", maCVHT);
            conn = DataProvider.MoKetNoi();
            DataTable dt = DataProvider.TruyVanLayDuLieu(sTruyVan, conn);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            CVHT_DTO cvht = new CVHT_DTO();
            cvht.Id = int.Parse(dt.Rows[0]["Id"].ToString());
            cvht.MaCVHT = dt.Rows[0]["MaCVHT"].ToString();
            cvht.TenCVHT = dt.Rows[0]["TenCVHT"].ToString();
            cvht.NgaySinh = Convert.ToDateTime(dt.Rows[0]["NgaySinh"].ToString());
            cvht.GioiTinh = dt.Rows[0]["GioiTinh"].ToString();
            cvht.TrangThai = int.Parse(dt.Rows[0]["TrangThai"].ToString());
            DataProvider.DongKetNoi(conn);
            return cvht;
        }

        public static bool ThemCVHT(CVHT_DTO cvht)
        {
            string sTruyVan = string.Format("INSERT INTO CVHT (MaCVHT, TenCVHT, NgaySinh, GioiTinh) VALUES ('{0}', N'{1}', '{2}', N'{3}')", cvht.MaCVHT, cvht.TenCVHT, cvht.NgaySinh.ToString("yyyy-MM-dd"), cvht.GioiTinh);
            conn = DataProvider.MoKetNoi();
            bool kq = DataProvider.TruyVanKhongLayDuLieu(sTruyVan, conn);
            DataProvider.DongKetNoi(conn);
            return kq;
        }

        public static bool CapNhatCVHT(CVHT_DTO cvht)
        {
            string sTruyVan = string.Format("UPDATE CVHT SET TenCVHT = N'{0}', NgaySinh = '{1}', GioiTinh = N'{2}' WHERE MaCVHT = '{3}'", cvht.TenCVHT, cvht.NgaySinh.ToString("yyyy-MM-dd"), cvht.GioiTinh, cvht.MaCVHT);
            conn = DataProvider.MoKetNoi();
            bool kq = DataProvider.TruyVanKhongLayDuLieu(sTruyVan, conn);
            DataProvider.DongKetNoi(conn);
            return kq;
        }

        public static bool XoaCVHT(string maCVHT)
        {
            string sTruyVan = string.Format("UPDATE CVHT SET TrangThai=0 WHERE MaCVHT = '{0}'", maCVHT);
            conn = DataProvider.MoKetNoi();
            bool kq = DataProvider.TruyVanKhongLayDuLieu(sTruyVan, conn);
            DataProvider.DongKetNoi(conn);
            return kq;
        }


    }
}
