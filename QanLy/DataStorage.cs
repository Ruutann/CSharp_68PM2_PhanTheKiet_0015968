using System;
using System.Collections.Generic;
using System.Data;

namespace QanLy// Đảm bảo trùng với namespace của Form chính
{
    public static class DataStorage
    {
        // 1. Nơi lưu trữ bảng Lớp học
        public static DataTable dtLopHoc = new DataTable();

        // 2. Nơi lưu trữ bảng Sinh viên
        public static DataTable dtSinhVien = new DataTable();

        // 3. Hàm khởi tạo dữ liệu mặc định (Chạy 1 lần duy nhất)
        public static void InitData()
        {
            // Thiết lập cột cho bảng Lớp
            if (dtLopHoc.Columns.Count == 0)
            {
                dtLopHoc.Columns.Add("MaID");
                dtLopHoc.Columns.Add("MaLop");
                dtLopHoc.Columns.Add("TenLop");
                dtLopHoc.Columns.Add("GhiChu");

                // Thêm vài lớp mẫu cho HUCE
                dtLopHoc.Rows.Add("1", "68PM1", "Công nghệ phần mềm 1", "abc");
                dtLopHoc.Rows.Add("2", "68PM2", "Công nghệ phần mềm 2", "xyz");
            }

            // Thiết lập cột cho bảng Sinh viên
            if (dtSinhVien.Columns.Count == 0)
            {
                dtSinhVien.Columns.Add("MaSV");
                dtSinhVien.Columns.Add("HoTen");
                dtSinhVien.Columns.Add("GioiTinh");
                dtSinhVien.Columns.Add("NgaySinh");
                dtSinhVien.Columns.Add("Lop");

                // Dữ liệu mẫu của Kiệt
                dtSinhVien.Rows.Add("0015968", "Phan Thế Kiệt", "Nam", "15/05/2026", "68PM2");
            }
        }
    }
}