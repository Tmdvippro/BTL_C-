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
            }
            catch { MessageBox.Show("Không thể tải dữ liệu kho!"); }
        }

        private async void btnLuu_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMaPhieu.Text) || string.IsNullOrEmpty(txtTenSP.Text) || string.IsNullOrEmpty(txtSL.Text) || string.IsNullOrEmpty(txtDonVi.Text) || string.IsNullOrEmpty(txtDonGia.Text) || string.IsNullOrEmpty(cboNV.Text) || string.IsNullOrEmpty(cboPhanLoai.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ Mã hàng và Số lượng!");
                return;
            }

            var item = new KhoDTO
            {
                maPhieu = txtMaPhieu.Text,
                tenSP = txtTenSP.Text,
                soLuong = int.Parse(txtSL.Text),
                donVi = txtDonVi.Text,
                donGia = txtDonGia.Text,
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
            txtMaPhieu.Clear();
            txtTenSP.Clear();
            txtSL.Clear();
            txtDonVi.Clear();
            txtDonGia.Clear();
            cboPhanLoai.SelectedIndex = -1;
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
            // 1. Kiểm tra ID an toàn (tránh lỗi Column not found)
            if (dgvKho.CurrentRow == null || dgvKho.CurrentRow.Cells["colID"].Value == null)
            {
                MessageBox.Show("Không tìm thấy mã dòng để sửa!");
                return;
            }
            string id = dgvKho.CurrentRow.Cells["colID"].Value.ToString();

            // 2. Chuyển đổi số lượng an toàn (Tránh lỗi FormatException)
            if (!int.TryParse(txtSL.Text, out int sl))
            {
                return;
            }

            // 3. Khởi tạo đối tượng (Sửa các dòng bị highlight)
            var updatedItem = new KhoDTO
            {
                maPhieu = txtMaPhieu.Text,
                tenSP = txtTenSP.Text,
                soLuong = sl,
                donVi = txtDonVi.Text,
                donGia = txtDonGia.Text,
                phanLoai = cboPhanLoai.Text,
                nhanVien = cboNV.Text
            };

            try
            {
                // 4. Chuyển sang JSON bằng Newtonsoft.Json
                var json = JsonConvert.SerializeObject(updatedItem);
                var content = new StringContent(json, Encoding.UTF8, "application/json");

                // 5. Gửi yêu cầu PUT lên API: URL/id
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
                txtMaPhieu.Text = row.Cells["colMaPhieu"].Value?.ToString();
                txtTenSP.Text = row.Cells["colTenSP"].Value?.ToString();
                txtSL.Text = row.Cells["colSL"].Value?.ToString();
                txtDonVi.Text = row.Cells["colDonVi"].Value?.ToString();
                txtDonGia.Text = row.Cells["colDonGia"].Value?.ToString();
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
            public string donGia { get; set; }
            public string phanLoai { get; set; }
            public string nhanVien { get; set; }
        }
    }
}
