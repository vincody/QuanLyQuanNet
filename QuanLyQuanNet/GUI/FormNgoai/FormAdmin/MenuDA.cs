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

        private void btnThemMon_Click(object sender, EventArgs e)
        {
            // Tạo một instance mới của Form ThemMonAn
            ThemMonAn themMonForm = new ThemMonAn();

            // Hiển thị Form ThemMonAn và chờ nó đóng
            DialogResult result = themMonForm.ShowDialog();

            // Kiểm tra kết quả trả về từ form ThemMonAn
            // Nếu kết quả là DialogResult.OK (đã thêm thành công và đóng form)
            if (result == DialogResult.OK)
            {
                // ***** MÃ CẬP NHẬT DỮ LIỆU ĐƯỢC THÊM VÀO ĐÂY *****

                // Gọi hàm để tải lại hoặc làm mới danh sách món ăn trên form MenuDA này.
                // BẠN CẦN THAY THẾ LoadDataMonAn() bằng tên hàm tải dữ liệu thực tế của bạn.
                LoadMenuData();

                // Ví dụ, nếu bạn dùng DataGridView có tên dgvMonAn:
                // dgvMonAn.Refresh(); 
            }
        }

        private void btnSuaChiTietMon_Click(object sender, EventArgs e)
        {
            if (dataGridViewMenu.SelectedRows.Count > 0)
            {
                // 1. Lấy dữ liệu từ dòng được chọn
                DataGridViewRow selectedRow = dataGridViewMenu.SelectedRows[0];

                try
                {
                    MonAnModel monAnSua = new MonAnModel
                    {
                        // Đảm bảo tên cột khớp với tên cột trong SQL SELECT
                        MonAnID = Convert.ToInt32(selectedRow.Cells["MonAnID"].Value),
                        TenMon = selectedRow.Cells["TenMon"].Value.ToString(),
                        Gia = Convert.ToDecimal(selectedRow.Cells["Gia"].Value),
                        DanhMuc = selectedRow.Cells["DanhMuc"].Value.ToString(),
                        HinhAnhPath = selectedRow.Cells["HinhAnhPath"].Value.ToString()
                    };

                    // 2. Mở form SuaMonAn và truyền dữ liệu
                    SuaMonAn suaForm = new SuaMonAn(monAnSua);
                    DialogResult result = suaForm.ShowDialog();

                    // 3. Nếu sửa thành công, làm mới DataGridView
                    if (result == DialogResult.OK)
                    {
                        // Gọi hàm nạp lại dữ liệu của bạn
                        LoadMenuData(); // THAY THẾ LoadMenuData() bằng tên hàm của bạn
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Lỗi khi lấy dữ liệu từ DataGridView: {ex.Message}. Vui lòng kiểm tra lại tên cột và kiểu dữ liệu.", "Lỗi dữ liệu");
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một món ăn để sửa.", "Cảnh báo");
            }
        }

        private void btnXoaMonAn_Click(object sender, EventArgs e)
        {
            // 1. Kiểm tra xem người dùng đã chọn dòng nào chưa
            if (dataGridViewMenu.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn một món ăn để xóa.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Lấy thông tin món ăn được chọn
            DataGridViewRow selectedRow = dataGridViewMenu.SelectedRows[0];

            try
            {
                int monAnID = Convert.ToInt32(selectedRow.Cells["MonAnID"].Value);
                string tenMon = selectedRow.Cells["TenMon"].Value.ToString();

                // 2. HIỆN THỊ HỘP THOẠI XÁC NHẬN
                DialogResult dialogResult = MessageBox.Show(
                    $"Bạn có chắc chắn muốn xóa món ăn '{tenMon}' không?",
                    "Xác nhận xóa món ăn",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                // 3. THỰC HIỆN XÓA NẾU NGƯỜI DÙNG CHỌN CÓ (Yes)
                if (dialogResult == DialogResult.Yes)
                {
                    XoaMonAnTrongDatabase(monAnID, tenMon);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi lấy dữ liệu món ăn: {ex.Message}. Vui lòng kiểm tra lại DataGridView.", "Lỗi dữ liệu");
            }
        }
        // Thêm phương thức để thực hiện kết nối và xóa Database
        private void XoaMonAnTrongDatabase(int monAnID, string tenMon)
        {
            

            // Câu lệnh DELETE SQL
            string query = "DELETE FROM ThucDon WHERE MonAnID = @MonAnID";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@MonAnID", monAnID);

                try
                {
                    connection.Open();
                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show($"Đã xóa món ăn '{tenMon}' thành công.", "Hoàn tất", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // 4. LÀM MỚI DATAGRIDVIEW
                        LoadMenuData(); // Gọi hàm nạp lại dữ liệu của bạn để cập nhật DataGridView
                    }
                    else
                    {
                        MessageBox.Show($"Không tìm thấy món ăn có ID {monAnID} để xóa.", "Lỗi xóa", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                catch (SqlException ex)
                {
                    MessageBox.Show($"Lỗi Database khi xóa: {ex.Message}", "Lỗi CSDL", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Lỗi không xác định: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
