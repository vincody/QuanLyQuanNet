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
        public static decimal SoDu { get; set; }           // Số dư hiện tại của khách (lấy từ TaiKhoan)
        public static decimal GiaTheoGio { get; set; }
        // Thêm các thông tin khác nếu cần, ví dụ: ID người dùng, Tên hiển thị...   
        public static void ClearSession()
        {
            // Reset tất cả các thuộc tính về giá trị mặc định an toàn (NULL hoặc 0/False)
            TenDangNhap = null;
            IsAdmin = false;
            IsNhanVien = false;
            IsKhach = false;
            TenMay = null;
            TaiKhoanID = 0;
            SoDu = 0;
            // Đặt lại tất cả các thuộc tính bạn đã khai báo trong UserSession
            // Ví dụ: UserSession.GiaTheoGio = 0;
        }
    }
}
