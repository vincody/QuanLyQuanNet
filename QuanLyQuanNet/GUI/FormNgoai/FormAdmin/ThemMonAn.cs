using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO; // Thêm thư viện này cho các thao tác về File/Path
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyQuanNet.GUI.FormNgoai.FormAdmin
{
    public partial class ThemMonAn : Form
    {
        private const string connectionString = "Server=VINH; Database=QuanLyQuanNetDB; Integrated Security=True;";

        private string duongDanAnhDeLuuDB = "";
        private readonly string ThuMucImages; // Thư mục Images gốc của Project
        private readonly string ThuMucOutputImages; // Thư mục Images trong bin\Debug

        public ThemMonAn()
        {
            InitializeComponent();
            this.ControlBox = false;

            // --- LOGIC XÁC ĐỊNH THƯ MỤC IMAGES LINH HOẠT ---
            string duongDanHienTai = Application.StartupPath;

            // Lùi về 4 cấp để đến thư mục gốc của Project
            DirectoryInfo thuMucGoc =
                Directory.GetParent(duongDanHienTai)
                            .Parent
                            .Parent
                            .Parent;

            // 1. Thư mục Images GỐC (nơi VS quản lý)
            ThuMucImages = Path.Combine(thuMucGoc.FullName, "Images");

            // 2. Thư mục Images OUTPUT (nơi ứng dụng đọc)
            ThuMucOutputImages = Path.Combine(Application.StartupPath, "Images");

            // Đảm bảo cả hai thư mục tồn tại
            if (!Directory.Exists(ThuMucImages))
            {
                Directory.CreateDirectory(ThuMucImages);
            }
            if (!Directory.Exists(ThuMucOutputImages))
            {
                Directory.CreateDirectory(ThuMucOutputImages);
            }

            // Khởi tạo thêm các control khác
            comboBoxPhanLoai.Items.Add("Đồ ăn");
            comboBoxPhanLoai.Items.Add("Đồ uống");
        }
        // drag form
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        //
        private void btnThemAnhMA_Click(object sender, EventArgs e)
        {
            // Lấy đường dẫn đến thư mục Downloads của người dùng hiện tại
            string downloadPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile), "Downloads");

            OpenFileDialog openFileDialog = new OpenFileDialog();

            if (Directory.Exists(downloadPath))
            {
                openFileDialog.InitialDirectory = downloadPath;
            }
            else
            {
                openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);
            }

            openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string duongDanGoc = openFileDialog.FileName;
                string tenTep = Path.GetFileName(duongDanGoc);

                // Đường dẫn đích 1: Thư mục gốc Project
                string duongDanDichProject = Path.Combine(ThuMucImages, tenTep);

                // Đường dẫn đích 2: Thư mục Output (bin\Debug)
                string duongDanDichOutput = Path.Combine(ThuMucOutputImages, tenTep);

                try
                {
                    // --- BƯỚC 1: Tải Ảnh vào Bộ Nhớ An Toàn ---
                    Image loadedImage;
                    using (var stream = new MemoryStream(File.ReadAllBytes(duongDanGoc)))
                    {
                        Image img = Image.FromStream(stream);
                        loadedImage = new Bitmap(img);
                        img.Dispose();
                    }

                    // --- BƯỚC 2: Giải Phóng và Sao Chép KÉP ---
                    if (pictureBoxAnhMonAn.Image != null)
                    {
                        pictureBoxAnhMonAn.Image.Dispose();
                        pictureBoxAnhMonAn.Image = null;
                    }

                    // 2a. Sao chép vào thư mục Project GỐC (Duy trì source file)
                    File.Copy(duongDanGoc, duongDanDichProject, true);

                    // 2b. SAO CHÉP VÀO THƯ MỤC OUTPUT (NƠI ỨNG DỤNG ĐỌC)
                    File.Copy(duongDanGoc, duongDanDichOutput, true);


                    // --- BƯỚC 3: Hiển thị Ảnh ---
                    pictureBoxAnhMonAn.Image = loadedImage;


                    // --- BƯỚC 4: Cập nhật Đường dẫn DB ---
                    // Lưu đường dẫn tương đối từ thư mục Output/Images (nơi DataGridView đọc)
                    duongDanAnhDeLuuDB = $"Images/{tenTep}";

                    MessageBox.Show($"Đã sao chép và hiển thị ảnh thành công. Đường dẫn lưu DB: {duongDanAnhDeLuuDB}",
                                    "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Lỗi khi sao chép hoặc tải ảnh: {ex.Message}", "Lỗi",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnHoatTatMon_Click(object sender, EventArgs e)
        {
            // 1. KIỂM TRA HỢP LỆ (VALIDATION)
            if (string.IsNullOrWhiteSpace(textBoxTenMA.Text) ||
                comboBoxPhanLoai.SelectedItem == null ||
                !decimal.TryParse(textBoxGiaMonAn.Text, out decimal giaMonAn) || giaMonAn <= 0 ||
                string.IsNullOrWhiteSpace(duongDanAnhDeLuuDB))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ và chính xác tất cả thông tin (Tên, Phân loại, Giá, Ảnh).",
                                "Thiếu/Sai thông tin", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 2. THỰC HIỆN INSERT VÀO DATABASE
            string tenMon = textBoxTenMA.Text;
            string danhMuc = comboBoxPhanLoai.Text;
            string hinhAnhPath = duongDanAnhDeLuuDB;

            // Đã sửa tên bảng thành ThucDon
            string query = @"INSERT INTO ThucDon (TenMon, Gia, DanhMuc, HinhAnhPath) 
                             VALUES (@TenMon, @Gia, @DanhMuc, @HinhAnhPath)";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);

                // Thêm các tham số (Parameters)
                command.Parameters.AddWithValue("@TenMon", tenMon);
                command.Parameters.AddWithValue("@Gia", giaMonAn);
                command.Parameters.AddWithValue("@DanhMuc", danhMuc);
                command.Parameters.AddWithValue("@HinhAnhPath", hinhAnhPath);

                try
                {
                    connection.Open();
                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show($"Đã thêm món ăn '{tenMon}' thành công!",
                                        "Hoàn tất", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.DialogResult = DialogResult.OK;
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Không có món ăn nào được thêm vào CSDL.", "Lỗi",
                                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (SqlException ex)
                {
                    MessageBox.Show($"Lỗi Database (SQL Server): {ex.Message}", "Lỗi CSDL",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Lỗi không xác định: {ex.Message}", "Lỗi",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}