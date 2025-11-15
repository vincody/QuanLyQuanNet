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

namespace QuanLyQuanNet.GUI.FormNgoai.FormAdmin
{
    public partial class MenuDA : Form
    {
        private const string connectionString = "Server=VINH; Database=QuanLyQuanNetDB; Integrated Security=True;";
        public MenuDA()
        {
            InitializeComponent();
  
        }
        // Gọi hàm này khi Form Load
        private void LoadMenuData(string searchKeyword = null)
        {
            // Truy vấn lấy tất cả các cột cần thiết (MonAnID là bắt buộc để truy vấn ảnh sau này)
            string query = "SELECT MonAnID, TenMon, DanhMuc, Gia, HinhAnhPath FROM ThucDon";

            // Thêm điều kiện tìm kiếm nếu có từ khóa
            if (!string.IsNullOrEmpty(searchKeyword))
            {
                // Thêm WHERE hoặc AND nếu đã có điều kiện khác
                // Giả sử chỉ có điều kiện WHERE cho tìm kiếm
                query += " WHERE TenMon LIKE @Keyword";
            }
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    if (!string.IsNullOrEmpty(searchKeyword))
                    {
                        // Thêm tham số tìm kiếm
                        command.Parameters.AddWithValue("@Keyword", "%" + searchKeyword + "%");
                    }
                    try
                    {
                        connection.Open();
                        SqlDataAdapter adapter = new SqlDataAdapter(command);
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);

                        dataGridViewMenu.DataSource = dt;

                        // Định dạng và sắp xếp Grid
                        FormatMenuGrid();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi tải dữ liệu thực đơn: " + ex.Message, "Lỗi CSDL", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
        // Hàm này căn chỉnh và đặt tên header theo yêu cầu
        private void FormatMenuGrid()
        {
            if (dataGridViewMenu.DataSource == null) return;

            // Ẩn các cột không cần thiết và định dạng Header
            dataGridViewMenu.RowHeadersVisible = false;
            dataGridViewMenu.SelectionMode = DataGridViewSelectionMode.FullRowSelect; // Chọn toàn bộ dòng
            dataGridViewMenu.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            // Ẩn tất cả các cột ban đầu
            foreach (DataGridViewColumn col in dataGridViewMenu.Columns)
            {
                col.Visible = false;
            }

            // Tên món ăn (TenMon) - Index 0
            dataGridViewMenu.Columns["TenMon"].Visible = true;
            dataGridViewMenu.Columns["TenMon"].DisplayIndex = 0;
            dataGridViewMenu.Columns["TenMon"].HeaderText = "Tên Món";
            dataGridViewMenu.Columns["TenMon"].SortMode = DataGridViewColumnSortMode.NotSortable;

            // Danh mục (DanhMuc) - Index 1
            dataGridViewMenu.Columns["DanhMuc"].Visible = true;
            dataGridViewMenu.Columns["DanhMuc"].DisplayIndex = 1;
            dataGridViewMenu.Columns["DanhMuc"].HeaderText = "Phân loại";
            dataGridViewMenu.Columns["DanhMuc"].SortMode = DataGridViewColumnSortMode.NotSortable;

            // Giá (Gia) - Index 2
            dataGridViewMenu.Columns["Gia"].Visible = true;
            dataGridViewMenu.Columns["Gia"].DisplayIndex = 2;
            dataGridViewMenu.Columns["Gia"].HeaderText = "Giá (VNĐ)";
            dataGridViewMenu.Columns["Gia"].DefaultCellStyle.Format = "N0";
            dataGridViewMenu.Columns["Gia"].SortMode = DataGridViewColumnSortMode.NotSortable;

            // Ẩn các cột hỗ trợ (MonAnID, HinhAnhPath)
            // MonAnID và HinhAnhPath đã được tải nhưng vẫn ẩn
            if (dataGridViewMenu.Columns.Contains("MonAnID"))
                dataGridViewMenu.Columns["MonAnID"].Visible = false;
            if (dataGridViewMenu.Columns.Contains("HinhAnhPath"))
                dataGridViewMenu.Columns["HinhAnhPath"].Visible = false;
        }
        private void dataGridViewMenu_SelectionChanged(object sender, EventArgs e)
        {
            // Đảm bảo chỉ xử lý khi CÓ một dòng được chọn
            if (dataGridViewMenu.SelectedRows.Count == 1)
            {
                DataGridViewRow selectedRow = dataGridViewMenu.SelectedRows[0];

                // Lấy giá trị của các cột cần thiết
                object tenMonValue = selectedRow.Cells["TenMon"].Value;
                object giaValue = selectedRow.Cells["Gia"].Value;
                object danhMucValue = selectedRow.Cells["DanhMuc"].Value;
                object pathValue = selectedRow.Cells["HinhAnhPath"].Value;

                // --- 1. HIỂN THỊ DỮ LIỆU VÀO TEXTBOXES ---

                // Gán Tên món ăn
                textBoxTenMA.Text = tenMonValue?.ToString() ?? "";

                // Gán Phân loại
                textBoxPL.Text = danhMucValue?.ToString() ?? "";

                // Gán Giá (và định dạng tiền tệ)
                if (giaValue != null && giaValue != DBNull.Value)
                {
                    decimal gia = Convert.ToDecimal(giaValue);
                    // Hiển thị giá có định dạng tiền tệ
                    textBoxGia.Text = gia.ToString("N0") + " VNĐ";
                }
                else
                {
                    textBoxGia.Text = "0 VNĐ";
                }


                // --- 2. TẢI ẢNH (Logic cũ) ---

                string hinhAnhPath = (pathValue != null && pathValue != DBNull.Value) ? pathValue.ToString() : null;

                if (!string.IsNullOrEmpty(hinhAnhPath))
                {
                    try
                    {
                        string fullPath = Path.Combine(Application.StartupPath, hinhAnhPath);

                        if (File.Exists(fullPath))
                        {
                            // Tạo bản sao ảnh để tránh lỗi khóa file
                            using (var stream = new FileStream(fullPath, FileMode.Open, FileAccess.Read))
                            {
                                pictureBoxMenu.Image = Image.FromStream(stream);
                            }
                            pictureBoxMenu.SizeMode = PictureBoxSizeMode.Zoom;
                        }
                        else
                        {
                            pictureBoxMenu.Image = null;
                        }
                    }
                    catch (Exception ex)
                    {
                        // Xử lý lỗi tải ảnh
                        pictureBoxMenu.Image = null;
                    }
                }
                else
                {
                    pictureBoxMenu.Image = null; // Xóa ảnh nếu không có đường dẫn
                }
            }
            else
            {
                // Xóa nội dung TextBox và PictureBox nếu không có dòng nào được chọn
                textBoxTenMA.Text = "";
                textBoxGia.Text = "";
                textBoxPL.Text = "";
                pictureBoxMenu.Image = null;
            }
        }

        // Gọi hàm này khi Form Load
        private void Menu_Load(object sender, EventArgs e)
        {
            LoadMenuData();
            // Gán sự kiện SelectionChanged (nếu chưa gán trong Designer)
            this.dataGridViewMenu.SelectionChanged += new EventHandler(this.dataGridViewMenu_SelectionChanged);
        }
        private void textBoxTimKiem_TextChanged(object sender, EventArgs e)
        {
            string keyword = textBoxTimKiem.Text;

            // Gọi hàm tải dữ liệu với từ khóa mới
            LoadMenuData(keyword);
        }

    }
}
