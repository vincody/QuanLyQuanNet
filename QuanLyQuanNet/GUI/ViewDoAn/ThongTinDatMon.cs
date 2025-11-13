using System;
using System.Collections.Generic;
// ... (các using khác) ...
using System.Windows.Forms;

namespace QuanLyQuanNet.GUI.ViewDoAn
{
    public partial class ThongTinDatMon : UserControl
    {
        // Cần có các thuộc tính công khai (Public)
        public string TenMon { get; set; }
        public decimal GiaDonVi { get; set; }
        private int _soLuong = 1;

        public int MonAnID { get; set; } // <<<<< ĐÃ KHAI BÁO

        public event EventHandler<OrderUpdateEventArgs> QuantityChanged;
        public event EventHandler ItemRemoved;

        // Thuộc tính này không cần thiết, Form cha nên quản lý Dictionary
        // public Dictionary<string, ThongTinDatMon> CurrentOrderItems { get; set; } 

        public ThongTinDatMon()
        {
            InitializeComponent();
        }

        // ✅ ĐÃ SỬA: Bổ sung MonAnID vào tham số
        public void InitializeItem(int monAnID, string tenMon, decimal giaDonVi)
        {
            this.MonAnID = monAnID;       // ✅ Gán MonAnID
            this.TenMon = tenMon;
            this.GiaDonVi = giaDonVi;
            UpdateDisplay();
        }

        // Hàm cập nhật hiển thị (tên món, số lượng, tổng giá)
        private void UpdateDisplay()
        {
            labelTenMon.Text = this.TenMon;
            // Hiển thị tổng giá tiền: Đơn giá * Số lượng
            labelGiaTien.Text = (this.GiaDonVi * _soLuong).ToString("N0") + " VNĐ";
            // Giả định Label SoLuong tồn tại trên User Control
            SoLuong.Text = _soLuong.ToString();

            // Gửi sự kiện cập nhật lên Form cha để tính tổng hóa đơn
            QuantityChanged?.Invoke(this, new OrderUpdateEventArgs(this.TenMon, this.GiaDonVi, _soLuong));
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            _soLuong++;
            UpdateDisplay();
        }

        private void btnBot_Click(object sender, EventArgs e)
        {
            if (_soLuong > 1)
            {
                _soLuong--;
                UpdateDisplay();
            }
        }

        private void btnXoaMon_Click(object sender, EventArgs e)
        {
            // Thông báo cho Form cha trước khi xóa control
            ItemRemoved?.Invoke(this, EventArgs.Empty);
            // Xóa chính control này khỏi FlowLayoutPanel
            this.Dispose();
        }

        // Class mô hình dữ liệu để gửi thông tin cập nhật (GIỮ NGUYÊN)
        public class OrderUpdateEventArgs : EventArgs
        {
            public string ItemName { get; }
            public decimal UnitPrice { get; }
            public int Quantity { get; }

            public OrderUpdateEventArgs(string name, decimal price, int quantity)
            {
                ItemName = name;
                UnitPrice = price;
                Quantity = quantity;
            }
        }

        // ✅ ĐÃ XÓA/DI CHUYỂN: Các hàm OrderItemControl_QuantityChanged và ItemRemoved
        // đã bị xóa khỏi đây vì chúng thuộc về Form cha (GoiMon.cs).
        // Hãy đảm bảo code trong GoiMon.cs gọi InitializeItem(monAnID, tenMon, giaDonVi).
    }
}