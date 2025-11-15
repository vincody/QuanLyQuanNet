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
    public partial class KHang : Form
    {
        private const string connectionString = "Server=VINH; Database=QuanLyQuanNetDB; Integrated Security=True;";

        public KHang()
        {
            InitializeComponent();
            btnSuaThongTin.Enabled = false;
            this.dataGridViewTK.SelectionChanged += new EventHandler(this.dataGridViewTK_SelectionChanged);
        }
        // Hàm xử lý khi hàng được chọn/bỏ chọn
        private void dataGridViewTK_SelectionChanged(object sender, EventArgs e)
        {
            // Kích hoạt nút nếu có ít nhất một hàng được chọn
            btnSuaThongTin.Enabled = dataGridViewTK.SelectedRows.Count == 1;
        }

        // Hàm này được gọi khi Form Load
        private void LoadDataIntoGrid(string sdtFilter = null)
        {
            // 1. Xây dựng truy vấn SQL
            string query = "SELECT TaiKhoanID, TenDangNhap, HoTen, SDT, CCCD, SoDu FROM TaiKhoan";

            // Chỉ lấy các tài khoản có isKhach = 1 (Tùy chọn)
            query += " WHERE isKhach = 1";

            // Thêm điều kiện tìm kiếm nếu có
            if (!string.IsNullOrEmpty(sdtFilter))
            {
                query += " AND SDT LIKE @SDTFilter";
            }

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    if (!string.IsNullOrEmpty(sdtFilter))
                    {
                        // ✅ SỬA LỖI TRUY VẤN:
                        // 1. Dùng SqlDbType.NVarChar để báo cho SQL Server biết đây là chuỗi Unicode.
                        // 2. Thêm tiền tố N nếu dùng kiểu khác (nhưng dùng Parameters tốt hơn).
                        // 3. Đảm bảo sử dụng tham số (@SDTFilter) một cách rõ ràng.

                        command.Parameters.Add("@SDTFilter", SqlDbType.NVarChar).Value = "%" + sdtFilter + "%";
                    }

                    try
                    {
                        connection.Open();
                        SqlDataAdapter adapter = new SqlDataAdapter(command);
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);

                        // Gán dữ liệu vào DataGridView
                        dataGridViewTK.DataSource = dt;

                        // 2. Định dạng cột và sắp xếp thứ tự hiển thị
                        FormatAndOrderGrid();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi tải dữ liệu khách hàng: " + ex.Message, "Lỗi CSDL", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        // Hàm này căn chỉnh và đặt tên header theo yêu cầu
        private void FormatAndOrderGrid()
        {
            // Kiểm tra DataGridView có dữ liệu chưa
            if (dataGridViewTK.DataSource == null) return;

            // 1. Ẩn tất cả các cột ban đầu
            foreach (DataGridViewColumn col in dataGridViewTK.Columns)
            {
                col.Visible = false;
            }
            // BỔ SUNG: Ẩn cột TaiKhoanID
            if (dataGridViewTK.Columns.Contains("TaiKhoanID"))
            {
                dataGridViewTK.Columns["TaiKhoanID"].Visible = false;
            }

            // 2. Hiển thị lại các cột theo thứ tự và đặt tên header

            // Tên đăng nhập (TenDangNhap) - Cột 0
            dataGridViewTK.Columns["TenDangNhap"].Visible = true;
            dataGridViewTK.Columns["TenDangNhap"].DisplayIndex = 0;
            dataGridViewTK.Columns["TenDangNhap"].HeaderText = "Tên Đăng Nhập";

            // Họ tên (HoTen) - Cột 1
            dataGridViewTK.Columns["HoTen"].Visible = true;
            dataGridViewTK.Columns["HoTen"].DisplayIndex = 1;
            dataGridViewTK.Columns["HoTen"].HeaderText = "Họ Tên";

            // SĐT (SDT) - Cột 2
            dataGridViewTK.Columns["SDT"].Visible = true;
            dataGridViewTK.Columns["SDT"].DisplayIndex = 2;
            dataGridViewTK.Columns["SDT"].HeaderText = "SĐT";

            // 3: CCCD (CCCD)  <<< CỘT MỚI
            dataGridViewTK.Columns["CCCD"].Visible = true;
            dataGridViewTK.Columns["CCCD"].DisplayIndex = 3;
            dataGridViewTK.Columns["CCCD"].HeaderText = "CCCD";

            // Số dư (SoDu) - Cột 4
            dataGridViewTK.Columns["SoDu"].Visible = true;
            dataGridViewTK.Columns["SoDu"].DisplayIndex = 4;
            dataGridViewTK.Columns["SoDu"].HeaderText = "Số Dư";
            dataGridViewTK.Columns["SoDu"].DefaultCellStyle.Format = "N0"; // Định dạng tiền tệ
        }

        // Hàm này nên được gọi trong sự kiện Form_Load
        private void KHang_Load(object sender, EventArgs e)
        {
            LoadDataIntoGrid();
        }
        private void textBoxSDT_TextChanged(object sender, EventArgs e)
        {
            string filterText = textBoxSDT.Text.Trim();

            // Gọi lại hàm LoadDataIntoGrid với chuỗi tìm kiếm
            LoadDataIntoGrid(filterText);
        }

        private void btnThemTaiKhoan_Click(object sender, EventArgs e)
        {
            ThemTaiKhoan formThem = new ThemTaiKhoan();
            formThem.ShowDialog();

            // Tải lại DataGridView sau khi tạo tài khoản thành công
            LoadDataIntoGrid();
        }

        private void btnSuaThongTin_Click(object sender, EventArgs e)
        {
            if (dataGridViewTK.SelectedRows.Count == 1)
            {
                // 1. Lấy dữ liệu từ hàng đang chọn
                DataGridViewRow selectedRow = dataGridViewTK.SelectedRows[0];

                // 2. Tạo một đối tượng chứa dữ liệu để truyền đi
                TaiKhoanData data = new TaiKhoanData
                {
                    // Sử dụng Convert.ToInt32 để xử lý an toàn hơn so với casting trực tiếp (int)
                    TaiKhoanID = Convert.ToInt32(selectedRow.Cells["TaiKhoanID"].Value),
                    TenDangNhap = selectedRow.Cells["TenDangNhap"].Value.ToString(),
                    HoTen = selectedRow.Cells["HoTen"].Value.ToString(),
                    CCCD = selectedRow.Cells["CCCD"].Value.ToString(),
                    SDT = selectedRow.Cells["SDT"].Value.ToString(),
                    SoDu = Convert.ToDecimal(selectedRow.Cells["SoDu"].Value)
                };

                // 3. Mở Form và truyền dữ liệu
                SuaThongTin formSua = new SuaThongTin(data);
                formSua.ShowDialog();

                // Tải lại DataGridView sau khi sửa thông tin
                LoadDataIntoGrid();
            }
        }
    }
}
