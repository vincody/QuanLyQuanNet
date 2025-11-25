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
    public partial class KhoQL : Form
    {
        private const string connectionString = "Server=VINH; Database=QuanLyQuanNetDB; Integrated Security=True;";
        public KhoQL()
        {
            InitializeComponent();
        }
        private void KhoQL_Load(object sender, EventArgs e)
        {
            LoadKhoData();
        }
        private void LoadKhoData()
        {
            // 1. Truy vấn lấy dữ liệu theo thứ tự mong muốn
            string query = @"
                SELECT 
                    NguyenLieuID, 
                    DanhMuc, 
                    TenNguyenLieu, 
                    GiaNhap, 
                    DonViTinh, 
                    SoLuongTon 
                FROM NguyenLieu";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    try
                    {
                        connection.Open();
                        SqlDataAdapter adapter = new SqlDataAdapter(command);
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);

                        // ✅ ĐÃ SỬA TÊN CONTROL
                        DatagridviewKhoQL.DataSource = dt;

                        // 2. Định dạng hiển thị DataGridView
                        FormatKhoGrid();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi tải dữ liệu kho: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
        private void FormatKhoGrid()
        {
            // ✅ ĐÃ SỬA TÊN CONTROL (Thay thế toàn bộ DatagridviewKhoQL bằng DatagridviewKhoQL)
            if (DatagridviewKhoQL.DataSource == null) return;

            // Cấu hình giao diện chung

            // --- ĐỊNH DẠNG CỘT ---

            // 1. ID (NguyenLieuID)
            DatagridviewKhoQL.Columns["NguyenLieuID"].HeaderText = "ID";


            // 2. Nhóm (DanhMuc)
            DatagridviewKhoQL.Columns["DanhMuc"].HeaderText = "Nhóm";

            // 3. Tên (TenNguyenLieu)
            DatagridviewKhoQL.Columns["TenNguyenLieu"].HeaderText = "Tên";


            // 4. Giá (GiaNhap)
            DatagridviewKhoQL.Columns["GiaNhap"].HeaderText = "Giá nhập";
            DatagridviewKhoQL.Columns["GiaNhap"].Width = 75;
            DatagridviewKhoQL.Columns["GiaNhap"].DefaultCellStyle.Format = "N0"; // Định dạng tiền tệ (ví dụ: 10,000)

            // 5. Đơn vị (DonViTinh)
            DatagridviewKhoQL.Columns["DonViTinh"].HeaderText = "Đơn vị";

            // 6. Số lượng trong (SoLuongTon)
            DatagridviewKhoQL.Columns["SoLuongTon"].HeaderText = "Số lượng";

        }

        private void btnNhapKho_Click(object sender, EventArgs e)
        {
            NhapKho formNhap = new NhapKho();
            formNhap.ShowDialog(); // Dùng ShowDialog để dừng Form cha lại

            // Sau khi đóng form nhập, tải lại dữ liệu để thấy thay đổi
            LoadKhoData();
        }

        private void btnSuaThongTin_Click(object sender, EventArgs e)
        {
            // Kiểm tra xem có dòng nào được chọn không
            if (DatagridviewKhoQL.SelectedRows.Count == 1)
            {
                // Lấy dữ liệu từ dòng đang chọn
                DataGridViewRow row = DatagridviewKhoQL.SelectedRows[0];

                // Đọc dữ liệu từ các cột (chú ý ép kiểu đúng)
                // Lưu ý: Tên cột ("NguyenLieuID",...) phải khớp với DataPropertyName bạn đã đặt
                int id = Convert.ToInt32(row.Cells["NguyenLieuID"].Value);
                string ten = row.Cells["TenNguyenLieu"].Value.ToString();
                string nhom = row.Cells["DanhMuc"].Value.ToString();
                decimal gia = Convert.ToDecimal(row.Cells["GiaNhap"].Value);
                string donVi = row.Cells["DonViTinh"].Value.ToString();
                int soLuong = Convert.ToInt32(row.Cells["SoLuongTon"].Value);

                // Mở Form Sửa và truyền dữ liệu
                SuaThongTinKho formSua = new SuaThongTinKho(id, ten, nhom, gia, donVi, soLuong);
                formSua.ShowDialog();

                // Tải lại dữ liệu sau khi sửa
                LoadKhoData();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một dòng nguyên liệu để sửa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
