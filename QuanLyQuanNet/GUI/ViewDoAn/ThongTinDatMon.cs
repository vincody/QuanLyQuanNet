using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyQuanNet.GUI.ViewDoAn
{
    public partial class ThongTinDatMon : UserControl
    {
        // Cần có các thuộc tính công khai (Public) để Form cha gán dữ liệu
        public string TenMon { get; set; }
        public decimal GiaDonVi { get; set; }
        private int _soLuong = 1;
        public event EventHandler<OrderUpdateEventArgs> QuantityChanged;
        public event EventHandler ItemRemoved;

        // Add this field to your ThongTinDatMon class if you want to manage order items here,
        // or (recommended) pass the dictionary from the parent form as a parameter to the control's constructor or method.
        // For demonstration, I'll add a property to set it from outside:
        public Dictionary<string, ThongTinDatMon> CurrentOrderItems { get; set; }

        public ThongTinDatMon()
        {
            InitializeComponent();
        }
        // Gán giá trị ban đầu và cập nhật
        public void InitializeItem(string tenMon, decimal giaDonVi)
        {
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
        // Class mô hình dữ liệu để gửi thông tin cập nhật
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
        // Xử lý khi số lượng món ăn thay đổi (btnThem/btnTru được bấm)
        private void OrderItemControl_QuantityChanged(object sender, OrderUpdateEventArgs e)
        {
            // Ở đây bạn có thể cập nhật Tổng hóa đơn của Form chính
            // Ví dụ: UpdateTotalOrder();
        }
        // Xử lý khi món ăn bị xóa (btnXoaMon được bấm)
        private void OrderItemControl_ItemRemoved(object sender, EventArgs e)
        {
            ThongTinDatMon removedControl = sender as ThongTinDatMon;
            if (removedControl != null && CurrentOrderItems != null)
            {
                // Xóa món ăn khỏi Dictionary quản lý
                CurrentOrderItems.Remove(removedControl.TenMon);

                // Cập nhật lại Tổng hóa đơn
                // UpdateTotalOrder();
            }
        }
    }
}
