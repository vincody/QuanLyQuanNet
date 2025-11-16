using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyQuanNet.GUI.FormNgoai.FormAdmin
{
    public partial class SuaMonAn : Form
    {
        private const string connectionString = "Server=VINH; Database=QuanLyQuanNetDB; Integrated Security=True;";
        public SuaMonAn()
        {
            InitializeComponent();
            this.Text = "";
            this.ControlBox = false;
        }
        // drag form
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        //

        private MonAnModel MonAnHienTai;
        private string duongDanAnhDeLuuDB = "";

        // Khai báo lại các biến đường dẫn
        private readonly string ThuMucImages;
        private readonly string ThuMucOutputImages;
        // Hàm tạo nhận đối tượng MonAnModel
        public SuaMonAn(MonAnModel monAnCanSua)
        {
            InitializeComponent();
            MonAnHienTai = monAnCanSua;

            // --- 1. KHỞI TẠO ĐƯỜNG DẪN (Giống ThemMonAn) ---
            string duongDanHienTai = Application.StartupPath;
            DirectoryInfo thuMucGoc =
                Directory.GetParent(duongDanHienTai).Parent.Parent.Parent;

            ThuMucImages = Path.Combine(thuMucGoc.FullName, "Images");
            ThuMucOutputImages = Path.Combine(Application.StartupPath, "Images");

            if (!Directory.Exists(ThuMucImages))
            {
                Directory.CreateDirectory(ThuMucImages);
            }
            if (!Directory.Exists(ThuMucOutputImages))
            {
                Directory.CreateDirectory(ThuMucOutputImages);
            }
            // ----------------------------------------------------

            // Khởi tạo ComboBox
            comboBoxPhanLoai.Items.Add("Đồ ăn");
            comboBoxPhanLoai.Items.Add("Đồ uống");

            // Load dữ liệu lên controls
            LoadThongTinMonAn();
        }
        private void LoadThongTinMonAn()
        {
            // 1. Hiển thị thông tin cơ bản
            textBoxTenMA.Text = MonAnHienTai.TenMon;
            textBoxGiaMonAn.Text = MonAnHienTai.Gia.ToString();
            comboBoxPhanLoai.Text = MonAnHienTai.DanhMuc;

            // Khởi tạo duongDanAnhDeLuuDB bằng đường dẫn cũ
            duongDanAnhDeLuuDB = MonAnHienTai.HinhAnhPath;

            // 2. Hiển thị ảnh cũ bằng logic tải an toàn
            string tenAnhDB = MonAnHienTai.HinhAnhPath;

            // Xây dựng đường dẫn tuyệt đối (đọc từ thư mục Output/Images)
            string fullPath = Path.Combine(ThuMucOutputImages, Path.GetFileName(tenAnhDB));

            if (File.Exists(fullPath))
            {
                try
                {
                    using (var stream = new MemoryStream(File.ReadAllBytes(fullPath)))
                    {
                        Image img = Image.FromStream(stream);
                        // Sử dụng Bitmap Clone để tránh khóa tệp
                        pictureBoxAnhMonAn.Image = new Bitmap(img);
                        img.Dispose();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi tải ảnh cũ: " + ex.Message, "Lỗi Ảnh");
                    pictureBoxAnhMonAn.Image = null;
                }
            }
            else
            {
                // 
                pictureBoxAnhMonAn.Image = null; // Hoặc gán ảnh mặc định
            }
        }

        private void btnSuaAnhMA_Click(object sender, EventArgs e)
        {
            // Logic giống hệt ThemMonAn, đảm bảo sao chép kép và tải an toàn
            string downloadPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile), "Downloads");
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Directory.Exists(downloadPath) ? downloadPath : Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);
            openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string duongDanGoc = openFileDialog.FileName;
                string tenTep = Path.GetFileName(duongDanGoc);
                string duongDanDichProject = Path.Combine(ThuMucImages, tenTep);
                string duongDanDichOutput = Path.Combine(ThuMucOutputImages, tenTep);

                try
                {
                    // Tải ảnh an toàn vào bộ nhớ
                    Image loadedImage;
                    using (var stream = new MemoryStream(File.ReadAllBytes(duongDanGoc)))
                    {
                        Image img = Image.FromStream(stream);
                        loadedImage = new Bitmap(img);
                        img.Dispose();
                    }

                    // Giải phóng ảnh cũ trước khi ghi đè
                    if (pictureBoxAnhMonAn.Image != null)
                    {
                        pictureBoxAnhMonAn.Image.Dispose();
                        pictureBoxAnhMonAn.Image = null;
                    }

                    // Sao chép kép
                    File.Copy(duongDanGoc, duongDanDichProject, true);
                    File.Copy(duongDanGoc, duongDanDichOutput, true);

                    // Hiển thị và cập nhật đường dẫn DB
                    pictureBoxAnhMonAn.Image = loadedImage;
                    // Sử dụng format "Images/ten_tep" để khớp với logic cũ của bạn
                    duongDanAnhDeLuuDB = $"Images/{tenTep}";

                    MessageBox.Show("Đã chọn ảnh mới thành công.", "Hoàn tất");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Lỗi khi sao chép hoặc tải ảnh: {ex.Message}", "Lỗi");
                }
            }
        }

        private void btnSuaMonAn_Click(object sender, EventArgs e)
        {
            // 1. Kiểm tra Validation
            if (string.IsNullOrWhiteSpace(textBoxTenMA.Text) ||
                !decimal.TryParse(textBoxGiaMonAn.Text, out decimal giaMonAn) || giaMonAn <= 0 ||
                string.IsNullOrWhiteSpace(duongDanAnhDeLuuDB))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin.", "Thiếu thông tin");
                return;
            }

            // 2. THỰC HIỆN UPDATE VÀO DATABASE
            string query = @"UPDATE ThucDon 
                             SET TenMon = @TenMon, 
                                 Gia = @Gia, 
                                 DanhMuc = @DanhMuc, 
                                 HinhAnhPath = @HinhAnhPath 
                             WHERE MonAnID = @MonAnID";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);

                // Thêm các tham số
                command.Parameters.AddWithValue("@MonAnID", MonAnHienTai.MonAnID); // Dùng ID để UPDATE
                command.Parameters.AddWithValue("@TenMon", textBoxTenMA.Text);
                command.Parameters.AddWithValue("@Gia", giaMonAn);
                command.Parameters.AddWithValue("@DanhMuc", comboBoxPhanLoai.Text);
                command.Parameters.AddWithValue("@HinhAnhPath", duongDanAnhDeLuuDB);

                try
                {
                    connection.Open();
                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Cập nhật món ăn thành công!", "Hoàn tất");
                        this.DialogResult = DialogResult.OK;
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Không có món ăn nào được cập nhật.", "Lỗi");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Lỗi Database: {ex.Message}", "Lỗi CSDL");
                }
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
