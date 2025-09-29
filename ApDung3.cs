using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace LeTuanKiet_1150080022_BTtuan5
{
    public class Form5 : Form
    {
        private Label lblTitle;
        private Label lblNhapSo;
        private TextBox txtNhapSo;
        private Button btnNhapSo;
        private ListBox lstDaySo;

        private Button btnTang2, btnChonSoChanDau, btnChonSoLeCuoi;
        private Button btnXoaDangChon, btnXoaPhanTuDau, btnXoaPhanTuCuoi;
        private Button btnKetThuc, btnXoaDaySo;

        public Form5()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            // ===== Form =====
            Text = "Ứng dụng xử lý dãy số";
            StartPosition = FormStartPosition.CenterScreen;
            ClientSize = new Size(550, 400);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;

            // ===== Title =====
            lblTitle = new Label
            {
                Dock = DockStyle.Top,
                Height = 50,
                Text = "Ứng dụng xử lý dãy số",
                TextAlign = ContentAlignment.MiddleCenter,
                ForeColor = Color.Black,
                BackColor = Color.Teal,
                Font = new Font("Segoe UI", 18, FontStyle.Bold)
            };
            Controls.Add(lblTitle);

            // ===== Nhập số =====
            lblNhapSo = new Label { Text = "Nhập số nguyên:", Location = new Point(10, 65), AutoSize = true };
            txtNhapSo = new TextBox { Location = new Point(130, 62), Width = 120 };
            // chỉ cho nhập số
            txtNhapSo.KeyPress += (s, e) =>
            {
                // chỉ cho số và phím điều khiển
                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                    e.Handled = true;
                // nếu Enter thì thêm số
                if (e.KeyChar == (char)Keys.Enter)
                {
                    e.Handled = true;
                    NhapSo();
                }
            };

            btnNhapSo = new Button { Text = "Nhập số", Location = new Point(270, 60), Size = new Size(80, 27) };
            btnNhapSo.Click += (s, e) => NhapSo();

            Controls.Add(lblNhapSo);
            Controls.Add(txtNhapSo);
            Controls.Add(btnNhapSo);

            // ===== ListBox =====
            lstDaySo = new ListBox { Location = new Point(10, 100), Size = new Size(220, 220) };
            Controls.Add(lstDaySo);

            // ===== Các nút chức năng =====
            int x = 250, y = 100, w = 220, h = 30, pad = 35;

            btnTang2 = new Button { Text = "Tăng mỗi phần tử lên 2", Location = new Point(x, y), Size = new Size(w, h) };
            btnTang2.Click += (s, e) =>
            {
                for (int i = 0; i < lstDaySo.Items.Count; i++)
                {
                    int val = int.Parse(lstDaySo.Items[i].ToString());
                    lstDaySo.Items[i] = (val + 2).ToString();
                }
            };

            btnChonSoChanDau = new Button { Text = "Chọn số chẵn đầu", Location = new Point(x, y += pad), Size = new Size(w, h) };
            btnChonSoChanDau.Click += (s, e) =>
            {
                lstDaySo.ClearSelected();
                for (int i = 0; i < lstDaySo.Items.Count; i++)
                {
                    if (int.Parse(lstDaySo.Items[i].ToString()) % 2 == 0)
                    {
                        lstDaySo.SelectedIndex = i;
                        break;
                    }
                }
            };

            btnChonSoLeCuoi = new Button { Text = "Chọn số lẻ cuối", Location = new Point(x, y += pad), Size = new Size(w, h) };
            btnChonSoLeCuoi.Click += (s, e) =>
            {
                lstDaySo.ClearSelected();
                for (int i = lstDaySo.Items.Count - 1; i >= 0; i--)
                {
                    if (int.Parse(lstDaySo.Items[i].ToString()) % 2 != 0)
                    {
                        lstDaySo.SelectedIndex = i;
                        break;
                    }
                }
            };

            btnXoaDangChon = new Button { Text = "Xóa phần tử đang chọn", Location = new Point(x, y += pad), Size = new Size(w, h) };
            btnXoaDangChon.Click += (s, e) =>
            {
                while (lstDaySo.SelectedItems.Count > 0)
                    lstDaySo.Items.Remove(lstDaySo.SelectedItems[0]);
            };

            btnXoaPhanTuDau = new Button { Text = "Xóa phần tử đầu", Location = new Point(x, y += pad), Size = new Size(w, h) };
            btnXoaPhanTuDau.Click += (s, e) =>
            {
                if (lstDaySo.Items.Count > 0)
                    lstDaySo.Items.RemoveAt(0);
            };

            btnXoaPhanTuCuoi = new Button { Text = "Xóa phần tử cuối", Location = new Point(x, y += pad), Size = new Size(w, h) };
            btnXoaPhanTuCuoi.Click += (s, e) =>
            {
                if (lstDaySo.Items.Count > 0)
                    lstDaySo.Items.RemoveAt(lstDaySo.Items.Count - 1);
            };

            // Nút dưới cùng
            btnKetThuc = new Button
            {
                Text = "Kết thúc ứng dụng",
                Location = new Point(10, 330),
                Size = new Size(220, 35),
                BackColor = Color.Red,
                ForeColor = Color.White
            };
            btnKetThuc.Click += (s, e) => Close();

            btnXoaDaySo = new Button
            {
                Text = "Xóa dãy số",
                Location = new Point(250, 330),
                Size = new Size(220, 35),
                BackColor = Color.DimGray,
                ForeColor = Color.White
            };
            btnXoaDaySo.Click += (s, e) => lstDaySo.Items.Clear();

            Controls.AddRange(new Control[]
            {
                btnTang2, btnChonSoChanDau, btnChonSoLeCuoi,
                btnXoaDangChon, btnXoaPhanTuDau, btnXoaPhanTuCuoi,
                btnKetThuc, btnXoaDaySo
            });

            AcceptButton = btnNhapSo;
            CancelButton = btnKetThuc;
        }

        // Thêm số mới vào ListBox
        private void NhapSo()
        {
            if (string.IsNullOrWhiteSpace(txtNhapSo.Text))
            {
                MessageBox.Show("Vui lòng nhập số nguyên!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNhapSo.Focus();
                return;
            }
            lstDaySo.Items.Add(txtNhapSo.Text.Trim());
            txtNhapSo.Clear();
            txtNhapSo.Focus();
        }
    }
}
