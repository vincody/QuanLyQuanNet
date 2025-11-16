using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanNet
{
    public class MonAnModel
    {
        public int MonAnID { get; set; } // Cần thiết để biết món nào cần sửa trong DB
        public string TenMon { get; set; }
        public decimal Gia { get; set; }
        public string DanhMuc { get; set; }
        public string HinhAnhPath { get; set; }
    }
}
