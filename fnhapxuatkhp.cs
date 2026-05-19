using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyNhapXuat
{
    public partial class fNhapXuatKho : Form
    {
        private string apiURL = "https://6a0025352b7ab34960301a22.mockapi.io/nhapxuat";
        private HttpClient client = new HttpClient();

        int index = -1;
        public fNhapXuatKho()
        {
            InitializeComponent();
            this.Load += FNhapXuatKho_Load;
        }

        private async void FNhapXuatKho_Load(object sender, EventArgs e)
        {
            await LoadData();
        }

        // --- HÀM TỰ ĐỘNG SINH MÃ PHIẾU TỪ DANH SÁCH MOCK API ---
        private string MaPhieu()
        {
            string maMoi = "PN001"; // Mặc định nếu API trống
            try
            {
                var list = dgvKho.DataSource as List<KhoDTO>;
                if (list != null && list.Count > 0)
                {
                    var maxNumber = list
                        .Where(p => p.maPhieu != null && p.maPhieu.StartsWith("PN"))
                        .Select(p => int.TryParse(p.maPhieu.Substring(2), out int num) ? num : 0)
                        .DefaultIfEmpty(0)
                        .Max();

                    maMoi = "PN" + (maxNumber + 1).ToString("D3");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tính toán sinh mã: " + ex.Message);
            }
            return maMoi;
        }
        private async Task LoadData()
        {
            try
            {
                string res = await client.GetStringAsync(apiURL);
                var ds = JsonConvert.DeserializeObject<List<KhoDTO>>(res);

                // Tắt tự động thêm cột
                dgvKho.AutoGenerateColumns = false;
                dgvKho.DataSource = null;

                if (ds != null)
                {
                    dgvKho.DataSource = ds;

                    // Ẩn cột ID nếu nó tồn tại
                    if (dgvKho.Columns.Contains("colID")) dgvKho.Columns["colID"].Visible = false;
                }

                if (dgvKho.Columns.Contains("colDonGia"))
                {
                    // Định dạng hiển thị số phân cách hàng nghìn, không lấy số thập phân
                    dgvKho.Columns["colDonGia"].DefaultCellStyle.Format = "N0";
                }

                // ĐỊNH DẠNG THÀNH TIỀN TRÊN DATAGRIDVIEW
                if (dgvKho.Columns.Contains("colThanhTien"))
                {
                    dgvKho.Columns["colThanhTien"].DefaultCellStyle.Format = "N0";
                }

                lbMaPhieu.Text = MaPhieu();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không thể tải dữ liệu kho! Lỗi chi tiết: " + ex.Message);
            }
        }

        private async void btnLuu_Click(object sender, EventArgs e)
        {
            string gia = txtDonGia.Text.Replace(".", "").Replace(",", "");
            var item = new KhoDTO
            {
                maPhieu = lbMaPhieu.Text,
                tenSP = cbTenSP.Text,
                soLuong = int.Parse(txtSL.Text),
                donVi = cbDonVi.Text,
                donGia = long.TryParse(gia, out long dg) ? dg : 0,
                phanLoai = cboPhanLoai.Text,
                nhanVien = cboNV.Text,
            };

            var json = JsonConvert.SerializeObject(item);
            var content = new StringContent(json, Encoding.UTF8, "application/json");
            var response = await client.PostAsync(apiURL, content);

            if (response.IsSuccessStatusCode)
            {
                await LoadData();
                ClearInput();
                MessageBox.Show("Đã lưu giao dịch kho!");
            }
        }

        private void ClearInput()
        {

            cbTenSP.SelectedIndex = -1; 
            txtSL.Clear();
            cbDonVi.SelectedIndex = -1;
            txtDonGia.Clear();
            cboPhanLoai.SelectedIndex = -1;
            lbMaPhieu.Text = MaPhieu();
        }

        private async void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgvKho.CurrentRow != null)
            {
                var idValue = dgvKho.CurrentRow.Cells["colId"].Value;
                if (idValue != null)
                {
                    string id = idValue.ToString();

                    var confirm = MessageBox.Show("Bạn có chắc muốn xóa không?", "Xác nhận", MessageBoxButtons.YesNo);
                    if (confirm == DialogResult.Yes)
                    {
                        await client.DeleteAsync(apiURL + "/" + id);
                        await LoadData();
                        MessageBox.Show("Đã xóa thành công!");
                    }
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một dòng để xóa!");
            }
        }



        private async void btnSua_Click(object sender, EventArgs e)
        {
            if (dgvKho.CurrentRow == null || dgvKho.CurrentRow.Cells["colID"].Value == null)
            {
                MessageBox.Show("Không tìm thấy mã dòng để sửa!");
                return;
            }
            string id = dgvKho.CurrentRow.Cells["colID"].Value.ToString();

            if (!int.TryParse(txtSL.Text, out int sl))
            {
                return;
            }

            string gia = txtDonGia.Text.Replace(".", "").Replace(",", "");

            var updatedItem = new KhoDTO
            {
                maPhieu = lbMaPhieu.Text,
                tenSP = cbTenSP.Text,
                soLuong = sl,
                donVi = cbDonVi.Text,
                donGia = long.TryParse(gia, out long dg) ? dg : 0,
                phanLoai = cboPhanLoai.Text,
                nhanVien = cboNV.Text
            };

            try
            {
                // Chuyển sang JSON bằng Newtonsoft.Json
                var json = JsonConvert.SerializeObject(updatedItem);
                var content = new StringContent(json, Encoding.UTF8, "application/json");

                // Gửi yêu cầu PUT lên API: URL/id
                var response = await client.PutAsync(apiURL + "/" + id, content);

                if (response.IsSuccessStatusCode)
                {
                    MessageBox.Show("Cập nhật dữ liệu lên Server thành công!");
                    await LoadData(); // Tải lại bảng để cập nhật số liệu mới nhất
                    ClearInput();
                }
                else
                {
                    MessageBox.Show("Lỗi khi cập nhật API: " + response.StatusCode);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi: " + ex.Message);
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            index = e.RowIndex;
            if (index >= 0)
            {
                DataGridViewRow row = dgvKho.Rows[index];
                // Gán ngược dữ liệu từ bảng lên các ô nhập liệu
                lbMaPhieu.Text = row.Cells["colMaPhieu"].Value?.ToString();
                cbTenSP.Text = row.Cells["colTenSP"].Value?.ToString();
                txtSL.Text = row.Cells["colSL"].Value?.ToString();
                cbDonVi.Text = row.Cells["colDonVi"].Value?.ToString();
                // SỬA: Khi lấy dữ liệu đơn giá từ lưới đắp ngược lại TextBox, ép định dạng N0 luôn để hiển thị đồng bộ dấu chấm
                if (row.Cells["colDonGia"].Value != null)
                {
                    if (double.TryParse(row.Cells["colDonGia"].Value.ToString(), out double dgValue))
                    {
                        txtDonGia.Text = string.Format("{0:N0}", dgValue);
                    }
                    else
                    {
                        txtDonGia.Text = row.Cells["colDonGia"].Value.ToString();
                    }
                }
                cboPhanLoai.Text = row.Cells["colPhanLoai"].Value?.ToString();
            }
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }


        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void fNhapXuatKho_Load(object sender, EventArgs e)
        {

        }

        private void lbMaPhieu_Click(object sender, EventArgs e)
        {

        }

        private void lbTenSP_Click(object sender, EventArgs e)
        {

        }

        public class KhoDTO
        {
            public string id { get; set; }
            public string maPhieu { get; set; }
            public string tenSP { get; set; }
            public int soLuong { get; set; }
            public string donVi { get; set; }
            public long donGia { get; set; }
            public long thanhTien
            {
                get { return soLuong * donGia; }
            }
            public string phanLoai { get; set; }
            public string nhanVien { get; set; }
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void txtDonGia_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtDonGia.Text)) return;

            try
            {
                // Tạm thời gỡ bỏ sự kiện TextChanged để tránh lặp vô hạn khi format lại chuỗi
                txtDonGia.TextChanged -= txtDonGia_TextChanged;

                // Xóa tất cả các dấu phân cách cũ (. hoặc ,) để lấy số thuần túy
                string value = txtDonGia.Text.Replace(",", "").Replace(".", "");

                if (double.TryParse(value, out double number))
                {
                    // Định dạng lại số theo chuẩn phân cách hàng nghìn (N0)
                    txtDonGia.Text = string.Format("{0:N0}", number);

                    // Đưa con trỏ chuột về cuối dòng sau khi định dạng lại chuỗi
                    txtDonGia.SelectionStart = txtDonGia.Text.Length;
                }

                // Đăng ký lại sự kiện TextChanged
                txtDonGia.TextChanged += txtDonGia_TextChanged;
            }
            catch (Exception ex)
            {
                // Đảm bảo luôn đăng ký lại sự kiện kể cả khi lỗi
                txtDonGia.TextChanged += txtDonGia_TextChanged;
            }
        }
    }
}
