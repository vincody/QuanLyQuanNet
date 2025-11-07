using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanNet
{
    public static class UserSession
    {
        public static string TenDangNhap { get; set; }
        public static bool IsAdmin { get; set; }
        public static bool IsNhanVien { get; set; }
        public static bool IsKhach { get; set; }
        public static string TenMay { get; set; }
        public static int TaiKhoanID { get; set; }
        public static string HoTen { get; set; }
        // Thêm các thông tin khác nếu cần, ví dụ: ID người dùng, Tên hiển thị...
    }
}
