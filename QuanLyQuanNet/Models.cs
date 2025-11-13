using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace QuanLyQuanNet
{
    public class Models
    {
        // Đặt các class này bên ngoài Form chính (Ví dụ: trong một file Models.cs)

        public class FilmItem
        {
            public string slug { get; set; }
            public string name { get; set; }
            public string poster_url { get; set; } // Giả định trường này tồn tại trong response
            public int year { get; set; }
        }

        public class FilmApiResponse
        {
            // Cấu trúc API thường trả về data/items bên trong một đối tượng gốc
            // Cần kiểm tra response JSON thực tế để điều chỉnh nếu cần
            public List<FilmItem> items { get; set; }
            // ✅ SỬA LỖI ÁNH XẠ: Ánh xạ trường "total_page" từ JSON vào thuộc tính C# "totalPages"
            [JsonProperty("total_page")]
            public int totalPages { get; set; }
            public int totalItems { get; set; } // Nên thêm cả totalItems nếu API cung cấp
            // Thêm các trường khác như totalItems, totalPages... nếu bạn cần phân trang
        }
    }
}
