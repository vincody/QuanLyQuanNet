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
    public partial class LSMay : Form
    {
        private const string connectionString = "Server=VINH; Database=QuanLyQuanNetDB; Integrated Security=True;";
        public LSMay()
        {
            InitializeComponent();
            this.Load += LSMay_Load;
        }
        private void LSMay_Load(object sender, EventArgs e)
        {
            LoadOrderHistory();
        }
        private void LoadOrderHistory()
        {
            // Câu truy vấn JOIN 2 bảng DonDatMon (DDM) và Users (U) để lấy Tên khách hàng (HoTen)
            string query = @"
        SELECT
            DDM.DonDatID,
            T.HoTen, -- Lấy tên khách hàng từ bảng TaiKhoan
            DDM.TenMay,
            DDM.PhuongThucTT,
            DDM.TongTien,
            DDM.TrangThai,
            DDM.NgayDat
        FROM
            DonDatMon DDM
        JOIN
            TaiKhoan T ON DDM.TaiKhoanID = T.TaiKhoanID -- ✅ Dùng TaiKhoan để JOIN
        ORDER BY
            DDM.NgayDat DESC;
    ";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                    DataTable dataTable = new DataTable();

                    adapter.Fill(dataTable);

                    // Gán dữ liệu vào DataGridView
                    dataGridViewLSOrder.DataSource = dataTable;

                    // Thiết lập tiêu đề cột tiếng Việt theo yêu cầu
                    SetDataGridViewHeaders();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi truy vấn lịch sử đơn hàng: " + ex.Message, "Lỗi CSDL", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void SetDataGridViewHeaders()
        {
            // Đặt tên tiêu đề (Header Text) cho các cột hiển thị
            if (dataGridViewLSOrder.Columns.Contains("DonDatID"))
                dataGridViewLSOrder.Columns["DonDatID"].HeaderText = "Mã đơn";

            if (dataGridViewLSOrder.Columns.Contains("HoTen"))
                dataGridViewLSOrder.Columns["HoTen"].HeaderText = "Tên khách hàng";

            if (dataGridViewLSOrder.Columns.Contains("TenMay"))
                dataGridViewLSOrder.Columns["TenMay"].HeaderText = "Máy đặt";

            if (dataGridViewLSOrder.Columns.Contains("PhuongThucTT"))
                dataGridViewLSOrder.Columns["PhuongThucTT"].HeaderText = "Phương thức TT";

            if (dataGridViewLSOrder.Columns.Contains("TongTien"))
                dataGridViewLSOrder.Columns["TongTien"].HeaderText = "Tổng tiền";

            if (dataGridViewLSOrder.Columns.Contains("TrangThai"))
                dataGridViewLSOrder.Columns["TrangThai"].HeaderText = "Trạng thái";

            if (dataGridViewLSOrder.Columns.Contains("NgayDat"))
                dataGridViewLSOrder.Columns["NgayDat"].HeaderText = "Ngày đặt đơn";
        }

        private void btnXemDonDatMon_Click(object sender, EventArgs e)
        {
            if (dataGridViewLSOrder.SelectedRows.Count != 1)
            {
                MessageBox.Show("Vui lòng chọn một đơn hàng để xem chi tiết.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Lấy DonDatID từ hàng đang chọn (Giả định cột này đã được tải vào DataGridView)
            DataGridViewRow selectedRow = dataGridViewLSOrder.SelectedRows[0];

            // ✅ SỬA LỖI: KIỂM TRA SỰ TỒN TẠI CỦA CỘT TRONG DATAGRIDVIEW
            if (!dataGridViewLSOrder.Columns.Contains("DonDatID"))
            {
                MessageBox.Show("Lỗi: Không tìm thấy Mã đơn (DonDatID) trong DataGridView. Vui lòng kiểm tra lại truy vấn SQL.", "Lỗi CSDL", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Lấy DonDatID từ ô đó (Đã hợp lệ)
            int donDatID = Convert.ToInt32(selectedRow.Cells["DonDatID"].Value);

            // Mở Form ChiTietOrderMon và truyền ID
            ChiTietOrderMon formChiTiet = new ChiTietOrderMon(donDatID);
            formChiTiet.ShowDialog();

            // Tải lại lịch sử đơn hàng sau khi Form chi tiết đóng (để cập nhật trạng thái)
            LoadOrderHistory();
        }
    }
}
