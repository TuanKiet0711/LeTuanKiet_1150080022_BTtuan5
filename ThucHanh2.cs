using System;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;

namespace LeTuanKiet_1150080022_BTtuan5
{
    public class Form4 : Form
    {
        // ==== Constants (đơn giá) ====
        const int GIA_LAY_CAO_RANG = 50_000;     // 2 hàm
        const int GIA_TAY_TRANG   = 100_000;     // 2 hàm
        const int GIA_HAN_RANG    = 100_000;     // /1 răng
        const int GIA_BE_RANG     = 10_000;      // /1 răng
        const int GIA_BOC_RANG    = 1_000_000;   // /1 răng

        // ==== Controls ====
        private Label lblTitle;
        private Label lblTenKh;
        private TextBox txtTenKh;
        private ErrorProvider err;

        private GroupBox grpDichVu;
        private CheckBox chkLayCaoRang, chkTayTrang, chkHanRang, chkBeRang, chkBocRang;
        private Label lblGiaLCR, lblGiaTTR, lblGiaHR, lblGiaBR, lblGiaBoc;
        private NumericUpDown nupHanRang, nupBeRang, nupBocRang;

        private GroupBox grpChucNang;
        private Button btnTinhTien, btnThoat;
        private TextBox txtThanhTien;

        public Form4()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            // ===== Form =====
            Text = "Phòng khám nha khoa";
            StartPosition = FormStartPosition.CenterScreen;
            ClientSize = new Size(560, 460);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;

            // ===== Title =====
            lblTitle = new Label
            {
                Dock = DockStyle.Top,
                Height = 60,
                Text = "PHÒNG KHÁM NHA KHOA HẢI ÂU",
                TextAlign = ContentAlignment.MiddleCenter,
                ForeColor = Color.White,
                BackColor = Color.FromArgb(0, 180, 0),
                Font = new Font("Segoe UI", 20, FontStyle.Bold)
            };
            Controls.Add(lblTitle);

            // ===== Tên khách hàng =====
            lblTenKh = new Label { Text = "Tên khách hàng:", Location = new Point(12, 75), AutoSize = true };
            txtTenKh = new TextBox { Location = new Point(130, 72), Width = 360 };
            txtTenKh.Validating += txtTenKh_Validating;

            err = new ErrorProvider();
            err.BlinkStyle = ErrorBlinkStyle.NeverBlink;
            err.ContainerControl = this;

            Controls.Add(lblTenKh);
            Controls.Add(txtTenKh);

            // ===== Group Dịch vụ =====
            grpDichVu = new GroupBox
            {
                Text = "Dịch vụ tại phòng khám:",
                Location = new Point(12, 112),
                Size = new Size(530, 200)
            };
            Controls.Add(grpDichVu);

            // Checkboxes
            chkLayCaoRang = new CheckBox { Text = "Lấy cao răng", Location = new Point(16, 30), AutoSize = true, Checked = true };
            chkTayTrang   = new CheckBox { Text = "Tẩy trắng răng", Location = new Point(16, 60), AutoSize = true, Checked = true };
            chkHanRang    = new CheckBox { Text = "Hàn răng", Location = new Point(16, 90), AutoSize = true };
            chkBeRang     = new CheckBox { Text = "Bẻ răng", Location = new Point(16, 120), AutoSize = true };
            chkBocRang    = new CheckBox { Text = "Bọc răng", Location = new Point(16, 150), AutoSize = true };

            // Labels giá
            lblGiaLCR = new Label { Text = "50.000đ/2 hàm", Location = new Point(180, 30), AutoSize = true };
            lblGiaTTR = new Label { Text = "100.000đ/2 hàm", Location = new Point(180, 60), AutoSize = true };
            lblGiaHR  = new Label { Text = "100.000đ/1 răng", Location = new Point(180, 90), AutoSize = true };
            lblGiaBR  = new Label { Text = "10.000đ/1 răng", Location = new Point(180, 120), AutoSize = true };
            lblGiaBoc = new Label { Text = "1.000.000đ/1 răng", Location = new Point(180, 150), AutoSize = true };

            // NumericUpDown (số răng)
            nupHanRang = MakeNup(new Point(420, 88));
            nupBeRang  = MakeNup(new Point(420, 118));
            nupBocRang = MakeNup(new Point(420, 148));

            // Mặc định disable nếu chưa tick
            ToggleNupWithCheckbox(chkHanRang, nupHanRang);
            ToggleNupWithCheckbox(chkBeRang,  nupBeRang);
            ToggleNupWithCheckbox(chkBocRang, nupBocRang);

            // Sự kiện bật/tắt
            chkHanRang.CheckedChanged += (s, e) => ToggleNupWithCheckbox(chkHanRang, nupHanRang);
            chkBeRang.CheckedChanged  += (s, e) => ToggleNupWithCheckbox(chkBeRang,  nupBeRang);
            chkBocRang.CheckedChanged += (s, e) => ToggleNupWithCheckbox(chkBocRang, nupBocRang);

            grpDichVu.Controls.AddRange(new Control[]
            {
                chkLayCaoRang, chkTayTrang, chkHanRang, chkBeRang, chkBocRang,
                lblGiaLCR, lblGiaTTR, lblGiaHR, lblGiaBR, lblGiaBoc,
                nupHanRang, nupBeRang, nupBocRang
            });

            // ===== Group Chức năng =====
            grpChucNang = new GroupBox { Text = "Chức năng:", Location = new Point(12, 318), Size = new Size(530, 120) };
            Controls.Add(grpChucNang);

            btnTinhTien = new Button { Text = "Tính tiền", Location = new Point(30, 70), Size = new Size(110, 32) };
            btnThoat    = new Button { Text = "Thoát", Location = new Point(380, 70), Size = new Size(110, 32) };
            btnTinhTien.Click += btnTinhTien_Click;
            btnThoat.Click += (s, e) => Close();

            txtThanhTien = new TextBox
            {
                Location = new Point(30, 28),
                Size = new Size(460, 30),
                ReadOnly = true,
                Font = new Font("Segoe UI", 12, FontStyle.Bold),
                TextAlign = HorizontalAlignment.Center
            };

            grpChucNang.Controls.AddRange(new Control[] { txtThanhTien, btnTinhTien, btnThoat });

            // Phím tắt
            AcceptButton = btnTinhTien;
            CancelButton = btnThoat;
        }

        private NumericUpDown MakeNup(Point p) =>
            new NumericUpDown { Location = p, Size = new Size(60, 27), Minimum = 1, Maximum = 32, Value = 1 };

        private void ToggleNupWithCheckbox(CheckBox chk, NumericUpDown nup)
        {
            nup.Enabled = chk.Checked;
            if (!chk.Checked) nup.Value = 1;
        }

        private void txtTenKh_Validating(object? sender, System.ComponentModel.CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTenKh.Text))
            {
                e.Cancel = true;
                err.SetError(txtTenKh, "Tên khách hàng không được để trống!");
            }
            else err.SetError(txtTenKh, null);
        }

        private void btnTinhTien_Click(object? sender, EventArgs e)
        {
            if (!ValidateChildren(ValidationConstraints.Enabled))
            {
                txtTenKh.Focus();
                return;
            }

            long thanhTien = 0;
            if (chkLayCaoRang.Checked) thanhTien += GIA_LAY_CAO_RANG;
            if (chkTayTrang.Checked)   thanhTien += GIA_TAY_TRANG;
            if (chkHanRang.Checked)    thanhTien += (long)nupHanRang.Value * GIA_HAN_RANG;
            if (chkBeRang.Checked)     thanhTien += (long)nupBeRang.Value  * GIA_BE_RANG;
            if (chkBocRang.Checked)    thanhTien += (long)nupBocRang.Value * GIA_BOC_RANG;

            txtThanhTien.Text =
                $"{txtTenKh.Text.Trim()} phải thanh toán: {thanhTien.ToString("N0", new CultureInfo("vi-VN"))} đ";
        }
    }
}
