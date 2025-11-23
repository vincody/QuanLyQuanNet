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
using System.IO;
using QuanLyQuanNet.GUI.Menu;
using QuanLyQuanNet.GUI.ViewDoAn;

namespace QuanLyQuanNet.GUI.FormNgoai.FormKhach
{
    public partial class GoiMon : Form
    {
        private const string connectionString = "Server=VINH; Database=QuanLyQuanNetDB; Integrated Security=True;";

        private int TaiKhoanID;
        private string TenMayHienTai;

        private Dictionary<string, ThongTinDatMon> currentOrderItems = new Dictionary<string, ThongTinDatMon>();
        private string currentCategory = "Tất cả";

        public GoiMon()
        {
            InitializeComponent();

            if (UserSession.TaiKhoanID == 0)
            {
                MessageBox.Show("Lỗi hệ thống: Không tìm thấy ID tài khoản đang đăng nhập.", "Lỗi Session", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return;
            }
            this.TaiKhoanID = UserSession.TaiKhoanID;
            this.TenMayHienTai = UserSession.TenMay;

            LoadMenu();
            SetupCategoryFilters();

            this.textBoxTimMonAn.TextChanged += new EventHandler(this.textBoxTimMonAn_TextChanged);
            this.checkBoxTienMat.CheckedChanged += new EventHandler(this.checkBoxTienMat_CheckedChanged);
            this.checkBoxSoDu.CheckedChanged += new EventHandler(this.checkBoxSoDu_CheckedChanged);
            this.btnDatMon.Click += new EventHandler(this.btnDatMon_Click);
        }

        private void LoadMenu(string filterCategory = "Tất cả", string searchKeyword = "")
        {
            MenuDoAn.Controls.Clear();
            string query = "SELECT MonAnID, TenMon, Gia, HinhAnhPath, DanhMuc FROM ThucDon";

            List<string> whereClauses = new List<string>();
            if (filterCategory != "Tất cả") whereClauses.Add("DanhMuc = @Category");
            if (!string.IsNullOrEmpty(searchKeyword)) whereClauses.Add("TenMon LIKE @SearchKeyword");

            if (whereClauses.Count > 0) query += " WHERE " + string.Join(" AND ", whereClauses);

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    if (filterCategory != "Tất cả") command.Parameters.AddWithValue("@Category", filterCategory);
                    if (!string.IsNullOrEmpty(searchKeyword)) command.Parameters.AddWithValue("@SearchKeyword", "%" + searchKeyword + "%");

                    try
                    {
                        connection.Open();
                        SqlDataReader reader = command.ExecuteReader();

                        while (reader.Read())
                        {
                            int monAnID = reader.GetInt32(reader.GetOrdinal("MonAnID"));
                            string tenMon = reader["TenMon"].ToString();
                            decimal gia = reader.GetDecimal(reader.GetOrdinal("Gia"));
                            string hinhAnhPath = reader["HinhAnhPath"].ToString();

                            DoAn monAnControl = new DoAn();
                            monAnControl.labelTenDoAn.Text = tenMon;
                            monAnControl.labelGiaDoAn.Text = gia.ToString("N0") + " VNĐ";

                            try
                            {
                                string fullPath = Path.Combine(Application.StartupPath, hinhAnhPath);
                                if (File.Exists(fullPath))
                                {
                                    using (var stream = new FileStream(fullPath, FileMode.Open, FileAccess.Read))
                                    {
                                        monAnControl.pictureBoxHinhAnh.Image = Image.FromStream(stream);
                                    }
                                    monAnControl.pictureBoxHinhAnh.SizeMode = PictureBoxSizeMode.Zoom;
                                }
                            }
                            catch (Exception imgEx)
                            { Console.WriteLine("Lỗi tải ảnh: " + imgEx.Message); }

                            MenuDoAn.Controls.Add(monAnControl);
                            monAnControl.ThemMonClicked += MonAn_Click;

                            monAnControl.Tag = new { MonAnID = monAnID, TenMon = tenMon, Gia = gia };
                        }
                    }
                    catch (Exception ex)
                    { MessageBox.Show("Lỗi tải thực đơn: " + ex.Message, "Lỗi CSDL", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                }
            }
        }

        private void SetupCategoryFilters()
        {
            string[] categories = { "Tất cả", "Đồ ăn", "Đồ uống", "Tráng miệng" };

            foreach (string category in categories)
            {
                Button btn = new Button();
                btn.Text = category;
                btn.Tag = category;
                btn.AutoSize = true;
                btn.Padding = new Padding(10, 5, 10, 5);
                btn.FlatStyle = FlatStyle.Flat;
                btn.FlatAppearance.BorderSize = 0;
                btn.Click += CategoryButton_Click;
                CagetoryMonAn.Controls.Add(btn);
            }
        }

        private void CategoryButton_Click(object sender, EventArgs e)
        {
            Button clickedButton = sender as Button;
            if (clickedButton != null)
            {
                string selectedCategory = clickedButton.Tag.ToString();
                LoadMenu(selectedCategory, textBoxTimMonAn.Text.Trim());
            }
        }

        private void textBoxTimMonAn_TextChanged(object sender, EventArgs e)
        {
            string keyword = textBoxTimMonAn.Text.Trim();
            LoadMenu(currentCategory, keyword);
        }

        private void MonAn_Click(object sender, EventArgs e)
        {
            Control clickedControl = sender as Control;
            if (clickedControl == null) return;

            DoAn menuControl = clickedControl as DoAn;

            if (menuControl == null)
            {
                Control parentControl = clickedControl.Parent;
                while (parentControl != null)
                {
                    menuControl = parentControl as DoAn;
                    if (menuControl != null) break;
                    parentControl = parentControl.Parent;
                }
            }

            if (menuControl?.Tag == null) return;

            dynamic itemInfo = menuControl.Tag;
            int monAnID = itemInfo.MonAnID;
            string tenMon = itemInfo.TenMon;
            decimal giaDonVi = itemInfo.Gia;

            AddOrUpdateOrderItem(monAnID, tenMon, giaDonVi);
        }

        private void AddOrUpdateOrderItem(int monAnID, string tenMon, decimal giaDonVi)
        {
            if (currentOrderItems.ContainsKey(tenMon))
            {
                currentOrderItems[tenMon].btnThem.PerformClick();
            }
            else
            {
                ThongTinDatMon orderItemControl = new ThongTinDatMon();

                orderItemControl.InitializeItem(monAnID, tenMon, giaDonVi);

                orderItemControl.QuantityChanged += OrderItemControl_QuantityChanged;
                orderItemControl.ItemRemoved += OrderItemControl_ItemRemoved;

                currentOrderItems.Add(tenMon, orderItemControl);
                ListMonAnDat.Controls.Add(orderItemControl);
            }
            UpdateTotalOrder();
        }

        private void OrderItemControl_ItemRemoved(object sender, EventArgs e)
        {
            ThongTinDatMon removedControl = sender as ThongTinDatMon;
            if (removedControl != null)
            {
                currentOrderItems.Remove(removedControl.TenMon);
                UpdateTotalOrder();
            }
        }

        private void OrderItemControl_QuantityChanged(object sender, ThongTinDatMon.OrderUpdateEventArgs e)
        {
            UpdateTotalOrder();
        }

        private void UpdateTotalOrder()
        {
            decimal tongTien = 0;
            foreach (var itemControl in currentOrderItems.Values)
            {
                int soLuong = int.Parse(itemControl.SoLuong.Text);
                decimal giaDonVi = itemControl.GiaDonVi;
                tongTien += (giaDonVi * soLuong);
            }
            labelTongTien.Text = tongTien.ToString("N0") + " VNĐ";
        }

        private void checkBoxTienMat_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxTienMat.Checked) { checkBoxSoDu.Enabled = false; }
            else { checkBoxSoDu.Enabled = true; }
        }

        private void checkBoxSoDu_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxSoDu.Checked) { checkBoxTienMat.Enabled = false; }
            else { checkBoxTienMat.Enabled = true; }
        }

        private decimal GetCurrentBalance(int taiKhoanId)
        {
            decimal soDu = 0;
            string query = "SELECT SoDu FROM TaiKhoan WHERE TaiKhoanID = @TaiKhoanID";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@TaiKhoanID", taiKhoanId);
                try
                {
                    connection.Open();
                    object result = command.ExecuteScalar();
                    if (result != null && result != DBNull.Value) soDu = Convert.ToDecimal(result);
                }
                catch (Exception ex)
                { MessageBox.Show("Lỗi lấy Số dư từ CSDL: " + ex.Message, "Lỗi DB", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            }
            return soDu;
        }

        private decimal GetHourlyRate(string tenMay)
        {
            decimal giaTheoGio = 0;
            string query = "SELECT GiaTheoGio FROM Computers WHERE TenMay = @TenMay";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@TenMay", tenMay);
                try
                {
                    connection.Open();
                    object result = command.ExecuteScalar();
                    if (result != null && result != DBNull.Value) giaTheoGio = Convert.ToDecimal(result);
                }
                catch (Exception ex)
                { MessageBox.Show("Lỗi lấy Giá theo giờ từ CSDL: " + ex.Message, "Lỗi DB", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            }
            return giaTheoGio;
        }

        private bool PlaceOrderTransaction(decimal tongTien, string phuongThucTT, decimal soDuHienTai)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlTransaction transaction = connection.BeginTransaction();

                try
                {
                    string insertDonDat = @"
                    INSERT INTO DonDatMon (TenMay, TaiKhoanID, PhuongThucTT, TongTien, TrangThai) 
                    OUTPUT INSERTED.DonDatID 
                    VALUES (@TenMay, @TaiKhoanID, @PhuongThucTT, @TongTien, N'Đang chờ')";

                    SqlCommand cmdDonDat = new SqlCommand(insertDonDat, connection, transaction);
                    cmdDonDat.Parameters.AddWithValue("@TenMay", TenMayHienTai);
                    cmdDonDat.Parameters.AddWithValue("@TaiKhoanID", TaiKhoanID);
                    cmdDonDat.Parameters.AddWithValue("@PhuongThucTT", phuongThucTT);
                    cmdDonDat.Parameters.AddWithValue("@TongTien", tongTien);

                    int donDatID = (int)cmdDonDat.ExecuteScalar();

                    string insertChiTiet = @"
                    INSERT INTO ChiTietDatMon (DonDatID, MonAnID, TenMon, SoLuong, GiaDonVi) 
                    VALUES (@DonDatID, @MonAnID, @TenMon, @SoLuong, @GiaDonVi)";

                    foreach (var item in currentOrderItems.Values)
                    {
                        SqlCommand cmdChiTiet = new SqlCommand(insertChiTiet, connection, transaction);
                        cmdChiTiet.Parameters.AddWithValue("@DonDatID", donDatID);
                        cmdChiTiet.Parameters.AddWithValue("@MonAnID", item.MonAnID);
                        cmdChiTiet.Parameters.AddWithValue("@TenMon", item.TenMon);
                        cmdChiTiet.Parameters.AddWithValue("@SoLuong", int.Parse(item.SoLuong.Text));
                        cmdChiTiet.Parameters.AddWithValue("@GiaDonVi", item.GiaDonVi);

                        cmdChiTiet.ExecuteNonQuery();
                    }

                    if (phuongThucTT == "Số dư")
                    {
                        decimal soDuMoi = soDuHienTai - tongTien;
                        string updateSoDu = "UPDATE TaiKhoan SET SoDu = @SoDuMoi WHERE TaiKhoanID = @TaiKhoanID";

                        SqlCommand cmdUpdateSoDu = new SqlCommand(updateSoDu, connection, transaction);
                        cmdUpdateSoDu.Parameters.AddWithValue("@SoDuMoi", soDuMoi);
                        cmdUpdateSoDu.Parameters.AddWithValue("@TaiKhoanID", TaiKhoanID);
                        cmdUpdateSoDu.ExecuteNonQuery();
                    }

                    transaction.Commit();
                    return true;
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    Console.WriteLine("Lỗi giao dịch đặt món: " + ex.Message);
                    return false;
                }
            }
        }

        private void btnDatMon_Click(object sender, EventArgs e)
        {
            if (currentOrderItems.Count == 0 || (!checkBoxTienMat.Checked && !checkBoxSoDu.Checked))
            {
                MessageBox.Show("Vui lòng chọn món và phương thức thanh toán.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            decimal tongTienDatMon;
            if (!decimal.TryParse(labelTongTien.Text.Replace(" VNĐ", "").Replace(".", "").Replace(",", ""), out tongTienDatMon))
            {
                MessageBox.Show("Không thể xác định Tổng tiền. Vui lòng thử lại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string phuongThucTT = checkBoxTienMat.Checked ? "Tiền mặt" : "Số dư";

            decimal giaTheoGio = GetHourlyRate(TenMayHienTai);
            decimal soDuHienTai = GetCurrentBalance(TaiKhoanID);

            if (phuongThucTT == "Số dư")
            {
                if (soDuHienTai < tongTienDatMon)
                {
                    MessageBox.Show($"Số dư hiện tại ({soDuHienTai:N0} VNĐ) không đủ để thanh toán ({tongTienDatMon:N0} VNĐ).", "Lỗi Số dư", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                decimal soDuConLaiSauTT = soDuHienTai - tongTienDatMon;
                if (soDuConLaiSauTT < giaTheoGio)
                {
                    MessageBox.Show($"Số dư còn lại ({soDuConLaiSauTT:N0} VNĐ) không đủ để duy trì máy (cần tối thiểu {giaTheoGio:N0} VNĐ).", "Lỗi Số dư", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            if (PlaceOrderTransaction(tongTienDatMon, phuongThucTT, soDuHienTai))
            {
                currentOrderItems.Clear();
                ListMonAnDat.Controls.Clear();
                UpdateTotalOrder();
                checkBoxTienMat.Checked = false;
                checkBoxSoDu.Checked = false;

                decimal soDuMoi = (phuongThucTT == "Số dư") ? (soDuHienTai - tongTienDatMon) : soDuHienTai;

                foreach (Form form in Application.OpenForms)
                {
                    if (form is ThongTinKhach thongTinForm)
                    {
                        thongTinForm.RefreshBalanceAfterOrder(soDuMoi);
                        break;
                    }
                }
                MessageBox.Show("Đặt món thành công! Đơn hàng đã được ghi nhận.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Lỗi trong quá trình lưu đơn hàng. Đã hoàn tác giao dịch.", "Lỗi DB", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void MenuDoAn_Paint(object sender, PaintEventArgs e) { }
        private void GoiMon_Load(object sender, EventArgs e) { }
        private void labelTongTien_Click(object sender, EventArgs e) { }
    }
}