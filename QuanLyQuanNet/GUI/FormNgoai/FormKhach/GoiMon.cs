using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyQuanNet.GUI.ViewDoAn;

namespace QuanLyQuanNet.GUI.FormNgoai.FormKhach
{
    public partial class GoiMon : Form
    {
        private const string connectionString = "Server=VINH; Database=QuanLyQuanNetDB; Integrated Security=True;";
        private Dictionary<string, ThongTinDatMon> currentOrderItems = new Dictionary<string, ThongTinDatMon>();
        public GoiMon()
        {
            InitializeComponent();
            LoadMenu();
            SetupCategoryFilters();
            // Gán sự kiện TextChanged
            this.textBoxTimMonAn.TextChanged += new EventHandler(this.textBoxTimMonAn_TextChanged);
        }
        // Gọi hàm này khi Form Load
        private void LoadMenu(string filterCategory = "Tất cả", string searchKeyword = "") // <<< ĐÃ THÊM THAM SỐ searchKeyword
        {
            // Xóa các controls cũ (nếu có) trước khi tải lại
            MenuDoAn.Controls.Clear();

            string query = "SELECT TenMon, Gia, HinhAnhPath, DanhMuc FROM ThucDon";

            // Khởi tạo danh sách các mệnh đề WHERE
            List<string> whereClauses = new List<string>();

            // 1. Xây dựng mệnh đề WHERE
            if (filterCategory != "Tất cả")
            {
                whereClauses.Add("DanhMuc = @Category");
            }

            // 2. BỔ SUNG LỌC THEO TỪ KHÓA TÌM KIẾM
            if (!string.IsNullOrEmpty(searchKeyword))
            {
                whereClauses.Add("TenMon LIKE @SearchKeyword");
            }

            // Xây dựng câu truy vấn hoàn chỉnh với các mệnh đề WHERE
            if (whereClauses.Count > 0)
            {
                query += " WHERE " + string.Join(" AND ", whereClauses);
            }
            // HẾT PHẦN XÂY DỰNG QUERY

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    // 3. Thêm tham số SQL
                    if (filterCategory != "Tất cả")
                    {
                        // Truyền giá trị Category được chọn
                        command.Parameters.AddWithValue("@Category", filterCategory);
                    }

                    // BỔ SUNG THAM SỐ TÌM KIẾM
                    if (!string.IsNullOrEmpty(searchKeyword))
                    {
                        // Sử dụng LIKE để tìm kiếm tương đối (chứa từ khóa)
                        command.Parameters.AddWithValue("@SearchKeyword", "%" + searchKeyword + "%");
                    }

                    try
                    {
                        connection.Open();
                        SqlDataReader reader = command.ExecuteReader();

                        while (reader.Read())
                        {
                            string tenMon = reader["TenMon"].ToString();
                            decimal gia = reader.GetDecimal(reader.GetOrdinal("Gia"));
                            string hinhAnhPath = reader["HinhAnhPath"].ToString();

                            // 1. Tạo một instance của User Control (DoAn.cs)
                            DoAn monAnControl = new DoAn();

                            // 2. Gán dữ liệu vào các controls con
                            monAnControl.labelTenDoAn.Text = tenMon;
                            monAnControl.labelGiaDoAn.Text = gia.ToString("N0") + " VNĐ";

                            // 3. Tải hình ảnh
                            try
                            {
                                string fullPath = System.IO.Path.Combine(Application.StartupPath, hinhAnhPath);
                                if (System.IO.File.Exists(fullPath))
                                {
                                    // *** Cải tiến: Tạo bản sao ảnh để tránh lỗi khóa file ***
                                    using (var stream = new System.IO.FileStream(fullPath, FileMode.Open, FileAccess.Read))
                                    {
                                        monAnControl.pictureBoxHinhAnh.Image = Image.FromStream(stream);
                                    }
                                    monAnControl.pictureBoxHinhAnh.SizeMode = PictureBoxSizeMode.Zoom;
                                }
                            }
                            catch (Exception imgEx)
                            {
                                Console.WriteLine("Lỗi tải ảnh: " + imgEx.Message);
                            }

                            // 4. Thêm User Control vào FlowLayoutPanel
                            MenuDoAn.Controls.Add(monAnControl);

                            // 5. GÁN SỰ KIỆN CLICK (ĐÃ SỬA LỖI CHUYỂN HƯỚNG)
                            monAnControl.Click += MonAn_Click; // Gán sự kiện cho chính UserControl

                            // ✅ BỔ SUNG QUAN TRỌNG: Gán sự kiện cho TẤT CẢ controls con
                            foreach (Control c in monAnControl.Controls)
                            {
                                c.Click += MonAn_Click;
                            }

                            // 6. Lưu thông tin quan trọng vào thuộc tính Tag của UserControl cha
                            monAnControl.Tag = new { TenMon = tenMon, Gia = gia };
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi tải thực đơn: " + ex.Message, "Lỗi CSDL", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
        // Gọi hàm này khi Form Load
        private void SetupCategoryFilters()
        {
            string[] categories = { "Tất cả", "Đồ ăn", "Đồ uống", "Tráng miệng" };

            foreach (string category in categories)
            {
                Button btn = new Button();
                btn.Text = category;
                btn.Tag = category; // Lưu giá trị category vào thuộc tính Tag

                btn.AutoSize = true;
                btn.Padding = new Padding(10, 5, 10, 5); // Tùy chỉnh kích thước
                btn.FlatStyle = FlatStyle.Flat;
                btn.FlatAppearance.BorderSize = 0;
                btn.Click += CategoryButton_Click; // Gán chung sự kiện Click

                // Thêm nút vào FlowLayoutPanel CagetoryMonAn
                CagetoryMonAn.Controls.Add(btn);
            }
        }
        // Xử lý sự kiện khi một nút phân loại được nhấn
        private void CategoryButton_Click(object sender, EventArgs e)
        {
            Button clickedButton = sender as Button;
            if (clickedButton != null)
            {
                string selectedCategory = clickedButton.Tag.ToString();

                // Gọi hàm tải menu với tham số phân loại
                LoadMenu(selectedCategory);
            }
        }
        private void MenuDoAn_Paint(object sender, PaintEventArgs e)
        {

        }

        private void GoiMon_Load(object sender, EventArgs e)
        {

        }
        private void MonAn_Click(object sender, EventArgs e)
        {
            Control clickedControl = sender as Control;
            if (clickedControl == null) return;

            // TÌM KIẾM USER CONTROL CHA (DoAn.cs)
            // Nếu control được bấm là DoAn, dùng chính nó. Nếu không, tìm cha.
            DoAn menuControl = clickedControl as DoAn;

            // Lặp qua các control cha cho đến khi tìm thấy DoAn.cs
            if (menuControl == null)
            {
                Control parentControl = clickedControl.Parent;
                while (parentControl != null)
                {
                    menuControl = parentControl as DoAn;
                    if (menuControl != null)
                    {
                        break;
                    }
                    parentControl = parentControl.Parent;
                }
            }

            // 3. Kiểm tra và lấy thông tin món ăn
            if (menuControl?.Tag == null) return;

            // Lấy thông tin đã lưu trong Tag của UserControl cha
            dynamic itemInfo = menuControl.Tag;
            string tenMon = itemInfo.TenMon;
            decimal giaDonVi = itemInfo.Gia;

            // Gọi hàm thêm/cập nhật món ăn
            AddOrUpdateOrderItem(tenMon, giaDonVi);
        }
        private void AddOrUpdateOrderItem(string tenMon, decimal giaDonVi)
        {
            if (currentOrderItems.ContainsKey(tenMon))
            {
                // Nếu món đã có trong đơn hàng: Tăng số lượng (bấm nút btnThem của control đó)
                currentOrderItems[tenMon].btnThem.PerformClick();
            }
            else
            {
                // Nếu món chưa có: Tạo mới User Control ThongTinDatMon
                ThongTinDatMon orderItemControl = new ThongTinDatMon();
                orderItemControl.InitializeItem(tenMon, giaDonVi);

                // Đăng ký sự kiện cập nhật số lượng
                orderItemControl.QuantityChanged += OrderItemControl_QuantityChanged;
                // Đăng ký sự kiện xóa
                orderItemControl.ItemRemoved += OrderItemControl_ItemRemoved;


                // Lưu trữ và hiển thị
                currentOrderItems.Add(tenMon, orderItemControl);
                ListMonAnDat.Controls.Add(orderItemControl);
            }
            // Rất quan trọng: Cập nhật tổng tiền ngay khi thêm/tăng món lần đầu
            UpdateTotalOrder();
        }

        private void OrderItemControl_ItemRemoved(object sender, EventArgs e)
        {
            ThongTinDatMon removedControl = sender as ThongTinDatMon;
            if (removedControl != null)
            {
                // Xóa món ăn khỏi Dictionary quản lý
                currentOrderItems.Remove(removedControl.TenMon);

                // Cập nhật lại Tổng hóa đơn
                UpdateTotalOrder();
            }
        }

        // Add this method to your GoiMon class
        private void OrderItemControl_QuantityChanged(object sender, ThongTinDatMon.OrderUpdateEventArgs e)
        {
            UpdateTotalOrder();
        }
        private void UpdateTotalOrder()
        {
            decimal tongTien = 0;

            // Lặp qua tất cả các User Control món ăn trong Dictionary
            foreach (var itemControl in currentOrderItems.Values)
            {
                // Tính tổng tiền: Đơn giá * Số lượng
                // Giả định bạn có thể truy cập Số lượng và GiaDonVi từ User Control
                int soLuong = int.Parse(itemControl.SoLuong.Text); // Lấy số lượng từ Label SoLuong
                decimal giaDonVi = itemControl.GiaDonVi;           // Lấy đơn giá từ thuộc tính Public

                tongTien += (giaDonVi * soLuong);
            }

            // Hiển thị tổng tiền lên Label
            labelTongTien.Text = tongTien.ToString("N0") + " VNĐ";
        }
        private void textBoxTimMonAn_TextChanged(object sender, EventArgs e)
        {
            string keyword = textBoxTimMonAn.Text.Trim();

            // Giả định bạn có biến string currentCategory để giữ trạng thái lọc hiện tại
            // Nếu không, chỉ cần gọi LoadMenu("Tất cả", keyword)

            // Ví dụ gọi:
            LoadMenu("Tất cả", keyword);
        }
    }
}
