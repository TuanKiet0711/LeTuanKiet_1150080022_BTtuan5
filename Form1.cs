using System;
using System.Windows.Forms;

namespace LeTuanKiet_1150080022_BTtuan5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // Gắn sự kiện cho các nút còn lại (nếu chưa gắn trong Designer)
            btnTru.Click += btnTru_Click;
            btnNhan.Click += btnNhan_Click;
            btnChia.Click += btnChia_Click;
            btnXoa.Click += btnXoa_Click;
            btnThoat.Click += btnThoat_Click;
        }

        private void button1_Click(object sender, EventArgs e) // bạn đã gắn btnCong.Click += button1_Click trong Designer
        {
            try
            {
                double a = Convert.ToDouble(txtA.Text.Trim());
                double b = Convert.ToDouble(txtB.Text.Trim());
                txtKetQua.Text = (a + b).ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnTru_Click(object sender, EventArgs e)
        {
            try
            {
                double a = Convert.ToDouble(txtA.Text.Trim());
                double b = Convert.ToDouble(txtB.Text.Trim());
                txtKetQua.Text = (a - b).ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnNhan_Click(object sender, EventArgs e)
        {
            try
            {
                double a = Convert.ToDouble(txtA.Text.Trim());
                double b = Convert.ToDouble(txtB.Text.Trim());
                txtKetQua.Text = (a * b).ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnChia_Click(object sender, EventArgs e)
        {
            try
            {
                double a = Convert.ToDouble(txtA.Text.Trim());
                double b = Convert.ToDouble(txtB.Text.Trim());
                if (b == 0)
                {
                    MessageBox.Show("Mẫu số không được phép bằng 0. Nhập lại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtB.Text = "";
                    txtB.Focus();
                    return;
                }
                txtKetQua.Text = (a / b).ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            txtA.Clear();
            txtB.Clear();
            txtKetQua.Clear();
            txtA.Focus();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có thực sự thoát không?",
                                                  "Thoát chương trình",
                                                  MessageBoxButtons.YesNo,
                                                  MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        // Nếu Designer có label1_Click thì thêm tạm hàm trống để không báo lỗi:
        private void label1_Click(object sender, EventArgs e)
        {
            // không làm gì
        }
    }
}
