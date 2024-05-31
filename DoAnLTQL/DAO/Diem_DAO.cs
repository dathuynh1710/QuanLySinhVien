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
    public class Diem_DAO
    {
        static SqlConnection conn;

        public static List<Diem_DTO> LayListDiemSinhVienConHocVaConMonHoc()
        {
            string sTruyVan = "SELECT Diem.*, SinhVien.*, MonHoc.* FROM Diem INNER JOIN SinhVien ON Diem.MaSinhVien = SinhVien.MaSinhVien INNER JOIN MonHoc ON Diem.MaMonHoc = MonHoc.MaMonHoc WHERE SinhVien.TrangThai = 1 AND MonHoc.TrangThai = 1";
            conn = DataProvider.MoKetNoi();
            DataTable dt = DataProvider.TruyVanLayDuLieu(sTruyVan, conn);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            List<Diem_DTO> lstDiem = new List<Diem_DTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                Diem_DTO diem = new Diem_DTO();
                diem.Id = int.Parse(dt.Rows[i]["Id"].ToString());
                diem.MaMonHoc = dt.Rows[i]["MaMonHoc"].ToString();
                diem.MaSinhVien = dt.Rows[i]["MaSinhVien"].ToString();
                diem.PhanTramTrenLop = int.Parse(dt.Rows[i]["PhanTramTrenLop"].ToString());
                diem.PhanTramThi = int.Parse(dt.Rows[i]["PhanTramThi"].ToString());
                diem.DiemTrenLop = float.Parse(dt.Rows[i]["DiemTrenLop"].ToString());
                diem.DiemThi = float.Parse(dt.Rows[i]["DiemThi"].ToString());
                diem.DiemTB = float.Parse(dt.Rows[i]["DiemTB"].ToString());
                diem.Loai = dt.Rows[i]["Loai"].ToString();
                lstDiem.Add(diem);
            }
            DataProvider.DongKetNoi(conn);
            return lstDiem;
        }

        public static Diem_DTO TimDiemTheoMaMonHoc(string maMonHoc)
        {
            string sTruyVan = string.Format(@"select * from Diem where MaMonHoc = '{0}'", maMonHoc);
            conn = DataProvider.MoKetNoi();
            DataTable dt = DataProvider.TruyVanLayDuLieu(sTruyVan, conn);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            Diem_DTO diem = new Diem_DTO();
            diem.Id = int.Parse(dt.Rows[0]["Id"].ToString());
            diem.MaMonHoc = dt.Rows[0]["MaMonHoc"].ToString();
            diem.MaSinhVien = dt.Rows[0]["MaSinhVien"].ToString();
            diem.PhanTramTrenLop = int.Parse(dt.Rows[0]["PhanTramTrenLop"].ToString());
            diem.PhanTramThi = int.Parse(dt.Rows[0]["PhanTramThi"].ToString());
            diem.DiemTrenLop = float.Parse(dt.Rows[0]["DiemTrenLop"].ToString());
            diem.DiemThi = float.Parse(dt.Rows[0]["DiemThi"].ToString());
            diem.DiemTB = float.Parse(dt.Rows[0]["DiemTB"].ToString());
            diem.Loai = dt.Rows[0]["Loai"].ToString();
            DataProvider.DongKetNoi(conn);
            return diem;
        }

        public static Diem_DTO TimDiemTheoMaMonHocVaMaSinhVien(string maMonHoc, string maSinhVien)
        {
            string sTruyVan = string.Format(@"select * from Diem where MaMonHoc = '{0}' and MaSinhVien='{1}'", maMonHoc,maSinhVien);
            conn = DataProvider.MoKetNoi();
            DataTable dt = DataProvider.TruyVanLayDuLieu(sTruyVan, conn);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            Diem_DTO diem = new Diem_DTO();
            diem.Id = int.Parse(dt.Rows[0]["Id"].ToString());
            diem.MaMonHoc = dt.Rows[0]["MaMonHoc"].ToString();
            diem.MaSinhVien = dt.Rows[0]["MaSinhVien"].ToString();
            diem.PhanTramTrenLop = int.Parse(dt.Rows[0]["PhanTramTrenLop"].ToString());
            diem.PhanTramThi = int.Parse(dt.Rows[0]["PhanTramThi"].ToString());
            diem.DiemTrenLop = float.Parse(dt.Rows[0]["DiemTrenLop"].ToString());
            diem.DiemThi = float.Parse(dt.Rows[0]["DiemThi"].ToString());
            diem.DiemTB = float.Parse(dt.Rows[0]["DiemTB"].ToString());
            diem.Loai = dt.Rows[0]["Loai"].ToString();
            DataProvider.DongKetNoi(conn);
            return diem;
        }



        public static bool ThemDiem(Diem_DTO diem)
        {
            string sTruyVan = string.Format(@"INSERT INTO Diem (MaSinhVien, MaMonHoc, PhanTramTrenLop, PhanTramThi, DiemTrenLop, DiemThi, DiemTB, Loai)
                                  VALUES ('{0}', '{1}', {2}, {3}, {4}, {5}, {6}, '{7}')",
                                  diem.MaSinhVien, diem.MaMonHoc, diem.PhanTramTrenLop, diem.PhanTramThi, diem.DiemTrenLop, diem.DiemThi, diem.DiemTB, diem.Loai);

            conn = DataProvider.MoKetNoi();
            bool kq = DataProvider.TruyVanKhongLayDuLieu(sTruyVan, conn);
            if (kq)
            {
                return true;
            }
            DataProvider.DongKetNoi(conn);
            return false;

        }
        public static bool SuaDiem(Diem_DTO diem)
        {
            string sTruyVan = string.Format(@"UPDATE Diem 
                                  SET MaSinhVien = '{0}', MaMonHoc = '{1}', PhanTramTrenLop = {2}, PhanTramThi = {3}, 
                                      DiemTrenLop = {4}, DiemThi = {5}, DiemTB = {6}, Loai = '{7}'
                                  WHERE Id = {8}",
                                  diem.MaSinhVien, diem.MaMonHoc, diem.PhanTramTrenLop, diem.PhanTramThi,
                                  diem.DiemTrenLop, diem.DiemThi, diem.DiemTB, diem.Loai,
                                  diem.Id);

            conn = DataProvider.MoKetNoi();
            bool kq = DataProvider.TruyVanKhongLayDuLieu(sTruyVan, conn);
            if (kq)
            {
                return true;
            }
            DataProvider.DongKetNoi(conn);
            return false;

        }

        public static bool XoaDiem(string maSinhVien, string maMonHoc)
        {
            string sTruyVan = string.Format(@"DELETE FROM Diem WHERE MaSinhVien = '{0}' and MaMonHoc = '{1}'", maSinhVien, maMonHoc);

            conn = DataProvider.MoKetNoi();
            bool kq = DataProvider.TruyVanKhongLayDuLieu(sTruyVan, conn);
            if (kq)
            {
                return true;
            }
            DataProvider.DongKetNoi(conn);
            return false;
        }

            public static bool KiemTraDiem(string maSinhVien, string maMonHoc)
        {
            // Tạo câu truy vấn SELECT để kiểm tra xem sinh viên có điểm cho môn học đó chưa
            string sTruyVan = string.Format(@"SELECT COUNT(*) FROM Diem 
                                      WHERE MaSinhVien = '{0}' AND MaMonHoc = '{1}'", maSinhVien, maMonHoc);

            // Thực hiện truy vấn và kiểm tra kết quả
            int count = 0;
            conn = DataProvider.MoKetNoi();
            SqlCommand cmd = new SqlCommand(sTruyVan, conn);
            count = (int)cmd.ExecuteScalar(); // Lấy số lượng bản ghi trả về
            if(count>0) {
                return true;
            }
            DataProvider.DongKetNoi(conn);

            // Nếu số lượng bản ghi > 0, có nghĩa là sinh viên đã có điểm cho môn học đó
            return false;
        }

    }
}
