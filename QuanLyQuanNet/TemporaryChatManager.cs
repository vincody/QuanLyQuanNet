using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanNet
{
    public static class TemporaryChatManager
    {
        // Cấu trúc để lưu lịch sử chat của từng máy
        public static Dictionary<string, List<string>> ChatHistory = new Dictionary<string, List<string>>();

        // Tùy chọn: Flag báo hiệu Admin có sẵn sàng chat hay không
        public static bool IsAdminReady ;

        // Thêm static HashSet này để theo dõi các cửa sổ chat admin đang mở
        public static HashSet<string> OpenAdminChatWindows = new HashSet<string>();

        // Thêm thuộc tính này để theo dõi các máy có tin nhắn mới
        public static HashSet<string> MachinesWithNewMessages = new HashSet<string>();

        // Phương thức thêm tin nhắn vào lịch sử
        public static void AddMessage(string tenMay, string tenNguoiGui, string noiDung)
        {
            // Định dạng tin nhắn giống như ảnh mẫu: [HH:mm:ss] [Sender]: Content
            string formattedTime = DateTime.Now.ToString("HH:mm:ss");
            string message = $"{formattedTime} [{tenNguoiGui}]: {noiDung}";

            // Kiểm tra và thêm vào Dictionary
            if (!ChatHistory.ContainsKey(tenMay))
            {
                ChatHistory[tenMay] = new List<string>();
            }

            ChatHistory[tenMay].Add(message);

            // Đ đánh dấu máy này là có tin nhắn mới
            MachinesWithNewMessages.Add(tenMay);
        }


        // Phương thức lấy lịch sử chat
        public static List<string> GetHistory(string tenMay)
        {
            if (ChatHistory.ContainsKey(tenMay))
            {
                return ChatHistory[tenMay];
            }
            return new List<string>();
        }
    }

    public class ChatMessage
    {
        public DateTime Time { get; set; }
        public string Sender { get; set; }
        public string Content { get; set; }
    }
}
