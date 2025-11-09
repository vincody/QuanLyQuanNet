using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanNet
{
    public static class TemporaryChatManager
    {
        // ✅ ĐÃ SỬA: Chuyển ChatHistory sang lưu trữ đối tượng ChatMessage
        public static Dictionary<string, List<ChatMessage>> ChatHistory = new Dictionary<string, List<ChatMessage>>();

        // Tùy chọn: Flag báo hiệu Admin có sẵn sàng chat hay không
        public static bool IsAdminReady;

        // Thêm static HashSet này để theo dõi các cửa sổ chat admin đang mở
        public static HashSet<string> OpenAdminChatWindows = new HashSet<string>();

        // Thêm thuộc tính này để theo dõi các máy có tin nhắn mới
        public static HashSet<string> MachinesWithNewMessages = new HashSet<string>();

        // Phương thức thêm tin nhắn vào lịch sử
        public static void AddMessage(string tenMay, string tenNguoiGui, string noiDung)
        {
            // ✅ ĐÃ SỬA: Tạo đối tượng ChatMessage thay vì chuỗi đơn
            ChatMessage message = new ChatMessage
            {
                Time = DateTime.Now,
                Sender = tenNguoiGui,
                Content = noiDung
            };

            // Kiểm tra và thêm vào Dictionary
            if (!ChatHistory.ContainsKey(tenMay))
            {
                // ✅ ĐÃ SỬA: Khởi tạo với List<ChatMessage>
                ChatHistory[tenMay] = new List<ChatMessage>();
            }

            ChatHistory[tenMay].Add(message);

            // Đánh dấu máy này là có tin nhắn mới (chỉ thêm nếu cửa sổ chat chưa mở)
            // Logic này sẽ kích hoạt thông báo Admin tự động bật Form ChatvKH
            if (!OpenAdminChatWindows.Contains(tenMay))
            {
                MachinesWithNewMessages.Add(tenMay);
            }
        }


        // Phương thức lấy lịch sử chat
        // ✅ ĐÃ SỬA: Trả về List<ChatMessage>
        public static List<ChatMessage> GetHistory(string tenMay)
        {
            if (ChatHistory.ContainsKey(tenMay))
            {
                return ChatHistory[tenMay];
            }
            // ✅ ĐÃ SỬA: Trả về List<ChatMessage> rỗng
            return new List<ChatMessage>();
        }
    }

    // ✅ ĐÃ GIỮ NGUYÊN VÀ CẦN ĐƯỢC SỬ DỤNG
    public class ChatMessage
    {
        public DateTime Time { get; set; }
        public string Sender { get; set; }
        public string Content { get; set; }
    }
}