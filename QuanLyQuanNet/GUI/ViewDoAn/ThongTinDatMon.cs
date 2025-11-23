using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing; // Cần cho Image
using System.IO;      // Cần cho FileStream, Path
using System.Windows.Forms;
using System.Runtime.Serialization; // Add this for serialization attributes

namespace QuanLyQuanNet.GUI.ViewDoAn
{
    [Serializable] // Add this attribute to enable serialization for the class
    public partial class ThongTinDatMon : UserControl
    {
        // Các thuộc tính công khai
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        [Browsable(true)]
        [Bindable(true)]
        public string TenMon { get; set; }
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        [Browsable(true)]
        [Bindable(true)]
        public decimal GiaDonVi { get; set; }
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        [Browsable(true)]
        [Bindable(true)]
        public int MonAnID { get; set; }

        private int _soLuong = 1;

        public event EventHandler<OrderUpdateEventArgs> QuantityChanged;
        public event EventHandler ItemRemoved;

        public ThongTinDatMon()
        {
            InitializeComponent();
        }

        // ✅ ĐÃ SỬA: Thêm tham số 'hinhAnhPath'
        public void InitializeItem(int monAnID, string tenMon, decimal giaDonVi, string hinhAnhPath)
        {
            this.MonAnID = monAnID;
            this.TenMon = tenMon;
            this.GiaDonVi = giaDonVi;

            // --- LOGIC TẢI ẢNH ---
            if (!string.IsNullOrEmpty(hinhAnhPath))
            {
                try
                {
                    string fullPath = Path.Combine(Application.StartupPath, hinhAnhPath);
                    if (File.Exists(fullPath))
                    {
                        // Dùng FileStream để không khóa file ảnh
                        using (var stream = new FileStream(fullPath, FileMode.Open, FileAccess.Read))
                        {
                            pictureBoxHienThiAnh.Image = Image.FromStream(stream);
                        }
                        pictureBoxHienThiAnh.SizeMode = PictureBoxSizeMode.Zoom;
                    }
                }
                catch (Exception)
                {
                    // Nếu lỗi tải ảnh, có thể gán ảnh mặc định hoặc để trống
                    pictureBoxHienThiAnh.Image = null;
                }
            }
            // ---------------------

            UpdateDisplay();
        }

        private void UpdateDisplay()
        {
            labelTenMon.Text = this.TenMon;
            labelGiaTien.Text = (this.GiaDonVi * _soLuong).ToString("N0") + " VNĐ";
            SoLuong.Text = _soLuong.ToString();

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
            ItemRemoved?.Invoke(this, EventArgs.Empty);
            this.Dispose();
        }

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
    }
}